Imports System.Data.OleDb
Public Class Supplier_Transaction
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset

    Dim countingsup As Integer = 1
    Dim itemlistsup As String
    Dim itempricessup As String
    Dim today_datesup As String
    Dim today_timesup As String
    Dim Orderlocsup As String
    Dim deliveryaddsup As Double
    Dim finaltotalsup As Double
    Dim keysup As String
    Dim paymethodsup As String
    Dim paymentconfirmsup As String
    Dim answersup As Integer
    Dim exbalancesup As Integer = 1000000
    Dim currentbalancesup As Double
    Dim pnamesup As String
    Dim pricesup As Double
    Dim productidsup As String
    Dim OrderDatesup As String
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"

    Private Sub SUPPLIER_TRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
        tbl.Open("select * from Supplier", db, ADODB.CursorTypeEnum.adOpenDynamic,
        ADODB.LockTypeEnum.adLockOptimistic)

        If supid = "1006" Then
            With tbl
                .MoveFirst()
                .Find("Supplier_ID = '" & supid & "'")

                supid = .Fields(1).Value
                supname = .Fields(2).Value
                suplocation = .Fields(3).Value
            End With
        ElseIf supid = "1009" Then
            With tbl
                .MoveFirst()
                .Find("Supplier_ID = '" & supid & "'")

                supid = .Fields(1).Value
                supname = .Fields(2).Value
                suplocation = .Fields(3).Value
            End With
        Else
            MessageBox.Show("Something went wrong, Error")
        End If
        db.Close()


        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Store.mdb")
        tbl.Open("select * from Supplier", db, ADODB.CursorTypeEnum.adOpenDynamic,
        ADODB.LockTypeEnum.adLockOptimistic)
        lblTime.Text = TimeOfDay.ToLongTimeString
        lblDate.Text = Today.ToLongDateString
        OrderDatesup = Today.ToShortDateString
        lblmethod.Text = method
        txtamount.Text = Totalsup
        txtamount.Enabled = False
        If method = "DELIVERY" Then

        ElseIf method = "PICKUP" Then
            groupboxlocation.Enabled = False

        End If

        Do Until countingsup > numitemtopass
            If countingsup = 1 Then
                itemlistsup = itempass1
                itempricessup = itemprice1
            ElseIf countingsup = 2 Then
                itemlistsup = itempass2
                itempricessup = itemprice2
            ElseIf countingsup = 3 Then
                itemlistsup = itempass3
                itempricessup = itemprice3
            ElseIf countingsup = 4 Then
                itemlistsup = itempass4
                itempricessup = itemprice4
            ElseIf countingsup = 5 Then
                itemlistsup = itempass5
                itempricessup = itemprice5
            ElseIf countingsup = 6 Then
                itemlistsup = itempass6
                itempricessup = itemprice6
            ElseIf countingsup = 7 Then
                itemlistsup = itempass7
                itempricessup = itemprice7
            ElseIf countingsup = 8 Then
                itemlistsup = itempass8
                itempricessup = itemprice8
            ElseIf countingsup = 9 Then
                itemlistsup = itempass9
                itempricessup = itemprice9
            ElseIf countingsup = 10 Then
                itemlistsup = itempass10
                itempricessup = itemprice10
            ElseIf countingsup = 11 Then
                itemlistsup = itempass11
                itempricessup = itemprice11
            ElseIf countingsup = 12 Then
                itemlistsup = itempass12
                itempricessup = itemprice12
            ElseIf countingsup = 13 Then
                itemlistsup = itempass13
                itempricessup = itemprice13
            ElseIf countingsup = 14 Then
                itemlistsup = itempass14
                itempricessup = itemprice14
            End If
            lstordered.Items.Add(itemlistsup)
            lstprice.Items.Add(itempricessup)
            countingsup = countingsup + 1
        Loop

    End Sub
    Private Sub btnconfirm_Click_1(sender As Object, e As EventArgs) Handles btnconfirm.Click

        If method = "DELIVERY" Then

            If rdbtnluzon.Checked() Then
                Orderlocsup = "Luzon"
                deliveryaddsup = 100
                keysup = "true"
            ElseIf rdbtnvisayas.Checked() Then
                Orderlocsup = "Visayas"
                deliveryaddsup = 200
                keysup = "true"
            ElseIf rdbtnmindanao.Checked() Then
                Orderlocsup = "Mindanao"
                deliveryaddsup = 300
                keysup = "true"
            Else
                keysup = "false"
                answersup = MessageBox.Show("Pick a main point of location (Luzon or Visayas or Mindanao))",
                            "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If answersup = DialogResult.OK Then
                Else
                End If
            End If

            If keysup = "true" Then
                If rdbtnbtransfer.Checked() Then
                    keysup = "true"
                    paymethodsup = "Bank Transfer"
                ElseIf rdbtngcash.Checked() Then
                    keysup = "true"
                    paymethodsup = "Gcash"
                ElseIf rdbtnpmaya.Checked() Then
                    keysup = "true"
                    paymethodsup = "Paymaya"
                Else
                    keysup = "false"
                    answersup = MessageBox.Show("Pick a payment method(Bank Transfer or Gcash or Paymaya)", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If answersup = DialogResult.OK Then
                    Else
                    End If
                End If
            Else
            End If

            If keysup = "true" Then
                answersup = MessageBox.Show("Do you want to confirm your payment?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If answersup = DialogResult.Yes Then

                    finaltotalsup = Totalsup + deliveryaddsup
                    paymentconfirmsup = "true"


                ElseIf answersup = DialogResult.No Then
                Else

                End If
            Else
            End If


        ElseIf method = "PICKUP" Then

            If rdbtnbtransfer.Checked() Then
                keysup = "true"
                paymethodsup = "Bank Transfer"
            ElseIf rdbtngcash.Checked() Then
                keysup = "true"
                paymethodsup = "Gcash"
            ElseIf rdbtnpmaya.Checked() Then
                keysup = "true"
                paymethodsup = "Paymaya"
            Else
                keysup = "false"
                answersup = MessageBox.Show("Pick a payment method(Bank Transfer or Gcash or Paymaya)", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If answersup = DialogResult.OK Then
                Else
                End If
            End If

            If keysup = "true" Then
                answersup = MessageBox.Show("Do you want to confirm your payment?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If answersup = DialogResult.Yes Then
                    finaltotalsup = Totalsup + deliveryaddsup
                    paymentconfirmsup = "true"

                ElseIf answersup = DialogResult.No Then
                Else

                End If
            Else
            End If
        Else
        End If


        If paymentconfirmsup = "true" Then
            today_datesup = lblDate.Text
            today_timesup = lblTime.Text
            today_datesup.ToString()
            today_timesup.ToString()
            currentbalancesup = exbalancesup - (Total + deliveryaddsup)


            MessageBox.Show("Date Ordered: " + lblDate.Text + vbNewLine + "Date Time: " + lblTime.Text + vbNewLine +
                "Vendor_ID: " + supid + "Supplier_ID" + supid + vbNewLine + "Service: " + method + vbNewLine + "Payment Method: " + paymethodsup +
                vbNewLine + "Available Balance: " + exbalancesup.ToString() + vbNewLine + "Current Balance: " + currentbalancesup.ToString() +
                vbNewLine + "Order Amount: " + Total.ToString() + vbNewLine + "Delivery Fee: " + deliveryaddsup.ToString() + vbNewLine + "Total Amount: " +
                                finaltotalsup.ToString())

            For l_index As Integer = 0 To lstordered.Items.Count - 1
                Dim l_text As String = CStr(lstordered.Items(l_index))

                If l_text = "Power Supply" Then
                    pricesup = psupply
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitypsupply = Quantity
                    productidsup = "101"
                    pnamesup = "Power Supply"
                ElseIf l_text = "CPU" Then
                    pricesup = cpu
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitycpu = Quantity
                    productidsup = 102
                    pnamesup = "CPU"
                ElseIf l_text = "Fan" Then
                    pricesup = fan
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityfan = Quantity
                    productidsup = "103"
                    pnamesup = "Fan"
                ElseIf l_text = "Video Card" Then
                    pricesup = vcard
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityvcard = Quantity
                    productidsup = "104"
                    pnamesup = "Video Card"
                ElseIf l_text = "Sound Card" Then
                    pricesup = scard
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityscard = Quantity
                    productidsup = "105"
                    pnamesup = "Sound Card"
                ElseIf l_text = "Motherboard" Then
                    pricesup = mboard
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitymboard = Quantity
                    productidsup = "106"
                    pnamesup = "Motherboard"
                ElseIf l_text = "Monitor" Then
                    pricesup = monitor
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitymonitor = Quantity
                    productidsup = "107"
                    pnamesup = "Monitor"
                ElseIf l_text = "Keyboard" Then
                    pricesup = kboard
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitykboard = Quantity
                    productidsup = "108"
                    pnamesup = "Keyboard"
                ElseIf l_text = "Mouse" Then
                    pricesup = mouse
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitymouse = Quantity
                    productidsup = "109"
                    pnamesup = "Mouse"
                ElseIf l_text = "Headset" Then
                    pricesup = headset
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityhset = Quantity
                    productidsup = "110"
                    pnamesup = "Headset"
                ElseIf l_text = "Speaker" Then
                    pricesup = speaker
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityspeaker = Quantity
                    productidsup = "111"
                    pnamesup = "Speaker"
                ElseIf l_text = "Webcam" Then
                    pricesup = webcam
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantitywebcam = Quantity
                    productidsup = "112"
                    pnamesup = "Webcam"
                ElseIf l_text = "RAM" Then
                    pricesup = ram
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityram = Quantity
                    productidsup = "113"
                    pnamesup = "RAM"
                ElseIf l_text = "Hard Disk Drive" Then
                    pricesup = hdd
                    Quantity = lstprice.Items(l_index) / pricesup
                    quantityhdd = Quantity
                    productidsup = "114"
                    pnamesup = "Hard Disk Drive"
                End If

                tbl.AddNew()

                With tbl
                    .MoveLast()
                    .Fields(1).Value = vendorid
                    .Fields(2).Value = vendorname
                    .Fields(3).Value = supid
                    .Fields(4).Value = supname
                    .Fields(5).Value = suplocation
                    .Fields(6).Value = productidsup
                    .Fields(7).Value = pnamesup
                    .Fields(8).Value = pricesup
                    .Fields(9).Value = Quantity
                    .Update()
                End With

            Next

            db.Close()

            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Sales.mdb")
            tbl.Open("select * from PurchaseReport ", db, ADODB.CursorTypeEnum.adOpenDynamic,
            ADODB.LockTypeEnum.adLockOptimistic)
            tbl.AddNew()
            With tbl
                .MoveLast()
                .Fields(1).Value = OrderDatesup
                .Fields(2).Value = vendorid
                .Fields(3).Value = supid
                .Fields(4).Value = supname
                .Fields(5).Value = suplocation
                .Fields(6).Value = Totalsup
                .Fields(7).Value = method
                .Fields(8).Value = deliveryaddsup
                .Fields(9).Value = paymethodsup
                .Fields(10).Value = finaltotalsup

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
                    spowersupply = spowersupply + quantitypsupply
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 101 & "'")
                        tbl.Fields(2).Value = spowersupply
                        .Update()
                    End With

                ElseIf l_text = "CPU" Then
                    scpu = scpu + quantitycpu
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 102 & "'")
                        tbl.Fields(2).Value = scpu
                        .Update()
                    End With

                ElseIf l_text = "Fan" Then
                    sfan = sfan + quantityfan
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 103 & "'")
                        tbl.Fields(2).Value = sfan
                        .Update()
                    End With

                ElseIf l_text = "Video Card" Then
                    svideocard = svideocard + quantityvcard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 104 & "'")
                        tbl.Fields(2).Value = svideocard
                        .Update()
                    End With

                ElseIf l_text = "Sound Card" Then
                    ssoundcard = ssoundcard + quantityscard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 105 & "'")
                        tbl.Fields(2).Value = ssoundcard
                        .Update()
                    End With

                ElseIf l_text = "Motherboard" Then
                    smotherboard = smotherboard + quantitymboard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 106 & "'")
                        tbl.Fields(2).Value = smotherboard
                        .Update()
                    End With

                ElseIf l_text = "Monitor" Then
                    smonitor = smonitor + quantitymonitor
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 107 & "'")
                        tbl.Fields(2).Value = smonitor
                        .Update()
                    End With

                ElseIf l_text = "Keyboard" Then
                    skeyboard = skeyboard + quantitykboard
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 108 & "'")
                        tbl.Fields(2).Value = skeyboard
                        .Update()
                    End With

                ElseIf l_text = "Mouse" Then
                    smouse = smouse + quantitymouse
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 109 & "'")
                        tbl.Fields(2).Value = smouse
                        .Update()
                    End With

                ElseIf l_text = "Headset" Then
                    sheadset = sheadset + quantityhset
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 110 & "'")
                        tbl.Fields(2).Value = sheadset
                        .Update()
                    End With

                ElseIf l_text = "Speaker" Then
                    sspeaker = sspeaker + quantityspeaker
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 111 & "'")
                        tbl.Fields(2).Value = sspeaker
                        .Update()
                    End With

                ElseIf l_text = "Webcam" Then
                    swebcam = swebcam + quantitywebcam
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 112 & "'")
                        tbl.Fields(2).Value = swebcam
                        .Update()
                    End With

                ElseIf l_text = "RAM" Then
                    sram = sram + quantityram
                    With tbl
                        .MoveFirst()
                        .Find("ProductID = '" & 113 & "'")
                        tbl.Fields(2).Value = sram
                        .Update()
                    End With

                ElseIf l_text = "Hard Disk Drive" Then
                    sharddiskdrive = sharddiskdrive + quantityhdd
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
                loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Confirmed Transaction of Seller's account"
                loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Confirmed"
                loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
                loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

                loginAudit.ExecuteNonQuery()
            End Using
            conn.Close()

            db.Close()

            numitemtopass = 0
            Totalsup = 0
            countingsup = 0
            itemlistsup = ""
            itempricessup = ""
            today_datesup = ""
            today_timesup = ""
            Orderlocsup = ""
            deliveryaddsup = 0
            finaltotalsup = 0
            keysup = ""
            paymethodsup = ""
            paymentconfirmsup = ""
            answersup = 0
            exbalancesup = 0
            currentbalancesup = 0
            pnamesup = ""
            pricesup = 0
            productidsup = ""
            OrderDatesup = ""
            Me.Close()
            Supplier_Store.Close()
            Choosing_Supplier.Close()
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