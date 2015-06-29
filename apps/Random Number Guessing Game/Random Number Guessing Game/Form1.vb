' Written by Valery Samovich 
' June 28, 2015
Option Strict On
Option Explicit On

Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intNumber As Integer          ' Declare an Integer variable.
        Dim randNumber As New Random    ' Create a Random object

        Dim intCount As Integer         ' Counter variable
        Dim intGuess As Integer         ' To hold guess number
        Dim strInput As String          ' To hold user input

        ' Get a random integer and assign it to i
        intNumber = randNumber.Next(1, 100)

        ' Get the each guess number
        Do While intGuess <> intNumber
            ' Get a guess number from the user.
            strInput = InputBox("Enter the guess number " & intCount.ToString())

            ' Convert input to a Integer.
            If Integer.TryParse(strInput, intGuess) Then
                ' Determine if the number higher, lower or equal.
                If intGuess > intNumber Then
                    MessageBox.Show("The number is too high, try again.")
                ElseIf intGuess < intNumber Then
                    MessageBox.Show("The number is too low, try again.")
                ElseIf intGuess = intNumber Then
                    MessageBox.Show("The number is correct. great job!")
                End If
                ' Add 1 to the loop counter
                intCount += 1
            Else
                ' Display an error message for invalid input
                MessageBox.Show("Enter a numeric value")
            End If
        Loop
        ' Display the number of guesses
        lblGuesses.Text = intCount.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
