Public Class UpdateParticipantForm
    Private DB As New DBAccess
    'Populating text box method
    Private Sub UpdateParticipantForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim class_standing As String
        DB.AddParam("@partId", ParticipantsForm.IdTextBox.Text)
        DB.ExecuteQuery("select * from participant where id=?")
        IdTextBox.Text = DB.DBDataTable(0)!id
        FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
        LastNameTextBox.Text = DB.DBDataTable(0)!last_name
        EmailTextBox.Text = DB.DBDataTable(0)!cmu_email
        MajorTextBox.Text = DB.DBDataTable(0)!major_program
        MinorTextBox.Text = DB.DBDataTable(0)!minor
        ClubTextBox.Text = DB.DBDataTable(0)!club
        class_standing = DB.DBDataTable(0)!class_standing

        If class_standing = "Graduate" Then
            ClassStandingComboBox.SelectedIndex = 0
        ElseIf class_standing = "Freshman" Then
            ClassStandingComboBox.SelectedIndex = 1
        ElseIf class_standing = "Sophomore" Then
            ClassStandingComboBox.SelectedIndex = 2
        ElseIf class_standing = "Junior" Then
            ClassStandingComboBox.SelectedIndex = 3
        ElseIf class_standing = "Senior" Then
            ClassStandingComboBox.SelectedIndex = 4
        End If



    End Sub

    'Method to handle cancel button
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    'Method to toggle textbox enabled property
    Private Sub SetFieldsEditable(b As Boolean)
        FirstNameTextBox.Enabled = b
        LastNameTextBox.Enabled = b
        EmailTextBox.Enabled = b
        MajorTextBox.Enabled = b
        MinorTextBox.Enabled = b
        ClubTextBox.Enabled = b
        ClassStandingComboBox.Enabled = b
    End Sub

    'Method to validate input
    Private Function validateInput() As String
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            Return "Please enter correct first name"
        ElseIf String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            Return "Please enter correct last name"
        ElseIf String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            Return "Please enter correct email"
        ElseIf String.IsNullOrWhiteSpace(MajorTextBox.Text) Then
            Return "Please enter correct major"
        ElseIf String.IsNullOrWhiteSpace(MinorTextBox.Text) Then
            Return "Please enter correct minor"
        ElseIf String.IsNullOrWhiteSpace(ClubTextBox.Text) Then
            Return "Please enter correct club"
        Else
            Return "All Correct"
        End If

    End Function

    'Method to handle edit/save button
    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim val As String
        If EditSaveButton.Text = "&Edit" Then
            SetFieldsEditable(True)
            EditSaveButton.Text = "&Save"
        Else
            SetFieldsEditable(False)
            EditSaveButton.Text = "&Edit"



            val = validateInput()
            If val <> "All Correct" Then
                MessageBox.Show(val)
                Exit Sub
            End If

            DB.AddParam("@firestname", FirstNameTextBox.Text)
            DB.AddParam("@lastname", LastNameTextBox.Text)
            DB.AddParam("@email", EmailTextBox.Text)
            DB.AddParam("@major", MajorTextBox.Text)
            DB.AddParam("@minor", MinorTextBox.Text)
            DB.AddParam("@club", ClubTextBox.Text)
            DB.AddParam("@class_standing", ClassStandingComboBox.Text)
            DB.AddParam("id", IdTextBox.Text)


            DB.ExecuteQuery("update participant set first_name= ?, last_name=?,cmu_email=?,major_program=?,minor=?,club=?,class_standing=? where id=?")

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