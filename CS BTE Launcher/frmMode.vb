Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmMode

    Dim map As String = My.Application.Info.DirectoryPath
    Dim gmp As String = "\cstrike\addons\amxmodx\configs\"
    Dim mg As String = map & gmp

    Dim nomod As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-none.ini" 'Original
    Dim teamdm As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-td.ini" 'Team Deathmatch
    Dim funmod As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-funmode.ini" 'Fun Mode
    Dim zb3 As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-zb3.ini" 'Zombie Mode 3
    Dim zbs As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-npc.ini" 'Zombie Scenerio
    Dim drun As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-dr.ini" 'Deathrun
    Dim basic As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-basic.ini" 'Basic
    Dim gundm As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-gd.ini" 'Gun Deathmatch
    Dim zbe As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-ze.ini" 'Zombie Escape
    Dim zb1 As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-zb1.ini" 'Zombie Mode 1
    Dim singledm As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-single.ini" 'Deathmatch
    Dim hidden As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-hidden.ini" 'Hidden Mode
    Dim zb4 As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-zb4.ini" 'Zombie Mode 4
    Dim nndm As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\plugins-dm.ini" 'NN Deathmatch

    Private Sub chkFile()
        Try
            If File.Exists(nomod) Then
                If File.Exists(map & gmp & "disabled-none.ini") Then
                    File.Delete(nomod)
                End If
            End If
            If File.Exists(teamdm) Then
                If File.Exists(map & gmp & "disabled-td.ini") Then
                    File.Delete(teamdm)
                End If
            End If
            If File.Exists(funmod) Then
                If File.Exists(map & gmp & "disabled-funmode.ini") Then
                    File.Delete(funmod)
                End If
            End If
            If File.Exists(zb3) Then
                If File.Exists(map & gmp & "disabled-zb3.ini") Then
                    File.Delete(zb3)
                End If
            End If
            If File.Exists(zbs) Then
                If File.Exists(map & gmp & "disabled-npc.ini") Then
                    File.Delete(zbs)
                End If
            End If
            If File.Exists(drun) Then
                If File.Exists(map & gmp & "disabled-dr.ini") Then
                    File.Delete(drun)
                End If
            End If
            If File.Exists(basic) Then
                If File.Exists(map & gmp & "disabled-basic.ini") Then
                    File.Delete(basic)
                End If
            End If
            If File.Exists(gundm) Then
                If File.Exists(map & gmp & "disabled-gd.ini") Then
                    File.Delete(gundm)
                End If
            End If
            If File.Exists(zbe) Then
                If File.Exists(map & gmp & "disabled-ze.ini") Then
                    File.Delete(zbe)
                End If
            End If
            If File.Exists(zb1) Then
                If File.Exists(map & gmp & "disabled-zb1.ini") Then
                    File.Delete(zb1)
                End If
            End If
            If File.Exists(singledm) Then
                If File.Exists(map & gmp & "disabled-single.ini") Then
                    File.Delete(singledm)
                End If
            End If
            If File.Exists(hidden) Then
                If File.Exists(map & gmp & "disabled-hidden.ini") Then
                    File.Delete(hidden)
                End If
            End If
            If File.Exists(zb4) Then
                If File.Exists(map & gmp & "disabled-zb4.ini") Then
                    File.Delete(zb4)
                End If
            End If
            If File.Exists(nndm) Then
                If File.Exists(map & gmp & "disabled-dm.ini") Then
                    File.Delete(nndm)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    

    Private Sub frmLauncher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkFile()

        Try
            If File.Exists(nomod) Then
                pic_none.Image = My.Resources.none_s
                lbl_Mode.Text = "Original"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\basic_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
                sr.Close()
            ElseIf File.Exists(teamdm) Then
                pic_tdm.Image = My.Resources.td_s
                lbl_Mode.Text = "Team Deathmatch"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\tdm_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch, (FUN) Team Deathmatch: Item Battle"
                sr.Close()
            ElseIf File.Exists(funmod) Then
                pic_fun.Image = My.Resources.fun_s
                lbl_Mode.Text = "Fun Mode"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\fun_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(BK) Bazooka Match"
                sr.Close()
            ElseIf File.Exists(zb3) Then
                pic_zb3.Image = My.Resources.zb3_s
                lbl_Mode.Text = "Zombie Mode 3"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zb3_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (BZM) Zombie Mode, (CS) Combat Skill, (DE) Bomb Defuse, (ZM) Zombie Mode"
                sr.Close()
            ElseIf File.Exists(zb4) Then
                pic_zb4.Image = My.Resources.zb4_s
                lbl_Mode.Text = "Zombie Mode 4"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zb4_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (BZM) Zombie Mode, (CS) Combat Skill, (DE) Bomb Defuse, (ZM) Zombie Mode"
                sr.Close()
            ElseIf File.Exists(zb1) Then
                pic_zb1.Image = My.Resources.zb1_s
                lbl_Mode.Text = "Zombie Mode 1"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zb1_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (BZM) Zombie Mode, (CS) Combat Skill, (DE) Bomb Defuse, (ZM) Zombie Mode"
                sr.Close()
            ElseIf File.Exists(zbs) Then
                pic_npc.Image = My.Resources.npc_s
                lbl_Mode.Text = "Zombie Scenario"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zs_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(ZS) Zombie Scenario"
                sr.Close()
            ElseIf File.Exists(drun) Then
                pic_dr.Image = My.Resources.dr_s
                lbl_Mode.Text = "Deathrun"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\dr_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(CSO) Deathrun"
                sr.Close()
            ElseIf File.Exists(basic) Then
                pic_basic.Image = My.Resources.basic_s
                lbl_Mode.Text = "Basic"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\basic_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
                sr.Close()
            ElseIf File.Exists(gundm) Then
                pic_gd.Image = My.Resources.gdm_s
                lbl_Mode.Text = "Gun Deathmatch"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\tdm_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
                sr.Close()
            ElseIf File.Exists(zbe) Then
                pic_ze.Image = My.Resources.ze_s
                lbl_Mode.Text = "Zombie Escape"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\ze_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(ZE) Zombie Escape"
                sr.Close()
            ElseIf File.Exists(singledm) Then
                pic_dm.Image = My.Resources.dm_s
                lbl_Mode.Text = "Deathmatch"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\nndm_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
                sr.Close()
            ElseIf File.Exists(hidden) Then
                pic_hd.Image = My.Resources.hd_s
                lbl_Mode.Text = "Hidden Mode"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\hd_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(HD) Hidden Mode"
                sr.Close()
            ElseIf File.Exists(nndm) Then
                pic_nndm.Image = My.Resources.nndm_s
                lbl_Mode.Text = "NN Deathmatch"
                Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\nndm_mod.txt")
                txt_Mode.Text = sr.ReadToEnd
                lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
                sr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_Play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Play.Click
        frmLauncher.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        frmLauncher.Show()
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        frmBackground2.Show()
        If My.Settings.BGM = "On" Then
            Try
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\launcher\gamestartup.wav", AudioPlayMode.BackgroundLoop)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            Try
                My.Computer.Audio.Stop()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End If
        NotifyIcon1.Visible = False
    End Sub

    Private Sub pic_basic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_basic.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-basic.ini", "plugins-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Basic"
        frmLauncher.lbl_Mode.Text = "Basic"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\basic_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
        sr.Close()

        pic_basic.Image = My.Resources.basic_s
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readmap()
    End Sub

    Private Sub pic_none_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_none.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-none.ini", "plugins-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Original"
        frmLauncher.lbl_Mode.Text = "Original"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\basic_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_s
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_dm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_dm.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-single.ini", "plugins-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Deathmatch"
        frmLauncher.lbl_Mode.Text = "Deathmatch"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\nndm_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_s
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_nndm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_nndm.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-dm.ini", "plugins-dm.ini")
        lbl_Mode.Text = "NN Deathmatch"
        frmLauncher.lbl_Mode.Text = "NN Deathmatch"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\nndm_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_s
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_tdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_tdm.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-td.ini", "plugins-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Team Deathmatch"
        frmLauncher.lbl_Mode.Text = "Team Deathmatch"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\tdm_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch, (FUN) Team Deathmatch: Item Battle"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_s
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_gd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_gd.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-gd.ini", "plugins-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Gun Deathmatch"
        frmLauncher.lbl_Mode.Text = "Gun Deathmatch"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\tdm_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (AWP) Sniper Match, (CS) Combat Skill, (DE) Bomb Defuse, (FY) Fight Yard, (DM) Deathmatch"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_s
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_hd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_hd.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-hidden.ini", "plugins-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Hidden Mode"
        frmLauncher.lbl_Mode.Text = "Hidden Mode"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\hd_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(HD) Hidden Mode"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_s
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_fun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_fun.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-funmode.ini", "plugins-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Fun Mode"
        frmLauncher.lbl_Mode.Text = "Fun Mode"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\fun_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(BK) Bazooka Match"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_s
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_dr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_dr.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-dr.ini", "plugins-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Deathrun"
        frmLauncher.lbl_Mode.Text = "Deathrun"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\dr_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(CSO) Deathrun"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_s
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_zb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_zb1.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-zb1.ini", "plugins-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Zombie Mode 1"
        frmLauncher.lbl_Mode.Text = "Zombie Mode 1"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zb1_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (BZM) Zombie Mode, (CS) Combat Skill, (DE) Bomb Defuse, (ZM) Zombie Mode"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_s
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_zb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_zb3.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-zb3.ini", "plugins-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Zombie Mode 3"
        frmLauncher.lbl_Mode.Text = "Zombie Mode 3"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zb3_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (BZM) Zombie Mode, (CS) Combat Skill, (DE) Bomb Defuse, (ZM) Zombie Mode"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_s
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_zb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_zb4.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-zb4.ini", "plugins-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Zombie Mode 4"
        frmLauncher.lbl_Mode.Text = "Zombie Mode 4"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zb4_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(AS) Assassination, (BZM) Zombie Mode, (CS) Combat Skill, (DE) Bomb Defuse, (ZM) Zombie Mode"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_s
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_npc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_npc.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-ze.ini", "disabled-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-npc.ini", "plugins-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Zombie Scenario"
        frmLauncher.lbl_Mode.Text = "Zombie Scenario"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\zs_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(ZS) Zombie Scenario"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_s
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_n

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub

    Private Sub pic_ze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ze.Click
        On Error Resume Next
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-none.ini", "disabled-none.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb3.ini", "disabled-zb3.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dr.ini", "disabled-dr.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-gd.ini", "disabled-gd.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "disabled-ze.ini", "plugins-ze.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-td.ini", "disabled-td.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-single.ini", "disabled-single.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-npc.ini", "disabled-npc.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb1.ini", "disabled-zb1.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-basic.ini", "disabled-basic.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-funmode.ini", "disabled-funmode.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-hidden.ini", "disabled-hidden.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-zb4.ini", "disabled-zb4.ini")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\" & "plugins-dm.ini", "disabled-dm.ini")
        lbl_Mode.Text = "Zombie Escape"
        frmLauncher.lbl_Mode.Text = "Zombie Escape"

        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\launcher\ze_mod.txt")
        txt_Mode.Text = sr.ReadToEnd
        lbl_Map.Text = "(ZE) Zombie Escape"
        sr.Close()

        pic_basic.Image = My.Resources.basic_n
        pic_dm.Image = My.Resources.dm_n
        pic_dr.Image = My.Resources.dr_n
        pic_fun.Image = My.Resources.fun_n
        pic_gd.Image = My.Resources.gdm_n
        pic_hd.Image = My.Resources.hd_n
        pic_nndm.Image = My.Resources.nndm_n
        pic_none.Image = My.Resources.none_n
        pic_npc.Image = My.Resources.npc_n
        pic_tdm.Image = My.Resources.td_n
        pic_zb1.Image = My.Resources.zb1_n
        pic_zb3.Image = My.Resources.zb3_n
        pic_zb4.Image = My.Resources.zb4_n
        pic_ze.Image = My.Resources.ze_s

        frmLauncher.cmb_Map.Items.Clear()
        frmLauncher.readMap()
    End Sub
End Class