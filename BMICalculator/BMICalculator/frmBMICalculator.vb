'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 10/07/2021
'Description: Chapter 7 [FINAL]
'             *This program will calculate BMI for the user upon selection of a measurement system, as well as 
'              entry of their weight and height in either metric or imperial. If entry is nonexistent, negative,
'              or non-numeric, an error will be displayed and calculations ceased.

'              **I am aware that we are instructed to use an event handler that is triggered by using the tab key,
'                however I decided that I liked the idea of a caret listener better, so I used text changed event 
'                handlers to emulate a caret listener and display the calculate button upon detection of input.

Public Class frmBMICalculator
    Dim intInputControl, intSystemControl As Int32
    Dim blnSystemCheck, blnWeightCheck, blnHeightCheck As Boolean
    Dim _cstrErrorBoxMessage As String = "Input must be numeric & greater than 0."
    Dim _cstrErrorBoxTitle As String = "Invalid entry!"

    'BEGIN EVENT HANDLERS'

    'Set lable text according to selected item, then set system bool to true and check bools'
    Private Sub lstMeasureSystems_MouseClick(sender As Object, e As MouseEventArgs) Handles lstMeasureSystems.MouseClick
        If (lstMeasureSystems.SelectedItem Is "         Imperial") Then
            lblWeight.Text = "Weight in lbs."
            lblHeight.Text = "Height in inches"
            blnSystemCheck = True
            intSystemControl = 1
            CheckBools()
        ElseIf (lstMeasureSystems.SelectedItem Is "          Metric") Then
            lblWeight.Text = "Weight in kgs."
            lblHeight.Text = "Height in meters"
            blnSystemCheck = True
            intSystemControl = 2
            CheckBools()
        End If
    End Sub

    'Confirm input and check bools on weight changed event'
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        intInputControl = 1
        ConfirmInput(intInputControl, txtWeight.Text)
        CheckBools()
    End Sub

    'Confirm input and check bools on height changed event'
    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        intInputControl = 2
        ConfirmInput(intInputControl, txtHeight.Text)
        CheckBools()
    End Sub

    'Proceed to validate input and calculate'
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ValidateInput()
    End Sub

    'END EVENT HANDLERS'

    'BEGIN LOGICAL ROUTINES'

    'Check length of input depending on control variable'
    Private Sub ConfirmInput(ByVal intInputControl As Integer, ByVal strInput As String)
        If (intInputControl = 1) Then
            If (strInput.Length > 0) Then
                blnWeightCheck = True
            Else
                blnWeightCheck = False
            End If
        ElseIf (intInputControl = 2) Then
            If (strInput.Length > 0) Then
                blnHeightCheck = True
            Else
                blnHeightCheck = False
            End If
        End If
    End Sub

    'Check for all required inputs to activate or deactivate button'
    Private Sub CheckBools()
        If (blnSystemCheck = True AndAlso blnWeightCheck = True AndAlso blnHeightCheck = True) Then
            ButtonEnabler()
        Else
            ButtonDisabler()
        End If
    End Sub

    'Enable calculate button on invoke'
    Private Sub ButtonEnabler()
        btnCalculate.BeginInvoke(
            Sub()
                btnCalculate.Enabled = True
            End Sub
        )
    End Sub

    'Disable calculate button on invoke'
    Private Sub ButtonDisabler()
        btnCalculate.BeginInvoke(
            Sub()
                btnCalculate.Enabled = False
            End Sub
        )
    End Sub

    'Validate all inputs before calculating'
    Private Sub ValidateInput()
        Try
            Dim decWeightInput, decHeightInput As Decimal
            decWeightInput = Decimal.Parse(txtWeight.Text)
            decHeightInput = Decimal.Parse(txtHeight.Text)
            If (decWeightInput < 0 Or decHeightInput < 0) Then
                MsgBox(_cstrErrorBoxMessage, , _cstrErrorBoxTitle)
            Else
                CheckMeasurementSystem(decWeightInput, decHeightInput)
            End If
        Catch Exception As ArgumentNullException
            MsgBox(_cstrErrorBoxMessage, , _cstrErrorBoxTitle)
        Catch Exception As FormatException
            MsgBox(_cstrErrorBoxMessage, , _cstrErrorBoxTitle)
        Catch Exception As SystemException
            MsgBox(_cstrErrorBoxMessage, , _cstrErrorBoxTitle)
        End Try
    End Sub

    'Check selected system of measurement'
    Private Sub CheckMeasurementSystem(ByVal decWeight As Decimal, ByVal decHeight As Decimal)
        If (intSystemControl = 1) Then
            txtBMI.Text = CType(CalculateImperialOutput(decWeight, decHeight), String)
        ElseIf (intSystemControl = 2) Then
            txtBMI.Text = CType(CalculateMetricOutput(decWeight, decHeight), String)
        End If
    End Sub

    'Calculate BMI if Imperial'
    Function CalculateImperialOutput(ByVal decWeight As Decimal, ByVal decHeight As Decimal) As Decimal
        Dim decImperialOutput As Decimal = CDec(Format((decWeight / (decHeight * decHeight)) * 703, "0.00"))
        Return decImperialOutput
    End Function

    'Calculate BMI if Metric'
    Function CalculateMetricOutput(ByVal decWeight As Decimal, ByVal decHeight As Decimal) As Decimal
        Dim decMetricOutput As Decimal = CDec(Format(decWeight / (decHeight * decHeight), "0.00"))
        Return decMetricOutput
    End Function

    'END LOGICAL ROUTINES'

End Class
