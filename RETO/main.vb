Public Class main
    Private Sub BTNCIUDADANOS_Click(sender As Object, e As EventArgs) Handles BTNCIUDADANOS.Click
        Dim ciudadanosForm As New ciudadanos
        ciudadanosForm.ShowDialog()
    End Sub

    Private Sub BTNLUGARNACIMIENTO_Click(sender As Object, e As EventArgs) Handles BTNLUGARNACIMIENTO.Click
        Dim lugaresNacimientoForm As New lugaresdenacimiento
        lugaresdenacimiento.ShowDialog()
    End Sub

    Private Sub BTNNACIONALIDAD_Click(sender As Object, e As EventArgs) Handles BTNNACIONALIDAD.Click
        Dim nacionalidadesForm As New nacionalidades
        nacionalidadesForm.ShowDialog()
    End Sub

    Private Sub BTNPROVINCIAS_Click(sender As Object, e As EventArgs) Handles BTNPROVINCIAS.Click
        Dim provinciaForm As New provincias
        provinciaForm.ShowDialog()
    End Sub

    Private Sub BTNCANTONES_Click(sender As Object, e As EventArgs) Handles BTNCANTONES.Click
        Dim form As New cantones
        form.ShowDialog()
    End Sub

    Private Sub BTNDISTRITO_Click(sender As Object, e As EventArgs) Handles BTNDISTRITO.Click
        Dim form As New distritos
        form.ShowDialog()
    End Sub
End Class