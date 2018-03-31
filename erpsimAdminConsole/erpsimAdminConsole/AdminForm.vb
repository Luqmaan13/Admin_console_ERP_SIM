Public Class AdminHomeForm
    Private DB As New DBAccess
    Private status As Integer
    Private Sub AddDaysLeft()
        Dim eventDate As Date
        Dim numOfDays As TimeSpan
        ' DB.AddParam("@todaystoday", Date.Today)
        DB.ExecuteQuery("select * from event where date >= CURDATE() and status=1 order by date asc")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        Try
            eventDate = DB.DBDataTable(0)!date
            EventIdTextBox.Text = DB.DBDataTable(0)!id
            status = DB.DBDataTable(0)!status
            numOfDays = eventDate - Date.Today
            DaysLeftLabel.Text = numOfDays.TotalDays.ToString + " days left for the event"
            Exit Sub
        Catch ex As Exception

        End Try
        DaysLeftLabel.Text = "No future event"
        EnableDisableMenuStrip(False)
    End Sub





    Private Sub AddPracticeSessions()
        DB.AddParam("@eventId", EventIdTextBox.Text)
        DB.ExecuteQuery("select id,date,start_time,room from practice where date >= CURDATE() and status=1 and event_id =? order by date asc")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        PracticeDataGridView.DataSource = DB.DBDataTable

    End Sub

    Private Sub EnableDisableMenuStrip(b As Boolean)
        PracticeSessionsToolStripMenuItem.Enabled = b
        ParticipantsToolStripMenuItem.Enabled = b
        ManageTeamsToolStripMenuItem.Enabled = b
        MentorsToolStripMenuItem.Enabled = b
        CompaniesToolStripMenuItem.Enabled = b
        AttendanceToolStripMenuItem.Enabled = b
    End Sub


    Private Sub AdminHomeForm_Load(sender As Object, e As EventArgs) Handles Me.Load, Me.Activated
        PracticeIdTextBox.Visible = False
        EnableDisableMenuStrip(False)


        AddDaysLeft()
        If DaysLeftLabel.Text = "No future event" Then
            Exit Sub
        End If
        AddPracticeSessions()
        EnableDisableMenuStrip(True)
    End Sub

    Private Sub PracticeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PracticeDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or e.RowIndex = PracticeDataGridView.RowCount - 1 Then
            PracticeIdTextBox.Clear()

            Exit Sub

        End If

        PracticeIdTextBox.Text = PracticeDataGridView.Item(0, e.RowIndex).Value
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ParticipantsForm.ShowDialog()
    End Sub



    Private Sub ViewEditAllToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageTeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageTeamsToolStripMenuItem.Click
        ManageTeams.ShowDialog()
    End Sub

    Private Sub EventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventToolStripMenuItem.Click
        EventForm.ShowDialog()
    End Sub



    Private Sub PracticeSessionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PracticeSessionsToolStripMenuItem.Click
        PracticeForm.ShowDialog()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        AttendanceForm.ShowDialog()
    End Sub

    Private Sub ParticipantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParticipantsToolStripMenuItem.Click
        ParticipantsForm.ShowDialog()
    End Sub

    Private Sub CompaniesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompaniesToolStripMenuItem.Click
        CompanyForm.ShowDialog()
    End Sub

    Private Sub ManageTeamsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ManageTeamsToolStripMenuItem1.Click
        ManageMentorsForm.ShowDialog()
    End Sub

    Private Sub ViewEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEditToolStripMenuItem.Click
        MentorsForm.ShowDialog()
    End Sub

    Private Sub EmailListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailListToolStripMenuItem.Click
        EmailListForm.ShowDialog()
    End Sub
End Class
