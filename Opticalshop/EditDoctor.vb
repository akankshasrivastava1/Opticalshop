Imports System.Data.OleDb

Public Class EditDoctor

    Private Sub EditDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CusID()
    End Sub

    Public Sub CusID()
        ComboBox1.Items.Clear()
        ds.Clear()
        con.Close()

        con.Open()
        str = "Select * From Doctor"
        cmd = New OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Doctor")
        Dim a As Integer = ds.Tables("Doctor").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("Doctor").Rows(i)(0).ToString())
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Close()

        con.Open()

        cmd = New OleDbCommand(str, con)
        If IsNumeric(ComboBox1.Text) Then
            cmd.CommandText = "select * from Doctor where DoctorID=@did"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@did", ComboBox1.Text)
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
            str = "UPDATE Doctor set DoctorName=@name,Qualification=@qul,HospitalName=@HN,Phone=@Phone,Email=@Email Where DoctorID=@dID"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("@name", TextBox1.Text)
            cmd.Parameters.AddWithValue("@qul", TextBox2.Text)
            cmd.Parameters.AddWithValue("@HN", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Phone", TextBox4.Text)
            cmd.Parameters.AddWithValue("@Email", TextBox5.Text)
            cmd.Parameters.AddWithValue("@dID", ComboBox1.Text)
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
        Dim msg As Integer = MsgBox("Do You Really want to Delete Doctor :-'" & TextBox1.Text & "' ?", MsgBoxStyle.YesNoCancel, "Delete Customer Record")

        If msg = DialogResult.Yes Then

            Try
                con.Open()
                str = "Delete From Doctor where DoctorID=@ID"
                cmd = New OleDbCommand(str, con)
                cmd.Parameters.AddWithValue("@ID", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Record Deleted", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                clr()


                Dim ctr As Integer
                'cn.Open()
                ComboBox1.Items.Clear()
                ds.Clear()
                str = "select * from Doctor"
                cmd = New OleDbCommand(str, con)
                da.SelectCommand = cmd
                da.Fill(ds, "Doctor")
                ctr = ds.Tables("Doctor").Rows.Count - 1
                For i = 0 To ctr
                    ComboBox1.Items.Add(ds.Tables("Doctor").Rows(i)(0).ToString)
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class