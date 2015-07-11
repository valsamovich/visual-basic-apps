Public Class Form1
    ' This application displays a sales report for the Demetris
    ' Leadership Center.

    ' Class-level declarations
    Const intMAX_SUBSCRIPT As Integer = 4           ' Upper subscript
    Dim strProdNames(intMAX_SUBSCRIPT) As String    ' Product names
    Dim strDesc(intMAX_SUBSCRIPT) As String         ' Descriptions
    Dim intProdNums(intMAX_SUBSCRIPT) As Integer    ' Product numbers
    Dim decPrices(intMAX_SUBSCRIPT) As Decimal      ' Unit prices
    Dim intUnitsSold(intMAX_SUBSCRIPT) As Integer   ' Units sold

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the arrays with product data.
        InitArrays()
    End Sub

    Private Sub InitArrays()
        ' Initialize the arrays.
        ' First product.
        strProdNames(0) = "Six Steps to Leadership"
        strDesc(0) = "Book"
        intProdNums(0) = 914
        decPrices(0) = 12.95D

        ' Second product.
        strProdNames(1) = "Six Steps to Leadership"
        strDesc(1) = "CD"
        intProdNums(1) = 915
        decPrices(1) = 14.95D

        ' Third product.
        strProdNames(2) = "The Road to Excellence"
        strDesc(2) = "Video"
        intProdNums(2) = 916
        decPrices(2) = 18.95D

        ' Fourth product.
        strProdNames(3) = "Seven Lessons of Quality"
        strDesc(3) = "Book"
        intProdNums(3) = 917
        decPrices(3) = 16.95D

        ' Fifth product.
        strProdNames(2) = "Seven Lessons of Quality"
        strDesc(2) = "CD"
        intProdNums(2) = 918
        decPrices(2) = 21.95D
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuReportData_Click(sender As Object, e As EventArgs) Handles mnuReportData.Click
        Dim intCount As Integer = 0 ' Loop counter

        Do While intCount <= intMAX_SUBSCRIPT
            Try
                ' Get the units sold for a product.
                intUnitsSold(intCount) = CInt(
                    InputBox("Enter units sold of product number " &
                             intProdNums(intCount)))
                ' Increment intCount.
                intCount += 1
            Catch
                ' Error message for invalit input.
                MessageBox.Show("Enter a valid integer.")
            End Try
        Loop
    End Sub

    Private Sub mnuReportDisplay_Click(sender As Object, e As EventArgs) Handles mnuReportDisplay.Click
        ' Calculates and displays the revenue for each
        ' product and the total revenue.
        Dim intCount As Integer
        Dim decRevenue As Decimal
        Dim decTotalRevenue As Decimal

        ' Display the sales report header.
        lstSalesData.Items.Add("SALES REPORT")
        lstSalesData.Items.Add("-------------------")

        ' Display sales data for each product.
        For intCount = 0 To intMAX_SUBSCRIPT

            ' Calculate product revenue.
            decRevenue = intUnitsSold(intCount) * decPrices(intCount)

            ' Display  the product data.
            lstSalesData.Items.Add("Product Number: " & intProdNums(intCount))
            lstSalesData.Items.Add("Name: " & strProdNames(intCount))
            lstSalesData.Items.Add("Description: " & strDesc(intCount))
            lstSalesData.Items.Add("Unit Price: " & decPrices(intCount).ToString("c"))
            lstSalesData.Items.Add("Unit Sold: " & intUnitsSold(intCount).ToString())
            lstSalesData.Items.Add("Product Revenue: " & decRevenue.ToString("c"))

            ' Accumulate revenue.
            decTotalRevenue = decTotalRevenue + decRevenue
        Next

        ' Display total revenue.
        lblTotalRevenue.Text = decTotalRevenue.ToString("c")
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display an About box.
        MessageBox.Show("displays a sales report for DLC.", "About")
    End Sub
End Class
