<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddonSettingsForm
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sample Item", "DATA", "HERE"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddonSettingsForm))
        Me.AddAddon_pb = New System.Windows.Forms.PictureBox()
        Me.RemAddon_pb = New System.Windows.Forms.PictureBox()
        Me.ConfigureAddon_pb = New System.Windows.Forms.PictureBox()
        Me.AddonListView_lv = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EntryPointColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GetAddons_pb = New System.Windows.Forms.PictureBox()
        Me.UpdateList_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AddAddon_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemAddon_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigureAddon_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetAddons_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddAddon_pb
        '
        Me.AddAddon_pb.BackColor = System.Drawing.Color.Transparent
        Me.AddAddon_pb.Image = Global.Filmmaker.My.Resources.Resources.ic_addadd
        Me.AddAddon_pb.Location = New System.Drawing.Point(12, 12)
        Me.AddAddon_pb.Name = "AddAddon_pb"
        Me.AddAddon_pb.Size = New System.Drawing.Size(151, 160)
        Me.AddAddon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddAddon_pb.TabIndex = 30
        Me.AddAddon_pb.TabStop = False
        '
        'RemAddon_pb
        '
        Me.RemAddon_pb.BackColor = System.Drawing.Color.Transparent
        Me.RemAddon_pb.Image = Global.Filmmaker.My.Resources.Resources.ic_deladd
        Me.RemAddon_pb.Location = New System.Drawing.Point(12, 181)
        Me.RemAddon_pb.Name = "RemAddon_pb"
        Me.RemAddon_pb.Size = New System.Drawing.Size(151, 160)
        Me.RemAddon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RemAddon_pb.TabIndex = 30
        Me.RemAddon_pb.TabStop = False
        '
        'ConfigureAddon_pb
        '
        Me.ConfigureAddon_pb.BackColor = System.Drawing.Color.Transparent
        Me.ConfigureAddon_pb.Image = Global.Filmmaker.My.Resources.Resources.ic_confadd
        Me.ConfigureAddon_pb.Location = New System.Drawing.Point(169, 12)
        Me.ConfigureAddon_pb.Name = "ConfigureAddon_pb"
        Me.ConfigureAddon_pb.Size = New System.Drawing.Size(151, 160)
        Me.ConfigureAddon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ConfigureAddon_pb.TabIndex = 30
        Me.ConfigureAddon_pb.TabStop = False
        '
        'AddonListView_lv
        '
        Me.AddonListView_lv.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.AddonListView_lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddonListView_lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.EntryPointColumn})
        ListViewItem1.Tag = "EEE"
        ListViewItem1.UseItemStyleForSubItems = False
        Me.AddonListView_lv.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.AddonListView_lv.Location = New System.Drawing.Point(326, 35)
        Me.AddonListView_lv.MultiSelect = False
        Me.AddonListView_lv.Name = "AddonListView_lv"
        Me.AddonListView_lv.ShowItemToolTips = True
        Me.AddonListView_lv.Size = New System.Drawing.Size(359, 277)
        Me.AddonListView_lv.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AddonListView_lv.TabIndex = 31
        Me.AddonListView_lv.UseCompatibleStateImageBehavior = False
        Me.AddonListView_lv.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 111
        '
        'TypeColumn
        '
        Me.TypeColumn.Tag = "Dayeta"
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 81
        '
        'EntryPointColumn
        '
        Me.EntryPointColumn.Text = "Entry Point"
        Me.EntryPointColumn.Width = 156
        '
        'GetAddons_pb
        '
        Me.GetAddons_pb.BackColor = System.Drawing.Color.Transparent
        Me.GetAddons_pb.Image = Global.Filmmaker.My.Resources.Resources.ic_getadd
        Me.GetAddons_pb.Location = New System.Drawing.Point(169, 181)
        Me.GetAddons_pb.Name = "GetAddons_pb"
        Me.GetAddons_pb.Size = New System.Drawing.Size(151, 160)
        Me.GetAddons_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GetAddons_pb.TabIndex = 30
        Me.GetAddons_pb.TabStop = False
        '
        'UpdateList_btn
        '
        Me.UpdateList_btn.Location = New System.Drawing.Point(326, 318)
        Me.UpdateList_btn.Name = "UpdateList_btn"
        Me.UpdateList_btn.Size = New System.Drawing.Size(359, 23)
        Me.UpdateList_btn.TabIndex = 32
        Me.UpdateList_btn.Text = "Update List"
        Me.UpdateList_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "The buttons aren't working yet, it's part of the UI update."
        '
        'AddonSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 353)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateList_btn)
        Me.Controls.Add(Me.AddonListView_lv)
        Me.Controls.Add(Me.GetAddons_pb)
        Me.Controls.Add(Me.ConfigureAddon_pb)
        Me.Controls.Add(Me.RemAddon_pb)
        Me.Controls.Add(Me.AddAddon_pb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddonSettingsForm"
        Me.Text = "Addon Dashboard"
        CType(Me.AddAddon_pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemAddon_pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigureAddon_pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetAddons_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddAddon_pb As PictureBox
    Friend WithEvents RemAddon_pb As PictureBox
    Friend WithEvents ConfigureAddon_pb As PictureBox
    Friend WithEvents AddonListView_lv As ListView
    Friend WithEvents GetAddons_pb As PictureBox
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents TypeColumn As ColumnHeader
    Friend WithEvents EntryPointColumn As ColumnHeader
    Friend WithEvents UpdateList_btn As Button
    Friend WithEvents Label1 As Label
End Class
