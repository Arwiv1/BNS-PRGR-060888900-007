Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmAddEnfermero

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        oEnfermero.Dni = Trim(txtDNI.Text)
        oEnfermero.Idarea = cboArea.SelectedText
        oEnfermero.Nombre = Trim(txtNombreEnfermero.Text)
        oEnfermero.Apellido = Trim(txtApellidosEnfermero.Text)
        oEnfermero.Sexo = cboSexo.Text
        oEnfermero.Estudios = cboEstudios.Text
        oEnfermero.FechaNacimiento = Format(CDate(mskNacimiento.Text), "yyyy-MM-dd")
        oEnfermero.Nacionalidad = cboNacionalidadPaciente.Text
        oEnfermero.Telefono = mskCodigodearea.Text & txtTelefonoPaciente.Text
        oEnfermero.TelefonoEmergencia = mskCodigodeareaEmergencia.Text & txtTelefonoPacienteEmergencia.Text
        oEnfermero.Direccion = Trim(txtCalleEnfermero.Text) & Trim(txtEntreEnfermero.Text) & Trim(txtYEnfermero.Text)


        oEnfermero.Insertar()
        Me.Close()
    End Sub

End Class
