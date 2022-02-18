Public Class inicio

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan_inicio.Hide()
        Busqueda_avanzada.Show()
    End Sub

    Private Sub pan_presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, pan_presentacion.KeyPress
        pan_inicio.Show()
    End Sub

    Private Sub pan_presentacion_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, pan_presentacion.MouseClick
        pan_inicio.Show()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Me.Hide()
        gestion_datos.Show()
    End Sub
End Class
