Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmEnfermeros

    Private Sub ConfigurarGrilla()
        With lvEnfermero
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .HotTracking = False
            .HoverSelection = False
            .Columns.Clear()
            .Activation = ItemActivation.OneClick
            .Columns.Add("ID", 40, HorizontalAlignment.Right)
            .Columns.Add("Area", 70, HorizontalAlignment.Left)
            .Columns.Add("Apellido y Nombre", 150, HorizontalAlignment.Left)
            .Columns.Add("Documento", 75, HorizontalAlignment.Left)
            .Columns.Add("Codigo identificador", 150, HorizontalAlignment.Left)
            .Columns.Add("S.", 40, HorizontalAlignment.Left)


        End With
    End Sub
    Private Sub CargarEnfermero()
        Dim oLV As ListViewItem
        Dim drEnfermero As MySqlDataReader = oEnfermero.TraerEnfermero()
        lvEnfermero.Visible = False
        lvEnfermero.Items.Clear()
        While drEnfermero.Read()
            oLV = New ListViewItem(Trim(drEnfermero("Idenfermeros")))
            oLV.SubItems.Add(Trim(drEnfermero("Area")))
            oLV.SubItems.Add(Trim(drEnfermero("Nombre")))
            oLV.SubItems.Add(drEnfermero("DNI"))
            oLV.SubItems.Add(Trim(drEnfermero("Codigo_Identificacion")))
            oLV.SubItems.Add(Trim(drEnfermero("sexo")))
            lvEnfermero.Items.Add(oLV)
        End While
        lvEnfermero.Visible = True
    End Sub

    Private Sub frmEnfermero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConfigurarGrilla()
        Call CargarEnfermero()

    End Sub

    Private Sub mnuAgregar_Enfermeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgregar_Enfermeros.Click
        Call Agregar()
    End Sub
    Private Sub Agregar()
        Dim vForm As New frmAddEnfermero
        vForm.Text = "Nuevo Enfermero"
        vForm.ShowDialog()
        CargarEnfermero()
    End Sub
End Class