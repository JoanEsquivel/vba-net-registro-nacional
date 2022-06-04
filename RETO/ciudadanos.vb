Public Class ciudadanos
    Dim DirFoto As String = ""
    Friend Sub ValidarLleno()
        If IDENTIFICACION.Text <> "" And NOMBRECOMPLETO.Text <> "" And DirFoto <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub

    Friend Sub limpiar()
        IDENTIFICACION.Clear()
        NOMBRECOMPLETO.Clear()
        FOTO.Image = My.Resources.USER
    End Sub
    Private Sub ciudadanos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub FOTO_Click(sender As Object, e As EventArgs) Handles FOTO.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            DirFoto = ABRIR.FileName
            FOTO.Image = Image.FromFile(DirFoto)
        End If
        ValidarLleno()
    End Sub

    Private Sub IDENTIFICACION_TextChanged(sender As Object, e As EventArgs) Handles IDENTIFICACION.TextChanged
        ValidarLleno()
    End Sub

    Private Sub NOMBRECOMPLETO_TextChanged(sender As Object, e As EventArgs) Handles NOMBRECOMPLETO.TextChanged
        ValidarLleno()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click


    End Sub
End Class