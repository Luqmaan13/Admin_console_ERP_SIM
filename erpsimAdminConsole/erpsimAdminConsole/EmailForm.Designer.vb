<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailForm
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuickEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracticeReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Participants", "Liason", "Mentors"})
        Me.ComboBox1.Location = New System.Drawing.Point(294, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Select one"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(150, 169)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(407, 240)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(398, 415)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 4
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickEmailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuickEmailToolStripMenuItem
        '
        Me.QuickEmailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeamInfoToolStripMenuItem, Me.AttendanceInfoToolStripMenuItem, Me.PracticeReminderToolStripMenuItem})
        Me.QuickEmailToolStripMenuItem.Name = "QuickEmailToolStripMenuItem"
        Me.QuickEmailToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.QuickEmailToolStripMenuItem.Text = "Quick Email"
        '
        'TeamInfoToolStripMenuItem
        '
        Me.TeamInfoToolStripMenuItem.Name = "TeamInfoToolStripMenuItem"
        Me.TeamInfoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TeamInfoToolStripMenuItem.Text = "Team Info"
        '
        'AttendanceInfoToolStripMenuItem
        '
        Me.AttendanceInfoToolStripMenuItem.Name = "AttendanceInfoToolStripMenuItem"
        Me.AttendanceInfoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AttendanceInfoToolStripMenuItem.Text = "Attendance Info"
        '
        'PracticeReminderToolStripMenuItem
        '
        Me.PracticeReminderToolStripMenuItem.Name = "PracticeReminderToolStripMenuItem"
        Me.PracticeReminderToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PracticeReminderToolStripMenuItem.Text = "Practice Reminder"
        '
        'EmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 449)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmailForm"
        Me.Text = "EmailForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SendButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuickEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeamInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PracticeReminderToolStripMenuItem As ToolStripMenuItem
End Class
