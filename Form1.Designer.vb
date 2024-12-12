<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        txtEmail = New TextBox()
        txtEmployeeID = New TextBox()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        btnClear = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        txtSalary = New TextBox()
        txtJob = New TextBox()
        txtPhoneNumber = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ListView1 = New ListView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1023, 97)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(268, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 84)
        Label1.TabIndex = 0
        Label1.Text = "      SIMPLE EMPLOYEE`S RECORD SYSTEM" & vbCrLf & "(Basic CRUD - Create, Retrieve, Update, Delete)" & vbCrLf & "                Peñaloza, Tipawan, Velgado"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(txtEmployeeID)
        Panel2.Controls.Add(txtLastName)
        Panel2.Controls.Add(txtFirstName)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(txtSalary)
        Panel2.Controls.Add(txtJob)
        Panel2.Controls.Add(txtPhoneNumber)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Panel2.Location = New Point(6, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1007, 267)
        Panel2.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(152, 198)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 30)
        txtEmail.TabIndex = 24
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Enabled = False
        txtEmployeeID.Location = New Point(152, 39)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.ReadOnly = True
        txtEmployeeID.Size = New Size(250, 30)
        txtEmployeeID.TabIndex = 23
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(152, 94)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(250, 30)
        txtLastName.TabIndex = 22
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(152, 143)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(250, 30)
        txtFirstName.TabIndex = 21
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(595, 89)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 20
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Location = New Point(872, 189)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(113, 36)
        btnClear.TabIndex = 19
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.White
        btnDelete.Location = New Point(872, 139)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(113, 36)
        btnDelete.TabIndex = 18
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.White
        btnEdit.Location = New Point(872, 85)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(113, 36)
        btnEdit.TabIndex = 17
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.White
        btnAdd.Location = New Point(872, 33)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(113, 36)
        btnAdd.TabIndex = 16
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(595, 198)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(250, 30)
        txtSalary.TabIndex = 15
        ' 
        ' txtJob
        ' 
        txtJob.Location = New Point(595, 143)
        txtJob.Name = "txtJob"
        txtJob.Size = New Size(250, 30)
        txtJob.TabIndex = 14
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(595, 39)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(250, 30)
        txtPhoneNumber.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F)
        Label10.Location = New Point(524, 201)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 20)
        Label10.TabIndex = 8
        Label10.Text = "Salary:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(504, 146)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 20)
        Label9.TabIndex = 7
        Label9.Text = "Job Title:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(497, 91)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 20)
        Label8.TabIndex = 6
        Label8.Text = "Hire Date:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(42, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 20)
        Label7.TabIndex = 5
        Label7.Text = "Last Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(39, 146)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 4
        Label6.Text = "First Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(21, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 20)
        Label5.TabIndex = 3
        Label5.Text = "Email address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(462, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 2
        Label4.Text = "Phone Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(25, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 1
        Label3.Text = "Employee ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 20)
        Label2.TabIndex = 0
        Label2.Text = "PERSONAL INFORMATION:"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(6, 377)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1009, 189)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1023, 572)
        Controls.Add(ListView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee's Record"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtJob As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ListView1 As ListView

End Class
