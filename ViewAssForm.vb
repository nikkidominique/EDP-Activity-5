Imports MySql.Data.MySqlClient
Public Class ViewAssForm
    Private Sub ViewAssForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QueryString = "SELECT * FROM employee_sys.assignment;"
            Dim Search As New MySqlDataAdapter(QueryString, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "assignment")
            DataGridView1.DataSource = ds.Tables("assignment")
            myconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            myconn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuForm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class