Imports System.Data.OleDb
Imports System.Data
Public Class SaleForm
    Dim Lastno As Integer
    Dim cmd2 As OleDbCommand
    Public cn, b, pdct, t, d As String


    Private Sub SaleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bill()
        Pro()
        doc()
        CustName()
        TextBox11.Text = DateTime.Now
    End Sub
    Public Sub bill()

        con.Close()
        con.Open()
        str = "Select * From tblSale"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "tblSale")
        'For Generating Bill No. 

        Lastno = ds.Tables("tblSale").Rows.Count + 1
        If Lastno >= 0 Then
            TextBox5.Text = "Bill" & Lastno
        Else
            TextBox5.Text = "Bill" & 0
        End If
        con.Close()

    End Sub

    Public Sub CustName()
        ComboBox1.Items.Clear()
        ds.Clear()
        con.Close()

        con.Open()
        str = "select * From Customer"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Customer")
        Dim a As Integer = ds.Tables("Customer").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("Customer").Rows(i)(0).ToString())
        Next
    End Sub
    Public Sub Pro()
        ComboBox2.Items.Clear()
        ds.Clear()
        con.Close()
        con.Open()
        str = "select * from Product"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Product")
        Dim a As Integer = ds.Tables("Product").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox2.Items.Add(ds.Tables("Product").Rows(i)(0).ToString())
        Next
    End Sub

    Public Sub doc()
        ComboBox3.Items.Clear()
        ds.Clear()
        con.Close()
        con.Open()
        str = "select * from Doctor"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Doctor")
        Dim a As Integer = ds.Tables("Doctor").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox3.Items.Add(ds.Tables("Doctor").Rows(i)(0).ToString())
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Close()
        con.Open()
        str = "Select * from Customer where CustomerID=@id"
        cmd = New OleDbCommand(str, con)

       
        cmd.Parameters.AddWithValue("@id", ComboBox1.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            If dr.Read() Then
                TextBox17.Text = dr.GetValue(1)
                TextBox1.Text = dr.GetValue(2)
                TextBox2.Text = dr.GetValue(3)
                TextBox3.Text = dr.GetValue(4)
                TextBox4.Text = dr.GetValue(5)

                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()

        Finally
            con.Close()

        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.Close()
        con.Open()
        cmd2 = New OleDbCommand("Select * From Product where ProductID='" + ComboBox2.Text + "'", con)
        Dim dr As OleDbDataReader = cmd2.ExecuteReader()
        If dr.Read Then
            TextBox10.Text = dr.GetValue(1)
            TextBox9.Text = dr.GetValue(2)
            TextBox8.Text = dr.GetValue(3)
            TextBox7.Text = dr.GetValue(4)
            TextBox6.Text = dr.GetValue(5)
            dr.Close()
        End If
        con.Close()



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        con.Close()
        con.Open()
        str = "Select * from Doctor where DoctorID=@Did"
        cmd = New OleDbCommand(str, con)


        cmd.Parameters.AddWithValue("@Did", ComboBox3.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            If dr.Read() Then
                TextBox18.Text = dr.GetValue(1)
                TextBox15.Text = dr.GetValue(2)
                TextBox14.Text = dr.GetValue(3)
                TextBox13.Text = dr.GetValue(4)
                TextBox12.Text = dr.GetValue(5)

                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()

        Finally
            con.Close()

        End Try

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim tot As Integer
        tot = Val(TextBox6.Text) * Val(ComboBox4.Text)
        TextBox16.Text = Convert.ToString(tot)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Close()
        str = "Insert into [tblSale]([CustomerID],[CustomerName],[CustAddress],[Phone],[EyePower],[ConsultantDoctor],[ProductID],[PEyePower],[GlassType],[Price],[Quantity],[TotalPrice],[DoctorID],[DoctorName],[Qualification],[HospitalName],[DPhone],[Email],[ProductName],[Dateofsale],[FrameType]) values('" & ComboBox1.Text & "','" & TextBox17.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox6.Text & "','" & ComboBox4.Text & "','" & TextBox16.Text & "','" & ComboBox3.Text & "','" & TextBox18.Text & "','" & TextBox15.Text & "','" & TextBox14.Text & "','" & TextBox13.Text & "','" & TextBox12.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox7.Text & "')"
        Try
            con.Open()
            cmd = New OleDbCommand(str, con)
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Record saved", MsgBoxStyle.Information)
                b = TextBox5.Text
                cn = TextBox17.Text
                pdct = TextBox10.Text
                t = TextBox16.Text
                d = TextBox11.Text
                Me.Hide()
                Receipt.Show()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class