Imports System.Data.OleDb

Public Class Form2

    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Enabled = True
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoopDataSet.Society' table. You can move, or remove it, as needed.
        Me.SocietyTableAdapter.Fill(Me.CoopDataSet.Society)
        'TODO: This line of code loads data into the 'CoopDataSet.Court' table. You can move, or remove it, as needed.
        Me.CourtTableAdapter.Fill(Me.CoopDataSet.Court)

        pro = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()

        dataview()

    End Sub

    Private Sub dataview()


        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT Case_no, Court_no, Society_no, Creidtor_name, Premium FROM Creditor;", myconnection)
        da.Fill(dt)
        dtview.DataSource = dt.DefaultView


    End Sub

    Private Sub clear()
        txtRno.Clear()
        txtCaseNo.Clear()
        cmbCourtName.SelectedIndex = 0
        cmbSocietyName.SelectedIndex = 0
        txtCreditorName.Clear()
        txtPremium.Clear()
        txtInstallment.Clear()
        txtGuaranter1.Clear()
        txtGuaranter2.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'pro = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\coop.accdb")
        'connstring = pro
        'myconnection.ConnectionString = connstring
        'myconnection.Open()
        command = "INSERT INTO Creditor VALUES('" & txtRno.Text & "' , '" & txtCaseNo.Text & "' , '" & cmbCourtName.SelectedIndex + 1 & "' , '" & cmbSocietyName.SelectedIndex + 1 & "' , '" & txtCreditorName.Text & "' , '" & txtPremium.Text & "' , '" & txtInstallment.Text & "' , '" & txtGuaranter1.Text & "' , '" & txtGuaranter2.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Referee_no", CType(txtRno.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Case_no", CType(txtCaseNo.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Court_no", CType(cmbCourtName.SelectedIndex.ToString() + 1, String)))
        cmd.Parameters.Add(New OleDbParameter("Society_no", CType(cmbSocietyName.SelectedIndex.ToString() + 1, String)))
        cmd.Parameters.Add(New OleDbParameter("Creidtor_name", CType(txtCreditorName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Premium", CType(txtPremium.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Installment", CType(txtInstallment.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Guaranter1", CType(txtGuaranter1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Guaranter2", CType(txtGuaranter2.Text, String)))
        MsgBox("Record Saved")

        Try

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dataview()
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True

    End Sub



End Class