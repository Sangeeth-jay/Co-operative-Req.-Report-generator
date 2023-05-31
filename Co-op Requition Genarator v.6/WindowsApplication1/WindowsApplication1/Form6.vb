Public Class Form6
    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim thisDB As String = Application.StartupPath & "\coop.accdb"

        Dim destination As String = Application.StartupPath & "\coop" & Format(Now, "yyyy-MM-dd h m s") & ".accdb"

        FileCopy(thisDB, destination)
        MessageBox.Show("Backup Success")
    End Sub
End Class