Imports System.Data.OleDb

Public Class EditProduct

    Private Sub EditProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getdata()

    End Sub
    Public Sub getdata()
        con.Close()

        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from Product"
            cmd.Connection = con
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt

            End Using
        End Using
    End Sub
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Close()

        con.Open()
        Using cmd As New OleDbCommand()
            cmd.CommandText = "Select * from Product where ProductID LIKE @ID + '%' "
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim())
            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    DataGridView1.DataSource = dt
                    TextBox2.Text = dt.Rows(0)(0).ToString()
                    TextBox3.Text = dt.Rows(0)(1).ToString()
                    TextBox4.Text = dt.Rows(0)(2).ToString()
                    TextBox5.Text = dt.Rows(0)(3).ToString()
                    TextBox6.Text = dt.Rows(0)(4).ToString()
                    TextBox7.Text = dt.Rows(0)(5).ToString()
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

                End If


            End Using
        End Using
    End Sub
    Public Sub clr()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        clr()
        getdata()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
       
        'For DataGridView Cell Click

       
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox2.Text = DataGridView1.Item(0, i).Value
        Me.TextBox3.Text = DataGridView1.Item(1, i).Value
        Me.TextBox4.Text = DataGridView1.Item(2, i).Value
        Me.TextBox5.Text = DataGridView1.Item(3, i).Value
        Me.TextBox6.Text = DataGridView1.Item(4, i).Value
        Me.TextBox7.Text = DataGridView1.Item(5, i).Value

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'FOR UPDATE
        con.Close()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("PLZ FIll All details")
            Exit Sub
        End If

        con.Open()
        cmd = New OleDbCommand("Update [Product] Set [ProductName]='" & TextBox3.Text & "',[EyePower]='" & TextBox4.Text & "',[GlassType]='" & TextBox5.Text & "',[FrameType]='" & TextBox6.Text & "',[Price]='" & TextBox7.Text & "' Where [ProductID]='" & TextBox2.Text & "' ", con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Record UPDATE SUccessfully..")
            clr()

            getdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()

        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Close()

        If TextBox2.Text = "" Then

            MsgBox("PLZ FIll All details")
            Exit Sub
        End If
        Dim msg As Integer = MsgBox("Do You Really want to Delete Customer :-'" & TextBox1.Text & "' ?", MsgBoxStyle.YesNoCancel, "Delete Customer Record")

        If msg = DialogResult.Yes Then
            con.Open()

            cmd = New OleDbCommand("Delete from Product Where ProductID='" & TextBox2.Text & "'", con)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Record deleted successfully")
                clr()

                getdata()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try
        End If
        

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clr()
        Me.Close()

    End Sub

    Private Sub EditProduct_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()


    End Sub
End Class