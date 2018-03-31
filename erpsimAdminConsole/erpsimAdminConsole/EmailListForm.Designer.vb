<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailListForm
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
        Me.EmailListComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailListRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'EmailListComboBox
        '
        Me.EmailListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmailListComboBox.FormattingEnabled = True
        Me.EmailListComboBox.Items.AddRange(New Object() {"Participants", "Liasons", "Mentors", "All"})
        Me.EmailListComboBox.Location = New System.Drawing.Point(267, 71)
        Me.EmailListComboBox.Name = "EmailListComboBox"
        Me.EmailListComboBox.Size = New System.Drawing.Size(160, 21)
        Me.EmailListComboBox.TabIndex = 0
        '
        'EmailListRichTextBox
        '
        Me.EmailListRichTextBox.Location = New System.Drawing.Point(35, 98)
        Me.EmailListRichTextBox.Name = "EmailListRichTextBox"
        Me.EmailListRichTextBox.Size = New System.Drawing.Size(613, 214)
        Me.EmailListRichTextBox.TabIndex = 1
        Me.EmailListRichTextBox.Text = ""
        '
        'EmailListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 383)
        Me.Controls.Add(Me.EmailListRichTextBox)
        Me.Controls.Add(Me.EmailListComboBox)
        Me.Name = "EmailListForm"
        Me.Text = "EmailListForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmailListComboBox As ComboBox
    Friend WithEvents EmailListRichTextBox As RichTextBox
End Class
