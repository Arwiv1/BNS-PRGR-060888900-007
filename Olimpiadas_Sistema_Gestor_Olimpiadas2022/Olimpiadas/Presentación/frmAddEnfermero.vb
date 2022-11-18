Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmAddEnfermero

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        oEnfermero.Dni = Trim(txtDNI.Text)
        oEnfermero.Idarea = CInt(cboArea.Items(cboArea.SelectedIndex).ItemData)
        oEnfermero.Nombre = Trim(txtNombreEnfermero.Text)
        oEnfermero.Apellido = Trim(txtApellidosEnfermero.Text)
        oEnfermero.CodIdentificacion = Trim(txtCodIdentificacion.Text)
        oEnfermero.Sexo = cboSexo.Text
        oEnfermero.Estudios = cboEstudios.Text
        oEnfermero.FechaNacimiento = Format(CDate(mskNacimiento.Text), "yyyy-MM-dd")
        oEnfermero.Nacionalidad = cboNacionalidadPaciente.Text
        oEnfermero.Telefono = mskCodigodearea.Text & txtTelefonoPaciente.Text
        oEnfermero.TelefonoEmergencia = mskCodigodeareaEmergencia.Text & txtTelefonoPacienteEmergencia.Text
        oEnfermero.Direccion = Trim(txtCalleEnfermero.Text) & Trim(txtEntreEnfermero.Text) & Trim(txtYEnfermero.Text)
        oEnfermero.email = Trim(txtEmail.Text)

        oEnfermero.Insertar()
        Me.Close()
    End Sub

    Private Sub cargarAreas()
        Dim drAreas As MySqlDataReader = oEnfermero.traeAreas()

        cboArea.Items.Clear()

        While drAreas.Read()
            cboArea.Items.Add(New Combo_ItemData(Trim(drAreas("Nombre")), Trim(drAreas("Idareas"))))
        End While

        drAreas.Close()
        drAreas = Nothing
    End Sub

    Private Sub frmAddEnfermero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarAreas()
    End Sub

 
End Class
