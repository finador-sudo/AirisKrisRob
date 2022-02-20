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
        dg_roles.DataMember = "Tabla_roles"

        dg_clientes.DataSource = dataset_clientes
        dg_clientes.DataMember = "Tabla_clientes"

        dg_proveedores.DataSource = dataset_proveedores
        dg_proveedores.DataMember = "Tabla_proveedores"

        dg_productos.DataSource = dataset_productos
        dg_productos.DataMember = "Tabla_productos"

        dg_categorias.DataSource = dataset_categoria_productos
        dg_categorias.DataMember = "Tabla_categoria_productos"

        tb_emple_id.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.emp_id")
        tb_emple_nom.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.emp_nom")
        tb_emple_ape1.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.emp_ape1")
        tb_emple_ape2.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.emp_ape2")
        tb_emple_rol.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.rol_id")
        tb_emple_tlf.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.emp_telefono")
        tb_emple_correo.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.emp_correo")
        tb_emple_usu.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.usuario")
        tb_emple_cont.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.password")

        tb_roles_id.DataBindings.Add("text", dataset_roles, "Tabla_roles.rol_id")
        tb_roles_rol.DataBindings.Add("text", dataset_roles, "Tabla_roles.rol_nom")

        tb_clientes_id.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.clie_id")
        tb_clientes_nombre.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.clie_nom")
        tb_clientes_ape1.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.clie_ape1")
        tb_clientes_ape2.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.clie_ape2")
        tb_clientes_telefono.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.clie_telefono")
        tb_clientes_empleadoID.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.emp_id")
        tb_clientes_direccion.DataBindings.Add("text", dataset_clientes, "Tabla_clientes.clie_dir")

        tb_proveedores_id.DataBindings.Add("text", dataset_proveedores, "Tabla_proveedores.pro_id")
        tb_proveedores_nombre.DataBindings.Add("text", dataset_proveedores, "Tabla_proveedores.pro_nom")
        tb_proveedores_direccion.DataBindings.Add("text", dataset_proveedores, "Tabla_proveedores.pro_dir")
        tb_proveedores_telefono.DataBindings.Add("text", dataset_proveedores, "Tabla_proveedores.pro_telefono")
        tb_proveedores_contacto.DataBindings.Add("text", dataset_proveedores, "Tabla_proveedores.pro_contacto")

        tb_productos_id.DataBindings.Add("text", dataset_productos, "Tabla_productos.prod_id")
        tb_productos_nombre.DataBindings.Add("text", dataset_productos, "Tabla_productos.prod_nom")
        tb_productos_precio.DataBindings.Add("text", dataset_productos, "Tabla_productos.precio")
        tb_productos_categoriaID.DataBindings.Add("text", dataset_productos, "Tabla_productos.cat_id")
        tb_productos_stock.DataBindings.Add("text", dataset_productos, "Tabla_productos.prod_stock")
        tb_productos_descripccion.DataBindings.Add("text", dataset_productos, "Tabla_productos.prod_descrip")
        tb_productos_marca.DataBindings.Add("text", dataset_productos, "Tabla_productos.prod_marca")

        tb_categorias_id.DataBindings.Add("text", dataset_categoria_productos, "Tabla_categoria_productos.cat_id")
        tb_categorias_nombre.DataBindings.Add("text", dataset_categoria_productos, "Tabla_categoria_productos.cat_nom")
        tb_categorias_descripccion.DataBindings.Add("text", dataset_categoria_productos, "Tabla_categoria_productos.cat_descrip")



    End Sub


    Private Sub ts_volver_Click(sender As Object, e As EventArgs) Handles ts_volver.Click
        inicio.Show()
        Me.Close()

    End Sub

    Private Sub ts_volverimg_Click(sender As Object, e As EventArgs) Handles ts_volverimg.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub ts_busqueda_Click(sender As Object, e As EventArgs) Handles ts_busqueda.Click
        Busqueda_avanzada.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub tb_proveedores_Click(sender As Object, e As EventArgs) Handles tb_proveedores.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles lbl_empleados_password.Click

    End Sub

    Private Sub tab_productos_Click(sender As Object, e As EventArgs) Handles tab_productos.Click

    End Sub
End Class