Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Public Class AB
    Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Online Computer Parts Stores.mdb")
    Private Sub InsertAuditRecord(userId As Integer, userName As String, userType As String, action As String, moduleName As String)
        ' ... (rest of the function)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        'populating listview
        Dim command = "SELECT * FROM TB_AUDITS ORDER BY [DATE] DESC, [TIME] DESC"
        Dim getAudit As New OleDbCommand(command, connection)
        Dim auditReader As OleDbDataReader
        auditReader = getAudit.ExecuteReader

        While (auditReader.Read)
            ' Debugging: Show a message box with the values being read from the database
            Dim debugMessage As String = String.Format("ID: {0}, USERNAME: {1}, USER_TYPE: {2}, AUDIT: {3}, Date: {4}, Time: {5}", auditReader.GetValue(0), auditReader.GetValue(1), auditReader.GetValue(2), auditReader.GetValue(3), auditReader.GetValue(4), auditReader.GetValue(5))
            MessageBox.Show(debugMessage)

            Dim newItem As New ListViewItem
            newItem.Text = auditReader.GetValue(0)
            newItem.SubItems.Add(auditReader.GetValue(1))
            newItem.SubItems.Add(auditReader.GetValue(2))
            newItem.SubItems.Add(auditReader.GetValue(3))
            newItem.SubItems.Add(auditReader.GetValue(4))
            newItem.SubItems.Add(auditReader.GetValue(5))
            lsvAudits.Items.Add(newItem)
        End While

        connection.Close()
    End Sub

    Private Sub AB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Online_Computer_Parts_StoreDataSet.TB_AUDITS' table. You can move, or remove it, as needed.
        Me.TB_AUDITSTableAdapter.Fill(Me.Online_Computer_Parts_StoreDataSet.TB_AUDITS)

        ' Call the InsertAuditRecord function with appropriate values for the parameters
        InsertAuditRecord(username, user_type, audit, adate, time)

        Dim command = "SELECT * FROM TB_AUDITS ORDER BY [DATE] DESC, [TIME] DESC"
        Dim getAudit As New OleDbCommand(command, connection)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            ' Change the form state back to normal when it's maximized
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class