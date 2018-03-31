Public Class NewPracticeForm
    Private DB As New DBAccess
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim practiceStatus As Integer = 1
        If String.IsNullOrWhiteSpace(RoomsTextBox.Text) Then
            MessageBox.Show("Please enter room number")
            Exit Sub
        End If

        DB.AddParam("@date", PracticeDateTimePicker.Value)
        DB.AddParam("@stTime", StartTimeDateTimePicker.Value)
        DB.AddParam("@rooms", RoomsTextBox.Text)
        DB.AddParam("@status", practiceStatus)
        DB.AddParam("@eventid", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("insert into practice(date,start_time,room,status,event_id) values (?,?,?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MessageBox.Show("Succesfully updated")
        Me.Close()
    End Sub



    Private Sub NewPracticeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PracticeDateTimePicker.MinDate = Date.Today



        '  StartTimeDateTimePicker.MinDate = DateAndTime.Now
    End Sub


End Class