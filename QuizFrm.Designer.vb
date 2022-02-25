<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuizFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.question_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.user_answer = New System.Windows.Forms.TextBox()
        Me.op1_Txt = New System.Windows.Forms.RadioButton()
        Me.op2_Txt = New System.Windows.Forms.RadioButton()
        Me.op3_Txt = New System.Windows.Forms.RadioButton()
        Me.op4_Txt = New System.Windows.Forms.RadioButton()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Dbquestion_score_txt = New System.Windows.Forms.Label()
        Me.strtbtn = New System.Windows.Forms.Button()
        Me.topic_Txt = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.finish_label = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Diffcultylbl = New System.Windows.Forms.Label()
        Me.topictxt_label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addQ_sub_txt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Qusername_lbl = New System.Windows.Forms.Label()
        Me.userscore = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.difficulty_Txt = New System.Windows.Forms.TextBox()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Difficulty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Location = New System.Drawing.Point(53, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Add Topic"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(376, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Answer"
        '
        'ans_Txt
        '
        Me.ans_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ans_Txt.Location = New System.Drawing.Point(379, 375)
        Me.ans_Txt.Name = "ans_Txt"
        Me.ans_Txt.Size = New System.Drawing.Size(100, 15)
        Me.ans_Txt.TabIndex = 43
        '
        'question_id
        '
        Me.question_id.BackColor = System.Drawing.Color.Indigo
        Me.question_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.question_id.ForeColor = System.Drawing.Color.White
        Me.question_id.Location = New System.Drawing.Point(103, 190)
        Me.question_id.Name = "question_id"
        Me.question_id.Size = New System.Drawing.Size(36, 15)
        Me.question_id.TabIndex = 39
        Me.question_id.Text = "9"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "4."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "3."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "2."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "1."
        '
        'nextBtn
        '
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Location = New System.Drawing.Point(447, 483)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(94, 33)
        Me.nextBtn.TabIndex = 29
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Question "
        '
        'question_txt
        '
        Me.question_txt.Location = New System.Drawing.Point(163, 190)
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
        Me.Label7.Location = New System.Drawing.Point(519, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "User Answer"
        '
        'user_answer
        '
        Me.user_answer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user_answer.Location = New System.Drawing.Point(522, 375)
        Me.user_answer.Name = "user_answer"
        Me.user_answer.Size = New System.Drawing.Size(100, 15)
        Me.user_answer.TabIndex = 50
        '
        'op1_Txt
        '
        Me.op1_Txt.AutoSize = True
        Me.op1_Txt.Location = New System.Drawing.Point(185, 350)
        Me.op1_Txt.Name = "op1_Txt"
        Me.op1_Txt.Size = New System.Drawing.Size(17, 16)
        Me.op1_Txt.TabIndex = 52
        Me.op1_Txt.TabStop = True
        Me.op1_Txt.UseVisualStyleBackColor = True
        '
        'op2_Txt
        '
        Me.op2_Txt.AutoSize = True
        Me.op2_Txt.Location = New System.Drawing.Point(186, 388)
        Me.op2_Txt.Name = "op2_Txt"
        Me.op2_Txt.Size = New System.Drawing.Size(17, 16)
        Me.op2_Txt.TabIndex = 53
        Me.op2_Txt.TabStop = True
        Me.op2_Txt.UseVisualStyleBackColor = True
        '
        'op3_Txt
        '
        Me.op3_Txt.AutoSize = True
        Me.op3_Txt.Location = New System.Drawing.Point(186, 426)
        Me.op3_Txt.Name = "op3_Txt"
        Me.op3_Txt.Size = New System.Drawing.Size(17, 16)
        Me.op3_Txt.TabIndex = 54
        Me.op3_Txt.TabStop = True
        Me.op3_Txt.UseVisualStyleBackColor = True
        '
        'op4_Txt
        '
        Me.op4_Txt.AutoSize = True
        Me.op4_Txt.Location = New System.Drawing.Point(186, 464)
        Me.op4_Txt.Name = "op4_Txt"
        Me.op4_Txt.Size = New System.Drawing.Size(17, 16)
        Me.op4_Txt.TabIndex = 55
        Me.op4_Txt.TabStop = True
        Me.op4_Txt.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(719, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Check"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Dbquestion_score_txt
        '
        Me.Dbquestion_score_txt.AutoSize = True
        Me.Dbquestion_score_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dbquestion_score_txt.ForeColor = System.Drawing.Color.Chartreuse
        Me.Dbquestion_score_txt.Location = New System.Drawing.Point(455, 162)
        Me.Dbquestion_score_txt.Name = "Dbquestion_score_txt"
        Me.Dbquestion_score_txt.Size = New System.Drawing.Size(24, 25)
        Me.Dbquestion_score_txt.TabIndex = 61
        Me.Dbquestion_score_txt.Text = "0"
        '
        'strtbtn
        '
        Me.strtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strtbtn.Location = New System.Drawing.Point(347, 483)
        Me.strtbtn.Name = "strtbtn"
        Me.strtbtn.Size = New System.Drawing.Size(94, 33)
        Me.strtbtn.TabIndex = 65
        Me.strtbtn.Text = "Start"
        Me.strtbtn.UseVisualStyleBackColor = True
        '
        'topic_Txt
        '
        Me.topic_Txt.FormattingEnabled = True
        Me.topic_Txt.Location = New System.Drawing.Point(162, 132)
        Me.topic_Txt.Name = "topic_Txt"
        Me.topic_Txt.Size = New System.Drawing.Size(361, 24)
        Me.topic_Txt.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label12.Location = New System.Drawing.Point(569, 9)
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
        Me.Label13.Location = New System.Drawing.Point(359, 162)
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
        Me.finish_label.Location = New System.Drawing.Point(640, 414)
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
        Me.Label14.Location = New System.Drawing.Point(569, 414)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 25)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Finish"
        Me.Label14.Visible = False
        '
        'Diffcultylbl
        '
        Me.Diffcultylbl.AutoSize = True
        Me.Diffcultylbl.Location = New System.Drawing.Point(983, 403)
        Me.Diffcultylbl.Name = "Diffcultylbl"
        Me.Diffcultylbl.Size = New System.Drawing.Size(58, 17)
        Me.Diffcultylbl.TabIndex = 71
        Me.Diffcultylbl.Text = "Diffculty"
        '
        'topictxt_label
        '
        Me.topictxt_label.AutoSize = True
        Me.topictxt_label.Location = New System.Drawing.Point(934, 403)
        Me.topictxt_label.Name = "topictxt_label"
        Me.topictxt_label.Size = New System.Drawing.Size(43, 17)
        Me.topictxt_label.TabIndex = 74
        Me.topictxt_label.Text = "Topic"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(830, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "next"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1047, 400)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 24)
        Me.ComboBox1.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Subject"
        '
        'addQ_sub_txt
        '
        Me.addQ_sub_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addQ_sub_txt.Location = New System.Drawing.Point(163, 64)
        Me.addQ_sub_txt.Multiline = True
        Me.addQ_sub_txt.Name = "addQ_sub_txt"
        Me.addQ_sub_txt.Size = New System.Drawing.Size(130, 22)
        Me.addQ_sub_txt.TabIndex = 79
        Me.addQ_sub_txt.Text = "computer"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(100, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 17)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Hi,"
        '
        'Qusername_lbl
        '
        Me.Qusername_lbl.AutoSize = True
        Me.Qusername_lbl.Location = New System.Drawing.Point(159, 24)
        Me.Qusername_lbl.Name = "Qusername_lbl"
        Me.Qusername_lbl.Size = New System.Drawing.Size(59, 17)
        Me.Qusername_lbl.TabIndex = 83
        Me.Qusername_lbl.Text = "huma31"
        '
        'userscore
        '
        Me.userscore.BackColor = System.Drawing.Color.Indigo
        Me.userscore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userscore.ForeColor = System.Drawing.Color.White
        Me.userscore.Location = New System.Drawing.Point(559, 49)
        Me.userscore.Name = "userscore"
        Me.userscore.Size = New System.Drawing.Size(100, 15)
        Me.userscore.TabIndex = 84
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(547, 483)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 33)
        Me.Button4.TabIndex = 86
        Me.Button4.Text = "Finish"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'difficulty_Txt
        '
        Me.difficulty_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.difficulty_Txt.Location = New System.Drawing.Point(162, 99)
        Me.difficulty_Txt.Multiline = True
        Me.difficulty_Txt.Name = "difficulty_Txt"
        Me.difficulty_Txt.Size = New System.Drawing.Size(130, 22)
        Me.difficulty_Txt.TabIndex = 87
        '
        'QuizFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1325, 542)
        Me.Controls.Add(Me.difficulty_Txt)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.userscore)
        Me.Controls.Add(Me.Qusername_lbl)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.addQ_sub_txt)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.topictxt_label)
        Me.Controls.Add(Me.Diffcultylbl)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.finish_label)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.topic_Txt)
        Me.Controls.Add(Me.strtbtn)
        Me.Controls.Add(Me.Dbquestion_score_txt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.photo)
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
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.question_txt)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizFrm"
        Me.Text = "QuizFrm"
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
    Friend WithEvents nextBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents question_txt As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents user_answer As TextBox
    Friend WithEvents op1_Txt As RadioButton
    Friend WithEvents op2_Txt As RadioButton
    Friend WithEvents op3_Txt As RadioButton
    Friend WithEvents op4_Txt As RadioButton
    Friend WithEvents photo As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Dbquestion_score_txt As Label
    Friend WithEvents strtbtn As Button
    Friend WithEvents topic_Txt As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents finish_label As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Diffcultylbl As Label
    Friend WithEvents topictxt_label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addQ_sub_txt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Qusername_lbl As Label
    Friend WithEvents userscore As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents difficulty_Txt As TextBox
End Class
