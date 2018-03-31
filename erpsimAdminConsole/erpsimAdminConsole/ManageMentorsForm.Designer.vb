<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageMentorsForm
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
        Me.TeamDataGridView = New System.Windows.Forms.DataGridView()
        Me.MentorTeamDataGridView = New System.Windows.Forms.DataGridView()
        Me.UAMentorDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewMentorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiFunctionalMenuStripToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TeamIdTextBox = New System.Windows.Forms.TextBox()
        Me.MentorIdTextBox = New System.Windows.Forms.TextBox()
        Me.UAMentorIdTextBox = New System.Windows.Forms.TextBox()
        CType(Me.TeamDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MentorTeamDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UAMentorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TeamDataGridView.Location = New System.Drawing.Point(12, 65)
        Me.TeamDataGridView.Name = "TeamDataGridView"
        Me.TeamDataGridView.ReadOnly = True
        Me.TeamDataGridView.Size = New System.Drawing.Size(368, 370)
        Me.TeamDataGridView.TabIndex = 0
        '
        'MentorTeamDataGridView
        '
        Me.MentorTeamDataGridView.AllowUserToAddRows = False
        Me.MentorTeamDataGridView.AllowUserToDeleteRows = False
        Me.MentorTeamDataGridView.AllowUserToResizeColumns = False
        Me.MentorTeamDataGridView.AllowUserToResizeRows = False
        Me.MentorTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MentorTeamDataGridView.Location = New System.Drawing.Point(386, 65)
        Me.MentorTeamDataGridView.Name = "MentorTeamDataGridView"
        Me.MentorTeamDataGridView.ReadOnly = True
        Me.MentorTeamDataGridView.Size = New System.Drawing.Size(366, 370)
        Me.MentorTeamDataGridView.TabIndex = 1
        '
        'UAMentorDataGridView
        '
        Me.UAMentorDataGridView.AllowUserToAddRows = False
        Me.UAMentorDataGridView.AllowUserToDeleteRows = False
        Me.UAMentorDataGridView.AllowUserToResizeColumns = False
        Me.UAMentorDataGridView.AllowUserToResizeRows = False
        Me.UAMentorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UAMentorDataGridView.Location = New System.Drawing.Point(758, 65)
        Me.UAMentorDataGridView.Name = "UAMentorDataGridView"
        Me.UAMentorDataGridView.ReadOnly = True
        Me.UAMentorDataGridView.Size = New System.Drawing.Size(329, 370)
        Me.UAMentorDataGridView.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMentorToolStripMenuItem, Me.MultiFunctionalMenuStripToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1099, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewMentorToolStripMenuItem
        '
        Me.NewMentorToolStripMenuItem.Name = "NewMentorToolStripMenuItem"
        Me.NewMentorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.NewMentorToolStripMenuItem.Text = "New Mentor"
        '
        'MultiFunctionalMenuStripToolStripMenuItem
        '
        Me.MultiFunctionalMenuStripToolStripMenuItem.Name = "MultiFunctionalMenuStripToolStripMenuItem"
        Me.MultiFunctionalMenuStripToolStripMenuItem.Size = New System.Drawing.Size(158, 20)
        Me.MultiFunctionalMenuStripToolStripMenuItem.Text = "MultiFunctionalMenuStrip"
        Me.MultiFunctionalMenuStripToolStripMenuItem.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Teams"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mentors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(885, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Available"
        '
        'TeamIdTextBox
        '
        Me.TeamIdTextBox.Location = New System.Drawing.Point(13, 39)
        Me.TeamIdTextBox.Name = "TeamIdTextBox"
        Me.TeamIdTextBox.ReadOnly = True
        Me.TeamIdTextBox.Size = New System.Drawing.Size(48, 20)
        Me.TeamIdTextBox.TabIndex = 7
        '
        'MentorIdTextBox
        '
        Me.MentorIdTextBox.Location = New System.Drawing.Point(386, 39)
        Me.MentorIdTextBox.Name = "MentorIdTextBox"
        Me.MentorIdTextBox.ReadOnly = True
        Me.MentorIdTextBox.Size = New System.Drawing.Size(48, 20)
        Me.MentorIdTextBox.TabIndex = 8
        '
        'UAMentorIdTextBox
        '
        Me.UAMentorIdTextBox.Location = New System.Drawing.Point(758, 39)
        Me.UAMentorIdTextBox.Name = "UAMentorIdTextBox"
        Me.UAMentorIdTextBox.ReadOnly = True
        Me.UAMentorIdTextBox.Size = New System.Drawing.Size(46, 20)
        Me.UAMentorIdTextBox.TabIndex = 9
        '
        'ManageMentorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 447)
        Me.Controls.Add(Me.UAMentorIdTextBox)
        Me.Controls.Add(Me.MentorIdTextBox)
        Me.Controls.Add(Me.TeamIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UAMentorDataGridView)
        Me.Controls.Add(Me.MentorTeamDataGridView)
        Me.Controls.Add(Me.TeamDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManageMentorsForm"
        Me.Text = "ManageMentorsForm"
        CType(Me.TeamDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MentorTeamDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UAMentorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TeamDataGridView As DataGridView
    Friend WithEvents MentorTeamDataGridView As DataGridView
    Friend WithEvents UAMentorDataGridView As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MultiFunctionalMenuStripToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TeamIdTextBox As TextBox
    Friend WithEvents MentorIdTextBox As TextBox
    Friend WithEvents UAMentorIdTextBox As TextBox
    Friend WithEvents NewMentorToolStripMenuItem As ToolStripMenuItem
End Class
