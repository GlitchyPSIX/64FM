<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class webCheatSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(webCheatSearch))
        Me.optionsStrip = New System.Windows.Forms.ToolStrip()
        Me.closeStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cheatsBrowser = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optionsStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'optionsStrip
        '
        Me.optionsStrip.BackColor = System.Drawing.Color.Black
        Me.optionsStrip.CanOverflow = False
        Me.optionsStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.optionsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closeStripButton, Me.ToolStripButton1})
        Me.optionsStrip.Location = New System.Drawing.Point(0, 0)
        Me.optionsStrip.Name = "optionsStrip"
        Me.optionsStrip.Size = New System.Drawing.Size(789, 25)
        Me.optionsStrip.TabIndex = 13
        Me.optionsStrip.Text = "ToolStrip1"
        '
        'closeStripButton
        '
        Me.closeStripButton.Name = "closeStripButton"
        Me.closeStripButton.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripButton1.Text = "Back to Cheats Home Page"
        '
        'cheatsBrowser
        '
        Me.cheatsBrowser.Dock = System.Windows.Forms.DockStyle.Top
        Me.cheatsBrowser.Location = New System.Drawing.Point(0, 25)
        Me.cheatsBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cheatsBrowser.Name = "cheatsBrowser"
        Me.cheatsBrowser.Size = New System.Drawing.Size(789, 507)
        Me.cheatsBrowser.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(227, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Only use NTSC-region cheats. Website is owned by James Stuart."
        '
        'webCheatSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 562)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cheatsBrowser)
        Me.Controls.Add(Me.optionsStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "webCheatSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Search"
        Me.optionsStrip.ResumeLayout(False)
        Me.optionsStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optionsStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents closeStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cheatsBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
