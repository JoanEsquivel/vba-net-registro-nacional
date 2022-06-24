<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class distritos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(distritos))
        Me.DISTRITOGP = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DISTRITO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PROVINCIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.CANTON = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBProvinciaDistrito = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CBProvinciaDistritos = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNProvinciaDistritos = New Guna.UI2.WinForms.Guna2Button()
        Me.btnElegirProvinciaDistrito = New Guna.UI2.WinForms.Guna2Button()
        Me.btnElegirCantonDistrito = New Guna.UI2.WinForms.Guna2Button()
        Me.GBCantonDistrito = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CBCantonDistrito = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNCantonDistrito = New Guna.UI2.WinForms.Guna2Button()
        Me.DISTRITOGP.SuspendLayout()
        Me.GBProvinciaDistrito.SuspendLayout()
        Me.GBCantonDistrito.SuspendLayout()
        Me.SuspendLayout()
        '
        'DISTRITOGP
        '
        Me.DISTRITOGP.Controls.Add(Me.btnElegirCantonDistrito)
        Me.DISTRITOGP.Controls.Add(Me.btnElegirProvinciaDistrito)
        Me.DISTRITOGP.Controls.Add(Me.DISTRITO)
        Me.DISTRITOGP.Controls.Add(Me.Label3)
        Me.DISTRITOGP.Controls.Add(Me.PROVINCIA)
        Me.DISTRITOGP.Controls.Add(Me.Label1)
        Me.DISTRITOGP.Controls.Add(Me.GUARDAR)
        Me.DISTRITOGP.Controls.Add(Me.CANTON)
        Me.DISTRITOGP.Controls.Add(Me.Label2)
        Me.DISTRITOGP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DISTRITOGP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DISTRITOGP.Location = New System.Drawing.Point(203, 48)
        Me.DISTRITOGP.Name = "DISTRITOGP"
        Me.DISTRITOGP.Size = New System.Drawing.Size(487, 266)
        Me.DISTRITOGP.TabIndex = 7
        Me.DISTRITOGP.Text = "Ingrese un distrito"
        '
        'DISTRITO
        '
        Me.DISTRITO.BorderRadius = 5
        Me.DISTRITO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DISTRITO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DISTRITO.DefaultText = ""
        Me.DISTRITO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DISTRITO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DISTRITO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DISTRITO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DISTRITO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DISTRITO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DISTRITO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DISTRITO.Location = New System.Drawing.Point(83, 154)
        Me.DISTRITO.Name = "DISTRITO"
        Me.DISTRITO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DISTRITO.PlaceholderText = "Ej: La Merced"
        Me.DISTRITO.SelectedText = ""
        Me.DISTRITO.Size = New System.Drawing.Size(188, 23)
        Me.DISTRITO.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Distrito"
        '
        'PROVINCIA
        '
        Me.PROVINCIA.BorderRadius = 5
        Me.PROVINCIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PROVINCIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PROVINCIA.DefaultText = ""
        Me.PROVINCIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PROVINCIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PROVINCIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PROVINCIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PROVINCIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PROVINCIA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PROVINCIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PROVINCIA.Location = New System.Drawing.Point(85, 76)
        Me.PROVINCIA.Name = "PROVINCIA"
        Me.PROVINCIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PROVINCIA.PlaceholderText = "Ej: 1"
        Me.PROVINCIA.SelectedText = ""
        Me.PROVINCIA.Size = New System.Drawing.Size(188, 23)
        Me.PROVINCIA.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Provincia"
        '
        'GUARDAR
        '
        Me.GUARDAR.BorderRadius = 5
        Me.GUARDAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GUARDAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GUARDAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GUARDAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GUARDAR.ForeColor = System.Drawing.Color.White
        Me.GUARDAR.Image = CType(resources.GetObject("GUARDAR.Image"), System.Drawing.Image)
        Me.GUARDAR.Location = New System.Drawing.Point(71, 183)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(89, 28)
        Me.GUARDAR.TabIndex = 115
        Me.GUARDAR.Text = "Guardar"
        '
        'CANTON
        '
        Me.CANTON.BorderRadius = 5
        Me.CANTON.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CANTON.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CANTON.DefaultText = ""
        Me.CANTON.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CANTON.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CANTON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CANTON.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CANTON.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CANTON.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CANTON.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CANTON.Location = New System.Drawing.Point(83, 113)
        Me.CANTON.Name = "CANTON"
        Me.CANTON.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CANTON.PlaceholderText = "Ej: 2"
        Me.CANTON.SelectedText = ""
        Me.CANTON.Size = New System.Drawing.Size(188, 23)
        Me.CANTON.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Canton:"
        '
        'GBProvinciaDistrito
        '
        Me.GBProvinciaDistrito.Controls.Add(Me.CBProvinciaDistritos)
        Me.GBProvinciaDistrito.Controls.Add(Me.BTNProvinciaDistritos)
        Me.GBProvinciaDistrito.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBProvinciaDistrito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GBProvinciaDistrito.Location = New System.Drawing.Point(12, 28)
        Me.GBProvinciaDistrito.Name = "GBProvinciaDistrito"
        Me.GBProvinciaDistrito.Size = New System.Drawing.Size(465, 168)
        Me.GBProvinciaDistrito.TabIndex = 120
        Me.GBProvinciaDistrito.Text = "Provincia"
        Me.GBProvinciaDistrito.Visible = False
        '
        'CBProvinciaDistritos
        '
        Me.CBProvinciaDistritos.BackColor = System.Drawing.Color.Transparent
        Me.CBProvinciaDistritos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBProvinciaDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvinciaDistritos.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBProvinciaDistritos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBProvinciaDistritos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBProvinciaDistritos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBProvinciaDistritos.ItemHeight = 30
        Me.CBProvinciaDistritos.Location = New System.Drawing.Point(80, 81)
        Me.CBProvinciaDistritos.Name = "CBProvinciaDistritos"
        Me.CBProvinciaDistritos.Size = New System.Drawing.Size(140, 36)
        Me.CBProvinciaDistritos.TabIndex = 2
        '
        'BTNProvinciaDistritos
        '
        Me.BTNProvinciaDistritos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNProvinciaDistritos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNProvinciaDistritos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNProvinciaDistritos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNProvinciaDistritos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNProvinciaDistritos.ForeColor = System.Drawing.Color.White
        Me.BTNProvinciaDistritos.Location = New System.Drawing.Point(244, 77)
        Me.BTNProvinciaDistritos.Name = "BTNProvinciaDistritos"
        Me.BTNProvinciaDistritos.Size = New System.Drawing.Size(180, 45)
        Me.BTNProvinciaDistritos.TabIndex = 1
        Me.BTNProvinciaDistritos.Text = "Elegir"
        '
        'btnElegirProvinciaDistrito
        '
        Me.btnElegirProvinciaDistrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnElegirProvinciaDistrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnElegirProvinciaDistrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnElegirProvinciaDistrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnElegirProvinciaDistrito.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnElegirProvinciaDistrito.ForeColor = System.Drawing.Color.White
        Me.btnElegirProvinciaDistrito.Location = New System.Drawing.Point(298, 75)
        Me.btnElegirProvinciaDistrito.Name = "btnElegirProvinciaDistrito"
        Me.btnElegirProvinciaDistrito.Size = New System.Drawing.Size(46, 24)
        Me.btnElegirProvinciaDistrito.TabIndex = 121
        Me.btnElegirProvinciaDistrito.Text = "..."
        '
        'btnElegirCantonDistrito
        '
        Me.btnElegirCantonDistrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnElegirCantonDistrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnElegirCantonDistrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnElegirCantonDistrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnElegirCantonDistrito.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnElegirCantonDistrito.ForeColor = System.Drawing.Color.White
        Me.btnElegirCantonDistrito.Location = New System.Drawing.Point(298, 114)
        Me.btnElegirCantonDistrito.Name = "btnElegirCantonDistrito"
        Me.btnElegirCantonDistrito.Size = New System.Drawing.Size(46, 24)
        Me.btnElegirCantonDistrito.TabIndex = 123
        Me.btnElegirCantonDistrito.Text = "..."
        '
        'GBCantonDistrito
        '
        Me.GBCantonDistrito.Controls.Add(Me.CBCantonDistrito)
        Me.GBCantonDistrito.Controls.Add(Me.BTNCantonDistrito)
        Me.GBCantonDistrito.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBCantonDistrito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GBCantonDistrito.Location = New System.Drawing.Point(12, 202)
        Me.GBCantonDistrito.Name = "GBCantonDistrito"
        Me.GBCantonDistrito.Size = New System.Drawing.Size(465, 168)
        Me.GBCantonDistrito.TabIndex = 122
        Me.GBCantonDistrito.Text = "Canton"
        Me.GBCantonDistrito.Visible = False
        '
        'CBCantonDistrito
        '
        Me.CBCantonDistrito.BackColor = System.Drawing.Color.Transparent
        Me.CBCantonDistrito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCantonDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCantonDistrito.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBCantonDistrito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBCantonDistrito.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCantonDistrito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBCantonDistrito.ItemHeight = 30
        Me.CBCantonDistrito.Location = New System.Drawing.Point(80, 81)
        Me.CBCantonDistrito.Name = "CBCantonDistrito"
        Me.CBCantonDistrito.Size = New System.Drawing.Size(140, 36)
        Me.CBCantonDistrito.TabIndex = 2
        '
        'BTNCantonDistrito
        '
        Me.BTNCantonDistrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNCantonDistrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNCantonDistrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCantonDistrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCantonDistrito.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCantonDistrito.ForeColor = System.Drawing.Color.White
        Me.BTNCantonDistrito.Location = New System.Drawing.Point(244, 77)
        Me.BTNCantonDistrito.Name = "BTNCantonDistrito"
        Me.BTNCantonDistrito.Size = New System.Drawing.Size(180, 45)
        Me.BTNCantonDistrito.TabIndex = 1
        Me.BTNCantonDistrito.Text = "Elegir"
        '
        'distritos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 408)
        Me.Controls.Add(Me.GBCantonDistrito)
        Me.Controls.Add(Me.GBProvinciaDistrito)
        Me.Controls.Add(Me.DISTRITOGP)
        Me.Name = "distritos"
        Me.Text = "distritos"
        Me.DISTRITOGP.ResumeLayout(False)
        Me.DISTRITOGP.PerformLayout()
        Me.GBProvinciaDistrito.ResumeLayout(False)
        Me.GBCantonDistrito.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DISTRITOGP As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CANTON As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DISTRITO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PROVINCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBProvinciaDistrito As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CBProvinciaDistritos As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNProvinciaDistritos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnElegirCantonDistrito As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnElegirProvinciaDistrito As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBCantonDistrito As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CBCantonDistrito As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNCantonDistrito As Guna.UI2.WinForms.Guna2Button
End Class
