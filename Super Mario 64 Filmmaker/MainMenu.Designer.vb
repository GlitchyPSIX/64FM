<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.OpenFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.TenthOfASecond = New System.Windows.Forms.Timer(Me.components)
        Me.ImgPrw = New System.Windows.Forms.PictureBox()
        Me.settings_btn = New System.Windows.Forms.PictureBox()
        Me.tut_btn = New System.Windows.Forms.PictureBox()
        Me.Addon_btn = New System.Windows.Forms.PictureBox()
        Me.btnSV = New System.Windows.Forms.PictureBox()
        Me.btnFRPS = New System.Windows.Forms.PictureBox()
        Me.btnGame = New System.Windows.Forms.PictureBox()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.ExpandOrRetract = New System.Windows.Forms.PictureBox()
        Me.btnChat = New System.Windows.Forms.PictureBox()
        Me.btnCinema = New System.Windows.Forms.PictureBox()
        Me.noticon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.noticon_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Show64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ImgPrw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tut_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Addon_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFRPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpandOrRetract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCinema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.noticon_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDlg
        '
        Me.OpenFileDlg.FileName = "OpenFileDialog1"
        '
        'ImgPrw
        '
        Me.ImgPrw.BackColor = System.Drawing.Color.Transparent
        Me.ImgPrw.Location = New System.Drawing.Point(192, 82)
        Me.ImgPrw.Name = "ImgPrw"
        Me.ImgPrw.Size = New System.Drawing.Size(112, 112)
        Me.ImgPrw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPrw.TabIndex = 24
        Me.ImgPrw.TabStop = False
        Me.ImgPrw.WaitOnLoad = True
        '
        'settings_btn
        '
        Me.settings_btn.BackColor = System.Drawing.Color.Transparent
        Me.settings_btn.Image = Global.Filmmaker.My.Resources.Resources.ic_cfg
        Me.settings_btn.Location = New System.Drawing.Point(326, 414)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.Size = New System.Drawing.Size(151, 160)
        Me.settings_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.settings_btn.TabIndex = 21
        Me.settings_btn.TabStop = False
        '
        'tut_btn
        '
        Me.tut_btn.BackColor = System.Drawing.Color.Transparent
        Me.tut_btn.Image = Global.Filmmaker.My.Resources.Resources.ic_tut
        Me.tut_btn.Location = New System.Drawing.Point(541, 414)
        Me.tut_btn.Name = "tut_btn"
        Me.tut_btn.Size = New System.Drawing.Size(151, 160)
        Me.tut_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tut_btn.TabIndex = 18
        Me.tut_btn.TabStop = False
        '
        'Addon_btn
        '
        Me.Addon_btn.BackColor = System.Drawing.Color.Transparent
        Me.Addon_btn.Image = Global.Filmmaker.My.Resources.Resources.ic_add
        Me.Addon_btn.Location = New System.Drawing.Point(541, 248)
        Me.Addon_btn.Name = "Addon_btn"
        Me.Addon_btn.Size = New System.Drawing.Size(151, 160)
        Me.Addon_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Addon_btn.TabIndex = 20
        Me.Addon_btn.TabStop = False
        '
        'btnSV
        '
        Me.btnSV.BackColor = System.Drawing.Color.Transparent
        Me.btnSV.Image = Global.Filmmaker.My.Resources.Resources.ic_ve
        Me.btnSV.Location = New System.Drawing.Point(169, 414)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(151, 160)
        Me.btnSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSV.TabIndex = 18
        Me.btnSV.TabStop = False
        '
        'btnFRPS
        '
        Me.btnFRPS.BackColor = System.Drawing.Color.Transparent
        Me.btnFRPS.Image = Global.Filmmaker.My.Resources.Resources.ic_rec
        Me.btnFRPS.Location = New System.Drawing.Point(12, 248)
        Me.btnFRPS.Name = "btnFRPS"
        Me.btnFRPS.Size = New System.Drawing.Size(151, 160)
        Me.btnFRPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFRPS.TabIndex = 18
        Me.btnFRPS.TabStop = False
        '
        'btnGame
        '
        Me.btnGame.BackColor = System.Drawing.Color.Transparent
        Me.btnGame.Image = Global.Filmmaker.My.Resources.Resources.ic_64p
        Me.btnGame.Location = New System.Drawing.Point(12, 414)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.Size = New System.Drawing.Size(151, 160)
        Me.btnGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGame.TabIndex = 18
        Me.btnGame.TabStop = False
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WelcomeLabel.Location = New System.Drawing.Point(188, 197)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(119, 20)
        Me.WelcomeLabel.TabIndex = 25
        Me.WelcomeLabel.Text = "Welcome Back,"
        Me.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ExpandOrRetract
        '
        Me.ExpandOrRetract.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandOrRetract.BackColor = System.Drawing.Color.Transparent
        Me.ExpandOrRetract.Image = Global.Filmmaker.My.Resources.Resources.Expand
        Me.ExpandOrRetract.Location = New System.Drawing.Point(481, 290)
        Me.ExpandOrRetract.Name = "ExpandOrRetract"
        Me.ExpandOrRetract.Size = New System.Drawing.Size(38, 80)
        Me.ExpandOrRetract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExpandOrRetract.TabIndex = 28
        Me.ExpandOrRetract.TabStop = False
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.Transparent
        Me.btnChat.Location = New System.Drawing.Point(541, 82)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(151, 160)
        Me.btnChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnChat.TabIndex = 23
        Me.btnChat.TabStop = False
        '
        'btnCinema
        '
        Me.btnCinema.BackColor = System.Drawing.Color.Transparent
        Me.btnCinema.Image = CType(resources.GetObject("btnCinema.Image"), System.Drawing.Image)
        Me.btnCinema.Location = New System.Drawing.Point(326, 248)
        Me.btnCinema.Name = "btnCinema"
        Me.btnCinema.Size = New System.Drawing.Size(151, 160)
        Me.btnCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCinema.TabIndex = 29
        Me.btnCinema.TabStop = False
        '
        'noticon
        '
        Me.noticon.Icon = CType(resources.GetObject("noticon.Icon"), System.Drawing.Icon)
        Me.noticon.Text = "64Filmmaker"
        '
        'noticon_strip
        '
        Me.noticon_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Show64FMToolStripMenuItem, Me.ToolStripSeparator2, Me.Exit64FMToolStripMenuItem})
        Me.noticon_strip.Name = "noticon_strip"
        Me.noticon_strip.Size = New System.Drawing.Size(136, 54)
        '
        'Show64FMToolStripMenuItem
        '
        Me.Show64FMToolStripMenuItem.Name = "Show64FMToolStripMenuItem"
        Me.Show64FMToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.Show64FMToolStripMenuItem.Text = "Show 64FM"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(132, 6)
        '
        'Exit64FMToolStripMenuItem
        '
        Me.Exit64FMToolStripMenuItem.Name = "Exit64FMToolStripMenuItem"
        Me.Exit64FMToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.Exit64FMToolStripMenuItem.Text = "Exit 64FM"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = Global.Filmmaker.My.Resources.Resources.dark_noise
        Me.ClientSize = New System.Drawing.Size(519, 639)
        Me.Controls.Add(Me.btnCinema)
        Me.Controls.Add(Me.ExpandOrRetract)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.ImgPrw)
        Me.Controls.Add(Me.settings_btn)
        Me.Controls.Add(Me.tut_btn)
        Me.Controls.Add(Me.Addon_btn)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnSV)
        Me.Controls.Add(Me.btnFRPS)
        Me.Controls.Add(Me.btnGame)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Main Menu"
        CType(Me.ImgPrw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tut_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Addon_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFRPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpandOrRetract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCinema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.noticon_strip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGame As System.Windows.Forms.PictureBox
    Friend WithEvents tut_btn As System.Windows.Forms.PictureBox
    Friend WithEvents btnSV As System.Windows.Forms.PictureBox
    Friend WithEvents btnFRPS As System.Windows.Forms.PictureBox
    Friend WithEvents Addon_btn As System.Windows.Forms.PictureBox
    Friend WithEvents settings_btn As System.Windows.Forms.PictureBox
    Friend WithEvents TenthOfASecond As System.Windows.Forms.Timer
    Friend WithEvents ImgPrw As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpandOrRetract As System.Windows.Forms.PictureBox
    Friend WithEvents btnChat As System.Windows.Forms.PictureBox
    Friend WithEvents btnCinema As System.Windows.Forms.PictureBox
    Friend WithEvents noticon As NotifyIcon
    Friend WithEvents noticon_strip As ContextMenuStrip
    Friend WithEvents Show64FMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Exit64FMToolStripMenuItem As ToolStripMenuItem
End Class
