Imports System.Data.OleDb
Public Class Inventory_Report
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"
    Private Sub Inventory_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Inventory Report of Buyer's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & ">Inventory Report Opened"
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
            stock101.Text = tbl.Fields(2).Value
            spowersupply = stock101.Text
            If spowersupply <= 5 Then
                status101.BackColor = Color.Red
            ElseIf spowersupply <= 9 Then
                status101.BackColor = Color.Yellow
            Else status101.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 102 & "'")
            stock102.Text = tbl.Fields(2).Value
            scpu = stock102.Text
            If scpu <= 5 Then
                status102.BackColor = Color.Red
            ElseIf scpu <= 9 Then
                status102.BackColor = Color.Yellow
            Else status102.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 103 & "'")
            stock103.Text = tbl.Fields(2).Value
            sfan = stock103.Text
            If sfan <= 5 Then
                status103.BackColor = Color.Red
            ElseIf sfan <= 9 Then
                status103.BackColor = Color.Yellow
            Else status103.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 104 & "'")
            stock104.Text = tbl.Fields(2).Value
            svideocard = stock104.Text
            If svideocard <= 5 Then
                status104.BackColor = Color.Red
            ElseIf svideocard <= 9 Then
                status104.BackColor = Color.Yellow
            Else status104.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 105 & "'")
            stock105.Text = tbl.Fields(2).Value
            ssoundcard = stock105.Text
            If ssoundcard <= 5 Then
                status105.BackColor = Color.Red
            ElseIf ssoundcard <= 9 Then
                status105.BackColor = Color.Yellow
            Else status105.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 106 & "'")
            stock106.Text = tbl.Fields(2).Value
            smotherboard = stock106.Text
            If smotherboard <= 5 Then
                status106.BackColor = Color.Red
            ElseIf smotherboard <= 9 Then
                status106.BackColor = Color.Yellow
            Else status106.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 107 & "'")
            stock107.Text = tbl.Fields(2).Value
            smonitor = stock107.Text
            If smonitor <= 5 Then
                status107.BackColor = Color.Red
            ElseIf smonitor <= 9 Then
                status107.BackColor = Color.Yellow
            Else status107.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 108 & "'")
            stock108.Text = tbl.Fields(2).Value
            skeyboard = stock108.Text
            If skeyboard <= 5 Then
                status108.BackColor = Color.Red
            ElseIf skeyboard <= 9 Then
                status108.BackColor = Color.Yellow
            Else status108.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 109 & "'")
            stock109.Text = tbl.Fields(2).Value
            smouse = stock109.Text
            If smouse <= 5 Then
                status109.BackColor = Color.Red
            ElseIf smouse <= 9 Then
                status109.BackColor = Color.Yellow
            Else status109.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 110 & "'")
            stock110.Text = tbl.Fields(2).Value
            sheadset = stock110.Text
            If sheadset <= 5 Then
                status110.BackColor = Color.Red
            ElseIf sheadset <= 9 Then
                status110.BackColor = Color.Yellow
            Else status110.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 111 & "'")
            stock111.Text = tbl.Fields(2).Value
            sspeaker = stock111.Text
            If sspeaker <= 5 Then
                status111.BackColor = Color.Red
            ElseIf sspeaker <= 9 Then
                status111.BackColor = Color.Yellow
            Else status111.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 112 & "'")
            stock112.Text = tbl.Fields(2).Value
            swebcam = stock112.Text
            If swebcam <= 5 Then
                status112.BackColor = Color.Red
            ElseIf swebcam <= 9 Then
                status112.BackColor = Color.Yellow
            Else status112.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 113 & "'")
            stock113.Text = tbl.Fields(2).Value
            sram = stock113.Text
            If sram <= 5 Then
                status113.BackColor = Color.Red
            ElseIf sram <= 9 Then
                status113.BackColor = Color.Yellow
            Else status113.BackColor = Color.Lime
            End If
        End With
        With tbl
            .MoveFirst()
            .Find("ProductID = '" & 114 & "'")
            stock114.Text = tbl.Fields(2).Value
            sharddiskdrive = stock114.Text
            If sharddiskdrive <= 5 Then
                status114.BackColor = Color.Red
            ElseIf sharddiskdrive <= 9 Then
                status114.BackColor = Color.Yellow
            Else status114.BackColor = Color.Lime
            End If
        End With
    End Sub

    Private Sub exitlogin_Click(sender As Object, e As EventArgs) Handles exitlogin.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Inventory Report of Buyer's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & ">Inventory Report Closed"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        conn.Close()
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
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