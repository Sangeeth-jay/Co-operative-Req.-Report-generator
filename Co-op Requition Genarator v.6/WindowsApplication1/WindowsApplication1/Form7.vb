Imports System.Data.OleDb
Public Class Form7
    Dim refereeno As String
    Dim courtno As String
    Dim societyno As String
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoopDataSet.Society' table. You can move, or remove it, as needed.
        Me.SocietyTableAdapter.Fill(Me.CoopDataSet.Society)
        'TODO: This line of code loads data into the 'CoopDataSet.Court' table. You can move, or remove it, as needed.
        Me.CourtTableAdapter.Fill(Me.CoopDataSet.Court)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim conn As New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        con.Open()

        Dim strsql As String
        strsql = "SELECT Referee_no,Court_no,Society_no,Creidtor_name,Premium,Installment,Guaranter1,Guaranter2 FROM Creditor WHERE Case_no=" + txtCase.Text + ";"
        Dim cmd As New OleDbCommand(strsql, con)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        txtRefreeno.Text = myreader("Referee_no")
        courtno = myreader("Court_no")
        societyno = myreader("Society_no")
        txtCreditorname.Text = myreader("Creidtor_name")
        txtPremium.Text = myreader("Premium")
        txtInstallement.Text = myreader("Installment")
        txtGuarantor1.Text = myreader("Guaranter1")
        txtGuarantor2.Text = myreader("Guaranter2")

        cmbCourtname.SelectedIndex = courtno - 1
        cmbSocietyname.SelectedIndex = societyno - 1


        'Dim csql As String
        'csql = "SELECT Court_name FROM Court WHERE Court_id =" + courtno + ";"
        'Dim cmd1 As New OleDbCommand(csql, conn)
        'Dim myreader1 As OleDbDataReader
        'myreader1 = cmd1.ExecuteReader
        'myreader1.Read()

        'cmbCourtname.Text = myreader1("Court_name")

        'Dim ssql As String
        'ssql = "SELECT Society_name FROM Society WHERE Society_id =" + societyno + ";"
        'Dim cmd2 As New OleDbCommand(ssql, conn)
        'Dim myreader2 As OleDbDataReader
        'myreader2 = cmd2.ExecuteReader
        'myreader2.Read()

        'cmbSocietyname.Text = myreader2("Society_name")


        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True

    End Sub
    Private Sub clear()
        txtRefreeno.Clear()
        txtCase.Clear()
        cmbCourtname.SelectedIndex = 0
        cmbSocietyname.SelectedIndex = 0
        txtCreditorname.Clear()
        txtPremium.Clear()
        txtInstallement.Clear()
        txtGuarantor1.Clear()
        txtGuarantor2.Clear()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim caseno As String = txtCase.Text
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")

        con.Open()
        Dim strsql As String
        strsql = "Update Creditor Set Referee_no = '" & txtRefreeno.Text & "', Court_no='" & cmbCourtname.SelectedIndex + 1 & "' , Society_no='" & cmbSocietyname.SelectedIndex + 1 & "' , Creidtor_name='" & txtCreditorname.Text & "' ,  Premium='" & txtPremium.Text & "' , Installment='" & txtInstallement.Text & "' , Guaranter1='" & txtGuarantor1.Text & "'  , Guaranter2 = '" & txtGuarantor2.Text & "' WHERE Case_no=" & caseno & ";"

        Dim cmd As New OleDbCommand(strsql, con)
        MsgBox("Update Success")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim caseno As String = txtCase.Text
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")

        con.Open()
        Dim strsql As String
        strsql = "DELETE FROM Creditor WHERE Case_no=" & caseno & ";"

        Dim cmd As New OleDbCommand(strsql, con)
        MsgBox("Delete Success")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class