'Public Class Class1
'    Dim mRow As Integer = 0
'    Dim newpage As Boolean = True
'    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
'        With DataGridView1
'            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
'            fmt.LineAlignment = StringAlignment.Center
'            fmt.Trimming = StringTrimming.EllipsisCharacter
'            Dim y As Single = e.MarginBounds.Top
'            Do While mRow < .RowCount
'                Dim row As DataGridViewRow = .Rows(mRow)
'                Dim x As Single = e.MarginBounds.Left
'                Dim h As Single = 0
'                For Each cell As DataGridViewCell In row.Cells
'                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
'                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
'                    If (newpage) Then
'                        e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
'                    Else
'                        e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
'                    End If
'                    x += rc.Width
'                    h = Math.Max(h, rc.Height)
'                Next
'                newpage = False
'                y += h
'                mRow += 1
'                If y + h > e.MarginBounds.Bottom Then
'                    e.HasMorePages = True
'                    mRow -= 1
'                    newpage = True
'                    Exit Sub
'                End If
'            Loop
'            mRow = 0
'        End With
'    End Sub

'    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
'        PrintPreviewDialog1.Document = PrintDocument1
'        PrintPreviewDialog1.ShowDialog()
'    End Sub
''End Class
'Imports System.Data.OleDb
'Imports System.Drawing.Printing

'Public Class Form3

'    Private mRow As Integer = 0
'    Private newpage As Boolean = True

'    Dim pro As String
'    Dim connstring As String
'    Dim command As String
'    Dim myconnection As OleDbConnection = New OleDbConnection

'    Dim con As New OleDbConnection
'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Form1.Enabled = True
'        Me.Close()

'    End Sub

'    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'TODO: This line of code loads data into the 'CoopDataSet.Society' table. You can move, or remove it, as needed.
'        Me.SocietyTableAdapter.Fill(Me.CoopDataSet.Society)
'        Timer1.Enabled = True
'        d1.Format = DateTimePickerFormat.Custom
'        d1.CustomFormat = "dd/MM/yyyy"

'        d2.Format = DateTimePickerFormat.Custom
'        d2.CustomFormat = "dd/MM/yyyy"

'        Timer1.Enabled = True

'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
'    End Sub

'    Private Sub btnCreateR_Click(sender As Object, e As EventArgs) Handles btnCreateR.Click
'        Dim ds As New DataSet
'        Dim dt As New DataTable
'        Dim date1 As DateTime = DateTime.Parse(d1.Text)
'        Dim date2 As DateTime = DateTime.Parse(d2.Text)
'        Dim societyid As String = cmbSocietyName.SelectedIndex.ToString() + 1
'        Dim tot As Double
'        ds.Tables.Add(dt)
'        Dim da As New OleDbDataAdapter


'        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb"
'        con.Open()
'        da = New OleDbDataAdapter("SELECT D.Case_no, D.Referee_no,C.Creidtor_name, D.Recieved_amount, D.Recieved_date FROM Decision D, Creditor C WHERE (Recieved_date BETWEEN #" + date1 + "# AND #" + date2 + "#) AND  Society_id = " + societyid + " AND  D.Referee_no=C.Referee_no ;", con)
'        da.Fill(dt)
'        DataGridView1.DataSource = dt.DefaultView


'        con.Close()

'        For i As Integer = 0 To DataGridView1.RowCount - 1
'            tot += DataGridView1.Rows(i).Cells(3).Value

'        Next

'        lblTot.Text = tot



'    End Sub

'    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage

'        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
'        fmt.LineAlignment = StringAlignment.Center
'        fmt.Trimming = StringTrimming.EllipsisCharacter
'        Dim y As Int32 = e.MarginBounds.Top
'        Dim rc As Rectangle
'        Dim x As Int32
'        Dim h As Int32 = 0
'        Dim row As DataGridViewRow
'        'stackover flow'

'        Dim primaryfont As Font = New Font("Algerian", 8)
'        Dim primarynumbers As Font = New Font("Times New Roman", 12)
'        Dim secfont As Font = New Font("Times New Roman", 10)
'        Dim primaryregular As Font = New Font("Times New Roman", 12)
'        Dim secondaryfont As Font = New Font("Times New Roman", 16)
'        Dim thirdfont As Font = New Font("Times New Roman", 18, FontStyle.Bold)
'        Dim topmargin = PrintDocument2.DefaultPageSettings.Margins.Top
'        Dim leftmargin = PrintDocument2.DefaultPageSettings.Margins.Left
'        Dim rightmargin = PrintDocument2.DefaultPageSettings.Margins.Right
'        Dim bottommargin = PrintDocument2.DefaultPageSettings.Margins.Bottom
'        Dim line = ""

