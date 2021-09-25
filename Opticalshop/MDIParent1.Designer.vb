<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDDctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.ProductToolStripMenuItem, Me.DoctorToolStripMenuItem, Me.SalesToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AboutMeToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1735, 33)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDCustomerToolStripMenuItem, Me.EDITCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CustomerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ADDCustomerToolStripMenuItem
        '
        Me.ADDCustomerToolStripMenuItem.Name = "ADDCustomerToolStripMenuItem"
        Me.ADDCustomerToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.ADDCustomerToolStripMenuItem.Text = "ADD Customer"
        '
        'EDITCustomerToolStripMenuItem
        '
        Me.EDITCustomerToolStripMenuItem.Name = "EDITCustomerToolStripMenuItem"
        Me.EDITCustomerToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.EDITCustomerToolStripMenuItem.Text = "EDIT Customer"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDProductToolStripMenuItem, Me.EDITProductToolStripMenuItem})
        Me.ProductToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ProductToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'ADDProductToolStripMenuItem
        '
        Me.ADDProductToolStripMenuItem.Name = "ADDProductToolStripMenuItem"
        Me.ADDProductToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.ADDProductToolStripMenuItem.Text = "ADD Product"
        '
        'EDITProductToolStripMenuItem
        '
        Me.EDITProductToolStripMenuItem.Name = "EDITProductToolStripMenuItem"
        Me.EDITProductToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.EDITProductToolStripMenuItem.Text = "EDIT Product"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDDctorToolStripMenuItem, Me.EDITDoctorToolStripMenuItem})
        Me.DoctorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.DoctorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.DoctorToolStripMenuItem.Text = "Doctor"
        '
        'ADDDctorToolStripMenuItem
        '
        Me.ADDDctorToolStripMenuItem.Name = "ADDDctorToolStripMenuItem"
        Me.ADDDctorToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.ADDDctorToolStripMenuItem.Text = "ADD Dctor"
        '
        'EDITDoctorToolStripMenuItem
        '
        Me.EDITDoctorToolStripMenuItem.Name = "EDITDoctorToolStripMenuItem"
        Me.EDITDoctorToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.EDITDoctorToolStripMenuItem.Text = "EDIT Doctor"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.SalesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReportsToolStripMenuItem, Me.ProductReportsToolStripMenuItem, Me.DoctorReportsToolStripMenuItem, Me.SalesReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(96, 29)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'CustomerReportsToolStripMenuItem
        '
        Me.CustomerReportsToolStripMenuItem.Name = "CustomerReportsToolStripMenuItem"
        Me.CustomerReportsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.CustomerReportsToolStripMenuItem.Text = "Customer Reports"
        '
        'ProductReportsToolStripMenuItem
        '
        Me.ProductReportsToolStripMenuItem.Name = "ProductReportsToolStripMenuItem"
        Me.ProductReportsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.ProductReportsToolStripMenuItem.Text = "Product Reports"
        '
        'DoctorReportsToolStripMenuItem
        '
        Me.DoctorReportsToolStripMenuItem.Name = "DoctorReportsToolStripMenuItem"
        Me.DoctorReportsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.DoctorReportsToolStripMenuItem.Text = "Doctor Reports"
        '
        'SalesReportsToolStripMenuItem
        '
        Me.SalesReportsToolStripMenuItem.Name = "SalesReportsToolStripMenuItem"
        Me.SalesReportsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.SalesReportsToolStripMenuItem.Text = "Sales Reports"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(59, 29)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMeToolStripMenuItem1, Me.AboutSoftwareToolStripMenuItem})
        Me.AboutMeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutMeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.AboutMeToolStripMenuItem.Text = "About Us"
        '
        'AboutMeToolStripMenuItem1
        '
        Me.AboutMeToolStripMenuItem1.Name = "AboutMeToolStripMenuItem1"
        Me.AboutMeToolStripMenuItem1.Size = New System.Drawing.Size(239, 30)
        Me.AboutMeToolStripMenuItem1.Text = "About Me"
        '
        'AboutSoftwareToolStripMenuItem
        '
        Me.AboutSoftwareToolStripMenuItem.Name = "AboutSoftwareToolStripMenuItem"
        Me.AboutSoftwareToolStripMenuItem.Size = New System.Drawing.Size(239, 30)
        Me.AboutSoftwareToolStripMenuItem.Text = "About Software"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(991, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1475, 38)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 55)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 96)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1680, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1735, 558)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDDctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITDoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutSoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
