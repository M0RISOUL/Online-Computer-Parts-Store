Imports System.Data.OleDb
Module Sales
    Public Provider As String
    Public database As String
    Public password As String
    Public mysql As String
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public dt As New DataTable
    Public cn As New OleDbConnection("")
    Public cm As OleDbCommand
    Public dr As OleDbDataReader

    Public Sub conn()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub
End Module
