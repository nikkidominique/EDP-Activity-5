Imports MySql.Data.MySqlClient
Public Class UpDeleteForm
    Private Sub UpDeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QueryString = "SELECT * FROM database.employee;"
            Dim Search As New MySqlDataAdapter(QueryString, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "employee")
            DataGridView1.DataSource = ds.Tables("employee")
            myconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            myconn.Close()
        End Try
    End Sub

End Class