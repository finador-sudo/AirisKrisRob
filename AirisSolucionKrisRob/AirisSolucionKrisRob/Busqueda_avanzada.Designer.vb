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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pan_emple = New System.Windows.Forms.Panel()
        Me.tb_id_emple = New System.Windows.Forms.TextBox()
        Me.tb_nom_emple = New System.Windows.Forms.TextBox()
        Me.tb_ape1_emple = New System.Windows.Forms.TextBox()
        Me.tb_ape2_emple = New System.Windows.Forms.TextBox()
        Me.tb_telef_emple = New System.Windows.Forms.TextBox()
        Me.tb_rolid_emple = New System.Windows.Forms.TextBox()
        Me.tb_correo_emple = New System.Windows.Forms.TextBox()
        Me.pan_categorias = New System.Windows.Forms.Panel()
        Me.tb_id_cat = New System.Windows.Forms.TextBox()
        Me.tb_nom_cat = New System.Windows.Forms.TextBox()
        Me.tb_desc_cat = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        CType(Me.dg_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_emple.SuspendLayout()
        Me.pan_categorias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_tablas
        '
        Me.cb_tablas.FormattingEnabled = True
        Me.cb_tablas.Location = New System.Drawing.Point(191, 68)
        Me.cb_tablas.Name = "cb_tablas"
        Me.cb_tablas.Size = New System.Drawing.Size(196, 21)
        Me.cb_tablas.TabIndex = 0
        '
        'lbl_tabla
        '
        Me.lbl_tabla.AutoSize = True
        Me.lbl_tabla.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabla.Location = New System.Drawing.Point(134, 65)
        Me.lbl_tabla.Name = "lbl_tabla"
        Me.lbl_tabla.Size = New System.Drawing.Size(45, 20)
        Me.lbl_tabla.TabIndex = 1
        Me.lbl_tabla.Text = "Tabla:"
        '
        'dg_busqueda
        '
        Me.dg_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_busqueda.Location = New System.Drawing.Point(88, 312)
        Me.dg_busqueda.Name = "dg_busqueda"
        Me.dg_busqueda.Size = New System.Drawing.Size(383, 179)
        Me.dg_busqueda.TabIndex = 2
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(236, 516)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 36)
        Me.btn_cerrar.TabIndex = 3
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(236, 268)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rol (ID):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Segundo apellido:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Primer apellido:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nombre:"
        '
        'pan_emple
        '
        Me.pan_emple.Controls.Add(Me.tb_correo_emple)
        Me.pan_emple.Controls.Add(Me.tb_rolid_emple)
        Me.pan_emple.Controls.Add(Me.tb_telef_emple)
        Me.pan_emple.Controls.Add(Me.tb_ape2_emple)
        Me.pan_emple.Controls.Add(Me.tb_ape1_emple)
        Me.pan_emple.Controls.Add(Me.tb_nom_emple)
        Me.pan_emple.Controls.Add(Me.tb_id_emple)
        Me.pan_emple.Controls.Add(Me.Label1)
        Me.pan_emple.Controls.Add(Me.Label3)
        Me.pan_emple.Controls.Add(Me.Label4)
        Me.pan_emple.Controls.Add(Me.Label5)
        Me.pan_emple.Controls.Add(Me.Label6)
        Me.pan_emple.Controls.Add(Me.Label9)
        Me.pan_emple.Controls.Add(Me.Label7)
        Me.pan_emple.Controls.Add(Me.Label8)
        Me.pan_emple.Location = New System.Drawing.Point(38, 107)
        Me.pan_emple.Name = "pan_emple"
        Me.pan_emple.Size = New System.Drawing.Size(453, 155)
        Me.pan_emple.TabIndex = 14
        '
        'tb_id_emple
        '
        Me.tb_id_emple.Location = New System.Drawing.Point(139, 18)
        Me.tb_id_emple.Name = "tb_id_emple"
        Me.tb_id_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_id_emple.TabIndex = 14
        '
        'tb_nom_emple
        '
        Me.tb_nom_emple.Location = New System.Drawing.Point(139, 48)
        Me.tb_nom_emple.Name = "tb_nom_emple"
        Me.tb_nom_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_nom_emple.TabIndex = 15
        '
        'tb_ape1_emple
        '
        Me.tb_ape1_emple.Location = New System.Drawing.Point(139, 78)
        Me.tb_ape1_emple.Name = "tb_ape1_emple"
        Me.tb_ape1_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_ape1_emple.TabIndex = 16
        '
        'tb_ape2_emple
        '
        Me.tb_ape2_emple.Location = New System.Drawing.Point(139, 109)
        Me.tb_ape2_emple.Name = "tb_ape2_emple"
        Me.tb_ape2_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_ape2_emple.TabIndex = 17
        '
        'tb_telef_emple
        '
        Me.tb_telef_emple.Location = New System.Drawing.Point(327, 48)
        Me.tb_telef_emple.Name = "tb_telef_emple"
        Me.tb_telef_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_telef_emple.TabIndex = 18
        '
        'tb_rolid_emple
        '
        Me.tb_rolid_emple.Location = New System.Drawing.Point(327, 18)
        Me.tb_rolid_emple.Name = "tb_rolid_emple"
        Me.tb_rolid_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_rolid_emple.TabIndex = 19
        '
        'tb_correo_emple
        '
        Me.tb_correo_emple.Location = New System.Drawing.Point(327, 78)
        Me.tb_correo_emple.Name = "tb_correo_emple"
        Me.tb_correo_emple.Size = New System.Drawing.Size(91, 20)
        Me.tb_correo_emple.TabIndex = 20
        '
        'pan_categorias
        '
        Me.pan_categorias.Controls.Add(Me.Label11)
        Me.pan_categorias.Controls.Add(Me.lbl_nom)
        Me.pan_categorias.Controls.Add(Me.lbl_id)
        Me.pan_categorias.Controls.Add(Me.tb_desc_cat)
        Me.pan_categorias.Controls.Add(Me.tb_nom_cat)
        Me.pan_categorias.Controls.Add(Me.tb_id_cat)
        Me.pan_categorias.Location = New System.Drawing.Point(38, 107)
        Me.pan_categorias.Name = "pan_categorias"
        Me.pan_categorias.Size = New System.Drawing.Size(453, 155)
        Me.pan_categorias.TabIndex = 15
        '
        'tb_id_cat
        '
        Me.tb_id_cat.Location = New System.Drawing.Point(234, 27)
        Me.tb_id_cat.Name = "tb_id_cat"
        Me.tb_id_cat.Size = New System.Drawing.Size(100, 20)
        Me.tb_id_cat.TabIndex = 0
        '
        'tb_nom_cat
        '
        Me.tb_nom_cat.Location = New System.Drawing.Point(234, 65)
        Me.tb_nom_cat.Name = "tb_nom_cat"
        Me.tb_nom_cat.Size = New System.Drawing.Size(100, 20)
        Me.tb_nom_cat.TabIndex = 1
        '
        'tb_desc_cat
        '
        Me.tb_desc_cat.Location = New System.Drawing.Point(234, 103)
        Me.tb_desc_cat.Name = "tb_desc_cat"
        Me.tb_desc_cat.Size = New System.Drawing.Size(100, 20)
        Me.tb_desc_cat.TabIndex = 2
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(174, 29)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 15)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "ID:"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(86, 67)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(133, 15)
        Me.lbl_nom.TabIndex = 4
        Me.lbl_nom.Text = "Nombre de la categoría:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(134, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Descripción:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(38, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 155)
        Me.Panel1.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(282, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(282, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(120, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(282, 111)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(120, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(100, 105)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Busqueda_avanzada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pan_categorias)
        Me.Controls.Add(Me.pan_emple)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dg_busqueda)
        Me.Controls.Add(Me.lbl_tabla)
        Me.Controls.Add(Me.cb_tablas)
        Me.Name = "Busqueda_avanzada"
        Me.Text = "Busqueda_avanzada"
        CType(Me.dg_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_emple.ResumeLayout(False)
        Me.pan_emple.PerformLayout()
        Me.pan_categorias.ResumeLayout(False)
        Me.pan_categorias.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_tablas As ComboBox
    Friend WithEvents lbl_tabla As Label
    Friend WithEvents dg_busqueda As DataGridView
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pan_emple As Panel
    Friend WithEvents tb_correo_emple As TextBox
    Friend WithEvents tb_rolid_emple As TextBox
    Friend WithEvents tb_telef_emple As TextBox
    Friend WithEvents tb_ape2_emple As TextBox
    Friend WithEvents tb_ape1_emple As TextBox
    Friend WithEvents tb_nom_emple As TextBox
    Friend WithEvents tb_id_emple As TextBox
    Friend WithEvents pan_categorias As Panel
    Friend WithEvents tb_desc_cat As TextBox
    Friend WithEvents tb_nom_cat As TextBox
    Friend WithEvents tb_id_cat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
