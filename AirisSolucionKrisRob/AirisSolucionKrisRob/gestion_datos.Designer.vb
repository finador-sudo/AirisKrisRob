<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestion_datos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestion_datos))
        Me.toolstrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_busqueda = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_info = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_acerca = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_cerrar = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tss_barraprogreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.tss_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss_fechahora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tab_roles = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tb_roles_rol = New System.Windows.Forms.TextBox()
        Me.lbl_baja_roles = New System.Windows.Forms.Label()
        Me.lbl_roles_rol = New System.Windows.Forms.Label()
        Me.lbl_alta_roles = New System.Windows.Forms.Label()
        Me.lbl_roles_id = New System.Windows.Forms.Label()
        Me.lbl_mod_roles = New System.Windows.Forms.Label()
        Me.tb_roles_id = New System.Windows.Forms.TextBox()
        Me.ts_roles = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_rol = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_roles = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_roles = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_roles = New System.Windows.Forms.ToolStripLabel()
        Me.tab_empleados = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ts_empleados = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_empleados = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_empleados = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_empleados = New System.Windows.Forms.ToolStripLabel()
        Me.tb_proveedores = New System.Windows.Forms.TabPage()
        Me.lbl_proveedores_direccion = New System.Windows.Forms.Label()
        Me.lbl_proveedores_id = New System.Windows.Forms.Label()
        Me.lbl_proveedores_nombre = New System.Windows.Forms.Label()
        Me.lbl_proveedores_telefono = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dg_proveedores = New System.Windows.Forms.DataGridView()
        Me.btn_provedores_baja = New System.Windows.Forms.Button()
        Me.btn_provedores_alta = New System.Windows.Forms.Button()
        Me.btn_provedores_modificar = New System.Windows.Forms.Button()
        Me.tb_proveedores_direccion = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_telefono = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_contacto = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_nombre = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_id = New System.Windows.Forms.TextBox()
        Me.lbl_proveedores_contacto = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ts_proveedores = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_proveedores = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_provedores = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_proveedores = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_proveedores = New System.Windows.Forms.ToolStripLabel()
        Me.tb_clientes = New System.Windows.Forms.TabPage()
        Me.lbl_clientes_direccion = New System.Windows.Forms.Label()
        Me.tb_clientes_direccion = New System.Windows.Forms.TextBox()
        Me.tb_clientes_ape2 = New System.Windows.Forms.TextBox()
        Me.tb_clientes_ape1 = New System.Windows.Forms.TextBox()
        Me.tb_clientes_telefono = New System.Windows.Forms.TextBox()
        Me.tb_clientes_empleadoID = New System.Windows.Forms.TextBox()
        Me.tb_clientes_nombre = New System.Windows.Forms.TextBox()
        Me.tb_clientes_id = New System.Windows.Forms.TextBox()
        Me.lbl_clientes_ape2 = New System.Windows.Forms.Label()
        Me.lbl_clientes_ape1 = New System.Windows.Forms.Label()
        Me.lbl_clientes_nombre = New System.Windows.Forms.Label()
        Me.lbl_clientes_id = New System.Windows.Forms.Label()
        Me.lbl_clientes_empleadoID = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbl_clientes_telefono = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.btn_clientes_baja = New System.Windows.Forms.Button()
        Me.btn_clientes_alta = New System.Windows.Forms.Button()
        Me.btn_clientes_modificar = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ts_clientes = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tab_categorias = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tit_categoria = New System.Windows.Forms.Label()
        Me.lbl_baja_categoria = New System.Windows.Forms.Label()
        Me.lbl_mod_categoria = New System.Windows.Forms.Label()
        Me.tb_categorias_descripccion = New System.Windows.Forms.TextBox()
        Me.tb_categorias_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_categoria_descripcion = New System.Windows.Forms.Label()
        Me.lbl_alta_categoria = New System.Windows.Forms.Label()
        Me.lbl_categoria_nombre = New System.Windows.Forms.Label()
        Me.lbl_categoria_id = New System.Windows.Forms.Label()
        Me.tb_categorias_id = New System.Windows.Forms.TextBox()
        Me.dg_categorias = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_categoria = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_categoria_productos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_categorias_producto = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_categoria_productos = New System.Windows.Forms.ToolStripLabel()
        Me.tab_productos = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_baja_prod = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_alta_prod = New System.Windows.Forms.Label()
        Me.lbl_producto_stock = New System.Windows.Forms.Label()
        Me.lbl_productos_categoria_id = New System.Windows.Forms.Label()
        Me.lbl_productos_precio = New System.Windows.Forms.Label()
        Me.lbl_productos_nombre = New System.Windows.Forms.Label()
        Me.lbl_productos_id = New System.Windows.Forms.Label()
        Me.tb_productos_precio = New System.Windows.Forms.TextBox()
        Me.tb_productos_categoriaID = New System.Windows.Forms.TextBox()
        Me.tb_productos_stock = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.tb_productos_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_productos_id = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_productos_marca = New System.Windows.Forms.Label()
        Me.lbl_productos_descripccion = New System.Windows.Forms.Label()
        Me.tb_productos_descripccion = New System.Windows.Forms.TextBox()
        Me.tb_productos_marca = New System.Windows.Forms.TextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_producto = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_productos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_productos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel12 = New System.Windows.Forms.ToolStripLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tit_datos_emp = New System.Windows.Forms.Label()
        Me.dg_emple = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pan_datos_emple = New System.Windows.Forms.Panel()
        Me.pb5 = New System.Windows.Forms.PictureBox()
        Me.tb_emple_nom = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_cont_emple = New System.Windows.Forms.Label()
        Me.lbl_nom_emple = New System.Windows.Forms.Label()
        Me.lbl_rol_emple = New System.Windows.Forms.Label()
        Me.tb_emple_rol = New System.Windows.Forms.TextBox()
        Me.lbl_id_emple = New System.Windows.Forms.Label()
        Me.tb_emple_ape2 = New System.Windows.Forms.TextBox()
        Me.tb_emple_cont = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_email = New System.Windows.Forms.Label()
        Me.lbl_empleados_ape1 = New System.Windows.Forms.Label()
        Me.tit_emple = New System.Windows.Forms.Label()
        Me.tb_emple_tlf = New System.Windows.Forms.TextBox()
        Me.tb_emple_usu = New System.Windows.Forms.TextBox()
        Me.tb_emple_ape1 = New System.Windows.Forms.TextBox()
        Me.tb_emple_id = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_telefono = New System.Windows.Forms.Label()
        Me.tb_emple_correo = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_ape2 = New System.Windows.Forms.Label()
        Me.pb4 = New System.Windows.Forms.PictureBox()
        Me.pb7 = New System.Windows.Forms.PictureBox()
        Me.pb8 = New System.Windows.Forms.PictureBox()
        Me.pb9 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb6 = New System.Windows.Forms.PictureBox()
        Me.lbl_alta_empleados = New System.Windows.Forms.Label()
        Me.btn_emp_alta = New System.Windows.Forms.PictureBox()
        Me.lbl_baja_empleados = New System.Windows.Forms.Label()
        Me.btn_emp_baja = New System.Windows.Forms.PictureBox()
        Me.lbl_mod_empleados = New System.Windows.Forms.Label()
        Me.btn_emp_modif = New System.Windows.Forms.PictureBox()
        Me.pan_logo = New System.Windows.Forms.Panel()
        Me.pan_datos_roles = New System.Windows.Forms.Panel()
        Me.btn_mod_roles = New System.Windows.Forms.PictureBox()
        Me.btn_alta_rol = New System.Windows.Forms.PictureBox()
        Me.btn_baja_roles = New System.Windows.Forms.PictureBox()
        Me.pn_logo = New System.Windows.Forms.PictureBox()
        Me.pan_dg_rol = New System.Windows.Forms.Panel()
        Me.dg_roles = New System.Windows.Forms.DataGridView()
        Me.btn_mod_categoria = New System.Windows.Forms.PictureBox()
        Me.btn_alta_categoria = New System.Windows.Forms.PictureBox()
        Me.btn_baja_categoria = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btn_baja_prod = New System.Windows.Forms.PictureBox()
        Me.btn_alta_prod = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.ts_volverimg = New System.Windows.Forms.ToolStripButton()
        Me.tit_roles = New System.Windows.Forms.Label()
        Me.pb_rol = New System.Windows.Forms.PictureBox()
        Me.pb_id_rol = New System.Windows.Forms.PictureBox()
        Me.toolstrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.tab_roles.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ts_roles.SuspendLayout()
        Me.tab_empleados.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ts_empleados.SuspendLayout()
        Me.tb_proveedores.SuspendLayout()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_proveedores.SuspendLayout()
        Me.tb_clientes.SuspendLayout()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_clientes.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.tab_categorias.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dg_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.tab_productos.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_emple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_datos_emple.SuspendLayout()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_emp_alta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_emp_baja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_emp_modif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_datos_roles.SuspendLayout()
        CType(Me.btn_mod_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alta_rol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_baja_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pn_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_dg_rol.SuspendLayout()
        CType(Me.dg_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_mod_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alta_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_baja_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_baja_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alta_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_id_rol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstrip
        '
        Me.toolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_volverimg, Me.ToolStripSeparator2, Me.ts_busqueda, Me.ToolStripSeparator1, Me.ts_info, Me.ToolStripSeparator13, Me.ts_acerca, Me.ToolStripSeparator5, Me.ts_cerrar})
        Me.toolstrip.Location = New System.Drawing.Point(0, 0)
        Me.toolstrip.Name = "toolstrip"
        Me.toolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.toolstrip.Size = New System.Drawing.Size(1904, 30)
        Me.toolstrip.TabIndex = 1
        Me.toolstrip.Text = " "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ts_busqueda
        '
        Me.ts_busqueda.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_busqueda.Name = "ts_busqueda"
        Me.ts_busqueda.Size = New System.Drawing.Size(193, 27)
        Me.ts_busqueda.Text = "Realizar busqueda avanzada"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ts_info
        '
        Me.ts_info.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_info.Name = "ts_info"
        Me.ts_info.Size = New System.Drawing.Size(66, 27)
        Me.ts_info.Text = "Informes"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 30)
        '
        'ts_acerca
        '
        Me.ts_acerca.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_acerca.Name = "ts_acerca"
        Me.ts_acerca.Size = New System.Drawing.Size(85, 27)
        Me.ts_acerca.Text = "Acerca de..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'ts_cerrar
        '
        Me.ts_cerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_cerrar.Name = "ts_cerrar"
        Me.ts_cerrar.Size = New System.Drawing.Size(95, 27)
        Me.ts_cerrar.Text = "Cerrar sesión"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_barraprogreso, Me.tss_usuario, Me.tss_fechahora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1019)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1904, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tss_barraprogreso
        '
        Me.tss_barraprogreso.Name = "tss_barraprogreso"
        Me.tss_barraprogreso.Size = New System.Drawing.Size(100, 16)
        '
        'tss_usuario
        '
        Me.tss_usuario.Name = "tss_usuario"
        Me.tss_usuario.Size = New System.Drawing.Size(47, 17)
        Me.tss_usuario.Text = "Usuario"
        '
        'tss_fechahora
        '
        Me.tss_fechahora.Name = "tss_fechahora"
        Me.tss_fechahora.Size = New System.Drawing.Size(74, 17)
        Me.tss_fechahora.Text = "Fecha y hora"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'tab_roles
        '
        Me.tab_roles.Controls.Add(Me.SplitContainer2)
        Me.tab_roles.Controls.Add(Me.ts_roles)
        Me.tab_roles.Location = New System.Drawing.Point(4, 28)
        Me.tab_roles.Name = "tab_roles"
        Me.tab_roles.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_roles.Size = New System.Drawing.Size(1896, 957)
        Me.tab_roles.TabIndex = 10
        Me.tab_roles.Text = "Roles"
        Me.tab_roles.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.pan_datos_roles)
        Me.SplitContainer2.Panel1.Controls.Add(Me.pn_logo)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.pan_dg_rol)
        Me.SplitContainer2.Size = New System.Drawing.Size(1890, 926)
        Me.SplitContainer2.SplitterDistance = 1149
        Me.SplitContainer2.TabIndex = 106
        '
        'tb_roles_rol
        '
        Me.tb_roles_rol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_roles_rol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_roles_rol.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_roles_rol.Location = New System.Drawing.Point(511, 175)
        Me.tb_roles_rol.Name = "tb_roles_rol"
        Me.tb_roles_rol.Size = New System.Drawing.Size(173, 26)
        Me.tb_roles_rol.TabIndex = 14
        '
        'lbl_baja_roles
        '
        Me.lbl_baja_roles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_baja_roles.AutoSize = True
        Me.lbl_baja_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_baja_roles.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baja_roles.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_baja_roles.Location = New System.Drawing.Point(480, 296)
        Me.lbl_baja_roles.Name = "lbl_baja_roles"
        Me.lbl_baja_roles.Size = New System.Drawing.Size(70, 31)
        Me.lbl_baja_roles.TabIndex = 102
        Me.lbl_baja_roles.Text = "BAJA"
        '
        'lbl_roles_rol
        '
        Me.lbl_roles_rol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_roles_rol.AutoSize = True
        Me.lbl_roles_rol.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roles_rol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_roles_rol.Location = New System.Drawing.Point(335, 171)
        Me.lbl_roles_rol.Name = "lbl_roles_rol"
        Me.lbl_roles_rol.Size = New System.Drawing.Size(56, 33)
        Me.lbl_roles_rol.TabIndex = 13
        Me.lbl_roles_rol.Text = "Rol:"
        '
        'lbl_alta_roles
        '
        Me.lbl_alta_roles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_alta_roles.AutoSize = True
        Me.lbl_alta_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_alta_roles.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alta_roles.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_alta_roles.Location = New System.Drawing.Point(239, 296)
        Me.lbl_alta_roles.Name = "lbl_alta_roles"
        Me.lbl_alta_roles.Size = New System.Drawing.Size(70, 31)
        Me.lbl_alta_roles.TabIndex = 100
        Me.lbl_alta_roles.Text = "ALTA"
        '
        'lbl_roles_id
        '
        Me.lbl_roles_id.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_roles_id.AutoSize = True
        Me.lbl_roles_id.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roles_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_roles_id.Location = New System.Drawing.Point(344, 90)
        Me.lbl_roles_id.Name = "lbl_roles_id"
        Me.lbl_roles_id.Size = New System.Drawing.Size(46, 33)
        Me.lbl_roles_id.TabIndex = 12
        Me.lbl_roles_id.Text = "ID:"
        '
        'lbl_mod_roles
        '
        Me.lbl_mod_roles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_mod_roles.AutoSize = True
        Me.lbl_mod_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_mod_roles.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mod_roles.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_mod_roles.Location = New System.Drawing.Point(683, 296)
        Me.lbl_mod_roles.Name = "lbl_mod_roles"
        Me.lbl_mod_roles.Size = New System.Drawing.Size(138, 31)
        Me.lbl_mod_roles.TabIndex = 101
        Me.lbl_mod_roles.Text = "MODIFICAR"
        '
        'tb_roles_id
        '
        Me.tb_roles_id.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_roles_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_roles_id.Enabled = False
        Me.tb_roles_id.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_roles_id.Location = New System.Drawing.Point(511, 97)
        Me.tb_roles_id.Name = "tb_roles_id"
        Me.tb_roles_id.Size = New System.Drawing.Size(173, 26)
        Me.tb_roles_id.TabIndex = 11
        '
        'ts_roles
        '
        Me.ts_roles.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_roles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_roles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_roles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_rol, Me.ToolStripSeparator17, Me.tslbl_alta_roles, Me.ToolStripSeparator18, Me.tslbl_baja_roles, Me.tslbl_modificar_roles})
        Me.ts_roles.Location = New System.Drawing.Point(3, 3)
        Me.ts_roles.Name = "ts_roles"
        Me.ts_roles.Size = New System.Drawing.Size(1890, 25)
        Me.ts_roles.TabIndex = 103
        Me.ts_roles.Text = "ToolStrip2"
        '
        'tslbl_nuevo_rol
        '
        Me.tslbl_nuevo_rol.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_nuevo_rol.Name = "tslbl_nuevo_rol"
        Me.tslbl_nuevo_rol.Size = New System.Drawing.Size(48, 22)
        Me.tslbl_nuevo_rol.Text = "Nuevo"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_roles
        '
        Me.tslbl_alta_roles.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_alta_roles.Name = "tslbl_alta_roles"
        Me.tslbl_alta_roles.Size = New System.Drawing.Size(31, 22)
        Me.tslbl_alta_roles.Text = "Alta"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_roles
        '
        Me.tslbl_baja_roles.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_baja_roles.Name = "tslbl_baja_roles"
        Me.tslbl_baja_roles.Size = New System.Drawing.Size(35, 22)
        Me.tslbl_baja_roles.Text = "Baja"
        '
        'tslbl_modificar_roles
        '
        Me.tslbl_modificar_roles.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_modificar_roles.Name = "tslbl_modificar_roles"
        Me.tslbl_modificar_roles.Size = New System.Drawing.Size(63, 22)
        Me.tslbl_modificar_roles.Text = "Modificar"
        '
        'tab_empleados
        '
        Me.tab_empleados.BackColor = System.Drawing.Color.White
        Me.tab_empleados.Controls.Add(Me.SplitContainer1)
        Me.tab_empleados.Controls.Add(Me.ts_empleados)
        Me.tab_empleados.Location = New System.Drawing.Point(4, 28)
        Me.tab_empleados.Name = "tab_empleados"
        Me.tab_empleados.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_empleados.Size = New System.Drawing.Size(1896, 957)
        Me.tab_empleados.TabIndex = 9
        Me.tab_empleados.Text = "Empleados"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pan_datos_emple)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pan_logo)
        Me.SplitContainer1.Size = New System.Drawing.Size(1890, 926)
        Me.SplitContainer1.SplitterDistance = 427
        Me.SplitContainer1.TabIndex = 64
        '
        'ts_empleados
        '
        Me.ts_empleados.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_empleados.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_empleados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_empleados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo, Me.ToolStripSeparator3, Me.tslbl_alta_empleados, Me.ToolStripSeparator4, Me.tslbl_baja_empleados, Me.tslbl_modificar_empleados})
        Me.ts_empleados.Location = New System.Drawing.Point(3, 3)
        Me.ts_empleados.Name = "ts_empleados"
        Me.ts_empleados.Size = New System.Drawing.Size(1890, 25)
        Me.ts_empleados.TabIndex = 2
        Me.ts_empleados.Text = "ToolStrip2"
        '
        'tslbl_nuevo
        '
        Me.tslbl_nuevo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_nuevo.Name = "tslbl_nuevo"
        Me.tslbl_nuevo.Size = New System.Drawing.Size(50, 22)
        Me.tslbl_nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_empleados
        '
        Me.tslbl_alta_empleados.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_alta_empleados.Name = "tslbl_alta_empleados"
        Me.tslbl_alta_empleados.Size = New System.Drawing.Size(35, 22)
        Me.tslbl_alta_empleados.Text = "Alta"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_empleados
        '
        Me.tslbl_baja_empleados.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_baja_empleados.Name = "tslbl_baja_empleados"
        Me.tslbl_baja_empleados.Size = New System.Drawing.Size(38, 22)
        Me.tslbl_baja_empleados.Text = "Baja"
        '
        'tslbl_modificar_empleados
        '
        Me.tslbl_modificar_empleados.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_modificar_empleados.Name = "tslbl_modificar_empleados"
        Me.tslbl_modificar_empleados.Size = New System.Drawing.Size(70, 22)
        Me.tslbl_modificar_empleados.Text = "Modificar"
        '
        'tb_proveedores
        '
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_direccion)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_id)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_nombre)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_telefono)
        Me.tb_proveedores.Controls.Add(Me.Label25)
        Me.tb_proveedores.Controls.Add(Me.Label28)
        Me.tb_proveedores.Controls.Add(Me.dg_proveedores)
        Me.tb_proveedores.Controls.Add(Me.btn_provedores_baja)
        Me.tb_proveedores.Controls.Add(Me.btn_provedores_alta)
        Me.tb_proveedores.Controls.Add(Me.btn_provedores_modificar)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_direccion)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_telefono)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_contacto)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_nombre)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_id)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_contacto)
        Me.tb_proveedores.Controls.Add(Me.Label34)
        Me.tb_proveedores.Controls.Add(Me.Label35)
        Me.tb_proveedores.Controls.Add(Me.ts_proveedores)
        Me.tb_proveedores.Controls.Add(Me.PictureBox4)
        Me.tb_proveedores.Location = New System.Drawing.Point(4, 28)
        Me.tb_proveedores.Name = "tb_proveedores"
        Me.tb_proveedores.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_proveedores.Size = New System.Drawing.Size(1896, 957)
        Me.tb_proveedores.TabIndex = 8
        Me.tb_proveedores.Text = "Proveedores"
        Me.tb_proveedores.UseVisualStyleBackColor = True
        '
        'lbl_proveedores_direccion
        '
        Me.lbl_proveedores_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_direccion.AutoSize = True
        Me.lbl_proveedores_direccion.Location = New System.Drawing.Point(526, 511)
        Me.lbl_proveedores_direccion.Name = "lbl_proveedores_direccion"
        Me.lbl_proveedores_direccion.Size = New System.Drawing.Size(74, 19)
        Me.lbl_proveedores_direccion.TabIndex = 92
        Me.lbl_proveedores_direccion.Text = "Direccion:"
        '
        'lbl_proveedores_id
        '
        Me.lbl_proveedores_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_id.AutoSize = True
        Me.lbl_proveedores_id.Location = New System.Drawing.Point(526, 446)
        Me.lbl_proveedores_id.Name = "lbl_proveedores_id"
        Me.lbl_proveedores_id.Size = New System.Drawing.Size(27, 19)
        Me.lbl_proveedores_id.TabIndex = 90
        Me.lbl_proveedores_id.Text = "ID:"
        '
        'lbl_proveedores_nombre
        '
        Me.lbl_proveedores_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_nombre.AutoSize = True
        Me.lbl_proveedores_nombre.Location = New System.Drawing.Point(525, 476)
        Me.lbl_proveedores_nombre.Name = "lbl_proveedores_nombre"
        Me.lbl_proveedores_nombre.Size = New System.Drawing.Size(64, 19)
        Me.lbl_proveedores_nombre.TabIndex = 89
        Me.lbl_proveedores_nombre.Text = "Nombre:"
        '
        'lbl_proveedores_telefono
        '
        Me.lbl_proveedores_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_telefono.AutoSize = True
        Me.lbl_proveedores_telefono.Location = New System.Drawing.Point(802, 450)
        Me.lbl_proveedores_telefono.Name = "lbl_proveedores_telefono"
        Me.lbl_proveedores_telefono.Size = New System.Drawing.Size(69, 19)
        Me.lbl_proveedores_telefono.TabIndex = 87
        Me.lbl_proveedores_telefono.Text = "Teléfono:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(399, 511)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 19)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Dirección:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(372, 400)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 19)
        Me.Label28.TabIndex = 83
        Me.Label28.Text = "Label28"
        '
        'dg_proveedores
        '
        Me.dg_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_proveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_proveedores.Location = New System.Drawing.Point(3, 28)
        Me.dg_proveedores.Name = "dg_proveedores"
        Me.dg_proveedores.Size = New System.Drawing.Size(1890, 290)
        Me.dg_proveedores.TabIndex = 82
        '
        'btn_provedores_baja
        '
        Me.btn_provedores_baja.Location = New System.Drawing.Point(910, 511)
        Me.btn_provedores_baja.Name = "btn_provedores_baja"
        Me.btn_provedores_baja.Size = New System.Drawing.Size(75, 52)
        Me.btn_provedores_baja.TabIndex = 81
        Me.btn_provedores_baja.Text = "BAJA"
        Me.btn_provedores_baja.UseVisualStyleBackColor = True
        '
        'btn_provedores_alta
        '
        Me.btn_provedores_alta.Location = New System.Drawing.Point(829, 511)
        Me.btn_provedores_alta.Name = "btn_provedores_alta"
        Me.btn_provedores_alta.Size = New System.Drawing.Size(75, 52)
        Me.btn_provedores_alta.TabIndex = 80
        Me.btn_provedores_alta.Text = "ALTA"
        Me.btn_provedores_alta.UseVisualStyleBackColor = True
        '
        'btn_provedores_modificar
        '
        Me.btn_provedores_modificar.Location = New System.Drawing.Point(986, 511)
        Me.btn_provedores_modificar.Name = "btn_provedores_modificar"
        Me.btn_provedores_modificar.Size = New System.Drawing.Size(75, 52)
        Me.btn_provedores_modificar.TabIndex = 79
        Me.btn_provedores_modificar.Text = "MODIFICAR"
        Me.btn_provedores_modificar.UseVisualStyleBackColor = True
        '
        'tb_proveedores_direccion
        '
        Me.tb_proveedores_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_direccion.Location = New System.Drawing.Point(608, 507)
        Me.tb_proveedores_direccion.Name = "tb_proveedores_direccion"
        Me.tb_proveedores_direccion.Size = New System.Drawing.Size(289, 27)
        Me.tb_proveedores_direccion.TabIndex = 78
        '
        'tb_proveedores_telefono
        '
        Me.tb_proveedores_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_telefono.Location = New System.Drawing.Point(952, 447)
        Me.tb_proveedores_telefono.Name = "tb_proveedores_telefono"
        Me.tb_proveedores_telefono.Size = New System.Drawing.Size(117, 27)
        Me.tb_proveedores_telefono.TabIndex = 76
        '
        'tb_proveedores_contacto
        '
        Me.tb_proveedores_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_contacto.Location = New System.Drawing.Point(952, 477)
        Me.tb_proveedores_contacto.Name = "tb_proveedores_contacto"
        Me.tb_proveedores_contacto.Size = New System.Drawing.Size(117, 27)
        Me.tb_proveedores_contacto.TabIndex = 75
        '
        'tb_proveedores_nombre
        '
        Me.tb_proveedores_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_nombre.Location = New System.Drawing.Point(608, 475)
        Me.tb_proveedores_nombre.Name = "tb_proveedores_nombre"
        Me.tb_proveedores_nombre.Size = New System.Drawing.Size(117, 27)
        Me.tb_proveedores_nombre.TabIndex = 74
        '
        'tb_proveedores_id
        '
        Me.tb_proveedores_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_id.Enabled = False
        Me.tb_proveedores_id.Location = New System.Drawing.Point(608, 446)
        Me.tb_proveedores_id.Name = "tb_proveedores_id"
        Me.tb_proveedores_id.Size = New System.Drawing.Size(117, 27)
        Me.tb_proveedores_id.TabIndex = 70
        '
        'lbl_proveedores_contacto
        '
        Me.lbl_proveedores_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_contacto.AutoSize = True
        Me.lbl_proveedores_contacto.Location = New System.Drawing.Point(802, 480)
        Me.lbl_proveedores_contacto.Name = "lbl_proveedores_contacto"
        Me.lbl_proveedores_contacto.Size = New System.Drawing.Size(71, 19)
        Me.lbl_proveedores_contacto.TabIndex = 73
        Me.lbl_proveedores_contacto.Text = "Contacto:"
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(406, 479)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 19)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "Nombre:"
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(433, 450)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(27, 19)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "ID:"
        '
        'ts_proveedores
        '
        Me.ts_proveedores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_proveedores.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_proveedores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_proveedores, Me.ToolStripSeparator15, Me.tslbl_alta_provedores, Me.ToolStripSeparator16, Me.tslbl_baja_proveedores, Me.tslbl_modificar_proveedores})
        Me.ts_proveedores.Location = New System.Drawing.Point(3, 3)
        Me.ts_proveedores.Name = "ts_proveedores"
        Me.ts_proveedores.Size = New System.Drawing.Size(1890, 25)
        Me.ts_proveedores.TabIndex = 88
        Me.ts_proveedores.Text = "ToolStrip5"
        '
        'tslbl_nuevo_proveedores
        '
        Me.tslbl_nuevo_proveedores.Name = "tslbl_nuevo_proveedores"
        Me.tslbl_nuevo_proveedores.Size = New System.Drawing.Size(42, 22)
        Me.tslbl_nuevo_proveedores.Text = "Nuevo"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_provedores
        '
        Me.tslbl_alta_provedores.Name = "tslbl_alta_provedores"
        Me.tslbl_alta_provedores.Size = New System.Drawing.Size(28, 22)
        Me.tslbl_alta_provedores.Text = "Alta"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_proveedores
        '
        Me.tslbl_baja_proveedores.Name = "tslbl_baja_proveedores"
        Me.tslbl_baja_proveedores.Size = New System.Drawing.Size(29, 22)
        Me.tslbl_baja_proveedores.Text = "Baja"
        '
        'tslbl_modificar_proveedores
        '
        Me.tslbl_modificar_proveedores.Name = "tslbl_modificar_proveedores"
        Me.tslbl_modificar_proveedores.Size = New System.Drawing.Size(58, 22)
        Me.tslbl_modificar_proveedores.Text = "Modificar"
        '
        'tb_clientes
        '
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_direccion)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_direccion)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_ape2)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_ape1)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_telefono)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_empleadoID)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_nombre)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_id)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_ape2)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_ape1)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_nombre)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_id)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_empleadoID)
        Me.tb_clientes.Controls.Add(Me.Label31)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_telefono)
        Me.tb_clientes.Controls.Add(Me.Label9)
        Me.tb_clientes.Controls.Add(Me.dg_clientes)
        Me.tb_clientes.Controls.Add(Me.btn_clientes_baja)
        Me.tb_clientes.Controls.Add(Me.btn_clientes_alta)
        Me.tb_clientes.Controls.Add(Me.btn_clientes_modificar)
        Me.tb_clientes.Controls.Add(Me.Label26)
        Me.tb_clientes.Controls.Add(Me.Label29)
        Me.tb_clientes.Controls.Add(Me.ts_clientes)
        Me.tb_clientes.Controls.Add(Me.PictureBox3)
        Me.tb_clientes.Location = New System.Drawing.Point(4, 28)
        Me.tb_clientes.Name = "tb_clientes"
        Me.tb_clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_clientes.Size = New System.Drawing.Size(1896, 957)
        Me.tb_clientes.TabIndex = 7
        Me.tb_clientes.Text = "Clientes"
        Me.tb_clientes.UseVisualStyleBackColor = True
        '
        'lbl_clientes_direccion
        '
        Me.lbl_clientes_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_direccion.Location = New System.Drawing.Point(536, 527)
        Me.lbl_clientes_direccion.Name = "lbl_clientes_direccion"
        Me.lbl_clientes_direccion.Size = New System.Drawing.Size(53, 14)
        Me.lbl_clientes_direccion.TabIndex = 94
        Me.lbl_clientes_direccion.Text = "Direccion:"
        '
        'tb_clientes_direccion
        '
        Me.tb_clientes_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_direccion.Location = New System.Drawing.Point(618, 523)
        Me.tb_clientes_direccion.Name = "tb_clientes_direccion"
        Me.tb_clientes_direccion.Size = New System.Drawing.Size(273, 27)
        Me.tb_clientes_direccion.TabIndex = 93
        '
        'tb_clientes_ape2
        '
        Me.tb_clientes_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_ape2.Location = New System.Drawing.Point(879, 499)
        Me.tb_clientes_ape2.Name = "tb_clientes_ape2"
        Me.tb_clientes_ape2.Size = New System.Drawing.Size(117, 27)
        Me.tb_clientes_ape2.TabIndex = 75
        '
        'tb_clientes_ape1
        '
        Me.tb_clientes_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_ape1.Location = New System.Drawing.Point(618, 493)
        Me.tb_clientes_ape1.Name = "tb_clientes_ape1"
        Me.tb_clientes_ape1.Size = New System.Drawing.Size(117, 27)
        Me.tb_clientes_ape1.TabIndex = 59
        '
        'tb_clientes_telefono
        '
        Me.tb_clientes_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_telefono.Location = New System.Drawing.Point(880, 434)
        Me.tb_clientes_telefono.Name = "tb_clientes_telefono"
        Me.tb_clientes_telefono.Size = New System.Drawing.Size(117, 27)
        Me.tb_clientes_telefono.TabIndex = 58
        '
        'tb_clientes_empleadoID
        '
        Me.tb_clientes_empleadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_empleadoID.Location = New System.Drawing.Point(880, 466)
        Me.tb_clientes_empleadoID.Name = "tb_clientes_empleadoID"
        Me.tb_clientes_empleadoID.Size = New System.Drawing.Size(117, 27)
        Me.tb_clientes_empleadoID.TabIndex = 57
        '
        'tb_clientes_nombre
        '
        Me.tb_clientes_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_nombre.Location = New System.Drawing.Point(618, 463)
        Me.tb_clientes_nombre.Name = "tb_clientes_nombre"
        Me.tb_clientes_nombre.Size = New System.Drawing.Size(117, 27)
        Me.tb_clientes_nombre.TabIndex = 54
        '
        'tb_clientes_id
        '
        Me.tb_clientes_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_id.Enabled = False
        Me.tb_clientes_id.Location = New System.Drawing.Point(618, 434)
        Me.tb_clientes_id.Name = "tb_clientes_id"
        Me.tb_clientes_id.Size = New System.Drawing.Size(117, 27)
        Me.tb_clientes_id.TabIndex = 47
        '
        'lbl_clientes_ape2
        '
        Me.lbl_clientes_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_ape2.AutoSize = True
        Me.lbl_clientes_ape2.Location = New System.Drawing.Point(782, 499)
        Me.lbl_clientes_ape2.Name = "lbl_clientes_ape2"
        Me.lbl_clientes_ape2.Size = New System.Drawing.Size(125, 19)
        Me.lbl_clientes_ape2.TabIndex = 74
        Me.lbl_clientes_ape2.Text = "Segundo Apellido:"
        '
        'lbl_clientes_ape1
        '
        Me.lbl_clientes_ape1.AutoSize = True
        Me.lbl_clientes_ape1.Location = New System.Drawing.Point(56, 497)
        Me.lbl_clientes_ape1.Name = "lbl_clientes_ape1"
        Me.lbl_clientes_ape1.Size = New System.Drawing.Size(112, 19)
        Me.lbl_clientes_ape1.TabIndex = 73
        Me.lbl_clientes_ape1.Text = "Primer Apellido:"
        '
        'lbl_clientes_nombre
        '
        Me.lbl_clientes_nombre.AutoSize = True
        Me.lbl_clientes_nombre.Location = New System.Drawing.Point(56, 466)
        Me.lbl_clientes_nombre.Name = "lbl_clientes_nombre"
        Me.lbl_clientes_nombre.Size = New System.Drawing.Size(64, 19)
        Me.lbl_clientes_nombre.TabIndex = 72
        Me.lbl_clientes_nombre.Text = "Nombre:"
        '
        'lbl_clientes_id
        '
        Me.lbl_clientes_id.AutoSize = True
        Me.lbl_clientes_id.Location = New System.Drawing.Point(56, 434)
        Me.lbl_clientes_id.Name = "lbl_clientes_id"
        Me.lbl_clientes_id.Size = New System.Drawing.Size(27, 19)
        Me.lbl_clientes_id.TabIndex = 71
        Me.lbl_clientes_id.Text = "ID:"
        '
        'lbl_clientes_empleadoID
        '
        Me.lbl_clientes_empleadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_empleadoID.AutoSize = True
        Me.lbl_clientes_empleadoID.Location = New System.Drawing.Point(806, 469)
        Me.lbl_clientes_empleadoID.Name = "lbl_clientes_empleadoID"
        Me.lbl_clientes_empleadoID.Size = New System.Drawing.Size(95, 19)
        Me.lbl_clientes_empleadoID.TabIndex = 69
        Me.lbl_clientes_empleadoID.Text = "Empleado ID:"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(376, 499)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(111, 19)
        Me.Label31.TabIndex = 68
        Me.Label31.Text = "Primer apellido:"
        '
        'lbl_clientes_telefono
        '
        Me.lbl_clientes_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_telefono.AutoSize = True
        Me.lbl_clientes_telefono.Location = New System.Drawing.Point(824, 434)
        Me.lbl_clientes_telefono.Name = "lbl_clientes_telefono"
        Me.lbl_clientes_telefono.Size = New System.Drawing.Size(69, 19)
        Me.lbl_clientes_telefono.TabIndex = 67
        Me.lbl_clientes_telefono.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 388)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Label9"
        '
        'dg_clientes
        '
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_clientes.Location = New System.Drawing.Point(3, 28)
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.Size = New System.Drawing.Size(1890, 290)
        Me.dg_clientes.TabIndex = 63
        '
        'btn_clientes_baja
        '
        Me.btn_clientes_baja.Location = New System.Drawing.Point(949, 527)
        Me.btn_clientes_baja.Name = "btn_clientes_baja"
        Me.btn_clientes_baja.Size = New System.Drawing.Size(75, 52)
        Me.btn_clientes_baja.TabIndex = 62
        Me.btn_clientes_baja.Text = "BAJA"
        Me.btn_clientes_baja.UseVisualStyleBackColor = True
        '
        'btn_clientes_alta
        '
        Me.btn_clientes_alta.Location = New System.Drawing.Point(868, 527)
        Me.btn_clientes_alta.Name = "btn_clientes_alta"
        Me.btn_clientes_alta.Size = New System.Drawing.Size(75, 52)
        Me.btn_clientes_alta.TabIndex = 61
        Me.btn_clientes_alta.Text = "ALTA"
        Me.btn_clientes_alta.UseVisualStyleBackColor = True
        '
        'btn_clientes_modificar
        '
        Me.btn_clientes_modificar.Location = New System.Drawing.Point(1025, 527)
        Me.btn_clientes_modificar.Name = "btn_clientes_modificar"
        Me.btn_clientes_modificar.Size = New System.Drawing.Size(75, 52)
        Me.btn_clientes_modificar.TabIndex = 60
        Me.btn_clientes_modificar.Text = "MODIFICAR"
        Me.btn_clientes_modificar.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(406, 467)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 19)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "Nombre:"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(433, 438)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(27, 19)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "ID:"
        '
        'ts_clientes
        '
        Me.ts_clientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_clientes.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_clientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_clientes, Me.ToolStripSeparator12, Me.tslbl_alta_clientes, Me.ToolStripSeparator14, Me.tslbl_baja_clientes, Me.tslbl_modificar_clientes})
        Me.ts_clientes.Location = New System.Drawing.Point(3, 3)
        Me.ts_clientes.Name = "ts_clientes"
        Me.ts_clientes.Size = New System.Drawing.Size(1890, 25)
        Me.ts_clientes.TabIndex = 70
        Me.ts_clientes.Text = "ToolStrip4"
        '
        'tslbl_nuevo_clientes
        '
        Me.tslbl_nuevo_clientes.Name = "tslbl_nuevo_clientes"
        Me.tslbl_nuevo_clientes.Size = New System.Drawing.Size(42, 22)
        Me.tslbl_nuevo_clientes.Text = "Nuevo"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_clientes
        '
        Me.tslbl_alta_clientes.Name = "tslbl_alta_clientes"
        Me.tslbl_alta_clientes.Size = New System.Drawing.Size(28, 22)
        Me.tslbl_alta_clientes.Text = "Alta"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_clientes
        '
        Me.tslbl_baja_clientes.Name = "tslbl_baja_clientes"
        Me.tslbl_baja_clientes.Size = New System.Drawing.Size(29, 22)
        Me.tslbl_baja_clientes.Text = "Baja"
        '
        'tslbl_modificar_clientes
        '
        Me.tslbl_modificar_clientes.Name = "tslbl_modificar_clientes"
        Me.tslbl_modificar_clientes.Size = New System.Drawing.Size(58, 22)
        Me.tslbl_modificar_clientes.Text = "Modificar"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tb_clientes)
        Me.TabControl.Controls.Add(Me.tb_proveedores)
        Me.TabControl.Controls.Add(Me.tab_empleados)
        Me.TabControl.Controls.Add(Me.tab_roles)
        Me.TabControl.Controls.Add(Me.tab_categorias)
        Me.TabControl.Controls.Add(Me.tab_productos)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 30)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1904, 989)
        Me.TabControl.TabIndex = 0
        '
        'tab_categorias
        '
        Me.tab_categorias.Controls.Add(Me.SplitContainer3)
        Me.tab_categorias.Controls.Add(Me.ToolStrip2)
        Me.tab_categorias.Location = New System.Drawing.Point(4, 28)
        Me.tab_categorias.Name = "tab_categorias"
        Me.tab_categorias.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_categorias.Size = New System.Drawing.Size(1896, 957)
        Me.tab_categorias.TabIndex = 11
        Me.tab_categorias.Text = "Categorías productos"
        Me.tab_categorias.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.tit_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_baja_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_mod_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.tb_categorias_descripccion)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_mod_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.tb_categorias_nombre)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_categoria_descripcion)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_alta_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_categoria_nombre)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_alta_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lbl_categoria_id)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_baja_categoria)
        Me.SplitContainer3.Panel1.Controls.Add(Me.tb_categorias_id)
        Me.SplitContainer3.Panel1.Controls.Add(Me.PictureBox9)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.dg_categorias)
        Me.SplitContainer3.Size = New System.Drawing.Size(1890, 926)
        Me.SplitContainer3.SplitterDistance = 1386
        Me.SplitContainer3.TabIndex = 114
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1353, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(33, 926)
        Me.Panel4.TabIndex = 107
        '
        'tit_categoria
        '
        Me.tit_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tit_categoria.AutoSize = True
        Me.tit_categoria.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tit_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.tit_categoria.Location = New System.Drawing.Point(688, 50)
        Me.tit_categoria.Name = "tit_categoria"
        Me.tit_categoria.Size = New System.Drawing.Size(203, 31)
        Me.tit_categoria.TabIndex = 107
        Me.tit_categoria.Text = "Datos de categoría:"
        '
        'lbl_baja_categoria
        '
        Me.lbl_baja_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_baja_categoria.AutoSize = True
        Me.lbl_baja_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.lbl_baja_categoria.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baja_categoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_baja_categoria.Location = New System.Drawing.Point(741, 388)
        Me.lbl_baja_categoria.Name = "lbl_baja_categoria"
        Me.lbl_baja_categoria.Size = New System.Drawing.Size(70, 31)
        Me.lbl_baja_categoria.TabIndex = 113
        Me.lbl_baja_categoria.Text = "BAJA"
        '
        'lbl_mod_categoria
        '
        Me.lbl_mod_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mod_categoria.AutoSize = True
        Me.lbl_mod_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_mod_categoria.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mod_categoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_mod_categoria.Location = New System.Drawing.Point(944, 388)
        Me.lbl_mod_categoria.Name = "lbl_mod_categoria"
        Me.lbl_mod_categoria.Size = New System.Drawing.Size(138, 31)
        Me.lbl_mod_categoria.TabIndex = 112
        Me.lbl_mod_categoria.Text = "MODIFICAR"
        '
        'tb_categorias_descripccion
        '
        Me.tb_categorias_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_descripccion.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_categorias_descripccion.Location = New System.Drawing.Point(676, 257)
        Me.tb_categorias_descripccion.Multiline = True
        Me.tb_categorias_descripccion.Name = "tb_categorias_descripccion"
        Me.tb_categorias_descripccion.Size = New System.Drawing.Size(206, 83)
        Me.tb_categorias_descripccion.TabIndex = 23
        '
        'tb_categorias_nombre
        '
        Me.tb_categorias_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_nombre.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_categorias_nombre.Location = New System.Drawing.Point(676, 182)
        Me.tb_categorias_nombre.Name = "tb_categorias_nombre"
        Me.tb_categorias_nombre.Size = New System.Drawing.Size(206, 32)
        Me.tb_categorias_nombre.TabIndex = 22
        '
        'lbl_categoria_descripcion
        '
        Me.lbl_categoria_descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_descripcion.AutoSize = True
        Me.lbl_categoria_descripcion.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria_descripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_categoria_descripcion.Location = New System.Drawing.Point(520, 261)
        Me.lbl_categoria_descripcion.Name = "lbl_categoria_descripcion"
        Me.lbl_categoria_descripcion.Size = New System.Drawing.Size(96, 23)
        Me.lbl_categoria_descripcion.TabIndex = 21
        Me.lbl_categoria_descripcion.Text = "Descripción:"
        '
        'lbl_alta_categoria
        '
        Me.lbl_alta_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_alta_categoria.AutoSize = True
        Me.lbl_alta_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lbl_alta_categoria.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alta_categoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_alta_categoria.Location = New System.Drawing.Point(499, 383)
        Me.lbl_alta_categoria.Name = "lbl_alta_categoria"
        Me.lbl_alta_categoria.Size = New System.Drawing.Size(70, 31)
        Me.lbl_alta_categoria.TabIndex = 111
        Me.lbl_alta_categoria.Text = "ALTA"
        '
        'lbl_categoria_nombre
        '
        Me.lbl_categoria_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_nombre.AutoSize = True
        Me.lbl_categoria_nombre.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_categoria_nombre.Location = New System.Drawing.Point(440, 186)
        Me.lbl_categoria_nombre.Name = "lbl_categoria_nombre"
        Me.lbl_categoria_nombre.Size = New System.Drawing.Size(176, 23)
        Me.lbl_categoria_nombre.TabIndex = 20
        Me.lbl_categoria_nombre.Text = "Nombre de la categoría:"
        '
        'lbl_categoria_id
        '
        Me.lbl_categoria_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_id.AutoSize = True
        Me.lbl_categoria_id.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_categoria_id.Location = New System.Drawing.Point(588, 120)
        Me.lbl_categoria_id.Name = "lbl_categoria_id"
        Me.lbl_categoria_id.Size = New System.Drawing.Size(28, 23)
        Me.lbl_categoria_id.TabIndex = 19
        Me.lbl_categoria_id.Text = "ID:"
        '
        'tb_categorias_id
        '
        Me.tb_categorias_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_id.Enabled = False
        Me.tb_categorias_id.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_categorias_id.Location = New System.Drawing.Point(676, 116)
        Me.tb_categorias_id.Name = "tb_categorias_id"
        Me.tb_categorias_id.Size = New System.Drawing.Size(93, 32)
        Me.tb_categorias_id.TabIndex = 18
        '
        'dg_categorias
        '
        Me.dg_categorias.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_categorias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_categorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_categorias.Location = New System.Drawing.Point(0, 0)
        Me.dg_categorias.Name = "dg_categorias"
        Me.dg_categorias.Size = New System.Drawing.Size(500, 926)
        Me.dg_categorias.TabIndex = 25
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_categoria, Me.ToolStripSeparator8, Me.tslbl_alta_categoria_productos, Me.ToolStripSeparator9, Me.tslbl_baja_categorias_producto, Me.tslbl_modificar_categoria_productos})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1890, 25)
        Me.ToolStrip2.TabIndex = 28
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tslbl_nuevo_categoria
        '
        Me.tslbl_nuevo_categoria.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_nuevo_categoria.Name = "tslbl_nuevo_categoria"
        Me.tslbl_nuevo_categoria.Size = New System.Drawing.Size(48, 22)
        Me.tslbl_nuevo_categoria.Text = "Nuevo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_categoria_productos
        '
        Me.tslbl_alta_categoria_productos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_alta_categoria_productos.Name = "tslbl_alta_categoria_productos"
        Me.tslbl_alta_categoria_productos.Size = New System.Drawing.Size(31, 22)
        Me.tslbl_alta_categoria_productos.Text = "Alta"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_categorias_producto
        '
        Me.tslbl_baja_categorias_producto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_baja_categorias_producto.Name = "tslbl_baja_categorias_producto"
        Me.tslbl_baja_categorias_producto.Size = New System.Drawing.Size(35, 22)
        Me.tslbl_baja_categorias_producto.Text = "Baja"
        '
        'tslbl_modificar_categoria_productos
        '
        Me.tslbl_modificar_categoria_productos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_modificar_categoria_productos.Name = "tslbl_modificar_categoria_productos"
        Me.tslbl_modificar_categoria_productos.Size = New System.Drawing.Size(63, 22)
        Me.tslbl_modificar_categoria_productos.Text = "Modificar"
        '
        'tab_productos
        '
        Me.tab_productos.Controls.Add(Me.SplitContainer4)
        Me.tab_productos.Controls.Add(Me.ToolStrip3)
        Me.tab_productos.Location = New System.Drawing.Point(4, 28)
        Me.tab_productos.Name = "tab_productos"
        Me.tab_productos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_productos.Size = New System.Drawing.Size(1896, 957)
        Me.tab_productos.TabIndex = 12
        Me.tab_productos.Text = "Productos"
        Me.tab_productos.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.dg_productos)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_baja_prod)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_baja_prod)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_alta_prod)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btn_alta_prod)
        Me.SplitContainer4.Panel2.Controls.Add(Me.PictureBox17)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_producto_stock)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_productos_categoria_id)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_productos_precio)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_productos_nombre)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_productos_id)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_precio)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_categoriaID)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_stock)
        Me.SplitContainer4.Panel2.Controls.Add(Me.TextBox6)
        Me.SplitContainer4.Panel2.Controls.Add(Me.TextBox7)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_nombre)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_id)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.PictureBox10)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_productos_marca)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lbl_productos_descripccion)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_descripccion)
        Me.SplitContainer4.Panel2.Controls.Add(Me.tb_productos_marca)
        Me.SplitContainer4.Size = New System.Drawing.Size(1890, 926)
        Me.SplitContainer4.SplitterDistance = 445
        Me.SplitContainer4.TabIndex = 63
        '
        'dg_productos
        '
        Me.dg_productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_productos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_productos.Location = New System.Drawing.Point(0, 0)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.Size = New System.Drawing.Size(1890, 445)
        Me.dg_productos.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(556, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 31)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "Datos de categoría:"
        '
        'lbl_baja_prod
        '
        Me.lbl_baja_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_baja_prod.AutoSize = True
        Me.lbl_baja_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.lbl_baja_prod.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baja_prod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_baja_prod.Location = New System.Drawing.Point(987, 308)
        Me.lbl_baja_prod.Name = "lbl_baja_prod"
        Me.lbl_baja_prod.Size = New System.Drawing.Size(70, 31)
        Me.lbl_baja_prod.TabIndex = 129
        Me.lbl_baja_prod.Text = "BAJA"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(956, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 31)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "MODIFICAR"
        '
        'lbl_alta_prod
        '
        Me.lbl_alta_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_alta_prod.AutoSize = True
        Me.lbl_alta_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lbl_alta_prod.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alta_prod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_alta_prod.Location = New System.Drawing.Point(987, 89)
        Me.lbl_alta_prod.Name = "lbl_alta_prod"
        Me.lbl_alta_prod.Size = New System.Drawing.Size(70, 31)
        Me.lbl_alta_prod.TabIndex = 127
        Me.lbl_alta_prod.Text = "ALTA"
        '
        'lbl_producto_stock
        '
        Me.lbl_producto_stock.AutoSize = True
        Me.lbl_producto_stock.Location = New System.Drawing.Point(146, 237)
        Me.lbl_producto_stock.Name = "lbl_producto_stock"
        Me.lbl_producto_stock.Size = New System.Drawing.Size(47, 19)
        Me.lbl_producto_stock.TabIndex = 113
        Me.lbl_producto_stock.Text = "Stock:"
        '
        'lbl_productos_categoria_id
        '
        Me.lbl_productos_categoria_id.AutoSize = True
        Me.lbl_productos_categoria_id.Location = New System.Drawing.Point(129, 206)
        Me.lbl_productos_categoria_id.Name = "lbl_productos_categoria_id"
        Me.lbl_productos_categoria_id.Size = New System.Drawing.Size(94, 19)
        Me.lbl_productos_categoria_id.TabIndex = 112
        Me.lbl_productos_categoria_id.Text = "Categoria ID:"
        '
        'lbl_productos_precio
        '
        Me.lbl_productos_precio.AutoSize = True
        Me.lbl_productos_precio.Location = New System.Drawing.Point(146, 175)
        Me.lbl_productos_precio.Name = "lbl_productos_precio"
        Me.lbl_productos_precio.Size = New System.Drawing.Size(53, 19)
        Me.lbl_productos_precio.TabIndex = 111
        Me.lbl_productos_precio.Text = "Precio:"
        '
        'lbl_productos_nombre
        '
        Me.lbl_productos_nombre.AutoSize = True
        Me.lbl_productos_nombre.Location = New System.Drawing.Point(146, 146)
        Me.lbl_productos_nombre.Name = "lbl_productos_nombre"
        Me.lbl_productos_nombre.Size = New System.Drawing.Size(64, 19)
        Me.lbl_productos_nombre.TabIndex = 110
        Me.lbl_productos_nombre.Text = "Nombre:"
        '
        'lbl_productos_id
        '
        Me.lbl_productos_id.AutoSize = True
        Me.lbl_productos_id.Location = New System.Drawing.Point(146, 112)
        Me.lbl_productos_id.Name = "lbl_productos_id"
        Me.lbl_productos_id.Size = New System.Drawing.Size(27, 19)
        Me.lbl_productos_id.TabIndex = 109
        Me.lbl_productos_id.Text = "ID:"
        '
        'tb_productos_precio
        '
        Me.tb_productos_precio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_precio.Location = New System.Drawing.Point(476, 169)
        Me.tb_productos_precio.Name = "tb_productos_precio"
        Me.tb_productos_precio.Size = New System.Drawing.Size(117, 27)
        Me.tb_productos_precio.TabIndex = 108
        '
        'tb_productos_categoriaID
        '
        Me.tb_productos_categoriaID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_categoriaID.Location = New System.Drawing.Point(476, 203)
        Me.tb_productos_categoriaID.Name = "tb_productos_categoriaID"
        Me.tb_productos_categoriaID.Size = New System.Drawing.Size(117, 27)
        Me.tb_productos_categoriaID.TabIndex = 107
        '
        'tb_productos_stock
        '
        Me.tb_productos_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_stock.Location = New System.Drawing.Point(476, 234)
        Me.tb_productos_stock.Name = "tb_productos_stock"
        Me.tb_productos_stock.Size = New System.Drawing.Size(117, 27)
        Me.tb_productos_stock.TabIndex = 106
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(774, 111)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(117, 27)
        Me.TextBox6.TabIndex = 105
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(774, 146)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(117, 72)
        Me.TextBox7.TabIndex = 104
        '
        'tb_productos_nombre
        '
        Me.tb_productos_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_nombre.Location = New System.Drawing.Point(476, 138)
        Me.tb_productos_nombre.Name = "tb_productos_nombre"
        Me.tb_productos_nombre.Size = New System.Drawing.Size(117, 27)
        Me.tb_productos_nombre.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(733, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(708, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Descripción:"
        '
        'tb_productos_id
        '
        Me.tb_productos_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_id.Enabled = False
        Me.tb_productos_id.Location = New System.Drawing.Point(476, 109)
        Me.tb_productos_id.Name = "tb_productos_id"
        Me.tb_productos_id.Size = New System.Drawing.Size(117, 27)
        Me.tb_productos_id.TabIndex = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1890, 33)
        Me.Panel1.TabIndex = 99
        '
        'lbl_productos_marca
        '
        Me.lbl_productos_marca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_productos_marca.AutoSize = True
        Me.lbl_productos_marca.Location = New System.Drawing.Point(1447, 139)
        Me.lbl_productos_marca.Name = "lbl_productos_marca"
        Me.lbl_productos_marca.Size = New System.Drawing.Size(54, 19)
        Me.lbl_productos_marca.TabIndex = 29
        Me.lbl_productos_marca.Text = "Marca:"
        '
        'lbl_productos_descripccion
        '
        Me.lbl_productos_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_productos_descripccion.AutoSize = True
        Me.lbl_productos_descripccion.Location = New System.Drawing.Point(1422, 174)
        Me.lbl_productos_descripccion.Name = "lbl_productos_descripccion"
        Me.lbl_productos_descripccion.Size = New System.Drawing.Size(89, 19)
        Me.lbl_productos_descripccion.TabIndex = 28
        Me.lbl_productos_descripccion.Text = "Descripción:"
        '
        'tb_productos_descripccion
        '
        Me.tb_productos_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_descripccion.Location = New System.Drawing.Point(1488, 171)
        Me.tb_productos_descripccion.Multiline = True
        Me.tb_productos_descripccion.Name = "tb_productos_descripccion"
        Me.tb_productos_descripccion.Size = New System.Drawing.Size(117, 72)
        Me.tb_productos_descripccion.TabIndex = 33
        '
        'tb_productos_marca
        '
        Me.tb_productos_marca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_marca.Location = New System.Drawing.Point(1488, 136)
        Me.tb_productos_marca.Name = "tb_productos_marca"
        Me.tb_productos_marca.Size = New System.Drawing.Size(117, 27)
        Me.tb_productos_marca.TabIndex = 36
        '
        'ToolStrip3
        '
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_producto, Me.ToolStripSeparator10, Me.tslbl_alta_productos, Me.ToolStripSeparator11, Me.tslbl_baja_productos, Me.ToolStripLabel12})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1890, 25)
        Me.ToolStrip3.TabIndex = 47
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'tslbl_nuevo_producto
        '
        Me.tslbl_nuevo_producto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_nuevo_producto.Name = "tslbl_nuevo_producto"
        Me.tslbl_nuevo_producto.Size = New System.Drawing.Size(48, 22)
        Me.tslbl_nuevo_producto.Text = "Nuevo"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_productos
        '
        Me.tslbl_alta_productos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_alta_productos.Name = "tslbl_alta_productos"
        Me.tslbl_alta_productos.Size = New System.Drawing.Size(31, 22)
        Me.tslbl_alta_productos.Text = "Alta"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_productos
        '
        Me.tslbl_baja_productos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslbl_baja_productos.Name = "tslbl_baja_productos"
        Me.tslbl_baja_productos.Size = New System.Drawing.Size(35, 22)
        Me.tslbl_baja_productos.Text = "Baja"
        '
        'ToolStripLabel12
        '
        Me.ToolStripLabel12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel12.Name = "ToolStripLabel12"
        Me.ToolStripLabel12.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel12.Text = "Modificar"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox3.Location = New System.Drawing.Point(868, 368)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(249, 144)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox4.Location = New System.Drawing.Point(829, 352)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(249, 144)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 84
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.panel_dg
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.tit_datos_emp)
        Me.Panel2.Controls.Add(Me.dg_emple)
        Me.Panel2.Location = New System.Drawing.Point(21, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1846, 385)
        Me.Panel2.TabIndex = 0
        '
        'tit_datos_emp
        '
        Me.tit_datos_emp.AutoSize = True
        Me.tit_datos_emp.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tit_datos_emp.Font = New System.Drawing.Font("Corbel", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tit_datos_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.tit_datos_emp.Location = New System.Drawing.Point(768, 12)
        Me.tit_datos_emp.Name = "tit_datos_emp"
        Me.tit_datos_emp.Size = New System.Drawing.Size(280, 42)
        Me.tit_datos_emp.TabIndex = 127
        Me.tit_datos_emp.Text = "TABLA DE DATOS"
        '
        'dg_emple
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dg_emple.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_emple.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_emple.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_emple.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dg_emple.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_emple.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_emple.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_emple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_emple.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dg_emple.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dg_emple.Location = New System.Drawing.Point(49, 57)
        Me.dg_emple.Name = "dg_emple"
        Me.dg_emple.Size = New System.Drawing.Size(1761, 279)
        Me.dg_emple.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'pan_datos_emple
        '
        Me.pan_datos_emple.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.pan_datos
        Me.pan_datos_emple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_datos_emple.Controls.Add(Me.pb5)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_nom)
        Me.pan_datos_emple.Controls.Add(Me.lbl_usuario)
        Me.pan_datos_emple.Controls.Add(Me.lbl_cont_emple)
        Me.pan_datos_emple.Controls.Add(Me.lbl_nom_emple)
        Me.pan_datos_emple.Controls.Add(Me.lbl_rol_emple)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_rol)
        Me.pan_datos_emple.Controls.Add(Me.lbl_id_emple)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_ape2)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_cont)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_email)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_ape1)
        Me.pan_datos_emple.Controls.Add(Me.tit_emple)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_tlf)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_usu)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_ape1)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_id)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_telefono)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_correo)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_ape2)
        Me.pan_datos_emple.Controls.Add(Me.pb4)
        Me.pan_datos_emple.Controls.Add(Me.pb7)
        Me.pan_datos_emple.Controls.Add(Me.pb8)
        Me.pan_datos_emple.Controls.Add(Me.pb9)
        Me.pan_datos_emple.Controls.Add(Me.pb1)
        Me.pan_datos_emple.Controls.Add(Me.pb2)
        Me.pan_datos_emple.Controls.Add(Me.pb3)
        Me.pan_datos_emple.Controls.Add(Me.pb6)
        Me.pan_datos_emple.Controls.Add(Me.lbl_alta_empleados)
        Me.pan_datos_emple.Controls.Add(Me.btn_emp_alta)
        Me.pan_datos_emple.Controls.Add(Me.lbl_baja_empleados)
        Me.pan_datos_emple.Controls.Add(Me.btn_emp_baja)
        Me.pan_datos_emple.Controls.Add(Me.lbl_mod_empleados)
        Me.pan_datos_emple.Controls.Add(Me.btn_emp_modif)
        Me.pan_datos_emple.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_datos_emple.Location = New System.Drawing.Point(21, 7)
        Me.pan_datos_emple.Name = "pan_datos_emple"
        Me.pan_datos_emple.Size = New System.Drawing.Size(1323, 458)
        Me.pan_datos_emple.TabIndex = 125
        '
        'pb5
        '
        Me.pb5.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb5.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb5.Location = New System.Drawing.Point(322, 319)
        Me.pb5.Name = "pb5"
        Me.pb5.Size = New System.Drawing.Size(224, 59)
        Me.pb5.TabIndex = 126
        Me.pb5.TabStop = False
        '
        'tb_emple_nom
        '
        Me.tb_emple_nom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_nom.BackColor = System.Drawing.Color.White
        Me.tb_emple_nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_nom.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_nom.Location = New System.Drawing.Point(348, 335)
        Me.tb_emple_nom.Name = "tb_emple_nom"
        Me.tb_emple_nom.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_nom.TabIndex = 114
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_usuario.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_usuario.Location = New System.Drawing.Point(135, 212)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(106, 33)
        Me.lbl_usuario.TabIndex = 103
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_cont_emple
        '
        Me.lbl_cont_emple.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_cont_emple.AutoSize = True
        Me.lbl_cont_emple.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_cont_emple.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cont_emple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_cont_emple.Location = New System.Drawing.Point(96, 268)
        Me.lbl_cont_emple.Name = "lbl_cont_emple"
        Me.lbl_cont_emple.Size = New System.Drawing.Size(145, 33)
        Me.lbl_cont_emple.TabIndex = 102
        Me.lbl_cont_emple.Text = "Contraseña:"
        '
        'lbl_nom_emple
        '
        Me.lbl_nom_emple.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_nom_emple.AutoSize = True
        Me.lbl_nom_emple.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_nom_emple.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_emple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_nom_emple.Location = New System.Drawing.Point(130, 329)
        Me.lbl_nom_emple.Name = "lbl_nom_emple"
        Me.lbl_nom_emple.Size = New System.Drawing.Size(111, 33)
        Me.lbl_nom_emple.TabIndex = 104
        Me.lbl_nom_emple.Text = "Nombre:"
        '
        'lbl_rol_emple
        '
        Me.lbl_rol_emple.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_rol_emple.AutoSize = True
        Me.lbl_rol_emple.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_rol_emple.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rol_emple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_rol_emple.Location = New System.Drawing.Point(185, 154)
        Me.lbl_rol_emple.Name = "lbl_rol_emple"
        Me.lbl_rol_emple.Size = New System.Drawing.Size(56, 33)
        Me.lbl_rol_emple.TabIndex = 101
        Me.lbl_rol_emple.Text = "Rol:"
        '
        'tb_emple_rol
        '
        Me.tb_emple_rol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_rol.BackColor = System.Drawing.Color.White
        Me.tb_emple_rol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_rol.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_rol.Location = New System.Drawing.Point(348, 160)
        Me.tb_emple_rol.Name = "tb_emple_rol"
        Me.tb_emple_rol.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_rol.TabIndex = 109
        '
        'lbl_id_emple
        '
        Me.lbl_id_emple.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_id_emple.AutoSize = True
        Me.lbl_id_emple.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_id_emple.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_emple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_id_emple.Location = New System.Drawing.Point(195, 96)
        Me.lbl_id_emple.Name = "lbl_id_emple"
        Me.lbl_id_emple.Size = New System.Drawing.Size(46, 33)
        Me.lbl_id_emple.TabIndex = 100
        Me.lbl_id_emple.Text = "ID:"
        '
        'tb_emple_ape2
        '
        Me.tb_emple_ape2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_ape2.BackColor = System.Drawing.Color.White
        Me.tb_emple_ape2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_ape2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_ape2.Location = New System.Drawing.Point(1000, 152)
        Me.tb_emple_ape2.Name = "tb_emple_ape2"
        Me.tb_emple_ape2.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_ape2.TabIndex = 110
        '
        'tb_emple_cont
        '
        Me.tb_emple_cont.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_cont.BackColor = System.Drawing.Color.White
        Me.tb_emple_cont.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_cont.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_cont.Location = New System.Drawing.Point(348, 274)
        Me.tb_emple_cont.Name = "tb_emple_cont"
        Me.tb_emple_cont.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_cont.TabIndex = 115
        '
        'lbl_empleados_email
        '
        Me.lbl_empleados_email.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_empleados_email.AutoSize = True
        Me.lbl_empleados_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_empleados_email.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empleados_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_empleados_email.Location = New System.Drawing.Point(690, 262)
        Me.lbl_empleados_email.Name = "lbl_empleados_email"
        Me.lbl_empleados_email.Size = New System.Drawing.Size(221, 33)
        Me.lbl_empleados_email.TabIndex = 108
        Me.lbl_empleados_email.Text = "Correo electrónico:"
        '
        'lbl_empleados_ape1
        '
        Me.lbl_empleados_ape1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_empleados_ape1.AutoSize = True
        Me.lbl_empleados_ape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_empleados_ape1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empleados_ape1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_empleados_ape1.Location = New System.Drawing.Point(724, 90)
        Me.lbl_empleados_ape1.Name = "lbl_empleados_ape1"
        Me.lbl_empleados_ape1.Size = New System.Drawing.Size(187, 33)
        Me.lbl_empleados_ape1.TabIndex = 106
        Me.lbl_empleados_ape1.Text = "Primer apellido:"
        '
        'tit_emple
        '
        Me.tit_emple.AutoSize = True
        Me.tit_emple.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tit_emple.Font = New System.Drawing.Font("Corbel", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tit_emple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.tit_emple.Location = New System.Drawing.Point(436, 17)
        Me.tit_emple.Name = "tit_emple"
        Me.tit_emple.Size = New System.Drawing.Size(388, 42)
        Me.tit_emple.TabIndex = 117
        Me.tit_emple.Text = "DATOS DE EMPLEADO/A"
        '
        'tb_emple_tlf
        '
        Me.tb_emple_tlf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_tlf.BackColor = System.Drawing.Color.White
        Me.tb_emple_tlf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_tlf.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_tlf.Location = New System.Drawing.Point(1000, 210)
        Me.tb_emple_tlf.Name = "tb_emple_tlf"
        Me.tb_emple_tlf.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_tlf.TabIndex = 111
        '
        'tb_emple_usu
        '
        Me.tb_emple_usu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_usu.BackColor = System.Drawing.Color.White
        Me.tb_emple_usu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_usu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_usu.Location = New System.Drawing.Point(348, 218)
        Me.tb_emple_usu.Name = "tb_emple_usu"
        Me.tb_emple_usu.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_usu.TabIndex = 116
        '
        'tb_emple_ape1
        '
        Me.tb_emple_ape1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_ape1.BackColor = System.Drawing.Color.White
        Me.tb_emple_ape1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_ape1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_ape1.Location = New System.Drawing.Point(1000, 96)
        Me.tb_emple_ape1.Name = "tb_emple_ape1"
        Me.tb_emple_ape1.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_ape1.TabIndex = 113
        '
        'tb_emple_id
        '
        Me.tb_emple_id.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_id.BackColor = System.Drawing.Color.White
        Me.tb_emple_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_id.Enabled = False
        Me.tb_emple_id.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_id.Location = New System.Drawing.Point(348, 102)
        Me.tb_emple_id.Name = "tb_emple_id"
        Me.tb_emple_id.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_id.TabIndex = 99
        '
        'lbl_empleados_telefono
        '
        Me.lbl_empleados_telefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_empleados_telefono.AutoSize = True
        Me.lbl_empleados_telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_empleados_telefono.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empleados_telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_empleados_telefono.Location = New System.Drawing.Point(797, 204)
        Me.lbl_empleados_telefono.Name = "lbl_empleados_telefono"
        Me.lbl_empleados_telefono.Size = New System.Drawing.Size(114, 33)
        Me.lbl_empleados_telefono.TabIndex = 107
        Me.lbl_empleados_telefono.Text = "Teléfono:"
        '
        'tb_emple_correo
        '
        Me.tb_emple_correo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_emple_correo.BackColor = System.Drawing.Color.White
        Me.tb_emple_correo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_emple_correo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_emple_correo.Location = New System.Drawing.Point(1000, 268)
        Me.tb_emple_correo.Name = "tb_emple_correo"
        Me.tb_emple_correo.Size = New System.Drawing.Size(173, 26)
        Me.tb_emple_correo.TabIndex = 112
        '
        'lbl_empleados_ape2
        '
        Me.lbl_empleados_ape2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_empleados_ape2.AutoSize = True
        Me.lbl_empleados_ape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lbl_empleados_ape2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empleados_ape2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_empleados_ape2.Location = New System.Drawing.Point(703, 146)
        Me.lbl_empleados_ape2.Name = "lbl_empleados_ape2"
        Me.lbl_empleados_ape2.Size = New System.Drawing.Size(208, 33)
        Me.lbl_empleados_ape2.TabIndex = 105
        Me.lbl_empleados_ape2.Text = "Segundo apellido:"
        '
        'pb4
        '
        Me.pb4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb4.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb4.Location = New System.Drawing.Point(322, 260)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(224, 59)
        Me.pb4.TabIndex = 119
        Me.pb4.TabStop = False
        '
        'pb7
        '
        Me.pb7.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb7.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb7.Location = New System.Drawing.Point(974, 137)
        Me.pb7.Name = "pb7"
        Me.pb7.Size = New System.Drawing.Size(224, 59)
        Me.pb7.TabIndex = 123
        Me.pb7.TabStop = False
        '
        'pb8
        '
        Me.pb8.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb8.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb8.Location = New System.Drawing.Point(974, 196)
        Me.pb8.Name = "pb8"
        Me.pb8.Size = New System.Drawing.Size(224, 59)
        Me.pb8.TabIndex = 120
        Me.pb8.TabStop = False
        '
        'pb9
        '
        Me.pb9.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb9.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb9.Location = New System.Drawing.Point(974, 254)
        Me.pb9.Name = "pb9"
        Me.pb9.Size = New System.Drawing.Size(224, 59)
        Me.pb9.TabIndex = 122
        Me.pb9.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb1.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(322, 87)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(224, 59)
        Me.pb1.TabIndex = 121
        Me.pb1.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb2.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb2.Location = New System.Drawing.Point(322, 145)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(224, 59)
        Me.pb2.TabIndex = 124
        Me.pb2.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb3.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb3.Location = New System.Drawing.Point(322, 204)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(224, 59)
        Me.pb3.TabIndex = 125
        Me.pb3.TabStop = False
        '
        'pb6
        '
        Me.pb6.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb6.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb6.Location = New System.Drawing.Point(974, 81)
        Me.pb6.Name = "pb6"
        Me.pb6.Size = New System.Drawing.Size(224, 59)
        Me.pb6.TabIndex = 118
        Me.pb6.TabStop = False
        '
        'lbl_alta_empleados
        '
        Me.lbl_alta_empleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_alta_empleados.AutoSize = True
        Me.lbl_alta_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_alta_empleados.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alta_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_alta_empleados.Location = New System.Drawing.Point(724, 360)
        Me.lbl_alta_empleados.Name = "lbl_alta_empleados"
        Me.lbl_alta_empleados.Size = New System.Drawing.Size(70, 31)
        Me.lbl_alta_empleados.TabIndex = 121
        Me.lbl_alta_empleados.Text = "ALTA"
        '
        'btn_emp_alta
        '
        Me.btn_emp_alta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_emp_alta.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_emp_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_emp_alta.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.BTN
        Me.btn_emp_alta.Location = New System.Drawing.Point(673, 339)
        Me.btn_emp_alta.Name = "btn_emp_alta"
        Me.btn_emp_alta.Size = New System.Drawing.Size(175, 84)
        Me.btn_emp_alta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_emp_alta.TabIndex = 118
        Me.btn_emp_alta.TabStop = False
        '
        'lbl_baja_empleados
        '
        Me.lbl_baja_empleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_baja_empleados.AutoSize = True
        Me.lbl_baja_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_baja_empleados.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baja_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_baja_empleados.Location = New System.Drawing.Point(1090, 360)
        Me.lbl_baja_empleados.Name = "lbl_baja_empleados"
        Me.lbl_baja_empleados.Size = New System.Drawing.Size(70, 31)
        Me.lbl_baja_empleados.TabIndex = 123
        Me.lbl_baja_empleados.Text = "BAJA"
        '
        'btn_emp_baja
        '
        Me.btn_emp_baja.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_emp_baja.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_emp_baja.BackgroundImage = CType(resources.GetObject("btn_emp_baja.BackgroundImage"), System.Drawing.Image)
        Me.btn_emp_baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_emp_baja.Location = New System.Drawing.Point(1035, 339)
        Me.btn_emp_baja.Name = "btn_emp_baja"
        Me.btn_emp_baja.Size = New System.Drawing.Size(175, 84)
        Me.btn_emp_baja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_emp_baja.TabIndex = 119
        Me.btn_emp_baja.TabStop = False
        '
        'lbl_mod_empleados
        '
        Me.lbl_mod_empleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_mod_empleados.AutoSize = True
        Me.lbl_mod_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbl_mod_empleados.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mod_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_mod_empleados.Location = New System.Drawing.Point(873, 360)
        Me.lbl_mod_empleados.Name = "lbl_mod_empleados"
        Me.lbl_mod_empleados.Size = New System.Drawing.Size(138, 31)
        Me.lbl_mod_empleados.TabIndex = 122
        Me.lbl_mod_empleados.Text = "MODIFICAR"
        '
        'btn_emp_modif
        '
        Me.btn_emp_modif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_emp_modif.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_emp_modif.BackgroundImage = CType(resources.GetObject("btn_emp_modif.BackgroundImage"), System.Drawing.Image)
        Me.btn_emp_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_emp_modif.Location = New System.Drawing.Point(855, 338)
        Me.btn_emp_modif.Name = "btn_emp_modif"
        Me.btn_emp_modif.Size = New System.Drawing.Size(175, 84)
        Me.btn_emp_modif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_emp_modif.TabIndex = 120
        Me.btn_emp_modif.TabStop = False
        '
        'pan_logo
        '
        Me.pan_logo.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.Logo
        Me.pan_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_logo.Location = New System.Drawing.Point(1365, 7)
        Me.pan_logo.Name = "pan_logo"
        Me.pan_logo.Size = New System.Drawing.Size(502, 458)
        Me.pan_logo.TabIndex = 127
        '
        'pan_datos_roles
        '
        Me.pan_datos_roles.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.pan_datos_roles
        Me.pan_datos_roles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_datos_roles.Controls.Add(Me.tit_roles)
        Me.pan_datos_roles.Controls.Add(Me.lbl_baja_roles)
        Me.pan_datos_roles.Controls.Add(Me.tb_roles_id)
        Me.pan_datos_roles.Controls.Add(Me.tb_roles_rol)
        Me.pan_datos_roles.Controls.Add(Me.lbl_alta_roles)
        Me.pan_datos_roles.Controls.Add(Me.lbl_mod_roles)
        Me.pan_datos_roles.Controls.Add(Me.btn_mod_roles)
        Me.pan_datos_roles.Controls.Add(Me.lbl_roles_id)
        Me.pan_datos_roles.Controls.Add(Me.btn_alta_rol)
        Me.pan_datos_roles.Controls.Add(Me.lbl_roles_rol)
        Me.pan_datos_roles.Controls.Add(Me.btn_baja_roles)
        Me.pan_datos_roles.Controls.Add(Me.pb_id_rol)
        Me.pan_datos_roles.Controls.Add(Me.pb_rol)
        Me.pan_datos_roles.Location = New System.Drawing.Point(29, 23)
        Me.pan_datos_roles.Name = "pan_datos_roles"
        Me.pan_datos_roles.Size = New System.Drawing.Size(1101, 449)
        Me.pan_datos_roles.TabIndex = 104
        '
        'btn_mod_roles
        '
        Me.btn_mod_roles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_mod_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_mod_roles.BackgroundImage = CType(resources.GetObject("btn_mod_roles.BackgroundImage"), System.Drawing.Image)
        Me.btn_mod_roles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mod_roles.Location = New System.Drawing.Point(665, 274)
        Me.btn_mod_roles.Name = "btn_mod_roles"
        Me.btn_mod_roles.Size = New System.Drawing.Size(175, 84)
        Me.btn_mod_roles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_mod_roles.TabIndex = 99
        Me.btn_mod_roles.TabStop = False
        '
        'btn_alta_rol
        '
        Me.btn_alta_rol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_alta_rol.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_alta_rol.BackgroundImage = CType(resources.GetObject("btn_alta_rol.BackgroundImage"), System.Drawing.Image)
        Me.btn_alta_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alta_rol.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.BTN
        Me.btn_alta_rol.Location = New System.Drawing.Point(189, 274)
        Me.btn_alta_rol.Name = "btn_alta_rol"
        Me.btn_alta_rol.Size = New System.Drawing.Size(175, 84)
        Me.btn_alta_rol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_alta_rol.TabIndex = 97
        Me.btn_alta_rol.TabStop = False
        '
        'btn_baja_roles
        '
        Me.btn_baja_roles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_baja_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_baja_roles.BackgroundImage = CType(resources.GetObject("btn_baja_roles.BackgroundImage"), System.Drawing.Image)
        Me.btn_baja_roles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_baja_roles.Location = New System.Drawing.Point(428, 274)
        Me.btn_baja_roles.Name = "btn_baja_roles"
        Me.btn_baja_roles.Size = New System.Drawing.Size(175, 84)
        Me.btn_baja_roles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_baja_roles.TabIndex = 98
        Me.btn_baja_roles.TabStop = False
        '
        'pn_logo
        '
        Me.pn_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pn_logo.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Logo_2
        Me.pn_logo.Location = New System.Drawing.Point(29, 489)
        Me.pn_logo.Name = "pn_logo"
        Me.pn_logo.Size = New System.Drawing.Size(1101, 434)
        Me.pn_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pn_logo.TabIndex = 103
        Me.pn_logo.TabStop = False
        '
        'pan_dg_rol
        '
        Me.pan_dg_rol.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.panel_dg_rol
        Me.pan_dg_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_dg_rol.Controls.Add(Me.dg_roles)
        Me.pan_dg_rol.Location = New System.Drawing.Point(28, 23)
        Me.pan_dg_rol.Name = "pan_dg_rol"
        Me.pan_dg_rol.Size = New System.Drawing.Size(702, 871)
        Me.pan_dg_rol.TabIndex = 0
        '
        'dg_roles
        '
        Me.dg_roles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dg_roles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_roles.Location = New System.Drawing.Point(60, 107)
        Me.dg_roles.Name = "dg_roles"
        Me.dg_roles.Size = New System.Drawing.Size(605, 725)
        Me.dg_roles.TabIndex = 1
        '
        'btn_mod_categoria
        '
        Me.btn_mod_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_mod_categoria.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Recurso_2_2x
        Me.btn_mod_categoria.Location = New System.Drawing.Point(926, 371)
        Me.btn_mod_categoria.Name = "btn_mod_categoria"
        Me.btn_mod_categoria.Size = New System.Drawing.Size(175, 84)
        Me.btn_mod_categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_mod_categoria.TabIndex = 110
        Me.btn_mod_categoria.TabStop = False
        '
        'btn_alta_categoria
        '
        Me.btn_alta_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_alta_categoria.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.alta
        Me.btn_alta_categoria.Location = New System.Drawing.Point(449, 366)
        Me.btn_alta_categoria.Name = "btn_alta_categoria"
        Me.btn_alta_categoria.Size = New System.Drawing.Size(175, 84)
        Me.btn_alta_categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_alta_categoria.TabIndex = 108
        Me.btn_alta_categoria.TabStop = False
        '
        'btn_baja_categoria
        '
        Me.btn_baja_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_baja_categoria.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.baja
        Me.btn_baja_categoria.Location = New System.Drawing.Point(689, 371)
        Me.btn_baja_categoria.Name = "btn_baja_categoria"
        Me.btn_baja_categoria.Size = New System.Drawing.Size(175, 84)
        Me.btn_baja_categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_baja_categoria.TabIndex = 109
        Me.btn_baja_categoria.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox9.Location = New System.Drawing.Point(592, 455)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(390, 344)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 62
        Me.PictureBox9.TabStop = False
        '
        'btn_baja_prod
        '
        Me.btn_baja_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_baja_prod.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.baja
        Me.btn_baja_prod.Location = New System.Drawing.Point(935, 291)
        Me.btn_baja_prod.Name = "btn_baja_prod"
        Me.btn_baja_prod.Size = New System.Drawing.Size(175, 84)
        Me.btn_baja_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_baja_prod.TabIndex = 125
        Me.btn_baja_prod.TabStop = False
        '
        'btn_alta_prod
        '
        Me.btn_alta_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_alta_prod.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.alta
        Me.btn_alta_prod.Location = New System.Drawing.Point(937, 72)
        Me.btn_alta_prod.Name = "btn_alta_prod"
        Me.btn_alta_prod.Size = New System.Drawing.Size(175, 84)
        Me.btn_alta_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_alta_prod.TabIndex = 124
        Me.btn_alta_prod.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox17.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Recurso_2_2x
        Me.PictureBox17.Location = New System.Drawing.Point(938, 181)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(175, 84)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 126
        Me.PictureBox17.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox10.Location = New System.Drawing.Point(1181, 41)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(390, 344)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 62
        Me.PictureBox10.TabStop = False
        '
        'ts_volverimg
        '
        Me.ts_volverimg.AutoSize = False
        Me.ts_volverimg.BackgroundImage = CType(resources.GetObject("ts_volverimg.BackgroundImage"), System.Drawing.Image)
        Me.ts_volverimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ts_volverimg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_volverimg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_volverimg.Name = "ts_volverimg"
        Me.ts_volverimg.Size = New System.Drawing.Size(60, 27)
        Me.ts_volverimg.Text = "ToolStripButton1"
        '
        'tit_roles
        '
        Me.tit_roles.AutoSize = True
        Me.tit_roles.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tit_roles.Font = New System.Drawing.Font("Corbel", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tit_roles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.tit_roles.Location = New System.Drawing.Point(466, 29)
        Me.tit_roles.Name = "tit_roles"
        Me.tit_roles.Size = New System.Drawing.Size(245, 42)
        Me.tit_roles.TabIndex = 118
        Me.tit_roles.Text = "DATOS DE ROL"
        '
        'pb_rol
        '
        Me.pb_rol.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb_rol.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_rol.Location = New System.Drawing.Point(486, 160)
        Me.pb_rol.Name = "pb_rol"
        Me.pb_rol.Size = New System.Drawing.Size(224, 59)
        Me.pb_rol.TabIndex = 122
        Me.pb_rol.TabStop = False
        '
        'pb_id_rol
        '
        Me.pb_id_rol.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pb_id_rol.BackgroundImage = Global.AirisSolucionKrisRob.My.Resources.Resources.texbox
        Me.pb_id_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_id_rol.Location = New System.Drawing.Point(486, 83)
        Me.pb_id_rol.Name = "pb_id_rol"
        Me.pb_id_rol.Size = New System.Drawing.Size(224, 59)
        Me.pb_id_rol.TabIndex = 123
        Me.pb_id_rol.TabStop = False
        '
        'gestion_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.toolstrip)
        Me.Name = "gestion_datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de datos maestros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolstrip.ResumeLayout(False)
        Me.toolstrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tab_roles.ResumeLayout(False)
        Me.tab_roles.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ts_roles.ResumeLayout(False)
        Me.ts_roles.PerformLayout()
        Me.tab_empleados.ResumeLayout(False)
        Me.tab_empleados.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ts_empleados.ResumeLayout(False)
        Me.ts_empleados.PerformLayout()
        Me.tb_proveedores.ResumeLayout(False)
        Me.tb_proveedores.PerformLayout()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_proveedores.ResumeLayout(False)
        Me.ts_proveedores.PerformLayout()
        Me.tb_clientes.ResumeLayout(False)
        Me.tb_clientes.PerformLayout()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_clientes.ResumeLayout(False)
        Me.ts_clientes.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.tab_categorias.ResumeLayout(False)
        Me.tab_categorias.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dg_categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tab_productos.ResumeLayout(False)
        Me.tab_productos.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg_emple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_datos_emple.ResumeLayout(False)
        Me.pan_datos_emple.PerformLayout()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_emp_alta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_emp_baja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_emp_modif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_datos_roles.ResumeLayout(False)
        Me.pan_datos_roles.PerformLayout()
        CType(Me.btn_mod_roles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alta_rol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_baja_roles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pn_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_dg_rol.ResumeLayout(False)
        CType(Me.dg_roles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_mod_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alta_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_baja_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_baja_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alta_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_id_rol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstrip As ToolStrip
    Friend WithEvents ts_busqueda As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tss_barraprogreso As ToolStripProgressBar
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ts_volverimg As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ts_info As ToolStripLabel
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ts_cerrar As ToolStripLabel
    Friend WithEvents tss_usuario As ToolStripStatusLabel
    Friend WithEvents tss_fechahora As ToolStripStatusLabel
    Friend WithEvents ts_acerca As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tab_roles As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tb_roles_rol As TextBox
    Friend WithEvents lbl_baja_roles As Label
    Friend WithEvents lbl_roles_rol As Label
    Friend WithEvents lbl_alta_roles As Label
    Friend WithEvents lbl_roles_id As Label
    Friend WithEvents lbl_mod_roles As Label
    Friend WithEvents tb_roles_id As TextBox
    Friend WithEvents btn_mod_roles As PictureBox
    Friend WithEvents btn_alta_rol As PictureBox
    Friend WithEvents btn_baja_roles As PictureBox
    Friend WithEvents dg_roles As DataGridView
    Friend WithEvents ts_roles As ToolStrip
    Friend WithEvents tslbl_nuevo_rol As ToolStripLabel
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents tslbl_alta_roles As ToolStripLabel
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents tslbl_baja_roles As ToolStripLabel
    Friend WithEvents tslbl_modificar_roles As ToolStripLabel
    Friend WithEvents tab_empleados As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dg_emple As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_baja_empleados As Label
    Friend WithEvents lbl_mod_empleados As Label
    Friend WithEvents btn_emp_baja As PictureBox
    Friend WithEvents lbl_alta_empleados As Label
    Friend WithEvents btn_emp_alta As PictureBox
    Friend WithEvents btn_emp_modif As PictureBox
    Friend WithEvents tit_emple As Label
    Friend WithEvents tb_emple_id As TextBox
    Friend WithEvents tb_emple_usu As TextBox
    Friend WithEvents tb_emple_ape2 As TextBox
    Friend WithEvents tb_emple_cont As TextBox
    Friend WithEvents lbl_empleados_email As Label
    Friend WithEvents tb_emple_nom As TextBox
    Friend WithEvents lbl_id_emple As Label
    Friend WithEvents lbl_empleados_ape1 As Label
    Friend WithEvents tb_emple_tlf As TextBox
    Friend WithEvents tb_emple_rol As TextBox
    Friend WithEvents lbl_rol_emple As Label
    Friend WithEvents tb_emple_ape1 As TextBox
    Friend WithEvents lbl_empleados_telefono As Label
    Friend WithEvents lbl_nom_emple As Label
    Friend WithEvents lbl_cont_emple As Label
    Friend WithEvents lbl_empleados_ape2 As Label
    Friend WithEvents tb_emple_correo As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents ts_empleados As ToolStrip
    Friend WithEvents tslbl_nuevo As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tslbl_alta_empleados As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tslbl_baja_empleados As ToolStripLabel
    Friend WithEvents tslbl_modificar_empleados As ToolStripLabel
    Friend WithEvents tb_proveedores As TabPage
    Friend WithEvents lbl_proveedores_direccion As Label
    Friend WithEvents lbl_proveedores_id As Label
    Friend WithEvents lbl_proveedores_nombre As Label
    Friend WithEvents lbl_proveedores_telefono As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dg_proveedores As DataGridView
    Friend WithEvents btn_provedores_baja As Button
    Friend WithEvents btn_provedores_alta As Button
    Friend WithEvents btn_provedores_modificar As Button
    Friend WithEvents tb_proveedores_direccion As TextBox
    Friend WithEvents tb_proveedores_telefono As TextBox
    Friend WithEvents tb_proveedores_contacto As TextBox
    Friend WithEvents tb_proveedores_nombre As TextBox
    Friend WithEvents tb_proveedores_id As TextBox
    Friend WithEvents lbl_proveedores_contacto As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents ts_proveedores As ToolStrip
    Friend WithEvents tslbl_nuevo_proveedores As ToolStripLabel
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents tslbl_alta_provedores As ToolStripLabel
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents tslbl_baja_proveedores As ToolStripLabel
    Friend WithEvents tslbl_modificar_proveedores As ToolStripLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents tb_clientes As TabPage
    Friend WithEvents lbl_clientes_direccion As Label
    Friend WithEvents tb_clientes_direccion As TextBox
    Friend WithEvents tb_clientes_ape2 As TextBox
    Friend WithEvents tb_clientes_ape1 As TextBox
    Friend WithEvents tb_clientes_telefono As TextBox
    Friend WithEvents tb_clientes_empleadoID As TextBox
    Friend WithEvents tb_clientes_nombre As TextBox
    Friend WithEvents tb_clientes_id As TextBox
    Friend WithEvents lbl_clientes_ape2 As Label
    Friend WithEvents lbl_clientes_ape1 As Label
    Friend WithEvents lbl_clientes_nombre As Label
    Friend WithEvents lbl_clientes_id As Label
    Friend WithEvents lbl_clientes_empleadoID As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lbl_clientes_telefono As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dg_clientes As DataGridView
    Friend WithEvents btn_clientes_baja As Button
    Friend WithEvents btn_clientes_alta As Button
    Friend WithEvents btn_clientes_modificar As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents ts_clientes As ToolStrip
    Friend WithEvents tslbl_nuevo_clientes As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents tslbl_alta_clientes As ToolStripLabel
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents tslbl_baja_clientes As ToolStripLabel
    Friend WithEvents tslbl_modificar_clientes As ToolStripLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents tab_categorias As TabPage
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tit_categoria As Label
    Friend WithEvents lbl_baja_categoria As Label
    Friend WithEvents lbl_mod_categoria As Label
    Friend WithEvents tb_categorias_descripccion As TextBox
    Friend WithEvents btn_mod_categoria As PictureBox
    Friend WithEvents tb_categorias_nombre As TextBox
    Friend WithEvents lbl_categoria_descripcion As Label
    Friend WithEvents lbl_alta_categoria As Label
    Friend WithEvents lbl_categoria_nombre As Label
    Friend WithEvents btn_alta_categoria As PictureBox
    Friend WithEvents lbl_categoria_id As Label
    Friend WithEvents btn_baja_categoria As PictureBox
    Friend WithEvents tb_categorias_id As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents dg_categorias As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tslbl_nuevo_categoria As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tslbl_alta_categoria_productos As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tslbl_baja_categorias_producto As ToolStripLabel
    Friend WithEvents tslbl_modificar_categoria_productos As ToolStripLabel
    Friend WithEvents tab_productos As TabPage
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents dg_productos As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_baja_prod As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_baja_prod As PictureBox
    Friend WithEvents lbl_alta_prod As Label
    Friend WithEvents btn_alta_prod As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents lbl_producto_stock As Label
    Friend WithEvents lbl_productos_categoria_id As Label
    Friend WithEvents lbl_productos_precio As Label
    Friend WithEvents lbl_productos_nombre As Label
    Friend WithEvents lbl_productos_id As Label
    Friend WithEvents tb_productos_precio As TextBox
    Friend WithEvents tb_productos_categoriaID As TextBox
    Friend WithEvents tb_productos_stock As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents tb_productos_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_productos_id As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents lbl_productos_marca As Label
    Friend WithEvents lbl_productos_descripccion As Label
    Friend WithEvents tb_productos_descripccion As TextBox
    Friend WithEvents tb_productos_marca As TextBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents tslbl_nuevo_producto As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tslbl_alta_productos As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tslbl_baja_productos As ToolStripLabel
    Friend WithEvents ToolStripLabel12 As ToolStripLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pan_datos_emple As Panel
    Friend WithEvents pan_logo As Panel
    Friend WithEvents pb6 As PictureBox
    Friend WithEvents pb4 As PictureBox
    Friend WithEvents pb7 As PictureBox
    Friend WithEvents pb8 As PictureBox
    Friend WithEvents pb9 As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents pb5 As PictureBox
    Friend WithEvents tit_datos_emp As Label
    Friend WithEvents pan_dg_rol As Panel
    Friend WithEvents pn_logo As PictureBox
    Friend WithEvents pan_datos_roles As Panel
    Friend WithEvents tit_roles As Label
    Friend WithEvents pb_id_rol As PictureBox
    Friend WithEvents pb_rol As PictureBox
End Class
