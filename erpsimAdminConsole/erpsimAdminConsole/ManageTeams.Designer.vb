<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageTeams
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TeamDataGridView = New System.Windows.Forms.DataGridView()
        Me.TeamMatesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnAssignedParticipantsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TeamIdTextBox = New System.Windows.Forms.TextBox()
        Me.TeamMateIdTextBox = New System.Windows.Forms.TextBox()
        Me.UAParticipantsIDTextBox = New System.Windows.Forms.TextBox()
        Me.DesiredTeamMateDataGridView = New System.Windows.Forms.DataGridView()
        Me.UAParNameTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MultifuncionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiFuncDeleteStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NewTeamButton = New System.Windows.Forms.Button()
        CType(Me.TeamDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamMatesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnAssignedParticipantsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesiredTeamMateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TeamDataGridView
        '
        Me.TeamDataGridView.AllowUserToAddRows = False
        Me.TeamDataGridView.AllowUserToDeleteRows = False
        Me.TeamDataGridView.AllowUserToResizeColumns = False
        Me.TeamDataGridView.AllowUserToResizeRows = False
        Me.TeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeamDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TeamDataGridView.Location = New System.Drawing.Point(28, 85)
        Me.TeamDataGridView.Name = "TeamDataGridView"
        Me.TeamDataGridView.Size = New System.Drawing.Size(422, 402)
        Me.TeamDataGridView.TabIndex = 0
        '
        'TeamMatesDataGridView
        '
        Me.TeamMatesDataGridView.AllowUserToAddRows = False
        Me.TeamMatesDataGridView.AllowUserToDeleteRows = False
        Me.TeamMatesDataGridView.AllowUserToResizeColumns = False
        Me.TeamMatesDataGridView.AllowUserToResizeRows = False
        Me.TeamMatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeamMatesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TeamMatesDataGridView.Location = New System.Drawing.Point(456, 85)
        Me.TeamMatesDataGridView.Name = "TeamMatesDataGridView"
        Me.TeamMatesDataGridView.Size = New System.Drawing.Size(370, 216)
        Me.TeamMatesDataGridView.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(949, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Unassigned"
        '
        'UnAssignedParticipantsDataGridView
        '
        Me.UnAssignedParticipantsDataGridView.AllowUserToAddRows = False
        Me.UnAssignedParticipantsDataGridView.AllowUserToDeleteRows = False
        Me.UnAssignedParticipantsDataGridView.AllowUserToResizeColumns = False
        Me.UnAssignedParticipantsDataGridView.AllowUserToResizeRows = False
        Me.UnAssignedParticipantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnAssignedParticipantsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.UnAssignedParticipantsDataGridView.Location = New System.Drawing.Point(832, 86)
        Me.UnAssignedParticipantsDataGridView.Name = "UnAssignedParticipantsDataGridView"
        Me.UnAssignedParticipantsDataGridView.Size = New System.Drawing.Size(350, 402)
        Me.UnAssignedParticipantsDataGridView.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(610, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Teammates"
        '
        'TeamIdTextBox
        '
        Me.TeamIdTextBox.Enabled = False
        Me.TeamIdTextBox.Location = New System.Drawing.Point(28, 57)
        Me.TeamIdTextBox.Name = "TeamIdTextBox"
        Me.TeamIdTextBox.ReadOnly = True
        Me.TeamIdTextBox.Size = New System.Drawing.Size(45, 20)
        Me.TeamIdTextBox.TabIndex = 8
        '
        'TeamMateIdTextBox
        '
        Me.TeamMateIdTextBox.Enabled = False
        Me.TeamMateIdTextBox.Location = New System.Drawing.Point(510, 59)
        Me.TeamMateIdTextBox.Name = "TeamMateIdTextBox"
        Me.TeamMateIdTextBox.ReadOnly = True
        Me.TeamMateIdTextBox.Size = New System.Drawing.Size(45, 20)
        Me.TeamMateIdTextBox.TabIndex = 9
        '
        'UAParticipantsIDTextBox
        '
        Me.UAParticipantsIDTextBox.Enabled = False
        Me.UAParticipantsIDTextBox.Location = New System.Drawing.Point(832, 59)
        Me.UAParticipantsIDTextBox.Name = "UAParticipantsIDTextBox"
        Me.UAParticipantsIDTextBox.ReadOnly = True
        Me.UAParticipantsIDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.UAParticipantsIDTextBox.TabIndex = 10
        '
        'DesiredTeamMateDataGridView
        '
        Me.DesiredTeamMateDataGridView.AllowUserToAddRows = False
        Me.DesiredTeamMateDataGridView.AllowUserToDeleteRows = False
        Me.DesiredTeamMateDataGridView.AllowUserToResizeColumns = False
        Me.DesiredTeamMateDataGridView.AllowUserToResizeRows = False
        Me.DesiredTeamMateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DesiredTeamMateDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DesiredTeamMateDataGridView.Location = New System.Drawing.Point(456, 337)
        Me.DesiredTeamMateDataGridView.Name = "DesiredTeamMateDataGridView"
        Me.DesiredTeamMateDataGridView.Size = New System.Drawing.Size(370, 150)
        Me.DesiredTeamMateDataGridView.TabIndex = 11
        '
        'UAParNameTextBox
        '
        Me.UAParNameTextBox.Location = New System.Drawing.Point(1082, 57)
        Me.UAParNameTextBox.Name = "UAParNameTextBox"
        Me.UAParNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UAParNameTextBox.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MultifuncionalToolStripMenuItem, Me.MultiFuncDeleteStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1194, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MultifuncionalToolStripMenuItem
        '
        Me.MultifuncionalToolStripMenuItem.Name = "MultifuncionalToolStripMenuItem"
        Me.MultifuncionalToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.MultifuncionalToolStripMenuItem.Text = "multi-funcional"
        Me.MultifuncionalToolStripMenuItem.Visible = False
        '
        'MultiFuncDeleteStripMenuItem
        '
        Me.MultiFuncDeleteStripMenuItem.Name = "MultiFuncDeleteStripMenuItem"
        Me.MultiFuncDeleteStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MultiFuncDeleteStripMenuItem.Text = "Delete"
        Me.MultiFuncDeleteStripMenuItem.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(587, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Desired teammates"
        '
        'NewTeamButton
        '
        Me.NewTeamButton.ForeColor = System.Drawing.Color.Black
        Me.NewTeamButton.Location = New System.Drawing.Point(375, 57)
        Me.NewTeamButton.Name = "NewTeamButton"
        Me.NewTeamButton.Size = New System.Drawing.Size(75, 23)
        Me.NewTeamButton.TabIndex = 16
        Me.NewTeamButton.Text = "New Team"
        Me.NewTeamButton.UseVisualStyleBackColor = True
        '
        'ManageTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1194, 531)
        Me.Controls.Add(Me.NewTeamButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UAParNameTextBox)
        Me.Controls.Add(Me.DesiredTeamMateDataGridView)
        Me.Controls.Add(Me.UAParticipantsIDTextBox)
        Me.Controls.Add(Me.TeamMateIdTextBox)
        Me.Controls.Add(Me.TeamIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UnAssignedParticipantsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TeamMatesDataGridView)
        Me.Controls.Add(Me.TeamDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManageTeams"
        Me.Text = "ManageTeams"
        CType(Me.TeamDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamMatesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnAssignedParticipantsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesiredTeamMateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TeamDataGridView As DataGridView
    Friend WithEvents TeamMatesDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnAssignedParticipantsDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TeamIdTextBox As TextBox
    Friend WithEvents TeamMateIdTextBox As TextBox
    Friend WithEvents UAParticipantsIDTextBox As TextBox
    Friend WithEvents DesiredTeamMateDataGridView As DataGridView
    Friend WithEvents UAParNameTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MultifuncionalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents MultiFuncDeleteStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTeamButton As Button
End Class
