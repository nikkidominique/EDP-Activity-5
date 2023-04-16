<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
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
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.ExportBtn1 = New System.Windows.Forms.Button()
        Me.ImportBtn1 = New System.Windows.Forms.Button()
        Me.LocateDataBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ViewArchBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkMagenta
        Me.DataGridView1.Location = New System.Drawing.Point(12, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(881, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(331, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Records"
        '
        'MenuBtn
        '
        Me.MenuBtn.BackColor = System.Drawing.Color.HotPink
        Me.MenuBtn.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBtn.Location = New System.Drawing.Point(12, 12)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(75, 27)
        Me.MenuBtn.TabIndex = 2
        Me.MenuBtn.Text = "Menu"
        Me.MenuBtn.UseVisualStyleBackColor = False
        '
        'ExportBtn1
        '
        Me.ExportBtn1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBtn1.Location = New System.Drawing.Point(767, 169)
        Me.ExportBtn1.Name = "ExportBtn1"
        Me.ExportBtn1.Size = New System.Drawing.Size(126, 32)
        Me.ExportBtn1.TabIndex = 3
        Me.ExportBtn1.Text = "Export as CSV"
        Me.ExportBtn1.UseVisualStyleBackColor = True
        '
        'ImportBtn1
        '
        Me.ImportBtn1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportBtn1.Location = New System.Drawing.Point(12, 151)
        Me.ImportBtn1.Name = "ImportBtn1"
        Me.ImportBtn1.Size = New System.Drawing.Size(126, 32)
        Me.ImportBtn1.TabIndex = 4
        Me.ImportBtn1.Text = "Import Data"
        Me.ImportBtn1.UseVisualStyleBackColor = True
        '
        'LocateDataBtn
        '
        Me.LocateDataBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocateDataBtn.Location = New System.Drawing.Point(12, 113)
        Me.LocateDataBtn.Name = "LocateDataBtn"
        Me.LocateDataBtn.Size = New System.Drawing.Size(126, 32)
        Me.LocateDataBtn.TabIndex = 5
        Me.LocateDataBtn.Text = "Locate Data"
        Me.LocateDataBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(795, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 34)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Employee Archive"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewArchBtn
        '
        Me.ViewArchBtn.BackColor = System.Drawing.Color.LavenderBlush
        Me.ViewArchBtn.Image = Global.Activity_4.My.Resources.Resources.view
        Me.ViewArchBtn.Location = New System.Drawing.Point(795, 12)
        Me.ViewArchBtn.Name = "ViewArchBtn"
        Me.ViewArchBtn.Size = New System.Drawing.Size(98, 117)
        Me.ViewArchBtn.TabIndex = 6
        Me.ViewArchBtn.UseVisualStyleBackColor = False
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(905, 559)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ViewArchBtn)
        Me.Controls.Add(Me.LocateDataBtn)
        Me.Controls.Add(Me.ImportBtn1)
        Me.Controls.Add(Me.ExportBtn1)
        Me.Controls.Add(Me.MenuBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewForm"
        Me.Text = "View Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuBtn As Button
    Friend WithEvents ExportBtn1 As Button
    Friend WithEvents ImportBtn1 As Button
    Friend WithEvents LocateDataBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ViewArchBtn As Button
End Class
