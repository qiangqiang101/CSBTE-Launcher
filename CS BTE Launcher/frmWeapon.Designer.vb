<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeapon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeapon))
        Me.BitdefenderForm1 = New CS_BTE_Launcher.BitdefenderForm()
        Me.btn_Cancel = New CS_BTE_Launcher.BitdefenderButton()
        Me.btn_Save = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderGroupbox2 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.pb_Weight = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pb_FiringSpeed = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pb_Reaction = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pb_HitRate = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.pb_Damage = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.lbl_Ammo = New System.Windows.Forms.Label()
        Me.lbl_Cost = New System.Windows.Forms.Label()
        Me.lbl_Model = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BitdefenderGroupbox1 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.lv_Weapon = New System.Windows.Forms.ListView()
        Me.BitdefenderForm1.SuspendLayout()
        Me.BitdefenderGroupbox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BitdefenderGroupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BitdefenderForm1
        '
        Me.BitdefenderForm1.BackColor = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.Controls.Add(Me.btn_Cancel)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Save)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox2)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox1)
        Me.BitdefenderForm1.DisableControlboxClose = True
        Me.BitdefenderForm1.DisableControlboxMax = True
        Me.BitdefenderForm1.DisableControlboxMin = True
        Me.BitdefenderForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BitdefenderForm1.Location = New System.Drawing.Point(0, 0)
        Me.BitdefenderForm1.Name = "BitdefenderForm1"
        Me.BitdefenderForm1.Size = New System.Drawing.Size(971, 545)
        Me.BitdefenderForm1.TabIndex = 0
        Me.BitdefenderForm1.Text = "Counter-Strike BreakThrough Edition Weapon Selection"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.Location = New System.Drawing.Point(765, 486)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(186, 40)
        Me.btn_Cancel.TabIndex = 80
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.Location = New System.Drawing.Point(573, 486)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(186, 40)
        Me.btn_Save.TabIndex = 79
        Me.btn_Save.Text = "Select"
        '
        'BitdefenderGroupbox2
        '
        Me.BitdefenderGroupbox2.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox2.Controls.Add(Me.pb_Weight)
        Me.BitdefenderGroupbox2.Controls.Add(Me.pb_FiringSpeed)
        Me.BitdefenderGroupbox2.Controls.Add(Me.pb_Reaction)
        Me.BitdefenderGroupbox2.Controls.Add(Me.pb_HitRate)
        Me.BitdefenderGroupbox2.Controls.Add(Me.pb_Damage)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Ammo)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Cost)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Model)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_Name)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label11)
        Me.BitdefenderGroupbox2.Controls.Add(Me.lbl_ID)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label10)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label9)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label8)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label7)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label6)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label5)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label4)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label3)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label2)
        Me.BitdefenderGroupbox2.Controls.Add(Me.Label1)
        Me.BitdefenderGroupbox2.Controls.Add(Me.PictureBox1)
        Me.BitdefenderGroupbox2.Location = New System.Drawing.Point(668, 40)
        Me.BitdefenderGroupbox2.Name = "BitdefenderGroupbox2"
        Me.BitdefenderGroupbox2.Size = New System.Drawing.Size(283, 440)
        Me.BitdefenderGroupbox2.Subtitle = ""
        Me.BitdefenderGroupbox2.TabIndex = 72
        Me.BitdefenderGroupbox2.Title = "Weapon Information"
        '
        'pb_Weight
        '
        '
        '
        '
        Me.pb_Weight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pb_Weight.Location = New System.Drawing.Point(78, 343)
        Me.pb_Weight.Name = "pb_Weight"
        Me.pb_Weight.Size = New System.Drawing.Size(188, 15)
        Me.pb_Weight.TabIndex = 78
        Me.pb_Weight.Text = "ProgressBarX5"
        '
        'pb_FiringSpeed
        '
        '
        '
        '
        Me.pb_FiringSpeed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pb_FiringSpeed.Location = New System.Drawing.Point(78, 318)
        Me.pb_FiringSpeed.Name = "pb_FiringSpeed"
        Me.pb_FiringSpeed.Size = New System.Drawing.Size(188, 15)
        Me.pb_FiringSpeed.TabIndex = 77
        Me.pb_FiringSpeed.Text = "ProgressBarX4"
        '
        'pb_Reaction
        '
        '
        '
        '
        Me.pb_Reaction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pb_Reaction.Location = New System.Drawing.Point(78, 293)
        Me.pb_Reaction.Name = "pb_Reaction"
        Me.pb_Reaction.Size = New System.Drawing.Size(188, 15)
        Me.pb_Reaction.TabIndex = 76
        Me.pb_Reaction.Text = "ProgressBarX3"
        '
        'pb_HitRate
        '
        '
        '
        '
        Me.pb_HitRate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pb_HitRate.Location = New System.Drawing.Point(78, 268)
        Me.pb_HitRate.Name = "pb_HitRate"
        Me.pb_HitRate.Size = New System.Drawing.Size(188, 15)
        Me.pb_HitRate.TabIndex = 75
        Me.pb_HitRate.Text = "ProgressBarX2"
        '
        'pb_Damage
        '
        '
        '
        '
        Me.pb_Damage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pb_Damage.Location = New System.Drawing.Point(78, 243)
        Me.pb_Damage.Name = "pb_Damage"
        Me.pb_Damage.Size = New System.Drawing.Size(188, 15)
        Me.pb_Damage.TabIndex = 74
        Me.pb_Damage.Text = "ProgressBarX1"
        '
        'lbl_Ammo
        '
        Me.lbl_Ammo.AutoSize = True
        Me.lbl_Ammo.ForeColor = System.Drawing.Color.White
        Me.lbl_Ammo.Location = New System.Drawing.Point(75, 393)
        Me.lbl_Ammo.Name = "lbl_Ammo"
        Me.lbl_Ammo.Size = New System.Drawing.Size(13, 15)
        Me.lbl_Ammo.TabIndex = 68
        Me.lbl_Ammo.Text = "0"
        '
        'lbl_Cost
        '
        Me.lbl_Cost.AutoSize = True
        Me.lbl_Cost.ForeColor = System.Drawing.Color.White
        Me.lbl_Cost.Location = New System.Drawing.Point(75, 368)
        Me.lbl_Cost.Name = "lbl_Cost"
        Me.lbl_Cost.Size = New System.Drawing.Size(19, 15)
        Me.lbl_Cost.TabIndex = 67
        Me.lbl_Cost.Text = "$0"
        '
        'lbl_Model
        '
        Me.lbl_Model.AutoSize = True
        Me.lbl_Model.ForeColor = System.Drawing.Color.White
        Me.lbl_Model.Location = New System.Drawing.Point(75, 218)
        Me.lbl_Model.Name = "lbl_Model"
        Me.lbl_Model.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Model.TabIndex = 61
        Me.lbl_Model.Text = "-"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.ForeColor = System.Drawing.Color.White
        Me.lbl_Name.Location = New System.Drawing.Point(75, 193)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Name.TabIndex = 60
        Me.lbl_Name.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 393)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Ammo:"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.ForeColor = System.Drawing.Color.White
        Me.lbl_ID.Location = New System.Drawing.Point(75, 168)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(13, 15)
        Me.lbl_ID.TabIndex = 57
        Me.lbl_ID.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 15)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(15, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Weight:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Fire Rate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Recoil:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Hit Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Damage:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Weapon Preview:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.CS_BTE_Launcher.My.Resources.Resources.cannotuse
        Me.PictureBox1.Location = New System.Drawing.Point(9, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BitdefenderGroupbox1
        '
        Me.BitdefenderGroupbox1.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox1.Controls.Add(Me.lv_Weapon)
        Me.BitdefenderGroupbox1.Location = New System.Drawing.Point(20, 40)
        Me.BitdefenderGroupbox1.Name = "BitdefenderGroupbox1"
        Me.BitdefenderGroupbox1.Size = New System.Drawing.Size(642, 440)
        Me.BitdefenderGroupbox1.Subtitle = ""
        Me.BitdefenderGroupbox1.TabIndex = 71
        Me.BitdefenderGroupbox1.Title = "Your Weapons"
        '
        'lv_Weapon
        '
        Me.lv_Weapon.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lv_Weapon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_Weapon.ForeColor = System.Drawing.Color.White
        Me.lv_Weapon.Location = New System.Drawing.Point(12, 47)
        Me.lv_Weapon.MultiSelect = False
        Me.lv_Weapon.Name = "lv_Weapon"
        Me.lv_Weapon.Size = New System.Drawing.Size(619, 382)
        Me.lv_Weapon.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_Weapon.TabIndex = 71
        Me.lv_Weapon.TileSize = New System.Drawing.Size(118, 25)
        Me.lv_Weapon.UseCompatibleStateImageBehavior = False
        Me.lv_Weapon.View = System.Windows.Forms.View.Tile
        '
        'frmWeapon
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(971, 545)
        Me.Controls.Add(Me.BitdefenderForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmWeapon"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Counter-Strike BreakThrough Edition Weapon Selection"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.ResumeLayout(False)
        Me.BitdefenderGroupbox2.ResumeLayout(False)
        Me.BitdefenderGroupbox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BitdefenderGroupbox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitdefenderForm1 As CS_BTE_Launcher.BitdefenderForm
    Friend WithEvents BitdefenderGroupbox1 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents lv_Weapon As System.Windows.Forms.ListView
    Friend WithEvents BitdefenderGroupbox2 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents pb_Weight As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents pb_FiringSpeed As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents pb_Reaction As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents pb_HitRate As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents pb_Damage As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents lbl_Ammo As System.Windows.Forms.Label
    Friend WithEvents lbl_Cost As System.Windows.Forms.Label
    Friend WithEvents lbl_Model As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Cancel As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents btn_Save As CS_BTE_Launcher.BitdefenderButton
End Class
