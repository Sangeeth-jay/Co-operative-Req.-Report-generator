Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Form1
    Dim refereeno As String
    Dim courtno As String
    Dim societyno As String
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Dim ddate As String

    Private Sub AddCreditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCreditorToolStripMenuItem.Click
        Me.Enabled = False
        Form2.Show()

    End Sub

    Private Sub CreateRequisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateRequisionToolStripMenuItem.Click
        Me.Enabled = False
        Form3.Show()

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("yyyy-MM-dd")
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb"
        con.Open()

        validation()


    End Sub

    Private Sub validation()
        Dim date1 As Date = Date.Now.ToString("yyyy-MM-dd")


        Dim stry As String
        stry = "SELECT * FROM Validation ;"

        Dim cmd As New OleDbCommand(stry, con)
        Dim myreader As OleDbDataReader

        myreader = cmd.ExecuteReader
        myreader.Read()

        Dim date2 As Date
        date2 = myreader("Expire_date")

        If date1 >= date2 Then
            Me.Enabled = False
        End If




    End Sub

    Private Sub UpdateRequistionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRequistionToolStripMenuItem.Click
        Me.Enabled = False
        Form4.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Form5.Show()

    End Sub

    Private Sub clear()
        txtCase.Clear()
        lblCourtName.Text = "Name"
        lblSocietyName.Text = "Name"
        lblCreditorName.Text = "Name"
        lblPremium.Text = "0.00"
        lblBalance.Text = "0.00"
        txtRAmount.Clear()
        txtRDate.Clear()

    End Sub

    Private Sub loaddata()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT Referee_no, Recieved_amount, Recieved_date FROM Decision WHERE Case_no =" + txtCase.Text + ";", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView




        'con.Close()



    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        conn.Open()




        Dim strsql As String
        strsql = "SELECT Referee_no,Court_no,Society_no,Creidtor_name,Premium FROM Creditor WHERE Case_no=" + txtCase.Text + ";"
        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        loaddata()

        refereeno = myreader("Referee_no")
        courtno = myreader("Court_no")
        societyno = myreader("Society_no")
        lblCreditorName.Text = myreader("Creidtor_name")
        lblPremium.Text = myreader("Premium")

        Dim csql As String
        csql = "SELECT Court_name FROM Court WHERE Court_id =" + courtno + ";"
        Dim cmd1 As New OleDbCommand(csql, conn)
        Dim myreader1 As OleDbDataReader
        myreader1 = cmd1.ExecuteReader
        myreader1.Read()

        lblCourtName.Text = myreader1("Court_name")

        Dim ssql As String
        ssql = "SELECT Society_name FROM Society WHERE Society_id =" + societyno + ";"
        Dim cmd2 As New OleDbCommand(ssql, conn)
        Dim myreader2 As OleDbDataReader
        myreader2 = cmd2.ExecuteReader
        myreader2.Read()

        lblSocietyName.Text = myreader2("Society_name")





        conn.Close()

        Dim premium As Double
        Dim tot As Double

        premium = lblPremium.Text
        For i As Integer = 0 To DataGridView1.RowCount - 1
            tot = tot + DataGridView1.Rows(i).Cells(1).Value

        Next

        lblBalance.Text = premium - tot






    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pro = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO Decision VALUES('" & txtCase.Text & "' , '" & refereeno & "' , '" & courtno & "' , '" & societyno & "' , '" & txtRAmount.Text & "' , '" & txtRDate.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Case_no", CType(txtCase.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Referee_no", CType(refereeno, String)))
        cmd.Parameters.Add(New OleDbParameter("Court_id", CType(lblCourtName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Society_id", CType(lblSocietyName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Recieved_amount", CType(txtRAmount.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Recieved_date", CType(txtRDate.Text, String)))



        ''MsgBox("Record Updated")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            loaddata()

            clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(e.RowIndex)
        ddate = selectedrow.Cells(2).Value

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim strsql As New OleDbCommand("DELETE FROM Decision WHERE Case_no=" & txtCase.Text & " And Recieved_date=#" & ddate & "#;", con)

        MsgBox("Record Deleted!")

        Try
            strsql.ExecuteNonQuery()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim intResponse As Integer



        intResponse = MsgBox("Are you sure you want to quit?", vbYesNo + vbExclamation, "Quit")



        If intResponse = vbNo Then

            Me.Close()



        End If
    End Sub

    Private Sub CreateBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateBackupToolStripMenuItem.Click
        Form6.Show()
        Me.Enabled = False
    End Sub

    Private Sub UpdateCreditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCreditorToolStripMenuItem.Click
        Form7.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddSocietyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSocietyToolStripMenuItem.Click
        Form8.Show()
        Me.Enabled = False
    End Sub

    Private Sub SocietyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocietyReportToolStripMenuItem.Click
        Form9.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static intstart As Integer

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

        txtHeight = PrintDocument1.DefaultPageSettings.PaperSize.Height - PrintDocument1.DefaultPageSettings.Margins.Top - PrintDocument1.DefaultPageSettings.Margins.Bottom - (e.PageBounds.Height - 1250)

        Dim LinesPerPage As Integer = CInt(Math.Round(txtHeight / (50)))
        Dim intLineNumber As Integer = 0

        e.Graphics.DrawString("ණයකරුගේ විස්තරය", secondaryfont, Brushes.Black, (Width / 2) - 280, topmargin - 20)

        e.Graphics.DrawString("නඩු අංකය       : ", secfont, Brushes.Black, leftmargin, topmargin + 40)
        e.Graphics.DrawString(txtCase.Text, secfont, Brushes.Black, leftmargin + 130, topmargin + 40)
        e.Graphics.DrawString("උසාවිය         : ", secfont, Brushes.Black, leftmargin, topmargin + 60)
        e.Graphics.DrawString(lblCourtName.Text, secfont, Brushes.Black, leftmargin + 130, topmargin + 60)
        e.Graphics.DrawString("සමිතිය         : ", secfont, Brushes.Black, leftmargin, topmargin + 80)
        e.Graphics.DrawString(lblSocietyName.Text, secfont, Brushes.Black, leftmargin + 130, topmargin + 80)
        e.Graphics.DrawString("ණයකරුගේ නම : ", secfont, Brushes.Black, leftmargin, topmargin + 100)
        e.Graphics.DrawString(lblCreditorName.Text, secfont, Brushes.Black, leftmargin + 130, topmargin + 100)

        Dim x1 = topmargin + 120
        Dim x2 = topmargin + 190
        Dim y1 = leftmargin + 30
        Dim y2 = rightmargin + 30

        e.Graphics.DrawLine(Pens.Black, leftmargin, x1, e.PageBounds.Width - leftmargin, x1)

        e.Graphics.DrawLine(Pens.Black, leftmargin, x1 + 2, e.PageBounds.Width - leftmargin, x1 + 2)
        e.Graphics.DrawLine(Pens.Black, leftmargin, x2 - 40, e.PageBounds.Width - leftmargin, x2 - 40)
        e.Graphics.DrawLine(Pens.Black, leftmargin, x1 + 2, leftmargin, x2 - 40)
        e.Graphics.DrawString("ගෙවූ මුදල", secfont, Brushes.Black, leftmargin + 90, x1 + 7)
        e.Graphics.DrawLine(Pens.Black, leftmargin + 250, x1 + 2, leftmargin + 250, x2 - 40)
        e.Graphics.DrawString("මුදල් ගෙවූ දිනය", secfont, Brushes.Black, leftmargin + 380, x1 + 7)
        e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - leftmargin, x1 + 2, e.PageBounds.Width - leftmargin, x2 - 40)

        Dim ptop = x2
        Dim numRow = DataGridView1.RowCount - 1

        For intcounter = intstart To numRow
            e.Graphics.DrawString(DataGridView1.Rows(intcounter).Cells(1).Value, fntText, Brushes.Black, leftmargin + 50, x2)
            e.Graphics.DrawString(DataGridView1.Rows(intcounter).Cells(2).Value, fntText, Brushes.Black, leftmargin + 300, x2)

            intLineNumber += 1
            x2 += 30
            If intLineNumber > LinesPerPage - 1 Then
                intstart = intcounter + 1
                e.HasMorePages = True
                Exit For

            End If
        Next

        e.Graphics.DrawString("ගෙවිය යුතු මුලු මුදල :", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 145)
        e.Graphics.DrawString(lblPremium.Text, secfont, Brushes.Black, leftmargin + 200, e.PageBounds.Height - 145)
        e.Graphics.DrawString("ගෙවිය යුතු ඉතිරි මුදල :", secfont, Brushes.Black, leftmargin, e.PageBounds.Height - 125)
        e.Graphics.DrawString(lblBalance.Text, secfont, Brushes.Black, leftmargin + 200, e.PageBounds.Height - 125)




    End Sub

    Private Sub print()
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        '' If PrintDialog1.ShowDialog() = 1 Then
        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        Dim pagesetup As New PageSettings
        With pagesetup
            .Margins.Right = 50
            .Margins.Left = 50
            .Margins.Top = 50
            .Margins.Bottom = 50

        End With





        PrintDocument1.Print()

    End Sub
End Class
