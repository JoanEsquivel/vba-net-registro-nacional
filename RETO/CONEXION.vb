Imports System.Data.OleDb
Imports System.Data.SqlClient

Module CONEXION
    Public Db As New OleDb.OleDbConnection
    Public SQL As String
    Public T, T1, T2, T3 As New DataSet
    Public VECTOR_COLUMNA_OCULTAR(100) As Integer

    'USADAS PARA LA IMAGEN
    Public DA As SqlDataAdapter
    Public SERVIDOR As String = "DR-SALAS\DRSALAS"
    Public str_Base As String = "2022-01" 'BASE DE DATOS PARA IMAGEN
    Public BD As String = "2022-01" 'BASE DE DATOS PARA IMAGEN
    Public CONEXION_IMG As New SqlConnection("Data Source=" & SERVIDOR & ";" & "Initial Catalog=" & BD & ";Integrated Security=" & True)


    'Contador ID
    Public ID_Contador As Integer = 0
    Private Contador As Integer = 0
    Private Rows As Integer = 0
    Private Vueltas As Integer = 0

    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\ruta.udl"
        Db.ConnectionString = Ruta
        Db.Open()
    End Sub

    Friend Sub DESCONECTAR()
        Db.Close()
    End Sub

    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub

    Friend Sub EJECUTAR(ByVal Sql As String)
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub

    Friend Function PK(ByVal TABLA As String, ByVal LLAVE_PRIMARIA As String) As Integer
        Dim T As New DataSet
        Dim SQL As String

        T.Tables.Clear()
        SQL = "SELECT " & LLAVE_PRIMARIA & " FROM " & TABLA
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count = 0 Then
            PK = 1
        Else
            T.Tables.Clear()
            SQL = "SELECT MAX(" & LLAVE_PRIMARIA & ") FROM " & TABLA
            CARGAR_TABLA(T, SQL)
            PK = T.Tables(0).Rows(0).Item(0) + 1
        End If
    End Function

    Function CONTADOR_ID(Tabla As DataSet, Sentencia As String) As Integer
        Tabla.Clear()
        Contador = 0
        Rows = 0
        Vueltas = 0
        CARGAR_TABLA(Tabla, Sentencia)
        If Tabla.Tables(0).Rows.Count = 0 Then
            Rows = Tabla.Tables(0).Rows.Count
            Contador = Rows
        ElseIf Tabla.Tables(0).Rows.Count > 0 Then
            Vueltas = Tabla.Tables(0).Rows.Count - 1
            For FILA As Integer = 0 To Vueltas
                If FILA = Vueltas Then
                    If Rows >= Tabla.Tables(0).Rows(FILA).ItemArray(0) Then
                        Rows = Rows + 1
                        Exit For
                    End If
                ElseIf Rows = Tabla.Tables(0).Rows(FILA).ItemArray(0) Then
                    Rows = Rows + 1
                ElseIf Rows < Tabla.Tables(0).Rows(FILA).ItemArray(0) Then
                    Exit For
                End If
            Next
            Contador = Rows
        End If
        Rows = 0
        Vueltas = 0
        Return Contador
        Contador = 0
    End Function

    Friend Sub REFRESCAR(ByRef L As ListView, ByVal SQL As String, ByVal CAMPOS As Integer)
        Dim J As Integer
        Dim IdLugarDeNacimiento, IdNacionalidad, IdProvinciaElegida, IdCantonElegido, IdDistritoElegido As Integer
        Dim LugarDeNacimientoElegido, NacionalidadElegida, ProvinciaEligida, CantonElegido, DistritoElegido As String
        T.Tables.Clear()
        L.Items.Clear()
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J = 1 To CAMPOS - 1
                    If (J = 10) Then
                        IdLugarDeNacimiento = T.Tables(0).Rows(I).Item(J)
                        LugarDeNacimientoElegido = convertirIDEnTexto("LUGARDENACIMIENTO", "LUGARDENACIMIENTO", "IDNACIMIENTO", IdLugarDeNacimiento)
                        L.Items(L.Items.Count - 1).SubItems.Add(LugarDeNacimientoElegido)
                    ElseIf (J = 11) Then
                        IdNacionalidad = T.Tables(0).Rows(I).Item(J)
                        NacionalidadElegida = convertirIDEnTexto("NACIONALIDAD", "NACIONALIDAD", "IDNACIONALIDAD", IdNacionalidad)
                        L.Items(L.Items.Count - 1).SubItems.Add(NacionalidadElegida)
                    ElseIf (J = 12) Then
                        IdProvinciaElegida = T.Tables(0).Rows(I).Item(J)
                        ProvinciaEligida = convertirIDEnTexto("PROVINCIA", "PROVINCIA", "IDPROVINCIA", IdProvinciaElegida)
                        L.Items(L.Items.Count - 1).SubItems.Add(ProvinciaEligida)
                    ElseIf (J = 13) Then
                        IdCantonElegido = T.Tables(0).Rows(I).Item(J)
                        CantonElegido = convertirIDEnTexto("CANTON", "CANTON", "IDCANTON", IdCantonElegido)
                        L.Items(L.Items.Count - 1).SubItems.Add(CantonElegido)
                    ElseIf (J = 14) Then
                        IdDistritoElegido = T.Tables(0).Rows(I).Item(J)
                        DistritoElegido = convertirIDEnTexto("DISTRITO", "DISTRITO", "IDDISTRITO", IdDistritoElegido)
                        L.Items(L.Items.Count - 1).SubItems.Add(DistritoElegido)
                    Else
                        L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                    End If
                Next
            Next
            L.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            L.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            L.Columns(0).Width = 0
            L.Columns(1).Width = 0
            L.Columns(3).Width = 0
            L.Columns(4).Width = 0
            L.Columns(6).Width = 0
            L.Columns(8).Width = 0
            L.Columns(9).Width = 0
            L.Columns(10).Width = 0
            L.Columns(11).Width = 0
            L.Columns(13).Width = 0
            L.Columns(14).Width = 0

        End If
    End Sub

    Public Function convertirIDEnTexto(ByVal ValorTexto As String, ByVal nombreDeLaTabla As String, ByVal IdAConvertir As String, ByVal ValorID As String) As String
        Dim text As String

        T2.Tables.Clear()
        SQL = "SELECT " & ValorTexto & " FROM " & nombreDeLaTabla & " WHERE " & IdAConvertir & " = " & ValorID & ""
        CARGAR_TABLA(T2, SQL)
        If (T2.Tables(0).Rows.Count > 0) Then
            For I = 0 To T2.Tables(0).Rows.Count - 1
                text = T2.Tables(0).Rows(I).Item(0)
            Next
        End If

        Return text
    End Function
End Module
