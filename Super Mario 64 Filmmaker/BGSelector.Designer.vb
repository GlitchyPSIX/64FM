<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BGSelector
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("In progress.")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BGSelector))
        Me.whitenoise = New System.Windows.Forms.PictureBox()
        Me.darknoise = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomList_lw = New System.Windows.Forms.ListView()
        Me.OK_btn = New System.Windows.Forms.Button()
        CType(Me.whitenoise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.darknoise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'whitenoise
        '
        Me.whitenoise.Image = Global.Filmmaker.My.Resources.Resources.white_noise
        Me.whitenoise.Location = New System.Drawing.Point(11, 11)
        Me.whitenoise.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.whitenoise.Name = "whitenoise"
        Me.whitenoise.Size = New System.Drawing.Size(115, 115)
        Me.whitenoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.whitenoise.TabIndex = 0
        Me.whitenoise.TabStop = False
        '
        'darknoise
        '
        Me.darknoise.Image = Global.Filmmaker.My.Resources.Resources.dark_noise
        Me.darknoise.Location = New System.Drawing.Point(11, 163)
        Me.darknoise.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.darknoise.Name = "darknoise"
        Me.darknoise.Size = New System.Drawing.Size(115, 115)
        Me.darknoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.darknoise.TabIndex = 0
        Me.darknoise.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "White Noise"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Custom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 281)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dark Noise"
        '
        'CustomList_lw
        '
        Me.CustomList_lw.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.CustomList_lw.Location = New System.Drawing.Point(149, 33)
        Me.CustomList_lw.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CustomList_lw.Name = "CustomList_lw"
        Me.CustomList_lw.Size = New System.Drawing.Size(266, 245)
        Me.CustomList_lw.TabIndex = 6
        Me.CustomList_lw.UseCompatibleStateImageBehavior = False
        Me.CustomList_lw.View = System.Windows.Forms.View.Tile
        '
        'OK_btn
        '
        Me.OK_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_btn.Location = New System.Drawing.Point(149, 281)
        Me.OK_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.OK_btn.Name = "OK_btn"
        Me.OK_btn.Size = New System.Drawing.Size(266, 27)
        Me.OK_btn.TabIndex = 7
        Me.OK_btn.Text = "OK"
        Me.OK_btn.UseVisualStyleBackColor = True
        '
        'BGSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(434, 333)
        Me.Controls.Add(Me.OK_btn)
        Me.Controls.Add(Me.CustomList_lw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.darknoise)
        Me.Controls.Add(Me.whitenoise)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Name = "BGSelector"
        Me.Text = "Select your background"
        CType(Me.whitenoise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.darknoise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents whitenoise As System.Windows.Forms.PictureBox
    Friend WithEvents darknoise As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CustomList_lw As ListView
    Friend WithEvents OK_btn As Button
End Class
