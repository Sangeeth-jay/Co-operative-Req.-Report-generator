Imports System.Data.OleDb
Public Class Form8

    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub
    Private Sub clear()
        txtsocietyid.Clear()
        txtsocietyname.Clear()
    End Sub
    Private Sub loaddata()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM Society;", pro)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        command = "INSERT INTO Society VALUES('" & txtsocietyid.Text & "' , '" & txtsocietyname.Text & "' )"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Society_id", CType(txtsocietyid.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Society_name", CType(txtsocietyname.Text, String)))
        MsgBox("Record Saved")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            loaddata()
            myconnection.Open()
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        loaddata()
    End Sub
End Class