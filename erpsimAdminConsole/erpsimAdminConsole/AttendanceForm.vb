Imports System.ComponentModel

Public Class AttendanceForm
    Private DB As New DBAccess
    Public practiceId As Integer
    Public PracticeDate As Date
    Private Sub populatePart()
        DB.AddParam("@eventId", AdminHomeForm.EventIdTextBox.Text)
        DB.AddParam("@pid", practiceId)
        DB.ExecuteQuery("select * from participant join participation on
 participant.id=participation.participant_id 
where event_id=? and not exists(select participant.id from 
participant join attendance on participant.id= attendance.participant_id where practice_id=?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        ParticipantDataGridView.DataSource = DB.DBDataTable
    End Sub



    Private Function GetPraceticeDetails() As String
        Dim count As Integer

        DB.ExecuteQuery("select count(*) as count1  from practice where date= current_date()")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Function
        End If
        count = DB.DBDataTable(0)!count1
        If count = 0 Then
            Return "No Practice Session Today"
        Else
            DB.ExecuteQuery("select *  from practice where date= current_date()")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Function
            End If
            practiceId = DB.DBDataTable(0)!id
            PracticeDate = DB.DBDataTable(0)!date

        End If
        Return PracticeDate.ToString
    End Function

    Private Sub mulfuDisable()
        MultiFunctionalToolStripMenuItem.Enabled = False
        MultiFunctionalToolStripMenuItem.Visible = False
    End Sub

    Private Sub loadPresent()
        DB.ExecuteQuery("select * from participant join attendance on participant.id	= attendance.participant_id
join practice on attendance.practice_id=practice.id where practice.date = current_date()")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        PresentDataGridView.DataSource = DB.DBDataTable

    End Sub

    Private Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated

        PracticeDateLabel.Text = GetPraceticeDetails()
        populatePart()
        mulfuDisable()
        loadPresent()
    End Sub

    Private Sub ParticipantDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ParticipantDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            ParticipantIdTextBox.Clear()

            Exit Sub
        End If

        ParticipantIdTextBox.Text = ParticipantDataGridView.Item(0, e.RowIndex).Value
        MultiFunctionalToolStripMenuItem.Visible = True
        MultiFunctionalToolStripMenuItem.Enabled = True
        MultiFunctionalToolStripMenuItem.Text = "Mark Present"

    End Sub

    Private Sub MarkParticipantPresent()
        DB.AddParam("@practiceid", practiceId)
        DB.AddParam("@partId", ParticipantIdTextBox.Text)
        DB.ExecuteQuery("insert into attendance(practice_id,participant_id) values(?,?)")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub MarkParticipantAbsent()
        DB.AddParam("@practiceid", practiceId)
        DB.AddParam("@partId", ParticipantIdTextBox.Text)
        DB.ExecuteQuery("delete from attendance where practice_id=? and participant_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    Private Sub MultiFunctionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiFunctionalToolStripMenuItem.Click
        If MultiFunctionalToolStripMenuItem.Text = "Mark Present" Then
            MarkParticipantPresent()
            ParticipantIdTextBox.Clear()
            mulfuDisable()
            populatePart()
            loadPresent()
        ElseIf MultiFunctionalToolStripMenuItem.Text = "Mark Absent" Then
            MarkParticipantAbsent()
            ParticipantIdTextBox.Clear()
            mulfuDisable()
            populatePart()
            loadPresent()
        End If
    End Sub

    Private Sub PresentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresentDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            ParticipantIdTextBox.Clear()

            Exit Sub

        End If

        ParticipantIdTextBox.Text = PresentDataGridView.Item(0, e.RowIndex).Value
        MultiFunctionalToolStripMenuItem.Visible = True
        MultiFunctionalToolStripMenuItem.Enabled = True
        MultiFunctionalToolStripMenuItem.Text = "Mark Absent"
    End Sub

    'Private Sub AttendanceForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    ParticipantDataGridView.Rows.Clear()
    '    ParticipantDataGridView.Columns.Clear()
    '    PresentDataGridView.Rows.Clear()
    '    PresentDataGridView.Columns.Clear()
    '    ParticipantIdTextBox.Text = ""

    'End Sub


End Class