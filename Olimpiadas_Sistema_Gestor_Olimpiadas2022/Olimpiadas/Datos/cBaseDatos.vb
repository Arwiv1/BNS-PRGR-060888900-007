Option Strict On
Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class cBaseDatos

    Public oConn As MySql.Data.MySqlClient.MySqlConnection = Nothing
    Private oComando As MySql.Data.MySqlClient.MySqlCommand = Nothing
    Private oTransaccion As MySql.Data.MySqlClient.MySqlTransaction = Nothing


    Public Function EjecutarConsulta(ByVal sentenciaSQL As String) As MySql.Data.MySqlClient.MySqlDataReader
        Me.Conectar()
        Me.oComando = New MySql.Data.MySqlClient.MySqlCommand
        Me.oComando.Connection = Me.oConn
        Me.oComando.CommandText = sentenciaSQL
        Me.oComando.CommandType = CommandType.Text

        If Not Me.oTransaccion Is Nothing Then
            Me.oComando.Transaction = Me.oTransaccion
        End If
        Return Me.oComando.ExecuteReader()

    End Function

    Public Function EjecutarComando(ByVal comandoSQL As String) As Integer
        Me.Conectar()
        Me.oComando = New MySqlCommand

        Me.oComando.Connection = Me.oConn
        Me.oComando.CommandText = comandoSQL
        Me.oComando.CommandType = Data.CommandType.Text

        If Not Me.oTransaccion Is Nothing Then
            Me.oComando.Transaction = Me.oTransaccion
        End If

        Return Me.oComando.ExecuteNonQuery()
    End Function

    Public Sub ComenzarTransaccion()
        If Me.oTransaccion Is Nothing Then
            Me.oTransaccion = Me.oConn.BeginTransaction()
        End If
    End Sub

    Public Sub CancelarTransaccion()
        If Not Me.oTransaccion Is Nothing Then
            Me.oTransaccion.Rollback()
        End If
    End Sub

    Public Sub ConfirmarTransaccion()
        If Not Me.oTransaccion Is Nothing Then
            Me.oTransaccion.Commit()
        End If
    End Sub

    Public Sub Conectar()

        If Not Me.oTransaccion Is Nothing Then
            If Me.oConn.State = Data.ConnectionState.Open Then
                Throw New BaseDatosException("La conexión ya se encuentra abierta.")
            End If
        End If

        Try

            If Me.oConn Is Nothing Then
                Me.oConn = New MySql.Data.MySqlClient.MySqlConnection
                Me.oComando = New MySql.Data.MySqlClient.MySqlCommand
                Me.oConn.ConnectionString = gCadenaConexion
            End If

            If Me.oConn.State = Data.ConnectionState.Open Then
                Me.oConn.Close()
                Me.oConn.Open()
            Else
                Me.oConn.Open()

            End If

        Catch ex As BaseDatosException
            Throw New BaseDatosException("Error al conectarse.")
        End Try
    End Sub

    Public Sub Desconectar()
        If Me.oConn.State = Data.ConnectionState.Open Then
            Me.oConn.Close()
        End If
    End Sub
    Public Function DataReaderMapToList(Of T)(ByVal dr As MySqlDataReader) As List(Of T)
        Dim list As New List(Of T)
        Dim obj As T
        While dr.Read()
            obj = Activator.CreateInstance(Of T)()
            For Each prop As PropertyInfo In obj.GetType().GetProperties()
                If Not Object.Equals(dr(prop.Name).ToString, DBNull.Value) Then
                    prop.SetValue(obj, dr(prop.Name).ToString, Nothing)
                End If
            Next
            list.Add(obj)
        End While
        Return list
    End Function
End Class

Public Class BaseDatosException
    Inherits ApplicationException

    Public Sub New(ByVal mensaje As String, ByVal original As Exception)
        MyBase.New(mensaje, original)
    End Sub

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
    End Sub
End Class
