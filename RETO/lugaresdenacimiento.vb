Public Class lugaresdenacimiento

    Friend Sub limpiar()
        LUGARDENACIMIENTO.Clear()
    End Sub
    Friend Sub validarDatos()
        If LUGARDENACIMIENTO.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        SQL = "INSERT INTO LUGARDENACIMIENTO (IDNACIMIENTO, LUGARDENACIMIENTO) VALUES (" & PK("LUGARDENACIMIENTO", "IDNACIMIENTO") & ", '" & LUGARDENACIMIENTO.Text & "')"
        EJECUTAR(SQL)
        MsgBox("Los datos se almacenaron de forma satisfactoria", vbInformation + vbOKOnly, "EXITO!")
        limpiar()

    End Sub

    Private Sub LUGARDENACIMIENTO_TextChanged(sender As Object, e As EventArgs) Handles LUGARDENACIMIENTO.TextChanged
        validarDatos()
    End Sub

    Private Sub lugaresdenacimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
    End Sub
End Class