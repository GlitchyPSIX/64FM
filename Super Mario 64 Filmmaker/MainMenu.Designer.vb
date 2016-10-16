<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.OpenFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.AppVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TenthOfASecond = New System.Windows.Forms.Timer(Me.components)
        Me.ImgPrw = New System.Windows.Forms.PictureBox()
        Me.settings_btn = New System.Windows.Forms.PictureBox()
        Me.tut_btn = New System.Windows.Forms.PictureBox()
        Me.Addon_btn = New System.Windows.Forms.PictureBox()
        Me.btnSV = New System.Windows.Forms.PictureBox()
        Me.btnFRPS = New System.Windows.Forms.PictureBox()
        Me.btnGame = New System.Windows.Forms.PictureBox()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadAddonImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCheatImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportSpecialPackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClockworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstRunSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoEditorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MachinimaGuidelinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutSM64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandOrRetract = New System.Windows.Forms.PictureBox()
        Me.btnChat = New System.Windows.Forms.PictureBox()
        Me.btnCinema = New System.Windows.Forms.PictureBox()
        Me.noticon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.noticon_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Show64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Version_lb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.WebpageLink_lb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.About64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.About64PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDlg
        '
        Me.OpenFileDlg.FileName = "OpenFileDialog1"
        '
        'AppVer
        '
        Me.AppVer.BackColor = System.Drawing.Color.Black
        Me.AppVer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AppVer.Name = "AppVer"
        Me.AppVer.Size = New System.Drawing.Size(102, 17)
        Me.AppVer.Text = "64Filmmaker FTW"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(107, 17)
        Me.ToolStripStatusLabel1.Text = "64Network Forums"
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
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAddonImporterToolStripMenuItem, Me.LoadCheatImporterToolStripMenuItem, Me.ImportSpecialPackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadAddonImporterToolStripMenuItem
        '
        Me.LoadAddonImporterToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.LoadAddon
        Me.LoadAddonImporterToolStripMenuItem.Name = "LoadAddonImporterToolStripMenuItem"
        Me.LoadAddonImporterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.LoadAddonImporterToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.LoadAddonImporterToolStripMenuItem.Text = "Import Addon..."
        '
        'LoadCheatImporterToolStripMenuItem
        '
        Me.LoadCheatImporterToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.LoadCheatSht
        Me.LoadCheatImporterToolStripMenuItem.Name = "LoadCheatImporterToolStripMenuItem"
        Me.LoadCheatImporterToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.LoadCheatImporterToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.LoadCheatImporterToolStripMenuItem.Text = "Import Cheatsheet..."
        '
        'ImportSpecialPackToolStripMenuItem
        '
        Me.ImportSpecialPackToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.LoadSpecialPkg
        Me.ImportSpecialPackToolStripMenuItem.Name = "ImportSpecialPackToolStripMenuItem"
        Me.ImportSpecialPackToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ImportSpecialPackToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ImportSpecialPackToolStripMenuItem.Text = "Import Special Pack..."
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.AddonsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.User
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'AddonsToolStripMenuItem
        '
        Me.AddonsToolStripMenuItem.Image = CType(resources.GetObject("AddonsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddonsToolStripMenuItem.Name = "AddonsToolStripMenuItem"
        Me.AddonsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddonsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddonsToolStripMenuItem.Text = "Addons"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.ClockworkToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutSM64FMToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.Online
        Me.OnlineHelpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Online Help..."
        '
        'ClockworkToolStripMenuItem
        '
        Me.ClockworkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstRunSetupToolStripMenuItem, Me.ToolStripSeparator3, Me.EmulatorToolStripMenuItem, Me.VideoEditorsToolStripMenuItem, Me.MachinimaGuidelinesToolStripMenuItem})
        Me.ClockworkToolStripMenuItem.Image = CType(resources.GetObject("ClockworkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClockworkToolStripMenuItem.Name = "ClockworkToolStripMenuItem"
        Me.ClockworkToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ClockworkToolStripMenuItem.Text = "64Clockwork"
        '
        'FirstRunSetupToolStripMenuItem
        '
        Me.FirstRunSetupToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.Tutorials
        Me.FirstRunSetupToolStripMenuItem.Name = "FirstRunSetupToolStripMenuItem"
        Me.FirstRunSetupToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.FirstRunSetupToolStripMenuItem.Text = "First Run Setup Tutorial"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        'EmulatorToolStripMenuItem
        '
        Me.EmulatorToolStripMenuItem.Name = "EmulatorToolStripMenuItem"
        Me.EmulatorToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EmulatorToolStripMenuItem.Text = "Emulator"
        '
        'VideoEditorsToolStripMenuItem
        '
        Me.VideoEditorsToolStripMenuItem.Name = "VideoEditorsToolStripMenuItem"
        Me.VideoEditorsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VideoEditorsToolStripMenuItem.Text = "Video Editors"
        '
        'MachinimaGuidelinesToolStripMenuItem
        '
        Me.MachinimaGuidelinesToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.Guides
        Me.MachinimaGuidelinesToolStripMenuItem.Name = "MachinimaGuidelinesToolStripMenuItem"
        Me.MachinimaGuidelinesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.MachinimaGuidelinesToolStripMenuItem.Text = "Machinima Tips"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'AboutSM64FMToolStripMenuItem
        '
        Me.AboutSM64FMToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.About
        Me.AboutSM64FMToolStripMenuItem.Name = "AboutSM64FMToolStripMenuItem"
        Me.AboutSM64FMToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AboutSM64FMToolStripMenuItem.Text = "About 64Filmmaker..."
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
        Me.btnChat.Image = Global.Filmmaker.My.Resources.Resources.IM
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Version_lb, Me.WebpageLink_lb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Version_lb
        '
        Me.Version_lb.Name = "Version_lb"
        Me.Version_lb.Size = New System.Drawing.Size(645, 17)
        Me.Version_lb.Spring = True
        Me.Version_lb.Text = "64Filmmaker ."
        Me.Version_lb.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'WebpageLink_lb
        '
        Me.WebpageLink_lb.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.WebpageLink_lb.BackColor = System.Drawing.Color.Transparent
        Me.WebpageLink_lb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.WebpageLink_lb.IsLink = True
        Me.WebpageLink_lb.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.WebpageLink_lb.LinkColor = System.Drawing.Color.Gray
        Me.WebpageLink_lb.Name = "WebpageLink_lb"
        Me.WebpageLink_lb.Size = New System.Drawing.Size(137, 17)
        Me.WebpageLink_lb.Text = "64Filmmaker Homepage"
        Me.WebpageLink_lb.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(519, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About64FMToolStripMenuItem, Me.ToolStripSeparator4, Me.About64PlayerToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'About64FMToolStripMenuItem
        '
        Me.About64FMToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.About
        Me.About64FMToolStripMenuItem.Name = "About64FMToolStripMenuItem"
        Me.About64FMToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.About64FMToolStripMenuItem.Text = "About 64FM..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(160, 6)
        '
        'About64PlayerToolStripMenuItem
        '
        Me.About64PlayerToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.About
        Me.About64PlayerToolStripMenuItem.Name = "About64PlayerToolStripMenuItem"
        Me.About64PlayerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.About64PlayerToolStripMenuItem.Text = "About 64Player..."
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = Global.Filmmaker.My.Resources.Resources.dark_noise
        Me.ClientSize = New System.Drawing.Size(519, 639)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.MainMenuStrip = Me.MenuStrip1
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents AppVer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TenthOfASecond As System.Windows.Forms.Timer
    Friend WithEvents ImgPrw As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadAddonImporterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadCheatImporterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutSM64FMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportSpecialPackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpandOrRetract As System.Windows.Forms.PictureBox
    Friend WithEvents btnChat As System.Windows.Forms.PictureBox
    Friend WithEvents btnCinema As System.Windows.Forms.PictureBox
    Friend WithEvents noticon As NotifyIcon
    Friend WithEvents noticon_strip As ContextMenuStrip
    Friend WithEvents Show64FMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Exit64FMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClockworkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirstRunSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EmulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoEditorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MachinimaGuidelinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Version_lb As ToolStripStatusLabel
    Friend WithEvents WebpageLink_lb As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents About64FMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents About64PlayerToolStripMenuItem As ToolStripMenuItem
End Class
