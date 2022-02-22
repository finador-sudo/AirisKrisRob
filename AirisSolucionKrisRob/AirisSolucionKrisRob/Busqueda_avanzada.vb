Imports System.Data.OleDb



Public Class Busqueda_avanzada

    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=airis_db.accdb")
    Public auxDataset As New DataSet
    Public preparedStatement As New OleDbCommand
    Public miAdapter As New OleDbDataAdapter


    Private Sub Busqueda_avanzada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan_categorias.Hide()
        pan_empleados.Hide()
    End Sub

    Private Sub cb_tablas_SelectedIndexChanged(sender As Object, e As EventArgs)
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

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)
        Select Case cb_tablas.Text
            Case "Clientes"
                Dim _id_clientes As String = tb_id_clientes.Text
                Dim _clie_nom As String = tb_nombre_clientes.Text
                Dim _clie_ape1 As String = tb_ape1_clientes.Text
                Dim _clie_ape2 As String = tb_ape2_clientes.Text
                Dim _clie_telefono As String = tb_telefono_clientes.Text
                Dim _emp_nom As String = tb_empleado_id_clientes.Text

                'Dim preparedStatement As New OleDbCommand(("select * from clientes where clie_id = ? and clie_nom = ? and clie_ape1 = ? and clie_ape2 = ? and clie_telefono = ? and emp_id = ?"), conexion)
                Dim preStateClientes As New OleDbCommand(("select clientes.clie_id,clientes.clie_nom,clientes.clie_ape1,clientes.clie_ape2,clientes.clie_telefono,empleados.emp_nom
                    FROM clientes,empleados WHERE
                    clientes.emp_id = empleados.emp_id and (clie_id LIKE @clie_id) and (clie_nom LIKE @clie_nom) and (clie_ape1 LIKE @clie_ape1) and (clie_ape2 LIKE @clie_ape2) and (clie_telefono LIKE @clie_telefono) and (empleados.emp_nom LIKE @emp_nom)"), conexion)
                preStateClientes.Parameters.AddWithValue("@clie_id", If(_id_clientes = "", "%", _id_clientes))
                preStateClientes.Parameters.AddWithValue("@clie_nom", If(_clie_nom = "", "%", "%" + _clie_nom + "%"))
                preStateClientes.Parameters.AddWithValue("@clie_ape1", If(_clie_ape1 = "", "%", "%" + _clie_ape1 + "%"))
                preStateClientes.Parameters.AddWithValue("@clie_ape2", If(_clie_ape2 = "", "%", "%" + _clie_ape2 + "%"))
                preStateClientes.Parameters.AddWithValue("@clie_telefono", If(_clie_telefono = "", "%", "%" + _clie_telefono + "%"))
                preStateClientes.Parameters.AddWithValue("@emp_nom", If(_emp_nom = "", "%", "%" + _emp_nom + "%"))
                miAdapter.SelectCommand = preStateClientes
                auxDataset.Clear()
                miAdapter.Fill(auxDataset, "busquedaCliente")
                dg_busqueda.DataSource = auxDataset
                dg_busqueda.DataMember = "busquedaCliente"

            Case "Productos"
                Dim _prod_id As String = tb_id_productos.Text
                Dim _prod_nom As String = tb_nombre_productos.Text
                Dim _precio As String = tb_precio_productos.Text
                Dim _categoria As String = tb_categoria_id_productos.Text
                Dim _stock As String = tb_stock_productos.Text
                Dim _marca As String = tb_marca_productos.Text

                Dim preStateProductos As New OleDbCommand(("select productos.prod_id,productos.prod_nom,productos.precio,productos.prod_stock,productos.prod_marca,categorias_prod.cat_nom
                        FROM productos, categorias_prod where categorias_prod.cat_id = productos.cat_id and 
                        (productos.prod_id LIKE @prod_id) and (productos.prod_nom LIKE @prod_nom) and (productos.precio LIKE @precio) and (productos.prod_stock LIKE @stock) AND (productos.prod_marca LIKE @marca) AND (categorias_prod.cat_nom LIKE @categoria)"), conexion)
                preStateProductos.Parameters.AddWithValue("@prod_id", If(_prod_id = "", "%", _prod_id))
                preStateProductos.Parameters.AddWithValue("@prod_nom", If(_prod_nom = "", "%", "%" + _prod_nom + "%"))
                preStateProductos.Parameters.AddWithValue("@precio", If(_precio = "", "%", _precio))
                preStateProductos.Parameters.AddWithValue("@stock", If(_stock = "", "%", _stock))
                preStateProductos.Parameters.AddWithValue("@marca", If(_marca = "", "%", "%" + _marca + "%"))
                preStateProductos.Parameters.AddWithValue("@categoria", If(_categoria = "", "%", "%" + _categoria + "%"))

                miAdapter.SelectCommand = preStateProductos
                auxDataset.Clear()
                miAdapter.Fill(auxDataset, "busquedaProducto")
                dg_busqueda.DataSource = auxDataset
                dg_busqueda.DataMember = "busquedaProducto"

            Case "Provedores"
                Dim _pro_id As String = tb_id_provedores.Text
                Dim _pro_nom As String = tb_nombre_provedores.Text
                Dim _pro_dir As String = tb_direccion_provedores.Text
                Dim _pro_telefono As String = tb_telefono_provedores.Text

                Dim preStateProv As New OleDbCommand(("SELECT * FROM proveedores 
                WHERE (pro_id LIKE @pro_id) AND (pro_nom LIKE @pro_nom) AND (pro_dir LIKE @pro_dir) AND (pro_telefono LIKE @pro_telefono)"), conexion)

                preStateProv.Parameters.AddWithValue("@pro_id", If(_pro_id = "", "%", _pro_id))
                preStateProv.Parameters.AddWithValue("@pro_nom", If(_pro_nom = "", "%", _pro_nom))
                preStateProv.Parameters.AddWithValue("@pro_dir", If(_pro_telefono = "", "%", _pro_dir))
                preStateProv.Parameters.AddWithValue("@pro_telefono", If(_pro_telefono = "", "%", _pro_telefono))

                miAdapter.SelectCommand = preStateProv
                auxDataset.Clear()
                miAdapter.Fill(auxDataset, "busquedaProveedores")
                dg_busqueda.DataSource = auxDataset
                dg_busqueda.DataMember = "busquedaProveedores"

            Case "Roles"
                Dim _rol_id As String = tb_rol_id_emple.Text
                Dim _rol_nom As String = tb_rol_nombre.Text

                Dim preStateRoles As New OleDbCommand(("select * from roles where (rol_id LIKE @rol_id) and (rol_nom LIKE @rol_nom)"), conexion)
                preStateRoles.Parameters.AddWithValue("@rol_id", If(_rol_id = "", "%", _rol_id))
                preStateRoles.Parameters.AddWithValue("@rol_nom", If(_rol_nom = "", "%", "%" + _rol_nom + "%"))

                miAdapter.SelectCommand = preStateRoles
                auxDataset.Clear()
                miAdapter.Fill(auxDataset, "busquedaRol")
                dg_busqueda.DataSource = auxDataset
                dg_busqueda.DataMember = "busquedaRol"

            Case "Categorias de producto"
                Dim _cat_id As String = tb_id_cat.Text
                Dim _cat_nom As String = tb_nom_cat.Text

                Dim preStateCatProd As New OleDbCommand(("select * from categorias_prod where (cat_id LIKE @cat_id) and (cat_nom LIKE @cat_nom)"), conexion)
                preStateCatProd.Parameters.AddWithValue("@cat_id", If(_cat_id = "", "%", _cat_id))
                preStateCatProd.Parameters.AddWithValue("@cat_nom", If(_cat_nom = "", "%", "%" + _cat_nom + "%"))
                miAdapter.SelectCommand = preStateCatProd
                auxDataset.Clear()
                miAdapter.Fill(auxDataset, "busquedaCategoria")
                dg_busqueda.DataSource = auxDataset
                dg_busqueda.DataMember = "busquedaCategoria"

            Case "Empleados"

        End Select
    End Sub

    Private Sub lbl_id_empleado_clientes_Click(sender As Object, e As EventArgs)

    End Sub
End Class