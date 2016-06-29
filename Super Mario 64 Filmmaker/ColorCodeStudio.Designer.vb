<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorCodeStudio
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorCodeStudio))
		Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.CCListBox = New System.Windows.Forms.ListBox()
		Me.SavedCCsLabel = New System.Windows.Forms.Label()
		Me.DeleteSelectedbtn = New System.Windows.Forms.Button()
		Me.LoadSelectedbtn = New System.Windows.Forms.Button()
		Me.LoadYoursbtn = New System.Windows.Forms.Button()
		Me.UpdateMeList = New System.Windows.Forms.Timer(Me.components)
		Me.UpdateNow = New System.Windows.Forms.Button()
		Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
		Me.MarioSprite = New System.Windows.Forms.PictureBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.ImportCCButton = New System.Windows.Forms.Button()
		Me.DefaultButton = New System.Windows.Forms.Button()
		Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
		Me.ExportCCButton = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LoadRamButton = New System.Windows.Forms.Button()
		Me.ShoesButton3 = New System.Windows.Forms.Button()
		Me.ShoesButton1 = New System.Windows.Forms.Button()
		Me.GlovesButton3 = New System.Windows.Forms.Button()
		Me.GlovesButton1 = New System.Windows.Forms.Button()
		Me.PantsButton3 = New System.Windows.Forms.Button()
		Me.PantsButton1 = New System.Windows.Forms.Button()
		Me.SkinButton3 = New System.Windows.Forms.Button()
		Me.SkinButton1 = New System.Windows.Forms.Button()
		Me.HairButton3 = New System.Windows.Forms.Button()
		Me.HairButton1 = New System.Windows.Forms.Button()
		Me.HatButton3 = New System.Windows.Forms.Button()
		Me.HatButton1 = New System.Windows.Forms.Button()
		CType(Me.MarioSprite,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'ToolTip1
		'
		Me.ToolTip1.AutoPopDelay = 10000
		Me.ToolTip1.InitialDelay = 1000
		Me.ToolTip1.ReshowDelay = 100
		'
		'CCListBox
		'
		Me.CCListBox.FormattingEnabled = true
		Me.CCListBox.Location = New System.Drawing.Point(12, 56)
		Me.CCListBox.Name = "CCListBox"
		Me.CCListBox.Size = New System.Drawing.Size(120, 290)
		Me.CCListBox.TabIndex = 37
		'
		'SavedCCsLabel
		'
		Me.SavedCCsLabel.AutoSize = true
		Me.SavedCCsLabel.Location = New System.Drawing.Point(24, 40)
		Me.SavedCCsLabel.Name = "SavedCCsLabel"
		Me.SavedCCsLabel.Size = New System.Drawing.Size(94, 13)
		Me.SavedCCsLabel.TabIndex = 38
		Me.SavedCCsLabel.Text = "Saved Colorcodes"
		'
		'DeleteSelectedbtn
		'
		Me.DeleteSelectedbtn.Location = New System.Drawing.Point(13, 441)
		Me.DeleteSelectedbtn.Name = "DeleteSelectedbtn"
		Me.DeleteSelectedbtn.Size = New System.Drawing.Size(119, 23)
		Me.DeleteSelectedbtn.TabIndex = 39
		Me.DeleteSelectedbtn.Text = "Delete Selected"
		Me.DeleteSelectedbtn.UseVisualStyleBackColor = true
		'
		'LoadSelectedbtn
		'
		Me.LoadSelectedbtn.Location = New System.Drawing.Point(13, 412)
		Me.LoadSelectedbtn.Name = "LoadSelectedbtn"
		Me.LoadSelectedbtn.Size = New System.Drawing.Size(119, 23)
		Me.LoadSelectedbtn.TabIndex = 40
		Me.LoadSelectedbtn.Text = "Load Selected"
		Me.LoadSelectedbtn.UseVisualStyleBackColor = true
		'
		'LoadYoursbtn
		'
		Me.LoadYoursbtn.Location = New System.Drawing.Point(13, 383)
		Me.LoadYoursbtn.Name = "LoadYoursbtn"
		Me.LoadYoursbtn.Size = New System.Drawing.Size(119, 23)
		Me.LoadYoursbtn.TabIndex = 41
		Me.LoadYoursbtn.Text = "Load your CC"
		Me.LoadYoursbtn.UseVisualStyleBackColor = true
		'
		'UpdateMeList
		'
		Me.UpdateMeList.Enabled = true
		Me.UpdateMeList.Interval = 3000
		'
		'UpdateNow
		'
		Me.UpdateNow.Location = New System.Drawing.Point(13, 354)
		Me.UpdateNow.Name = "UpdateNow"
		Me.UpdateNow.Size = New System.Drawing.Size(119, 23)
		Me.UpdateNow.TabIndex = 42
		Me.UpdateNow.Text = "Update List"
		Me.UpdateNow.UseVisualStyleBackColor = true
		'
		'ToolTip2
		'
		Me.ToolTip2.AutoPopDelay = 10000
		Me.ToolTip2.InitialDelay = 1000
		Me.ToolTip2.ReshowDelay = 100
		'
		'MarioSprite
		'
		Me.MarioSprite.Image = Global.Filmmaker.My.Resources.Resources.M64MM2_CC_Mario_big
		Me.MarioSprite.Location = New System.Drawing.Point(271, 111)
		Me.MarioSprite.Name = "MarioSprite"
		Me.MarioSprite.Size = New System.Drawing.Size(256, 270)
		Me.MarioSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.MarioSprite.TabIndex = 66
		Me.MarioSprite.TabStop = false
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(153, 9)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(492, 31)
		Me.Label7.TabIndex = 65
		Me.Label7.Text = "IMPORTANT: Make sure to uncheck any color codes currently enabled in Project64. O"& _ 
    "therwise, they will prevent this program from modifying Mario's colors."
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'ImportCCButton
		'
		Me.ImportCCButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.ImportCCButton.Location = New System.Drawing.Point(278, 441)
		Me.ImportCCButton.Name = "ImportCCButton"
		Me.ImportCCButton.Size = New System.Drawing.Size(119, 23)
		Me.ImportCCButton.TabIndex = 63
		Me.ImportCCButton.Text = "Import color code..."
		Me.ImportCCButton.UseVisualStyleBackColor = true
		'
		'DefaultButton
		'
		Me.DefaultButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.DefaultButton.Location = New System.Drawing.Point(153, 441)
		Me.DefaultButton.Name = "DefaultButton"
		Me.DefaultButton.Size = New System.Drawing.Size(119, 23)
		Me.DefaultButton.TabIndex = 55
		Me.DefaultButton.Text = "Defaults"
		Me.DefaultButton.UseVisualStyleBackColor = true
		'
		'ExportCCButton
		'
		Me.ExportCCButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.ExportCCButton.Location = New System.Drawing.Point(528, 441)
		Me.ExportCCButton.Name = "ExportCCButton"
		Me.ExportCCButton.Size = New System.Drawing.Size(119, 23)
		Me.ExportCCButton.TabIndex = 64
		Me.ExportCCButton.Text = "Export color code..."
		Me.ExportCCButton.UseVisualStyleBackColor = true
		'
		'Label6
		'
		Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.Label6.Location = New System.Drawing.Point(324, 413)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(154, 13)
		Me.Label6.TabIndex = 62
		Me.Label6.Text = "Shoes"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.Label5.Location = New System.Drawing.Point(159, 256)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(69, 13)
		Me.Label5.TabIndex = 61
		Me.Label5.Text = "Gloves"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label4
		'
		Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.Label4.Location = New System.Drawing.Point(573, 256)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 13)
		Me.Label4.TabIndex = 60
		Me.Label4.Text = "Overalls"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.Label3.Location = New System.Drawing.Point(570, 150)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(75, 13)
		Me.Label3.TabIndex = 59
		Me.Label3.Text = "Skin"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label2
		'
		Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.Label2.Location = New System.Drawing.Point(156, 150)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 13)
		Me.Label2.TabIndex = 58
		Me.Label2.Text = "Hair"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.Label1.Location = New System.Drawing.Point(321, 61)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(157, 18)
		Me.Label1.TabIndex = 57
		Me.Label1.Text = "Hat/Shirt"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'LoadRamButton
		'
		Me.LoadRamButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.LoadRamButton.Location = New System.Drawing.Point(403, 441)
		Me.LoadRamButton.Name = "LoadRamButton"
		Me.LoadRamButton.Size = New System.Drawing.Size(119, 23)
		Me.LoadRamButton.TabIndex = 56
		Me.LoadRamButton.Text = "Load from game"
		Me.LoadRamButton.UseVisualStyleBackColor = true
		'
		'ShoesButton3
		'
		Me.ShoesButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.ShoesButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(114,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(14,Byte),Integer))
		Me.ShoesButton3.Location = New System.Drawing.Point(403, 387)
		Me.ShoesButton3.Name = "ShoesButton3"
		Me.ShoesButton3.Size = New System.Drawing.Size(75, 23)
		Me.ShoesButton3.TabIndex = 54
		Me.ShoesButton3.UseVisualStyleBackColor = false
		'
		'ShoesButton1
		'
		Me.ShoesButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.ShoesButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(14,Byte),Integer), CType(CType(7,Byte),Integer))
		Me.ShoesButton1.Location = New System.Drawing.Point(321, 387)
		Me.ShoesButton1.Name = "ShoesButton1"
		Me.ShoesButton1.Size = New System.Drawing.Size(75, 23)
		Me.ShoesButton1.TabIndex = 53
		Me.ShoesButton1.UseVisualStyleBackColor = false
		'
		'GlovesButton3
		'
		Me.GlovesButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.GlovesButton3.BackColor = System.Drawing.Color.White
		Me.GlovesButton3.Location = New System.Drawing.Point(156, 301)
		Me.GlovesButton3.Name = "GlovesButton3"
		Me.GlovesButton3.Size = New System.Drawing.Size(75, 23)
		Me.GlovesButton3.TabIndex = 52
		Me.GlovesButton3.UseVisualStyleBackColor = false
		'
		'GlovesButton1
		'
		Me.GlovesButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.GlovesButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(127,Byte),Integer), CType(CType(127,Byte),Integer))
		Me.GlovesButton1.Location = New System.Drawing.Point(156, 272)
		Me.GlovesButton1.Name = "GlovesButton1"
		Me.GlovesButton1.Size = New System.Drawing.Size(75, 23)
		Me.GlovesButton1.TabIndex = 51
		Me.GlovesButton1.UseVisualStyleBackColor = false
		'
		'PantsButton3
		'
		Me.PantsButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.PantsButton3.BackColor = System.Drawing.Color.Blue
		Me.PantsButton3.Location = New System.Drawing.Point(570, 301)
		Me.PantsButton3.Name = "PantsButton3"
		Me.PantsButton3.Size = New System.Drawing.Size(75, 23)
		Me.PantsButton3.TabIndex = 50
		Me.PantsButton3.UseVisualStyleBackColor = false
		'
		'PantsButton1
		'
		Me.PantsButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.PantsButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(127,Byte),Integer))
		Me.PantsButton1.Location = New System.Drawing.Point(570, 272)
		Me.PantsButton1.Name = "PantsButton1"
		Me.PantsButton1.Size = New System.Drawing.Size(75, 23)
		Me.PantsButton1.TabIndex = 49
		Me.PantsButton1.UseVisualStyleBackColor = false
		'
		'SkinButton3
		'
		Me.SkinButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.SkinButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(193,Byte),Integer), CType(CType(121,Byte),Integer))
		Me.SkinButton3.Location = New System.Drawing.Point(570, 190)
		Me.SkinButton3.Name = "SkinButton3"
		Me.SkinButton3.Size = New System.Drawing.Size(75, 23)
		Me.SkinButton3.TabIndex = 48
		Me.SkinButton3.UseVisualStyleBackColor = false
		'
		'SkinButton1
		'
		Me.SkinButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.SkinButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(60,Byte),Integer))
		Me.SkinButton1.Location = New System.Drawing.Point(570, 166)
		Me.SkinButton1.Name = "SkinButton1"
		Me.SkinButton1.Size = New System.Drawing.Size(75, 23)
		Me.SkinButton1.TabIndex = 47
		Me.SkinButton1.UseVisualStyleBackColor = false
		'
		'HairButton3
		'
		Me.HairButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.HairButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(115,Byte),Integer), CType(CType(6,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.HairButton3.Location = New System.Drawing.Point(153, 190)
		Me.HairButton3.Name = "HairButton3"
		Me.HairButton3.Size = New System.Drawing.Size(75, 23)
		Me.HairButton3.TabIndex = 46
		Me.HairButton3.UseVisualStyleBackColor = false
		'
		'HairButton1
		'
		Me.HairButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.HairButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(3,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.HairButton1.Location = New System.Drawing.Point(153, 166)
		Me.HairButton1.Name = "HairButton1"
		Me.HairButton1.Size = New System.Drawing.Size(75, 23)
		Me.HairButton1.TabIndex = 45
		Me.HairButton1.UseVisualStyleBackColor = false
		'
		'HatButton3
		'
		Me.HatButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.HatButton3.BackColor = System.Drawing.Color.Red
		Me.HatButton3.Location = New System.Drawing.Point(403, 82)
		Me.HatButton3.Name = "HatButton3"
		Me.HatButton3.Size = New System.Drawing.Size(75, 23)
		Me.HatButton3.TabIndex = 44
		Me.HatButton3.UseVisualStyleBackColor = false
		'
		'HatButton1
		'
		Me.HatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.HatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.HatButton1.Location = New System.Drawing.Point(321, 82)
		Me.HatButton1.Name = "HatButton1"
		Me.HatButton1.Size = New System.Drawing.Size(75, 23)
		Me.HatButton1.TabIndex = 43
		Me.HatButton1.UseVisualStyleBackColor = false
		'
		'ColorCodeStudio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(657, 476)
		Me.Controls.Add(Me.MarioSprite)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.ImportCCButton)
		Me.Controls.Add(Me.DefaultButton)
		Me.Controls.Add(Me.ExportCCButton)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.LoadRamButton)
		Me.Controls.Add(Me.ShoesButton3)
		Me.Controls.Add(Me.ShoesButton1)
		Me.Controls.Add(Me.GlovesButton3)
		Me.Controls.Add(Me.GlovesButton1)
		Me.Controls.Add(Me.PantsButton3)
		Me.Controls.Add(Me.PantsButton1)
		Me.Controls.Add(Me.SkinButton3)
		Me.Controls.Add(Me.SkinButton1)
		Me.Controls.Add(Me.HairButton3)
		Me.Controls.Add(Me.HairButton1)
		Me.Controls.Add(Me.HatButton3)
		Me.Controls.Add(Me.HatButton1)
		Me.Controls.Add(Me.UpdateNow)
		Me.Controls.Add(Me.LoadYoursbtn)
		Me.Controls.Add(Me.LoadSelectedbtn)
		Me.Controls.Add(Me.DeleteSelectedbtn)
		Me.Controls.Add(Me.SavedCCsLabel)
		Me.Controls.Add(Me.CCListBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MaximizeBox = false
		Me.Name = "ColorCodeStudio"
		Me.Text = "Color Code Studio"
		CType(Me.MarioSprite,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CCListBox As ListBox
    Friend WithEvents SavedCCsLabel As Label
    Friend WithEvents DeleteSelectedbtn As Button
    Friend WithEvents LoadSelectedbtn As Button
    Friend WithEvents LoadYoursbtn As Button
    Friend WithEvents UpdateMeList As Timer
    Friend WithEvents UpdateNow As Button
	Friend WithEvents ToolTip2 As ToolTip
	Friend WithEvents MarioSprite As PictureBox
	Friend WithEvents Label7 As Label
	Friend WithEvents ImportCCButton As Button
	Friend WithEvents DefaultButton As Button
	Friend WithEvents ColorDialog2 As ColorDialog
	Friend WithEvents ExportCCButton As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents LoadRamButton As Button
	Friend WithEvents ShoesButton3 As Button
	Friend WithEvents ShoesButton1 As Button
	Friend WithEvents GlovesButton3 As Button
	Friend WithEvents GlovesButton1 As Button
	Friend WithEvents PantsButton3 As Button
	Friend WithEvents PantsButton1 As Button
	Friend WithEvents SkinButton3 As Button
	Friend WithEvents SkinButton1 As Button
	Friend WithEvents HairButton3 As Button
	Friend WithEvents HairButton1 As Button
	Friend WithEvents HatButton3 As Button
	Friend WithEvents HatButton1 As Button
End Class
