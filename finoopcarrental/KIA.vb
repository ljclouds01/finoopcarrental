Public Class KIA
    Public Property LoggedInName As String
    Public Property LoggedInContact As String
    Public Property LoggedInAddress As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub KIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarAvailability()
        AddHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub CarRented_Handler(sender As Object, e As EventArgs)
        RefreshCarAvailability()
    End Sub

    Private Sub RefreshCarAvailability()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Kia EV9", btnRent)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Kia EV9"
        SessionModule.selectedCarRate = 5000
        SessionModule.selectedCarId = 3

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReservedForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub KIA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler CarRented, AddressOf CarRented_Handler
    End Sub
End Class