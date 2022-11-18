<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnfermeros
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.mnuAgregar_Enfermeros = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripButton()
        Me.mnuEditar_Enfermeros = New System.Windows.Forms.ToolStripButton()
        Me.separador2 = New System.Windows.Forms.ToolStripButton()
        Me.mnuElminar_Enfermeros = New System.Windows.Forms.ToolStripButton()
        Me.separador3 = New System.Windows.Forms.ToolStripButton()
        Me.separador4 = New System.Windows.Forms.ToolStripButton()
        Me.grbBusqueda_Enfermeros = New System.Windows.Forms.GroupBox()
        Me.txtDNI_Enfermeros = New System.Windows.Forms.TextBox()
        Me.lblDni_Enfermeros = New System.Windows.Forms.Label()
        Me.txtApellido_Enfermeros = New System.Windows.Forms.TextBox()
        Me.lblApellido_Enfermeros = New System.Windows.Forms.Label()
        Me.grb1_Enfermeros = New System.Windows.Forms.GroupBox()
        Me.lvEnfermero = New System.Windows.Forms.ListView()
        Me.ToolStrip1.SuspendLayout()
        Me.grbBusqueda_Enfermeros.SuspendLayout()
        Me.grb1_Enfermeros.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar_Enfermeros, Me.separador1, Me.mnuEditar_Enfermeros, Me.separador2, Me.mnuElminar_Enfermeros, Me.separador3, Me.separador4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1105, 73)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'mnuAgregar_Enfermeros
        '
        Me.mnuAgregar_Enfermeros.Image = Global.Olimpiadas.My.Resources.Resources.Add
        Me.mnuAgregar_Enfermeros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAgregar_Enfermeros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAgregar_Enfermeros.Name = "mnuAgregar_Enfermeros"
        Me.mnuAgregar_Enfermeros.Size = New System.Drawing.Size(101, 70)
        Me.mnuAgregar_Enfermeros.Text = "Agregar"
        '
        'separador1
        '
        Me.separador1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.separador1.Enabled = False
        Me.separador1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(23, 70)
        Me.separador1.Text = "ToolStripButton1"
        '
        'mnuEditar_Enfermeros
        '
        Me.mnuEditar_Enfermeros.Image = Global.Olimpiadas.My.Resources.Resources.Modify
        Me.mnuEditar_Enfermeros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuEditar_Enfermeros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditar_Enfermeros.Name = "mnuEditar_Enfermeros"
        Me.mnuEditar_Enfermeros.Size = New System.Drawing.Size(89, 70)
        Me.mnuEditar_Enfermeros.Text = "Editar"
        '
        'separador2
        '
        Me.separador2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.separador2.Enabled = False
        Me.separador2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(23, 70)
        Me.separador2.Text = "ToolStripButton1"
        '
        'mnuElminar_Enfermeros
        '
        Me.mnuElminar_Enfermeros.Image = Global.Olimpiadas.My.Resources.Resources.Delete
        Me.mnuElminar_Enfermeros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuElminar_Enfermeros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuElminar_Enfermeros.Name = "mnuElminar_Enfermeros"
        Me.mnuElminar_Enfermeros.Size = New System.Drawing.Size(102, 70)
        Me.mnuElminar_Enfermeros.Text = "Eliminar"
        '
        'separador3
        '
        Me.separador3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.separador3.Enabled = False
        Me.separador3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador3.Name = "separador3"
        Me.separador3.Size = New System.Drawing.Size(23, 70)
        Me.separador3.Text = "separador3"
        '
        'separador4
        '
        Me.separador4.Enabled = False
        Me.separador4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.separador4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador4.Name = "separador4"
        Me.separador4.Size = New System.Drawing.Size(23, 70)
        '
        'grbBusqueda_Enfermeros
        '
        Me.grbBusqueda_Enfermeros.Controls.Add(Me.txtDNI_Enfermeros)
        Me.grbBusqueda_Enfermeros.Controls.Add(Me.lblDni_Enfermeros)
        Me.grbBusqueda_Enfermeros.Controls.Add(Me.txtApellido_Enfermeros)
        Me.grbBusqueda_Enfermeros.Controls.Add(Me.lblApellido_Enfermeros)
        Me.grbBusqueda_Enfermeros.Location = New System.Drawing.Point(9, 92)
        Me.grbBusqueda_Enfermeros.Name = "grbBusqueda_Enfermeros"
        Me.grbBusqueda_Enfermeros.Size = New System.Drawing.Size(1110, 99)
        Me.grbBusqueda_Enfermeros.TabIndex = 2
        Me.grbBusqueda_Enfermeros.TabStop = False
        Me.grbBusqueda_Enfermeros.Text = "Busqueda"
        '
        'txtDNI_Enfermeros
        '
        Me.txtDNI_Enfermeros.Location = New System.Drawing.Point(76, 62)
        Me.txtDNI_Enfermeros.Name = "txtDNI_Enfermeros"
        Me.txtDNI_Enfermeros.Size = New System.Drawing.Size(132, 20)
        Me.txtDNI_Enfermeros.TabIndex = 3
        '
        'lblDni_Enfermeros
        '
        Me.lblDni_Enfermeros.AutoSize = True
        Me.lblDni_Enfermeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni_Enfermeros.Location = New System.Drawing.Point(23, 64)
        Me.lblDni_Enfermeros.Name = "lblDni_Enfermeros"
        Me.lblDni_Enfermeros.Size = New System.Drawing.Size(37, 15)
        Me.lblDni_Enfermeros.TabIndex = 2
        Me.lblDni_Enfermeros.Text = "D.N.I:"
        '
        'txtApellido_Enfermeros
        '
        Me.txtApellido_Enfermeros.Location = New System.Drawing.Point(76, 25)
        Me.txtApellido_Enfermeros.Name = "txtApellido_Enfermeros"
        Me.txtApellido_Enfermeros.Size = New System.Drawing.Size(256, 20)
        Me.txtApellido_Enfermeros.TabIndex = 1
        '
        'lblApellido_Enfermeros
        '
        Me.lblApellido_Enfermeros.AutoSize = True
        Me.lblApellido_Enfermeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido_Enfermeros.Location = New System.Drawing.Point(6, 26)
        Me.lblApellido_Enfermeros.Name = "lblApellido_Enfermeros"
        Me.lblApellido_Enfermeros.Size = New System.Drawing.Size(54, 15)
        Me.lblApellido_Enfermeros.TabIndex = 0
        Me.lblApellido_Enfermeros.Text = "Apellido:"
        '
        'grb1_Enfermeros
        '
        Me.grb1_Enfermeros.Controls.Add(Me.lvEnfermero)
        Me.grb1_Enfermeros.Location = New System.Drawing.Point(9, 210)
        Me.grb1_Enfermeros.Name = "grb1_Enfermeros"
        Me.grb1_Enfermeros.Size = New System.Drawing.Size(1091, 381)
        Me.grb1_Enfermeros.TabIndex = 3
        Me.grb1_Enfermeros.TabStop = False
        '
        'lvEnfermero
        '
        Me.lvEnfermero.Location = New System.Drawing.Point(24, 18)
        Me.lvEnfermero.Name = "lvEnfermero"
        Me.lvEnfermero.Size = New System.Drawing.Size(1042, 346)
        Me.lvEnfermero.TabIndex = 0
        Me.lvEnfermero.UseCompatibleStateImageBehavior = False
        '
        'frmEnfermeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 615)
        Me.Controls.Add(Me.grb1_Enfermeros)
        Me.Controls.Add(Me.grbBusqueda_Enfermeros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEnfermeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermeros"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grbBusqueda_Enfermeros.ResumeLayout(False)
        Me.grbBusqueda_Enfermeros.PerformLayout()
        Me.grb1_Enfermeros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuAgregar_Enfermeros As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEditar_Enfermeros As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuElminar_Enfermeros As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents grbBusqueda_Enfermeros As System.Windows.Forms.GroupBox
    Friend WithEvents txtDNI_Enfermeros As System.Windows.Forms.TextBox
    Friend WithEvents lblDni_Enfermeros As System.Windows.Forms.Label
    Friend WithEvents txtApellido_Enfermeros As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido_Enfermeros As System.Windows.Forms.Label
    Friend WithEvents grb1_Enfermeros As System.Windows.Forms.GroupBox
    Friend WithEvents lvEnfermero As System.Windows.Forms.ListView
End Class
