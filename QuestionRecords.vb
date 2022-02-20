
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.

Imports System.IO
Public Class QuestionRecords
    Private bitmap As Bitmap 'for print grid
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()

    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=ADMINRG-CP6AJ00;Initial Catalog=QuizappDB;Integrated Security=True"

    Private Sub search_txt()
        Dim str As String
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            str = "Select * from questionsTb where Topic like '" & category_searchtxt.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "questionsTb")
            con.Close()
            questiondate_grid.DataSource = ds
            questiondate_grid.DataMember = "questionsTb"
            questiondate_grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Topic Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'delete function
    Private Sub DeleteSelecedRows()
        Try
            Dim ObjConnection As New SqlConnection()
            Dim i As Integer
            Dim mResult
            mResult = MsgBox("Want you really delete the selected records?",
            vbYesNo + vbQuestion, "Removal confirmation")
            If mResult = vbNo Then
                Exit Sub
            End If
            ObjConnection.ConnectionString = cs
            Dim ObjCommand As New SqlCommand()
            ObjCommand.Connection = ObjConnection
            For i = Me.questiondate_grid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from questionsTb where Qno='" & questiondate_grid.SelectedRows(i).Cells("Qno").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.questiondate_grid.Rows.Remove(Me.questiondate_grid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteSelecedRows()
    End Sub
    Private Sub question_getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from questionsTb ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            questiondate_grid.DataSource = dt
            questiondate_grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Services Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub


    Private Sub questiondate_grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles questiondate_grid.CellMouseClick
        Try

            AddQuestionFrm.question_id.Text = questiondate_grid.CurrentRow.Cells(0).Value.ToString
            AddQuestionFrm.question_txt.Text = questiondate_grid.CurrentRow.Cells(1).Value.ToString
            AddQuestionFrm.op1_Txt.Text = questiondate_grid.CurrentRow.Cells(2).Value.ToString
            AddQuestionFrm.op2_Txt.Text = questiondate_grid.CurrentRow.Cells(3).Value.ToString
            AddQuestionFrm.op3_Txt.Text = questiondate_grid.CurrentRow.Cells(4).Value.ToString
            AddQuestionFrm.op4_Txt.Text = questiondate_grid.CurrentRow.Cells(5).Value.ToString
            AddQuestionFrm.ans_Txt.Text = questiondate_grid.CurrentRow.Cells(6).Value.ToString
            AddQuestionFrm.topic_Txt.Text = questiondate_grid.CurrentRow.Cells(7).Value.ToString
            AddQuestionFrm.difficulty_Txt.Text = questiondate_grid.CurrentRow.Cells(8).Value.ToString
            '  AddQuestionFrm.ans_Txt.Text = questiondate_grid.CurrentRow.Cells(9).Value.ToString
            ' Image()
            Dim i As Integer
            i = questiondate_grid.CurrentRow.Index
            Dim bytes As [Byte]() = (questiondate_grid.Item(9, i).Value)
            Dim ms As New MemoryStream(bytes)
            AddQuestionFrm.photo.Image = Image.FromStream(ms)
            AddQuestionFrm.Show()
        Catch ex As Exception
            MsgBox("Failed:GridCick " & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search_txt()
    End Sub

    Private Sub QuestionRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        question_getdata()
    End Sub
End Class