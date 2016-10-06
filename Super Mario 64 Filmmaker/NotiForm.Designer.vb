<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotiForm
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
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.btnDismiss = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Location = New System.Drawing.Point(12, 26)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(160, 25)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name"
        '
        'lbMessage
        '
        Me.lbMessage.BackColor = System.Drawing.Color.Transparent
        Me.lbMessage.Location = New System.Drawing.Point(12, 51)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(160, 104)
        Me.lbMessage.TabIndex = 1
        Me.lbMessage.Text = "Message"
        Me.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReply
        '
        Me.btnReply.Location = New System.Drawing.Point(12, 158)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(75, 23)
        Me.btnReply.TabIndex = 2
        Me.btnReply.Text = "Reply"
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'btnDismiss
        '
        Me.btnDismiss.Location = New System.Drawing.Point(97, 158)
        Me.btnDismiss.Name = "btnDismiss"
        Me.btnDismiss.Size = New System.Drawing.Size(75, 23)
        Me.btnDismiss.TabIndex = 3
        Me.btnDismiss.Text = "Dismiss"
        Me.btnDismiss.UseVisualStyleBackColor = True
        '
        'NotiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Filmmaker.My.Resources.Resources.white_noise
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(186, 185)
        Me.Controls.Add(Me.btnDismiss)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.lbMessage)
        Me.Controls.Add(Me.lbName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NotiForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "You got a PM"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents btnReply As System.Windows.Forms.Button
    Friend WithEvents btnDismiss As System.Windows.Forms.Button
End Class
