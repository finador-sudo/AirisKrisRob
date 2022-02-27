Imports System.Data.OleDb

Public Class inicio

    ' Dim conexionInicio As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=airis_db.accdb")
    Dim conexionInicio As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=airis_db.accdb")

    Dim adaptadorUsuarios As New OleDbDataAdapter("select * from empleados", conexionInicio)
    Dim dataset_usuarios As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan_inicio.Hide()
    End Sub

    Private Sub pan_presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, pan_presentacion.KeyPress
        pan_inicio.Show()
    End Sub

    Private Sub pan_presentacion_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, pan_presentacion.MouseClick
        pan_inicio.Show()
    End Sub

    Private Sub ll_pagoficial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_pagoficial.LinkClicked
        Process.Start("chrome.exe", "www.AIRIS.es")

    End Sub

    Private Sub cb_cont_CheckedChanged(sender As Object, e As EventArgs) Handles cb_cont.CheckedChanged
        If cb_cont.Checked Then
            tb_cont.PasswordChar = ""
        Else
            tb_cont.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click, lbl_entrar.Click
        Dim usu As String = tb_usu.Text
        Dim pass As String = tb_cont.Text

        adaptadorUsuarios.Fill(dataset_usuarios, "Tabla_empleados")

        Dim pos As Integer = 0
        Dim m As Integer

        Try
            conexionInicio.Open()
            Dim comando As New OleDbCommand("Select * from empleados Where cont is not Null", conexionInicio)
            Dim reader As OleDbDataReader = comando.ExecuteReader

            While reader.Read
                If reader.Item("usuario") = usu And reader.Item("cont") = pass Then
                    m = 1
                Else
                    pos += 1
                End If
            End While

            If m = 1 Then
                NotifyIcon1.BalloonTipTitle = "Sesion iniciada"
                NotifyIcon1.BalloonTipText = "Sesion iniciada con usuario " + usu
                NotifyIcon1.ShowBalloonTip(2)

                'Guardamos en el fichero el acceso
                FileOpen(1, "AccesosUsuariosAiris.txt", OpenMode.Append)
                WriteLine(1, "Acceso por parte de " + usu + ", con clave: " + pass + ", fecha: " + DateString + "; hora:" + TimeString)

                FileClose()
                ll_acerca.Visible = False
                ll_pagoficial.Visible = False
                'progressBarAction()
                logedUser = usu
                Me.Hide()
                gestion_datos.Close()
                gestion_datos.Show()

            Else
                NotifyIcon1.BalloonTipTitle = "Sesion fallida"
                NotifyIcon1.BalloonTipText = "Sesion fallida con el usuario  " + usu
                NotifyIcon1.ShowBalloonTip(2)

                'Guardamos en el fichero el intento fallido de acceso del usuario
                FileOpen(1, "AccesosUsuariosAiris.txt", OpenMode.Append)
                WriteLine(1, "Acceso denegado para " + usu + ", fecha: " + DateString + "; hora:" + TimeString)
                FileClose()

                MsgBox("Usuario o la contraseña es incorrecto.", MsgBoxStyle.Information, "Error de acceso")
            End If
            conexionInicio.Close()
            tb_cont.Text = ""
            tb_usu.Text = ""

        Catch ex As Exception
            MsgBox(ex.StackTrace, MsgBoxStyle.Critical, "Error critico en la base de datos")
            FileOpen(2, "errores_airis.txt", OpenMode.Append)
            WriteLine(2, " " + ex.StackTrace + ", fecha: " + DateString + "; hora:" + TimeString)
            FileClose(2)
        Finally
            conexionInicio.Close
        End Try

    End Sub

    Private Sub progressBarAction()
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000000

        For i As Integer = 1 To 1000000


            ProgressBar1.Increment(1)

        Next

        ProgressBar1.Visible = False

    End Sub

    Private Sub ll_acerca_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_acerca.LinkClicked
        Help.ShowHelp(ll_acerca, "Airis.chm")
    End Sub

    Private Sub tb_usu_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_usu.KeyDown, tb_cont.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_entrar_Click(New Object, New EventArgs)
        End If
    End Sub
End Class
