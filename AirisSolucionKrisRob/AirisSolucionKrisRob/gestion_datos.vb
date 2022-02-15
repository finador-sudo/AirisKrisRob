Imports System.Data.OleDb


Public Class gestion_datos
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=././BBDD/airis_db.accdb")
    Public adaptador_roles As New OleDbDataAdapter("Select * from roles", conexion)
    Public adaptador_empleados As New OleDbDataAdapter("Select * from empleados", conexion)
    Public adaptador_clientes As New OleDbDataAdapter("Select * from clientes", conexion)
    Public adaptador_proveedores As New OleDbDataAdapter("Select * from proveedores", conexion)
    Public adaptador_productos As New OleDbDataAdapter("Select * from productos", conexion)
    Public adaptador_categoria_productos As New OleDbDataAdapter("Select * from categorias_prod", conexion)

    Public dataset_roles As New DataSet
    Public dataset_empleados As New DataSet
    Public dataset_clientes As New DataSet
    Public dataset_proveedores As New DataSet
    Public dataset_productos As New DataSet
    Public dataset_categoria_productos As New DataSet

    Private Sub gestion_datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador_roles.Fill(dataset_roles, "Tabla_roles")
        adaptador_empleados.Fill(dataset_empleados, "Tabla_empleados")
        adaptador_clientes.Fill(dataset_clientes, "Tabla_clientes")
        adaptador_proveedores.Fill(dataset_proveedores, "Tabla_proveedores")
        adaptador_productos.Fill(dataset_productos, "Tabla_productos")
        adaptador_categoria_productos.Fill(dataset_categoria_productos, "Tabla_categoria_productos")

        dg_emple.DataSource = dataset_empleados
        dg_emple.DataMember = "Tabla_empleados"

        dg_roles.DataSource = dataset_roles
        dg_roles.DataSource = "Tabla_roles"






    End Sub


    Private Sub ts_volver_Click(sender As Object, e As EventArgs) Handles ts_volver.Click
        inicio.Show()
        Me.Close()

    End Sub

    Private Sub ts_volverimg_Click(sender As Object, e As EventArgs) Handles ts_volverimg.Click
        inicio.Show()
        Me.Close()
    End Sub

End Class