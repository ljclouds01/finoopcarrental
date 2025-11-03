Imports MySql.Data.MySqlClient
Public Class RentalForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Private Sub CaculateTotalCost()
        If dtpEndDate.Value.Date < dtpStartDate.Value.Date Then
            txtTotalCost.Text = "Invalid"
            Exit Sub
        End If

        Dim days As Integer = (dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days + 1
        Dim rate As Decimal
        Decimal.TryParse(txtPrice.Text, rate)

        Dim total As Decimal = days * rate
        txtTotalCost.Text = total.ToString("N2")

    End Sub
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Selected Car ID: " & SessionModule.selectedCarId)
        CaculateTotalCost()
        txtCustomersName.Text = SessionModule.LoggedInName
        txtContactNumber.Text = SessionModule.LoggedInContact
        txtAddress.Text = SessionModule.LoggedInAddress

        txtCarModel.Text = SessionModule.selectedCarModel
        txtPrice.Text = SessionModule.selectedCarRate.ToString("N2")

        txtCustomersName.ReadOnly = True
        txtContactNumber.ReadOnly = True
        txtAddress.ReadOnly = True
        txtCarModel.ReadOnly = True
        txtPrice.ReadOnly = True
        txtTotalCost.ReadOnly = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        CaculateTotalCost()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        CaculateTotalCost()
    End Sub

    Private Sub rentBtn_Click(sender As Object, e As EventArgs) Handles rentBtn.Click

        Dim carID As Integer = SessionModule.selectedCarId
        Dim name As String = txtCustomersName.Text
        Dim contact As String = txtContactNumber.Text
        Dim address As String = txtAddress.Text
        Dim carModel As String = txtCarModel.Text
        Dim startDate As Date = dtpStartDate.Value.Date
        Dim endDate As Date = dtpEndDate.Value.Date
        Dim price As Decimal = txtPrice.Text
        Dim totalCost As Decimal = txtTotalCost.Text
        Dim status As String = "Rented"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO rental (car_id, customer_name, contact_number, address, car_model, start_date, end_date, price, total_cost, status)
                       VALUES (@car_id, @customer_name, @contact_number, @address, @car_model, @start_date, @end_date, @price, @total_cost, @status)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@car_id", SessionModule.selectedCarId)
                    cmd.Parameters.AddWithValue("@customer_name", name)
                    cmd.Parameters.AddWithValue("@contact_number", contact)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@car_model", carModel)
                    cmd.Parameters.AddWithValue("@start_date", startDate)
                    cmd.Parameters.AddWithValue("@end_date", endDate)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@total_cost", totalCost)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using

                Dim updateQuery As String = "UPDATE cars set stock = stock - 1 where id = @id"
                Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                    cmdUpdate.Parameters.AddWithValue("@id", SessionModule.selectedCarId)
                    cmdUpdate.ExecuteNonQuery()
                End Using


                MessageBox.Show("Car rented successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub
End Class