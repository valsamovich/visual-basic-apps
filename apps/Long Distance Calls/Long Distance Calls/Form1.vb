Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intMinutes As Integer           ' Number of minutes
        Dim dblTotalFee As Double           ' Total charge for a phone call
        Dim blnInputOk As Boolean = True

        ' Constants for rate per mintues
        Const dblDAYTIME_FEE As Double = 0.07
        Const dblEVENING_FEE As Double = 0.12
        Const dblOFFPEAK_FEE As Double = 0.05

        lblStatus.Text = String.Empty
        ' Validate and convert the number of minutes
        If Integer.TryParse(txtMinutes.Text, intMinutes) = False Then
            lblStatus.Text = "Minutes must be in an integer."
            blnInputOk = False
        ElseIf intMinutes <= 0 Then
            ' Validate  the number of mintues
            lblStatus.Text = "Minutes must be greater than 0."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            ' Determine the base call fee.
            If radDaytime.Checked = True Then
                dblTotalFee = dblDAYTIME_FEE * intMinutes
            ElseIf radEvening.Checked = True Then
                dblTotalFee = dblEVENING_FEE * intMinutes
            ElseIf radOffPeak.Checked = True Then
                dblTotalFee = dblOFFPEAK_FEE * intMinutes
            End If
        End If

        ' Display the call total fee.
        lblTotalFee.Text = dblTotalFee.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the Daytime radio button.
        radDaytime.Checked = True

        ' Clear the number of minutes
        txtMinutes.Clear()

        ' Clear the total charge
        lblTotalFee.Text = String.Empty

        ' Clear the status message
        lblStatus.Text = String.Empty

        ' Give txtMinutes the focus.
        txtMinutes.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
