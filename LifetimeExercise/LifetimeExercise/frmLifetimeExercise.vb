'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 08/30/2021
'Description: [FINAL]
'             *This program will accept input for the user's name, as well as
'              a birth date and a current date. It will then calculate the estimated
'              hours exercised assuming an individual exercised 3 hours a week or 0.428571 hours
'              per day. It will display this value along with a sentence describing it at the bottom.
'              A reset button and exit button are present to allow user repetition control.*  

'              **Calculations accomplished by utilizing a series of nested For loops to move through 
'                the years, months and days. Within and containing these For loops are a series of If loops 
'                to handle particular situations regarding date mechanics. (Birth Year = Current Year, etc.)

'                ***Though unnecessary to the assignment parameters, I went ahead and caught various potential 
'                   errors from user input as well. These include non-integer input in the date boxes, out of range 
'                   integers in date boxes, incomplete form boxes, and negative dates.***

Public Class frmLifetimeExercise
    Const _cdecHoursPerDay As Decimal = 0.428571
    Dim intMonthDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
    Dim decHoursExercised As Decimal
    Dim strNameInput As String
    Dim intBirthMonth, intBirthDate, intBirthYear As Integer
    Dim intCurrentMonth, intCurrentDate, intCurrentYear As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If txtName.TextLength = 0 Or txtBirthDD.TextLength = 0 Or txtBirthMM.TextLength = 0 Or txtBirthYYYY.TextLength = 0 Or txtCurrentDD.TextLength = 0 Or txtCurrentMM.TextLength = 0 Or txtCurrentYYYY.TextLength = 0 Then
            MessageBox.Show("All Entries Are Required.", "Incomplete Form",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Name Instantiation'
        strNameInput = txtName.Text

        'Birth Year Instantiation'
        If IsNumeric(txtBirthYYYY.Text) Then
            intBirthYear = txtBirthYYYY.Text
        Else
            MessageBox.Show("Integers Only.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Birth Month Instantiation'
        If IsNumeric(txtBirthMM.Text) Then
            If txtBirthMM.Text <= 12 AndAlso txtBirthMM.Text > 0 Then
                intBirthMonth = txtBirthMM.Text
            Else
                MessageBox.Show("Integers (1-12) Only.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Integers (1-12) Only.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Birth Date Instantiation'
        If IsNumeric(txtBirthDD.Text) Then
            If txtBirthDD.Text <= intMonthDays(intBirthMonth - 1) AndAlso txtBirthDD.Text > 0 Then
                intBirthDate = txtBirthDD.Text
            Else
                MessageBox.Show("Date Entered Is Invalid", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Integers (1-" & intMonthDays(intBirthMonth - 1) & ") Only.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Year Instantiation'
        If IsNumeric(txtCurrentYYYY.Text) Then
            If txtCurrentYYYY.Text >= intBirthYear Then
                intCurrentYear = txtCurrentYYYY.Text
            Else
                MessageBox.Show("Current Date Must Be After Birth Date.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Integers Only.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Month Instantiation'
        If IsNumeric(txtCurrentMM.Text) Then
            If intCurrentYear = intBirthYear Then
                If txtCurrentMM.Text >= intBirthMonth Then
                    intCurrentMonth = txtCurrentMM.Text
                Else
                    MessageBox.Show("Current Date Must Be After Birth Date.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            ElseIf intCurrentYear > intBirthYear Then
                If txtCurrentMM.Text <= 12 AndAlso txtCurrentMM.Text > 0 Then
                    intCurrentMonth = txtCurrentMM.Text
                Else
                    MessageBox.Show("Integers (1-12) Only.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
        Else
            MessageBox.Show("Integers (1-12) Only.", "Invalid Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Date Instantiation'
        If IsNumeric(txtCurrentDD.Text) Then
            If intCurrentYear = intBirthYear Then
                If intCurrentMonth = intBirthMonth Then
                    If txtCurrentDD.Text >= intBirthDate AndAlso txtCurrentDD.Text < intMonthDays(intCurrentMonth - 1) Then
                        intCurrentDate = txtCurrentDD.Text
                    Else
                        MessageBox.Show("Current Date Must Be After Birth Date.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Else
                    If txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) AndAlso txtCurrentDD.Text > 0 Then
                        intCurrentDate = txtCurrentDD.Text
                    Else
                        MessageBox.Show("Integers (1-" & intMonthDays(intCurrentMonth - 1) & ") Only.", "Invalid Entry",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
            Else
                If txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) AndAlso txtCurrentDD.Text > 0 Then
                    intCurrentDate = txtCurrentDD.Text
                Else
                    MessageBox.Show("Integers (1-" & intMonthDays(intCurrentMonth - 1) & ") Only.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
        Else
            MessageBox.Show("Integers Only.", "Invalid Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Calculate Hours Exercised'
        For year As Integer = intBirthYear To intCurrentYear
            If year = intBirthYear Then
                If intBirthYear = intCurrentYear Then
                    For month As Integer = intBirthMonth To intCurrentMonth
                        If month = intBirthMonth Then
                            For day As Integer = intBirthDate To intCurrentDate
                                decHoursExercised += _cdecHoursPerDay
                                If day = intCurrentDate - 1 Then
                                    Exit For
                                End If
                            Next
                        Else
                            For day As Integer = 1 To intMonthDays(month - 1)
                                decHoursExercised += _cdecHoursPerDay
                                If day = intMonthDays(month - 1) - 1 Then
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                Else
                    For month As Integer = intBirthMonth To 12
                        If month = intBirthMonth Then
                            For day As Integer = intBirthDate To intMonthDays(month - 1)
                                decHoursExercised += _cdecHoursPerDay
                                If day = intMonthDays(month - 1) - 1 Then
                                    Exit For
                                End If
                            Next
                        Else
                            For day As Integer = 1 To intMonthDays(month - 1)
                                decHoursExercised += _cdecHoursPerDay
                                If day = intMonthDays(month - 1) Then
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            ElseIf year < intCurrentYear AndAlso year > intBirthYear Then
                For month As Integer = 1 To 12
                    If year Mod 4 = 0 AndAlso month = 2 Then
                        decHoursExercised += _cdecHoursPerDay
                    End If
                    For day As Integer = 1 To intMonthDays(month - 1)
                        decHoursExercised += _cdecHoursPerDay
                        If day = intMonthDays(month - 1) Then
                            Exit For
                        End If
                    Next
                Next
            ElseIf year = intCurrentYear AndAlso intCurrentYear > intBirthYear Then
                For month As Integer = 1 To intBirthMonth
                    If month < intBirthMonth Then
                        For day As Integer = 1 To intMonthDays(month - 1)
                            decHoursExercised += _cdecHoursPerDay
                            If day = intMonthDays(month - 1) Then
                                Exit For
                            End If
                        Next
                    ElseIf month = intBirthMonth Then
                        For day As Integer = 1 To intBirthDate
                            decHoursExercised += _cdecHoursPerDay
                            If day = intBirthDate Then
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If
        Next
        Dim temp As Decimal = Format(decHoursExercised, "0.00")
        lblDetails.Text = txtName.Text & " has exercised for an estimated total of " &
                          temp & " hours in his/her lifetime."
        lblDetails.Visible = True
        decHoursExercised = 0
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        decHoursExercised = 0
        intCurrentMonth = 0
        intCurrentDate = 0
        intCurrentYear = 0
        intBirthMonth = 0
        intBirthDate = 0
        intBirthYear = 0
        txtName.Text = ""
        txtBirthDD.Text = ""
        txtBirthMM.Text = ""
        txtBirthYYYY.Text = ""
        txtCurrentDD.Text = ""
        txtCurrentMM.Text = ""
        txtCurrentYYYY.Text = ""
        lblDetails.ResetText()
        lblDetails.Visible = False
    End Sub
End Class
