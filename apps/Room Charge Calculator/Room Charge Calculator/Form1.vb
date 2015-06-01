Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
