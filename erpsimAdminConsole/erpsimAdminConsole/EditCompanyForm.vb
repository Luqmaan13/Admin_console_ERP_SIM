Public Class EditCompanyForm
    Private DB As New DBAccess
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub disableEnableTextBoxes(b As Boolean)
        CompanyNameTextBox.Enabled = b
        ContactPersonTextBox.Enabled = b
        EmailTextBox.Enabled = b
        WebsiteTextBox.Enabled = b
        PhoneTextBox.Enabled = b

    End Sub

    Private Function validateTextBoxes() As String
        If String.IsNullOrWhiteSpace(CompanyNameTextBox.Text) Then
            Return "Please enter company"
        ElseIf String.IsNullOrWhiteSpace(ContactPersonTextBox.Text) Then
            Return "Please enter contact person"
        ElseIf String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            Return "Please enter email"
        ElseIf String.IsNullOrWhiteSpace(WebsiteTextBox.Text) Then
            Return "Please enter website"
        ElseIf String.IsNullOrWhiteSpace(PhoneTextBox.Text) Then
            Return "Please enter phone number"
        Else
            Return "All Correct"
        End If
    End Function

    Private Sub loadCompany()
        DB.AddParam("@id", CompanyForm.CompanyIdTextBox.Text)
        DB.ExecuteQuery("select * from company where id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        CompanyIdTextBox.Text = DB.DBDataTable(0)!id
        CompanyNameTextBox.Text = DB.DBDataTable(0)!name
        ContactPersonTextBox.Text = DB.DBDataTable(0)!contact_person
        EmailTextBox.Text = DB.DBDataTable(0)!email
        WebsiteTextBox.Text = DB.DBDataTable(0)!website
        PhoneTextBox.Text = DB.DBDataTable(0)!phone
    End Sub

    Private Sub EditCompanyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableEnableTextBoxes(False)
        loadCompany()
    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim s As String
        If EditSaveButton.Text = "&Edit" Then
            disableEnableTextBoxes(True)
            EditSaveButton.Text = "&Save"
        Else
            disableEnableTextBoxes(False)
            EditSaveButton.Text = "&Edit"

            s = validateTextBoxes()
            If s <> "All Correct" Then
                MessageBox.Show(s)
                Exit Sub
            End If

            DB.AddParam("@companyName", CompanyNameTextBox.Text)
            DB.AddParam("@contPer", ContactPersonTextBox.Text)
            DB.AddParam("@email", EmailTextBox.Text)
            DB.AddParam("@website", WebsiteTextBox.Text)
            DB.AddParam("@phone", PhoneTextBox.Text)
            DB.AddParam("@id", CompanyIdTextBox.Text)
            DB.ExecuteQuery("update company set name=?,contact_person=?,email=?,website=?,phone=? where id=?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("succesfully updated")
            Me.Close()
        End If
    End Sub
End Class