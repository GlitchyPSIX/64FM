<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cheatEssentials
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cheatEssentials))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GPSIcheats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "What cheats do you need now?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GPSIcheats
        '
        Me.GPSIcheats.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GPSIcheats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GPSIcheats.ForeColor = System.Drawing.Color.Black
        Me.GPSIcheats.Location = New System.Drawing.Point(104, 79)
        Me.GPSIcheats.Name = "GPSIcheats"
        Me.GPSIcheats.Size = New System.Drawing.Size(194, 25)
        Me.GPSIcheats.TabIndex = 4
        Me.GPSIcheats.Text = "GlitchyPSIX's Machinima Essentials"
        Me.GPSIcheats.UseVisualStyleBackColor = False
        '
        'cheatEssentials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(400, 178)
        Me.Controls.Add(Me.GPSIcheats)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cheatEssentials"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheat Essentials Selector"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GPSIcheats As System.Windows.Forms.Button
End Class
