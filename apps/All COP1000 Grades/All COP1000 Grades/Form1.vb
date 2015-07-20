' Written by Valery Samovich 
' July 19, 2015
Option Strict On
Option Explicit On

Public Class Form1

    ' Class-level constants for total possible points per category
    Const intTEST_POSSIBLE_POINTS As Integer = 450       ' Possible points per one test
    Const intTUTORIAL_POSSIBLE_POINTS As Integer = 175   ' Possible points per one tutorial
    Const intPROJECT_POSSIBLE_POINTS As Integer = 280    ' Possible points per one project

    ' Array declarations for three categories of scores.
    Dim intTests(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorials(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjects(6) As Integer    ' Hold the 7 projects scores

    ' Function drop lowest score and calculate the total nuber of points. 
    Function ProcessScores() As Integer

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

End Class
