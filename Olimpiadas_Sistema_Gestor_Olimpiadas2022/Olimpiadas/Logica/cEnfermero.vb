Imports System.Text
Imports MySql.Data.MySqlClient
Public Class cEnfermero
   

    Private m_idPaciente As String
    Private m_idarea As String
    Private m_Nombre As String
    Private m_Apellido As String
    Private m_Dni As String
    Private m_Codigo_Identificacion As String
    Private m_Nacionalidad As String
    Private m_Direccion As String
    Private m_Sexo As String
    Private m_Telefono As String
    Private m_TelefonoEmergencia As String
    Private m_FechaNacimiento As String
    Private m_email As String
    Private m_Estudios As String

    Public Sub New()
    End Sub
    Public Sub finalize()
        Me.finalize()
    End Sub

    Public Property Idarea() As String
        Get
            Return Me.m_idarea
        End Get
        Set(ByVal value As String)
            Me.m_idarea = value
        End Set
    End Property

    Public Property Nacionalidad() As String
        Get
            Return Me.m_Nacionalidad
        End Get
        Set(ByVal value As String)
            Me.m_Nacionalidad = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Me.m_Telefono
        End Get
        Set(ByVal value As String)
            Me.m_Telefono = value
        End Set
    End Property

    Public Property TelefonoEmergencia() As String
        Get
            Return Me.m_TelefonoEmergencia
        End Get
        Set(ByVal value As String)
            Me.m_TelefonoEmergencia = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me.m_Nombre
        End Get
        Set(ByVal value As String)
            Me.m_Nombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return Me.m_Apellido
        End Get
        Set(ByVal value As String)
            Me.m_Apellido = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Me.m_Direccion
        End Get
        Set(ByVal value As String)
            Me.m_Direccion = value
        End Set
    End Property

    Public Property Estudios() As String
        Get
            Return Me.m_Estudios
        End Get
        Set(ByVal value As String)
            Me.m_Estudios = value
        End Set
    End Property

    Public Property Dni() As String
        Get
            Return Me.m_Dni
        End Get
        Set(ByVal value As String)
            Me.m_Dni = value
        End Set
    End Property

    Public Property FechaNacimiento() As String
        Get
            Return Me.m_FechaNacimiento
        End Get
        Set(ByVal value As String)
            Me.m_FechaNacimiento = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return Me.m_Sexo
        End Get
        Set(ByVal value As String)
            Me.m_Sexo = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return Me.m_email
        End Get
        Set(ByVal value As String)
            Me.m_email = value
        End Set
    End Property

    Public Function Insertar() As Boolean
        Dim F_SQL As New StringBuilder
        Dim F_Resultado As Boolean = False

        F_SQL.Append("INSERT INTO Enfermero ")
        F_SQL.Append("(Idarea")
        F_SQL.Append("Nombre")
        F_SQL.Append(",Apellido")
        F_SQL.Append(",DNI")
        F_SQL.Append(",Codigo_Identificacion")
        F_SQL.Append(",Sexo")
        F_SQL.Append(",Telefono")
        F_SQL.Append(",Fecha_nacimiento")
        F_SQL.Append(",Correo_electronico")
        F_SQL.Append(",Estudios)")
        F_SQL.Append(" VALUES ")
        F_SQL.Append("('" & Me.m_idarea & "'")
        F_SQL.Append(",'" & Me.m_Nombre & "'")
        F_SQL.Append(",'" & Me.m_Apellido & "'")
        F_SQL.Append(",'" & Me.m_Dni & "'")
        F_SQL.Append(",'" & Me.m_Codigo_Identificacion & "'")
        F_SQL.Append(",'" & Me.m_Sexo & "'")
        F_SQL.Append(",'" & Me.m_Telefono & "'")
        F_SQL.Append(",'" & Me.m_FechaNacimiento & "'")
        F_SQL.Append(",'" & Me.m_email & "'")
        F_SQL.Append(",'" & Me.m_Estudios & "')")

        Call oDB.EjecutarComando(F_SQL.ToString)
        F_Resultado = True
        Return F_Resultado
    End Function

    Public Function EliminarAlumno(ByVal unIdAlumno As String) As Boolean
        Dim vResultado As Boolean = False
        Dim vSQL As New StringBuilder
        vSQL.Append("DELETE FROM Direccion WHERE idDireccion=(select idDireccion from Alumno where idAlumno='" & unIdAlumno & "');")
        vSQL.Append("DELETE FROM Telefono WHERE idTelefono=(select idTelefono from Alumno where idAlumno='" & unIdAlumno & "');") 'Planilla'
        vSQL.Append("DELETE FROM Tutor WHERE idAlumno='" & unIdAlumno & "';")
        vSQL.Append("DELETE FROM Alumno WHERE idAlumno='" & unIdAlumno & "';")

        Call oDB.EjecutarComando(vSQL.ToString)
        vResultado = True


        Return vResultado
    End Function

    Public Function TraerEnfermero() As MySqlDataReader
        Dim vSQL As New StringBuilder
        Dim cursoLista As String = ""
        vSQL.Append("SELECT E.Idenfermeros,A.Nombre as 'Area',Concat(E.Nombre,E.Apellido) AS 'Nombre',E.DNI,E.Codigo_Identificacion,E.Sexo,E.Telefono,E.Fecha_nacimiento,E.Correo_electronico,E.Estudios from Enfermero E inner join Area A ON (E.Idenfermeros=A.Idareas)")
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
