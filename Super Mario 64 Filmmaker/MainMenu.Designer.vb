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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AppVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TenthOfASecond = New System.Windows.Forms.Timer(Me.components)
        Me.ImgPrw = New System.Windows.Forms.PictureBox()
        Me.btnSC = New System.Windows.Forms.PictureBox()
        Me.btnCHT = New System.Windows.Forms.PictureBox()
        Me.btnWorkshop = New System.Windows.Forms.PictureBox()
        Me.btnEXT = New System.Windows.Forms.PictureBox()
        Me.btnSV = New System.Windows.Forms.PictureBox()
        Me.btnFRPS = New System.Windows.Forms.PictureBox()
        Me.btnGame = New System.Windows.Forms.PictureBox()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadAddonImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCheatImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportSpecialPackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SonyVegasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Project64ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecorderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SonyVegasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Project64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneratorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheatSearcherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserInterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VegasEffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VegasSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecorderSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUseVegasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUseTheRecorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToLoadGreenScreensInProject64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToCatridgeTiltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutSM64FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandOrRetract = New System.Windows.Forms.PictureBox()
        Me.btnChat = New System.Windows.Forms.PictureBox()
        Me.btnCinema = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ImgPrw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCHT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWorkshop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEXT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFRPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.ExpandOrRetract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCinema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDlg
        '
        Me.OpenFileDlg.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppVer, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 19
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
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = "HitGub"
        '
        'ImgPrw
        '
        Me.ImgPrw.BackColor = System.Drawing.Color.Transparent
        Me.ImgPrw.Location = New System.Drawing.Point(34, 69)
        Me.ImgPrw.Name = "ImgPrw"
        Me.ImgPrw.Size = New System.Drawing.Size(112, 112)
        Me.ImgPrw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPrw.TabIndex = 24
        Me.ImgPrw.TabStop = False
        Me.ImgPrw.WaitOnLoad = True
        '
        'btnSC
        '
        Me.btnSC.BackColor = System.Drawing.Color.Transparent
        Me.btnSC.Image = Global.Filmmaker.My.Resources.Resources.SC
        Me.btnSC.Location = New System.Drawing.Point(169, 414)
        Me.btnSC.Name = "btnSC"
        Me.btnSC.Size = New System.Drawing.Size(151, 160)
        Me.btnSC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSC.TabIndex = 21
        Me.btnSC.TabStop = False
        '
        'btnCHT
        '
        Me.btnCHT.BackColor = System.Drawing.Color.Transparent
        Me.btnCHT.Image = Global.Filmmaker.My.Resources.Resources.CHT
        Me.btnCHT.Location = New System.Drawing.Point(12, 414)
        Me.btnCHT.Name = "btnCHT"
        Me.btnCHT.Size = New System.Drawing.Size(151, 160)
        Me.btnCHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCHT.TabIndex = 18
        Me.btnCHT.TabStop = False
        '
        'btnWorkshop
        '
        Me.btnWorkshop.BackColor = System.Drawing.Color.Transparent
        Me.btnWorkshop.Image = Global.Filmmaker.My.Resources.Resources.ADD
        Me.btnWorkshop.Location = New System.Drawing.Point(326, 414)
        Me.btnWorkshop.Name = "btnWorkshop"
        Me.btnWorkshop.Size = New System.Drawing.Size(151, 160)
        Me.btnWorkshop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnWorkshop.TabIndex = 20
        Me.btnWorkshop.TabStop = False
        '
        'btnEXT
        '
        Me.btnEXT.BackColor = System.Drawing.Color.Transparent
        Me.btnEXT.Image = Global.Filmmaker.My.Resources.Resources.Extras
        Me.btnEXT.Location = New System.Drawing.Point(326, 82)
        Me.btnEXT.Name = "btnEXT"
        Me.btnEXT.Size = New System.Drawing.Size(151, 160)
        Me.btnEXT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEXT.TabIndex = 23
        Me.btnEXT.TabStop = False
        '
        'btnSV
        '
        Me.btnSV.BackColor = System.Drawing.Color.Transparent
        Me.btnSV.Image = Global.Filmmaker.My.Resources.Resources.Vegas10
        Me.btnSV.Location = New System.Drawing.Point(169, 82)
        Me.btnSV.Name = "btnSV"
        Me.btnSV.Size = New System.Drawing.Size(151, 160)
        Me.btnSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSV.TabIndex = 18
        Me.btnSV.TabStop = False
        '
        'btnFRPS
        '
        Me.btnFRPS.BackColor = System.Drawing.Color.Transparent
        Me.btnFRPS.Image = Global.Filmmaker.My.Resources.Resources.FR4PS
        Me.btnFRPS.Location = New System.Drawing.Point(169, 248)
        Me.btnFRPS.Name = "btnFRPS"
        Me.btnFRPS.Size = New System.Drawing.Size(151, 160)
        Me.btnFRPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFRPS.TabIndex = 18
        Me.btnFRPS.TabStop = False
        '
        'btnGame
        '
        Me.btnGame.BackColor = System.Drawing.Color.Transparent
        Me.btnGame.Image = Global.Filmmaker.My.Resources.Resources.PJ6A
        Me.btnGame.Location = New System.Drawing.Point(12, 248)
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
        Me.WelcomeLabel.Location = New System.Drawing.Point(30, 184)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(119, 20)
        Me.WelcomeLabel.TabIndex = 25
        Me.WelcomeLabel.Text = "Welcome Back,"
        Me.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(519, 24)
        Me.MenuStrip.TabIndex = 27
        Me.MenuStrip.Text = "MenuStrip2"
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
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.AddonsToolStripMenuItem, Me.SonyVegasToolStripMenuItem1, Me.Project64ToolStripMenuItem1, Me.RecorderToolStripMenuItem1})
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
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'AddonsToolStripMenuItem
        '
        Me.AddonsToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.Addon
        Me.AddonsToolStripMenuItem.Name = "AddonsToolStripMenuItem"
        Me.AddonsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddonsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddonsToolStripMenuItem.Text = "Addons"
        '
        'SonyVegasToolStripMenuItem1
        '
        Me.SonyVegasToolStripMenuItem1.Image = Global.Filmmaker.My.Resources.Resources.Vegas
        Me.SonyVegasToolStripMenuItem1.Name = "SonyVegasToolStripMenuItem1"
        Me.SonyVegasToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.SonyVegasToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.SonyVegasToolStripMenuItem1.Text = "Sony Vegas"
        '
        'Project64ToolStripMenuItem1
        '
        Me.Project64ToolStripMenuItem1.Image = Global.Filmmaker.My.Resources.Resources.ProjectSF
        Me.Project64ToolStripMenuItem1.Name = "Project64ToolStripMenuItem1"
        Me.Project64ToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.Project64ToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.Project64ToolStripMenuItem1.Text = "Project64"
        '
        'RecorderToolStripMenuItem1
        '
        Me.RecorderToolStripMenuItem1.Image = Global.Filmmaker.My.Resources.Resources.Recorder
        Me.RecorderToolStripMenuItem1.Name = "RecorderToolStripMenuItem1"
        Me.RecorderToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RecorderToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.RecorderToolStripMenuItem1.Text = "Recorder"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.GuidesToolStripMenuItem, Me.TutorialsToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutSM64FMToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.WebHelp
        Me.OnlineHelpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Online Help..."
        '
        'GuidesToolStripMenuItem
        '
        Me.GuidesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SonyVegasToolStripMenuItem, Me.RecorderToolStripMenuItem, Me.Project64ToolStripMenuItem, Me.GeneratorsToolStripMenuItem, Me.CheatSearcherToolStripMenuItem, Me.UserInterfaceToolStripMenuItem})
        Me.GuidesToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.Guides
        Me.GuidesToolStripMenuItem.Name = "GuidesToolStripMenuItem"
        Me.GuidesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GuidesToolStripMenuItem.Text = "Guides"
        '
        'SonyVegasToolStripMenuItem
        '
        Me.SonyVegasToolStripMenuItem.Name = "SonyVegasToolStripMenuItem"
        Me.SonyVegasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SonyVegasToolStripMenuItem.Text = "Sony Vegas"
        '
        'RecorderToolStripMenuItem
        '
        Me.RecorderToolStripMenuItem.Name = "RecorderToolStripMenuItem"
        Me.RecorderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RecorderToolStripMenuItem.Text = "Recorder"
        '
        'Project64ToolStripMenuItem
        '
        Me.Project64ToolStripMenuItem.Name = "Project64ToolStripMenuItem"
        Me.Project64ToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.Project64ToolStripMenuItem.Text = "Project64"
        '
        'GeneratorsToolStripMenuItem
        '
        Me.GeneratorsToolStripMenuItem.Name = "GeneratorsToolStripMenuItem"
        Me.GeneratorsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GeneratorsToolStripMenuItem.Text = "Generators"
        '
        'CheatSearcherToolStripMenuItem
        '
        Me.CheatSearcherToolStripMenuItem.Name = "CheatSearcherToolStripMenuItem"
        Me.CheatSearcherToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CheatSearcherToolStripMenuItem.Text = "Cheat Searcher"
        '
        'UserInterfaceToolStripMenuItem
        '
        Me.UserInterfaceToolStripMenuItem.Name = "UserInterfaceToolStripMenuItem"
        Me.UserInterfaceToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.UserInterfaceToolStripMenuItem.Text = "User Interface"
        '
        'TutorialsToolStripMenuItem
        '
        Me.TutorialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VegasEffectsToolStripMenuItem, Me.VegasSettingsToolStripMenuItem, Me.RecorderSettingsToolStripMenuItem, Me.HowToUseVegasToolStripMenuItem, Me.HowToUseTheRecorderToolStripMenuItem, Me.HowToLoadGreenScreensInProject64ToolStripMenuItem, Me.HowToCatridgeTiltToolStripMenuItem})
        Me.TutorialsToolStripMenuItem.Image = Global.Filmmaker.My.Resources.Resources.Tutorials
        Me.TutorialsToolStripMenuItem.Name = "TutorialsToolStripMenuItem"
        Me.TutorialsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.TutorialsToolStripMenuItem.Text = "Tutorials"
        '
        'VegasEffectsToolStripMenuItem
        '
        Me.VegasEffectsToolStripMenuItem.Name = "VegasEffectsToolStripMenuItem"
        Me.VegasEffectsToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.VegasEffectsToolStripMenuItem.Text = "Vegas Effects"
        '
        'VegasSettingsToolStripMenuItem
        '
        Me.VegasSettingsToolStripMenuItem.Name = "VegasSettingsToolStripMenuItem"
        Me.VegasSettingsToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.VegasSettingsToolStripMenuItem.Text = "Vegas Settings"
        '
        'RecorderSettingsToolStripMenuItem
        '
        Me.RecorderSettingsToolStripMenuItem.Name = "RecorderSettingsToolStripMenuItem"
        Me.RecorderSettingsToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.RecorderSettingsToolStripMenuItem.Text = "Recorder Settings"
        '
        'HowToUseVegasToolStripMenuItem
        '
        Me.HowToUseVegasToolStripMenuItem.Name = "HowToUseVegasToolStripMenuItem"
        Me.HowToUseVegasToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.HowToUseVegasToolStripMenuItem.Text = "How to use Vegas"
        '
        'HowToUseTheRecorderToolStripMenuItem
        '
        Me.HowToUseTheRecorderToolStripMenuItem.Name = "HowToUseTheRecorderToolStripMenuItem"
        Me.HowToUseTheRecorderToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.HowToUseTheRecorderToolStripMenuItem.Text = "How to use the Recorder"
        '
        'HowToLoadGreenScreensInProject64ToolStripMenuItem
        '
        Me.HowToLoadGreenScreensInProject64ToolStripMenuItem.Name = "HowToLoadGreenScreensInProject64ToolStripMenuItem"
        Me.HowToLoadGreenScreensInProject64ToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.HowToLoadGreenScreensInProject64ToolStripMenuItem.Text = "How to load Green Screens in Project64"
        '
        'HowToCatridgeTiltToolStripMenuItem
        '
        Me.HowToCatridgeTiltToolStripMenuItem.Name = "HowToCatridgeTiltToolStripMenuItem"
        Me.HowToCatridgeTiltToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.HowToCatridgeTiltToolStripMenuItem.Text = "How to ""Catridge Tilt"""
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
        Me.btnCinema.Image = Global.Filmmaker.My.Resources.Resources.ACC1
        Me.btnCinema.Location = New System.Drawing.Point(326, 248)
        Me.btnCinema.Name = "btnCinema"
        Me.btnCinema.Size = New System.Drawing.Size(151, 160)
        Me.btnCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCinema.TabIndex = 29
        Me.btnCinema.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 639)
        Me.Controls.Add(Me.btnCinema)
        Me.Controls.Add(Me.ExpandOrRetract)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.ImgPrw)
        Me.Controls.Add(Me.btnSC)
        Me.Controls.Add(Me.btnCHT)
        Me.Controls.Add(Me.btnWorkshop)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnEXT)
        Me.Controls.Add(Me.btnSV)
        Me.Controls.Add(Me.btnFRPS)
        Me.Controls.Add(Me.btnGame)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Main Menu"
        Me.TransparencyKey = System.Drawing.Color.LavenderBlush
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ImgPrw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCHT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWorkshop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEXT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFRPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.ExpandOrRetract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCinema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGame As System.Windows.Forms.PictureBox
    Friend WithEvents btnCHT As System.Windows.Forms.PictureBox
    Friend WithEvents btnSV As System.Windows.Forms.PictureBox
    Friend WithEvents btnFRPS As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnWorkshop As System.Windows.Forms.PictureBox
    Friend WithEvents btnSC As System.Windows.Forms.PictureBox
    Friend WithEvents AppVer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnEXT As System.Windows.Forms.PictureBox
    Friend WithEvents TenthOfASecond As System.Windows.Forms.Timer
    Friend WithEvents ImgPrw As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadAddonImporterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadCheatImporterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonyVegasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Project64ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecorderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuidesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonyVegasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Project64ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneratorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheatSearcherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserInterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VegasEffectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VegasSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecorderSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToUseVegasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToUseTheRecorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToLoadGreenScreensInProject64ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToCatridgeTiltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutSM64FMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportSpecialPackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpandOrRetract As System.Windows.Forms.PictureBox
    Friend WithEvents btnChat As System.Windows.Forms.PictureBox
    Friend WithEvents btnCinema As System.Windows.Forms.PictureBox

End Class
