Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmLlamado
    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub ConfigurarGrilla()
        With lvLlamadas
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .HotTracking = False
            .HoverSelection = False
            .Columns.Clear()
            .Activation = ItemActivation.OneClick
            .Columns.Add("ID", 40, HorizontalAlignment.Right)
            .Columns.Add("Emergencia", 30, HorizontalAlignment.Left)
            .Columns.Add("Atendido", 40, HorizontalAlignment.Left)
            .Columns.Add("Fecha", 100, HorizontalAlignment.Left)
            .Columns.Add("Ubicacion", 50, HorizontalAlignment.Left)
            .Columns.Add("Idhabitacion", 60, HorizontalAlignment.Left)
            .Columns.Add("Inicio_llamado", 85, HorizontalAlignment.Left)
            .Columns.Add("Fin_llamado", 70, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub CargarLlamadas()
        Dim oLV As ListViewItem
        Dim drLlamado As MySqlDataReader = oLlamado.TraerLlamadas()
        lvLlamadas.Visible = False
        lvLlamadas.Items.Clear()
        While drLlamado.Read()
            oLV = New ListViewItem(Trim(drLlamado("idLlamado")))
            oLV.SubItems.Add(Trim(drLlamado("Emergencia")))
            oLV.SubItems.Add(Trim(drLlamado("Atendido")))
            oLV.SubItems.Add(drLlamado("Fecha"))
            oLV.SubItems.Add(drLlamado("Ubicacion"))
            oLV.SubItems.Add(Trim(drLlamado("Idhabitacion")))
            oLV.SubItems.Add(Trim(drLlamado("Inicio_llamado")))
            oLV.SubItems.Add(Trim(drLlamado("Fin_llamado")))
            lvLlamadas.Items.Add(oLV)
        End While
        lvLlamadas.Visible = True
    End Sub

    Private Sub frmLlamadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConfigurarGrilla()
        Call CargarLlamadas()
    End Sub
End Class