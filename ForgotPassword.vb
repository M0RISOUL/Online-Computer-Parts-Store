Imports System.Data.OleDb
Public Class ForgotPassword

    Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
    Dim resetPass As New ChangePass
    Dim conn

    Private Sub lbltitle_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\2ND SEM\ADVANCE DATABASE SYSTEMS\project\project\Online Computer Parts Store\bin\Debug\Online Computer Parts Store.mdb")
        'tbl.Open("select * from Account", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim command As String = "SELECT * FROM ACCOUNT WHERE [USERNAME] = @USERNAME AND [EMAIL] = @EMAIL"
        Dim ForgotPassword As New OleDbCommand(command, connection)
        ForgotPassword.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUsername.Text.Trim
        ForgotPassword.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = txtEmailAdd.Text.Trim
        Dim count As Integer = ForgotPassword.ExecuteScalar

        command = "SELECT [ID] FROM Account WHERE [USERNAME] = @USERNAME AND [EMAIL] = @EMAIL"
        Dim ID As New OleDbCommand(command, connection)
        ID.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUsername.Text.Trim
        ID.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = txtEmailAdd.Text.Trim

        Dim reader As OleDbDataReader
        reader = ID.ExecuteReader
        reader.Read()

        If count > 0 Then
            resetPass.UserID = reader("ID")
            Me.Hide()
            resetPass.Show()
        Else
            MessageBox.Show("The username or email address you entered is invalid", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmailAdd.Clear()
        End If

        connection.Close()
        Dim login As New LoginForm
        Me.Hide()
    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        btnForgotPassword.Enabled = (txtUsername.Text.Trim() <> "" AndAlso txtEmailAdd.Text.Trim() <> "")
    End Sub

    Private Sub txtEmailAdd_TextChanged(sender As Object, e As EventArgs) Handles txtEmailAdd.TextChanged
        btnForgotPassword.Enabled = (txtUsername.Text.Trim() <> "" AndAlso txtEmailAdd.Text.Trim() <> "")
    End Sub
End Class

