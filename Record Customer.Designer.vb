<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record_Customer))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.RECORDS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CUSTOMER_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CUSTOMER_NAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ADRESS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PRODUCT_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PRODUCT_NAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PRICE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QUANTITY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.txt9 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaximize = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(512, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "AGE:"
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.Location = New System.Drawing.Point(513, 170)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(48, 24)
        Me.txt4.TabIndex = 163
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RECORDS, Me.CUSTOMER_ID, Me.CUSTOMER_NAME, Me.ADRESS, Me.PRODUCT_ID, Me.PRODUCT_NAME, Me.PRICE, Me.QUANTITY})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(72, 416)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1059, 246)
        Me.ListView1.TabIndex = 162
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'RECORDS
        '
        Me.RECORDS.Text = "RECORDS"
        Me.RECORDS.Width = 100
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.Text = "CUSTOMER_ID"
        Me.CUSTOMER_ID.Width = 100
        '
        'CUSTOMER_NAME
        '
        Me.CUSTOMER_NAME.Text = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.Width = 100
        '
        'ADRESS
        '
        Me.ADRESS.Text = "ADRESS"
        Me.ADRESS.Width = 300
        '
        'PRODUCT_ID
        '
        Me.PRODUCT_ID.Text = "PRODUCT_ID"
        Me.PRODUCT_ID.Width = 100
        '
        'PRODUCT_NAME
        '
        Me.PRODUCT_NAME.Text = "PRODUCT_NAME"
        Me.PRODUCT_NAME.Width = 150
        '
        'PRICE
        '
        Me.PRICE.Text = "PRICE"
        Me.PRICE.Width = 100
        '
        'QUANTITY
        '
        Me.QUANTITY.Text = "QUANTITY"
        Me.QUANTITY.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(389, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 84)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "CUSTOMER RECORDS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(79, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "RECORDS:"
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(83, 170)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(90, 24)
        Me.txt1.TabIndex = 159
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.BackColor = System.Drawing.Color.Transparent
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Location = New System.Drawing.Point(1012, 147)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(102, 20)
        Me.a.TabIndex = 158
        Me.a.Text = "QUANTITY:"
        '
        'txt9
        '
        Me.txt9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9.Location = New System.Drawing.Point(1015, 170)
        Me.txt9.Name = "txt9"
        Me.txt9.Size = New System.Drawing.Size(99, 24)
        Me.txt9.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(903, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "PRICE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(723, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "PRODUCT_NAME:"
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.BackColor = System.Drawing.Color.Transparent
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.Color.White
        Me.b.Location = New System.Drawing.Point(577, 147)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(128, 20)
        Me.b.TabIndex = 154
        Me.b.Text = "PRODUCT_ID:"
        '
        'txt8
        '
        Me.txt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8.Location = New System.Drawing.Point(890, 170)
        Me.txt8.Name = "txt8"
        Me.txt8.Size = New System.Drawing.Size(99, 24)
        Me.txt8.TabIndex = 153
        '
        'txt7
        '
        Me.txt7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7.Location = New System.Drawing.Point(726, 170)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(146, 24)
        Me.txt7.TabIndex = 152
        '
        'txt6
        '
        Me.txt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6.Location = New System.Drawing.Point(581, 170)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(115, 24)
        Me.txt6.TabIndex = 151
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(204, 170)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(96, 24)
        Me.txt2.TabIndex = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(557, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "ADDRESS:"
        '
        'txt5
        '
        Me.txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.Location = New System.Drawing.Point(403, 230)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(417, 24)
        Me.txt5.TabIndex = 148
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnView.Location = New System.Drawing.Point(366, 375)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(500, 32)
        Me.btnView.TabIndex = 147
        Me.btnView.Text = "VIEW RECORDS"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLast.Location = New System.Drawing.Point(753, 323)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(113, 35)
        Me.btnLast.TabIndex = 146
        Me.btnLast.Text = "LAST"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrev.Location = New System.Drawing.Point(621, 323)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(113, 35)
        Me.btnPrev.TabIndex = 145
        Me.btnPrev.Text = "PREVIOUS"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNext.Location = New System.Drawing.Point(489, 323)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(113, 35)
        Me.btnNext.TabIndex = 144
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFirst.Location = New System.Drawing.Point(366, 323)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(112, 35)
        Me.btnFirst.TabIndex = 143
        Me.btnFirst.Text = "FIRST"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFind.Location = New System.Drawing.Point(366, 270)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(237, 35)
        Me.btnFind.TabIndex = 142
        Me.btnFind.Text = "FIND"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(623, 270)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(243, 35)
        Me.btnDelete.TabIndex = 141
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(330, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 20)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "CUSTOMER_NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(186, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "CUSTOMER_ID"
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(333, 170)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(155, 24)
        Me.txt3.TabIndex = 138
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btnExit)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnMinimize)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnMaximize)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.SpringGreen
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Turquoise
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1198, 50)
        Me.Guna2GradientPanel1.TabIndex = 165
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
        Me.btnExit.Location = New System.Drawing.Point(1141, 11)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(42, 25)
        Me.btnExit.TabIndex = 356
        Me.btnExit.Text = "X"
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
        Me.btnMinimize.Location = New System.Drawing.Point(1037, 11)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(42, 25)
        Me.btnMinimize.TabIndex = 355
        Me.btnMinimize.Text = "__"
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaximize.FillColor = System.Drawing.Color.White
        Me.btnMaximize.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.Black
        Me.btnMaximize.Location = New System.Drawing.Point(1089, 11)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(42, 25)
        Me.btnMaximize.TabIndex = 354
        Me.btnMaximize.Text = "▢"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Turquoise
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.SpringGreen
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 699)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1198, 50)
        Me.Guna2GradientPanel2.TabIndex = 166
        '
        'Record_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1198, 749)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.txt9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.txt8)
        Me.Controls.Add(Me.txt7)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Record_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record_Customer"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt4 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents RECORDS As ColumnHeader
    Friend WithEvents CUSTOMER_ID As ColumnHeader
    Friend WithEvents CUSTOMER_NAME As ColumnHeader
    Friend WithEvents ADRESS As ColumnHeader
    Friend WithEvents PRODUCT_ID As ColumnHeader
    Friend WithEvents PRODUCT_NAME As ColumnHeader
    Friend WithEvents PRICE As ColumnHeader
    Friend WithEvents QUANTITY As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents a As Label
    Friend WithEvents txt9 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents b As Label
    Friend WithEvents txt8 As TextBox
    Friend WithEvents txt7 As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt5 As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
End Class
