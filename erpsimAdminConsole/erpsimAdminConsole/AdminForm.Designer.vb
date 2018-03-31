<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomeForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracticeSessionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParticipantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MentorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTeamsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompaniesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PracticeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DaysLeftLabel = New System.Windows.Forms.Label()
        Me.ReportsButton = New System.Windows.Forms.Button()
        Me.PracticeIdTextBox = New System.Windows.Forms.TextBox()
        Me.EventIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PracticeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(266, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Administrator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(424, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Up Coming Practice Sessions"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventToolStripMenuItem, Me.PracticeSessionsToolStripMenuItem, Me.ParticipantsToolStripMenuItem, Me.ManageTeamsToolStripMenuItem, Me.MentorsToolStripMenuItem, Me.CompaniesToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.EmailListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(751, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.EventToolStripMenuItem.Text = "&Event"
        '
        'PracticeSessionsToolStripMenuItem
        '
        Me.PracticeSessionsToolStripMenuItem.Name = "PracticeSessionsToolStripMenuItem"
        Me.PracticeSessionsToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.PracticeSessionsToolStripMenuItem.Text = "Practice Sessions"
        '
        'ParticipantsToolStripMenuItem
        '
        Me.ParticipantsToolStripMenuItem.Name = "ParticipantsToolStripMenuItem"
        Me.ParticipantsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ParticipantsToolStripMenuItem.Text = "Participants"
        '
        'ManageTeamsToolStripMenuItem
        '
        Me.ManageTeamsToolStripMenuItem.Name = "ManageTeamsToolStripMenuItem"
        Me.ManageTeamsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ManageTeamsToolStripMenuItem.Text = "Teams"
        '
        'MentorsToolStripMenuItem
        '
        Me.MentorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageTeamsToolStripMenuItem1, Me.ViewEditToolStripMenuItem})
        Me.MentorsToolStripMenuItem.Name = "MentorsToolStripMenuItem"
        Me.MentorsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MentorsToolStripMenuItem.Text = "Mentors"
        '
        'ManageTeamsToolStripMenuItem1
        '
        Me.ManageTeamsToolStripMenuItem1.Name = "ManageTeamsToolStripMenuItem1"
        Me.ManageTeamsToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ManageTeamsToolStripMenuItem1.Text = "Manage Teams"
        '
        'ViewEditToolStripMenuItem
        '
        Me.ViewEditToolStripMenuItem.Name = "ViewEditToolStripMenuItem"
        Me.ViewEditToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewEditToolStripMenuItem.Text = "View/Edit"
        '
        'CompaniesToolStripMenuItem
        '
        Me.CompaniesToolStripMenuItem.Name = "CompaniesToolStripMenuItem"
        Me.CompaniesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.CompaniesToolStripMenuItem.Text = "Companies"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'PracticeDataGridView
        '
        Me.PracticeDataGridView.AllowUserToAddRows = False
        Me.PracticeDataGridView.AllowUserToDeleteRows = False
        Me.PracticeDataGridView.AllowUserToResizeColumns = False
        Me.PracticeDataGridView.AllowUserToResizeRows = False
        Me.PracticeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PracticeDataGridView.Location = New System.Drawing.Point(382, 141)
        Me.PracticeDataGridView.Name = "PracticeDataGridView"
        Me.PracticeDataGridView.ReadOnly = True
        Me.PracticeDataGridView.Size = New System.Drawing.Size(333, 186)
        Me.PracticeDataGridView.TabIndex = 3
        '
        'DaysLeftLabel
        '
        Me.DaysLeftLabel.AutoSize = True
        Me.DaysLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaysLeftLabel.ForeColor = System.Drawing.Color.Cornsilk
        Me.DaysLeftLabel.Location = New System.Drawing.Point(60, 81)
        Me.DaysLeftLabel.Name = "DaysLeftLabel"
        Me.DaysLeftLabel.Size = New System.Drawing.Size(198, 25)
        Me.DaysLeftLabel.TabIndex = 4
        Me.DaysLeftLabel.Text = "_ Days Left for D-Day"
        '
        'ReportsButton
        '
        Me.ReportsButton.Location = New System.Drawing.Point(640, 28)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(75, 23)
        Me.ReportsButton.TabIndex = 5
        Me.ReportsButton.Text = "&Reports"
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'PracticeIdTextBox
        '
        Me.PracticeIdTextBox.Location = New System.Drawing.Point(449, 115)
        Me.PracticeIdTextBox.Name = "PracticeIdTextBox"
        Me.PracticeIdTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PracticeIdTextBox.TabIndex = 6
        '
        'EventIdTextBox
        '
        Me.EventIdTextBox.Enabled = False
        Me.EventIdTextBox.Location = New System.Drawing.Point(78, 45)
        Me.EventIdTextBox.Name = "EventIdTextBox"
        Me.EventIdTextBox.Size = New System.Drawing.Size(58, 20)
        Me.EventIdTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Event ID:"
        '
        'EmailListToolStripMenuItem
        '
        Me.EmailListToolStripMenuItem.Name = "EmailListToolStripMenuItem"
        Me.EmailListToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EmailListToolStripMenuItem.Text = "Email List"
        '
        'AdminHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(751, 465)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EventIdTextBox)
        Me.Controls.Add(Me.PracticeIdTextBox)
        Me.Controls.Add(Me.ReportsButton)
        Me.Controls.Add(Me.DaysLeftLabel)
        Me.Controls.Add(Me.PracticeDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminHomeForm"
        Me.Text = "Erpsim Administrator Console"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PracticeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ParticipantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MentorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompaniesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PracticeDataGridView As DataGridView
    Friend WithEvents DaysLeftLabel As Label
    Friend WithEvents ReportsButton As Button
    Friend WithEvents PracticeIdTextBox As TextBox
    Friend WithEvents ManageTeamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventIdTextBox As TextBox
    Friend WithEvents PracticeSessionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents ManageTeamsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailListToolStripMenuItem As ToolStripMenuItem
End Class
