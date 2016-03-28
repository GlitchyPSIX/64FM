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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat))
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.UserContextStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectBuzzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecretToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.lbNick = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbMessage = New System.Windows.Forms.RichTextBox()
        Me.BuzzerTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExplosionToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NudgeCooldown = New System.Windows.Forms.ProgressBar()
        Me.ExplodeCooldown = New System.Windows.Forms.ProgressBar()
        Me.BuzzerCooldownControl = New System.Windows.Forms.Timer(Me.components)
        Me.ExplosionCooldownControl = New System.Windows.Forms.Timer(Me.components)
        Me.btnExplode = New System.Windows.Forms.Button()
        Me.btnNudge = New System.Windows.Forms.Button()
        Me.UserContextStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbLog
        '
        Me.rtbLog.Location = New System.Drawing.Point(12, 12)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ReadOnly = True
        Me.rtbLog.Size = New System.Drawing.Size(465, 373)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'lstUsers
        '
        Me.lstUsers.ContextMenuStrip = Me.UserContextStrip
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Items.AddRange(New Object() {" "})
        Me.lstUsers.Location = New System.Drawing.Point(480, 12)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(105, 290)
        Me.lstUsers.TabIndex = 1
        '
        'UserContextStrip
        '
        Me.UserContextStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PMToolStripMenuItem, Me.FreezeToolStripMenuItem, Me.ToolStripMenuItem1, Me.DirectBuzzToolStripMenuItem, Me.PunchToolStripMenuItem, Me.SecretToolStripMenuItem, Me.KickToolStripMenuItem})
        Me.UserContextStrip.Name = "UserContextStrip"
        Me.UserContextStrip.Size = New System.Drawing.Size(133, 158)
        '
        'PMToolStripMenuItem
        '
        Me.PMToolStripMenuItem.Name = "PMToolStripMenuItem"
        Me.PMToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PMToolStripMenuItem.Text = "PM"
        '
        'FreezeToolStripMenuItem
        '
        Me.FreezeToolStripMenuItem.Name = "FreezeToolStripMenuItem"
        Me.FreezeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.FreezeToolStripMenuItem.Text = "Freeze"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem1.Text = "Unfreeze"
        '
        'DirectBuzzToolStripMenuItem
        '
        Me.DirectBuzzToolStripMenuItem.Name = "DirectBuzzToolStripMenuItem"
        Me.DirectBuzzToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DirectBuzzToolStripMenuItem.Text = "Direct Buzz"
        '
        'PunchToolStripMenuItem
        '
        Me.PunchToolStripMenuItem.Name = "PunchToolStripMenuItem"
        Me.PunchToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PunchToolStripMenuItem.Text = "Punch"
        '
        'SecretToolStripMenuItem
        '
        Me.SecretToolStripMenuItem.Name = "SecretToolStripMenuItem"
        Me.SecretToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SecretToolStripMenuItem.Text = "Secret!"
        '
        'KickToolStripMenuItem
        '
        Me.KickToolStripMenuItem.Name = "KickToolStripMenuItem"
        Me.KickToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.KickToolStripMenuItem.Text = "Kick"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Transparent
        Me.btnConnect.Location = New System.Drawing.Point(480, 378)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(105, 29)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Go Online"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.Transparent
        Me.btnDisconnect.Location = New System.Drawing.Point(480, 413)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(105, 29)
        Me.btnDisconnect.TabIndex = 2
        Me.btnDisconnect.Text = "Go Offline"
        Me.btnDisconnect.UseVisualStyleBackColor = False
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
        Me.btnSend.Location = New System.Drawing.Point(480, 448)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(105, 80)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(12, 448)
        Me.tbMessage.MaxLength = 1000
        Me.tbMessage.Multiline = False
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.tbMessage.Size = New System.Drawing.Size(465, 80)
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
        Me.NudgeCooldown.Size = New System.Drawing.Size(421, 20)
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
        'btnExplode
        '
        Me.btnExplode.BackColor = System.Drawing.Color.Transparent
        Me.btnExplode.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Explode
        Me.btnExplode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExplode.Enabled = False
        Me.btnExplode.Location = New System.Drawing.Point(42, 418)
        Me.btnExplode.Name = "btnExplode"
        Me.btnExplode.Size = New System.Drawing.Size(30, 29)
        Me.btnExplode.TabIndex = 7
        Me.btnExplode.UseVisualStyleBackColor = False
        '
        'btnNudge
        '
        Me.btnNudge.BackColor = System.Drawing.Color.Transparent
        Me.btnNudge.BackgroundImage = Global.Filmmaker.My.Resources.Resources.Nudge
        Me.btnNudge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNudge.Enabled = False
        Me.btnNudge.Location = New System.Drawing.Point(12, 391)
        Me.btnNudge.Name = "btnNudge"
        Me.btnNudge.Size = New System.Drawing.Size(28, 29)
        Me.btnNudge.TabIndex = 7
        Me.btnNudge.UseVisualStyleBackColor = False
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(597, 540)
        Me.Controls.Add(Me.ExplodeCooldown)
        Me.Controls.Add(Me.NudgeCooldown)
        Me.Controls.Add(Me.btnExplode)
        Me.Controls.Add(Me.btnNudge)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lbNick)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.rtbLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chat"
        Me.Text = "64Messenger"
        Me.UserContextStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbLog As System.Windows.Forms.RichTextBox
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents lbNick As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents tbMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents btnNudge As System.Windows.Forms.Button
    Friend WithEvents btnExplode As System.Windows.Forms.Button
    Friend WithEvents BuzzerTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents ExplosionToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents NudgeCooldown As System.Windows.Forms.ProgressBar
    Friend WithEvents ExplodeCooldown As System.Windows.Forms.ProgressBar
    Friend WithEvents BuzzerCooldownControl As System.Windows.Forms.Timer
    Friend WithEvents ExplosionCooldownControl As System.Windows.Forms.Timer
    Friend WithEvents UserContextStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectBuzzToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PunchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecretToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
