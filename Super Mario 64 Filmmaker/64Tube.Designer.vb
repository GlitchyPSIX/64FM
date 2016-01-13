<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _64Tube
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
        Me.components = New System.ComponentModel.Container()
        Me.EmbeddedVideoPlayer = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.VideoHistory = New System.Windows.Forms.ListBox()
        Me.VideoPlayer = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.SuspendLayout()
        '
        'EmbeddedVideoPlayer
        '
        Me.EmbeddedVideoPlayer.Location = New System.Drawing.Point(13, 13)
        Me.EmbeddedVideoPlayer.NavigationInfo = Awesomium.Core.NavigationInfo.Normal
        Me.EmbeddedVideoPlayer.Size = New System.Drawing.Size(514, 390)
        Me.EmbeddedVideoPlayer.TabIndex = 0
        '
        'VideoHistory
        '
        Me.VideoHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoHistory.FormattingEnabled = True
        Me.VideoHistory.HorizontalScrollbar = True
        Me.VideoHistory.Items.AddRange(New Object() {"Deveyopers (<->) 2PGK-jEIQy4"})
        Me.VideoHistory.Location = New System.Drawing.Point(602, 0)
        Me.VideoHistory.Name = "VideoHistory"
        Me.VideoHistory.Size = New System.Drawing.Size(167, 472)
        Me.VideoHistory.TabIndex = 1
        '
        'VideoPlayer
        '
        Me.VideoPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VideoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayer.Size = New System.Drawing.Size(596, 470)
        Me.VideoPlayer.Source = New System.Uri("chrome:history", System.UriKind.Absolute)
        Me.VideoPlayer.TabIndex = 0
        '
        '_64Tube
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 471)
        Me.Controls.Add(Me.VideoPlayer)
        Me.Controls.Add(Me.VideoHistory)
        Me.Name = "_64Tube"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "_64Tube"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents EmbeddedVideoPlayer As Awesomium.Windows.Forms.WebControl
    Friend WithEvents VideoHistory As System.Windows.Forms.ListBox
    Friend WithEvents VideoPlayer As Awesomium.Windows.Forms.WebControl
End Class
