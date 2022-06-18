Public Class ciudadanos
    Dim DirFoto As String = ""

    Dim LugarNacimientoElegida = "", ProvinciaElegida = "", CantonElegido = "", DistritoElegido = "", NacionalidadElegida = ""
    Dim IdProvinciaEligda = 0, IdCantonElegido = 0, IdDistritoElegido = 0
    Friend Sub ValidarLleno()
        If IDENTIFICACION.Text <> "" And NOMBRECOMPLETO.Text <> "" And DirFoto <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub

    Friend Sub limpiar()
        IDENTIFICACION.Clear()
        IDENTIFICACION.Text = 0
        IDENTIFICACION.Tag = 0
        NOMBRECOMPLETO.Clear()
        FOTO.Image = My.Resources.USER
        REFRESCAR(L, "SELECT ID, IDENTIFICACION, NOMBRECOMPLETO, CONOCIDOCOMO, IDENTIFICACIONPADRE, NOMBREPADRE, IDENTIFICACIONMADRE, NOMBREMADRE, FECHANACIMIENTO, FOTO, IDNACIMIENTO, IDNACIONALIDAD, IDPROVINCIA, IDCANTON, IDDISTRITO  FROM CIUDADANOS", 15)
    End Sub

    Friend Sub llenarLugaresDeNacimiento()
        CBLUGARDENACIMIENTO.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT LUGARDENACIMIENTO FROM LUGARDENACIMIENTO"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBLUGARDENACIMIENTO.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If

    End Sub

    Friend Sub llenarNacionalidades()
        CBNACIONALIDAD.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT NACIONALIDAD FROM NACIONALIDAD"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBNACIONALIDAD.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If

    End Sub

    Friend Sub LlenarProvincias()
        CBPROVINCIA.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT PROVINCIA FROM PROVINCIA"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBPROVINCIA.Items.Add(T.Tables(0).Rows(I).Item(0))

            Next
        End If
    End Sub

    Friend Sub LlenarProvinciasBusqueda()
        CBBUSQUEDAPROVINCIA.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT PROVINCIA FROM PROVINCIA"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBBUSQUEDAPROVINCIA.Items.Add(T.Tables(0).Rows(I).Item(0))

            Next
        End If
    End Sub
    Friend Sub LlenarCantones(idProvinciaParametro As Integer)
        CBCANTON.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT CANTON FROM CANTON WHERE IDPROVINCIA = '" & idProvinciaParametro & "'"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBCANTON.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub
    Friend Sub LlenarDistritos(idCantonParametro As Integer)
        CBDISTRITO.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT DISTRITO FROM DISTRITO WHERE IDCANTON = '" & idCantonParametro & "'"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CBDISTRITO.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub
    Private Sub ciudadanos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        LlenarProvinciasBusqueda()
    End Sub

    Public Function convertirTextoEnID(ByVal idAObtener As String, ByVal nombreDeLaTabla As String, ByVal NombreDeLaColumnaAConvertir As String, ByVal ValorDeLaColumna As String) As Integer
        Dim id As Integer

        T.Tables.Clear()
        SQL = "SELECT " & idAObtener & " FROM " & nombreDeLaTabla & " WHERE " & NombreDeLaColumnaAConvertir & " = '" & ValorDeLaColumna & "'"
        CARGAR_TABLA(T, SQL)
        If (T.Tables(0).Rows.Count > 0) Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                id = T.Tables(0).Rows(I).Item(0)
            Next
        End If

        Return id
    End Function

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
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

        SQL = "INSERT INTO CIUDADANOS (ID, IDENTIFICACION, NOMBRECOMPLETO, CONOCIDOCOMO, IDENTIFICACIONPADRE, NOMBREPADRE, IDENTIFICACIONMADRE, NOMBREMADRE, FECHANACIMIENTO, FOTO, IDNACIMIENTO, IDNACIONALIDAD, IDPROVINCIA, IDCANTON, IDDISTRITO) VALUES (" & PK("CIUDADANOS", "ID") & ", '" & IDENTIFICACION.Text & "', '" & NOMBRECOMPLETO.Text & "', '" & CONOCIDOCOMO.Text & "', '" & IDENTIFICACIONPADRE.Text & "', '" & NOMBREDELPADRE.Text & "', '" & IDENTIFICACIONMADRE.Text & "','" & NOMBREMADRE.Text & "', '" & FECHANACIMIENTO.Text & "', '" & DirFoto & "', " & IDNACIMIENTO.Tag & ", " & IDNACIONALIDAD.Tag & ", " & IDPROVINCIA.Tag & ", " & IDCANTON.Tag & "," & IDDISTRITO.Tag & ")"
        EJECUTAR(SQL)
        limpiar()
        MsgBox("Los datos se han almacenado satisfactoriamente.", vbInformation + vbOKOnly, "Guardando")

    End Sub

    Private Sub ciudadanos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = 106) Then 'F5=106
            llenarLugaresDeNacimiento()
            GBLUGARDENACIMIENTO.Visible = True
            If (e.KeyCode = 37) Then
                GBLUGARDENACIMIENTO.Visible = False
            End If
        End If
    End Sub

    Private Sub CBLUGARDENACIMIENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBLUGARDENACIMIENTO.SelectedIndexChanged
        If (CBLUGARDENACIMIENTO.Text <> "") Then
            LugarNacimientoElegida = CBLUGARDENACIMIENTO.Text
            BTNCBLUGARNACIMIENTO.Enabled = True
        Else
            BTNCBLUGARNACIMIENTO.Enabled = False
        End If
    End Sub

    Private Sub BTNCBLUGARNACIMIENTO_Click(sender As Object, e As EventArgs) Handles BTNCBLUGARNACIMIENTO.Click
        T.Tables.Clear()
        SQL = "SELECT IDNACIMIENTO, LUGARDENACIMIENTO FROM LUGARDENACIMIENTO WHERE LUGARDENACIMIENTO = '" & LugarNacimientoElegida & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IDNACIMIENTO.Tag = T.Tables(0).Rows(0).ItemArray(0)
            IDNACIMIENTO.Text = LugarNacimientoElegida
        End If
        GBLUGARDENACIMIENTO.Visible = False


    End Sub

    Private Sub btnGuardarLugarVotacion_Click(sender As Object, e As EventArgs) Handles btnGuardarLugarVotacion.Click
        IDPROVINCIA.Text = ProvinciaElegida
        IDPROVINCIA.Tag = IdProvinciaEligda
        IDCANTON.Text = CantonElegido
        IDCANTON.Tag = IdCantonElegido
        IDDISTRITO.Text = DistritoElegido
        IDDISTRITO.Tag = IdDistritoElegido
        GBLUGARDEVOTACION.Visible = False
    End Sub

    Private Sub btnLugarNacimiento_Click(sender As Object, e As EventArgs) Handles btnLugarNacimiento.Click
        llenarLugaresDeNacimiento()
        GBLUGARDENACIMIENTO.Visible = True
    End Sub

    Private Sub BtnSeleccionarNacionalidad_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarNacionalidad.Click
        NacionalidadElegida = CBNACIONALIDAD.Text

        T.Tables.Clear()
        SQL = "SELECT IDNACIONALIDAD FROM NACIONALIDAD WHERE NACIONALIDAD = '" & NacionalidadElegida & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IDNACIONALIDAD.Tag = T.Tables(0).Rows(0).ItemArray(0)
            IDNACIONALIDAD.Text = NacionalidadElegida
        End If


        GBNACIONALIDAD.Visible = False
    End Sub

    Private Sub BUSCANDO_TextChanged(sender As Object, e As EventArgs) Handles BUSCANDO.TextChanged
        REFRESCAR(L, "SELECT ID, IDENTIFICACION, NOMBRECOMPLETO, CONOCIDOCOMO, IDENTIFICACIONPADRE, NOMBREPADRE, IDENTIFICACIONMADRE, NOMBREMADRE, FECHANACIMIENTO, FOTO, IDNACIMIENTO, IDNACIONALIDAD, IDPROVINCIA, IDCANTON, IDDISTRITO  FROM CIUDADANOS WHERE NOMBRECOMPLETO LIKE '" & BUSCANDO.Text & "%'", 15)
    End Sub

    Friend Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If (L.SelectedItems.Count > 0) Then
            IDENTIFICACION.Text = L.SelectedItems(0).SubItems(1).Text
            NOMBRECOMPLETO.Text = L.SelectedItems(0).SubItems(2).Text
            CONOCIDOCOMO.Text = L.SelectedItems(0).SubItems(3).Text
            IDENTIFICACIONPADRE.Text = L.SelectedItems(0).SubItems(4).Text
            NOMBREDELPADRE.Text = L.SelectedItems(0).SubItems(5).Text
            IDENTIFICACIONMADRE.Text = L.SelectedItems(0).SubItems(6).Text
            NOMBREMADRE.Text = L.SelectedItems(0).SubItems(7).Text
            FECHANACIMIENTO.Text = L.SelectedItems(0).SubItems(8).Text
            FOTO.Image = Image.FromFile(L.SelectedItems(0).SubItems(9).Text)
            DirFoto = L.SelectedItems(0).SubItems(9).Text
            IDNACIMIENTO.Text = L.SelectedItems(0).SubItems(10).Text
            IDNACIONALIDAD.Text = L.SelectedItems(0).SubItems(11).Text
            IDPROVINCIA.Text = L.SelectedItems(0).SubItems(12).Text
            IDCANTON.Text = L.SelectedItems(0).SubItems(13).Text
            IDDISTRITO.Text = L.SelectedItems(0).SubItems(14).Text




        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        REFRESCAR(L, "SELECT ID, IDENTIFICACION, NOMBRECOMPLETO, CONOCIDOCOMO, IDENTIFICACIONPADRE, NOMBREPADRE, IDENTIFICACIONMADRE, NOMBREMADRE, FECHANACIMIENTO, FOTO, IDNACIMIENTO, IDNACIONALIDAD, IDPROVINCIA, IDCANTON, IDDISTRITO  FROM CIUDADANOS WHERE NOMBREMADRE = '" & Guna2TextBox1.Text & "' OR NOMBREPADRE = '" & Guna2TextBox1.Text & "'", 15)
    End Sub

    Private Sub CBBUSQUEDAPROVINCIA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBUSQUEDAPROVINCIA.SelectedIndexChanged

    End Sub

    Private Sub CBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNACIONALIDAD.SelectedIndexChanged
        If (CBNACIONALIDAD.Text <> "") Then

            BtnSeleccionarNacionalidad.Enabled = True
        Else
            BtnSeleccionarNacionalidad.Enabled = False
        End If
    End Sub

    Private Sub BTNBUSQUEDAPROVINCIA_Click(sender As Object, e As EventArgs) Handles BTNBUSQUEDAPROVINCIA.Click
        Dim provinciaElegida As String
        Dim idProvinciaElegida As Integer


        provinciaElegida = CBBUSQUEDAPROVINCIA.Text

        idProvinciaElegida = convertirTextoEnID("IDPROVINCIA", "PROVINCIA", "PROVINCIA", provinciaElegida)

        IDENTIFICACION.Text = idProvinciaElegida



        REFRESCAR(L, "SELECT ID, IDENTIFICACION, NOMBRECOMPLETO, CONOCIDOCOMO, IDENTIFICACIONPADRE, NOMBREPADRE, IDENTIFICACIONMADRE, NOMBREMADRE, FECHANACIMIENTO, FOTO, IDNACIMIENTO, IDNACIONALIDAD, IDPROVINCIA, IDCANTON, IDDISTRITO  FROM CIUDADANOS WHERE IDPROVINCIA = " & idProvinciaElegida & "", 15)
    End Sub

    Private Sub btnNacionalidad_Click(sender As Object, e As EventArgs) Handles btnNacionalidad.Click
        llenarNacionalidades()
        GBNACIONALIDAD.Visible = True
    End Sub

    Private Sub btnLugarDeVotacion_Click(sender As Object, e As EventArgs) Handles btnLugarDeVotacion.Click
        LlenarProvincias()
        GBLUGARDEVOTACION.Visible = True
    End Sub

    Private Sub btnSeleccionarProvincia_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProvincia.Click
        ProvinciaElegida = CBPROVINCIA.Text

        'Obtener ID Provincia
        T.Tables.Clear()
        SQL = "SELECT IDPROVINCIA from PROVINCIA WHERE PROVINCIA = '" & ProvinciaElegida & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IdProvinciaEligda = T.Tables(0).Rows(0).ItemArray(0)
        End If

        'Control de visibilidad
        GBLUGARDENACIMIENTO.Visible = False
        btnSeleccionarCanton.Enabled = True
        CBCANTON.Enabled = True

        LlenarCantones(IdProvinciaEligda)
    End Sub

    Private Sub btnSeleccionarCanton_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCanton.Click
        CantonElegido = CBCANTON.Text

        'Obtener ID Canton
        T.Tables.Clear()
        SQL = "SELECT IDCANTON FROM CANTON WHERE CANTON = '" & CantonElegido & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IdCantonElegido = T.Tables(0).Rows(0).ItemArray(0)
        End If


        btnSeleccionarDistrito.Enabled = True
        CBDISTRITO.Enabled = True

        LlenarDistritos(IdCantonElegido)
    End Sub

    Private Sub btnSeleccionarDistrito_Click(sender As Object, e As EventArgs) Handles btnSeleccionarDistrito.Click

        DistritoElegido = CBDISTRITO.Text
        'Obtener ID Canton
        T.Tables.Clear()
        SQL = "SELECT IDDISTRITO FROM DISTRITO WHERE DISTRITO = '" & DistritoElegido & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            IdDistritoElegido = T.Tables(0).Rows(0).ItemArray(0)
        End If

        btnGuardarLugarVotacion.Enabled = True
    End Sub
End Class