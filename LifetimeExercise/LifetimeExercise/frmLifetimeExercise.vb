'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 08/30/2021
'Description: [FINAL]
'             *This program will accept input for the user's name, as well as
'              a birth date and a current date. It will then calculate the estimated
'              hours exercised assuming an individual exercised 3 hours a week or 0.428571 hours
'              per day. It will display this value along with a sentence describing it at the bottom.
'              A reset button and exit button are present to allow user repetition control.*  

'              **Calculations accomplished by converting input integers to string and then to Date. 
'                Utilized DateDiff to get the day count between the dates and multiplied that by _cdecHoursPerDay.**

'                ***Though unnecessary to the assignment parameters, I went ahead and caught various potential 
'                   errors from user input as well. These include non-integer input in the date boxes, out of range 
'                   integers in date boxes, incomplete form boxes, and negative dates.***

Public Class frmLifetimeExercise
    Const _cdecHoursPerDay As Decimal = 0.428571
    Dim intMonthDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
    Dim decHoursExercised As Decimal
    Dim strNameInput, strBirthDate, strCurrentDate As String
    Dim intBirthMonth, intBirthDate, intBirthYear As Integer
    Dim intCurrentMonth, intCurrentDate, intCurrentYear As Integer
    Dim dateBirthDate, dateCurrentDate As Date

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Complete Form Check'
        If txtName.TextLength = 0 Or txtBirthDD.TextLength = 0 Or txtBirthMM.TextLength = 0 Or txtBirthYYYY.TextLength = 0 Or txtCurrentDD.TextLength = 0 Or txtCurrentMM.TextLength = 0 Or txtCurrentYYYY.TextLength = 0 Then
            MessageBox.Show("All Entries Are Required.", "Incomplete Form",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Name Instantiation'
        strNameInput = txtName.Text

        'Birth Year Instantiation'
        If IsNumeric(txtBirthYYYY.Text) Then
            If Integer.TryParse(txtBirthYYYY.Text, txtBirthYYYY.Text) AndAlso txtBirthYYYY.Text > 999 AndAlso txtBirthYYYY.Text < 10000 Then
                intBirthYear = txtBirthYYYY.Text
            Else
                MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Birth Month Instantiation'
        If IsNumeric(txtBirthMM.Text) Then
            If Integer.TryParse(txtBirthMM.Text, txtBirthMM.Text) Then
                If txtBirthMM.Text <= 12 AndAlso txtBirthMM.Text > 0 Then
                    intBirthMonth = txtBirthMM.Text
                Else
                    MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Birth Date Instantiation'
        If IsNumeric(txtBirthDD.Text) Then
            If Integer.TryParse(txtBirthDD.Text, txtBirthDD.Text) Then
                If txtBirthDD.Text <= intMonthDays(intBirthMonth - 1) AndAlso txtBirthDD.Text > 0 Then
                    intBirthDate = txtBirthDD.Text
                Else
                    MessageBox.Show("Invalid Entry", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Year Instantiation'
        If IsNumeric(txtCurrentYYYY.Text) Then
            If Integer.TryParse(txtCurrentYYYY.Text, txtCurrentYYYY.Text) Then
                If txtCurrentYYYY.Text >= intBirthYear AndAlso txtCurrentYYYY.Text < 10000 Then
                    intCurrentYear = txtCurrentYYYY.Text
                Else
                    MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Month Instantiation'
        If IsNumeric(txtCurrentMM.Text) Then
            If Integer.TryParse(txtCurrentMM.Text, txtCurrentMM.Text) Then
                If intCurrentYear = intBirthYear Then
                    If txtCurrentMM.Text >= intBirthMonth AndAlso txtCurrentMM.Text <= 12 Then
                        intCurrentMonth = txtCurrentMM.Text
                    Else
                        MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                ElseIf intCurrentYear > intBirthYear Then
                    If txtCurrentMM.Text <= 12 AndAlso txtCurrentMM.Text > 0 Then
                        intCurrentMonth = txtCurrentMM.Text
                    Else
                        MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
            Else
                MessageBox.Show("Invalid Entry.", "Invalid Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Date Instantiation'
        If IsNumeric(txtCurrentDD.Text) Then
            If Integer.TryParse(txtCurrentDD.Text, txtCurrentDD.Text) Then
                If intCurrentYear = intBirthYear Then
                    If intCurrentMonth = intBirthMonth Then
                        If txtCurrentDD.Text >= intBirthDate AndAlso txtCurrentDD.Text < intMonthDays(intCurrentMonth - 1) Then
                            intCurrentDate = txtCurrentDD.Text
                        Else
                            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Else
                        If txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) AndAlso txtCurrentDD.Text > 0 Then
                            intCurrentDate = txtCurrentDD.Text
                        Else
                            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                Else
                    If txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) AndAlso txtCurrentDD.Text > 0 Then
                        intCurrentDate = txtCurrentDD.Text
                    Else
                        MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
            Else
                MessageBox.Show("Invalid Entry.", "Invalid Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Convert Int to String'
        If intBirthMonth < 10 Then
            If intBirthDate < 10 Then
                strBirthDate = "0" & intBirthMonth.ToString + "0" & intBirthDate.ToString + intBirthYear.ToString
            Else
                strBirthDate = "0" & intBirthMonth.ToString + intBirthDate.ToString + intBirthYear.ToString
            End If
        Else
            strBirthDate = intBirthMonth.ToString + intBirthDate.ToString + intBirthYear.ToString
        End If

        If intCurrentMonth < 10 Then
            If intCurrentDate < 10 Then
                strCurrentDate = "0" & intCurrentMonth.ToString + "0" & intCurrentDate.ToString + intCurrentYear.ToString
            Else
                strCurrentDate = "0" & intCurrentMonth.ToString + intCurrentDate.ToString + intCurrentYear.ToString
            End If
        Else
            strCurrentDate = intCurrentMonth.ToString + intCurrentDate.ToString + intCurrentYear.ToString
        End If

        'Convert String to Date'
        dateBirthDate = Date.ParseExact(strBirthDate, "MMddyyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        dateCurrentDate = Date.ParseExact(strCurrentDate, "MMddyyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)

        'Calculate Hours'
        Dim dayCount = DateDiff(DateInterval.Day, dateBirthDate, dateCurrentDate)
        decHoursExercised = dayCount * _cdecHoursPerDay

        'Display Output Message'
        Dim temp As Decimal = Format(decHoursExercised, "0.00")
        lblDetails.Text = txtName.Text & " has exercised for an estimated total of " &
                          temp & " hours in his/her lifetime."
        lblDetails.Visible = True
        decHoursExercised = 0

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
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
