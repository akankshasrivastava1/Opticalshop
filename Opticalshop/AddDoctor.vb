Imports System.Data.OleDb
Public Class AddDoctor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        If TextBox3.Text = "" Then TextBox3.Focus() : Exit Sub
        If TextBox4.Text = "" Then TextBox4.Focus() : Exit Sub
        If TextBox5.Text = "" Then TextBox5.Focus() : Exit Sub



        Try
            con.Open()
            cmd = New OleDbCommand("Insert into Doctor(DoctorName,Qualification,HospitalName,Phone,Email) values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then


                MsgBox("Record saved successfully  ", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)

                clr()
            Else
                MsgBox("Record NOT saved ", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub clr()
        TextBox1.Clear()
        TextBox2.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class