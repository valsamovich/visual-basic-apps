Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intNumber As Integer            ' Declare an integer variable
        Dim randNumber As New Random        ' Create a Random object
        Dim intGuessNumber As Integer       ' To hold input for user
        Dim intGuessCounter As Integer      ' To hold number of guess
        Dim btnInputOk As Boolean = True    ' Help to validate input

        ' Get an random integer and assign it to integerNumber
        intNumber = randNumber.Next(1, 100)

        ' Get the user input, validating at the same time
        If Not Integer.TryParse(txtGuessNumber.Text, intGuessNumber) Then
            lblMessage.Text = " Guess number must be a number"
            btnInputOk = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGuessNumber.Clear()          ' Clear the guess number 
        lblMessage.Text = String.Empty  ' Clear the message box

        ' Set focus on guess number
        txtGuessNumber.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

End Class