'        line &= " " & vbCrLf
'        line &= "----------------Wellcome---------------" & vbCrLf & vbCrLf
'        line &= " " & vbCrLf & vbCrLf

'        'e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
'        e.Graphics.DrawString("නිකුත් කල දින සිට 30 දිනක් ඇතුළත දී ගෙවිය යුතුයි.", primaryfont, Brushes.Black, leftmargin, topmargin)
'        e.Graphics.DrawString("......................වැනි රික්විසිෂන් පත", secondaryfont, Brushes.Black, (Width / 2) - 30, topmargin + 25)
'        e.Graphics.DrawString("ගාල්ල සමුපකාර සංවර්ධන සහකාර කොමසාරිස් ගිණුමේ තැන්පත් කරන ලද මුදල් ලබා ගැනීම පිණිසයි.", secfont, Brushes.Black, leftmargin + 20, topmargin + 70)
'        e.Graphics.DrawLine(Pens.Black, leftmargin, 145, e.PageBounds.Width - leftmargin, 145)


'        Dim x1 = topmargin + 100
'        Dim x2 = topmargin + 170
'        Dim y1 = leftmargin + 30
'        Dim y2 = rightmargin + 30

'        e.Graphics.DrawLine(Pens.Black, leftmargin, 150, e.PageBounds.Width - leftmargin, 150)
'        e.Graphics.DrawLine(Pens.Black, leftmargin, 220, leftmargin + 900, 220)
'        e.Graphics.DrawLine(Pens.Black, leftmargin, x1, leftmargin, x2)
'        e.Graphics.DrawLine(Pens.Black, leftmargin + 150, x1, leftmargin + 150, x2)
'        ''e.Graphics.DrawLine(Pens.Black, leftmargin, 250, e.PageBounds.Width - leftmargin, 250)
'        e.Graphics.DrawString("නඩු අංකය", secfont, Brushes.Black, leftmargin + 35, x1 + 30)

'        e.Graphics.DrawLine(Pens.Black, leftmargin + 300, x1, leftmargin + 300, x2)
'        e.Graphics.DrawString("තීරක අංකය", secfont, Brushes.Black, leftmargin + 180, x1 + 30)

'        e.Graphics.DrawLine(Pens.Black, leftmargin + 700, x1, leftmargin + 700, x2)
'        e.Graphics.DrawString("විස්තරය", secfont, Brushes.Black, leftmargin + 460, x1 + 30)

'        e.Graphics.DrawLine(Pens.Black, leftmargin + 900, x1, leftmargin + 900, x2)
'        e.Graphics.DrawString("තැන්පත් කල මුදල", secfont, Brushes.Black, leftmargin + 740, x1 + 30)
'        Dim pTop = x2
'        'e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - leftmargin, x1, e.PageBounds.Width - leftmargin, x2)
''e.Graphics.DrawString("දිනය", secfont, Brushes.Black, leftmargin + 960, x1 + 30)

''stack over flow'



''With DataGridView1
''    fmt.LineAlignment = StringAlignment.Center
''    fmt.Trimming = StringTrimming.EllipsisCharacter

''    Do While mRow < .RowCount
''        row = .Rows(mRow)
''        x = e.MarginBounds.Left
''        h = 0
''        For Each cell As DataGridViewCell In row.Cells
''            rc = New Rectangle(x, y + 190, cell.Size.Width, cell.Size.Height)
''            ''e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
''            'If (newpage) Then
''            x2 = x1 + 80

''            For i As Integer = 0 To DataGridView1.RowCount - 1


''                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(0).Value, primarynumbers, Brushes.Black, leftmargin + 35, x2)
''                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).Value, primarynumbers, Brushes.Black, leftmargin + 180, x2)
''                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(2).Value, primarynumbers, Brushes.Black, leftmargin + 460, x2)
''                e.Graphics.DrawString(DataGridView1.Rows(i).Cells(3).Value, primarynumbers, Brushes.Black, leftmargin + 740, x2)

''                x2 += 20

''            Next

''            'Else
''            '    'e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
''            'End If
''            x += rc.Width
''            h = Math.Max(h, rc.Height)
''        Next
''        newpage = False
''        y += h
''        mRow += 1
''        ''
''        If y + h > e.MarginBounds.Bottom Then
''            e.HasMorePages = True
''            mRow -= 1
''            newpage = True
''            Exit Sub
''        End If
''    Loop
''    mRow = 0

''End With

