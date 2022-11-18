Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmPacientes
    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub ConfigurarGrilla()
        With lvPacientes
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .HotTracking = False
            .HoverSelection = False
            .Columns.Clear()
            .Activation = ItemActivation.OneClick
            .Columns.Add("ID", 40, HorizontalAlignment.Right)
            .Columns.Add("Apellido y Nombre", 150, HorizontalAlignment.Left)
            .Columns.Add("S.", 40, HorizontalAlignment.Left)
            .Columns.Add("Documento", 75, HorizontalAlignment.Left)
            .Columns.Add("Teléfono De Emergencia", 100, HorizontalAlignment.Left)
            .Columns.Add("Dirección", 60, HorizontalAlignment.Left)
            .Columns.Add("Correo Electronico", 85, HorizontalAlignment.Left)
            .Columns.Add("Etnia", 70, HorizontalAlignment.Left)
            .Columns.Add("Religión", 60, HorizontalAlignment.Left)
            .Columns.Add("Estudios", 80, HorizontalAlignment.Left)
            .Columns.Add("Teléfono", 90, HorizontalAlignment.Left)
            .Columns.Add("Género", 90, HorizontalAlignment.Left)
            .Columns.Add("Nombre autopersivido", 150, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub CargarPacientes()
        Dim oLV As ListViewItem
        Dim drPaciente As MySqlDataReader = oPaciente.TraerPaciente()
        lvPacientes.Visible = False
        lvPacientes.Items.Clear()
        While drPaciente.Read()
            oLV = New ListViewItem(Trim(drPaciente("Idpaciente")))
            oLV.SubItems.Add(Trim(drPaciente("Nombre")))
            oLV.SubItems.Add(Trim(drPaciente("Sexo")))
            oLV.SubItems.Add(Trim(drPaciente("DNI")))
            oLV.SubItems.Add(drPaciente("Telefono_Emergencia"))
            oLV.SubItems.Add(Trim(drPaciente("Direccion")))
            oLV.SubItems.Add(Trim(drPaciente("Correo_electronico")))
            oLV.SubItems.Add(Trim(drPaciente("Etnia")))
            oLV.SubItems.Add(Trim(drPaciente("Religion")))
            oLV.SubItems.Add(Trim(drPaciente("Estudios")))
            oLV.SubItems.Add(Trim(drPaciente("Telefono")))
            oLV.SubItems.Add(Trim(drPaciente("Genero")))
            oLV.SubItems.Add(Trim(drPaciente("Nombre_autopersibido")))


            lvPacientes.Items.Add(oLV)
        End While
        lvPacientes.Visible = True
    End Sub

    Private Sub Agregar()
        Dim vForm As New frmAddPaciente
        vForm.Text = "Nuevo Paciente"
        vForm.ShowDialog()
        CargarPacientes()
    End Sub

    Private Sub mnuAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgregar.Click
        Call Agregar()
    End Sub

    Private Sub Editar()
        Dim vForm As New frmAddPaciente
        vForm.Text = "Editando"
        vForm.ShowDialog()
    End Sub

    Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
        Editar()
    End Sub

    Private Sub frmPacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConfigurarGrilla()
        Call CargarPacientes()

    End Sub
End Class