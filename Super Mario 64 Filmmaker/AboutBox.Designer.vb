<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AssignedTo = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.MemoryNumber = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Filmmaker.My.Resources.Resources.SM64FM_Logo
        Me.PictureBox2.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(529, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'AssignedTo
        '
        Me.AssignedTo.Location = New System.Drawing.Point(6, 162)
        Me.AssignedTo.Name = "AssignedTo"
        Me.AssignedTo.Size = New System.Drawing.Size(531, 29)
        Me.AssignedTo.TabIndex = 12
        Me.AssignedTo.Text = "Label1"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(237, 418)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(63, 23)
        Me.OKButton.TabIndex = 13
        Me.OKButton.Text = "&OK"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(9, 230)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.Size = New System.Drawing.Size(531, 182)
        Me.TextBoxDescription.TabIndex = 14
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'MemoryNumber
        '
        Me.MemoryNumber.AutoSize = True
        Me.MemoryNumber.Location = New System.Drawing.Point(6, 194)
        Me.MemoryNumber.Name = "MemoryNumber"
        Me.MemoryNumber.Size = New System.Drawing.Size(39, 13)
        Me.MemoryNumber.TabIndex = 15
        Me.MemoryNumber.Text = "Label1"
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 453)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.AssignedTo)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.MemoryNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About 64Filmmaker..."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents AssignedTo As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents MemoryNumber As System.Windows.Forms.Label

End Class
