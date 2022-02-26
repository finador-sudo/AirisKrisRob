Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class gestion_datos
    Public c As String
    'Conexion a la base de datos
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=airis_db.accdb")

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
        tb_emple_cont.DataBindings.Add("text", dataset_empleados, "Tabla_empleados.cont")

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

    Private Sub ts_volver_Click(sender As Object, e As EventArgs)
        inicio.Show()
        Me.Close()

    End Sub

    Private Sub ts_busqueda_Click(sender As Object, e As EventArgs) Handles ts_busqueda.Click
        Busqueda_avanzada.Show()
        Me.Hide()
    End Sub
    '-------------------------------------------------------------------------
    'TAB EMPLEADOS
    '-------------------------------------------------------------------------
    'BOTON NUEVO 
    Private Sub tslbl_nuevo_Click(sender As Object, e As EventArgs) Handles tslbl_nuevo.Click
        tb_emple_id.Text = ""
        tb_emple_rol.Text = ""
        tb_emple_usu.Text = ""
        tb_emple_cont.Text = ""
        tb_emple_nom.Text = ""
        tb_emple_ape1.Text = ""
        tb_emple_ape2.Text = ""
        tb_emple_tlf.Text = ""
        tb_emple_correo.Text = ""
    End Sub

    'BOTON ALTA 
    Private Sub tslbl_alta_empleados_Click(sender As Object, e As EventArgs) Handles tslbl_alta_empleados.Click, btn_emp_alta.Click, lbl_alta_empleados.Click
        If (tb_emple_id.Text = "") Then
            If Not (tb_emple_rol.Text = "" Or tb_emple_usu.Text = "" Or tb_emple_cont.Text = "" Or tb_emple_nom.Text = "" Or tb_emple_ape1.Text = "" Or tb_emple_ape2.Text = "" Or tb_emple_tlf.Text = "" Or tb_emple_correo.Text = "") Then
                'Todos los campos correctos
                Try
                    conexion.Open()
                    Dim empInsert As New OleDbCommand("INSERT INTO empleados (emp_nom,emp_ape1,emp_ape2,rol_id,emp_telefono,emp_correo,usuario,cont) VALUES (@nom,@ape,@ape2,@rol,@telefono,@mail,@usu,@pas)", conexion)
                    empInsert.Parameters.AddWithValue("@nom", tb_emple_nom.Text.Trim)
                    empInsert.Parameters.AddWithValue("@ape", tb_emple_ape1.Text.Trim)
                    empInsert.Parameters.AddWithValue("@ape2", tb_emple_ape2.Text.Trim)
                    empInsert.Parameters.AddWithValue("@rol", tb_emple_rol.Text.Trim)
                    empInsert.Parameters.AddWithValue("@telefono", tb_emple_tlf.Text.Trim)
                    empInsert.Parameters.AddWithValue("@correo", tb_emple_correo.Text.Trim)
                    empInsert.Parameters.AddWithValue("@usu", tb_emple_usu.Text.Trim)
                    empInsert.Parameters.AddWithValue("@pas", tb_emple_cont.Text.Trim)
                    empInsert.ExecuteNonQuery()

                    updateGridEmpleados()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al insertar empleados")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al añadir un empleado: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)

                Finally
                    conexion.Close()
                End Try
            Else
                MsgBox("Campos incompletos", 0 + MsgBoxStyle.Information, "Campo incorrecto")
            End If
        Else
            'indicar que presione "Nuevo" antes
        End If
    End Sub

    'BOTON BAJA
    Private Sub tslbl_baja_empleados_Click(sender As Object, e As EventArgs) Handles tslbl_baja_empleados.Click, btn_emp_baja.Click, lbl_baja_empleados.Click
        If Not (tb_emple_id.Text = "") Then
            If MsgBoxResult.Ok = MsgBox("Confirmar eliminar registro?", MsgBoxStyle.OkCancel, "Confirmar baja") Then
                Try
                    conexion.Open()
                    Dim deleteEmpleado As New OleDbCommand("delete from empleados WHERE emp_id = @id", conexion)
                    deleteEmpleado.Parameters.AddWithValue("@id", tb_emple_id.Text.Trim)
                    deleteEmpleado.ExecuteNonQuery()
                    updateGridEmpleados()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al insertar empleados")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al añadir un empleado: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            Else

            End If

        End If
    End Sub
    'BOTON MODIFICAR
    Private Sub tslbl_modificar_empleados_Click(sender As Object, e As EventArgs) Handles tslbl_modificar_empleados.Click, btn_emp_modif.Click, lbl_mod_empleados.Click
        If Not (tb_emple_id.Text = "" Or tb_emple_rol.Text = "" Or tb_emple_usu.Text = "" Or tb_emple_cont.Text = "" Or tb_emple_nom.Text = "" Or tb_emple_ape1.Text = "" Or tb_emple_ape2.Text = "" Or tb_emple_tlf.Text = "" Or tb_emple_correo.Text = "") Then
            Try
                conexion.Open()
                Dim updateEmpleados As New OleDbCommand("UPDATE empleados SET emp_nom = @nom, emp_ape1 = @ape1, emp_ape2 = @ape2, rol_id = @rol, emp_telefono = @tlf, emp_correo = @mail, usuario = @usu, cont = @cont WHERE emp_id = @id", conexion)
                updateEmpleados.Parameters.AddWithValue("@nom", tb_emple_nom.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@ape1", tb_emple_ape1.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@ape2", tb_emple_ape2.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@rol", tb_emple_rol.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@tlf", tb_emple_tlf.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@mail", tb_emple_correo.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@usu", tb_emple_usu.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@cont", tb_emple_cont.Text.Trim)
                updateEmpleados.Parameters.AddWithValue("@id", tb_emple_id.Text.Trim)
                updateEmpleados.ExecuteNonQuery()
                updateGridEmpleados()
            Catch ex As Exception
                MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al insertar empleados")
                FileOpen(2, "errores_airis.txt", OpenMode.Append)
                WriteLine(2, "Error al añadir un empleado: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose(2)
            Finally
                conexion.Close()
            End Try
        Else
            MsgBox("Campos vacios, por favor revise la informacion.", MsgBoxStyle.Information, "Campos incompletos")
        End If
    End Sub



    '-------------------------------------------------------------------------
    'TAB ROLES
    '-------------------------------------------------------------------------
    'BOTON NUEVO
    Private Sub tslbl_nuevo_rol_Click(sender As Object, e As EventArgs) Handles tslbl_nuevo_rol.Click
        tb_roles_id.Text = ""
        tb_roles_rol.Text = ""
    End Sub
    'BOTON ALTA
    Private Sub tslbl_alta_roles_Click(sender As Object, e As EventArgs) Handles tslbl_alta_roles.Click, btn_alta_rol.Click, lbl_alta_roles.Click
        If (tb_roles_id.Text = "") Then
            If (tb_roles_rol.Text = "") Then
                MsgBox("Por favor introduzca un nombre de rol", 0 + MsgBoxStyle.Information, "Nombre incorrecto")
                tb_roles_rol.Focus()
            Else
                Try
                    conexion.Open()
                    Dim rolesInsert As New OleDbCommand("INSERT INTO roles (rol_nom) VALUES (@rol)", conexion)
                    rolesInsert.Parameters.AddWithValue("@rol", tb_roles_rol.Text)
                    rolesInsert.ExecuteNonQuery()
                    updateGridRoles()

                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al insertar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al añadir un rol: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try


            End If
        End If
    End Sub
    'BOTON BAJA
    Private Sub tslbl_baja_roles_Click(sender As Object, e As EventArgs) Handles tslbl_baja_roles.Click, btn_baja_roles.Click, lbl_baja_roles.Click
        If Not (tb_roles_id.Text = "") Then
            If Not (tb_roles_rol.Text = "") Then
                Try
                    conexion.Open()
                    Dim rolesDelete As New OleDbCommand("DELETE FROM roles WHERE rol_id = @rol_id and rol_nom = @rol_nom", conexion)
                    rolesDelete.Parameters.AddWithValue("@rol_id", tb_roles_id.Text)
                    rolesDelete.Parameters.AddWithValue("@rol_nom", tb_roles_rol.Text)
                    rolesDelete.ExecuteNonQuery()
                    updateGridRoles()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar un rol: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try

            Else
                MsgBox("Por favor introduzca un nombre de rol correcto", 0 + MsgBoxStyle.Information, "Seleccion incorrecta")
            End If
        Else
            MsgBox("Por favor selecione un rol para eliminar", 0 + MsgBoxStyle.Information, "Seleccion incorrecta")
        End If
    End Sub
    'BOTON MODIFICAR
    Private Sub tslbl_modificar_roles_Click(sender As Object, e As EventArgs) Handles tslbl_modificar_roles.Click, btn_mod_roles.Click, lbl_mod_roles.Click
        If Not (tb_roles_id.Text = "") Then
            If Not (tb_roles_rol.Text = "") Then
                Try
                    conexion.Open()
                    Dim rolesUpdate As New OleDbCommand("UPDATE roles SET rol_nom = @rol_nom WHERE rol_id = @rol_id", conexion)
                    rolesUpdate.Parameters.AddWithValue("@rol_nom", tb_roles_rol.Text)
                    rolesUpdate.Parameters.AddWithValue("@rol_id", tb_roles_id.Text)
                    rolesUpdate.ExecuteNonQuery()
                    updateGridRoles()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al modificar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al modificar un rol: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)

                Finally
                    conexion.Close()
                End Try
            Else
                MsgBox("Campos incorrectos", 0 + MsgBoxStyle.Information, "Campo incorrecto")
            End If
        Else
            MsgBox("Por favor selecione un rol para eliminar", 0 + MsgBoxStyle.Information, "Seleccion incorrecta")
        End If
    End Sub

    '-------------------------------------------------------------------------
    'TAB CATEGORIAS
    '-------------------------------------------------------------------------
    'BOTON NUEVO
    Private Sub tslbl_nuevo_categoria_Click(sender As Object, e As EventArgs) Handles tslbl_nuevo_categoria.Click
        tb_categorias_id.Text = ""
        tb_categorias_nombre.Text = ""
        tb_categorias_descripccion.Text = ""
    End Sub
    'BOTON ALTA
    Private Sub tslbl_alta_categoria_productos_Click(sender As Object, e As EventArgs) Handles tslbl_alta_categoria_productos.Click, btn_alta_categoria.Click, lbl_alta_categoria.Click
        If (tb_categorias_id.Text = "") Then
            If Not (tb_categorias_nombre.Text = "" Or tb_categorias_descripccion.Text = "") Then
                Try
                    conexion.Open()
                    Dim insertCategoria As New OleDbCommand("INSERT INTO categorias_prod (cat_nom,cat_descrip) VALUES (@nom,@desc)", conexion)
                    insertCategoria.Parameters.AddWithValue("@nom", tb_categorias_nombre.Text)
                    insertCategoria.Parameters.AddWithValue("@desc", tb_categorias_descripccion.Text)
                    insertCategoria.ExecuteNonQuery()
                    conexion.Close()
                    updateGridCategorias()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)

                Finally
                    conexion.Close()
                End Try
            Else
                MsgBox("Seleccione un elemento", MsgBoxStyle.Information, "Seleccion vacia")
            End If
        Else

        End If

    End Sub
    'BOTON BAJA
    Private Sub tslbl_baja_categorias_producto_Click(sender As Object, e As EventArgs) Handles tslbl_baja_categorias_producto.Click, btn_baja_categoria.Click, lbl_baja_categoria.Click
        If Not ((tb_categorias_id.Text = "" And tb_categorias_descripccion.Text = "" And tb_categorias_nombre.Text = "")) Then
            Try
                conexion.Open()
                Dim deleteCategoria As New OleDbCommand("DELETE FROM categorias_prod WHERE cat_id = @cat_id", conexion)
                deleteCategoria.Parameters.AddWithValue("@cat_id", tb_categorias_id.Text)

                deleteCategoria.ExecuteNonQuery()
                updateGridCategorias()
            Catch ex As Exception
                MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                FileOpen(2, "errores_airis.txt", OpenMode.Append)
                WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose(2)
            Finally
                conexion.Close()
            End Try

        End If
    End Sub
    'BOTON MODIFICAR
    Private Sub tslbl_modificar_categoria_productos_Click(sender As Object, e As EventArgs) Handles tslbl_modificar_categoria_productos.Click, btn_mod_categoria.Click, lbl_mod_categoria.Click
        If Not ((tb_categorias_id.Text = "" Or tb_categorias_descripccion.Text = "" Or tb_categorias_nombre.Text = "")) Then
            Try
                conexion.Open()
                Dim updateCategoria As New OleDbCommand("UPDATE categorias_prod SET cat_nom = @cat_nom, cat_descrip = @cat_descrip WHERE (cat_id=@cat_id)", conexion)
                updateCategoria.Parameters.AddWithValue("@cat_nom", tb_categorias_nombre.Text.Trim)
                updateCategoria.Parameters.AddWithValue("@cat_descrip", tb_categorias_descripccion.Text.Trim)
                updateCategoria.Parameters.AddWithValue("@cat_id", tb_categorias_id.Text.Trim)
                updateCategoria.ExecuteNonQuery()
                updateGridCategorias()
            Catch ex As Exception
                MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                FileOpen(2, "errores_airis.txt", OpenMode.Append)
                WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose(2)
            Finally
                conexion.Close()
            End Try
        Else

        End If
    End Sub

    '-------------------------------------------------------------------------
    'TAB PRODUCTOS
    '-------------------------------------------------------------------------
    'BOTON NUEVO
    Private Sub tslbl_nuevo_producto_Click(sender As Object, e As EventArgs) Handles tslbl_nuevo_producto.Click
        tb_productos_id.Text = ""
        tb_productos_nombre.Text = ""
        tb_productos_precio.Text = ""
        tb_productos_stock.Text = ""
        tb_productos_descripccion.Text = ""
        tb_productos_marca.Text = ""
        tb_productos_categoriaID.Text = ""
    End Sub
    'BOTON ALTA
    Private Sub tslbl_alta_productos_Click(sender As Object, e As EventArgs) Handles tslbl_alta_productos.Click, btn_alta_prod.Click, lbl_alta_prod.Click
        If (tb_productos_id.Text = "") Then
            If Not (tb_productos_categoriaID.Text = "" Or tb_productos_descripccion.Text = "" Or tb_productos_marca.Text = "" Or tb_productos_nombre.Text = "" Or tb_productos_precio.Text = "" Or tb_productos_stock.Text = "") Then
                Try
                    conexion.Open()
                    Dim insertProducto As New OleDbCommand("insert into productos (prod_nom,precio,cat_id,prod_stock,prod_descrip,prod_marca) values (@nom,@precio,@cat,@stock,@desc,@marca)", conexion)
                    insertProducto.Parameters.AddWithValue("@nom", tb_productos_nombre.Text.Trim)
                    insertProducto.Parameters.AddWithValue("@precio", tb_productos_precio.Text.Trim)
                    insertProducto.Parameters.AddWithValue("@cat", tb_productos_categoriaID.Text.Trim)
                    insertProducto.Parameters.AddWithValue("@stock", tb_productos_stock.Text.Trim)
                    insertProducto.Parameters.AddWithValue("@desc", tb_productos_descripccion.Text.Trim)
                    insertProducto.Parameters.AddWithValue("@marca", tb_productos_marca.Text.Trim)
                    insertProducto.ExecuteNonQuery()
                    updateGridProducto()

                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al insertar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al añadir un rol: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MsgBox("vacia el campo id", MsgBoxStyle.Critical, "Error al insertar roles")
        End If
    End Sub
    'BOTON BAJA
    Private Sub tslbl_baja_productos_Click(sender As Object, e As EventArgs) Handles tslbl_baja_productos.Click, btn_baja_prod.Click, lbl_baja_prod.Click
        If Not (tb_productos_id.Text = "") Then
            If MsgBoxResult.Ok = MsgBox("Confirmar eliminar registro?", MsgBoxStyle.OkCancel, "Confirmar baja") Then
                Try
                    conexion.Open()
                    Dim deleteProducto As New OleDbCommand("delete from productos WHERE prod_id = @id", conexion)
                    deleteProducto.Parameters.AddWithValue("@id", tb_productos_id.Text.Trim)
                    deleteProducto.ExecuteNonQuery()
                    updateGridProducto()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            Else
                MsgBox("Seleccione un elemento", MsgBoxStyle.Information, "Seleccion vacia")
            End If
        End If
    End Sub
    'BOTON MODIFICAR
    Private Sub tslbl_modificar_productos_Click(sender As Object, e As EventArgs) Handles tslbl_modificar_productos.Click, btn_mod_prod.Click, lbl_mod_prod.Click
        If Not (tb_productos_id.Text = "" Or tb_productos_categoriaID.Text = "" Or tb_productos_descripccion.Text = "" Or tb_productos_id.Text = "" Or tb_productos_id.Text = "" Or tb_productos_marca.Text = "" Or tb_productos_nombre.Text = "" Or tb_productos_precio.Text = "" Or tb_productos_stock.Text = "") Then
            Try
                conexion.Open()
                Dim updateProducto As New OleDbCommand("UPDATE productos SET prod_nom = @nom, precio = @precio, cat_id = @catid, prod_stock = @stock, prod_descrip = @desc, prod_marca = @marca WHERE prod_id = @id", conexion)
                updateProducto.Parameters.AddWithValue("@nom", tb_productos_nombre.Text.Trim)
                updateProducto.Parameters.AddWithValue("@precio", tb_productos_precio.Text.Trim)
                updateProducto.Parameters.AddWithValue("@catid", tb_productos_categoriaID.Text.Trim)
                updateProducto.Parameters.AddWithValue("@stock", tb_productos_stock.Text.Trim)
                updateProducto.Parameters.AddWithValue("@desc", tb_productos_descripccion.Text.Trim)
                updateProducto.Parameters.AddWithValue("@marca", tb_productos_marca.Text.Trim)
                updateProducto.Parameters.AddWithValue("@id", tb_productos_id.Text.Trim)
                updateProducto.ExecuteNonQuery()
                updateGridProducto()

            Catch ex As Exception
                MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                FileOpen(2, "errores_airis.txt", OpenMode.Append)
                WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose(2)
            Finally
                conexion.Close()
            End Try
        Else
            MsgBox("Campos vacios, por favor revise la informacion.", MsgBoxStyle.Information, "Campos incompletos")
        End If


    End Sub

    '-------------------------------------------------------------------------
    'TAB CLIENTES
    '-------------------------------------------------------------------------
    'BOTON NUEVO
    Private Sub tslbl_nuevo_clientes_Click(sender As Object, e As EventArgs) Handles tslbl_nuevo_clientes.Click
        tb_clientes_id.Text = ""
        tb_clientes_nombre.Text = ""
        tb_clientes_ape1.Text = ""
        tb_clientes_ape2.Text = ""
        tb_clientes_direccion.Text = ""
        tb_clientes_empleadoID.Text = ""
        tb_clientes_telefono.Text = ""
    End Sub
    'BOTON ALTA
    Private Sub tslbl_alta_clientes_Click(sender As Object, e As EventArgs) Handles tslbl_alta_clientes.Click, btn_clientes_alta.Click, lbl_alta_clientes.Click
        If (tb_clientes_id.Text = "") Then
            If Not (tb_clientes_ape1.Text = "" Or tb_clientes_ape2.Text = "" Or tb_clientes_direccion.Text = "" Or tb_clientes_empleadoID.Text = "" Or tb_clientes_nombre.Text = "" Or tb_clientes_telefono.Text = "") Then
                Try
                    conexion.Open()
                    Dim insertCliente As New OleDbCommand("INSERT INTO clientes (clie_nom,clie_ape1,clie_ape2,clie_telefono,emp_id,clie_dir) VALUES (@nom,@ape1,@ape2,@tlf,@emp_id,@dir)", conexion)
                    insertCliente.Parameters.AddWithValue("@nom", tb_clientes_nombre.Text.Trim)
                    insertCliente.Parameters.AddWithValue("@ape1", tb_clientes_ape1.Text.Trim)
                    insertCliente.Parameters.AddWithValue("@ape2", tb_clientes_ape2.Text.Trim)
                    insertCliente.Parameters.AddWithValue("@tlf", tb_clientes_telefono.Text.Trim)
                    insertCliente.Parameters.AddWithValue("@emp_id", tb_clientes_empleadoID.Text.Trim)
                    insertCliente.Parameters.AddWithValue("@dir", tb_clientes_direccion.Text.Trim)
                    insertCliente.ExecuteNonQuery()
                    updateGridClientes()

                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            Else
                MsgBox("Campos vacios, por favor revise la informacion.", MsgBoxStyle.Information, "Campos incompletos")
            End If
        Else
            MsgBox("Debe selecionar Nuevo antes de dar de alta", MsgBoxStyle.Information, "Selecione formulario nuevo")
        End If
    End Sub
    'BOTON BAJA
    Private Sub tslbl_baja_clientes_Click(sender As Object, e As EventArgs) Handles tslbl_baja_clientes.Click, btn_clientes_baja.Click
        If Not (tb_clientes.Text = "") Then
            If MsgBoxResult.Ok = MsgBox("Confirmar eliminar registro?", MsgBoxStyle.OkCancel, "Confirmar baja") Then
                Try
                    conexion.Open()
                    Dim deleteClientes As New OleDbCommand("DELETE FROM clientes WHERE clie_id = @id", conexion)
                    deleteClientes.Parameters.AddWithValue("@id", tb_clientes_id.Text.Trim)
                    deleteClientes.ExecuteNonQuery()
                    updateGridClientes()

                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MsgBox("Seleccione un elemento", MsgBoxStyle.Information, "Seleccion vacia")
        End If
    End Sub
    'BOTON MODIFICAR
    Private Sub tslbl_modificar_clientes_Click(sender As Object, e As EventArgs) Handles tslbl_modificar_clientes.Click, btn_clientes_modificar.Click, lbl_mod_clie.Click
        If Not (tb_clientes_id.Text = "" Or tb_clientes_ape1.Text = "" Or tb_clientes_ape2.Text = "" Or tb_clientes_direccion.Text = "" Or tb_clientes_empleadoID.Text = "" Or tb_clientes_nombre.Text = "" Or tb_clientes_telefono.Text = "") Then
            Try
                conexion.Open()
                Dim updateCliente As New OleDbCommand("UPDATE clientes SET clie_nom = @nom, clie_ape1 = @ape1, clie_ape2 = @ape2, clie_telefono = @tlf, emp_id = @empid, clie_dir = @dir WHERE clie_id = @id", conexion)
                updateCliente.Parameters.AddWithValue("@nom", tb_clientes_nombre.Text.Trim)
                updateCliente.Parameters.AddWithValue("@ape1", tb_clientes_ape1.Text.Trim)
                updateCliente.Parameters.AddWithValue("@ape2", tb_clientes_ape2.Text.Trim)
                updateCliente.Parameters.AddWithValue("@tlf", tb_clientes_telefono.Text.Trim)
                updateCliente.Parameters.AddWithValue("@empid", tb_clientes_empleadoID.Text.Trim)
                updateCliente.Parameters.AddWithValue("@dir", tb_clientes_direccion.Text.Trim)
                updateCliente.Parameters.AddWithValue("@id", tb_clientes_id.Text.Trim)
                updateCliente.ExecuteNonQuery()
                updateGridClientes()
            Catch ex As Exception
                MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                FileOpen(2, "errores_airis.txt", OpenMode.Append)
                WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose(2)

            Finally
                conexion.Close()
            End Try
        Else
            MsgBox("Campos vacios, por favor revise la informacion.", MsgBoxStyle.Information, "Campos incompletos")
        End If
    End Sub



    '-------------------------------------------------------------------------
    'TAB PROVEEDORES
    '-------------------------------------------------------------------------
    'BOTON NUEVO
    Private Sub tslbl_nuevo_proveedores_Click(sender As Object, e As EventArgs) Handles tslbl_nuevo_proveedores.Click
        tb_proveedores_id.Text = ""
        tb_proveedores_contacto.Text = ""
        tb_proveedores_direccion.Text = ""
        tb_proveedores_nombre.Text = ""
        tb_proveedores_telefono.Text = ""
    End Sub
    'BOTON ALTA
    Private Sub tslbl_alta_provedores_Click(sender As Object, e As EventArgs) Handles tslbl_alta_provedores.Click, btn_alta_prov.Click, lbl_alta_prov.Click
        If (tb_proveedores_id.Text = "") Then
            If Not (tb_proveedores_contacto.Text = "" Or tb_proveedores_direccion.Text = "" Or tb_proveedores_nombre.Text = "" Or tb_proveedores_telefono.Text = "") Then
                Try
                    conexion.Open()
                    Dim insertProveedor As New OleDbCommand("insert into proveedores (pro_nom,pro_dir,pro_telefono,pro_contacto) values (@nom,@dir,@tlf,@contacto)", conexion)
                    insertProveedor.Parameters.AddWithValue("@nom", tb_proveedores_nombre.Text.Trim)
                    insertProveedor.Parameters.AddWithValue("@dir", tb_proveedores_direccion.Text.Trim)
                    insertProveedor.Parameters.AddWithValue("@tlf", tb_proveedores_telefono.Text.Trim)
                    insertProveedor.Parameters.AddWithValue("@contacto", tb_proveedores_contacto.Text.Trim)
                    insertProveedor.ExecuteNonQuery()
                    updateGridProveedores()

                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            Else
                MsgBox("Campos vacios, por favor revise la informacion", MsgBoxStyle.Information, "Campos incompletos")
            End If
        Else
            MsgBox("Debe selecionar Nuevo antes de dar de alta", MsgBoxStyle.Information, "Campos incompletos")
        End If

    End Sub

    'BOTON BAJA
    Private Sub tslbl_baja_proveedores_Click(sender As Object, e As EventArgs) Handles tslbl_baja_proveedores.Click, btn_baja_prod.Click, lbl_baja_prov.Click
        If Not (tb_clientes.Text = "") Then
            If MsgBoxResult.Ok = MsgBox("Confirmar eliminar registro?", MsgBoxStyle.OkCancel, "Confirmar baja") Then
                Try
                    conexion.Open()
                    Dim deleteProveedors As New OleDbCommand("DELETE FROM proveedores WHERE pro_id = @id", conexion)
                    deleteProveedors.Parameters.AddWithValue("@id", tb_proveedores_id.Text.Trim)
                    deleteProveedors.ExecuteNonQuery()
                    updateGridProveedores()
                Catch ex As Exception
                    MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                    FileOpen(2, "errores_airis.txt", OpenMode.Append)
                    WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                    FileClose(2)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MsgBox("Seleccione un elemento", MsgBoxStyle.Information, "Seleccion vacia")
        End If
    End Sub
    'BOTON MODIFICAR
    Private Sub tslbl_modificar_proveedores_Click(sender As Object, e As EventArgs) Handles tslbl_modificar_proveedores.Click, btn_provedores_modificar.Click, lbl_mod_prov.Click
        If Not (tb_proveedores_id.Text = "" Or tb_proveedores_contacto.Text = "" Or tb_proveedores_direccion.Text = "" Or tb_proveedores_nombre.Text = "" Or tb_proveedores_telefono.Text = "") Then
            Try
                conexion.Open()
                Dim updateProveedor As New OleDbCommand("UPDATE proveedores SET pro_nom = @nom, pro_dir = @dir, pro_telefono = @tlf, pro_contacto = @contacto WHERE pro_id = @id", conexion)
                updateProveedor.Parameters.AddWithValue("@nom", tb_proveedores_nombre.Text.Trim)
                updateProveedor.Parameters.AddWithValue("@dir", tb_proveedores_direccion.Text.Trim)
                updateProveedor.Parameters.AddWithValue("@tlf", tb_proveedores_telefono.Text.Trim)
                updateProveedor.Parameters.AddWithValue("@contacto", tb_proveedores_contacto.Text.Trim)
                updateProveedor.Parameters.AddWithValue("@id", tb_proveedores_id.Text.Trim)
                updateProveedor.ExecuteNonQuery()
                updateGridProveedores()
            Catch ex As Exception
                MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error al eliminar roles")
                FileOpen(2, "errores_airis.txt", OpenMode.Append)
                WriteLine(2, "Error al eliminar una categoria: " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose(2)
            Finally
                conexion.Close()
            End Try
        Else
            MsgBox("Campos vacios, por favor revise la informacion.", MsgBoxStyle.Information, "Campos incompletos")
        End If
    End Sub

    'UPDATES

    Private Sub updateGridProveedores()
        dataset_proveedores.Clear()
        adaptador_proveedores.Fill(dataset_proveedores, "Tabla_proveedores")
        BindingContext(dataset_proveedores, "Tabla_proveedores").Position = BindingContext(dataset_proveedores, "Tabla_proveedores").Count
    End Sub

    Private Sub updateGridClientes()
        dataset_clientes.Clear()
        adaptador_clientes.Fill(dataset_clientes, "Tabla_clientes")
        BindingContext(dataset_clientes, "Tabla_clientes").Position = BindingContext(dataset_clientes, "Tabla_clientes").Count
    End Sub

    Private Sub updateGridCategorias()
        dataset_categoria_productos.Clear()
        adaptador_categoria_productos.Fill(dataset_categoria_productos, "Tabla_categoria_productos")
        BindingContext(dataset_categoria_productos, "Tabla_categoria_productos").Position = BindingContext(dataset_categoria_productos, "Tabla_categoria_productos").Count
    End Sub

    Private Sub updateGridEmpleados()
        dataset_empleados.Clear()
        adaptador_empleados.Fill(dataset_empleados, "Tabla_empleados")
        BindingContext(dataset_empleados, "Tabla_empleados").Position = BindingContext(dataset_empleados, "Tabla_empleados").Count
    End Sub

    Private Sub updateGridRoles()
        dataset_roles.Clear()
        adaptador_roles.Fill(dataset_roles, "Tabla_roles")
        BindingContext(dataset_roles, "Tabla_roles").Position = BindingContext(dataset_roles, "Tabla_roles").Count
    End Sub

    Private Sub updateGridProducto()
        dataset_productos.Clear()
        adaptador_productos.Fill(dataset_productos, "Tabla_productos")
        BindingContext(dataset_productos, "Tabla_productos").Position = BindingContext(dataset_productos, "Tabla_productos").Count
    End Sub

    'Cerrar y volver
    Private Sub gestion_datos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        inicio.Show()
    End Sub

    Private Sub ts_volverimg_Click(sender As Object, e As EventArgs) Handles ts_volverimg.Click
        Me.Hide()
        inicio.Show()
    End Sub

    'INFORMES
    Private Sub info_clie_Click(sender As Object, e As EventArgs) Handles info_clie.Click
        Informe.Show()
        c = 1
    End Sub

    Private Sub info_prod_Click(sender As Object, e As EventArgs) Handles info_prod.Click
        Informe.Show()
        c = 2
    End Sub
    'AYUDAS
    Private Sub ll_ayuda_roles_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_ayuda_roles.LinkClicked
        Help.ShowHelp(ll_ayuda_roles, "Airis.chm")
    End Sub

    Private Sub ll_ayuda_emple_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_ayuda_emple.LinkClicked
        Help.ShowHelp(ll_ayuda_emple, "Airis.chm")
    End Sub

    Private Sub ll_ayuda_cat_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_ayuda_cat.LinkClicked
        Help.ShowHelp(ll_ayuda_cat, "Airis.chm")
    End Sub

    Private Sub ll_ayuda_prod_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_ayuda_prod.LinkClicked
        Help.ShowHelp(ll_ayuda_prod, "Airis.chm")
    End Sub

    Private Sub ll_ayuda_clie_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_ayuda_clie.LinkClicked
        Help.ShowHelp(ll_ayuda_clie, "Airis.chm")
    End Sub

    Private Sub ll_ayuda_prov_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_ayuda_prov.LinkClicked
        Help.ShowHelp(ll_ayuda_prov, "Airis.chm")
    End Sub

    '
    'Eventos de teclado y validaciones
    '
    'Enteros (rol id de empleado,clientes empleado ID,categoria de producto, stock)
    Private Sub checkEntero(sender As TextBox, e As EventArgs) Handles tb_emple_rol.TextChanged, tb_clientes_empleadoID.TextChanged, tb_categorias_id.TextChanged, tb_productos_categoriaID.TextChanged, tb_productos_stock.TextChanged
        Dim strToCheck As String = sender.Text
        If Not (validaciones.allNumbers(strToCheck)) Then
            If strToCheck.Length > 0 Then
                sender.Text = strToCheck.Substring(0, strToCheck.Length - 1)
                MsgBox("Este campo solo acepta numeros enteros", MsgBoxStyle.Information, "Error: Valor invalido")
            End If
        End If
    End Sub
    'Alfanumerico (usuario, nombre de producto,marca ,nombre categoria)
    Private Sub checkAlfanumerico(sender As TextBox, e As EventArgs) Handles tb_emple_usu.TextChanged, tb_productos_nombre.TextChanged, tb_productos_marca.TextChanged, tb_categorias_nombre.TextChanged
        Dim strToCheck As String = sender.Text
        If Not (validaciones.validarAlfanumerico(strToCheck)) Then
            If strToCheck.Length > 0 Then
                sender.Text = strToCheck.Substring(0, strToCheck.Length - 1)
                MsgBox("Este campo solo admite alfanumericos", MsgBoxStyle.Information, "Error: Valor invalido")
            End If
        End If
    End Sub
    'Numeros de telefono
    Private Sub checkNumerotelefonico(sender As TextBox, e As EventArgs) Handles tb_emple_tlf.LostFocus, tb_clientes_telefono.LostFocus
        Dim strToCheck As String = sender.Text
        If Not (validaciones.validarNumeroTelefono(strToCheck)) Then
            sender.Text = ""
            MsgBox("Este campo solo admite un formato de numero de telefono", MsgBoxStyle.Information, "Error: Valor invalido")
        End If
    End Sub
    'Solo letras(nombres y apellidos)
    Private Sub checkSoloLetras(sender As TextBox, e As EventArgs) Handles tb_emple_nom.TextChanged, tb_emple_ape1.TextChanged, tb_emple_ape2.TextChanged, tb_clientes_nombre.TextChanged, tb_clientes_ape1.TextChanged, tb_clientes_ape2.TextChanged, tb_proveedores_contacto.TextChanged
        Dim strToCheck As String = sender.Text
        If Not (validaciones.onlyLetter(strToCheck)) Then
            If strToCheck.Length > 0 Then
                sender.Text = strToCheck.Substring(0, strToCheck.Length - 1)
                MsgBox("Este campo solo admite letras", MsgBoxStyle.Information, "Error: Valor invalido")
            End If
        End If
    End Sub
    'Solo nuemros y decimales (precio)
    Private Sub checkPrecio(sender As TextBox, e As EventArgs) Handles tb_productos_precio.TextChanged
        Dim strToCheck As String = sender.Text
        If Not (validaciones.naturalDecimal(strToCheck)) Then
            If strToCheck.Length > 0 Then
                sender.Text = strToCheck.Substring(0, strToCheck.Length - 1)
                MsgBox("Este campo solo admite enteros o decimales", MsgBoxStyle.Information, "Error: Valor invalido")
            End If
        End If
    End Sub
End Class