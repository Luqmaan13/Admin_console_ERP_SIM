<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCompanyForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CompanyIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(112, 243)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(49, 20)
        Me.CancelButton.TabIndex = 25
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(44, 243)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(43, 20)
        Me.EditSaveButton.TabIndex = 23
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Phone"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(129, 203)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Website"
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.Location = New System.Drawing.Point(129, 171)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(159, 20)
        Me.WebsiteTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(129, 139)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(159, 20)
        Me.EmailTextBox.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Contact Person"
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(129, 108)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactPersonTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Company Name"
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(129, 74)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.CompanyNameTextBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ID"
        '
        'CompanyIdTextBox
        '
        Me.CompanyIdTextBox.Enabled = False
        Me.CompanyIdTextBox.Location = New System.Drawing.Point(129, 48)
        Me.CompanyIdTextBox.Name = "CompanyIdTextBox"
        Me.CompanyIdTextBox.Size = New System.Drawing.Size(32, 20)
        Me.CompanyIdTextBox.TabIndex = 26
        '
        'EditCompanyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 322)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CompanyIdTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
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
        Me.Name = "EditCompanyForm"
        Me.Text = "EditCompanyForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents WebsiteTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContactPersonTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CompanyIdTextBox As TextBox
End Class
