Public Class Vios
    Public Property LoggedInName As String
    Public Property LoggedInContact As String
    Public Property LoggedInAddress As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        SessionModule.selectedCarModel = "Toyota Vios"
        SessionModule.selectedCarRate = 1800
        SessionModule.selectedCarId = 1

        Dim rentalForm As New RentalForm()
        rentalForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles reserveBtn.Click
        SessionModule.selectedCarModel = "Toyota Vios"
        SessionModule.selectedCarRate = 1800
        SessionModule.selectedCarId = 1

        Dim reservedForm As New ReservedForm()
        reservedForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Vios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarAvailability()
        AddHandler CarRented, AddressOf CarRented_Handler
    End Sub

    Private Sub CarRented_Handler(sender As Object, e As EventArgs)
        RefreshCarAvailability()
    End Sub

    Private Sub RefreshCarAvailability()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=car_rental"
        CheckCarAvailability(connectionString, "Toyota Vios", btnRent)
        CheckCarAvailabilityReserved(connectionString, "Toyota Vios", reserveBtn)
    End Sub

    Private Sub Vios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler CarRented, AddressOf CarRented_Handler
    End Sub
End Class