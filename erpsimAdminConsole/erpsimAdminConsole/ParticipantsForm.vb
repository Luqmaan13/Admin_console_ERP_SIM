Public Class ParticipantsForm
    Private DB As New DBAccess
    Private status As Integer
    'Method to load participants
    Private Sub LoadParticipants()
        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select * from participant join participation on participant.id=participation.participant_id where participation.event_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        ParticipantDataGridView.DataSource = DB.DBDataTable
    End Sub

    'Method to run when form is activated
    Private Sub ParticipantsForm_Load(sender As Object, e As EventArgs) Handles Me.Activated, Me.Load

        LoadParticipants()
        toggleMenuSteupStatus(False)

    End Sub



    'Method to handle grid view cell click
    Private Sub ParticipantDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ParticipantDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            IdTextBox.Clear()

            Exit Sub
        End If

        IdTextBox.Text = ParticipantDataGridView.Item(0, e.RowIndex).Value
        status = ParticipantDataGridView.Item(11, e.RowIndex).Value
        toggleMenuSteupStatus(True)
    End Sub

    Private Sub toggleMenuSteupStatus(b As Boolean)
        EditToolStripMenuItem.Enabled = b
        ToggleParticipantStatusToolStripMenuItem.Enabled = b
    End Sub

    'Method to handle cell double click
    Private Sub ParticipantDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ParticipantDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or e.RowIndex = ParticipantDataGridView.RowCount - 1 Then
            IdTextBox.Clear()

            Exit Sub
        End If

        IdTextBox.Text = ParticipantDataGridView.Item(0, e.RowIndex).Value
        UpdateParticipantForm.ShowDialog()
    End Sub

    'Method to handle editing tool strip click
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If IdTextBox.Text <> "" Then
            UpdateParticipantForm.ShowDialog()
        Else
            MessageBox.Show("Please select participant to edit")
        End If
    End Sub

    'Method to handle keying up of name text box
    Private Sub NameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles NameTextBox.KeyUp
        IdTextBox.Clear()
        toggleMenuSteupStatus(False)
        populatelateGridViewWithSearch(NameTextBox.Text)
    End Sub

    'Method to search grid with first name
    Private Sub populatelateGridViewWithSearch(name As String)
        DB.AddParam("@eventid", AdminHomeForm.EventIdTextBox.Text)
        DB.AddParam("@name", name & "%")
        DB.ExecuteQuery("select * from participant join participation on participant.id=participation.participant_id where participation.event_id=?
and participant.first_name like ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        ParticipantDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub ToggleParticipantStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleParticipantStatusToolStripMenuItem.Click
        Dim warningmessage As String = "You are going to change the status of the selected participant, Do you wisht to continue?"

        If MessageBox.Show(warningmessage, "Toggle Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbNo Then

            Exit Sub

        End If
        If status = 1 Then
            DB.AddParam("@status", 0)
        Else
            DB.AddParam("@status", 1)
        End If
        DB.AddParam("@parId", IdTextBox.Text)
        DB.ExecuteQuery("update participant set status=? where id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Status successfully toggled")
        IdTextBox.Clear()
    End Sub
End Class