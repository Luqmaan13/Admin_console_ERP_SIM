Public Class MentorsForm
    Private DB As New DBAccess

    Private Sub LoadMentors()
        DB.ExecuteQuery("select * from mentor")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MentorsDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub enableDisableToolStrip(b As Boolean)
        EditToolStripMenuItem.Enabled = b
        EditToolStripMenuItem.Visible = b
    End Sub

    Private Sub MentorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        MentorIdTextBox.Clear()
        enableDisableToolStrip(False)
        LoadMentors()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewMentorForm.ShowDialog()
    End Sub

    Private Sub MentorsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MentorsDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            MentorIdTextBox.Clear()
            enableDisableToolStrip(False)
            Exit Sub
        End If
        enableDisableToolStrip(True)
        MentorIdTextBox.Text = MentorsDataGridView.Item(0, e.RowIndex).Value

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditMentorsForm.ShowDialog()
    End Sub
End Class