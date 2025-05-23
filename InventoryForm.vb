Imports System.Data.OleDb
Public Class InventoryForm
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Inventory Form of Buyer's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & ">Inventory Form Opened"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using

        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Inventory.mdb")
        tbl.Open("select * from Products", db, ADODB.CursorTypeEnum.adOpenDynamic,
            ADODB.LockTypeEnum.adLockOptimistic)
        With tbl
    .MoveFirst()
    .Find("ProductID = '" & 101 & "'")
            stockpowersupply.Text = tbl.Fields(2).Value
            spowersupply = stockpowersupply.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 102 & "'")
            stockcpu.Text = tbl.Fields(2).Value
            scpu = stockcpu.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 103 & "'")
            stockfan.Text = tbl.Fields(2).Value
            sfan = stockfan.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 104 & "'")
            stockvideocard.Text = tbl.Fields(2).Value
            svideocard = stockvideocard.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 105 & "'")
            stocksoundcard.Text = tbl.Fields(2).Value
            ssoundcard = stocksoundcard.Text

    End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 106 & "'")
            stockmotherboard.Text = tbl.Fields(2).Value
            smotherboard = stockmotherboard.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 107 & "'")
            stockmonitor.Text = tbl.Fields(2).Value
            smonitor = stockmonitor.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 108 & "'")
            stockkeyboard.Text = tbl.Fields(2).Value
            skeyboard = stockkeyboard.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 109 & "'")
            stockmouse.Text = tbl.Fields(2).Value
            smouse = stockmouse.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 110 & "'")
            stockheadset.Text = tbl.Fields(2).Value
            sheadset = stockheadset.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 111 & "'")
            stockspeaker.Text = tbl.Fields(2).Value
            sspeaker = stockspeaker.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 112 & "'")
            stockwebcam.Text = tbl.Fields(2).Value
            swebcam = stockwebcam.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 113 & "'")
            stockram.Text = tbl.Fields(2).Value
            sram = stockram.Text
        End With
    With tbl
    .MoveFirst()
    .Find("ProductID = '" & 114 & "'")
            stockharddiskdrive.Text = tbl.Fields(2).Value
            sharddiskdrive = stockharddiskdrive.Text
        End With

        If spowersupply = 5 Or scpu = 5 Or sfan = 5 Or svideocard = 5 Or ssoundcard = 5 Or smotherboard = 5 Or
            smonitor = 5 Or skeyboard = 5 Or smouse = 5 Or sheadset = 5 Or sspeaker = 5 Or swebcam = 5 Or
           sram = 5 Or sharddiskdrive = 5 Then '

            MessageBox.Show("There is Product/s that must be replenished" + vbNewLine +
          "Click on the Inventory Report to view", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
        End If

    End Sub
    Dim Answer As String
    Dim num As Integer

    Private Sub btnexits_Click(sender As Object, e As EventArgs) Handles btnexits.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Inventory Form of Buyer's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & ">Inventory Form Closed"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        Me.Close()
    End Sub

    Private Sub btninventoryreport_Click(sender As Object, e As EventArgs) Handles btninventoryreport.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Inventory Form of Buyer's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & ">Inventory Form Closed"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using

        Inventory_Report.Show()
        Me.Close()

    End Sub

    Private Sub btnMaximize_Click_1(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then

            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class