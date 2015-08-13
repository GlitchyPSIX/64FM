Imports System
Imports System.IO

Public Class CinematicControl
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Private WithEvents AboutBox As AboutCinematicControl
    Private ChangeCamera As Boolean = False
    Private CameraUnfrozen As Boolean = True
    Private PrecisionStage As Byte = 0
    Private SoftCameraUnfrozen As Boolean = True
    Private Base As Long
    Public Shared EmuOpen As Boolean = False
    Private Key3WasUp As Boolean = True
    Private ctrlkey As Boolean
    Private AnimList As New List(Of Animation)
    Private AnimData As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private LastCBox1Index As Integer
    Private TestOnce As Boolean = False
    Private DisableAnimSwap As Boolean = False
    Private OriginalFuntionCall As String
    Private CameraControlFunction As String

    Private ReadOnly Property CB1AnimIndex As Integer
        Get
            For Each anim As Animation In AnimList
                If anim.Value = ComboBox1.SelectedValue Then Return anim.Index
            Next
        End Get
    End Property

    Private ReadOnly Property CB2AnimIndex As Integer
        Get
            For Each anim As Animation In AnimList
                If anim.Value = ComboBox2.SelectedValue Then Return anim.Index
            Next
        End Get
    End Property

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        AddHandler ComboBox1.SelectedValueChanged, AddressOf ComboBox1_SelectedValueChanged
        AddHandler ComboBox2.SelectedValueChanged, AddressOf ComboBox2_SelectedValueChanged
        AddHandler ResetAnimationSwapsMenuItem.Click, AddressOf ResetAnimations
        AddHandler b_Freeze.Click, AddressOf Freeze
        AddHandler b_Unfreeze.Click, AddressOf Unfreeze
        AddHandler b_ChangeCameraType.Click, AddressOf ChangeCameraType
        AddHandler b_SoftFreeze.Click, AddressOf SoftFreeze
        AddHandler b_SoftUnfreeze.Click, AddressOf SoftUnfreeze
        AddHandler AboutMenuItem.Click, AddressOf AboutBox.ShowDialog
        AddHandler ForceCameraPresetMenuItem.Click, AddressOf ForceCameraPreset
        AddHandler Timer1.Tick, AddressOf Main

        Try
            Using sr As New StreamReader("animation_data.txt")
                Do While sr.Peek() >= 0
                    Dim rawLine As String
                    rawLine = sr.ReadLine()
                    Dim step1 As String = rawLine.Trim()
                    Dim step2 As String = step1.TrimStart("0")
                    Dim step3 As String = step2.TrimStart("x")
                    Dim splitLine() As String = Split(step3, " = ")
                    AnimData.Add(splitLine(0), splitLine(1))
                    AnimList.Add(New Animation(splitLine(0), splitLine(1), CInt(splitLine(2))))
                Loop
            End Using
        Catch e As Exception
            MessageBox.Show("Error reading animation data file:" & vbCrLf & e.Message)
            DisableAnimSwap = True
            Label7.Text = "Animation data not loaded!"
            Label6.Text = "Animation data not loaded!"
            ComboBox1.Refresh()
            ComboBox2.Refresh()
        End Try

        If AnimData.Count > 0 And DisableAnimSwap = False Then
            ComboBox1.DataSource = New BindingSource(AnimData, Nothing)
            ComboBox1.DisplayMember = "Value"
            ComboBox1.ValueMember = "Key"
            ComboBox2.DataSource = New BindingSource(AnimData, Nothing)
            ComboBox2.DisplayMember = "Value"
            ComboBox2.ValueMember = "Key"
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            LastCBox1Index = 0
            ComboBox1.Refresh()
            ComboBox2.Refresh()
        End If

        If GetEmuProcess("Project64") = Nothing Then
            EmuOpen = False
        Else
            EmuOpen = True
        End If
    End Sub

    Public Function GetChunks(value As String, chunkSize As Integer) As List(Of String)
        Dim bytes As New List(Of String)
        While value.Length > chunkSize
            bytes.Add(value.Substring(0, chunkSize))
            value = value.Substring(chunkSize)
        End While
        If value <> "" Then
            bytes.Add(value)
        End If
        Return bytes
    End Function

    Private Sub WriteAnimationSwap()
        If EmuOpen = True And Base > 0 Then
            WriteInteger("Project64", Base + &H64040 + ((CB1AnimIndex + 1) * 8), Integer.Parse(GetChunks(ComboBox2.SelectedValue, 8)(0), Globalization.NumberStyles.HexNumber))
            WriteInteger("Project64", Base + &H64044 + ((CB1AnimIndex + 1) * 8), Integer.Parse(GetChunks(ComboBox2.SelectedValue, 8)(1), Globalization.NumberStyles.HexNumber))
        End If
    End Sub

    Private Function CurrentAnimInRAM() As String
        Dim Whole As String = ""
        Dim Half1 As String = ""
        Dim Half2 As String = ""
        If EmuOpen = True And Base > 0 Then
            For x = 0 To 3
                Dim nextPart As String = Hex(CStr(ReadByte("Project64", Base + &H64040 + ((CB1AnimIndex + 1) * 8) + x)(0)))
                If nextPart.Count = 1 Then nextPart = "0" & nextPart
                Half1 = Half1 & StrReverse(nextPart)
            Next

            For x = 0 To 3
                Dim nextPart As String = Hex(CStr(ReadByte("Project64", Base + &H64044 + ((CB1AnimIndex + 1) * 8) + x)(0)))
                If nextPart.Count = 1 Then nextPart = "0" & nextPart
                Half2 = Half2 & StrReverse(nextPart)
            Next

            Whole = StrReverse(Half1) & StrReverse(Half2)
            Return Whole
        End If
        Return "Error"
    End Function

    Private Sub ResetAnimations()
        For Each anim As Animation In AnimList
            WriteInteger("Project64", Base + &H64040 + ((anim.Index + 1) * 8), Integer.Parse(GetChunks(anim.Value, 8)(0), Globalization.NumberStyles.HexNumber))
            WriteInteger("Project64", Base + &H64044 + ((anim.Index + 1) * 8), Integer.Parse(GetChunks(anim.Value, 8)(1), Globalization.NumberStyles.HexNumber))
        Next
        ComboBox2.SelectedIndex = ComboBox1.SelectedIndex
    End Sub

    Private Sub ForceCameraPreset()
        WriteInteger("Project64", Base + &H33C6D6, &H1010, 2)
    End Sub

    Private Sub GetBase(Optional silent As Boolean = True)
        ' Get the base RAM address of the emulated memory block by searching for the constant value of SM64's first RAM address
        BaseAddressLabel.Text = "Scanning for base address..."
        BaseAddressLabel.Refresh()
        Base = GetBaseAddress("Project64", silent)
        If Base > 0 Then
            If silent = False Then
                MessageBox.Show("The base address is: " & Hex(Base))
            End If
            BaseAddressLabel.Text = "The base address is: " & Hex(Base)
        Else
            BaseAddressLabel.Text = "Base address not found!"
        End If
    End Sub

    Private Sub Freeze()
        If EmuOpen = True And Base > 0 Then
            ChangeCamera = False
            CameraUnfrozen = False
            WriteInteger("Project64", Base + &H33C848, &H80000000)
        End If
    End Sub

    Private Sub Unfreeze()
        If EmuOpen = True And Base > 0 Then
            ChangeCamera = False
            CameraUnfrozen = True
            b_ChangeCameraType.Text = "Change Camera Type"
            WriteInteger("Project64", Base + &H33C848, 0)
        End If
    End Sub

    Private Sub ChangeCameraType()
        If EmuOpen = True And Base > 0 Then
            ChangeCamera = Not ChangeCamera
            If ChangeCamera = True Then
                CameraUnfrozen = False
                b_ChangeCameraType.Text = "Go to new area"
            Else
                Unfreeze()
            End If
        End If
    End Sub

    Private Sub SoftFreeze()
        If EmuOpen = True And Base > 0 Then
            SoftCameraUnfrozen = False
            'MsgBox(Hex(ReadInteger("Project64", Base + &H33B204)))
            WriteInteger("Project64", Base + &H33B204, &H8001C520)
        End If
    End Sub

    Private Sub SoftUnfreeze()
        If EmuOpen = True And Base > 0 Then
            SoftCameraUnfrozen = True
            'MsgBox(Hex(ReadInteger("Project64", Base + &H33B204)))
            WriteInteger("Project64", Base + &H33B204, &H8033C520)
        End If
    End Sub

    Private Sub Main(myObject As Object, ByVal myEventArgs As EventArgs)
        ' Main program update call
        If GetEmuProcess("Project64") = Nothing Then
            EmuOpen = False
        Else
            EmuOpen = True
        End If

        If EmuOpen = True Then
            If Base > 0 Then
                ' Check if base address is still correct
                If ReadInteger("Project64", Base) <> &H3C1A8032 Then ' If our old base is not valid, we need to start looking for a new one
                    Base = 0
                    b_ChangeCameraType.Enabled = False
                    b_Freeze.Enabled = False
                    b_Unfreeze.Enabled = False
                    ComboBox1.Enabled = False
                    ComboBox2.Enabled = False
                    b_SoftFreeze.Enabled = False
                    b_SoftUnfreeze.Enabled = False
                    PrecisionModeOff(True)
                    Exit Sub
                End If

                b_ChangeCameraType.Enabled = True
                b_Freeze.Enabled = True
                b_Unfreeze.Enabled = True
                ComboBox1.Enabled = Not DisableAnimSwap
                ComboBox2.Enabled = Not DisableAnimSwap
                b_SoftFreeze.Enabled = True
                b_SoftUnfreeze.Enabled = True
                If PrecisionStage = 0 Then
                    PrecisionStatusLabel.Text = "Precision Mode is disabled." + vbCrLf + "Enable it in Settings -> Enable Precision Mode"
                    b_PrecisionPlusOne.Text = "Precision Mode Disabled"
                End If


                If DisableAnimSwap = False Then WriteAnimationSwap()

                ' Handle key input (for hotkeys, etc.)
                HandleInput()

                ' Sometimes exiting first-person while the camera is frozen will result in a glitched state where Mario is stuck in first-person.
                ' This checks to see if this has happened, and forcibly fixes the camera if needed.
                If ReadLong("Project64", Base + &H33C848) >= &HA2000000L Then WriteInteger("Project64", Base + &H33C848, &H80000000)

                ' If we are changing camera modes, repeatedly force the camera into frozen mode.
                If ChangeCamera = True Then
                    WriteInteger("Project64", Base + &H33C848, &H80000000)
                End If

            Else
                b_Freeze.Enabled = False
                b_Unfreeze.Enabled = False
                b_ChangeCameraType.Enabled = False
                b_ChangeCameraType.Text = "Change Camera Type"
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                b_SoftFreeze.Enabled = False
                b_SoftUnfreeze.Enabled = False
                GetBase()
            End If
        Else
            b_Freeze.Enabled = False
            b_Unfreeze.Enabled = False
            b_ChangeCameraType.Enabled = False
            b_ChangeCameraType.Text = "Change Camera Type"
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            b_SoftFreeze.Enabled = False
            b_SoftUnfreeze.Enabled = False
            BaseAddressLabel.Text = "Project64 isn't open!"
            PrecisionStatusLabel.Text = "Precision mode is disabled: Project64 isn't open."
        End If
    End Sub

    Private Sub HandleInput()
        If GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D1) Then
            Freeze()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D2) Then
            Unfreeze()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D3) And Key3WasUp Then
            Key3WasUp = False
            ChangeCameraType()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D4) Then
            SoftFreeze()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D5) Then
            SoftUnfreeze()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D6) Then
            For x = 0 To 26
                Dim partialFunction As Integer = ReadInteger("Project64", Base + &H290D90 + (4 * x))
                WriteInteger("Project64", Base + &H33D2D0 + (4 * x), partialFunction)
            Next
            WriteInteger("Project64", Base + &H33D3D0, ReadInteger("Project64", Base + &H33CBD0))
            WriteInteger("Project64", Base + &HEE060, &H8033D2D0)
            'MsgBox(CameraControlFunction)
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.D7) Then
            For x = 0 To 26
                Dim partialFunction As String = Hex(ReadInteger("Project64", Base + &H290D90 + (4 * x)))
                If partialFunction.Count < 7 Then
                    For y = 0 To (7 - partialFunction.Count)
                        partialFunction = "0" & partialFunction
                    Next

                End If
                CameraControlFunction = CameraControlFunction & partialFunction
            Next

        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.R) And DisableAnimSwap = False Then
            ResetAnimations()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.F) Then
            ForceCameraPreset()
        ElseIf GetKeyPress(Keys.ControlKey) And GetKeyPress(Keys.P) Then
            If PrecisionModeMenuItem.Checked = False Then
                PrecisionModeOn(False)
            ElseIf PrecisionModeMenuItem.Checked = True Then
                PrecisionModeOff(False)
            End If

        End If

        If GetKeyPress(Keys.D3) = False Then
            Key3WasUp = True
        Else
            Key3WasUp = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If UndoPreviousAnimationSwapsMenuItem.Checked And EmuOpen = True And Base > 0 And DisableAnimSwap = False Then
            For Each anim As Animation In AnimList
                If anim.Value = DirectCast(ComboBox2.Items(LastCBox1Index), KeyValuePair(Of String, String)).Key Then
                    WriteInteger("Project64", Base + &H64040 + ((anim.Index + 1) * 8), Integer.Parse(GetChunks(anim.Value, 8)(0), Globalization.NumberStyles.HexNumber))
                    WriteInteger("Project64", Base + &H64044 + ((anim.Index + 1) * 8), Integer.Parse(GetChunks(anim.Value, 8)(1), Globalization.NumberStyles.HexNumber))
                    Exit For
                End If
            Next
        End If
        LastCBox1Index = ComboBox1.SelectedIndex

        If EmuOpen = True And Base > 0 Then ComboBox2.SelectedValue = CurrentAnimInRAM()
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs)
        If DisableAnimSwap = False Then WriteAnimationSwap()
    End Sub

    Private Sub RetainAnimationSwapsMenuItem_Click(sender As Object, e As EventArgs) Handles RetainAnimationSwapsMenuItem.Click
        RetainAnimationSwapsMenuItem.Checked = True
        RetainAnimationSwapsMenuItem.CheckState = CheckState.Checked

        UndoPreviousAnimationSwapsMenuItem.Checked = False
        UndoPreviousAnimationSwapsMenuItem.CheckState = CheckState.Unchecked
    End Sub

    Private Sub UndoPreviousAnimationSwapsMenuItem_Click(sender As Object, e As EventArgs) Handles UndoPreviousAnimationSwapsMenuItem.Click
        UndoPreviousAnimationSwapsMenuItem.Checked = True
        UndoPreviousAnimationSwapsMenuItem.CheckState = CheckState.Checked

        RetainAnimationSwapsMenuItem.Checked = False
        RetainAnimationSwapsMenuItem.CheckState = CheckState.Unchecked
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100 'Make the timer tick every tenth of a second, to avoid unneccesary CPU use in some processors.
        Timer1.Start()
    End Sub

    Private Sub b_PrecisionPlusOne_Click(sender As Object, e As EventArgs) Handles b_PrecisionPlusOne.Click
        If PrecisionStage = 1 Then
            LockAngle()
        ElseIf PrecisionStage = 2 Then
            PrecisionModeOn(True)
        End If
    End Sub
    ''' <summary>
    ''' Enables Precision Mode
    ''' </summary>
    ''' <param name="Reclick">True or false - Is a button reclick?</param>
    Private Sub PrecisionModeOn(ByVal Reclick As Boolean)
        If Reclick = False Then
            PrecisionStatusLabel.Text = "Camera position locked. Click the button below to lock camera rotation."
            NormalCamControls.Enabled = False
            b_PrecisionPlusOne.Enabled = True
            PrecisionStage = 1
            b_PrecisionPlusOne.Text = "Lock Camera Rotation"
            SoftFreeze()
            WriteInteger("Project64", Base + &H33C848, &H60000000)
        ElseIf Reclick = True Then
            PrecisionStatusLabel.Text = "Camera rotation unlocked. Click the button below to lock camera rotation."
            b_PrecisionPlusOne.Enabled = True
            Unfreeze()
            PrecisionStage = 1
            b_PrecisionPlusOne.Text = "Lock Camera Rotation"
            SoftFreeze()
            WriteInteger("Project64", Base + &H33C848, &H60000000)
        End If
    End Sub
    ''' <summary>
    ''' Locks the angle of the camera in C-Up mode.
    ''' </summary>
    Private Sub LockAngle()
        PrecisionStatusLabel.Text = "Camera completely locked. Press the button below to re-adjust camera angle." + vbCrLf + "To disable precision mode, uncheck Settings -> Enable Precision Mode"
        Freeze()
        b_PrecisionPlusOne.Text = "Unlock Camera Rotation"
        PrecisionStage = 2
    End Sub
    ''' <summary>
    ''' Turns off Precision Mode
    ''' </summary>
    ''' <param name="Hard">True or False - Hard shutdown. Does not enable any buttons/unfreeze the camera</param>
    Private Sub PrecisionModeOff(ByVal Hard As Boolean)
        If Hard = False Then
            NormalCamControls.Enabled = True
            b_PrecisionPlusOne.Enabled = False
            PrecisionStage = 0
            Unfreeze()
            SoftUnfreeze()
            PrecisionStatusLabel.Text = "Precision Mode is disabled." + vbCrLf + "Enable it in Settings -> Enable Precision Mode"
            PrecisionModeMenuItem.Checked = False
            'Insert Here the WriteInteger for unforce C-Up mode
        Else
            b_PrecisionPlusOne.Enabled = False
            PrecisionStage = 0
            PrecisionModeMenuItem.Checked = False
        End If
    End Sub

    Private Sub PrecisionCameraModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrecisionModeMenuItem.Click
        If PrecisionModeMenuItem.Checked = False Then
            If Base = 0 Then
                MsgBox("Cannot use Precision Mode if Project64 with Super Mario 64 is not loaded.", MsgBoxStyle.Exclamation, "I'm sorry Dave")
            Else
                PrecisionModeOn(False)
                PrecisionModeMenuItem.Checked = True
            End If
        Else
            PrecisionModeOff(False)
        End If
    End Sub
End Class

Public Class Animation
    Public Value As String
    Public Description As String
    Public Index As Integer

    Public Sub New(val As String, desc As String, ind As Integer)
        Value = val
        Description = desc
        Index = ind
    End Sub
End Class
