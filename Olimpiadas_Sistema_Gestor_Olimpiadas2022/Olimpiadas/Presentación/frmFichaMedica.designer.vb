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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGrupoFactor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCuil = New System.Windows.Forms.MaskedTextBox()
        Me.lblCuil = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.gprNacimientoAlumno = New System.Windows.Forms.GroupBox()
        Me.cboNacionalidadAlumno = New System.Windows.Forms.ComboBox()
        Me.lblNacionalidadAlumno = New System.Windows.Forms.Label()
        Me.txtLugarnacimiento = New System.Windows.Forms.TextBox()
        Me.lblLugarnacimiento = New System.Windows.Forms.Label()
        Me.mskNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.grpDireccionAlumno = New System.Windows.Forms.GroupBox()
        Me.txtNumeroAlumno = New System.Windows.Forms.TextBox()
        Me.lblNumeroAlumno = New System.Windows.Forms.Label()
        Me.txtCodigoPostalAlumno = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostalAlumno = New System.Windows.Forms.Label()
        Me.txtDptoAlumno = New System.Windows.Forms.TextBox()
        Me.lblDptoAlumno = New System.Windows.Forms.Label()
        Me.txtPisoAlumno = New System.Windows.Forms.TextBox()
        Me.lblPisoAlumno = New System.Windows.Forms.Label()
        Me.txtYAlumno = New System.Windows.Forms.TextBox()
        Me.lblYAlumno = New System.Windows.Forms.Label()
        Me.txtEntreAlumno = New System.Windows.Forms.TextBox()
        Me.lblEntreAlumno = New System.Windows.Forms.Label()
        Me.txtCalleAlumno = New System.Windows.Forms.TextBox()
        Me.lblCalleAlumno = New System.Windows.Forms.Label()
        Me.cboLocalidadAlumno = New System.Windows.Forms.ComboBox()
        Me.lblLocalidadAlumno = New System.Windows.Forms.Label()
        Me.cboPartidoAlumno = New System.Windows.Forms.ComboBox()
        Me.lblPartidoAlumno = New System.Windows.Forms.Label()
        Me.grpTelefono = New System.Windows.Forms.GroupBox()
        Me.txtTelefonoAlumno = New System.Windows.Forms.TextBox()
        Me.lblNumerodetelefono = New System.Windows.Forms.Label()
        Me.lblEmailInstitucional = New System.Windows.Forms.Label()
        Me.mskCodigodearea = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailInstitucional = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCodigodearea = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblNumerodedocumento = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.lblTipodedocumento = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdImprimirFicha = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grpDatosalumno.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gprNacimientoAlumno.SuspendLayout()
        Me.grpDireccionAlumno.SuspendLayout()
        Me.grpTelefono.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosalumno
        '
        Me.grpDatosalumno.Controls.Add(Me.GroupBox1)
        Me.grpDatosalumno.Controls.Add(Me.Label1)
        Me.grpDatosalumno.Controls.Add(Me.TextBox1)
        Me.grpDatosalumno.Controls.Add(Me.txtCuil)
        Me.grpDatosalumno.Controls.Add(Me.lblCuil)
        Me.grpDatosalumno.Controls.Add(Me.txtApellidos)
        Me.grpDatosalumno.Controls.Add(Me.txtNombreAlumno)
        Me.grpDatosalumno.Controls.Add(Me.cboSexo)
        Me.grpDatosalumno.Controls.Add(Me.gprNacimientoAlumno)
        Me.grpDatosalumno.Controls.Add(Me.grpDireccionAlumno)
        Me.grpDatosalumno.Controls.Add(Me.grpTelefono)
        Me.grpDatosalumno.Controls.Add(Me.lblNumerodedocumento)
        Me.grpDatosalumno.Controls.Add(Me.cboTipoDocumento)
        Me.grpDatosalumno.Controls.Add(Me.lblTipodedocumento)
        Me.grpDatosalumno.Controls.Add(Me.lblApellidos)
        Me.grpDatosalumno.Controls.Add(Me.lblGenero)
        Me.grpDatosalumno.Controls.Add(Me.lblNombres)
        Me.grpDatosalumno.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosalumno.Name = "grpDatosalumno"
        Me.grpDatosalumno.Size = New System.Drawing.Size(854, 406)
        Me.grpDatosalumno.TabIndex = 5
        Me.grpDatosalumno.TabStop = False
        Me.grpDatosalumno.Text = "Datos Paciente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.lblGrupoFactor)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(841, 99)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Médicos"
        '
        'lblGrupoFactor
        '
        Me.lblGrupoFactor.AutoSize = True
        Me.lblGrupoFactor.Location = New System.Drawing.Point(9, 16)
        Me.lblGrupoFactor.Name = "lblGrupoFactor"
        Me.lblGrupoFactor.Size = New System.Drawing.Size(77, 13)
        Me.lblGrupoFactor.TabIndex = 0
        Me.lblGrupoFactor.Text = "Grupo y Factor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(599, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Género:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(414, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 122
        '
        'txtCuil
        '
        Me.txtCuil.Location = New System.Drawing.Point(55, 28)
        Me.txtCuil.Mask = "00-90000000-0"
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(90, 20)
        Me.txtCuil.TabIndex = 9
        '
        'lblCuil
        '
        Me.lblCuil.AutoSize = True
        Me.lblCuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCuil.Location = New System.Drawing.Point(6, 29)
        Me.lblCuil.Name = "lblCuil"
        Me.lblCuil.Size = New System.Drawing.Size(43, 16)
        Me.lblCuil.TabIndex = 121
        Me.lblCuil.Text = "CUIL: "
        '
        'txtApellidos
        '
        Me.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidos.Location = New System.Drawing.Point(392, 59)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(263, 20)
        Me.txtApellidos.TabIndex = 13
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreAlumno.Location = New System.Drawing.Point(79, 59)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(239, 20)
        Me.txtNombreAlumno.TabIndex = 12
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cboSexo.Location = New System.Drawing.Point(661, 27)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(144, 21)
        Me.cboSexo.TabIndex = 14
        '
        'gprNacimientoAlumno
        '
        Me.gprNacimientoAlumno.Controls.Add(Me.cboNacionalidadAlumno)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblNacionalidadAlumno)
        Me.gprNacimientoAlumno.Controls.Add(Me.txtLugarnacimiento)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblLugarnacimiento)
        Me.gprNacimientoAlumno.Controls.Add(Me.mskNacimiento)
        Me.gprNacimientoAlumno.Controls.Add(Me.lblNacimiento)
        Me.gprNacimientoAlumno.Location = New System.Drawing.Point(7, 92)
        Me.gprNacimientoAlumno.Name = "gprNacimientoAlumno"
        Me.gprNacimientoAlumno.Size = New System.Drawing.Size(841, 49)
        Me.gprNacimientoAlumno.TabIndex = 15
        Me.gprNacimientoAlumno.TabStop = False
        Me.gprNacimientoAlumno.Text = "Nacimiento"
        '
        'cboNacionalidadAlumno
        '
        Me.cboNacionalidadAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNacionalidadAlumno.FormattingEnabled = True
        Me.cboNacionalidadAlumno.ItemHeight = 13
        Me.cboNacionalidadAlumno.Location = New System.Drawing.Point(594, 17)
        Me.cboNacionalidadAlumno.Name = "cboNacionalidadAlumno"
        Me.cboNacionalidadAlumno.Size = New System.Drawing.Size(165, 21)
        Me.cboNacionalidadAlumno.TabIndex = 18
        '
        'lblNacionalidadAlumno
        '
        Me.lblNacionalidadAlumno.AutoSize = True
        Me.lblNacionalidadAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNacionalidadAlumno.Location = New System.Drawing.Point(498, 19)
        Me.lblNacionalidadAlumno.Name = "lblNacionalidadAlumno"
        Me.lblNacionalidadAlumno.Size = New System.Drawing.Size(92, 16)
        Me.lblNacionalidadAlumno.TabIndex = 106
        Me.lblNacionalidadAlumno.Text = "Nacionalidad:"
        '
        'txtLugarnacimiento
        '
        Me.txtLugarnacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugarnacimiento.Location = New System.Drawing.Point(293, 18)
        Me.txtLugarnacimiento.Name = "txtLugarnacimiento"
        Me.txtLugarnacimiento.Size = New System.Drawing.Size(182, 20)
        Me.txtLugarnacimiento.TabIndex = 17
        '
        'lblLugarnacimiento
        '
        Me.lblLugarnacimiento.AutoSize = True
        Me.lblLugarnacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblLugarnacimiento.Location = New System.Drawing.Point(248, 19)
        Me.lblLugarnacimiento.Name = "lblLugarnacimiento"
        Me.lblLugarnacimiento.Size = New System.Drawing.Size(45, 16)
        Me.lblLugarnacimiento.TabIndex = 17
        Me.lblLugarnacimiento.Text = "Lugar:"
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
        'grpDireccionAlumno
        '
        Me.grpDireccionAlumno.Controls.Add(Me.txtNumeroAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblNumeroAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.txtCodigoPostalAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblCodigoPostalAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.txtDptoAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblDptoAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.txtPisoAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblPisoAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.txtYAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblYAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.txtEntreAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblEntreAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.txtCalleAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblCalleAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.cboLocalidadAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblLocalidadAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.cboPartidoAlumno)
        Me.grpDireccionAlumno.Controls.Add(Me.lblPartidoAlumno)
        Me.grpDireccionAlumno.Location = New System.Drawing.Point(6, 211)
        Me.grpDireccionAlumno.Name = "grpDireccionAlumno"
        Me.grpDireccionAlumno.Size = New System.Drawing.Size(842, 84)
        Me.grpDireccionAlumno.TabIndex = 25
        Me.grpDireccionAlumno.TabStop = False
        Me.grpDireccionAlumno.Text = "Dirección"
        '
        'txtNumeroAlumno
        '
        Me.txtNumeroAlumno.Location = New System.Drawing.Point(206, 51)
        Me.txtNumeroAlumno.Name = "txtNumeroAlumno"
        Me.txtNumeroAlumno.Size = New System.Drawing.Size(55, 20)
        Me.txtNumeroAlumno.TabIndex = 30
        '
        'lblNumeroAlumno
        '
        Me.lblNumeroAlumno.AutoSize = True
        Me.lblNumeroAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroAlumno.Location = New System.Drawing.Point(171, 52)
        Me.lblNumeroAlumno.Name = "lblNumeroAlumno"
        Me.lblNumeroAlumno.Size = New System.Drawing.Size(33, 16)
        Me.lblNumeroAlumno.TabIndex = 120
        Me.lblNumeroAlumno.Text = "Nro:"
        '
        'txtCodigoPostalAlumno
        '
        Me.txtCodigoPostalAlumno.Location = New System.Drawing.Point(590, 20)
        Me.txtCodigoPostalAlumno.Name = "txtCodigoPostalAlumno"
        Me.txtCodigoPostalAlumno.Size = New System.Drawing.Size(71, 20)
        Me.txtCodigoPostalAlumno.TabIndex = 28
        '
        'lblCodigoPostalAlumno
        '
        Me.lblCodigoPostalAlumno.AutoSize = True
        Me.lblCodigoPostalAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostalAlumno.Location = New System.Drawing.Point(558, 21)
        Me.lblCodigoPostalAlumno.Name = "lblCodigoPostalAlumno"
        Me.lblCodigoPostalAlumno.Size = New System.Drawing.Size(29, 16)
        Me.lblCodigoPostalAlumno.TabIndex = 119
        Me.lblCodigoPostalAlumno.Text = "CP:"
        '
        'txtDptoAlumno
        '
        Me.txtDptoAlumno.Location = New System.Drawing.Point(707, 51)
        Me.txtDptoAlumno.Name = "txtDptoAlumno"
        Me.txtDptoAlumno.Size = New System.Drawing.Size(52, 20)
        Me.txtDptoAlumno.TabIndex = 34
        '
        'lblDptoAlumno
        '
        Me.lblDptoAlumno.AutoSize = True
        Me.lblDptoAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDptoAlumno.Location = New System.Drawing.Point(661, 52)
        Me.lblDptoAlumno.Name = "lblDptoAlumno"
        Me.lblDptoAlumno.Size = New System.Drawing.Size(40, 16)
        Me.lblDptoAlumno.TabIndex = 116
        Me.lblDptoAlumno.Text = "Dpto:"
        '
        'txtPisoAlumno
        '
        Me.txtPisoAlumno.Location = New System.Drawing.Point(590, 51)
        Me.txtPisoAlumno.Name = "txtPisoAlumno"
        Me.txtPisoAlumno.Size = New System.Drawing.Size(52, 20)
        Me.txtPisoAlumno.TabIndex = 33
        '
        'lblPisoAlumno
        '
        Me.lblPisoAlumno.AutoSize = True
        Me.lblPisoAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPisoAlumno.Location = New System.Drawing.Point(548, 52)
        Me.lblPisoAlumno.Name = "lblPisoAlumno"
        Me.lblPisoAlumno.Size = New System.Drawing.Size(38, 16)
        Me.lblPisoAlumno.TabIndex = 112
        Me.lblPisoAlumno.Text = "Piso:"
        '
        'txtYAlumno
        '
        Me.txtYAlumno.Location = New System.Drawing.Point(459, 51)
        Me.txtYAlumno.Name = "txtYAlumno"
        Me.txtYAlumno.Size = New System.Drawing.Size(80, 20)
        Me.txtYAlumno.TabIndex = 32
        '
        'lblYAlumno
        '
        Me.lblYAlumno.AutoSize = True
        Me.lblYAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYAlumno.Location = New System.Drawing.Point(433, 49)
        Me.lblYAlumno.Name = "lblYAlumno"
        Me.lblYAlumno.Size = New System.Drawing.Size(20, 16)
        Me.lblYAlumno.TabIndex = 107
        Me.lblYAlumno.Text = "Y:"
        '
        'txtEntreAlumno
        '
        Me.txtEntreAlumno.Location = New System.Drawing.Point(346, 51)
        Me.txtEntreAlumno.Name = "txtEntreAlumno"
        Me.txtEntreAlumno.Size = New System.Drawing.Size(80, 20)
        Me.txtEntreAlumno.TabIndex = 31
        '
        'lblEntreAlumno
        '
        Me.lblEntreAlumno.AutoSize = True
        Me.lblEntreAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntreAlumno.Location = New System.Drawing.Point(271, 52)
        Me.lblEntreAlumno.Name = "lblEntreAlumno"
        Me.lblEntreAlumno.Size = New System.Drawing.Size(42, 16)
        Me.lblEntreAlumno.TabIndex = 106
        Me.lblEntreAlumno.Text = "Entre:"
        '
        'txtCalleAlumno
        '
        Me.txtCalleAlumno.Location = New System.Drawing.Point(66, 51)
        Me.txtCalleAlumno.Name = "txtCalleAlumno"
        Me.txtCalleAlumno.Size = New System.Drawing.Size(99, 20)
        Me.txtCalleAlumno.TabIndex = 29
        '
        'lblCalleAlumno
        '
        Me.lblCalleAlumno.AutoSize = True
        Me.lblCalleAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalleAlumno.Location = New System.Drawing.Point(6, 52)
        Me.lblCalleAlumno.Name = "lblCalleAlumno"
        Me.lblCalleAlumno.Size = New System.Drawing.Size(42, 16)
        Me.lblCalleAlumno.TabIndex = 105
        Me.lblCalleAlumno.Text = "Calle:"
        '
        'cboLocalidadAlumno
        '
        Me.cboLocalidadAlumno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLocalidadAlumno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocalidadAlumno.FormattingEnabled = True
        Me.cboLocalidadAlumno.Location = New System.Drawing.Point(346, 20)
        Me.cboLocalidadAlumno.Name = "cboLocalidadAlumno"
        Me.cboLocalidadAlumno.Size = New System.Drawing.Size(193, 21)
        Me.cboLocalidadAlumno.Sorted = True
        Me.cboLocalidadAlumno.TabIndex = 27
        '
        'lblLocalidadAlumno
        '
        Me.lblLocalidadAlumno.AutoSize = True
        Me.lblLocalidadAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidadAlumno.Location = New System.Drawing.Point(271, 22)
        Me.lblLocalidadAlumno.Name = "lblLocalidadAlumno"
        Me.lblLocalidadAlumno.Size = New System.Drawing.Size(71, 16)
        Me.lblLocalidadAlumno.TabIndex = 104
        Me.lblLocalidadAlumno.Text = "Localidad:"
        '
        'cboPartidoAlumno
        '
        Me.cboPartidoAlumno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPartidoAlumno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPartidoAlumno.FormattingEnabled = True
        Me.cboPartidoAlumno.ItemHeight = 13
        Me.cboPartidoAlumno.Location = New System.Drawing.Point(66, 19)
        Me.cboPartidoAlumno.Name = "cboPartidoAlumno"
        Me.cboPartidoAlumno.Size = New System.Drawing.Size(195, 21)
        Me.cboPartidoAlumno.Sorted = True
        Me.cboPartidoAlumno.TabIndex = 26
        '
        'lblPartidoAlumno
        '
        Me.lblPartidoAlumno.AutoSize = True
        Me.lblPartidoAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartidoAlumno.Location = New System.Drawing.Point(6, 19)
        Me.lblPartidoAlumno.Name = "lblPartidoAlumno"
        Me.lblPartidoAlumno.Size = New System.Drawing.Size(54, 16)
        Me.lblPartidoAlumno.TabIndex = 103
        Me.lblPartidoAlumno.Text = "Partido:"
        '
        'grpTelefono
        '
        Me.grpTelefono.Controls.Add(Me.txtTelefonoAlumno)
        Me.grpTelefono.Controls.Add(Me.lblNumerodetelefono)
        Me.grpTelefono.Controls.Add(Me.lblEmailInstitucional)
        Me.grpTelefono.Controls.Add(Me.mskCodigodearea)
        Me.grpTelefono.Controls.Add(Me.txtEmailInstitucional)
        Me.grpTelefono.Controls.Add(Me.lblTipo)
        Me.grpTelefono.Controls.Add(Me.lblEmail)
        Me.grpTelefono.Controls.Add(Me.lblCodigodearea)
        Me.grpTelefono.Controls.Add(Me.txtEmail)
        Me.grpTelefono.Controls.Add(Me.cboTipo)
        Me.grpTelefono.Location = New System.Drawing.Point(7, 142)
        Me.grpTelefono.Name = "grpTelefono"
        Me.grpTelefono.Size = New System.Drawing.Size(841, 68)
        Me.grpTelefono.TabIndex = 19
        Me.grpTelefono.TabStop = False
        Me.grpTelefono.Text = "Datos de contacto"
        '
        'txtTelefonoAlumno
        '
        Me.txtTelefonoAlumno.Location = New System.Drawing.Point(322, 28)
        Me.txtTelefonoAlumno.Name = "txtTelefonoAlumno"
        Me.txtTelefonoAlumno.Size = New System.Drawing.Size(93, 20)
        Me.txtTelefonoAlumno.TabIndex = 22
        '
        'lblNumerodetelefono
        '
        Me.lblNumerodetelefono.AutoSize = True
        Me.lblNumerodetelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumerodetelefono.Location = New System.Drawing.Point(261, 30)
        Me.lblNumerodetelefono.Name = "lblNumerodetelefono"
        Me.lblNumerodetelefono.Size = New System.Drawing.Size(59, 16)
        Me.lblNumerodetelefono.TabIndex = 41
        Me.lblNumerodetelefono.Text = "Número:"
        '
        'lblEmailInstitucional
        '
        Me.lblEmailInstitucional.AutoSize = True
        Me.lblEmailInstitucional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailInstitucional.Location = New System.Drawing.Point(467, 41)
        Me.lblEmailInstitucional.Name = "lblEmailInstitucional"
        Me.lblEmailInstitucional.Size = New System.Drawing.Size(122, 16)
        Me.lblEmailInstitucional.TabIndex = 119
        Me.lblEmailInstitucional.Text = "Correo Electrónico:"
        '
        'mskCodigodearea
        '
        Me.mskCodigodearea.Location = New System.Drawing.Point(200, 29)
        Me.mskCodigodearea.Mask = "(9999)"
        Me.mskCodigodearea.Name = "mskCodigodearea"
        Me.mskCodigodearea.Size = New System.Drawing.Size(42, 20)
        Me.mskCodigodearea.TabIndex = 21
        '
        'txtEmailInstitucional
        '
        Me.txtEmailInstitucional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmailInstitucional.Location = New System.Drawing.Point(592, 39)
        Me.txtEmailInstitucional.Name = "txtEmailInstitucional"
        Me.txtEmailInstitucional.Size = New System.Drawing.Size(237, 20)
        Me.txtEmailInstitucional.TabIndex = 24
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTipo.Location = New System.Drawing.Point(8, 29)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 16)
        Me.lblTipo.TabIndex = 39
        Me.lblTipo.Text = "Tipo:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(468, 16)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(121, 16)
        Me.lblEmail.TabIndex = 117
        Me.lblEmail.Text = "Correo electrónico:"
        '
        'lblCodigodearea
        '
        Me.lblCodigodearea.AutoSize = True
        Me.lblCodigodearea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCodigodearea.Location = New System.Drawing.Point(131, 30)
        Me.lblCodigodearea.Name = "lblCodigodearea"
        Me.lblCodigodearea.Size = New System.Drawing.Size(71, 16)
        Me.lblCodigodearea.TabIndex = 2
        Me.lblCodigodearea.Text = "Cód. Área:"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(592, 14)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(237, 20)
        Me.txtEmail.TabIndex = 23
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"MOVIL", "FIJO"})
        Me.cboTipo.Location = New System.Drawing.Point(49, 28)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(64, 21)
        Me.cboTipo.TabIndex = 20
        '
        'lblNumerodedocumento
        '
        Me.lblNumerodedocumento.AutoSize = True
        Me.lblNumerodedocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumerodedocumento.Location = New System.Drawing.Point(349, 29)
        Me.lblNumerodedocumento.Name = "lblNumerodedocumento"
        Me.lblNumerodedocumento.Size = New System.Drawing.Size(59, 16)
        Me.lblNumerodedocumento.TabIndex = 19
        Me.lblNumerodedocumento.Text = "Número:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(235, 28)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(102, 21)
        Me.cboTipoDocumento.TabIndex = 10
        '
        'lblTipodedocumento
        '
        Me.lblTipodedocumento.AutoSize = True
        Me.lblTipodedocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTipodedocumento.Location = New System.Drawing.Point(162, 29)
        Me.lblTipodedocumento.Name = "lblTipodedocumento"
        Me.lblTipodedocumento.Size = New System.Drawing.Size(67, 16)
        Me.lblTipodedocumento.TabIndex = 17
        Me.lblTipodedocumento.Text = "Tipo Doc:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblApellidos.Location = New System.Drawing.Point(321, 61)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(72, 16)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Apellido/s:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGenero.Location = New System.Drawing.Point(536, 29)
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
        Me.cmdLimpiar.Location = New System.Drawing.Point(341, 424)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(224, 424)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 29)
        Me.cmdAceptar.TabIndex = 106
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmdImprimirFicha
        '
        Me.cmdImprimirFicha.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdImprimirFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdImprimirFicha.Location = New System.Drawing.Point(454, 424)
        Me.cmdImprimirFicha.Name = "cmdImprimirFicha"
        Me.cmdImprimirFicha.Size = New System.Drawing.Size(104, 29)
        Me.cmdImprimirFicha.TabIndex = 109
        Me.cmdImprimirFicha.Text = "Imprimir Ficha"
        Me.cmdImprimirFicha.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 1
        '
        'frmFichaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(876, 461)
        Me.Controls.Add(Me.cmdImprimirFicha)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.grpDatosalumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFichaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha Médica"
        Me.grpDatosalumno.ResumeLayout(False)
        Me.grpDatosalumno.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gprNacimientoAlumno.ResumeLayout(False)
        Me.gprNacimientoAlumno.PerformLayout()
        Me.grpDireccionAlumno.ResumeLayout(False)
        Me.grpDireccionAlumno.PerformLayout()
        Me.grpTelefono.ResumeLayout(False)
        Me.grpTelefono.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosalumno As System.Windows.Forms.GroupBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents txtNombreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumerodedocumento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipodedocumento As System.Windows.Forms.Label
    Friend WithEvents grpTelefono As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefonoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblNumerodetelefono As System.Windows.Forms.Label
    Friend WithEvents mskCodigodearea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblCodigodearea As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents gprNacimientoAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents cboNacionalidadAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacionalidadAlumno As System.Windows.Forms.Label
    Friend WithEvents txtLugarnacimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblLugarnacimiento As System.Windows.Forms.Label
    Friend WithEvents mskNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents grpDireccionAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroAlumno As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostalAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoPostalAlumno As System.Windows.Forms.Label
    Friend WithEvents txtDptoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblDptoAlumno As System.Windows.Forms.Label
    Friend WithEvents txtPisoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblPisoAlumno As System.Windows.Forms.Label
    Friend WithEvents txtYAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblYAlumno As System.Windows.Forms.Label
    Friend WithEvents txtEntreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblEntreAlumno As System.Windows.Forms.Label
    Friend WithEvents txtCalleAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblCalleAlumno As System.Windows.Forms.Label
    Friend WithEvents cboLocalidadAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalidadAlumno As System.Windows.Forms.Label
    Friend WithEvents cboPartidoAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents lblPartidoAlumno As System.Windows.Forms.Label
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdImprimirFicha As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailInstitucional As System.Windows.Forms.Label
    Friend WithEvents txtEmailInstitucional As System.Windows.Forms.TextBox
    Friend WithEvents lblCuil As System.Windows.Forms.Label
    Friend WithEvents txtCuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrupoFactor As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
