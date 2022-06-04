Public Class nacionalidades
    Friend Sub limpiar()
        NACIONALIDAD.Clear()
    End Sub
    Friend Sub validarDatos()
        If NACIONALIDAD.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        SQL = "INSERT INTO NACIONALIDAD (IDNACIONALIDAD, NACIONALIDAD) VALUES (" & PK("NACIONALIDAD", "IDNACIONALIDAD") & ", '" & NACIONALIDAD.Text & "')"
        EJECUTAR(SQL)
        MsgBox("Los datos se almacenaron de forma satisfactoria", vbInformation + vbOKOnly, "EXITO!")
        limpiar()
    End Sub

    Private Sub NACIONALIDAD_TextChanged(sender As Object, e As EventArgs) Handles NACIONALIDAD.TextChanged
        validarDatos()
    End Sub
End Class