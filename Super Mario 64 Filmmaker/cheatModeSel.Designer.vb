<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cheatModeSel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cheatModeSel))
        Me.closeStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EssentialsBtn = New System.Windows.Forms.PictureBox()
        Me.WebBtn = New System.Windows.Forms.PictureBox()
        CType(Me.EssentialsBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeStripButton
        '
        Me.closeStripButton.Name = "closeStripButton"
        Me.closeStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'EssentialsBtn
        '
        Me.EssentialsBtn.Image = Global.Filmmaker.My.Resources.Resources.CHT
        Me.EssentialsBtn.Location = New System.Drawing.Point(50, 43)
        Me.EssentialsBtn.Name = "EssentialsBtn"
        Me.EssentialsBtn.Size = New System.Drawing.Size(153, 149)
        Me.EssentialsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EssentialsBtn.TabIndex = 0
        Me.EssentialsBtn.TabStop = False
        '
        'WebBtn
        '
        Me.WebBtn.Image = Global.Filmmaker.My.Resources.Resources.EYE
        Me.WebBtn.Location = New System.Drawing.Point(243, 43)
        Me.WebBtn.Name = "WebBtn"
        Me.WebBtn.Size = New System.Drawing.Size(153, 149)
        Me.WebBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WebBtn.TabIndex = 0
        Me.WebBtn.TabStop = False
        '
        'cheatModeSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(451, 273)
        Me.Controls.Add(Me.WebBtn)
        Me.Controls.Add(Me.EssentialsBtn)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cheatModeSel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select What to do..."
        CType(Me.EssentialsBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closeStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EssentialsBtn As System.Windows.Forms.PictureBox
    Friend WithEvents WebBtn As System.Windows.Forms.PictureBox
End Class
