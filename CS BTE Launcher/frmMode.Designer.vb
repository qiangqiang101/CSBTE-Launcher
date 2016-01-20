<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMode))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BitdefenderForm1 = New CS_BTE_Launcher.BitdefenderForm()
        Me.btn_Close = New CS_BTE_Launcher.BitdefenderButton()
        Me.btn_Play = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderGroupbox1 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.BitdefenderSeparator1 = New CS_BTE_Launcher.BitdefenderSeparator()
        Me.lbl_Map = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Mode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Mode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_ze = New System.Windows.Forms.PictureBox()
        Me.pic_npc = New System.Windows.Forms.PictureBox()
        Me.pic_zb4 = New System.Windows.Forms.PictureBox()
        Me.pic_zb3 = New System.Windows.Forms.PictureBox()
        Me.pic_zb1 = New System.Windows.Forms.PictureBox()
        Me.pic_dr = New System.Windows.Forms.PictureBox()
        Me.pic_fun = New System.Windows.Forms.PictureBox()
        Me.pic_hd = New System.Windows.Forms.PictureBox()
        Me.pic_gd = New System.Windows.Forms.PictureBox()
        Me.pic_tdm = New System.Windows.Forms.PictureBox()
        Me.pic_nndm = New System.Windows.Forms.PictureBox()
        Me.pic_dm = New System.Windows.Forms.PictureBox()
        Me.pic_none = New System.Windows.Forms.PictureBox()
        Me.pic_basic = New System.Windows.Forms.PictureBox()
        Me.BitdefenderForm1.SuspendLayout()
        Me.BitdefenderGroupbox1.SuspendLayout()
        CType(Me.pic_ze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_npc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_zb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_zb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_zb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_dr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_fun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_hd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_gd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_tdm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_nndm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_dm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_none, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_basic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Counter-Strike: Breakthrough Edition Launcher is still Running!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to dismiss" & _
            "."
        Me.NotifyIcon1.BalloonTipTitle = "Counter-Strike: Breakthrough Edition Launcher"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Counter-Strike: Breakthrough Edition Launcher"
        Me.NotifyIcon1.Visible = True
        '
        'BitdefenderForm1
        '
        Me.BitdefenderForm1.BackColor = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.Controls.Add(Me.btn_Close)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Play)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox1)
        Me.BitdefenderForm1.DisableControlboxClose = True
        Me.BitdefenderForm1.DisableControlboxMax = True
        Me.BitdefenderForm1.DisableControlboxMin = True
        Me.BitdefenderForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BitdefenderForm1.Location = New System.Drawing.Point(0, 0)
        Me.BitdefenderForm1.Name = "BitdefenderForm1"
        Me.BitdefenderForm1.Padding = New System.Windows.Forms.Padding(10)
        Me.BitdefenderForm1.Size = New System.Drawing.Size(1019, 554)
        Me.BitdefenderForm1.TabIndex = 0
        Me.BitdefenderForm1.Text = "Mode Selection"
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.Location = New System.Drawing.Point(837, 493)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(159, 40)
        Me.btn_Close.TabIndex = 9
        Me.btn_Close.Text = "Cancel"
        '
        'btn_Play
        '
        Me.btn_Play.BackColor = System.Drawing.Color.Transparent
        Me.btn_Play.Location = New System.Drawing.Point(672, 493)
        Me.btn_Play.Name = "btn_Play"
        Me.btn_Play.Size = New System.Drawing.Size(159, 40)
        Me.btn_Play.TabIndex = 5
        Me.btn_Play.Text = "OK"
        '
        'BitdefenderGroupbox1
        '
        Me.BitdefenderGroupbox1.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox1.Controls.Add(Me.BitdefenderSeparator1)
        Me.BitdefenderGroupbox1.Controls.Add(Me.lbl_Map)
        Me.BitdefenderGroupbox1.Controls.Add(Me.Label3)
        Me.BitdefenderGroupbox1.Controls.Add(Me.lbl_Mode)
        Me.BitdefenderGroupbox1.Controls.Add(Me.Label2)
        Me.BitdefenderGroupbox1.Controls.Add(Me.txt_Mode)
        Me.BitdefenderGroupbox1.Controls.Add(Me.Label1)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_ze)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_npc)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_zb4)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_zb3)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_zb1)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_dr)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_fun)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_hd)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_gd)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_tdm)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_nndm)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_dm)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_none)
        Me.BitdefenderGroupbox1.Controls.Add(Me.pic_basic)
        Me.BitdefenderGroupbox1.Location = New System.Drawing.Point(20, 40)
        Me.BitdefenderGroupbox1.Name = "BitdefenderGroupbox1"
        Me.BitdefenderGroupbox1.Size = New System.Drawing.Size(976, 447)
        Me.BitdefenderGroupbox1.Subtitle = ""
        Me.BitdefenderGroupbox1.TabIndex = 0
        Me.BitdefenderGroupbox1.Title = "Game Modes"
        '
        'BitdefenderSeparator1
        '
        Me.BitdefenderSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderSeparator1.Location = New System.Drawing.Point(14, 381)
        Me.BitdefenderSeparator1.Name = "BitdefenderSeparator1"
        Me.BitdefenderSeparator1.Size = New System.Drawing.Size(950, 3)
        Me.BitdefenderSeparator1.TabIndex = 52
        Me.BitdefenderSeparator1.Text = "BitdefenderSeparator1"
        '
        'lbl_Map
        '
        Me.lbl_Map.AutoSize = True
        Me.lbl_Map.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Map.ForeColor = System.Drawing.Color.White
        Me.lbl_Map.Location = New System.Drawing.Point(103, 413)
        Me.lbl_Map.Name = "lbl_Map"
        Me.lbl_Map.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Map.TabIndex = 51
        Me.lbl_Map.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Playable Maps:"
        '
        'lbl_Mode
        '
        Me.lbl_Mode.AutoSize = True
        Me.lbl_Mode.ForeColor = System.Drawing.Color.White
        Me.lbl_Mode.Location = New System.Drawing.Point(135, 398)
        Me.lbl_Mode.Name = "lbl_Mode"
        Me.lbl_Mode.Size = New System.Drawing.Size(83, 15)
        Me.lbl_Mode.TabIndex = 49
        Me.lbl_Mode.Text = "None Selected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Current Game Mode:"
        '
        'txt_Mode
        '
        Me.txt_Mode.BackColor = System.Drawing.Color.Transparent
        Me.txt_Mode.ForeColor = System.Drawing.Color.White
        Me.txt_Mode.Location = New System.Drawing.Point(578, 59)
        Me.txt_Mode.Name = "txt_Mode"
        Me.txt_Mode.Size = New System.Drawing.Size(384, 319)
        Me.txt_Mode.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(578, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Mode Information:"
        '
        'pic_ze
        '
        Me.pic_ze.Image = Global.CS_BTE_Launcher.My.Resources.Resources.ze_n
        Me.pic_ze.Location = New System.Drawing.Point(155, 287)
        Me.pic_ze.Name = "pic_ze"
        Me.pic_ze.Size = New System.Drawing.Size(135, 75)
        Me.pic_ze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ze.TabIndex = 45
        Me.pic_ze.TabStop = False
        '
        'pic_npc
        '
        Me.pic_npc.Image = Global.CS_BTE_Launcher.My.Resources.Resources.npc_n
        Me.pic_npc.Location = New System.Drawing.Point(14, 287)
        Me.pic_npc.Name = "pic_npc"
        Me.pic_npc.Size = New System.Drawing.Size(135, 75)
        Me.pic_npc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_npc.TabIndex = 44
        Me.pic_npc.TabStop = False
        '
        'pic_zb4
        '
        Me.pic_zb4.Image = Global.CS_BTE_Launcher.My.Resources.Resources.zb4_n
        Me.pic_zb4.Location = New System.Drawing.Point(437, 206)
        Me.pic_zb4.Name = "pic_zb4"
        Me.pic_zb4.Size = New System.Drawing.Size(135, 75)
        Me.pic_zb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_zb4.TabIndex = 43
        Me.pic_zb4.TabStop = False
        '
        'pic_zb3
        '
        Me.pic_zb3.Image = Global.CS_BTE_Launcher.My.Resources.Resources.zb3_n
        Me.pic_zb3.Location = New System.Drawing.Point(296, 206)
        Me.pic_zb3.Name = "pic_zb3"
        Me.pic_zb3.Size = New System.Drawing.Size(135, 75)
        Me.pic_zb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_zb3.TabIndex = 42
        Me.pic_zb3.TabStop = False
        '
        'pic_zb1
        '
        Me.pic_zb1.Image = Global.CS_BTE_Launcher.My.Resources.Resources.zb1_n
        Me.pic_zb1.Location = New System.Drawing.Point(155, 206)
        Me.pic_zb1.Name = "pic_zb1"
        Me.pic_zb1.Size = New System.Drawing.Size(135, 75)
        Me.pic_zb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_zb1.TabIndex = 41
        Me.pic_zb1.TabStop = False
        '
        'pic_dr
        '
        Me.pic_dr.Image = Global.CS_BTE_Launcher.My.Resources.Resources.dr_n
        Me.pic_dr.Location = New System.Drawing.Point(14, 206)
        Me.pic_dr.Name = "pic_dr"
        Me.pic_dr.Size = New System.Drawing.Size(135, 75)
        Me.pic_dr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_dr.TabIndex = 40
        Me.pic_dr.TabStop = False
        '
        'pic_fun
        '
        Me.pic_fun.Image = Global.CS_BTE_Launcher.My.Resources.Resources.fun_n
        Me.pic_fun.Location = New System.Drawing.Point(437, 125)
        Me.pic_fun.Name = "pic_fun"
        Me.pic_fun.Size = New System.Drawing.Size(135, 75)
        Me.pic_fun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_fun.TabIndex = 39
        Me.pic_fun.TabStop = False
        '
        'pic_hd
        '
        Me.pic_hd.Image = Global.CS_BTE_Launcher.My.Resources.Resources.hd_n
        Me.pic_hd.Location = New System.Drawing.Point(296, 125)
        Me.pic_hd.Name = "pic_hd"
        Me.pic_hd.Size = New System.Drawing.Size(135, 75)
        Me.pic_hd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_hd.TabIndex = 38
        Me.pic_hd.TabStop = False
        '
        'pic_gd
        '
        Me.pic_gd.Image = Global.CS_BTE_Launcher.My.Resources.Resources.gdm_n
        Me.pic_gd.Location = New System.Drawing.Point(155, 125)
        Me.pic_gd.Name = "pic_gd"
        Me.pic_gd.Size = New System.Drawing.Size(135, 75)
        Me.pic_gd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_gd.TabIndex = 37
        Me.pic_gd.TabStop = False
        '
        'pic_tdm
        '
        Me.pic_tdm.Image = Global.CS_BTE_Launcher.My.Resources.Resources.td_n
        Me.pic_tdm.Location = New System.Drawing.Point(14, 125)
        Me.pic_tdm.Name = "pic_tdm"
        Me.pic_tdm.Size = New System.Drawing.Size(135, 75)
        Me.pic_tdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_tdm.TabIndex = 36
        Me.pic_tdm.TabStop = False
        '
        'pic_nndm
        '
        Me.pic_nndm.Image = Global.CS_BTE_Launcher.My.Resources.Resources.nndm_n
        Me.pic_nndm.Location = New System.Drawing.Point(437, 44)
        Me.pic_nndm.Name = "pic_nndm"
        Me.pic_nndm.Size = New System.Drawing.Size(135, 75)
        Me.pic_nndm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_nndm.TabIndex = 35
        Me.pic_nndm.TabStop = False
        '
        'pic_dm
        '
        Me.pic_dm.Image = Global.CS_BTE_Launcher.My.Resources.Resources.dm_n
        Me.pic_dm.Location = New System.Drawing.Point(296, 44)
        Me.pic_dm.Name = "pic_dm"
        Me.pic_dm.Size = New System.Drawing.Size(135, 75)
        Me.pic_dm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_dm.TabIndex = 34
        Me.pic_dm.TabStop = False
        '
        'pic_none
        '
        Me.pic_none.Image = Global.CS_BTE_Launcher.My.Resources.Resources.none_n
        Me.pic_none.Location = New System.Drawing.Point(155, 44)
        Me.pic_none.Name = "pic_none"
        Me.pic_none.Size = New System.Drawing.Size(135, 75)
        Me.pic_none.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_none.TabIndex = 33
        Me.pic_none.TabStop = False
        '
        'pic_basic
        '
        Me.pic_basic.Image = Global.CS_BTE_Launcher.My.Resources.Resources.basic_n
        Me.pic_basic.Location = New System.Drawing.Point(14, 44)
        Me.pic_basic.Name = "pic_basic"
        Me.pic_basic.Size = New System.Drawing.Size(135, 75)
        Me.pic_basic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_basic.TabIndex = 32
        Me.pic_basic.TabStop = False
        '
        'frmMode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1019, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.BitdefenderForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMode"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mode Selection"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.ResumeLayout(False)
        Me.BitdefenderGroupbox1.ResumeLayout(False)
        Me.BitdefenderGroupbox1.PerformLayout()
        CType(Me.pic_ze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_npc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_zb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_zb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_zb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_dr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_fun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_hd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_gd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_tdm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_nndm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_dm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_none, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_basic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitdefenderForm1 As CS_BTE_Launcher.BitdefenderForm
    Friend WithEvents BitdefenderGroupbox1 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents pic_ze As System.Windows.Forms.PictureBox
    Friend WithEvents pic_npc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_zb4 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_zb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_zb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_dr As System.Windows.Forms.PictureBox
    Friend WithEvents pic_fun As System.Windows.Forms.PictureBox
    Friend WithEvents pic_hd As System.Windows.Forms.PictureBox
    Friend WithEvents pic_gd As System.Windows.Forms.PictureBox
    Friend WithEvents pic_tdm As System.Windows.Forms.PictureBox
    Friend WithEvents pic_nndm As System.Windows.Forms.PictureBox
    Friend WithEvents pic_dm As System.Windows.Forms.PictureBox
    Friend WithEvents pic_none As System.Windows.Forms.PictureBox
    Friend WithEvents pic_basic As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Map As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Mode As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Mode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents btn_Play As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents BitdefenderSeparator1 As CS_BTE_Launcher.BitdefenderSeparator
End Class
