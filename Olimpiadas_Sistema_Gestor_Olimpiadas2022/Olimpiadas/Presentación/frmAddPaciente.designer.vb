<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPaciente))
        Me.grpDatosPaciente = New System.Windows.Forms.GroupBox()
        Me.txtNombreAutopercibido = New System.Windows.Forms.TextBox()
        Me.lblNombreAutopercibido = New System.Windows.Forms.Label()
        Me.cboEstudios = New System.Windows.Forms.ComboBox()
        Me.lblEstudios = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtApellidosPacientes = New System.Windows.Forms.TextBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.gprNacimientoAlumno = New System.Windows.Forms.GroupBox()
        Me.cboReligion = New System.Windows.Forms.ComboBox()
        Me.lblReligion = New System.Windows.Forms.Label()
        Me.cboEtnia = New System.Windows.Forms.ComboBox()
        Me.lblEtnia = New System.Windows.Forms.Label()
        Me.cboNacionalidadPaciente = New System.Windows.Forms.ComboBox()
        Me.lblNacionalidadPaciente = New System.Windows.Forms.Label()
        Me.mskNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.grpDireccionPaciente = New System.Windows.Forms.GroupBox()
        Me.txtYPaciente = New System.Windows.Forms.TextBox()
        Me.lblYPaciente = New System.Windows.Forms.Label()
        Me.txtEntrePaciente = New System.Windows.Forms.TextBox()
        Me.lblEntrePaciente = New System.Windows.Forms.Label()
        Me.txtCallePaciente = New System.Windows.Forms.TextBox()
        Me.lblCallePaciente = New System.Windows.Forms.Label()
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
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.grpDatosPaciente.SuspendLayout()
        Me.gprNacimientoAlumno.SuspendLayout()
        Me.grpDireccionPaciente.SuspendLayout()
        Me.grpTelefono.SuspendLayout()
        Me.grpDatosEmergencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosPaciente
        '
        Me.grpDatosPaciente.Controls.Add(Me.txtNombreAutopercibido)
        Me.grpDatosPaciente.Controls.Add(Me.lblNombreAutopercibido)
        Me.grpDatosPaciente.Controls.Add(Me.cboEstudios)
        Me.grpDatosPaciente.Controls.Add(Me.lblEstudios)
        Me.grpDatosPaciente.Controls.Add(Me.cboSexo)
        Me.grpDatosPaciente.Controls.Add(Me.lblSexo)
        Me.grpDatosPaciente.Controls.Add(Me.txtApellidosPacientes)
        Me.grpDatosPaciente.Controls.Add(Me.txtNombrePaciente)
        Me.grpDatosPaciente.Controls.Add(Me.gprNacimientoAlumno)
        Me.grpDatosPaciente.Controls.Add(Me.grpDireccionPaciente)
        Me.grpDatosPaciente.Controls.Add(Me.grpTelefono)
        Me.grpDatosPaciente.Controls.Add(Me.txtDNI)
        Me.grpDatosPaciente.Controls.Add(Me.lblNumerodedocumento)
        Me.grpDatosPaciente.Controls.Add(Me.cboGenero)
        Me.grpDatosPaciente.Controls.Add(Me.lblApellidos)
        Me.grpDatosPaciente.Controls.Add(Me.lblGenero)
        Me.grpDatosPaciente.Controls.Add(Me.lblNombres)
        Me.grpDatosPaciente.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosPaciente.Name = "grpDatosPaciente"
        Me.grpDatosPaciente.Size = New System.Drawing.Size(527, 440)
        Me.grpDatosPaciente.TabIndex = 5
        Me.grpDatosPaciente.TabStop = False
        Me.grpDatosPaciente.Text = "Datos Paciente"
        '
        'txtNombreAutopercibido
        '
        Me.txtNombreAutopercibido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreAutopercibido.Location = New System.Drawing.Point(168, 83)
        Me.txtNombreAutopercibido.Name = "txtNombreAutopercibido"
        Me.txtNombreAutopercibido.Size = New System.Drawing.Size(168, 20)
        Me.txtNombreAutopercibido.TabIndex = 127
        '
        'lblNombreAutopercibido
        '
        Me.lblNombreAutopercibido.AutoSize = True
        Me.lblNombreAutopercibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNombreAutopercibido.Location = New System.Drawing.Point(6, 87)
        Me.lblNombreAutopercibido.Name = "lblNombreAutopercibido"
        Me.lblNombreAutopercibido.Size = New System.Drawing.Size(147, 16)
        Me.lblNombreAutopercibido.TabIndex = 126
        Me.lblNombreAutopercibido.Text = "Nombre Autopercibido:"
        '
        'cboEstudios
        '
        Me.cboEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstudios.FormattingEnabled = True
        Me.cboEstudios.Items.AddRange(New Object() {"Primario Incompleto", "Primario Completo", "Secundario Incompleto", "Secundario Completo"})
        Me.cboEstudios.Location = New System.Drawing.Point(333, 24)
        Me.cboEstudios.Name = "cboEstudios"
        Me.cboEstudios.Size = New System.Drawing.Size(174, 21)
        Me.cboEstudios.TabIndex = 125
        '
        'lblEstudios
        '
        Me.lblEstudios.AutoSize = True
        Me.lblEstudios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblEstudios.Location = New System.Drawing.Point(264, 29)
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
        Me.cboSexo.Location = New System.Drawing.Point(66, 116)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(163, 21)
        Me.cboSexo.TabIndex = 123
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSexo.Location = New System.Drawing.Point(6, 121)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(42, 16)
        Me.lblSexo.TabIndex = 122
        Me.lblSexo.Text = "Sexo:"
        '
        'txtApellidosPacientes
        '
        Me.txtApellidosPacientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidosPacientes.Location = New System.Drawing.Point(333, 55)
        Me.txtApellidosPacientes.Name = "txtApellidosPacientes"
        Me.txtApellidosPacientes.Size = New System.Drawing.Size(174, 20)
        Me.txtApellidosPacientes.TabIndex = 13
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombrePaciente.Location = New System.Drawing.Point(83, 55)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(146, 20)
        Me.txtNombrePaciente.TabIndex = 12
        '
        'gprNacimientoAlumno
        '
        Me.gprNacimientoAlumno.Controls.Add(Me.cboReligion)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblReligion)
        Me.gprNacimientoAlumno.Controls.Add(Me.cboEtnia)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblEtnia)
        Me.gprNacimientoAlumno.Controls.Add(Me.cboNacionalidadPaciente)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblNacionalidadPaciente)
        Me.gprNacimientoAlumno.Controls.Add(Me.mskNacimiento)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblNacimiento)
        Me.gprNacimientoAlumno.Location = New System.Drawing.Point(6, 143)
        Me.gprNacimientoAlumno.Name = "gprNacimientoAlumno"
        Me.gprNacimientoAlumno.Size = New System.Drawing.Size(513, 75)
        Me.gprNacimientoAlumno.TabIndex = 15
        Me.gprNacimientoAlumno.TabStop = False
        Me.gprNacimientoAlumno.Text = "Nacimiento"
        '
        'cboReligion
        '
        Me.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.ItemHeight = 13
        Me.cboReligion.Items.AddRange(New Object() {"Cristianismo", "Hinduismo", "Islam", "Jainismo"})
        Me.cboReligion.Location = New System.Drawing.Point(312, 45)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.Size = New System.Drawing.Size(189, 21)
        Me.cboReligion.TabIndex = 110
        '
        'lblReligion
        '
        Me.lblReligion.AutoSize = True
        Me.lblReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblReligion.Location = New System.Drawing.Point(239, 50)
        Me.lblReligion.Name = "lblReligion"
        Me.lblReligion.Size = New System.Drawing.Size(61, 16)
        Me.lblReligion.TabIndex = 109
        Me.lblReligion.Text = "Religion:"
        '
        'cboEtnia
        '
        Me.cboEtnia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEtnia.FormattingEnabled = True
        Me.cboEtnia.ItemHeight = 13
        Me.cboEtnia.Items.AddRange(New Object() {"Pueblo Aborigen", "Pueblo Caucásicos"})
        Me.cboEtnia.Location = New System.Drawing.Point(60, 45)
        Me.cboEtnia.Name = "cboEtnia"
        Me.cboEtnia.Size = New System.Drawing.Size(162, 21)
        Me.cboEtnia.TabIndex = 108
        '
        'lblEtnia
        '
        Me.lblEtnia.AutoSize = True
        Me.lblEtnia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblEtnia.Location = New System.Drawing.Point(9, 50)
        Me.lblEtnia.Name = "lblEtnia"
        Me.lblEtnia.Size = New System.Drawing.Size(41, 16)
        Me.lblEtnia.TabIndex = 107
        Me.lblEtnia.Text = "Etnia:"
        '
        'cboNacionalidadPaciente
        '
        Me.cboNacionalidadPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNacionalidadPaciente.FormattingEnabled = True
        Me.cboNacionalidadPaciente.ItemHeight = 13
        Me.cboNacionalidadPaciente.Items.AddRange(New Object() {"Argentina"})
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
        Me.grpDireccionPaciente.Controls.Add(Me.txtYPaciente)
        Me.grpDireccionPaciente.Controls.Add(Me.lblYPaciente)
        Me.grpDireccionPaciente.Controls.Add(Me.txtEntrePaciente)
        Me.grpDireccionPaciente.Controls.Add(Me.lblEntrePaciente)
        Me.grpDireccionPaciente.Controls.Add(Me.txtCallePaciente)
        Me.grpDireccionPaciente.Controls.Add(Me.lblCallePaciente)
        Me.grpDireccionPaciente.Location = New System.Drawing.Point(6, 373)
        Me.grpDireccionPaciente.Name = "grpDireccionPaciente"
        Me.grpDireccionPaciente.Size = New System.Drawing.Size(513, 60)
        Me.grpDireccionPaciente.TabIndex = 25
        Me.grpDireccionPaciente.TabStop = False
        Me.grpDireccionPaciente.Text = "Dirección"
        '
        'txtYPaciente
        '
        Me.txtYPaciente.Location = New System.Drawing.Point(398, 22)
        Me.txtYPaciente.Name = "txtYPaciente"
        Me.txtYPaciente.Size = New System.Drawing.Size(80, 20)
        Me.txtYPaciente.TabIndex = 32
        '
        'lblYPaciente
        '
        Me.lblYPaciente.AutoSize = True
        Me.lblYPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYPaciente.Location = New System.Drawing.Point(352, 26)
        Me.lblYPaciente.Name = "lblYPaciente"
        Me.lblYPaciente.Size = New System.Drawing.Size(20, 16)
        Me.lblYPaciente.TabIndex = 107
        Me.lblYPaciente.Text = "Y:"
        '
        'txtEntrePaciente
        '
        Me.txtEntrePaciente.Location = New System.Drawing.Point(241, 22)
        Me.txtEntrePaciente.Name = "txtEntrePaciente"
        Me.txtEntrePaciente.Size = New System.Drawing.Size(80, 20)
        Me.txtEntrePaciente.TabIndex = 31
        '
        'lblEntrePaciente
        '
        Me.lblEntrePaciente.AutoSize = True
        Me.lblEntrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrePaciente.Location = New System.Drawing.Point(181, 26)
        Me.lblEntrePaciente.Name = "lblEntrePaciente"
        Me.lblEntrePaciente.Size = New System.Drawing.Size(42, 16)
        Me.lblEntrePaciente.TabIndex = 106
        Me.lblEntrePaciente.Text = "Entre:"
        '
        'txtCallePaciente
        '
        Me.txtCallePaciente.Location = New System.Drawing.Point(50, 22)
        Me.txtCallePaciente.Name = "txtCallePaciente"
        Me.txtCallePaciente.Size = New System.Drawing.Size(99, 20)
        Me.txtCallePaciente.TabIndex = 29
        '
        'lblCallePaciente
        '
        Me.lblCallePaciente.AutoSize = True
        Me.lblCallePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallePaciente.Location = New System.Drawing.Point(6, 26)
        Me.lblCallePaciente.Name = "lblCallePaciente"
        Me.lblCallePaciente.Size = New System.Drawing.Size(42, 16)
        Me.lblCallePaciente.TabIndex = 105
        Me.lblCallePaciente.Text = "Calle:"
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
        Me.grpTelefono.Location = New System.Drawing.Point(6, 224)
        Me.grpTelefono.Name = "grpTelefono"
        Me.grpTelefono.Size = New System.Drawing.Size(513, 143)
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
        Me.grpDatosEmergencia.Size = New System.Drawing.Size(501, 68)
        Me.grpDatosEmergencia.TabIndex = 126
        Me.grpDatosEmergencia.TabStop = False
        Me.grpDatosEmergencia.Text = "Datos de Emergencia"
        '
        'txtTelefonoPacienteEmergencia
        '
        Me.txtTelefonoPacienteEmergencia.Location = New System.Drawing.Point(236, 21)
        Me.txtTelefonoPacienteEmergencia.Name = "txtTelefonoPacienteEmergencia"
        Me.txtTelefonoPacienteEmergencia.Size = New System.Drawing.Size(129, 20)
        Me.txtTelefonoPacienteEmergencia.TabIndex = 22
        '
        'lbltxtTelefonoPacienteEmergencia
        '
        Me.lbltxtTelefonoPacienteEmergencia.AutoSize = True
        Me.lbltxtTelefonoPacienteEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbltxtTelefonoPacienteEmergencia.Location = New System.Drawing.Point(153, 25)
        Me.lbltxtTelefonoPacienteEmergencia.Name = "lbltxtTelefonoPacienteEmergencia"
        Me.lbltxtTelefonoPacienteEmergencia.Size = New System.Drawing.Size(59, 16)
        Me.lbltxtTelefonoPacienteEmergencia.TabIndex = 41
        Me.lbltxtTelefonoPacienteEmergencia.Text = "Número:"
        '
        'mskCodigodeareaEmergencia
        '
        Me.mskCodigodeareaEmergencia.Location = New System.Drawing.Point(86, 21)
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
        Me.txtTelefonoPaciente.Location = New System.Drawing.Point(236, 21)
        Me.txtTelefonoPaciente.Name = "txtTelefonoPaciente"
        Me.txtTelefonoPaciente.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefonoPaciente.TabIndex = 22
        '
        'lblNumerodetelefono
        '
        Me.lblNumerodetelefono.AutoSize = True
        Me.lblNumerodetelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumerodetelefono.Location = New System.Drawing.Point(153, 25)
        Me.lblNumerodetelefono.Name = "lblNumerodetelefono"
        Me.lblNumerodetelefono.Size = New System.Drawing.Size(59, 16)
        Me.lblNumerodetelefono.TabIndex = 41
        Me.lblNumerodetelefono.Text = "Número:"
        '
        'mskCodigodearea
        '
        Me.mskCodigodearea.Location = New System.Drawing.Point(86, 21)
        Me.mskCodigodearea.Mask = "(9999)"
        Me.mskCodigodearea.Name = "mskCodigodearea"
        Me.mskCodigodearea.Size = New System.Drawing.Size(42, 20)
        Me.mskCodigodearea.TabIndex = 21
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(9, 50)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(121, 16)
        Me.lblEmail.TabIndex = 117
        Me.lblEmail.Text = "Correo electrónico:"
        '
        'lblCodigodearea
        '
        Me.lblCodigodearea.AutoSize = True
        Me.lblCodigodearea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCodigodearea.Location = New System.Drawing.Point(9, 25)
        Me.lblCodigodearea.Name = "lblCodigodearea"
        Me.lblCodigodearea.Size = New System.Drawing.Size(71, 16)
        Me.lblCodigodearea.TabIndex = 2
        Me.lblCodigodearea.Text = "Cód. Área:"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(156, 46)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 20)
        Me.txtEmail.TabIndex = 23
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(56, 25)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(202, 20)
        Me.txtDNI.TabIndex = 11
        '
        'lblNumerodedocumento
        '
        Me.lblNumerodedocumento.AutoSize = True
        Me.lblNumerodedocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumerodedocumento.Location = New System.Drawing.Point(6, 29)
        Me.lblNumerodedocumento.Name = "lblNumerodedocumento"
        Me.lblNumerodedocumento.Size = New System.Drawing.Size(34, 16)
        Me.lblNumerodedocumento.TabIndex = 19
        Me.lblNumerodedocumento.Text = "DNI:"
        '
        'cboGenero
        '
        Me.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"No binario", "Transgénero", "Transexual", "Trigénero", "Otro"})
        Me.cboGenero.Location = New System.Drawing.Point(333, 116)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(174, 21)
        Me.cboGenero.TabIndex = 14
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblApellidos.Location = New System.Drawing.Point(244, 59)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(72, 16)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Apellido/s:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGenero.Location = New System.Drawing.Point(250, 121)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(56, 16)
        Me.lblGenero.TabIndex = 9
        Me.lblGenero.Text = "Género:"
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
        'cmdLimpiar
        '
        Me.cmdLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(315, 458)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 29)
        Me.cmdLimpiar.TabIndex = 107
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdAceptar.Location = New System.Drawing.Point(150, 458)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 106
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'frmAddPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(550, 494)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grpDatosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente"
        Me.grpDatosPaciente.ResumeLayout(False)
        Me.grpDatosPaciente.PerformLayout()
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
    Friend WithEvents grpDatosPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents txtApellidosPacientes As System.Windows.Forms.TextBox
    Friend WithEvents cboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblNumerodedocumento As System.Windows.Forms.Label
    Friend WithEvents grpTelefono As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefonoPaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblNumerodetelefono As System.Windows.Forms.Label
    Friend WithEvents mskCodigodearea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCodigodearea As System.Windows.Forms.Label
    Friend WithEvents gprNacimientoAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents cboNacionalidadPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacionalidadPaciente As System.Windows.Forms.Label
    Friend WithEvents mskNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents grpDireccionPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents txtYPaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblYPaciente As System.Windows.Forms.Label
    Friend WithEvents txtEntrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblEntrePaciente As System.Windows.Forms.Label
    Friend WithEvents txtCallePaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblCallePaciente As System.Windows.Forms.Label
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cboEstudios As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstudios As System.Windows.Forms.Label
    Friend WithEvents grpDatosEmergencia As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefonoPacienteEmergencia As System.Windows.Forms.TextBox
    Friend WithEvents lbltxtTelefonoPacienteEmergencia As System.Windows.Forms.Label
    Friend WithEvents mskCodigodeareaEmergencia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCodigodeareaEmergencia As System.Windows.Forms.Label
    Friend WithEvents cboEtnia As System.Windows.Forms.ComboBox
    Friend WithEvents lblEtnia As System.Windows.Forms.Label
    Friend WithEvents cboReligion As System.Windows.Forms.ComboBox
    Friend WithEvents lblReligion As System.Windows.Forms.Label
    Friend WithEvents txtNombreAutopercibido As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreAutopercibido As System.Windows.Forms.Label

End Class
