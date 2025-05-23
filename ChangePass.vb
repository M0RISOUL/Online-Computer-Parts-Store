Imports System.ComponentModel
Imports System.Data.OleDb
Public Class ChangePass
    Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
    Public Shared UserID As Integer
    Dim ID As Integer

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtConfirmPass.Text <> txtNewPass.Text Then
            MessageBox.Show("PASSWORDS DO NOT MATCH", "INVALID PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim command As String

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        If txtConfirmPass.Text = txtNewPass.Text Then
            command = "UPDATE Account SET [PASSWORD] = @pass WHERE [ID] = @ID"
            Dim updatePass As New OleDbCommand(command, connection)
            updatePass.Parameters.AddWithValue("@PASS", OleDbType.VarChar).Value = txtNewPass.Text.Trim
            updatePass.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = UserID
            updatePass.ExecuteNonQuery()

            Dim count As Integer

            Do
                Dim randomizer As New Random
                ID = randomizer.Next(1000, 9999)

                command = "SELECT COUNT(*) FROM TB_AUDITS WHERE [ID] = @ID"
                Dim countID As New OleDbCommand(command, connection)
                countID.Parameters.AddWithValue("@ID", OleDbType.Integer).Value = ID

                count = Convert.ToInt32(countID.ExecuteScalar())

            Loop While (count > 0)

            'retrieving username
            command = "SELECT [USERNAME] FROM Account WHERE [ID] = @ID"
            Dim getUname As New OleDbCommand(command, connection)
            getUname.Parameters.AddWithValue("ID", OleDbType.Integer).Value = UserID
            Dim username As String = getUname.ExecuteScalar

            'appending audit records to audit trail table
            command = "INSERT INTO TB_AUDITS ( [USERNAME], [ACTION_TYPE], [AUDIT], [DATE], [TIME]) values ( @USERNAME, @ACTIONTYPE, @AUDIT, @DATE, @TIME)"
            Dim insertaudit As New OleDbCommand(command, connection)
            ' insertaudit.Parameters.AddWithValue("@ID", OleDbType.Integer).Value = UserID
            insertaudit.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = username
            insertaudit.Parameters.AddWithValue("@ACTION_TYPE", OleDbType.VarChar).Value = "Password Reset"
            insertaudit.Parameters.AddWithValue("@AUDIT", OleDbType.VarChar).Value = "user : <" & username & "> changed the account's password"
            insertaudit.Parameters.AddWithValue("@DATE", OleDbType.Date).Value = Now.ToShortDateString
            insertaudit.Parameters.AddWithValue("@TIME", OleDbType.Date).Value = Now.ToShortTimeString
            insertaudit.ExecuteNonQuery()

            MessageBox.Show("PASSWORD HAS BEEN CHANGED SUCCESSFULLY", "PASSWORD RESET", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewPass.Clear()
            connection.Close()

            Me.Hide()
        End If
    End Sub
    Private Sub txtNewPass_Validating(sender As Object, e As CancelEventArgs) Handles txtNewPass.Validating
        'validates password length
        If txtNewPass.Text.Length > 0 Then
            If txtNewPass.Text.Length < 8 Then
                MessageBox.Show("YOUR PASSWORD MUST BE AT LEAST 8 CHARACTERS LONG", "PASSWORD TOO SHORT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPass.Clear()
                btnChangePassword.Enabled = False 'disables the button
            Else
                btnChangePassword.Enabled = True 'enables the button
            End If
        Else
            btnChangePassword.Enabled = False 'disables the button
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtConfirmPass.Clear()
        txtNewPass.Clear()
    End Sub

End Class