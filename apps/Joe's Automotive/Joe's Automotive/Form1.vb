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
        Dim decParts As Decimal             ' The parts cost
        Dim decLabor As Decimal             ' The labor hours
        Dim decServicesAndLabor As Decimal  ' Holds the total for services and labor
        Dim decTaxOnParts As Decimal        ' Holds the sales tax on parts
        Dim decTotal As Decimal             ' Holds the order total

        If PartsIsValid() And LaborIsValid() Then
            ' Get the parts cost.
            Decimal.TryParse(txtParts.Text, decParts)

            ' Get labor hours.
            Decimal.TryParse(txtLabor.Text, decLabor)

            ' Get the total for services and labor
            decServicesAndLabor = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges(decLabor)

            ' Get the taxes for parts
            decTaxOnParts = TaxCharges(decParts)

            ' Get the total charges.
            decTotal = TotalCharges(decServicesAndLabor, decParts, decTaxOnParts)

            ' Display the summary details, formatted as currency.
            lblServicesAndLabel.Text = decServicesAndLabor.ToString("c")
            lblParts.Text = decParts.ToString("c")
            lblTaxOnParts.Text = decTaxOnParts.ToString("c")
            lblTotalFees.Text = decTotal.ToString("c")
        End If
        
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

    Function PartsIsValid() As Boolean
        ' Declate a variable to temporary hold the parts value.
        Dim decPartsTempValue As Decimal

        ' Try to convert the value entered by the user to a Decimal.
        ' If it will not convert, display an error message and return false. 
        If Not Decimal.TryParse(txtParts.Text, decPartsTempValue) Then
            MessageBox.Show("Enter a numeric value for the parts cost.")
            Return False
        End If

        ' Determine whether the value entered is negative.
        ' If it is, display an error message and return false.
        If decPartsTempValue < 0 Then
            MessageBox.Show("Enter a positive numeric value for the parts cost.")
        End If

        ' If value is valid, return true.
        Return True
    End Function

    Function LaborIsValid() As Boolean
        ' Declate a variable to temporary hold the labor hours.
        Dim decLaborTempValue As Decimal

        ' Try to convert the value entered by the user to a Decimal.
        ' If it will not convert, display an error message and return false. 
        If Not Decimal.TryParse(txtLabor.Text, decLaborTempValue) Then
            MessageBox.Show("Enter a numeric value for the labor hours.")
            Return False
        End If

        ' Determine whether the value entered is negative.
        ' If it is, display an error message and return false.
        If decLaborTempValue < 0 Then
            MessageBox.Show("Enter a positive numeric value for the labor hours.")
        End If

        ' If value is valid, return true.
        Return True
    End Function

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

    Function OtherCharges(ByVal decLabor As Decimal) As Decimal
        ' This function returns the charge for labor.
        Dim decLaborCharge As Decimal
        decLaborCharge = decLabor * 20

        ' Return the labor charge.
        Return decLaborCharge
    End Function

    Function TaxCharges(ByVal decParts As Decimal) As Decimal
        ' This function receives the parts amount and return the amount of the sales tax.
        Return decParts * decTAX_RATE
    End Function

    Function TotalCharges(ByVal decServicesAndLabor As Decimal,
                          ByVal decParts As Decimal,
                          ByVal decTaxOnParts As Decimal) As Decimal
        ' This function returns the amount of the total charges.
        Return decServicesAndLabor + decParts + decTaxOnParts
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
