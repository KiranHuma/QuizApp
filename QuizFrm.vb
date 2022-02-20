Imports System.Data.SqlClient
Public Class QuizFrm
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
    Dim cs As String = "Data Source=ADMINRG-CP6AJ00;Initial Catalog=QuizappDB;Integrated Security=True"
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
            cmd.CommandText = "insert into questionsTb(Qno,question,option1,option2,option3,option4,answer,Topic,difficulty)values
                                                 ('" & question_id.Text & "','" & question_txt.Text & "','" & op1_Txt.Text & "','" & op2_Txt.Text & "','" & op3_Txt.Text & "','" & op4_Txt.Text & "','" & ans_Txt.Text & "','" & topic_Txt.Text & "','" & difficulty_Txt.Text & "' )"
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
        Integer.TryParse(question_id.Text, int)
        question_id.Text = (int + 1)
    End Sub
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(Qno) FROM questionsTb "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                question_id.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                question_id.Text = num.ToString
                getvaluedb()

            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Transaction ID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub

    Private Sub getvaluedb()
        Dim constr As String = cs
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("Select * from questionsTb where Qno = '" & question_id.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()
                Using sdr As SqlDataReader = cmd.ExecuteReader()
                    sdr.Read()


                    question_id.Text = sdr("Qno").ToString()
                    question_txt.Text = sdr("question").ToString()
                    op1_Txt.Text = sdr("option1").ToString()
                    op2_Txt.Text = sdr("option2").ToString()
                    op3_Txt.Text = sdr("option3").ToString()
                    op4_Txt.Text = sdr("option4").ToString()
                    topic_Txt.Text = sdr("answer").ToString()
                    ans_Txt.Text = sdr("category").ToString()
                End Using
                con.Close()
            End Using
        End Using
    End Sub
    Private Sub QuizFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        txtboxid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        questionid()
        getvaluedb()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        insert()
    End Sub

    Private Sub topic_Txt_TextChanged(sender As Object, e As EventArgs) Handles topic_Txt.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub op1_Txt_TextChanged(sender As Object, e As EventArgs) Handles op1_Txt.TextChanged

    End Sub

    Private Sub op2_Txt_TextChanged(sender As Object, e As EventArgs) Handles op2_Txt.TextChanged

    End Sub

    Private Sub op4_Txt_TextChanged(sender As Object, e As EventArgs) Handles op4_Txt.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
    End Sub
End Class