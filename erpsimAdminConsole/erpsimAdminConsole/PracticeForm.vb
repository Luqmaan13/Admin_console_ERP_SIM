Public Class PracticeForm
    Private DB As New DBAccess
    Private status As Integer
    Private Sub PracticeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        DB.AddParam("id", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select * from practice where event_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        PracticeDataGridView.DataSource = DB.DBDataTable
        toggleMenuStripStatus(False)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewPracticeForm.ShowDialog()
    End Sub

    Private Sub toggleMenuStripStatus(b As Boolean)
        EditToolStripMenuItem.Enabled = b
        TogglePracticeStatusToolStripMenuItem.Enabled = b
    End Sub


    Private Sub PracticeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PracticeDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            PracticeIdTextBox.Clear()

            Exit Sub
        End If
        PracticeIdTextBox.Text = PracticeDataGridView.Item(0, e.RowIndex).Value
        status = PracticeDataGridView.Item(5, e.RowIndex).Value

        toggleMenuStripStatus(True)

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditPracticeForm.ShowDialog()
    End Sub

    Private Sub TogglePracticeStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TogglePracticeStatusToolStripMenuItem.Click
        Dim warningmessage As String = "You are going to change the status of the selected practice session, Do you wisht to continue?"

        If MessageBox.Show(warningmessage, "Toggle Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbNo Then

            Exit Sub

        End If
        If status = 1 Then
            DB.AddParam("@status", 0)
        Else
            DB.AddParam("@status", 1)
        End If
        DB.AddParam("@pracId", PracticeIdTextBox.Text)
        DB.ExecuteQuery("update practice set status=? where id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MessageBox.Show("Status successfully toggled")
        PracticeIdTextBox.Clear()
    End Sub
End Class