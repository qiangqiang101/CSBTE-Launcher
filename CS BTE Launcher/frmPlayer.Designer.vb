<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlayer))
        Me.BitdefenderForm1 = New CS_BTE_Launcher.BitdefenderForm()
        Me.btn_Save = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderGroupbox3 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.txt_SelName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New CS_BTE_Launcher.BitdefenderButton()
        Me.btn_Select = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderGroupbox2 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.lbl_SelectedT = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_SelectedCT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Sex = New System.Windows.Forms.Label()
        Me.lbl_Model = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Team = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BitdefenderGroupbox1 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.lv_Player = New System.Windows.Forms.ListView()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.lv_MyPlayer = New System.Windows.Forms.ListView()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btn_Clear = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderForm1.SuspendLayout()
        Me.BitdefenderGroupbox3.SuspendLayout()
        Me.BitdefenderGroupbox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BitdefenderGroupbox1.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BitdefenderForm1
        '
        Me.BitdefenderForm1.BackColor = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.Controls.Add(Me.btn_Clear)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Save)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox3)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Cancel)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Select)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox2)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox1)
        Me.BitdefenderForm1.DisableControlboxClose = True
        Me.BitdefenderForm1.DisableControlboxMax = True
        Me.BitdefenderForm1.DisableControlboxMin = True
        Me.BitdefenderForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BitdefenderForm1.Location = New System.Drawing.Point(0, 0)
        Me.BitdefenderForm1.Name = "BitdefenderForm1"
        Me.BitdefenderForm1.Size = New System.Drawing.Size(1261, 545)
        Me.BitdefenderForm1.TabIndex = 0
        Me.BitdefenderForm1.Text = "Counter-Strike BreakThrough Edition Player Selection"
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.Location = New System.Drawing.Point(862, 486)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(186, 40)
        Me.btn_Save.TabIndex = 84
        Me.btn_Save.Text = "Save Selected Player(s)"
        '
        'BitdefenderGroupbox3
        '
        Me.BitdefenderGroupbox3.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox3.Controls.Add(Me.txt_SelName)
        Me.BitdefenderGroupbox3.Controls.Add(Me.Label13)
        Me.BitdefenderGroupbox3.Location = New System.Drawing.Point(957, 40)
        Me.BitdefenderGroupbox3.Name = "BitdefenderGroupbox3"
        Me.BitdefenderGroupbox3.Size = New System.Drawing.Size(283, 440)
        Me.BitdefenderGroupbox3.Subtitle = ""
        Me.BitdefenderGroupbox3.TabIndex = 83
        Me.BitdefenderGroupbox3.Title = "Your Information"
        '
        'txt_SelName
        '
        Me.txt_SelName.ForeColor = System.Drawing.Color.White
        Me.txt_SelName.Location = New System.Drawing.Point(16, 60)
        Me.txt_SelName.Name = "txt_SelName"
        Me.txt_SelName.Size = New System.Drawing.Size(256, 368)
        Me.txt_SelName.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "You have selected:"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.Location = New System.Drawing.Point(1054, 486)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(186, 40)
        Me.btn_Cancel.TabIndex = 82
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Select
        '
        Me.btn_Select.BackColor = System.Drawing.Color.Transparent
        Me.btn_Select.Location = New System.Drawing.Point(478, 486)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(186, 40)
        Me.btn_Select.TabIndex = 81
        Me.btn_Select.Text = "Add"
        '
        'BitdefenderGroupbox2
        '
        Me.BitdefenderGroupbox2.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_SelectedT)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label8)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_SelectedCT)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label7)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Sex)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Model)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Name)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Team)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label6)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label5)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label4)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label3)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label1)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox1)
        Me.BitdefenderGroupbox2.Location = New System.Drawing.Point(668, 40)
        Me.BitdefenderGroupbox2.Name = "BitdefenderGroupbox2"
        Me.BitdefenderGroupbox2.Size = New System.Drawing.Size(283, 440)
        Me.BitdefenderGroupbox2.Subtitle = ""
        Me.BitdefenderGroupbox2.TabIndex = 73
        Me.BitdefenderGroupbox2.Title = "Player Information"
        '
        'lbl_SelectedT
        '
        Me.lbl_SelectedT.AutoSize = True
        Me.lbl_SelectedT.ForeColor = System.Drawing.Color.White
        Me.lbl_SelectedT.Location = New System.Drawing.Point(93, 400)
        Me.lbl_SelectedT.Name = "lbl_SelectedT"
        Me.lbl_SelectedT.Size = New System.Drawing.Size(13, 15)
        Me.lbl_SelectedT.TabIndex = 72
        Me.lbl_SelectedT.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Selected T:"
        '
        'lbl_SelectedCT
        '
        Me.lbl_SelectedCT.AutoSize = True
        Me.lbl_SelectedCT.ForeColor = System.Drawing.Color.White
        Me.lbl_SelectedCT.Location = New System.Drawing.Point(93, 375)
        Me.lbl_SelectedCT.Name = "lbl_SelectedCT"
        Me.lbl_SelectedCT.Size = New System.Drawing.Size(13, 15)
        Me.lbl_SelectedCT.TabIndex = 70
        Me.lbl_SelectedCT.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Selected CT:"
        '
        'lbl_Sex
        '
        Me.lbl_Sex.AutoSize = True
        Me.lbl_Sex.ForeColor = System.Drawing.Color.White
        Me.lbl_Sex.Location = New System.Drawing.Point(93, 350)
        Me.lbl_Sex.Name = "lbl_Sex"
        Me.lbl_Sex.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Sex.TabIndex = 68
        Me.lbl_Sex.Text = "-"
        '
        'lbl_Model
        '
        Me.lbl_Model.AutoSize = True
        Me.lbl_Model.ForeColor = System.Drawing.Color.White
        Me.lbl_Model.Location = New System.Drawing.Point(93, 300)
        Me.lbl_Model.Name = "lbl_Model"
        Me.lbl_Model.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Model.TabIndex = 61
        Me.lbl_Model.Text = "-"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.ForeColor = System.Drawing.Color.White
        Me.lbl_Name.Location = New System.Drawing.Point(93, 275)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Name.TabIndex = 60
        Me.lbl_Name.Text = "-"
        '
        'lbl_Team
        '
        Me.lbl_Team.AutoSize = True
        Me.lbl_Team.ForeColor = System.Drawing.Color.White
        Me.lbl_Team.Location = New System.Drawing.Point(93, 325)
        Me.lbl_Team.Name = "lbl_Team"
        Me.lbl_Team.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Team.TabIndex = 57
        Me.lbl_Team.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Sex:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Team:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Player Preview:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.CS_BTE_Launcher.My.Resources.Resources.cannotuse
        Me.PictureBox1.Location = New System.Drawing.Point(9, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BitdefenderGroupbox1
        '
        Me.BitdefenderGroupbox1.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox1.Controls.Add(Me.SuperTabControl1)
        Me.BitdefenderGroupbox1.Location = New System.Drawing.Point(20, 40)
        Me.BitdefenderGroupbox1.Name = "BitdefenderGroupbox1"
        Me.BitdefenderGroupbox1.Size = New System.Drawing.Size(642, 440)
        Me.BitdefenderGroupbox1.Subtitle = ""
        Me.BitdefenderGroupbox1.TabIndex = 72
        Me.BitdefenderGroupbox1.Title = ""
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.White
        Me.SuperTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(618, 416)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SuperTabControl1.TabIndex = 85
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.lv_Player)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(618, 388)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'lv_Player
        '
        Me.lv_Player.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lv_Player.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_Player.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Player.ForeColor = System.Drawing.Color.White
        Me.lv_Player.Location = New System.Drawing.Point(0, 0)
        Me.lv_Player.MultiSelect = False
        Me.lv_Player.Name = "lv_Player"
        Me.lv_Player.Size = New System.Drawing.Size(618, 388)
        Me.lv_Player.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_Player.TabIndex = 72
        Me.lv_Player.TileSize = New System.Drawing.Size(150, 25)
        Me.lv_Player.UseCompatibleStateImageBehavior = False
        Me.lv_Player.View = System.Windows.Forms.View.Tile
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Players"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.lv_MyPlayer)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(618, 416)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'lv_MyPlayer
        '
        Me.lv_MyPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lv_MyPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_MyPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_MyPlayer.ForeColor = System.Drawing.Color.White
        Me.lv_MyPlayer.Location = New System.Drawing.Point(0, 0)
        Me.lv_MyPlayer.MultiSelect = False
        Me.lv_MyPlayer.Name = "lv_MyPlayer"
        Me.lv_MyPlayer.Size = New System.Drawing.Size(618, 416)
        Me.lv_MyPlayer.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_MyPlayer.TabIndex = 73
        Me.lv_MyPlayer.TileSize = New System.Drawing.Size(150, 25)
        Me.lv_MyPlayer.UseCompatibleStateImageBehavior = False
        Me.lv_MyPlayer.View = System.Windows.Forms.View.Tile
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Selected Players"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(1, Byte), Integer)))
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_Clear.Location = New System.Drawing.Point(670, 486)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(186, 40)
        Me.btn_Clear.TabIndex = 85
        Me.btn_Clear.Text = "Clear Selected"
        '
        'frmPlayer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1261, 545)
        Me.Controls.Add(Me.BitdefenderForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPlayer"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Counter-Strike BreakThrough Edition Player Selection"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.ResumeLayout(False)
        Me.BitdefenderGroupbox3.ResumeLayout(False)
        Me.BitdefenderGroupbox3.PerformLayout()
        Me.BitdefenderGroupbox2.ResumeLayout(False)
        Me.BitdefenderGroupbox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BitdefenderGroupbox1.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitdefenderForm1 As CS_BTE_Launcher.BitdefenderForm
    Friend WithEvents BitdefenderGroupbox1 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents BitdefenderGroupbox2 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents lbl_Sex As System.Windows.Forms.Label
    Friend WithEvents lbl_Model As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Team As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_SelectedCT As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_SelectedT As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents btn_Select As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents BitdefenderGroupbox3 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents txt_SelName As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents lv_Player As System.Windows.Forms.ListView
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents lv_MyPlayer As System.Windows.Forms.ListView
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btn_Clear As CS_BTE_Launcher.BitdefenderButton
End Class
