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

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
