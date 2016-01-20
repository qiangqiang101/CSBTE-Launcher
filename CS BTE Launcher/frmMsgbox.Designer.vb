<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgbox))
        Me.BitdefenderForm1 = New CS_BTE_Launcher.BitdefenderForm()
        Me.btn_Cancel = New CS_BTE_Launcher.BitdefenderButton()
        Me.btn_Yes = New CS_BTE_Launcher.BitdefenderButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BitdefenderForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BitdefenderForm1
        '
        Me.BitdefenderForm1.BackColor = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.Controls.Add(Me.Label1)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Cancel)
        Me.BitdefenderForm1.Controls.Add(Me.btn_Yes)
        Me.BitdefenderForm1.DisableControlboxClose = False
        Me.BitdefenderForm1.DisableControlboxMax = False
        Me.BitdefenderForm1.DisableControlboxMin = False
        Me.BitdefenderForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BitdefenderForm1.Location = New System.Drawing.Point(0, 0)
        Me.BitdefenderForm1.Name = "BitdefenderForm1"
        Me.BitdefenderForm1.Size = New System.Drawing.Size(394, 205)
        Me.BitdefenderForm1.TabIndex = 0
        Me.BitdefenderForm1.Text = "Quit Game"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.Location = New System.Drawing.Point(203, 148)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(145, 40)
        Me.btn_Cancel.TabIndex = 76
        Me.btn_Cancel.Text = "No"
        '
        'btn_Yes
        '
        Me.btn_Yes.BackColor = System.Drawing.Color.Transparent
        Me.btn_Yes.Location = New System.Drawing.Point(52, 148)
        Me.btn_Yes.Name = "btn_Yes"
        Me.btn_Yes.Size = New System.Drawing.Size(145, 40)
        Me.btn_Yes.TabIndex = 75
        Me.btn_Yes.Text = "Yes"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 37)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Do you wish to stop playing now?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMsgbox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(394, 205)
        Me.Controls.Add(Me.BitdefenderForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMsgbox"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quit Game"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BitdefenderForm1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BitdefenderForm1 As CS_BTE_Launcher.BitdefenderForm
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As CS_BTE_Launcher.BitdefenderButton
    Friend WithEvents btn_Yes As CS_BTE_Launcher.BitdefenderButton
End Class
