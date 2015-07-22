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
    Dim intTestScoresArray(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorialScoresArray(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjectScoresArray(6) As Integer    ' Hold the 7 projects scores

    ' Function drop lowest score and calculate the total nuber of points. 
    Function ProcessScores() As Integer
        ' TO-DO: Add body for this function.
        ' Page: 486 for lower grade drop - 501
    End Function

    Private Sub bntEnterScores_Click(sender As Object, e As EventArgs) Handles bntEnterScores.Click
        Dim intTestScore As Integer         ' To hold the user's input fo tests
        Dim intTestCount As Integer         ' Loop counter for tests

        Dim intTutorialScore As Integer     ' To hold the user's input for tutorials
        Dim intTutorialCount As Integer     ' Loop counter for tutorials

        Dim intProjectScore As Integer      ' To hold the user's input for projects
        Dim intProjectCount As Integer      ' Loop counter for projects

        ' Get the test scores and and add them to the test array.
        Do While intTestCount < intTestScoresArray.Length
            Try
                ' Get a test score.
                intTestScore = CInt(InputBox("Enter the test score #" & CStr(intTestCount + 1)))
                ' Add test score to in array.
                intTestScoresArray(intTestCount) = intTestScore
                ' Increment counter
                intTestCount += 1
            Catch
                ' Error message for invalid test score.
                MessageBox.Show("Enter a numeric value for test score.")
            End Try
        Loop

        ' For debugging
        MessageBox.Show("Scores are successfully entered to the test array!")
        Dim result1 As String = String.Join("", intTestScoresArray)
        lblTestArray.Text = result1

        ' Get the tutorial scores and and add them to the tutorial array.
        Do While intTutorialCount < intTutorialScoresArray.Length
            Try
                ' Get a tutorial score.
                intTutorialScore = CInt(InputBox("Enter the tutorial score #" & CStr(intTutorialCount + 1)))
                ' Add tutorial score to in array.
                intTutorialScoresArray(intTutorialCount) = intTutorialScore
                ' Increment counter
                intTutorialCount += 1
            Catch
                ' Error message for invalid tutorial score.
                MessageBox.Show("Enter a numeric value for tutorial score.")
            End Try
        Loop

        ' For debugging
        MessageBox.Show("Scores are successfully entered to the tutorial array!")
        Dim result2 As String = String.Join("", intTutorialScoresArray)
        lblTutorialArray.Text = result2

        ' Get the project scores and and add them to the project array.
        Do While intProjectCount < intProjectScoresArray.Length
            Try
                ' Get a project score.
                intProjectScore = CInt(InputBox("Enter the project score #" & CStr(intProjectCount + 1)))
                ' Add project score to in array.
                intProjectScoresArray(intProjectCount) = intProjectScore
                ' Increment counter
                intProjectCount += 1
            Catch
                ' Error message for invalid project score.
                MessageBox.Show("Enter a numeric value for project score.")
            End Try
        Loop

        ' For debugging
        MessageBox.Show("Scores are successfully entered to the ptoject array!")
        Dim result3 As String = String.Join("", intProjectScoresArray)
        lblProjectArray.Text = result3

    End Sub

    Private Sub btnSaveScores_Click(sender As Object, e As EventArgs) Handles btnSaveScores.Click
        ' Local variables.
        Dim outputFile As StreamWriter      ' Object variable
        Dim intTestCount As Integer         ' Hold the test count
        Dim intTestScore As Integer         ' To hold the score from array

        Try
            ' Create the file
            outputFile = File.CreateText("MyGrades.txt")
            ' Get 8 numbers and write them to the file
            For intTestCount = 0 To (intTestScoresArray.Length - 1)
                intTestScore = intTestScoresArray(intTestCount)
                outputFile.WriteLine(intTestScore)
                lstArrayLoad.Items.Add(intTestScore)
            Next
            outputFile.Close()
            MessageBox.Show("MyScores.txt file successfully created!")
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
            For intTestCount = 1 To 8
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
