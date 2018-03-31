Public Class EditMentorForm
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Function validateInputs() As String
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            Return "Please enter first name"
        ElseIf String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            Return "Please enter last name"
        ElseIf String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            Return "Please enter email"
        ElseIf String.IsNullOrWhiteSpace(PhoneTextBox.Text) Then
            Return "Please enter phone number"
        ElseIf CompanyComboBox.SelectedIndex = -1 Then
            Return "please select company"
        Else
            Return "All Correct"
        End If
    End Function

    Private Sub SetFieldsEditable(b As Boolean)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim s As String
        Dim id As Integer

        If EditSaveButton.Text = "&Edit" Then
            SetFieldsEditable(True)
            EditSaveButton.Text = "&Save"
        Else
            SetFieldsEditable(False)
            EditSaveButton.Text = "&Edit"



        End If
    End Sub
End Class