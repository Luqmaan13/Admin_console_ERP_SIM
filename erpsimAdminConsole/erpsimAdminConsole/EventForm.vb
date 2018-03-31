Public Class EventForm
    Private DB As New DBAccess
    Private status As Integer
    Private Sub populateEvents()
        DB.ExecuteQuery("select id,name,date,status from event order by date desc")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        EventsDataGridView.DataSource = DB.DBDataTable
    End Sub



    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        populateEvents()
        EditToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewEventForm.ShowDialog()
    End Sub

    Private Sub EventsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventsDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Or e.RowIndex = EventsDataGridView.RowCount - 1 Then
            EventIdTextBox.Clear()

            Exit Sub
        End If
        EventIdTextBox.Text = EventsDataGridView.Item(0, e.RowIndex).Value
        status = EventsDataGridView.Item(3, e.RowIndex).Value
        EditToolStripMenuItem.Enabled = True
        DeleteToolStripMenuItem.Enabled = True

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditEventForm.ShowDialog()
    End Sub



    Private Sub deleteEvent()
        Dim warningmessage As String = "You are going to change the status of the selected event, Do you wisht to continue?"

        If MessageBox.Show(warningmessage, "Toggle Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbNo Then

            Exit Sub

        End If

        If status = 1 Then
            DB.AddParam("@status", 0)
        Else
            DB.AddParam("@status", 1)
        End If
        DB.AddParam("@id", EventIdTextBox.Text)
        DB.ExecuteQuery("update event set status = ? where id=?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Status successfully toggled")
        EventIdTextBox.Clear()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        deleteEvent()
    End Sub
End Class