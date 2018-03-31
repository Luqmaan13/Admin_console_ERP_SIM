Public Class NewEventForm
    Private DB As New DBAccess
    Private Const NOT_CORRECT_INPUT As String = "Not correct input"
    Private Const CORRECT_INPUT As String = "correct"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Function validateInput() As String
        If String.IsNullOrWhiteSpace(GameNameTextBox.Text) Then
            Return NOT_CORRECT_INPUT
        ElseIf String.IsNullOrWhiteSpace(GameDescriptionRichTextBox.Text) Then
            Return NOT_CORRECT_INPUT
        Else
            Return CORRECT_INPUT
        End If
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim s As String
        s = validateInput()
        If s <> CORRECT_INPUT Then
            MessageBox.Show("please fill the textboxes")
            Exit Sub
        End If
        DB.AddParam("name", GameNameTextBox.Text)
        DB.AddParam("description", GameDescriptionRichTextBox.Text)
        DB.AddParam("date", GameDateTimePicker.Value)
        DB.AddParam("sem", SemesterComboBox.Text)

        DB.ExecuteQuery("insert into event(name,description,date,semester) values(?,?,?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub NewEventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameDateTimePicker.MinDate = Date.Now
    End Sub
End Class