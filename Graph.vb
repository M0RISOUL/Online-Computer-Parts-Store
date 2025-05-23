Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class graph
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Sales.mdb"

    Private Sub aForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesDataSet1.SalesReport' table. You can move, or remove it, as needed.
        Me.SalesReportTableAdapter.Fill(Me.SalesDataSet1.SalesReport)
        'TODO: This line of code loads data into the 'InventoryDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.InventoryDataSet.Products)

        conn.ConnectionString = dbProvider & dbDataSource
        'loadchart()
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Chart2.Series.Clear()
        Chart2.Series.Add("Series1")

        Dim query As String = "SELECT [Order_Date], COUNT([Total Amount]) AS TOTAL FROM SalesReport GROUP BY [Order_Date]"
        Dim da As New OleDbDataAdapter(query, conn)
        Dim ds As New DataSet

        da.Fill(ds, "Order_Date")

        Dim series1 As Series = Chart2.Series("Series1")
        series1.ChartType = SeriesChartType.Doughnut
        series1.Name = "Order_Date"

        With Chart2
            .DataSource = ds.Tables("Order_Date")
            .Series(series1.Name).XValueMember = "Order_Date"
            .Series(series1.Name).YValueMembers = "TOTAL"
            .Series(0).LabelFormat = "{#,##0}"
            .Series(0).IsValueShownAsLabel = True
            .Series(0)("ColumnLabelStyle") = "Outside"
            .Series(0).BorderWidth = 1
            .Series(0).BorderColor = System.Drawing.Color.Red
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LegendText = "#VALX (#PERCENT)"
        End With
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim db As New ADODB.Connection()
        Dim tbl As New ADODB.Recordset()
        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Store.mdb")
        tbl.Open("select * from Customer", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Store.mdb")
        conn.Open()

        Dim series3 As New Series()
        Chart3.Series.Clear()

        series3.ChartType = SeriesChartType.Column
        Chart3.Series.Add(series3)

        With Chart3
            .Series(0).Palette = ChartColorPalette.SemiTransparent
            .Series(0).BorderColor = Color.Blue
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
        End With

        Dim XAxis As Axis = Chart3.ChartAreas(0).AxisX
        Dim YAxis As Axis = Chart3.ChartAreas(0).AxisY
        XAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        YAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        XAxis.Interval = 1

        Dim table As New DataTable()
        Dim command As New OleDbCommand("SELECT Product_ID, SUM(Price * Quantity) AS TotalPrice FROM Customer GROUP BY Product_ID
", conn)

        Dim da As New OleDbDataAdapter(command)
        table.Clear()
        da.Fill(table)



        '("SELECT TOP 7 Sum([Total Amount]) As TotalAmount, [Order_Date], [Service] FROM [SalesReport] WHERE [Service]=? GROUP BY [Order_Date], [Service] ORDER BY [Order_Date]", conn)
        Dim amt As Integer
        Dim prodID As Integer
        Dim records As String
        Dim price As Integer

        For i = 0 To table.Rows.Count - 1
            prodID = CInt(table(i)("Product_ID"))
            price = CDbl(table(i)("TotalPrice"))
            series3.Points.AddXY(prodID, price)
        Next


        conn.Close()
        tbl.Close()
        db.Close()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim db As New ADODB.Connection()
        Dim tbl As New ADODB.Recordset()
        db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Inventory.mdb")
        tbl.Open("select * from Products", db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jet Boy Abordaje\Downloads\Online Computer Parts Store (3)\Online Computer Parts Store\bin\Debug\Transactions\Inventory.mdb")
        conn.Open()

        Dim series3 As New Series()
        Chart4.Series.Clear()

        series3.ChartType = SeriesChartType.Doughnut
        Chart4.Series.Add(series3)

        With Chart4
            .Series(0).Palette = ChartColorPalette.SemiTransparent
            .Series(0).BorderColor = Color.Blue
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
        End With

        Dim XAxis As Axis = Chart4.ChartAreas(0).AxisX
        Dim YAxis As Axis = Chart4.ChartAreas(0).AxisY
        XAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        YAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        XAxis.Interval = 1

        Dim table As New DataTable()
        Dim command As New OleDbCommand("SELECT Products.[Product Name], Products.Stock FROM Products", conn)

        Dim da As New OleDbDataAdapter(command)
        table.Clear()
        da.Fill(table)

        Dim prodName As String
        Dim stock As Integer

        For i = 0 To table.Rows.Count - 1
            prodName = CStr(table(i)("Product Name"))
            stock = CInt(table(i)("Stock"))
            series3.Points.AddXY(prodName, stock)
        Next

        conn.Close()
        tbl.Close()
        db.Close()
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
