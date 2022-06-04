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
End Module
