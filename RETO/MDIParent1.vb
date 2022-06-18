Imports System.Windows.Forms

Public Class MDIMain
    Private Sub menuItemCiudadanos_Click(sender As Object, e As EventArgs) Handles menuItemCiudadanos.Click
        ciudadanos.Show()
    End Sub

    Private Sub menuItemLugarDeNacimiento_Click(sender As Object, e As EventArgs) Handles menuItemLugarDeNacimiento.Click
        lugaresdenacimiento.Show()
    End Sub

    Private Sub menuItemNacionalidades_Click(sender As Object, e As EventArgs) Handles menuItemNacionalidades.Click
        nacionalidades.Show()
    End Sub

    Private Sub menuItemProvincias_Click(sender As Object, e As EventArgs) Handles menuItemProvincias.Click
        provincias.Show()
    End Sub

    Private Sub menuItemCantones_Click(sender As Object, e As EventArgs) Handles menuItemCantones.Click
        cantones.Show()
    End Sub

    Private Sub menuItemDistritos_Click(sender As Object, e As EventArgs) Handles menuItemDistritos.Click
        distritos.Show()
    End Sub
End Class
