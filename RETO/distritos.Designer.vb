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
        Me.Salir = New Guna.UI2.WinForms.Guna2Button()
        Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.CANTON = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DISTRITOGP.SuspendLayout()
        Me.SuspendLayout()
        '
        'DISTRITOGP
        '
        Me.DISTRITOGP.Controls.Add(Me.DISTRITO)
        Me.DISTRITOGP.Controls.Add(Me.Label3)
        Me.DISTRITOGP.Controls.Add(Me.PROVINCIA)
        Me.DISTRITOGP.Controls.Add(Me.Label1)
        Me.DISTRITOGP.Controls.Add(Me.Salir)
        Me.DISTRITOGP.Controls.Add(Me.GUARDAR)
        Me.DISTRITOGP.Controls.Add(Me.CANTON)
        Me.DISTRITOGP.Controls.Add(Me.Label2)
        Me.DISTRITOGP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DISTRITOGP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DISTRITOGP.Location = New System.Drawing.Point(12, 12)
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
        'Salir
        '
        Me.Salir.BorderRadius = 5
        Me.Salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Location = New System.Drawing.Point(182, 183)
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
        'distritos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 307)
        Me.Controls.Add(Me.DISTRITOGP)
        Me.Name = "distritos"
        Me.Text = "distritos"
        Me.DISTRITOGP.ResumeLayout(False)
        Me.DISTRITOGP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DISTRITOGP As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Salir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CANTON As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DISTRITO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PROVINCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
