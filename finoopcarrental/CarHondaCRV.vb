Public Class CarHondaCRV
    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Honda CRV"
        SessionModule.selectedCarRate = 4000
        SessionModule.selectedCarId = 7

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CarHondaCRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarAvailability()
        AddHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub CarRented_Handler(sender As Object, e As EventArgs)
        RefreshCarAvailability()
    End Sub

    Private Sub RefreshCarAvailability()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Honda CRV", btnRent)
        CheckCarAvailabilityReserved(connectionString, "Honda CRV", reserveBtn)
    End Sub

    Private Sub CarHondaCRV_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles reserveBtn.Click
        SessionModule.selectedCarModel = "Honda CRV"
        SessionModule.selectedCarRate = 4000
        SessionModule.selectedCarId = 7

        Dim reservationForm As New ReservedForm()
        reservationForm.Show()
    End Sub
End Class