<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeArchiveForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuBtn12 = New System.Windows.Forms.Button()
        Me.LocateDataBtn1 = New System.Windows.Forms.Button()
        Me.ImportDataBtn1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkMagenta
        Me.DataGridView1.Location = New System.Drawing.Point(12, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(881, 358)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(329, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee Archives"
        '
        'MenuBtn12
        '
        Me.MenuBtn12.BackColor = System.Drawing.Color.HotPink
        Me.MenuBtn12.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBtn12.Location = New System.Drawing.Point(3, 2)
        Me.MenuBtn12.Name = "MenuBtn12"
        Me.MenuBtn12.Size = New System.Drawing.Size(75, 27)
        Me.MenuBtn12.TabIndex = 3
        Me.MenuBtn12.Text = "Menu"
        Me.MenuBtn12.UseVisualStyleBackColor = False
        '
        'LocateDataBtn1
        '
        Me.LocateDataBtn1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocateDataBtn1.Location = New System.Drawing.Point(12, 109)
        Me.LocateDataBtn1.Name = "LocateDataBtn1"
        Me.LocateDataBtn1.Size = New System.Drawing.Size(126, 32)
        Me.LocateDataBtn1.TabIndex = 7
        Me.LocateDataBtn1.Text = "Locate Data"
        Me.LocateDataBtn1.UseVisualStyleBackColor = True
        '
        'ImportDataBtn1
        '
        Me.ImportDataBtn1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportDataBtn1.Location = New System.Drawing.Point(12, 147)
        Me.ImportDataBtn1.Name = "ImportDataBtn1"
        Me.ImportDataBtn1.Size = New System.Drawing.Size(126, 32)
        Me.ImportDataBtn1.TabIndex = 6
        Me.ImportDataBtn1.Text = "Import Data"
        Me.ImportDataBtn1.UseVisualStyleBackColor = True
        '
        'EmployeeArchiveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(905, 559)
        Me.Controls.Add(Me.LocateDataBtn1)
        Me.Controls.Add(Me.ImportDataBtn1)
        Me.Controls.Add(Me.MenuBtn12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EmployeeArchiveForm"
        Me.Text = "Employee Archive Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuBtn12 As Button
    Friend WithEvents LocateDataBtn1 As Button
    Friend WithEvents ImportDataBtn1 As Button
End Class
