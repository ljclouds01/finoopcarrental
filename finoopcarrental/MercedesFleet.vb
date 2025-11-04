Public Class MercedesFleet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using mercedezForm As New MercedesBenz()
            mercedezForm.ShowDialog()
        End Using
    End Sub
End Class