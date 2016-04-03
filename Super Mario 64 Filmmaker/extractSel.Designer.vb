<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extractSel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extractSel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowPath = New System.Windows.Forms.Button()
        Me.btnVC = New System.Windows.Forms.Button()
        Me.btnWLD = New System.Windows.Forms.Button()
        Me.btnCHR = New System.Windows.Forms.Button()
        Me.btnSND = New System.Windows.Forms.Button()
        Me.btnSFX = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(318, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 76)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "These will be extracted to their own folder in the 64Filmmaker folder."
        '
        'btnShowPath
        '
        Me.btnShowPath.ForeColor = System.Drawing.Color.Black
        Me.btnShowPath.Location = New System.Drawing.Point(338, 81)
        Me.btnShowPath.Name = "btnShowPath"
        Me.btnShowPath.Size = New System.Drawing.Size(114, 34)
        Me.btnShowPath.TabIndex = 20
        Me.btnShowPath.Text = "Go there!"
        Me.btnShowPath.UseVisualStyleBackColor = True
        '
        'btnVC
        '
        Me.btnVC.BackColor = System.Drawing.Color.Transparent
        Me.btnVC.BackgroundImage = Global.Filmmaker.My.Resources.Resources.VFX
        Me.btnVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVC.Location = New System.Drawing.Point(318, 194)
        Me.btnVC.Name = "btnVC"
        Me.btnVC.Size = New System.Drawing.Size(155, 150)
        Me.btnVC.TabIndex = 18
        Me.btnVC.UseVisualStyleBackColor = False
        '
        'btnWLD
        '
        Me.btnWLD.BackColor = System.Drawing.Color.Transparent
        Me.btnWLD.BackgroundImage = Global.Filmmaker.My.Resources.Resources.CHK
        Me.btnWLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWLD.Location = New System.Drawing.Point(164, 194)
        Me.btnWLD.Name = "btnWLD"
        Me.btnWLD.Size = New System.Drawing.Size(148, 149)
        Me.btnWLD.TabIndex = 17
        Me.btnWLD.UseVisualStyleBackColor = False
        '
        'btnCHR
        '
        Me.btnCHR.BackColor = System.Drawing.Color.Transparent
        Me.btnCHR.BackgroundImage = Global.Filmmaker.My.Resources.Resources.CHK
        Me.btnCHR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCHR.Location = New System.Drawing.Point(12, 194)
        Me.btnCHR.Name = "btnCHR"
        Me.btnCHR.Size = New System.Drawing.Size(146, 149)
        Me.btnCHR.TabIndex = 16
        Me.btnCHR.UseVisualStyleBackColor = False
        '
        'btnSND
        '
        Me.btnSND.BackColor = System.Drawing.Color.Transparent
        Me.btnSND.BackgroundImage = Global.Filmmaker.My.Resources.Resources.OST
        Me.btnSND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSND.Location = New System.Drawing.Point(164, 39)
        Me.btnSND.Name = "btnSND"
        Me.btnSND.Size = New System.Drawing.Size(148, 149)
        Me.btnSND.TabIndex = 15
        Me.btnSND.UseVisualStyleBackColor = False
        '
        'btnSFX
        '
        Me.btnSFX.BackColor = System.Drawing.Color.Transparent
        Me.btnSFX.BackgroundImage = Global.Filmmaker.My.Resources.Resources.SFX
        Me.btnSFX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSFX.Location = New System.Drawing.Point(12, 39)
        Me.btnSFX.Name = "btnSFX"
        Me.btnSFX.Size = New System.Drawing.Size(146, 149)
        Me.btnSFX.TabIndex = 14
        Me.btnSFX.UseVisualStyleBackColor = False
        '
        'extractSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 356)
        Me.Controls.Add(Me.btnShowPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVC)
        Me.Controls.Add(Me.btnWLD)
        Me.Controls.Add(Me.btnCHR)
        Me.Controls.Add(Me.btnSND)
        Me.Controls.Add(Me.btnSFX)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "extractSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select what to extract"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSFX As System.Windows.Forms.Button
    Friend WithEvents btnSND As System.Windows.Forms.Button
    Friend WithEvents btnCHR As System.Windows.Forms.Button
    Friend WithEvents btnWLD As System.Windows.Forms.Button
    Friend WithEvents btnVC As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowPath As System.Windows.Forms.Button
End Class
