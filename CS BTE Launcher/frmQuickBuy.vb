Public Class frmQuickBuy

    Public mHook As String = My.Application.Info.DirectoryPath & "\metahook\quickbuy.ini"
    Public bteWpnBte As String = My.Application.Info.DirectoryPath & "\launcher\bte_wpn.ini"
    Public pri1m As String = ReadIniValue(mHook, "QuickBuy1", "Primary")
    Public sec1m As String = ReadIniValue(mHook, "QuickBuy1", "Secondary")
    Public mel1m As String = ReadIniValue(mHook, "QuickBuy1", "Knife")
    Public gre1m As String = ReadIniValue(mHook, "QuickBuy1", "Grenade")
    Public pri2m As String = ReadIniValue(mHook, "QuickBuy2", "Primary")
    Public sec2m As String = ReadIniValue(mHook, "QuickBuy2", "Secondary")
    Public mel2m As String = ReadIniValue(mHook, "QuickBuy2", "Knife")
    Public gre2m As String = ReadIniValue(mHook, "QuickBuy2", "Grenade")
    Public pri3m As String = ReadIniValue(mHook, "QuickBuy3", "Primary")
    Public sec3m As String = ReadIniValue(mHook, "QuickBuy3", "Secondary")
    Public mel3m As String = ReadIniValue(mHook, "QuickBuy3", "Knife")
    Public gre3m As String = ReadIniValue(mHook, "QuickBuy3", "Grenade")
    Public pri4m As String = ReadIniValue(mHook, "QuickBuy4", "Primary")
    Public sec4m As String = ReadIniValue(mHook, "QuickBuy4", "Secondary")
    Public mel4m As String = ReadIniValue(mHook, "QuickBuy4", "Knife")
    Public gre4m As String = ReadIniValue(mHook, "QuickBuy4", "Grenade")
    Public pri5m As String = ReadIniValue(mHook, "QuickBuy5", "Primary")
    Public sec5m As String = ReadIniValue(mHook, "QuickBuy5", "Secondary")
    Public mel5m As String = ReadIniValue(mHook, "QuickBuy5", "Knife")
    Public gre5m As String = ReadIniValue(mHook, "QuickBuy5", "Grenade")

    Private Sub frmQuickBuy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = frmCangku.Left + 350
        Me.Top = frmCangku.Top + 150

        Dim pri1n As String = ReadIniValue(bteWpnBte, "NAME", pri1m)
        Dim sec1n As String = ReadIniValue(bteWpnBte, "NAME", sec1m)
        Dim mel1n As String = ReadIniValue(bteWpnBte, "NAME", mel1m)
        Dim gre1n As String = ReadIniValue(bteWpnBte, "NAME", gre1m)
        Dim pri2n As String = ReadIniValue(bteWpnBte, "NAME", pri2m)
        Dim sec2n As String = ReadIniValue(bteWpnBte, "NAME", sec2m)
        Dim mel2n As String = ReadIniValue(bteWpnBte, "NAME", mel2m)
        Dim gre2n As String = ReadIniValue(bteWpnBte, "NAME", gre2m)
        Dim pri3n As String = ReadIniValue(bteWpnBte, "NAME", pri3m)
        Dim sec3n As String = ReadIniValue(bteWpnBte, "NAME", sec3m)
        Dim mel3n As String = ReadIniValue(bteWpnBte, "NAME", mel3m)
        Dim gre3n As String = ReadIniValue(bteWpnBte, "NAME", gre3m)
        Dim pri4n As String = ReadIniValue(bteWpnBte, "NAME", pri4m)
        Dim sec4n As String = ReadIniValue(bteWpnBte, "NAME", sec4m)
        Dim mel4n As String = ReadIniValue(bteWpnBte, "NAME", mel4m)
        Dim gre4n As String = ReadIniValue(bteWpnBte, "NAME", gre4m)
        Dim pri5n As String = ReadIniValue(bteWpnBte, "NAME", pri5m)
        Dim sec5n As String = ReadIniValue(bteWpnBte, "NAME", sec5m)
        Dim mel5n As String = ReadIniValue(bteWpnBte, "NAME", mel5m)
        Dim gre5n As String = ReadIniValue(bteWpnBte, "NAME", gre5m)

        pb_PriWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri1m & ".png")
        pb_PriWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri2m & ".png")
        pb_PriWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri3m & ".png")
        pb_PriWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri4m & ".png")
        pb_PriWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & pri5m & ".png")
        pb_SecWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec1m & ".png")
        pb_SecWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec2m & ".png")
        pb_SecWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec3m & ".png")
        pb_SecWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec4m & ".png")
        pb_SecWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & sec5m & ".png")
        pb_MelWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel1m & ".png")
        pb_MelWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel2m & ".png")
        pb_MelWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel3m & ".png")
        pb_MelWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel4m & ".png")
        pb_MelWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & mel5m & ".png")
        pb_GreWpn1.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre1m & ".png")
        pb_GreWpn2.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre2m & ".png")
        pb_GreWpn3.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre3m & ".png")
        pb_GreWpn4.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre4m & ".png")
        pb_GreWpn5.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\launcher\wpnimg\" & gre5m & ".png")
        lbl_PriWpn1.Text = pri1n
        lbl_PriWpn2.Text = pri2n
        lbl_PriWpn3.Text = pri3n
        lbl_PriWpn4.Text = pri4n
        lbl_PriWpn5.Text = pri5n
        lbl_SecWpn1.Text = sec1n
        lbl_SecWpn2.Text = sec2n
        lbl_SecWpn3.Text = sec3n
        lbl_SecWpn4.Text = sec4n
        lbl_SecWpn5.Text = sec5n
        lbl_MelWpn1.Text = mel1n
        lbl_MelWpn2.Text = mel2n
        lbl_MelWpn3.Text = mel3n
        lbl_MelWpn4.Text = mel4n
        lbl_MelWpn5.Text = mel5n
        lbl_GreWpn1.Text = gre1n
        lbl_GreWpn2.Text = gre2n
        lbl_GreWpn3.Text = gre3n
        lbl_GreWpn4.Text = gre4n
        lbl_GreWpn5.Text = gre5n
    End Sub

    Private Sub pb_PriWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri1"
    End Sub

    Private Sub pb_PriWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri2"
    End Sub

    Private Sub pb_PriWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri3"
    End Sub

    Private Sub pb_PriWpn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn4.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri4"
    End Sub

    Private Sub pb_PriWpn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_PriWpn5.Click
        frmWeapon.Show()
        frmWeapon.readSelectedPrimary()
        frmWeapon.fromWhere = "pri5"
    End Sub

    Private Sub pb_SecWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec1"
    End Sub

    Private Sub pb_SecWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec2"
    End Sub

    Private Sub pb_SecWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec3"
    End Sub

    Private Sub pb_SecWpn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn4.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec4"
    End Sub

    Private Sub pb_SecWpn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_SecWpn5.Click
        frmWeapon.Show()
        frmWeapon.readSelectedSecondary()
        frmWeapon.fromWhere = "sec5"
    End Sub

    Private Sub pb_MelWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel1"
    End Sub

    Private Sub pb_MelWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel2"
    End Sub

    Private Sub pb_MelWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel3"
    End Sub

    Private Sub pb_MelWpn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn4.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel4"
    End Sub

    Private Sub pb_MelWpn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_MelWpn5.Click
        frmWeapon.Show()
        frmWeapon.readSelectedMelee()
        frmWeapon.fromWhere = "mel5"
    End Sub

    Private Sub pb_GreWpn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn1.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre1"
    End Sub

    Private Sub pb_GreWpn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn2.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre2"
    End Sub

    Private Sub pb_GreWpn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn3.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre3"
    End Sub

    Private Sub pb_GreWpn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn4.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre4"
    End Sub

    Private Sub pb_GreWpn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_GreWpn5.Click
        frmWeapon.Show()
        frmWeapon.readSelectedGrenade()
        frmWeapon.fromWhere = "gre5"
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
         Try
            WriteIniValue2(mHook, "QuickBuy1", "Primary", pri1m)
            WriteIniValue2(mHook, "QuickBuy2", "Primary", pri2m)
            WriteIniValue2(mHook, "QuickBuy3", "Primary", pri3m)
            WriteIniValue2(mHook, "QuickBuy4", "Primary", pri4m)
            WriteIniValue2(mHook, "QuickBuy5", "Primary", pri5m)
            WriteIniValue2(mHook, "QuickBuy1", "Secondary", sec1m)
            WriteIniValue2(mHook, "QuickBuy2", "Secondary", sec2m)
            WriteIniValue2(mHook, "QuickBuy3", "Secondary", sec3m)
            WriteIniValue2(mHook, "QuickBuy4", "Secondary", sec4m)
            WriteIniValue2(mHook, "QuickBuy5", "Secondary", sec5m)
            WriteIniValue2(mHook, "QuickBuy1", "Knife", mel1m)
            WriteIniValue2(mHook, "QuickBuy2", "Knife", mel2m)
            WriteIniValue2(mHook, "QuickBuy3", "Knife", mel3m)
            WriteIniValue2(mHook, "QuickBuy4", "Knife", mel4m)
            WriteIniValue2(mHook, "QuickBuy5", "Knife", mel5m)
            WriteIniValue2(mHook, "QuickBuy1", "Grenade", gre1m)
            WriteIniValue2(mHook, "QuickBuy2", "Grenade", gre2m)
            WriteIniValue2(mHook, "QuickBuy3", "Grenade", gre3m)
            WriteIniValue2(mHook, "QuickBuy4", "Grenade", gre4m)
            WriteIniValue2(mHook, "QuickBuy5", "Grenade", gre5m)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        frmCangku.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        frmCangku.Show()
        Me.Hide()
    End Sub
End Class