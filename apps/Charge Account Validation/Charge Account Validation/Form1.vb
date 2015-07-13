' Written by Valery Samovich 
' July 12, 2015
Option Strict On
Option Explicit On

Public Class Form1

    ' Declar array of valid numbers 
    Dim intNumbers() As Integer = {5658845, 4520125, 7895122, 8777541, 8451277, 1302850,
                                   8080152, 4562555, 5552012, 5050552, 7825877, 1250255,
                                   1005231, 6545231, 3852085, 7576651, 7881200, 4581002}

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim intInput As Integer     ' To hold input

        If inputIsValid() Then
            ' Get the input value.
            Integer.TryParse(txtInput.Text, intInput)

            If isValid(intInput) Then
                MessageBox.Show("Account number is valid.")
            Else
                MessageBox.Show("Account number is invalid.")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function inputIsValid() As Boolean
        ' Varialbe to temporary hold the input value.
        Dim intInputTempValue As Integer

        ' Try to convert the value entered by the user to a Integer.
        ' If it will not convert, display an error message and return false. 
        If Not Integer.TryParse(txtInput.Text, intInputTempValue) Then
            MessageBox.Show("Enter a numeric value for the input.")
            Return False
        End If

        ' Determine whether the value entered is negative.
        ' If it is, display an error message and return false.
        If intInputTempValue < 0 Then
            MessageBox.Show("Enter a positive numeric value for the input.")
        End If

        ' If value is valid, return true.
        Return True
    End Function

    ' Sequential search to determine wheather a number appears in the array.
    Function isValid(ByVal intInput As Integer) As Boolean
        Dim btnFound As Boolean = False     ' Boolean flag for search
        Dim intIndex As Integer             ' Hold an array index

        ' Loop thru array to validate if the number appears in it.
        While Not btnFound And intIndex < intNumbers.Length()
            If intNumbers(intIndex) = intInput Then
                btnFound = True
            Else
                intIndex += 1
            End If
        End While

        ' Return the flag of the search. 
        Return True
    End Function

End Class
