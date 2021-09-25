Imports System.Data.OleDb
Public Class EditCustomer

    Private Sub EditCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()

        CusID()
    End Sub

    Public Sub CusID()
        ComboBox1.Items.Clear()
        ds.Clear()
        con.Close()

        con.Open()
        str = "Select * From Customer"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Customer")
        Dim a As Integer = ds.Tables("Customer").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("Customer").Rows(i)(0).ToString())
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Close()

        con.Open()

        cmd = New OleDbCommand(str, con)
        If IsNumeric(ComboBox1.Text) Then
            cmd.CommandText = "select * from Customer where CustomerID=@cid"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@cid", ComboBox1.Text)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Try
                If dr.Read() Then
                    TextBox1.Text = dr.GetValue(1)
                    TextBox2.Text = dr.GetValue(2)
                    TextBox3.Text = dr.GetValue(3)
                    TextBox4.Text = dr.GetValue(4)
                    TextBox5.Text = dr.GetValue(5)
                    dr.Close()

                End If

            Catch ex As Exception
                MsgBox("", ex.Message)
                dr.Close()
            Finally
                con.Close()

            End Try

        End If




    End Sub
    

   
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("PLZ FIll the details")
            Exit Sub

        End If
        Try
            con.Close()

            con.Open()
            str = "UPDATE Customer set CustomerName=@name,Address=@Address,Phone=@Phone,EyePower=@EP,ConsultantDoctor=@CD Where CustomerID=@CID"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("@name", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Address", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Phone", TextBox3.Text)
            cmd.Parameters.AddWithValue("@EP", TextBox4.Text)
            cmd.Parameters.AddWithValue("@CD", TextBox5.Text)
            cmd.Parameters.AddWithValue("@CID", ComboBox1.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Record Updated successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)


        Catch ex As Exception
            MsgBox("", ex.Message)
        Finally
            con.Close()

        End Try

        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Plz Fill all details")
            Exit Sub

        End If
        Dim msg As Integer = MsgBox("Do You Really want to Delete Customer :-'" & TextBox1.Text & "' ?", MsgBoxStyle.YesNoCancel, "Delete Customer Record")

        If msg = DialogResult.Yes Then

            Try
                con.Open()
                str = "Delete From Customer where CustomerID=@ID"
                cmd = New OleDbCommand(str, con)
                cmd.Parameters.AddWithValue("@ID", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Record Deleted", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                clr()
               

                Dim ctr As Integer
                'cn.Open()
                ComboBox1.Items.Clear()
                ds.Clear()
                str = "select * from Customer"
                cmd = New OleDbCommand(str, con)
                da.SelectCommand = cmd
                da.Fill(ds, "Customer")
                ctr = ds.Tables("Customer").Rows.Count - 1
                For i = 0 To ctr
                    ComboBox1.Items.Add(ds.Tables("Customer").Rows(i)(0).ToString)
                Next

            Catch ex As Exception
                MsgBox("Record Not Deleted")

            Finally
                con.Close()


            End Try
        End If


    End Sub
    Public Sub clr()
        TextBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        TextBox5.Clear()
        ComboBox1.Items.Clear()


    End Sub

    Private Sub EditCustomer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        ComboBox1.Items.Clear()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class