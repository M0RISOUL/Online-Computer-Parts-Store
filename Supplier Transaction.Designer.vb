<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier_Transaction
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier_Transaction))
        Me.rdbtnluzon = New System.Windows.Forms.RadioButton()
        Me.lblmethod = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.rdbtnmindanao = New System.Windows.Forms.RadioButton()
        Me.rdbtnpmaya = New System.Windows.Forms.RadioButton()
        Me.rdbtngcash = New System.Windows.Forms.RadioButton()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbtnbtransfer = New System.Windows.Forms.RadioButton()
        Me.lstprice = New System.Windows.Forms.ListBox()
        Me.rdbtnvisayas = New System.Windows.Forms.RadioButton()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lstordered = New System.Windows.Forms.ListBox()
        Me.groupboxlocation = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox15.SuspendLayout()
        Me.groupboxlocation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbtnluzon
        '
        Me.rdbtnluzon.AutoSize = True
        Me.rdbtnluzon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnluzon.Location = New System.Drawing.Point(28, 34)
        Me.rdbtnluzon.Name = "rdbtnluzon"
        Me.rdbtnluzon.Size = New System.Drawing.Size(160, 24)
        Me.rdbtnluzon.TabIndex = 12
        Me.rdbtnluzon.TabStop = True
        Me.rdbtnluzon.Text = "Luzon (₱100.00)"
        Me.rdbtnluzon.UseVisualStyleBackColor = True
        '
        'lblmethod
        '
        Me.lblmethod.AutoSize = True
        Me.lblmethod.BackColor = System.Drawing.Color.Transparent
        Me.lblmethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmethod.ForeColor = System.Drawing.Color.White
        Me.lblmethod.Location = New System.Drawing.Point(471, 92)
        Me.lblmethod.Name = "lblmethod"
        Me.lblmethod.Size = New System.Drawing.Size(93, 24)
        Me.lblmethod.TabIndex = 73
        Me.lblmethod.Text = "METHOD"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox15.Controls.Add(Me.Label1)
        Me.GroupBox15.Controls.Add(Me.lblTime)
        Me.GroupBox15.Controls.Add(Me.lblDate)
        Me.GroupBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox15.Location = New System.Drawing.Point(26, 20)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(614, 59)
        Me.GroupBox15.TabIndex = 72
        Me.GroupBox15.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "SUPPLIER TRANSACTION"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(509, 21)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 18)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(25, 21)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 18)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "Date"
        '
        'rdbtnmindanao
        '
        Me.rdbtnmindanao.AutoSize = True
        Me.rdbtnmindanao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnmindanao.Location = New System.Drawing.Point(416, 34)
        Me.rdbtnmindanao.Name = "rdbtnmindanao"
        Me.rdbtnmindanao.Size = New System.Drawing.Size(164, 24)
        Me.rdbtnmindanao.TabIndex = 14
        Me.rdbtnmindanao.TabStop = True
        Me.rdbtnmindanao.Text = "Mindanao (₱300)"
        Me.rdbtnmindanao.UseVisualStyleBackColor = True
        '
        'rdbtnpmaya
        '
        Me.rdbtnpmaya.AutoSize = True
        Me.rdbtnpmaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnpmaya.Location = New System.Drawing.Point(19, 73)
        Me.rdbtnpmaya.Name = "rdbtnpmaya"
        Me.rdbtnpmaya.Size = New System.Drawing.Size(98, 24)
        Me.rdbtnpmaya.TabIndex = 1
        Me.rdbtnpmaya.TabStop = True
        Me.rdbtnpmaya.Text = "Paymaya"
        Me.rdbtnpmaya.UseVisualStyleBackColor = True
        '
        'rdbtngcash
        '
        Me.rdbtngcash.AutoSize = True
        Me.rdbtngcash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtngcash.Location = New System.Drawing.Point(19, 114)
        Me.rdbtngcash.Name = "rdbtngcash"
        Me.rdbtngcash.Size = New System.Drawing.Size(79, 24)
        Me.rdbtngcash.TabIndex = 0
        Me.rdbtngcash.TabStop = True
        Me.rdbtngcash.Text = "Gcash"
        Me.rdbtngcash.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(410, 161)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(228, 31)
        Me.txtamount.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ITEM PRICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ORDERED ITEMS"
        '
        'rdbtnbtransfer
        '
        Me.rdbtnbtransfer.AutoSize = True
        Me.rdbtnbtransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnbtransfer.Location = New System.Drawing.Point(19, 34)
        Me.rdbtnbtransfer.Name = "rdbtnbtransfer"
        Me.rdbtnbtransfer.Size = New System.Drawing.Size(135, 24)
        Me.rdbtnbtransfer.TabIndex = 2
        Me.rdbtnbtransfer.TabStop = True
        Me.rdbtnbtransfer.Text = "BankTransfer"
        Me.rdbtnbtransfer.UseVisualStyleBackColor = True
        '
        'lstprice
        '
        Me.lstprice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lstprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprice.FormattingEnabled = True
        Me.lstprice.ItemHeight = 20
        Me.lstprice.Location = New System.Drawing.Point(213, 120)
        Me.lstprice.Name = "lstprice"
        Me.lstprice.Size = New System.Drawing.Size(160, 344)
        Me.lstprice.TabIndex = 9
        '
        'rdbtnvisayas
        '
        Me.rdbtnvisayas.AutoSize = True
        Me.rdbtnvisayas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnvisayas.Location = New System.Drawing.Point(225, 34)
        Me.rdbtnvisayas.Name = "rdbtnvisayas"
        Me.rdbtnvisayas.Size = New System.Drawing.Size(148, 24)
        Me.rdbtnvisayas.TabIndex = 13
        Me.rdbtnvisayas.TabStop = True
        Me.rdbtnvisayas.Text = "Visayas (₱200)"
        Me.rdbtnvisayas.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(406, 134)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(165, 24)
        Me.lbltotal.TabIndex = 6
        Me.lbltotal.Text = "TOTAL AMOUNT:"
        '
        'lstordered
        '
        Me.lstordered.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lstordered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstordered.FormattingEnabled = True
        Me.lstordered.ItemHeight = 20
        Me.lstordered.Location = New System.Drawing.Point(25, 120)
        Me.lstordered.Name = "lstordered"
        Me.lstordered.Size = New System.Drawing.Size(160, 344)
        Me.lstordered.TabIndex = 3
        '
        'groupboxlocation
        '
        Me.groupboxlocation.BackColor = System.Drawing.Color.Transparent
        Me.groupboxlocation.Controls.Add(Me.rdbtnmindanao)
        Me.groupboxlocation.Controls.Add(Me.rdbtnvisayas)
        Me.groupboxlocation.Controls.Add(Me.rdbtnluzon)
        Me.groupboxlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxlocation.ForeColor = System.Drawing.Color.White
        Me.groupboxlocation.Location = New System.Drawing.Point(26, 481)
        Me.groupboxlocation.Name = "groupboxlocation"
        Me.groupboxlocation.Size = New System.Drawing.Size(614, 90)
        Me.groupboxlocation.TabIndex = 15
        Me.groupboxlocation.TabStop = False
        Me.groupboxlocation.Text = "DELIVERY POINT"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbtnbtransfer)
        Me.GroupBox1.Controls.Add(Me.rdbtnpmaya)
        Me.GroupBox1.Controls.Add(Me.rdbtngcash)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(410, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 172)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAYMENT OPTION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnconfirm)
        Me.Panel1.Controls.Add(Me.lblmethod)
        Me.Panel1.Controls.Add(Me.GroupBox15)
        Me.Panel1.Controls.Add(Me.txtamount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lstprice)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lstordered)
        Me.Panel1.Controls.Add(Me.groupboxlocation)
        Me.Panel1.Location = New System.Drawing.Point(36, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 596)
        Me.Panel1.TabIndex = 12
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btnMinimize)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnExit)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Turquoise
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(736, 50)
        Me.Guna2GradientPanel1.TabIndex = 13
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Turquoise
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.SpringGreen
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 712)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(736, 50)
        Me.Guna2GradientPanel2.TabIndex = 14
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnconfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnconfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnconfirm.Location = New System.Drawing.Point(410, 406)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(228, 58)
        Me.btnconfirm.TabIndex = 346
        Me.btnconfirm.Text = "CONFIRM ORDER"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinimize.FillColor = System.Drawing.Color.White
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Black
        Me.btnMinimize.Location = New System.Drawing.Point(635, 10)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(42, 25)
        Me.btnMinimize.TabIndex = 20
        Me.btnMinimize.Text = "__"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(685, 10)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(42, 25)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "X"
        '
        'Supplier_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 762)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supplier_Transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier_Transaction"
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.groupboxlocation.ResumeLayout(False)
        Me.groupboxlocation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdbtnluzon As RadioButton
    Friend WithEvents lblmethod As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents rdbtnmindanao As RadioButton
    Friend WithEvents rdbtnpmaya As RadioButton
    Friend WithEvents rdbtngcash As RadioButton
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbtnbtransfer As RadioButton
    Friend WithEvents lstprice As ListBox
    Friend WithEvents rdbtnvisayas As RadioButton
    Friend WithEvents lbltotal As Label
    Friend WithEvents lstordered As ListBox
    Friend WithEvents groupboxlocation As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
End Class
