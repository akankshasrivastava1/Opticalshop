Imports System.Data
Imports System.Data.OleDb
Module Module1

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:OSMS.accdb")
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public str As String



   



End Module
