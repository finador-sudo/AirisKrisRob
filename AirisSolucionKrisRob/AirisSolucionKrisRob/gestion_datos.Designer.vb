﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btn_empleados_alta = New System.Windows.Forms.Button()
        Me.btn_empleados_modificar = New System.Windows.Forms.Button()
        Me.btn_empleados_baja = New System.Windows.Forms.Button()
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
        Me.tslbl_nuevo_empleado = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_empleados = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_empleados = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_empleados = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tab_roles = New System.Windows.Forms.TabPage()
        Me.ts_roles = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_rol = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_roles = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_roles = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_roles = New System.Windows.Forms.ToolStripLabel()
        Me.btn_roles_baja = New System.Windows.Forms.Button()
        Me.btn_roles_alta = New System.Windows.Forms.Button()
        Me.btn_roles_modificar = New System.Windows.Forms.Button()
        Me.dg_roles = New System.Windows.Forms.DataGridView()
        Me.tb_roles_rol = New System.Windows.Forms.TextBox()
        Me.lbl_roles_rol = New System.Windows.Forms.Label()
        Me.lbl_roles_id = New System.Windows.Forms.Label()
        Me.tb_roles_id = New System.Windows.Forms.TextBox()
        Me.tab_categorias = New System.Windows.Forms.TabPage()
        Me.ts_categoria = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_categoria = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_categoria_productos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_categorias_producto = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_categoria_productos = New System.Windows.Forms.ToolStripLabel()
        Me.btn_categorias_baja = New System.Windows.Forms.Button()
        Me.btn_categorias_alta = New System.Windows.Forms.Button()
        Me.btn_categorias_modificar = New System.Windows.Forms.Button()
        Me.dg_categorias = New System.Windows.Forms.DataGridView()
        Me.tb_categorias_descripccion = New System.Windows.Forms.TextBox()
        Me.tb_categorias_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_categoria_descripcion = New System.Windows.Forms.Label()
        Me.lbl_categoria_nombre = New System.Windows.Forms.Label()
        Me.lbl_categoria_id = New System.Windows.Forms.Label()
        Me.tb_categorias_id = New System.Windows.Forms.TextBox()
        Me.tab_productos = New System.Windows.Forms.TabPage()
        Me.lbl_producto_stock = New System.Windows.Forms.Label()
        Me.lbl_productos_categoria_id = New System.Windows.Forms.Label()
        Me.lbl_productos_precio = New System.Windows.Forms.Label()
        Me.lbl_productos_nombre = New System.Windows.Forms.Label()
        Me.lbl_productos_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.btn_productos_baja = New System.Windows.Forms.Button()
        Me.btn_productos_alta = New System.Windows.Forms.Button()
        Me.btn_productos_modificar = New System.Windows.Forms.Button()
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
        Me.ts_productos = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_producto = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_productos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_productos = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_productos = New System.Windows.Forms.ToolStripLabel()
        Me.tb_clientes = New System.Windows.Forms.TabPage()
        Me.lbl_clientes_direccion = New System.Windows.Forms.Label()
        Me.tb_clientes_direccion = New System.Windows.Forms.TextBox()
        Me.tb_clientes_ape2 = New System.Windows.Forms.TextBox()
        Me.lbl_clientes_ape2 = New System.Windows.Forms.Label()
        Me.lbl_clientes_ape1 = New System.Windows.Forms.Label()
        Me.lbl_clientes_nombre = New System.Windows.Forms.Label()
        Me.lbl_clientes_id = New System.Windows.Forms.Label()
        Me.lbl_clientes_empleadoID = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbl_clientes_telefono = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.btn_clientes_baja = New System.Windows.Forms.Button()
        Me.btn_clientes_alta = New System.Windows.Forms.Button()
        Me.btn_clientes_modificar = New System.Windows.Forms.Button()
        Me.tb_clientes_ape1 = New System.Windows.Forms.TextBox()
        Me.tb_clientes_telefono = New System.Windows.Forms.TextBox()
        Me.tb_clientes_empleadoID = New System.Windows.Forms.TextBox()
        Me.tb_clientes_nombre = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tb_clientes_id = New System.Windows.Forms.TextBox()
        Me.ts_clientes = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_clientes = New System.Windows.Forms.ToolStripLabel()
        Me.tb_proveedores = New System.Windows.Forms.TabPage()
        Me.lbl_proveedores_direccion = New System.Windows.Forms.Label()
        Me.lbl_proveedores_id = New System.Windows.Forms.Label()
        Me.lbl_proveedores_nombre = New System.Windows.Forms.Label()
        Me.lbl_proveedores_telefono = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dg_proveedores = New System.Windows.Forms.DataGridView()
        Me.btn_provedores_baja = New System.Windows.Forms.Button()
        Me.btn_provedores_alta = New System.Windows.Forms.Button()
        Me.btn_provedores_modificar = New System.Windows.Forms.Button()
        Me.tb_proveedores_direccion = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_telefono = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_contacto = New System.Windows.Forms.TextBox()
        Me.tb_proveedores_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_proveedores_contacto = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tb_proveedores_id = New System.Windows.Forms.TextBox()
        Me.ts_proveedores = New System.Windows.Forms.ToolStrip()
        Me.tslbl_nuevo_proveedores = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_alta_provedores = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbl_baja_proveedores = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl_modificar_proveedores = New System.Windows.Forms.ToolStripLabel()
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
        Me.ts_roles.SuspendLayout()
        CType(Me.dg_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_categorias.SuspendLayout()
        Me.ts_categoria.SuspendLayout()
        CType(Me.dg_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_productos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_productos.SuspendLayout()
        Me.tb_clientes.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_clientes.SuspendLayout()
        Me.tb_proveedores.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_proveedores.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolstrip
        '
        Me.toolstrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_volverimg, Me.ts_volver, Me.ToolStripSeparator2, Me.ts_busqueda, Me.ToolStripSeparator1, Me.ts_info, Me.ToolStripSeparator13, Me.ts_acerca, Me.ToolStripSeparator5, Me.ts_cerrar})
        Me.toolstrip.Location = New System.Drawing.Point(0, 0)
        Me.toolstrip.Name = "toolstrip"
        Me.toolstrip.Size = New System.Drawing.Size(1443, 27)
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
        Me.ts_volver.Size = New System.Drawing.Size(48, 24)
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
        Me.ts_busqueda.Size = New System.Drawing.Size(151, 24)
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
        Me.ts_info.Size = New System.Drawing.Size(54, 24)
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
        Me.ts_acerca.Size = New System.Drawing.Size(66, 24)
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
        Me.ts_cerrar.Size = New System.Drawing.Size(76, 24)
        Me.ts_cerrar.Text = "Cerrar sesión"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_barraprogreso, Me.tss_usuario, Me.tss_fechahora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 798)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1443, 22)
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
        'tab_empleados
        '
        Me.tab_empleados.Controls.Add(Me.pan_datos_emple)
        Me.tab_empleados.Controls.Add(Me.dg_emple)
        Me.tab_empleados.Controls.Add(Me.ts_empleados)
        Me.tab_empleados.Location = New System.Drawing.Point(23, 4)
        Me.tab_empleados.Name = "tab_empleados"
        Me.tab_empleados.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tab_empleados.Size = New System.Drawing.Size(1416, 763)
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
        Me.pan_datos_emple.Location = New System.Drawing.Point(3, 277)
        Me.pan_datos_emple.Name = "pan_datos_emple"
        Me.pan_datos_emple.Size = New System.Drawing.Size(1410, 483)
        Me.pan_datos_emple.TabIndex = 63
        '
        'pan_btns_emple
        '
        Me.pan_btns_emple.AutoSize = True
        Me.pan_btns_emple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pan_btns_emple.Controls.Add(Me.PictureBox2)
        Me.pan_btns_emple.Controls.Add(Me.btn_empleados_alta)
        Me.pan_btns_emple.Controls.Add(Me.btn_empleados_modificar)
        Me.pan_btns_emple.Controls.Add(Me.btn_empleados_baja)
        Me.pan_btns_emple.Dock = System.Windows.Forms.DockStyle.Right
        Me.pan_btns_emple.Location = New System.Drawing.Point(1118, 0)
        Me.pan_btns_emple.Name = "pan_btns_emple"
        Me.pan_btns_emple.Size = New System.Drawing.Size(292, 483)
        Me.pan_btns_emple.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox2.Location = New System.Drawing.Point(40, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 144)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'btn_empleados_alta
        '
        Me.btn_empleados_alta.Location = New System.Drawing.Point(25, 165)
        Me.btn_empleados_alta.Name = "btn_empleados_alta"
        Me.btn_empleados_alta.Size = New System.Drawing.Size(75, 52)
        Me.btn_empleados_alta.TabIndex = 59
        Me.btn_empleados_alta.Text = "ALTA"
        Me.btn_empleados_alta.UseVisualStyleBackColor = True
        '
        'btn_empleados_modificar
        '
        Me.btn_empleados_modificar.Location = New System.Drawing.Point(214, 165)
        Me.btn_empleados_modificar.Name = "btn_empleados_modificar"
        Me.btn_empleados_modificar.Size = New System.Drawing.Size(75, 52)
        Me.btn_empleados_modificar.TabIndex = 58
        Me.btn_empleados_modificar.Text = "MODIFICAR"
        Me.btn_empleados_modificar.UseVisualStyleBackColor = True
        '
        'btn_empleados_baja
        '
        Me.btn_empleados_baja.Location = New System.Drawing.Point(118, 162)
        Me.btn_empleados_baja.Name = "btn_empleados_baja"
        Me.btn_empleados_baja.Size = New System.Drawing.Size(75, 52)
        Me.btn_empleados_baja.TabIndex = 60
        Me.btn_empleados_baja.Text = "BAJA"
        Me.btn_empleados_baja.UseVisualStyleBackColor = True
        '
        'tb_emple_usu
        '
        Me.tb_emple_usu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_usu.Location = New System.Drawing.Point(141, 97)
        Me.tb_emple_usu.Name = "tb_emple_usu"
        Me.tb_emple_usu.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_usu.TabIndex = 57
        '
        'tb_emple_cont
        '
        Me.tb_emple_cont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_cont.Location = New System.Drawing.Point(141, 130)
        Me.tb_emple_cont.Name = "tb_emple_cont"
        Me.tb_emple_cont.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_cont.TabIndex = 56
        '
        'tb_emple_nom
        '
        Me.tb_emple_nom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_nom.Location = New System.Drawing.Point(141, 161)
        Me.tb_emple_nom.Name = "tb_emple_nom"
        Me.tb_emple_nom.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_nom.TabIndex = 55
        '
        'lbl_empleados_ape1
        '
        Me.lbl_empleados_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_ape1.AutoSize = True
        Me.lbl_empleados_ape1.Location = New System.Drawing.Point(295, 43)
        Me.lbl_empleados_ape1.Name = "lbl_empleados_ape1"
        Me.lbl_empleados_ape1.Size = New System.Drawing.Size(78, 13)
        Me.lbl_empleados_ape1.TabIndex = 47
        Me.lbl_empleados_ape1.Text = "Primer apellido:"
        '
        'tb_emple_rol
        '
        Me.tb_emple_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_rol.Location = New System.Drawing.Point(141, 65)
        Me.tb_emple_rol.Name = "tb_emple_rol"
        Me.tb_emple_rol.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_rol.TabIndex = 50
        '
        'tb_emple_ape1
        '
        Me.tb_emple_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_ape1.Location = New System.Drawing.Point(465, 40)
        Me.tb_emple_ape1.Name = "tb_emple_ape1"
        Me.tb_emple_ape1.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_ape1.TabIndex = 54
        '
        'lbl_empleados_nombre
        '
        Me.lbl_empleados_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_nombre.AutoSize = True
        Me.lbl_empleados_nombre.Location = New System.Drawing.Point(73, 161)
        Me.lbl_empleados_nombre.Name = "lbl_empleados_nombre"
        Me.lbl_empleados_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_empleados_nombre.TabIndex = 45
        Me.lbl_empleados_nombre.Text = "Nombre:"
        '
        'lbl_empleados_ape2
        '
        Me.lbl_empleados_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_ape2.AutoSize = True
        Me.lbl_empleados_ape2.Location = New System.Drawing.Point(285, 78)
        Me.lbl_empleados_ape2.Name = "lbl_empleados_ape2"
        Me.lbl_empleados_ape2.Size = New System.Drawing.Size(92, 13)
        Me.lbl_empleados_ape2.TabIndex = 46
        Me.lbl_empleados_ape2.Text = "Segundo apellido:"
        '
        'lbl_empleados_usuario
        '
        Me.lbl_empleados_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_usuario.AutoSize = True
        Me.lbl_empleados_usuario.Location = New System.Drawing.Point(75, 97)
        Me.lbl_empleados_usuario.Name = "lbl_empleados_usuario"
        Me.lbl_empleados_usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_empleados_usuario.TabIndex = 44
        Me.lbl_empleados_usuario.Text = "Usuario:"
        '
        'tb_emple_correo
        '
        Me.tb_emple_correo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_correo.Location = New System.Drawing.Point(465, 146)
        Me.tb_emple_correo.Name = "tb_emple_correo"
        Me.tb_emple_correo.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_correo.TabIndex = 53
        '
        'lbl_empleados_password
        '
        Me.lbl_empleados_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_password.AutoSize = True
        Me.lbl_empleados_password.Location = New System.Drawing.Point(57, 130)
        Me.lbl_empleados_password.Name = "lbl_empleados_password"
        Me.lbl_empleados_password.Size = New System.Drawing.Size(64, 13)
        Me.lbl_empleados_password.TabIndex = 43
        Me.lbl_empleados_password.Text = "Contraseña:"
        '
        'lbl_empleados_telefono
        '
        Me.lbl_empleados_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_telefono.AutoSize = True
        Me.lbl_empleados_telefono.Location = New System.Drawing.Point(325, 112)
        Me.lbl_empleados_telefono.Name = "lbl_empleados_telefono"
        Me.lbl_empleados_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_empleados_telefono.TabIndex = 48
        Me.lbl_empleados_telefono.Text = "Teléfono:"
        '
        'lbl_empleados_rol
        '
        Me.lbl_empleados_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_rol.AutoSize = True
        Me.lbl_empleados_rol.Location = New System.Drawing.Point(94, 65)
        Me.lbl_empleados_rol.Name = "lbl_empleados_rol"
        Me.lbl_empleados_rol.Size = New System.Drawing.Size(26, 13)
        Me.lbl_empleados_rol.TabIndex = 42
        Me.lbl_empleados_rol.Text = "Rol:"
        '
        'tb_emple_tlf
        '
        Me.tb_emple_tlf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_tlf.Location = New System.Drawing.Point(465, 109)
        Me.tb_emple_tlf.Name = "tb_emple_tlf"
        Me.tb_emple_tlf.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_tlf.TabIndex = 52
        '
        'lbl_empleados_id
        '
        Me.lbl_empleados_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_id.AutoSize = True
        Me.lbl_empleados_id.Location = New System.Drawing.Point(94, 36)
        Me.lbl_empleados_id.Name = "lbl_empleados_id"
        Me.lbl_empleados_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_empleados_id.TabIndex = 41
        Me.lbl_empleados_id.Text = "ID:"
        '
        'lbl_empleados_email
        '
        Me.lbl_empleados_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_empleados_email.AutoSize = True
        Me.lbl_empleados_email.Location = New System.Drawing.Point(281, 149)
        Me.lbl_empleados_email.Name = "lbl_empleados_email"
        Me.lbl_empleados_email.Size = New System.Drawing.Size(96, 13)
        Me.lbl_empleados_email.TabIndex = 49
        Me.lbl_empleados_email.Text = "Correo electrónico:"
        '
        'tb_emple_id
        '
        Me.tb_emple_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_id.Enabled = False
        Me.tb_emple_id.Location = New System.Drawing.Point(141, 36)
        Me.tb_emple_id.Name = "tb_emple_id"
        Me.tb_emple_id.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_id.TabIndex = 40
        '
        'tb_emple_ape2
        '
        Me.tb_emple_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_emple_ape2.Location = New System.Drawing.Point(465, 75)
        Me.tb_emple_ape2.Name = "tb_emple_ape2"
        Me.tb_emple_ape2.Size = New System.Drawing.Size(117, 20)
        Me.tb_emple_ape2.TabIndex = 51
        '
        'dg_emple
        '
        Me.dg_emple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_emple.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_emple.Location = New System.Drawing.Point(3, 28)
        Me.dg_emple.Name = "dg_emple"
        Me.dg_emple.Size = New System.Drawing.Size(1410, 245)
        Me.dg_emple.TabIndex = 62
        '
        'ts_empleados
        '
        Me.ts_empleados.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_empleados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_empleados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_empleado, Me.ToolStripSeparator3, Me.tslbl_alta_empleados, Me.ToolStripSeparator4, Me.tslbl_baja_empleados, Me.tslbl_modificar_empleados})
        Me.ts_empleados.Location = New System.Drawing.Point(3, 3)
        Me.ts_empleados.Name = "ts_empleados"
        Me.ts_empleados.Size = New System.Drawing.Size(1410, 25)
        Me.ts_empleados.TabIndex = 2
        Me.ts_empleados.Text = "ToolStrip2"
        '
        'tslbl_nuevo_empleado
        '
        Me.tslbl_nuevo_empleado.Name = "tslbl_nuevo_empleado"
        Me.tslbl_nuevo_empleado.Size = New System.Drawing.Size(42, 22)
        Me.tslbl_nuevo_empleado.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_empleados
        '
        Me.tslbl_alta_empleados.Name = "tslbl_alta_empleados"
        Me.tslbl_alta_empleados.Size = New System.Drawing.Size(28, 22)
        Me.tslbl_alta_empleados.Text = "Alta"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_empleados
        '
        Me.tslbl_baja_empleados.Name = "tslbl_baja_empleados"
        Me.tslbl_baja_empleados.Size = New System.Drawing.Size(29, 22)
        Me.tslbl_baja_empleados.Text = "Baja"
        '
        'tslbl_modificar_empleados
        '
        Me.tslbl_modificar_empleados.Name = "tslbl_modificar_empleados"
        Me.tslbl_modificar_empleados.Size = New System.Drawing.Size(58, 22)
        Me.tslbl_modificar_empleados.Text = "Modificar"
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
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1443, 771)
        Me.TabControl.TabIndex = 0
        '
        'tab_roles
        '
        Me.tab_roles.Controls.Add(Me.ts_roles)
        Me.tab_roles.Controls.Add(Me.btn_roles_baja)
        Me.tab_roles.Controls.Add(Me.btn_roles_alta)
        Me.tab_roles.Controls.Add(Me.btn_roles_modificar)
        Me.tab_roles.Controls.Add(Me.dg_roles)
        Me.tab_roles.Controls.Add(Me.tb_roles_rol)
        Me.tab_roles.Controls.Add(Me.lbl_roles_rol)
        Me.tab_roles.Controls.Add(Me.lbl_roles_id)
        Me.tab_roles.Controls.Add(Me.tb_roles_id)
        Me.tab_roles.Location = New System.Drawing.Point(23, 4)
        Me.tab_roles.Name = "tab_roles"
        Me.tab_roles.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tab_roles.Size = New System.Drawing.Size(1416, 763)
        Me.tab_roles.TabIndex = 4
        Me.tab_roles.Text = "Roles"
        Me.tab_roles.UseVisualStyleBackColor = True
        '
        'ts_roles
        '
        Me.ts_roles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_roles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_roles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_rol, Me.ToolStripSeparator6, Me.tslbl_alta_roles, Me.ToolStripSeparator7, Me.tslbl_baja_roles, Me.tslbl_modificar_roles})
        Me.ts_roles.Location = New System.Drawing.Point(3, 3)
        Me.ts_roles.Name = "ts_roles"
        Me.ts_roles.Size = New System.Drawing.Size(892, 25)
        Me.ts_roles.TabIndex = 25
        Me.ts_roles.Text = "ToolStrip2"
        '
        'tslbl_nuevo_rol
        '
        Me.tslbl_nuevo_rol.Name = "tslbl_nuevo_rol"
        Me.tslbl_nuevo_rol.Size = New System.Drawing.Size(42, 22)
        Me.tslbl_nuevo_rol.Text = "Nuevo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_roles
        '
        Me.tslbl_alta_roles.Name = "tslbl_alta_roles"
        Me.tslbl_alta_roles.Size = New System.Drawing.Size(28, 22)
        Me.tslbl_alta_roles.Text = "Alta"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_roles
        '
        Me.tslbl_baja_roles.Name = "tslbl_baja_roles"
        Me.tslbl_baja_roles.Size = New System.Drawing.Size(29, 22)
        Me.tslbl_baja_roles.Text = "Baja"
        '
        'tslbl_modificar_roles
        '
        Me.tslbl_modificar_roles.Name = "tslbl_modificar_roles"
        Me.tslbl_modificar_roles.Size = New System.Drawing.Size(58, 22)
        Me.tslbl_modificar_roles.Text = "Modificar"
        '
        'btn_roles_baja
        '
        Me.btn_roles_baja.Location = New System.Drawing.Point(210, 391)
        Me.btn_roles_baja.Name = "btn_roles_baja"
        Me.btn_roles_baja.Size = New System.Drawing.Size(69, 52)
        Me.btn_roles_baja.TabIndex = 24
        Me.btn_roles_baja.Text = "BAJA"
        Me.btn_roles_baja.UseVisualStyleBackColor = True
        '
        'btn_roles_alta
        '
        Me.btn_roles_alta.Location = New System.Drawing.Point(129, 391)
        Me.btn_roles_alta.Name = "btn_roles_alta"
        Me.btn_roles_alta.Size = New System.Drawing.Size(69, 52)
        Me.btn_roles_alta.TabIndex = 23
        Me.btn_roles_alta.Text = "ALTA"
        Me.btn_roles_alta.UseVisualStyleBackColor = True
        '
        'btn_roles_modificar
        '
        Me.btn_roles_modificar.Location = New System.Drawing.Point(286, 391)
        Me.btn_roles_modificar.Name = "btn_roles_modificar"
        Me.btn_roles_modificar.Size = New System.Drawing.Size(69, 52)
        Me.btn_roles_modificar.TabIndex = 22
        Me.btn_roles_modificar.Text = "MODIFICAR"
        Me.btn_roles_modificar.UseVisualStyleBackColor = True
        '
        'dg_roles
        '
        Me.dg_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_roles.Dock = System.Windows.Forms.DockStyle.Right
        Me.dg_roles.Location = New System.Drawing.Point(895, 3)
        Me.dg_roles.Name = "dg_roles"
        Me.dg_roles.Size = New System.Drawing.Size(518, 757)
        Me.dg_roles.TabIndex = 0
        '
        'tb_roles_rol
        '
        Me.tb_roles_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_roles_rol.Location = New System.Drawing.Point(140, 251)
        Me.tb_roles_rol.Name = "tb_roles_rol"
        Me.tb_roles_rol.Size = New System.Drawing.Size(117, 20)
        Me.tb_roles_rol.TabIndex = 14
        '
        'lbl_roles_rol
        '
        Me.lbl_roles_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_roles_rol.AutoSize = True
        Me.lbl_roles_rol.Location = New System.Drawing.Point(113, 254)
        Me.lbl_roles_rol.Name = "lbl_roles_rol"
        Me.lbl_roles_rol.Size = New System.Drawing.Size(26, 13)
        Me.lbl_roles_rol.TabIndex = 13
        Me.lbl_roles_rol.Text = "Rol:"
        '
        'lbl_roles_id
        '
        Me.lbl_roles_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_roles_id.AutoSize = True
        Me.lbl_roles_id.Location = New System.Drawing.Point(118, 224)
        Me.lbl_roles_id.Name = "lbl_roles_id"
        Me.lbl_roles_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_roles_id.TabIndex = 12
        Me.lbl_roles_id.Text = "ID:"
        '
        'tb_roles_id
        '
        Me.tb_roles_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_roles_id.Enabled = False
        Me.tb_roles_id.Location = New System.Drawing.Point(140, 222)
        Me.tb_roles_id.Name = "tb_roles_id"
        Me.tb_roles_id.Size = New System.Drawing.Size(117, 20)
        Me.tb_roles_id.TabIndex = 11
        '
        'tab_categorias
        '
        Me.tab_categorias.Controls.Add(Me.ts_categoria)
        Me.tab_categorias.Controls.Add(Me.btn_categorias_baja)
        Me.tab_categorias.Controls.Add(Me.btn_categorias_alta)
        Me.tab_categorias.Controls.Add(Me.btn_categorias_modificar)
        Me.tab_categorias.Controls.Add(Me.dg_categorias)
        Me.tab_categorias.Controls.Add(Me.tb_categorias_descripccion)
        Me.tab_categorias.Controls.Add(Me.tb_categorias_nombre)
        Me.tab_categorias.Controls.Add(Me.lbl_categoria_descripcion)
        Me.tab_categorias.Controls.Add(Me.lbl_categoria_nombre)
        Me.tab_categorias.Controls.Add(Me.lbl_categoria_id)
        Me.tab_categorias.Controls.Add(Me.tb_categorias_id)
        Me.tab_categorias.Location = New System.Drawing.Point(23, 4)
        Me.tab_categorias.Name = "tab_categorias"
        Me.tab_categorias.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tab_categorias.Size = New System.Drawing.Size(1416, 763)
        Me.tab_categorias.TabIndex = 5
        Me.tab_categorias.Text = "Categorías productos"
        Me.tab_categorias.UseVisualStyleBackColor = True
        '
        'ts_categoria
        '
        Me.ts_categoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_categoria.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_categoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_categoria, Me.ToolStripSeparator8, Me.tslbl_alta_categoria_productos, Me.ToolStripSeparator9, Me.tslbl_baja_categorias_producto, Me.tslbl_modificar_categoria_productos})
        Me.ts_categoria.Location = New System.Drawing.Point(3, 3)
        Me.ts_categoria.Name = "ts_categoria"
        Me.ts_categoria.Size = New System.Drawing.Size(976, 25)
        Me.ts_categoria.TabIndex = 28
        Me.ts_categoria.Text = "ToolStrip2"
        '
        'tslbl_nuevo_categoria
        '
        Me.tslbl_nuevo_categoria.Name = "tslbl_nuevo_categoria"
        Me.tslbl_nuevo_categoria.Size = New System.Drawing.Size(42, 22)
        Me.tslbl_nuevo_categoria.Text = "Nuevo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_categoria_productos
        '
        Me.tslbl_alta_categoria_productos.Name = "tslbl_alta_categoria_productos"
        Me.tslbl_alta_categoria_productos.Size = New System.Drawing.Size(28, 22)
        Me.tslbl_alta_categoria_productos.Text = "Alta"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_categorias_producto
        '
        Me.tslbl_baja_categorias_producto.Name = "tslbl_baja_categorias_producto"
        Me.tslbl_baja_categorias_producto.Size = New System.Drawing.Size(29, 22)
        Me.tslbl_baja_categorias_producto.Text = "Baja"
        '
        'tslbl_modificar_categoria_productos
        '
        Me.tslbl_modificar_categoria_productos.Name = "tslbl_modificar_categoria_productos"
        Me.tslbl_modificar_categoria_productos.Size = New System.Drawing.Size(58, 22)
        Me.tslbl_modificar_categoria_productos.Text = "Modificar"
        '
        'btn_categorias_baja
        '
        Me.btn_categorias_baja.Location = New System.Drawing.Point(362, 410)
        Me.btn_categorias_baja.Name = "btn_categorias_baja"
        Me.btn_categorias_baja.Size = New System.Drawing.Size(75, 52)
        Me.btn_categorias_baja.TabIndex = 27
        Me.btn_categorias_baja.Text = "BAJA"
        Me.btn_categorias_baja.UseVisualStyleBackColor = True
        '
        'btn_categorias_alta
        '
        Me.btn_categorias_alta.Location = New System.Drawing.Point(281, 410)
        Me.btn_categorias_alta.Name = "btn_categorias_alta"
        Me.btn_categorias_alta.Size = New System.Drawing.Size(75, 52)
        Me.btn_categorias_alta.TabIndex = 26
        Me.btn_categorias_alta.Text = "ALTA"
        Me.btn_categorias_alta.UseVisualStyleBackColor = True
        '
        'btn_categorias_modificar
        '
        Me.btn_categorias_modificar.Location = New System.Drawing.Point(443, 410)
        Me.btn_categorias_modificar.Name = "btn_categorias_modificar"
        Me.btn_categorias_modificar.Size = New System.Drawing.Size(75, 52)
        Me.btn_categorias_modificar.TabIndex = 25
        Me.btn_categorias_modificar.Text = "MODIFICAR"
        Me.btn_categorias_modificar.UseVisualStyleBackColor = True
        '
        'dg_categorias
        '
        Me.dg_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_categorias.Dock = System.Windows.Forms.DockStyle.Right
        Me.dg_categorias.Location = New System.Drawing.Point(979, 3)
        Me.dg_categorias.Name = "dg_categorias"
        Me.dg_categorias.Size = New System.Drawing.Size(434, 757)
        Me.dg_categorias.TabIndex = 24
        '
        'tb_categorias_descripccion
        '
        Me.tb_categorias_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_descripccion.Location = New System.Drawing.Point(156, 284)
        Me.tb_categorias_descripccion.Multiline = True
        Me.tb_categorias_descripccion.Name = "tb_categorias_descripccion"
        Me.tb_categorias_descripccion.Size = New System.Drawing.Size(206, 83)
        Me.tb_categorias_descripccion.TabIndex = 23
        '
        'tb_categorias_nombre
        '
        Me.tb_categorias_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_nombre.Location = New System.Drawing.Point(156, 252)
        Me.tb_categorias_nombre.Name = "tb_categorias_nombre"
        Me.tb_categorias_nombre.Size = New System.Drawing.Size(206, 20)
        Me.tb_categorias_nombre.TabIndex = 22
        '
        'lbl_categoria_descripcion
        '
        Me.lbl_categoria_descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_descripcion.AutoSize = True
        Me.lbl_categoria_descripcion.Location = New System.Drawing.Point(91, 287)
        Me.lbl_categoria_descripcion.Name = "lbl_categoria_descripcion"
        Me.lbl_categoria_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_categoria_descripcion.TabIndex = 21
        Me.lbl_categoria_descripcion.Text = "Descripción:"
        '
        'lbl_categoria_nombre
        '
        Me.lbl_categoria_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_nombre.AutoSize = True
        Me.lbl_categoria_nombre.Location = New System.Drawing.Point(34, 254)
        Me.lbl_categoria_nombre.Name = "lbl_categoria_nombre"
        Me.lbl_categoria_nombre.Size = New System.Drawing.Size(122, 13)
        Me.lbl_categoria_nombre.TabIndex = 20
        Me.lbl_categoria_nombre.Text = "Nombre de la categoría:"
        '
        'lbl_categoria_id
        '
        Me.lbl_categoria_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_categoria_id.AutoSize = True
        Me.lbl_categoria_id.Location = New System.Drawing.Point(135, 225)
        Me.lbl_categoria_id.Name = "lbl_categoria_id"
        Me.lbl_categoria_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_categoria_id.TabIndex = 19
        Me.lbl_categoria_id.Text = "ID:"
        '
        'tb_categorias_id
        '
        Me.tb_categorias_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_categorias_id.Enabled = False
        Me.tb_categorias_id.Location = New System.Drawing.Point(156, 223)
        Me.tb_categorias_id.Name = "tb_categorias_id"
        Me.tb_categorias_id.Size = New System.Drawing.Size(93, 20)
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
        Me.tab_productos.Controls.Add(Me.btn_productos_baja)
        Me.tab_productos.Controls.Add(Me.btn_productos_alta)
        Me.tab_productos.Controls.Add(Me.btn_productos_modificar)
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
        Me.tab_productos.Controls.Add(Me.ts_productos)
        Me.tab_productos.Location = New System.Drawing.Point(23, 4)
        Me.tab_productos.Name = "tab_productos"
        Me.tab_productos.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tab_productos.Size = New System.Drawing.Size(1416, 763)
        Me.tab_productos.TabIndex = 6
        Me.tab_productos.Text = "Productos"
        Me.tab_productos.UseVisualStyleBackColor = True
        '
        'lbl_producto_stock
        '
        Me.lbl_producto_stock.AutoSize = True
        Me.lbl_producto_stock.Location = New System.Drawing.Point(73, 541)
        Me.lbl_producto_stock.Name = "lbl_producto_stock"
        Me.lbl_producto_stock.Size = New System.Drawing.Size(38, 13)
        Me.lbl_producto_stock.TabIndex = 52
        Me.lbl_producto_stock.Text = "Stock:"
        '
        'lbl_productos_categoria_id
        '
        Me.lbl_productos_categoria_id.AutoSize = True
        Me.lbl_productos_categoria_id.Location = New System.Drawing.Point(56, 510)
        Me.lbl_productos_categoria_id.Name = "lbl_productos_categoria_id"
        Me.lbl_productos_categoria_id.Size = New System.Drawing.Size(69, 13)
        Me.lbl_productos_categoria_id.TabIndex = 51
        Me.lbl_productos_categoria_id.Text = "Categoria ID:"
        '
        'lbl_productos_precio
        '
        Me.lbl_productos_precio.AutoSize = True
        Me.lbl_productos_precio.Location = New System.Drawing.Point(73, 479)
        Me.lbl_productos_precio.Name = "lbl_productos_precio"
        Me.lbl_productos_precio.Size = New System.Drawing.Size(40, 13)
        Me.lbl_productos_precio.TabIndex = 50
        Me.lbl_productos_precio.Text = "Precio:"
        '
        'lbl_productos_nombre
        '
        Me.lbl_productos_nombre.AutoSize = True
        Me.lbl_productos_nombre.Location = New System.Drawing.Point(73, 450)
        Me.lbl_productos_nombre.Name = "lbl_productos_nombre"
        Me.lbl_productos_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_productos_nombre.TabIndex = 49
        Me.lbl_productos_nombre.Text = "Nombre:"
        '
        'lbl_productos_id
        '
        Me.lbl_productos_id.AutoSize = True
        Me.lbl_productos_id.Location = New System.Drawing.Point(73, 416)
        Me.lbl_productos_id.Name = "lbl_productos_id"
        Me.lbl_productos_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_productos_id.TabIndex = 48
        Me.lbl_productos_id.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-64, 540)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Stock:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(868, 345)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(372, 365)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Label14"
        '
        'dg_productos
        '
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_productos.Location = New System.Drawing.Point(3, 28)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.Size = New System.Drawing.Size(1410, 290)
        Me.dg_productos.TabIndex = 43
        '
        'btn_productos_baja
        '
        Me.btn_productos_baja.Location = New System.Drawing.Point(949, 504)
        Me.btn_productos_baja.Name = "btn_productos_baja"
        Me.btn_productos_baja.Size = New System.Drawing.Size(75, 52)
        Me.btn_productos_baja.TabIndex = 42
        Me.btn_productos_baja.Text = "BAJA"
        Me.btn_productos_baja.UseVisualStyleBackColor = True
        '
        'btn_productos_alta
        '
        Me.btn_productos_alta.Location = New System.Drawing.Point(868, 504)
        Me.btn_productos_alta.Name = "btn_productos_alta"
        Me.btn_productos_alta.Size = New System.Drawing.Size(75, 52)
        Me.btn_productos_alta.TabIndex = 41
        Me.btn_productos_alta.Text = "ALTA"
        Me.btn_productos_alta.UseVisualStyleBackColor = True
        '
        'btn_productos_modificar
        '
        Me.btn_productos_modificar.Location = New System.Drawing.Point(1030, 504)
        Me.btn_productos_modificar.Name = "btn_productos_modificar"
        Me.btn_productos_modificar.Size = New System.Drawing.Size(75, 52)
        Me.btn_productos_modificar.TabIndex = 40
        Me.btn_productos_modificar.Text = "MODIFICAR"
        Me.btn_productos_modificar.UseVisualStyleBackColor = True
        '
        'tb_productos_precio
        '
        Me.tb_productos_precio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_precio.Location = New System.Drawing.Point(130, 474)
        Me.tb_productos_precio.Name = "tb_productos_precio"
        Me.tb_productos_precio.Size = New System.Drawing.Size(117, 20)
        Me.tb_productos_precio.TabIndex = 39
        '
        'tb_productos_categoriaID
        '
        Me.tb_productos_categoriaID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_categoriaID.Location = New System.Drawing.Point(130, 508)
        Me.tb_productos_categoriaID.Name = "tb_productos_categoriaID"
        Me.tb_productos_categoriaID.Size = New System.Drawing.Size(117, 20)
        Me.tb_productos_categoriaID.TabIndex = 38
        '
        'tb_productos_stock
        '
        Me.tb_productos_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_stock.Location = New System.Drawing.Point(130, 539)
        Me.tb_productos_stock.Name = "tb_productos_stock"
        Me.tb_productos_stock.Size = New System.Drawing.Size(117, 20)
        Me.tb_productos_stock.TabIndex = 37
        '
        'tb_productos_marca
        '
        Me.tb_productos_marca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_marca.Location = New System.Drawing.Point(475, 415)
        Me.tb_productos_marca.Name = "tb_productos_marca"
        Me.tb_productos_marca.Size = New System.Drawing.Size(117, 20)
        Me.tb_productos_marca.TabIndex = 36
        '
        'tb_productos_descripccion
        '
        Me.tb_productos_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_descripccion.Location = New System.Drawing.Point(475, 450)
        Me.tb_productos_descripccion.Multiline = True
        Me.tb_productos_descripccion.Name = "tb_productos_descripccion"
        Me.tb_productos_descripccion.Size = New System.Drawing.Size(117, 72)
        Me.tb_productos_descripccion.TabIndex = 33
        '
        'tb_productos_nombre
        '
        Me.tb_productos_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_nombre.Location = New System.Drawing.Point(130, 443)
        Me.tb_productos_nombre.Name = "tb_productos_nombre"
        Me.tb_productos_nombre.Size = New System.Drawing.Size(117, 20)
        Me.tb_productos_nombre.TabIndex = 32
        '
        'lbl_productos_marca
        '
        Me.lbl_productos_marca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_productos_marca.AutoSize = True
        Me.lbl_productos_marca.Location = New System.Drawing.Point(434, 418)
        Me.lbl_productos_marca.Name = "lbl_productos_marca"
        Me.lbl_productos_marca.Size = New System.Drawing.Size(40, 13)
        Me.lbl_productos_marca.TabIndex = 29
        Me.lbl_productos_marca.Text = "Marca:"
        '
        'lbl_productos_descripccion
        '
        Me.lbl_productos_descripccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_productos_descripccion.AutoSize = True
        Me.lbl_productos_descripccion.Location = New System.Drawing.Point(409, 453)
        Me.lbl_productos_descripccion.Name = "lbl_productos_descripccion"
        Me.lbl_productos_descripccion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_productos_descripccion.TabIndex = 28
        Me.lbl_productos_descripccion.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-74, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-83, 509)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Categoría:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-66, 476)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Precio:"
        '
        'lbl_id
        '
        Me.lbl_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(-47, 415)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_id.TabIndex = 23
        Me.lbl_id.Text = "ID:"
        '
        'tb_productos_id
        '
        Me.tb_productos_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_productos_id.Enabled = False
        Me.tb_productos_id.Location = New System.Drawing.Point(130, 414)
        Me.tb_productos_id.Name = "tb_productos_id"
        Me.tb_productos_id.Size = New System.Drawing.Size(117, 20)
        Me.tb_productos_id.TabIndex = 22
        '
        'ts_productos
        '
        Me.ts_productos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_productos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_productos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_producto, Me.ToolStripSeparator10, Me.tslbl_alta_productos, Me.ToolStripSeparator11, Me.tslbl_baja_productos, Me.tslbl_modificar_productos})
        Me.ts_productos.Location = New System.Drawing.Point(3, 3)
        Me.ts_productos.Name = "ts_productos"
        Me.ts_productos.Size = New System.Drawing.Size(1410, 25)
        Me.ts_productos.TabIndex = 47
        Me.ts_productos.Text = "ToolStrip3"
        '
        'tslbl_nuevo_producto
        '
        Me.tslbl_nuevo_producto.Name = "tslbl_nuevo_producto"
        Me.tslbl_nuevo_producto.Size = New System.Drawing.Size(42, 22)
        Me.tslbl_nuevo_producto.Text = "Nuevo"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_alta_productos
        '
        Me.tslbl_alta_productos.Name = "tslbl_alta_productos"
        Me.tslbl_alta_productos.Size = New System.Drawing.Size(28, 22)
        Me.tslbl_alta_productos.Text = "Alta"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'tslbl_baja_productos
        '
        Me.tslbl_baja_productos.Name = "tslbl_baja_productos"
        Me.tslbl_baja_productos.Size = New System.Drawing.Size(29, 22)
        Me.tslbl_baja_productos.Text = "Baja"
        '
        'tslbl_modificar_productos
        '
        Me.tslbl_modificar_productos.Name = "tslbl_modificar_productos"
        Me.tslbl_modificar_productos.Size = New System.Drawing.Size(58, 22)
        Me.tslbl_modificar_productos.Text = "Modificar"
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
        Me.tb_clientes.Controls.Add(Me.btn_clientes_baja)
        Me.tb_clientes.Controls.Add(Me.btn_clientes_alta)
        Me.tb_clientes.Controls.Add(Me.btn_clientes_modificar)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_ape1)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_telefono)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_empleadoID)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_nombre)
        Me.tb_clientes.Controls.Add(Me.Label26)
        Me.tb_clientes.Controls.Add(Me.Label29)
        Me.tb_clientes.Controls.Add(Me.tb_clientes_id)
        Me.tb_clientes.Controls.Add(Me.ts_clientes)
        Me.tb_clientes.Location = New System.Drawing.Point(23, 4)
        Me.tb_clientes.Name = "tb_clientes"
        Me.tb_clientes.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tb_clientes.Size = New System.Drawing.Size(1416, 763)
        Me.tb_clientes.TabIndex = 7
        Me.tb_clientes.Text = "Clientes"
        Me.tb_clientes.UseVisualStyleBackColor = True
        '
        'lbl_clientes_direccion
        '
        Me.lbl_clientes_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_direccion.Location = New System.Drawing.Point(56, 527)
        Me.lbl_clientes_direccion.Name = "lbl_clientes_direccion"
        Me.lbl_clientes_direccion.Size = New System.Drawing.Size(53, 14)
        Me.lbl_clientes_direccion.TabIndex = 94
        Me.lbl_clientes_direccion.Text = "Direccion:"
        '
        'tb_clientes_direccion
        '
        Me.tb_clientes_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_direccion.Location = New System.Drawing.Point(138, 523)
        Me.tb_clientes_direccion.Name = "tb_clientes_direccion"
        Me.tb_clientes_direccion.Size = New System.Drawing.Size(273, 20)
        Me.tb_clientes_direccion.TabIndex = 93
        '
        'tb_clientes_ape2
        '
        Me.tb_clientes_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_ape2.Location = New System.Drawing.Point(399, 499)
        Me.tb_clientes_ape2.Name = "tb_clientes_ape2"
        Me.tb_clientes_ape2.Size = New System.Drawing.Size(117, 20)
        Me.tb_clientes_ape2.TabIndex = 75
        '
        'lbl_clientes_ape2
        '
        Me.lbl_clientes_ape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_ape2.AutoSize = True
        Me.lbl_clientes_ape2.Location = New System.Drawing.Point(302, 499)
        Me.lbl_clientes_ape2.Name = "lbl_clientes_ape2"
        Me.lbl_clientes_ape2.Size = New System.Drawing.Size(93, 13)
        Me.lbl_clientes_ape2.TabIndex = 74
        Me.lbl_clientes_ape2.Text = "Segundo Apellido:"
        '
        'lbl_clientes_ape1
        '
        Me.lbl_clientes_ape1.AutoSize = True
        Me.lbl_clientes_ape1.Location = New System.Drawing.Point(56, 497)
        Me.lbl_clientes_ape1.Name = "lbl_clientes_ape1"
        Me.lbl_clientes_ape1.Size = New System.Drawing.Size(79, 13)
        Me.lbl_clientes_ape1.TabIndex = 73
        Me.lbl_clientes_ape1.Text = "Primer Apellido:"
        '
        'lbl_clientes_nombre
        '
        Me.lbl_clientes_nombre.AutoSize = True
        Me.lbl_clientes_nombre.Location = New System.Drawing.Point(56, 466)
        Me.lbl_clientes_nombre.Name = "lbl_clientes_nombre"
        Me.lbl_clientes_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_clientes_nombre.TabIndex = 72
        Me.lbl_clientes_nombre.Text = "Nombre:"
        '
        'lbl_clientes_id
        '
        Me.lbl_clientes_id.AutoSize = True
        Me.lbl_clientes_id.Location = New System.Drawing.Point(56, 434)
        Me.lbl_clientes_id.Name = "lbl_clientes_id"
        Me.lbl_clientes_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_clientes_id.TabIndex = 71
        Me.lbl_clientes_id.Text = "ID:"
        '
        'lbl_clientes_empleadoID
        '
        Me.lbl_clientes_empleadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_empleadoID.AutoSize = True
        Me.lbl_clientes_empleadoID.Location = New System.Drawing.Point(326, 469)
        Me.lbl_clientes_empleadoID.Name = "lbl_clientes_empleadoID"
        Me.lbl_clientes_empleadoID.Size = New System.Drawing.Size(71, 13)
        Me.lbl_clientes_empleadoID.TabIndex = 69
        Me.lbl_clientes_empleadoID.Text = "Empleado ID:"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(-104, 499)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 13)
        Me.Label31.TabIndex = 68
        Me.Label31.Text = "Primer apellido:"
        '
        'lbl_clientes_telefono
        '
        Me.lbl_clientes_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_clientes_telefono.AutoSize = True
        Me.lbl_clientes_telefono.Location = New System.Drawing.Point(344, 434)
        Me.lbl_clientes_telefono.Name = "lbl_clientes_telefono"
        Me.lbl_clientes_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_clientes_telefono.TabIndex = 67
        Me.lbl_clientes_telefono.Text = "Telefono:"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 388)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Label9"
        '
        'dg_clientes
        '
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_clientes.Location = New System.Drawing.Point(3, 28)
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.Size = New System.Drawing.Size(1410, 290)
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
        'tb_clientes_ape1
        '
        Me.tb_clientes_ape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_ape1.Location = New System.Drawing.Point(138, 493)
        Me.tb_clientes_ape1.Name = "tb_clientes_ape1"
        Me.tb_clientes_ape1.Size = New System.Drawing.Size(117, 20)
        Me.tb_clientes_ape1.TabIndex = 59
        '
        'tb_clientes_telefono
        '
        Me.tb_clientes_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_telefono.Location = New System.Drawing.Point(400, 434)
        Me.tb_clientes_telefono.Name = "tb_clientes_telefono"
        Me.tb_clientes_telefono.Size = New System.Drawing.Size(117, 20)
        Me.tb_clientes_telefono.TabIndex = 58
        '
        'tb_clientes_empleadoID
        '
        Me.tb_clientes_empleadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_empleadoID.Location = New System.Drawing.Point(400, 466)
        Me.tb_clientes_empleadoID.Name = "tb_clientes_empleadoID"
        Me.tb_clientes_empleadoID.Size = New System.Drawing.Size(117, 20)
        Me.tb_clientes_empleadoID.TabIndex = 57
        '
        'tb_clientes_nombre
        '
        Me.tb_clientes_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_nombre.Location = New System.Drawing.Point(138, 463)
        Me.tb_clientes_nombre.Name = "tb_clientes_nombre"
        Me.tb_clientes_nombre.Size = New System.Drawing.Size(117, 20)
        Me.tb_clientes_nombre.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-74, 467)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 13)
        Me.Label26.TabIndex = 51
        Me.Label26.Text = "Nombre:"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(-47, 438)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(21, 13)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "ID:"
        '
        'tb_clientes_id
        '
        Me.tb_clientes_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_clientes_id.Enabled = False
        Me.tb_clientes_id.Location = New System.Drawing.Point(138, 434)
        Me.tb_clientes_id.Name = "tb_clientes_id"
        Me.tb_clientes_id.Size = New System.Drawing.Size(117, 20)
        Me.tb_clientes_id.TabIndex = 47
        '
        'ts_clientes
        '
        Me.ts_clientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_clientes.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_clientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_clientes, Me.ToolStripSeparator12, Me.tslbl_alta_clientes, Me.ToolStripSeparator14, Me.tslbl_baja_clientes, Me.tslbl_modificar_clientes})
        Me.ts_clientes.Location = New System.Drawing.Point(3, 3)
        Me.ts_clientes.Name = "ts_clientes"
        Me.ts_clientes.Size = New System.Drawing.Size(1410, 25)
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
        Me.tb_proveedores.Controls.Add(Me.btn_provedores_baja)
        Me.tb_proveedores.Controls.Add(Me.btn_provedores_alta)
        Me.tb_proveedores.Controls.Add(Me.btn_provedores_modificar)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_direccion)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_telefono)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_contacto)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_nombre)
        Me.tb_proveedores.Controls.Add(Me.lbl_proveedores_contacto)
        Me.tb_proveedores.Controls.Add(Me.Label34)
        Me.tb_proveedores.Controls.Add(Me.Label35)
        Me.tb_proveedores.Controls.Add(Me.tb_proveedores_id)
        Me.tb_proveedores.Controls.Add(Me.ts_proveedores)
        Me.tb_proveedores.Location = New System.Drawing.Point(23, 4)
        Me.tb_proveedores.Name = "tb_proveedores"
        Me.tb_proveedores.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tb_proveedores.Size = New System.Drawing.Size(1416, 763)
        Me.tb_proveedores.TabIndex = 8
        Me.tb_proveedores.Text = "Proveedores"
        Me.tb_proveedores.UseVisualStyleBackColor = True
        '
        'lbl_proveedores_direccion
        '
        Me.lbl_proveedores_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_direccion.AutoSize = True
        Me.lbl_proveedores_direccion.Location = New System.Drawing.Point(46, 511)
        Me.lbl_proveedores_direccion.Name = "lbl_proveedores_direccion"
        Me.lbl_proveedores_direccion.Size = New System.Drawing.Size(55, 13)
        Me.lbl_proveedores_direccion.TabIndex = 92
        Me.lbl_proveedores_direccion.Text = "Direccion:"
        '
        'lbl_proveedores_id
        '
        Me.lbl_proveedores_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_id.AutoSize = True
        Me.lbl_proveedores_id.Location = New System.Drawing.Point(46, 446)
        Me.lbl_proveedores_id.Name = "lbl_proveedores_id"
        Me.lbl_proveedores_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_proveedores_id.TabIndex = 90
        Me.lbl_proveedores_id.Text = "ID:"
        '
        'lbl_proveedores_nombre
        '
        Me.lbl_proveedores_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_nombre.AutoSize = True
        Me.lbl_proveedores_nombre.Location = New System.Drawing.Point(45, 476)
        Me.lbl_proveedores_nombre.Name = "lbl_proveedores_nombre"
        Me.lbl_proveedores_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_proveedores_nombre.TabIndex = 89
        Me.lbl_proveedores_nombre.Text = "Nombre:"
        '
        'lbl_proveedores_telefono
        '
        Me.lbl_proveedores_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_telefono.AutoSize = True
        Me.lbl_proveedores_telefono.Location = New System.Drawing.Point(322, 450)
        Me.lbl_proveedores_telefono.Name = "lbl_proveedores_telefono"
        Me.lbl_proveedores_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_proveedores_telefono.TabIndex = 87
        Me.lbl_proveedores_telefono.Text = "Teléfono:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(-81, 511)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Dirección:"
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
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(372, 400)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 13)
        Me.Label28.TabIndex = 83
        Me.Label28.Text = "Label28"
        '
        'dg_proveedores
        '
        Me.dg_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_proveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.dg_proveedores.Location = New System.Drawing.Point(3, 28)
        Me.dg_proveedores.Name = "dg_proveedores"
        Me.dg_proveedores.Size = New System.Drawing.Size(1410, 290)
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
        Me.tb_proveedores_direccion.Location = New System.Drawing.Point(128, 507)
        Me.tb_proveedores_direccion.Name = "tb_proveedores_direccion"
        Me.tb_proveedores_direccion.Size = New System.Drawing.Size(289, 20)
        Me.tb_proveedores_direccion.TabIndex = 78
        '
        'tb_proveedores_telefono
        '
        Me.tb_proveedores_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_telefono.Location = New System.Drawing.Point(472, 447)
        Me.tb_proveedores_telefono.Name = "tb_proveedores_telefono"
        Me.tb_proveedores_telefono.Size = New System.Drawing.Size(117, 20)
        Me.tb_proveedores_telefono.TabIndex = 76
        '
        'tb_proveedores_contacto
        '
        Me.tb_proveedores_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_contacto.Location = New System.Drawing.Point(472, 477)
        Me.tb_proveedores_contacto.Name = "tb_proveedores_contacto"
        Me.tb_proveedores_contacto.Size = New System.Drawing.Size(117, 20)
        Me.tb_proveedores_contacto.TabIndex = 75
        '
        'tb_proveedores_nombre
        '
        Me.tb_proveedores_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_nombre.Location = New System.Drawing.Point(128, 475)
        Me.tb_proveedores_nombre.Name = "tb_proveedores_nombre"
        Me.tb_proveedores_nombre.Size = New System.Drawing.Size(117, 20)
        Me.tb_proveedores_nombre.TabIndex = 74
        '
        'lbl_proveedores_contacto
        '
        Me.lbl_proveedores_contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedores_contacto.AutoSize = True
        Me.lbl_proveedores_contacto.Location = New System.Drawing.Point(322, 480)
        Me.lbl_proveedores_contacto.Name = "lbl_proveedores_contacto"
        Me.lbl_proveedores_contacto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_proveedores_contacto.TabIndex = 73
        Me.lbl_proveedores_contacto.Text = "Contacto:"
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(-74, 479)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "Nombre:"
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(-47, 450)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 13)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "ID:"
        '
        'tb_proveedores_id
        '
        Me.tb_proveedores_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_proveedores_id.Enabled = False
        Me.tb_proveedores_id.Location = New System.Drawing.Point(128, 446)
        Me.tb_proveedores_id.Name = "tb_proveedores_id"
        Me.tb_proveedores_id.Size = New System.Drawing.Size(117, 20)
        Me.tb_proveedores_id.TabIndex = 70
        '
        'ts_proveedores
        '
        Me.ts_proveedores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_proveedores.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_proveedores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_nuevo_proveedores, Me.ToolStripSeparator15, Me.tslbl_alta_provedores, Me.ToolStripSeparator16, Me.tslbl_baja_proveedores, Me.tslbl_modificar_proveedores})
        Me.ts_proveedores.Location = New System.Drawing.Point(3, 3)
        Me.ts_proveedores.Name = "ts_proveedores"
        Me.ts_proveedores.Size = New System.Drawing.Size(1410, 25)
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
        'gestion_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 820)
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
        Me.ts_roles.ResumeLayout(False)
        Me.ts_roles.PerformLayout()
        CType(Me.dg_roles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_categorias.ResumeLayout(False)
        Me.tab_categorias.PerformLayout()
        Me.ts_categoria.ResumeLayout(False)
        Me.ts_categoria.PerformLayout()
        CType(Me.dg_categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_productos.ResumeLayout(False)
        Me.tab_productos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_productos.ResumeLayout(False)
        Me.ts_productos.PerformLayout()
        Me.tb_clientes.ResumeLayout(False)
        Me.tb_clientes.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_clientes.ResumeLayout(False)
        Me.ts_clientes.PerformLayout()
        Me.tb_proveedores.ResumeLayout(False)
        Me.tb_proveedores.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_proveedores.ResumeLayout(False)
        Me.ts_proveedores.PerformLayout()
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
    Friend WithEvents tslbl_nuevo_empleado As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tslbl_alta_empleados As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tslbl_baja_empleados As ToolStripLabel
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
    Friend WithEvents btn_roles_baja As Button
    Friend WithEvents btn_roles_alta As Button
    Friend WithEvents btn_roles_modificar As Button
    Friend WithEvents tb_roles_rol As TextBox
    Friend WithEvents lbl_roles_rol As Label
    Friend WithEvents lbl_roles_id As Label
    Friend WithEvents tb_roles_id As TextBox
    Friend WithEvents btn_categorias_baja As Button
    Friend WithEvents btn_categorias_alta As Button
    Friend WithEvents btn_categorias_modificar As Button
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
    Friend WithEvents btn_productos_baja As Button
    Friend WithEvents btn_productos_alta As Button
    Friend WithEvents btn_productos_modificar As Button
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
    Friend WithEvents btn_empleados_baja As Button
    Friend WithEvents btn_empleados_alta As Button
    Friend WithEvents btn_empleados_modificar As Button
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
    Friend WithEvents btn_clientes_baja As Button
    Friend WithEvents btn_clientes_alta As Button
    Friend WithEvents btn_clientes_modificar As Button
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
    Friend WithEvents btn_provedores_baja As Button
    Friend WithEvents btn_provedores_alta As Button
    Friend WithEvents btn_provedores_modificar As Button
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
    Friend WithEvents tslbl_modificar_empleados As ToolStripLabel
    Friend WithEvents ts_roles As ToolStrip
    Friend WithEvents tslbl_nuevo_rol As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tslbl_alta_roles As ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tslbl_baja_roles As ToolStripLabel
    Friend WithEvents tslbl_modificar_roles As ToolStripLabel
    Friend WithEvents ts_categoria As ToolStrip
    Friend WithEvents tslbl_nuevo_categoria As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tslbl_alta_categoria_productos As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tslbl_baja_categorias_producto As ToolStripLabel
    Friend WithEvents tslbl_modificar_categoria_productos As ToolStripLabel
    Friend WithEvents ts_productos As ToolStrip
    Friend WithEvents tslbl_nuevo_producto As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tslbl_alta_productos As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tslbl_baja_productos As ToolStripLabel
    Friend WithEvents tslbl_modificar_productos As ToolStripLabel
    Friend WithEvents ts_clientes As ToolStrip
    Friend WithEvents tslbl_nuevo_clientes As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents tslbl_alta_clientes As ToolStripLabel
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents tslbl_baja_clientes As ToolStripLabel
    Friend WithEvents tslbl_modificar_clientes As ToolStripLabel
    Friend WithEvents ts_proveedores As ToolStrip
    Friend WithEvents tslbl_nuevo_proveedores As ToolStripLabel
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents tslbl_alta_provedores As ToolStripLabel
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents tslbl_baja_proveedores As ToolStripLabel
    Friend WithEvents tslbl_modificar_proveedores As ToolStripLabel
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
