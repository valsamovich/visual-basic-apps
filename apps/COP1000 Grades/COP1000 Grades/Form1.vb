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
        Dim intIntroPost As Integer = 0             ' To hold intro post points

        Dim intChapter1Test As Integer = 0          ' To hold chapter 1 test points
        Dim intChapter1Tutorial As Integer = 0      ' To hold chapter 1 tutorial points
        Dim intChapter1Project As Integer = 0       ' To hold chapter 1 project points

        Dim intChapter2Test As Integer = 0          ' To hold chapter 2 test points
        Dim intChapter2Tutorial As Integer = 0      ' To hold chapter 2 tutorial points
        Dim intChapter2Project As Integer = 0       ' To hold chapter 2 project points

        Dim intChapter3Test As Integer = 0          ' To hold chapter 3 test points
        Dim intChapter3Tutorial As Integer = 0      ' To hold chapter 3 tutorial points

        Dim intTotalPossiblePoints As Integer = 250 ' To hold total possible points
        Dim intTotalPointsEarned As Integer = 0     ' To hold total points earned
        Dim intPrecentageGrade As Integer = 0       ' To hold PrecentageGrade

        ' Read the values from the Introduction TextBox control. 
        intIntroPost = CInt(txtIntroPost.Text)

        ' Read the values from the Chapter 1 TextBox controls. 
        intChapter1Test = CInt(txtChapter1Test.Text)
        intChapter1Tutorial = CInt(txtChapter1Tutorial.Text)
        intChapter1Project = CInt(txtChapter1Project.Text)

        ' Read the values from the Chapter 2 TextBox controls. 
        intChapter2Test = CInt(txtChapter2Test.Text)
        intChapter2Tutorial = CInt(txtChapter2Tutorial.Text)
        intChapter2Project = CInt(txtChapter2Project.Text)

        ' Read the values from the Chapter 3 TextBox controls. 
        intChapter3Test = CInt(txtChapter3Test.Text)
        intChapter3Tutorial = CInt(txtChapter3Tutorial.Text)

        ' Calculate  the total points earned
        intTotalPointsEarned = intIntroPost +
            intChapter1Test + intChapter1Tutorial + intChapter1Project +
            intChapter2Test + intChapter2Tutorial + intChapter2Project +
            intChapter3Test + intChapter3Tutorial

        ' Display the total possible points
        lblTotalPossiblePoints.Text = CStr(intTotalPossiblePoints)

        ' Display the total points earned
        lblTotalPointsEarned.Text = CStr(intTotalPointsEarned)
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
