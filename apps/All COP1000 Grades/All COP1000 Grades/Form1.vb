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

    ' Array declarations for three categories of scores.
    Dim intTestsScoresArray(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorialsScoresArray(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjectsScoresArray(6) As Integer    ' Hold the 7 projects scores

    ' Function drop lowest score and calculate the total nuber of points. 
    Function ProcessScores() As Integer
        ' TO-DO: Add body for this function.
        ' Page: 486
    End Function

    Private Sub bntEnterScores_Click(sender As Object, e As EventArgs) Handles bntEnterScores.Click
        Dim intTestScore As Integer     ' To hold the user's input
        Dim intTestCount As Integer     ' Loop counter

        ' TO-DO: Add local variables for tutorials.
        ' TO-DO: Add local variables for projects.

        ' Get the tests scores and add them to an test array.
        Do While intTestCount < intTestsScoresArray.Length
            Try
                ' Get a test scores.
                intTestScore = CInt(InputBox("Enter the test score #" & CStr(intTestCount + 1)))
                ' Add test scores to in array.
                intTestsScoresArray(intTestCount) = intTestScore
                ' Increment counter
                intTestScore += 1
            Catch
                ' Error message for invalid score.
                MessageBox.Show("Enter a numeric value for test score.")
            End Try
        Loop

        ' To-DO: Add loop for tutorials
        ' TO-DO: Add loop for projects.
    End Sub

    Private Sub btnSaveScores_Click(sender As Object, e As EventArgs) Handles btnSaveScores.Click
        ' Local variables.
        Dim outputFile As StreamWriter      ' Object variable
        Dim intTestCount As Integer         ' Hold the count for tests

        Try
            ' Add test scores to the file.
            outputFile = File.CreateText("MyScores.txt")
            For intTestCount = 0 To (intTestsScoresArray.Length - 1)
                outputFile.WriteLine(intTestsScoresArray(intTestCount))
            Next
            outputFile.Close()
        Catch
            ' Error message for invalid score.
            MessageBox.Show("No scores have been entered. Click Enter Scores button to enter your scores.")
        End Try
    End Sub

    Private Sub btnLoadScores_Click(sender As Object, e As EventArgs) Handles btnLoadScores.Click
        ' Local variables.
        Dim inputFile As StreamReader       ' Object variable
        Dim intTestCount As Integer         ' Hold the count for tests
        Dim intTestScore As Integer         ' Hold the list number
        ' TO-DO: Add local variables for tutorials.
        ' TO-DO: Add local variables for projects.

        ' Check to see whether the file exists. If it does, then
        ' read is contents. Otherwise display an erro message.

        Try
            ' Open the file.
            inputFile = File.OpenText("MyGrades.txt")

            ' Clear the listboxes.
            lstTests.Items.Clear()
            lstTutorials.Items.Clear()
            lstProjects.Items.Clear()

            ' Read the 7 numbers for tests and display them.
            For intTestCount = 1 To 7
                intTestScore = CInt(inputFile.ReadLine())
                lstTests.Items.Add(intTestScore)
            Next

            ' TO-DO: Add loop for tutorial scores.
            ' TO-DO: Add loop for project scores.

            ' Close the file.
            inputFile.Close()
        Catch
            ' Error message for file open error.
            MessageBox.Show("No scores have been entered. Click Enter Scores button to enter your scores.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

End Class
