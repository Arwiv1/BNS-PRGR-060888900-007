<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlamado
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
        Me.grbBusqueda = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.dtpLlamadas = New System.Windows.Forms.DateTimePicker()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtHabitacion = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.lvLlamadas = New System.Windows.Forms.ListView()
        Me.grbBusqueda.SuspendLayout()
        Me.grb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbBusqueda
        '
        Me.grbBusqueda.Controls.Add(Me.Label1)
        Me.grbBusqueda.Controls.Add(Me.cbHabitacion)
        Me.grbBusqueda.Controls.Add(Me.dtpLlamadas)
        Me.grbBusqueda.Controls.Add(Me.cmdBuscar)
        Me.grbBusqueda.Controls.Add(Me.txtHabitacion)
        Me.grbBusqueda.Controls.Add(Me.lblDni)
        Me.grbBusqueda.Controls.Add(Me.lbl)
        Me.grbBusqueda.Location = New System.Drawing.Point(18, 17)
        Me.grbBusqueda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbBusqueda.Name = "grbBusqueda"
        Me.grbBusqueda.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbBusqueda.Size = New System.Drawing.Size(834, 157)
        Me.grbBusqueda.TabIndex = 2
        Me.grbBusqueda.TabStop = False
        Me.grbBusqueda.Text = "Busqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(534, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Habitación:"
        '
        'cbHabitacion
        '
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Location = New System.Drawing.Point(634, 32)
        Me.cbHabitacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(180, 28)
        Me.cbHabitacion.TabIndex = 112
        '
        'dtpLlamadas
        '
        Me.dtpLlamadas.Location = New System.Drawing.Point(182, 35)
        Me.dtpLlamadas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpLlamadas.Name = "dtpLlamadas"
        Me.dtpLlamadas.Size = New System.Drawing.Size(298, 26)
        Me.dtpLlamadas.TabIndex = 111
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdBuscar.Location = New System.Drawing.Point(669, 100)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(156, 45)
        Me.cmdBuscar.TabIndex = 110
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        Me.cmdBuscar.Visible = False
        '
        'txtHabitacion
        '
        Me.txtHabitacion.Location = New System.Drawing.Point(147, 100)
        Me.txtHabitacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHabitacion.Name = "txtHabitacion"
        Me.txtHabitacion.Size = New System.Drawing.Size(196, 26)
        Me.txtHabitacion.TabIndex = 3
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(34, 100)
        Me.lblDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(100, 22)
        Me.lblDni.TabIndex = 2
        Me.lblDni.Text = "Habitacion:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(9, 42)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(157, 22)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Fecha de llamada:"
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.lvLlamadas)
        Me.grb1.Location = New System.Drawing.Point(18, 185)
        Me.grb1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grb1.Name = "grb1"
        Me.grb1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grb1.Size = New System.Drawing.Size(834, 602)
        Me.grb1.TabIndex = 3
        Me.grb1.TabStop = False
        '
        'lvLlamadas
        '
        Me.lvLlamadas.Location = New System.Drawing.Point(36, 29)
        Me.lvLlamadas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lvLlamadas.Name = "lvLlamadas"
        Me.lvLlamadas.Size = New System.Drawing.Size(796, 544)
        Me.lvLlamadas.TabIndex = 0
        Me.lvLlamadas.UseCompatibleStateImageBehavior = False
        '
        'frmLlamados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 788)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.grbBusqueda)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLlamados"
        Me.Text = "Llamados"
        Me.grbBusqueda.ResumeLayout(False)
        Me.grbBusqueda.PerformLayout()
        Me.grb1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents txtHabitacion As System.Windows.Forms.TextBox
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents grb1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvLlamadas As System.Windows.Forms.ListView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbHabitacion As System.Windows.Forms.ComboBox
    Friend WithEvents dtpLlamadas As System.Windows.Forms.DateTimePicker
End Class
