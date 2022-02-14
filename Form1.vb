Imports System.Data.SqlClient
Public Class Form1

    Private bitmap As Bitmap 'for print grid
    Dim dr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dt As New DataTable

    Dim cs As String = "Data Source=DESKTOP-R157FBN;Initial Catalog=quizzdb;Integrated Security=True"
    'Database Connection
    Private Sub dbaccessconnection()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            'MsgBox("welcome ")
        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'insert data into database
    Private Sub insert()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into questionsTb(Qno,question,option1,option2,option3,option4,answer,category)values
                                                 ('" & TextBox6.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox8.Text & "', '" & TextBox7.Text & "')"
            cmd.ExecuteNonQuery()
            '  welcomemsg.Text = "'Service" & service_txt.Text & "' saved successfully!"
            ' welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            con.Close()
            ' getdata()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub questionid()


        Dim int As Integer
        Integer.TryParse(TextBox6.Text, int)
        TextBox6.Text = (int + 1)
    End Sub
    Private Sub getvaluedb()
        Dim constr As String = cs
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("Select * from questionsTb where Qno = '" & TextBox6.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()
                Using sdr As SqlDataReader = cmd.ExecuteReader()
                    sdr.Read()

                    TextBox6.Text = sdr("Qno").ToString()
                    TextBox1.Text = sdr("question").ToString()
                    TextBox2.Text = sdr("option1").ToString()
                    TextBox3.Text = sdr("option2").ToString()
                    TextBox4.Text = sdr("option3").ToString()
                    TextBox5.Text = sdr("option4").ToString()
                    TextBox8.Text = sdr("answer").ToString()
                    TextBox7.Text = sdr("category").ToString()
                End Using
                con.Close()
            End Using
        End Using
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        getvaluedb()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        questionid()
        getvaluedb()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insert()
    End Sub
End Class
