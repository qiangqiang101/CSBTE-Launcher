Public Class frmJoin


    Private Sub btn_JoinSvr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_JoinSvr.Click
        My.Settings.IP = txt_IPAddress.Text
        My.Settings.Port = txt_Port.Text
        My.Settings.Save()

        Try
            Shell(My.Application.Info.DirectoryPath & "\cstrike.exe +connect " & txt_IPAddress.Text & ":" & txt_Port.Text, AppWinStyle.NormalFocus)
            Me.Hide()
            frmBackground2.Hide()
            My.Computer.Audio.Stop()
            frmMode.NotifyIcon1.Visible = True
            frmMode.NotifyIcon1.ShowBalloonTip(10)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Hide()
    End Sub

    Private Sub frmJoin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_IPAddress.Text = My.Settings.IP
        txt_Port.Text = My.Settings.Port
    End Sub
End Class