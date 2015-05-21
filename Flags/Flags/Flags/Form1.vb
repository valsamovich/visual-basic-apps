Public Class Form1
    ' Valery Samovich
    Private Sub picUSA_Click(sender As Object, e As EventArgs) Handles picUSA.Click
        ' Display United States of America.
        lblMessage.Text = "United States of America"
    End Sub

    Private Sub picCanada_Click(sender As Object, e As EventArgs) Handles picCanada.Click
        ' Display Canada.
        lblMessage.Text = "Canada"
    End Sub

    Private Sub picUK_Click(sender As Object, e As EventArgs) Handles picUK.Click
        ' Display United Kingdom.
        lblMessage.Text = "United Kingdom"
    End Sub

    Private Sub picAustralia_Click(sender As Object, e As EventArgs) Handles picAustralia.Click
        ' Display Australia.
        lblMessage.Text = "Australia"
    End Sub

    Private Sub picBrazil_Click(sender As Object, e As EventArgs) Handles picBrazil.Click
        ' Display Brazil.
        lblMessage.Text = "Brazil"
    End Sub

    Private Sub picItaly_Click(sender As Object, e As EventArgs) Handles picItaly.Click
        ' Display Italy.
        lblMessage.Text = "Italy"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
