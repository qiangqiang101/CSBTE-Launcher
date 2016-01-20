Public Class frmHLDS

    Dim inpBox As String
    Dim lines() As String = IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\launcher\map_list.txt")

    Private Sub frmHLDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_IpAddress.Text = My.Settings.HLDS_IP
        txt_Port.Text = My.Settings.HLDS_Port
        txt_MaxPlayer.Text = My.Settings.HLDS_MaxPlayer
        txt_RCONPwd.Text = My.Settings.HLDS_Password
        cmb_Map.Items.AddRange(lines)
        cmb_Map.SelectedItem = My.Settings.HLDS_Map
    End Sub

    Private Sub btn_HLDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HLDS.Click
        My.Settings.HLDS_IP = txt_IPAddress.Text
        My.Settings.HLDS_Port = txt_Port.Text
        My.Settings.HLDS_MaxPlayer = txt_MaxPlayer.Text
        My.Settings.HLDS_Password = txt_RCONPwd.Text
        My.Settings.HLDS_Map = cmb_Map.SelectedItem
        My.Settings.Save()

        Try
            Shell(My.Application.Info.DirectoryPath & "\hlds.exe -game cstrike +port " & txt_Port.Text & " +ip " & txt_IpAddress.Text & " +map " & cmb_Map.SelectedItem & ".bsp +maxplayers " & _
                  txt_MaxPlayer.Text & " +rcon_password " & txt_RCONPwd.Text & " -noipx -noaff -master -insecure -console +sv_lan 0 +exec server.cfg", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Hide()
    End Sub
End Class