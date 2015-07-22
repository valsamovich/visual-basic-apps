' Written by Valery Samovich 
' July 21, 2015
Option Strict On
Option Explicit On

Imports System.IO

Public Class Form1
    ' Class-level constants for total possible points per category
    Const intTEST_POSSIBLE_POINTS As Integer = 350      ' Possible points per one test
    Const intTUTORIAL_POSSIBLE_POINTS As Integer = 150  ' Possible points per one tutorial
    Const intPROJECT_POSSIBLE_POINTS As Integer = 240   ' Possible points per one project

    Dim intTotalPossibleValues As Integer               ' To hold total possible points

    ' Array declarations for three categories of scores.
    Dim intTestScoresArray(7) As Integer       ' Hold the 8 tests scores
    Dim intTutorialScoresArray(6) As Integer   ' Hold the 7 tutorials scores
    Dim intProjectScoresArray(6) As Integer    ' Hold the 7 projects scores

    ' Local variables.
    Dim inputFile As StreamReader       ' Object variable
    Dim outputFile As StreamWriter      ' Object variable

    ' Function drop lowest score and calculate the total nuber of points. 
    Sub ProcessScores()
        ' TO-DO: Add body for this function.
        ' Page: 486 for lower grade drop - 501

        Dim intTestScore As Integer         ' To hold the test list number
        Dim intTestCount As Integer         ' To hold the count of tests

        Dim intTutorialScore As Integer     ' To hold the tutorial list number
        Dim intTutorialCount As Integer     ' To hold the count of tutorials

        Dim intProjectScore As Integer      ' To hold the project list number
        Dim intProjectCount As Integer      ' To hold the count of projects

        Dim intTestTotalPoins As Integer    ' To hold test total points earned

        ' Clear the listboxes.
        lstTests.Items.Clear()
        lstTutorials.Items.Clear()
        lstProjects.Items.Clear()

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

        For intTestCount = 0 To (intTestScoresArray.Length - 1)
            intTestTotalPoins += intTestScoresArray(intTestCount)
        Next

        ' Calculate total possible points.
        intTotalPossibleValues = intTEST_POSSIBLE_POINTS +
            intTUTORIAL_POSSIBLE_POINTS + intPROJECT_POSSIBLE_POINTS
        ' Display total possible points.
        lblPossiblePoints.Text = intTotalPossibleValues.ToString

        lblPointsEarned.Text = intTestTotalPoins.ToString
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

        '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
        MessageBox.Show("Scores are successfully entered to the test array!")
        Dim result1 As String = String.Join("", intTestScoresArray)
        lblTestArray.Text = result1
        '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''

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

        '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
        MessageBox.Show("Scores are successfully entered to the tutorial array!")
        Dim result2 As String = String.Join("", intTutorialScoresArray)
        lblTutorialArray.Text = result2
        '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''

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

        '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
        MessageBox.Show("Scores are successfully entered to the ptoject array!")
        Dim result3 As String = String.Join("", intProjectScoresArray)
        lblProjectArray.Text = result3
        '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''

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
                '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
                ' lstArrayLoad.Items.Add(intTestScore)
                '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
            Next

            '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
            MessageBox.Show("Test scores successfully added to MyScores.txt file!")
            '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''

            ' Get tutorial scores and write them to the file.
            For intTutorialCount = 0 To (intTutorialScoresArray.Length - 1)
                intTutorialScore = intTutorialScoresArray(intTutorialCount)
                outputFile.WriteLine(intTutorialScore)
                '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
                ' lstArrayLoad.Items.Add(intTestScore)
                '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
            Next

            '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
            MessageBox.Show("Tutorial scores successfully added to MyScores.txt file!")
            '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''

            ' Get tutorial scores and write them to the file.
            For intProjectCount = 0 To (intProjectScoresArray.Length - 1)
                intProjectScore = intProjectScoresArray(intProjectCount)
                outputFile.WriteLine(intProjectScore)
                '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
                ' lstArrayLoad.Items.Add(intTestScore)
                '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
            Next

            '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''
            MessageBox.Show("Project scores successfully added to MyScores.txt file!")
            '''''''''' For debugging '''''''''''''''''''''''''''''''''''''''''''''''''

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
