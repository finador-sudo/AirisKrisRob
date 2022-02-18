Imports System.Data.OleDb



Public Class Busqueda_avanzada

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

    Private Sub Busqueda_avanzada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan_categorias.Hide()
        pan_empleados.Hide()
        Console.Write("Hola mundo")
    End Sub

    Private Sub cb_tablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tablas.SelectedIndexChanged
        Select Case cb_tablas.Text
            Case "Clientes"
                pan_roles.Hide()
                pan_categorias.Hide()
                pan_clientes.Show()
                pan_empleados.Hide()
                pan_productos.Hide()
                pan_provedores.Hide()
            Case "Productos"
                pan_roles.Hide()
                pan_categorias.Hide()
                pan_clientes.Hide()
                pan_empleados.Hide()
                pan_productos.Show()
                pan_provedores.Hide()
            Case "Provedores"
                pan_roles.Hide()
                pan_categorias.Hide()
                pan_clientes.Hide()
                pan_empleados.Hide()
                pan_productos.Hide()
                pan_provedores.Show()
            Case "Roles"
                pan_roles.Show()
                pan_categorias.Hide()
                pan_clientes.Hide()
                pan_empleados.Hide()
                pan_productos.Hide()
                pan_provedores.Hide()
            Case "Categorias de producto"
                pan_roles.Hide()
                pan_categorias.Show()
                pan_clientes.Hide()
                pan_empleados.Hide()
                pan_productos.Hide()
                pan_provedores.Hide()
            Case "Empleados"
                pan_roles.Hide()
                pan_categorias.Hide()
                pan_clientes.Hide()
                pan_empleados.Show()
                pan_productos.Hide()
                pan_provedores.Hide()
        End Select
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Select Case cb_tablas.Text
            Case "Clientes"
                Console.Write("BuscarCliente")
                Dim cb As New OleDbDataAdapter("select * from clientes", conexion)
                Dim ds As New DataSet
                Dim _id_clientes As String = tb_id_clientes.Text
                Dim _clie_nom As String = tb_nombre_clientes.Text
                Dim _clie_ape1 As String = tb_ape1_clientes.Text
                Dim _clie_ape2 As String = tb_ape2_clientes.Text
                Dim _clie_telefono As String = tb_telefono_clientes.Text
                Dim _emp_id As String = tb_empleado_id_clientes.Text

                'Dim preparedStatement As New OleDbCommand(("select * from clientes where clie_id = ? and clie_nom = ? and clie_ape1 = ? and clie_ape2 = ? and clie_telefono = ? and emp_id = ?"), conexion)
                Dim preparedStatement As New OleDbCommand(("select * from clientes"), conexion)
                'preparedStatement.Parameters.AddWithValue("clie_id", _id_clientes)
                'preparedStatement.Parameters.AddWithValue("clie_id", If(_id_clientes = "", "%", _id_clientes))
                'preparedStatement.Parameters.AddWithValue("clie_nom", _clie_nom)
                'preparedStatement.Parameters.AddWithValue("clie_nom", If(_clie_nom = "", "%", _clie_nom))
                'preparedStatement.Parameters.AddWithValue("clie_ape1", _clie_ape1)
                'preparedStatement.Parameters.AddWithValue("clie_ape1", If(_clie_ape1 = "", "%", _clie_ape1))
                'preparedStatement.Parameters.AddWithValue("clie_ape2", _clie_ape2)
                'preparedStatement.Parameters.AddWithValue("clie_ape2", If(_clie_ape2 = "", "%", _clie_ape2))
                'preparedStatement.Parameters.AddWithValue("clie_telefono", _clie_telefono)
                'preparedStatement.Parameters.AddWithValue("clie_telefono", If(_clie_telefono = "", "%", _clie_telefono))
                'preparedStatement.Parameters.AddWithValue("emp_id", _emp_id)
                'preparedStatement.Parameters.AddWithValue("emp_id", If(_emp_id = "", "%", _emp_id))
                conexion.Open()
                preparedStatement.ExecuteNonQuery()
                cb.SelectCommand = preparedStatement
                ds.Clear()
                cb.Fill(ds, "busquedaCliente")
                dg_busqueda.DataSource = ds


            Case "Productos"

            Case "Provedores"

            Case "Roles"

            Case "Categorias de producto"

            Case "Empleados"

        End Select
    End Sub
End Class