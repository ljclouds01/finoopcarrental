Public Class CarHondaCivic
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Honda Civic"
        SessionModule.selectedCarRate = 3000
        SessionModule.selectedCarId = 6

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub CarHondaCivic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarAvailability()
        AddHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub CarRented_Handler(sender As Object, e As EventArgs)
        RefreshCarAvailability()
    End Sub

    Private Sub RefreshCarAvailability()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Honda Civic", btnRent)
    End Sub

    Private Sub CarHondaCivic_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler CarRented, AddressOf CarRented_Handler
    End Sub
End Class