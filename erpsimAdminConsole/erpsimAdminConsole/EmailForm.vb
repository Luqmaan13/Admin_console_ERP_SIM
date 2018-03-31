
Public Class EmailForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.   
        Me.Text = "tutorialspoint.com"
    End Sub



    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        'Try
        '    Dim oXL As Excel.Application
        '    Dim oWB As Excel.Workbook
        '    Dim oSheet As Excel.Worksheet
        '    Dim oRng As Excel.Range


        '    'On Error GoTo Err_Handler

        '    ' Start Excel and get Application object.
        '    oXL = CreateObject("Excel.Application")
        '    oXL.Visible = True

        '    ' Get a new workbook.
        '    oWB = oXL.Workbooks.Add
        '    oSheet = oWB.ActiveSheet
        '    Dim iRow As Integer = 1
        '    For iRow = 1 To 10
        '        oSheet.Cells(iRow, 1).Value = "Test" & iRow
        '    Next iRow

        '    '//Create an Array and then add these entries to an excel spreadsheet
        '    Dim a(10) As String
        '    For iRow = 1 To 10
        '        a(iRow) = "Array Entry" & iRow.ToString
        '    Next

        '    '//Add to sheet
        '    For iRow = 1 To 10
        '        oSheet.Cells(iRow, 2).Value = a(iRow)
        '    Next iRow

        '    '//Add from a textbox Control
        '    oSheet.Cells(1, 2).Value = TextBox1.Text

        '    ' Make sure Excel is visible and give the user control
        '    ' of Microsoft Excel's lifetime.
        '    oXL.Visible = True
        '    oXL.UserControl = True

        '    ' Make sure you release object references.
        '    oRng = Nothing
        '    oSheet = Nothing
        '    oWB = Nothing
        '    oXL = Nothing
        'Catch ex As Exception
        '    MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)

        'End Try
    End Sub
End Class