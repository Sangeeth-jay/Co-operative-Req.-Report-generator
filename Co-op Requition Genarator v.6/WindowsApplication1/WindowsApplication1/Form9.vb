Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class Form9
    Dim con As New OleDbConnection
    Dim fullamount As String
    Private mRow As Integer = 0
    Private newpage As Boolean = True

    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim strsql As String
    Dim sidn As String
    Dim sname As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Form1.Enabled = True
        Me.Close()
    End Sub
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        'TODO: This line of code loads data into the 'CoopDataSet.Society' table. You can move, or remove it, as needed.
        Me.SocietyTableAdapter.Fill(Me.CoopDataSet.Society)
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy"

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim date1 As DateTime = DateTime.Parse(d1.Text)
        Dim date2 As DateTime = DateTime.Parse(d2.Text)
        Dim societyid As String = cmbsocietyname.SelectedIndex.ToString() + 1
        ds.Tables.Add(dt)
        Dim tot As Double
        Dim da As New OleDbDataAdapter


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb"
        con.Open()
        da = New OleDbDataAdapter("SELECT Society_name,Full_amount,Print_date from Amount WHERE (Print_date BETWEEN #" + date1 + "# And #" + date2 + "#) AND  Society_id = " + societyid + " ;", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

        'D.Society_id, D.Full_amount, D.Print_date FROM Amount D, Society C WHERE (Print_date BETWEEN #" + date1 + "# And #" + date2 + "#) And  Society_id = " + societyid + "
        con.Close()



        For i As Integer = 0 To DataGridView1.RowCount - 1
            tot += DataGridView1.Rows(i).Cells(1).Value

        Next

        lbltot.Text = tot


    End Sub
    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static intStart As Integer

        Dim fntText As Font = New Font("Times New Roman", 12)

        Dim txtHeight As Integer
        Dim primaryfont As Font = New Font("Algerian", 8)
        Dim primarynumbers As Font = New Font("Times New Roman", 12)
        Dim secfont As Font = New Font("Times New Roman", 10)
        Dim primaryregular As Font = New Font("Times New Roman", 12)
        Dim secondaryfont As Font = New Font("Times New Roman", 16)
        Dim thirdfont As Font = New Font("Times New Roman", 18, FontStyle.Bold)
        Dim topmargin = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim leftmargin = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim rightmargin = PrintDocument1.DefaultPageSettings.Margins.Right
        Dim bottommargin = PrintDocument1.DefaultPageSettings.Margins.Bottom

        txtHeight = PrintDocument1.DefaultPageSettings.PaperSize.Height - PrintDocument1.DefaultPageSettings.Margins.Top - PrintDocument1.DefaultPageSettings.Margins.Bottom - (e.PageBounds.Height - 500)

        '-- Calculate the number of lines per page .25 is just a buffer spacing need to remove the hard coding later and fix it to the font.
        Dim LinesPerPage As Integer = CInt(Math.Round(txtHeight / (50)))

        Dim intLineNumber As Integer = 0



        Dim datel As String = lbldate.Text

        Dim x1 = topmargin + 100
        Dim x2 = topmargin + 170
        Dim y1 = leftmargin + 30
        Dim y2 = rightmargin + 30

        e.Graphics.DrawLine(Pens.Black, leftmargin, 150, e.PageBounds.Width - leftmargin, 150)
        e.Graphics.DrawLine(Pens.Black, leftmargin, 220, e.PageBounds.Width - leftmargin, 220)
        ''e.Graphics.DrawLine(Pens.Black, leftmargin, 220, leftmargin + 900, 220)
        e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - leftmargin, x1, e.PageBounds.Width - leftmargin, x2)
        e.Graphics.DrawLine(Pens.Black, leftmargin, x1, leftmargin, x2)
        e.Graphics.DrawLine(Pens.Black, leftmargin + 150, x1 - 1, leftmargin + 150, x2)
        ''e.Graphics.DrawLine(Pens.Black, leftmargin, 250, e.PageBounds.Width - leftmargin, 250)
        e.Graphics.DrawLine(Pens.Black, leftmargin + 460, x1 - 1, leftmargin + 460, x2)


        e.Graphics.DrawString("සමිති විස්තරය", secondaryfont, Brushes.Black, (Width / 2) + 100, topmargin - 10)


        e.Graphics.DrawString("සමිති‌යේ නම", secfont, Brushes.Black, leftmargin + 660, x1 + 30)

        ''e.Graphics.DrawLine(Pens.Black, leftmargin + 300, x1, leftmargin + 300, x2)
        e.Graphics.DrawString("ගෙවූ මුදල", secfont, Brushes.Black, leftmargin + 250, x1 + 30)

        e.Graphics.DrawLine(Pens.Black, leftmargin + 150, x1, leftmargin + 150, x2)
        e.Graphics.DrawString("රික්විශන් දිනය", secfont, Brushes.Black, leftmargin + 30, x1 + 30)

        ''e.Graphics.DrawLine(Pens.Black, leftmargin + 900, x1, leftmargin + 900, x2)
        e.Graphics.DrawString(datel, secfont, Brushes.Black, e.PageBounds.Width - 100, topmargin)
        Dim pTop = x2
        Dim numRow = DataGridView1.RowCount - 1


        For intCounter = intStart To numRow
            ''e.Graphics.DrawString(intCounter, fntText, Brushes.Black, leftmargin, (fntText.Height * intLineNumber) + topmargin)
            e.Graphics.DrawString(DataGridView1.Rows(intCounter).Cells(0).Value, fntText, Brushes.Black, leftmargin + 540, x2 + 4.5)
            e.Graphics.DrawString(DataGridView1.Rows(intCounter).Cells(1).Value, fntText, Brushes.Black, leftmargin + 210, x2 + 4.5)
            e.Graphics.DrawString(DataGridView1.Rows(intCounter).Cells(2).Value, fntText, Brushes.Black, leftmargin + 35, x2 + 4.5)
            e.Graphics.DrawLine(Pens.Black, leftmargin, x2 + 1, e.PageBounds.Width - leftmargin, x2 + 1)
            intLineNumber += 1
            x2 += 30
            If intLineNumber > LinesPerPage - 1 Then
                '-- Start where we left off.
                intStart = intCounter + 1

                e.HasMorePages = True
                Exit For

            End If
        Next

        ''e.Graphics.DrawLine(Pens.Black, leftmargin + 900, x1, leftmargin + 900, e.PageBounds.Height - 140)
        e.Graphics.DrawLine(Pens.Black, leftmargin, e.PageBounds.Height - 140, e.PageBounds.Width - leftmargin, e.PageBounds.Height - 140)
        e.Graphics.DrawString("රු." + lbltot.Text.ToString() + ".00/=", primarynumbers, Brushes.Black, leftmargin + 180, e.PageBounds.Height - 115)
        e.Graphics.DrawString(" මුලු මුදල :", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 115)
        '' e.Graphics.DrawString(" මුලු මුදල :", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 100)
    End Sub
    Private Sub print()
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        Dim pagesetup As New PageSettings
        With pagesetup
            .Margins.Right = 50
            .Margins.Left = 50
            .Margins.Top = 50
            pagesetup.Landscape = True
            .Margins.Bottom = 50

        End With

        PrintDocument1.DefaultPageSettings = pagesetup

        PrintDocument1.Print()

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Print()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub
End Class