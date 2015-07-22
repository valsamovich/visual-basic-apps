' Written by Valery Samovich 
' July 21, 2015
Option Strict On
Option Explicit On

Imports System.IO

Public Class Form1
    ' Class-level constants for total possible points per category.
    Const intTEST_POSSIBLE_POINTS As Integer = 350      ' Possible points per one test
    Const intTUTORIAL_POSSIBLE_POINTS As Integer = 150  ' Possible points per one tutorial
    Const intPROJECT_POSSIBLE_POINTS As Integer = 240   ' Possible points per one project

    'Class-level variables.
    Dim intTotalPossiblePoints As Integer   ' To hold total possible points
    Dim intToTalEarnedPoints As Integer     ' To hold total earned points
    Dim dblPercentageGrade As Double        ' To hold percentage grade

    Dim intTestLowestScore As Integer       ' To hold lowest test score
    Dim intTutorialLowestScore As Integer   ' To hold lowest tutorial score
    Dim intProjectLowestScore As Integer    ' To hold lowest project score

    ' Array declarations for three categories of scores.
    Dim intTestScoresArray(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorialScoresArray(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjectScoresArray(6) As Integer    ' Hold the 7 projects scores

    Dim inputFile As StreamReader   ' Object variable
    Dim outputFile As StreamWriter  ' Object variable

    ' Function to pre=osess scores. 
    Sub ProcessScores()
        ' Local variables.
        Dim intTestScore As Integer             ' To hold the test list number
        Dim intTestCount As Integer             ' To hold the count of tests

        Dim intTutorialScore As Integer         ' To hold the tutorial list number
        Dim intTutorialCount As Integer         ' To hold the count of tutorials

        Dim intProjectScore As Integer          ' To hold the project list number
        Dim intProjectCount As Integer          ' To hold the count of projects

        Dim intTestTotalPoins As Integer        ' To hold test total points earned
        Dim intTutorialTotalPoins As Integer    ' To hold tutorial total points earned
        Dim intProjectTotalPoins As Integer     ' To hold project total points earned

        ' Clear the listboxes.
        lstTests.Items.Clear()
        lstTutorials.Items.Clear()
        lstProjects.Items.Clear()

        ' Sum tha test points
        For intTestCount = 0 To (intTestScoresArray.Length - 1)
            intTestTotalPoins += intTestScoresArray(intTestCount)
        Next

        ' Sum tha tutorial points
        For intTutorialCount = 0 To (intTutorialScoresArray.Length - 1)
            intTutorialTotalPoins += intTutorialScoresArray(intTutorialCount)
        Next

        ' Sum tha project points
        For intProjectCount = 0 To (intProjectScoresArray.Length - 1)
            intProjectTotalPoins += intProjectScoresArray(intProjectCount)
        Next

        ' Get the first element
        intTestLowestScore = intTestScoresArray(0)

        ' Search for the lowest test score.
        For intTestCount = 1 To (intTestScoresArray.Length - 1)
            If intTestScoresArray(intTestCount) < intTestLowestScore Then
                intTestLowestScore = intTestScoresArray(intTestCount)
            End If
        Next

        ' Get the first element
        intTutorialLowestScore = intTutorialScoresArray(0)

        ' Search for the lowest tutorial score.
        For intTutorialCount = 1 To (intTutorialScoresArray.Length - 1)
            If intTutorialScoresArray(intTutorialCount) < intTutorialLowestScore Then
                intTutorialLowestScore = intTutorialScoresArray(intTutorialCount)
            End If
        Next

        ' Get the first element
        intProjectLowestScore = intProjectScoresArray(0)

        ' Search for the lowest tutorial score.
        For intProjectCount = 1 To (intProjectScoresArray.Length - 1)
            If intProjectScoresArray(intProjectCount) < intProjectLowestScore Then
                intProjectLowestScore = intProjectScoresArray(intProjectCount)
            End If
        Next

        ' Read the 8 numbers for tests and display them.
        For intTestCount = 1 To 8
            intTestScore = CInt(inputFile.ReadLine())
            lstTests.Items.Add(intTestScore)
        Next

        ' Read the 7 numbers for tests and display them.
        For intTutorialCount = 9 To 15
            intTutorialScore = CInt(inputFile.ReadLine())
            lstTutorials.Items.Add(intTutorialScore)
        Next

        ' Read the 7 numbers for tests and display them.
        For intProjectCount = 16 To 22
            intProjectScore = CInt(inputFile.ReadLine())
            lstProjects.Items.Add(intProjectScore)
        Next

        ' Calculate total possible points.
        intTotalPossiblePoints = intTEST_POSSIBLE_POINTS +
            intTUTORIAL_POSSIBLE_POINTS + intPROJECT_POSSIBLE_POINTS

        ' Calculate total points earned.
        intToTalEarnedPoints = intTestTotalPoins +
            intTutorialTotalPoins + intProjectTotalPoins

        ' Calculate the percentage grade
        dblPercentageGrade = intToTalEarnedPoints / intTotalPossiblePoints

        ' Display total possible points.
        lblPossiblePoints.Text = intTotalPossiblePoints.ToString

        ' Display total earned points.
        lblPointsEarned.Text = intToTalEarnedPoints.ToString

        ' Display the the percentage grade
        lblPercentageGrade.Text = dblPercentageGrade.ToString("p")
    End Sub

    Private Sub bntEnterScores_Click(sender As Object, e As EventArgs) Handles bntEnterScores.Click
        ' Local variables.
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

        ' Success message.
        MessageBox.Show("Test scores are successfully entered to array!")

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

        ' Success message.
        MessageBox.Show("Tutorial scores are successfully entered to array!")

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

        ' Success message.
        MessageBox.Show("Project scores are successfully entered to array!")

    End Sub

    Private Sub btnSaveScores_Click(sender As Object, e As EventArgs) Handles btnSaveScores.Click
        Dim intTestScore As Integer         ' To hold the score from test array
        Dim intTestCount As Integer         ' Loop counter for tests

        Dim intTutorialScore As Integer     ' To hold the score from tutorial array
        Dim intTutorialCount As Integer     ' Loop counter for tutorials

        Dim intProjectScore As Integer      ' To hold the score from project array
        Dim intProjectCount As Integer      ' Loop counter for projects

        Try
            ' Create the file
            outputFile = File.CreateText("MyGrades.txt")

            ' Get test scores and write them to the file.
            For intTestCount = 0 To (intTestScoresArray.Length - 1)
                intTestScore = intTestScoresArray(intTestCount)
                outputFile.WriteLine(intTestScore)
            Next

            ' Get tutorial scores and write them to the file.
            For intTutorialCount = 0 To (intTutorialScoresArray.Length - 1)
                intTutorialScore = intTutorialScoresArray(intTutorialCount)
                outputFile.WriteLine(intTutorialScore)
            Next

            ' Get tutorial scores and write them to the file.
            For intProjectCount = 0 To (intProjectScoresArray.Length - 1)
                intProjectScore = intProjectScoresArray(intProjectCount)
                outputFile.WriteLine(intProjectScore)
            Next

            ' Success message.
            MessageBox.Show("All scores successfully added to MyScores.txt file!")

            ' Close the file
            outputFile.Close()

        Catch
            ' Error message for invalid score.
            MessageBox.Show("No scores have been entered. Click Enter Scores button to enter your scores.")
        End Try
    End Sub

    Private Sub btnLoadScores_Click(sender As Object, e As EventArgs) Handles btnLoadScores.Click
        ' Check to see whether the file exists. If it does, then
        ' read is contents. Otherwise display an erro message.
        Try
            ' Open the file.
            inputFile = File.OpenText("MyGrades.txt")

            ' Process the scores.
            ProcessScores()

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
