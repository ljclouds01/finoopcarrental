Public Class AVANZA
    Public Property LoggedInName As String
    Public Property LoggedInContact As String
    Public Property LoggedInAddress As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReservedForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserDashboard.Show()
        Me.Close()
    End Sub

    Private Sub AVANZA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class