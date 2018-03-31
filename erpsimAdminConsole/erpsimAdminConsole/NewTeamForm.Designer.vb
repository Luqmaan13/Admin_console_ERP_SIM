<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTeamForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TeamTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.TeamDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TeamDataGridView
        '
        Me.TeamDataGridView.AllowUserToAddRows = False
        Me.TeamDataGridView.AllowUserToDeleteRows = False
        Me.TeamDataGridView.AllowUserToResizeColumns = False
        Me.TeamDataGridView.AllowUserToResizeRows = False
        Me.TeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeamDataGridView.Location = New System.Drawing.Point(29, 60)
        Me.TeamDataGridView.Name = "TeamDataGridView"
        Me.TeamDataGridView.ReadOnly = True
        Me.TeamDataGridView.Size = New System.Drawing.Size(341, 268)
        Me.TeamDataGridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Exsisting teams"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Team Name:"
        '
        'TeamTextBox
        '
        Me.TeamTextBox.Location = New System.Drawing.Point(608, 147)
        Me.TeamTextBox.Name = "TeamTextBox"
        Me.TeamTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeamTextBox.TabIndex = 3
        '
        'CompanyComboBox
        '
        Me.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyComboBox.FormattingEnabled = True
        Me.CompanyComboBox.Location = New System.Drawing.Point(608, 116)
        Me.CompanyComboBox.Name = "CompanyComboBox"
        Me.CompanyComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CompanyComboBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Company:"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(530, 183)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(633, 183)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'NewTeamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 362)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CompanyComboBox)
        Me.Controls.Add(Me.TeamTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TeamDataGridView)
        Me.Name = "NewTeamForm"
        Me.Text = "TeamForm"
        CType(Me.TeamDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TeamDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TeamTextBox As TextBox
    Friend WithEvents CompanyComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
End Class
