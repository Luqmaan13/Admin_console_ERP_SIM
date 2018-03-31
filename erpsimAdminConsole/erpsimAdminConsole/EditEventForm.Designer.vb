<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEventForm
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GameDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GameDescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GameNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EventIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(158, 223)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 20
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(51, 223)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 19
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"Spring", "Summer ", "Fall"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(112, 188)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SemesterComboBox.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Semester:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date:"
        '
        'GameDateTimePicker
        '
        Me.GameDateTimePicker.Location = New System.Drawing.Point(112, 157)
        Me.GameDateTimePicker.Name = "GameDateTimePicker"
        Me.GameDateTimePicker.Size = New System.Drawing.Size(182, 20)
        Me.GameDateTimePicker.TabIndex = 15
        '
        'GameDescriptionRichTextBox
        '
        Me.GameDescriptionRichTextBox.Location = New System.Drawing.Point(112, 86)
        Me.GameDescriptionRichTextBox.Name = "GameDescriptionRichTextBox"
        Me.GameDescriptionRichTextBox.Size = New System.Drawing.Size(200, 65)
        Me.GameDescriptionRichTextBox.TabIndex = 14
        Me.GameDescriptionRichTextBox.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Description:"
        '
        'GameNameTextBox
        '
        Me.GameNameTextBox.Location = New System.Drawing.Point(112, 60)
        Me.GameNameTextBox.Name = "GameNameTextBox"
        Me.GameNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GameNameTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Game Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Event ID:"
        '
        'EventIdTextBox
        '
        Me.EventIdTextBox.Enabled = False
        Me.EventIdTextBox.Location = New System.Drawing.Point(112, 34)
        Me.EventIdTextBox.Name = "EventIdTextBox"
        Me.EventIdTextBox.Size = New System.Drawing.Size(53, 20)
        Me.EventIdTextBox.TabIndex = 22
        '
        'EditEventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 282)
        Me.Controls.Add(Me.EventIdTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GameDateTimePicker)
        Me.Controls.Add(Me.GameDescriptionRichTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GameNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditEventForm"
        Me.Text = "EditEventForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GameDateTimePicker As DateTimePicker
    Friend WithEvents GameDescriptionRichTextBox As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GameNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EventIdTextBox As TextBox
End Class
