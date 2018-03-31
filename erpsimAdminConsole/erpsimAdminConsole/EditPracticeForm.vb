Public Class EditPracticeForm
    Private DB As New DBAccess
    Private Sub EditPracticeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.AddParam("prid", PracticeForm.PracticeIdTextBox.Text)
        DB.ExecuteQuery("select * from practice where id =?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        PracticeIdTextBox.Text = DB.DBDataTable(0)!id
        PracticeDateTimePicker.Value = DB.DBDataTable(0)!date
        StartTimeDateTimePicker.Value = DateTime.Parse(DB.DBDataTable(0)!start_time.ToString)
        RoomsTextBox.Text = DB.DBDataTable(0)!room
        PracticeDateTimePicker.MinDate = Date.Today
        SetFieldsEditable(False)
    End Sub

    Private Sub SetFieldsEditable(b As Boolean)
        StartTimeDateTimePicker.Enabled = b
        PracticeDateTimePicker.Enabled = b
        RoomsTextBox.Enabled = b
    End Sub



    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click

        If EditSaveButton.Text = "&Edit" Then
            SetFieldsEditable(True)
            EditSaveButton.Text = "&Save"
        Else
            SetFieldsEditable(False)
            EditSaveButton.Text = "&Edit"

            'Save the information to the database
            'validation stuff


            If String.IsNullOrWhiteSpace(RoomsTextBox.Text) Then
                MessageBox.Show("Please enter valid inputs")
                Exit Sub
            End If

            DB.AddParam("@date", PracticeDateTimePicker.Value)
            DB.AddParam("@stTime", StartTimeDateTimePicker.Value)
            DB.AddParam("@rooms", RoomsTextBox.Text)
            DB.AddParam("id", PracticeIdTextBox.Text)
            DB.ExecuteQuery("update practice set date=?,start_time=?,room=? where id=?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            Else
                MessageBox.Show("Successfully updated")
            End If
            Me.Close()
        End If
    End Sub
End Class