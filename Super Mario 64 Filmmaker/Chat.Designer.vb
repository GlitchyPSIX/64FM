<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.btnGoLive = New System.Windows.Forms.Button()
        Me.btnGoDead = New System.Windows.Forms.Button()
        Me.lbNick = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbMessage = New System.Windows.Forms.RichTextBox()
        Me.BuzzerTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExplosionToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NudgeCooldown = New System.Windows.Forms.ProgressBar()
        Me.ExplodeCooldown = New System.Windows.Forms.ProgressBar()
        Me.BuzzerCooldownControl = New System.Windows.Forms.Timer(Me.components)
        Me.ExplosionCooldownControl = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshList = New System.Windows.Forms.Timer(Me.components)
        Me.Explode = New System.Windows.Forms.Button()
        Me.Nudge = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbLog
        '
        Me.rtbLog.Location = New System.Drawing.Point(12, 12)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(465, 373)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Items.AddRange(New Object() {" "})
        Me.lstUsers.Location = New System.Drawing.Point(480, 12)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(105, 290)
        Me.lstUsers.TabIndex = 1
        '
        'btnGoLive
        '
        Me.btnGoLive.BackColor = System.Drawing.Color.Transparent
        Me.btnGoLive.Location = New System.Drawing.Point(480, 378)
        Me.btnGoLive.Name = "btnGoLive"
        Me.btnGoLive.Size = New System.Drawing.Size(105, 29)
        Me.btnGoLive.TabIndex = 2
        Me.btnGoLive.Text = "Go Online"
        Me.btnGoLive.UseVisualStyleBackColor = False
        '
        'btnGoDead
        '
        Me.btnGoDead.BackColor = System.Drawing.Color.Transparent
        Me.btnGoDead.Location = New System.Drawing.Point(480, 413)
        Me.btnGoDead.Name = "btnGoDead"
        Me.btnGoDead.Size = New System.Drawing.Size(105, 29)
        Me.btnGoDead.TabIndex = 2
        Me.btnGoDead.Text = "Go Offline"
        Me.btnGoDead.UseVisualStyleBackColor = False
        '
        'lbNick
        '
        Me.lbNick.BackColor = System.Drawing.Color.Transparent
        Me.lbNick.Location = New System.Drawing.Point(483, 305)
        Me.lbNick.Name = "lbNick"
        Me.lbNick.Size = New System.Drawing.Size(97, 40)
        Me.lbNick.TabIndex = 3
        Me.lbNick.Text = "Your nickname is:"
        Me.lbNick.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(409, 448)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(68, 20)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(12, 448)
        Me.tbMessage.Multiline = False
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.Size = New System.Drawing.Size(391, 20)
        Me.tbMessage.TabIndex = 6
        Me.tbMessage.Text = ""
        '
        'BuzzerTooltip
        '
        Me.BuzzerTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.BuzzerTooltip.ToolTipTitle = "Buzzer (Gentle Nudge)"
        '
        'ExplosionToolTip
        '
        Me.ExplosionToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ExplosionToolTip.ToolTipTitle = "Explosion (Violent Nudge)"
        '
        'NudgeCooldown
        '
        Me.NudgeCooldown.Location = New System.Drawing.Point(46, 396)
        Me.NudgeCooldown.Maximum = 6
        Me.NudgeCooldown.Name = "NudgeCooldown"
        Me.NudgeCooldown.Size = New System.Drawing.Size(391, 20)
        Me.NudgeCooldown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.NudgeCooldown.TabIndex = 8
        Me.NudgeCooldown.Value = 6
        '
        'ExplodeCooldown
        '
        Me.ExplodeCooldown.Location = New System.Drawing.Point(78, 422)
        Me.ExplodeCooldown.Maximum = 20
        Me.ExplodeCooldown.Name = "ExplodeCooldown"
        Me.ExplodeCooldown.Size = New System.Drawing.Size(389, 20)
        Me.ExplodeCooldown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ExplodeCooldown.TabIndex = 8
        Me.ExplodeCooldown.Value = 20
        '
        'BuzzerCooldownControl
        '
        '
        'ExplosionCooldownControl
        '
        '
        'Explode
        '
        Me.Explode.BackColor = System.Drawing.Color.Transparent
        Me.Explode.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Explode
        Me.Explode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Explode.Enabled = False
        Me.Explode.Location = New System.Drawing.Point(42, 418)
        Me.Explode.Name = "Explode"
        Me.Explode.Size = New System.Drawing.Size(30, 29)
        Me.Explode.TabIndex = 7
        Me.Explode.UseVisualStyleBackColor = False
        '
        'Nudge
        '
        Me.Nudge.BackColor = System.Drawing.Color.Transparent
        Me.Nudge.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Nudge
        Me.Nudge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Nudge.Enabled = False
        Me.Nudge.Location = New System.Drawing.Point(12, 391)
        Me.Nudge.Name = "Nudge"
        Me.Nudge.Size = New System.Drawing.Size(28, 29)
        Me.Nudge.TabIndex = 7
        Me.Nudge.UseVisualStyleBackColor = False
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(597, 475)
        Me.Controls.Add(Me.ExplodeCooldown)
        Me.Controls.Add(Me.NudgeCooldown)
        Me.Controls.Add(Me.Explode)
        Me.Controls.Add(Me.Nudge)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lbNick)
        Me.Controls.Add(Me.btnGoDead)
        Me.Controls.Add(Me.btnGoLive)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.rtbLog)
        Me.Name = "Chat"
        Me.Text = "Chat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbLog As System.Windows.Forms.RichTextBox
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents btnGoLive As System.Windows.Forms.Button
    Friend WithEvents btnGoDead As System.Windows.Forms.Button
    Friend WithEvents lbNick As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents tbMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents Nudge As System.Windows.Forms.Button
    Friend WithEvents Explode As System.Windows.Forms.Button
    Friend WithEvents BuzzerTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents ExplosionToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents NudgeCooldown As System.Windows.Forms.ProgressBar
    Friend WithEvents ExplodeCooldown As System.Windows.Forms.ProgressBar
    Friend WithEvents BuzzerCooldownControl As System.Windows.Forms.Timer
    Friend WithEvents ExplosionCooldownControl As System.Windows.Forms.Timer
    Friend WithEvents RefreshList As System.Windows.Forms.Timer
End Class
