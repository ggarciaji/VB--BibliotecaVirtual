Imports System.Data.SqlClient
Public Class Per_Bibliotecario
    Inherits Per_Conexion
    Public Function AccederBibliotecario(ByVal DomBibliotecario As Dom_Bibliotecario) As Boolean
        Try
            Conectar()
            Dim cmd As New SqlCommand("procedimientosVerificar.spAccederBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@usuario", DomBibliotecario._Nro_Carnet)
                .AddWithValue("@clave", DomBibliotecario._Contrasena)
            End With

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function MostrarBibliotecarios() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("procedimientosListar.spMostrarBibliotecarios", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablabibliotecarios As New DataTable
            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablabibliotecarios)
                Return tablabibliotecarios
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            Desconectar()
        End Try
    End Function


    Public Function AgregarBibliotecario(ByVal DomBibliotecario As Dom_Bibliotecario) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ProcedimientosAgregar.spAgregarBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@BibliotecarioCodigo", DomBibliotecario._CodBibliotecario)
                .AddWithValue("@BibliotecarioNombres", DomBibliotecario._Nombres)
                .AddWithValue("@BibliotecarioApellidos", DomBibliotecario._Apellidos)
                .AddWithValue("@BibliotecarioDireccion", DomBibliotecario._Direccion)
                .AddWithValue("@BibliotecarioEmail", DomBibliotecario._Email)
                .AddWithValue("@BibliotecarioTelefono", DomBibliotecario._Telefono)
                .AddWithValue("@BibliotecarioDni", DomBibliotecario._Dni)
                .AddWithValue("@BibliotecarioUsuarioSistema", DomBibliotecario._Nro_Carnet)
                .AddWithValue("@BibliotecarioClave", DomBibliotecario._Contrasena)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            Desconectar()
        End Try
    End Function

    Public Function ModificarBibliotecario(ByVal DomBibliotecario As Dom_Bibliotecario) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ProcedimientosModificar.spModificarBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@BibliotecarioCodigo", DomBibliotecario._CodBibliotecario)
                .AddWithValue("@BibliotecarioNombres", DomBibliotecario._Nombres)
                .AddWithValue("@BibliotecarioApellidos", DomBibliotecario._Apellidos)
                .AddWithValue("@BibliotecarioDireccion", DomBibliotecario._Direccion)
                .AddWithValue("@BibliotecarioEmail", DomBibliotecario._Email)
                .AddWithValue("@BibliotecarioTelefono", DomBibliotecario._Telefono)
                .AddWithValue("@BibliotecarioDni", DomBibliotecario._Dni)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            Desconectar()
        End Try
    End Function


    Public Function EliminarBibliotecario(ByVal DomBibliotecario As Dom_Bibliotecario) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ProcedimientosEliminar.spEliminarBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@BibliotecarioCodigo", DomBibliotecario._CodBibliotecario)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            Desconectar()
        End Try
    End Function
End Class
