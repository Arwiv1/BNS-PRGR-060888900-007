Imports System.IO
Module modMain

    ' -----------------------------
    ' \\ -- Clases
    ' -----------------------------

    Public oDB As cBaseDatos
    Public oPaciente As cPaciente
    Public oEnfermero As cEnfermero

    ' -----------------------------
    ' \\ -- Variables Globales
    ' -----------------------------

    Public gCadenaConexion As String

    Public Sub Main()

        Try

            gCadenaConexion = "server=200.58.125.66;port=3306;uid=agustin;pwd=Agu$2022;database=olimpiadas_tec5;Allow Zero Datetime=True;"
            oDB = New cBaseDatos
            oDB.Conectar()
            oPaciente = New cPaciente
            oEnfermero = New cEnfermero
            Application.EnableVisualStyles()
            Application.Run(frmLogin)
        Catch ex As Exception
            MessageBox.Show("Error al Inicar. " & vbNewLine & "Descripción del Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
