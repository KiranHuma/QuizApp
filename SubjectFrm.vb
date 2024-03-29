﻿Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.

Imports System.IO
Public Class SubjectFrm
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter

    Dim source2 As New BindingSource()


    Dim cmd As New SqlClient.SqlCommand

    Dim cs As String = "Data Source=ADMINRG-CP6AJ00;Initial Catalog=QuizappDB;Integrated Security=True"

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        End
    End Sub
    Private Sub question_getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select DISTINCT Q_Subject from questionsTb ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            subject_grid.DataSource = dt
            subject_grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub question_getdataof_result()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from Result_tb where Username='" & username_lbl.Text & "'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub SubjectFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        question_getdata()
        question_getdataof_result()
        ' get_score()

    End Sub
    Private Sub change_difficulty()
        If userscore.Text < 30 Then
            QuizFrm.difficulty_Txt.Text = "Easy"
        ElseIf userscore.Text >= 31 And userscore.Text <= 61 Then
            QuizFrm.difficulty_Txt.Text = "Medium"
        ElseIf userscore.Text >= 61 Then
            QuizFrm.difficulty_Txt.Text = "Difficult"
        End If
    End Sub
    Private Sub search_txt()
        Dim str As String
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            str = "Select Q_Subject from questionsTb where Q_Subject like '" & category_searchtxt.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "questionsTb")
            con.Close()
            subject_grid.DataSource = ds
            subject_grid.DataMember = "questionsTb"
            subject_grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed: Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub search_txt_topic()
        Dim str As String
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            str = "Select * from Result_tb where Topic like '" & TextBox1.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Result_tb")
            con.Close()
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Result_tb"
            DataGridView1.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed: Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub category_searchtxt_TextChanged(sender As Object, e As EventArgs) Handles category_searchtxt.TextChanged
        search_txt()
    End Sub

    Private Sub questiondate_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles subject_grid.CellContentClick

    End Sub
    Private Sub get_score()

        Dim constr As String = cs
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("Select Score from Result_tb where Username = '" & username_lbl.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()

                Using sdr As SqlDataReader = cmd.ExecuteReader()
                    sdr.Read()


                    userscore.Text = sdr("Score").ToString()

                End Using
                con.Close()

            End Using
        End Using
    End Sub
    Private Sub questiondate_grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles subject_grid.CellMouseClick

        addQ_subb_txt.Text = subject_grid.CurrentRow.Cells(0).Value.ToString

        Try
            If addQ_subb_txt.Text = "" Then
                MsgBox("Select Subject")
            Else
                userscore.Text = 0
                QuizFrm.addQ_sub_txt.Text = Me.addQ_subb_txt.Text
                QuizFrm.userscore.Text = Me.userscore.Text
                QuizFrm.Qusername_lbl.Text = Me.username_lbl.Text
                QuizFrm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Failed:GridCick of subject" & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        search_txt_topic()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        userscore.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub
End Class