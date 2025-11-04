Public Class ToyotaFleet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using viosForm As New Vios()
            viosForm.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using avanzaForm As New AVANZA()
            avanzaForm.ShowDialog()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using landCruiserForm As New CarLandCruiser()
            landCruiserForm.ShowDialog()
        End Using
    End Sub

    Private Sub ToyotaFleet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class