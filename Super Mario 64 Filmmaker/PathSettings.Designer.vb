<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PathSettings
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
        Me.veLb = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.browsevrBtn = New System.Windows.Forms.Button()
        Me.browseveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'veLb
        '
        Me.veLb.AutoSize = True
        Me.veLb.Location = New System.Drawing.Point(12, 28)
        Me.veLb.Name = "veLb"
        Me.veLb.Size = New System.Drawing.Size(67, 13)
        Me.veLb.TabIndex = 0
        Me.veLb.Text = "Video Editor:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(429, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recorder:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(429, 20)
        Me.TextBox2.TabIndex = 3
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(223, 155)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(75, 23)
        Me.okBtn.TabIndex = 4
        Me.okBtn.Text = "&OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'browsevrBtn
        '
        Me.browsevrBtn.Location = New System.Drawing.Point(450, 93)
        Me.browsevrBtn.Name = "browsevrBtn"
        Me.browsevrBtn.Size = New System.Drawing.Size(59, 23)
        Me.browsevrBtn.TabIndex = 5
        Me.browsevrBtn.Text = "..."
        Me.browsevrBtn.UseVisualStyleBackColor = True
        '
        'browseveBtn
        '
        Me.browseveBtn.Location = New System.Drawing.Point(450, 44)
        Me.browseveBtn.Name = "browseveBtn"
        Me.browseveBtn.Size = New System.Drawing.Size(59, 23)
        Me.browseveBtn.TabIndex = 5
        Me.browseveBtn.Text = "..."
        Me.browseveBtn.UseVisualStyleBackColor = True
        '
        'PathSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 190)
        Me.Controls.Add(Me.browseveBtn)
        Me.Controls.Add(Me.browsevrBtn)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.veLb)
        Me.Name = "PathSettings"
        Me.Text = "Path Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents veLb As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents okBtn As Button
    Friend WithEvents browsevrBtn As Button
    Friend WithEvents browseveBtn As Button
End Class
