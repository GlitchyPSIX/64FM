<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inb4beta
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
        Me.rafBtn = New System.Windows.Forms.Button()
        Me.nameLb = New System.Windows.Forms.Label()
        Me.imgptLb = New System.Windows.Forms.Label()
        Me.albnmLb = New System.Windows.Forms.Label()
        Me.btnLoadCHTSHT = New System.Windows.Forms.Button()
        Me.lbCht = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rafBtn
        '
        Me.rafBtn.Location = New System.Drawing.Point(12, 33)
        Me.rafBtn.Name = "rafBtn"
        Me.rafBtn.Size = New System.Drawing.Size(101, 23)
        Me.rafBtn.TabIndex = 0
        Me.rafBtn.Text = "Read And Fill"
        Me.rafBtn.UseVisualStyleBackColor = True
        '
        'nameLb
        '
        Me.nameLb.AutoSize = True
        Me.nameLb.Location = New System.Drawing.Point(12, 78)
        Me.nameLb.Name = "nameLb"
        Me.nameLb.Size = New System.Drawing.Size(39, 13)
        Me.nameLb.TabIndex = 1
        Me.nameLb.Text = "Label1"
        '
        'imgptLb
        '
        Me.imgptLb.AutoSize = True
        Me.imgptLb.Location = New System.Drawing.Point(12, 104)
        Me.imgptLb.Name = "imgptLb"
        Me.imgptLb.Size = New System.Drawing.Size(39, 13)
        Me.imgptLb.TabIndex = 1
        Me.imgptLb.Text = "Label1"
        '
        'albnmLb
        '
        Me.albnmLb.AutoSize = True
        Me.albnmLb.Location = New System.Drawing.Point(12, 131)
        Me.albnmLb.Name = "albnmLb"
        Me.albnmLb.Size = New System.Drawing.Size(39, 13)
        Me.albnmLb.TabIndex = 1
        Me.albnmLb.Text = "Label1"
        '
        'btnLoadCHTSHT
        '
        Me.btnLoadCHTSHT.Location = New System.Drawing.Point(341, 33)
        Me.btnLoadCHTSHT.Name = "btnLoadCHTSHT"
        Me.btnLoadCHTSHT.Size = New System.Drawing.Size(149, 23)
        Me.btnLoadCHTSHT.TabIndex = 0
        Me.btnLoadCHTSHT.Text = "Read and get latter cheat"
        Me.btnLoadCHTSHT.UseVisualStyleBackColor = True
        '
        'lbCht
        '
        Me.lbCht.AutoSize = True
        Me.lbCht.Location = New System.Drawing.Point(338, 78)
        Me.lbCht.Name = "lbCht"
        Me.lbCht.Size = New System.Drawing.Size(39, 13)
        Me.lbCht.TabIndex = 2
        Me.lbCht.Text = "Label1"
        '
        'inb4beta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 333)
        Me.Controls.Add(Me.lbCht)
        Me.Controls.Add(Me.albnmLb)
        Me.Controls.Add(Me.imgptLb)
        Me.Controls.Add(Me.nameLb)
        Me.Controls.Add(Me.btnLoadCHTSHT)
        Me.Controls.Add(Me.rafBtn)
        Me.Name = "inb4beta"
        Me.Text = "inb4beta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rafBtn As Button
    Friend WithEvents nameLb As Label
    Friend WithEvents imgptLb As Label
    Friend WithEvents albnmLb As Label
    Friend WithEvents btnLoadCHTSHT As Button
    Friend WithEvents lbCht As Label
End Class
