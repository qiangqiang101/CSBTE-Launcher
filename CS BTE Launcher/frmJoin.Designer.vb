<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJoin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJoin))
        Me.BitdefenderForm1 = New CS_BTE_Launcher.BitdefenderForm()
        Me.btn_Cancel = New CS_BTE_Launcher.BitdefenderButton()
        Me.btn_JoinSvr = New CS_BTE_Launcher.BitdefenderButton()
        Me.BitdefenderGroupbox3 = New CS_BTE_Launcher.BitdefenderGroupbox()
        Me.txt_Port = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_IPAddress = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BitdefenderForm1.SuspendLayout()
        Me.BitdefenderGroupbox3.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BitdefenderForm1
        '
        Me.BitdefenderForm1.BackColor = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.Controls.Add(Me.btn_Cancel)
        Me.BitdefenderForm1.Controls.Add(Me.btn_JoinSvr)
        Me.BitdefenderForm1.Controls.Add(Me.BitdefenderGroupbox3)
        Me.BitdefenderForm1.DisableControlboxClose = True
        Me.BitdefenderForm1.DisableControlboxMax = True
        Me.BitdefenderForm1.DisableControlboxMin = True
        Me.BitdefenderForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BitdefenderForm1.Location = New System.Drawing.Point(0, 0)
        Me.BitdefenderForm1.Name = "BitdefenderForm1"
        Me.BitdefenderForm1.Size = New System.Drawing.Size(360, 234)
        Me.BitdefenderForm1.TabIndex = 0
        Me.BitdefenderForm1.Text = "Join Game"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.Location = New System.Drawing.Point(181, 175)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(145, 40)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_JoinSvr
        '
        Me.btn_JoinSvr.BackColor = System.Drawing.Color.Transparent
        Me.btn_JoinSvr.Location = New System.Drawing.Point(30, 175)
        Me.btn_JoinSvr.Name = "btn_JoinSvr"
        Me.btn_JoinSvr.Size = New System.Drawing.Size(145, 40)
        Me.btn_JoinSvr.TabIndex = 3
        Me.btn_JoinSvr.Text = "Join Game"
        '
        'BitdefenderGroupbox3
        '
        Me.BitdefenderGroupbox3.BackColor = System.Drawing.Color.Transparent
        Me.BitdefenderGroupbox3.Controls.Add(Me.txt_Port)
        Me.BitdefenderGroupbox3.Controls.Add(Me.PictureBox7)
        Me.BitdefenderGroupbox3.Controls.Add(Me.Label10)
        Me.BitdefenderGroupbox3.Controls.Add(Me.txt_IPAddress)
        Me.BitdefenderGroupbox3.Controls.Add(Me.PictureBox6)
        Me.BitdefenderGroupbox3.Controls.Add(Me.Label9)
        Me.BitdefenderGroupbox3.Location = New System.Drawing.Point(20, 40)
        Me.BitdefenderGroupbox3.Name = "BitdefenderGroupbox3"
        Me.BitdefenderGroupbox3.Size = New System.Drawing.Size(320, 129)
        Me.BitdefenderGroupbox3.Subtitle = ""
        Me.BitdefenderGroupbox3.TabIndex = 3
        Me.BitdefenderGroupbox3.Title = "Join Server"
        '
        'txt_Port
        '
        Me.txt_Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Port.Location = New System.Drawing.Point(118, 87)
        Me.txt_Port.Name = "txt_Port"
        Me.txt_Port.Size = New System.Drawing.Size(183, 16)
        Me.txt_Port.TabIndex = 2
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox7.Location = New System.Drawing.Point(114, 80)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox7.TabIndex = 54
        Me.PictureBox7.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 15)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Port:"
        '
        'txt_IPAddress
        '
        Me.txt_IPAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.txt_IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_IPAddress.Location = New System.Drawing.Point(118, 52)
        Me.txt_IPAddress.Name = "txt_IPAddress"
        Me.txt_IPAddress.Size = New System.Drawing.Size(183, 16)
        Me.txt_IPAddress.TabIndex = 1
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.CS_BTE_Launcher.My.Resources.Resources.textbox
        Me.PictureBox6.Location = New System.Drawing.Point(114, 45)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(190, 28)
        Me.PictureBox6.TabIndex = 51
        Me.PictureBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "IP Address:"
        '
        'frmJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 234)
        Me.Controls.Add(Me.BitdefenderForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmJoin"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Join Game"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.ResumeLayout(False)
        Me.BitdefenderGroupbox3.ResumeLayout(False)
        Me.BitdefenderGroupbox3.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitdefenderForm1 As CS_BTE_Launcher.BitdefenderForm
    Friend WithEvents btn_JoinSvr As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents BitdefenderGroupbox3 As CS_BTE_Launcher.BitdefenderGroupbox
    Friend WithEvents txt_Port As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_IPAddress As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As CS_BTE_Launcher.BitdefenderButton
End Class
