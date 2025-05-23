Imports System.Data.OleDb
Public Class LoginForm
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset
    Dim auditID
    Dim userId
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If




        If String.IsNullOrEmpty(txtUname.Text) Then
            MessageBox.Show("Enter a Username", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf String.IsNullOrEmpty(txtPass.Text) Then
            MessageBox.Show("Enter a Password", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtUname.Text = "admin" And txtPass.Text = "admin" Then
            Dim admin As New AdminForm
            admin.Show()
            Hide()

        Else
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
            tbl.Open("select * from Account", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With tbl
                .MoveFirst()
                .Find("USERNAME = '" & txtUname.Text & "'")
                If .EOF = True Then
                    MessageBox.Show("Account does not exist", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If .Fields(7).Value = txtPass.Text Then
                        'Using createAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)


                        If .Fields(9).Value = "Customer" Then
                            customer_id = .Fields(1).Value
                            fullname = .Fields(2).Value
                            age = .Fields(3).Value
                            address = .Fields(4).Value
                            email = .Fields(5).Value
                            usernames = .Fields(6).Value
                            pass = .Fields(7).Value
                            Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
                                loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUname.Text.Trim
                                loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Login of Buyer's account"
                                loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & txtUname.Text.Trim & "> Logged In"
                                loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
                                loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

                                loginAudit.ExecuteNonQuery()
                            End Using
                            conn.Close()
                            Dim store As New STORE
                            store.Show()
                            Hide()
                            db.Close()
                        ElseIf .Fields(9).Value = "Seller" Then
                            vendorid = .Fields(1).Value
                            vendorname = .Fields(2).Value
                            usernames = .Fields(6).Value
                            Using loginAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
                                loginAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUname.Text.Trim
                                loginAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Login of Seller's account"
                                loginAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & txtUname.Text.Trim & "> Logged In"
                                loginAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
                                loginAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

                                loginAudit.ExecuteNonQuery()
                            End Using
                            conn.Close()
                            Dim admin As New AdminForm
                            admin.Show()
                            Hide()
                            db.Close()

                        End If



                    Else
                        MessageBox.Show("Incorrect Password", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If

            End With
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblReg.LinkClicked
        Dim reg As New RegisterForm
        reg.Show()
        Hide()
    End Sub

    '    Private Sub InsertAuditRecord(userId As Integer, userName As String, userType As String, action As String)
    '   Dim auditID
    '  Dim conn
    ' Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\2ND SEM\ADVANCE DATABASE SYSTEMS\project\project\Online Computer Parts Store\bin\Debug\Online Computer Parts Store.mdb"
    'Using connection As New OleDbConnection(connectionString)
    '       connection.Open()
    '
    '    Using createAudit As New OleDbCommand("INSERT INTO TB_AUDIT ([AUDIT_ID], [USER_ID], [USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES (@AUDIT_ID, @USER_ID, @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
    '               createAudit.Parameters.AddWithValue("@AUDIT_ID", OleDbType.Integer).Value = auditID
    '              ' Add the user ID (if any) to USER_ID parameter
    ''             createAudit.Parameters.AddWithValue("@USER_ID", OleDbType.Integer).Value = userId
    '           createAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = userName
    '          createAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = userType = "Creation of Buyer's account"
    '         createAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = action = "User: <" & txtUname.Text.Trim & "> account has been created"
    '        createAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
    ''       createAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()
    '
    '                createAudit.ExecuteNonQuery()
    '   End Using
    '  End Using
    ' End Sub



    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim forgotPassword As New ForgotPassword
        forgotPassword.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class