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
        Dim IdProvinciaElegida As Integer
        Dim ProvinciaEligida As String
        Dim SQLProvincia As String
        T.Tables.Clear()

        L.Items.Clear()

        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J = 1 To CAMPOS - 1
                    'If (J <> 2 And J <> 5 And J <> 7 And J <> 12) Then
                    '    L.Columns(J).Width = 0
                    'End If
                    If (J = 12) Then

                        IdProvinciaElegida = T.Tables(0).Rows(I).Item(J)

                        'Obtener ID Provincia
                        T2.Tables.Clear()
                        SQLProvincia = "SELECT PROVINCIA from PROVINCIA WHERE IDPROVINCIA = " & IdProvinciaElegida & ""
                        CARGAR_TABLA(T2, SQLProvincia)
                        If T.Tables(0).Rows.Count > 0 Then
                            ProvinciaEligida = T2.Tables(0).Rows(0).ItemArray(0)
                        End If

                        L.Items(L.Items.Count - 1).SubItems.Add(ProvinciaEligida)
                    Else
                        L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                    End If

                    'https://stackoverflow.com/questions/6233625/vb-net-adding-items-to-a-listview-along-with-tag-property
                    'L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J)).Tag
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
End Module
