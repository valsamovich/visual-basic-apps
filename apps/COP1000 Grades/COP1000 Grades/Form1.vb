' Written by Valery Samovich 
' June 7, 2015 
Option Strict On
Option Explicit On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Place the focus to the first field.
        txtIntroPost.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculation 
        Dim intIntroPost As Integer                 ' To hold intro post points

        Dim intChapter1Test As Integer              ' To hold chapter 1 test points

        Dim intChapter2Test As Integer              ' To hold chapter 2 test points
        Dim intChapter2Tutorial As Integer          ' To hold chapter 2 tutorial points
        Dim intChapter2Project As Integer           ' To hold chapter 2 project points

        Dim intChapter3Test As Integer              ' To hold chapter 3 test points
        Dim intChapter3Tutorial As Integer          ' To hold chapter 3 tutorial points

        Dim intTotalPossiblePoints As Integer = 250 ' To hold total possible points
        Dim intTotalPointsEarned As Integer         ' To hold total points earned
        Dim intPercentageGrade As Integer           ' To hold PrecentageGrade

        Try
            ' Read the values from the Introduction TextBox control. 
            intIntroPost = CInt(txtIntroPost.Text)

            ' Read the values from the Chapter 1 TextBox controls. 
            intChapter1Test = CInt(txtChapter1Test.Text)

            ' Read the values from the Chapter 2 TextBox controls. 
            intChapter2Test = CInt(txtChapter2Test.Text)
            intChapter2Tutorial = CInt(txtChapter2Tutorial.Text)
            intChapter2Project = CInt(txtChapter2Project.Text)

            ' Read the values from the Chapter 3 TextBox controls. 
            intChapter3Test = CInt(txtChapter3Test.Text)
            intChapter3Tutorial = CInt(txtChapter3Tutorial.Text)

            ' Calculate  the total points earned
            intTotalPointsEarned = intIntroPost + intChapter1Test +
                intChapter2Test + intChapter2Tutorial + intChapter2Project +
                intChapter3Test + intChapter3Tutorial

            ' Calculate the precentage grade
            intPercentageGrade = CInt(intTotalPointsEarned * 100 / intTotalPossiblePoints)

            ' Display the total possible points
            lblTotalPossiblePoints.Text = CStr(intTotalPossiblePoints)

            ' Display the total points earned
            lblTotalPointsEarned.Text = CStr(intTotalPointsEarned)

            ' Display the total points earned
            lblPercentageGrade.Text = intPercentageGrade.ToString("n")
        Catch
            ' Display an error mssage
            MessageBox.Show("Error: All imput must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the intro post fields.
        txtIntroPost.Clear()

        ' Clear the Chapter 1 field.
        txtChapter1Test.Clear()

        ' Clear the Chapter 2 fields.
        txtChapter2Test.Clear()
        txtChapter2Tutorial.Clear()
        txtChapter2Project.Clear()

        ' Clear the Chapter 1 fields.
        txtChapter3Test.Clear()
        txtChapter3Tutorial.Clear()

        ' Clear the Total fields.
        lblTotalPossiblePoints.Text = String.Empty
        lblTotalPointsEarned.Text = String.Empty
        lblPercentageGrade.Text = String.Empty

        ' Reset the focus to the first field.
        txtIntroPost.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
