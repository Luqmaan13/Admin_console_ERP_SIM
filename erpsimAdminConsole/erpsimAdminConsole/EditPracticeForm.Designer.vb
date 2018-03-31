<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPracticeForm
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
        Me.RoomsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.StartTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PracticeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PracticeIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RoomsTextBox
        '
        Me.RoomsTextBox.Location = New System.Drawing.Point(113, 128)
        Me.RoomsTextBox.Name = "RoomsTextBox"
        Me.RoomsTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RoomsTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Room(s):"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(156, 168)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 17
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(39, 168)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 16
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'StartTimeDateTimePicker
        '
        Me.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.StartTimeDateTimePicker.Location = New System.Drawing.Point(113, 102)
        Me.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker"
        Me.StartTimeDateTimePicker.ShowUpDown = True
        Me.StartTimeDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.StartTimeDateTimePicker.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Start Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date:"
        '
        'PracticeDateTimePicker
        '
        Me.PracticeDateTimePicker.Location = New System.Drawing.Point(113, 76)
        Me.PracticeDateTimePicker.Name = "PracticeDateTimePicker"
        Me.PracticeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PracticeDateTimePicker.TabIndex = 12
        '
        'PracticeIdTextBox
        '
        Me.PracticeIdTextBox.Enabled = False
        Me.PracticeIdTextBox.Location = New System.Drawing.Point(113, 50)
        Me.PracticeIdTextBox.Name = "PracticeIdTextBox"
        Me.PracticeIdTextBox.Size = New System.Drawing.Size(43, 20)
        Me.PracticeIdTextBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ID:"
        '
        'EditPracticeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 231)
        Me.Controls.Add(Me.PracticeIdTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RoomsTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.StartTimeDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PracticeDateTimePicker)
        Me.Name = "EditPracticeForm"
        Me.Text = "EditPracticeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoomsTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents StartTimeDateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PracticeDateTimePicker As DateTimePicker
    Friend WithEvents PracticeIdTextBox As TextBox
    Friend WithEvents Label4 As Label
End Class
