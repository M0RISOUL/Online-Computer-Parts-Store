Imports System.Data.OleDb
Public Class AdminForm
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs) Handles btninventory.Click

        InventoryForm.Show()
    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Customer Records of Seller's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Customer Records"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        Record_Customer.Show()
    End Sub

    Private Sub btnsupplier_Click(sender As Object, e As EventArgs) Handles btnsupplier.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Supplier Records of Seller's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Supplier Records"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        Record_Supplier.Show()
    End Sub


    Private Sub btnsupplierstore_Click_1(sender As Object, e As EventArgs) Handles btnsupplierstore.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Supplier Store of Seller's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Supplier Store"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        Choosing_Supplier.Show()
    End Sub

    Private Sub btnAuditTrail_Click(sender As Object, e As EventArgs) Handles btnAuditTrail.Click
        AB.Show()
    End Sub

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Logout of Sellers's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Logged Out"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        conn.Close()
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
            loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernames.Trim
            loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Sales Report of Seller's account"
            loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & usernames.Trim & "> Sales Report"
            loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
            loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

            loginAudit.ExecuteNonQuery()
        End Using
        Sales_Report.Show()
    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        graph.Show()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Database_Backup.Show
    End Sub
End Class
