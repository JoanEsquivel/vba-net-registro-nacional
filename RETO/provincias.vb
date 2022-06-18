Public Class provincias
    Friend Sub limpiar()
        PROVINCIA.Clear()
    End Sub
    Friend Sub validarDatos()
        If PROVINCIA.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        SQL = "INSERT INTO PROVINCIA (IDPROVINCIA, PROVINCIA) VALUES (" & PK("PROVINCIA", "IDPROVINCIA") & ", '" & PROVINCIA.Text & "')"
        EJECUTAR(SQL)
        MsgBox("Los datos se almacenaron de forma satisfactoria", vbInformation + vbOKOnly, "EXITO!")
        limpiar()
    End Sub

    Private Sub PROVINCIA_TextChanged(sender As Object, e As EventArgs) Handles PROVINCIA.TextChanged
        validarDatos()
    End Sub

    Private Sub provincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
    End Sub
End Class