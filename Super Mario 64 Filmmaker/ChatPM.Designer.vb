<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatPM
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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(346, 408)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(68, 23)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(20, 408)
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.Size = New System.Drawing.Size(320, 20)
        Me.tbMessage.TabIndex = 7
        '
        'rtbLog
        '
        Me.rtbLog.Location = New System.Drawing.Point(20, 12)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(394, 390)
        Me.rtbLog.TabIndex = 6
        Me.rtbLog.Text = ""
        '
        'ChatPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 437)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.rtbLog)
        Me.Name = "ChatPM"
        Me.Text = "ChatPM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents tbMessage As System.Windows.Forms.TextBox
    Friend WithEvents rtbLog As System.Windows.Forms.RichTextBox
End Class
