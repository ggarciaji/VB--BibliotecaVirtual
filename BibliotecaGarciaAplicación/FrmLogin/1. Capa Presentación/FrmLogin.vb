Imports System.Data
Imports System.Data.SqlClient

Public Class FrmLogin
    Dim DominioBibliotecario As New Dom_Bibliotecario
    Dim PerBibliotecario As New Per_Bibliotecario
    Dim user, clave As String

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try

            If txtclave.Text = "" Then
                MsgBox("Complete los datos porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
                Return
            End If

            DominioBibliotecario._Nro_Carnet = Convert.ToString(txtuser.Text)
            DominioBibliotecario._Contrasena = Convert.ToString(txtclave.Text)

            If PerBibliotecario.AccederBibliotecario(DominioBibliotecario) Then
                Me.Hide()
                MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje del Sistema")
                FrmPrincipal.Show()
            Else
                MsgBox("Carnet o contraseña incorrecta", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
End Class
