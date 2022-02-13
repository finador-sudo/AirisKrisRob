Public Class inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan_inicio.Hide()
    End Sub

    Private Sub pan_presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        pan_inicio.Show()
    End Sub

    Private Sub pan_presentacion_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        pan_inicio.Show()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

    End Sub
End Class
