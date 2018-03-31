<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPracticeForm
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
        Me.PracticeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StartTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoomsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PracticeDateTimePicker
        '
        Me.PracticeDateTimePicker.Location = New System.Drawing.Point(114, 35)
        Me.PracticeDateTimePicker.Name = "PracticeDateTimePicker"
        Me.PracticeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PracticeDateTimePicker.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start Time:"
        '
        'StartTimeDateTimePicker
        '
        Me.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.StartTimeDateTimePicker.Location = New System.Drawing.Point(114, 70)
        Me.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker"
        Me.StartTimeDateTimePicker.ShowUpDown = True
        Me.StartTimeDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.StartTimeDateTimePicker.TabIndex = 7
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(34, 148)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(151, 148)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Room(s):"
        '
        'RoomsTextBox
        '
        Me.RoomsTextBox.Location = New System.Drawing.Point(114, 109)
        Me.RoomsTextBox.Name = "RoomsTextBox"
        Me.RoomsTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RoomsTextBox.TabIndex = 11
        '
        'NewPracticeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 204)
        Me.Controls.Add(Me.RoomsTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.StartTimeDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PracticeDateTimePicker)
        Me.Name = "NewPracticeForm"
        Me.Text = "NewPracticeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PracticeDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StartTimeDateTimePicker As DateTimePicker
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RoomsTextBox As TextBox
End Class
