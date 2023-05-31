Imports System.Data.OleDb
Public Class Form4
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoopDataSet.Society' table. You can move, or remove it, as needed.
        Me.SocietyTableAdapter.Fill(Me.CoopDataSet.Society)
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "dd/MM/yyyy"

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        conn.Open()
        Dim date1 As DateTime = DateTime.Parse(d1.Text)
        Dim societyno As String = (cmbSocietyName.SelectedIndex + 1)

        Dim strsql As String
        strsql = "SELECT * FROM Requision_issue WHERE Society_id=" + societyno + "And Report_Print=#" + date1 + "# ;"

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        txtStatus.Text = myreader("Status")
        txtCheckNo.Text = myreader("Check_number")
        txtCashI.Text = myreader("Check_Issue_date")

        conn.Close()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As DateTime = DateTime.Parse(d1.Text)
        Dim societyno As String = cmbSocietyName.SelectedIndex + 1
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")



        con.Open()
        Dim strsql As String
        strsql = "Update Requision_issue Set Status = '" & txtStatus.Text & "', Check_number='" & txtCheckNo.Text & "' , Check_Issue_date = #" & txtCashI.Text & "# WHERE Society_id=" & societyno & " And Report_Print=#" & date1 & "# ;"

        Dim cmd As New OleDbCommand(strsql, con)
        MsgBox("Update Success")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub

End Class