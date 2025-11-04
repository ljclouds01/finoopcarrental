Public Class MercedesBenz
    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Mercedes Benz C"
        SessionModule.selectedCarRate = 4000
        SessionModule.selectedCarId = 9

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MercedesBenz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarAvailability()
        AddHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub CarRented_Handler(sender As Object, e As EventArgs)
        RefreshCarAvailability()
    End Sub

    Private Sub RefreshCarAvailability()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Mercedes Benz C", btnRent)
        CheckCarAvailabilityReserved(connectionString, "Mercedes Benz C", reserveBtn)
    End Sub

    Private Sub MercedesBenz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles reserveBtn.Click
        SessionModule.selectedCarModel = "Mercedes Benz C"
        SessionModule.selectedCarRate = 4000
        SessionModule.selectedCarId = 9

        Dim reservationForm As New ReservedForm()
        reservationForm.Show()
    End Sub
End Class