<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.difficulty_Txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.topic_Txt = New System.Windows.Forms.TextBox()
        Me.ans_Txt = New System.Windows.Forms.TextBox()
        Me.question_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.op4_Txt = New System.Windows.Forms.TextBox()
        Me.op3_Txt = New System.Windows.Forms.TextBox()
        Me.op2_Txt = New System.Windows.Forms.TextBox()
        Me.op1_Txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.question_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(141, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Difficulty"
        '
        'difficulty_Txt
        '
        Me.difficulty_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.difficulty_Txt.Location = New System.Drawing.Point(208, 67)
        Me.difficulty_Txt.Multiline = True
        Me.difficulty_Txt.Name = "difficulty_Txt"
        Me.difficulty_Txt.Size = New System.Drawing.Size(110, 22)
        Me.difficulty_Txt.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Topic"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 588)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Answer"
        '
        'topic_Txt
        '
        Me.topic_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.topic_Txt.Location = New System.Drawing.Point(208, 131)
        Me.topic_Txt.Multiline = True
        Me.topic_Txt.Name = "topic_Txt"
        Me.topic_Txt.Size = New System.Drawing.Size(298, 52)
        Me.topic_Txt.TabIndex = 44
        '
        'ans_Txt
        '
        Me.ans_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ans_Txt.Location = New System.Drawing.Point(37, 617)
        Me.ans_Txt.Name = "ans_Txt"
        Me.ans_Txt.Size = New System.Drawing.Size(100, 15)
        Me.ans_Txt.TabIndex = 43
        '
        'question_id
        '
        Me.question_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.question_id.Location = New System.Drawing.Point(144, 225)
        Me.question_id.Name = "question_id"
        Me.question_id.Size = New System.Drawing.Size(36, 15)
        Me.question_id.TabIndex = 39
        Me.question_id.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(457, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "4."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 465)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "3."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "2."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "1."
        '
        'op4_Txt
        '
        Me.op4_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op4_Txt.Location = New System.Drawing.Point(483, 465)
        Me.op4_Txt.Multiline = True
        Me.op4_Txt.Name = "op4_Txt"
        Me.op4_Txt.Size = New System.Drawing.Size(213, 42)
        Me.op4_Txt.TabIndex = 34
        '
        'op3_Txt
        '
        Me.op3_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op3_Txt.Location = New System.Drawing.Point(214, 465)
        Me.op3_Txt.Multiline = True
        Me.op3_Txt.Name = "op3_Txt"
        Me.op3_Txt.Size = New System.Drawing.Size(213, 42)
        Me.op3_Txt.TabIndex = 33
        '
        'op2_Txt
        '
        Me.op2_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op2_Txt.Location = New System.Drawing.Point(483, 395)
        Me.op2_Txt.Multiline = True
        Me.op2_Txt.Name = "op2_Txt"
        Me.op2_Txt.Size = New System.Drawing.Size(213, 42)
        Me.op2_Txt.TabIndex = 32
        '
        'op1_Txt
        '
        Me.op1_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op1_Txt.Location = New System.Drawing.Point(214, 397)
        Me.op1_Txt.Multiline = True
        Me.op1_Txt.Name = "op1_Txt"
        Me.op1_Txt.Size = New System.Drawing.Size(213, 42)
        Me.op1_Txt.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(602, 572)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 33)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Question "
        '
        'question_txt
        '
        Me.question_txt.Location = New System.Drawing.Point(186, 213)
        Me.question_txt.Multiline = True
        Me.question_txt.Name = "question_txt"
        Me.question_txt.Size = New System.Drawing.Size(510, 136)
        Me.question_txt.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(802, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 29)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "X"
        '
        'QuizFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(845, 686)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.difficulty_Txt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.topic_Txt)
        Me.Controls.Add(Me.ans_Txt)
        Me.Controls.Add(Me.question_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.op4_Txt)
        Me.Controls.Add(Me.op3_Txt)
        Me.Controls.Add(Me.op2_Txt)
        Me.Controls.Add(Me.op1_Txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.question_txt)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizFrm"
        Me.Text = "QuizFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents difficulty_Txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents topic_Txt As TextBox
    Friend WithEvents ans_Txt As TextBox
    Friend WithEvents question_id As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents op4_Txt As TextBox
    Friend WithEvents op3_Txt As TextBox
    Friend WithEvents op2_Txt As TextBox
    Friend WithEvents op1_Txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents question_txt As TextBox
    Private WithEvents Label2 As Label
End Class
