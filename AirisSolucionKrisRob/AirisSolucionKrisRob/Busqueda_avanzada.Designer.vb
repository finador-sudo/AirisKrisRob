<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_avanzada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cb_tablas = New System.Windows.Forms.ComboBox()
        Me.lbl_tabla = New System.Windows.Forms.Label()
        Me.dg_busqueda = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_id_empleados = New System.Windows.Forms.Label()
        Me.lbl_correo_empleado = New System.Windows.Forms.Label()
        Me.lbl_telefono_empleado = New System.Windows.Forms.Label()
        Me.llb_rol_empleados = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_ape2_empleado = New System.Windows.Forms.Label()
        Me.lbl_ape1_empleado = New System.Windows.Forms.Label()
        Me.lbl_nom_empleados = New System.Windows.Forms.Label()
        Me.pan_empleados = New System.Windows.Forms.Panel()
        Me.lbl_empleados = New System.Windows.Forms.Label()
        Me.tb_correo_emple = New System.Windows.Forms.TextBox()
        Me.tb_rol_id_emple = New System.Windows.Forms.TextBox()
        Me.tb_telef_emple = New System.Windows.Forms.TextBox()
        Me.tb_ape2_emple = New System.Windows.Forms.TextBox()
        Me.tb_ape1_emple = New System.Windows.Forms.TextBox()
        Me.tb_nom_emple = New System.Windows.Forms.TextBox()
        Me.tb_id_emple = New System.Windows.Forms.TextBox()
        Me.pan_categorias = New System.Windows.Forms.Panel()
        Me.lbl_categorias = New System.Windows.Forms.Label()
        Me.lbl_desc_categoria = New System.Windows.Forms.Label()
        Me.lbl_nom_categoria = New System.Windows.Forms.Label()
        Me.lbl_id_categoria = New System.Windows.Forms.Label()
        Me.tb_desc_cat = New System.Windows.Forms.TextBox()
        Me.tb_nom_cat = New System.Windows.Forms.TextBox()
        Me.tb_id_cat = New System.Windows.Forms.TextBox()
        Me.pan_productos = New System.Windows.Forms.Panel()
        Me.lbl_marca_productos = New System.Windows.Forms.Label()
        Me.lbl_stock_productos = New System.Windows.Forms.Label()
        Me.lbl_categoria_producto = New System.Windows.Forms.Label()
        Me.lbl_precio_producto = New System.Windows.Forms.Label()
        Me.lbl_nombre_producto = New System.Windows.Forms.Label()
        Me.lbl_id_productos = New System.Windows.Forms.Label()
        Me.lbl_productos = New System.Windows.Forms.Label()
        Me.tb_precio_productos = New System.Windows.Forms.TextBox()
        Me.tb_marca_productos = New System.Windows.Forms.TextBox()
        Me.tb_stock_productos = New System.Windows.Forms.TextBox()
        Me.tb_id_productos = New System.Windows.Forms.TextBox()
        Me.tb_nombre_productos = New System.Windows.Forms.TextBox()
        Me.tb_categoria_id_productos = New System.Windows.Forms.TextBox()
        Me.pan_clientes = New System.Windows.Forms.Panel()
        Me.lbl_id_empleado_clientes = New System.Windows.Forms.Label()
        Me.lbl_telefono_cliente = New System.Windows.Forms.Label()
        Me.lbl_ape2_clientes = New System.Windows.Forms.Label()
        Me.lbl_ape1_clientes = New System.Windows.Forms.Label()
        Me.lbl_nombre_clientes = New System.Windows.Forms.Label()
        Me.lbl_id_clientes = New System.Windows.Forms.Label()
        Me.lbl_clientes = New System.Windows.Forms.Label()
        Me.tb_ape1_clientes = New System.Windows.Forms.TextBox()
        Me.tb_empleado_id_clientes = New System.Windows.Forms.TextBox()
        Me.tb_telefono_clientes = New System.Windows.Forms.TextBox()
        Me.tb_id_clientes = New System.Windows.Forms.TextBox()
        Me.tb_nombre_clientes = New System.Windows.Forms.TextBox()
        Me.tb_ape2_clientes = New System.Windows.Forms.TextBox()
        Me.pan_provedores = New System.Windows.Forms.Panel()
        Me.lbl_contacto_provedores = New System.Windows.Forms.Label()
        Me.lbl_telefono_provedores = New System.Windows.Forms.Label()
        Me.lbl_direccion_provedores = New System.Windows.Forms.Label()
        Me.lbl_nombre_provedores = New System.Windows.Forms.Label()
        Me.lbl_id_provedores = New System.Windows.Forms.Label()
        Me.lbl_provedores = New System.Windows.Forms.Label()
        Me.tb_direccion_provedores = New System.Windows.Forms.TextBox()
        Me.tb_contacto_ = New System.Windows.Forms.TextBox()
        Me.tb_id_provedores = New System.Windows.Forms.TextBox()
        Me.tb_nombre_provedores = New System.Windows.Forms.TextBox()
        Me.tb_telefono_provedores = New System.Windows.Forms.TextBox()
        Me.pan_roles = New System.Windows.Forms.Panel()
        Me.lbl_rol_nombre = New System.Windows.Forms.Label()
        Me.lbl_id_rol = New System.Windows.Forms.Label()
        Me.lbl_roles = New System.Windows.Forms.Label()
        Me.rb_rol_id = New System.Windows.Forms.TextBox()
        Me.tb_rol_nombre = New System.Windows.Forms.TextBox()
        CType(Me.dg_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_empleados.SuspendLayout()
        Me.pan_categorias.SuspendLayout()
        Me.pan_productos.SuspendLayout()
        Me.pan_clientes.SuspendLayout()
        Me.pan_provedores.SuspendLayout()
        Me.pan_roles.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_tablas
        '
        Me.cb_tablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tablas.FormattingEnabled = True
        Me.cb_tablas.Items.AddRange(New Object() {"Clientes", "Categorias de producto", "Roles", "Empleados", "Productos", "Provedores"})
        Me.cb_tablas.Location = New System.Drawing.Point(255, 84)
        Me.cb_tablas.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_tablas.Name = "cb_tablas"
        Me.cb_tablas.Size = New System.Drawing.Size(260, 24)
        Me.cb_tablas.TabIndex = 0
        '
        'lbl_tabla
        '
        Me.lbl_tabla.AutoSize = True
        Me.lbl_tabla.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabla.Location = New System.Drawing.Point(179, 80)
        Me.lbl_tabla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tabla.Name = "lbl_tabla"
        Me.lbl_tabla.Size = New System.Drawing.Size(55, 24)
        Me.lbl_tabla.TabIndex = 1
        Me.lbl_tabla.Text = "Tabla:"
        '
        'dg_busqueda
        '
        Me.dg_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_busqueda.Location = New System.Drawing.Point(117, 384)
        Me.dg_busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.dg_busqueda.Name = "dg_busqueda"
        Me.dg_busqueda.Size = New System.Drawing.Size(930, 220)
        Me.dg_busqueda.TabIndex = 2
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(315, 635)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(100, 44)
        Me.btn_cerrar.TabIndex = 3
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(315, 330)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(100, 28)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_id_empleados
        '
        Me.lbl_id_empleados.AutoSize = True
        Me.lbl_id_empleados.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_empleados.Location = New System.Drawing.Point(139, 25)
        Me.lbl_id_empleados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_empleados.Name = "lbl_id_empleados"
        Me.lbl_id_empleados.Size = New System.Drawing.Size(27, 20)
        Me.lbl_id_empleados.TabIndex = 5
        Me.lbl_id_empleados.Text = "ID:"
        '
        'lbl_correo_empleado
        '
        Me.lbl_correo_empleado.AutoSize = True
        Me.lbl_correo_empleado.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correo_empleado.Location = New System.Drawing.Point(372, 98)
        Me.lbl_correo_empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_correo_empleado.Name = "lbl_correo_empleado"
        Me.lbl_correo_empleado.Size = New System.Drawing.Size(57, 20)
        Me.lbl_correo_empleado.TabIndex = 7
        Me.lbl_correo_empleado.Text = "Correo:"
        '
        'lbl_telefono_empleado
        '
        Me.lbl_telefono_empleado.AutoSize = True
        Me.lbl_telefono_empleado.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_empleado.Location = New System.Drawing.Point(360, 62)
        Me.lbl_telefono_empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono_empleado.Name = "lbl_telefono_empleado"
        Me.lbl_telefono_empleado.Size = New System.Drawing.Size(71, 20)
        Me.lbl_telefono_empleado.TabIndex = 8
        Me.lbl_telefono_empleado.Text = "Teléfono:"
        '
        'llb_rol_empleados
        '
        Me.llb_rol_empleados.AutoSize = True
        Me.llb_rol_empleados.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llb_rol_empleados.Location = New System.Drawing.Point(372, 23)
        Me.llb_rol_empleados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llb_rol_empleados.Name = "llb_rol_empleados"
        Me.llb_rol_empleados.Size = New System.Drawing.Size(63, 20)
        Me.llb_rol_empleados.TabIndex = 9
        Me.llb_rol_empleados.Text = "Rol (ID):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 10
        '
        'lbl_ape2_empleado
        '
        Me.lbl_ape2_empleado.AutoSize = True
        Me.lbl_ape2_empleado.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape2_empleado.Location = New System.Drawing.Point(41, 137)
        Me.lbl_ape2_empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape2_empleado.Name = "lbl_ape2_empleado"
        Me.lbl_ape2_empleado.Size = New System.Drawing.Size(130, 20)
        Me.lbl_ape2_empleado.TabIndex = 11
        Me.lbl_ape2_empleado.Text = "Segundo apellido:"
        '
        'lbl_ape1_empleado
        '
        Me.lbl_ape1_empleado.AutoSize = True
        Me.lbl_ape1_empleado.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape1_empleado.Location = New System.Drawing.Point(53, 98)
        Me.lbl_ape1_empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape1_empleado.Name = "lbl_ape1_empleado"
        Me.lbl_ape1_empleado.Size = New System.Drawing.Size(114, 20)
        Me.lbl_ape1_empleado.TabIndex = 12
        Me.lbl_ape1_empleado.Text = "Primer apellido:"
        '
        'lbl_nom_empleados
        '
        Me.lbl_nom_empleados.AutoSize = True
        Me.lbl_nom_empleados.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_empleados.Location = New System.Drawing.Point(101, 62)
        Me.lbl_nom_empleados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom_empleados.Name = "lbl_nom_empleados"
        Me.lbl_nom_empleados.Size = New System.Drawing.Size(67, 20)
        Me.lbl_nom_empleados.TabIndex = 13
        Me.lbl_nom_empleados.Text = "Nombre:"
        '
        'pan_empleados
        '
        Me.pan_empleados.Controls.Add(Me.lbl_empleados)
        Me.pan_empleados.Controls.Add(Me.tb_correo_emple)
        Me.pan_empleados.Controls.Add(Me.tb_rol_id_emple)
        Me.pan_empleados.Controls.Add(Me.tb_telef_emple)
        Me.pan_empleados.Controls.Add(Me.tb_ape2_emple)
        Me.pan_empleados.Controls.Add(Me.tb_ape1_emple)
        Me.pan_empleados.Controls.Add(Me.tb_nom_emple)
        Me.pan_empleados.Controls.Add(Me.tb_id_emple)
        Me.pan_empleados.Controls.Add(Me.lbl_id_empleados)
        Me.pan_empleados.Controls.Add(Me.lbl_correo_empleado)
        Me.pan_empleados.Controls.Add(Me.lbl_telefono_empleado)
        Me.pan_empleados.Controls.Add(Me.llb_rol_empleados)
        Me.pan_empleados.Controls.Add(Me.Label6)
        Me.pan_empleados.Controls.Add(Me.lbl_nom_empleados)
        Me.pan_empleados.Controls.Add(Me.lbl_ape2_empleado)
        Me.pan_empleados.Controls.Add(Me.lbl_ape1_empleado)
        Me.pan_empleados.Location = New System.Drawing.Point(73, 117)
        Me.pan_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_empleados.Name = "pan_empleados"
        Me.pan_empleados.Size = New System.Drawing.Size(604, 191)
        Me.pan_empleados.TabIndex = 14
        '
        'lbl_empleados
        '
        Me.lbl_empleados.AutoSize = True
        Me.lbl_empleados.Location = New System.Drawing.Point(19, 11)
        Me.lbl_empleados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados.Name = "lbl_empleados"
        Me.lbl_empleados.Size = New System.Drawing.Size(78, 17)
        Me.lbl_empleados.TabIndex = 21
        Me.lbl_empleados.Text = "Empleados"
        '
        'tb_correo_emple
        '
        Me.tb_correo_emple.Location = New System.Drawing.Point(436, 96)
        Me.tb_correo_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_correo_emple.Name = "tb_correo_emple"
        Me.tb_correo_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_correo_emple.TabIndex = 20
        '
        'tb_rol_id_emple
        '
        Me.tb_rol_id_emple.Location = New System.Drawing.Point(436, 22)
        Me.tb_rol_id_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rol_id_emple.Name = "tb_rol_id_emple"
        Me.tb_rol_id_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_rol_id_emple.TabIndex = 19
        '
        'tb_telef_emple
        '
        Me.tb_telef_emple.Location = New System.Drawing.Point(436, 59)
        Me.tb_telef_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_telef_emple.Name = "tb_telef_emple"
        Me.tb_telef_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_telef_emple.TabIndex = 18
        '
        'tb_ape2_emple
        '
        Me.tb_ape2_emple.Location = New System.Drawing.Point(185, 134)
        Me.tb_ape2_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ape2_emple.Name = "tb_ape2_emple"
        Me.tb_ape2_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_ape2_emple.TabIndex = 17
        '
        'tb_ape1_emple
        '
        Me.tb_ape1_emple.Location = New System.Drawing.Point(185, 96)
        Me.tb_ape1_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ape1_emple.Name = "tb_ape1_emple"
        Me.tb_ape1_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_ape1_emple.TabIndex = 16
        '
        'tb_nom_emple
        '
        Me.tb_nom_emple.Location = New System.Drawing.Point(185, 59)
        Me.tb_nom_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nom_emple.Name = "tb_nom_emple"
        Me.tb_nom_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_nom_emple.TabIndex = 15
        '
        'tb_id_emple
        '
        Me.tb_id_emple.Location = New System.Drawing.Point(185, 22)
        Me.tb_id_emple.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id_emple.Name = "tb_id_emple"
        Me.tb_id_emple.Size = New System.Drawing.Size(120, 22)
        Me.tb_id_emple.TabIndex = 14
        '
        'pan_categorias
        '
        Me.pan_categorias.Controls.Add(Me.lbl_categorias)
        Me.pan_categorias.Controls.Add(Me.lbl_desc_categoria)
        Me.pan_categorias.Controls.Add(Me.lbl_nom_categoria)
        Me.pan_categorias.Controls.Add(Me.lbl_id_categoria)
        Me.pan_categorias.Controls.Add(Me.tb_desc_cat)
        Me.pan_categorias.Controls.Add(Me.tb_nom_cat)
        Me.pan_categorias.Controls.Add(Me.tb_id_cat)
        Me.pan_categorias.Location = New System.Drawing.Point(73, 117)
        Me.pan_categorias.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_categorias.Name = "pan_categorias"
        Me.pan_categorias.Size = New System.Drawing.Size(604, 191)
        Me.pan_categorias.TabIndex = 15
        '
        'lbl_categorias
        '
        Me.lbl_categorias.AutoSize = True
        Me.lbl_categorias.Location = New System.Drawing.Point(19, 17)
        Me.lbl_categorias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categorias.Name = "lbl_categorias"
        Me.lbl_categorias.Size = New System.Drawing.Size(76, 17)
        Me.lbl_categorias.TabIndex = 7
        Me.lbl_categorias.Text = "Categorias"
        '
        'lbl_desc_categoria
        '
        Me.lbl_desc_categoria.AutoSize = True
        Me.lbl_desc_categoria.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_categoria.Location = New System.Drawing.Point(179, 129)
        Me.lbl_desc_categoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc_categoria.Name = "lbl_desc_categoria"
        Me.lbl_desc_categoria.Size = New System.Drawing.Size(90, 20)
        Me.lbl_desc_categoria.TabIndex = 5
        Me.lbl_desc_categoria.Text = "Descripción:"
        '
        'lbl_nom_categoria
        '
        Me.lbl_nom_categoria.AutoSize = True
        Me.lbl_nom_categoria.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_categoria.Location = New System.Drawing.Point(115, 82)
        Me.lbl_nom_categoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom_categoria.Name = "lbl_nom_categoria"
        Me.lbl_nom_categoria.Size = New System.Drawing.Size(171, 20)
        Me.lbl_nom_categoria.TabIndex = 4
        Me.lbl_nom_categoria.Text = "Nombre de la categoría:"
        '
        'lbl_id_categoria
        '
        Me.lbl_id_categoria.AutoSize = True
        Me.lbl_id_categoria.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_categoria.Location = New System.Drawing.Point(232, 36)
        Me.lbl_id_categoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_categoria.Name = "lbl_id_categoria"
        Me.lbl_id_categoria.Size = New System.Drawing.Size(27, 20)
        Me.lbl_id_categoria.TabIndex = 3
        Me.lbl_id_categoria.Text = "ID:"
        '
        'tb_desc_cat
        '
        Me.tb_desc_cat.Location = New System.Drawing.Point(312, 127)
        Me.tb_desc_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_desc_cat.Name = "tb_desc_cat"
        Me.tb_desc_cat.Size = New System.Drawing.Size(132, 22)
        Me.tb_desc_cat.TabIndex = 2
        '
        'tb_nom_cat
        '
        Me.tb_nom_cat.Location = New System.Drawing.Point(312, 80)
        Me.tb_nom_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nom_cat.Name = "tb_nom_cat"
        Me.tb_nom_cat.Size = New System.Drawing.Size(132, 22)
        Me.tb_nom_cat.TabIndex = 1
        '
        'tb_id_cat
        '
        Me.tb_id_cat.Location = New System.Drawing.Point(312, 33)
        Me.tb_id_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id_cat.Name = "tb_id_cat"
        Me.tb_id_cat.Size = New System.Drawing.Size(132, 22)
        Me.tb_id_cat.TabIndex = 0
        '
        'pan_productos
        '
        Me.pan_productos.Controls.Add(Me.lbl_marca_productos)
        Me.pan_productos.Controls.Add(Me.lbl_stock_productos)
        Me.pan_productos.Controls.Add(Me.lbl_categoria_producto)
        Me.pan_productos.Controls.Add(Me.lbl_precio_producto)
        Me.pan_productos.Controls.Add(Me.lbl_nombre_producto)
        Me.pan_productos.Controls.Add(Me.lbl_id_productos)
        Me.pan_productos.Controls.Add(Me.lbl_productos)
        Me.pan_productos.Controls.Add(Me.tb_precio_productos)
        Me.pan_productos.Controls.Add(Me.tb_marca_productos)
        Me.pan_productos.Controls.Add(Me.tb_stock_productos)
        Me.pan_productos.Controls.Add(Me.tb_id_productos)
        Me.pan_productos.Controls.Add(Me.tb_nombre_productos)
        Me.pan_productos.Controls.Add(Me.tb_categoria_id_productos)
        Me.pan_productos.Location = New System.Drawing.Point(73, 117)
        Me.pan_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_productos.Name = "pan_productos"
        Me.pan_productos.Size = New System.Drawing.Size(604, 191)
        Me.pan_productos.TabIndex = 17
        '
        'lbl_marca_productos
        '
        Me.lbl_marca_productos.AutoSize = True
        Me.lbl_marca_productos.Location = New System.Drawing.Point(319, 140)
        Me.lbl_marca_productos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_marca_productos.Name = "lbl_marca_productos"
        Me.lbl_marca_productos.Size = New System.Drawing.Size(51, 17)
        Me.lbl_marca_productos.TabIndex = 13
        Me.lbl_marca_productos.Text = "Marca:"
        '
        'lbl_stock_productos
        '
        Me.lbl_stock_productos.AutoSize = True
        Me.lbl_stock_productos.Location = New System.Drawing.Point(321, 86)
        Me.lbl_stock_productos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_stock_productos.Name = "lbl_stock_productos"
        Me.lbl_stock_productos.Size = New System.Drawing.Size(47, 17)
        Me.lbl_stock_productos.TabIndex = 12
        Me.lbl_stock_productos.Text = "Stock:"
        '
        'lbl_categoria_producto
        '
        Me.lbl_categoria_producto.AutoSize = True
        Me.lbl_categoria_producto.Location = New System.Drawing.Point(301, 38)
        Me.lbl_categoria_producto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categoria_producto.Name = "lbl_categoria_producto"
        Me.lbl_categoria_producto.Size = New System.Drawing.Size(73, 17)
        Me.lbl_categoria_producto.TabIndex = 11
        Me.lbl_categoria_producto.Text = "Categoria:"
        '
        'lbl_precio_producto
        '
        Me.lbl_precio_producto.AutoSize = True
        Me.lbl_precio_producto.Location = New System.Drawing.Point(80, 132)
        Me.lbl_precio_producto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_precio_producto.Name = "lbl_precio_producto"
        Me.lbl_precio_producto.Size = New System.Drawing.Size(52, 17)
        Me.lbl_precio_producto.TabIndex = 10
        Me.lbl_precio_producto.Text = "Precio:"
        '
        'lbl_nombre_producto
        '
        Me.lbl_nombre_producto.AutoSize = True
        Me.lbl_nombre_producto.Location = New System.Drawing.Point(65, 82)
        Me.lbl_nombre_producto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_producto.Name = "lbl_nombre_producto"
        Me.lbl_nombre_producto.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre_producto.TabIndex = 9
        Me.lbl_nombre_producto.Text = "Nombre:"
        '
        'lbl_id_productos
        '
        Me.lbl_id_productos.AutoSize = True
        Me.lbl_id_productos.Location = New System.Drawing.Point(101, 39)
        Me.lbl_id_productos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_productos.Name = "lbl_id_productos"
        Me.lbl_id_productos.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id_productos.TabIndex = 8
        Me.lbl_id_productos.Text = "ID:"
        '
        'lbl_productos
        '
        Me.lbl_productos.AutoSize = True
        Me.lbl_productos.Location = New System.Drawing.Point(12, 10)
        Me.lbl_productos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos.Name = "lbl_productos"
        Me.lbl_productos.Size = New System.Drawing.Size(72, 17)
        Me.lbl_productos.TabIndex = 7
        Me.lbl_productos.Text = "Productos"
        '
        'tb_precio_productos
        '
        Me.tb_precio_productos.Location = New System.Drawing.Point(133, 129)
        Me.tb_precio_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_precio_productos.Name = "tb_precio_productos"
        Me.tb_precio_productos.Size = New System.Drawing.Size(123, 22)
        Me.tb_precio_productos.TabIndex = 5
        '
        'tb_marca_productos
        '
        Me.tb_marca_productos.Location = New System.Drawing.Point(376, 137)
        Me.tb_marca_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_marca_productos.Name = "tb_marca_productos"
        Me.tb_marca_productos.Size = New System.Drawing.Size(159, 22)
        Me.tb_marca_productos.TabIndex = 4
        '
        'tb_stock_productos
        '
        Me.tb_stock_productos.Location = New System.Drawing.Point(376, 82)
        Me.tb_stock_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_stock_productos.Name = "tb_stock_productos"
        Me.tb_stock_productos.Size = New System.Drawing.Size(159, 22)
        Me.tb_stock_productos.TabIndex = 3
        '
        'tb_id_productos
        '
        Me.tb_id_productos.Location = New System.Drawing.Point(133, 36)
        Me.tb_id_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id_productos.Name = "tb_id_productos"
        Me.tb_id_productos.Size = New System.Drawing.Size(123, 22)
        Me.tb_id_productos.TabIndex = 2
        '
        'tb_nombre_productos
        '
        Me.tb_nombre_productos.Location = New System.Drawing.Point(132, 80)
        Me.tb_nombre_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nombre_productos.Name = "tb_nombre_productos"
        Me.tb_nombre_productos.Size = New System.Drawing.Size(124, 22)
        Me.tb_nombre_productos.TabIndex = 1
        '
        'tb_categoria_id_productos
        '
        Me.tb_categoria_id_productos.Location = New System.Drawing.Point(376, 36)
        Me.tb_categoria_id_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_categoria_id_productos.Name = "tb_categoria_id_productos"
        Me.tb_categoria_id_productos.Size = New System.Drawing.Size(159, 22)
        Me.tb_categoria_id_productos.TabIndex = 0
        '
        'pan_clientes
        '
        Me.pan_clientes.Controls.Add(Me.lbl_id_empleado_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_telefono_cliente)
        Me.pan_clientes.Controls.Add(Me.lbl_ape2_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_ape1_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_nombre_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_id_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_ape1_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_empleado_id_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_telefono_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_id_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_nombre_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_ape2_clientes)
        Me.pan_clientes.Location = New System.Drawing.Point(73, 117)
        Me.pan_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_clientes.Name = "pan_clientes"
        Me.pan_clientes.Size = New System.Drawing.Size(604, 191)
        Me.pan_clientes.TabIndex = 18
        '
        'lbl_id_empleado_clientes
        '
        Me.lbl_id_empleado_clientes.AutoSize = True
        Me.lbl_id_empleado_clientes.Location = New System.Drawing.Point(302, 131)
        Me.lbl_id_empleado_clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_empleado_clientes.Name = "lbl_id_empleado_clientes"
        Me.lbl_id_empleado_clientes.Size = New System.Drawing.Size(141, 17)
        Me.lbl_id_empleado_clientes.TabIndex = 13
        Me.lbl_id_empleado_clientes.Text = "Empleado de ventas:"
        '
        'lbl_telefono_cliente
        '
        Me.lbl_telefono_cliente.AutoSize = True
        Me.lbl_telefono_cliente.Location = New System.Drawing.Point(372, 87)
        Me.lbl_telefono_cliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono_cliente.Name = "lbl_telefono_cliente"
        Me.lbl_telefono_cliente.Size = New System.Drawing.Size(68, 17)
        Me.lbl_telefono_cliente.TabIndex = 12
        Me.lbl_telefono_cliente.Text = "Telefono:"
        '
        'lbl_ape2_clientes
        '
        Me.lbl_ape2_clientes.AutoSize = True
        Me.lbl_ape2_clientes.Location = New System.Drawing.Point(321, 39)
        Me.lbl_ape2_clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape2_clientes.Name = "lbl_ape2_clientes"
        Me.lbl_ape2_clientes.Size = New System.Drawing.Size(123, 17)
        Me.lbl_ape2_clientes.TabIndex = 11
        Me.lbl_ape2_clientes.Text = "Segundo Apellido:"
        '
        'lbl_ape1_clientes
        '
        Me.lbl_ape1_clientes.AutoSize = True
        Me.lbl_ape1_clientes.Location = New System.Drawing.Point(8, 132)
        Me.lbl_ape1_clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape1_clientes.Name = "lbl_ape1_clientes"
        Me.lbl_ape1_clientes.Size = New System.Drawing.Size(107, 17)
        Me.lbl_ape1_clientes.TabIndex = 10
        Me.lbl_ape1_clientes.Text = "Primer Apellido:"
        '
        'lbl_nombre_clientes
        '
        Me.lbl_nombre_clientes.AutoSize = True
        Me.lbl_nombre_clientes.Location = New System.Drawing.Point(45, 84)
        Me.lbl_nombre_clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_clientes.Name = "lbl_nombre_clientes"
        Me.lbl_nombre_clientes.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre_clientes.TabIndex = 9
        Me.lbl_nombre_clientes.Text = "Nombre:"
        '
        'lbl_id_clientes
        '
        Me.lbl_id_clientes.AutoSize = True
        Me.lbl_id_clientes.Location = New System.Drawing.Point(83, 39)
        Me.lbl_id_clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_clientes.Name = "lbl_id_clientes"
        Me.lbl_id_clientes.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id_clientes.TabIndex = 8
        Me.lbl_id_clientes.Text = "ID:"
        '
        'lbl_clientes
        '
        Me.lbl_clientes.AutoSize = True
        Me.lbl_clientes.Location = New System.Drawing.Point(19, 22)
        Me.lbl_clientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes.Name = "lbl_clientes"
        Me.lbl_clientes.Size = New System.Drawing.Size(58, 17)
        Me.lbl_clientes.TabIndex = 7
        Me.lbl_clientes.Text = "Clientes"
        '
        'tb_ape1_clientes
        '
        Me.tb_ape1_clientes.Location = New System.Drawing.Point(116, 129)
        Me.tb_ape1_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ape1_clientes.Name = "tb_ape1_clientes"
        Me.tb_ape1_clientes.Size = New System.Drawing.Size(141, 22)
        Me.tb_ape1_clientes.TabIndex = 5
        '
        'tb_empleado_id_clientes
        '
        Me.tb_empleado_id_clientes.Location = New System.Drawing.Point(444, 128)
        Me.tb_empleado_id_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_empleado_id_clientes.Name = "tb_empleado_id_clientes"
        Me.tb_empleado_id_clientes.Size = New System.Drawing.Size(139, 22)
        Me.tb_empleado_id_clientes.TabIndex = 4
        '
        'tb_telefono_clientes
        '
        Me.tb_telefono_clientes.Location = New System.Drawing.Point(445, 82)
        Me.tb_telefono_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_telefono_clientes.Name = "tb_telefono_clientes"
        Me.tb_telefono_clientes.Size = New System.Drawing.Size(139, 22)
        Me.tb_telefono_clientes.TabIndex = 3
        '
        'tb_id_clientes
        '
        Me.tb_id_clientes.Location = New System.Drawing.Point(116, 36)
        Me.tb_id_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id_clientes.Name = "tb_id_clientes"
        Me.tb_id_clientes.Size = New System.Drawing.Size(141, 22)
        Me.tb_id_clientes.TabIndex = 2
        '
        'tb_nombre_clientes
        '
        Me.tb_nombre_clientes.Location = New System.Drawing.Point(116, 80)
        Me.tb_nombre_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nombre_clientes.Name = "tb_nombre_clientes"
        Me.tb_nombre_clientes.Size = New System.Drawing.Size(140, 22)
        Me.tb_nombre_clientes.TabIndex = 1
        '
        'tb_ape2_clientes
        '
        Me.tb_ape2_clientes.Location = New System.Drawing.Point(445, 36)
        Me.tb_ape2_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ape2_clientes.Name = "tb_ape2_clientes"
        Me.tb_ape2_clientes.Size = New System.Drawing.Size(139, 22)
        Me.tb_ape2_clientes.TabIndex = 0
        '
        'pan_provedores
        '
        Me.pan_provedores.Controls.Add(Me.lbl_contacto_provedores)
        Me.pan_provedores.Controls.Add(Me.lbl_telefono_provedores)
        Me.pan_provedores.Controls.Add(Me.lbl_direccion_provedores)
        Me.pan_provedores.Controls.Add(Me.lbl_nombre_provedores)
        Me.pan_provedores.Controls.Add(Me.lbl_id_provedores)
        Me.pan_provedores.Controls.Add(Me.lbl_provedores)
        Me.pan_provedores.Controls.Add(Me.tb_direccion_provedores)
        Me.pan_provedores.Controls.Add(Me.tb_contacto_)
        Me.pan_provedores.Controls.Add(Me.tb_id_provedores)
        Me.pan_provedores.Controls.Add(Me.tb_nombre_provedores)
        Me.pan_provedores.Controls.Add(Me.tb_telefono_provedores)
        Me.pan_provedores.Location = New System.Drawing.Point(73, 117)
        Me.pan_provedores.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_provedores.Name = "pan_provedores"
        Me.pan_provedores.Size = New System.Drawing.Size(604, 191)
        Me.pan_provedores.TabIndex = 19
        '
        'lbl_contacto_provedores
        '
        Me.lbl_contacto_provedores.AutoSize = True
        Me.lbl_contacto_provedores.Location = New System.Drawing.Point(303, 85)
        Me.lbl_contacto_provedores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_contacto_provedores.Name = "lbl_contacto_provedores"
        Me.lbl_contacto_provedores.Size = New System.Drawing.Size(68, 17)
        Me.lbl_contacto_provedores.TabIndex = 12
        Me.lbl_contacto_provedores.Text = "Contacto:"
        '
        'lbl_telefono_provedores
        '
        Me.lbl_telefono_provedores.AutoSize = True
        Me.lbl_telefono_provedores.Location = New System.Drawing.Point(303, 38)
        Me.lbl_telefono_provedores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono_provedores.Name = "lbl_telefono_provedores"
        Me.lbl_telefono_provedores.Size = New System.Drawing.Size(68, 17)
        Me.lbl_telefono_provedores.TabIndex = 11
        Me.lbl_telefono_provedores.Text = "Telefono:"
        '
        'lbl_direccion_provedores
        '
        Me.lbl_direccion_provedores.AutoSize = True
        Me.lbl_direccion_provedores.Location = New System.Drawing.Point(57, 134)
        Me.lbl_direccion_provedores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_direccion_provedores.Name = "lbl_direccion_provedores"
        Me.lbl_direccion_provedores.Size = New System.Drawing.Size(71, 17)
        Me.lbl_direccion_provedores.TabIndex = 10
        Me.lbl_direccion_provedores.Text = "Direccion:"
        '
        'lbl_nombre_provedores
        '
        Me.lbl_nombre_provedores.AutoSize = True
        Me.lbl_nombre_provedores.Location = New System.Drawing.Point(65, 85)
        Me.lbl_nombre_provedores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_provedores.Name = "lbl_nombre_provedores"
        Me.lbl_nombre_provedores.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre_provedores.TabIndex = 9
        Me.lbl_nombre_provedores.Text = "Nombre:"
        '
        'lbl_id_provedores
        '
        Me.lbl_id_provedores.AutoSize = True
        Me.lbl_id_provedores.Location = New System.Drawing.Point(101, 39)
        Me.lbl_id_provedores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_provedores.Name = "lbl_id_provedores"
        Me.lbl_id_provedores.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id_provedores.TabIndex = 8
        Me.lbl_id_provedores.Text = "ID:"
        '
        'lbl_provedores
        '
        Me.lbl_provedores.AutoSize = True
        Me.lbl_provedores.Location = New System.Drawing.Point(19, 11)
        Me.lbl_provedores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_provedores.Name = "lbl_provedores"
        Me.lbl_provedores.Size = New System.Drawing.Size(81, 17)
        Me.lbl_provedores.TabIndex = 7
        Me.lbl_provedores.Text = "Provedores"
        '
        'tb_direccion_provedores
        '
        Me.tb_direccion_provedores.Location = New System.Drawing.Point(133, 129)
        Me.tb_direccion_provedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_direccion_provedores.Name = "tb_direccion_provedores"
        Me.tb_direccion_provedores.Size = New System.Drawing.Size(123, 22)
        Me.tb_direccion_provedores.TabIndex = 5
        '
        'tb_contacto_
        '
        Me.tb_contacto_.Location = New System.Drawing.Point(376, 82)
        Me.tb_contacto_.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_contacto_.Name = "tb_contacto_"
        Me.tb_contacto_.Size = New System.Drawing.Size(159, 22)
        Me.tb_contacto_.TabIndex = 3
        '
        'tb_id_provedores
        '
        Me.tb_id_provedores.Location = New System.Drawing.Point(133, 36)
        Me.tb_id_provedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id_provedores.Name = "tb_id_provedores"
        Me.tb_id_provedores.Size = New System.Drawing.Size(124, 22)
        Me.tb_id_provedores.TabIndex = 2
        '
        'tb_nombre_provedores
        '
        Me.tb_nombre_provedores.Location = New System.Drawing.Point(132, 80)
        Me.tb_nombre_provedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nombre_provedores.Name = "tb_nombre_provedores"
        Me.tb_nombre_provedores.Size = New System.Drawing.Size(125, 22)
        Me.tb_nombre_provedores.TabIndex = 1
        '
        'tb_telefono_provedores
        '
        Me.tb_telefono_provedores.Location = New System.Drawing.Point(376, 36)
        Me.tb_telefono_provedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_telefono_provedores.Name = "tb_telefono_provedores"
        Me.tb_telefono_provedores.Size = New System.Drawing.Size(159, 22)
        Me.tb_telefono_provedores.TabIndex = 0
        '
        'pan_roles
        '
        Me.pan_roles.Controls.Add(Me.lbl_rol_nombre)
        Me.pan_roles.Controls.Add(Me.lbl_id_rol)
        Me.pan_roles.Controls.Add(Me.lbl_roles)
        Me.pan_roles.Controls.Add(Me.rb_rol_id)
        Me.pan_roles.Controls.Add(Me.tb_rol_nombre)
        Me.pan_roles.Location = New System.Drawing.Point(73, 117)
        Me.pan_roles.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_roles.Name = "pan_roles"
        Me.pan_roles.Size = New System.Drawing.Size(604, 191)
        Me.pan_roles.TabIndex = 20
        '
        'lbl_rol_nombre
        '
        Me.lbl_rol_nombre.AutoSize = True
        Me.lbl_rol_nombre.Location = New System.Drawing.Point(360, 42)
        Me.lbl_rol_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_rol_nombre.Name = "lbl_rol_nombre"
        Me.lbl_rol_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_rol_nombre.TabIndex = 8
        Me.lbl_rol_nombre.Text = "Nombre:"
        '
        'lbl_id_rol
        '
        Me.lbl_id_rol.AutoSize = True
        Me.lbl_id_rol.Location = New System.Drawing.Point(147, 42)
        Me.lbl_id_rol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_rol.Name = "lbl_id_rol"
        Me.lbl_id_rol.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id_rol.TabIndex = 7
        Me.lbl_id_rol.Text = "ID:"
        '
        'lbl_roles
        '
        Me.lbl_roles.AutoSize = True
        Me.lbl_roles.Location = New System.Drawing.Point(19, 22)
        Me.lbl_roles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_roles.Name = "lbl_roles"
        Me.lbl_roles.Size = New System.Drawing.Size(44, 17)
        Me.lbl_roles.TabIndex = 6
        Me.lbl_roles.Text = "Roles"
        '
        'rb_rol_id
        '
        Me.rb_rol_id.Location = New System.Drawing.Point(183, 36)
        Me.rb_rol_id.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_rol_id.Name = "rb_rol_id"
        Me.rb_rol_id.Size = New System.Drawing.Size(109, 22)
        Me.rb_rol_id.TabIndex = 2
        '
        'tb_rol_nombre
        '
        Me.tb_rol_nombre.Location = New System.Drawing.Point(428, 36)
        Me.tb_rol_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rol_nombre.Name = "tb_rol_nombre"
        Me.tb_rol_nombre.Size = New System.Drawing.Size(107, 22)
        Me.tb_rol_nombre.TabIndex = 0
        '
        'Busqueda_avanzada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 718)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dg_busqueda)
        Me.Controls.Add(Me.lbl_tabla)
        Me.Controls.Add(Me.cb_tablas)
        Me.Controls.Add(Me.pan_clientes)
        Me.Controls.Add(Me.pan_provedores)
        Me.Controls.Add(Me.pan_productos)
        Me.Controls.Add(Me.pan_categorias)
        Me.Controls.Add(Me.pan_empleados)
        Me.Controls.Add(Me.pan_roles)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Busqueda_avanzada"
        Me.Text = "Busqueda_avanzada"
        CType(Me.dg_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_empleados.ResumeLayout(False)
        Me.pan_empleados.PerformLayout()
        Me.pan_categorias.ResumeLayout(False)
        Me.pan_categorias.PerformLayout()
        Me.pan_productos.ResumeLayout(False)
        Me.pan_productos.PerformLayout()
        Me.pan_clientes.ResumeLayout(False)
        Me.pan_clientes.PerformLayout()
        Me.pan_provedores.ResumeLayout(False)
        Me.pan_provedores.PerformLayout()
        Me.pan_roles.ResumeLayout(False)
        Me.pan_roles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_tablas As ComboBox
    Friend WithEvents lbl_tabla As Label
    Friend WithEvents dg_busqueda As DataGridView
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_id_empleados As Label
    Friend WithEvents lbl_correo_empleado As Label
    Friend WithEvents lbl_telefono_empleado As Label
    Friend WithEvents llb_rol_empleados As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_ape2_empleado As Label
    Friend WithEvents lbl_ape1_empleado As Label
    Friend WithEvents lbl_nom_empleados As Label
    Friend WithEvents pan_empleados As Panel
    Friend WithEvents tb_correo_emple As TextBox
    Friend WithEvents tb_telef_emple As TextBox
    Friend WithEvents tb_ape2_emple As TextBox
    Friend WithEvents tb_ape1_emple As TextBox
    Friend WithEvents tb_nom_emple As TextBox
    Friend WithEvents tb_id_emple As TextBox
    Friend WithEvents pan_categorias As Panel
    Friend WithEvents tb_desc_cat As TextBox
    Friend WithEvents tb_nom_cat As TextBox
    Friend WithEvents tb_id_cat As TextBox
    Friend WithEvents lbl_desc_categoria As Label
    Friend WithEvents lbl_nom_categoria As Label
    Friend WithEvents lbl_id_categoria As Label
    Friend WithEvents pan_productos As Panel
    Friend WithEvents pan_clientes As Panel
    Friend WithEvents pan_provedores As Panel
    Friend WithEvents tb_direccion_provedores As TextBox
    Friend WithEvents tb_contacto_ As TextBox
    Friend WithEvents tb_id_provedores As TextBox
    Friend WithEvents tb_nombre_provedores As TextBox
    Friend WithEvents tb_telefono_provedores As TextBox
    Friend WithEvents tb_ape1_clientes As TextBox
    Friend WithEvents tb_empleado_id_clientes As TextBox
    Friend WithEvents tb_telefono_clientes As TextBox
    Friend WithEvents tb_id_clientes As TextBox
    Friend WithEvents tb_nombre_clientes As TextBox
    Friend WithEvents tb_ape2_clientes As TextBox
    Friend WithEvents tb_precio_productos As TextBox
    Friend WithEvents tb_marca_productos As TextBox
    Friend WithEvents tb_stock_productos As TextBox
    Friend WithEvents tb_id_productos As TextBox
    Friend WithEvents tb_nombre_productos As TextBox
    Friend WithEvents tb_categoria_id_productos As TextBox
    Friend WithEvents pan_roles As Panel
    Friend WithEvents rb_rol_id As TextBox
    Friend WithEvents tb_rol_nombre As TextBox
    Friend WithEvents lbl_roles As Label
    Friend WithEvents lbl_productos As Label
    Friend WithEvents lbl_clientes As Label
    Friend WithEvents lbl_provedores As Label
    Friend WithEvents lbl_categorias As Label
    Friend WithEvents lbl_empleados As Label
    Friend WithEvents tb_rol_id_emple As TextBox
    Friend WithEvents lbl_rol_nombre As Label
    Friend WithEvents lbl_id_rol As Label
    Friend WithEvents lbl_id_clientes As Label
    Friend WithEvents lbl_nombre_clientes As Label
    Friend WithEvents lbl_ape1_clientes As Label
    Friend WithEvents lbl_ape2_clientes As Label
    Friend WithEvents lbl_telefono_cliente As Label
    Friend WithEvents lbl_id_empleado_clientes As Label
    Friend WithEvents lbl_nombre_provedores As Label
    Friend WithEvents lbl_id_provedores As Label
    Friend WithEvents lbl_contacto_provedores As Label
    Friend WithEvents lbl_telefono_provedores As Label
    Friend WithEvents lbl_direccion_provedores As Label
    Friend WithEvents lbl_marca_productos As Label
    Friend WithEvents lbl_stock_productos As Label
    Friend WithEvents lbl_categoria_producto As Label
    Friend WithEvents lbl_precio_producto As Label
    Friend WithEvents lbl_nombre_producto As Label
    Friend WithEvents lbl_id_productos As Label
End Class
