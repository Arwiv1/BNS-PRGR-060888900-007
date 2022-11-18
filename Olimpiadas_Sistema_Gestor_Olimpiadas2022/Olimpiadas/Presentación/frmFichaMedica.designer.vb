<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFichaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFichaMedica))
        Me.grpDatosalumno = New System.Windows.Forms.GroupBox()
        Me.cbObra_social = New System.Windows.Forms.ComboBox()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.lblEnfermero_asignado = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtTipo_sangre = New System.Windows.Forms.TextBox()
        Me.cboEnfermero = New System.Windows.Forms.ComboBox()
        Me.grpDireccionAlumno = New System.Windows.Forms.GroupBox()
        Me.txtMedicacion = New System.Windows.Forms.TextBox()
        Me.txtCodigo_clinico = New System.Windows.Forms.TextBox()
        Me.lblNumeroAlumno = New System.Windows.Forms.Label()
        Me.lblhabitacion = New System.Windows.Forms.Label()
        Me.lblMedicacion = New System.Windows.Forms.Label()
        Me.cboPaciente = New System.Windows.Forms.ComboBox()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblObra_social = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.grpDatosalumno.SuspendLayout()
        Me.grpDireccionAlumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosalumno
        '
        Me.grpDatosalumno.Controls.Add(Me.cbObra_social)
        Me.grpDatosalumno.Controls.Add(Me.cmdLimpiar)
        Me.grpDatosalumno.Controls.Add(Me.lblEnfermero_asignado)
        Me.grpDatosalumno.Controls.Add(Me.cmdAceptar)
        Me.grpDatosalumno.Controls.Add(Me.txtTipo_sangre)
        Me.grpDatosalumno.Controls.Add(Me.cboEnfermero)
        Me.grpDatosalumno.Controls.Add(Me.grpDireccionAlumno)
        Me.grpDatosalumno.Controls.Add(Me.cboPaciente)
        Me.grpDatosalumno.Controls.Add(Me.lblPaciente)
        Me.grpDatosalumno.Controls.Add(Me.lblApellidos)
        Me.grpDatosalumno.Controls.Add(Me.lblObra_social)
        Me.grpDatosalumno.Location = New System.Drawing.Point(18, 39)
        Me.grpDatosalumno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDatosalumno.Name = "grpDatosalumno"
        Me.grpDatosalumno.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDatosalumno.Size = New System.Drawing.Size(874, 363)
        Me.grpDatosalumno.TabIndex = 5
        Me.grpDatosalumno.TabStop = False
        Me.grpDatosalumno.Text = "Datos Paciente"
        '
        'cbObra_social
        '
        Me.cbObra_social.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbObra_social.FormattingEnabled = True
        Me.cbObra_social.Location = New System.Drawing.Point(186, 91)
        Me.cbObra_social.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbObra_social.Name = "cbObra_social"
        Me.cbObra_social.Size = New System.Drawing.Size(189, 28)
        Me.cbObra_social.TabIndex = 124
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(460, 295)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(112, 45)
        Me.cmdLimpiar.TabIndex = 107
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'lblEnfermero_asignado
        '
        Me.lblEnfermero_asignado.AutoSize = True
        Me.lblEnfermero_asignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblEnfermero_asignado.Location = New System.Drawing.Point(441, 37)
        Me.lblEnfermero_asignado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnfermero_asignado.Name = "lblEnfermero_asignado"
        Me.lblEnfermero_asignado.Size = New System.Drawing.Size(196, 25)
        Me.lblEnfermero_asignado.TabIndex = 123
        Me.lblEnfermero_asignado.Text = "Enfermero Asignado:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdAceptar.Location = New System.Drawing.Point(278, 295)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(112, 45)
        Me.cmdAceptar.TabIndex = 106
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'txtTipo_sangre
        '
        Me.txtTipo_sangre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo_sangre.Location = New System.Drawing.Point(645, 95)
        Me.txtTipo_sangre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTipo_sangre.Name = "txtTipo_sangre"
        Me.txtTipo_sangre.Size = New System.Drawing.Size(118, 26)
        Me.txtTipo_sangre.TabIndex = 13
        '
        'cboEnfermero
        '
        Me.cboEnfermero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnfermero.FormattingEnabled = True
        Me.cboEnfermero.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cboEnfermero.Location = New System.Drawing.Point(645, 38)
        Me.cboEnfermero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboEnfermero.Name = "cboEnfermero"
        Me.cboEnfermero.Size = New System.Drawing.Size(214, 28)
        Me.cboEnfermero.TabIndex = 14
        '
        'grpDireccionAlumno
        '
        Me.grpDireccionAlumno.Controls.Add(Me.ComboBox2)
        Me.grpDireccionAlumno.Controls.Add(Me.txtMedicacion)
        Me.grpDireccionAlumno.Controls.Add(Me.txtCodigo_clinico)
        Me.grpDireccionAlumno.Controls.Add(Me.lblNumeroAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblhabitacion)
        Me.grpDireccionAlumno.Controls.Add(Me.lblMedicacion)
        Me.grpDireccionAlumno.Location = New System.Drawing.Point(0, 156)
        Me.grpDireccionAlumno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDireccionAlumno.Name = "grpDireccionAlumno"
        Me.grpDireccionAlumno.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDireccionAlumno.Size = New System.Drawing.Size(859, 129)
        Me.grpDireccionAlumno.TabIndex = 25
        Me.grpDireccionAlumno.TabStop = False
        Me.grpDireccionAlumno.Text = "Dirección"
        '
        'txtMedicacion
        '
        Me.txtMedicacion.Location = New System.Drawing.Point(134, 30)
        Me.txtMedicacion.Multiline = True
        Me.txtMedicacion.Name = "txtMedicacion"
        Me.txtMedicacion.Size = New System.Drawing.Size(241, 91)
        Me.txtMedicacion.TabIndex = 121
        '
        'txtCodigo_clinico
        '
        Me.txtCodigo_clinico.Location = New System.Drawing.Point(618, 31)
        Me.txtCodigo_clinico.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigo_clinico.Name = "txtCodigo_clinico"
        Me.txtCodigo_clinico.Size = New System.Drawing.Size(126, 26)
        Me.txtCodigo_clinico.TabIndex = 30
        '
        'lblNumeroAlumno
        '
        Me.lblNumeroAlumno.AutoSize = True
        Me.lblNumeroAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroAlumno.Location = New System.Drawing.Point(399, 30)
        Me.lblNumeroAlumno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroAlumno.Name = "lblNumeroAlumno"
        Me.lblNumeroAlumno.Size = New System.Drawing.Size(211, 25)
        Me.lblNumeroAlumno.TabIndex = 120
        Me.lblNumeroAlumno.Text = "Codigo historial clinico:"
        '
        'lblhabitacion
        '
        Me.lblhabitacion.AutoSize = True
        Me.lblhabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabitacion.Location = New System.Drawing.Point(476, 83)
        Me.lblhabitacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhabitacion.Name = "lblhabitacion"
        Me.lblhabitacion.Size = New System.Drawing.Size(110, 25)
        Me.lblhabitacion.TabIndex = 106
        Me.lblhabitacion.Text = "Habitacion:"
        '
        'lblMedicacion
        '
        Me.lblMedicacion.AutoSize = True
        Me.lblMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicacion.Location = New System.Drawing.Point(9, 63)
        Me.lblMedicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(118, 25)
        Me.lblMedicacion.TabIndex = 103
        Me.lblMedicacion.Text = "Medicacion:"
        '
        'cboPaciente
        '
        Me.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaciente.FormattingEnabled = True
        Me.cboPaciente.Location = New System.Drawing.Point(186, 39)
        Me.cboPaciente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboPaciente.Name = "cboPaciente"
        Me.cboPaciente.Size = New System.Drawing.Size(189, 28)
        Me.cboPaciente.TabIndex = 10
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblPaciente.Location = New System.Drawing.Point(64, 38)
        Me.lblPaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(94, 25)
        Me.lblPaciente.TabIndex = 17
        Me.lblPaciente.Text = "Paciente:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblApellidos.Location = New System.Drawing.Point(488, 96)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(149, 25)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Tipo de sangre:"
        '
        'lblObra_social
        '
        Me.lblObra_social.AutoSize = True
        Me.lblObra_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblObra_social.Location = New System.Drawing.Point(61, 91)
        Me.lblObra_social.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObra_social.Name = "lblObra_social"
        Me.lblObra_social.Size = New System.Drawing.Size(117, 25)
        Me.lblObra_social.TabIndex = 7
        Me.lblObra_social.Text = "Obra social:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.ComboBox2.Location = New System.Drawing.Point(594, 84)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 28)
        Me.ComboBox2.TabIndex = 122
        '
        'frmFichaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(927, 422)
        Me.Controls.Add(Me.grpDatosalumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFichaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha Médica"
        Me.grpDatosalumno.ResumeLayout(False)
        Me.grpDatosalumno.PerformLayout()
        Me.grpDireccionAlumno.ResumeLayout(False)
        Me.grpDireccionAlumno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosalumno As System.Windows.Forms.GroupBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblObra_social As System.Windows.Forms.Label
    Friend WithEvents txtTipo_sangre As System.Windows.Forms.TextBox
    Friend WithEvents cboEnfermero As System.Windows.Forms.ComboBox
    Friend WithEvents cboPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents grpDireccionAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo_clinico As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroAlumno As System.Windows.Forms.Label
    Friend WithEvents lblhabitacion As System.Windows.Forms.Label
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblEnfermero_asignado As System.Windows.Forms.Label
    Friend WithEvents cbObra_social As System.Windows.Forms.ComboBox
    Friend WithEvents txtMedicacion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox

End Class
