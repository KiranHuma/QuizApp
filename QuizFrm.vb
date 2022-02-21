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
                ' getvaluedb()

            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Transaction ID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    Private Sub get_first_row_Id()

        Try
            dbaccessconnection()
            Dim command As New SqlCommand(" SELECT TOP 1 * FROM questionsTb where Qno >= '" & question_id.Text & "' AND difficulty='" & difficulty_Txt.Text & "' And Topic ='" & topic_Txt.Text & "'", con)
            con.Open()
            cmd.Parameters.Clear()
            Dim read As SqlDataReader = command.ExecuteReader()

            Do While read.Read()
                question_id.Text = (read("Qno").ToString())

                question_txt.Text = (read("question").ToString())
                op1_Txt.Text = (read("option1").ToString())
                op2_Txt.Text = (read("option2").ToString())
                op3_Txt.Text = (read("option3").ToString())
                op4_Txt.Text = (read("option4").ToString())
                ans_Txt.Text = (read("answer").ToString())
                topic_Txt.Text = (read("Topic").ToString())
                difficulty_Txt.Text = (read("difficulty").ToString())
                Dbquestion_score_txt.Text = (read("score").ToString())
                ' photo.Text = sdr("photo").ToString()
                ' get_image()

            Loop
            read.Close()

        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        Finally
            con.Close()
        End Try


    End Sub
    Private Sub finish_question()

        Dim connStr As String = cs
                Dim query As String = "SELECT COUNT(Qno) FROM questionsTb where difficulty='" & difficulty_Txt.Text & "' And Topic ='" & topic_Txt.Text & "'"
                Using conn As New SqlConnection(connStr)
                    Using cmd As New SqlCommand()
                        With cmd
                            .Connection = conn
                            .CommandText = query
                            .CommandType = CommandType.Text
                        End With
                Try
                    conn.Open()
                    Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
                    '  MsgBox(count.ToString()
                    finish_label.Text = count.ToString()
                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                            Me.Dispose()
                        End Try
                    End Using
                End Using




    End Sub
    Private Sub get_image()
        Try
            dbaccessconnection()
            con.Open()

            ' con.ConnectionString = cs
            da = New SqlDataAdapter("select photo from questionsTb where Qno = '" & question_id.Text & "' ", con)
            da.Fill(ds)
            Dim saveImage As IO.MemoryStream
            Dim imgByte As Byte()
            If ds.Tables.Count > 0 Then
                imgByte = ds.Tables(0).Rows(0)("photo")
                saveImage = New IO.MemoryStream(imgByte)
                photo.Image = Image.FromStream(saveImage)
            End If
            con.Close()

        Catch ex As Exception
            Me.Dispose()
        Finally
            con.Close()
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
                    topic_Txt.Text = sdr("Topic").ToString()
                    topic_Txt.Text = sdr("difficulty").ToString()
                    topic_Txt.Text = sdr("score").ToString()
                    ' photo.Text = sdr("photo").ToString()
                    get_image()
                End Using
                con.Close()

            End Using
        End Using
    End Sub
    Private Sub QuizFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        FillCombo()

        ' txtboxid()
    End Sub
    Private Sub FillCombo()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT Topic FROM questionsTb"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "questionsTb")
            With Me.topic_Txt
                .DataSource = ds.Tables("questionsTb")
                .DisplayMember = "Topic"
                .ValueMember = "Topic"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        questionid()
        getvaluedb()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        insert()
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ' txtboxid
        finish_question()
        'correct_answer()
        ' useranswer_selected()
        ' get_first_row_Id()
        ' get_image()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        get_first_row_Id()
        get_image()
    End Sub
    Private Sub useranswer_selected()
        If op1_Txt.Checked Then
            user_answer.Text = op1_Txt.Text
        ElseIf op2_Txt.Checked Then
            user_answer.Text = op2_Txt.Text
        ElseIf op3_Txt.Checked Then
            user_answer.Text = op3_Txt.Text
        ElseIf op4_Txt.Checked Then
            user_answer.Text = op4_Txt.Text
        End If
    End Sub
    Private Sub correct_answer()
        If ans_Txt.Text = user_answer.Text Then
            Dim correctans As Integer
            correctans = Math.Abs(Integer.Parse(Dbquestion_score_txt.Text) + (Integer.Parse(userscore.Text)))
            userscore.Text = Convert.ToString(correctans)
            'totalpredictblnce = Math.Abs(totalpredictblnce)

        End If
    End Sub
    Private Sub op1_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op1_Txt.CheckedChanged
        useranswer_selected()
    End Sub

    Private Sub op2_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op2_Txt.CheckedChanged
        useranswer_selected()
    End Sub

    Private Sub op3_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op3_Txt.CheckedChanged
        useranswer_selected()
    End Sub

    Private Sub op4_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op4_Txt.CheckedChanged
        useranswer_selected()
    End Sub

End Class