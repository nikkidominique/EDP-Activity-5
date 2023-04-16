Imports MySql.Data.MySqlClient
Public Class MenuForm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        ViewForm.Show()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        AddForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles UpDeleteBtn.Click
        UpDeleteForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewAssForm.Show()
    End Sub

    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            myconn.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            myconn.Close()
            MessageBox.Show("Backup Successful!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class