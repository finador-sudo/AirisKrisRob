Public Class Informe

    Private Sub Informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gestion_datos.c = 1 Then
            Dim objClie As New Clientes
            CrystalReportViewer1.ReportSource = objClie
        Else
            Dim objProd As New Productos
            CrystalReportViewer1.ReportSource = objProd
        End If
    End Sub
End Class