Public Class ManageTeams
    Private DB As New DBAccess
    Private Const REMOVE_MEMBER As String = "Remove team-member"
    Private Const ADD_MEMBER As String = "Add team-member"
    Private Const EDIT_TEAM As String = "Edit Team"
    Private Const MAKE_REMOVE_LIASON = "Make/Remove Liason"
    Private liason As Integer

    Private Sub LoadTeams()
        DB.AddParam("eventid", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("Select * from team where event_id=? ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        TeamDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub LoadUAParticipants()
        DB.AddParam("eventid", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("SELECT t1.id,t1.first_name,t1.last_name FROM participant t1
join participation on t1.id=participation.participant_id
WHERE NOT EXISTS (SELECT t2.participant_id FROM team_assignment t2 WHERE t1.ID = t2.participant_id) and event_id=? and t1.status=1")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        UnAssignedParticipantsDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub ManageTeams_Load(sender As Object, e As EventArgs) Handles Me.Load, Me.Activated
        ' MultifuncionalToolStripMenuItem.Visible = False
        TeamIdTextBox.Clear()
        LoadTeams()
        LoadUAParticipants()
    End Sub

    Private Sub populateTeamMateGridView()
        DB.AddParam("@teamid", TeamIdTextBox.Text)
        DB.ExecuteQuery("select participant.id, participant.first_name,participant.last_name,participant.cmu_email,participant.liaison from
team_assignment join  participant on team_assignment.participant_id=participant.id where team_assignment.team_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        TeamMatesDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub TeamDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeamDataGridView.CellClick

        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            TeamIdTextBox.Clear()
            Exit Sub
        End If

        TeamIdTextBox.Text = TeamDataGridView.Item(0, e.RowIndex).Value
        clearDesiredDataGrid()
        populateTeamMateGridView()
        ShowMenuStripForTeam()

    End Sub

    Private Sub UnAssignedParticipantsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UnAssignedParticipantsDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or e.RowIndex = TeamDataGridView.RowCount - 1 Then
            UAParticipantsIDTextBox.Clear()

            Exit Sub
        End If
        If TeamIdTextBox.Text = "" Then
            MessageBox.Show("Please select a team first")
            Exit Sub
        End If
        clearDesiredDataGrid()
        UAParticipantsIDTextBox.Text = UnAssignedParticipantsDataGridView.Item(0, e.RowIndex).Value

        ShowMenuStripForUAParticipant()
        'LoadDesiredTeamMates(UAParticipantsIDTextBox.Text)
    End Sub

    Private Sub clearDesiredDataGrid()
        DesiredTeamMateDataGridView.DataSource = Nothing
    End Sub
    Private Sub TeamMatesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeamMatesDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            TeamMateIdTextBox.Clear()

            Exit Sub
        End If
        clearDesiredDataGrid()
        TeamMateIdTextBox.Text = TeamMatesDataGridView.Item(0, e.RowIndex).Value
        liason = TeamMatesDataGridView.Item(4, e.RowIndex).Value
        ShowMenuStripForTeamMate()
        LoadDesiredTeamMates(TeamMateIdTextBox.Text)
    End Sub


    Private Sub DesiredTeamMateDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DesiredTeamMateDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            UAParNameTextBox.Clear()

            Exit Sub
        End If
        UAParNameTextBox.Text = DesiredTeamMateDataGridView.Item(0, e.RowIndex).Value
        SearchbyfirstName(UAParNameTextBox.Text)
        'clearDesiredDataGrid()
    End Sub


    Private Sub LoadDesiredTeamMates(partId As String)
        ' Dim prosTeamMates As String
        'Get the desired team mates in a string
        DB.AddParam("@parId", Integer.Parse(partId))
        DB.ExecuteQuery("select desired_teammate from desired_teammates where participant_id=?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        DesiredTeamMateDataGridView.DataSource = DB.DBDataTable


    End Sub

    Private Sub ShowMenuStripForTeamMate()
        MultifuncionalToolStripMenuItem.Enabled = True
        MultifuncionalToolStripMenuItem.Text = REMOVE_MEMBER
        MultifuncionalToolStripMenuItem.Visible = True
        MultiFuncDeleteStripMenuItem.Enabled = True
        MultiFuncDeleteStripMenuItem.Visible = True
        MultiFuncDeleteStripMenuItem.Text = MAKE_REMOVE_LIASON
    End Sub

    Private Sub ShowMenuStripForUAParticipant()
        MultifuncionalToolStripMenuItem.Enabled = True
        MultifuncionalToolStripMenuItem.Text = ADD_MEMBER
        MultifuncionalToolStripMenuItem.Visible = True
        MultiFuncDeleteStripMenuItem.Enabled = False
        MultiFuncDeleteStripMenuItem.Visible = False
    End Sub

    Private Sub disableMenuStrip()
        MultiFuncDeleteStripMenuItem.Enabled = False
        MultifuncionalToolStripMenuItem.Enabled = False
        MultiFuncDeleteStripMenuItem.Visible = False
        MultifuncionalToolStripMenuItem.Visible = False
        'TeamIdTextBox.Text = ""
    End Sub


    Private Sub ShowMenuStripForTeam()
        'MultiFuncDeleteStripMenuItem.Enabled = True
        MultifuncionalToolStripMenuItem.Enabled = True
        MultifuncionalToolStripMenuItem.Text = EDIT_TEAM
        MultifuncionalToolStripMenuItem.Visible = True
        ' MultiFuncDeleteStripMenuItem.Visible = True
    End Sub


    Private Sub SearchbyfirstName(firstName As String)
        DB.AddParam("@firstName", firstName & "%")
        DB.AddParam("event_id", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("SELECT t1.id,t1.first_name,t1.last_name FROM participant t1
join participation on t1.id=participation.participant_id
WHERE NOT EXISTS (SELECT t2.participant_id FROM team_assignment t2 WHERE t1.ID = t2.participant_id) and t1.first_name like ? and participation.event_id=? and t1.status=1")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        UnAssignedParticipantsDataGridView.DataSource = DB.DBDataTable


    End Sub



    Private Sub UAParNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles UAParNameTextBox.KeyUp
        SearchbyfirstName(UAParNameTextBox.Text)
    End Sub





    Private Sub MultifuncionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultifuncionalToolStripMenuItem.Click
        If MultifuncionalToolStripMenuItem.Text = EDIT_TEAM Then
            EditTeamForm.ShowDialog()
        ElseIf MultifuncionalToolStripMenuItem.Text = ADD_MEMBER Then
            AddTeamMember(UAParticipantsIDTextBox.Text, TeamIdTextBox.Text)
        ElseIf MultifuncionalToolStripMenuItem.Text = REMOVE_MEMBER Then
            RemoveTeamMember(TeamIdTextBox.Text, TeamMateIdTextBox.Text)

        End If
        LoadTables()
    End Sub

    Private Sub LoadTables()

        LoadUAParticipants()
        populateTeamMateGridView()
        disableMenuStrip()
    End Sub

    Private Sub RemoveTeamMember(teamid As String, teamMateId As String)
        DB.AddParam("@teamMateId", Integer.Parse(teamMateId))
        If liason = 1 Then
            DB.ExecuteQuery("update participant set liaison=0 where id=?")
        Else
            DB.ExecuteQuery("update participant set liaison=0 where id=?")
        End If
        DB.AddParam("@teamId", Integer.Parse(teamid))
        DB.AddParam("@teamMateId", Integer.Parse(teamMateId))
        DB.ExecuteQuery("delete from team_assignment where team_id=? and participant_id=?")


        TeamMateIdTextBox.Clear()
    End Sub

    Private Sub AddTeamMember(teamMemid As String, teamId As String)
        DB.AddParam("@teamMem", Integer.Parse(teamMemid))
        DB.AddParam("@teamId", Integer.Parse(teamId))
        DB.ExecuteQuery("insert into team_assignment(participant_id,team_id) values(?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        UAParNameTextBox.Clear()
    End Sub

    Private Sub MultiFuncDeleteStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiFuncDeleteStripMenuItem.Click
        If MultiFuncDeleteStripMenuItem.Text = MAKE_REMOVE_LIASON Then
            If liason = 1 Then
                DB.AddParam("@li", 0)
            Else
                DB.AddParam("@li", 1)
            End If
            DB.AddParam("@parId", TeamMateIdTextBox.Text)
            DB.ExecuteQuery("update participant set liaison=? where id= ?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            Else
                populateTeamMateGridView()

            End If
        End If
    End Sub

    Private Sub DeleteTeam()
        Dim warningmessage As String = "You are going to delete the selected team, It  could be a bad practice for you to delete a vital record such as a team from a business database. this delete function is for demonstration purpose only. Are you sure that you want to delete the selected team record?"

        If MessageBox.Show(warningmessage, "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbNo Then

            Exit Sub

        End If

        DB.AddParam("@teamID", TeamIdTextBox.Text)
        DB.ExecuteQuery("delete from team_assignment where team_id=?")

        DB.AddParam("@teamID", TeamIdTextBox.Text)
        DB.ExecuteQuery("delete from mentor_team where team_id=?")

        DB.AddParam("@teamID", TeamIdTextBox.Text)
        DB.ExecuteQuery("delete from team where id=?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If

        MessageBox.Show("The record has been succesfully deleted from the database!", "Delete Succesful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        TeamIdTextBox.Clear()
        UAParNameTextBox.Clear()
        TeamMateIdTextBox.Clear()
        LoadTables()



    End Sub



    Private Sub NewTeamButton_Click(sender As Object, e As EventArgs) Handles NewTeamButton.Click
        NewTeamForm.ShowDialog()
    End Sub


End Class