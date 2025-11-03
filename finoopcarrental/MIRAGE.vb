Public Class MIRAGE
    Public Property LoggedInName As String
    Public Property LoggedInContact As String
    Public Property LoggedInAddress As Strings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Mitsubishi Mirage"
        SessionModule.selectedCarRate = 1500
        SessionModule.selectedCarId = 2

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReservedForm.Show()
    End Sub

    Private Sub MIRAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Mitsubishi Mirage", btnRent)
    End Sub
End Class