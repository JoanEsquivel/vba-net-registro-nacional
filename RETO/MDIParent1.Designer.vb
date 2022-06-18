<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemCiudadanos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemLugarDeNacimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemNacionalidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugarDeVotacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemProvincias = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemCantones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemDistritos = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemCiudadanos, Me.menuItemLugarDeNacimiento, Me.menuItemNacionalidades, Me.LugarDeVotacionToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(78, 20)
        Me.FileMenu.Text = "Fomularios"
        '
        'menuItemCiudadanos
        '
        Me.menuItemCiudadanos.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuItemCiudadanos.Name = "menuItemCiudadanos"
        Me.menuItemCiudadanos.Size = New System.Drawing.Size(183, 22)
        Me.menuItemCiudadanos.Text = "Ciudadanos"
        '
        'menuItemLugarDeNacimiento
        '
        Me.menuItemLugarDeNacimiento.Name = "menuItemLugarDeNacimiento"
        Me.menuItemLugarDeNacimiento.Size = New System.Drawing.Size(183, 22)
        Me.menuItemLugarDeNacimiento.Text = "Lugar de nacimiento"
        '
        'menuItemNacionalidades
        '
        Me.menuItemNacionalidades.Name = "menuItemNacionalidades"
        Me.menuItemNacionalidades.Size = New System.Drawing.Size(183, 22)
        Me.menuItemNacionalidades.Text = "Nacionalidades"
        '
        'LugarDeVotacionToolStripMenuItem
        '
        Me.LugarDeVotacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemProvincias, Me.menuItemCantones, Me.menuItemDistritos})
        Me.LugarDeVotacionToolStripMenuItem.Name = "LugarDeVotacionToolStripMenuItem"
        Me.LugarDeVotacionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LugarDeVotacionToolStripMenuItem.Text = "Lugar de Votacion"
        '
        'menuItemProvincias
        '
        Me.menuItemProvincias.Name = "menuItemProvincias"
        Me.menuItemProvincias.Size = New System.Drawing.Size(180, 22)
        Me.menuItemProvincias.Text = "Provincias"
        '
        'menuItemCantones
        '
        Me.menuItemCantones.Name = "menuItemCantones"
        Me.menuItemCantones.Size = New System.Drawing.Size(180, 22)
        Me.menuItemCantones.Text = "Cantones"
        '
        'menuItemDistritos
        '
        Me.menuItemDistritos.Name = "menuItemDistritos"
        Me.menuItemDistritos.Size = New System.Drawing.Size(180, 22)
        Me.menuItemDistritos.Text = "Distritos"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMain"
        Me.Text = "Registro de Ciudadanos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents menuItemCiudadanos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents menuItemLugarDeNacimiento As ToolStripMenuItem
    Friend WithEvents menuItemNacionalidades As ToolStripMenuItem
    Friend WithEvents LugarDeVotacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemProvincias As ToolStripMenuItem
    Friend WithEvents menuItemCantones As ToolStripMenuItem
    Friend WithEvents menuItemDistritos As ToolStripMenuItem
End Class
