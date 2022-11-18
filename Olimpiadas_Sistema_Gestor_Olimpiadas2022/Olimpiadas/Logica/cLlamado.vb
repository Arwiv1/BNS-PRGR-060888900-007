Imports System.Text
Imports MySql.Data.MySqlClient
Public Class cLlamado
    Public Sub New()
    End Sub
    Public Sub finalize()
        Me.finalize()
    End Sub

    Public Function TraerLlamadas() As MySqlDataReader
        Dim vSQL As New StringBuilder
        Dim cursoLista As String = ""
        vSQL.Append("select idLlamado,Emergencia,Atendido,Fecha,Ubicacion,Idhabitacion,Inicio_llamado,Fin_llamado from Llamado")
        Return oDB.EjecutarConsulta(vSQL.ToString)
    End Function

    Public Function Actualizar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("UPDATE Alumno SET")

        'vSQL.Append(" Nombre='" & Me.m_Nombre & "',")
        'vSQL.Append(" Apellido='" & Me.m_Apellido & "',")
        'vSQL.Append(" idTipoDocumento='" & Me.m_TipoDocumento & "',")
        'vSQL.Append(" idDireccion='" & Me.m_Direccion & "',")
        'vSQL.Append(" idTurno='" & Me.m_Turno & "',")
        'vSQL.Append(" Lugar_Nacimiento='" & Me.m_LugarNacimiento & "',")
        'vSQL.Append(" Fecha_Nacimiento=date('" & Me.m_FechaNacimiento & "'),")
        'vSQL.Append(" Numero_Documento='" & Me.m_Documento & "',")
        'vSQL.Append(" CUIL='" & Me.m_CUIL & "',")
        'vSQL.Append(" idNacionalidad='" & Me.m_Nacionalidad & "',")
        'vSQL.Append(" Escuela_Procedencia='" & Me.m_EscuelaProcedencia & "',")
        'vSQL.Append(" sexo='" & Me.m_Sexo & "',")
        'vSQL.Append(" Legajo='" & Me.m_Legajo & "',")
        'vSQL.Append(" idEspecialidad='" & Me.m_Especialidad & "',")
        'vSQL.Append(" Condicion='" & Me.m_Condicion & "',")
        'vSQL.Append(" email='" & Me.m_email & "',")
        'vSQL.Append(" email_institucional='" & Me.m_emailInstitucional & "',")
        'vSQL.Append(" Anio_Inscripcion='" & Me.m_AnioInscripcion & "',")
        'vSQL.Append(" Legajo_Libro='" & Me.m_libro & "',")
        'vSQL.Append(" Legajo_Folio='" & Me.m_folio & "'")
        'vSQL.Append(" WHERE idAlumno='" & Me.m_idAlumno & "'")

        Call oDB.EjecutarComando(vSQL.ToString)
        vResultado = True
        Return vResultado
    End Function


End Class
