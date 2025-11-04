Public Class AVANZA
    Public Property LoggedInName As String
    Public Property LoggedInContact As String
    Public Property LoggedInAddress As String

    Private Sub AVANZA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarAvailability()
        AddHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Toyota Avanza"
        SessionModule.selectedCarRate = 3000
        SessionModule.selectedCarId = 4

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles reserveBtn.Click
        SessionModule.selectedCarModel = "Toyota Avanza"
        SessionModule.selectedCarRate = 3000
        SessionModule.selectedCarId = 4

        Dim reservationForm As New ReservedForm()
        reservationForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CarRented_Handler(sender As Object, e As EventArgs)
        RefreshCarAvailability()
    End Sub

    Private Sub RefreshCarAvailability()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Toyota Avanza", btnRent)
        CheckCarAvailabilityReserved(connectionString, "Toyota Avanza", reserveBtn)
    End Sub
    Private Sub AVANZA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
End Class