'''trying
''        Dim pagehight = 600
''        Dim Index = 0
''        Dim numRow = DataGridView1.RowCount - 1
''        For i As Integer = 0 To numRow


''            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(0).Value, primarynumbers, Brushes.Black, leftmargin + 35, x2)
''            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).Value, primarynumbers, Brushes.Black, leftmargin + 180, x2)
''            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(2).Value, primarynumbers, Brushes.Black, leftmargin + 460, x2)
''            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(4).Value, primarynumbers, Brushes.Black, leftmargin + 740, x2)

''            x2 += 20
''            If pagehight <= x2 Then
''                e.HasMorePages = True
''                x2 = pTop
''                MessageBox.Show(x2)

''            Else
''                e.HasMorePages = False
''                If i = numRow Then
''                    MessageBox.Show(x2)
''                End If
''            End If

''        Next


''        e.Graphics.DrawLine(Pens.Black, leftmargin + 900, x1, leftmargin + 900, e.PageBounds.Height - 140)
''        e.Graphics.DrawLine(Pens.Black, leftmargin, e.PageBounds.Height - 140, e.PageBounds.Width - leftmargin, e.PageBounds.Height - 140)
''        e.Graphics.DrawString("රු." + lblTot.Text.ToString() + ".00/=", primarynumbers, Brushes.Black, leftmargin + 180, e.PageBounds.Height - 125)
''        e.Graphics.DrawString("ගෙවිය යුතු මුලු මුදල :", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 125)
''        e.Graphics.DrawString("ගෙවිය යුතු මුලු මුදල :", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 100)
''        e.Graphics.DrawString("......................................................", secfont, Brushes.Black, leftmargin + 180, e.PageBounds.Height - 100)
''        e.Graphics.DrawString("සකස් කලේ : ", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 73)
''        e.Graphics.DrawString("......................................................", secfont, Brushes.Black, leftmargin + 180, e.PageBounds.Height - 73)

''        e.Graphics.DrawString("පරීක්ෂා කලේ : ", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 45)
''        e.Graphics.DrawString("...................................................... ", secfont, Brushes.Black, leftmargin + 180, e.PageBounds.Height - 45)

''        e.Graphics.DrawString("අත්සන : ", secfont, Brushes.Black, leftmargin + 430, e.PageBounds.Height - 45)
''        e.Graphics.DrawString("...................................................... ", secfont, Brushes.Black, leftmargin + 500, e.PageBounds.Height - 45)

''        e.Graphics.DrawString("ආයතන මුද්රාව : ", secfont, Brushes.Black, leftmargin + 740, e.PageBounds.Height - 45)
''        e.Graphics.DrawString("...................................................... ", secfont, Brushes.Black, leftmargin + 870, e.PageBounds.Height - 45)

''    End Sub

''    Private Sub print()
''        PrintDialog1.PrinterSettings = PrintDocument2.PrinterSettings
''        '' If PrintDialog1.ShowDialog() = 1 Then
''        PrintDocument2.PrinterSettings = PrintDialog1.PrinterSettings
''        Dim pagesetup As New PageSettings
''        With pagesetup
''            .Margins.Right = 50
''            .Margins.Left = 50
''            .Margins.Top = 50
''            .Margins.Bottom = 50

''        End With

''        pagesetup.Landscape = True
''        PrintDocument2.DefaultPageSettings = pagesetup


''        ''End If
''        PrintPreviewDialog1.Document = PrintDocument2
''        PrintPreviewDialog1.ShowDialog()
''    End Sub

''    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
''        print()


''        pro = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
''        connstring = pro
''        myconnection.ConnectionString = connstring
''        myconnection.Open()
''        command = "INSERT INTO Requision_issue VALUES('" & cmbSocietyName.SelectedIndex + 1 & "','" & lblDate.Text & "','Not Issued','**********','Not Issued') ;"

''        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

''        cmd.Parameters.Add(New OleDbParameter("Society_id", CType(cmbSocietyName.SelectedIndex.ToString() + 1, String)))
''        cmd.Parameters.Add(New OleDbParameter("Report_Print", CType(lblDate.Text, String)))
''        cmd.Parameters.Add(New OleDbParameter("Status", CType("Not Issued", String)))
''        cmd.Parameters.Add(New OleDbParameter("Check_number", CType("**********", String)))
''        cmd.Parameters.Add(New OleDbParameter("Check_Issue_date", CType("Not Issued", String)))



''        Try
''            cmd.ExecuteNonQuery()
''            cmd.Dispose()
''            myconnection.Close()


''        Catch ex As Exception
''            MsgBox(ex.Message)
''        End Try



''    End Sub

''    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
''        Form1.Enabled = True
''    End Sub

''End Class