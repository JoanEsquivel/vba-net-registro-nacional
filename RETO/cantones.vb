Public Class cantones
    Friend Sub limpiar()
        IDPROVINCIA.Clear()
        CANTON.Clear()
    End Sub
    Friend Sub validarDatos()
        If IDPROVINCIA.Text <> "" And CANTON.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub
    Private Sub CANTON_TextChanged(sender As Object, e As EventArgs) Handles CANTON.TextChanged
        validarDatos()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        SQL = "INSERT INTO CANTON (IDCANTON, IDPROVINCIA, CANTON) VALUES (" & PK("CANTON", "IDCANTON") & ", " & IDPROVINCIA.Text & ", '" & CANTON.Text & "')"
        EJECUTAR(SQL)
        MsgBox("Los datos se almacenaron de forma satisfactoria", vbInformation + vbOKOnly, "EXITO!")
        limpiar()
    End Sub

    Private Sub IDPROVINCIA_TextChanged(sender As Object, e As EventArgs) Handles IDPROVINCIA.TextChanged
        validarDatos()
    End Sub
End Class