Public Class ReservedForm
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

        Dim downPayment As Decimal = Decimal.Parse(txtTotalCost.Text) * 0.5D
        txtDownPayment.Text = downPayment.ToString("N2")

    End Sub
    Private Sub ReservedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        CaculateTotalCost()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        CaculateTotalCost()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles reserveBtn.Click

    End Sub
End Class