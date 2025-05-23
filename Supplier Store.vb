Public Class Supplier_Store

    Public db As New ADODB.Connection
        Public tbl As New ADODB.Recordset

        Dim counter As Integer = 1

        Dim send As String

        Dim item As String
        Dim item11 As String
        Dim item22 As String
        Dim item33 As String
        Dim item44 As String
        Dim item55 As String
        Dim item66 As String
        Dim item77 As String
        Dim item88 As String
        Dim item99 As String
        Dim item101 As String
        Dim item112 As String
        Dim item123 As String
        Dim item134 As String
        Dim item145 As String

        Dim Answer As Integer

        Dim pass As String



        Dim itemprice As Double = 0
        Private Sub SUPPLIER_STORE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblDate.Text = Today.ToLongDateString
            lblTime.Text = TimeOfDay.ToLongTimeString


            item11 = "Power Supply"
            item22 = "CPU"
            item33 = "Fan"
            item44 = "Video Card"
            item55 = "Sound Card"
            item66 = "Motherboard"
            item77 = "Monitor"
            item88 = "Keyboard"
            item99 = "Mouse"
            item101 = "Headset"
            item112 = "Speaker"
            item123 = "Webcam"
            item134 = "RAM"
            item145 = "Hard Disk Drive"

        End Sub

        Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
            lstSold.Items.Clear()
            lstPrice.Items.Clear()
            txttotal.Text = ""
            Totalsup = 0
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

        End Sub

        Private Sub btnbuypsupply_Click(sender As Object, e As EventArgs) Handles btnbuypsupply.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item11)
                Quantity1 = Quantity
                lstPrice.Items.Add(Format(psupply * Quantity1, "Standard"))
                Totalsup += psupply * Quantity1
                txttotal.Text = Totalsup
                btnbuypsupply.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuycpu_Click(sender As Object, e As EventArgs) Handles btnbuycpu.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item22)
                Quantity2 = Quantity
                lstPrice.Items.Add(Format(cpu * Quantity2, "Standard"))
                Totalsup += cpu * Quantity2
                txttotal.Text = Totalsup
                btnbuycpu.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuyfan_Click(sender As Object, e As EventArgs) Handles btnbuyfan.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item33)
                Quantity3 = Quantity
                lstPrice.Items.Add(Format(fan * Quantity3, "Standard"))
                Totalsup += fan * Quantity3
                txttotal.Text = Totalsup
                btnbuyfan.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuyvcard_Click(sender As Object, e As EventArgs) Handles btnbuyvcard.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item44)
                Quantity4 = Quantity
                lstPrice.Items.Add(Format(vcard * Quantity4, "Standard"))
                Totalsup += vcard * Quantity4
                txttotal.Text = Totalsup
                btnbuyvcard.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuyscard_Click(sender As Object, e As EventArgs) Handles btnbuyscard.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item55)
                Quantity5 = Quantity
                lstPrice.Items.Add(Format(scard * Quantity5, "Standard"))
                Totalsup += scard * Quantity5
                txttotal.Text = Totalsup
                btnbuyscard.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuymboard_Click(sender As Object, e As EventArgs) Handles btnbuymboard.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item66)
                Quantity6 = Quantity
                lstPrice.Items.Add(Format(mboard * Quantity6, "Standard"))
                Totalsup += mboard * Quantity6
                txttotal.Text = Totalsup
                btnbuymboard.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuymonitor_Click(sender As Object, e As EventArgs) Handles btnbuymonitor.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item77)
                Quantity7 = Quantity
                lstPrice.Items.Add(Format(monitor * Quantity7, "Standard"))
                Totalsup += monitor * Quantity7
                txttotal.Text = Totalsup
                btnbuymonitor.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuykboard_Click(sender As Object, e As EventArgs) Handles btnbuykboard.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item88)
                Quantity8 = Quantity
                lstPrice.Items.Add(Format(kboard * Quantity8, "Standard"))
                Totalsup += kboard * Quantity8
                txttotal.Text = Totalsup
                btnbuykboard.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuymouse_Click(sender As Object, e As EventArgs) Handles btnbuymouse.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item99)
                Quantity9 = Quantity
                lstPrice.Items.Add(Format(mouse * Quantity9, "Standard"))
                Totalsup += mouse * Quantity9
                txttotal.Text = Totalsup
                btnbuymouse.Enabled = False
            Else
            End If
        End Sub
        Private Sub btnbuyheadset_Click(sender As Object, e As EventArgs) Handles btnbuyheadset.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item101)
                Quantity10 = Quantity
                lstPrice.Items.Add(Format(headset * Quantity10, "Standard"))
                Totalsup += headset * Quantity10
                txttotal.Text = Totalsup
                btnbuyheadset.Enabled = False
            Else
            End If
        End Sub
        Private Sub btnbuyspeaker_Click(sender As Object, e As EventArgs) Handles btnbuyspeaker.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item112)
                Quantity11 = Quantity
                lstPrice.Items.Add(Format(speaker * Quantity11, "Standard"))
                Totalsup += speaker * Quantity11
                txttotal.Text = Totalsup
                btnbuyspeaker.Enabled = False
            Else
            End If
        End Sub


        Private Sub btnbuywebcam_Click(sender As Object, e As EventArgs) Handles btnbuywebcam.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item123)
                Quantity12 = Quantity
                lstPrice.Items.Add(Format(webcam * Quantity12, "Standard"))
                Totalsup += webcam * Quantity12
                txttotal.Text = Totalsup
                btnbuywebcam.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuyram_Click(sender As Object, e As EventArgs) Handles btnbuyram.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item134)
                Quantity13 = Quantity
                lstPrice.Items.Add(Format(ram * Quantity13, "Standard"))
                Totalsup += ram * Quantity13
                txttotal.Text = Totalsup
                btnbuyram.Enabled = False
            Else
            End If
        End Sub

        Private Sub btnbuyhdd_Click(sender As Object, e As EventArgs) Handles btnbuyhdd.Click
            Call BuyButton()
            If pass = "True" Then
                lstSold.Items.Add(item145)
                Quantity14 = Quantity
                lstPrice.Items.Add(Format(hdd * Quantity14, "Standard"))
                Totalsup += hdd * Quantity14
                txttotal.Text = Totalsup
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




        Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

            Answer = MessageBox.Show("Do you want to Exit?" + vbNewLine + "Any entries will be erased at the process",
                        "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Answer = DialogResult.Yes Then
                Totalsup = 0


                Me.Close()
            Else
            End If
        End Sub


    Private Sub btncontinue_Click(sender As Object, e As EventArgs) Handles btncontinue.Click



        If Totalsup = 0 Then
            pass = "False"
            Answer = MessageBox.Show("You did not buy any product", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                Supplier_Transaction.Show()
                Me.Hide()


            ElseIf Answer = DialogResult.No Then

            Else
            End If

        Else
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

End Class
