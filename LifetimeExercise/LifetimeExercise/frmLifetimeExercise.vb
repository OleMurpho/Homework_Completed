'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 09/08/2021
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

    Private Sub frmLifetimeExercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim dateBirthDate, dateCurrentDate As Date

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Complete Form Check'
        If txtName.TextLength = 0 Or                                                'Check for name'
            txtBirthDD.TextLength = 0 Or                                            'Check for birth date'
            txtBirthMM.TextLength = 0 Or                                            'Check for birth month'
            txtBirthYYYY.TextLength = 0 Or                                          'Check for birth year'
            txtCurrentDD.TextLength = 0 Or                                          'Check for current date'
            txtCurrentMM.TextLength = 0 Or                                          'Check for current month'
            txtCurrentYYYY.TextLength = 0 Then                                      'Check for current year'
            MessageBox.Show("All Entries Are Required.", "Incomplete Form",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Name Instantiation'
        strNameInput = txtName.Text

        'Birth Year Instantiation'
        If IsNumeric(txtBirthYYYY.Text) Then                                        'Check if numeric'
            If Integer.TryParse(txtBirthYYYY.Text, txtBirthYYYY.Text) AndAlso       'Check if integer'
                txtBirthYYYY.Text > 999 AndAlso txtBirthYYYY.Text < 10000 Then      'Check if 4 digits'
                intBirthYear = txtBirthYYYY.Text
                If intBirthYear Mod 4 = 0 Then                                      'Check for leap year*'
                    intMonthDays(1) = 29                                                '*Set February to 29 days in intMonthDays array'
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

        'Birth Month Instantiation'
        If IsNumeric(txtBirthMM.Text) Then                                          'Check if numeric'
            If Integer.TryParse(txtBirthMM.Text, txtBirthMM.Text) Then              'Check if integer'
                If txtBirthMM.Text <= 12 AndAlso txtBirthMM.Text > 0 Then           'Check if birth month > 0 and <= 12'
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
        If IsNumeric(txtBirthDD.Text) Then                                          'Check if numeric'
            If Integer.TryParse(txtBirthDD.Text, txtBirthDD.Text) Then              'Check if integer'
                If txtBirthDD.Text <= intMonthDays(intBirthMonth - 1) AndAlso       'Check if birth date > 0 and <= intMonthDays(x)'
                    txtBirthDD.Text > 0 Then
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
        intMonthDays(1) = 28                                                        'Set February to 28 days in intMonthDays array'
        'Current Year Instantiation'
        If IsNumeric(txtCurrentYYYY.Text) Then                                      'Check if numeric'
            If Integer.TryParse(txtCurrentYYYY.Text, txtCurrentYYYY.Text) Then      'Check if integer'
                If txtCurrentYYYY.Text >= intBirthYear AndAlso                      'Check if current year >= birth year'
                    txtCurrentYYYY.Text < 10000 Then                                'Check if 4 digits'
                    intCurrentYear = txtCurrentYYYY.Text
                    If intCurrentYear Mod 4 = 0 Then                                'Check for leap year*'
                        intMonthDays(1) = 29                                            '*Set February to 29 days in intMonthDays array'
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
        Else
            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Current Month Instantiation'
        If IsNumeric(txtCurrentMM.Text) Then                                        'Check if numeric'
            If Integer.TryParse(txtCurrentMM.Text, txtCurrentMM.Text) Then          'Check if integer'
                If intCurrentYear = intBirthYear Then                               'Check if current year = birth year*'
                    If txtCurrentMM.Text >= intBirthMonth AndAlso                       '*Check if current month >= birth month'
                        txtCurrentMM.Text <= 12 Then                                    '*Check if current month <= 12'
                        intCurrentMonth = txtCurrentMM.Text
                    Else
                        MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                ElseIf intCurrentYear > intBirthYear Then                           'Check if current year > birth year*'
                    If txtCurrentMM.Text <= 12 AndAlso                                  '*Check if current month <= 12'
                        txtCurrentMM.Text > 0 Then                                      '*Check if current month > 0'
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
        If IsNumeric(txtCurrentDD.Text) Then                                        'Check if numeric'
            If Integer.TryParse(txtCurrentDD.Text, txtCurrentDD.Text) Then          'Check if integer'
                If intCurrentYear = intBirthYear Then                               'Check if current year = birth year*'
                    If intCurrentMonth = intBirthMonth Then                             '*Check if current month = birth month**'
                        If txtCurrentDD.Text >= intBirthDate AndAlso                        '**Check if current date >= birth date'
                            txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) Then      '**Check if current date <= max days for month'
                            intCurrentDate = txtCurrentDD.Text
                        Else
                            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Else
                        If txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) AndAlso   '**Check if current date <= max days for month'
                            txtCurrentDD.Text > 0 Then                                      '**Check if current date > 0'
                            intCurrentDate = txtCurrentDD.Text
                        Else
                            MessageBox.Show("Invalid Entry.", "Invalid Entry",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                Else
                    If txtCurrentDD.Text <= intMonthDays(intCurrentMonth - 1) AndAlso   '*Check if current date <= max days for month'
                        txtCurrentDD.Text > 0 Then                                      '*Check if current date > 0'
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
        intMonthDays(1) = 28                                                        'Set February to 28 days in intMonthDays array'
        'Convert Int to String'
        If intBirthMonth < 10 Then                                                  'Check if birth month < 10*'
            If intBirthDate < 10 Then                                                   '*Check if birth date < 10'
                strBirthDate = "0" & intBirthMonth.ToString +                           '*Add zeros for parsing'
                               "0" & intBirthDate.ToString +
                               intBirthYear.ToString
            Else
                strBirthDate = "0" & intBirthMonth.ToString +
                               intBirthDate.ToString +
                               intBirthYear.ToString
            End If
        Else
            strBirthDate = intBirthMonth.ToString +
                           intBirthDate.ToString +
                           intBirthYear.ToString
        End If

        If intCurrentMonth < 10 Then                                                'Check if current month < 10*'
            If intCurrentDate < 10 Then                                                 '*Check if current date < 10'   
                strCurrentDate = "0" & intCurrentMonth.ToString +                       '*Add zeros for parsing'
                                 "0" & intCurrentDate.ToString +
                                 intCurrentYear.ToString
            Else
                strCurrentDate = "0" & intCurrentMonth.ToString +
                                 intCurrentDate.ToString +
                                 intCurrentYear.ToString
            End If
        Else
            strCurrentDate = intCurrentMonth.ToString +
                             intCurrentDate.ToString +
                             intCurrentYear.ToString
        End If

        'Convert String to Date'
        dateBirthDate = Date.ParseExact(strBirthDate, "MMddyyyy",                   'Parse converted birth date String to Date'
                        System.Globalization.DateTimeFormatInfo.InvariantInfo)
        dateCurrentDate = Date.ParseExact(strCurrentDate, "MMddyyyy",                'Parse converted current date String to Date'
                          System.Globalization.DateTimeFormatInfo.InvariantInfo)

        'Calculate Hours'
        Dim dayCount = DateDiff(DateInterval.Day, dateBirthDate, dateCurrentDate)   'Get total days between birth Date and current Date'
        decHoursExercised = dayCount * _cdecHoursPerDay                             'total days * 0.428571 = decHoursExercised'

        'Display Output Message'
        Dim temp As Decimal = Format(decHoursExercised, "0.00")                     'Format decHoursExercised to 2 decimal places'
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
