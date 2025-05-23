Public Class Record_Supplier
    Public db As New ADODB.Connection
    Public tbl As New ADODB.Recordset
    Private Sub Record_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlineStoreDataSet.Customer' table. You can move, or remove it, as needed.


        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Store.mdb")
        tbl.Open("select * from Supplier", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        tbl.MoveFirst()
        Call DisplayRecord()
        Call DisabledControl()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim n As String
        n = InputBox("Enter Record here: ")
        With tbl
            .MoveFirst()
            .Find("Records = '" & n & "'")
            If .EOF = True Then
                MsgBox("Record not found")
            Else
                Call DisplayRecord()
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Byte
        ans = MessageBox.Show("Delete Record" & vbNewLine & "Are you
sure...", "Delete", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            tbl.Delete()
            MsgBox("Record Deleted...")
            tbl.MoveFirst()
            Call DisplayRecord()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim objItem As ListViewItem
        tbl.MoveFirst()
        ListView2.Items.Clear()
        Do While tbl.EOF = False
            objItem = ListView2.Items.Add(tbl.Fields(0).Value)
            With objItem
                .SubItems.Add(If(tbl.Fields(1).Value IsNot DBNull.Value, tbl.Fields(1).Value, ""))
                .SubItems.Add(If(tbl.Fields(2).Value IsNot DBNull.Value, tbl.Fields(2).Value, ""))
                .SubItems.Add(If(tbl.Fields(3).Value IsNot DBNull.Value, tbl.Fields(3).Value, ""))
                .SubItems.Add(If(tbl.Fields(4).Value IsNot DBNull.Value, tbl.Fields(4).Value, ""))
                .SubItems.Add(If(tbl.Fields(5).Value IsNot DBNull.Value, tbl.Fields(5).Value, ""))
                .SubItems.Add(If(tbl.Fields(6).Value IsNot DBNull.Value, tbl.Fields(6).Value, ""))
                .SubItems.Add(If(tbl.Fields(7).Value IsNot DBNull.Value, tbl.Fields(7).Value, ""))
                .SubItems.Add(If(tbl.Fields(8).Value IsNot DBNull.Value, tbl.Fields(8).Value, ""))
                .SubItems.Add(If(tbl.Fields(9).Value IsNot DBNull.Value, tbl.Fields(9).Value, ""))
            End With
            tbl.MoveNext()
        Loop
        tbl.MoveFirst()
        Call DisplayRecord()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        tbl.MoveFirst()
        Call DisplayRecord()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        tbl.MoveLast()
        Call DisplayRecord()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        With tbl
            .MoveNext()
            If .EOF = True Then
                MsgBox("end of file encountered...")
                .MoveLast()
            Else
                DisplayRecord()
            End If
        End With
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        tbl.MovePrevious()
        If tbl.BOF = False Then
            DisplayRecord()
        Else
            MessageBox.Show("Beginning of record encountered...")
            tbl.MoveFirst()
        End If
    End Sub
    Private Sub DisplayRecord()
        With tbl
            If Not IsDBNull(.Fields(0).Value) Then txt1.Text = .Fields(0).Value Else txt1.Text = ""
            If Not IsDBNull(.Fields(1).Value) Then txt2.Text = .Fields(1).Value Else txt2.Text = ""
            If Not IsDBNull(.Fields(2).Value) Then txt3.Text = .Fields(2).Value Else txt3.Text = ""
            If Not IsDBNull(.Fields(3).Value) Then txt4.Text = .Fields(3).Value Else txt4.Text = ""
            If Not IsDBNull(.Fields(4).Value) Then txt5.Text = .Fields(4).Value Else txt5.Text = ""
            If Not IsDBNull(.Fields(5).Value) Then txt6.Text = .Fields(5).Value Else txt6.Text = ""
            If Not IsDBNull(.Fields(6).Value) Then txt7.Text = .Fields(6).Value Else txt7.Text = ""
            If Not IsDBNull(.Fields(7).Value) Then txt8.Text = .Fields(7).Value Else txt8.Text = ""
            If Not IsDBNull(.Fields(8).Value) Then txt9.Text = .Fields(8).Value Else txt9.Text = ""
            If Not IsDBNull(.Fields(9).Value) Then txt10.Text = .Fields(9).Value Else txt10.Text = ""

        End With
    End Sub

    Private Sub DisabledControl()
        txt1.Enabled = False
        txt2.Enabled = False
        txt3.Enabled = False
        txt4.Enabled = False
        txt5.Enabled = False
        txt6.Enabled = False
        txt7.Enabled = False
        txt8.Enabled = False
        txt9.Enabled = False
        txt10.Enabled = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            ' Change the form state back to normal when it's maximized
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
End Class