<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.PanelDisplay = New System.Windows.Forms.Panel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnsupplierstore = New System.Windows.Forms.Button()
        Me.btninventory = New System.Windows.Forms.Button()
        Me.btnAuditTrail = New System.Windows.Forms.Button()
        Me.btncustomer = New System.Windows.Forms.Button()
        Me.btnsupplier = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.PanelDisplay.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDisplay
        '
        Me.PanelDisplay.BackColor = System.Drawing.Color.Beige
        Me.PanelDisplay.BackgroundImage = CType(resources.GetObject("PanelDisplay.BackgroundImage"), System.Drawing.Image)
        Me.PanelDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDisplay.Controls.Add(Me.Guna2GradientPanel1)
        Me.PanelDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDisplay.Location = New System.Drawing.Point(0, 0)
        Me.PanelDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDisplay.Name = "PanelDisplay"
        Me.PanelDisplay.Size = New System.Drawing.Size(1297, 1039)
        Me.PanelDisplay.TabIndex = 5
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btnBackup)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnGraph)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSalesReport)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnsupplierstore)
        Me.Guna2GradientPanel1.Controls.Add(Me.btninventory)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnAuditTrail)
        Me.Guna2GradientPanel1.Controls.Add(Me.btncustomer)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnsupplier)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnlogout)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Turquoise
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.SpringGreen
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(268, 1039)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(20, 15)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(227, 110)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 22
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnSalesReport
        '
        Me.btnSalesReport.BackColor = System.Drawing.Color.Teal
        Me.btnSalesReport.FlatAppearance.BorderSize = 0
        Me.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.Image = CType(resources.GetObject("btnSalesReport.Image"), System.Drawing.Image)
        Me.btnSalesReport.Location = New System.Drawing.Point(21, 428)
        Me.btnSalesReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(227, 82)
        Me.btnSalesReport.TabIndex = 16
        Me.btnSalesReport.Text = "SALES REPORT"
        Me.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalesReport.UseVisualStyleBackColor = False
        '
        'btnsupplierstore
        '
        Me.btnsupplierstore.BackColor = System.Drawing.Color.Teal
        Me.btnsupplierstore.FlatAppearance.BorderSize = 0
        Me.btnsupplierstore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsupplierstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupplierstore.Image = CType(resources.GetObject("btnsupplierstore.Image"), System.Drawing.Image)
        Me.btnsupplierstore.Location = New System.Drawing.Point(21, 522)
        Me.btnsupplierstore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsupplierstore.Name = "btnsupplierstore"
        Me.btnsupplierstore.Size = New System.Drawing.Size(227, 82)
        Me.btnsupplierstore.TabIndex = 15
        Me.btnsupplierstore.Text = "SUPPLIER STORE"
        Me.btnsupplierstore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsupplierstore.UseVisualStyleBackColor = False
        '
        'btninventory
        '
        Me.btninventory.BackColor = System.Drawing.Color.Teal
        Me.btninventory.FlatAppearance.BorderSize = 0
        Me.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.Image = CType(resources.GetObject("btninventory.Image"), System.Drawing.Image)
        Me.btninventory.Location = New System.Drawing.Point(21, 146)
        Me.btninventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Size = New System.Drawing.Size(227, 82)
        Me.btninventory.TabIndex = 10
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninventory.UseVisualStyleBackColor = False
        '
        'btnAuditTrail
        '
        Me.btnAuditTrail.BackColor = System.Drawing.Color.Teal
        Me.btnAuditTrail.FlatAppearance.BorderSize = 0
        Me.btnAuditTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditTrail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuditTrail.Image = CType(resources.GetObject("btnAuditTrail.Image"), System.Drawing.Image)
        Me.btnAuditTrail.Location = New System.Drawing.Point(21, 828)
        Me.btnAuditTrail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAuditTrail.Name = "btnAuditTrail"
        Me.btnAuditTrail.Size = New System.Drawing.Size(227, 82)
        Me.btnAuditTrail.TabIndex = 14
        Me.btnAuditTrail.Text = "AUDIT TRAIL"
        Me.btnAuditTrail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAuditTrail.UseVisualStyleBackColor = False
        '
        'btncustomer
        '
        Me.btncustomer.BackColor = System.Drawing.Color.Teal
        Me.btncustomer.FlatAppearance.BorderSize = 0
        Me.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomer.Image = CType(resources.GetObject("btncustomer.Image"), System.Drawing.Image)
        Me.btncustomer.Location = New System.Drawing.Point(21, 239)
        Me.btncustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(227, 82)
        Me.btncustomer.TabIndex = 11
        Me.btncustomer.Text = "RECORDS - CUSTOMER"
        Me.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncustomer.UseVisualStyleBackColor = False
        '
        'btnsupplier
        '
        Me.btnsupplier.BackColor = System.Drawing.Color.Teal
        Me.btnsupplier.FlatAppearance.BorderSize = 0
        Me.btnsupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupplier.Image = CType(resources.GetObject("btnsupplier.Image"), System.Drawing.Image)
        Me.btnsupplier.Location = New System.Drawing.Point(21, 334)
        Me.btnsupplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsupplier.Name = "btnsupplier"
        Me.btnsupplier.Size = New System.Drawing.Size(227, 82)
        Me.btnsupplier.TabIndex = 13
        Me.btnsupplier.Text = "RECORDS - SUPPLIER"
        Me.btnsupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsupplier.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Teal
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.Location = New System.Drawing.Point(21, 924)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(227, 82)
        Me.btnlogout.TabIndex = 12
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnGraph
        '
        Me.btnGraph.BackColor = System.Drawing.Color.Teal
        Me.btnGraph.FlatAppearance.BorderSize = 0
        Me.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraph.Image = CType(resources.GetObject("btnGraph.Image"), System.Drawing.Image)
        Me.btnGraph.Location = New System.Drawing.Point(20, 624)
        Me.btnGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(227, 82)
        Me.btnGraph.TabIndex = 23
        Me.btnGraph.Text = "GRAPH"
        Me.btnGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGraph.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Teal
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.Location = New System.Drawing.Point(20, 725)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(227, 82)
        Me.btnBackup.TabIndex = 24
        Me.btnBackup.Text = "DATABASE BACKUP"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 1039)
        Me.Controls.Add(Me.PanelDisplay)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.PanelDisplay.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDisplay As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnsupplierstore As Button
    Friend WithEvents btninventory As Button
    Friend WithEvents btnAuditTrail As Button
    Friend WithEvents btncustomer As Button
    Friend WithEvents btnsupplier As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnGraph As Button
End Class
