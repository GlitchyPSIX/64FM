<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftwareForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoftwareForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OKbtn = New System.Windows.Forms.Button()
        Me.VideoEditortb = New System.Windows.Forms.TextBox()
        Me.Recordertb = New System.Windows.Forms.TextBox()
        Me.AudioEditortb = New System.Windows.Forms.TextBox()
        Me.SearchVideoEditorbtn = New System.Windows.Forms.Button()
        Me.SearchRecorderbtn = New System.Windows.Forms.Button()
        Me.AudioEditorSearchbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.IllegalStuff = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Video Editor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recorder:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Audio Editor:"
        '
        'OKbtn
        '
        Me.OKbtn.Location = New System.Drawing.Point(242, 122)
        Me.OKbtn.Name = "OKbtn"
        Me.OKbtn.Size = New System.Drawing.Size(75, 23)
        Me.OKbtn.TabIndex = 8
        Me.OKbtn.Text = "OK"
        Me.OKbtn.UseVisualStyleBackColor = True
        '
        'VideoEditortb
        '
        Me.VideoEditortb.Location = New System.Drawing.Point(100, 29)
        Me.VideoEditortb.Name = "VideoEditortb"
        Me.VideoEditortb.Size = New System.Drawing.Size(300, 20)
        Me.VideoEditortb.TabIndex = 1
        '
        'Recordertb
        '
        Me.Recordertb.Location = New System.Drawing.Point(100, 58)
        Me.Recordertb.Name = "Recordertb"
        Me.Recordertb.Size = New System.Drawing.Size(300, 20)
        Me.Recordertb.TabIndex = 3
        '
        'AudioEditortb
        '
        Me.AudioEditortb.Location = New System.Drawing.Point(100, 86)
        Me.AudioEditortb.Name = "AudioEditortb"
        Me.AudioEditortb.Size = New System.Drawing.Size(300, 20)
        Me.AudioEditortb.TabIndex = 5
        '
        'SearchVideoEditorbtn
        '
        Me.SearchVideoEditorbtn.Location = New System.Drawing.Point(406, 29)
        Me.SearchVideoEditorbtn.Name = "SearchVideoEditorbtn"
        Me.SearchVideoEditorbtn.Size = New System.Drawing.Size(29, 20)
        Me.SearchVideoEditorbtn.TabIndex = 2
        Me.SearchVideoEditorbtn.Text = "..."
        Me.SearchVideoEditorbtn.UseVisualStyleBackColor = True
        '
        'SearchRecorderbtn
        '
        Me.SearchRecorderbtn.Location = New System.Drawing.Point(406, 57)
        Me.SearchRecorderbtn.Name = "SearchRecorderbtn"
        Me.SearchRecorderbtn.Size = New System.Drawing.Size(29, 21)
        Me.SearchRecorderbtn.TabIndex = 4
        Me.SearchRecorderbtn.Text = "..."
        Me.SearchRecorderbtn.UseVisualStyleBackColor = True
        '
        'AudioEditorSearchbtn
        '
        Me.AudioEditorSearchbtn.Location = New System.Drawing.Point(406, 86)
        Me.AudioEditorSearchbtn.Name = "AudioEditorSearchbtn"
        Me.AudioEditorSearchbtn.Size = New System.Drawing.Size(29, 20)
        Me.AudioEditorSearchbtn.TabIndex = 6
        Me.AudioEditorSearchbtn.Text = "..."
        Me.AudioEditorSearchbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Recommendation:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(540, 90)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(48, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Audacity"
        '
        'IllegalStuff
        '
        Me.IllegalStuff.AutoSize = True
        Me.IllegalStuff.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IllegalStuff.Location = New System.Drawing.Point(444, 41)
        Me.IllegalStuff.Name = "IllegalStuff"
        Me.IllegalStuff.Size = New System.Drawing.Size(141, 31)
        Me.IllegalStuff.TabIndex = 9
        Me.IllegalStuff.TabStop = True
        Me.IllegalStuff.Text = "Check 'em"
        '
        'frmSoftwareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(596, 157)
        Me.Controls.Add(Me.IllegalStuff)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AudioEditorSearchbtn)
        Me.Controls.Add(Me.SearchRecorderbtn)
        Me.Controls.Add(Me.SearchVideoEditorbtn)
        Me.Controls.Add(Me.AudioEditortb)
        Me.Controls.Add(Me.Recordertb)
        Me.Controls.Add(Me.VideoEditortb)
        Me.Controls.Add(Me.OKbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSoftwareForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editor Software"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OKbtn As Button
    Friend WithEvents VideoEditortb As TextBox
    Friend WithEvents Recordertb As TextBox
    Friend WithEvents AudioEditortb As TextBox
    Friend WithEvents SearchVideoEditorbtn As Button
    Friend WithEvents SearchRecorderbtn As Button
    Friend WithEvents AudioEditorSearchbtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents IllegalStuff As LinkLabel
End Class
