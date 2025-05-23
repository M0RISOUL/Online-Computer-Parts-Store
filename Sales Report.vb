Imports System.Data.OleDb
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Reflection.Metadata
Imports Document = iTextSharp.text.Document

Public Class Sales_Report
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Sales.mdb"
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="D:\2ND SEM\ADVANCE DATABASE SYSTEMS\project\project\Online Computer Parts Store\bin\Debug\Transactions\Sales.mdb"
    Private Sub Sales_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
    End Sub
    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    'Load Data depends on date time picker 

    Sub sales()
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
        End If

        'Open the connection
        conn.Open()

        'Create a new command with the SQL query and the open connection
        cm = New OleDbCommand("Select OrderID, Order_Date, Customer_ID, [Order Amount], Service, Fee, [Total Amount] From SalesReport where Order_Date BETWEEN #" & Guna2DateTimePicker1.Value.Date & "# and #" & dtpSaleTo.Value.Date & "# Order By Order_Date", conn)

        'Execute the query and get the data reader
        dr = cm.ExecuteReader

        'Loop through the data reader and populate the DataGridView
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("OrderID").ToString, dr.Item("Order_Date").ToString, dr.Item("Customer_ID").ToString, dr.Item("Order Amount").ToString, dr.Item("Service").ToString, dr.Item("Fee").ToString, dr.Item("Total Amount").ToString)
        End While

        'Close the data reader and the connection
        dr.Close()
        conn.Close()
    End Sub


    'ButtonSavetoPDF
    Private Sub SaveasPDF_Click(sender As Object, e As EventArgs) Handles SaveasPDF.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter filename to create PDF!", vbExclamation)
        Else
            ExportDataToPDFTable()
            MsgBox("PDF file succesfully created!", vbInformation)
        End If
    End Sub


    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))

        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("Sales Report: " & Guna2DateTimePicker1.Value.ToString("MM-dd-yyyy") & "  To  " & dtpSaleTo.Value.ToString("MM-dd-yyyy") & vbCr & "Run Date: " & Now, font12Bold))

        doc.Open()
        doc.Add(p1)

        Dim PdfTable As New PdfPTable(7)
        PdfTable.TotalWidth = 490.0F
        PdfTable.LockedWidth = True

        Dim widths As Single() = New Single() {0.4F, 1.0F, 0.8F, 0.7F, 0.8F, 0.8F, 0.8F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1
        PdfTable.SpacingBefore = 2.0F

        Dim PdfCell As PdfPCell = Nothing
        PdfCell = New PdfPCell(New Phrase("OrderID", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)


        PdfCell = New PdfPCell(New Phrase("Order_Date", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase("Customer_ID", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase("Order Amount", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase("Service", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase("Fee", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)

        PdfCell = New PdfPCell(New Phrase("Total Amount", font12Bold))
        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
        PdfTable.AddCell(PdfCell)

        Dim dt As DataTable = getDataTable()

        If dt IsNot Nothing Then
            For rows As Integer = 0 To dt.Rows.Count - 1
                For coloumns As Integer = 0 To dt.Columns.Count - 1
                    PdfCell = New PdfPCell(New Phrase(dt.Rows(rows)(coloumns).ToString, font12Normal))
                    If coloumns = 0 Or coloumns = 1 Or coloumns = 2 Or coloumns = 3 Or coloumns = 4 Or coloumns = 5 Or coloumns = 6 Then

                        PdfCell.HorizontalAlignment = HorizontalAlignment.Right
                    End If
                    PdfTable.AddCell(PdfCell)
                Next
            Next
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub

    Private Function getDataTable() As DataTable
        Dim datatable As New DataTable("MyDataTable")
        Dim datacolumn1 As New DataColumn(DataGridView1.Columns(0).HeaderText.ToString, GetType(String))
        Dim datacolumn2 As New DataColumn(DataGridView1.Columns(1).HeaderText.ToString, GetType(String))
        Dim datacolumn3 As New DataColumn(DataGridView1.Columns(2).HeaderText.ToString, GetType(String))
        Dim datacolumn4 As New DataColumn(DataGridView1.Columns(3).HeaderText.ToString, GetType(String))
        Dim datacolumn5 As New DataColumn(DataGridView1.Columns(4).HeaderText.ToString, GetType(String))
        Dim datacolumn6 As New DataColumn(DataGridView1.Columns(5).HeaderText.ToString, GetType(String))
        Dim datacolumn7 As New DataColumn(DataGridView1.Columns(6).HeaderText.ToString, GetType(String))


        datatable.Columns.Add(datacolumn1)
        datatable.Columns.Add(datacolumn2)
        datatable.Columns.Add(datacolumn3)
        datatable.Columns.Add(datacolumn4)
        datatable.Columns.Add(datacolumn5)
        datatable.Columns.Add(datacolumn6)
        datatable.Columns.Add(datacolumn7)

        Dim dataRow As DataRow
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            dataRow = datatable.NewRow
            dataRow(DataGridView1.Columns(0).HeaderText.ToString) = DataGridView1.Rows(i).Cells(0).Value.ToString
            dataRow(DataGridView1.Columns(1).HeaderText.ToString) = DataGridView1.Rows(i).Cells(1).Value.ToString
            dataRow(DataGridView1.Columns(2).HeaderText.ToString) = DataGridView1.Rows(i).Cells(2).Value.ToString
            dataRow(DataGridView1.Columns(3).HeaderText.ToString) = DataGridView1.Rows(i).Cells(3).Value.ToString
            dataRow(DataGridView1.Columns(4).HeaderText.ToString) = DataGridView1.Rows(i).Cells(4).Value.ToString
            dataRow(DataGridView1.Columns(5).HeaderText.ToString) = DataGridView1.Rows(i).Cells(5).Value.ToString
            dataRow(DataGridView1.Columns(6).HeaderText.ToString) = DataGridView1.Rows(i).Cells(6).Value.ToString

            datatable.Rows.Add(dataRow)
        Next
        datatable.AcceptChanges()
        Return datatable
    End Function

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        sales()
    End Sub

    'clear datagridview 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class