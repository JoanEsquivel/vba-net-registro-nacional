Public Class distritos

    Friend Sub limpiar()
        PROVINCIA.Clear()
        CANTON.Clear()
        DISTRITO.Clear()
    End Sub
    Friend Sub validarDatos()
        If PROVINCIA.Text <> "" And CANTON.Text <> "" And DISTRITO.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        SQL = "INSERT INTO DISTRITO (IDDISTRITO, IDPROVINCIA, IDCANTON, DISTRITO) VALUES (" & PK("DISTRITO", "IDDISTRITO") & ", " & PROVINCIA.Text & "," & CANTON.Text & ", '" & DISTRITO.Text & "')"
        EJECUTAR(SQL)
        MsgBox("Los datos se almacenaron de forma satisfactoria", vbInformation + vbOKOnly, "EXITO!")
        limpiar()
    End Sub

    Private Sub PROVINCIA_TextChanged(sender As Object, e As EventArgs) Handles PROVINCIA.TextChanged
        validarDatos()
    End Sub

    Private Sub CANTON_TextChanged(sender As Object, e As EventArgs) Handles CANTON.TextChanged
        validarDatos()
    End Sub

    Private Sub DISTRITO_TextChanged(sender As Object, e As EventArgs) Handles DISTRITO.TextChanged
        validarDatos()
    End Sub
End Class