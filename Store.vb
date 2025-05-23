Public Class STORE
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset

    Dim max As Integer
    Dim counter As Integer = 1


    Dim send As String

    Dim item As String
    Dim item1 As String
    Dim item2 As String
    Dim item3 As String
    Dim item4 As String
    Dim item5 As String
    Dim item6 As String
    Dim item7 As String
    Dim item8 As String
    Dim item9 As String
    Dim item10 As String
    Dim item11 As String
    Dim item12 As String
    Dim item13 As String
    Dim item14 As String

    Dim stock As Integer
    Dim Answer As Integer

    Dim pass As String

    Dim max1 As Integer
    Dim max2 As Integer
    Dim max3 As Integer
    Dim max4 As Integer
    Dim max5 As Integer
    Dim max6 As Integer
    Dim max7 As Integer
    Dim max8 As Integer
    Dim max9 As Integer
    Dim max10 As Integer
    Dim max11 As Integer
    Dim max12 As Integer
    Dim max13 As Integer
    Dim max14 As Integer
    Dim max15 As Integer

    Dim itemprice As Double = 0
    Private Sub STORE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Today.ToLongDateString
        lblTime.Text = TimeOfDay.ToLongTimeString

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

        Do While counter <= 14
            If counter = 1 Then
                item1 = "Power Supply"
                item = item1
                stock = spowersupply
            ElseIf counter = 2 Then
                item2 = "CPU"
                item = item2
                stock = scpu
            ElseIf counter = 3 Then
                item3 = "Fan"
                item = item3
                stock = sfan
            ElseIf counter = 4 Then
                item4 = "Video Card"
                item = item4
                stock = svideocard
            ElseIf counter = 5 Then
                item5 = "Sound Card"
                item = item5
                stock = ssoundcard
            ElseIf counter = 6 Then
                item6 = "Motherboard"
                item = item6
                stock = smotherboard
            ElseIf counter = 7 Then
                item7 = "Monitor"
                item = item7
                stock = smonitor
            ElseIf counter = 8 Then
                item8 = "Keyboard"
                item = item8
                stock = skeyboard
            ElseIf counter = 9 Then
                item9 = "Mouse"
                item = item9
                stock = smouse
            ElseIf counter = 10 Then
                item10 = "Headset"
                item = item10
                stock = sheadset
            ElseIf counter = 11 Then
                item11 = "Speaker"
                item = item11
                stock = sspeaker
            ElseIf counter = 12 Then
                item12 = "Webcam"
                item = item12
                stock = swebcam
            ElseIf counter = 13 Then
                item13 = "RAM"
                item = item13
                stock = sram
            ElseIf counter = 14 Then
                item14 = "Hard Disk Drive"
                item = item14
                stock = sharddiskdrive
            Else
            End If


            If stock >= 15 Then
                max = 10
            ElseIf stock = 14 Then
                max = 9
            ElseIf stock = 13 Then
                max = 8
            ElseIf stock = 12 Then
                max = 7
            ElseIf stock = 11 Then
                max = 6
            ElseIf stock = 10 Then
                max = 5
            ElseIf stock = 9 Then
                max = 4
            ElseIf stock = 8 Then
                max = 3
            ElseIf stock = 7 Then
                max = 2
            ElseIf stock = 6 Then
                max = 1
            ElseIf stock <= 5 Then
                max = 0
            Else
            End If


            If item = "Power Supply" Then
                max1 = max
                lblmaxpsupply.Text = max1
            ElseIf item = "CPU" Then
                max2 = max
                lblmaxcpu.Text = max2
            ElseIf item = "Fan" Then
                max3 = max
                lblmaxfan.Text = max3
            ElseIf item = "Video Card" Then
                max4 = max
                lblmaxvcard.Text = max4
            ElseIf item = "Sound Card" Then
                max5 = max
                lblmaxscard.Text = max5
            ElseIf item = "Motherboard" Then
                max6 = max
                lblmaxmboard.Text = max6
            ElseIf item = "Monitor" Then
                max7 = max
                lblmaxmonitor.Text = max7
            ElseIf item = "Keyboard" Then
                max8 = max
                lblmaxkeyboard.Text = max8
            ElseIf item = "Mouse" Then
                max9 = max
                lblmaxmouse.Text = max9
            ElseIf item = "Headset" Then
                max10 = max
                lblmaxheadset.Text = max10
            ElseIf item = "Speaker" Then
                max11 = max
                lblmaxspeaker.Text = max11
            ElseIf item = "Webcam" Then
                max12 = max
                lblmaxwebcam.Text = max12
            ElseIf item = "RAM" Then
                max13 = max
                lblmaxram.Text = max13
            ElseIf item = "Hard Disk Drive" Then
                max14 = max
                lblmaxhdd.Text = max14

            End If
            counter = counter + 1
        Loop
    End Sub

    Private Sub btnbuypsupply_Click(sender As Object, e As EventArgs) Handles btnbuypsupply.Click
        Call BuyButton()
        If pass = "True" Then
            max = max1
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item1)
            Quantity1 = Quantity
            lstPrice.Items.Add(Format(psupply * Quantity1, "Standard"))
            Total += psupply * Quantity1
            txttotal.Text = Total
            btnbuypsupply.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuycpu_Click(sender As Object, e As EventArgs) Handles btnbuycpu.Click
        Call BuyButton()
        If pass = "True" Then
            max = max2
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item2)
            Quantity2 = Quantity
            lstPrice.Items.Add(Format(cpu * Quantity2, "Standard"))
            Total += cpu * Quantity2
            txttotal.Text = Total
            btnbuycpu.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuyfan_Click(sender As Object, e As EventArgs) Handles btnbuyfan.Click
        Call BuyButton()
        If pass = "True" Then
            max = max3
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item3)
            Quantity3 = Quantity
            lstPrice.Items.Add(Format(fan * Quantity3, "Standard"))
            Total += fan * Quantity3
            txttotal.Text = Total
            btnbuyfan.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuyvcard_Click(sender As Object, e As EventArgs) Handles btnbuyvcard.Click
        Call BuyButton()
        If pass = "True" Then
            max = max4
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item4)
            Quantity4 = Quantity
            lstPrice.Items.Add(Format(vcard * Quantity4, "Standard"))
            Total += vcard * Quantity4
            txttotal.Text = Total
            btnbuyvcard.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuyscard_Click(sender As Object, e As EventArgs) Handles btnbuyscard.Click
        Call BuyButton()
        If pass = "True" Then
            max = max5
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item5)
            Quantity5 = Quantity
            lstPrice.Items.Add(Format(scard * Quantity5, "Standard"))
            Total += scard * Quantity5
            txttotal.Text = Total
            btnbuyscard.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuymboard_Click(sender As Object, e As EventArgs) Handles btnbuymboard.Click
        Call BuyButton()
        If pass = "True" Then
            max = max6
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item6)
            Quantity6 = Quantity
            lstPrice.Items.Add(Format(mboard * Quantity6, "Standard"))
            Total += mboard * Quantity6
            txttotal.Text = Total
            btnbuymboard.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuymonitor_Click(sender As Object, e As EventArgs) Handles btnbuymonitor.Click
        Call BuyButton()
        If pass = "True" Then
            max = max7
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item7)
            Quantity7 = Quantity
            lstPrice.Items.Add(Format(monitor * Quantity7, "Standard"))
            Total += monitor * Quantity7
            txttotal.Text = Total
            btnbuymonitor.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuykboard_Click(sender As Object, e As EventArgs) Handles btnbuykboard.Click
        Call BuyButton()
        If pass = "True" Then
            max = max8
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item8)
            Quantity8 = Quantity
            lstPrice.Items.Add(Format(kboard * Quantity8, "Standard"))
            Total += kboard * Quantity8
            txttotal.Text = Total
            btnbuykboard.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuymouse_Click(sender As Object, e As EventArgs) Handles btnbuymouse.Click
        Call BuyButton()
        If pass = "True" Then
            max = max9
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item9)
            Quantity9 = Quantity
            lstPrice.Items.Add(Format(mouse * Quantity9, "Standard"))
            Total += mouse * Quantity9
            txttotal.Text = Total
            btnbuymouse.Enabled = False
        Else
        End If
    End Sub
    Private Sub btnbuyheadset_Click(sender As Object, e As EventArgs) Handles btnbuyheadset.Click
        Call BuyButton()
        If pass = "True" Then
            max = max10
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item10)
            Quantity10 = Quantity
            lstPrice.Items.Add(Format(headset * Quantity10, "Standard"))
            Total += headset * Quantity10
            txttotal.Text = Total
            btnbuyheadset.Enabled = False
        Else
        End If
    End Sub
    Private Sub btnbuyspeaker_Click(sender As Object, e As EventArgs) Handles btnbuyspeaker.Click
        Call BuyButton()
        If pass = "True" Then
            max = max11
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item11)
            Quantity11 = Quantity
            lstPrice.Items.Add(Format(speaker * Quantity11, "Standard"))
            Total += speaker * Quantity11
            txttotal.Text = Total
            btnbuyspeaker.Enabled = False
        Else
        End If
    End Sub


    Private Sub btnbuywebcam_Click(sender As Object, e As EventArgs) Handles btnbuywebcam.Click
        Call BuyButton()
        If pass = "True" Then
            max = max12
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item12)
            Quantity12 = Quantity
            lstPrice.Items.Add(Format(webcam * Quantity12, "Standard"))
            Total += webcam * Quantity12
            txttotal.Text = Total
            btnbuywebcam.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuyram_Click(sender As Object, e As EventArgs) Handles btnbuyram.Click
        Call BuyButton()
        If pass = "True" Then
            max = max13
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item13)
            Quantity13 = Quantity
            lstPrice.Items.Add(Format(ram * Quantity13, "Standard"))
            Total += ram * Quantity13
            txttotal.Text = Total
            btnbuyram.Enabled = False
        Else
        End If
    End Sub

    Private Sub btnbuyhdd_Click(sender As Object, e As EventArgs) Handles btnbuyhdd.Click
        Call BuyButton()
        If pass = "True" Then
            max = max14
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item14)
            Quantity14 = Quantity
            lstPrice.Items.Add(Format(hdd * Quantity14, "Standard"))
            Total += hdd * Quantity14
            txttotal.Text = Total
            btnbuyhdd.Enabled = False
        Else
        End If
    End Sub

    Private Sub BuyButton()
        If cboquantity.SelectedIndex = 0 Then
            Quantity = 1
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 1 Then
            Quantity = 2
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 2 Then
            Quantity = 3
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 3 Then
            Quantity = 4
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 4 Then
            Quantity = 5
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 5 Then
            Quantity = 6
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 6 Then
            Quantity = 7
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 7 Then
            Quantity = 8
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 8 Then
            Quantity = 9
            pass = "True"
        ElseIf cboquantity.SelectedIndex = 9 Then
            Quantity = 10
            pass = "True"
        Else
            pass = "False"
            Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose from 1 to 10 dropbox only",
                                           "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Answer = DialogResult.OK Then
            Else
            End If

        End If

    End Sub


    Private Sub Maximum()
        If max >= 10 Then
            If (Quantity > 0 And Quantity < 11) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                                               "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 9 Then
            If (Quantity > 0 And Quantity < 10) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 8 Then
            If (Quantity > 0 And Quantity < 9) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 7 Then
            If (Quantity > 0 And Quantity < 8) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 6 Then
            If (Quantity > 0 And Quantity < 7) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 5 Then
            If (Quantity > 0 And Quantity < 6) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 4 Then
            If (Quantity > 0 And Quantity < 5) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 3 Then
            If (Quantity > 0 And Quantity < 4) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 2 Then
            If (Quantity > 0 And Quantity < 3) Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        ElseIf max = 1 Then
            If Quantity = 1 Then
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Invalid Quantity Entry" + vbNewLine + "Choose less than or equal the maximum purchase",
                             "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If

        Else
            pass = "False"
            Answer = MessageBox.Show("That Item is out of stock" + vbNewLine, "Error")
            If Answer = DialogResult.OK Then
            Else
            End If

        End If
    End Sub

    Private Sub btnexit_Click_1(sender As Object, e As EventArgs) Handles btnexit.Click

        Answer = MessageBox.Show("Do you want to Exit?" + vbNewLine + "Any entries will be erased at the process",
                        "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If Answer = DialogResult.Yes Then
            Total = 0
            Dim LOGIN As New LoginForm
            LOGIN.Show()
            Hide()
        Else
        End If
    End Sub


    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        lstSold.Items.Clear()
        lstPrice.Items.Clear()
        txttotal.Text = ""
        Total = 0
        btnbuypsupply.Enabled = True
        btnbuycpu.Enabled = True
        btnbuyfan.Enabled = True
        btnbuyvcard.Enabled = True
        btnbuyscard.Enabled = True
        btnbuymboard.Enabled = True
        btnbuymonitor.Enabled = True
        btnbuykboard.Enabled = True
        btnbuymouse.Enabled = True
        btnbuyheadset.Enabled = True
        btnbuyspeaker.Enabled = True
        btnbuywebcam.Enabled = True
        btnbuyram.Enabled = True
        btnbuyhdd.Enabled = True
        rdbtndelivery.Checked = False
        rdbtnpickup.Checked = False

    End Sub

    Private Sub continues_Click(sender As Object, e As EventArgs) Handles continues.Click



        If Total = 0 Or Total < 1000 Then
            pass = "False"
            Answer = MessageBox.Show("Minimum amount must be 1000", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Answer = DialogResult.OK Then
            Else
            End If

        Else

            If rdbtndelivery.Checked Then
                method = "DELIVERY"
                pass = "True"
            ElseIf rdbtnpickup.Checked Then
                method = "PICKUP"
                pass = "True"
            Else
                pass = "False"
                Answer = MessageBox.Show("Choose at the bottom of the tab if you want a Delivery or Pickup Method", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Answer = DialogResult.OK Then
                Else
                End If
            End If
        End If


        If pass = "True" Then
            Answer = MessageBox.Show("Do you want to continue?" + vbNewLine + "Entries at this tab will be used at the next steps", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Answer = DialogResult.Yes Then
                Dim TRANSACT As New TransactionForm
                For l_index As Integer = 0 To lstSold.Items.Count - 1
                    Dim l_text As String = CStr(lstSold.Items(l_index))
                    If l_index = 0 Then
                        itempass1 = l_text
                    ElseIf l_index = 1 Then
                        itempass2 = l_text
                    ElseIf l_index = 2 Then
                        itempass3 = l_text
                    ElseIf l_index = 3 Then
                        itempass4 = l_text
                    ElseIf l_index = 4 Then
                        itempass5 = l_text
                    ElseIf l_index = 5 Then
                        itempass6 = l_text
                    ElseIf l_index = 6 Then
                        itempass7 = l_text
                    ElseIf l_index = 7 Then
                        itempass8 = l_text
                    ElseIf l_index = 8 Then
                        itempass9 = l_text
                    ElseIf l_index = 9 Then
                        itempass10 = l_text
                    ElseIf l_index = 10 Then
                        itempass11 = l_text
                    ElseIf l_index = 11 Then
                        itempass12 = l_text
                    ElseIf l_index = 12 Then
                        itempass13 = l_text
                    ElseIf l_index = 13 Then
                        itempass14 = l_text
                    Else
                    End If

                    For l_index2 As Integer = 0 To lstPrice.Items.Count - 1
                        Dim l_price As String = CStr(lstPrice.Items(l_index2))
                        If l_index2 = 0 Then
                            itemprice1 = l_price
                        ElseIf l_index2 = 1 Then
                            itemprice2 = l_price
                        ElseIf l_index2 = 2 Then
                            itemprice3 = l_price
                        ElseIf l_index2 = 3 Then
                            itemprice4 = l_price
                        ElseIf l_index2 = 4 Then
                            itemprice5 = l_price
                        ElseIf l_index2 = 5 Then
                            itemprice6 = l_price
                        ElseIf l_index2 = 6 Then
                            itemprice7 = l_price
                        ElseIf l_index2 = 7 Then
                            itemprice8 = l_price
                        ElseIf l_index2 = 8 Then
                            itemprice9 = l_price
                        ElseIf l_index2 = 9 Then
                            itemprice10 = l_price
                        ElseIf l_index2 = 10 Then
                            itemprice11 = l_price
                        ElseIf l_index2 = 11 Then
                            itemprice12 = l_price
                        ElseIf l_index2 = 12 Then
                            itemprice13 = l_price
                        ElseIf l_index2 = 13 Then
                            itemprice14 = l_price
                        End If

                    Next
                    numitemtopass = numitemtopass + 1
                Next
                TRANSACT.Show()
                Hide()


            ElseIf Answer = DialogResult.No Then

            Else
            End If

        Else
        End If
    End Sub

    Private Sub btnMaximize_Click_1(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            ' Change the form state back to normal when it's maximized
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Call BuyButton()
        If pass = "True" Then
            max = max13
            Call Maximum()
        Else
        End If
        If pass = "True" Then
            lstSold.Items.Add(item13)
            Quantity13 = Quantity
            lstPrice.Items.Add(Format(ram * Quantity13, "Standard"))
            Total += ram * Quantity13
            txttotal.Text = Total
            btnbuyram.Enabled = False
        Else
        End If
    End Sub
End Class