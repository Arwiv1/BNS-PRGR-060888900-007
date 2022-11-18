Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmAddPaciente

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        oPaciente.Dni = Trim(txtDNI.Text)
        oPaciente.Estudio = cboEstudios.Text
        oPaciente.Nombre = txtNombrePaciente.Text
        oPaciente.Apellido = txtApellidosPacientes.Text
        oPaciente.NombreAuto = txtNombreAutopercibido.Text
        oPaciente.Sexo = cboSexo.Text
        oPaciente.Genero = cboGenero.Text
        oPaciente.FechaNacimiento = Format(CDate(mskNacimiento.Text), "yyyy-MM-dd")
        oPaciente.Nacionalidad = cboNacionalidadPaciente.Text
        oPaciente.Etnia = cboEtnia.Text
        oPaciente.Religion = cboReligion.Text
        oPaciente.Telefono = mskCodigodearea.Text & " " & txtTelefonoPaciente.Text
        oPaciente.email = txtEmail.Text
        oPaciente.TelefonoEmergencia = mskCodigodeareaEmergencia.Text & " " & txtTelefonoPacienteEmergencia.Text
        oPaciente.Direccion = txtCallePaciente.Text & " " & txtEntrePaciente.Text & " " & txtYPaciente.Text

        oPaciente.Insertar()
        Me.Close()
    End Sub

End Class
