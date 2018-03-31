Public Class ManageMentorsForm
    Private DB As New DBAccess
    Private id As Integer
    Private Sub LoadTeams()
        DB.AddParam("eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select * from team where event_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        TeamDataGridView.DataSource = DB.DBDataTable

    End Sub
    Private Sub ManageMentorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeams()

    End Sub

    Private Sub LoadMentorsOfTeam(id As Integer)
        DB.AddParam("@tid", id)
        DB.ExecuteQuery("select * from mentor join mentor_team on mentor.id= mentor_team.mentor_id where team_id = ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MentorTeamDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub LoadUAMentorsOfCompany(id As Integer)
        DB.AddParam("@companyid", id)
        DB.AddParam("@eventid", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select * from mentor where company_id=? and  mentor.id not in (select mentor_id from mentor_team join team on mentor_team.team_id=team.id where event_id=?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        UAMentorDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub TeamDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeamDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            TeamIdTextBox.Clear()

            Exit Sub
        End If
        EnableDisAbleToolStrup(False)
        TeamIdTextBox.Text = TeamDataGridView.Item(0, e.RowIndex).Value
        LoadMentorsOfTeam(TeamIdTextBox.Text)
        id = TeamDataGridView.Item(2, e.RowIndex).Value
        LoadUAMentorsOfCompany(id)
    End Sub

    Private Sub EnableDisAbleToolStrup(b As Boolean)
        MultiFunctionalMenuStripToolStripMenuItem.Enabled = b
        MultiFunctionalMenuStripToolStripMenuItem.Visible = b
    End Sub

    Private Sub MentorTeamDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MentorTeamDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            MentorIdTextBox.Clear()

            Exit Sub
        End If
        UAMentorIdTextBox.Clear()
        EnableDisAbleToolStrup(True)
        MultiFunctionalMenuStripToolStripMenuItem.Text = "Remove Mentor"
        MentorIdTextBox.Text = MentorTeamDataGridView.Item(0, e.RowIndex).Value
    End Sub

    Private Sub UAMentorDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UAMentorDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            UAMentorIdTextBox.Clear()

            Exit Sub
        End If

        UAMentorIdTextBox.Text = UAMentorDataGridView.Item(0, e.RowIndex).Value
        MentorIdTextBox.Clear()
        EnableDisAbleToolStrup(True)
        MultiFunctionalMenuStripToolStripMenuItem.Text = "Add Mentor"
    End Sub

    Private Sub MultiFunctionalMenuStripToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiFunctionalMenuStripToolStripMenuItem.Click
        If MultiFunctionalMenuStripToolStripMenuItem.Text = "Add Mentor" Then
            AddMentor()
        ElseIf MultiFunctionalMenuStripToolStripMenuItem.Text = "Remove Mentor" Then
            RemoveMentor()

        End If
        MultiFunctionalMenuStripToolStripMenuItem.Enabled = False
        MultiFunctionalMenuStripToolStripMenuItem.Visible = False

        loadTables()

    End Sub

    Private Sub RemoveMentor()
        DB.AddParam("@tid", TeamIdTextBox.Text)
        DB.AddParam("@mId", MentorIdTextBox.Text)
        DB.ExecuteQuery("delete from mentor_team where team_id=? and mentor_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MentorIdTextBox.Clear()

    End Sub

    Private Sub loadTables()

        LoadUAMentorsOfCompany(id)
        LoadMentorsOfTeam(TeamIdTextBox.Text)
    End Sub

    Private Sub AddMentor()
        DB.AddParam("@mid", UAMentorIdTextBox.Text)
        DB.AddParam("@tid", TeamIdTextBox.Text)

        DB.ExecuteQuery("insert into mentor_team(mentor_id,team_id) values(?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        UAMentorIdTextBox.Clear()

    End Sub

    Private Sub NewMentorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMentorToolStripMenuItem.Click
        NewMentorForm.ShowDialog()
    End Sub
End Class