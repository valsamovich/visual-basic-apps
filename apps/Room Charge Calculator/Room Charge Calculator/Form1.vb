Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal        ' Room charges total
        Dim decAddCharges As Decimal         ' Additional charges
        Dim decSubtotal As Decimal           ' Subtotal
        Dim decTax As Decimal                ' Tax
        Dim decTotal As Decimal              ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D ' Tax 

        lblStatus.Text = String.Empty
        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub
End Class
