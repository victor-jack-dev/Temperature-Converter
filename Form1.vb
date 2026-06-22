Public Class frmTemp

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim temp As Double
        Dim result As Double

        'Check if input is valid
        If txtTemp.Text = "" Then
            MessageBox.Show("Please enter a temperature")
            Exit Sub
        End If

        temp = Val(txtTemp.Text)

        'Celsius to Fahrenheit
        If rdoCtoF.Checked = True Then
            result = (temp * 9 / 5) + 32
            txtResult.Text = "Fahrenheit: " & result

            'Fahrenheit to Celsius
        ElseIf rdoFtoC.Checked = True Then
            result = (temp - 32) * 5 / 9
            txtResult.Text = "Celsius: " & result

        Else
            MessageBox.Show("Please select conversion type")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
