Imports System.Data.OleDb
Imports System.Data

Public Class ALLDetails

    Private Sub ALLDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Visible = False
        Button5.Visible = False
        Label4.Visible = False
        Label9.Visible = False
        Label10.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        ComboBox1.Visible = False
        Button5.Visible = False
        Label4.Visible = False
        Label9.Visible = True
        Label10.Visible = True

        Dgv()
    End Sub
    Public Sub Dgv()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Customer"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Adpt.Fill(ds, "Customer")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        sum()
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ComboBox1.Visible = False
        Button5.Visible = False
        Label4.Visible = False
        Label9.Visible = True
        Label10.Visible = True
        Dgv2()
    End Sub
    Public Sub Dgv2()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Doctor"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Dim ds2 As DataSet = New DataSet

        Adpt.Fill(ds2, "Doctor")
        DataGridView1.DataSource = ds2.Tables(0)
        con.Close()
        sum()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        ComboBox1.Visible = False
        Button5.Visible = False
        Label4.Visible = False
        Label9.Visible = True
        Label10.Visible = True
        Dgv3()
    End Sub
    Public Sub Dgv3()
        ds.Clear()
        con.Close()
        con.Open()
        str = "Select * From Product"
        Dim Adpt As New OleDbDataAdapter(str, con)
        Dim ds3 As DataSet = New DataSet

        Adpt.Fill(ds3, "Product")
        DataGridView1.DataSource = ds3.Tables(0)
        con.Close()
        sum()
    End Sub
    Public Sub sum()
        Label10.Text = DataGridView1.Rows.Count - 1
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Label4.Visible = True
        ComboBox1.Visible = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button5.Visible = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label10.Visible = False
        Label9.Visible = False

        If ComboBox1.Text = "Customer" Then
            search()
        ElseIf ComboBox1.Text = "Doctor" Then
            search2()
        ElseIf ComboBox1.Text = "Product" Then
            search3()
        Else
            MsgBox("Plz Select Table name form Combobox", MsgBoxStyle.Critical)

        End If
    End Sub
    Public Sub search()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * From Customer where CustomerID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())
            Dim dt As New DataTable
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Exclamation)

                End If
            End Using
        End Using

        

    End Sub
    Public Sub search2()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * From Doctor where DOctorID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())
            Dim dt As New DataTable
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Exclamation)

                End If
            End Using
        End Using
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.Red
    End Sub
    Public Sub search3()
        con.Close()
        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * From Product where ProductID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())
            Dim dt As New DataTable
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Exclamation)

                End If
            End Using
        End Using
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.Blue
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class