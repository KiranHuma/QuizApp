<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddQuestionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddQuestionFrm))
        Me.question_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.op1_Txt = New System.Windows.Forms.TextBox()
        Me.op2_Txt = New System.Windows.Forms.TextBox()
        Me.op3_Txt = New System.Windows.Forms.TextBox()
        Me.op4_Txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.question_id = New System.Windows.Forms.TextBox()
        Me.ans_Txt = New System.Windows.Forms.TextBox()
        Me.topic_Txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.difficulty_Txt = New System.Windows.Forms.ComboBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'question_txt
        '
        Me.question_txt.Location = New System.Drawing.Point(12, 195)
        Me.question_txt.Multiline = True
        Me.question_txt.Name = "question_txt"
        Me.question_txt.Size = New System.Drawing.Size(468, 57)
        Me.question_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Question "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(644, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Indigo
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(860, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'op1_Txt
        '
        Me.op1_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op1_Txt.Location = New System.Drawing.Point(39, 289)
        Me.op1_Txt.Multiline = True
        Me.op1_Txt.Name = "op1_Txt"
        Me.op1_Txt.Size = New System.Drawing.Size(203, 45)
        Me.op1_Txt.TabIndex = 9
        '
        'op2_Txt
        '
        Me.op2_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op2_Txt.Location = New System.Drawing.Point(277, 284)
        Me.op2_Txt.Multiline = True
        Me.op2_Txt.Name = "op2_Txt"
        Me.op2_Txt.Size = New System.Drawing.Size(203, 45)
        Me.op2_Txt.TabIndex = 10
        '
        'op3_Txt
        '
        Me.op3_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op3_Txt.Location = New System.Drawing.Point(39, 352)
        Me.op3_Txt.Multiline = True
        Me.op3_Txt.Name = "op3_Txt"
        Me.op3_Txt.Size = New System.Drawing.Size(203, 45)
        Me.op3_Txt.TabIndex = 11
        '
        'op4_Txt
        '
        Me.op4_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.op4_Txt.Location = New System.Drawing.Point(277, 352)
        Me.op4_Txt.Multiline = True
        Me.op4_Txt.Name = "op4_Txt"
        Me.op4_Txt.Size = New System.Drawing.Size(203, 45)
        Me.op4_Txt.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "1."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(248, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "2."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "3."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(251, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "4."
        '
        'question_id
        '
        Me.question_id.BackColor = System.Drawing.Color.Indigo
        Me.question_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.question_id.Enabled = False
        Me.question_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question_id.ForeColor = System.Drawing.Color.White
        Me.question_id.Location = New System.Drawing.Point(108, 174)
        Me.question_id.Name = "question_id"
        Me.question_id.Size = New System.Drawing.Size(36, 20)
        Me.question_id.TabIndex = 17
        Me.question_id.Text = "0"
        '
        'ans_Txt
        '
        Me.ans_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ans_Txt.Location = New System.Drawing.Point(90, 443)
        Me.ans_Txt.Multiline = True
        Me.ans_Txt.Name = "ans_Txt"
        Me.ans_Txt.Size = New System.Drawing.Size(244, 39)
        Me.ans_Txt.TabIndex = 21
        '
        'topic_Txt
        '
        Me.topic_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.topic_Txt.Location = New System.Drawing.Point(15, 56)
        Me.topic_Txt.Multiline = True
        Me.topic_Txt.Name = "topic_Txt"
        Me.topic_Txt.Size = New System.Drawing.Size(465, 50)
        Me.topic_Txt.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Answer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(13, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Topic"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Difficulty Level"
        '
        'difficulty_Txt
        '
        Me.difficulty_Txt.FormattingEnabled = True
        Me.difficulty_Txt.Items.AddRange(New Object() {"Easy", "Medium", "Difficult"})
        Me.difficulty_Txt.Location = New System.Drawing.Point(15, 142)
        Me.difficulty_Txt.Name = "difficulty_Txt"
        Me.difficulty_Txt.Size = New System.Drawing.Size(465, 24)
        Me.difficulty_Txt.TabIndex = 27
        '
        'photo
        '
        Me.photo.Image = CType(resources.GetObject("photo.Image"), System.Drawing.Image)
        Me.photo.Location = New System.Drawing.Point(647, 56)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(393, 350)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photo.TabIndex = 29
        Me.photo.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Indigo
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(786, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 36)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Upload Image"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(1100, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 29)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "X"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Indigo
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(968, 489)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 33)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Records"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Indigo
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(752, 489)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 33)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(34, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "noupdate"
        Me.Label2.Visible = False
        '
        'AddQuestionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1143, 549)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.photo)
        Me.Controls.Add(Me.difficulty_Txt)
        Me.Controls.Add(Me.Label11)
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
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.question_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddQuestionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents question_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents op1_Txt As TextBox
    Friend WithEvents op2_Txt As TextBox
    Friend WithEvents op3_Txt As TextBox
    Friend WithEvents op4_Txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents question_id As TextBox
    Friend WithEvents ans_Txt As TextBox
    Friend WithEvents topic_Txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents difficulty_Txt As ComboBox
    Friend WithEvents photo As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Private WithEvents Label13 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
End Class
