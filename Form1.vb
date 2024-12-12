Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Public Sub ClearText()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtEmployeeID.Clear()
        txtJob.Clear()
        txtPhoneNumber.Clear()
        txtSalary.Clear()

    End Sub

    Public Sub InsertData()
        If Not ValidateInputs() Then
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "INSERT INTO tblEmployee (last_name, first_name, email, phone_number, hire_date, job_title, salary) VALUES (@last_name, @firstname, @email, @phonenumber, @hire_date, @job_title, @salary)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text.Trim())
            cmd.Parameters.AddWithValue("@hire_date", DateTimePicker1.Value.ToString("yyyy-MM-dd").Trim())
            cmd.Parameters.AddWithValue("@job_title", txtJob.Text.Trim())
            cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text.Trim()))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListView1.Clear()
            ClearText()

            btnEdit.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            MsgBox("Inserting Error: " & ex.Message)
        Finally
            ConfigureListView()
            LoadEmployeeData()
            DisableText()

            btnAdd.Text = "ADD"
        End Try
    End Sub

    Public Sub UpdateData()
        If Not ValidateInputs() Then
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "UPDATE tblEmployee SET last_name = @last_name, first_name = @firstname, email = @email, phone_number = @phonenumber, hire_date = @hire_date, job_title = @job_title, salary = @salary WHERE employee_ID = @employee_ID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text.Trim())
            cmd.Parameters.AddWithValue("@hire_date", DateTimePicker1.Value.ToString("yyyy-MM-dd").Trim())
            cmd.Parameters.AddWithValue("@job_title", txtJob.Text.Trim())
            cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text.Trim()))
            cmd.Parameters.AddWithValue("@employee_ID", txtEmployeeID.Text.Trim())
            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Updated Successfully", "Update Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListView1.Clear()
            ClearText()

            btnDelete.Enabled = True
            btnAdd.Enabled = True
        Catch ex As Exception
            MsgBox("Updating Error: " & ex.Message)
        Finally
            ConfigureListView()
            LoadEmployeeData()
            DisableText()
            btnEdit.Text = "EDIT"
        End Try
    End Sub

    Public Sub DeleteData()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "DELETE FROM tblEmployee WHERE employee_ID = @EmployeeID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Deleted Successfully", "Delete Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListView1.Clear()
            ClearText()
        Catch ex As Exception
            MsgBox("Deleting Error: " & ex.Message)
        Finally
            ConfigureListView()
            LoadEmployeeData()
            DisableText()
        End Try
    End Sub

    Public Sub LoadEmployeeData()
        Dim query As String = "select * from tblEmployee"
        Dim cmd As New MySqlCommand(query, conn)
        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read()
                Dim item As New ListViewItem(reader("employee_ID").ToString())
                item.SubItems.Add(reader("last_name").ToString())
                item.SubItems.Add(reader("first_name").ToString())
                item.SubItems.Add(reader("email").ToString())
                item.SubItems.Add(reader("phone_number").ToString())
                item.SubItems.Add(reader("hire_date").ToString())
                item.SubItems.Add(reader("job_title").ToString())
                item.SubItems.Add(reader("salary").ToString())
                ListView1.Items.Add(item)
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("Error loading employee data " & ex.Message)
        End Try
    End Sub

    Public Sub ConfigureListView()
        With ListView1
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Employee ID", 150, HorizontalAlignment.Left)
            .Columns.Add("Last Name", 150, HorizontalAlignment.Left)
            .Columns.Add("First Name", 150, HorizontalAlignment.Left)
            .Columns.Add("Email", 300, HorizontalAlignment.Left)
            .Columns.Add("Phone Number", 300, HorizontalAlignment.Left)
            .Columns.Add("Hire Date", 150, HorizontalAlignment.Left)
            .Columns.Add("Job Title", 250, HorizontalAlignment.Left)
            .Columns.Add("Salary", 150, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableText()
        OpenConnection()
        ConfigureListView()
            LoadEmployeeData()

    End Sub

    Public Function ValidateInputs() As Boolean
        If txtLastName.Text.Trim() = "" Then
            MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Focus()
            Return False
        End If

        If txtFirstName.Text.Trim() = "" Then
            MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            Return False
        End If

        If txtEmail.Text.Trim() = "" OrElse Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("A valid Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return False
        End If

        If txtJob.Text.Trim() = "" Then
            MessageBox.Show("Job Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtJob.Focus()
            Return False
        End If

        If txtPhoneNumber.Text.Trim() = "" OrElse Not IsNumeric(txtPhoneNumber.Text) Then
            MessageBox.Show("A valid Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhoneNumber.Focus()
            Return False
        End If

        If txtSalary.Text.Trim() = "" OrElse Not IsNumeric(txtSalary.Text) Then
            MessageBox.Show("A valid Salary is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSalary.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub DisableText()
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtEmail.Enabled = False
        txtEmployeeID.Enabled = False
        txtJob.Enabled = False
        txtPhoneNumber.Enabled = False
        txtSalary.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Public Sub EnableText()
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtEmail.Enabled = True
        txtEmployeeID.Enabled = True
        txtJob.Enabled = True
        txtPhoneNumber.Enabled = True
        txtSalary.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "ADD" Then
            btnAdd.Text = "SAVE"
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            EnableText()
        ElseIf btnAdd.Text = "SAVE" Then
            InsertData()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "EDIT" Then
            btnEdit.Text = "UPDATE"
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            EnableText()
        ElseIf btnEdit.Text = "UPDATE" Then
            UpdateData()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim selectedItem As ListView.SelectedListViewItemCollection = CType(sender, ListView).SelectedItems
        If selectedItem.Count > 0 Then
            txtEmployeeID.Text = selectedItem(0).SubItems(0).Text
            txtLastName.Text = selectedItem(0).SubItems(1).Text
            txtFirstName.Text = selectedItem(0).SubItems(2).Text
            txtEmail.Text = selectedItem(0).SubItems(3).Text
            txtPhoneNumber.Text = selectedItem(0).SubItems(4).Text
            DateTimePicker1.Value = DateTime.Parse(selectedItem(0).SubItems(5).Text)
            txtJob.Text = selectedItem(0).SubItems(6).Text
            txtSalary.Text = selectedItem(0).SubItems(7).Text
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearText()
    End Sub
End Class
