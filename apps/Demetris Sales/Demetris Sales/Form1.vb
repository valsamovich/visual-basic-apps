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

    End Sub
End Class
