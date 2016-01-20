Public Class frmLauncher

    Private bteUserConfig As String = My.Application.Info.DirectoryPath & "\cstrike\userconfig.cfg"
    Private bteConfig As String = My.Application.Info.DirectoryPath & "\cstrike\config.cfg"
    Private bteServer As String = My.Application.Info.DirectoryPath & "\cstrike\server.cfg"
    Private bteBotConfig As String = My.Application.Info.DirectoryPath & "\cstrike\launcher.cfg"
    Dim lines() As String = System.IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\launcher\map_list.txt")

    Dim botDifficulty As Integer = ReadCfgValue("bot_difficulty", bteBotConfig)
    Dim svLan As Integer = ReadCfgValue("sv_lan", bteBotConfig)

    Dim deathCamType As Integer = ReadCfgValue("mp_forcecamera", bteServer)
    Dim enableAllTalk As Integer = ReadCfgValue("sv_alltalk", bteServer)
    Dim enableVoice As Integer = ReadCfgValue("sv_voiceenable", bteServer)
    Dim voiceQuality As Integer = ReadCfgValue("sv_voicequality", bteServer)
    Dim logFilling As Integer = ReadCfgValue("mp_logfile", bteServer)
    Dim logMsg As Integer = ReadCfgValue("mp_logmessages", bteServer)
    Dim logDetail As Integer = ReadCfgValue("mp_logdetail", bteServer)
    Dim allowDownload As Integer = ReadCfgValue("sv_allowdownload", bteServer)
    Dim allowFlashlight As Integer = ReadCfgValue("mp_flashlight", bteServer)
    Dim allowSpectator As Integer = ReadCfgValue("allow_spectators", bteServer)
    Dim allowUpload As Integer = ReadCfgValue("sv_allowupload", bteServer)
    Dim disableChaseDeathCam As Integer = ReadCfgValue("mp_fadetoblack", bteServer)
    Dim autoTeamBalance As Integer = ReadCfgValue("mp_autoteambalance", bteServer)
    Dim fallDamage As Integer = ReadCfgValue("mp_falldamage", bteServer)
    Dim friendlyGrenade As Integer = ReadCfgValue("mp_friendly_grenade_damage", bteServer)
    Dim footSteps As Integer = ReadCfgValue("mp_footsteps", bteServer)
    Dim friendlyFire As Integer = ReadCfgValue("mp_friendlyfire", bteServer)
    Dim kickIdlerTKer As Integer = ReadCfgValue("mp_autokick", bteServer)
    Dim killTKer As Integer = ReadCfgValue("mp_tkpunish", bteServer)
    Dim sendLogo As Integer = ReadCfgValue("sv_send_logos", bteServer)
    Dim sendResources As Integer = ReadCfgValue("sv_send_resources", bteServer)

    Dim botJoinTeam As String = ReadCfgValue("bot_join_team", bteBotConfig)
    Dim botRadio As String = ReadCfgValue("bot_chatter", bteBotConfig)
    Dim botJoinAfterPlayer As Integer = ReadCfgValue("bot_join_after_player", bteBotConfig)
    Dim botDeferGoal As Integer = ReadCfgValue("bot_defer_to_human", bteBotConfig)
    Dim botRogue As Integer = ReadCfgValue("bot_allow_rogues", bteBotConfig)
    Dim botPistol As Integer = ReadCfgValue("bot_allow_pistols", bteBotConfig)
    Dim botShotgun As Integer = ReadCfgValue("bot_allow_shotguns", bteBotConfig)
    Dim botSubmachinegun As Integer = ReadCfgValue("bot_allow_sub_machine_guns", bteBotConfig)
    Dim botMachinegun As Integer = ReadCfgValue("bot_allow_machine_guns", bteBotConfig)
    Dim botRifle As Integer = ReadCfgValue("bot_allow_rifles", bteBotConfig)
    Dim botGrenade As Integer = ReadCfgValue("bot_allow_grenades", bteBotConfig)
    Dim botSniper As Integer = ReadCfgValue("bot_allow_snipers", bteBotConfig)

    Private Function GetHostIP(ByVal af As System.Net.Sockets.AddressFamily) As String

        Dim host As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        Dim strRet As String = ""

        For Each ip As System.Net.IPAddress In host.AddressList
            If ip.AddressFamily = af Then
                strRet = ip.ToString
                Exit For
            End If
        Next

        Return strRet

    End Function

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Hide()
    End Sub

    Public Sub readMap()
        pb_Map.Image = My.Resources.random_cso

        If frmMode.lbl_Mode.Text = "Basic" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("awp_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("dm_") Then
                                    If Not cmb_Map.Items(n).ToString.Contains("fy_") Then
                                        cmb_Map.Items.RemoveAt(n)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Original" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("awp_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("dm_") Then
                                    If Not cmb_Map.Items(n).ToString.Contains("fy_") Then
                                        cmb_Map.Items.RemoveAt(n)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Deathmatch" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("awp_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("dm_") Then
                                    If Not cmb_Map.Items(n).ToString.Contains("fy_") Then
                                        cmb_Map.Items.RemoveAt(n)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "NN Deathmatch" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("awp_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("dm_") Then
                                    If Not cmb_Map.Items(n).ToString.Contains("fy_") Then
                                        cmb_Map.Items.RemoveAt(n)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Team Deathmatch" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("awp_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("dm_") Then
                                    If Not cmb_Map.Items(n).ToString.Contains("fy_") Then
                                        If Not cmb_Map.Items(n).ToString.Contains("fun_") Then
                                            cmb_Map.Items.RemoveAt(n)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Gun Deathmatch" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("awp_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("dm_") Then
                                    If Not cmb_Map.Items(n).ToString.Contains("fy_") Then
                                        cmb_Map.Items.RemoveAt(n)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Zombie Mode 1" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("zm_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("bzm_") Then
                                    cmb_Map.Items.RemoveAt(n)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Zombie Mode 3" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("zm_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("bzm_") Then
                                    cmb_Map.Items.RemoveAt(n)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Zombie Mode 4" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("de_") Then
                    If Not cmb_Map.Items(n).ToString.Contains("cs_") Then
                        If Not cmb_Map.Items(n).ToString.Contains("as_") Then
                            If Not cmb_Map.Items(n).ToString.Contains("zm_") Then
                                If Not cmb_Map.Items(n).ToString.Contains("bzm_") Then
                                    cmb_Map.Items.RemoveAt(n)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Zombie Scenario" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("zs_") Then
                    cmb_Map.Items.RemoveAt(n)
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Zombie Escape" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("ze_") Then
                    cmb_Map.Items.RemoveAt(n)
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Deathrun" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("cso_") Then
                    cmb_Map.Items.RemoveAt(n)
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Hidden Mode" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("hd_") Then
                    cmb_Map.Items.RemoveAt(n)
                End If
            Next
        End If

        If frmMode.lbl_Mode.Text = "Fun Mode" Then
            cmb_Map.Items.AddRange(lines)
            For n As Integer = cmb_Map.Items.Count - 1 To 0 Step -1
                If Not cmb_Map.Items(n).ToString.Contains("bk_") Then
                    cmb_Map.Items.RemoveAt(n)
                End If
            Next
        End If
    End Sub

    Private Sub frmLauncher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = frmMode.Left + 330
        Me.Top = frmMode.Top + 1

        lbl_IpAddress.Text = GetHostIP(Net.Sockets.AddressFamily.InterNetwork)

        readMap()
        'cmb_Map.Items.AddRange(lines)
            cmb_Map.SelectedItem = My.Settings.HLDS_Map
            lbl_Mode.Text = frmMode.lbl_Mode.Text
            If My.Settings.Bot_Enable = "Enable" Then
                chk_IncludeBOT.Checked = True
            Else
                chk_IncludeBOT.Checked = False
            End If
            If chk_IncludeBOT.Checked = True Then
                txt_BotAmount.Enabled = True
                cmb_BotLevel.Enabled = True
            Else
                txt_BotAmount.Enabled = False
                cmb_BotLevel.Enabled = False
            End If
            txt_BotAmount.Text = ReadCfgValue("bot_quota", bteBotConfig)
            If botDifficulty = 0 Then
                cmb_BotLevel.SelectedItem = "Easy"
            ElseIf botDifficulty = 1 Then
                cmb_BotLevel.SelectedItem = "Normal"
            ElseIf botDifficulty = 2 Then
                cmb_BotLevel.SelectedItem = "Hard"
            ElseIf botDifficulty = 3 Then
                cmb_BotLevel.SelectedItem = "Expert"
            Else
                cmb_BotLevel.SelectedItem = Nothing
            End If
        If svLan = 1 Then
            cmb_Lan.SelectedItem = "LAN"
        Else
            cmb_Lan.SelectedItem = "Internet"
        End If

            txt_HostName.Text = ReadCfgValue("hostname", bteServer)
        txt_MaxPlayers.Text = My.Settings.HLDS_MaxPlayer
            txt_SvrPwd.Text = ReadCfgValue("sv_password", bteServer)
            txt_RconPwd.Text = ReadCfgValue("rcon_password", bteServer)
            txt_MapTime.Text = ReadCfgValue("mp_timelimit", bteServer)
            txt_WinLimit.Text = ReadCfgValue("mp_winlimit", bteServer)
            txt_FragLimit.Text = ReadCfgValue("mp_fraglimit", bteServer)
            txt_RoundLimit.Text = ReadCfgValue("mp_maxrounds", bteServer)
            txt_RoundTime.Text = ReadCfgValue("mp_roundtime", bteServer)
            txt_FreezeTime.Text = ReadCfgValue("mp_freezetime", bteServer)
            txt_BuyTime.Text = ReadCfgValue("mp_buytime", bteServer)
            txt_C4Timer.Text = ReadCfgValue("mp_c4timer", bteServer)
            txt_StartingMoney.Text = ReadCfgValue("mp_startmoney", bteServer)
            txt_HostageKill.Text = ReadCfgValue("mp_hostagepenalty", bteServer)
            txt_DecalFreq.Text = ReadCfgValue("decalfrequency", bteServer)
            txt_LimitTeamPlayers.Text = ReadCfgValue("mp_limitteams", bteServer)
            txt_MaxRate.Text = ReadCfgValue("sv_maxrate", bteServer)
            If deathCamType = 0 Then
                cmb_DeathCamType.SelectedItem = "Spectate anyone"
            ElseIf deathCamType = 1 Then
                cmb_DeathCamType.SelectedItem = "Spectate team only"
            Else
                cmb_DeathCamType.SelectedItem = "Only first-person"
            End If
            If enableAllTalk = 1 Then
                chk_AllTalk.Checked = True
            Else
                chk_AllTalk.Checked = False
            End If
            If enableVoice = 1 Then
                chk_EnableVoice.Checked = True
            Else
                chk_EnableVoice.Checked = False
            End If
            If voiceQuality = 0 Then
                cmb_VoiceQuality.SelectedItem = "Extremely Low"
            ElseIf voiceQuality = 1 Then
                cmb_VoiceQuality.SelectedItem = "Very Low"
            ElseIf voiceQuality = 2 Then
                cmb_VoiceQuality.SelectedItem = "Low"
            ElseIf voiceQuality = 3 Then
                cmb_VoiceQuality.SelectedItem = "Medium"
            ElseIf voiceQuality = 4 Then
                cmb_VoiceQuality.SelectedItem = "High"
            ElseIf voiceQuality = 5 Then
                cmb_VoiceQuality.SelectedItem = "Very High"
            End If
            If logFilling = 1 Then
                chk_LogFiling.Checked = True
            Else
                chk_LogFiling.Checked = False
            End If
            If logMsg = 1 Then
                chk_LoggingMsg.Checked = True
            Else
                chk_LoggingMsg.Checked = False
            End If
            If logDetail = 0 Then
                cmb_LoggingDetail.SelectedItem = "No Log"
            ElseIf logDetail = 1 Then
                cmb_LoggingDetail.SelectedItem = "Enemy Damage"
            ElseIf logDetail = 2 Then
                cmb_LoggingDetail.SelectedItem = "Teammate Damage"
            ElseIf logDetail = 3 Then
                cmb_LoggingDetail.SelectedItem = "Both"
            End If
            If allowDownload = 1 Then
                chk_Download.Checked = True
            Else
                chk_Download.Checked = False
            End If
            If allowFlashlight = 1 Then
                chk_Flashlight.Checked = True
            Else
                chk_Flashlight.Checked = False
            End If
            If allowSpectator = 1 Then
                chk_Spectators.Checked = True
            Else
                chk_Spectators.Checked = False
            End If
            If allowUpload = 1 Then
                chk_Upload.Checked = True
            Else
                chk_Upload.Checked = False
            End If
            If disableChaseDeathCam = 1 Then
                chk_ChaseDeathCam.Checked = True
            Else
                chk_ChaseDeathCam.Checked = False
            End If
            If autoTeamBalance = 1 Then
                chk_AutoTeamBalance.Checked = True
            Else
                chk_AutoTeamBalance.Checked = False
            End If
            If fallDamage = 1 Then
                chk_FallDmg.Checked = True
            Else
                chk_FallDmg.Checked = False
            End If
            If friendlyGrenade = 1 Then
                chk_FriendlyGrenadeDmg.Checked = True
            Else
                chk_FriendlyGrenadeDmg.Checked = False
            End If
            If footSteps = 1 Then
                chk_Footsteps.Checked = True
            Else
                chk_Footsteps.Checked = False
            End If
            If friendlyFire = 1 Then
                chk_FriendlyFire.Checked = True
            Else
                chk_FriendlyFire.Checked = False
            End If
            If kickIdlerTKer = 1 Then
                chk_KickIdler.Checked = True
            Else
                chk_KickIdler.Checked = False
            End If
            If killTKer = 1 Then
                chk_KillTKer.Checked = True
            Else
                chk_KillTKer.Checked = False
            End If
            If sendLogo = 1 Then
                chk_SendLogo.Checked = True
            Else
                chk_SendLogo.Checked = False
            End If
            If sendResources = 1 Then
                chk_SendResource.Checked = True
            Else
                chk_SendResource.Checked = False
            End If

        txt_BotNamePrefix.Text = ReadCfgValue("bot_prefix", bteBotConfig)
        If botJoinTeam = "any" Then
            cmb_BotJoinTeam.SelectedItem = "Random"
        ElseIf botJoinTeam = "T" Then
            cmb_BotJoinTeam.SelectedItem = "Terrorists"
        ElseIf botJoinTeam = "CT" Then
            cmb_BotJoinTeam.SelectedItem = "Counter-Terrorists"
        End If
        If botRadio = "off" Then
            cmb_BotRadioChatter.SelectedItem = "Off"
        ElseIf botRadio = "normal" Then
            cmb_BotRadioChatter.SelectedItem = "Normal"
        ElseIf botRadio = "minimal" Then
            cmb_BotRadioChatter.SelectedItem = "Minimal"
        ElseIf botRadio = "radio" Then
            cmb_BotRadioChatter.SelectedItem = "Standard Radio"
        End If
        If botJoinAfterPlayer = 1 Then
            chk_BotJoinAfterPlayer.Checked = True
        Else
            chk_BotJoinAfterPlayer.Checked = False
        End If
        If botDeferGoal = 1 Then
            chk_BotDeferGoal.Checked = True
        Else
            chk_BotDeferGoal.Checked = False
        End If
        If botRogue = 1 Then
            chk_BotRogue.Checked = True
        Else
            chk_BotRogue.Checked = False
        End If
        If botPistol = 1 Then
            chk_Pistols.Checked = True
        Else
            chk_Pistols.Checked = False
        End If
        If botShotgun = 1 Then
            chk_Shotguns.Checked = True
        Else
            chk_Shotguns.Checked = False
        End If
        If botSubmachinegun = 1 Then
            chk_Submachine.Checked = True
        Else
            chk_Submachine.Checked = False
        End If
        If botMachinegun = 1 Then
            chk_Machinegun.Checked = True
        Else
            chk_Submachine.Checked = False
        End If
        If botRifle = 1 Then
            chk_Rifle.Checked = True
        Else
            chk_Rifle.Checked = False
        End If
        If botGrenade = 1 Then
            chk_Grenade.Checked = True
        Else
            chk_Grenade.Checked = False
        End If
        If botSniper = 1 Then
            chk_Sniper.Checked = True
        Else
            chk_Sniper.Checked = False
        End If
    End Sub

    Private Sub lbl_Mode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Mode.Click
        frmMode.Show()
        Me.Hide()
    End Sub

    Private Sub chk_IncludeBOT_ChangeChecked(ByVal sender As System.Object, ByVal check As System.Boolean) Handles chk_IncludeBOT.ChangeChecked
        If txt_BotAmount.Enabled = True And cmb_BotLevel.Enabled = True Then
            txt_BotAmount.Enabled = False
            cmb_BotLevel.Enabled = False
        Else
            txt_BotAmount.Enabled = True
            cmb_BotLevel.Enabled = True
        End If
    End Sub

    Private Sub cmb_Map_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Map.SelectedIndexChanged
        On Error Resume Next
        pb_Map.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\mapimg\" & cmb_Map.SelectedItem & "_cso.png")
    End Sub

    Private Sub saveUsrSetting()
        My.Settings.HLDS_Map = cmb_Map.SelectedItem
        WriteCfgValue("bot_quota", txt_BotAmount.Text, bteBotConfig)
        If cmb_BotLevel.SelectedItem = "Easy" Then
            botDifficulty = 0
        ElseIf cmb_BotLevel.SelectedItem = "Normal" Then
            botDifficulty = 1
        ElseIf cmb_BotLevel.SelectedItem = "Hard" Then
            botDifficulty = 2
        ElseIf cmb_BotLevel.SelectedItem = "Expert" Then
            botDifficulty = 3
        End If
        WriteCfgValue("bot_difficulty", botDifficulty, bteBotConfig)
        If cmb_Lan.SelectedItem = "LAN" Then
            svLan = 1
        Else
            svLan = 0
        End If
        WriteCfgValue("sv_lan", svLan, bteBotConfig)

        WriteCfgValue("hostname", txt_HostName.Text, bteServer)
        My.Settings.HLDS_MaxPlayer = txt_MaxPlayers.Text
        WriteCfgValue("sv_password", txt_SvrPwd.Text, bteServer)
        WriteCfgValue("rcon_password", txt_RconPwd.Text, bteServer)
        WriteCfgValue("mp_timelimit", txt_MapTime.Text, bteServer)
        WriteCfgValue("mp_winlimit", txt_WinLimit.Text, bteServer)
        WriteCfgValue("mp_fraglimit", txt_FragLimit.Text, bteServer)
        WriteCfgValue("mp_maxrounds", txt_RoundLimit.Text, bteServer)
        WriteCfgValue("mp_roundtime", txt_RoundTime.Text, bteServer)
        WriteCfgValue("mp_freezetime", txt_FreezeTime.Text, bteServer)
        WriteCfgValue("mp_buytime", txt_BuyTime.Text, bteServer)
        WriteCfgValue("mp_c4timer", txt_C4Timer.Text, bteServer)
        WriteCfgValue("mp_startmoney", txt_StartingMoney.Text, bteServer)
        WriteCfgValue("mp_hostagepenalty", txt_HostageKill.Text, bteServer)
        WriteCfgValue("decalfrequency", txt_DecalFreq.Text, bteServer)
        WriteCfgValue("mp_limitteams", txt_LimitTeamPlayers.Text, bteServer)
        WriteCfgValue("sv_maxrate", txt_MaxRate.Text, bteServer)
        If cmb_DeathCamType.SelectedItem = "Spectate anyone" Then
            deathCamType = 0
        ElseIf cmb_DeathCamType.SelectedItem = "Spectate team only" Then
            deathCamType = 1
        ElseIf cmb_DeathCamType.SelectedItem = "Only first-person" Then
            deathCamType = 2
        End If
        If chk_AllTalk.Checked = True Then
            enableAllTalk = 1
        Else
            enableAllTalk = 0
        End If
        If chk_EnableVoice.Checked = True Then
            enableVoice = 1
        Else
            enableVoice = 0
        End If
        If cmb_VoiceQuality.SelectedItem = "Extremely Low" Then
            voiceQuality = 0
        ElseIf cmb_VoiceQuality.SelectedItem = "Very Low" Then
            voiceQuality = 1
        ElseIf cmb_VoiceQuality.SelectedItem = "Low" Then
            voiceQuality = 2
        ElseIf cmb_VoiceQuality.SelectedItem = "Medium" Then
            voiceQuality = 3
        ElseIf cmb_VoiceQuality.SelectedItem = "High" Then
            voiceQuality = 4
        ElseIf cmb_VoiceQuality.SelectedItem = "Very High" Then
            voiceQuality = 5
        End If
        If chk_LogFiling.Checked = True Then
            logFilling = 1
        Else
            logFilling = 0
        End If
        If chk_LoggingMsg.Checked = True Then
            logMsg = 1
        Else
            chk_LoggingMsg.Checked = True
        End If
        If cmb_LoggingDetail.SelectedItem = "No Log" Then
            logDetail = 0
        ElseIf cmb_LoggingDetail.SelectedItem = "Enemy Damage" Then
            logDetail = 1
        ElseIf cmb_LoggingDetail.SelectedItem = "Teammate Damage" Then
            logDetail = 2
        ElseIf cmb_LoggingDetail.SelectedItem = "Both" Then
            logDetail = 3
        End If
        If chk_Download.Checked = True Then
            allowDownload = 1
        Else
            allowDownload = 0
        End If
        If chk_Flashlight.Checked = True Then
            allowFlashlight = 1
        Else
            allowFlashlight = 0
        End If
        If chk_Spectators.Checked = True Then
            allowSpectator = 1
        Else
            allowSpectator = 0
        End If
        If chk_Upload.Checked = True Then
            allowUpload = 1
        Else
            allowUpload = 0
        End If
        If chk_ChaseDeathCam.Checked = True Then
            disableChaseDeathCam = 1
        Else
            disableChaseDeathCam = 0
        End If
        If chk_AutoTeamBalance.Checked = True Then
            autoTeamBalance = 1
        Else
            autoTeamBalance = 0
        End If
        If chk_FallDmg.Checked = True Then
            fallDamage = 1
        Else
            fallDamage = 0
        End If
        If chk_Grenade.Checked = True Then
            friendlyGrenade = 1
        Else
            friendlyGrenade = 0
        End If
        If chk_Footsteps.Checked = True Then
            footSteps = 1
        Else
            footSteps = 0
        End If
        If chk_FriendlyFire.Checked = True Then
            friendlyFire = 1
        Else
            friendlyFire = 0
        End If
        If chk_KickIdler.Checked = True Then
            kickIdlerTKer = 1
        Else
            kickIdlerTKer = 0
        End If
        If chk_KillTKer.Checked = True Then
            killTKer = 1
        Else
            killTKer = 0
        End If
        If chk_SendLogo.Checked = True Then
            sendLogo = 1
        Else
            sendLogo = 0
        End If
        If chk_SendResource.Checked = True Then
            sendResources = 1
        Else
            sendResources = 0
        End If
        WriteCfgValue("mp_forcecamera", deathCamType, bteServer)
        WriteCfgValue("sv_alltalk", enableAllTalk, bteServer)
        WriteCfgValue("sv_voiceenable", enableVoice, bteServer)
        WriteCfgValue("sv_voicequality", voiceQuality, bteServer)
        WriteCfgValue("mp_logfile", logFilling, bteServer)
        WriteCfgValue("mp_logmessages", logMsg, bteServer)
        WriteCfgValue("mp_logdetail", logDetail, bteServer)
        WriteCfgValue("sv_allowdownload", allowDownload, bteServer)
        WriteCfgValue("mp_flashlight", allowFlashlight, bteServer)
        WriteCfgValue("allow_spectators", allowSpectator, bteServer)
        WriteCfgValue("sv_allowupload", allowUpload, bteServer)
        WriteCfgValue("mp_fadetoblack", disableChaseDeathCam, bteServer)
        WriteCfgValue("mp_autoteambalance", autoTeamBalance, bteServer)
        WriteCfgValue("mp_falldamage", fallDamage, bteServer)
        WriteCfgValue("mp_friendly_grenade_damage", friendlyGrenade, bteServer)
        WriteCfgValue("mp_footsteps", footSteps, bteServer)
        WriteCfgValue("mp_friendlyfire", friendlyFire, bteServer)
        WriteCfgValue("mp_autokick", kickIdlerTKer, bteServer)
        WriteCfgValue("mp_tkpunish", killTKer, bteServer)
        WriteCfgValue("sv_send_logos", sendLogo, bteServer)
        WriteCfgValue("sv_send_resources", sendResources, bteServer)

        WriteCfgValue("bot_prefix", txt_BotNamePrefix.Text, bteBotConfig)
        If cmb_BotJoinTeam.SelectedItem = "Random" Then
            botJoinTeam = "any"
        ElseIf cmb_BotJoinTeam.SelectedItem = "Counter-Terrorists" Then
            botJoinTeam = "CT"
        ElseIf cmb_BotJoinTeam.SelectedItem = "Terrorists" Then
            botJoinTeam = "T"
        End If
        If cmb_BotRadioChatter.SelectedItem = "Normal" Then
            botRadio = "normal"
        ElseIf cmb_BotRadioChatter.SelectedItem = "Minimal" Then
            botRadio = "minimal"
        ElseIf cmb_BotRadioChatter.SelectedItem = "Standard Radio" Then
            botRadio = "radio"
        ElseIf cmb_BotRadioChatter.SelectedItem = "Off" Then
            botRadio = "off"
        End If
        If chk_BotJoinAfterPlayer.Checked = True Then
            botJoinAfterPlayer = 1
        Else
            botJoinAfterPlayer = 0
        End If
        If chk_BotDeferGoal.Checked = True Then
            botDeferGoal = 1
        Else
            botDeferGoal = 0
        End If
        If chk_BotRogue.Checked = True Then
            botRogue = 1
        Else
            botRogue = 0
        End If
        If chk_Pistols.Checked = True Then
            botPistol = 1
        Else
            botPistol = 0
        End If
        If chk_Shotguns.Checked = True Then
            botShotgun = 1
        Else
            botShotgun = 0
        End If
        If chk_Submachine.Checked = True Then
            botSubmachinegun = 1
        Else
            botSubmachinegun = 0
        End If
        If chk_Machinegun.Checked = True Then
            botMachinegun = 1
        Else
            botMachinegun = 0
        End If
        If chk_Rifle.Checked = True Then
            botRifle = 1
        Else
            botRifle = 0
        End If
        If chk_Grenade.Checked = True Then
            botGrenade = 1
        Else
            botGrenade = 0
        End If
        If chk_Sniper.Checked = True Then
            botSniper = 1
        Else
            botSniper = 0
        End If
        WriteCfgValue("bot_join_team", botJoinTeam, bteBotConfig)
        WriteCfgValue("bot_chatter", botRadio, bteBotConfig)
        WriteCfgValue("bot_join_after_player", botJoinAfterPlayer, bteBotConfig)
        WriteCfgValue("bot_defer_to_human", botDeferGoal, bteBotConfig)
        WriteCfgValue("bot_allow_rogues", botRogue, bteBotConfig)
        WriteCfgValue("bot_allow_pistols", botPistol, bteBotConfig)
        WriteCfgValue("bot_allow_shotguns", botShotgun, bteBotConfig)
        WriteCfgValue("bot_allow_sub_machine_guns", botSubmachinegun, bteBotConfig)
        WriteCfgValue("bot_allow_machine_guns", botMachinegun, bteBotConfig)
        WriteCfgValue("bot_allow_rifles", botRifle, bteBotConfig)
        WriteCfgValue("bot_allow_grenades", botGrenade, bteBotConfig)
        WriteCfgValue("bot_allow_snipers", botSniper, bteBotConfig)
        My.Settings.Save()
    End Sub

    Private Sub btn_HLDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HLDS.Click
        Try
            saveUsrSetting()
            Shell(My.Application.Info.DirectoryPath & "\cstrike.exe +maxplayers " & txt_MaxPlayers.Text & " +map " & cmb_Map.SelectedItem & ".bsp +exec server.cfg +exec launcher.cfg", AppWinStyle.NormalFocus)
            frmBackground2.Hide()
            Me.Hide()
            frmMode.NotifyIcon1.Visible = True
            frmMode.NotifyIcon1.ShowBalloonTip(10)
            My.Computer.Audio.Stop()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class