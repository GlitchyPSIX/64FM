<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class animCodeGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(animCodeGen))
        Me.codeList = New System.Windows.Forms.ListBox()
        Me.checkForXYC = New System.Windows.Forms.Timer(Me.components)
        Me.cheatBox = New System.Windows.Forms.RichTextBox()
        Me.copyCode = New System.Windows.Forms.Button()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.IntegrityLabel = New System.Windows.Forms.Label()
        Me.IntegrityImage = New System.Windows.Forms.PictureBox()
        Me.HoverCheck = New System.Windows.Forms.CheckBox()
        Me.AnimCodeGenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.IntegrityImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimCodeGenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'codeList
        '
        Me.codeList.Font = New System.Drawing.Font("Roboto Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeList.FormattingEnabled = True
        Me.codeList.ItemHeight = 18
        Me.codeList.Items.AddRange(New Object() {"Climb up ledge", "Thrown from painting", "Blown by wind", "Dying on ground", "Backflip", "Climbing up tree movement", "In tree", "Swinging from tree", "Go back into tree", "Jump out of tree from hand stand", "Hand stand in tree", "Go back from hand stand", "In tree?", "Standing straight with arms out", "Skid on ground", "Skid on ground, go back to normal", "Crouching", "Return from long jump", "Forward long jump", "Backward long jump", "Launched from cannon", "Walk while holding small object", "Run while holding small object?", "Walk while holding small object?", "Cold, rubbing hands together", "Cold (part 2)", "Cold (part 3)", "Climb on ledge", "Waving", "Look upward", "Look upward then downward", "Summon Peach", "Lift hand", "Take cap off", "Walking at end looking backward to sky", "Look backward then run (at end)", "Lift hand (slower?)", "Fly at end", "Peace sign", "Get out of sand/snow", "Jumping from lava", "Flying (wing cap)", "Hang onto monkey-bar", "Thrown onto ground", "Thrown forward", "Dying while on stomach", "Dying in gas", "Coughing in gas", "Throw key in air catch it", "Normal death", "Hang from ledge", "Lift up on ledge quickly", "Wobble while on monkey-bars", "Put hat on", "Putting star under hat", "Putting star under hat (part 2)", "Head stuck under sand", "Sliding on bottom", "Triple jump then ground-pound", "Ground-pound", "Ground-pound (part 2)", "Bottom stuck in snow / sand", "Standing and holding small object", "Jump with small object (wearing wing cap)", "Pick up small object", "Coming down with small object (wearing wing cap)", "Slide then fall with small object", "Sliding with small object", "Get up from ground with small object", "On Koopa shell", "Walking (not running)", "Side flip?", "Jump while riding shell", "Landing from double jump", "Mid-air part of double jump", "Normal jump", "Land from normal jump", "Kick in mid-air", "Double jump", "Triple jump", "Throw object", "Slide kick", "Fall from height", "Fall hard from double jump", "Picked up by enemy", "Pick up large object", "Get up after being thrown", "Launch into flying position", "Move on monkey-bars", "Move on monkey-bars (part 2)", "Missing cap after getting star", "Open door and walk in", "Exit door", "Open door with key", "Unknown (looks like Mario is bowing)", "Similar to avobe", "Animates both avobe", "Unknown (Mario moves arm)", "Kick in mid-air and land", "Unknown similar to 04FC14C punch left?", "Punch left (part 2)", "Punch right", "Punch left (part 3)", "Pick up small object and stand", "Push against something while walking", "Jump on Koopa shell (part 2)", "Set small object down", "Special triple jump", "Similar to avobe (backward)", "Do a trip and go back to crouching", "Running", "Running (2)", "Get bumped by enemy", "Get bumped by enemy (behind)", "Dying in sand", "Stuck, looking around", "Walking through sand", "Dying from shock", "Getting shocked", "Bump into wall", "Fall forward", "Holding large object", "Against wall", "Sidestepping against wall", "Sidestepping against wall(2)", "Sleepy (1)", "Sleepy (2)", "Sleepy (3)", "Sleepy (4)", "Sleeping", "Lay down", "Laying and sleeping", "Belly flop", "On belly", "Get up after bumping into wall", "Get up after belly flop holding small object", "Beginning of side kick", "Get up from slide kick go back to crouching", "Sliding with hands back", "Get up and stand", "Go into falling from height position", "Slide with hands back animation", "Tiptoe", "Land from spin jump", "Spin jump", "Start spin jump", "Come up from crouch", "Start crouch", "Crouching", "Crawling", "Come up from crawling", "In crawling position", "Opening door with star", "Open door with star end, walk in", "Hit by something", "Kick legs while holding object", "Holding object", "Swimming while holding object", "Stop while holding object", "Let go of object", "Holding object", "Drowning", "Die, slump over", "Die, slump over?", "Get hit from behind", "Walking (metal mario)", "Single stroke from tapping A", "Stop swimming", "Strokes from holding A", "Stop in water", "Grab object", "Press B", "Jump (metal mario)", "Throw object", "Floating", "Get star", "Get star (part 2)", "Grab Bowser's tail", "Holding Bowser", "Let go of Bowser", "Holding Bowser animation", "Throw large object", "Low energy", "Walking with large object", "Skid on ground start", "Switch direction quickly", "Land from side flip?", "Side flip", "Land from back flip / triple jump", "Triple jump", "Reading sign", "Standing normal (part 1)", "Standing normal (part 2)", "Standing normal (part 3)", "Hanging on monkey-bar", "Hanging on monkey-bar, look around", "Get up after sleeping (sitting)", "Get up after sleeping (laying)", "Begin walking", "Wall kick/jump from tree", "Hang onto pole/tree", "Get star", "End get star", "Triple jump and start flying", "Start special triple jump"})
        Me.codeList.Location = New System.Drawing.Point(12, 11)
        Me.codeList.Name = "codeList"
        Me.codeList.Size = New System.Drawing.Size(253, 382)
        Me.codeList.TabIndex = 0
        '
        'checkForXYC
        '
        '
        'cheatBox
        '
        Me.cheatBox.Font = New System.Drawing.Font("Roboto Condensed Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheatBox.Location = New System.Drawing.Point(271, 208)
        Me.cheatBox.Name = "cheatBox"
        Me.cheatBox.ReadOnly = True
        Me.cheatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.cheatBox.ShortcutsEnabled = False
        Me.cheatBox.Size = New System.Drawing.Size(176, 83)
        Me.cheatBox.TabIndex = 1
        Me.cheatBox.Text = ""
        Me.cheatBox.WordWrap = False
        '
        'copyCode
        '
        Me.copyCode.Location = New System.Drawing.Point(361, 362)
        Me.copyCode.Name = "copyCode"
        Me.copyCode.Size = New System.Drawing.Size(86, 31)
        Me.copyCode.TabIndex = 2
        Me.copyCode.Text = "Copy Code"
        Me.copyCode.UseVisualStyleBackColor = True
        '
        'closeForm
        '
        Me.closeForm.Location = New System.Drawing.Point(271, 362)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(84, 31)
        Me.closeForm.TabIndex = 2
        Me.closeForm.Text = "Close"
        Me.closeForm.UseVisualStyleBackColor = True
        '
        'IntegrityLabel
        '
        Me.IntegrityLabel.Font = New System.Drawing.Font("Roboto Condensed Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntegrityLabel.Location = New System.Drawing.Point(271, 65)
        Me.IntegrityLabel.Name = "IntegrityLabel"
        Me.IntegrityLabel.Size = New System.Drawing.Size(176, 140)
        Me.IntegrityLabel.TabIndex = 3
        Me.IntegrityLabel.Text = "Please select an Animation."
        Me.IntegrityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IntegrityImage
        '
        Me.IntegrityImage.Location = New System.Drawing.Point(336, 12)
        Me.IntegrityImage.Name = "IntegrityImage"
        Me.IntegrityImage.Size = New System.Drawing.Size(45, 50)
        Me.IntegrityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IntegrityImage.TabIndex = 4
        Me.IntegrityImage.TabStop = False
        '
        'HoverCheck
        '
        Me.HoverCheck.Font = New System.Drawing.Font("Roboto Condensed Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoverCheck.Location = New System.Drawing.Point(271, 297)
        Me.HoverCheck.Name = "HoverCheck"
        Me.HoverCheck.Size = New System.Drawing.Size(176, 37)
        Me.HoverCheck.TabIndex = 5
        Me.HoverCheck.Text = "Add Hover Cheat (Reselect animation to apply)"
        Me.HoverCheck.UseVisualStyleBackColor = True
        '
        'AnimCodeGenBindingSource
        '
        Me.AnimCodeGenBindingSource.DataSource = GetType(Filmmaker.animCodeGen)
        '
        'animCodeGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(459, 415)
        Me.Controls.Add(Me.HoverCheck)
        Me.Controls.Add(Me.IntegrityImage)
        Me.Controls.Add(Me.IntegrityLabel)
        Me.Controls.Add(Me.closeForm)
        Me.Controls.Add(Me.copyCode)
        Me.Controls.Add(Me.cheatBox)
        Me.Controls.Add(Me.codeList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "animCodeGen"
        Me.Text = "Animation Code Generator - SM64FM"
        Me.TransparencyKey = System.Drawing.Color.Plum
        CType(Me.IntegrityImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimCodeGenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents codeList As System.Windows.Forms.ListBox
    Friend WithEvents checkForXYC As System.Windows.Forms.Timer
    Friend WithEvents cheatBox As System.Windows.Forms.RichTextBox
    Friend WithEvents copyCode As System.Windows.Forms.Button
    Friend WithEvents closeForm As System.Windows.Forms.Button
    Friend WithEvents AnimCodeGenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IntegrityLabel As System.Windows.Forms.Label
    Friend WithEvents IntegrityImage As System.Windows.Forms.PictureBox
    Friend WithEvents HoverCheck As System.Windows.Forms.CheckBox
End Class
