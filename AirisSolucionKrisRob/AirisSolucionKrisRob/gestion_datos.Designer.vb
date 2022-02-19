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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestion_datos))
        Me.toolstrip = New System.Windows.Forms.ToolStrip()
        Me.ts_volverimg = New System.Windows.Forms.ToolStripButton()
        Me.ts_volver = New System.Windows.Forms.ToolStripLabel()
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
        Me.tab_empleados = New System.Windows.Forms.TabPage()
        Me.pan_datos_emple = New System.Windows.Forms.Panel()
        Me.pan_btns_emple = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.tb_emple_usu = New System.Windows.Forms.TextBox()
        Me.tb_emple_cont = New System.Windows.Forms.TextBox()
        Me.tb_emple_nom = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_ape1 = New System.Windows.Forms.Label()
        Me.tb_emple_rol = New System.Windows.Forms.TextBox()
        Me.tb_emple_ape1 = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_nombre = New System.Windows.Forms.Label()
        Me.lbl_empleados_ape2 = New System.Windows.Forms.Label()
        Me.lbl_empleados_usuario = New System.Windows.Forms.Label()
        Me.tb_emple_correo = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_password = New System.Windows.Forms.Label()
        Me.lbl_empleados_telefono = New System.Windows.Forms.Label()
        Me.lbl_empleados_rol = New System.Windows.Forms.Label()
        Me.tb_emple_tlf = New System.Windows.Forms.TextBox()
        Me.lbl_empleados_id = New System.Windows.Forms.Label()
        Me.lbl_empleados_email = New System.Windows.Forms.Label()
        Me.tb_emple_id = New System.Windows.Forms.TextBox()
        Me.tb_emple_ape2 = New System.Windows.Forms.TextBox()
        Me.dg_emple = New System.Windows.Forms.DataGridView()
        Me.ts_empleados = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tab_roles = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dg_roles = New System.Windows.Forms.DataGridView()
        Me.tb_roles_rol = New System.Windows.Forms.TextBox()
        Me.lbl_roles_rol = New System.Windows.Forms.Label()
        Me.lbl_roles_id = New System.Windows.Forms.Label()
        Me.tb_roles_id = New System.Windows.Forms.TextBox()
        Me.tab_categorias = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.dg_categorias = New System.Windows.Forms.DataGridView()
        Me.tb_categorias_descripccion = New System.Windows.Forms.TextBox()
        Me.tb_categorias_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_categoria_descripcion = New System.Windows.Forms.Label()
        Me.lbl_categoria_nombre = New System.Windows.Forms.Label()
        Me.lbl_categoria_id = New System.Windows.Forms.Label()
        Me.tb_categorias_id = New System.Windows.Forms.TextBox()
        Me.tab_productos = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_productos_precio = New System.Windows.Forms.TextBox()
        Me.tb_productos_categoriaID = New System.Windows.Forms.TextBox()
        Me.tb_productos_stock = New System.Windows.Forms.TextBox()
        Me.tb_productos_marca = New System.Windows.Forms.TextBox()
        Me.tb_productos_descripccion = New System.Windows.Forms.TextBox()
        Me.tb_productos_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_productos_marca = New System.Windows.Forms.Label()
        Me.lbl_productos_descripccion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.tb_productos_id = New System.Windows.Forms.TextBox()
        Me.tb_clientes = New System.Windows.Forms.TabPage()
        Me.lbl_clientes_empleadoID = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbl_clientes_telefono = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.tb_clientes_ape1 = New System.Windows.Forms.TextBox()
        Me.tb_clientes_telefono = New System.Windows.Forms.TextBox()
        Me.tb_clientes_empleadoID = New System.Windows.Forms.TextBox()
        Me.tb_clientes_nombre = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tb_clientes_id = New System.Windows.Forms.TextBox()
        Me.tb_proveedores = New System.Windows.Forms.TabPage()
        Me.lbl_proveedores_telefono = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dg_proveedores = New System.Windows.Forms.DataGridView()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.tb_proveedores_direccion = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_telefono = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_contacto = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_proveedores_contacto = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tb_proveedores_id = New System.Windows.Forms.TextBox()
        Me.tslbl_modificar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel11 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel12 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel13 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel14 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel15 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel19 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel16 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel17 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel18 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel20 = New System.Windows.Forms.ToolStripLabel()
        Me.lbl_productos_id = New System.Windows.Forms.Label()
        Me.lbl_productos_nombre = New System.Windows.Forms.Label()
        Me.lbl_productos_precio = New System.Windows.Forms.Label()
        Me.lbl_productos_categoria_id = New System.Windows.Forms.Label()
        Me.lbl_producto_stock = New System.Windows.Forms.Label()
        Me.lbl_clientes_id = New System.Windows.Forms.Label()
        Me.lbl_clientes_nombre = New System.Windows.Forms.Label()
        Me.lbl_clientes_ape1 = New System.Windows.Forms.Label()
        Me.tb_clientes_ape2 = New System.Windows.Forms.TextBox()
        Me.lbl_clientes_ape2 = New System.Windows.Forms.Label()
        Me.lbl_proveedores_id = New System.Windows.Forms.Label()
        Me.lbl_proveedores_nombre = New System.Windows.Forms.Label()
        Me.lbl_proveedores_direccion = New System.Windows.Forms.Label()
        Me.lbl_clientes_direccion = New System.Windows.Forms.Label()
        Me.tb_clientes_direccion = New System.Windows.Forms.TextBox()
        Me.toolstrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.tab_empleados.SuspendLayout()
        Me.pan_datos_emple.SuspendLayout()
        Me.pan_btns_emple.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_emple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_empleados.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.tab_roles.SuspendLayout()
        CType(Me.dg_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_categorias.SuspendLayout()
        CType(Me.dg_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_productos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_clientes.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_proveedores.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolstrip
        '
        Me.toolstrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_volverimg, Me.ts_volver, Me.ToolStripSeparator2, Me.ts_busqueda, Me.ToolStripSeparator1, Me.ts_info, Me.ToolStripSeparator13, Me.ts_acerca, Me.ToolStripSeparator5, Me.ts_cerrar})
        Me.toolstrip.Location = New System.Drawing.Point(0, 0)
        Me.toolstrip.Name = "toolstrip"
        Me.toolstrip.Size = New System.Drawing.Size(1924, 27)
        Me.toolstrip.TabIndex = 1
        Me.toolstrip.Text = " "
        '
        'ts_volverimg
        '
        Me.ts_volverimg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_volverimg.Image = CType(resources.GetObject("ts_volverimg.Image"), System.Drawing.Image)
        Me.ts_volverimg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_volverimg.Name = "ts_volverimg"
        Me.ts_volverimg.Size = New System.Drawing.Size(24, 24)
        Me.ts_volverimg.Text = "ToolStripButton1"
        '
        'ts_volver
        '
        Me.ts_volver.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.ts_volver.Name = "ts_volver"
        Me.ts_volver.Size = New System.Drawing.Size(58, 24)
        Me.ts_volver.Text = "VOLVER"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ts_busqueda
        '
        Me.ts_busqueda.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_busqueda.Name = "ts_busqueda"
        Me.ts_busqueda.Size = New System.Drawing.Size(191, 24)
        Me.ts_busqueda.Text = "Realizar busqueda avanzada"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ts_info
        '
        Me.ts_info.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_info.Name = "ts_info"
        Me.ts_info.Size = New System.Drawing.Size(66, 24)
        Me.ts_info.Text = "Informes"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 27)
        '
        'ts_acerca
        '
        Me.ts_acerca.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.ts_acerca.Name = "ts_acerca"
        Me.ts_acerca.Size = New System.Drawing.Size(84, 24)
        Me.ts_acerca.Text = "Acerca de..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ts_cerrar
        '
        Me.ts_cerrar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.ts_cerrar.Name = "ts_cerrar"
        Me.ts_cerrar.Size = New System.Drawing.Size(94, 24)
        Me.ts_cerrar.Text = "Cerrar sesión"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_barraprogreso, Me.tss_usuario, Me.tss_fechahora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 983)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1924, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tss_barraprogreso
        '
        Me.tss_barraprogreso.Name = "tss_barraprogreso"
        Me.tss_barraprogreso.Size = New System.Drawing.Size(133, 20)
        '
        'tss_usuario
        '
        Me.tss_usuario.Name = "tss_usuario"
        Me.tss_usuario.Size = New System.Drawing.Size(59, 21)
        Me.tss_usuario.Text = "Usuario"
        '
        'tss_fechahora
        '
        Me.tss_fechahora.Name = "tss_fechahora"
        Me.tss_fechahora.Size = New System.Drawing.Size(92, 21)
        Me.tss_fechahora.Text = "Fecha y hora"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'tab_empleados
        '
        Me.tab_empleados.Controls.Add(Me.pan_datos_emple)
        Me.tab_empleados.Controls.Add(Me.dg_emple)
        Me.tab_empleados.Controls.Add(Me.ts_empleados)
        Me.tab_empleados.Location = New System.Drawing.Point(25, 4)
        Me.tab_empleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_empleados.Name = "tab_empleados"
        Me.tab_empleados.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_empleados.Size = New System.Drawing.Size(1895, 948)
        Me.tab_empleados.TabIndex = 3
        Me.tab_empleados.Text = "Empleados"
        Me.tab_empleados.UseVisualStyleBackColor = True
        '
        'pan_datos_emple
        '
        Me.pan_datos_emple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pan_datos_emple.Controls.Add(Me.pan_btns_emple)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_usu)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_cont)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_nom)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_ape1)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_rol)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_ape1)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_nombre)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_ape2)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_usuario)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_correo)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_password)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_telefono)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_rol)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_tlf)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_id)
        Me.pan_datos_emple.Controls.Add(Me.lbl_empleados_email)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_id)
        Me.pan_datos_emple.Controls.Add(Me.tb_emple_ape2)
        Me.pan_datos_emple.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pan_datos_emple.Location = New System.Drawing.Point(4, 350)
        Me.pan_datos_emple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pan_datos_emple.Name = "pan_datos_emple"
        Me.pan_datos_emple.Size = New System.Drawing.Size(1887, 594)
        Me.pan_datos_emple.TabIndex = 63
        '
        'pan_btns_emple
        '
        Me.pan_btns_emple.AutoSize = True
        Me.pan_btns_emple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pan_btns_emple.Controls.Add(Me.PictureBox2)
        Me.pan_btns_emple.Controls.Add(Me.Button11)
        Me.pan_btns_emple.Controls.Add(Me.Button12)
        Me.pan_btns_emple.Controls.Add(Me.Button10)
        Me.pan_btns_emple.Dock = System.Windows.Forms.DockStyle.Right
        Me.pan_btns_emple.Location = New System.Drawing.Point(1498, 0)
        Me.pan_btns_emple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pan_btns_emple.Name = "pan_btns_emple"
        Me.pan_btns_emple.Size = New System.Drawing.Size(389, 594)
        Me.pan_btns_emple.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox2.Location = New System.Drawing.Point(53, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(332, 177)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(33, 203)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 64)
        Me.Button11.TabIndex = 59
        Me.Button11.Text = "ALTA"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(285, 203)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(100, 64)
        Me.Button12.TabIndex = 58
        Me.Button12.Text = "MODIFICAR"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(157, 199)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 64)
        Me.Button10.TabIndex = 60
        Me.Button10.Text = "BAJA"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'tb_emple_usu
        '
        Me.tb_emple_usu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_usu.Location = New System.Drawing.Point(195, 119)
        Me.tb_emple_usu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_usu.Name = "tb_emple_usu"
        Me.tb_emple_usu.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_usu.TabIndex = 57
        '
        'tb_emple_cont
        '
        Me.tb_emple_cont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_cont.Location = New System.Drawing.Point(195, 160)
        Me.tb_emple_cont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_cont.Name = "tb_emple_cont"
        Me.tb_emple_cont.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_cont.TabIndex = 56
        '
        'tb_emple_nom
        '
        Me.tb_emple_nom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_nom.Location = New System.Drawing.Point(195, 198)
        Me.tb_emple_nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_nom.Name = "tb_emple_nom"
        Me.tb_emple_nom.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_nom.TabIndex = 55
        '
        'lbl_empleados_ape1
        '
        Me.lbl_empleados_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_ape1.AutoSize = True
        Me.lbl_empleados_ape1.Location = New System.Drawing.Point(400, 53)
        Me.lbl_empleados_ape1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_ape1.Name = "lbl_empleados_ape1"
        Me.lbl_empleados_ape1.Size = New System.Drawing.Size(106, 17)
        Me.lbl_empleados_ape1.TabIndex = 47
        Me.lbl_empleados_ape1.Text = "Primer apellido:"
        '
        'tb_emple_rol
        '
        Me.tb_emple_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_rol.Location = New System.Drawing.Point(195, 80)
        Me.tb_emple_rol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_rol.Name = "tb_emple_rol"
        Me.tb_emple_rol.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_rol.TabIndex = 50
        '
        'tb_emple_ape1
        '
        Me.tb_emple_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_ape1.Location = New System.Drawing.Point(627, 49)
        Me.tb_emple_ape1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_ape1.Name = "tb_emple_ape1"
        Me.tb_emple_ape1.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_ape1.TabIndex = 54
        '
        'lbl_empleados_nombre
        '
        Me.lbl_empleados_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_nombre.AutoSize = True
        Me.lbl_empleados_nombre.Location = New System.Drawing.Point(104, 198)
        Me.lbl_empleados_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_nombre.Name = "lbl_empleados_nombre"
        Me.lbl_empleados_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_empleados_nombre.TabIndex = 45
        Me.lbl_empleados_nombre.Text = "Nombre:"
        '
        'lbl_empleados_ape2
        '
        Me.lbl_empleados_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_ape2.AutoSize = True
        Me.lbl_empleados_ape2.Location = New System.Drawing.Point(387, 96)
        Me.lbl_empleados_ape2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_ape2.Name = "lbl_empleados_ape2"
        Me.lbl_empleados_ape2.Size = New System.Drawing.Size(122, 17)
        Me.lbl_empleados_ape2.TabIndex = 46
        Me.lbl_empleados_ape2.Text = "Segundo apellido:"
        '
        'lbl_empleados_usuario
        '
        Me.lbl_empleados_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_usuario.AutoSize = True
        Me.lbl_empleados_usuario.Location = New System.Drawing.Point(106, 119)
        Me.lbl_empleados_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_usuario.Name = "lbl_empleados_usuario"
        Me.lbl_empleados_usuario.Size = New System.Drawing.Size(61, 17)
        Me.lbl_empleados_usuario.TabIndex = 44
        Me.lbl_empleados_usuario.Text = "Usuario:"
        '
        'tb_emple_correo
        '
        Me.tb_emple_correo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_correo.Location = New System.Drawing.Point(627, 180)
        Me.tb_emple_correo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_correo.Name = "tb_emple_correo"
        Me.tb_emple_correo.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_correo.TabIndex = 53
        '
        'lbl_empleados_password
        '
        Me.lbl_empleados_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_password.AutoSize = True
        Me.lbl_empleados_password.Location = New System.Drawing.Point(82, 160)
        Me.lbl_empleados_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_password.Name = "lbl_empleados_password"
        Me.lbl_empleados_password.Size = New System.Drawing.Size(85, 17)
        Me.lbl_empleados_password.TabIndex = 43
        Me.lbl_empleados_password.Text = "Contraseña:"
        '
        'lbl_empleados_telefono
        '
        Me.lbl_empleados_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_telefono.AutoSize = True
        Me.lbl_empleados_telefono.Location = New System.Drawing.Point(440, 138)
        Me.lbl_empleados_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_telefono.Name = "lbl_empleados_telefono"
        Me.lbl_empleados_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_empleados_telefono.TabIndex = 48
        Me.lbl_empleados_telefono.Text = "Teléfono:"
        '
        'lbl_empleados_rol
        '
        Me.lbl_empleados_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_rol.AutoSize = True
        Me.lbl_empleados_rol.Location = New System.Drawing.Point(132, 80)
        Me.lbl_empleados_rol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_rol.Name = "lbl_empleados_rol"
        Me.lbl_empleados_rol.Size = New System.Drawing.Size(33, 17)
        Me.lbl_empleados_rol.TabIndex = 42
        Me.lbl_empleados_rol.Text = "Rol:"
        '
        'tb_emple_tlf
        '
        Me.tb_emple_tlf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_tlf.Location = New System.Drawing.Point(627, 134)
        Me.tb_emple_tlf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_tlf.Name = "tb_emple_tlf"
        Me.tb_emple_tlf.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_tlf.TabIndex = 52
        '
        'lbl_empleados_id
        '
        Me.lbl_empleados_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_id.AutoSize = True
        Me.lbl_empleados_id.Location = New System.Drawing.Point(132, 44)
        Me.lbl_empleados_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_id.Name = "lbl_empleados_id"
        Me.lbl_empleados_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_empleados_id.TabIndex = 41
        Me.lbl_empleados_id.Text = "ID:"
        '
        'lbl_empleados_email
        '
        Me.lbl_empleados_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_email.AutoSize = True
        Me.lbl_empleados_email.Location = New System.Drawing.Point(381, 183)
        Me.lbl_empleados_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_empleados_email.Name = "lbl_empleados_email"
        Me.lbl_empleados_email.Size = New System.Drawing.Size(128, 17)
        Me.lbl_empleados_email.TabIndex = 49
        Me.lbl_empleados_email.Text = "Correo electrónico:"
        '
        'tb_emple_id
        '
        Me.tb_emple_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_id.Enabled = False
        Me.tb_emple_id.Location = New System.Drawing.Point(195, 44)
        Me.tb_emple_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_id.Name = "tb_emple_id"
        Me.tb_emple_id.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_id.TabIndex = 40
        '
        'tb_emple_ape2
        '
        Me.tb_emple_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_ape2.Location = New System.Drawing.Point(627, 92)
        Me.tb_emple_ape2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_emple_ape2.Name = "tb_emple_ape2"
        Me.tb_emple_ape2.Size = New System.Drawing.Size(155, 22)
        Me.tb_emple_ape2.TabIndex = 51
        '
        'dg_emple
        '
        Me.dg_emple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_emple.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_emple.Location = New System.Drawing.Point(4, 29)
        Me.dg_emple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_emple.Name = "dg_emple"
        Me.dg_emple.Size = New System.Drawing.Size(1887, 302)
        Me.dg_emple.TabIndex = 62
        '
        'ts_empleados
        '
        Me.ts_empleados.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_empleados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_empleados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo, Me.ToolStripSeparator3, Me.tslbl_alta, Me.ToolStripSeparator4, Me.tslbl_baja, Me.tslbl_modificar})
        Me.ts_empleados.Location = New System.Drawing.Point(4, 4)
        Me.ts_empleados.Name = "ts_empleados"
        Me.ts_empleados.Size = New System.Drawing.Size(1887, 25)
        Me.ts_empleados.TabIndex = 2
        Me.ts_empleados.Text = "ToolStrip2"
        '
        'tslbl_nuevo
        '
        Me.tslbl_nuevo.Name = "tslbl_nuevo"
        Me.tslbl_nuevo.Size = New System.Drawing.Size(52, 22)
        Me.tslbl_nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta
        '
        Me.tslbl_alta.Name = "tslbl_alta"
        Me.tslbl_alta.Size = New System.Drawing.Size(36, 22)
        Me.tslbl_alta.Text = "Alta"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja
        '
        Me.tslbl_baja.Name = "tslbl_baja"
        Me.tslbl_baja.Size = New System.Drawing.Size(38, 22)
        Me.tslbl_baja.Text = "Baja"
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl.Controls.Add(Me.tab_empleados)
        Me.TabControl.Controls.Add(Me.tab_roles)
        Me.TabControl.Controls.Add(Me.tab_categorias)
        Me.TabControl.Controls.Add(Me.tab_productos)
        Me.TabControl.Controls.Add(Me.tb_clientes)
        Me.TabControl.Controls.Add(Me.tb_proveedores)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 27)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1924, 956)
        Me.TabControl.TabIndex = 0
        '
        'tab_roles
        '
        Me.tab_roles.Controls.Add(Me.ToolStrip1)
        Me.tab_roles.Controls.Add(Me.Button3)
        Me.tab_roles.Controls.Add(Me.Button5)
        Me.tab_roles.Controls.Add(Me.Button6)
        Me.tab_roles.Controls.Add(Me.dg_roles)
        Me.tab_roles.Controls.Add(Me.tb_roles_rol)
        Me.tab_roles.Controls.Add(Me.lbl_roles_rol)
        Me.tab_roles.Controls.Add(Me.lbl_roles_id)
        Me.tab_roles.Controls.Add(Me.tb_roles_id)
        Me.tab_roles.Location = New System.Drawing.Point(25, 4)
        Me.tab_roles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_roles.Name = "tab_roles"
        Me.tab_roles.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_roles.Size = New System.Drawing.Size(1895, 948)
        Me.tab_roles.TabIndex = 4
        Me.tab_roles.Text = "Roles"
        Me.tab_roles.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(280, 481)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 64)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "BAJA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(172, 481)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 64)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "ALTA"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(381, 481)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 64)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "MODIFICAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dg_roles
        '
        Me.dg_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_roles.Dock = System.Windows.Forms.DockStyle.Right
        Me.dg_roles.Location = New System.Drawing.Point(1200, 4)
        Me.dg_roles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_roles.Name = "dg_roles"
        Me.dg_roles.Size = New System.Drawing.Size(691, 940)
        Me.dg_roles.TabIndex = 0
        '
        'tb_roles_rol
        '
        Me.tb_roles_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_roles_rol.Location = New System.Drawing.Point(186, 309)
        Me.tb_roles_rol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_roles_rol.Name = "tb_roles_rol"
        Me.tb_roles_rol.Size = New System.Drawing.Size(155, 22)
        Me.tb_roles_rol.TabIndex = 14
        '
        'lbl_roles_rol
        '
        Me.lbl_roles_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_roles_rol.AutoSize = True
        Me.lbl_roles_rol.Location = New System.Drawing.Point(151, 312)
        Me.lbl_roles_rol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_roles_rol.Name = "lbl_roles_rol"
        Me.lbl_roles_rol.Size = New System.Drawing.Size(33, 17)
        Me.lbl_roles_rol.TabIndex = 13
        Me.lbl_roles_rol.Text = "Rol:"
        '
        'lbl_roles_id
        '
        Me.lbl_roles_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_roles_id.AutoSize = True
        Me.lbl_roles_id.Location = New System.Drawing.Point(158, 276)
        Me.lbl_roles_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_roles_id.Name = "lbl_roles_id"
        Me.lbl_roles_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_roles_id.TabIndex = 12
        Me.lbl_roles_id.Text = "ID:"
        '
        'tb_roles_id
        '
        Me.tb_roles_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_roles_id.Enabled = False
        Me.tb_roles_id.Location = New System.Drawing.Point(186, 273)
        Me.tb_roles_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_roles_id.Name = "tb_roles_id"
        Me.tb_roles_id.Size = New System.Drawing.Size(155, 22)
        Me.tb_roles_id.TabIndex = 11
        '
        'tab_categorias
        '
        Me.tab_categorias.Controls.Add(Me.ToolStrip2)
        Me.tab_categorias.Controls.Add(Me.Button7)
        Me.tab_categorias.Controls.Add(Me.Button8)
        Me.tab_categorias.Controls.Add(Me.Button9)
        Me.tab_categorias.Controls.Add(Me.dg_categorias)
        Me.tab_categorias.Controls.Add(Me.tb_categorias_descripccion)
        Me.tab_categorias.Controls.Add(Me.tb_categorias_nombre)
        Me.tab_categorias.Controls.Add(Me.lbl_categoria_descripcion)
        Me.tab_categorias.Controls.Add(Me.lbl_categoria_nombre)
        Me.tab_categorias.Controls.Add(Me.lbl_categoria_id)
        Me.tab_categorias.Controls.Add(Me.tb_categorias_id)
        Me.tab_categorias.Location = New System.Drawing.Point(25, 4)
        Me.tab_categorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_categorias.Name = "tab_categorias"
        Me.tab_categorias.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_categorias.Size = New System.Drawing.Size(1895, 948)
        Me.tab_categorias.TabIndex = 5
        Me.tab_categorias.Text = "Categorías productos"
        Me.tab_categorias.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(483, 505)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 64)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "BAJA"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(375, 505)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 64)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "ALTA"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(591, 505)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 64)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "MODIFICAR"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'dg_categorias
        '
        Me.dg_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_categorias.Dock = System.Windows.Forms.DockStyle.Right
        Me.dg_categorias.Location = New System.Drawing.Point(1312, 4)
        Me.dg_categorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_categorias.Name = "dg_categorias"
        Me.dg_categorias.Size = New System.Drawing.Size(579, 940)
        Me.dg_categorias.TabIndex = 24
        '
        'tb_categorias_descripccion
        '
        Me.tb_categorias_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_descripccion.Location = New System.Drawing.Point(208, 350)
        Me.tb_categorias_descripccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_categorias_descripccion.Multiline = True
        Me.tb_categorias_descripccion.Name = "tb_categorias_descripccion"
        Me.tb_categorias_descripccion.Size = New System.Drawing.Size(273, 101)
        Me.tb_categorias_descripccion.TabIndex = 23
        '
        'tb_categorias_nombre
        '
        Me.tb_categorias_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_nombre.Location = New System.Drawing.Point(208, 310)
        Me.tb_categorias_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_categorias_nombre.Name = "tb_categorias_nombre"
        Me.tb_categorias_nombre.Size = New System.Drawing.Size(273, 22)
        Me.tb_categorias_nombre.TabIndex = 22
        '
        'lbl_categoria_descripcion
        '
        Me.lbl_categoria_descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_descripcion.AutoSize = True
        Me.lbl_categoria_descripcion.Location = New System.Drawing.Point(121, 353)
        Me.lbl_categoria_descripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categoria_descripcion.Name = "lbl_categoria_descripcion"
        Me.lbl_categoria_descripcion.Size = New System.Drawing.Size(86, 17)
        Me.lbl_categoria_descripcion.TabIndex = 21
        Me.lbl_categoria_descripcion.Text = "Descripción:"
        '
        'lbl_categoria_nombre
        '
        Me.lbl_categoria_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_nombre.AutoSize = True
        Me.lbl_categoria_nombre.Location = New System.Drawing.Point(46, 313)
        Me.lbl_categoria_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categoria_nombre.Name = "lbl_categoria_nombre"
        Me.lbl_categoria_nombre.Size = New System.Drawing.Size(160, 17)
        Me.lbl_categoria_nombre.TabIndex = 20
        Me.lbl_categoria_nombre.Text = "Nombre de la categoría:"
        '
        'lbl_categoria_id
        '
        Me.lbl_categoria_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_id.AutoSize = True
        Me.lbl_categoria_id.Location = New System.Drawing.Point(180, 277)
        Me.lbl_categoria_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_categoria_id.Name = "lbl_categoria_id"
        Me.lbl_categoria_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_categoria_id.TabIndex = 19
        Me.lbl_categoria_id.Text = "ID:"
        '
        'tb_categorias_id
        '
        Me.tb_categorias_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_id.Enabled = False
        Me.tb_categorias_id.Location = New System.Drawing.Point(208, 274)
        Me.tb_categorias_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_categorias_id.Name = "tb_categorias_id"
        Me.tb_categorias_id.Size = New System.Drawing.Size(123, 22)
        Me.tb_categorias_id.TabIndex = 18
        '
        'tab_productos
        '
        Me.tab_productos.Controls.Add(Me.lbl_producto_stock)
        Me.tab_productos.Controls.Add(Me.lbl_productos_categoria_id)
        Me.tab_productos.Controls.Add(Me.lbl_productos_precio)
        Me.tab_productos.Controls.Add(Me.lbl_productos_nombre)
        Me.tab_productos.Controls.Add(Me.lbl_productos_id)
        Me.tab_productos.Controls.Add(Me.Label2)
        Me.tab_productos.Controls.Add(Me.PictureBox1)
        Me.tab_productos.Controls.Add(Me.Label14)
        Me.tab_productos.Controls.Add(Me.dg_productos)
        Me.tab_productos.Controls.Add(Me.Button4)
        Me.tab_productos.Controls.Add(Me.Button2)
        Me.tab_productos.Controls.Add(Me.Button1)
        Me.tab_productos.Controls.Add(Me.tb_productos_precio)
        Me.tab_productos.Controls.Add(Me.tb_productos_categoriaID)
        Me.tab_productos.Controls.Add(Me.tb_productos_stock)
        Me.tab_productos.Controls.Add(Me.tb_productos_marca)
        Me.tab_productos.Controls.Add(Me.tb_productos_descripccion)
        Me.tab_productos.Controls.Add(Me.tb_productos_nombre)
        Me.tab_productos.Controls.Add(Me.lbl_productos_marca)
        Me.tab_productos.Controls.Add(Me.lbl_productos_descripccion)
        Me.tab_productos.Controls.Add(Me.Label5)
        Me.tab_productos.Controls.Add(Me.Label4)
        Me.tab_productos.Controls.Add(Me.Label3)
        Me.tab_productos.Controls.Add(Me.lbl_id)
        Me.tab_productos.Controls.Add(Me.tb_productos_id)
        Me.tab_productos.Controls.Add(Me.ToolStrip3)
        Me.tab_productos.Location = New System.Drawing.Point(25, 4)
        Me.tab_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_productos.Name = "tab_productos"
        Me.tab_productos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_productos.Size = New System.Drawing.Size(1895, 948)
        Me.tab_productos.TabIndex = 6
        Me.tab_productos.Text = "Productos"
        Me.tab_productos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-86, 665)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Stock:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(1157, 425)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(496, 449)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Label14"
        '
        'dg_productos
        '
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_productos.Location = New System.Drawing.Point(4, 29)
        Me.dg_productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.Size = New System.Drawing.Size(1887, 357)
        Me.dg_productos.TabIndex = 43
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1265, 620)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 64)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "BAJA"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1157, 620)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 64)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "ALTA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1367, 620)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 64)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "MODIFICAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_productos_precio
        '
        Me.tb_productos_precio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_precio.Location = New System.Drawing.Point(173, 584)
        Me.tb_productos_precio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_precio.Name = "tb_productos_precio"
        Me.tb_productos_precio.Size = New System.Drawing.Size(155, 22)
        Me.tb_productos_precio.TabIndex = 39
        '
        'tb_productos_categoriaID
        '
        Me.tb_productos_categoriaID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_categoriaID.Location = New System.Drawing.Point(173, 625)
        Me.tb_productos_categoriaID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_categoriaID.Name = "tb_productos_categoriaID"
        Me.tb_productos_categoriaID.Size = New System.Drawing.Size(155, 22)
        Me.tb_productos_categoriaID.TabIndex = 38
        '
        'tb_productos_stock
        '
        Me.tb_productos_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_stock.Location = New System.Drawing.Point(173, 663)
        Me.tb_productos_stock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_stock.Name = "tb_productos_stock"
        Me.tb_productos_stock.Size = New System.Drawing.Size(155, 22)
        Me.tb_productos_stock.TabIndex = 37
        '
        'tb_productos_marca
        '
        Me.tb_productos_marca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_marca.Location = New System.Drawing.Point(633, 511)
        Me.tb_productos_marca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_marca.Name = "tb_productos_marca"
        Me.tb_productos_marca.Size = New System.Drawing.Size(155, 22)
        Me.tb_productos_marca.TabIndex = 36
        '
        'tb_productos_descripccion
        '
        Me.tb_productos_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_descripccion.Location = New System.Drawing.Point(633, 554)
        Me.tb_productos_descripccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_descripccion.Multiline = True
        Me.tb_productos_descripccion.Name = "tb_productos_descripccion"
        Me.tb_productos_descripccion.Size = New System.Drawing.Size(155, 88)
        Me.tb_productos_descripccion.TabIndex = 33
        '
        'tb_productos_nombre
        '
        Me.tb_productos_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_nombre.Location = New System.Drawing.Point(173, 545)
        Me.tb_productos_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_nombre.Name = "tb_productos_nombre"
        Me.tb_productos_nombre.Size = New System.Drawing.Size(155, 22)
        Me.tb_productos_nombre.TabIndex = 32
        '
        'lbl_productos_marca
        '
        Me.lbl_productos_marca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_productos_marca.AutoSize = True
        Me.lbl_productos_marca.Location = New System.Drawing.Point(579, 514)
        Me.lbl_productos_marca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos_marca.Name = "lbl_productos_marca"
        Me.lbl_productos_marca.Size = New System.Drawing.Size(51, 17)
        Me.lbl_productos_marca.TabIndex = 29
        Me.lbl_productos_marca.Text = "Marca:"
        '
        'lbl_productos_descripccion
        '
        Me.lbl_productos_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_productos_descripccion.AutoSize = True
        Me.lbl_productos_descripccion.Location = New System.Drawing.Point(545, 557)
        Me.lbl_productos_descripccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos_descripccion.Name = "lbl_productos_descripccion"
        Me.lbl_productos_descripccion.Size = New System.Drawing.Size(86, 17)
        Me.lbl_productos_descripccion.TabIndex = 28
        Me.lbl_productos_descripccion.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-98, 546)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-111, 626)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Categoría:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-88, 586)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Precio:"
        '
        'lbl_id
        '
        Me.lbl_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(-63, 511)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 23
        Me.lbl_id.Text = "ID:"
        '
        'tb_productos_id
        '
        Me.tb_productos_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_id.Enabled = False
        Me.tb_productos_id.Location = New System.Drawing.Point(173, 509)
        Me.tb_productos_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_productos_id.Name = "tb_productos_id"
        Me.tb_productos_id.Size = New System.Drawing.Size(155, 22)
        Me.tb_productos_id.TabIndex = 22
        '
        'tb_clientes
        '
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_direccion)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_direccion)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_ape2)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_ape2)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_ape1)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_nombre)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_id)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_empleadoID)
        Me.tb_clientes.Controls.Add(Me.Label31)
        Me.tb_clientes.Controls.Add(Me.lbl_clientes_telefono)
        Me.tb_clientes.Controls.Add(Me.PictureBox3)
        Me.tb_clientes.Controls.Add(Me.Label9)
        Me.tb_clientes.Controls.Add(Me.dg_clientes)
        Me.tb_clientes.Controls.Add(Me.Button13)
        Me.tb_clientes.Controls.Add(Me.Button14)
        Me.tb_clientes.Controls.Add(Me.Button15)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_ape1)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_telefono)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_empleadoID)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_nombre)
        Me.tb_clientes.Controls.Add(Me.Label26)
        Me.tb_clientes.Controls.Add(Me.Label29)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_id)
        Me.tb_clientes.Controls.Add(Me.ToolStrip4)
        Me.tb_clientes.Location = New System.Drawing.Point(25, 4)
        Me.tb_clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes.Name = "tb_clientes"
        Me.tb_clientes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes.Size = New System.Drawing.Size(1895, 948)
        Me.tb_clientes.TabIndex = 7
        Me.tb_clientes.Text = "Clientes"
        Me.tb_clientes.UseVisualStyleBackColor = True
        '
        'lbl_clientes_empleadoID
        '
        Me.lbl_clientes_empleadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_empleadoID.AutoSize = True
        Me.lbl_clientes_empleadoID.Location = New System.Drawing.Point(434, 577)
        Me.lbl_clientes_empleadoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_empleadoID.Name = "lbl_clientes_empleadoID"
        Me.lbl_clientes_empleadoID.Size = New System.Drawing.Size(92, 17)
        Me.lbl_clientes_empleadoID.TabIndex = 69
        Me.lbl_clientes_empleadoID.Text = "Empleado ID:"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(-139, 614)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(106, 17)
        Me.Label31.TabIndex = 68
        Me.Label31.Text = "Primer apellido:"
        '
        'lbl_clientes_telefono
        '
        Me.lbl_clientes_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_telefono.AutoSize = True
        Me.lbl_clientes_telefono.Location = New System.Drawing.Point(458, 534)
        Me.lbl_clientes_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_telefono.Name = "lbl_clientes_telefono"
        Me.lbl_clientes_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_clientes_telefono.TabIndex = 67
        Me.lbl_clientes_telefono.Text = "Telefono:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox3.Location = New System.Drawing.Point(1157, 453)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(332, 177)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(496, 478)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Label9"
        '
        'dg_clientes
        '
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_clientes.Location = New System.Drawing.Point(4, 29)
        Me.dg_clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.Size = New System.Drawing.Size(1887, 357)
        Me.dg_clientes.TabIndex = 63
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(1265, 649)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(100, 64)
        Me.Button13.TabIndex = 62
        Me.Button13.Text = "BAJA"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(1157, 649)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(100, 64)
        Me.Button14.TabIndex = 61
        Me.Button14.Text = "ALTA"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(1367, 649)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(100, 64)
        Me.Button15.TabIndex = 60
        Me.Button15.Text = "MODIFICAR"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'tb_clientes_ape1
        '
        Me.tb_clientes_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_ape1.Location = New System.Drawing.Point(184, 607)
        Me.tb_clientes_ape1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes_ape1.Name = "tb_clientes_ape1"
        Me.tb_clientes_ape1.Size = New System.Drawing.Size(155, 22)
        Me.tb_clientes_ape1.TabIndex = 59
        '
        'tb_clientes_telefono
        '
        Me.tb_clientes_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_telefono.Location = New System.Drawing.Point(534, 534)
        Me.tb_clientes_telefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes_telefono.Name = "tb_clientes_telefono"
        Me.tb_clientes_telefono.Size = New System.Drawing.Size(155, 22)
        Me.tb_clientes_telefono.TabIndex = 58
        '
        'tb_clientes_empleadoID
        '
        Me.tb_clientes_empleadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_empleadoID.Location = New System.Drawing.Point(534, 573)
        Me.tb_clientes_empleadoID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes_empleadoID.Name = "tb_clientes_empleadoID"
        Me.tb_clientes_empleadoID.Size = New System.Drawing.Size(155, 22)
        Me.tb_clientes_empleadoID.TabIndex = 57
        '
        'tb_clientes_nombre
        '
        Me.tb_clientes_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_nombre.Location = New System.Drawing.Point(184, 570)
        Me.tb_clientes_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes_nombre.Name = "tb_clientes_nombre"
        Me.tb_clientes_nombre.Size = New System.Drawing.Size(155, 22)
        Me.tb_clientes_nombre.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-98, 575)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 17)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "Nombre:"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(-63, 539)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(25, 17)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "ID:"
        '
        'tb_clientes_id
        '
        Me.tb_clientes_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_id.Enabled = False
        Me.tb_clientes_id.Location = New System.Drawing.Point(184, 534)
        Me.tb_clientes_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_clientes_id.Name = "tb_clientes_id"
        Me.tb_clientes_id.Size = New System.Drawing.Size(155, 22)
        Me.tb_clientes_id.TabIndex = 47
        '
        'tb_proveedores
        '
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_direccion)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_id)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_nombre)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_telefono)
        Me.tb_proveedores.Controls.Add(Me.Label25)
        Me.tb_proveedores.Controls.Add(Me.PictureBox4)
        Me.tb_proveedores.Controls.Add(Me.Label28)
        Me.tb_proveedores.Controls.Add(Me.dg_proveedores)
        Me.tb_proveedores.Controls.Add(Me.Button16)
        Me.tb_proveedores.Controls.Add(Me.Button17)
        Me.tb_proveedores.Controls.Add(Me.Button18)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_direccion)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_telefono)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_contacto)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_nombre)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_contacto)
        Me.tb_proveedores.Controls.Add(Me.Label34)
        Me.tb_proveedores.Controls.Add(Me.Label35)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_id)
        Me.tb_proveedores.Controls.Add(Me.ToolStrip5)
        Me.tb_proveedores.Location = New System.Drawing.Point(25, 4)
        Me.tb_proveedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores.Name = "tb_proveedores"
        Me.tb_proveedores.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores.Size = New System.Drawing.Size(1895, 948)
        Me.tb_proveedores.TabIndex = 8
        Me.tb_proveedores.Text = "Proveedores"
        Me.tb_proveedores.UseVisualStyleBackColor = True
        '
        'lbl_proveedores_telefono
        '
        Me.lbl_proveedores_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_telefono.AutoSize = True
        Me.lbl_proveedores_telefono.Location = New System.Drawing.Point(430, 554)
        Me.lbl_proveedores_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_proveedores_telefono.Name = "lbl_proveedores_telefono"
        Me.lbl_proveedores_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_proveedores_telefono.TabIndex = 87
        Me.lbl_proveedores_telefono.Text = "Teléfono:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(-108, 629)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 17)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Dirección:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox4.Location = New System.Drawing.Point(1105, 433)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(332, 177)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 84
        Me.PictureBox4.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(496, 492)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 17)
        Me.Label28.TabIndex = 83
        Me.Label28.Text = "Label28"
        '
        'dg_proveedores
        '
        Me.dg_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_proveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_proveedores.Location = New System.Drawing.Point(4, 29)
        Me.dg_proveedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_proveedores.Name = "dg_proveedores"
        Me.dg_proveedores.Size = New System.Drawing.Size(1887, 357)
        Me.dg_proveedores.TabIndex = 82
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(1213, 629)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(100, 64)
        Me.Button16.TabIndex = 81
        Me.Button16.Text = "BAJA"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(1105, 629)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(100, 64)
        Me.Button17.TabIndex = 80
        Me.Button17.Text = "ALTA"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(1315, 629)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(100, 64)
        Me.Button18.TabIndex = 79
        Me.Button18.Text = "MODIFICAR"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'tb_proveedores_direccion
        '
        Me.tb_proveedores_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_direccion.Location = New System.Drawing.Point(171, 624)
        Me.tb_proveedores_direccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores_direccion.Name = "tb_proveedores_direccion"
        Me.tb_proveedores_direccion.Size = New System.Drawing.Size(384, 22)
        Me.tb_proveedores_direccion.TabIndex = 78
        '
        'tb_proveedores_telefono
        '
        Me.tb_proveedores_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_telefono.Location = New System.Drawing.Point(629, 550)
        Me.tb_proveedores_telefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores_telefono.Name = "tb_proveedores_telefono"
        Me.tb_proveedores_telefono.Size = New System.Drawing.Size(155, 22)
        Me.tb_proveedores_telefono.TabIndex = 76
        '
        'tb_proveedores_contacto
        '
        Me.tb_proveedores_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_contacto.Location = New System.Drawing.Point(629, 587)
        Me.tb_proveedores_contacto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores_contacto.Name = "tb_proveedores_contacto"
        Me.tb_proveedores_contacto.Size = New System.Drawing.Size(155, 22)
        Me.tb_proveedores_contacto.TabIndex = 75
        '
        'tb_proveedores_nombre
        '
        Me.tb_proveedores_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_nombre.Location = New System.Drawing.Point(171, 585)
        Me.tb_proveedores_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores_nombre.Name = "tb_proveedores_nombre"
        Me.tb_proveedores_nombre.Size = New System.Drawing.Size(155, 22)
        Me.tb_proveedores_nombre.TabIndex = 74
        '
        'lbl_proveedores_contacto
        '
        Me.lbl_proveedores_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_contacto.AutoSize = True
        Me.lbl_proveedores_contacto.Location = New System.Drawing.Point(429, 591)
        Me.lbl_proveedores_contacto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_proveedores_contacto.Name = "lbl_proveedores_contacto"
        Me.lbl_proveedores_contacto.Size = New System.Drawing.Size(68, 17)
        Me.lbl_proveedores_contacto.TabIndex = 73
        Me.lbl_proveedores_contacto.Text = "Contacto:"
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(-98, 590)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(62, 17)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "Nombre:"
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(-63, 554)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(25, 17)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "ID:"
        '
        'tb_proveedores_id
        '
        Me.tb_proveedores_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_id.Enabled = False
        Me.tb_proveedores_id.Location = New System.Drawing.Point(171, 549)
        Me.tb_proveedores_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_proveedores_id.Name = "tb_proveedores_id"
        Me.tb_proveedores_id.Size = New System.Drawing.Size(155, 22)
        Me.tb_proveedores_id.TabIndex = 70
        '
        'tslbl_modificar
        '
        Me.tslbl_modificar.Name = "tslbl_modificar"
        Me.tslbl_modificar.Size = New System.Drawing.Size(73, 22)
        Me.tslbl_modificar.Text = "Modificar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator6, Me.ToolStripLabel2, Me.ToolStripSeparator7, Me.ToolStripLabel3, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1196, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel1.Text = "Nuevo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel2.Text = "Alta"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel3.Text = "Baja"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel4.Text = "Modificar"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.ToolStripSeparator8, Me.ToolStripLabel6, Me.ToolStripSeparator9, Me.ToolStripLabel7, Me.ToolStripLabel8})
        Me.ToolStrip2.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1308, 25)
        Me.ToolStrip2.TabIndex = 28
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel5.Text = "Nuevo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel6.Text = "Alta"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel7.Text = "Baja"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel8.Text = "Modificar"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel9, Me.ToolStripSeparator10, Me.ToolStripLabel10, Me.ToolStripSeparator11, Me.ToolStripLabel11, Me.ToolStripLabel12})
        Me.ToolStrip3.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1887, 25)
        Me.ToolStrip3.TabIndex = 47
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel9.Text = "Nuevo"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel10
        '
        Me.ToolStripLabel10.Name = "ToolStripLabel10"
        Me.ToolStripLabel10.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel10.Text = "Alta"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel11
        '
        Me.ToolStripLabel11.Name = "ToolStripLabel11"
        Me.ToolStripLabel11.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel11.Text = "Baja"
        '
        'ToolStripLabel12
        '
        Me.ToolStripLabel12.Name = "ToolStripLabel12"
        Me.ToolStripLabel12.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel12.Text = "Modificar"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel13, Me.ToolStripSeparator12, Me.ToolStripLabel14, Me.ToolStripSeparator14, Me.ToolStripLabel15, Me.ToolStripLabel19})
        Me.ToolStrip4.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(1887, 25)
        Me.ToolStrip4.TabIndex = 70
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel13
        '
        Me.ToolStripLabel13.Name = "ToolStripLabel13"
        Me.ToolStripLabel13.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel13.Text = "Nuevo"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel14
        '
        Me.ToolStripLabel14.Name = "ToolStripLabel14"
        Me.ToolStripLabel14.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel14.Text = "Alta"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel15
        '
        Me.ToolStripLabel15.Name = "ToolStripLabel15"
        Me.ToolStripLabel15.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel15.Text = "Baja"
        '
        'ToolStripLabel19
        '
        Me.ToolStripLabel19.Name = "ToolStripLabel19"
        Me.ToolStripLabel19.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel19.Text = "Modificar"
        '
        'ToolStrip5
        '
        Me.ToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel16, Me.ToolStripSeparator15, Me.ToolStripLabel17, Me.ToolStripSeparator16, Me.ToolStripLabel18, Me.ToolStripLabel20})
        Me.ToolStrip5.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(1887, 25)
        Me.ToolStrip5.TabIndex = 88
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'ToolStripLabel16
        '
        Me.ToolStripLabel16.Name = "ToolStripLabel16"
        Me.ToolStripLabel16.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel16.Text = "Nuevo"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel17
        '
        Me.ToolStripLabel17.Name = "ToolStripLabel17"
        Me.ToolStripLabel17.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel17.Text = "Alta"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel18
        '
        Me.ToolStripLabel18.Name = "ToolStripLabel18"
        Me.ToolStripLabel18.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel18.Text = "Baja"
        '
        'ToolStripLabel20
        '
        Me.ToolStripLabel20.Name = "ToolStripLabel20"
        Me.ToolStripLabel20.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel20.Text = "Modificar"
        '
        'lbl_productos_id
        '
        Me.lbl_productos_id.AutoSize = True
        Me.lbl_productos_id.Location = New System.Drawing.Point(97, 512)
        Me.lbl_productos_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos_id.Name = "lbl_productos_id"
        Me.lbl_productos_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_productos_id.TabIndex = 48
        Me.lbl_productos_id.Text = "ID:"
        '
        'lbl_productos_nombre
        '
        Me.lbl_productos_nombre.AutoSize = True
        Me.lbl_productos_nombre.Location = New System.Drawing.Point(97, 554)
        Me.lbl_productos_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos_nombre.Name = "lbl_productos_nombre"
        Me.lbl_productos_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_productos_nombre.TabIndex = 49
        Me.lbl_productos_nombre.Text = "Nombre:"
        '
        'lbl_productos_precio
        '
        Me.lbl_productos_precio.AutoSize = True
        Me.lbl_productos_precio.Location = New System.Drawing.Point(97, 589)
        Me.lbl_productos_precio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos_precio.Name = "lbl_productos_precio"
        Me.lbl_productos_precio.Size = New System.Drawing.Size(52, 17)
        Me.lbl_productos_precio.TabIndex = 50
        Me.lbl_productos_precio.Text = "Precio:"
        '
        'lbl_productos_categoria_id
        '
        Me.lbl_productos_categoria_id.AutoSize = True
        Me.lbl_productos_categoria_id.Location = New System.Drawing.Point(75, 628)
        Me.lbl_productos_categoria_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productos_categoria_id.Name = "lbl_productos_categoria_id"
        Me.lbl_productos_categoria_id.Size = New System.Drawing.Size(90, 17)
        Me.lbl_productos_categoria_id.TabIndex = 51
        Me.lbl_productos_categoria_id.Text = "Categoria ID:"
        '
        'lbl_producto_stock
        '
        Me.lbl_producto_stock.AutoSize = True
        Me.lbl_producto_stock.Location = New System.Drawing.Point(97, 666)
        Me.lbl_producto_stock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_producto_stock.Name = "lbl_producto_stock"
        Me.lbl_producto_stock.Size = New System.Drawing.Size(47, 17)
        Me.lbl_producto_stock.TabIndex = 52
        Me.lbl_producto_stock.Text = "Stock:"
        '
        'lbl_clientes_id
        '
        Me.lbl_clientes_id.AutoSize = True
        Me.lbl_clientes_id.Location = New System.Drawing.Point(74, 534)
        Me.lbl_clientes_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_id.Name = "lbl_clientes_id"
        Me.lbl_clientes_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_clientes_id.TabIndex = 71
        Me.lbl_clientes_id.Text = "ID:"
        '
        'lbl_clientes_nombre
        '
        Me.lbl_clientes_nombre.AutoSize = True
        Me.lbl_clientes_nombre.Location = New System.Drawing.Point(74, 573)
        Me.lbl_clientes_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_nombre.Name = "lbl_clientes_nombre"
        Me.lbl_clientes_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_clientes_nombre.TabIndex = 72
        Me.lbl_clientes_nombre.Text = "Nombre:"
        '
        'lbl_clientes_ape1
        '
        Me.lbl_clientes_ape1.AutoSize = True
        Me.lbl_clientes_ape1.Location = New System.Drawing.Point(74, 612)
        Me.lbl_clientes_ape1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_ape1.Name = "lbl_clientes_ape1"
        Me.lbl_clientes_ape1.Size = New System.Drawing.Size(107, 17)
        Me.lbl_clientes_ape1.TabIndex = 73
        Me.lbl_clientes_ape1.Text = "Primer Apellido:"
        '
        'tb_clientes_ape2
        '
        Me.tb_clientes_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_ape2.Location = New System.Drawing.Point(532, 614)
        Me.tb_clientes_ape2.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_clientes_ape2.Name = "tb_clientes_ape2"
        Me.tb_clientes_ape2.Size = New System.Drawing.Size(155, 22)
        Me.tb_clientes_ape2.TabIndex = 75
        '
        'lbl_clientes_ape2
        '
        Me.lbl_clientes_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_ape2.AutoSize = True
        Me.lbl_clientes_ape2.Location = New System.Drawing.Point(403, 614)
        Me.lbl_clientes_ape2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_ape2.Name = "lbl_clientes_ape2"
        Me.lbl_clientes_ape2.Size = New System.Drawing.Size(123, 17)
        Me.lbl_clientes_ape2.TabIndex = 74
        Me.lbl_clientes_ape2.Text = "Segundo Apellido:"
        '
        'lbl_proveedores_id
        '
        Me.lbl_proveedores_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_id.AutoSize = True
        Me.lbl_proveedores_id.Location = New System.Drawing.Point(61, 549)
        Me.lbl_proveedores_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_proveedores_id.Name = "lbl_proveedores_id"
        Me.lbl_proveedores_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_proveedores_id.TabIndex = 90
        Me.lbl_proveedores_id.Text = "ID:"
        '
        'lbl_proveedores_nombre
        '
        Me.lbl_proveedores_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_nombre.AutoSize = True
        Me.lbl_proveedores_nombre.Location = New System.Drawing.Point(60, 586)
        Me.lbl_proveedores_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_proveedores_nombre.Name = "lbl_proveedores_nombre"
        Me.lbl_proveedores_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_proveedores_nombre.TabIndex = 89
        Me.lbl_proveedores_nombre.Text = "Nombre:"
        '
        'lbl_proveedores_direccion
        '
        Me.lbl_proveedores_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_direccion.AutoSize = True
        Me.lbl_proveedores_direccion.Location = New System.Drawing.Point(61, 629)
        Me.lbl_proveedores_direccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_proveedores_direccion.Name = "lbl_proveedores_direccion"
        Me.lbl_proveedores_direccion.Size = New System.Drawing.Size(71, 17)
        Me.lbl_proveedores_direccion.TabIndex = 92
        Me.lbl_proveedores_direccion.Text = "Direccion:"
        '
        'lbl_clientes_direccion
        '
        Me.lbl_clientes_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_direccion.Location = New System.Drawing.Point(74, 649)
        Me.lbl_clientes_direccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_clientes_direccion.Name = "lbl_clientes_direccion"
        Me.lbl_clientes_direccion.Size = New System.Drawing.Size(71, 17)
        Me.lbl_clientes_direccion.TabIndex = 94
        Me.lbl_clientes_direccion.Text = "Direccion:"
        '
        'tb_clientes_direccion
        '
        Me.tb_clientes_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_direccion.Location = New System.Drawing.Point(184, 644)
        Me.tb_clientes_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_clientes_direccion.Name = "tb_clientes_direccion"
        Me.tb_clientes_direccion.Size = New System.Drawing.Size(363, 22)
        Me.tb_clientes_direccion.TabIndex = 93
        '
        'gestion_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1009)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.toolstrip)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "gestion_datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de datos maestros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolstrip.ResumeLayout(False)
        Me.toolstrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tab_empleados.ResumeLayout(False)
        Me.tab_empleados.PerformLayout()
        Me.pan_datos_emple.ResumeLayout(False)
        Me.pan_datos_emple.PerformLayout()
        Me.pan_btns_emple.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_emple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_empleados.ResumeLayout(False)
        Me.ts_empleados.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.tab_roles.ResumeLayout(False)
        Me.tab_roles.PerformLayout()
        CType(Me.dg_roles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_categorias.ResumeLayout(False)
        Me.tab_categorias.PerformLayout()
        CType(Me.dg_categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_productos.ResumeLayout(False)
        Me.tab_productos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_clientes.ResumeLayout(False)
        Me.tb_clientes.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_proveedores.ResumeLayout(False)
        Me.tb_proveedores.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstrip As ToolStrip
    Friend WithEvents ts_busqueda As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tss_barraprogreso As ToolStripProgressBar
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ts_volverimg As ToolStripButton
    Friend WithEvents ts_volver As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tab_empleados As TabPage
    Friend WithEvents ts_empleados As ToolStrip
    Friend WithEvents tslbl_nuevo As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tslbl_alta As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tslbl_baja As ToolStripLabel
    Friend WithEvents TabControl As TabControl
    Friend WithEvents ts_info As ToolStripLabel
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ts_cerrar As ToolStripLabel
    Friend WithEvents tss_usuario As ToolStripStatusLabel
    Friend WithEvents tss_fechahora As ToolStripStatusLabel
    Friend WithEvents ts_acerca As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tab_roles As TabPage
    Friend WithEvents tab_categorias As TabPage
    Friend WithEvents dg_roles As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents tb_roles_rol As TextBox
    Friend WithEvents lbl_roles_rol As Label
    Friend WithEvents lbl_roles_id As Label
    Friend WithEvents tb_roles_id As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents dg_categorias As DataGridView
    Friend WithEvents tb_categorias_descripccion As TextBox
    Friend WithEvents tb_categorias_nombre As TextBox
    Friend WithEvents lbl_categoria_descripcion As Label
    Friend WithEvents lbl_categoria_nombre As Label
    Friend WithEvents lbl_categoria_id As Label
    Friend WithEvents tb_categorias_id As TextBox
    Friend WithEvents tab_productos As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dg_productos As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_productos_precio As TextBox
    Friend WithEvents tb_productos_categoriaID As TextBox
    Friend WithEvents tb_productos_stock As TextBox
    Friend WithEvents tb_productos_marca As TextBox
    Friend WithEvents tb_productos_descripccion As TextBox
    Friend WithEvents tb_productos_nombre As TextBox
    Friend WithEvents lbl_productos_marca As Label
    Friend WithEvents lbl_productos_descripccion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents tb_productos_id As TextBox
    Friend WithEvents tb_clientes As TabPage
    Friend WithEvents tb_proveedores As TabPage
    Friend WithEvents dg_emple As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents tb_emple_usu As TextBox
    Friend WithEvents tb_emple_cont As TextBox
    Friend WithEvents tb_emple_nom As TextBox
    Friend WithEvents tb_emple_ape1 As TextBox
    Friend WithEvents tb_emple_correo As TextBox
    Friend WithEvents tb_emple_tlf As TextBox
    Friend WithEvents tb_emple_ape2 As TextBox
    Friend WithEvents tb_emple_rol As TextBox
    Friend WithEvents lbl_empleados_email As Label
    Friend WithEvents lbl_empleados_telefono As Label
    Friend WithEvents lbl_empleados_ape1 As Label
    Friend WithEvents lbl_empleados_ape2 As Label
    Friend WithEvents lbl_empleados_nombre As Label
    Friend WithEvents lbl_empleados_usuario As Label
    Friend WithEvents lbl_empleados_password As Label
    Friend WithEvents lbl_empleados_rol As Label
    Friend WithEvents lbl_empleados_id As Label
    Friend WithEvents tb_emple_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_clientes_empleadoID As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lbl_clientes_telefono As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dg_clientes As DataGridView
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents tb_clientes_ape1 As TextBox
    Friend WithEvents tb_clientes_telefono As TextBox
    Friend WithEvents tb_clientes_empleadoID As TextBox
    Friend WithEvents tb_clientes_nombre As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents tb_clientes_id As TextBox
    Friend WithEvents lbl_proveedores_telefono As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label28 As Label
    Friend WithEvents dg_proveedores As DataGridView
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents tb_proveedores_direccion As TextBox
    Friend WithEvents tb_proveedores_telefono As TextBox
    Friend WithEvents tb_proveedores_contacto As TextBox
    Friend WithEvents tb_proveedores_nombre As TextBox
    Friend WithEvents lbl_proveedores_contacto As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents tb_proveedores_id As TextBox
    Friend WithEvents pan_datos_emple As Panel
    Friend WithEvents pan_btns_emple As Panel
    Friend WithEvents tslbl_modificar As ToolStripLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripLabel10 As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripLabel11 As ToolStripLabel
    Friend WithEvents ToolStripLabel12 As ToolStripLabel
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStripLabel13 As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripLabel14 As ToolStripLabel
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripLabel15 As ToolStripLabel
    Friend WithEvents ToolStripLabel19 As ToolStripLabel
    Friend WithEvents ToolStrip5 As ToolStrip
    Friend WithEvents ToolStripLabel16 As ToolStripLabel
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolStripLabel17 As ToolStripLabel
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents ToolStripLabel18 As ToolStripLabel
    Friend WithEvents ToolStripLabel20 As ToolStripLabel
    Friend WithEvents lbl_productos_precio As Label
    Friend WithEvents lbl_productos_nombre As Label
    Friend WithEvents lbl_productos_id As Label
    Friend WithEvents lbl_producto_stock As Label
    Friend WithEvents lbl_productos_categoria_id As Label
    Friend WithEvents tb_clientes_ape2 As TextBox
    Friend WithEvents lbl_clientes_ape2 As Label
    Friend WithEvents lbl_clientes_ape1 As Label
    Friend WithEvents lbl_clientes_nombre As Label
    Friend WithEvents lbl_clientes_id As Label
    Friend WithEvents lbl_proveedores_direccion As Label
    Friend WithEvents lbl_proveedores_id As Label
    Friend WithEvents lbl_proveedores_nombre As Label
    Friend WithEvents lbl_clientes_direccion As Label
    Friend WithEvents tb_clientes_direccion As TextBox
End Class
