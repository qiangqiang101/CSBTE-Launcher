Imports System.Runtime.InteropServices
Public Class frmCangku

    Private btePrimary As String = My.Application.Info.DirectoryPath & "\launcher\pri_wpn.ini"
    Private bteSecondary As String = My.Application.Info.DirectoryPath & "\launcher\sec_wpn.ini"
    Private bteMelee As String = My.Application.Info.DirectoryPath & "\launcher\mel_wpn.ini"
    Private bteGrenade As String = My.Application.Info.DirectoryPath & "\launcher\gre_wpn.ini"
    Private bteMyPrimary As String = My.Application.Info.DirectoryPath & "\launcher\pri_mywpn.ini"
    Private bteMySecondary As String = My.Application.Info.DirectoryPath & "\launcher\sec_mywpn.ini"
    Private bteMyMelee As String = My.Application.Info.DirectoryPath & "\launcher\mel_mywpn.ini"
    Private bteMyGrenade As String = My.Application.Info.DirectoryPath & "\launcher\gre_mywpn.ini"
    Private parameters As String() = {"[id]", "[name]", "[model]", "[category]"}
    Private items As New ListViewItem()
    Dim selModel As String = ""

    <DllImport("uxtheme.dll", ExactSpelling:=True, CharSet:=CharSet.Unicode)> _
    Private Shared Function SetWindowTheme(ByVal hwnd As IntPtr, ByVal pszSubAppName As String, ByVal pszSubIdList As String) As Integer
    End Function

    Private Sub readPrimary()
        Dim bteFormat As New BTEFormatReader(btePrimary, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Primary.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
                .SubItems.Add(bteFormat(i)("category"))
            End With
        Next
    End Sub

    Private Sub readSecondary()
        Dim bteFormat As New BTEFormatReader(bteSecondary, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Secondary.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
                .SubItems.Add(bteFormat(i)("category"))
            End With
        Next
    End Sub

    Private Sub readMelee()
        Dim bteFormat As New BTEFormatReader(bteMelee, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Melee.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
                .SubItems.Add(bteFormat(i)("category"))
            End With
        Next
    End Sub

    Private Sub readGrenade()
        Dim bteFormat As New BTEFormatReader(bteGrenade, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Grenades.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
                .SubItems.Add(bteFormat(i)("category"))
            End With
        Next
    End Sub

    Private Sub readSelectedPrimary()
        Dim bteFormat As New BTEFormatReader(bteMyPrimary, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_SelPrimary.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Private Sub readSelectedSecondary()
        Dim bteFormat As New BTEFormatReader(bteMySecondary, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_SelSecondary.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Private Sub readSelectedMelee()
        Dim bteFormat As New BTEFormatReader(bteMyMelee, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_SelMelee.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Private Sub readSelectedGrenade()
        Dim bteFormat As New BTEFormatReader(bteMyGrenade, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_SelGrenades.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Me.Hide()
    End Sub

    Private Sub frmCangku_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetWindowTheme(lv_Primary.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_Secondary.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_Melee.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_Grenades.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_SelPrimary.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_SelSecondary.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_SelMelee.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_SelGrenades.Handle, "Explorer", Nothing)

        readPrimary()
        readSecondary()
        readMelee()
        readGrenade()

        Dim loadAllWpn As Integer = ReadIniValue(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "LOADALLWEAPONS")
        If loadAllWpn = "0" Then
            rad_Off.Checked = True
        Else
            rad_On.Checked = True
        End If
    End Sub

    Private Sub refreshCtrls()
        pb_Damage.Value = 0
        pb_HitRate.Value = 0
        pb_Reaction.Value = 0
        pb_FiringSpeed.Value = 0
        pb_Weight.Value = 0
        lbl_Cost.Text = "$0"
        lbl_Ammo.Text = "Unlimited"
    End Sub

    Private Sub lv_Primary_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_Primary.DoubleClick
        If selModel.Contains(lbl_Model.Text & ",") Then
            Exit Sub
        Else
            txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
            selModel = selModel + lbl_Model.Text & ","
            lbl_SelWpn.Text = lbl_SelWpn.Text + 1
            Dim line = lv_Primary.SelectedIndices(0)
            lv_SelPrimary.Items.Add(lv_Primary.Items(line).Clone())
        End If
    End Sub

    Private Sub lv_Primary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Primary.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_Primary.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_Primary.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_Primary.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub lv_Secondary_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_Secondary.DoubleClick
        If selModel.Contains(lbl_Model.Text & ",") Then
            Exit Sub
        Else
            txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
            selModel = selModel + lbl_Model.Text & ","
            lbl_SelWpn.Text = lbl_SelWpn.Text + 1
            Dim line = lv_Secondary.SelectedIndices(0)
            lv_SelSecondary.Items.Add(lv_Secondary.Items(line).Clone())
        End If
    End Sub

    Private Sub lv_Secondary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Secondary.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_Secondary.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_Secondary.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_Secondary.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub lv_Melee_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_Melee.DoubleClick
        If selModel.Contains(lbl_Model.Text & ",") Then
            Exit Sub
        Else
            txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
            selModel = selModel + lbl_Model.Text & ","
            lbl_SelWpn.Text = lbl_SelWpn.Text + 1
            Dim line = lv_Melee.SelectedIndices(0)
            lv_SelMelee.Items.Add(lv_Melee.Items(line).Clone())
        End If
    End Sub

    Private Sub lv_Melee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Melee.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_Melee.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_Melee.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_Melee.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub lv_Grenade_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_Grenades.DoubleClick
        If selModel.Contains(lbl_Model.Text & ",") Then
            Exit Sub
        Else
            txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
            selModel = selModel + lbl_Model.Text & ","
            lbl_SelWpn.Text = lbl_SelWpn.Text + 1
            Dim line = lv_Grenades.SelectedIndices(0)
            lv_SelGrenades.Items.Add(lv_Grenades.Items(line).Clone())
        End If
    End Sub

    Private Sub lv_Grenade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Grenades.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_Grenades.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_Grenades.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_Grenades.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub btn_Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Select.Click
        If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
            If selModel.Contains(lbl_Model.Text & ",") Then
                Exit Sub
            Else
                txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
                selModel = selModel + lbl_Model.Text & ","
                lbl_SelWpn.Text = lbl_SelWpn.Text + 1
                Dim line = lv_Primary.SelectedIndices(0)
                lv_SelPrimary.Items.Add(lv_Primary.Items(line).Clone())
            End If
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem2 Then
            If selModel.Contains(lbl_Model.Text & ",") Then
                Exit Sub
            Else
                txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
                selModel = selModel + lbl_Model.Text & ","
                lbl_SelWpn.Text = lbl_SelWpn.Text + 1
                Dim line = lv_Secondary.SelectedIndices(0)
                lv_SelSecondary.Items.Add(lv_Secondary.Items(line).Clone())
            End If
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem3 Then
            If selModel.Contains(lbl_Model.Text & ",") Then
                Exit Sub
            Else
                txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
                selModel = selModel + lbl_Model.Text & ","
                lbl_SelWpn.Text = lbl_SelWpn.Text + 1
                Dim line = lv_Melee.SelectedIndices(0)
                lv_SelMelee.Items.Add(lv_Melee.Items(line).Clone())
            End If
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem4 Then
            If selModel.Contains(lbl_Model.Text & ",") Then
                Exit Sub
            Else
                txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
                selModel = selModel + lbl_Model.Text & ","
                lbl_SelWpn.Text = lbl_SelWpn.Text + 1
                Dim line = lv_Grenades.SelectedIndices(0)
                lv_SelGrenades.Items.Add(lv_Grenades.Items(line).Clone())
            End If
        End If
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelPrimary.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem2 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelSecondary.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem3 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelMelee.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem4 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelGrenades.Items.Clear()
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If rad_On.Checked = True Then
            WriteIniValue2(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "LOADALLWEAPONS", "1")
        ElseIf rad_On.Checked = False And rad_Off.Checked = False Then
            MsgBox("Error, Please Choose On or Off!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        Else
            WriteIniValue2(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "LOADALLWEAPONS", "0")
        End If

        If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
            WriteIniValue(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "RIFLES", selModel.ToString)
            MsgBox("You have selected: " & txt_SelName.Text, MsgBoxStyle.Information, "Info")
            Dim myPri As String = My.Application.Info.DirectoryPath & "\launcher\pri_mywpn.ini"
            Dim SW As New System.IO.StreamWriter(myPri)
            For Each myPriItem As ListViewItem In lv_SelPrimary.Items
                SW.Write("[id]" & myPriItem.SubItems(1).Text & "[name]" & myPriItem.Text & "[model]" & myPriItem.SubItems(2).Text & Environment.NewLine)
            Next
            SW.Close()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem2 Then
            WriteIniValue(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "PISTOLS", selModel.ToString)
            MsgBox("You have selected: " & txt_SelName.Text, MsgBoxStyle.Information, "Info")
            Dim mySec As String = My.Application.Info.DirectoryPath & "\launcher\sec_mywpn.ini"
            Dim SW As New System.IO.StreamWriter(mySec)
            For Each mySecItem As ListViewItem In lv_SelSecondary.Items
                SW.Write("[id]" & mySecItem.SubItems(1).Text & "[name]" & mySecItem.Text & "[model]" & mySecItem.SubItems(2).Text & Environment.NewLine)
            Next
            SW.Close()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem3 Then
            WriteIniValue(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "KNIFES", selModel.ToString)
            MsgBox("You have selected: " & txt_SelName.Text, MsgBoxStyle.Information, "Info")
            Dim myMel As String = My.Application.Info.DirectoryPath & "\launcher\mel_mywpn.ini"
            Dim SW As New System.IO.StreamWriter(myMel)
            For Each myMelItem As ListViewItem In lv_SelMelee.Items
                SW.Write("[id]" & myMelItem.SubItems(1).Text & "[name]" & myMelItem.Text & "[model]" & myMelItem.SubItems(2).Text & Environment.NewLine)
            Next
            SW.Close()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem4 Then
            WriteIniValue(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_precachewpn.ini", "My Weapons", "HEGRENADES", selModel.ToString)
            MsgBox("You have selected: " & txt_SelName.Text, MsgBoxStyle.Information, "Info")
            Dim myGre As String = My.Application.Info.DirectoryPath & "\launcher\gre_mywpn.ini"
            Dim SW As New System.IO.StreamWriter(myGre)
            For Each myGreItem As ListViewItem In lv_SelGrenades.Items
                SW.Write("[id]" & myGreItem.SubItems(1).Text & "[name]" & myGreItem.Text & "[model]" & myGreItem.SubItems(2).Text & Environment.NewLine)
            Next
            SW.Write("[id]65535[name]HE Grenade[model]hegrenade" & Environment.NewLine)
            SW.Close()
        End If
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelPrimary.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem2 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelSecondary.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem3 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelMelee.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem4 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelGrenades.Items.Clear()
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem5 Then
            txt_SelName.Text = ""
            selModel = ""
            lbl_SelWpn.Text = "0"
            lv_SelPrimary.Items.Clear()
            lv_SelSecondary.Items.Clear()
            lv_SelMelee.Items.Clear()
            lv_SelGrenades.Items.Clear()
            readSelectedPrimary()
            readSelectedSecondary()
            readSelectedMelee()
            readSelectedGrenade()
        End If
    End Sub

    Private Sub lv_SelPrimary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_SelPrimary.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_SelPrimary.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_SelPrimary.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_SelPrimary.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub lv_SelSecondary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_SelSecondary.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_SelSecondary.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_SelSecondary.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_SelSecondary.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub lv_SelMelee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_SelMelee.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_SelMelee.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_SelMelee.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_SelMelee.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub lv_SelGrenades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_SelGrenades.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_ID.Text = lv_SelGrenades.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_SelGrenades.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_SelGrenades.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub

    Private Sub btn_QuickBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_QuickBuy.Click
        frmQuickBuy.Show()
        Me.Hide()
    End Sub

    Private Sub btn_TeamSuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TeamSuit.Click
        frmTeamSuit.Show()
        Me.Hide()
    End Sub

    Private Sub rad_On_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_On.Click
        If rad_Off.Checked = True Then rad_Off.Checked = False
    End Sub

    Private Sub rad_Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_Off.Click
        If rad_On.Checked = True Then rad_On.Checked = False
    End Sub
End Class