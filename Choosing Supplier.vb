Public Class Choosing_Supplier
    Dim Answer As Integer
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If cbosupplier.SelectedIndex = 0 Then
            supid = "1006"
            Supplier_Store.Show()
            Me.Hide()
        ElseIf cbosupplier.SelectedIndex = 1 Then
            supid = "1009"
            Supplier_Store.Show()
            Me.Hide()
        Else
            Answer = MessageBox.Show("You did not choose a Supplier", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Answer = DialogResult.OK Then
            Else
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class