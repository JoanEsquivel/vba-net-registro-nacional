Public Class cantones
    Friend Sub limpiar()
        IDPROVINCIA.Clear()
        CANTON.Clear()
    End Sub

    Friend Sub LlenarProvincias()
        CBProvinciaCantones.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT PROVINCIA FROM PROVINCIA"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBProvinciaCantones.Items.Add(T.Tables(0).Rows(I).Item(0))

            Next
        End If
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
        SQL = "INSERT INTO CANTON (IDCANTON, IDPROVINCIA, CANTON) VALUES (" & PK("CANTON", "IDCANTON") & ", " & IDPROVINCIA.Tag & ", '" & CANTON.Text & "')"
        EJECUTAR(SQL)
        MsgBox("Los datos se almacenaron de forma satisfactoria", vbInformation + vbOKOnly, "EXITO!")
        limpiar()
    End Sub

    Private Sub IDPROVINCIA_TextChanged(sender As Object, e As EventArgs) Handles IDPROVINCIA.TextChanged
        validarDatos()
    End Sub

    Private Sub cantones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
    End Sub

    Private Sub btnElegirProvinciaCantones_Click(sender As Object, e As EventArgs) Handles btnElegirProvinciaCantones.Click
        LlenarProvincias()
        GBPROVINCIACANTON.Visible = True
    End Sub

    Private Sub BTNProvinciaCantones_Click(sender As Object, e As EventArgs) Handles BTNProvinciaCantones.Click
        Dim IdProvinciaEligda
        Dim ProvinciaElegida = CBProvinciaCantones.Text

        'Obtener ID Provincia
        T.Tables.Clear()
        SQL = "SELECT IDPROVINCIA from PROVINCIA WHERE PROVINCIA = '" & ProvinciaElegida & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IdProvinciaEligda = T.Tables(0).Rows(0).ItemArray(0)
        End If

        IDPROVINCIA.Text = ProvinciaElegida
        IDPROVINCIA.Tag = IdProvinciaEligda

        GBPROVINCIACANTON.Visible = False

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class