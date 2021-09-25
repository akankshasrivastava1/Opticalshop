Imports System.Data
Imports System.Data.OleDb
Public Class SaleReport

    Private Sub SaleReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dgv()
    End Sub
    Public Sub Dgv()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From tblSale"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Adpt.Fill(ds, "tblSale")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaleReport2.Show()

    End Sub
End Class