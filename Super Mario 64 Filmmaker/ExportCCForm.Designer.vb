<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportCCForm
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
        Me.Namelb = New System.Windows.Forms.Label()
        Me.Nametb = New System.Windows.Forms.TextBox()
        Me.OKbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Namelb
        '
        Me.Namelb.AutoSize = True
        Me.Namelb.Location = New System.Drawing.Point(12, 29)
        Me.Namelb.Name = "Namelb"
        Me.Namelb.Size = New System.Drawing.Size(38, 13)
        Me.Namelb.TabIndex = 0
        Me.Namelb.Text = "Name:"
        '
        'Nametb
        '
        Me.Nametb.Location = New System.Drawing.Point(56, 26)
        Me.Nametb.Name = "Nametb"
        Me.Nametb.Size = New System.Drawing.Size(311, 20)
        Me.Nametb.TabIndex = 1
        '
        'OKbtn
        '
        Me.OKbtn.Location = New System.Drawing.Point(56, 53)
        Me.OKbtn.Name = "OKbtn"
        Me.OKbtn.Size = New System.Drawing.Size(75, 23)
        Me.OKbtn.TabIndex = 2
        Me.OKbtn.Text = "OK"
        Me.OKbtn.UseVisualStyleBackColor = True
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(292, 52)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelbtn.TabIndex = 3
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'ExportCCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 87)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.OKbtn)
        Me.Controls.Add(Me.Nametb)
        Me.Controls.Add(Me.Namelb)
        Me.Name = "ExportCCForm"
        Me.Text = "Save CC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Namelb As Label
    Friend WithEvents Nametb As TextBox
    Friend WithEvents OKbtn As Button
    Friend WithEvents Cancelbtn As Button
End Class
