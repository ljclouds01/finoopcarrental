Public Class UserDashboard
    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim userDashboard As New UserDashboardPage2()
        UserDashboardPage2.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Vios.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MIRAGE.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        KIA.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AVANZA.Show()
        Me.Close()
    End Sub
End Class