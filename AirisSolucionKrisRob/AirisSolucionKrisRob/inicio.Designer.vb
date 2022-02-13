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
        Me.pan_presentacion = New System.Windows.Forms.Panel()
        Me.pan_inicio = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_cont = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_pulsar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.pan_presentacion.SuspendLayout()
        Me.pan_inicio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_presentacion
        '
        Me.pan_presentacion.Controls.Add(Me.pan_inicio)
        Me.pan_presentacion.Controls.Add(Me.lbl_pulsar)
        Me.pan_presentacion.Controls.Add(Me.PictureBox1)
        Me.pan_presentacion.Controls.Add(Me.Label1)
        Me.pan_presentacion.Location = New System.Drawing.Point(1, 1)
        Me.pan_presentacion.Name = "pan_presentacion"
        Me.pan_presentacion.Size = New System.Drawing.Size(647, 405)
        Me.pan_presentacion.TabIndex = 0
        '
        'pan_inicio
        '
        Me.pan_inicio.Controls.Add(Me.LinkLabel2)
        Me.pan_inicio.Controls.Add(Me.LinkLabel1)
        Me.pan_inicio.Controls.Add(Me.PictureBox2)
        Me.pan_inicio.Controls.Add(Me.btn_entrar)
        Me.pan_inicio.Controls.Add(Me.TextBox2)
        Me.pan_inicio.Controls.Add(Me.TextBox1)
        Me.pan_inicio.Controls.Add(Me.lbl_cont)
        Me.pan_inicio.Controls.Add(Me.lbl_usuario)
        Me.pan_inicio.Location = New System.Drawing.Point(132, 48)
        Me.pan_inicio.Name = "pan_inicio"
        Me.pan_inicio.Size = New System.Drawing.Size(371, 311)
        Me.pan_inicio.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo
        Me.PictureBox2.Location = New System.Drawing.Point(169, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btn_entrar
        '
        Me.btn_entrar.Location = New System.Drawing.Point(197, 185)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(186, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 119)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'lbl_cont
        '
        Me.lbl_cont.AutoSize = True
        Me.lbl_cont.Location = New System.Drawing.Point(95, 151)
        Me.lbl_cont.Name = "lbl_cont"
        Me.lbl_cont.Size = New System.Drawing.Size(64, 13)
        Me.lbl_cont.TabIndex = 1
        Me.lbl_cont.Text = "Contraseña:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(113, 122)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_pulsar
        '
        Me.lbl_pulsar.AutoSize = True
        Me.lbl_pulsar.Location = New System.Drawing.Point(215, 303)
        Me.lbl_pulsar.Name = "lbl_pulsar"
        Me.lbl_pulsar.Size = New System.Drawing.Size(182, 13)
        Me.lbl_pulsar.TabIndex = 2
        Me.lbl_pulsar.Text = "Pulsar cualquier tecla para continuar:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirisSolucionKrisRob.My.Resources.Resources._1975_airis_logo
        Me.PictureBox1.Location = New System.Drawing.Point(149, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRESENTACION DE LA EMPRESA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(157, 268)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ACERCA DE..."
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(157, 285)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(70, 13)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Página oficial"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 752)
        Me.Controls.Add(Me.pan_presentacion)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "inicio"
        Me.Text = "Airis Managment Application"
        Me.pan_presentacion.ResumeLayout(False)
        Me.pan_presentacion.PerformLayout()
        Me.pan_inicio.ResumeLayout(False)
        Me.pan_inicio.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pan_presentacion As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pan_inicio As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_cont As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_pulsar As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
