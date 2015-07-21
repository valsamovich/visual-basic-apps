' Written by Valery Samovich 
' July 19, 2015
Option Strict On
Option Explicit On

Imports System.IO

Public Class Form1
    ' Class-level constants for total possible points per category
    Const intTEST_POSSIBLE_POINTS As Integer = 450      ' Possible points per one test
    Const intTUTORIAL_POSSIBLE_POINTS As Integer = 175  ' Possible points per one tutorial
    Const intPROJECT_POSSIBLE_POINTS As Integer = 280   ' Possible points per one project
    Const strFILENAME As String = "MyGrades.txt"        ' To store scores

    ' Array declarations for three categories of scores.
    Dim intTests(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorials(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjects(6) As Integer    ' Hold the 7 projects scores

    ' Function drop lowest score and calculate the total nuber of points. 
    Function ProcessScores() As Integer

    End Function

    Private Sub bntEnterScores_Click(sender As Object, e As EventArgs) Handles bntEnterScores.Click
        Dim intCount As Integer = 0     ' Loop counter, intialized to 0
        Dim intNumber As Integer        ' To hold user input

        ' Get the scores and add them to the array
        Do While intCount < intTests.Length
            Try
                ' Get and tests scores
                intNumber = CInt(InputBox("Enter score for test #1."))

                ' Add the score to the array
                'TO-DO

                ' Increment intCount
                intCount += 1
            Catch
                ' Error messagge for invalid integer.
                MessageBox.Show("Enter a numeric value for test score.")
            End Try
        Loop
    End Sub

    Private Sub btnSaveScores_Click(sender As Object, e As EventArgs) Handles btnSaveScores.Click
        ' Local variables.
        Dim outputFile As StreamWriter  ' Object variable
    End Sub

    Private Sub btnLoadScores_Click(sender As Object, e As EventArgs) Handles btnLoadScores.Click
        ' Local variables.
        Dim inputFile As StreamReader   ' Object variable
        Dim strInput As String          ' To hold a lineof input

        Try
            ' Open the file.
            inputFile = File.OpenText(strFILENAME)

            ' Clear the listboxes.
            lstTests.Items.Clear()
            lstTutorials.Items.Clear()
            lstProjects.Items.Clear()

            ' Read the file's contents.
            Do Until inputFile.Peek = -1
                ' Read a line form the file.
                strInput = inputFile.ReadLine()

                ' Add the line of input to the list box.
                lstTests.Items.Add(strInput)
            Loop

            ' Close the file.
            inputFile.Close()
        Catch
            ' Error message for file open error.
            MessageBox.Show(strFILENAME & "cannot be opened.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

End Class
