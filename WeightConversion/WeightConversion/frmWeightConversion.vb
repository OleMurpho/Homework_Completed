'Class: CPT-185 | Dr. Bothur
'Student: Murphy M. Lopes
'Date: 09/09/2021
'Description: Chapter 5 [FINAL]
'             *This program will allow a user to select lb to kg, or kg to lb. By default it will select 
'              lb to kg. Upon transition from one radio button to the next, the text for the
'              lblConvert, lblWeight, and lblConversionType will change to match the input and output expected.
'              The user may input any positive integer or decimal up to 10 digits in length.
'              The program will then proceed to validate if input has been entered, and if it's numeric.
'              Once input requirements are met, the program will convert the given input into the selected
'              output format. It will display this input in the txtConvert box.
'              The txtConvert box is disabled and will only allow input from the program itself.
'              Reset and exit buttons are preset to allow user repetition control.*

'              **Once converted output has been given, selecting a new radio button will display a new converted
'                output, and then return to the original when radio buttons are changed again.

Public Class frmWeightConversion
    Dim _cdecConversionKey As Decimal = 2.2046
    Dim decWeightInput, decWeightConverted, decConvertedOutput As Decimal
    Dim chrConvertFrom As Char

    Private Sub radKgToLb_CheckedChanged(sender As Object, e As EventArgs) Handles radKgToLb.CheckedChanged
        If radKgToLb.Enabled Then
            lblConversionType.Text = "Kilograms to Pounds"
            chrConvertFrom = "K"
            lblConvert.Text = "To lbs"
            lblWeight.Text = "kgs"
        End If
        If decConvertedOutput.ToString.Length > 0 Then
            decWeightConverted = decWeightInput * _cdecConversionKey
            decConvertedOutput = Format(decWeightConverted, "0.000")
            txtConvert.Text = decConvertedOutput
        End If
    End Sub

    Private Sub radLbToKg_CheckedChanged(sender As Object, e As EventArgs) Handles radLbToKg.CheckedChanged
        If radLbToKg.Enabled Then
            lblConversionType.Text = "Pounds to Kilograms"
            chrConvertFrom = "P"
            lblConvert.Text = "To kgs"
            lblWeight.Text = "lbs"
        End If
        If decConvertedOutput.ToString.Length > 0 Then
            decWeightConverted = decWeightInput / _cdecConversionKey
            decConvertedOutput = Format(decWeightConverted, "0.000")
            txtConvert.Text = decConvertedOutput
        End If
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Check for input'
        If txtWeight.TextLength = 0 Then
            If chrConvertFrom = "P" Then
                MessageBox.Show("Weight in pounds required to continue.", "Input Required",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf chrConvertFrom = "K" Then
                MessageBox.Show("Weight in kilograms required to continue.", "Input Required",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        'Validate input'
        If IsNumeric(txtWeight.Text) Then
            If txtWeight.Text > 0 Then
                If txtWeight.TextLength <= 10 Then
                    decWeightInput = txtWeight.Text
                Else
                    MessageBox.Show("Number length must be no greater than 10.", "Invalid Entry",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Positive weight input required.", "Invalid Entry",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show("Numeric entry required.", "Invalid Entry",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Convert Input'
        If chrConvertFrom = "P" Then
            decWeightConverted = decWeightInput / _cdecConversionKey
            decConvertedOutput = Format(decWeightConverted, "0.000")
        ElseIf chrConvertFrom = "K" Then
            decWeightConverted = decWeightInput * _cdecConversionKey
            decConvertedOutput = Format(decWeightConverted, "0.000")
        End If

        'Output Converted Data'
        txtConvert.Text = decConvertedOutput
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtConvert.Text = "0.000"
        txtWeight.ResetText()
        decConvertedOutput = 0
        decWeightConverted = 0
        decWeightInput = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class

