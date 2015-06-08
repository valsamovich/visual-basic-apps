' Written by Valery Samovich 
' June 7, 2015 
Option Strict On
Option Explicit On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the intro post fields.
        txtIntroPost.Clear()

        ' Clear the Chapter 1 fields.
        txtChapter1Test.Clear()
        txtChapter1Tutorial.Clear()
        txtChapter1Project.Clear()

        ' Clear the Chapter 2 fields.
        txtChapter2Test.Clear()
        txtChapter2Tutorial.Clear()
        txtChapter2Project.Clear()

        ' Clear the Chapter 1 fields.
        txtChapter3Test.Clear()
        txtChapter3Tutorial.Clear()

        ' Clear the Total fields.
        lblTotalPossiblePoints.Text = String.Empty
        lblPointsEarned.Text = String.Empty
        lblPercentageGrade.Text = String.Empty

        ' Reset the focus to the first field.
        txtIntroPost.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
