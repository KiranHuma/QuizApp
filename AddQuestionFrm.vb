Imports System.Data.SqlClient
Imports System.IO

Public Class AddQuestionFrm

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
            cmd.CommandText = "insert into questionsTb(Qno,question,option1,option2,option3,option4,answer,Topic,difficulty,photo)values
                                                 ('" & question_id.Text & "','" & question_txt.Text & "','" & op1_Txt.Text & "','" & op2_Txt.Text & "','" & op3_Txt.Text & "','" & op4_Txt.Text & "','" & ans_Txt.Text & "','" & topic_Txt.Text & "','" & difficulty_Txt.Text & "',@photo)"

            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(photo.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)

            ms.Close()
            ms.Dispose()
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()


            If bmpImage IsNot Nothing Then
                bmpImage.Dispose()
            End If
            '  welcomemsg.Text = "'Service" & service_txt.Text & "' saved successfully!"
            ' welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            con.Close()
            ' getdata()
            MessageBox.Show("Data Inserted")
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
                ' getvaluedb()

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
                    topic_Txt.Text = sdr("Topic").ToString()
                    ans_Txt.Text = sdr("answer").ToString()
                    difficulty_Txt.Text = sdr("difficulty").ToString()
                End Using
                con.Close()
            End Using
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        txtboxid()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        questionid()
        getvaluedb()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insert()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                photo.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        QuestionRecords.Show()
    End Sub
    'edit Funtion
    Private Sub edit()
        Try
            con.Open()
            cmd.CommandText = ("UPDATE questionsTb SET  question= '" & question_txt.Text & "', option1= '" & op1_Txt.Text & "',option2= '" & op2_Txt.Text & "',option3= '" & op3_Txt.Text & "',option4= '" & op4_Txt.Text & "',answer= '" & ans_Txt.Text & "', Topic= '" & topic_Txt.Text & "',difficulty= '" & difficulty_Txt.Text & "',photo=@photo where Qno=" & question_id.Text & "")
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(photo.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            MessageBox.Show("Data updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Label2.Text = "noupdate" Then
            Label2.Text = "update"
            QuestionRecords.Show()
        Else
            edit()
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
