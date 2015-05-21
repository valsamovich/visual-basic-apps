Public Class Form1
    ' Valery Samovich
    Private Sub btnDisplayDirections_Click(sender As Object, e As EventArgs) Handles btnDisplayDirections.Click
        ' Make the directions visible.
        lblDirections.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
