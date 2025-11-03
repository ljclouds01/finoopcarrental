Imports MySql.Data.MySqlClient
Public Class AdminDashboard
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"

    Private Sub FormatGridView(dgv As DataGridView)
        With dgv
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .ReadOnly = True
            .MultiSelect = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .EnableHeadersVisualStyles = False
        End With
    End Sub

    Private Sub LoadAvailableCars()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT car_model AS 'Car Model', plateNumber AS 'Plate No.', color AS 'Color' FROM cars WHERE stock > 0"
                Using adapter As New MySqlDataAdapter(query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvAvailable.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading available cars: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadRentedCars()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT c.car_model AS 'Car Model', c.plateNumber AS 'Plate No.', c.color AS 'Color' FROM rental r JOIN cars c ON r.car_id = c.id WHERE r.status = 'Rented'"
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvRented.DataSource = table
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatGridView(dgvAvailable)
        FormatGridView(dgvRented)
        LoadAvailableCars()
        LoadRentedCars()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        AdminPendings.Show()
        Me.Close()
    End Sub

    Private Sub btnCustomerAcc_Click(sender As Object, e As EventArgs) Handles btnCustomerAcc.Click
        AdminCustomerAcc.Show()
        Me.Close()
    End Sub

    Private Sub dgvAvailable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellContentClick

    End Sub

    Private Sub dgvRented_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRented.CellContentClick

    End Sub
End Class