<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCompanyForm
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
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(121, 30)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.CompanyNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Company Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contact Person"
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(121, 64)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactPersonTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(121, 95)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(159, 20)
        Me.EmailTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Website"
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.Location = New System.Drawing.Point(121, 127)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(159, 20)
        Me.WebsiteTextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Phone"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(121, 159)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 8
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(36, 199)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(43, 20)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(85, 199)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(44, 20)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 20)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NewCompanyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 258)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WebsiteTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ContactPersonTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Name = "NewCompanyForm"
        Me.Text = "NewCompanyForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContactPersonTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents WebsiteTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Button3 As Button
End Class
