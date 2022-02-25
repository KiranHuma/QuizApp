Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography

Public Class Login
    Private cmd As New SqlCommand()
    Private con As New SqlConnection()

    Dim cs As String = "Data Source=ADMINRG-CP6AJ00;Initial Catalog=QuizappDB;Integrated Security=True"
    Public Sub dbaccessconnection()
        Try
            Dim connection As New SqlConnection(cs)
            cmd.Connection = con

            '  MessageBox.Show("Connected");
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Database not Connected")
        End Try
    End Sub

    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim constr As String = "Data Source=ADMINRG-CP6AJ00;Initial Catalog=UsersDB;Integrated Security=true"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("INSERT INTO Users VALUES(@Username, @Password)")
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", Encrypt(txtPass.Text.Trim()))
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = Decrypt(TextBox1.Text)
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        TextBox1.Text = Encrypt(txtPass.Text)
        If selectUser.Text = "User" Then

            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" & txtUsername.Text & "' AND Password='" & TextBox1.Text & "'", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then
                Me.Hide()
                ' QuizFrm.username_lbl.Text = Me.txtUsername.Text
                SubjectFrm.username_lbl.Text = Me.txtUsername.Text
                SubjectFrm.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
        ElseIf selectUser.Text = "Admin" Then
            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM db_admin WHERE Username='" & txtUsername.Text & "' AND Password='" & TextBox1.Text & "'", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then
                Me.Hide()
                Call (New AddQuestionFrm()).Show()

            Else
                MessageBox.Show("Your username Or password is not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                label6.ForeColor = Color.Red
                label6.Text = " Not succsessfully login "
            End If
        Else
            MessageBox.Show("Select your choice", "ADMIN or USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click
        SignupFrm.Show()
    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        End

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        SignupFrm.Show()
    End Sub
End Class