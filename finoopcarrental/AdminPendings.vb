Imports MySql.Data.MySqlClient
Public Class AdminPendings
    Dim connectionString As String = "server=localhost;userid=root;password=;database=car_rental"
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub AdminPendings_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnCustomerAcc_Click(sender As Object, e As EventArgs) Handles btnCustomerAcc.Click
        AdminCustomerAcc.Show()
        Me.Close()
    End Sub

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

    Private Sub SetupCustomHeaderDataGridView()
        dgvPendings.RowHeadersVisible = False
        dgvPendings.ColumnHeadersVisible = False
        dgvPendings.AutoGenerateColumns = False

        dgvPendings.Columns.Clear()

        Dim columns As New List(Of DataGridViewColumn) From {
            New DataGridViewTextBoxColumn() With {.Name = "CustomerName", .DataPropertyName = "customer_name", .Width = 150},
            New DataGridViewTextBoxColumn() With {.Name = "CarModel", .DataPropertyName = "car_model", .Width = 150},
            New DataGridViewTextBoxColumn() With {.Name = "StartDate", .DataPropertyName = "start_date", .Width = 110},
            New DataGridViewTextBoxColumn() With {.Name = "EndDate", .DataPropertyName = "end_date", .Width = 110},
            New DataGridViewTextBoxColumn() With {.Name = "Payment", .DataPropertyName = "payment_type", .Width = 90},
            New DataGridViewTextBoxColumn() With {.Name = "Status", .DataPropertyName = "status", .Width = 90}
        }

        For Each col In columns
            dgvPendings.Columns.Add(col)
        Next

        dgvPendings.BackgroundColor = Color.White
        dgvPendings.BorderStyle = BorderStyle.None
        dgvPendings.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgvPendings.RowTemplate.Height = 35
        dgvPendings.ReadOnly = True
        dgvPendings.AllowUserToAddRows = False
        dgvPendings.AllowUserToDeleteRows = False

        dgvPendings.GridColor = Color.LightGray
        dgvPendings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        dgvPendings.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        dgvPendings.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240)
        dgvPendings.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvPendings.DefaultCellStyle.Padding = New Padding(5)
        dgvPendings.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AdminPendings_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupCustomHeaderDataGridView()
        LoadAvailableCars()
        LoadRentedCars()
        LoadReservedCars()
    End Sub

    Private Sub LoadAvailableCars()
        lblAvailable.Text = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM cars WHERE stock > 0"
                Using cmd As New MySqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblAvailable.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading available cars: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadRentedCars()
        lblRented.Text = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM rental WHERE status = 'Rented' "
                Using cmd As New MySqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblRented.Text = count.ToString()
                End Using

                Dim query2 As String = "SELECT customer_name, car_model, start_date, end_date, payment_type, status FROM rental ORDER BY start_date DESC"
                Using adapter As New MySqlDataAdapter(query2, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvPendings.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading rented cars: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadReservedCars()
        lblReserved.Text = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM rental WHERE status = 'Reserved' "
                Using cmd As New MySqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblReserved.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblAvailable_Click(sender As Object, e As EventArgs) Handles lblAvailable.Click

    End Sub

    Private Sub dgvPendings_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub dgvPendings_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendings.CellContentClick

    End Sub
End Class