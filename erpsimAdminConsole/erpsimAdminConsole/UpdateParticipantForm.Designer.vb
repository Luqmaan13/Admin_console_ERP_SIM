<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateParticipantForm
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
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClubTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MinorTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ClassStandingComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(130, 38)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Enabled = False
        Me.FirstNameTextBox.Location = New System.Drawing.Point(130, 64)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Enabled = False
        Me.LastNameTextBox.Location = New System.Drawing.Point(130, 90)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name:"
        '
        'ClubTextBox
        '
        Me.ClubTextBox.Enabled = False
        Me.ClubTextBox.Location = New System.Drawing.Point(130, 221)
        Me.ClubTextBox.Name = "ClubTextBox"
        Me.ClubTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClubTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Club:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(130, 116)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email:"
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Enabled = False
        Me.MajorTextBox.Location = New System.Drawing.Point(130, 169)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MajorTextBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Major Program:"
        '
        'MinorTextBox
        '
        Me.MinorTextBox.Enabled = False
        Me.MinorTextBox.Location = New System.Drawing.Point(130, 195)
        Me.MinorTextBox.Name = "MinorTextBox"
        Me.MinorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MinorTextBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Minor:"
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(79, 263)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 15
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(186, 263)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 16
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ClassStandingComboBox
        '
        Me.ClassStandingComboBox.Enabled = False
        Me.ClassStandingComboBox.FormattingEnabled = True
        Me.ClassStandingComboBox.Items.AddRange(New Object() {"Graduate", "Freshman", "Sophomore", "Junior", "Senior"})
        Me.ClassStandingComboBox.Location = New System.Drawing.Point(130, 142)
        Me.ClassStandingComboBox.Name = "ClassStandingComboBox"
        Me.ClassStandingComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClassStandingComboBox.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Class Standing:"
        '
        'UpdateParticipantForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 317)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ClassStandingComboBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.MinorTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MajorTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClubTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateParticipantForm"
        Me.Text = "UpdateParticipantForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ClubTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MinorTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ClassStandingComboBox As ComboBox
    Friend WithEvents Label8 As Label
End Class
