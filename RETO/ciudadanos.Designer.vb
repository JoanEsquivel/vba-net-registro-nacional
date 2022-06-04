<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ciudadanos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ciudadanos))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Salir = New Guna.UI2.WinForms.Guna2Button()
        Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.FOTO = New System.Windows.Forms.PictureBox()
        Me.FECHANACIMIENTO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.IDDISTRITO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDCANTON = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IDPROVINCIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IDNACIONALIDAD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.IDNACIMIENTO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NOMBREMADRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IDENTIFICACIONMADRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NOMBREDELPADRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDENTIFICACIONPADRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDENTIFICACION = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CONOCIDOCOMO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NOMBRECOMPLETO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BUSCANDO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Salir)
        Me.Guna2GroupBox1.Controls.Add(Me.GUARDAR)
        Me.Guna2GroupBox1.Controls.Add(Me.FOTO)
        Me.Guna2GroupBox1.Controls.Add(Me.FECHANACIMIENTO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label14)
        Me.Guna2GroupBox1.Controls.Add(Me.IDDISTRITO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.IDCANTON)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.IDPROVINCIA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.IDNACIONALIDAD)
        Me.Guna2GroupBox1.Controls.Add(Me.Label12)
        Me.Guna2GroupBox1.Controls.Add(Me.IDNACIMIENTO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label13)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBREMADRE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.IDENTIFICACIONMADRE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBREDELPADRE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.IDENTIFICACIONPADRE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.IDENTIFICACION)
        Me.Guna2GroupBox1.Controls.Add(Me.CONOCIDOCOMO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRECOMPLETO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(136, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(813, 485)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "Ingrese un ciudadano"
        '
        'Salir
        '
        Me.Salir.BorderRadius = 5
        Me.Salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Location = New System.Drawing.Point(528, 301)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(89, 28)
        Me.Salir.TabIndex = 116
        Me.Salir.Text = "Salir"
        '
        'GUARDAR
        '
        Me.GUARDAR.BorderRadius = 5
        Me.GUARDAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GUARDAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GUARDAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GUARDAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GUARDAR.Enabled = False
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GUARDAR.ForeColor = System.Drawing.Color.White
        Me.GUARDAR.Image = CType(resources.GetObject("GUARDAR.Image"), System.Drawing.Image)
        Me.GUARDAR.Location = New System.Drawing.Point(433, 301)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(89, 28)
        Me.GUARDAR.TabIndex = 115
        Me.GUARDAR.Text = "Guardar"
        '
        'FOTO
        '
        Me.FOTO.Image = CType(resources.GetObject("FOTO.Image"), System.Drawing.Image)
        Me.FOTO.Location = New System.Drawing.Point(68, 330)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.Size = New System.Drawing.Size(216, 152)
        Me.FOTO.TabIndex = 114
        Me.FOTO.TabStop = False
        '
        'FECHANACIMIENTO
        '
        Me.FECHANACIMIENTO.BorderRadius = 5
        Me.FECHANACIMIENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FECHANACIMIENTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FECHANACIMIENTO.DefaultText = ""
        Me.FECHANACIMIENTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FECHANACIMIENTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FECHANACIMIENTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FECHANACIMIENTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FECHANACIMIENTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FECHANACIMIENTO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FECHANACIMIENTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FECHANACIMIENTO.Location = New System.Drawing.Point(165, 301)
        Me.FECHANACIMIENTO.Name = "FECHANACIMIENTO"
        Me.FECHANACIMIENTO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FECHANACIMIENTO.PlaceholderText = "Ej 25/05/2000"
        Me.FECHANACIMIENTO.SelectedText = ""
        Me.FECHANACIMIENTO.Size = New System.Drawing.Size(188, 23)
        Me.FECHANACIMIENTO.TabIndex = 113
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 305)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 15)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Fecha de nacimiento"
        '
        'IDDISTRITO
        '
        Me.IDDISTRITO.BorderRadius = 5
        Me.IDDISTRITO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDDISTRITO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDDISTRITO.DefaultText = ""
        Me.IDDISTRITO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDDISTRITO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDDISTRITO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDDISTRITO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDDISTRITO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDDISTRITO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDDISTRITO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDDISTRITO.Location = New System.Drawing.Point(556, 237)
        Me.IDDISTRITO.Name = "IDDISTRITO"
        Me.IDDISTRITO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDDISTRITO.PlaceholderText = "Ej San Pablo"
        Me.IDDISTRITO.SelectedText = ""
        Me.IDDISTRITO.Size = New System.Drawing.Size(188, 23)
        Me.IDDISTRITO.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Distrito"
        '
        'IDCANTON
        '
        Me.IDCANTON.BorderRadius = 5
        Me.IDCANTON.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDCANTON.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDCANTON.DefaultText = ""
        Me.IDCANTON.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDCANTON.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDCANTON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDCANTON.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDCANTON.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDCANTON.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDCANTON.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDCANTON.Location = New System.Drawing.Point(556, 202)
        Me.IDCANTON.Name = "IDCANTON"
        Me.IDCANTON.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDCANTON.PlaceholderText = "Ej Barva"
        Me.IDCANTON.SelectedText = ""
        Me.IDCANTON.Size = New System.Drawing.Size(188, 23)
        Me.IDCANTON.TabIndex = 109
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Canton"
        '
        'IDPROVINCIA
        '
        Me.IDPROVINCIA.BorderRadius = 5
        Me.IDPROVINCIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDPROVINCIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDPROVINCIA.DefaultText = ""
        Me.IDPROVINCIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDPROVINCIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDPROVINCIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDPROVINCIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDPROVINCIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDPROVINCIA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDPROVINCIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDPROVINCIA.Location = New System.Drawing.Point(556, 164)
        Me.IDPROVINCIA.Name = "IDPROVINCIA"
        Me.IDPROVINCIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDPROVINCIA.PlaceholderText = "Ej Heredia"
        Me.IDPROVINCIA.SelectedText = ""
        Me.IDPROVINCIA.Size = New System.Drawing.Size(188, 23)
        Me.IDPROVINCIA.TabIndex = 107
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(406, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Provincia"
        '
        'IDNACIONALIDAD
        '
        Me.IDNACIONALIDAD.BorderRadius = 5
        Me.IDNACIONALIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDNACIONALIDAD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDNACIONALIDAD.DefaultText = ""
        Me.IDNACIONALIDAD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDNACIONALIDAD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDNACIONALIDAD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDNACIONALIDAD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDNACIONALIDAD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDNACIONALIDAD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDNACIONALIDAD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDNACIONALIDAD.Location = New System.Drawing.Point(556, 124)
        Me.IDNACIONALIDAD.Name = "IDNACIONALIDAD"
        Me.IDNACIONALIDAD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDNACIONALIDAD.PlaceholderText = "Ej Costarricense"
        Me.IDNACIONALIDAD.SelectedText = ""
        Me.IDNACIONALIDAD.Size = New System.Drawing.Size(188, 23)
        Me.IDNACIONALIDAD.TabIndex = 105
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(406, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Nacionalidad"
        '
        'IDNACIMIENTO
        '
        Me.IDNACIMIENTO.BorderRadius = 5
        Me.IDNACIMIENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDNACIMIENTO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDNACIMIENTO.DefaultText = ""
        Me.IDNACIMIENTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDNACIMIENTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDNACIMIENTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDNACIMIENTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDNACIMIENTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDNACIMIENTO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDNACIMIENTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDNACIMIENTO.Location = New System.Drawing.Point(556, 88)
        Me.IDNACIMIENTO.Name = "IDNACIMIENTO"
        Me.IDNACIMIENTO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDNACIMIENTO.PlaceholderText = "Nombre Completo"
        Me.IDNACIMIENTO.SelectedText = ""
        Me.IDNACIMIENTO.Size = New System.Drawing.Size(188, 23)
        Me.IDNACIMIENTO.TabIndex = 103
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(406, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 15)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Lugar de nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 15)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Click sobre la imagen para actualizar"
        '
        'NOMBREMADRE
        '
        Me.NOMBREMADRE.BorderRadius = 5
        Me.NOMBREMADRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBREMADRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBREMADRE.DefaultText = ""
        Me.NOMBREMADRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBREMADRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBREMADRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBREMADRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBREMADRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBREMADRE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBREMADRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBREMADRE.Location = New System.Drawing.Point(165, 266)
        Me.NOMBREMADRE.Name = "NOMBREMADRE"
        Me.NOMBREMADRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBREMADRE.PlaceholderText = "ID Madre"
        Me.NOMBREMADRE.SelectedText = ""
        Me.NOMBREMADRE.Size = New System.Drawing.Size(188, 23)
        Me.NOMBREMADRE.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nombre de la madre"
        '
        'IDENTIFICACIONMADRE
        '
        Me.IDENTIFICACIONMADRE.BorderRadius = 5
        Me.IDENTIFICACIONMADRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDENTIFICACIONMADRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDENTIFICACIONMADRE.DefaultText = ""
        Me.IDENTIFICACIONMADRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDENTIFICACIONMADRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDENTIFICACIONMADRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDENTIFICACIONMADRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDENTIFICACIONMADRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDENTIFICACIONMADRE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDENTIFICACIONMADRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDENTIFICACIONMADRE.Location = New System.Drawing.Point(165, 237)
        Me.IDENTIFICACIONMADRE.Name = "IDENTIFICACIONMADRE"
        Me.IDENTIFICACIONMADRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDENTIFICACIONMADRE.PlaceholderText = "ID Madre"
        Me.IDENTIFICACIONMADRE.SelectedText = ""
        Me.IDENTIFICACIONMADRE.Size = New System.Drawing.Size(188, 23)
        Me.IDENTIFICACIONMADRE.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Identificacion de la madre"
        '
        'NOMBREDELPADRE
        '
        Me.NOMBREDELPADRE.BorderRadius = 5
        Me.NOMBREDELPADRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBREDELPADRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBREDELPADRE.DefaultText = ""
        Me.NOMBREDELPADRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBREDELPADRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBREDELPADRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBREDELPADRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBREDELPADRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBREDELPADRE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBREDELPADRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBREDELPADRE.Location = New System.Drawing.Point(165, 202)
        Me.NOMBREDELPADRE.Name = "NOMBREDELPADRE"
        Me.NOMBREDELPADRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBREDELPADRE.PlaceholderText = "Nombre del padre"
        Me.NOMBREDELPADRE.SelectedText = ""
        Me.NOMBREDELPADRE.Size = New System.Drawing.Size(188, 23)
        Me.NOMBREDELPADRE.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre del padre"
        '
        'IDENTIFICACIONPADRE
        '
        Me.IDENTIFICACIONPADRE.BorderRadius = 5
        Me.IDENTIFICACIONPADRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDENTIFICACIONPADRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDENTIFICACIONPADRE.DefaultText = ""
        Me.IDENTIFICACIONPADRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDENTIFICACIONPADRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDENTIFICACIONPADRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDENTIFICACIONPADRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDENTIFICACIONPADRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDENTIFICACIONPADRE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDENTIFICACIONPADRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDENTIFICACIONPADRE.Location = New System.Drawing.Point(165, 164)
        Me.IDENTIFICACIONPADRE.Name = "IDENTIFICACIONPADRE"
        Me.IDENTIFICACIONPADRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDENTIFICACIONPADRE.PlaceholderText = "ID Padre"
        Me.IDENTIFICACIONPADRE.SelectedText = ""
        Me.IDENTIFICACIONPADRE.Size = New System.Drawing.Size(188, 23)
        Me.IDENTIFICACIONPADRE.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Identificacion del padre"
        '
        'IDENTIFICACION
        '
        Me.IDENTIFICACION.BorderRadius = 5
        Me.IDENTIFICACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDENTIFICACION.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDENTIFICACION.DefaultText = ""
        Me.IDENTIFICACION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDENTIFICACION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDENTIFICACION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDENTIFICACION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDENTIFICACION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDENTIFICACION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDENTIFICACION.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDENTIFICACION.Location = New System.Drawing.Point(165, 59)
        Me.IDENTIFICACION.Name = "IDENTIFICACION"
        Me.IDENTIFICACION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDENTIFICACION.PlaceholderText = "ID"
        Me.IDENTIFICACION.SelectedText = ""
        Me.IDENTIFICACION.Size = New System.Drawing.Size(188, 23)
        Me.IDENTIFICACION.TabIndex = 8
        '
        'CONOCIDOCOMO
        '
        Me.CONOCIDOCOMO.BorderRadius = 5
        Me.CONOCIDOCOMO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CONOCIDOCOMO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONOCIDOCOMO.DefaultText = ""
        Me.CONOCIDOCOMO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONOCIDOCOMO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONOCIDOCOMO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONOCIDOCOMO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONOCIDOCOMO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONOCIDOCOMO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONOCIDOCOMO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONOCIDOCOMO.Location = New System.Drawing.Point(165, 124)
        Me.CONOCIDOCOMO.Name = "CONOCIDOCOMO"
        Me.CONOCIDOCOMO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONOCIDOCOMO.PlaceholderText = "Apodo"
        Me.CONOCIDOCOMO.SelectedText = ""
        Me.CONOCIDOCOMO.Size = New System.Drawing.Size(188, 23)
        Me.CONOCIDOCOMO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Conocido como"
        '
        'NOMBRECOMPLETO
        '
        Me.NOMBRECOMPLETO.BorderRadius = 5
        Me.NOMBRECOMPLETO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRECOMPLETO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRECOMPLETO.DefaultText = ""
        Me.NOMBRECOMPLETO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRECOMPLETO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRECOMPLETO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRECOMPLETO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRECOMPLETO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRECOMPLETO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRECOMPLETO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRECOMPLETO.Location = New System.Drawing.Point(165, 88)
        Me.NOMBRECOMPLETO.Name = "NOMBRECOMPLETO"
        Me.NOMBRECOMPLETO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRECOMPLETO.PlaceholderText = "Nombre Completo"
        Me.NOMBRECOMPLETO.SelectedText = ""
        Me.NOMBRECOMPLETO.Size = New System.Drawing.Size(188, 23)
        Me.NOMBRECOMPLETO.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificacion:"
        '
        'ABRIR
        '
        Me.ABRIR.Filter = "IMAGENES | *.jpg;*.mbp;*.jpeg"
        Me.ABRIR.Title = "Seleccionar Imagen"
        '
        'L
        '
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(967, 136)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(288, 248)
        Me.L.TabIndex = 8
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IDENTIFICACION"
        Me.ColumnHeader2.Width = 101
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "NOMBRE DEL CIUDADANO"
        Me.ColumnHeader3.Width = 185
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "FOTO"
        Me.ColumnHeader4.Width = 0
        '
        'BUSCANDO
        '
        Me.BUSCANDO.BorderRadius = 5
        Me.BUSCANDO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BUSCANDO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BUSCANDO.DefaultText = ""
        Me.BUSCANDO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BUSCANDO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BUSCANDO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BUSCANDO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BUSCANDO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BUSCANDO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BUSCANDO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BUSCANDO.Location = New System.Drawing.Point(1067, 101)
        Me.BUSCANDO.Name = "BUSCANDO"
        Me.BUSCANDO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BUSCANDO.PlaceholderText = "Digite el nombre del Ciudadano"
        Me.BUSCANDO.SelectedText = ""
        Me.BUSCANDO.Size = New System.Drawing.Size(188, 23)
        Me.BUSCANDO.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(964, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Nombre por buscar"
        '
        'ciudadanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 538)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.BUSCANDO)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "ciudadanos"
        Me.Text = "ciudadanos"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Salir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FOTO As PictureBox
    Friend WithEvents FECHANACIMIENTO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents IDDISTRITO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IDCANTON As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents IDPROVINCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents IDNACIONALIDAD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents IDNACIMIENTO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NOMBREMADRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IDENTIFICACIONMADRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NOMBREDELPADRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IDENTIFICACIONPADRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IDENTIFICACION As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CONOCIDOCOMO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NOMBRECOMPLETO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BUSCANDO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
End Class
