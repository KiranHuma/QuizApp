Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Public Class SignupFrm

    Dim cmd As New SqlCommand()
    Dim con As New SqlConnection()
    Dim str As String
    Dim com As SqlCommand

    Dim cs As String = "Data Source=ADMINRG-CP6AJ00;Initial Catalog=QuizappDB;Integrated Security=true"
    Private Sub dbaccessconnection()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub SignupFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxid()
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

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        'insert_para()
        insert()
        insert_usernameResult_()
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub insert()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "INSERT INTO Users (U_ID,Username,Name,Password,Gender,Contact_no,Email,My_Score)values
                                                 ('" & Uid_txt.Text & "','" & txtUsername.Text & "','" & txtName.Text & "','" & Encrypt(txtPass.Text.Trim()) & "','" & CmboGender.Text & "','" & txtContact.Text & "','" & txtEmail.Text & "','" & score_txt.Text & "')"



            cmd.ExecuteNonQuery()



            con.Close()
            ' getdata()
            MessageBox.Show("Registration completed Successfully")
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub insert_usernameResult_()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "INSERT INTO Result_tb (Username,Score)values
                                                 ('" & txtUsername.Text & "','" & score_txt.Text & "')"
            cmd.ExecuteNonQuery()
            con.Close()
            ' getdata()
            ' MessageBox.Show("Data Inserted")
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Public Sub namecheck()
        Dim con As New SqlConnection(cs)
        con.Open()
        str = "select count(*)from Users where Username='" & txtUsername.Text & "'"
        com = New SqlCommand(Str, con)
        Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
        con.Close()
        If count > 0 Then
            label7.Visible = True
            label7.Text = "Sorry! you can't take this username"
            label7.ForeColor = Color.Red
            'label7.Text = "";
        Else
            label7.Text = ""

        End If

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        namecheck()
    End Sub

    Private Sub txtPassAgain_TextChanged(sender As Object, e As EventArgs) Handles txtPassAgain.TextChanged
        If txtPass.Text = txtPassAgain.Text Then
            label8.Visible = True
            label8.Text = "Match"
            label8.ForeColor = Color.Green
        Else
            label8.Visible = True
            label8.Text = "Not match"
            label8.ForeColor = Color.Red
        End If

    End Sub
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(U_ID) FROM Users "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                Uid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                Uid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Transaction ID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        End
    End Sub
End Class