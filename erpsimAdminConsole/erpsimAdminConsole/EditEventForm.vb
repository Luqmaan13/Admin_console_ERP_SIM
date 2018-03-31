Public Class EditEventForm
    Private DB As New DBAccess
    Private Const SPRING As String = "Spring"
    Private Const SUMMER As String = "Fall"
    Private Const FALL As String = "Summer"
    Private Const NOT_CORRECT_INPUT As String = "Not correct input"
    Private Const CORRECT_INPUT As String = "correct"
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub PopulateTextBoxes()
        Dim semester As String
        DB.AddParam("id", EventForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select * from event where id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        EventIdTextBox.Text = DB.DBDataTable(0)!id
        GameNameTextBox.Text = DB.DBDataTable(0)!name
        GameDescriptionRichTextBox.Text = DB.DBDataTable(0)!description
        GameDateTimePicker.Value = DB.DBDataTable(0)!date
        semester = DB.DBDataTable(0)!semester

        If semester = SPRING Then
            SemesterComboBox.SelectedIndex = 0
        ElseIf semester = SUMMER Then
            SemesterComboBox.SelectedIndex = 2
        ElseIf semester = FALL Then
            SemesterComboBox.SelectedIndex = 1
        End If


    End Sub

    Private Sub EditEventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFieldsEditable(False)
        PopulateTextBoxes()
    End Sub

    Private Sub SetFieldsEditable(b As Boolean)
        GameDateTimePicker.Enabled = b
        GameNameTextBox.Enabled = b
        GameDescriptionRichTextBox.Enabled = b
        SemesterComboBox.Enabled = b
    End Sub

    Private Function validateInput()
        If String.IsNullOrWhiteSpace(GameNameTextBox.Text) Then
            Return NOT_CORRECT_INPUT
        ElseIf String.IsNullOrWhiteSpace(GameDescriptionRichTextBox.Text) Then
            Return NOT_CORRECT_INPUT
        Else
            Return CORRECT_INPUT
        End If
    End Function

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim val As String
        If EditSaveButton.Text = "&Edit" Then
            SetFieldsEditable(True)
            EditSaveButton.Text = "&Save"
        Else
            SetFieldsEditable(False)
            EditSaveButton.Text = "&Edit"



            val = validateInput()
            If val <> CORRECT_INPUT Then
                MessageBox.Show(val)
                Exit Sub
            End If

            DB.AddParam("name", GameNameTextBox.Text)
            DB.AddParam("descrip", GameDescriptionRichTextBox.Text)
            DB.AddParam("date", GameDateTimePicker.Value)
            DB.AddParam("sem", SemesterComboBox.Text)
            DB.AddParam("id", EventIdTextBox.Text)
            DB.ExecuteQuery("update event set name=?, description=?,date=?,semester=? where id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            Else
                MessageBox.Show("Successfully updated")
                Me.Close()
            End If

        End If
    End Sub
End Class