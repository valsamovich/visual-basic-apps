Public Class Form1
    ' Class-level declarations
    Const decTAX_RATE As Decimal = 0.06D        ' Tax rate
    Const decWHITE_BAGEL As Decimal = 1.25D     ' Cost of a white bagel
    Const decWHEAT_BAGEL As Decimal = 1.5D      ' Cost of a whole wheat bagel
    Const decCREAM_CHEESE As Decimal = 0.5D     ' Cost of cream cheese topping
    Const decBUTTER As Decimal = 0.25D          ' Cost of butter topping
    Const decBLUEBERRY As Decimal = 0.75D       ' Cost of blueberry topping
    Const decRASPBERRY As Decimal = 0.75D       ' Cost of raspberry topping
    Const decPEACH As Decimal = 0.75D           ' Cost of peach topping
    Const decREG_COFFEE As Decimal = 1.25D      ' Cost of regular coffee
    Const decCAPPUCCINO As Decimal = 2D         ' Cost of cappuccino
    Const decCAFE_AU_LAIT As Decimal = 1.75D    ' Cost of Cafe au lait

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This procedure calculates the total of an order.
        Dim decSubtotal As Decimal  ' Holds the order subtotal
        Dim decTax As Decimal       ' Holds the sales tax
        Dim decTotal As Decimal     ' Holds the order total

        decSubtotal = CalcBagelCost() + CalcToppingCost() CalcCoffeeCost()
        decTax = CalcTax(decSubtotal)
        decTotal = decSubtotal + decTax

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' This procedure resets the controls to default values.
        ResetBagels()
        ResetToppings()
        ResetCoffee()
        ResetPrice()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
