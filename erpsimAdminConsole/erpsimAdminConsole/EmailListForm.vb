Public Class EmailListForm
    Private DB As New DBAccess
    Private Sub loadAllParticipantEmails()


        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select cmu_email from participant join participation on participant.id = participation.participant_id where participation.event_id=?")

        Dim allEmails As String = ""
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            allEmails = allEmails & ADataRow("cmu_email") & ", "
        Next
        If DB.Recordcount > 0 Then
            EmailListRichTextBox.Text = allEmails


        End If


    End Sub


    Private Sub loadAllLiasons()


        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select cmu_email from participant join participation on participant.id = participation.participant_id where participation.event_id=? and participant.liaison=1 ")

        Dim allEmails As String = ""
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            allEmails = allEmails & ADataRow("cmu_email") & ", "
        Next

        allEmails = RTrim(allEmails)
        allEmails = allEmails.Substring(0, allEmails.Length - 1)

        If DB.Recordcount > 0 Then
            EmailListRichTextBox.Text = allEmails


        End If


    End Sub


    Private Sub loadAllMentors()


        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select email from mentor join mentor_team on mentor.id=mentor_team.mentor_id 
join team on mentor_team.team_id=team.id where team.event_id=? ")

        Dim allEmails As String = ""
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            allEmails = allEmails & ADataRow("email") & ", "
        Next
        allEmails = RTrim(allEmails)
        allEmails = allEmails.Substring(0, allEmails.Length - 1)
        If DB.Recordcount > 0 Then
            EmailListRichTextBox.Text = allEmails


        End If


    End Sub

    Private Sub loadAll()
        Dim allEmails As String = ""
        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select email from mentor join mentor_team on mentor.id=mentor_team.mentor_id 
join team on mentor_team.team_id=team.id where team.event_id=? ")


        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            allEmails = allEmails & ADataRow("email") & ", "
        Next

        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.ExecuteQuery("select cmu_email from participant join participation on participant.id = participation.participant_id where participation.event_id=?")

        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            allEmails = allEmails & ADataRow("cmu_email") & ", "

        Next
        allEmails = RTrim(allEmails)
        allEmails = allEmails.Substring(0, allEmails.Length - 1)
        If DB.Recordcount > 0 Then
            EmailListRichTextBox.Text = allEmails


        End If

    End Sub



    Private Sub EmailListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmailListComboBox.SelectedIndexChanged
        If EmailListComboBox.SelectedIndex = 0 Then
            loadAllParticipantEmails()
        ElseIf EmailListComboBox.SelectedIndex = 1 Then
            loadAllLiasons()
        ElseIf EmailListComboBox.SelectedIndex = 2 Then
            loadAllMentors()
        ElseIf EmailListComboBox.SelectedIndex = 3 Then
            loadAll()
        End If

    End Sub

    Private Sub EmailListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmailListComboBox.SelectedIndex = -1
        EmailListRichTextBox.Clear()
    End Sub
End Class