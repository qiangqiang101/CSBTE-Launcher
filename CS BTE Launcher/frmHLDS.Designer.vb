<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHLDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHLDS))
        Me.BitdefenderForm1 = New CS_BTE_Launcher.BitdefenderForm()
        Me.btn_Cancel = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderGroupbox2 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.txt_RCONPwd = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Port = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_IpAddress = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MaxPlayer = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Map = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_HLDS = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderForm1.SuspendLayout()
        Me.BitdefenderGroupbox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BitdefenderForm1
        '
        Me.BitdefenderForm1.BackColor = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.Controls.Add(Me.btn_Cancel)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox2)
        Me.BitdefenderForm1.Controls.Add(Me.btn_HLDS)
        Me.BitdefenderForm1.DisableControlboxClose = True
        Me.BitdefenderForm1.DisableControlboxMax = True
        Me.BitdefenderForm1.DisableControlboxMin = True
        Me.BitdefenderForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BitdefenderForm1.Location = New System.Drawing.Point(0, 0)
        Me.BitdefenderForm1.Name = "BitdefenderForm1"
        Me.BitdefenderForm1.Padding = New System.Windows.Forms.Padding(10)
        Me.BitdefenderForm1.Size = New System.Drawing.Size(363, 373)
        Me.BitdefenderForm1.TabIndex = 0
        Me.BitdefenderForm1.Text = "Create Online Server"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.Location = New System.Drawing.Point(182, 308)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(145, 40)
        Me.btn_Cancel.TabIndex = 8
        Me.btn_Cancel.Text = "Cancel"
        '
        'BitdefenderGroupbox2
        '
        Me.BitdefenderGroupbox2.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox2.Controls.Add(Me.txt_RCONPwd)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox5)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label6)
        Me.BitdefenderGroupbox2.Controls.Add(Me.txt_Port)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox3)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label3)
        Me.BitdefenderGroupbox2.Controls.Add(Me.txt_IpAddress)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox6)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label2)
        Me.BitdefenderGroupbox2.Controls.Add(Me.txt_MaxPlayer)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox4)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label1)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label5)
        Me.BitdefenderGroupbox2.Controls.Add(Me.cmb_Map)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox2)
        Me.BitdefenderGroupbox2.Controls.Add(Me.txt_Name)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox1)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label4)
        Me.BitdefenderGroupbox2.Location = New System.Drawing.Point(20, 40)
        Me.BitdefenderGroupbox2.Name = "BitdefenderGroupbox2"
        Me.BitdefenderGroupbox2.Size = New System.Drawing.Size(320, 262)
        Me.BitdefenderGroupbox2.Subtitle = ""
        Me.BitdefenderGroupbox2.TabIndex = 2
        Me.BitdefenderGroupbox2.Title = "Dedicated Server"
        '
        'txt_RCONPwd
        '
        Me.txt_RCONPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_RCONPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_RCONPwd.Location = New System.Drawing.Point(120, 221)
        Me.txt_RCONPwd.Name = "txt_RCONPwd"
        Me.txt_RCONPwd.Size = New System.Drawing.Size(183, 16)
        Me.txt_RCONPwd.TabIndex = 6
        Me.txt_RCONPwd.Text = "CSBTE"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox5.Location = New System.Drawing.Point(116, 214)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox5.TabIndex = 73
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "RCON Password"
        '
        'txt_Port
        '
        Me.txt_Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Port.Location = New System.Drawing.Point(120, 187)
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(183, 16)
        Me.txt_Port.TabIndex = 5
        Me.txt_Port.Text = "27015"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox3.Location = New System.Drawing.Point(116, 180)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "UDP Port"
        '
        'txt_IpAddress
        '
        Me.txt_IpAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_IpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_IpAddress.Location = New System.Drawing.Point(120, 153)
        Me.txt_IpAddress.Name = "txt_IpAddress"
        Me.txt_IpAddress.Size = New System.Drawing.Size(183, 16)
        Me.txt_IpAddress.TabIndex = 4
        Me.txt_IpAddress.Text = "127.0.0.1"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox6.Location = New System.Drawing.Point(116, 146)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox6.TabIndex = 67
        Me.PictureBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "IP Address"
        '
        'txt_MaxPlayer
        '
        Me.txt_MaxPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_MaxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_MaxPlayer.Location = New System.Drawing.Point(120, 119)
        Me.txt_MaxPlayer.Name = "txt_MaxPlayer"
        Me.txt_MaxPlayer.Size = New System.Drawing.Size(183, 16)
        Me.txt_MaxPlayer.TabIndex = 3
        Me.txt_MaxPlayer.Text = "32"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox4.Location = New System.Drawing.Point(116, 112)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox4.TabIndex = 64
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Max. Players"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Map"
        '
        'cmb_Map
        '
        Me.cmb_Map.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.cmb_Map.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Map.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_Map.FormattingEnabled = True
        Me.cmb_Map.Location = New System.Drawing.Point(120, 81)
        Me.cmb_Map.Name = "cmb_Map"
        Me.cmb_Map.Size = New System.Drawing.Size(183, 23)
        Me.cmb_Map.Sorted = True
        Me.cmb_Map.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox2.Location = New System.Drawing.Point(116, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'txt_Name
        '
        Me.txt_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Name.Location = New System.Drawing.Point(120, 51)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.ReadOnly = True
        Me.txt_Name.Size = New System.Drawing.Size(183, 16)
        Me.txt_Name.TabIndex = 1
        Me.txt_Name.Text = "Counter-Strike Breakthrough Edition"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox1.Location = New System.Drawing.Point(116, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Game"
        '
        'btn_HLDS
        '
        Me.btn_HLDS.BackColor = System.Drawing.Color.Transparent
        Me.btn_HLDS.Location = New System.Drawing.Point(31, 308)
        Me.btn_HLDS.Name = "btn_HLDS"
        Me.btn_HLDS.Size = New System.Drawing.Size(145, 40)
        Me.btn_HLDS.TabIndex = 7
        Me.btn_HLDS.Text = "Start Server"
        '
        'frmHLDS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(363, 373)
        Me.Controls.Add(Me.BitdefenderForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHLDS"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Online Server"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.ResumeLayout(False)
        Me.BitdefenderGroupbox2.ResumeLayout(False)
        Me.BitdefenderGroupbox2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitdefenderForm1 As CS_BTE_Launcher.BitdefenderForm
    Friend WithEvents BitdefenderGroupbox2 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents txt_MaxPlayer As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_HLDS As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_Map As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_RCONPwd As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Port As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_IpAddress As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As CS_BTE_Launcher.BitdefenderButton
End Class
