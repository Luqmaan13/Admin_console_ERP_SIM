Public Class NewCompanyForm
    Private DB As New DBAccess
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CompanyNameTextBox.Clear()
        ContactPersonTextBox.Clear()
        EmailTextBox.Clear()
        WebsiteTextBox.Clear()
        PhoneTextBox.Clear()

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

    Private Function checkForDublicates(name As String) As Integer
        Dim count As Integer
        DB.AddParam("@name", name)
        DB.ExecuteQuery("select count(*) as c from company where name=?")
        count = DB.DBDataTable(0)!c
        Return count
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim s As String
        Dim count As Integer
        s = validateTextBoxes()
        If s <> "All Correct" Then
            MessageBox.Show(s)
            Exit Sub
        End If

        count = checkForDublicates(CompanyNameTextBox.Text)
        If count > 0 Then
            MessageBox.Show("Company already exsists")
            Exit Sub
        End If

        DB.AddParam("@companyName", CompanyNameTextBox.Text)
        DB.AddParam("@contPer", ContactPersonTextBox.Text)
        DB.AddParam("@email", EmailTextBox.Text)
        DB.AddParam("@website", WebsiteTextBox.Text)
        DB.AddParam("@phone", PhoneTextBox.Text)
        DB.AddParam("@status", 1)
        DB.ExecuteQuery("insert into company(name,contact_person,email,website,phone,status) values(?,?,?,?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Succesfully added")
        Me.Close()
    End Sub
End Class