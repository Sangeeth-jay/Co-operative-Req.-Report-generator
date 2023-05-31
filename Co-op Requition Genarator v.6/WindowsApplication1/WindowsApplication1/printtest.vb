Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class printtest
    Private mRow As Integer = 0
    Private newpage As Boolean = True

    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Dim con As New OleDbConnection

    Private Sub printtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'CoopDataSet.Court' table. You can move, or remove it, as needed.
        '' Me.CourtTableAdapter.Fill(Me.CoopDataSet.Court)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim date1 As DateTime = DateTime.Parse("2022-10-01")
        Dim date2 As DateTime = DateTime.Parse("2022-10-31")
        Dim societyid As String = 1
        ''Dim tot As Double
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb"
        con.Open()
        da = New OleDbDataAdapter("SELECT D.Case_no, D.Referee_no,C.Creidtor_name, D.Recieved_amount, D.Recieved_date FROM Decision D, Creditor C WHERE (Recieved_date BETWEEN #" + date1 + "# AND #" + date2 + "#) AND  Society_id = " + societyid + " AND  D.Referee_no=C.Referee_no ;", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView


        con.Close()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow
        'stackover flow'

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
        Dim line = ""

        line &= " " & vbCrLf
        line &= "----------------Wellcome---------------" & vbCrLf & vbCrLf
        line &= " " & vbCrLf & vbCrLf

        'e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
        e.Graphics.DrawString("නිකුත් කල දින සිට 30 දිනක් ඇතුළත දී ගෙවිය යුතුයි.", primaryfont, Brushes.Black, leftmargin, topmargin)
        e.Graphics.DrawString("......................වැනි රික්විසිෂන් පත", secondaryfont, Brushes.Black, (Width / 2) - 30, topmargin + 25)
        e.Graphics.DrawString(".....................................................තැන්පත් කරන ලද මුදල් ලබා ගැනීම පිණිසයි.", secfont, Brushes.Black, leftmargin + 20, topmargin + 70)
        e.Graphics.DrawLine(Pens.Black, leftmargin, 145, e.PageBounds.Width - leftmargin, 145)


        Dim x1 = topmargin + 100
        Dim x2 = topmargin + 170
        Dim y1 = leftmargin + 30
        Dim y2 = rightmargin + 30

        e.Graphics.DrawLine(Pens.Black, leftmargin, 150, e.PageBounds.Width - leftmargin, 150)
        e.Graphics.DrawLine(Pens.Black, leftmargin, 220, e.PageBounds.Width - leftmargin, 220)
        e.Graphics.DrawLine(Pens.Black, leftmargin, x1, leftmargin, x2)
        e.Graphics.DrawLine(Pens.Black, leftmargin + 150, x1, leftmargin + 150, x2)
        ''e.Graphics.DrawLine(Pens.Black, leftmargin, 250, e.PageBounds.Width - leftmargin, 250)
        e.Graphics.DrawString("නඩු අංකය", secfont, Brushes.Black, leftmargin + 35, x1 + 30)

        e.Graphics.DrawLine(Pens.Black, leftmargin + 300, x1, leftmargin + 300, x2)
        e.Graphics.DrawString("තීරක අංකය", secfont, Brushes.Black, leftmargin + 180, x1 + 30)

        e.Graphics.DrawLine(Pens.Black, leftmargin + 700, x1, leftmargin + 700, x2)
        e.Graphics.DrawString("විස්තරය", secfont, Brushes.Black, leftmargin + 460, x1 + 30)

        e.Graphics.DrawLine(Pens.Black, leftmargin + 900, x1, leftmargin + 900, x2)
        e.Graphics.DrawString("තැන්පත් කල මුදල", secfont, Brushes.Black, leftmargin + 740, x1 + 30)

        e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - leftmargin, x1, e.PageBounds.Width - leftmargin, x2)
        ''e.Graphics.DrawString("දිනය", secfont, Brushes.Black, leftmargin + 960, x1 + 30)

        With DataGridView1
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter

            Do While mRow < .RowCount
                row = .Rows(mRow)
                x = e.MarginBounds.Left
                h = 0
                For Each cell As DataGridViewCell In row.Cells
                    rc = New Rectangle(x, y + 190, cell.Size.Width, cell.Size.Height)
                    ''e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    'If (newpage) Then
                    x2 = x1 + 100

                    For i As Integer = 0 To DataGridView1.RowCount - 1
                        e.Graphics.DrawString(DataGridView1.Rows(i).Cells(0).Value, primaryregular, Brushes.Black, leftmargin + 35, x2)
                        e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).Value, primaryregular, Brushes.Black, leftmargin + 180, x2)
                        e.Graphics.DrawString(DataGridView1.Rows(i).Cells(2).Value, primaryregular, Brushes.Black, leftmargin + 460, x2)
                        e.Graphics.DrawString(DataGridView1.Rows(i).Cells(3).Value, primaryregular, Brushes.Black, leftmargin + 740, x2)
                    Next

                        'Else
                        '    'e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                        'End If
                        x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0

        End With

    End Sub

    Private Sub print()
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        Dim pagesetup As New PageSettings
        With pagesetup
            .Margins.Right = 50
            .Margins.Left = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        pagesetup.Landscape = True
        PrintDocument1.DefaultPageSettings = pagesetup

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        print()


    End Sub
End Class