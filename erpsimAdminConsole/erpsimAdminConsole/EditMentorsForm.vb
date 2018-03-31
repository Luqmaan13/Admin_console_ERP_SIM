Public Class EditMentorsForm
    Private DB As New DBAccess
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub PopulateCompanyCombo()
        CompanyComboBox.Items.Clear()
        DB.ExecuteQuery("select * from company")
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            CompanyComboBox.Items.Add(ADataRow("name"))
        Next
    End Sub
    Private Function validateInput() As String
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


    Private Sub SetFieldsEditable(b As Boolean)
        FirstNameTextBox.Enabled = b
        LastNameTextBox.Enabled = b
        EmailTextBox.Enabled = b
        PhoneTextBox.Enabled = b
        CompanyComboBox.Enabled = b

    End Sub

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

    Private Sub PopulateTextBoxes()
        Dim s As Integer
        Dim CompanyName As String
        DB.AddParam("@id", MentorsForm.MentorIdTextBox.Text)
        DB.ExecuteQuery("select * from mentor where id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MentorIDTextBox.Text = MentorsForm.MentorIdTextBox.Text
        FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
        LastNameTextBox.Text = DB.DBDataTable(0)!last_name
        EmailTextBox.Text = DB.DBDataTable(0)!email
        PhoneTextBox.Text = DB.DBDataTable(0)!phone
        s = DB.DBDataTable(0)!company_id
        DB.AddParam("@id", s)
        DB.ExecuteQuery("select * from company where id=?")
        CompanyName = DB.DBDataTable(0)!name
        CompanyComboBox.SelectedItem = CompanyName

    End Sub

    Private Sub EditMentorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MentorIDTextBox.Enabled = False
        PopulateCompanyCombo()
        SetFieldsEditable(False)
        PopulateTextBoxes()
    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim val As String
        Dim id As Integer
        If EditSaveButton.Text = "&Edit" Then
            SetFieldsEditable(True)
            EditSaveButton.Text = "&Save"
        Else
            SetFieldsEditable(False)
            EditSaveButton.Text = "&Edit"



            val = validateInput()
            If val <> "All Correct" Then
                MessageBox.Show(val)
                Exit Sub
            End If

            id = getCompanyId(CompanyComboBox.Text)

            DB.AddParam("@firstName", FirstNameTextBox.Text)
            DB.AddParam("@lastName", LastNameTextBox.Text)
            DB.AddParam("@email", EmailTextBox.Text)
            DB.AddParam("@phone", PhoneTextBox.Text)
            DB.AddParam("@cid", id)
            DB.AddParam("@mid", MentorIDTextBox.Text)
            DB.ExecuteQuery("update mentor set first_name=?,last_name=?,email=?,phone=?,company_id=? where id=?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            Else
                MessageBox.Show("Successfully updated")
            End If

        End If
    End Sub
End Class