<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.CanButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEmployeeID = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogInButton
        '
        Me.LogInButton.BackColor = System.Drawing.Color.HotPink
        Me.LogInButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInButton.Location = New System.Drawing.Point(258, 337)
        Me.LogInButton.Margin = New System.Windows.Forms.Padding(5)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(100, 31)
        Me.LogInButton.TabIndex = 0
        Me.LogInButton.Text = "Log In"
        Me.LogInButton.UseVisualStyleBackColor = False
        '
        'CanButton
        '
        Me.CanButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.CanButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CanButton.Location = New System.Drawing.Point(258, 378)
        Me.CanButton.Margin = New System.Windows.Forms.Padding(5)
        Me.CanButton.Name = "CanButton"
        Me.CanButton.Size = New System.Drawing.Size(100, 33)
        Me.CanButton.TabIndex = 1
        Me.CanButton.Text = "Cancel"
        Me.CanButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 282)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextEmployeeID
        '
        Me.TextEmployeeID.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextEmployeeID.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmployeeID.Location = New System.Drawing.Point(203, 224)
        Me.TextEmployeeID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextEmployeeID.Name = "TextEmployeeID"
        Me.TextEmployeeID.Size = New System.Drawing.Size(210, 34)
        Me.TextEmployeeID.TabIndex = 4
        '
        'TextPassword
        '
        Me.TextPassword.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextPassword.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(203, 280)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPassword.Size = New System.Drawing.Size(210, 34)
        Me.TextPassword.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Activity_4.My.Resources.Resources.avatar
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(580, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextEmployeeID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CanButton)
        Me.Controls.Add(Me.LogInButton)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LogInForm"
        Me.Text = "Log In Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogInButton As Button
    Friend WithEvents CanButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextEmployeeID As TextBox
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
