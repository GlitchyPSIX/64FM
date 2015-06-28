Public Class animCodeGen
    Private codeX As String
    Private codeY As String
    Private codeC As String
    Private codeHover As String
    Private Pt1 As String
    Private Pt2 As String
    Private Pt3 As String

    Public Sub New()
        InitializeComponent()
        Pt1 = "8106450A "
        Pt2 = "81064508 "
        Pt3 = "8106450E "
    End Sub

    Private Sub codeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codeList.SelectedIndexChanged
        If HoverCheck.Checked = True Then
            codeHover = "8033B220 0001"
        End If

        If codeList.SelectedItem = "Climb up ledge" Then
            codeX = "0000"
            codeY = "11D0"
            codeC = "0B40"
        End If

        If codeList.SelectedItem = "Thrown from painting" Then
            codeX = "0000"
            codeY = "11D0"
            codeC = "1ADC"
        End If

        If codeList.SelectedItem = "Blown by wind" Then
            codeX = "0000"
            codeY = "11E8"
            codeC = "1AC4"
        End If

        If codeList.SelectedItem = "Dying on ground" Then
            codeX = "0000"
            codeY = "2CAC"
            codeC = "1228"
        End If

        If codeList.SelectedItem = "Backflip" Then
            codeX = "0000"
            codeY = "3ED4"
            codeC = "09EC"
        End If

        If codeList.SelectedItem = "Climbing up tree movement" Then
            codeX = "0000"
            codeY = "48C8"
            codeC = "17B8"
        End If

        If codeList.SelectedItem = "In tree" Then
            codeX = "0000"
            codeY = "6078"
            codeC = "0490"
        End If

        If codeList.SelectedItem = "Swinging from tree" Then
            codeX = "0000"
            codeY = "6508"
            codeC = "06E8"
        End If

        If codeList.SelectedItem = "Go back into tree" Then
            codeX = "0000"
            codeY = "6520"
            codeC = "06D0"
        End If

        If codeList.SelectedItem = "Jump out of tree from hand stand" Then
            codeX = "0000"
            codeY = "78F0"
            codeC = "0B04"
        End If

        If codeList.SelectedItem = "Hand stand in tree" Then
            codeX = "0000"
            codeY = "83F4"
            codeC = "0670"
        End If

        If codeList.SelectedItem = "Go back from hand stand" Then
            codeX = "0000"
            codeY = "840C"
            codeC = "0658"
        End If

        If codeList.SelectedItem = "In tree?" Then
            codeX = "0000"
            codeY = "8A64"
            codeC = "0416"
        End If

        If codeList.SelectedItem = "Standing straight with arms out" Then
            codeX = "0000"
            codeY = "8E7C"
            codeC = "0164"
        End If

        If codeList.SelectedItem = "Skid on ground" Then
            codeX = "0000"
            codeY = "0FE0"
            codeC = "070A"
        End If

        If codeList.SelectedItem = "Skid on ground, go back to normal" Then   ' You need to readd the comma where appropiate. -Kenny
            codeX = "0000"
            codeY = "8FF8"
            codeC = "06F2"
        End If

        If codeList.SelectedItem = "Crouching" Then
            codeX = "0000"
            codeY = "96EC"
            codeC = "05AA"
        End If

        If codeList.SelectedItem = "Return from long jump" Then
            codeX = "0000"
            codeY = "9C98"
            codeC = "063A"
        End If

        If codeList.SelectedItem = "Forward long jump" Then
            codeX = "0000"
            codeY = "A2D4"
            codeC = "07A2"
        End If

        If codeList.SelectedItem = "Backward long jump" Then
            codeX = "0000"
            codeY = "AA78"
            codeC = "0562"
        End If

        If codeList.SelectedItem = "Launched from cannon" Then
            codeX = "0000"
            codeY = "AFDC"
            codeC = "04B6"
        End If

        If codeList.SelectedItem = "Walk while holding small object" Then
            codeX = "0000"
            codeY = "B494"
            codeC = "1278"
        End If

        If codeList.SelectedItem = "Run while holding small object?" Then
            codeX = "0000"
            codeY = "C70C"
            codeC = "0C92"
        End If

        If codeList.SelectedItem = "Walk while holding small object?" Then
            codeX = "0000"
            codeY = "D3A0"
            codeC = "1278"
        End If

        If codeList.SelectedItem = "Cold, rubbing hands together" Then
            codeX = "0000"
            codeY = "E618"
            codeC = "15FE"
        End If

        If codeList.SelectedItem = "Cold (part 2)" Then
            codeX = "0000"
            codeY = "FC18"
            codeC = "058E"
        End If

        If codeList.SelectedItem = "Cold (part 3)" Then
            codeX = "0001"
            codeY = "01A8"
            codeC = "0C3E"
        End If

        If codeList.SelectedItem = "Climb on ledge" Then
            codeX = "0001"
            codeY = "0DE8"
            codeC = "0420"
        End If

        If codeList.SelectedItem = "Waving" Then
            codeX = "0001"
            codeY = "1208"
            codeC = "0678"
        End If

        If codeList.SelectedItem = "Look upward" Then
            codeX = "0001"
            codeY = "1880"
            codeC = "070E"
        End If

        If codeList.SelectedItem = "Look upward then downward" Then
            codeX = "0001"
            codeY = "1F90"
            codeC = "0462"
        End If

        If codeList.SelectedItem = "Summon Peach" Then
            codeX = "0001"
            codeY = "23F4"
            codeC = "1CE8"
        End If

        If codeList.SelectedItem = "Lift hand" Then
            codeX = "0001"
            codeY = "40DC"
            codeC = "0B46"
        End If

        If codeList.SelectedItem = "Take cap off" Then
            codeX = "0001"
            codeY = "4C24"
            codeC = "07EA"
        End If

        If codeList.SelectedItem = "Walking at end looking backward to sky" Then 'You need to add the comma where appropriate.
            codeX = "0001"
            codeY = "5410"
            codeC = "212C"
        End If

        If codeList.SelectedItem = "Look backward then run (at end)" Then
            codeX = "0001"
            codeY = "753C"
            codeC = "25B4"
        End If

        If codeList.SelectedItem = "Lift hand (slower?)" Then
            codeX = "0001"
            codeY = "9AF0"
            codeC = "2066"
        End If

        If codeList.SelectedItem = "Fly at end" Then
            codeX = "0001"
            codeY = "BB58"
            codeC = "1DCC"
        End If

        If codeList.SelectedItem = "Peace sign" Then
            codeX = "0001"
            codeY = "D924"
            codeC = "2428"
        End If

        If codeList.SelectedItem = "Get out of sand/snow" Then
            codeX = "0001"
            codeY = "FD4C"
            codeC = "0506"
        End If

        If codeList.SelectedItem = "Jumping from lava" Then
            codeX = "0002"
            codeY = "0254"
            codeC = "035A"
        End If

        If codeList.SelectedItem = "Flying (wing cap)" Then
            codeX = "0002"
            codeY = "05B0"
            codeC = "05F8"
        End If

        If codeList.SelectedItem = "Hang onto monkey-bar" Then
            codeX = "0002"
            codeY = "0BA8"
            codeC = "0742"
        End If

        If codeList.SelectedItem = "Thrown onto ground" Then
            codeX = "0002"
            codeY = "12EC"
            codeC = "1720"
        End If

        If codeList.SelectedItem = "Thrown forward" Then
            codeX = "0002"
            codeY = "1304"
            codeC = "1708"
        End If

        If codeList.SelectedItem = "Dying while on stomach" Then
            codeX = "0002"
            codeY = "2A0C"
            codeC = "OCE8"
        End If

        If codeList.SelectedItem = "Dying in gas" Then
            codeX = "0002"
            codeY = "36F4"
            codeC = "1E10"
        End If

        If codeList.SelectedItem = "Coughing in gas" Then
            codeX = "0002"
            codeY = "5504"
            codeC = "1648"
        End If

        If codeList.SelectedItem = "Throw key in air catch it" Then
            codeX = "0002"
            codeY = "6B4C"
            codeC = "2AB8"
        End If

        If codeList.SelectedItem = "Normal death" Then
            codeX = "0002"
            codeY = "9604"
            codeC = "1FE6"
        End If

        If codeList.SelectedItem = "Hang from ledge" Then
            codeX = "0002"
            codeY = "B5EC"
            codeC = "0C2C"
        End If

        If codeList.SelectedItem = "Lift up on ledge quickly" Then
            codeX = "0002"
            codeY = "C218"
            codeC = "0628"
        End If

        If codeList.SelectedItem = "Wobble while on monkey-bars" Then
            codeX = "0002"
            codeY = "C840"
            codeC = "0F8C"
        End If

        If codeList.SelectedItem = "Put hat on" Then
            codeX = "0002"
            codeY = "D7CC"
            codeC = "0F88"
        End If

        If codeList.SelectedItem = "Putting star under hat" Then
            codeX = "0002"
            codeY = "E754"
            codeC = "1BC0"
        End If

        If codeList.SelectedItem = "Putting star under hat (part 2)" Then
            codeX = "0003"
            codeY = "0314"
            codeC = "0460"
        End If

        If codeList.SelectedItem = "Head stuck under sand" Then
            codeX = "0003"
            codeY = "0774"
            codeC = "3196"
        End If

        If codeList.SelectedItem = "Sliding on bottom" Then
            codeX = "0003"
            codeY = "390C"
            codeC = "028A"
        End If

        If codeList.SelectedItem = "Triple jump then ground-pound" Then
            codeX = "0003"
            codeY = "3B98"
            codeC = "05C8"
        End If

        If codeList.SelectedItem = "Ground-Pound" Then
            codeX = "0003"
            codeY = "4160"
            codeC = "0432"
        End If

        If codeList.SelectedItem = "Ground-Pound (part 2)" Then
            codeX = "0003"
            codeY = "4178"
            codeC = "041A"
        End If

        If codeList.SelectedItem = "Bottom stuck in snow / sand" Then
            codeX = "0003"
            codeY = "4594"
            codeC = "2DF6"
        End If

        If codeList.SelectedItem = "Standing and holding small object" Then
            codeX = "0003"
            codeY = "738C"
            codeC = "0D28"
        End If

        If codeList.SelectedItem = "Jump with small object (wearing wing cap)" Then
            codeX = "0003"
            codeY = "0614"
            codeC = "032c"
        End If

        If codeList.SelectedItem = "Pick up small object" Then
            codeX = "0003"
            codeY = "8940"
            codeC = "04D0"
        End If

        If codeList.SelectedItem = "Coming down with small object (wearing wing cap)" Then
            codeX = "0003"
            codeY = "8E10"
            codeC = "0168"
        End If

        If codeList.SelectedItem = "Slide then fall with small object" Then
            codeX = "0003"
            codeY = "8F78"
            codeC = "039E"
        End If

        If codeList.SelectedItem = "Sliding with small object" Then
            codeX = "0003"
            codeY = "9318"
            codeC = "05D2"
        End If

        If codeList.SelectedItem = "Get up from ground with small object" Then
            codeX = "0003"
            codeY = "9330"
            codeC = "05BA"
        End If

        If codeList.SelectedItem = "On Koopa shell" Then
            codeX = "0003"
            codeY = "98EC"
            codeC = "045A"
        End If

        If codeList.SelectedItem = "Walking (not running)" Then
            codeX = "0003"
            codeY = "9D48"
            codeC = "045A"
        End If

        If codeList.SelectedItem = "Side flip?" Then
            codeX = "0003"
            codeY = "B248"
            codeC = "0626"
        End If

        If codeList.SelectedItem = "Jump while riding shell" Then
            codeX = "0003"
            codeY = "B870"
            codeC = "037C"
        End If

        If codeList.SelectedItem = "Landing from double jump" Then
            codeX = "0003"
            codeY = "BBEC"
            codeC = "067E"
        End If

        If codeList.SelectedItem = "Mid-air part of double jump" Then
            codeX = "0003"
            codeY = "C26C"
            codeC = "03B2"
        End If

        If codeList.SelectedItem = "Normal jump" Then
            codeX = "0003"
            codeY = "C620"
            codeC = "0AC4"
        End If

        If codeList.SelectedItem = "Land from normal jump" Then
            codeX = "0003"
            codeY = "C638"
            codeC = "0AAC"
        End If

        If codeList.SelectedItem = "Kick in mid-air" Then
            codeX = "0003"
            codeY = "D0E4"
            codeC = "073E"
        End If

        If codeList.SelectedItem = "Double jump" Then
            codeX = "0003"
            codeY = "D824"
            codeC = "02B8"
        End If

        If codeList.SelectedItem = "Triple Jump" Then
            codeX = "0003"
            codeY = "DADC"
            codeC = "04FE"
        End If

        If codeList.SelectedItem = "Throw object" Then
            codeX = "0003"
            codeY = "DFDC"
            codeC = "0482"
        End If

        If codeList.SelectedItem = "Slide kick" Then
            codeX = "0003"
            codeY = "E460"
            codeC = "08C6"
        End If

        If codeList.SelectedItem = "On Koopa shell" Then
            codeX = "0003"
            codeY = "ED28"
            codeC = "0636"
        End If

        If codeList.SelectedItem = "Fall from height" Then
            codeX = "0004"
            codeY = "2078"
            codeC = "0744"
        End If

        If codeList.SelectedItem = "Fall hard from double jump" Then
            codeX = "0004"
            codeY = "2029"
            codeC = "072C"
        End If

        If codeList.SelectedItem = "Picked up by enemy" Then
            codeX = "0004"
            codeY = "27BC"
            codeC = "054E"
        End If

        If codeList.SelectedItem = "Pick up large object" Then
            codeX = "0004"
            codeY = "2D0C"
            codeC = "0D00"
        End If

        If codeList.SelectedItem = "Get up after being thrown" Then
            codeX = "0004"
            codeY = "3A0C"
            codeC = "0DE2"
        End If

        If codeList.SelectedItem = "Launch into flying position" Then
            codeX = "0004"
            codeY = "47F0"
            codeC = "03E4"
        End If

        If codeList.SelectedItem = "Move on mokey-bars" Then
            codeX = "0004"
            codeY = "4BD4"
            codeC = "05FE"
        End If

        If codeList.SelectedItem = "Move on mokey-bars (part 2)" Then
            codeX = "0004"
            codeY = "54D4"
            codeC = "058A"
        End If

        If codeList.SelectedItem = "Missing cap after getting star" Then
            codeX = "0004"
            codeY = "5760"
            codeC = "3062"
        End If

        If codeList.SelectedItem = "Open door and walk in" Then
            codeX = "0004"
            codeY = "87C4"
            codeC = "14D6"
        End If

        If codeList.SelectedItem = "Exit door" Then
            codeX = "0004"
            codeY = "9C9C"
            codeC = "10C8"
        End If

        If codeList.SelectedItem = "Open door with key" Then
            codeX = "0004"
            codeY = "AD64"
            codeC = "3288"
        End If

        If codeList.SelectedItem = "Unknown (looks like Mario is bowing)" Then ' You need to add comma where appropriate.
            codeX = "0004"
            codeY = "DFEC"
            codeC = "03FA"
        End If

        If codeList.SelectedItem = "Similar to avobe" Then
            codeX = "0004"
            codeY = "E3E8"
            codeC = "076E"
        End If

        If codeList.SelectedItem = "Animates both avobe" Then
            codeX = "0004"
            codeY = "EB58"
            codeC = "05F2"
        End If

        If codeList.SelectedItem = "Unknown (Mario moves arm)" Then ' You know what needs to be done here. Comma
            codeX = "0004"
            codeY = "F14C"
            codeC = "07B8"
        End If

        If codeList.SelectedItem = "Kick in mid-air and land" Then
            codeX = "0004"
            codeY = "F904"
            codeC = "08B0"
        End If

        If codeList.SelectedItem = "Unknown similar to 04FC14C punch left?" Then ' You need to add commas where appropriate.
            codeX = "0005"
            codeY = "01B4"
            codeC = "0296"
        End If

        If codeList.SelectedItem = "Punch left (part 2)" Then
            codeX = "0005"
            codeY = "044C"
            codeC = "0268"
        End If

        If codeList.SelectedItem = "Punch right" Then
            codeX = "0005"
            codeY = "06B4"
            codeC = "0410"
        End If

        If codeList.SelectedItem = "Punch left (part 3)" Then
            codeX = "0005"
            codeY = "0AC4"
            codeC = "0538"
        End If

        If codeList.SelectedItem = "Pick up small object and stand" Then
            codeX = "0005"
            codeY = "0FFC"
            codeC = "04C0"
        End If

        If codeList.SelectedItem = "Push against something while walking" Then
            codeX = "0005"
            codeY = "14BC"
            codeC = "0618"
        End If

        If codeList.SelectedItem = "Jump on Koopa shell (part 2)" Then
            codeX = "0005"
            codeY = "1AD4"
            codeC = "061A"
        End If

        If codeList.SelectedItem = "Set small object down" Then
            codeX = "0005"
            codeY = "20F0"
            codeC = "0584"
        End If

        If codeList.SelectedItem = "Special triple jump" Then
            codeX = "0005"
            codeY = "2674"
            codeC = "018E"
        End If

        If codeList.SelectedItem = "Similar to avobe (backward)" Then ' Add comma where needed.
            codeX = "0005"
            codeY = "268C"
            codeC = "0176"
        End If

        If codeList.SelectedItem = "Do a trip and go back to crouching" Then
            codeX = "0005"
            codeY = "2804"
            codeC = "0932"
        End If

        If codeList.SelectedItem = "Running" Then
            codeX = "0005"
            codeY = "3138"
            codeC = "1222"
        End If

        If codeList.SelectedItem = "Running (2)" Then
            codeX = "0005"
            codeY = "3150"
            codeC = "120A"
        End If

        If codeList.SelectedItem = "Get bumped by enemy" Then
            codeX = "0005"
            codeY = "435C"
            codeC = "0848"
        End If

        If codeList.SelectedItem = "Get bumped by enemy (behind)" Then
            codeX = "0005"
            codeY = "4BA4"
            codeC = "0878"
        End If

        If codeList.SelectedItem = "Dying in sand" Then
            codeX = "0005"
            codeY = "541C"
            codeC = "0133C"
        End If

        If codeList.SelectedItem = "Stuck, looking around" Then ' Need to add comma where needed.
            codeX = "0005"
            codeY = "6758"
            codeC = "0AB4"
        End If

        If codeList.SelectedItem = "Walking through sand" Then
            codeX = "0005"
            codeY = "720C"
            codeC = "29EA"
        End If

        If codeList.SelectedItem = "Dying from shock" Then
            codeX = "0005"
            codeY = "9BF8"
            codeC = "0F46"
        End If

        If codeList.SelectedItem = "Getting shocked" Then
            codeX = "0005"
            codeY = "AB40"
            codeC = "02A6"
        End If

        If codeList.SelectedItem = "Bump into wall" Then
            codeX = "0005"
            codeY = "ADE8"
            codeC = "0A4C"
        End If

        If codeList.SelectedItem = "Fall forward" Then
            codeX = "0005"
            codeY = "B834"
            codeC = "0A10"
        End If

        If codeList.SelectedItem = "Holding large object" Then
            codeX = "0005"
            codeY = "C244"
            codeC = "056E"
        End If

        If codeList.SelectedItem = "Against wall" Then
            codeX = "0005"
            codeY = "7B40"
            codeC = "12CE"
        End If

        If codeList.SelectedItem = "Sidestepping against wall" Then
            codeX = "0005"
            codeY = "DA84"
            codeC = "0F3A"
        End If

        If codeList.SelectedItem = "Sidestepping against wall(2)" Then
            codeX = "0005"
            codeY = "E9C0"
            codeC = "11AC"
        End If

        If codeList.SelectedItem = "Sleepy (1)" Then
            codeX = "0005"
            codeY = "FB6C"
            codeC = "11E8"
        End If

        If codeList.SelectedItem = "Sleepy (2)" Then
            codeX = "0006"
            codeY = "0D54"
            codeC = "179E"
        End If

        If codeList.SelectedItem = "Sleepy (3)" Then
            codeX = "0006"
            codeY = "24F4"
            codeC = "1392"
        End If

        If codeList.SelectedItem = "Sleepy (4)" Then
            codeX = "0006"
            codeY = "3888"
            codeC = "13A8"
        End If

        If codeList.SelectedItem = "Sleeping" Then
            codeX = "0006"
            codeY = "4C30"
            codeC = "0258"
        End If

        If codeList.SelectedItem = "Lay down" Then
            codeX = "0006"
            codeY = "4E88"
            codeC = "0C6A"
        End If

        If codeList.SelectedItem = "Laying and sleeping" Then
            codeX = "0006"
            codeY = "5AF4"
            codeC = "0730"
        End If

        If codeList.SelectedItem = "Belly flop" Then
            codeX = "0006"
            codeY = "6224"
            codeC = "0618"
        End If

        If codeList.SelectedItem = "On belly" Then
            codeX = "0006"
            codeY = "623C"
            codeC = "0600"
        End If

        If codeList.SelectedItem = "Get up after bumping into wall" Then
            codeX = "0006"
            codeY = "683C"
            codeC = "0CB8"
        End If

        If codeList.SelectedItem = "Get up after belly flop holding small object" Then ' Add comma where needeed.
            codeX = "0006"
            codeY = "74F4"
            codeC = "0CAE"
        End If

        If codeList.SelectedItem = "Beginning of side kick" Then
            codeX = "0006"
            codeY = "81A4"
            codeC = "039A"
        End If

        If codeList.SelectedItem = "Get up from slide kick go back to crouching" Then ' Add comma where needed
            codeX = "0006"
            codeY = "8540"
            codeC = "0552"
        End If

        If codeList.SelectedItem = "Sliding with hands back" Then
            codeX = "0006"
            codeY = "8A94"
            codeC = "077E"
        End If

        If codeList.SelectedItem = "Get up and stand" Then
            codeX = "0006"
            codeY = "8AAC"
            codeC = "0766"
        End If

        If codeList.SelectedItem = "Go into falling from height position" Then
            codeX = "0006"
            codeY = "9214"
            codeC = "0508"
        End If

        If codeList.SelectedItem = "Slide with hands back animation" Then
            codeX = "0006"
            codeY = "971C"
            codeC = "021E"
        End If

        If codeList.SelectedItem = "Tiptoe" Then
            codeX = "0006"
            codeY = "993C"
            codeC = "16F4"
        End If

        If codeList.SelectedItem = "Land from spin jump" Then
            codeX = "0006"
            codeY = "B030"
            codeC = "036E"
        End If

        If codeList.SelectedItem = "Spin jump" Then
            codeX = "0006"
            codeY = "B3A0"
            codeC = "0164"
        End If

        If codeList.SelectedItem = "Start spin jump" Then
            codeX = "0006"
            codeY = "B504"
            codeC = "022C"
        End If

        If codeList.SelectedItem = "Come up from crouch" Then
            codeX = "0006"
            codeY = "B730"
            codeC = "03BC"
        End If

        If codeList.SelectedItem = "Start crouch" Then
            codeX = "0006"
            codeY = "BAEC"
            codeC = "02B4"
        End If

        If codeList.SelectedItem = "Crouching" Then
            codeX = "0006"
            codeY = "BDA0"
            codeC = "0BDA"
        End If

        If codeList.SelectedItem = "Crawling" Then
            codeX = "0006"
            codeY = "C97C"
            codeC = "1C7A"
        End If

        If codeList.SelectedItem = "Come up from crawling" Then
            codeX = "0006"
            codeY = "E5F8"
            codeC = "0398"
        End If

        If codeList.SelectedItem = "In crawling position" Then
            codeX = "0006"
            codeY = "E990"
            codeC = "038A"
        End If

        If codeList.SelectedItem = "Opening door with star" Then
            codeX = "0006"
            codeY = "ED1C"
            codeC = "1428"
        End If

        If codeList.SelectedItem = "Open door with star end, walk in" Then ' Add comma where needed
            codeX = "0007"
            codeY = "0144"
            codeC = "08AC"
        End If

        If codeList.SelectedItem = "Hit by something" Then
            codeX = "0007"
            codeY = "09F0"
            codeC = "10BC"
        End If

        If codeList.SelectedItem = "Kick legs while holding object" Then
            codeX = "0007"
            codeY = "1AAC"
            codeC = "041A"
        End If

        If codeList.SelectedItem = "Holding object" Then
            codeX = "0007"
            codeY = "1EC8"
            codeC = "029A"
        End If

        If codeList.SelectedItem = "Swimming while holding object" Then
            codeX = "0007"
            codeY = "2164"
            codeC = "04AC"
        End If

        If codeList.SelectedItem = "Stop while holding object" Then
            codeX = "0007"
            codeY = "2610"
            codeC = "06BC"
        End If

        If codeList.SelectedItem = "Let go of object" Then
            codeX = "0007"
            codeY = "2CCC"
            codeC = "0B32"
        End If

        If codeList.SelectedItem = "Holding object" Then
            codeX = "0007"
            codeY = "3800"
            codeC = "0786"
        End If

        If codeList.SelectedItem = "Drowning" Then
            codeX = "0007"
            codeY = "3F88"
            codeC = "1530"
        End If

        If codeList.SelectedItem = "Die, slump over" Then ' Add comma where needed
            codeX = "0007"
            codeY = "54B8"
            codeC = "0786"
        End If

        If codeList.SelectedItem = "Die, slump over?" Then ' Add comma where needed
            codeX = "0007"
            codeY = "67F4"
            codeC = "0D08"
        End If

        If codeList.SelectedItem = "Get hit from behind" Then
            codeX = "0007"
            codeY = "74FC"
            codeC = "105A"
        End If

        If codeList.SelectedItem = "Walking (metal mario)" Then
            codeX = "0007"
            codeY = "8558"
            codeC = "07D4"
        End If

        If codeList.SelectedItem = "Single stroke from tapping A" Then
            codeX = "0007"
            codeY = "8D2C"
            codeC = "04E0"
        End If

        If codeList.SelectedItem = "Stop swimming" Then
            codeX = "0007"
            codeY = "920C"
            codeC = "0402"
        End If

        If codeList.SelectedItem = "Strokes from holding A" Then
            codeX = "0007"
            codeY = "9610"
            codeC = "07BE"
        End If

        If codeList.SelectedItem = "Stop in water" Then
            codeX = "0007"
            codeY = "9DD0"
            codeC = "0858"
        End If

        If codeList.SelectedItem = "Grab object" Then
            codeX = "0007"
            codeY = "A628"
            codeC = "04D0"
        End If

        If codeList.SelectedItem = "Press B" Then
            codeX = "0007"
            codeY = "AAF8"
            codeC = "0984"
        End If

        If codeList.SelectedItem = "Jump (metal mario)" Then
            codeX = "0007"
            codeY = "B47C"
            codeC = "02CC"
        End If

        If codeList.SelectedItem = "Throw object" Then
            codeX = "0007"
            codeY = "B748"
            codeC = "0A86"
        End If

        If codeList.SelectedItem = "Floating" Then
            codeX = "0007"
            codeY = "C1D0"
            codeC = "0834"
        End If

        If codeList.SelectedItem = "Get star" Then
            codeX = "0007"
            codeY = "CA04"
            codeC = "1A72"
        End If

        If codeList.SelectedItem = "Get star (part 2)" Then
            codeX = "0007"
            codeY = "E478"
            codeC = "084A"
        End If

        If codeList.SelectedItem = "Grab Bowser's tail" Then
            codeX = "0007"
            codeY = "ECC4"
            codeC = "0692"
        End If

        If codeList.SelectedItem = "Holding Bowser" Then
            codeX = "0007"
            codeY = "ECDC"
            codeC = "067A"
        End If

        If codeList.SelectedItem = "Let go of Bowser" Then
            codeX = "0007"
            codeY = "F358"
            codeC = "0CB8"
        End If

        If codeList.SelectedItem = "Holding Bowser animation" Then
            codeX = "0008"
            codeY = "0010"
            codeC = "041C"
        End If

        If codeList.SelectedItem = "Throw large object" Then
            codeX = "0008"
            codeY = "042C"
            codeC = "0928"
        End If

        If codeList.SelectedItem = "Low energy" Then
            codeX = "0008"
            codeY = "0D54"
            codeC = "04EE"
        End If

        If codeList.SelectedItem = "Walking with large object" Then
            codeX = "0008"
            codeY = "1244"
            codeC = "1138"
        End If

        If codeList.SelectedItem = "Skid on ground start" Then
            codeX = "0008"
            codeY = "237C"
            codeC = "0724"
        End If

        If codeList.SelectedItem = "Switch direction quickly" Then
            codeX = "0008"
            codeY = "2394"
            codeC = "070C"
        End If

        If codeList.SelectedItem = "Land from side flip?" Then
            codeX = "0008"
            codeY = "2AA0"
            codeC = "040C"
        End If

        If codeList.SelectedItem = "Side flip" Then
            codeX = "0008"
            codeY = "2EAC"
            codeC = "08A4"
        End If

        If codeList.SelectedItem = "Land from back flip / triple jump" Then
            codeX = "0008"
            codeY = "3750"
            codeC = "0AA8"
        End If

        If codeList.SelectedItem = "Triple jump" Then
            codeX = "0008"
            codeY = "41F8"
            codeC = "0AB8"
        End If

        If codeList.SelectedItem = "Reading sign" Then
            codeX = "0008"
            codeY = "4CB0"
            codeC = "1642"
        End If

        If codeList.SelectedItem = "Standing normal (part 1)" Then
            codeX = "0008"
            codeY = "62F4"
            codeC = "08AA"
        End If

        If codeList.SelectedItem = "Standing normal (part 2)" Then
            codeX = "0008"
            codeY = "6BA0"
            codeC = "08AA"
        End If

        If codeList.SelectedItem = "Standing normal (part 3)" Then
            codeX = "0008"
            codeY = "744C"
            codeC = "08AA"
        End If

        If codeList.SelectedItem = "Hanging on mokey-bar" Then
            codeX = "0008"
            codeY = "7CF8"
            codeC = "0796"
        End If

        If codeList.SelectedItem = "Hanging on monkey-bar, look around" Then ' Add commas where needed
            codeX = "0008"
            codeY = "8490"
            codeC = "0C30"
        End If

        If codeList.SelectedItem = "Get up after sleeping (sitting)" Then
            codeX = "0008"
            codeY = "90C0"
            codeC = "0784"
        End If

        If codeList.SelectedItem = "Get up after sleeping (laying)" Then
            codeX = "0008"
            codeY = "9844"
            codeC = "08A8"
        End If

        If codeList.SelectedItem = "Begin walking" Then
            codeX = "0008"
            codeY = "A0EC"
            codeC = "08E2"
        End If

        If codeList.SelectedItem = "Wall kick/jump from tree" Then
            codeX = "0008"
            codeY = "A9D0"
            codeC = "0692"
        End If

        If codeList.SelectedItem = "Hang onto pole/tree" Then
            codeX = "0008"
            codeY = "A9D0"
            codeC = "0692"
        End If

        If codeList.SelectedItem = "Get star" Then
            codeX = "0008"
            codeY = "B064"
            codeC = "1554"
        End If

        If codeList.SelectedItem = "End get star" Then
            codeX = "0008"
            codeY = "C5B8"
            codeC = "06C8"
        End If

        If codeList.SelectedItem = "Triple jump and start flying" Then
            codeX = "0008"
            codeY = "CC80"
            codeC = "0BA8"
        End If

        If codeList.SelectedItem = "Start special triple jump" Then
            codeX = "0008"
            codeY = "B820"
            codeC = "03EE"
        End If

        If codeList.SelectedItem.ToString.Contains("?") = True Then
            IntegrityLabel.Text = "WARNING: This animation may be glitched."
            IntegrityImage.Image = My.Resources.Glitch
        ElseIf codeList.SelectedItem.ToString.Contains("Launched") Or codeList.SelectedItem.ToString.Contains("Fly") Or codeList.SelectedItem.ToString.Contains("Flying") Or codeList.SelectedItem.ToString.Contains("Fall") Or codeList.SelectedItem.ToString.Contains("Falling") Or codeList.SelectedItem.ToString.Contains("Blown") Or codeList.SelectedItem.ToString.Contains("Thrown") = True Then
            IntegrityLabel.Text = "INFO: This code needs the Hover Cheat in order to look OK."
            IntegrityImage.Image = My.Resources.Flying
        ElseIf codeList.SelectedItem.ToString.Contains("(part") Or codeList.SelectedItem.ToString.Contains("(1") Or codeList.SelectedItem.ToString.Contains("(2") Or codeList.SelectedItem.ToString.Contains("(3") Or codeList.SelectedItem.ToString.Contains("(4") = True Then
            IntegrityLabel.Text = "INFO: This animation is multipart. Pasting all parts together won't work. each one works separately."
            IntegrityImage.Image = My.Resources.Multipart
        ElseIf codeList.SelectedItem.ToString.Contains("Walk") = True Then
            IntegrityLabel.Text = "INFO: This is a Walking Animation. It may not change Mario's position."
            IntegrityImage.Image = My.Resources.MoveRoute
        ElseIf codeList.SelectedItem.ToString.Contains("Dead") Or codeList.SelectedItem.ToString.Contains("Die") Or codeList.SelectedItem.ToString.Contains("Death") Or codeList.SelectedItem.ToString.Contains("Dying") = True Then
            IntegrityLabel.Text = "INFO: This is a Death animation. After finish, Mario will keep the last frame of the animation until you release Z button."
            IntegrityImage.Image = My.Resources.Death
        ElseIf codeList.SelectedItem.ToString.Contains("Jump") Or codeList.SelectedItem.ToString.Contains("jump") = True Then
            IntegrityLabel.Text = "INFO:This is a Jump animation. This won't make Mario jump, it will simulate the animation of it and because of that you need to use Hover cheat."
            IntegrityImage.Image = My.Resources.Jump
        ElseIf codeList.SelectedItem.ToString.Contains("Hang") Or codeList.SelectedItem.ToString.Contains("Hanging") Or codeList.SelectedItem.ToString.Contains("Swinging") Or codeList.SelectedItem.ToString.Contains("Climb") Or codeList.SelectedItem.ToString.Contains("tree") = True Then
            IntegrityLabel.Text = "INFO: This is a Hang animation. Mario is not gonna hang in nothing and because of that needs to use the Hover cheat."
            IntegrityImage.Image = My.Resources.Hang
        ElseIf codeList.SelectedItem.ToString.Contains("Hold") Or codeList.SelectedItem.ToString.Contains("Holding") Or codeList.SelectedItem.ToString.Contains("Pick up") Or codeList.SelectedItem.ToString.Contains("Throw") Or codeList.SelectedItem.ToString.Contains("throw") = True Then
            IntegrityLabel.Text = "INFO: This is a Hold/Grab animation. Mario's not gonna hold anything, it will simulate it does."
            IntegrityImage.Image = My.Resources.Hold
        ElseIf codeList.SelectedItem.ToString.Contains("Unknown") = True Then
            IntegrityLabel.Text = "WARNING: This animation can't be recgonized as part of SM64 itself. Maybe it's an unused animation or something like that. Please check what it does and post it in the community."
            IntegrityImage.Image = My.Resources.Bugged
        ElseIf codeList.SelectedItem.ToString.Contains("avobe") = True Then
            IntegrityLabel.Text = "You're smart enough to know that 'Avobe' means the one AVOBE this one."
            IntegrityImage.Image = My.Resources.YouDontSay
        ElseIf codeList.SelectedItem.ToString.Contains(" ?") = False Then
            IntegrityLabel.Text = "This code may work properly."
            IntegrityImage.Image = My.Resources.OK
        End If
    End Sub

    Private Sub animCodeGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkForXYC.Enabled = True
        checkForXYC.Interval = 1
    End Sub

    Private Sub checkForXYC_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkForXYC.Tick
        If HoverCheck.Checked = True Then
            cheatBox.Text = (Pt1 + codeY + vbNewLine + Pt2 + codeX + vbNewLine + Pt3 + codeC + vbNewLine + codeHover)
        ElseIf HoverCheck.Checked = False Then
            cheatBox.Text = (Pt1 + codeY + vbNewLine + Pt2 + codeX + vbNewLine + Pt3 + codeC)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeForm.Click
        Me.Close()
    End Sub

    Private Sub copyCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copyCode.Click
        If HoverCheck.Checked = True Then
            Clipboard.SetText(Pt1 + codeY + vbNewLine + Pt2 + codeX + vbNewLine + Pt3 + codeC + vbNewLine + codeHover)
        ElseIf HoverCheck.Checked = False Then
            Clipboard.SetText(Pt1 + codeY + vbNewLine + Pt2 + codeX + vbNewLine + Pt3 + codeC)
        End If
    End Sub

    Private Sub HoverCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HoverCheck.CheckedChanged
        cheatBox.Text = (Pt1 + codeY + vbNewLine + Pt2 + codeX + vbNewLine + Pt3 + codeC + vbNewLine + codeHover)
        If HoverCheck.Checked = False Then
            cheatBox.Text = (Pt1 + codeY + vbNewLine + Pt2 + codeX + vbNewLine + Pt3 + codeC)
        End If
    End Sub
End Class