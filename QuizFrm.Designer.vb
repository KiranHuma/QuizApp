﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizFrm))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ans_Txt = New System.Windows.Forms.TextBox()
        Me.question_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.question_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.user_answer = New System.Windows.Forms.TextBox()
        Me.op1_Txt = New System.Windows.Forms.RadioButton()
        Me.op2_Txt = New System.Windows.Forms.RadioButton()
        Me.op3_Txt = New System.Windows.Forms.RadioButton()
        Me.op4_Txt = New System.Windows.Forms.RadioButton()
        Me.questiondate_grid = New System.Windows.Forms.DataGridView()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.userscore = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Dbquestion_score_txt = New System.Windows.Forms.Label()
        Me.difficulty_Txt = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.topic_Txt = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.finish_label = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.questiondate_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Difficulty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Topic"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Answer"
        '
        'ans_Txt
        '
        Me.ans_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ans_Txt.Location = New System.Drawing.Point(367, 292)
        Me.ans_Txt.Name = "ans_Txt"
        Me.ans_Txt.Size = New System.Drawing.Size(100, 15)
        Me.ans_Txt.TabIndex = 43
        '
        'question_id
        '
        Me.question_id.BackColor = System.Drawing.Color.Indigo
        Me.question_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.question_id.ForeColor = System.Drawing.Color.White
        Me.question_id.Location = New System.Drawing.Point(99, 112)
        Me.question_id.Name = "question_id"
        Me.question_id.Size = New System.Drawing.Size(36, 15)
        Me.question_id.TabIndex = 39
        Me.question_id.Text = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "4."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "3."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "2."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "1."
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(433, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 33)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Question "
        '
        'question_txt
        '
        Me.question_txt.Location = New System.Drawing.Point(151, 107)
        Me.question_txt.Multiline = True
        Me.question_txt.Name = "question_txt"
        Me.question_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.question_txt.Size = New System.Drawing.Size(476, 136)
        Me.question_txt.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(1282, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 29)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(507, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "User Answer"
        '
        'user_answer
        '
        Me.user_answer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user_answer.Location = New System.Drawing.Point(510, 292)
        Me.user_answer.Name = "user_answer"
        Me.user_answer.Size = New System.Drawing.Size(100, 15)
        Me.user_answer.TabIndex = 50
        '
        'op1_Txt
        '
        Me.op1_Txt.AutoSize = True
        Me.op1_Txt.Location = New System.Drawing.Point(173, 267)
        Me.op1_Txt.Name = "op1_Txt"
        Me.op1_Txt.Size = New System.Drawing.Size(115, 21)
        Me.op1_Txt.TabIndex = 52
        Me.op1_Txt.TabStop = True
        Me.op1_Txt.Text = "RadioButton1"
        Me.op1_Txt.UseVisualStyleBackColor = True
        '
        'op2_Txt
        '
        Me.op2_Txt.AutoSize = True
        Me.op2_Txt.Location = New System.Drawing.Point(174, 305)
        Me.op2_Txt.Name = "op2_Txt"
        Me.op2_Txt.Size = New System.Drawing.Size(115, 21)
        Me.op2_Txt.TabIndex = 53
        Me.op2_Txt.TabStop = True
        Me.op2_Txt.Text = "RadioButton2"
        Me.op2_Txt.UseVisualStyleBackColor = True
        '
        'op3_Txt
        '
        Me.op3_Txt.AutoSize = True
        Me.op3_Txt.Location = New System.Drawing.Point(174, 343)
        Me.op3_Txt.Name = "op3_Txt"
        Me.op3_Txt.Size = New System.Drawing.Size(115, 21)
        Me.op3_Txt.TabIndex = 54
        Me.op3_Txt.TabStop = True
        Me.op3_Txt.Text = "RadioButton3"
        Me.op3_Txt.UseVisualStyleBackColor = True
        '
        'op4_Txt
        '
        Me.op4_Txt.AutoSize = True
        Me.op4_Txt.Location = New System.Drawing.Point(174, 381)
        Me.op4_Txt.Name = "op4_Txt"
        Me.op4_Txt.Size = New System.Drawing.Size(115, 21)
        Me.op4_Txt.TabIndex = 55
        Me.op4_Txt.TabStop = True
        Me.op4_Txt.Text = "RadioButton4"
        Me.op4_Txt.UseVisualStyleBackColor = True
        '
        'questiondate_grid
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo
        Me.questiondate_grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.questiondate_grid.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.questiondate_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.questiondate_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.questiondate_grid.DefaultCellStyle = DataGridViewCellStyle7
        Me.questiondate_grid.GridColor = System.Drawing.Color.White
        Me.questiondate_grid.Location = New System.Drawing.Point(22, 467)
        Me.questiondate_grid.Name = "questiondate_grid"
        Me.questiondate_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.questiondate_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.questiondate_grid.RowHeadersWidth = 51
        Me.questiondate_grid.RowTemplate.Height = 24
        Me.questiondate_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.questiondate_grid.Size = New System.Drawing.Size(1233, 185)
        Me.questiondate_grid.TabIndex = 56
        '
        'photo
        '
        Me.photo.Image = CType(resources.GetObject("photo.Image"), System.Drawing.Image)
        Me.photo.Location = New System.Drawing.Point(705, 21)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(550, 353)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photo.TabIndex = 58
        Me.photo.TabStop = False
        '
        'userscore
        '
        Me.userscore.AutoSize = True
        Me.userscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userscore.ForeColor = System.Drawing.Color.Chartreuse
        Me.userscore.Location = New System.Drawing.Point(603, 49)
        Me.userscore.Name = "userscore"
        Me.userscore.Size = New System.Drawing.Size(24, 25)
        Me.userscore.TabIndex = 59
        Me.userscore.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(732, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Dbquestion_score_txt
        '
        Me.Dbquestion_score_txt.AutoSize = True
        Me.Dbquestion_score_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dbquestion_score_txt.ForeColor = System.Drawing.Color.Chartreuse
        Me.Dbquestion_score_txt.Location = New System.Drawing.Point(52, 186)
        Me.Dbquestion_score_txt.Name = "Dbquestion_score_txt"
        Me.Dbquestion_score_txt.Size = New System.Drawing.Size(24, 25)
        Me.Dbquestion_score_txt.TabIndex = 61
        Me.Dbquestion_score_txt.Text = "0"
        '
        'difficulty_Txt
        '
        Me.difficulty_Txt.FormattingEnabled = True
        Me.difficulty_Txt.Items.AddRange(New Object() {"Easy", "Difficult", "Medium"})
        Me.difficulty_Txt.Location = New System.Drawing.Point(151, 18)
        Me.difficulty_Txt.Name = "difficulty_Txt"
        Me.difficulty_Txt.Size = New System.Drawing.Size(190, 24)
        Me.difficulty_Txt.TabIndex = 62
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(533, 391)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 33)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "Finish"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(333, 391)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 33)
        Me.Button5.TabIndex = 65
        Me.Button5.Text = "Start"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'topic_Txt
        '
        Me.topic_Txt.FormattingEnabled = True
        Me.topic_Txt.Location = New System.Drawing.Point(150, 49)
        Me.topic_Txt.Name = "topic_Txt"
        Me.topic_Txt.Size = New System.Drawing.Size(361, 24)
        Me.topic_Txt.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label12.Location = New System.Drawing.Point(577, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 25)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Score"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label13.Location = New System.Drawing.Point(31, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 25)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Marks"
        '
        'finish_label
        '
        Me.finish_label.AutoSize = True
        Me.finish_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finish_label.ForeColor = System.Drawing.Color.Chartreuse
        Me.finish_label.Location = New System.Drawing.Point(628, 331)
        Me.finish_label.Name = "finish_label"
        Me.finish_label.Size = New System.Drawing.Size(24, 25)
        Me.finish_label.TabIndex = 69
        Me.finish_label.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(557, 331)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 25)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Finish"
        '
        'QuizFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1325, 686)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.finish_label)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.topic_Txt)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.difficulty_Txt)
        Me.Controls.Add(Me.Dbquestion_score_txt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.userscore)
        Me.Controls.Add(Me.photo)
        Me.Controls.Add(Me.questiondate_grid)
        Me.Controls.Add(Me.op4_Txt)
        Me.Controls.Add(Me.op3_Txt)
        Me.Controls.Add(Me.op2_Txt)
        Me.Controls.Add(Me.op1_Txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.user_answer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ans_Txt)
        Me.Controls.Add(Me.question_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.question_txt)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizFrm"
        Me.Text = "QuizFrm"
        CType(Me.questiondate_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ans_Txt As TextBox
    Friend WithEvents question_id As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents question_txt As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents user_answer As TextBox
    Friend WithEvents op1_Txt As RadioButton
    Friend WithEvents op2_Txt As RadioButton
    Friend WithEvents op3_Txt As RadioButton
    Friend WithEvents op4_Txt As RadioButton
    Friend WithEvents questiondate_grid As DataGridView
    Friend WithEvents photo As PictureBox
    Friend WithEvents userscore As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Dbquestion_score_txt As Label
    Friend WithEvents difficulty_Txt As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents topic_Txt As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents finish_label As Label
    Friend WithEvents Label14 As Label
End Class
