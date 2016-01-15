<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _64Player
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
        Me.TrackImage = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.TrackImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackImage
        '
        Me.TrackImage.BackColor = System.Drawing.Color.Black
        Me.TrackImage.Image = Global.Filmmaker.My.Resources.Resources._64player
        Me.TrackImage.Location = New System.Drawing.Point(232, 12)
        Me.TrackImage.Name = "TrackImage"
        Me.TrackImage.Size = New System.Drawing.Size(430, 291)
        Me.TrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TrackImage.TabIndex = 2
        Me.TrackImage.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 195)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 147)
        Me.ListBox1.TabIndex = 3
        '
        '_64Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 357)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TrackImage)
        Me.Name = "_64Player"
        Me.Text = "64Player - (not loaded)"
        CType(Me.TrackImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TrackImage As PictureBox
    Friend WithEvents ListBox1 As ListBox
End Class
