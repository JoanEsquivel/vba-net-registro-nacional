﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class provincias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(provincias))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.PROVINCIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.GUARDAR)
        Me.Guna2GroupBox1.Controls.Add(Me.PROVINCIA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(157, 130)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(487, 191)
        Me.Guna2GroupBox1.TabIndex = 5
        Me.Guna2GroupBox1.Text = "Ingrese una provincia"
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
        Me.GUARDAR.Location = New System.Drawing.Point(67, 122)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(89, 28)
        Me.GUARDAR.TabIndex = 115
        Me.GUARDAR.Text = "Guardar"
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
        Me.PROVINCIA.Location = New System.Drawing.Point(87, 74)
        Me.PROVINCIA.Name = "PROVINCIA"
        Me.PROVINCIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PROVINCIA.PlaceholderText = "Ej: San Jose"
        Me.PROVINCIA.SelectedText = ""
        Me.PROVINCIA.Size = New System.Drawing.Size(188, 23)
        Me.PROVINCIA.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provincia:"
        '
        'provincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "provincias"
        Me.Text = "provincias"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PROVINCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
