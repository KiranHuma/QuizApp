﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupFrm
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.CmboGender = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Uid_txt = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtentry = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.txtPassAgain = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.CmboGender)
        Me.panel1.Controls.Add(Me.Label10)
        Me.panel1.Controls.Add(Me.Uid_txt)
        Me.panel1.Controls.Add(Me.label12)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.label11)
        Me.panel1.Controls.Add(Me.txtentry)
        Me.panel1.Controls.Add(Me.txtUsername)
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.txtName)
        Me.panel1.Controls.Add(Me.txtPass)
        Me.panel1.Controls.Add(Me.txtEmail)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.txtPassAgain)
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.txtContact)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Location = New System.Drawing.Point(104, 32)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(582, 588)
        Me.panel1.TabIndex = 24
        '
        'CmboGender
        '
        Me.CmboGender.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboGender.Location = New System.Drawing.Point(206, 379)
        Me.CmboGender.Name = "CmboGender"
        Me.CmboGender.Size = New System.Drawing.Size(218, 23)
        Me.CmboGender.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(65, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "UserID"
        '
        'Uid_txt
        '
        Me.Uid_txt.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uid_txt.Location = New System.Drawing.Point(206, 180)
        Me.Uid_txt.Name = "Uid_txt"
        Me.Uid_txt.Size = New System.Drawing.Size(218, 23)
        Me.Uid_txt.TabIndex = 25
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(36, 95)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(336, 23)
        Me.label12.TabIndex = 24
        Me.label12.Text = "Please fill in the form to create account!"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Indigo
        Me.panel2.Location = New System.Drawing.Point(3, 138)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(576, 11)
        Me.panel2.TabIndex = 23
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.Black
        Me.label11.Location = New System.Drawing.Point(31, 39)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(111, 36)
        Me.label11.TabIndex = 22
        Me.label11.Text = "Sign Up"
        '
        'txtentry
        '
        Me.txtentry.AutoSize = True
        Me.txtentry.ForeColor = System.Drawing.Color.White
        Me.txtentry.Location = New System.Drawing.Point(219, 167)
        Me.txtentry.Name = "txtentry"
        Me.txtentry.Size = New System.Drawing.Size(16, 17)
        Me.txtentry.TabIndex = 12
        Me.txtentry.Text = "1"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(206, 219)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(218, 23)
        Me.txtUsername.TabIndex = 0
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(65, 504)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(44, 18)
        Me.label7.TabIndex = 21
        Me.label7.Text = "label7"
        Me.label7.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(206, 258)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(218, 23)
        Me.txtName.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(206, 297)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(218, 23)
        Me.txtPass.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(206, 456)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(218, 23)
        Me.txtEmail.TabIndex = 4
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Indigo
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(206, 524)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(90, 34)
        Me.button2.TabIndex = 17
        Me.button2.Text = "SignUp"
        Me.button2.UseVisualStyleBackColor = False
        '
        'txtPassAgain
        '
        Me.txtPassAgain.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassAgain.Location = New System.Drawing.Point(206, 336)
        Me.txtPassAgain.Name = "txtPassAgain"
        Me.txtPassAgain.Size = New System.Drawing.Size(218, 23)
        Me.txtPassAgain.TabIndex = 5
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label9.ForeColor = System.Drawing.Color.Black
        Me.label9.Location = New System.Drawing.Point(65, 420)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(91, 20)
        Me.label9.TabIndex = 16
        Me.label9.Text = "Contact no."
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(65, 220)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 20)
        Me.label1.TabIndex = 6
        Me.label1.Text = "UserName"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(206, 417)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(218, 23)
        Me.txtContact.TabIndex = 15
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(65, 260)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 20)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Name"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(430, 337)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(44, 18)
        Me.label8.TabIndex = 14
        Me.label8.Text = "label8"
        Me.label8.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(65, 300)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 20)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Password"
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(322, 524)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(102, 34)
        Me.button1.TabIndex = 13
        Me.button1.Text = "Login"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(65, 340)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(115, 20)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Password Again"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(65, 380)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(61, 20)
        Me.label5.TabIndex = 10
        Me.label5.Text = "Gender"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(65, 460)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(47, 20)
        Me.label6.TabIndex = 11
        Me.label6.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(775, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 29)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "X"
        '
        'SignupFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(818, 652)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignupFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignupFrm"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
	Private WithEvents label12 As Label
	Private WithEvents panel2 As Panel
	Private WithEvents label11 As Label
	Private WithEvents txtentry As Label
	Private WithEvents txtUsername As TextBox
	Private WithEvents label7 As Label
	Private WithEvents txtName As TextBox
	Private WithEvents txtPass As TextBox
	Private WithEvents txtEmail As TextBox
	Private WithEvents button2 As Button
	Private WithEvents txtPassAgain As TextBox
	Private WithEvents label9 As Label
	Private WithEvents label1 As Label
	Private WithEvents txtContact As TextBox
	Private WithEvents label2 As Label
	Private WithEvents label8 As Label
	Private WithEvents label3 As Label
	Private WithEvents button1 As Button
	Private WithEvents label4 As Label
	Private WithEvents label5 As Label
	Private WithEvents label6 As Label
	Private WithEvents Uid_txt As TextBox
	Private WithEvents Label10 As Label
	Private WithEvents CmboGender As TextBox
    Private WithEvents Label13 As Label
End Class
