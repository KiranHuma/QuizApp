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
    Dim table As New DataTable("table")
    ' selected row index 
    Dim rowIndex As Integer

    Dim str As String
    Dim com As SqlCommand


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

    Private Sub QuizFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        'get_user_score()


        change_difficulty()
        FillCombo()


    End Sub
    Private Sub FillCombo()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT DISTINCT (Topic) FROM questionsTb where Q_Subject= '" & addQ_sub_txt.Text & "' AND difficulty='" & Diffcultylbl.Text & "'"
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
            MessageBox.Show("Failed:Retrieving and Populating " & ex.Message)
            'Me.Dispose()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
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

    Private Sub op1_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op1_Txt.CheckedChanged
        useranswer_selected()
        check_topic()
        op1_Txt.Enabled = False
        op2_Txt.Enabled = False
        op3_Txt.Enabled = False
        op4_Txt.Enabled = False

    End Sub

    Private Sub op2_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op2_Txt.CheckedChanged
        useranswer_selected()
        check_topic()
        op1_Txt.Enabled = False
        op2_Txt.Enabled = False
        op3_Txt.Enabled = False
        op4_Txt.Enabled = False

    End Sub

    Private Sub op3_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op3_Txt.CheckedChanged
        useranswer_selected()
        check_topic()
        op1_Txt.Enabled = False
        op2_Txt.Enabled = False
        op3_Txt.Enabled = False
        op4_Txt.Enabled = False


    End Sub

    Private Sub op4_Txt_CheckedChanged(sender As Object, e As EventArgs) Handles op4_Txt.CheckedChanged
        useranswer_selected()
        check_topic()
        op1_Txt.Enabled = False
        op2_Txt.Enabled = False
        op3_Txt.Enabled = False
        op4_Txt.Enabled = False

    End Sub


    Private Sub topic_Txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles topic_Txt.SelectedIndexChanged
        ' topictxt_label.Text = topic_Txt.Text
        strtbtn.Enabled = True

    End Sub
    Private Sub get_first_row_Id()

        Try
            ' dbaccessconnection()
            Dim constr As String = cs
            Using con As SqlConnection = New SqlConnection(constr)

                Using command As SqlCommand = New SqlCommand(" SELECT TOP 1 * FROM questionsTb where Qno >= '" & question_id.Text & "' AND difficulty='" & difficulty_Txt.Text & "' And Topic ='" & topic_Txt.Text & "' AND  Q_Subject= '" & addQ_sub_txt.Text & "'", con)
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
                        get_image()

                    Loop
                    read.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        Finally
            con.Close()
        End Try


    End Sub
    Private Sub getvaluedb()
        Dim constr As String = cs
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("Select * from questionsTb where Qno = '" & ComboBox1.Text & "' AND difficulty='" & Diffcultylbl.Text & "' And Topic ='" & topictxt_label.Text & "'")
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
                    ans_Txt.Text = sdr("answer").ToString()
                    topic_Txt.Text = sdr("Topic").ToString()
                    difficulty_Txt.Text = sdr("difficulty").ToString()
                    Dbquestion_score_txt.Text = sdr("score").ToString()
                    ' photo.Text = sdr("photo").ToString()
                    get_image()
                End Using
                con.Close()

            End Using
        End Using
    End Sub

    ''wrong question checker
    ' Private Sub check_wronganswer()


    'If ans_Txt.Text <> user_answer.Text Then

    '  Dim dt As New DataTable
    'Dim dr As DataRow

    '   dt.Columns.Add("Question")
    '   dt.Columns.Add("option1")
    '   dt.Columns.Add("option2")
    '   dt.Columns.Add("option3")
    '    dt.Columns.Add("option4")
    '    dt.Columns.Add("answer")
    '    dt.Columns.Add("User_answer")


    '     dr = dt.NewRow
    '     dr("Question") = question_txt.Text
    '     dr("option1") = op1_Txt.Text
    '   dr("option2") = op2_Txt.Text
    '   dr("option3") = op3_Txt.Text
    '   dr("option4") = op4_Txt.Text
    '   dr("answer") = ans_Txt.Text
    '   dr("User_answer") = user_answer.Text

    '  dt.Rows.Add(dr)
    '   questiondate_grid.DataSource = dt
    '   MsgBox("Finish")
    'd If

    ' End Sub
    Private Sub strtbtn_Click(sender As Object, e As EventArgs) Handles strtbtn.Click

        get_first_row_Id()


        strtbtn.Enabled = False


        nextBtn.Enabled = True



    End Sub
    Private Sub correct_answer()
        If ans_Txt.Text = user_answer.Text Then
            Dim correctans As Integer
            correctans = Math.Abs(Integer.Parse(userscore.Text) + (Integer.Parse(Dbquestion_score_txt.Text)))
            userscore.Text = Convert.ToString(correctans)

        End If
    End Sub
    Private Sub questionid()
        Dim int As Integer
        Integer.TryParse(question_id.Text, int)
        question_id.Text = (int + 1)
    End Sub

    Private Sub finish_question()

        Dim connStr As String = cs
        Dim query As String = "SELECT MAX(Qno) FROM questionsTb where difficulty='" & difficulty_Txt.Text & "' And Topic ='" & topic_Txt.Text & "'"
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
    Private Sub enabled_options_fornext()
        op1_Txt.Enabled = True
        op2_Txt.Enabled = True
        op3_Txt.Enabled = True
        op4_Txt.Enabled = True
    End Sub

    Private Sub change_difficulty()
        If userscore.Text >= 0 And userscore.Text < 30 Then
            difficulty_Txt.Text = "Easy"
            FillCombo()
            get_first_row_Id()
        ElseIf userscore.Text > 30 And userscore.Text < 60 Then
            difficulty_Txt.Text = "Medium"
            FillCombo()
            get_first_row_Id()
        ElseIf userscore.Text > 60 Then
            difficulty_Txt.Text = "Difficult"
            FillCombo()
            get_first_row_Id()
        End If
    End Sub


    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        ' questionid()
        'check_wronganswer()


        'check_wronganswer()
        If finish_label.Text = question_id.Text Then
            MsgBox("Quiz Finished")

        Else
            change_difficulty()
            get_next_value_combo()
            ' fillcombo_quetionid_fornext()
            ' get_next_value_combo()
            ' getvaluedb()
            '  end_quiz()

        End If
    End Sub

    Private Sub difficulty_Txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles difficulty_Txt.SelectedIndexChanged
        Diffcultylbl.Text = difficulty_Txt.Text
    End Sub

    Private Sub get_next_value_combo()
        If ComboBox1.SelectedIndex < ComboBox1.Items.Count - 1 Then
            ComboBox1.SelectedIndex = ComboBox1.SelectedIndex + 1
        End If
    End Sub
    Private Sub fillcombo_quetionid_fornext()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT (Qno) FROM questionsTb where difficulty='" & difficulty_Txt.Text & "'  And Q_Subject= '" & addQ_sub_txt.Text & "'"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "questionsTb")
            With Me.ComboBox1
                .DataSource = ds.Tables("questionsTb")
                .DisplayMember = "Qno"
                .ValueMember = "Qno"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            'Me.Dispose()
        End Try
    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        question_id.Text = ComboBox1.Text
    End Sub

    Private Sub question_txt_TextChanged(sender As Object, e As EventArgs) Handles question_txt.TextChanged
        enabled_options_fornext()
    End Sub

    Private Sub user_answer_TextChanged(sender As Object, e As EventArgs) Handles user_answer.TextChanged
        correct_answer()


    End Sub


    Private Sub add_score()
        Try
            con.Open()
            cmd.CommandText = ("UPDATE Result_tb SET Score= '" & userscore.Text & "' where Topic='" & topic_Txt.Text & "'")

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub check_topic()

        Dim con As New SqlConnection(cs)
        con.Open()
        str = "Select count(*)from Result_tb where Topic='" & topictxt_label.Text & "'"
        com = New SqlCommand(Str, con)
        Dim count As Integer = Convert.ToInt32(com.ExecuteScalar())
        con.Close()
        If count > 0 Then
            add_score()
        Else
            insert_new_socre_for_new_topic()

        End If
    End Sub
    Private Sub insert_new_socre_for_new_topic()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into Result_tb(Username,Subject,Topic,Score)values
                                                 ('" & username_lbl.Text & "','" & addQ_sub_txt.Text & "','" & topic_Txt.Text & "','" & userscore.Text & "')"


            cmd.ExecuteNonQuery()
            con.Close()
            'MessageBox.Show("Data Inserted")
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fillcombo_quetionid_fornext()
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        get_next_value_combo()
        change_difficulty()
        topic_Txt.Enabled = True

    End Sub
End Class