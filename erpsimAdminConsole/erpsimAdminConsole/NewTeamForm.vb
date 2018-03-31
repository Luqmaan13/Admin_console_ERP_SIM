Public Class NewTeamForm
    Private DB As New DBAccess
    Private Const NOT_CORRECT_INPUT As String = "Not correct input"
    Private Const CORRECT_INPUT As String = "correct"

    Private Sub PopulateCompanyCombo()
        CompanyComboBox.Items.Clear()
        DB.ExecuteQuery("select * from company")
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            CompanyComboBox.Items.Add(ADataRow("name"))
        Next
    End Sub

    Private Sub NewTeamForm_Load(sender As Object, e As EventArgs) Handles Me.Load, Me.Activated
        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select * from team where event_id = ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        TeamDataGridView.DataSource = DB.DBDataTable
        PopulateCompanyCombo()



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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim s As String
        Dim id As Integer
        s = validateTextBox()
        If s <> CORRECT_INPUT Then
            MessageBox.Show("Please enter correct input")
            Exit Sub
        End If
        id = getCompanyId(CompanyComboBox.Text)
        DB.AddParam("@name", TeamTextBox.Text)
        DB.AddParam("@id", id)
        DB.AddParam("@eventid", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("insert into team(name,company_id,event_id) values(?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MessageBox.Show("successfully added company")
        CompanyComboBox.SelectedIndex = -1
        TeamTextBox.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class