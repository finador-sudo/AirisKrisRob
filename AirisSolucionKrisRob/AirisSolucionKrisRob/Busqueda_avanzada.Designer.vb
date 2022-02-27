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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda_avanzada))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.pan_divisor = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_buscar = New System.Windows.Forms.PictureBox()
        Me.lbl_tabla = New System.Windows.Forms.Label()
        Me.cb_tablas = New System.Windows.Forms.ComboBox()
        Me.pan_empleados = New System.Windows.Forms.Panel()
        Me.tb_usuario_empleado = New System.Windows.Forms.TextBox()
        Me.lbl_usuario_empleado = New System.Windows.Forms.Label()
        Me.lbl_empleados = New System.Windows.Forms.Label()
        Me.tb_correo_emple = New System.Windows.Forms.TextBox()
        Me.tb_rol_emple = New System.Windows.Forms.TextBox()
        Me.tb_telef_emple = New System.Windows.Forms.TextBox()
        Me.tb_ape2_emple = New System.Windows.Forms.TextBox()
        Me.tb_ape1_emple = New System.Windows.Forms.TextBox()
        Me.tb_nom_emple = New System.Windows.Forms.TextBox()
        Me.tb_id_emple = New System.Windows.Forms.TextBox()
        Me.lbl_id_empleados = New System.Windows.Forms.Label()
        Me.lbl_correo_empleado = New System.Windows.Forms.Label()
        Me.lbl_telefono_empleado = New System.Windows.Forms.Label()
        Me.llb_rol_empleados = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_nom_empleados = New System.Windows.Forms.Label()
        Me.lbl_ape2_empleado = New System.Windows.Forms.Label()
        Me.lbl_ape1_empleado = New System.Windows.Forms.Label()
        Me.pan_roles = New System.Windows.Forms.Panel()
        Me.lbl_rol_nombre = New System.Windows.Forms.Label()
        Me.lbl_id_rol = New System.Windows.Forms.Label()
        Me.lbl_roles = New System.Windows.Forms.Label()
        Me.rb_rol_id = New System.Windows.Forms.TextBox()
        Me.tb_rol_nombre = New System.Windows.Forms.TextBox()
        Me.pan_categorias = New System.Windows.Forms.Panel()
        Me.lbl_categorias = New System.Windows.Forms.Label()
        Me.lbl_nom_categoria = New System.Windows.Forms.Label()
        Me.lbl_id_categoria = New System.Windows.Forms.Label()
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
        Me.pan_clientes = New System.Windows.Forms.Panel()
        Me.lbl_telefono_cliente = New System.Windows.Forms.Label()
        Me.lbl_ape2_clientes = New System.Windows.Forms.Label()
        Me.lbl_id_empleado_clientes = New System.Windows.Forms.Label()
        Me.tb_telefono_clientes = New System.Windows.Forms.TextBox()
        Me.lbl_id_clientes = New System.Windows.Forms.Label()
        Me.lbl_clientes = New System.Windows.Forms.Label()
        Me.tb_ape2_clientes = New System.Windows.Forms.TextBox()
        Me.tb_id_clientes = New System.Windows.Forms.TextBox()
        Me.tb_nombre_clientes = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_clientes = New System.Windows.Forms.Label()
        Me.lbl_ape1_clientes = New System.Windows.Forms.Label()
        Me.tb_ape1_clientes = New System.Windows.Forms.TextBox()
        Me.tb_empleado_id_clientes = New System.Windows.Forms.TextBox()
        Me.dg_busqueda = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_empleados.SuspendLayout()
        Me.pan_roles.SuspendLayout()
        Me.pan_categorias.SuspendLayout()
        Me.pan_productos.SuspendLayout()
        Me.pan_provedores.SuspendLayout()
        Me.pan_clientes.SuspendLayout()
        CType(Me.dg_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_buscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_cerrar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_divisor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_cerrar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_buscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_tabla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cb_tablas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_empleados)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_roles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_categorias)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_productos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_provedores)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pan_clientes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dg_busqueda)
        Me.SplitContainer1.Size = New System.Drawing.Size(720, 560)
        Me.SplitContainer1.SplitterDistance = 329
        Me.SplitContainer1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(237, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BÚSQUEDA AVANZADA"
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_buscar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_buscar.Location = New System.Drawing.Point(446, 92)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(53, 16)
        Me.lbl_buscar.TabIndex = 25
        Me.lbl_buscar.Text = "BUSCAR"
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lbl_cerrar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_cerrar.Location = New System.Drawing.Point(25, 17)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(54, 16)
        Me.lbl_cerrar.TabIndex = 24
        Me.lbl_cerrar.Text = "CERRAR"
        '
        'pan_divisor
        '
        Me.pan_divisor.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.pan_divisor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pan_divisor.Location = New System.Drawing.Point(0, 326)
        Me.pan_divisor.Name = "pan_divisor"
        Me.pan_divisor.Size = New System.Drawing.Size(720, 3)
        Me.pan_divisor.TabIndex = 23
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.estandar
        Me.btn_cerrar.Location = New System.Drawing.Point(12, 12)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(81, 36)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 22
        Me.btn_cerrar.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Recurso_2_2x
        Me.btn_buscar.Location = New System.Drawing.Point(430, 88)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(81, 36)
        Me.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buscar.TabIndex = 21
        Me.btn_buscar.TabStop = False
        '
        'lbl_tabla
        '
        Me.lbl_tabla.AutoSize = True
        Me.lbl_tabla.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_tabla.Location = New System.Drawing.Point(195, 88)
        Me.lbl_tabla.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tabla.Name = "lbl_tabla"
        Me.lbl_tabla.Size = New System.Drawing.Size(47, 20)
        Me.lbl_tabla.TabIndex = 1
        Me.lbl_tabla.Text = "Tabla:"
        '
        'cb_tablas
        '
        Me.cb_tablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tablas.FormattingEnabled = True
        Me.cb_tablas.Items.AddRange(New Object() {"Clientes", "Categorias de producto", "Roles", "Empleados", "Productos", "Provedores"})
        Me.cb_tablas.Location = New System.Drawing.Point(250, 89)
        Me.cb_tablas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cb_tablas.Name = "cb_tablas"
        Me.cb_tablas.Size = New System.Drawing.Size(164, 21)
        Me.cb_tablas.TabIndex = 0
        '
        'pan_empleados
        '
        Me.pan_empleados.BackgroundImage = CType(resources.GetObject("pan_empleados.BackgroundImage"), System.Drawing.Image)
        Me.pan_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_empleados.Controls.Add(Me.tb_usuario_empleado)
        Me.pan_empleados.Controls.Add(Me.lbl_usuario_empleado)
        Me.pan_empleados.Controls.Add(Me.lbl_empleados)
        Me.pan_empleados.Controls.Add(Me.tb_correo_emple)
        Me.pan_empleados.Controls.Add(Me.tb_rol_emple)
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
        Me.pan_empleados.Location = New System.Drawing.Point(166, 135)
        Me.pan_empleados.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_empleados.Name = "pan_empleados"
        Me.pan_empleados.Size = New System.Drawing.Size(377, 179)
        Me.pan_empleados.TabIndex = 14
        Me.pan_empleados.Visible = False
        '
        'tb_usuario_empleado
        '
        Me.tb_usuario_empleado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usuario_empleado.Location = New System.Drawing.Point(277, 142)
        Me.tb_usuario_empleado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_usuario_empleado.Name = "tb_usuario_empleado"
        Me.tb_usuario_empleado.Size = New System.Drawing.Size(81, 22)
        Me.tb_usuario_empleado.TabIndex = 23
        '
        'lbl_usuario_empleado
        '
        Me.lbl_usuario_empleado.AutoSize = True
        Me.lbl_usuario_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_usuario_empleado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_usuario_empleado.Location = New System.Drawing.Point(224, 144)
        Me.lbl_usuario_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_usuario_empleado.Name = "lbl_usuario_empleado"
        Me.lbl_usuario_empleado.Size = New System.Drawing.Size(48, 16)
        Me.lbl_usuario_empleado.TabIndex = 22
        Me.lbl_usuario_empleado.Text = "Usuario:"
        '
        'lbl_empleados
        '
        Me.lbl_empleados.AutoSize = True
        Me.lbl_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_empleados.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_empleados.Location = New System.Drawing.Point(8, 12)
        Me.lbl_empleados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_empleados.Name = "lbl_empleados"
        Me.lbl_empleados.Size = New System.Drawing.Size(77, 20)
        Me.lbl_empleados.TabIndex = 21
        Me.lbl_empleados.Text = "Empleados"
        '
        'tb_correo_emple
        '
        Me.tb_correo_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_correo_emple.Location = New System.Drawing.Point(277, 106)
        Me.tb_correo_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_correo_emple.Name = "tb_correo_emple"
        Me.tb_correo_emple.Size = New System.Drawing.Size(81, 22)
        Me.tb_correo_emple.TabIndex = 20
        '
        'tb_rol_emple
        '
        Me.tb_rol_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_rol_emple.Location = New System.Drawing.Point(277, 37)
        Me.tb_rol_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_rol_emple.Name = "tb_rol_emple"
        Me.tb_rol_emple.Size = New System.Drawing.Size(81, 22)
        Me.tb_rol_emple.TabIndex = 19
        '
        'tb_telef_emple
        '
        Me.tb_telef_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telef_emple.Location = New System.Drawing.Point(277, 71)
        Me.tb_telef_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_telef_emple.Name = "tb_telef_emple"
        Me.tb_telef_emple.Size = New System.Drawing.Size(81, 22)
        Me.tb_telef_emple.TabIndex = 18
        '
        'tb_ape2_emple
        '
        Me.tb_ape2_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ape2_emple.Location = New System.Drawing.Point(118, 141)
        Me.tb_ape2_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_ape2_emple.Name = "tb_ape2_emple"
        Me.tb_ape2_emple.Size = New System.Drawing.Size(83, 22)
        Me.tb_ape2_emple.TabIndex = 17
        '
        'tb_ape1_emple
        '
        Me.tb_ape1_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ape1_emple.Location = New System.Drawing.Point(118, 105)
        Me.tb_ape1_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_ape1_emple.Name = "tb_ape1_emple"
        Me.tb_ape1_emple.Size = New System.Drawing.Size(83, 22)
        Me.tb_ape1_emple.TabIndex = 16
        '
        'tb_nom_emple
        '
        Me.tb_nom_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nom_emple.Location = New System.Drawing.Point(118, 70)
        Me.tb_nom_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_nom_emple.Name = "tb_nom_emple"
        Me.tb_nom_emple.Size = New System.Drawing.Size(83, 22)
        Me.tb_nom_emple.TabIndex = 15
        '
        'tb_id_emple
        '
        Me.tb_id_emple.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id_emple.Location = New System.Drawing.Point(118, 36)
        Me.tb_id_emple.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_id_emple.Name = "tb_id_emple"
        Me.tb_id_emple.Size = New System.Drawing.Size(83, 22)
        Me.tb_id_emple.TabIndex = 14
        '
        'lbl_id_empleados
        '
        Me.lbl_id_empleados.AutoSize = True
        Me.lbl_id_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_empleados.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_empleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_empleados.Location = New System.Drawing.Point(79, 38)
        Me.lbl_id_empleados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_empleados.Name = "lbl_id_empleados"
        Me.lbl_id_empleados.Size = New System.Drawing.Size(22, 16)
        Me.lbl_id_empleados.TabIndex = 5
        Me.lbl_id_empleados.Text = "ID:"
        '
        'lbl_correo_empleado
        '
        Me.lbl_correo_empleado.AutoSize = True
        Me.lbl_correo_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_correo_empleado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correo_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_correo_empleado.Location = New System.Drawing.Point(224, 108)
        Me.lbl_correo_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_correo_empleado.Name = "lbl_correo_empleado"
        Me.lbl_correo_empleado.Size = New System.Drawing.Size(45, 16)
        Me.lbl_correo_empleado.TabIndex = 7
        Me.lbl_correo_empleado.Text = "Correo:"
        '
        'lbl_telefono_empleado
        '
        Me.lbl_telefono_empleado.AutoSize = True
        Me.lbl_telefono_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_telefono_empleado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_telefono_empleado.Location = New System.Drawing.Point(217, 74)
        Me.lbl_telefono_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_telefono_empleado.Name = "lbl_telefono_empleado"
        Me.lbl_telefono_empleado.Size = New System.Drawing.Size(52, 16)
        Me.lbl_telefono_empleado.TabIndex = 8
        Me.lbl_telefono_empleado.Text = "Teléfono:"
        '
        'llb_rol_empleados
        '
        Me.llb_rol_empleados.AutoSize = True
        Me.llb_rol_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.llb_rol_empleados.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llb_rol_empleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.llb_rol_empleados.Location = New System.Drawing.Point(224, 38)
        Me.llb_rol_empleados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.llb_rol_empleados.Name = "llb_rol_empleados"
        Me.llb_rol_empleados.Size = New System.Drawing.Size(27, 16)
        Me.llb_rol_empleados.TabIndex = 9
        Me.llb_rol_empleados.Text = "Rol:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 10
        '
        'lbl_nom_empleados
        '
        Me.lbl_nom_empleados.AutoSize = True
        Me.lbl_nom_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_nom_empleados.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_empleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_nom_empleados.Location = New System.Drawing.Point(55, 73)
        Me.lbl_nom_empleados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nom_empleados.Name = "lbl_nom_empleados"
        Me.lbl_nom_empleados.Size = New System.Drawing.Size(49, 16)
        Me.lbl_nom_empleados.TabIndex = 13
        Me.lbl_nom_empleados.Text = "Nombre:"
        '
        'lbl_ape2_empleado
        '
        Me.lbl_ape2_empleado.AutoSize = True
        Me.lbl_ape2_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_ape2_empleado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape2_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_ape2_empleado.Location = New System.Drawing.Point(18, 143)
        Me.lbl_ape2_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ape2_empleado.Name = "lbl_ape2_empleado"
        Me.lbl_ape2_empleado.Size = New System.Drawing.Size(93, 16)
        Me.lbl_ape2_empleado.TabIndex = 11
        Me.lbl_ape2_empleado.Text = "Segundo apellido:"
        '
        'lbl_ape1_empleado
        '
        Me.lbl_ape1_empleado.AutoSize = True
        Me.lbl_ape1_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_ape1_empleado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape1_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_ape1_empleado.Location = New System.Drawing.Point(25, 107)
        Me.lbl_ape1_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ape1_empleado.Name = "lbl_ape1_empleado"
        Me.lbl_ape1_empleado.Size = New System.Drawing.Size(81, 16)
        Me.lbl_ape1_empleado.TabIndex = 12
        Me.lbl_ape1_empleado.Text = "Primer apellido:"
        '
        'pan_roles
        '
        Me.pan_roles.BackgroundImage = CType(resources.GetObject("pan_roles.BackgroundImage"), System.Drawing.Image)
        Me.pan_roles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_roles.Controls.Add(Me.lbl_rol_nombre)
        Me.pan_roles.Controls.Add(Me.lbl_id_rol)
        Me.pan_roles.Controls.Add(Me.lbl_roles)
        Me.pan_roles.Controls.Add(Me.rb_rol_id)
        Me.pan_roles.Controls.Add(Me.tb_rol_nombre)
        Me.pan_roles.Location = New System.Drawing.Point(166, 135)
        Me.pan_roles.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_roles.Name = "pan_roles"
        Me.pan_roles.Size = New System.Drawing.Size(377, 179)
        Me.pan_roles.TabIndex = 20
        Me.pan_roles.Visible = False
        '
        'lbl_rol_nombre
        '
        Me.lbl_rol_nombre.AutoSize = True
        Me.lbl_rol_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_rol_nombre.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rol_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_rol_nombre.Location = New System.Drawing.Point(111, 97)
        Me.lbl_rol_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rol_nombre.Name = "lbl_rol_nombre"
        Me.lbl_rol_nombre.Size = New System.Drawing.Size(49, 16)
        Me.lbl_rol_nombre.TabIndex = 8
        Me.lbl_rol_nombre.Text = "Nombre:"
        '
        'lbl_id_rol
        '
        Me.lbl_id_rol.AutoSize = True
        Me.lbl_id_rol.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_rol.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_rol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_rol.Location = New System.Drawing.Point(138, 59)
        Me.lbl_id_rol.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_rol.Name = "lbl_id_rol"
        Me.lbl_id_rol.Size = New System.Drawing.Size(22, 16)
        Me.lbl_id_rol.TabIndex = 7
        Me.lbl_id_rol.Text = "ID:"
        '
        'lbl_roles
        '
        Me.lbl_roles.AutoSize = True
        Me.lbl_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_roles.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_roles.Location = New System.Drawing.Point(8, 12)
        Me.lbl_roles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_roles.Name = "lbl_roles"
        Me.lbl_roles.Size = New System.Drawing.Size(44, 20)
        Me.lbl_roles.TabIndex = 6
        Me.lbl_roles.Text = "Roles"
        '
        'rb_rol_id
        '
        Me.rb_rol_id.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_rol_id.Location = New System.Drawing.Point(178, 57)
        Me.rb_rol_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rb_rol_id.MaxLength = 20
        Me.rb_rol_id.Name = "rb_rol_id"
        Me.rb_rol_id.Size = New System.Drawing.Size(103, 22)
        Me.rb_rol_id.TabIndex = 2
        '
        'tb_rol_nombre
        '
        Me.tb_rol_nombre.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_rol_nombre.Location = New System.Drawing.Point(178, 95)
        Me.tb_rol_nombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_rol_nombre.MaxLength = 20
        Me.tb_rol_nombre.Name = "tb_rol_nombre"
        Me.tb_rol_nombre.Size = New System.Drawing.Size(103, 22)
        Me.tb_rol_nombre.TabIndex = 0
        '
        'pan_categorias
        '
        Me.pan_categorias.BackgroundImage = CType(resources.GetObject("pan_categorias.BackgroundImage"), System.Drawing.Image)
        Me.pan_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_categorias.Controls.Add(Me.lbl_categorias)
        Me.pan_categorias.Controls.Add(Me.lbl_nom_categoria)
        Me.pan_categorias.Controls.Add(Me.lbl_id_categoria)
        Me.pan_categorias.Controls.Add(Me.tb_nom_cat)
        Me.pan_categorias.Controls.Add(Me.tb_id_cat)
        Me.pan_categorias.Location = New System.Drawing.Point(166, 135)
        Me.pan_categorias.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_categorias.Name = "pan_categorias"
        Me.pan_categorias.Size = New System.Drawing.Size(377, 179)
        Me.pan_categorias.TabIndex = 15
        Me.pan_categorias.Visible = False
        '
        'lbl_categorias
        '
        Me.lbl_categorias.AutoSize = True
        Me.lbl_categorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_categorias.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categorias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_categorias.Location = New System.Drawing.Point(8, 12)
        Me.lbl_categorias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_categorias.Name = "lbl_categorias"
        Me.lbl_categorias.Size = New System.Drawing.Size(75, 20)
        Me.lbl_categorias.TabIndex = 7
        Me.lbl_categorias.Text = "Categorias"
        '
        'lbl_nom_categoria
        '
        Me.lbl_nom_categoria.AutoSize = True
        Me.lbl_nom_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_nom_categoria.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_nom_categoria.Location = New System.Drawing.Point(35, 93)
        Me.lbl_nom_categoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nom_categoria.Name = "lbl_nom_categoria"
        Me.lbl_nom_categoria.Size = New System.Drawing.Size(121, 16)
        Me.lbl_nom_categoria.TabIndex = 4
        Me.lbl_nom_categoria.Text = "Nombre de la categoría:"
        '
        'lbl_id_categoria
        '
        Me.lbl_id_categoria.AutoSize = True
        Me.lbl_id_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_categoria.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_categoria.Location = New System.Drawing.Point(134, 48)
        Me.lbl_id_categoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_categoria.Name = "lbl_id_categoria"
        Me.lbl_id_categoria.Size = New System.Drawing.Size(22, 16)
        Me.lbl_id_categoria.TabIndex = 3
        Me.lbl_id_categoria.Text = "ID:"
        '
        'tb_nom_cat
        '
        Me.tb_nom_cat.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nom_cat.Location = New System.Drawing.Point(171, 90)
        Me.tb_nom_cat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_nom_cat.MaxLength = 20
        Me.tb_nom_cat.Name = "tb_nom_cat"
        Me.tb_nom_cat.Size = New System.Drawing.Size(140, 22)
        Me.tb_nom_cat.TabIndex = 1
        '
        'tb_id_cat
        '
        Me.tb_id_cat.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id_cat.Location = New System.Drawing.Point(171, 45)
        Me.tb_id_cat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_id_cat.MaxLength = 20
        Me.tb_id_cat.Name = "tb_id_cat"
        Me.tb_id_cat.Size = New System.Drawing.Size(140, 22)
        Me.tb_id_cat.TabIndex = 0
        '
        'pan_productos
        '
        Me.pan_productos.BackgroundImage = CType(resources.GetObject("pan_productos.BackgroundImage"), System.Drawing.Image)
        Me.pan_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.pan_productos.Location = New System.Drawing.Point(166, 135)
        Me.pan_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_productos.Name = "pan_productos"
        Me.pan_productos.Size = New System.Drawing.Size(377, 179)
        Me.pan_productos.TabIndex = 17
        Me.pan_productos.Visible = False
        '
        'lbl_marca_productos
        '
        Me.lbl_marca_productos.AutoSize = True
        Me.lbl_marca_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_marca_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marca_productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_marca_productos.Location = New System.Drawing.Point(195, 128)
        Me.lbl_marca_productos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_marca_productos.Name = "lbl_marca_productos"
        Me.lbl_marca_productos.Size = New System.Drawing.Size(41, 16)
        Me.lbl_marca_productos.TabIndex = 13
        Me.lbl_marca_productos.Text = "Marca:"
        '
        'lbl_stock_productos
        '
        Me.lbl_stock_productos.AutoSize = True
        Me.lbl_stock_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_stock_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock_productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_stock_productos.Location = New System.Drawing.Point(200, 81)
        Me.lbl_stock_productos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_stock_productos.Name = "lbl_stock_productos"
        Me.lbl_stock_productos.Size = New System.Drawing.Size(36, 16)
        Me.lbl_stock_productos.TabIndex = 12
        Me.lbl_stock_productos.Text = "Stock:"
        '
        'lbl_categoria_producto
        '
        Me.lbl_categoria_producto.AutoSize = True
        Me.lbl_categoria_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_categoria_producto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria_producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_categoria_producto.Location = New System.Drawing.Point(179, 39)
        Me.lbl_categoria_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_categoria_producto.Name = "lbl_categoria_producto"
        Me.lbl_categoria_producto.Size = New System.Drawing.Size(57, 16)
        Me.lbl_categoria_producto.TabIndex = 11
        Me.lbl_categoria_producto.Text = "Categoria:"
        '
        'lbl_precio_producto
        '
        Me.lbl_precio_producto.AutoSize = True
        Me.lbl_precio_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_precio_producto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_precio_producto.Location = New System.Drawing.Point(32, 128)
        Me.lbl_precio_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_precio_producto.Name = "lbl_precio_producto"
        Me.lbl_precio_producto.Size = New System.Drawing.Size(41, 16)
        Me.lbl_precio_producto.TabIndex = 10
        Me.lbl_precio_producto.Text = "Precio:"
        '
        'lbl_nombre_producto
        '
        Me.lbl_nombre_producto.AutoSize = True
        Me.lbl_nombre_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_nombre_producto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_nombre_producto.Location = New System.Drawing.Point(24, 79)
        Me.lbl_nombre_producto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre_producto.Name = "lbl_nombre_producto"
        Me.lbl_nombre_producto.Size = New System.Drawing.Size(49, 16)
        Me.lbl_nombre_producto.TabIndex = 9
        Me.lbl_nombre_producto.Text = "Nombre:"
        '
        'lbl_id_productos
        '
        Me.lbl_id_productos.AutoSize = True
        Me.lbl_id_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_productos.Location = New System.Drawing.Point(51, 39)
        Me.lbl_id_productos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_productos.Name = "lbl_id_productos"
        Me.lbl_id_productos.Size = New System.Drawing.Size(22, 16)
        Me.lbl_id_productos.TabIndex = 8
        Me.lbl_id_productos.Text = "ID:"
        '
        'lbl_productos
        '
        Me.lbl_productos.AutoSize = True
        Me.lbl_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_productos.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_productos.Location = New System.Drawing.Point(8, 12)
        Me.lbl_productos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_productos.Name = "lbl_productos"
        Me.lbl_productos.Size = New System.Drawing.Size(72, 20)
        Me.lbl_productos.TabIndex = 7
        Me.lbl_productos.Text = "Productos"
        '
        'tb_precio_productos
        '
        Me.tb_precio_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_precio_productos.Location = New System.Drawing.Point(77, 125)
        Me.tb_precio_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_precio_productos.MaxLength = 20
        Me.tb_precio_productos.Name = "tb_precio_productos"
        Me.tb_precio_productos.Size = New System.Drawing.Size(90, 22)
        Me.tb_precio_productos.TabIndex = 5
        '
        'tb_marca_productos
        '
        Me.tb_marca_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_marca_productos.Location = New System.Drawing.Point(246, 126)
        Me.tb_marca_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_marca_productos.MaxLength = 20
        Me.tb_marca_productos.Name = "tb_marca_productos"
        Me.tb_marca_productos.Size = New System.Drawing.Size(101, 22)
        Me.tb_marca_productos.TabIndex = 4
        '
        'tb_stock_productos
        '
        Me.tb_stock_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_stock_productos.Location = New System.Drawing.Point(246, 79)
        Me.tb_stock_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_stock_productos.MaxLength = 20
        Me.tb_stock_productos.Name = "tb_stock_productos"
        Me.tb_stock_productos.Size = New System.Drawing.Size(101, 22)
        Me.tb_stock_productos.TabIndex = 3
        '
        'tb_id_productos
        '
        Me.tb_id_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id_productos.Location = New System.Drawing.Point(77, 37)
        Me.tb_id_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_id_productos.MaxLength = 20
        Me.tb_id_productos.Name = "tb_id_productos"
        Me.tb_id_productos.Size = New System.Drawing.Size(90, 22)
        Me.tb_id_productos.TabIndex = 2
        '
        'tb_nombre_productos
        '
        Me.tb_nombre_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre_productos.Location = New System.Drawing.Point(76, 79)
        Me.tb_nombre_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_nombre_productos.MaxLength = 20
        Me.tb_nombre_productos.Name = "tb_nombre_productos"
        Me.tb_nombre_productos.Size = New System.Drawing.Size(91, 22)
        Me.tb_nombre_productos.TabIndex = 1
        '
        'tb_categoria_id_productos
        '
        Me.tb_categoria_id_productos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_categoria_id_productos.Location = New System.Drawing.Point(246, 37)
        Me.tb_categoria_id_productos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_categoria_id_productos.MaxLength = 20
        Me.tb_categoria_id_productos.Name = "tb_categoria_id_productos"
        Me.tb_categoria_id_productos.Size = New System.Drawing.Size(101, 22)
        Me.tb_categoria_id_productos.TabIndex = 0
        '
        'pan_provedores
        '
        Me.pan_provedores.BackgroundImage = CType(resources.GetObject("pan_provedores.BackgroundImage"), System.Drawing.Image)
        Me.pan_provedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.pan_provedores.Location = New System.Drawing.Point(166, 135)
        Me.pan_provedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_provedores.Name = "pan_provedores"
        Me.pan_provedores.Size = New System.Drawing.Size(377, 179)
        Me.pan_provedores.TabIndex = 19
        Me.pan_provedores.Visible = False
        '
        'lbl_contacto_provedores
        '
        Me.lbl_contacto_provedores.AutoSize = True
        Me.lbl_contacto_provedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_contacto_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contacto_provedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_contacto_provedores.Location = New System.Drawing.Point(189, 83)
        Me.lbl_contacto_provedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_contacto_provedores.Name = "lbl_contacto_provedores"
        Me.lbl_contacto_provedores.Size = New System.Drawing.Size(52, 16)
        Me.lbl_contacto_provedores.TabIndex = 12
        Me.lbl_contacto_provedores.Text = "Contacto:"
        '
        'lbl_telefono_provedores
        '
        Me.lbl_telefono_provedores.AutoSize = True
        Me.lbl_telefono_provedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_telefono_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_provedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_telefono_provedores.Location = New System.Drawing.Point(189, 39)
        Me.lbl_telefono_provedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_telefono_provedores.Name = "lbl_telefono_provedores"
        Me.lbl_telefono_provedores.Size = New System.Drawing.Size(52, 16)
        Me.lbl_telefono_provedores.TabIndex = 11
        Me.lbl_telefono_provedores.Text = "Telefono:"
        '
        'lbl_direccion_provedores
        '
        Me.lbl_direccion_provedores.AutoSize = True
        Me.lbl_direccion_provedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_direccion_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_provedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_direccion_provedores.Location = New System.Drawing.Point(24, 128)
        Me.lbl_direccion_provedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_direccion_provedores.Name = "lbl_direccion_provedores"
        Me.lbl_direccion_provedores.Size = New System.Drawing.Size(55, 16)
        Me.lbl_direccion_provedores.TabIndex = 10
        Me.lbl_direccion_provedores.Text = "Direccion:"
        '
        'lbl_nombre_provedores
        '
        Me.lbl_nombre_provedores.AutoSize = True
        Me.lbl_nombre_provedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_nombre_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_provedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_nombre_provedores.Location = New System.Drawing.Point(29, 82)
        Me.lbl_nombre_provedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre_provedores.Name = "lbl_nombre_provedores"
        Me.lbl_nombre_provedores.Size = New System.Drawing.Size(49, 16)
        Me.lbl_nombre_provedores.TabIndex = 9
        Me.lbl_nombre_provedores.Text = "Nombre:"
        '
        'lbl_id_provedores
        '
        Me.lbl_id_provedores.AutoSize = True
        Me.lbl_id_provedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_provedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_provedores.Location = New System.Drawing.Point(51, 39)
        Me.lbl_id_provedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_provedores.Name = "lbl_id_provedores"
        Me.lbl_id_provedores.Size = New System.Drawing.Size(22, 16)
        Me.lbl_id_provedores.TabIndex = 8
        Me.lbl_id_provedores.Text = "ID:"
        '
        'lbl_provedores
        '
        Me.lbl_provedores.AutoSize = True
        Me.lbl_provedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_provedores.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_provedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_provedores.Location = New System.Drawing.Point(8, 12)
        Me.lbl_provedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_provedores.Name = "lbl_provedores"
        Me.lbl_provedores.Size = New System.Drawing.Size(79, 20)
        Me.lbl_provedores.TabIndex = 7
        Me.lbl_provedores.Text = "Provedores"
        '
        'tb_direccion_provedores
        '
        Me.tb_direccion_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_direccion_provedores.Location = New System.Drawing.Point(88, 125)
        Me.tb_direccion_provedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_direccion_provedores.MaxLength = 20
        Me.tb_direccion_provedores.Name = "tb_direccion_provedores"
        Me.tb_direccion_provedores.Size = New System.Drawing.Size(95, 22)
        Me.tb_direccion_provedores.TabIndex = 5
        '
        'tb_contacto_
        '
        Me.tb_contacto_.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contacto_.Location = New System.Drawing.Point(246, 81)
        Me.tb_contacto_.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_contacto_.MaxLength = 20
        Me.tb_contacto_.Name = "tb_contacto_"
        Me.tb_contacto_.Size = New System.Drawing.Size(101, 22)
        Me.tb_contacto_.TabIndex = 3
        '
        'tb_id_provedores
        '
        Me.tb_id_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id_provedores.Location = New System.Drawing.Point(88, 37)
        Me.tb_id_provedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_id_provedores.MaxLength = 20
        Me.tb_id_provedores.Name = "tb_id_provedores"
        Me.tb_id_provedores.Size = New System.Drawing.Size(96, 22)
        Me.tb_id_provedores.TabIndex = 2
        '
        'tb_nombre_provedores
        '
        Me.tb_nombre_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre_provedores.Location = New System.Drawing.Point(87, 79)
        Me.tb_nombre_provedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_nombre_provedores.MaxLength = 20
        Me.tb_nombre_provedores.Name = "tb_nombre_provedores"
        Me.tb_nombre_provedores.Size = New System.Drawing.Size(97, 22)
        Me.tb_nombre_provedores.TabIndex = 1
        '
        'tb_telefono_provedores
        '
        Me.tb_telefono_provedores.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono_provedores.Location = New System.Drawing.Point(246, 37)
        Me.tb_telefono_provedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_telefono_provedores.MaxLength = 20
        Me.tb_telefono_provedores.Name = "tb_telefono_provedores"
        Me.tb_telefono_provedores.Size = New System.Drawing.Size(101, 22)
        Me.tb_telefono_provedores.TabIndex = 0
        '
        'pan_clientes
        '
        Me.pan_clientes.BackgroundImage = CType(resources.GetObject("pan_clientes.BackgroundImage"), System.Drawing.Image)
        Me.pan_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_clientes.Controls.Add(Me.lbl_telefono_cliente)
        Me.pan_clientes.Controls.Add(Me.lbl_ape2_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_id_empleado_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_telefono_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_id_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_ape2_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_id_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_nombre_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_nombre_clientes)
        Me.pan_clientes.Controls.Add(Me.lbl_ape1_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_ape1_clientes)
        Me.pan_clientes.Controls.Add(Me.tb_empleado_id_clientes)
        Me.pan_clientes.Location = New System.Drawing.Point(166, 135)
        Me.pan_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pan_clientes.Name = "pan_clientes"
        Me.pan_clientes.Size = New System.Drawing.Size(377, 179)
        Me.pan_clientes.TabIndex = 18
        Me.pan_clientes.Visible = False
        '
        'lbl_telefono_cliente
        '
        Me.lbl_telefono_cliente.AutoSize = True
        Me.lbl_telefono_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_telefono_cliente.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_telefono_cliente.Location = New System.Drawing.Point(191, 133)
        Me.lbl_telefono_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_telefono_cliente.Name = "lbl_telefono_cliente"
        Me.lbl_telefono_cliente.Size = New System.Drawing.Size(52, 16)
        Me.lbl_telefono_cliente.TabIndex = 12
        Me.lbl_telefono_cliente.Text = "Telefono:"
        '
        'lbl_ape2_clientes
        '
        Me.lbl_ape2_clientes.AutoSize = True
        Me.lbl_ape2_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_ape2_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape2_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_ape2_clientes.Location = New System.Drawing.Point(189, 77)
        Me.lbl_ape2_clientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ape2_clientes.Name = "lbl_ape2_clientes"
        Me.lbl_ape2_clientes.Size = New System.Drawing.Size(54, 32)
        Me.lbl_ape2_clientes.TabIndex = 11
        Me.lbl_ape2_clientes.Text = "Segundo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apellido:"
        '
        'lbl_id_empleado_clientes
        '
        Me.lbl_id_empleado_clientes.AutoSize = True
        Me.lbl_id_empleado_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_empleado_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_empleado_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_empleado_clientes.Location = New System.Drawing.Point(18, 123)
        Me.lbl_id_empleado_clientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_empleado_clientes.Name = "lbl_id_empleado_clientes"
        Me.lbl_id_empleado_clientes.Size = New System.Drawing.Size(58, 32)
        Me.lbl_id_empleado_clientes.TabIndex = 13
        Me.lbl_id_empleado_clientes.Text = "Empleado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de ventas:"
        '
        'tb_telefono_clientes
        '
        Me.tb_telefono_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telefono_clientes.Location = New System.Drawing.Point(248, 129)
        Me.tb_telefono_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_telefono_clientes.MaxLength = 20
        Me.tb_telefono_clientes.Name = "tb_telefono_clientes"
        Me.tb_telefono_clientes.Size = New System.Drawing.Size(88, 22)
        Me.tb_telefono_clientes.TabIndex = 3
        '
        'lbl_id_clientes
        '
        Me.lbl_id_clientes.AutoSize = True
        Me.lbl_id_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_id_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_clientes.Location = New System.Drawing.Point(51, 48)
        Me.lbl_id_clientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_clientes.Name = "lbl_id_clientes"
        Me.lbl_id_clientes.Size = New System.Drawing.Size(22, 16)
        Me.lbl_id_clientes.TabIndex = 8
        Me.lbl_id_clientes.Text = "ID:"
        '
        'lbl_clientes
        '
        Me.lbl_clientes.AutoSize = True
        Me.lbl_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_clientes.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_clientes.Location = New System.Drawing.Point(8, 12)
        Me.lbl_clientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_clientes.Name = "lbl_clientes"
        Me.lbl_clientes.Size = New System.Drawing.Size(59, 20)
        Me.lbl_clientes.TabIndex = 7
        Me.lbl_clientes.Text = "Clientes"
        '
        'tb_ape2_clientes
        '
        Me.tb_ape2_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ape2_clientes.Location = New System.Drawing.Point(247, 83)
        Me.tb_ape2_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_ape2_clientes.MaxLength = 20
        Me.tb_ape2_clientes.Name = "tb_ape2_clientes"
        Me.tb_ape2_clientes.Size = New System.Drawing.Size(88, 22)
        Me.tb_ape2_clientes.TabIndex = 0
        '
        'tb_id_clientes
        '
        Me.tb_id_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id_clientes.Location = New System.Drawing.Point(77, 44)
        Me.tb_id_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_id_clientes.MaxLength = 20
        Me.tb_id_clientes.Name = "tb_id_clientes"
        Me.tb_id_clientes.Size = New System.Drawing.Size(90, 22)
        Me.tb_id_clientes.TabIndex = 2
        '
        'tb_nombre_clientes
        '
        Me.tb_nombre_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre_clientes.Location = New System.Drawing.Point(247, 44)
        Me.tb_nombre_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_nombre_clientes.MaxLength = 20
        Me.tb_nombre_clientes.Name = "tb_nombre_clientes"
        Me.tb_nombre_clientes.Size = New System.Drawing.Size(89, 22)
        Me.tb_nombre_clientes.TabIndex = 1
        '
        'lbl_nombre_clientes
        '
        Me.lbl_nombre_clientes.AutoSize = True
        Me.lbl_nombre_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_nombre_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_nombre_clientes.Location = New System.Drawing.Point(194, 48)
        Me.lbl_nombre_clientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre_clientes.Name = "lbl_nombre_clientes"
        Me.lbl_nombre_clientes.Size = New System.Drawing.Size(49, 16)
        Me.lbl_nombre_clientes.TabIndex = 9
        Me.lbl_nombre_clientes.Text = "Nombre:"
        '
        'lbl_ape1_clientes
        '
        Me.lbl_ape1_clientes.AutoSize = True
        Me.lbl_ape1_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_ape1_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape1_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_ape1_clientes.Location = New System.Drawing.Point(25, 77)
        Me.lbl_ape1_clientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ape1_clientes.Name = "lbl_ape1_clientes"
        Me.lbl_ape1_clientes.Size = New System.Drawing.Size(48, 32)
        Me.lbl_ape1_clientes.TabIndex = 10
        Me.lbl_ape1_clientes.Text = "Primer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apellido:"
        '
        'tb_ape1_clientes
        '
        Me.tb_ape1_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ape1_clientes.Location = New System.Drawing.Point(76, 83)
        Me.tb_ape1_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_ape1_clientes.MaxLength = 20
        Me.tb_ape1_clientes.Name = "tb_ape1_clientes"
        Me.tb_ape1_clientes.Size = New System.Drawing.Size(90, 22)
        Me.tb_ape1_clientes.TabIndex = 5
        '
        'tb_empleado_id_clientes
        '
        Me.tb_empleado_id_clientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_empleado_id_clientes.Location = New System.Drawing.Point(78, 129)
        Me.tb_empleado_id_clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_empleado_id_clientes.MaxLength = 20
        Me.tb_empleado_id_clientes.Name = "tb_empleado_id_clientes"
        Me.tb_empleado_id_clientes.Size = New System.Drawing.Size(88, 22)
        Me.tb_empleado_id_clientes.TabIndex = 4
        '
        'dg_busqueda
        '
        Me.dg_busqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_busqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_busqueda.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_busqueda.Location = New System.Drawing.Point(0, 0)
        Me.dg_busqueda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dg_busqueda.Name = "dg_busqueda"
        Me.dg_busqueda.ReadOnly = True
        Me.dg_busqueda.Size = New System.Drawing.Size(720, 227)
        Me.dg_busqueda.TabIndex = 2
        '
        'Busqueda_avanzada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(720, 560)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(736, 599)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(736, 599)
        Me.Name = "Busqueda_avanzada"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda avanzada"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_empleados.ResumeLayout(False)
        Me.pan_empleados.PerformLayout()
        Me.pan_roles.ResumeLayout(False)
        Me.pan_roles.PerformLayout()
        Me.pan_categorias.ResumeLayout(False)
        Me.pan_categorias.PerformLayout()
        Me.pan_productos.ResumeLayout(False)
        Me.pan_productos.PerformLayout()
        Me.pan_provedores.ResumeLayout(False)
        Me.pan_provedores.PerformLayout()
        Me.pan_clientes.ResumeLayout(False)
        Me.pan_clientes.PerformLayout()
        CType(Me.dg_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_buscar As Label
    Friend WithEvents lbl_cerrar As Label
    Friend WithEvents pan_divisor As Panel
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_buscar As PictureBox
    Friend WithEvents pan_categorias As Panel
    Friend WithEvents lbl_categorias As Label
    Friend WithEvents lbl_nom_categoria As Label
    Friend WithEvents lbl_id_categoria As Label
    Friend WithEvents tb_nom_cat As TextBox
    Friend WithEvents tb_id_cat As TextBox
    Friend WithEvents pan_productos As Panel
    Friend WithEvents lbl_marca_productos As Label
    Friend WithEvents lbl_stock_productos As Label
    Friend WithEvents lbl_categoria_producto As Label
    Friend WithEvents lbl_precio_producto As Label
    Friend WithEvents lbl_nombre_producto As Label
    Friend WithEvents lbl_id_productos As Label
    Friend WithEvents lbl_productos As Label
    Friend WithEvents tb_precio_productos As TextBox
    Friend WithEvents tb_marca_productos As TextBox
    Friend WithEvents tb_stock_productos As TextBox
    Friend WithEvents tb_id_productos As TextBox
    Friend WithEvents tb_nombre_productos As TextBox
    Friend WithEvents tb_categoria_id_productos As TextBox
    Friend WithEvents lbl_tabla As Label
    Friend WithEvents pan_provedores As Panel
    Friend WithEvents lbl_contacto_provedores As Label
    Friend WithEvents lbl_telefono_provedores As Label
    Friend WithEvents lbl_direccion_provedores As Label
    Friend WithEvents lbl_nombre_provedores As Label
    Friend WithEvents lbl_id_provedores As Label
    Friend WithEvents lbl_provedores As Label
    Friend WithEvents tb_direccion_provedores As TextBox
    Friend WithEvents tb_contacto_ As TextBox
    Friend WithEvents tb_id_provedores As TextBox
    Friend WithEvents tb_nombre_provedores As TextBox
    Friend WithEvents tb_telefono_provedores As TextBox
    Friend WithEvents cb_tablas As ComboBox
    Friend WithEvents pan_clientes As Panel
    Friend WithEvents lbl_telefono_cliente As Label
    Friend WithEvents lbl_ape2_clientes As Label
    Friend WithEvents lbl_id_empleado_clientes As Label
    Friend WithEvents tb_telefono_clientes As TextBox
    Friend WithEvents lbl_id_clientes As Label
    Friend WithEvents lbl_clientes As Label
    Friend WithEvents tb_ape2_clientes As TextBox
    Friend WithEvents tb_id_clientes As TextBox
    Friend WithEvents tb_nombre_clientes As TextBox
    Friend WithEvents lbl_nombre_clientes As Label
    Friend WithEvents lbl_ape1_clientes As Label
    Friend WithEvents tb_ape1_clientes As TextBox
    Friend WithEvents tb_empleado_id_clientes As TextBox
    Friend WithEvents pan_empleados As Panel
    Friend WithEvents lbl_empleados As Label
    Friend WithEvents tb_correo_emple As TextBox
    Friend WithEvents tb_rol_emple As TextBox
    Friend WithEvents tb_telef_emple As TextBox
    Friend WithEvents tb_ape2_emple As TextBox
    Friend WithEvents tb_ape1_emple As TextBox
    Friend WithEvents tb_nom_emple As TextBox
    Friend WithEvents tb_id_emple As TextBox
    Friend WithEvents lbl_id_empleados As Label
    Friend WithEvents lbl_correo_empleado As Label
    Friend WithEvents lbl_telefono_empleado As Label
    Friend WithEvents llb_rol_empleados As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_nom_empleados As Label
    Friend WithEvents lbl_ape2_empleado As Label
    Friend WithEvents lbl_ape1_empleado As Label
    Friend WithEvents pan_roles As Panel
    Friend WithEvents lbl_rol_nombre As Label
    Friend WithEvents lbl_id_rol As Label
    Friend WithEvents lbl_roles As Label
    Friend WithEvents rb_rol_id As TextBox
    Friend WithEvents tb_rol_nombre As TextBox
    Friend WithEvents dg_busqueda As DataGridView
    Friend WithEvents tb_usuario_empleado As TextBox
    Friend WithEvents lbl_usuario_empleado As Label
End Class
