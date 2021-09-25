Imports System.Data
Imports System.Data.OleDb


Public Class LoginForm1
    Public name1 As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        con.Close()
        If UsernameTextBox.Text = "" Then UsernameTextBox.Focus() : Exit Sub
        If PasswordTextBox.Text = "" Then PasswordTextBox.Focus() : Exit Sub

        cmd = New OleDbCommand("Select * from Login where UserName=@UserName and Password=@Password", con)

        Dim UParam As New OleDb.OleDbParameter("@UserName", Me.UsernameTextBox.Text)
        Dim PassParam As New OleDb.OleDbParameter("@Password", Me.PasswordTextBox.Text)
        cmd.Parameters.Add(UParam)
        cmd.Parameters.Add(PassParam)
        cmd.Connection = con
        cmd.Connection.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        If dr.HasRows Then
            con.Close()

            My.Forms.MDIParent1.Show()
            Me.Close()
        Else
            MsgBox("UserID & Password Not Matched", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        End If





        'str = "Select * from Login where UserName='" + UsernameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'"
        'cmd = New OleDbCommand(str, con)
        'con.Open()
        'Dim dr As OleDbDataReader = cmd.ExecuteReader()
        'If dr.HasRows Then
        '    con.Close()

        '    My.Forms.MDIParent1.Show()
        '    Me.Close()
        'Else
        '    MsgBox("UserID & Password Not Matched", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        'End If

        'con.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True

            End If
        End If


    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub



End Class
