Public Class CompanyForm
    Private DB As New DBAccess

    Private Sub loadCompanies()
        DB.ExecuteQuery("select * from company")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        CompanyDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub CompanyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        loadCompanies()
        EditToolStripMenuItem.Enabled = False
        EditToolStripMenuItem.Visible = False
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewCompanyForm.ShowDialog()
    End Sub

    Private Sub CompanyDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompanyDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            CompanyIdTextBox.Clear()

            Exit Sub
        End If
        CompanyIdTextBox.Text = CompanyDataGridView.Item(0, e.RowIndex).Value
        EditToolStripMenuItem.Visible = True
        EditToolStripMenuItem.Enabled = True


    End Sub

    Private Sub searchByCompanyName(name As String)
        DB.AddParam("@cname", name & "%")
        DB.ExecuteQuery("select * from company where name like ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        CompanyDataGridView.DataSource = DB.DBDataTable
    End Sub


    Private Sub CompanyNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles CompanyNameTextBox.KeyUp
        searchByCompanyName(CompanyNameTextBox.Text)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditCompanyForm.ShowDialog()
    End Sub
End Class