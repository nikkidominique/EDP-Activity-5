Imports System.IO
Imports System.IO.Pipes
Imports System.Security.Policy
Imports System.Text
Imports Google.Protobuf.Reflection
Imports MySql.Data.MySqlClient
Public Class ViewForm
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QueryString = "SELECT * FROM employee_sys.employee;"
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

    Private Sub ViewArchBtn_Click(sender As Object, e As EventArgs) Handles ViewArchBtn.Click
        EmployeeArchiveForm.Show()
    End Sub

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        MenuForm.Show()
    End Sub

    Private Sub ExportBtn1_Click(sender As Object, e As EventArgs) Handles ExportBtn1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV file|*.csv"
        saveFileDialog1.Title = "Save CSV File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            Dim cmd As New MySqlCommand("SELECT * FROM employee", myconn)
            Dim dataAdapter As New MySqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            Dim csv As New StringBuilder()

            For Each row As DataRow In dataTable.Rows
                Dim fields = row.ItemArray.Select(Function(field) field.ToString()).ToArray()
                csv.AppendLine(String.Join(",", fields))
            Next

            File.WriteAllText(saveFileDialog1.FileName, csv.ToString())

            MsgBox("Data exported to " & saveFileDialog1.FileName & " successfully!")
        End If
    End Sub

    Private Sub LocateDataBtn_Click(sender As Object, e As EventArgs) Handles LocateDataBtn.Click
        Dim openFileDialog1 As New OpenFileDialog()

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName

            Dim fileName As String = Path.GetFileName(filePath)
            Dim destinationPath As String = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads\" & fileName
            File.Move(filePath, destinationPath)

            MessageBox.Show("File moved successfully!")
        End If
    End Sub

    Private Sub ImportBtn1_Click(sender As Object, e As EventArgs) Handles ImportBtn1.Click
        Dim openFileDialog2 As New OpenFileDialog()
        openFileDialog2.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog2.Title = "Select a CSV File"

        Dim result As DialogResult = openFileDialog2.ShowDialog()

        If result = DialogResult.OK Then
            Dim filePath As String = openFileDialog2.FileName
            Dim uploadsPath As String = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads\"
            Dim fileName As String = Path.GetFileName(filePath)
            File.Move(filePath, Path.Combine(uploadsPath, fileName))

            Dim commandText As String = "LOAD DATA INFILE '" & Path.Combine(uploadsPath, fileName) & "' INTO TABLE 
employee FIELDS TERMINATED BY ',' LINES TERMINATED BY '\r\n' IGNORE 1 ROWS (EmployeeID,LastName,FirstName,AssID,SupervisorID,JobID,Salary,Password)"

            Dim cmd As MySqlCommand = New MySqlCommand(commandText)
            cmd.Connection = myconn
            myconn.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data import completed!")
        End If
    End Sub


End Class