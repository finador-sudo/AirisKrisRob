<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.pan_presentacion = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pan_inicio = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ll_pagoficial = New System.Windows.Forms.LinkLabel()
        Me.ll_acerca = New System.Windows.Forms.LinkLabel()
        Me.cb_cont = New System.Windows.Forms.CheckBox()
        Me.lbl_inf = New System.Windows.Forms.Label()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.pb_ico_usu = New System.Windows.Forms.PictureBox()
        Me.pb_ico_cont = New System.Windows.Forms.PictureBox()
        Me.lbl_entrar = New System.Windows.Forms.Label()
        Me.tb_cont = New System.Windows.Forms.TextBox()
        Me.tb_usu = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.PictureBox()
        Me.pb_cont = New System.Windows.Forms.PictureBox()
        Me.pb_usu = New System.Windows.Forms.PictureBox()
        Me.pan_logo = New System.Windows.Forms.Panel()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pan_presentacion.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_inicio.SuspendLayout()
        CType(Me.pb_ico_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_ico_cont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_entrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_logo.SuspendLayout()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_presentacion
        '
        Me.pan_presentacion.Controls.Add(Me.Label1)
        Me.pan_presentacion.Controls.Add(Me.PictureBox1)
        Me.pan_presentacion.Location = New System.Drawing.Point(1, 1)
        Me.pan_presentacion.Name = "pan_presentacion"
        Me.pan_presentacion.Size = New System.Drawing.Size(467, 628)
        Me.pan_presentacion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 426)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 84)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Presiona cualquier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "botón para entrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(51, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 322)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pan_inicio
        '
        Me.pan_inicio.Controls.Add(Me.ProgressBar1)
        Me.pan_inicio.Controls.Add(Me.ll_pagoficial)
        Me.pan_inicio.Controls.Add(Me.ll_acerca)
        Me.pan_inicio.Controls.Add(Me.cb_cont)
        Me.pan_inicio.Controls.Add(Me.lbl_inf)
        Me.pan_inicio.Controls.Add(Me.lbl_bienvenido)
        Me.pan_inicio.Controls.Add(Me.pb_ico_usu)
        Me.pan_inicio.Controls.Add(Me.pb_ico_cont)
        Me.pan_inicio.Controls.Add(Me.lbl_entrar)
        Me.pan_inicio.Controls.Add(Me.tb_cont)
        Me.pan_inicio.Controls.Add(Me.tb_usu)
        Me.pan_inicio.Controls.Add(Me.btn_entrar)
        Me.pan_inicio.Controls.Add(Me.pb_cont)
        Me.pan_inicio.Controls.Add(Me.pb_usu)
        Me.pan_inicio.Controls.Add(Me.pan_logo)
        Me.pan_inicio.Location = New System.Drawing.Point(1, 1)
        Me.pan_inicio.Name = "pan_inicio"
        Me.pan_inicio.Size = New System.Drawing.Size(467, 628)
        Me.pan_inicio.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(72, 534)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(322, 56)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'll_pagoficial
        '
        Me.ll_pagoficial.AutoSize = True
        Me.ll_pagoficial.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_pagoficial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ll_pagoficial.LinkColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ll_pagoficial.Location = New System.Drawing.Point(177, 534)
        Me.ll_pagoficial.Name = "ll_pagoficial"
        Me.ll_pagoficial.Size = New System.Drawing.Size(110, 23)
        Me.ll_pagoficial.TabIndex = 29
        Me.ll_pagoficial.TabStop = True
        Me.ll_pagoficial.Text = "página oficial"
        '
        'll_acerca
        '
        Me.ll_acerca.AutoSize = True
        Me.ll_acerca.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_acerca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ll_acerca.LinkColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ll_acerca.Location = New System.Drawing.Point(177, 567)
        Me.ll_acerca.Name = "ll_acerca"
        Me.ll_acerca.Size = New System.Drawing.Size(111, 23)
        Me.ll_acerca.TabIndex = 28
        Me.ll_acerca.TabStop = True
        Me.ll_acerca.Text = "ACERCA DE..."
        '
        'cb_cont
        '
        Me.cb_cont.AutoSize = True
        Me.cb_cont.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cb_cont.Location = New System.Drawing.Point(162, 401)
        Me.cb_cont.Name = "cb_cont"
        Me.cb_cont.Size = New System.Drawing.Size(155, 23)
        Me.cb_cont.TabIndex = 27
        Me.cb_cont.Text = "Mostrar contraseña"
        Me.cb_cont.UseVisualStyleBackColor = True
        '
        'lbl_inf
        '
        Me.lbl_inf.AutoSize = True
        Me.lbl_inf.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_inf.Location = New System.Drawing.Point(99, 231)
        Me.lbl_inf.Name = "lbl_inf"
        Me.lbl_inf.Size = New System.Drawing.Size(276, 23)
        Me.lbl_inf.TabIndex = 26
        Me.lbl_inf.Text = "Introduce tu usuario y contraseña:"
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Lucida Calligraphy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(116, 27)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(242, 41)
        Me.lbl_bienvenido.TabIndex = 25
        Me.lbl_bienvenido.Text = "Bienvenido a"
        '
        'pb_ico_usu
        '
        Me.pb_ico_usu.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pb_ico_usu.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.circle_user_7
        Me.pb_ico_usu.Location = New System.Drawing.Point(103, 282)
        Me.pb_ico_usu.Name = "pb_ico_usu"
        Me.pb_ico_usu.Size = New System.Drawing.Size(30, 30)
        Me.pb_ico_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ico_usu.TabIndex = 24
        Me.pb_ico_usu.TabStop = False
        '
        'pb_ico_cont
        '
        Me.pb_ico_cont.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pb_ico_cont.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.lock_7
        Me.pb_ico_cont.Location = New System.Drawing.Point(103, 352)
        Me.pb_ico_cont.Name = "pb_ico_cont"
        Me.pb_ico_cont.Size = New System.Drawing.Size(30, 30)
        Me.pb_ico_cont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ico_cont.TabIndex = 23
        Me.pb_ico_cont.TabStop = False
        '
        'lbl_entrar
        '
        Me.lbl_entrar.AutoSize = True
        Me.lbl_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_entrar.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_entrar.ForeColor = System.Drawing.Color.White
        Me.lbl_entrar.Location = New System.Drawing.Point(179, 450)
        Me.lbl_entrar.Name = "lbl_entrar"
        Me.lbl_entrar.Size = New System.Drawing.Size(123, 39)
        Me.lbl_entrar.TabIndex = 22
        Me.lbl_entrar.Text = "ENTRAR"
        '
        'tb_cont
        '
        Me.tb_cont.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.tb_cont.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cont.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cont.Location = New System.Drawing.Point(150, 351)
        Me.tb_cont.MaxLength = 15
        Me.tb_cont.Name = "tb_cont"
        Me.tb_cont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_cont.Size = New System.Drawing.Size(212, 26)
        Me.tb_cont.TabIndex = 19
        '
        'tb_usu
        '
        Me.tb_usu.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.tb_usu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_usu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usu.Location = New System.Drawing.Point(150, 282)
        Me.tb_usu.MaxLength = 15
        Me.tb_usu.Name = "tb_usu"
        Me.tb_usu.Size = New System.Drawing.Size(209, 26)
        Me.tb_usu.TabIndex = 17
        '
        'btn_entrar
        '
        Me.btn_entrar.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Recurso_2_2x
        Me.btn_entrar.Location = New System.Drawing.Point(108, 441)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(258, 80)
        Me.btn_entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_entrar.TabIndex = 21
        Me.btn_entrar.TabStop = False
        '
        'pb_cont
        '
        Me.pb_cont.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Recurso_4_2x
        Me.pb_cont.Location = New System.Drawing.Point(95, 343)
        Me.pb_cont.Name = "pb_cont"
        Me.pb_cont.Size = New System.Drawing.Size(286, 46)
        Me.pb_cont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cont.TabIndex = 20
        Me.pb_cont.TabStop = False
        '
        'pb_usu
        '
        Me.pb_usu.Image = Global.AirisSolucionKrisRob.My.Resources.Resources.Recurso_4_2x
        Me.pb_usu.Location = New System.Drawing.Point(95, 274)
        Me.pb_usu.Name = "pb_usu"
        Me.pb_usu.Size = New System.Drawing.Size(286, 46)
        Me.pb_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_usu.TabIndex = 18
        Me.pb_usu.TabStop = False
        '
        'pan_logo
        '
        Me.pan_logo.Controls.Add(Me.pb_logo)
        Me.pan_logo.Location = New System.Drawing.Point(69, 59)
        Me.pan_logo.Name = "pan_logo"
        Me.pan_logo.Size = New System.Drawing.Size(329, 155)
        Me.pan_logo.TabIndex = 16
        '
        'pb_logo
        '
        Me.pb_logo.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo1
        Me.pb_logo.Location = New System.Drawing.Point(3, -56)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(322, 299)
        Me.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_logo.TabIndex = 0
        Me.pb_logo.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(468, 629)
        Me.Controls.Add(Me.pan_inicio)
        Me.Controls.Add(Me.pan_presentacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(484, 668)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(484, 668)
        Me.Name = "inicio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airis Managment Application"
        Me.pan_presentacion.ResumeLayout(False)
        Me.pan_presentacion.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_inicio.ResumeLayout(False)
        Me.pan_inicio.PerformLayout()
        CType(Me.pb_ico_usu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_ico_cont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_entrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_usu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_logo.ResumeLayout(False)
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_presentacion As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pan_inicio As Panel
    Friend WithEvents ll_pagoficial As LinkLabel
    Friend WithEvents ll_acerca As LinkLabel
    Friend WithEvents cb_cont As CheckBox
    Friend WithEvents lbl_inf As Label
    Friend WithEvents lbl_bienvenido As Label
    Friend WithEvents pb_ico_usu As PictureBox
    Friend WithEvents pb_ico_cont As PictureBox
    Friend WithEvents lbl_entrar As Label
    Friend WithEvents tb_cont As TextBox
    Friend WithEvents tb_usu As TextBox
    Friend WithEvents btn_entrar As PictureBox
    Friend WithEvents pb_cont As PictureBox
    Friend WithEvents pb_usu As PictureBox
    Friend WithEvents pan_logo As Panel
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
