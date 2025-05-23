Imports System.Data.OleDb

Public Class TransactionForm
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset

    Dim counting As Integer = 1
    Dim itemlist As String
    Dim itemprices As String
    Dim today_date As String
    Dim today_time As String
    Dim Orderloc As String
    Dim deliveryadd As Double
    Dim finaltotal As Double
    Dim key As String
    Dim paymethod As String
    Dim paymentconfirm As String
    Dim answer As Integer
    Dim exbalance As Integer = 1000000
    Dim currentbalance As Double
    Dim pname As String
    Dim price As Double
    Dim productid As String
    Dim OrderDate As String

    Dim wallet As Double

    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"
    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
        tbl.Open("select * from WALLET", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        With tbl
            .MoveFirst()
            .Find("USERNAME = '" & usernames & "'")
            wallet = tbl.Fields(2).Value
            exbalance = wallet
        End With
        db.Close()
        'table
        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Store.mdb")
        tbl.Open("select * from Customer", db, ADODB.CursorTypeEnum.adOpenDynamic,
        ADODB.LockTypeEnum.adLockOptimistic)

        lblTime.Text = TimeOfDay.ToLongTimeString
        lblDate.Text = Today.ToLongDateString
        OrderDate = Today.ToShortDateString
        lblmethod.Text = method
        txtamount.Text = Total
        txtamount.Enabled = False
        If method = "DELIVERY" Then

        ElseIf method = "PICKUP" Then
            groupboxlocation.Enabled = False

        End If


        Do Until counting > numitemtopass
            If counting = 1 Then
                itemlist = itempass1
                itemprices = itemprice1
            ElseIf counting = 2 Then
                itemlist = itempass2
                itemprices = itemprice2
            ElseIf counting = 3 Then
                itemlist = itempass3
                itemprices = itemprice3
            ElseIf counting = 4 Then
                itemlist = itempass4
                itemprices = itemprice4
            ElseIf counting = 5 Then
                itemlist = itempass5
                itemprices = itemprice5
            ElseIf counting = 6 Then
                itemlist = itempass6
                itemprices = itemprice6
            ElseIf counting = 7 Then
                itemlist = itempass7
                itemprices = itemprice7
            ElseIf counting = 8 Then
                itemlist = itempass8
                itemprices = itemprice8
            ElseIf counting = 9 Then
                itemlist = itempass9
                itemprices = itemprice9
            ElseIf counting = 10 Then
                itemlist = itempass10
                itemprices = itemprice10
            ElseIf counting = 11 Then
                itemlist = itempass11
                itemprices = itemprice11
            ElseIf counting = 12 Then
                itemlist = itempass12
                itemprices = itemprice12
            ElseIf counting = 13 Then
                itemlist = itempass13
                itemprices = itemprice13
            ElseIf counting = 14 Then
                itemlist = itempass14
                itemprices = itemprice14
            End If
            lstordered.Items.Add(itemlist)
            lstprice.Items.Add(itemprices)
            counting = counting + 1
        Loop

    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If method = "DELIVERY" Then

            If rdbtnluzon.Checked() Then
                Orderloc = "Luzon"
                deliveryadd = 100
                key = "true"
            ElseIf rdbtnvisayas.Checked() Then
                Orderloc = "Visayas"
                deliveryadd = 200
                key = "true"
            ElseIf rdbtnmindanao.Checked() Then
                Orderloc = "Mindanao"
                deliveryadd = 300
                key = "true"
            Else
                key = "false"
                answer = MessageBox.Show("Pick a main point of location (Luzon or Visayas or Mindanao))",
                            "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If answer = DialogResult.OK Then
                Else
                End If
            End If

            If key = "true" Then
                If rdbtnbtransfer.Checked() Then
                    key = "true"
                    paymethod = "Bank Transfer"
                ElseIf rdbtngcash.Checked() Then
                    key = "true"
                    paymethod = "Gcash"
                ElseIf rdbtnpmaya.Checked() Then
                    key = "true"
                    paymethod = "Paymaya"
                Else
                    key = "false"
                    answer = MessageBox.Show("Pick a payment method(Bank Transfer or Gcash or Paymaya)", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If answer = DialogResult.OK Then
                    Else
                    End If
                End If
            Else
            End If

            If key = "true" Then
                answer = MessageBox.Show("Do you want to confirm your payment?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If answer = DialogResult.Yes Then

                    finaltotal = Total + deliveryadd
                    paymentconfirm = "true"


                ElseIf answer = DialogResult.No Then
                Else

                End If
            Else
            End If


        ElseIf method = "PICKUP" Then

            If rdbtnbtransfer.Checked() Then
                key = "true"
                paymethod = "Bank Transfer"
            ElseIf rdbtngcash.Checked() Then
                key = "true"
                paymethod = "Gcash"
            ElseIf rdbtnpmaya.Checked() Then
                key = "true"
                paymethod = "Paymaya"
            Else
                key = "false"
                answer = MessageBox.Show("Pick a payment method(Bank Transfer or Gcash or Paymaya)", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If answer = DialogResult.OK Then
                Else
                End If
            End If

            If key = "true" Then
                answer = MessageBox.Show("Do you want to confirm your payment?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If answer = DialogResult.Yes Then
                    finaltotal = Total + deliveryadd
                    paymentconfirm = "true"

                ElseIf answer = DialogResult.No Then
                Else

                End If
            Else
            End If
        Else
        End If

        If paymentconfirm = "true" Then
            today_date = lblDate.Text
            today_time = lblTime.Text
            today_date.ToString()
            today_time.ToString()


            currentbalance = exbalance - (Total + deliveryadd)


            MessageBox.Show("Date Ordered: " + lblDate.Text + vbNewLine + "Date Time: " + lblTime.Text + vbNewLine +
                "Customer Name: " + fullname + vbNewLine + "Service: " + method + vbNewLine + "Payment Method: " + paymethod +
                vbNewLine + "Available Balance: " + exbalance.ToString() + vbNewLine + "Current Balance: " + currentbalance.ToString() +
                vbNewLine + "Order Amount: " + Total.ToString() + vbNewLine + "Delivery Fee: " + deliveryadd.ToString() + vbNewLine + "Total Amount: " +
                                finaltotal.ToString())

            For l_index As Integer = 0 To lstordered.Items.Count - 1
                Dim l_text As String = CStr(lstordered.Items(l_index))

                If l_text = "Power Supply" Then
                    price = psupply
                    Quantity = lstprice.Items(l_index) / price
                    quantitypsupply = Quantity
                    productid = "101"
                    pname = "Power Supply"
                ElseIf l_text = "CPU" Then
                    price = cpu
                    Quantity = lstprice.Items(l_index) / price
                    quantitycpu = Quantity
                    productid = 102
                    pname = "CPU"
                ElseIf l_text = "Fan" Then
                    price = fan
                    Quantity = lstprice.Items(l_index) / price
                    quantityfan = Quantity
                    productid = "103"
                    pname = "Fan"
                ElseIf l_text = "Video Card" Then
                    price = vcard
                    Quantity = lstprice.Items(l_index) / price
                    quantityvcard = Quantity
                    productid = "104"
                    pname = "Video Card"
                ElseIf l_text = "Sound Card" Then
                    price = scard
                    Quantity = lstprice.Items(l_index) / price
                    quantityscard = Quantity
                    productid = "105"
                    pname = "Sound Card"
                ElseIf l_text = "Motherboard" Then
                    price = mboard
                    Quantity = lstprice.Items(l_index) / price
                    quantitymboard = Quantity
                    productid = "106"
                    pname = "Motherboard"
                ElseIf l_text = "Monitor" Then
                    price = monitor
                    Quantity = lstprice.Items(l_index) / price
                    quantitymonitor = Quantity
                    productid = "107"
                    pname = "Monitor"
                ElseIf l_text = "Keyboard" Then
                    price = kboard
                    Quantity = lstprice.Items(l_index) / price
                    quantitykboard = Quantity
                    productid = "108"
                    pname = "Keyboard"
                ElseIf l_text = "Mouse" Then
                    price = mouse
                    Quantity = lstprice.Items(l_index) / price
                    quantitymouse = Quantity
                    productid = "109"
                    pname = "Mouse"
                ElseIf l_text = "Headset" Then
                    price = headset
                    Quantity = lstprice.Items(l_index) / price
                    quantityhset = Quantity
                    productid = "110"
                    pname = "Headset"
                ElseIf l_text = "Speaker" Then
                    price = speaker
                    Quantity = lstprice.Items(l_index) / price
                    quantityspeaker = Quantity
                    productid = "111"
                    pname = "Speaker"
                ElseIf l_text = "Webcam" Then
                    price = webcam
                    Quantity = lstprice.Items(l_index) / price
                    quantitywebcam = Quantity
                    productid = "112"
                    pname = "Webcam"
                ElseIf l_text = "RAM" Then
                    price = ram
                    Quantity = lstprice.Items(l_index) / price
                    quantityram = Quantity
                    productid = "113"
                    pname = "RAM"
                ElseIf l_text = "Hard Disk Drive" Then
                    price = hdd
                    Quantity = lstprice.Items(l_index) / price
                    quantityhdd = Quantity
                    productid = "114"
                    pname = "Hard Disk Drive"
                End If

                tbl.AddNew()

                With tbl
                    .MoveLast()
                    .Fields(1).Value = customer_id
                    .Fields(2).Value = fullname
                    .Fields(3).Value = age
                    .Fields(4).Value = address
                    .Fields(5).Value = productid
                    .Fields(6).Value = pname
                    .Fields(7).Value = price
                    .Fields(8).Value = Quantity
                    .Update()
                End With

            Next

            db.Close()

            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Sales.mdb")
            tbl.Open("select * from SalesReport ", db, ADODB.CursorTypeEnum.adOpenDynamic,
            ADODB.LockTypeEnum.adLockOptimistic)
            tbl.AddNew()
            With tbl
                .MoveLast()
                .Fields(1).Value = OrderDate
                .Fields(2).Value = customer_id
                .Fields(3).Value = fullname
                .Fields(4).Value = address
                .Fields(5).Value = Total
                .Fields(6).Value = method
                .Fields(7).Value = deliveryadd
                .Fields(8).Value = paymethod
                .Fields(9).Value = finaltotal

                .Update()
            End With

            db.Close()
            'table
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
            tbl.Open("select * from WALLET", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With tbl
                .MoveFirst()
                .Find("USERNAME = '" & usernames & "'")
                tbl.Fields(2).Value = currentbalance
                .Update()
            End With

            db.Close()

            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Inventory.mdb")
            tbl.Open("select * from Products", db, ADODB.CursorTypeEnum.adOpenDynamic,
            ADODB.LockTypeEnum.adLockOptimistic)

            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 101 & "'")
                spowersupply = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 102 & "'")
                scpu = tbl.Fields(2).Value

            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 103 & "'")
                sfan = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 104 & "'")
                svideocard = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 105 & "'")
                ssoundcard = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 106 & "'")
                smotherboard = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 107 & "'")
                smonitor = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 108 & "'")
                skeyboard = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 109 & "'")
                smouse = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 110 & "'")
                sheadset = tbl.Fields(2).Value

            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 111 & "'")
                sspeaker = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 112 & "'")
                swebcam = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 113 & "'")
                sram = tbl.Fields(2).Value
            End With
            With tbl
                .MoveFirst()
                .Find("ProductID = '" & 114 & "'")
                sharddiskdrive = tbl.Fields(2).Value
            End With

            For a_index As Integer = 0 To lstordered.Items.Count - 1
                Dim l_text As String = CStr(lstordered.Items(a_index))

                If l_text = "Power Supply" Then
                    spowersupply = spowersupply - quantitypsupply
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 101 & "'")
                        tbl.Fields(2).Value = spowersupply
                        .Update()
                    End With

                ElseIf l_text = "CPU" Then
                    scpu = scpu - quantitycpu
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 102 & "'")
                        tbl.Fields(2).Value = scpu
                        .Update()
                    End With

                ElseIf l_text = "Fan" Then
                    sfan = sfan - quantityfan
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 103 & "'")
                        tbl.Fields(2).Value = sfan
                        .Update()
                    End With

                ElseIf l_text = "Video Card" Then
                    svideocard = svideocard - quantityvcard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 104 & "'")
                        tbl.Fields(2).Value = svideocard
                        .Update()
                    End With

                ElseIf l_text = "Sound Card" Then
                    ssoundcard = ssoundcard - quantityscard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 105 & "'")
                        tbl.Fields(2).Value = ssoundcard
                        .Update()
                    End With

                ElseIf l_text = "Motherboard" Then
                    smotherboard = smotherboard - quantitymboard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 106 & "'")
                        tbl.Fields(2).Value = smotherboard
                        .Update()
                    End With

                ElseIf l_text = "Monitor" Then
                    smonitor = smonitor - quantitymonitor
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 107 & "'")
                        tbl.Fields(2).Value = smonitor
                        .Update()
                    End With

                ElseIf l_text = "Keyboard" Then
                    skeyboard = skeyboard - quantitykboard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 108 & "'")
                        tbl.Fields(2).Value = skeyboard
                        .Update()
                    End With

                ElseIf l_text = "Mouse" Then
                    smouse = smouse - quantitymouse
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 109 & "'")
                        tbl.Fields(2).Value = smouse
                        .Update()
                    End With

                ElseIf l_text = "Headset" Then
                    sheadset = sheadset - quantityhset
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 110 & "'")
                        tbl.Fields(2).Value = sheadset
                        .Update()
                    End With

                ElseIf l_text = "Speaker" Then
                    sspeaker = sspeaker - quantityspeaker
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 111 & "'")
                        tbl.Fields(2).Value = sspeaker
                        .Update()
                    End With

                ElseIf l_text = "Webcam" Then
                    swebcam = swebcam - quantitywebcam
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 112 & "'")
                        tbl.Fields(2).Value = swebcam
                        .Update()
                    End With

                ElseIf l_text = "RAM" Then
                    sram = sram - quantityram
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 113 & "'")
                        tbl.Fields(2).Value = sram
                        .Update()
                    End With

                ElseIf l_text = "Hard Disk Drive" Then
                    sharddiskdrive = sharddiskdrive - quantityhdd
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 114 & "'")
                        tbl.Fields(2).Value = sharddiskdrive
                        .Update()
                    End With
                End If

            Next
            Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
                loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
                loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Confirmed Transaction of Buyer's account"
                loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Confirmed"
                loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
                loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

                loginAudit.ExecuteNonQuery()
            End Using
            conn.Close()

            numitemtopass = 0
            Total = 0
            counting = 0
            itemlist = ""
            itemprices = ""
            today_date = ""
            today_time = ""
            Orderloc = ""
            deliveryadd = 0
            finaltotal = 0
            key = ""
            paymethod = ""
            paymentconfirm = ""
            answer = 0
            exbalance = 0
            currentbalance = 0
            pname = ""
            price = 0
            productid = ""
            OrderDate = ""
            Me.Close()
            Supplier_Store.Close()
            Choosing_Supplier.Close()

            db.Close()
            LoginForm.Show()
            Me.Hide()
        Else

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
