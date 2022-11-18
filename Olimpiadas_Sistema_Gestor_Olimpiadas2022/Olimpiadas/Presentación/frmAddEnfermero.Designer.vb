<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEnfermero
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
        Me.grpDatosEnfermero = New System.Windows.Forms.GroupBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cboEstudios = New System.Windows.Forms.ComboBox()
        Me.lblEstudios = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtApellidosEnfermero = New System.Windows.Forms.TextBox()
        Me.txtNombreEnfermero = New System.Windows.Forms.TextBox()
        Me.gprNacimientoAlumno = New System.Windows.Forms.GroupBox()
        Me.cboNacionalidadPaciente = New System.Windows.Forms.ComboBox()
        Me.lblNacionalidadPaciente = New System.Windows.Forms.Label()
        Me.mskNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.grpDireccionPaciente = New System.Windows.Forms.GroupBox()
        Me.txtYEnfermero = New System.Windows.Forms.TextBox()
        Me.lblYEnfermero = New System.Windows.Forms.Label()
        Me.txtEntreEnfermero = New System.Windows.Forms.TextBox()
        Me.lblEntreEnfermero = New System.Windows.Forms.Label()
        Me.txtCalleEnfermero = New System.Windows.Forms.TextBox()
        Me.lblCalleEnfermero = New System.Windows.Forms.Label()
        Me.grpTelefono = New System.Windows.Forms.GroupBox()
        Me.grpDatosEmergencia = New System.Windows.Forms.GroupBox()
        Me.txtTelefonoPacienteEmergencia = New System.Windows.Forms.TextBox()
        Me.lbltxtTelefonoPacienteEmergencia = New System.Windows.Forms.Label()
        Me.mskCodigodeareaEmergencia = New System.Windows.Forms.MaskedTextBox()
        Me.lblCodigodeareaEmergencia = New System.Windows.Forms.Label()
        Me.txtTelefonoPaciente = New System.Windows.Forms.TextBox()
        Me.lblNumerodetelefono = New System.Windows.Forms.Label()
        Me.mskCodigodearea = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCodigodearea = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblNumerodedocumento = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.grpDatosEnfermero.SuspendLayout()
        Me.gprNacimientoAlumno.SuspendLayout()
        Me.grpDireccionPaciente.SuspendLayout()
        Me.grpTelefono.SuspendLayout()
        Me.grpDatosEmergencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosEnfermero
        '
        Me.grpDatosEnfermero.Controls.Add(Me.cboArea)
        Me.grpDatosEnfermero.Controls.Add(Me.lblArea)
        Me.grpDatosEnfermero.Controls.Add(Me.cboEstudios)
        Me.grpDatosEnfermero.Controls.Add(Me.lblEstudios)
        Me.grpDatosEnfermero.Controls.Add(Me.cboSexo)
        Me.grpDatosEnfermero.Controls.Add(Me.lblSexo)
        Me.grpDatosEnfermero.Controls.Add(Me.txtApellidosEnfermero)
        Me.grpDatosEnfermero.Controls.Add(Me.txtNombreEnfermero)
        Me.grpDatosEnfermero.Controls.Add(Me.gprNacimientoAlumno)
        Me.grpDatosEnfermero.Controls.Add(Me.grpDireccionPaciente)
        Me.grpDatosEnfermero.Controls.Add(Me.grpTelefono)
        Me.grpDatosEnfermero.Controls.Add(Me.txtDNI)
        Me.grpDatosEnfermero.Controls.Add(Me.lblNumerodedocumento)
        Me.grpDatosEnfermero.Controls.Add(Me.lblApellidos)
        Me.grpDatosEnfermero.Controls.Add(Me.lblNombres)
        Me.grpDatosEnfermero.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosEnfermero.Name = "grpDatosEnfermero"
        Me.grpDatosEnfermero.Size = New System.Drawing.Size(529, 435)
        Me.grpDatosEnfermero.TabIndex = 6
        Me.grpDatosEnfermero.TabStop = False
        Me.grpDatosEnfermero.Text = "Datos Enfermero"
        '
        'cboArea
        '
        Me.cboArea.DisplayMember = "1"
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"Pediatria", "Quirofano", "Terapia", "Terapia Intensiva"})
        Me.cboArea.Location = New System.Drawing.Point(333, 18)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(174, 21)
        Me.cboArea.TabIndex = 127
        Me.cboArea.ValueMember = "1"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblArea.Location = New System.Drawing.Point(272, 23)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(47, 16)
        Me.lblArea.TabIndex = 126
        Me.lblArea.Text = "Áreas:"
        '
        'cboEstudios
        '
        Me.cboEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstudios.FormattingEnabled = True
        Me.cboEstudios.Items.AddRange(New Object() {"Primario Incompleto", "Primario Completo", "Secundario Incompleto", "Secundario Completo", "Universitario Incompleto", "Universitario Completo"})
        Me.cboEstudios.Location = New System.Drawing.Point(333, 91)
        Me.cboEstudios.Name = "cboEstudios"
        Me.cboEstudios.Size = New System.Drawing.Size(174, 21)
        Me.cboEstudios.TabIndex = 125
        '
        'lblEstudios
        '
        Me.lblEstudios.AutoSize = True
        Me.lblEstudios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblEstudios.Location = New System.Drawing.Point(264, 96)
        Me.lblEstudios.Name = "lblEstudios"
        Me.lblEstudios.Size = New System.Drawing.Size(63, 16)
        Me.lblEstudios.TabIndex = 124
        Me.lblEstudios.Text = "Estudios:"
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "X"})
        Me.cboSexo.Location = New System.Drawing.Point(69, 91)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(163, 21)
        Me.cboSexo.TabIndex = 123
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSexo.Location = New System.Drawing.Point(21, 96)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(42, 16)
        Me.lblSexo.TabIndex = 122
        Me.lblSexo.Text = "Sexo:"
        '
        'txtApellidosEnfermero
        '
        Me.txtApellidosEnfermero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidosEnfermero.Location = New System.Drawing.Point(333, 55)
        Me.txtApellidosEnfermero.Name = "txtApellidosEnfermero"
        Me.txtApellidosEnfermero.Size = New System.Drawing.Size(174, 20)
        Me.txtApellidosEnfermero.TabIndex = 13
        '
        'txtNombreEnfermero
        '
        Me.txtNombreEnfermero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEnfermero.Location = New System.Drawing.Point(83, 55)
        Me.txtNombreEnfermero.Name = "txtNombreEnfermero"
        Me.txtNombreEnfermero.Size = New System.Drawing.Size(146, 20)
        Me.txtNombreEnfermero.TabIndex = 12
        '
        'gprNacimientoAlumno
        '
        Me.gprNacimientoAlumno.Controls.Add(Me.cboNacionalidadPaciente)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblNacionalidadPaciente)
        Me.gprNacimientoAlumno.Controls.Add(Me.mskNacimiento)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblNacimiento)
        Me.gprNacimientoAlumno.Location = New System.Drawing.Point(6, 143)
        Me.gprNacimientoAlumno.Name = "gprNacimientoAlumno"
        Me.gprNacimientoAlumno.Size = New System.Drawing.Size(516, 57)
        Me.gprNacimientoAlumno.TabIndex = 15
        Me.gprNacimientoAlumno.TabStop = False
        Me.gprNacimientoAlumno.Text = "Nacimiento"
        '
        'cboNacionalidadPaciente
        '
        Me.cboNacionalidadPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNacionalidadPaciente.FormattingEnabled = True
        Me.cboNacionalidadPaciente.ItemHeight = 13
        Me.cboNacionalidadPaciente.Location = New System.Drawing.Point(336, 14)
        Me.cboNacionalidadPaciente.Name = "cboNacionalidadPaciente"
        Me.cboNacionalidadPaciente.Size = New System.Drawing.Size(165, 21)
        Me.cboNacionalidadPaciente.TabIndex = 18
        '
        'lblNacionalidadPaciente
        '
        Me.lblNacionalidadPaciente.AutoSize = True
        Me.lblNacionalidadPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNacionalidadPaciente.Location = New System.Drawing.Point(238, 19)
        Me.lblNacionalidadPaciente.Name = "lblNacionalidadPaciente"
        Me.lblNacionalidadPaciente.Size = New System.Drawing.Size(92, 16)
        Me.lblNacionalidadPaciente.TabIndex = 106
        Me.lblNacionalidadPaciente.Text = "Nacionalidad:"
        '
        'mskNacimiento
        '
        Me.mskNacimiento.Location = New System.Drawing.Point(132, 17)
        Me.mskNacimiento.Mask = "00/00/0000"
        Me.mskNacimiento.Name = "mskNacimiento"
        Me.mskNacimiento.Size = New System.Drawing.Size(90, 20)
        Me.mskNacimiento.TabIndex = 16
        Me.mskNacimiento.ValidatingType = GetType(Date)
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNacimiento.Location = New System.Drawing.Point(9, 19)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(117, 16)
        Me.lblNacimiento.TabIndex = 13
        Me.lblNacimiento.Text = "Fecha nacimiento:"
        '
        'grpDireccionPaciente
        '
        Me.grpDireccionPaciente.Controls.Add(Me.txtYEnfermero)
        Me.grpDireccionPaciente.Controls.Add(Me.lblYEnfermero)
        Me.grpDireccionPaciente.Controls.Add(Me.txtEntreEnfermero)
        Me.grpDireccionPaciente.Controls.Add(Me.lblEntreEnfermero)
        Me.grpDireccionPaciente.Controls.Add(Me.txtCalleEnfermero)
        Me.grpDireccionPaciente.Controls.Add(Me.lblCalleEnfermero)
        Me.grpDireccionPaciente.Location = New System.Drawing.Point(9, 367)
        Me.grpDireccionPaciente.Name = "grpDireccionPaciente"
        Me.grpDireccionPaciente.Size = New System.Drawing.Size(513, 60)
        Me.grpDireccionPaciente.TabIndex = 25
        Me.grpDireccionPaciente.TabStop = False
        Me.grpDireccionPaciente.Text = "Dirección"
        '
        'txtYEnfermero
        '
        Me.txtYEnfermero.Location = New System.Drawing.Point(398, 22)
        Me.txtYEnfermero.Name = "txtYEnfermero"
        Me.txtYEnfermero.Size = New System.Drawing.Size(80, 20)
        Me.txtYEnfermero.TabIndex = 32
        '
        'lblYEnfermero
        '
        Me.lblYEnfermero.AutoSize = True
        Me.lblYEnfermero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYEnfermero.Location = New System.Drawing.Point(352, 26)
        Me.lblYEnfermero.Name = "lblYEnfermero"
        Me.lblYEnfermero.Size = New System.Drawing.Size(20, 16)
        Me.lblYEnfermero.TabIndex = 107
        Me.lblYEnfermero.Text = "Y:"
        '
        'txtEntreEnfermero
        '
        Me.txtEntreEnfermero.Location = New System.Drawing.Point(241, 22)
        Me.txtEntreEnfermero.Name = "txtEntreEnfermero"
        Me.txtEntreEnfermero.Size = New System.Drawing.Size(80, 20)
        Me.txtEntreEnfermero.TabIndex = 31
        '
        'lblEntreEnfermero
        '
        Me.lblEntreEnfermero.AutoSize = True
        Me.lblEntreEnfermero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntreEnfermero.Location = New System.Drawing.Point(181, 26)
        Me.lblEntreEnfermero.Name = "lblEntreEnfermero"
        Me.lblEntreEnfermero.Size = New System.Drawing.Size(42, 16)
        Me.lblEntreEnfermero.TabIndex = 106
        Me.lblEntreEnfermero.Text = "Entre:"
        '
        'txtCalleEnfermero
        '
        Me.txtCalleEnfermero.Location = New System.Drawing.Point(50, 22)
        Me.txtCalleEnfermero.Name = "txtCalleEnfermero"
        Me.txtCalleEnfermero.Size = New System.Drawing.Size(99, 20)
        Me.txtCalleEnfermero.TabIndex = 29
        '
        'lblCalleEnfermero
        '
        Me.lblCalleEnfermero.AutoSize = True
        Me.lblCalleEnfermero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalleEnfermero.Location = New System.Drawing.Point(6, 26)
        Me.lblCalleEnfermero.Name = "lblCalleEnfermero"
        Me.lblCalleEnfermero.Size = New System.Drawing.Size(42, 16)
        Me.lblCalleEnfermero.TabIndex = 105
        Me.lblCalleEnfermero.Text = "Calle:"
        '
        'grpTelefono
        '
        Me.grpTelefono.Controls.Add(Me.grpDatosEmergencia)
        Me.grpTelefono.Controls.Add(Me.txtTelefonoPaciente)
        Me.grpTelefono.Controls.Add(Me.lblNumerodetelefono)
        Me.grpTelefono.Controls.Add(Me.mskCodigodearea)
        Me.grpTelefono.Controls.Add(Me.lblEmail)
        Me.grpTelefono.Controls.Add(Me.lblCodigodearea)
        Me.grpTelefono.Controls.Add(Me.txtEmail)
        Me.grpTelefono.Location = New System.Drawing.Point(6, 206)
        Me.grpTelefono.Name = "grpTelefono"
        Me.grpTelefono.Size = New System.Drawing.Size(516, 143)
        Me.grpTelefono.TabIndex = 19
        Me.grpTelefono.TabStop = False
        Me.grpTelefono.Text = "Datos de contacto"
        '
        'grpDatosEmergencia
        '
        Me.grpDatosEmergencia.Controls.Add(Me.txtTelefonoPacienteEmergencia)
        Me.grpDatosEmergencia.Controls.Add(Me.lbltxtTelefonoPacienteEmergencia)
        Me.grpDatosEmergencia.Controls.Add(Me.mskCodigodeareaEmergencia)
        Me.grpDatosEmergencia.Controls.Add(Me.lblCodigodeareaEmergencia)
        Me.grpDatosEmergencia.Location = New System.Drawing.Point(6, 69)
        Me.grpDatosEmergencia.Name = "grpDatosEmergencia"
        Me.grpDatosEmergencia.Size = New System.Drawing.Size(504, 68)
        Me.grpDatosEmergencia.TabIndex = 126
        Me.grpDatosEmergencia.TabStop = False
        Me.grpDatosEmergencia.Text = "Datos de Emergencia"
        '
        'txtTelefonoPacienteEmergencia
        '
        Me.txtTelefonoPacienteEmergencia.Location = New System.Drawing.Point(310, 25)
        Me.txtTelefonoPacienteEmergencia.Name = "txtTelefonoPacienteEmergencia"
        Me.txtTelefonoPacienteEmergencia.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefonoPacienteEmergencia.TabIndex = 22
        '
        'lbltxtTelefonoPacienteEmergencia
        '
        Me.lbltxtTelefonoPacienteEmergencia.AutoSize = True
        Me.lbltxtTelefonoPacienteEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbltxtTelefonoPacienteEmergencia.Location = New System.Drawing.Point(153, 25)
        Me.lbltxtTelefonoPacienteEmergencia.Name = "lbltxtTelefonoPacienteEmergencia"
        Me.lbltxtTelefonoPacienteEmergencia.Size = New System.Drawing.Size(154, 16)
        Me.lbltxtTelefonoPacienteEmergencia.TabIndex = 41
        Me.lbltxtTelefonoPacienteEmergencia.Text = "Número de Emergencia:"
        '
        'mskCodigodeareaEmergencia
        '
        Me.mskCodigodeareaEmergencia.Location = New System.Drawing.Point(101, 24)
        Me.mskCodigodeareaEmergencia.Mask = "(9999)"
        Me.mskCodigodeareaEmergencia.Name = "mskCodigodeareaEmergencia"
        Me.mskCodigodeareaEmergencia.Size = New System.Drawing.Size(42, 20)
        Me.mskCodigodeareaEmergencia.TabIndex = 21
        '
        'lblCodigodeareaEmergencia
        '
        Me.lblCodigodeareaEmergencia.AutoSize = True
        Me.lblCodigodeareaEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCodigodeareaEmergencia.Location = New System.Drawing.Point(9, 25)
        Me.lblCodigodeareaEmergencia.Name = "lblCodigodeareaEmergencia"
        Me.lblCodigodeareaEmergencia.Size = New System.Drawing.Size(71, 16)
        Me.lblCodigodeareaEmergencia.TabIndex = 2
        Me.lblCodigodeareaEmergencia.Text = "Cód. Área:"
        '
        'txtTelefonoPaciente
        '
        Me.txtTelefonoPaciente.Location = New System.Drawing.Point(316, 16)
        Me.txtTelefonoPaciente.Name = "txtTelefonoPaciente"
        Me.txtTelefonoPaciente.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefonoPaciente.TabIndex = 22
        '
        'lblNumerodetelefono
        '
        Me.lblNumerodetelefono.AutoSize = True
        Me.lblNumerodetelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumerodetelefono.Location = New System.Drawing.Point(251, 16)
        Me.lblNumerodetelefono.Name = "lblNumerodetelefono"
        Me.lblNumerodetelefono.Size = New System.Drawing.Size(59, 16)
        Me.lblNumerodetelefono.TabIndex = 41
        Me.lblNumerodetelefono.Text = "Número:"
        '
        'mskCodigodearea
        '
        Me.mskCodigodearea.Location = New System.Drawing.Point(156, 15)
        Me.mskCodigodearea.Mask = "(9999)"
        Me.mskCodigodearea.Name = "mskCodigodearea"
        Me.mskCodigodearea.Size = New System.Drawing.Size(42, 20)
        Me.mskCodigodearea.TabIndex = 21
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(60, 46)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(121, 16)
        Me.lblEmail.TabIndex = 117
        Me.lblEmail.Text = "Correo electrónico:"
        '
        'lblCodigodearea
        '
        Me.lblCodigodearea.AutoSize = True
        Me.lblCodigodearea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCodigodearea.Location = New System.Drawing.Point(79, 16)
        Me.lblCodigodearea.Name = "lblCodigodearea"
        Me.lblCodigodearea.Size = New System.Drawing.Size(71, 16)
        Me.lblCodigodearea.TabIndex = 2
        Me.lblCodigodearea.Text = "Cód. Área:"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(193, 46)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 20)
        Me.txtEmail.TabIndex = 23
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(59, 19)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(202, 20)
        Me.txtDNI.TabIndex = 11
        '
        'lblNumerodedocumento
        '
        Me.lblNumerodedocumento.AutoSize = True
        Me.lblNumerodedocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumerodedocumento.Location = New System.Drawing.Point(6, 20)
        Me.lblNumerodedocumento.Name = "lblNumerodedocumento"
        Me.lblNumerodedocumento.Size = New System.Drawing.Size(34, 16)
        Me.lblNumerodedocumento.TabIndex = 19
        Me.lblNumerodedocumento.Text = "DNI:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblApellidos.Location = New System.Drawing.Point(247, 59)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(72, 16)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Apellido/s:"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNombres.Location = New System.Drawing.Point(6, 59)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(71, 16)
        Me.lblNombres.TabIndex = 7
        Me.lblNombres.Text = "Nombre/s:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdAceptar.Location = New System.Drawing.Point(150, 453)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 107
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(318, 453)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 29)
        Me.cmdLimpiar.TabIndex = 128
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'frmAddEnfermero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 491)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grpDatosEnfermero)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddEnfermero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermero"
        Me.grpDatosEnfermero.ResumeLayout(False)
        Me.grpDatosEnfermero.PerformLayout()
        Me.gprNacimientoAlumno.ResumeLayout(False)
        Me.gprNacimientoAlumno.PerformLayout()
        Me.grpDireccionPaciente.ResumeLayout(False)
        Me.grpDireccionPaciente.PerformLayout()
        Me.grpTelefono.ResumeLayout(False)
        Me.grpTelefono.PerformLayout()
        Me.grpDatosEmergencia.ResumeLayout(False)
        Me.grpDatosEmergencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosEnfermero As System.Windows.Forms.GroupBox
    Friend WithEvents cboEstudios As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstudios As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents txtApellidosEnfermero As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreEnfermero As System.Windows.Forms.TextBox
    Friend WithEvents gprNacimientoAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents cboNacionalidadPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacionalidadPaciente As System.Windows.Forms.Label
    Friend WithEvents mskNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents grpDireccionPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents txtYEnfermero As System.Windows.Forms.TextBox
    Friend WithEvents lblYEnfermero As System.Windows.Forms.Label
    Friend WithEvents txtEntreEnfermero As System.Windows.Forms.TextBox
    Friend WithEvents lblEntreEnfermero As System.Windows.Forms.Label
    Friend WithEvents txtCalleEnfermero As System.Windows.Forms.TextBox
    Friend WithEvents lblCalleEnfermero As System.Windows.Forms.Label
    Friend WithEvents grpTelefono As System.Windows.Forms.GroupBox
    Friend WithEvents grpDatosEmergencia As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefonoPacienteEmergencia As System.Windows.Forms.TextBox
    Friend WithEvents lbltxtTelefonoPacienteEmergencia As System.Windows.Forms.Label
    Friend WithEvents mskCodigodeareaEmergencia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCodigodeareaEmergencia As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoPaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblNumerodetelefono As System.Windows.Forms.Label
    Friend WithEvents mskCodigodearea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblCodigodearea As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblNumerodedocumento As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
End Class
