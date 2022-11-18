<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
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
        Me.mnuAgregar = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripButton()
        Me.mnuEditar = New System.Windows.Forms.ToolStripButton()
        Me.separador2 = New System.Windows.Forms.ToolStripButton()
        Me.mnuElminar = New System.Windows.Forms.ToolStripButton()
        Me.separador3 = New System.Windows.Forms.ToolStripButton()
        Me.separador4 = New System.Windows.Forms.ToolStripButton()
        Me.grbBusqueda = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.lvPacientes = New System.Windows.Forms.ListView()
        Me.ToolStrip1.SuspendLayout()
        Me.grbBusqueda.SuspendLayout()
        Me.grb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.separador1, Me.mnuEditar, Me.separador2, Me.mnuElminar, Me.separador3, Me.separador4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1115, 75)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Image = Global.Olimpiadas.My.Resources.Resources.Add
        Me.mnuAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.Size = New System.Drawing.Size(101, 72)
        Me.mnuAgregar.Text = "Agregar"
        '
        'separador1
        '
        Me.separador1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.separador1.Enabled = False
        Me.separador1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(23, 72)
        Me.separador1.Text = "ToolStripButton1"
        '
        'mnuEditar
        '
        Me.mnuEditar.Image = Global.Olimpiadas.My.Resources.Resources.Modify
        Me.mnuEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.Size = New System.Drawing.Size(89, 72)
        Me.mnuEditar.Text = "Editar"
        '
        'separador2
        '
        Me.separador2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.separador2.Enabled = False
        Me.separador2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(23, 72)
        Me.separador2.Text = "ToolStripButton1"
        '
        'mnuElminar
        '
        Me.mnuElminar.Image = Global.Olimpiadas.My.Resources.Resources.Delete
        Me.mnuElminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuElminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuElminar.Name = "mnuElminar"
        Me.mnuElminar.Size = New System.Drawing.Size(102, 72)
        Me.mnuElminar.Text = "Eliminar"
        '
        'separador3
        '
        Me.separador3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.separador3.Enabled = False
        Me.separador3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador3.Name = "separador3"
        Me.separador3.Size = New System.Drawing.Size(23, 72)
        Me.separador3.Text = "separador3"
        '
        'separador4
        '
        Me.separador4.Enabled = False
        Me.separador4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.separador4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.separador4.Name = "separador4"
        Me.separador4.Size = New System.Drawing.Size(23, 72)
        '
        'grbBusqueda
        '
        Me.grbBusqueda.Controls.Add(Me.TextBox1)
        Me.grbBusqueda.Controls.Add(Me.lblDni)
        Me.grbBusqueda.Controls.Add(Me.txtApellido)
        Me.grbBusqueda.Controls.Add(Me.lblApellido)
        Me.grbBusqueda.Location = New System.Drawing.Point(12, 78)
        Me.grbBusqueda.Name = "grbBusqueda"
        Me.grbBusqueda.Size = New System.Drawing.Size(1110, 102)
        Me.grbBusqueda.TabIndex = 1
        Me.grbBusqueda.TabStop = False
        Me.grbBusqueda.Text = "Busqueda"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(23, 65)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(37, 15)
        Me.lblDni.TabIndex = 2
        Me.lblDni.Text = "D.N.I:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(76, 26)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(256, 20)
        Me.txtApellido.TabIndex = 1
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(6, 27)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(54, 15)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido:"
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.lvPacientes)
        Me.grb1.Location = New System.Drawing.Point(12, 195)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(1091, 391)
        Me.grb1.TabIndex = 2
        Me.grb1.TabStop = False
        '
        'lvPacientes
        '
        Me.lvPacientes.Location = New System.Drawing.Point(24, 19)
        Me.lvPacientes.Name = "lvPacientes"
        Me.lvPacientes.Size = New System.Drawing.Size(1042, 355)
        Me.lvPacientes.TabIndex = 0
        Me.lvPacientes.UseCompatibleStateImageBehavior = False
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1115, 625)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.grbBusqueda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(6, 195)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grbBusqueda.ResumeLayout(False)
        Me.grbBusqueda.PerformLayout()
        Me.grb1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuElminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents grb1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvPacientes As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
End Class
