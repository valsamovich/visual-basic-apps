Public Class Form1
    ' C1asa-level constants
    Const dblMONTHS_YEAR As Double = 12 ' Months per Year
    Const dblNEW_RATE As Double = 0.05  ' Interest rate, new cars
    Const dblUSED_RATE As Double = 0.08 ' Interest rate, used cars

    ' Class-level variable to hold the annual interest rate
    Dim dblAnnualRate As Double = dblNEW_RATE

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVehicleCost As Double    ' Vehicle cost
        Dim dblDownPayment As Double    ' Down payment
        Dim intMonths As Integer        ' Number of months for the loan
        Dim dblLoan As Double           ' Amount of the loan
        Dim dblMonthlyPayment As Double ' Monthly payment
        Dim dblInterest As Double       ' Interest paid for the period
        Dim dblPrincipal As Double      ' Principal paid for the period
        Dim intCount As Integer         ' Counter for the loop
        Dim strOut As String            ' Used to hold a line of output
        Dim blnlnputOk As Boolean = True

        ' Get the vehicle cost, validating at the same time.-
        If Not Double.TryParse(txtCost.Text, dblVehicleCost) Then
            lblMessage.Text = "Vehicle cost must be a number"
            blnlnputOk = False
        End If

        ' Get the down payment, validating at the same time.
        If Not Double.TryParse(txtDownPayment.Text, dblDownPayment) Then
            lblMessage.Text = "Down Payment must be a number"
            blnlnputOk = False
        End If

        ' Got the number of months, validating at the name  time.
        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            lblMessage.Text = "Months must be an  integer"
            blnlnputOk = False
        End If

        If blnlnputOk = True Then
            ' Calculate the loan ammout and monthy payment.
            dblLoan = dblVehicleCost - dblDownPayment
            dblMonthlyPayment = Pmt(dblAnnualRate / dblMONTHS_YEAR,
                                    intMonths, -dblLoan)

            ' Clear the list box and message label
            lstOutput.Items.Clear()
            lblMessage.Text = String.Empty

            For intCount = 1 To intMonths
                ' Calculate thr interest for this period.
                dblInterest = IPmt(dblAnnualRate / dblMONTHS_YEAR,
                                   intCount, intMonths, -dblLoan)

                ' Calculate thr principal for this period.
                dblInterest = PPmt(dblAnnualRate / dblMONTHS_YEAR,
                                   intCount, intMonths, -dblLoan)

                ' Start building the output string with the month.
                strOut = "Month " & intCount.ToString("d2")

                ' Add the payment amount to the output string.
                strOut &= ": payment = " & dblMonthlyPayment.ToString("n2")

                ' Add the interest amount to the output string.
                strOut &= ", interest = " & dblInterest.ToString("n2")

                ' Add the principal amount to the output string.
                strOut &= ", principal = " & dblPrincipal.ToString("n2")

                ' Add the output string to the list box.
                lstOutput.Items.Add(strOut)
            Next
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the interest rate, clear the text boxes, the list box, and the message label.
        dblAnnualRate = dblNEW_RATE
        lblAnnualRate.Text = dblNEW_RATE.ToString("p")
        txtCost.Clear()
        txtDownPayment.Clear()
        txtMonths.Clear()
        lstOutput.Items.Clear()
        lblMessage.Text = String.Empty

        ' Set default interest rate for new car loans.
        radNew.Checked = True

        ' Reset the focus to txtCost.
        txtCost.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
