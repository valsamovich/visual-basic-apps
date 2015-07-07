' Written by Valery Samovich 
' July 7, 2015
Option Strict On
Option Explicit On

Public Class Form1
    ' Class-level declarations
    Const decTAX_RATE As Decimal = 0.06D            ' Tax rate on parts cost
    Const decOIL_CHANGE As Decimal = 26D            ' Cost of a oil change
    Const decLUBE_JOB As Decimal = 18D              ' Cost of lube job
    Const decRADIATOR_FLUSH As Decimal = 30D        ' Cost of radiator flush
    Const decTRANSMISSION_FLUSH As Decimal = 80D    ' Cost of transmission flush
    Const decINSPECTION As Decimal = 15D            ' Cost of inspection
    Const decMUFFLER_REPLACEMENT As Decimal = 100D  ' Cost of muffler replacement
    Const decTIRE_ROTATION As Decimal = 20D         ' Cost of tire rotation

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        ' This procedure calculates the total of an order.
        Dim decServicesAndLabor As Decimal  ' Holds the total of services and labor
        Dim decParts As Decimal             ' Holds the parts
        Dim decTaxOnParts As Decimal        ' Holds the sales tax
        Dim decTotal As Decimal             ' Holds the order total

        decServicesAndLabor = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()
        decParts = PartsCharge()
        decTaxOnParts = TaxCharges(decParts)
        decTotal = TotalCharges(decServicesAndLabor, decTaxOnParts, decParts)

        lblServicesAndLabel.Text = decServicesAndLabor.ToString("c")
        lblParts.Text = decParts.ToString("c")
        lblTaxOnParts.Text = decTaxOnParts.ToString("c")
        lblTotalFees.Text = decTotal.ToString("c")
    End Sub

    Function PartsInput() As Boolean
        ' Declaration to hold the part value.
        Dim decPartsInput As Decimal

        ' Validate parts input validation.
        If Not Decimal.TryParse(txtParts.Text, decPartsInput) Then
            MessageBox.Show("Enter a numeric value for parts charges.")
            Return False
        End If

        If decPartsInput < 0 Then
            MessageBox.Show("Enter a positive numeric value for parts charges.")
        End If

        Return True
    End Function

    Function LaborInput() As Boolean
        ' Declaration to hold the labor value.
        Dim decLaborInput As Decimal

        ' Validate labor input validation.
        If Not Decimal.TryParse(txtLabor.Text, decLaborInput) Then
            MessageBox.Show("Enter a numeric value for labor charges.")
            Return False
        End If

        If decLaborInput < 0 Then
            MessageBox.Show("Enter a positive numeric value for labor charges.")
        End If

        Return True
    End Function

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
        ' This function returns the cost for an oil & lube.
        Dim decCostOfOilLubeCharges As Decimal = 0D

        If chkOilChange.Checked = True Then
            decCostOfOilLubeCharges += decOIL_CHANGE
        End If

        If chkLubeJob.Checked = True Then
            decCostOfOilLubeCharges += decLUBE_JOB
        End If

        Return decCostOfOilLubeCharges
    End Function

    Function FlushCharges() As Decimal
        ' This function returns the cost for a flushes.
        Dim decCostOfFlushCharges As Decimal = 0D

        If chkRadiatorFlush.Checked = True Then
            decCostOfFlushCharges += decRADIATOR_FLUSH
        End If

        If chkTransmissionFlush.Checked = True Then
            decCostOfFlushCharges += decTRANSMISSION_FLUSH
        End If

        Return decCostOfFlushCharges
    End Function

    Function MiscCharges() As Decimal
        ' This function returns the cost for a misc charges. 
        Dim decCostOfMiscCharges As Decimal = 0D

        If chkInspection.Checked = True Then
            decCostOfMiscCharges += decINSPECTION
        End If

        If chkReplaceMuffler.Checked = True Then
            decCostOfMiscCharges += decMUFFLER_REPLACEMENT
        End If

        If chkTireRotation.Checked = True Then
            decCostOfMiscCharges += decTIRE_ROTATION
        End If

        Return decCostOfMiscCharges
    End Function

    Function PartsCharge() As Decimal
        ' This function returns the charge of parts.
        Dim decPartsCharge As Decimal
        decPartsCharge = CDec(txtParts.Text)

        Return decPartsCharge
    End Function

    Function OtherCharges() As Decimal
        ' This function returns the charge for labor.
        Dim decLaborCharge As Decimal
        decLaborCharge = CDec(txtLabor.Text)
        decLaborCharge *= 20

        Return decLaborCharge
    End Function

    Function TaxCharges(ByVal decAmount As Decimal) As Decimal
        ' This function receives the parts amount and return the amount of the sales tax.
        Return decAmount * decTAX_RATE
    End Function

    Function TotalCharges(ByVal decServicesAndLabor As Decimal,
                          ByVal decTaxOnParts As Decimal,
                          ByVal decParts As Decimal) As Decimal
        ' This function returns the amount of the total charges.
        Return decServicesAndLabor + decTaxOnParts + decParts
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
