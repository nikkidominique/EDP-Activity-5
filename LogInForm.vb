Imports MySql.Data.MySqlClient

Public Class LogInForm
    Private Sub LogInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select * from employee where EmployeeID = '" _
                & .TextEmployeeID.Text & "' and Password = ('" _
                & .TextPassword.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                myconn.Close()
                MenuForm.Show()
            Else
                MessageBox.Show("Oops! Invalid Employee ID or password!")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanButton.Click
        Me.Close()
    End Sub
End Class