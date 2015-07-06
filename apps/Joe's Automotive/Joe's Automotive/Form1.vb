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
        Dim decTax As Decimal       ' Holds the sales tax
        Dim decTotal As Decimal     ' Holds the order total
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This procedures resets the controls to default values.
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function OilLubeCharges() As Decimal
        ' This function returns the cost of the selected oil charges.
        Return 0
    End Function

    Function FlushCharges() As Decimal
        ' This function returns the cost of the selected flush charges. 
        Return 0
    End Function

    Function MyFunc() As Decimal
        ' This function returns the cost of the selected misc charges. 
        Return 0
    End Function

    Function OtherCharges() As Decimal
        ' This function returns the cost of the selected other charges. 
        Return 0
    End Function

    Function TaxCharges() As Decimal
        ' This function returns the amount of the sales tax.
        Return 0
    End Function

    Function TotalCharges() As Decimal
        ' This function returns the amount of the total charges.
        Return 0
    End Function



    Sub ClearOilLube()
        ' This procedure resets the oil change selection.
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    Sub ClearFlushes()
        ' This procedure resets the flush selection.
        chkRadiatorFlush.Checked = False
        chkTransmissionFlush.Checked = False
    End Sub

    Sub ClearMisc()
        ' This procedure resets the misc selection.
        chkInspection.Checked = False
        chkReplaceMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    Sub ClearOther()
        ' This procedure resets the parts and labor.
        txtParts.Clear()
        txtLabor.Clear()
    End Sub

    Sub ClearFees()
        ' This procedure resets the summary.
        lblServicesAndLabel.Text = String.Empty
        lblParts.Text = String.Empty
        lblTaxOnParts.Text = String.Empty
        lblTotalFees.Text = String.Empty
    End Sub
End Class
