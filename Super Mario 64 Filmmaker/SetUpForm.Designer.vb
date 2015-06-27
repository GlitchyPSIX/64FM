<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NickLabel = New System.Windows.Forms.Label()
        Me.ImageLabel = New System.Windows.Forms.Label()
        Me.SelImgBtn = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyNameIsLabel = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.PickColor = New System.Windows.Forms.Button()
        Me.NotHaali = New System.Windows.Forms.SplitContainer()
        Me.SelBGBTN = New System.Windows.Forms.Button()
        Me.BGLabel = New System.Windows.Forms.Label()
        Me.ImgPrw = New System.Windows.Forms.PictureBox()
        Me.ColorSelector = New System.Windows.Forms.ColorDialog()
        Me.SetBackground = New System.Windows.Forms.Timer(Me.components)
        Me.NameLabel = New System.Windows.Forms.Label()
        CType(Me.NotHaali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotHaali.Panel1.SuspendLayout()
        Me.NotHaali.Panel2.SuspendLayout()
        Me.NotHaali.SuspendLayout()
        CType(Me.ImgPrw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NickLabel
        '
        Me.NickLabel.AutoSize = True
        Me.NickLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NickLabel.Location = New System.Drawing.Point(26, 20)
        Me.NickLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NickLabel.Name = "NickLabel"
        Me.NickLabel.Size = New System.Drawing.Size(205, 18)
        Me.NickLabel.TabIndex = 0
        Me.NickLabel.Text = "Please tell me your nickname:"
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageLabel.Location = New System.Drawing.Point(37, 135)
        Me.ImageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(174, 18)
        Me.ImageLabel.TabIndex = 1
        Me.ImageLabel.Text = "Select your profile image:"
        '
        'SelImgBtn
        '
        Me.SelImgBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelImgBtn.Location = New System.Drawing.Point(56, 160)
        Me.SelImgBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelImgBtn.Name = "SelImgBtn"
        Me.SelImgBtn.Size = New System.Drawing.Size(122, 31)
        Me.SelImgBtn.TabIndex = 3
        Me.SelImgBtn.Text = "Select image..."
        Me.SelImgBtn.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(29, 43)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(189, 24)
        Me.NameBox.TabIndex = 4
        Me.NameBox.WordWrap = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(74, 287)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyNameIsLabel
        '
        Me.MyNameIsLabel.AutoSize = True
        Me.MyNameIsLabel.BackColor = System.Drawing.Color.Transparent
        Me.MyNameIsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyNameIsLabel.Location = New System.Drawing.Point(75, 220)
        Me.MyNameIsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyNameIsLabel.Name = "MyNameIsLabel"
        Me.MyNameIsLabel.Size = New System.Drawing.Size(88, 36)
        Me.MyNameIsLabel.TabIndex = 6
        Me.MyNameIsLabel.Text = "Hello there! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "My name is:"
        Me.MyNameIsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorLabel.Location = New System.Drawing.Point(38, 75)
        Me.ColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(164, 18)
        Me.ColorLabel.TabIndex = 7
        Me.ColorLabel.Text = "What is your fav. color?"
        '
        'PickColor
        '
        Me.PickColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickColor.Location = New System.Drawing.Point(73, 99)
        Me.PickColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PickColor.Name = "PickColor"
        Me.PickColor.Size = New System.Drawing.Size(90, 31)
        Me.PickColor.TabIndex = 8
        Me.PickColor.Text = "Pick Me!"
        Me.PickColor.UseVisualStyleBackColor = True
        '
        'NotHaali
        '
        Me.NotHaali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NotHaali.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotHaali.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.NotHaali.IsSplitterFixed = True
        Me.NotHaali.Location = New System.Drawing.Point(0, 0)
        Me.NotHaali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NotHaali.Name = "NotHaali"
        '
        'NotHaali.Panel1
        '
        Me.NotHaali.Panel1.Controls.Add(Me.SelBGBTN)
        Me.NotHaali.Panel1.Controls.Add(Me.BGLabel)
        Me.NotHaali.Panel1.Controls.Add(Me.SelImgBtn)
        Me.NotHaali.Panel1.Controls.Add(Me.ColorLabel)
        Me.NotHaali.Panel1.Controls.Add(Me.PickColor)
        Me.NotHaali.Panel1.Controls.Add(Me.NameBox)
        Me.NotHaali.Panel1.Controls.Add(Me.Button1)
        Me.NotHaali.Panel1.Controls.Add(Me.NickLabel)
        Me.NotHaali.Panel1.Controls.Add(Me.ImageLabel)
        '
        'NotHaali.Panel2
        '
        Me.NotHaali.Panel2.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Background2
        Me.NotHaali.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NotHaali.Panel2.Controls.Add(Me.NameLabel)
        Me.NotHaali.Panel2.Controls.Add(Me.ImgPrw)
        Me.NotHaali.Panel2.Controls.Add(Me.MyNameIsLabel)
        Me.NotHaali.Size = New System.Drawing.Size(505, 338)
        Me.NotHaali.SplitterDistance = 254
        Me.NotHaali.TabIndex = 9
        '
        'SelBGBTN
        '
        Me.SelBGBTN.Location = New System.Drawing.Point(41, 220)
        Me.SelBGBTN.Name = "SelBGBTN"
        Me.SelBGBTN.Size = New System.Drawing.Size(155, 31)
        Me.SelBGBTN.TabIndex = 10
        Me.SelBGBTN.Text = "Select Background..."
        Me.SelBGBTN.UseVisualStyleBackColor = True
        '
        'BGLabel
        '
        Me.BGLabel.AutoSize = True
        Me.BGLabel.Location = New System.Drawing.Point(38, 199)
        Me.BGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BGLabel.Name = "BGLabel"
        Me.BGLabel.Size = New System.Drawing.Size(166, 18)
        Me.BGLabel.TabIndex = 9
        Me.BGLabel.Text = "Select your Background"
        '
        'ImgPrw
        '
        Me.ImgPrw.BackColor = System.Drawing.Color.Transparent
        Me.ImgPrw.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Background3
        Me.ImgPrw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ImgPrw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgPrw.Location = New System.Drawing.Point(59, 75)
        Me.ImgPrw.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImgPrw.Name = "ImgPrw"
        Me.ImgPrw.Size = New System.Drawing.Size(118, 121)
        Me.ImgPrw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPrw.TabIndex = 2
        Me.ImgPrw.TabStop = False
        '
        'SetBackground
        '
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NameLabel.Location = New System.Drawing.Point(3, 256)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(231, 49)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "(Name will be displayed here)"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SetUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 338)
        Me.Controls.Add(Me.NotHaali)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "SetUpForm"
        Me.Text = "Set Up User Details"
        Me.NotHaali.Panel1.ResumeLayout(False)
        Me.NotHaali.Panel1.PerformLayout()
        Me.NotHaali.Panel2.ResumeLayout(False)
        Me.NotHaali.Panel2.PerformLayout()
        CType(Me.NotHaali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotHaali.ResumeLayout(False)
        CType(Me.ImgPrw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NickLabel As System.Windows.Forms.Label
    Friend WithEvents ImageLabel As System.Windows.Forms.Label
    Friend WithEvents ImgPrw As System.Windows.Forms.PictureBox
    Friend WithEvents SelImgBtn As System.Windows.Forms.Button
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MyNameIsLabel As System.Windows.Forms.Label
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents PickColor As System.Windows.Forms.Button
    Friend WithEvents NotHaali As System.Windows.Forms.SplitContainer
    Friend WithEvents ColorSelector As System.Windows.Forms.ColorDialog
    Friend WithEvents BGLabel As System.Windows.Forms.Label
    Friend WithEvents SelBGBTN As System.Windows.Forms.Button
    Friend WithEvents SetBackground As System.Windows.Forms.Timer
    Friend WithEvents NameLabel As System.Windows.Forms.Label
End Class
