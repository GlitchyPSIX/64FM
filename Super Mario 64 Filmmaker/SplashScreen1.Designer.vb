<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PercentagedTime = New System.Windows.Forms.Timer(Me.components)
        Me.progressbar1 = New System.Windows.Forms.PictureBox()
        Me.SPLASHLOGO_PB = New System.Windows.Forms.PictureBox()
        Me.STATUS_RTB = New System.Windows.Forms.RichTextBox()
        CType(Me.progressbar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPLASHLOGO_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.Black
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Location = New System.Drawing.Point(-225, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(290, 66)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "64Filmmaker"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PercentagedTime
        '
        '
        'progressbar1
        '
        Me.progressbar1.Image = Global.Filmmaker.My.Resources.Resources.LoadingBalls
        Me.progressbar1.Location = New System.Drawing.Point(434, 245)
        Me.progressbar1.Name = "progressbar1"
        Me.progressbar1.Size = New System.Drawing.Size(50, 46)
        Me.progressbar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.progressbar1.TabIndex = 2
        Me.progressbar1.TabStop = False
        '
        'SPLASHLOGO_PB
        '
        Me.SPLASHLOGO_PB.Image = Global.Filmmaker.My.Resources.Resources.splashlogo
        Me.SPLASHLOGO_PB.Location = New System.Drawing.Point(0, 115)
        Me.SPLASHLOGO_PB.Name = "SPLASHLOGO_PB"
        Me.SPLASHLOGO_PB.Size = New System.Drawing.Size(176, 176)
        Me.SPLASHLOGO_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SPLASHLOGO_PB.TabIndex = 3
        Me.SPLASHLOGO_PB.TabStop = False
        '
        'STATUS_RTB
        '
        Me.STATUS_RTB.BackColor = System.Drawing.Color.Black
        Me.STATUS_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.STATUS_RTB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.STATUS_RTB.DetectUrls = False
        Me.STATUS_RTB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STATUS_RTB.ForeColor = System.Drawing.Color.White
        Me.STATUS_RTB.Location = New System.Drawing.Point(182, 245)
        Me.STATUS_RTB.Name = "STATUS_RTB"
        Me.STATUS_RTB.ReadOnly = True
        Me.STATUS_RTB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.STATUS_RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.STATUS_RTB.ShortcutsEnabled = False
        Me.STATUS_RTB.Size = New System.Drawing.Size(246, 46)
        Me.STATUS_RTB.TabIndex = 4
        Me.STATUS_RTB.TabStop = False
        Me.STATUS_RTB.Text = "-----------------"
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.STATUS_RTB)
        Me.Controls.Add(Me.SPLASHLOGO_PB)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.progressbar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.progressbar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPLASHLOGO_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents progressbar1 As System.Windows.Forms.PictureBox
    Friend WithEvents PercentagedTime As System.Windows.Forms.Timer
    Friend WithEvents SPLASHLOGO_PB As PictureBox
    Friend WithEvents STATUS_RTB As RichTextBox
End Class
