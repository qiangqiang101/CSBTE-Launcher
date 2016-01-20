Imports System.Runtime.InteropServices
Public Class frmPlayer

    Private launcherPlayer As String = My.Application.Info.DirectoryPath & "\launcher\player.ini"
    Private launcherMyPlayer As String = My.Application.Info.DirectoryPath & "\launcher\myplayer.ini"
    Private btePlayer As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_player.ini"
    Private items As New ListViewItem()
    Dim selModel As String = ""
    Private parameters As String() = {"[name]", "[model]", "[team]", "[sex]", "[hand]", "[radio]", "[tattoo]", "[emotion]"}

    <DllImport("uxtheme.dll", ExactSpelling:=True, CharSet:=CharSet.Unicode)> _
    Private Shared Function SetWindowTheme(ByVal hwnd As IntPtr, ByVal pszSubAppName As String, ByVal pszSubIdList As String) As Integer
    End Function

    Public Sub readPlayer()
        Dim bteFormat As New BTEFormatReader(launcherPlayer, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_Player.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("model"))
                .SubItems.Add(bteFormat(i)("team"))
                .SubItems.Add(bteFormat(i)("sex"))
                .SubItems.Add(bteFormat(i)("hand"))
                .SubItems.Add(bteFormat(i)("radio"))
                .SubItems.Add(bteFormat(i)("tattoo"))
                .SubItems.Add(bteFormat(i)("emotion"))
            End With
        Next
    End Sub

    Public Sub readMyPlayer()
        Dim bteFormat As New BTEFormatReader(launcherMyPlayer, parameters)

        For i As Integer = 0 To bteFormat.Count - 1
            items = lv_MyPlayer.Items.Add(bteFormat(i)("name"))
            With items
                .SubItems.Add(bteFormat(i)("model"))
                .SubItems.Add(bteFormat(i)("team"))
                .SubItems.Add(bteFormat(i)("sex"))
                .SubItems.Add(bteFormat(i)("hand"))
                .SubItems.Add(bteFormat(i)("radio"))
                .SubItems.Add(bteFormat(i)("tattoo"))
                .SubItems.Add(bteFormat(i)("emotion"))
            End With
        Next
    End Sub

    Private Sub lv_Player_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv_Player.DoubleClick
        If selModel.Contains(lbl_Model.Text & ",") Then
            Exit Sub
        ElseIf txt_SelName.Text = "" Then
            lv_MyPlayer.Items.Clear()
            GoTo 2
        Else
2:
            txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
            selModel = selModel + lbl_Model.Text & ","
            If lv_Player.SelectedItems(0).SubItems(2).Text = "1" Then
                lbl_SelectedT.Text = lbl_SelectedT.Text + 1
            Else
                lbl_SelectedCT.Text = lbl_SelectedCT.Text + 1
            End If
            If lbl_SelectedCT.Text > 19 Then
                lbl_SelectedCT.ForeColor = Color.Red
            Else
                lbl_SelectedCT.ForeColor = Color.White
            End If
            If lbl_SelectedT.Text > 19 Then
                lbl_SelectedT.ForeColor = Color.Red
            Else
                lbl_SelectedT.ForeColor = Color.White
            End If
            Dim line = lv_Player.SelectedIndices(0)
            lv_MyPlayer.Items.Add(lv_Player.Items(line).Clone())
        End If
    End Sub

    Private Sub lv_Player_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Player.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_Name.Text = lv_Player.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_Player.SelectedItems(0).SubItems(1).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\plyimg\" & lbl_Model.Text & ".png")
        'lbl_Team.Text = lv_Player.SelectedItems(0).SubItems(2).Text
        lbl_Sex.Text = lv_Player.SelectedItems(0).SubItems(3).Text

        If lv_Player.SelectedItems(0).SubItems(2).Text = "1" Then
            lbl_Team.Text = "Terrorist Force"
        Else
            lbl_Team.Text = "Counter-Terrorist Force"
        End If
        If lv_Player.SelectedItems(0).SubItems(3).Text = "1" Then
            lbl_Sex.Text = "Male"
        Else
            lbl_Sex.Text = "Female"
        End If
    End Sub

    Private Sub refreshCtrls()
        
    End Sub

    Private Sub frmPlayer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetWindowTheme(lv_Player.Handle, "Explorer", Nothing)
        SetWindowTheme(lv_MyPlayer.Handle, "Explorer", Nothing)

        readPlayer()
        readMyPlayer()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Hide()
    End Sub

    Private Sub btn_Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Select.Click
        If selModel.Contains(lbl_Model.Text & ",") Then
            Exit Sub
        ElseIf txt_SelName.Text = "" Then
            lv_MyPlayer.Items.Clear()
            GoTo 2
        Else
