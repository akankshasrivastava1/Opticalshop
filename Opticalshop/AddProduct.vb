Imports System.Data.OleDb

Public Class AddProduct
    Dim Lastno As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Close()

        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox3.Text = "" Then TextBox3.Focus() : Exit Sub
        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub
        If TextBox5.Text = "" Then TextBox5.Focus() : Exit Sub
        If TextBox6.Text = "" Then TextBox5.Focus() : Exit Sub

        Try
            con.Open()
            cmd = New OleDbCommand("Insert into Product(ProductID,ProductName,EyePower,GlassType,FrameType,Price) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then


                MsgBox("Record saved successfully  ", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                Dim result As Integer = MessageBox.Show("New Product Added. Want To Add Another One.", "Added", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    clr()
                    con.Close()
                    con.Open()

                    str = "select * from Product"
                    cmd = New OleDbCommand(str, con)
                    da.SelectCommand = cmd
                    da.Fill(ds, "Product")
                    Lastno = ds.Tables("Product").Rows.Count + 1
                    If Lastno >= 0 Then
                        TextBox1.Text = "PID" & Lastno
                    Else
                        TextBox1.Text = "PID" & 0
                        TextBox2.Focus()


                    End If


                End If
            Else
                MsgBox("Record NOT saved ", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

            End If
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

   
    Private Sub AddProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Close()

        con.Open()
        str = "select * from Product"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Product")

        'for ProductID Number


        Lastno = ds.Tables("Product").Rows.Count + 1

        If Lastno >= 0 Then
            TextBox1.Text = "PID" & Lastno
        Else
            TextBox1.Text = "PID" & 0
        End If
    End Sub

    Public Sub clr()
        ds.Clear()

        TextBox1.Clear()
        TextBox2.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
End Class