'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 09/20/2021
'Description: Chapter 6 [FINAL]
'             *This is the secondary Form for my program. This program will accept up to 10 maze completion
'              times from the user, validate the usability of the input, and then calculate an average if possible.

'              **This Form contains all the data input components to the program, as well as handles the necessary
'                calculations to determine the average input time. It does this by first validating that the input 
'                is numeric, positive, not blank, with no more than 10 entries with lengths less than 9.
'                Once validated, the input is placed within an array, then formatted and placed in the listbox object.
'                The array is then averaged, and that number is formatted and placed in the textbox object.

'                ***I also added functions to clear the previous data on input of new data, without having to
'                   hit the clear button in the File menu. If data exists and the input box is reinitiated, 
'                   but the new data is either nonexistant, invalid, or cancelled; the program will NOT clear 
'                   the previous data. If the new data is valid and usable, all previous data will be wiped.

Public Class frmTimeEntry
    Dim intCount As Integer
    Dim decTemp As Decimal
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Complete form check'
        If txtInputBox.TextLength = 0 Then
            MessageBox.Show("Input Required.", "Incomplete Form",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Max input check'
        If txtInputBox.Lines.Length > 10 Then
            MessageBox.Show("Maximum Input Is 10.", "Invalid Form",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Initialize array to number of lines -1'
        Dim decMazeTimes(txtInputBox.Lines.Length - 1) As Decimal

        'Check if input is numeric, positive, and < 9'  
        'If all are true, assign array with input, else display error'
        For intCount = 0 To txtInputBox.Lines.Length - 1
            If IsNumeric(txtInputBox.Lines(intCount)) Then
                If txtInputBox.Lines(intCount) > 0 Then
                    If txtInputBox.Lines(intCount).Length < 9 Then
                        decMazeTimes(intCount) = txtInputBox.Lines(intCount)
                    Else
                        MessageBox.Show("Input Length Less Than (9) Required.", "Invalid Form",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Positive Input Required.", "Invalid Form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Numeric Input Required.", "Invalid Form",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next

        'Check button counter, if > 0, clear list and average boxes and button count +1 | Else only button count +1'
        If frmDixonMaze.intButtonCounter > 0 Then
            frmDixonMaze.intButtonCounter += 1
            frmDixonMaze.lstAverages.Items.Clear()
            frmDixonMaze.txtAverageTime.ResetText()
        Else
            frmDixonMaze.intButtonCounter += 1
        End If

        'Loop through input array, format and assign each to list (List formatting completed for sake of appearances.)'
        For intCount = 0 To txtInputBox.Lines.Length - 1
            decTemp = Format(decMazeTimes(intCount), "0.0")
            frmDixonMaze.lstAverages.Items.Add(decTemp)
        Next

        'Initialize temp as formatted average of input array | Set average textbox to formatted average'
        decTemp = Format(decMazeTimes.Average, "0.0")
        frmDixonMaze.txtAverageTime.Text = decTemp

        'Reset all input and close input box.
        txtInputBox.ResetText()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Complete form check and max input check or close input box'
        If txtInputBox.TextLength > 0 Then
            If txtInputBox.Lines.Length > 10 Then
                txtInputBox.ResetText()
                Close()
                Exit Sub
            End If

            'Initialize array to number of lines -1'
            Dim decMazeTimes(txtInputBox.Lines.Length - 1) As Decimal

            'Check if input is numeric, positive, and < 9'  
            'If all are true, assign array with input, else close input box'
            For intCount = 0 To txtInputBox.Lines.Length - 1
                If IsNumeric(txtInputBox.Lines(intCount)) Then
                    If txtInputBox.Lines(intCount) >= 0 Then
                        If txtInputBox.Lines(intCount).Length < 9 Then
                            decMazeTimes(intCount) = txtInputBox.Lines(intCount)
                        Else
                            txtInputBox.ResetText()
                            Close()
                            Exit Sub
                        End If
                    Else
                        txtInputBox.ResetText()
                        Close()
                        Exit Sub
                    End If
                Else
                    txtInputBox.ResetText()
                    Close()
                    Exit Sub
                End If
            Next

            'Check button counter, if > 0, clear list and average boxes and button count +1 | Else only button count +1'
            If frmDixonMaze.intButtonCounter > 0 Then
                frmDixonMaze.intButtonCounter += 1
                frmDixonMaze.lstAverages.Items.Clear()
                frmDixonMaze.txtAverageTime.ResetText()
            Else
                frmDixonMaze.intButtonCounter += 1
            End If

            'Loop through input array, format and assign each to list (List formatting completed for sake of appearances.)'
            For intCount = 0 To txtInputBox.Lines.Length - 1
                decTemp = Format(decMazeTimes(intCount), "0.0")
                frmDixonMaze.lstAverages.Items.Add(decTemp)
            Next

            'Initialize temp as formatted average of input array | Set average textbox to formatted average'
            decTemp = Format(decMazeTimes.Average, "0.0")
            frmDixonMaze.txtAverageTime.Text = decTemp

            'Reset all input and close input box'
            txtInputBox.ResetText()
            Close()
        Else
            MessageBox.Show("No Input Detected.", "Invalid Form",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Close()
        End If
    End Sub
End Class
