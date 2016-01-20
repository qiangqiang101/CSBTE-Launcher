Public Class frmTeamSuit

    Public mHook As String = My.Application.Info.DirectoryPath & "\metahook\teamsuit.ini"
    Public launcher As String = My.Application.Info.DirectoryPath & "\launcher\bte_wpn.ini"
    Public pri1m As String = ReadIniValue(mHook, "TeamSuit1", "Primary")
    Public sec1m As String = ReadIniValue(mHook, "TeamSuit1", "Secondary")
    Public mel1m As String = ReadIniValue(mHook, "TeamSuit1", "Knife")
    Public gre1m As String = ReadIniValue(mHook, "TeamSuit1", "Grenade")
    Public pri2m As String = ReadIniValue(mHook, "TeamSuit2", "Primary")
    Public sec2m As String = ReadIniValue(mHook, "TeamSuit2", "Secondary")
    Public mel2m As String = ReadIniValue(mHook, "TeamSuit2", "Knife")
    Public gre2m As String = ReadIniValue(mHook, "TeamSuit2", "Grenade")
    Public pri3m As String = ReadIniValue(mHook, "TeamSuit3", "Primary")
    Public sec3m As String = ReadIniValue(mHook, "TeamSuit3", "Secondary")
    Public mel3m As String = ReadIniValue(mHook, "TeamSuit3", "Knife")
    Public gre3m As String = ReadIniValue(mHook, "TeamSuit3", "Grenade")

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frmCangku.Show()
        Me.Hide()
    End Sub

    Private Sub frmTeamSuit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = frmCangku.Left + 350
        Me.Top = frmCangku.Top + 150

        Dim pri1n As String = ReadIniValue(launcher, "NAME", pri1m)
        Dim sec1n As String = ReadIniValue(launcher, "NAME", sec1m)
        Dim mel1n As String = ReadIniValue(launcher, "NAME", mel1m)
        Dim gre1n As String = ReadIniValue(launcher, "NAME", gre1m)
        Dim pri2n As String = ReadIniValue(launcher, "NAME", pri2m)
        Dim sec2n As String = ReadIniValue(launcher, "NAME", sec2m)
        Dim mel2n As String = ReadIniValue(launcher, "NAME", mel2m)
        Dim gre2n As String = ReadIniValue(launcher, "NAME", gre2m)
        Dim pri3n As String = ReadIniValue(launcher, "NAME", pri3m)
        Dim sec3n As String = ReadIniValue(launcher, "NAME", sec3m)
        Dim mel3n As String = ReadIniValue(launcher, "NAME", mel3m)
        Dim gre3n As String = ReadIniValue(launcher, "NAME", gre3m)

        pb_PriWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri1m & ".png")
        pb_PriWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri2m & ".png")
        pb_PriWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri3m & ".png")
        pb_SecWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec1m & ".png")
        pb_SecWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec2m & ".png")
        pb_SecWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec3m & ".png")
        pb_MelWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel1m & ".png")
        pb_MelWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel2m & ".png")
        pb_MelWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel3m & ".png")
        pb_GreWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre1m & ".png")
        pb_GreWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre2m & ".png")
        pb_GreWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre3m & ".png")
        lbl_PriWpn1.Text = pri1n
        lbl_PriWpn2.Text = pri2n
        lbl_PriWpn3.Text = pri3n
        lbl_SecWpn1.Text = sec1n
        lbl_SecWpn2.Text = sec2n
        lbl_SecWpn3.Text = sec3n
        lbl_MelWpn1.Text = mel1n
        lbl_MelWpn2.Text = mel2n
        lbl_MelWpn3.Text = mel3n
        lbl_GreWpn1.Text = gre1n
        lbl_GreWpn2.Text = gre2n
        lbl_GreWpn3.Text = gre3n
    End Sub

    Private Sub pb_PriWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri1t"
    End Sub

    Private Sub pb_PriWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri2t"
    End Sub

    Private Sub pb_PriWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri3t"
    End Sub

    Private Sub pb_SecWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec1t"
    End Sub

    Private Sub pb_SecWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec2t"
    End Sub

    Private Sub pb_SecWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec3t"
    End Sub

    Private Sub pb_MelWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel1t"
    End Sub

    Private Sub pb_MelWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel2t"
    End Sub

    Private Sub pb_MelWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel3t"
    End Sub

    Private Sub pb_GreWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre1t"
    End Sub

    Private Sub pb_GreWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre2t"
    End Sub

    Private Sub pb_GreWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre3t"
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            WriteIniValue2(mHook, "TeamSuit1", "Primary", pri1m)
            WriteIniValue2(mHook, "TeamSuit2", "Primary", pri2m)
            WriteIniValue2(mHook, "TeamSuit3", "Primary", pri3m)
            WriteIniValue2(mHook, "TeamSuit1", "Secondary", sec1m)
            WriteIniValue2(mHook, "TeamSuit2", "Secondary", sec2m)
            WriteIniValue2(mHook, "TeamSuit3", "Secondary", sec3m)
            WriteIniValue2(mHook, "TeamSuit1", "Knife", mel1m)
            WriteIniValue2(mHook, "TeamSuit2", "Knife", mel2m)
            WriteIniValue2(mHook, "TeamSuit3", "Knife", mel3m)
            WriteIniValue2(mHook, "TeamSuit1", "Grenade", gre1m)
            WriteIniValue2(mHook, "TeamSuit2", "Grenade", gre2m)
            WriteIniValue2(mHook, "TeamSuit3", "Grenade", gre3m)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        frmCangku.Show()
        Me.Hide()
    End Sub

End Class