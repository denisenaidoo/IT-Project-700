<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msUserAction = New System.Windows.Forms.MenuStrip()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiUpdateUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDelID = New System.Windows.Forms.TextBox()
        Me.txtDelUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdFindSkill = New System.Windows.Forms.Button()
        Me.txtFindSkill = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msUserAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(41, 347)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(1003, 336)
        Me.dgvData.TabIndex = 0
        '
        'cbxUsers
        '
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(41, 257)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(1003, 24)
        Me.cbxUsers.TabIndex = 1
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(41, 98)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(816, 22)
        Me.txtFind.TabIndex = 2
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(881, 98)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(163, 27)
        Me.cmdFind.TabIndex = 3
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Employee Name: "
        '
        'msUserAction
        '
        Me.msUserAction.BackColor = System.Drawing.Color.Black
        Me.msUserAction.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msUserAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.msiDeleteUser, Me.msiUpdateUsers})
        Me.msUserAction.Location = New System.Drawing.Point(0, 0)
        Me.msUserAction.Name = "msUserAction"
        Me.msUserAction.Padding = New System.Windows.Forms.Padding(8, 10, 0, 10)
        Me.msUserAction.Size = New System.Drawing.Size(1082, 44)
        Me.msUserAction.TabIndex = 6
        Me.msUserAction.Text = "MenuStrip1"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.NewUserToolStripMenuItem.Text = "Create Employee"
        '
        'msiDeleteUser
        '
        Me.msiDeleteUser.Enabled = False
        Me.msiDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.msiDeleteUser.Name = "msiDeleteUser"
        Me.msiDeleteUser.Size = New System.Drawing.Size(137, 24)
        Me.msiDeleteUser.Text = "Delete Employee"
        '
        'msiUpdateUsers
        '
        Me.msiUpdateUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.msiUpdateUsers.Name = "msiUpdateUsers"
        Me.msiUpdateUsers.Size = New System.Drawing.Size(142, 24)
        Me.msiUpdateUsers.Text = "Update Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Employee ID:"
        '
        'txtDelID
        '
        Me.txtDelID.Location = New System.Drawing.Point(163, 304)
        Me.txtDelID.Name = "txtDelID"
        Me.txtDelID.ReadOnly = True
        Me.txtDelID.Size = New System.Drawing.Size(160, 22)
        Me.txtDelID.TabIndex = 8
        '
        'txtDelUser
        '
        Me.txtDelUser.Location = New System.Drawing.Point(580, 304)
        Me.txtDelUser.Name = "txtDelUser"
        Me.txtDelUser.ReadOnly = True
        Me.txtDelUser.Size = New System.Drawing.Size(464, 22)
        Me.txtDelUser.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Employee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Select Employee "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Enter Skillset: "
        '
        'cmdFindSkill
        '
        Me.cmdFindSkill.Location = New System.Drawing.Point(881, 168)
        Me.cmdFindSkill.Name = "cmdFindSkill"
        Me.cmdFindSkill.Size = New System.Drawing.Size(163, 27)
        Me.cmdFindSkill.TabIndex = 13
        Me.cmdFindSkill.Text = "Find"
        Me.cmdFindSkill.UseVisualStyleBackColor = True
        '
        'txtFindSkill
        '
        Me.txtFindSkill.Location = New System.Drawing.Point(41, 168)
        Me.txtFindSkill.Name = "txtFindSkill"
        Me.txtFindSkill.Size = New System.Drawing.Size(816, 22)
        Me.txtFindSkill.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1082, 708)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdFindSkill)
        Me.Controls.Add(Me.txtFindSkill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDelUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDelID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.msUserAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MainMenuStrip = Me.msUserAction
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Management System"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msUserAction.ResumeLayout(False)
        Me.msUserAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cbxUsers As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents cmdFind As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents msUserAction As MenuStrip
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDelID As TextBox
    Friend WithEvents txtDelUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents msiDeleteUser As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdFindSkill As Button
    Friend WithEvents txtFindSkill As TextBox
    Friend WithEvents msiUpdateUsers As ToolStripMenuItem
End Class
