Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class RegisterForm
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb"
    Dim auditID As Integer
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset

    Private Sub RegisterFormDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
        tbl.Open("select * from Account", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    End Sub
    Private Sub btnBacktoLogin_Click(sender As Object, e As EventArgs) Handles btnBacktoLogin.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Function ValidateEntry(ByVal Entry) As Boolean
        Dim regEx
        regEx = CreateObject("vbscript.regexp")

        regEx.Pattern = "^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&+=]).*$"

        ValidateEntry = regEx.test(Entry)

        regEx = Nothing

    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        age = txtage.Text

        With tbl
            .MoveFirst()
            .Find("USERNAME = '" & txtUserName.Text & "'")
            If .EOF = True Then
                If txtsss.Text = Nothing Or txtname.Text = Nothing Or txtage.Text = Nothing Or txtaddress.Text = Nothing Or
           txtemail.Text = Nothing Or txtUserName.Text = Nothing Or
           txtPassword.Text = Nothing Or cmbUserType.Text = Nothing Then
                    MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf age < 18 Or age > 100 Then
                    MessageBox.Show("This application can only be used by people with ages from 18 to 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf txtUserName.Text.Length < 8 Then
                    MessageBox.Show("Username must have atleast 8 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf ValidateEntry(txtPassword.Text) = False Then
                    MessageBox.Show("Password must have atleast 8 characters long with atleast one numeric character and uppercase,lowercase and one special character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
                    MessageBox.Show("Password must be the same with Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    tbl.AddNew()

                    With tbl
                        .MoveLast()
                        .Fields(1).Value = txtsss.Text.Trim
                        .Fields(2).Value = txtname.Text.Trim
                        .Fields(3).Value = age
                        .Fields(4).Value = txtaddress.Text.Trim
                        .Fields(5).Value = txtemail.Text.Trim
                        .Fields(6).Value = txtUserName.Text.Trim
                        .Fields(7).Value = txtPassword.Text.Trim
                        .Fields(8).Value = txtConfirmPassword.Text.Trim
                        .Fields(9).Value = cmbUserType.Text.Trim
                        .Update()
                    End With

                    Using createAudit As New OleDbCommand("INSERT INTO TB_AUDITS ([USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) VALUES ( @USERNAME, @ACTION_TYPE, @AUDIT, @DATE, @TIME)", conn)
                        '          createAudit.Parameters.AddWithValue("@AUDIT_ID", OleDbType.Integer).Value = auditID
                        ' Add the user ID (if any) to USER_ID parameter
                        '             createAudit.Parameters.AddWithValue("@USER_ID", OleDbType.Integer).Value = 0
                        createAudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUserName.Text.Trim
                        createAudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Creation of Buyer's account"
                        createAudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "User: <" & txtUserName.Text.Trim & "> account has been created"
                        createAudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString()
                        createAudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString()

                        createAudit.ExecuteNonQuery()
                    End Using
                    db.Close()

                    db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
                    tbl.Open("select * from WALLET", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    Dim walletex As Double = 1000000
                    tbl.AddNew()

                    With tbl
                        .MoveLast()
                        .Fields(1).Value = txtUserName.Text.Trim
                        .Fields(2).Value = walletex
                        .Fields(3).Value = "GCASH"

                        .Update()
                    End With
                    db.Close()
                    MessageBox.Show("Account created!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtsss.Clear()
                    txtname.Clear()
                    txtemail.Clear()
                    txtage.Clear()
                    txtaddress.Clear()
                    txtemail.Clear()
                    txtUserName.Clear()
                    txtPassword.Clear()
                    txtConfirmPassword.Clear()
                    cmbUserType.Text = ""
                    conn.Close()

                    Me.Hide()
                    LoginForm.Show()
                End If

            Else
                MessageBox.Show("Username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




End Class