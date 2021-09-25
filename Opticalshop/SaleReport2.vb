Public Class SaleReport2

    Private Sub SaleReport2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblSale' table. You can move, or remove it, as needed.
        Me.tblSaleTableAdapter.Fill(Me.DataSet1.tblSale)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class