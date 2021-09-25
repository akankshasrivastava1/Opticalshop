Imports System.Windows.Forms

Public Class MDIParent1





    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim res As Integer = MsgBox("Do You Really Want to logout The Application.?", MsgBoxStyle.YesNo)
        If res = DialogResult.No Then
        ElseIf res = DialogResult.Yes Then
            LoginForm1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm1.Show()
        Label1.Text = Date.Now.ToString()
        Button1.Text = "logout :" + My.Forms.LoginForm1.name1
    End Sub

    Private Sub ADDCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDCustomerToolStripMenuItem.Click
        Customer.Show()

    End Sub

    Private Sub EDITCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITCustomerToolStripMenuItem.Click
        EditCustomer.Show()

    End Sub

    Private Sub MDIParent1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub ADDProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDProductToolStripMenuItem.Click
        AddProduct.Show()

    End Sub

    Private Sub EDITProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITProductToolStripMenuItem.Click
        EditProduct.Show()

    End Sub

    Private Sub ADDDctorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDDctorToolStripMenuItem.Click
        AddDoctor.Show()

    End Sub

    Private Sub EDITDoctorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITDoctorToolStripMenuItem.Click
        EditDoctor.Show()

    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        SaleForm.Show()

    End Sub

    Private Sub CustomerReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportsToolStripMenuItem.Click
       
        ALLDetails.Show()



    End Sub

    Private Sub ProductReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductReportsToolStripMenuItem.Click
        ALLDetails.Show()




    End Sub

    Private Sub DoctorReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorReportsToolStripMenuItem.Click
        ALLDetails.Show()

    End Sub

    Private Sub SalesReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportsToolStripMenuItem.Click
        SaleReport.Show()

    End Sub

    Private Sub AboutMeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem1.Click
        About_Me.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MsgBox("Do You Really Want To Logout The Application.?", MsgBoxStyle.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            My.Forms.LoginForm1.UsernameTextBox.Text = ""
            My.Forms.LoginForm1.PasswordTextBox.Text = ""
            LoginForm1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AboutSoftwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutSoftwareToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
