Public Class KiaFleet
    Private Sub KiaFleet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using kiaForm As New KIA()
            kiaForm.ShowDialog()
        End Using
    End Sub
End Class