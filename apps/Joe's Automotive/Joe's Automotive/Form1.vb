' Written by Valery Samovich 
' July 6, 2015
Option Strict On
Option Explicit On

Public Class Form1
    ' Class-level declarations
    Const decTAX_RATE As Decimal = 0.06D            ' Tax rate
    Const decOIL_CHANGE As Decimal = 26D            ' Cost of a oil change
    Const decLUBE_JOB As Decimal = 18D              ' Cost of lube job
    Const decRADIATOR_FLUSH As Decimal = 30D        ' Cost of radiator flush
    Const decTRANSMISSION_FLUSH As Decimal = 80D    ' Cost of transmission flush
    Const decINSPECTION As Decimal = 15D            ' Cost of inspection
    Const decMUFFLER_REPLACEMENT As Decimal = 100D  ' Cost of muffler replacement
    Const decTIRE_ROTATION As Decimal = 20D         ' Cost of tire rotation

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        ' This procedure calculates the total of an order.

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
