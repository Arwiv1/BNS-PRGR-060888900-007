﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnfermeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFichaMedica = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFichaMedicaReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticas = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlamado = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.AyudaToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPacientes, Me.mnuEnfermeros, Me.mnuFichaMedica})
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(48, 20)
        Me.mnuArchivo.Text = "Inicio"
        '
        'mnuPacientes
        '
        Me.mnuPacientes.Name = "mnuPacientes"
        Me.mnuPacientes.Size = New System.Drawing.Size(144, 22)
        Me.mnuPacientes.Text = "Pacientes"
        '
        'mnuEnfermeros
        '
        Me.mnuEnfermeros.Name = "mnuEnfermeros"
        Me.mnuEnfermeros.Size = New System.Drawing.Size(144, 22)
        Me.mnuEnfermeros.Text = "Enfermeros"
        '
        'mnuFichaMedica
        '
        Me.mnuFichaMedica.Name = "mnuFichaMedica"
        Me.mnuFichaMedica.Size = New System.Drawing.Size(144, 22)
        Me.mnuFichaMedica.Text = "Ficha Médica"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFichaMedicaReport, Me.mnuEstadisticas, Me.mnuLlamado})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AyudaToolStripMenuItem.Text = "Reporte"
        '
        'mnuFichaMedicaReport
        '
        Me.mnuFichaMedicaReport.Name = "mnuFichaMedicaReport"
        Me.mnuFichaMedicaReport.Size = New System.Drawing.Size(152, 22)
        Me.mnuFichaMedicaReport.Text = "Ficha Médica"
        '
        'mnuEstadisticas
        '
        Me.mnuEstadisticas.Name = "mnuEstadisticas"
        Me.mnuEstadisticas.Size = New System.Drawing.Size(152, 22)
        Me.mnuEstadisticas.Text = "Estádistica"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcercaDe, Me.ToolStripMenuItem2})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(152, 22)
        Me.mnuAcercaDe.Text = "Acerca de"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'mnuLlamado
        '
        Me.mnuLlamado.Name = "mnuLlamado"
        Me.mnuLlamado.Size = New System.Drawing.Size(152, 22)
        Me.mnuLlamado.Text = "Llamados"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión Hospitalaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPacientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEnfermeros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFichaMedica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFichaMedicaReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLlamado As System.Windows.Forms.ToolStripMenuItem

End Class
