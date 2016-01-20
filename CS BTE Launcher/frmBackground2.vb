Public Class frmBackground2

    Function GetGreatestCommonDivisor(ByVal a As Integer, ByVal b As Integer) As Integer
        While b > 0
            GetGreatestCommonDivisor = a Mod b
            a = b
            b = GetGreatestCommonDivisor
        End While
        Return a
    End Function

    Private Sub frmBackground2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AR As Point = Nothing
        AR.X = CDbl(Screen.PrimaryScreen.Bounds.Width)
        AR.Y = CDbl(Screen.PrimaryScreen.Bounds.Height)
        Dim GCD As Integer = GetGreatestCommonDivisor(CInt(AR.X), CInt(AR.Y))
        Dim DAR As New Point With {.X = AR.X / GCD, .Y = AR.Y / GCD}

        If GCD = 16 Then
            Me.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\bg_pic_hd.jpg")
        Else
            Me.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\bg_pic.jpg")
        End If

        frmMode.Show()
        frmMode.Hide()

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
    End Sub

    Private Sub llbl_CreateGame_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_CreateGame.LinkClicked
        frmLauncher.Show()
    End Sub

    Private Sub llbl_HLDS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_HLDS.LinkClicked
        frmHLDS.Show()
    End Sub

    Private Sub llbl_StartNormal_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_StartNormal.LinkClicked
        Try
            Shell(My.Application.Info.DirectoryPath & "\cstrike.exe", AppWinStyle.NormalFocus)
            frmCangku.Hide()
            frmHLDS.Hide()
            frmJoin.Hide()
            frmLauncher.Hide()
            frmMode.Hide()
            frmOption.Hide()
            frmQuickBuy.Hide()
            frmTeamSuit.Hide()
            frmWeapon.Hide()
            Me.Hide()
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(10)
            My.Computer.Audio.Stop()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub llbl_JoinSvr_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_JoinSvr.LinkClicked
        frmJoin.Show()
    End Sub

    Private Sub llbl_WeaponSel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_WeaponSel.LinkClicked
        frmCangku.Show()
    End Sub

    Private Sub llbl_Settings_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_Settings.LinkClicked
        frmOption.Show()
    End Sub

    Private Sub llbl_Update_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_Update.LinkClicked
        Try
            Shell(My.Application.Info.DirectoryPath & "\patcher.exe /patcher_run", AppWinStyle.NormalFocus)
            End
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub llbl_End_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_End.LinkClicked
        frmMsgbox.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
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

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMsgbox.Show()
    End Sub

    Private Sub btn_Min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Min.Click
        Try
            frmCangku.Hide()
            frmHLDS.Hide()
            frmJoin.Hide()
            frmLauncher.Hide()
            frmMode.Hide()
            frmOption.Hide()
            frmQuickBuy.Hide()
            frmTeamSuit.Hide()
            frmWeapon.Hide()
            Me.Hide()
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(10)
            My.Computer.Audio.Stop()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub llbl_PlayerSel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_PlayerSel.LinkClicked
        frmPlayer.Show()
    End Sub
End Class