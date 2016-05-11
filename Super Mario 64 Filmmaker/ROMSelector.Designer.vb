<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROMSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ROMSelector))
        Me.romselLB = New System.Windows.Forms.ListBox()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.OKbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'romselLB
        '
        Me.romselLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.romselLB.FormattingEnabled = True
        Me.romselLB.Location = New System.Drawing.Point(12, 12)
        Me.romselLB.Name = "romselLB"
        Me.romselLB.ScrollAlwaysVisible = True
        Me.romselLB.Size = New System.Drawing.Size(358, 171)
        Me.romselLB.Sorted = True
        Me.romselLB.TabIndex = 0
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(295, 189)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelbtn.TabIndex = 1
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'OKbtn
        '
        Me.OKbtn.Location = New System.Drawing.Point(214, 189)
        Me.OKbtn.Name = "OKbtn"
        Me.OKbtn.Size = New System.Drawing.Size(75, 23)
        Me.OKbtn.TabIndex = 1
        Me.OKbtn.Text = "Start!"
        Me.OKbtn.UseVisualStyleBackColor = True
        '
        'ROMSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 217)
        Me.Controls.Add(Me.OKbtn)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.romselLB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ROMSelector"
        Me.Text = "Select the ROM you wish to start."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents romselLB As ListBox
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents OKbtn As Button
End Class
