<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cantones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cantones))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GBPROVINCIACANTON = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CBProvinciaCantones = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNProvinciaCantones = New Guna.UI2.WinForms.Guna2Button()
        Me.btnElegirProvinciaCantones = New Guna.UI2.WinForms.Guna2Button()
        Me.IDPROVINCIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.CANTON = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GBPROVINCIACANTON.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.GBPROVINCIACANTON)
        Me.Guna2GroupBox1.Controls.Add(Me.btnElegirProvinciaCantones)
        Me.Guna2GroupBox1.Controls.Add(Me.IDPROVINCIA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.GUARDAR)
        Me.Guna2GroupBox1.Controls.Add(Me.CANTON)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(609, 284)
        Me.Guna2GroupBox1.TabIndex = 6
        Me.Guna2GroupBox1.Text = "Ingrese un canton"
        '
        'GBPROVINCIACANTON
        '
        Me.GBPROVINCIACANTON.Controls.Add(Me.CBProvinciaCantones)
        Me.GBPROVINCIACANTON.Controls.Add(Me.BTNProvinciaCantones)
        Me.GBPROVINCIACANTON.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBPROVINCIACANTON.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.GBPROVINCIACANTON.Location = New System.Drawing.Point(42, 18)
        Me.GBPROVINCIACANTON.Name = "GBPROVINCIACANTON"
        Me.GBPROVINCIACANTON.Size = New System.Drawing.Size(465, 168)
        Me.GBPROVINCIACANTON.TabIndex = 119
        Me.GBPROVINCIACANTON.Text = "Provincia"
        Me.GBPROVINCIACANTON.Visible = False
        '
        'CBProvinciaCantones
        '
        Me.CBProvinciaCantones.BackColor = System.Drawing.Color.Transparent
        Me.CBProvinciaCantones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBProvinciaCantones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvinciaCantones.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBProvinciaCantones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBProvinciaCantones.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBProvinciaCantones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBProvinciaCantones.ItemHeight = 30
        Me.CBProvinciaCantones.Location = New System.Drawing.Point(80, 81)
        Me.CBProvinciaCantones.Name = "CBProvinciaCantones"
        Me.CBProvinciaCantones.Size = New System.Drawing.Size(140, 36)
        Me.CBProvinciaCantones.TabIndex = 2
        '
        'BTNProvinciaCantones
        '
        Me.BTNProvinciaCantones.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNProvinciaCantones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNProvinciaCantones.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNProvinciaCantones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNProvinciaCantones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNProvinciaCantones.ForeColor = System.Drawing.Color.White
        Me.BTNProvinciaCantones.Location = New System.Drawing.Point(244, 77)
        Me.BTNProvinciaCantones.Name = "BTNProvinciaCantones"
        Me.BTNProvinciaCantones.Size = New System.Drawing.Size(180, 45)
        Me.BTNProvinciaCantones.TabIndex = 1
        Me.BTNProvinciaCantones.Text = "Elegir"
        '
        'btnElegirProvinciaCantones
        '
        Me.btnElegirProvinciaCantones.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnElegirProvinciaCantones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnElegirProvinciaCantones.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnElegirProvinciaCantones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnElegirProvinciaCantones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnElegirProvinciaCantones.ForeColor = System.Drawing.Color.White
        Me.btnElegirProvinciaCantones.Location = New System.Drawing.Point(309, 69)
        Me.btnElegirProvinciaCantones.Name = "btnElegirProvinciaCantones"
        Me.btnElegirProvinciaCantones.Size = New System.Drawing.Size(46, 24)
        Me.btnElegirProvinciaCantones.TabIndex = 120
        Me.btnElegirProvinciaCantones.Text = "..."
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
        Me.IDPROVINCIA.Location = New System.Drawing.Point(106, 70)
        Me.IDPROVINCIA.Name = "IDPROVINCIA"
        Me.IDPROVINCIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDPROVINCIA.PlaceholderText = "Ej: 1"
        Me.IDPROVINCIA.SelectedText = ""
        Me.IDPROVINCIA.Size = New System.Drawing.Size(188, 23)
        Me.IDPROVINCIA.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Provincia"
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
        Me.GUARDAR.Location = New System.Drawing.Point(170, 175)
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
        Me.CANTON.Location = New System.Drawing.Point(106, 120)
        Me.CANTON.Name = "CANTON"
        Me.CANTON.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CANTON.PlaceholderText = "Ej: Santo Domingo"
        Me.CANTON.SelectedText = ""
        Me.CANTON.Size = New System.Drawing.Size(188, 23)
        Me.CANTON.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Canton:"
        '
        'cantones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 340)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "cantones"
        Me.Text = "cantones"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.GBPROVINCIACANTON.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CANTON As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IDPROVINCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnElegirProvinciaCantones As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GBPROVINCIACANTON As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CBProvinciaCantones As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNProvinciaCantones As Guna.UI2.WinForms.Guna2Button
End Class
