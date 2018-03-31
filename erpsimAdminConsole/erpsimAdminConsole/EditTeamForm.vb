Public Class EditTeamForm
    Private DB As New DBAccess
    Private Const NOT_CORRECT_INPUT = "Please enter correct input"
    Private Const CORRECT_INPUT = "Correct Input"
    Private Sub PopulateCompanyCombo()
        CompanyComboBox.Items.Clear()
        DB.ExecuteQuery("select * from company")
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            CompanyComboBox.Items.Add(ADataRow("name"))
        Next
    End Sub

    Private Sub EditTeamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As Integer
        Dim companyName As String
        PopulateCompanyCombo()
        TeamIdTextBox.Text = ManageTeams.TeamIdTextBox.Text
        DB.AddParam("@id", TeamIdTextBox.Text)
        DB.ExecuteQuery("select * from team where id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        TeamTextBox.Text = DB.DBDataTable(0)!name
        s = DB.DBDataTable(0)!company_id
        DB.AddParam("@id", s)
        DB.ExecuteQuery("select * from company where id=?")
        companyName = DB.DBDataTable(0)!name
        CompanyComboBox.SelectedItem = companyName

        SetFieldsEditable(False)
    End Sub

    Private Function validateTextBox() As String
        If String.IsNullOrWhiteSpace(TeamTextBox.Text) Then
            Return NOT_CORRECT_INPUT
        ElseIf String.IsNullOrWhiteSpace(CompanyComboBox.SelectedIndex = -1) Then
            Return NOT_CORRECT_INPUT
        End If
        Return CORRECT_INPUT
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

    Private Sub SetFieldsEditable(b As Boolean)
        TeamTextBox.Enabled = b
        CompanyComboBox.Enabled = b
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim s As String
        Dim id As Integer

        If EditSaveButton.Text = "&Edit" Then
            SetFieldsEditable(True)
            EditSaveButton.Text = "&Save"
        Else
            SetFieldsEditable(False)
            EditSaveButton.Text = "&Edit"


            s = validateTextBox()

            If s <> CORRECT_INPUT Then
                MessageBox.Show(s)
                Exit Sub
            End If
            id = getCompanyId(CompanyComboBox.Text)
            DB.AddParam("@Tname", TeamTextBox.Text)
            DB.AddParam("@Cid", id)
            DB.AddParam("@tid", TeamIdTextBox.Text)
            DB.ExecuteQuery("update team set name=?,company_id=? where id=?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub

            End If
            MessageBox.Show("Successfully updated")
            Me.Close()
        End If
    End Sub
End Class