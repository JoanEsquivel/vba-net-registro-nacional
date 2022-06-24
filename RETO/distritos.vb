Public Class distritos
    Friend Sub LlenarProvincias()
        CBProvinciaDistritos.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT PROVINCIA FROM PROVINCIA"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBProvinciaDistritos.Items.Add(T.Tables(0).Rows(I).Item(0))

            Next
        End If
    End Sub

    Friend Sub LlenarCantones(idProvinciaParametro As Integer)
        CBCantonDistrito.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT CANTON FROM CANTON WHERE IDPROVINCIA = '" & idProvinciaParametro & "'"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBCantonDistrito.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub
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
        SQL = "INSERT INTO DISTRITO (IDDISTRITO, IDPROVINCIA, IDCANTON, DISTRITO) VALUES (" & PK("DISTRITO", "IDDISTRITO") & ", " & PROVINCIA.Tag & "," & CANTON.Tag & ", '" & DISTRITO.Text & "')"
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

    Private Sub distritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
    End Sub

    Private Sub btnElegirProvinciaDistrito_Click(sender As Object, e As EventArgs) Handles btnElegirProvinciaDistrito.Click
        GBProvinciaDistrito.Visible = True
        LlenarProvincias()
    End Sub

    Private Sub btnElegirCantonDistrito_Click(sender As Object, e As EventArgs) Handles btnElegirCantonDistrito.Click
        GBCantonDistrito.Visible = True
    End Sub

    Private Sub BTNProvinciaDistritos_Click(sender As Object, e As EventArgs) Handles BTNProvinciaDistritos.Click
        Dim IdProvinciaEligda
        Dim ProvinciaElegida = CBProvinciaDistritos.Text

        'Obtener ID Provincia
        T.Tables.Clear()
        SQL = "SELECT IDPROVINCIA from PROVINCIA WHERE PROVINCIA = '" & ProvinciaElegida & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IdProvinciaEligda = T.Tables(0).Rows(0).ItemArray(0)
        End If

        PROVINCIA.Text = ProvinciaElegida
        PROVINCIA.Tag = IdProvinciaEligda

        GBProvinciaDistrito.Visible = False
        LlenarCantones(IdProvinciaEligda)
    End Sub

    Private Sub BTNCantonDistrito_Click(sender As Object, e As EventArgs) Handles BTNCantonDistrito.Click

        Dim IdCantonEligdo
        Dim CantonElegido = CBCantonDistrito.Text

        'Obtener ID Provincia
        T.Tables.Clear()
        SQL = "SELECT IDCANTON FROM CANTON WHERE CANTON = '" & CantonElegido & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IdCantonEligdo = T.Tables(0).Rows(0).ItemArray(0)
        End If

        CANTON.Text = CantonElegido
        CANTON.Tag = IdCantonEligdo

        GBCantonDistrito.Visible = False

    End Sub
End Class