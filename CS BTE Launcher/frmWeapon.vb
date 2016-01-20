Imports System.Runtime.InteropServices
Public Class frmWeapon

    Private bteMyPrimary As String = My.Application.Info.DirectoryPath & "\launcher\pri_mywpn.ini"
    Private bteMySecondary As String = My.Application.Info.DirectoryPath & "\launcher\sec_mywpn.ini"
    Private bteMyMelee As String = My.Application.Info.DirectoryPath & "\launcher\mel_mywpn.ini"
    Private bteMyGrenade As String = My.Application.Info.DirectoryPath & "\launcher\gre_mywpn.ini"
    Private parameters As String() = {"[id]", "[name]", "[model]", "[category]"}
    Private items As New ListViewItem()
    Dim selModel As String = ""
    Public fromWhere As String

    <DllImport("uxtheme.dll", ExactSpelling:=True, CharSet:=CharSet.Unicode)> _
    Private Shared Function SetWindowTheme(ByVal hwnd As IntPtr, ByVal pszSubAppName As String, ByVal pszSubIdList As String) As Integer
    End Function

    Public Sub readSelectedPrimary()
        Dim bteFormat As New BTEFormatReader(bteMyPrimary, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Weapon.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Public Sub readSelectedSecondary()
        Dim bteFormat As New BTEFormatReader(bteMySecondary, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Weapon.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Public Sub readSelectedMelee()
        Dim bteFormat As New BTEFormatReader(bteMyMelee, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Weapon.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
    End Sub

    Public Sub readSelectedGrenade()
        Dim bteFormat As New BTEFormatReader(bteMyGrenade, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Weapon.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("id"))
                .SubItems.Add(bteFormat(i)("model"))
            End With
        Next
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

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If fromWhere = "pri1" Then
                frmQuickBuy.pri1m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri1m & ".png")
            ElseIf fromWhere = "pri2" Then
                frmQuickBuy.pri2m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri2m & ".png")
            ElseIf fromWhere = "pri3" Then
                frmQuickBuy.pri3m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri3m & ".png")
            ElseIf fromWhere = "pri4" Then
                frmQuickBuy.pri4m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri4m & ".png")
            ElseIf fromWhere = "pri5" Then
                frmQuickBuy.pri5m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri5m & ".png")
            ElseIf fromWhere = "sec1" Then
                frmQuickBuy.sec1m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec1m & ".png")
            ElseIf fromWhere = "sec2" Then
                frmQuickBuy.sec2m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec2m & ".png")
            ElseIf fromWhere = "sec3" Then
                frmQuickBuy.sec3m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec3m & ".png")
            ElseIf fromWhere = "sec4" Then
                frmQuickBuy.sec4m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec4m & ".png")
            ElseIf fromWhere = "sec5" Then
                frmQuickBuy.sec5m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec5m & ".png")
            ElseIf fromWhere = "mel1" Then
                frmQuickBuy.mel1m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel1m & ".png")
            ElseIf fromWhere = "mel2" Then
                frmQuickBuy.mel2m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel2m & ".png")
            ElseIf fromWhere = "mel3" Then
                frmQuickBuy.mel3m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel3m & ".png")
            ElseIf fromWhere = "mel4" Then
                frmQuickBuy.mel4m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel4m & ".png")
            ElseIf fromWhere = "mel5" Then
                frmQuickBuy.mel5m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel5m & ".png")
            ElseIf fromWhere = "gre1" Then
                frmQuickBuy.gre1m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre1m & ".png")
            ElseIf fromWhere = "gre2" Then
                frmQuickBuy.gre2m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre2m & ".png")
            ElseIf fromWhere = "gre3" Then
                frmQuickBuy.gre3m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre3m & ".png")
            ElseIf fromWhere = "gre4" Then
                frmQuickBuy.gre4m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre4m & ".png")
            ElseIf fromWhere = "gre5" Then
                frmQuickBuy.gre5m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre5m & ".png")
            ElseIf fromWhere = "pri1t" Then
                frmTeamSuit.pri1m = lbl_Model.Text
                frmTeamSuit.lbl_PriWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_PriWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.pri1m & ".png")
            ElseIf fromWhere = "pri2t" Then
                frmTeamSuit.pri2m = lbl_Model.Text
                frmTeamSuit.lbl_PriWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_PriWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.pri2m & ".png")
            ElseIf fromWhere = "pri3t" Then
                frmTeamSuit.pri3m = lbl_Model.Text
                frmTeamSuit.lbl_PriWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_PriWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.pri3m & ".png")
            ElseIf fromWhere = "sec1t" Then
                frmTeamSuit.sec1m = lbl_Model.Text
                frmTeamSuit.lbl_SecWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_SecWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.sec1m & ".png")
            ElseIf fromWhere = "sec2t" Then
                frmTeamSuit.sec2m = lbl_Model.Text
                frmTeamSuit.lbl_SecWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_SecWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.sec2m & ".png")
            ElseIf fromWhere = "sec3t" Then
                frmTeamSuit.sec3m = lbl_Model.Text
                frmTeamSuit.lbl_SecWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_SecWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.sec3m & ".png")
            ElseIf fromWhere = "mel1t" Then
                frmTeamSuit.mel1m = lbl_Model.Text
                frmTeamSuit.lbl_MelWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_MelWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.mel1m & ".png")
            ElseIf fromWhere = "mel2t" Then
                frmTeamSuit.mel2m = lbl_Model.Text
                frmTeamSuit.lbl_MelWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_MelWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.mel2m & ".png")
            ElseIf fromWhere = "mel3t" Then
                frmTeamSuit.mel3m = lbl_Model.Text
                frmTeamSuit.lbl_MelWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_MelWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.mel3m & ".png")
            ElseIf fromWhere = "gre1t" Then
                frmTeamSuit.gre1m = lbl_Model.Text
                frmTeamSuit.lbl_GreWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_GreWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.gre1m & ".png")
            ElseIf fromWhere = "gre2t" Then
                frmTeamSuit.gre2m = lbl_Model.Text
                frmTeamSuit.lbl_GreWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_GreWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.gre2m & ".png")
            ElseIf fromWhere = "gre3t" Then
                frmTeamSuit.gre3m = lbl_Model.Text
                frmTeamSuit.lbl_GreWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_GreWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.gre3m & ".png")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        lv_Weapon.Items.Clear()
        frmQuickBuy.TopMost = True
        frmTeamSuit.TopMost = True
        Me.Hide()
    End Sub

    Private Sub frmWeapon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetWindowTheme(lv_Weapon.Handle, "Explorer", Nothing)

        frmQuickBuy.TopMost = False
        frmTeamSuit.TopMost = False
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        If fromWhere.Contains("t") Then
            frmTeamSuit.Show()
            frmTeamSuit.TopMost = True
            lv_Weapon.Items.Clear()
            Me.Hide()
        Else
            frmQuickBuy.Show()
            frmQuickBuy.TopMost = True
            lv_Weapon.Items.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub lv_Weapon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_Weapon.DoubleClick
        Try
            If fromWhere = "pri1" Then
                frmQuickBuy.pri1m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri1m & ".png")
            ElseIf fromWhere = "pri2" Then
                frmQuickBuy.pri2m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri2m & ".png")
            ElseIf fromWhere = "pri3" Then
                frmQuickBuy.pri3m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri3m & ".png")
            ElseIf fromWhere = "pri4" Then
                frmQuickBuy.pri4m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri4m & ".png")
            ElseIf fromWhere = "pri5" Then
                frmQuickBuy.pri5m = lbl_Model.Text
                frmQuickBuy.lbl_PriWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_PriWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.pri5m & ".png")
            ElseIf fromWhere = "sec1" Then
                frmQuickBuy.sec1m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec1m & ".png")
            ElseIf fromWhere = "sec2" Then
                frmQuickBuy.sec2m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec2m & ".png")
            ElseIf fromWhere = "sec3" Then
                frmQuickBuy.sec3m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec3m & ".png")
            ElseIf fromWhere = "sec4" Then
                frmQuickBuy.sec4m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec4m & ".png")
            ElseIf fromWhere = "sec5" Then
                frmQuickBuy.sec5m = lbl_Model.Text
                frmQuickBuy.lbl_SecWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_SecWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.sec5m & ".png")
            ElseIf fromWhere = "mel1" Then
                frmQuickBuy.mel1m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel1m & ".png")
            ElseIf fromWhere = "mel2" Then
                frmQuickBuy.mel2m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel2m & ".png")
            ElseIf fromWhere = "mel3" Then
                frmQuickBuy.mel3m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel3m & ".png")
            ElseIf fromWhere = "mel4" Then
                frmQuickBuy.mel4m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel4m & ".png")
            ElseIf fromWhere = "mel5" Then
                frmQuickBuy.mel5m = lbl_Model.Text
                frmQuickBuy.lbl_MelWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_MelWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.mel5m & ".png")
            ElseIf fromWhere = "gre1" Then
                frmQuickBuy.gre1m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn1.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre1m & ".png")
            ElseIf fromWhere = "gre2" Then
                frmQuickBuy.gre2m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn2.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre2m & ".png")
            ElseIf fromWhere = "gre3" Then
                frmQuickBuy.gre3m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn3.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre3m & ".png")
            ElseIf fromWhere = "gre4" Then
                frmQuickBuy.gre4m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn4.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre4m & ".png")
            ElseIf fromWhere = "gre5" Then
                frmQuickBuy.gre5m = lbl_Model.Text
                frmQuickBuy.lbl_GreWpn5.Text = lbl_Name.Text
                frmQuickBuy.pb_GreWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmQuickBuy.gre5m & ".png")
            ElseIf fromWhere = "pri1t" Then
                frmTeamSuit.pri1m = lbl_Model.Text
                frmTeamSuit.lbl_PriWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_PriWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.pri1m & ".png")
            ElseIf fromWhere = "pri2t" Then
                frmTeamSuit.pri2m = lbl_Model.Text
                frmTeamSuit.lbl_PriWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_PriWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.pri2m & ".png")
            ElseIf fromWhere = "pri3t" Then
                frmTeamSuit.pri3m = lbl_Model.Text
                frmTeamSuit.lbl_PriWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_PriWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.pri3m & ".png")
            ElseIf fromWhere = "sec1t" Then
                frmTeamSuit.sec1m = lbl_Model.Text
                frmTeamSuit.lbl_SecWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_SecWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.sec1m & ".png")
            ElseIf fromWhere = "sec2t" Then
                frmTeamSuit.sec2m = lbl_Model.Text
                frmTeamSuit.lbl_SecWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_SecWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.sec2m & ".png")
            ElseIf fromWhere = "sec3t" Then
                frmTeamSuit.sec3m = lbl_Model.Text
                frmTeamSuit.lbl_SecWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_SecWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.sec3m & ".png")
            ElseIf fromWhere = "mel1t" Then
                frmTeamSuit.mel1m = lbl_Model.Text
                frmTeamSuit.lbl_MelWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_MelWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.mel1m & ".png")
            ElseIf fromWhere = "mel2t" Then
                frmTeamSuit.mel2m = lbl_Model.Text
                frmTeamSuit.lbl_MelWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_MelWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.mel2m & ".png")
            ElseIf fromWhere = "mel3t" Then
                frmTeamSuit.mel3m = lbl_Model.Text
                frmTeamSuit.lbl_MelWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_MelWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.mel3m & ".png")
            ElseIf fromWhere = "gre1t" Then
                frmTeamSuit.gre1m = lbl_Model.Text
                frmTeamSuit.lbl_GreWpn1.Text = lbl_Name.Text
                frmTeamSuit.pb_GreWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.gre1m & ".png")
            ElseIf fromWhere = "gre2t" Then
                frmTeamSuit.gre2m = lbl_Model.Text
                frmTeamSuit.lbl_GreWpn2.Text = lbl_Name.Text
                frmTeamSuit.pb_GreWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.gre2m & ".png")
            ElseIf fromWhere = "gre3t" Then
                frmTeamSuit.gre3m = lbl_Model.Text
                frmTeamSuit.lbl_GreWpn3.Text = lbl_Name.Text
                frmTeamSuit.pb_GreWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & frmTeamSuit.gre3m & ".png")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        frmQuickBuy.TopMost = True
        frmTeamSuit.TopMost = True
        lv_Weapon.Items.Clear()
        Me.Hide()
    End Sub

    Private Sub lv_Weapon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Weapon.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_id.Text = lv_Weapon.SelectedItems(0).SubItems(1).Text
        lbl_Name.Text = lv_Weapon.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_Weapon.SelectedItems(0).SubItems(2).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & lbl_Model.Text & ".png")
        pb_Damage.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Damage")
        pb_HitRate.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "HitRate")
        pb_Reaction.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Reaction")
        pb_FiringSpeed.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "FiringSpeed")
        pb_Weight.Value = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Weight")
        lbl_Cost.Text = "$" & ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "Cost")
        lbl_Ammo.Text = ReadIniValue(My.Application.Info.DirectoryPath & "\metahook\weapons.ini", lbl_Model.Text.ToUpper, "BpAmmo")
    End Sub
End Class