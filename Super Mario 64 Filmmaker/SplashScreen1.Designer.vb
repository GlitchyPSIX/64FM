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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.PercentageLabel = New System.Windows.Forms.Label()
        Me.PercentagedTime = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.progressbar1 = New System.Windows.Forms.PictureBox()
        CType(Me.progressbar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.Red
        Me.TitleLabel.Location = New System.Drawing.Point(194, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(456, 222)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Super Mario 64 Filmmaker BETA"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(68, 263)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(95, 25)
        Me.StatusLabel.TabIndex = 3
        Me.StatusLabel.Text = "Loading:"
        '
        'PercentageLabel
        '
        Me.PercentageLabel.AutoSize = True
        Me.PercentageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PercentageLabel.Location = New System.Drawing.Point(153, 265)
        Me.PercentageLabel.Name = "PercentageLabel"
        Me.PercentageLabel.Size = New System.Drawing.Size(35, 24)
        Me.PercentageLabel.TabIndex = 4
        Me.PercentageLabel.Text = "0%"
        '
        'PercentagedTime
        '
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = True
        Me.ProgressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgressLabel.Location = New System.Drawing.Point(194, 265)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(176, 24)
        Me.ProgressLabel.TabIndex = 4
        Me.ProgressLabel.Text = "Loading Main Script"
        '
        'progressbar1
        '
        Me.progressbar1.Image = Global.Filmmaker.My.Resources.Resources._301
        Me.progressbar1.Location = New System.Drawing.Point(12, 245)
        Me.progressbar1.Name = "progressbar1"
        Me.progressbar1.Size = New System.Drawing.Size(50, 46)
        Me.progressbar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.progressbar1.TabIndex = 2
        Me.progressbar1.TabStop = False
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.PercentageLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.progressbar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.progressbar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents progressbar1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents PercentageLabel As System.Windows.Forms.Label
    Friend WithEvents PercentagedTime As System.Windows.Forms.Timer
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label

End Class