2:
            txt_SelName.Text = txt_SelName.Text + lbl_Name.Text & ", "
            selModel = selModel + lbl_Model.Text & ","
            If lv_Player.SelectedItems(0).SubItems(2).Text = "1" Then
                lbl_SelectedT.Text = lbl_SelectedT.Text + 1
            Else
                lbl_SelectedCT.Text = lbl_SelectedCT.Text + 1
            End If
            If lbl_SelectedCT.Text > 19 Then
                lbl_SelectedCT.ForeColor = Color.Red
            Else
                lbl_SelectedCT.ForeColor = Color.White
            End If
            If lbl_SelectedT.Text > 19 Then
                lbl_SelectedT.ForeColor = Color.Red
            Else
                lbl_SelectedT.ForeColor = Color.White
            End If
            Dim line = lv_Player.SelectedIndices(0)
            lv_MyPlayer.Items.Add(lv_Player.Items(line).Clone())
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_player.ini")
            System.IO.File.Create(My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_player.ini").Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim myPlayer As String = My.Application.Info.DirectoryPath & "\cstrike\addons\amxmodx\configs\bte_player.ini"
        Dim myPlayer2 As String = My.Application.Info.DirectoryPath & "\launcher\myplayer.ini"
        Dim SW As New System.IO.StreamWriter(myPlayer)
        Dim SW2 As New System.IO.StreamWriter(myPlayer2)
        SW.Write("SET_MODEL_INDEX = 1" & Environment.NewLine)

        For Each myPlayerItem As ListViewItem In lv_MyPlayer.Items
            SW.WriteLine("[name]" & myPlayerItem.Text & "[model]" & myPlayerItem.SubItems(1).Text & "[team]" & myPlayerItem.SubItems(2).Text & _
                      "[sex]" & myPlayerItem.SubItems(3).Text & "[hand]" & myPlayerItem.SubItems(4).Text & "[radio]" & myPlayerItem.SubItems(5).Text & _
                      "[tattoo]" & myPlayerItem.SubItems(6).Text & "[emotion]" & myPlayerItem.SubItems(6).Text)
        Next
        SW.Close()

        For Each myPlayerItem As ListViewItem In lv_MyPlayer.Items
            SW2.Write("[name]" & myPlayerItem.Text & "[model]" & myPlayerItem.SubItems(1).Text & "[team]" & myPlayerItem.SubItems(2).Text & _
                          "[sex]" & myPlayerItem.SubItems(3).Text & "[hand]" & myPlayerItem.SubItems(4).Text & "[radio]" & myPlayerItem.SubItems(5).Text & _
                          "[tattoo]" & myPlayerItem.SubItems(6).Text & "[emotion]" & myPlayerItem.SubItems(6).Text & Environment.NewLine)
        Next
        SW2.Close()
        MsgBox("You have selected: " & txt_SelName.Text, MsgBoxStyle.Information, "Info")
        Me.Close()
    End Sub

    Private Sub lv_MyPlayer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_MyPlayer.SelectedIndexChanged
        On Error Resume Next
        refreshCtrls()
        lbl_Name.Text = lv_MyPlayer.SelectedItems.Item(0).Text
        lbl_Model.Text = lv_MyPlayer.SelectedItems(0).SubItems(1).Text
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\plyimg\" & lbl_Model.Text & ".png")
        'lbl_Team.Text = lv_Player.SelectedItems(0).SubItems(2).Text
        'lbl_Sex.Text = lv_MyPlayer.SelectedItems(0).SubItems(3).Text

        If lv_MyPlayer.SelectedItems(0).SubItems(2).Text = "1" Then
            lbl_Team.Text = "Terrorist Force"
        Else
            lbl_Team.Text = "Counter-Terrorist Force"
        End If
        If lv_MyPlayer.SelectedItems(0).SubItems(3).Text = "1" Then
            lbl_Sex.Text = "Male"
        Else
            lbl_Sex.Text = "Female"
        End If
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        lv_MyPlayer.Items.Clear()
        txt_SelName.Text = ""
        selModel = ""
        lbl_SelectedCT.Text = 0
        lbl_SelectedT.Text = 0
    End Sub
End Class