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
End Class
