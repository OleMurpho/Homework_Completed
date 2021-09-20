'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 09/20/2021
'Description: Chapter 6 [FINAL]
'             *This is the primary Form for my program. This program will accept up to 10 maze completion
'              times from the user, validate the usability of the input, and then calculate an average if possible.

'              **This Form contains all the primary components to the program, as well as calls the input form
'                to ShowDialog(). It also contains necessary functions to allow the user to clear or exit the program.

Public Class frmDixonMaze
    'Intialize new input form'
    Dim frmInputBox As New frmTimeEntry

    'Initialize public button counter, accessible by input form'
    Public intButtonCounter As Integer
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        'Center input form and show'
        frmInputBox.StartPosition = FormStartPosition.CenterParent
        frmInputBox.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Reset all boxes'
        lstAverages.Items.Clear()
        txtAverageTime.ResetText()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit'
        Close()
    End Sub
End Class
