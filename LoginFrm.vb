Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Public Class Login
    Dim cs As String = "Data Source=DESKTOP-R157FBN;Initial Catalog=quizzdb;Integrated Security=True"
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
        PopulateDataGrid()
    End Sub
    Private Sub PopulateDataGrid()
        Dim constr As String = "Data Source=DESKTOP-R157FBN;Initial Catalog=UsersDB;Integrated Security=true"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT * FROM Users")
                Using sda As New SqlDataAdapter()
                    Dim dt As New DataTable()
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    sda.Fill(dt)
                    dgvUsers.DataSource = dt
                    dt.Columns(1).ColumnName = "Encrypted Password"
                    dt.Columns.Add("Password")
                    For Each row As DataRow In dt.Rows
                        row("Password") = Decrypt(row("Encrypted Password").ToString)
                    Next
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim constr As String = "Data Source=DESKTOP-R157FBN;Initial Catalog=UsersDB;Integrated Security=true"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("INSERT INTO Users VALUES(@Username, @Password)")
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", Encrypt(txtPassword.Text.Trim()))
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using

        PopulateDataGrid()
    End Sub
End Class