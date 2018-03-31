Public Class NewMentorForm
    Private DB As New DBAccess
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmailTextBox.Clear()
        PhoneTextBox.Clear()
        CompanyComboBox.SelectedIndex = -1

    End Sub

    Private Sub PopulateCompanyCombo()
        CompanyComboBox.Items.Clear()
        DB.ExecuteQuery("select * from company")
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            CompanyComboBox.Items.Add(ADataRow("name"))
        Next
    End Sub

    Private Sub NewMentorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCompanyCombo()
    End Sub

    Private Function validateInputs() As String
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            Return "Please enter first name"
        ElseIf String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            Return "Please enter last name"
        ElseIf String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            Return "Please enter email"
        ElseIf String.IsNullOrWhiteSpace(PhoneTextBox.Text) Then
            Return "Please enter phone number"
        ElseIf CompanyComboBox.SelectedIndex = -1 Then
            Return "please select company"
        Else
            Return "All Correct"
        End If
    End Function

    Private Function getCompanyId(name As String) As Integer
        Dim id As Integer = 1
        DB.AddParam("name", name)
        DB.ExecuteQuery("select * from company where name=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Return id
            Exit Function
        End If

        If DB.Recordcount > 0 Then
            Return Integer.Parse(DB.DBDataTable(0)!id)
        Else
            Return id
        End If


    End Function

    Private Function checkIfExsists(email As String) As Integer
        DB.AddParam("@email", email)
        DB.ExecuteQuery("select count(*) as count from mentor where email =?")
        Return DB.DBDataTable(0)!count
    End Function
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim p As Integer
        Dim s As String
        Dim id As Integer
        s = validateInputs()
        If s <> "All Correct" Then
            MessageBox.Show(s)
            Exit Sub
        End If
        p = checkIfExsists(EmailTextBox.Text)
        If p > 0 Then
            MessageBox.Show("Mentor already exsists")
            Exit Sub
        End If

        id = getCompanyId(CompanyComboBox.Text)

        DB.AddParam("@firstName", FirstNameTextBox.Text)
        DB.AddParam("@lastName", LastNameTextBox.Text)
        DB.AddParam("@email", EmailTextBox.Text)
        DB.AddParam("@phone", PhoneTextBox.Text)
        DB.AddParam("@cid", id)
        DB.AddParam("@status", 1)
        DB.ExecuteQuery("insert into mentor(first_name,last_name,email,phone,company_id,status) values(?,?,?,?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MessageBox.Show("Successfully added mentor")
        Me.Close()
    End Sub
End Class