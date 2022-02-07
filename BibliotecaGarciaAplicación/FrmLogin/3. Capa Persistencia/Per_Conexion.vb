Imports System.Data.SqlClient
Imports System.Configuration
Public Class Per_Conexion
    Public con As New SqlConnection(ModuloBiblioteca.cCadena)
    Public Sub Conectar()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
