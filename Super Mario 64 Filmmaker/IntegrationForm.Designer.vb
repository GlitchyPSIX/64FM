<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntegrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IntegrationForm))
        Me.LogoPB = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Loginlb = New System.Windows.Forms.Label()
        Me.Usrnmlb = New System.Windows.Forms.Label()
        Me.Pswdlb = New System.Windows.Forms.Label()
        Me.Usernmtb = New System.Windows.Forms.TextBox()
        Me.Pswdtb = New System.Windows.Forms.TextBox()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Newaccbtn = New System.Windows.Forms.Button()
        Me.forgotpassbtn = New System.Windows.Forms.Button()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPB
        '
        Me.LogoPB.BackColor = System.Drawing.Color.Transparent
        Me.LogoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPB.Image = Global.Filmmaker.My.Resources.Resources._64networklogo
        Me.LogoPB.Location = New System.Drawing.Point(100, 50)
        Me.LogoPB.Name = "LogoPB"
        Me.LogoPB.Size = New System.Drawing.Size(120, 120)
        Me.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPB.TabIndex = 0
        Me.LogoPB.TabStop = False
        Me.LogoPB.WaitOnLoad = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.forgotpassbtn)
        Me.Panel1.Controls.Add(Me.Newaccbtn)
        Me.Panel1.Controls.Add(Me.Loginbtn)
        Me.Panel1.Controls.Add(Me.Pswdtb)
        Me.Panel1.Controls.Add(Me.Usernmtb)
        Me.Panel1.Controls.Add(Me.Pswdlb)
        Me.Panel1.Controls.Add(Me.Usrnmlb)
        Me.Panel1.Controls.Add(Me.Loginlb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 445)
        Me.Panel1.TabIndex = 1
        '
        'Loginlb
        '
        Me.Loginlb.AutoSize = True
        Me.Loginlb.BackColor = System.Drawing.Color.Transparent
        Me.Loginlb.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginlb.ForeColor = System.Drawing.Color.White
        Me.Loginlb.Location = New System.Drawing.Point(29, 60)
        Me.Loginlb.Name = "Loginlb"
        Me.Loginlb.Size = New System.Drawing.Size(262, 80)
        Me.Loginlb.TabIndex = 0
        Me.Loginlb.Text = "Log in with your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "64Network account."
        Me.Loginlb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Usrnmlb
        '
        Me.Usrnmlb.AutoSize = True
        Me.Usrnmlb.BackColor = System.Drawing.Color.Transparent
        Me.Usrnmlb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usrnmlb.ForeColor = System.Drawing.Color.White
        Me.Usrnmlb.Location = New System.Drawing.Point(115, 156)
        Me.Usrnmlb.Name = "Usrnmlb"
        Me.Usrnmlb.Size = New System.Drawing.Size(91, 15)
        Me.Usrnmlb.TabIndex = 1
        Me.Usrnmlb.Text = "Username/Mail:"
        '
        'Pswdlb
        '
        Me.Pswdlb.AutoSize = True
        Me.Pswdlb.BackColor = System.Drawing.Color.Transparent
        Me.Pswdlb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pswdlb.ForeColor = System.Drawing.Color.White
        Me.Pswdlb.Location = New System.Drawing.Point(133, 206)
        Me.Pswdlb.Name = "Pswdlb"
        Me.Pswdlb.Size = New System.Drawing.Size(60, 15)
        Me.Pswdlb.TabIndex = 1
        Me.Pswdlb.Text = "Password:"
        '
        'Usernmtb
        '
        Me.Usernmtb.Location = New System.Drawing.Point(24, 174)
        Me.Usernmtb.Name = "Usernmtb"
        Me.Usernmtb.Size = New System.Drawing.Size(276, 20)
        Me.Usernmtb.TabIndex = 2
        '
        'Pswdtb
        '
        Me.Pswdtb.Location = New System.Drawing.Point(24, 224)
        Me.Pswdtb.Name = "Pswdtb"
        Me.Pswdtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9899)
        Me.Pswdtb.Size = New System.Drawing.Size(276, 20)
        Me.Pswdtb.TabIndex = 2
        '
        'Loginbtn
        '
        Me.Loginbtn.Location = New System.Drawing.Point(24, 260)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(88, 23)
        Me.Loginbtn.TabIndex = 3
        Me.Loginbtn.Text = "Login!"
        Me.Loginbtn.UseVisualStyleBackColor = True
        '
        'Newaccbtn
        '
        Me.Newaccbtn.Location = New System.Drawing.Point(212, 260)
        Me.Newaccbtn.Name = "Newaccbtn"
        Me.Newaccbtn.Size = New System.Drawing.Size(88, 23)
        Me.Newaccbtn.TabIndex = 3
        Me.Newaccbtn.Text = "Register!"
        Me.Newaccbtn.UseVisualStyleBackColor = True
        '
        'forgotpassbtn
        '
        Me.forgotpassbtn.Location = New System.Drawing.Point(118, 260)
        Me.forgotpassbtn.Name = "forgotpassbtn"
        Me.forgotpassbtn.Size = New System.Drawing.Size(88, 23)
        Me.forgotpassbtn.TabIndex = 3
        Me.forgotpassbtn.Text = "Forgot pass?"
        Me.forgotpassbtn.UseVisualStyleBackColor = True
        '
        'IntegrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(317, 558)
        Me.Controls.Add(Me.LogoPB)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IntegrationForm"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Log in to 64Network"
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoPB As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Loginlb As Label
    Friend WithEvents Pswdtb As TextBox
    Friend WithEvents Usernmtb As TextBox
    Friend WithEvents Pswdlb As Label
    Friend WithEvents Usrnmlb As Label
    Friend WithEvents forgotpassbtn As Button
    Friend WithEvents Newaccbtn As Button
    Friend WithEvents Loginbtn As Button
End Class
