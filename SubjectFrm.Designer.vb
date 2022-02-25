<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.subject_grid = New System.Windows.Forms.DataGridView()
        Me.category_searchtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.addQ_subb_txt = New System.Windows.Forms.TextBox()
        Me.username_lbl = New System.Windows.Forms.TextBox()
        Me.userscore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.subject_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(319, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 29)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "X"
        '
        'subject_grid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        Me.subject_grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.subject_grid.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subject_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.subject_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.subject_grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.subject_grid.GridColor = System.Drawing.Color.White
        Me.subject_grid.Location = New System.Drawing.Point(12, 189)
        Me.subject_grid.Name = "subject_grid"
        Me.subject_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subject_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.subject_grid.RowHeadersWidth = 51
        Me.subject_grid.RowTemplate.Height = 24
        Me.subject_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.subject_grid.Size = New System.Drawing.Size(338, 391)
        Me.subject_grid.TabIndex = 33
        '
        'category_searchtxt
        '
        Me.category_searchtxt.Location = New System.Drawing.Point(12, 139)
        Me.category_searchtxt.Name = "category_searchtxt"
        Me.category_searchtxt.Size = New System.Drawing.Size(338, 22)
        Me.category_searchtxt.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(188, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 37)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Search Subject"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'addQ_subb_txt
        '
        Me.addQ_subb_txt.Location = New System.Drawing.Point(25, 42)
        Me.addQ_subb_txt.Name = "addQ_subb_txt"
        Me.addQ_subb_txt.Size = New System.Drawing.Size(100, 22)
        Me.addQ_subb_txt.TabIndex = 36
        '
        'username_lbl
        '
        Me.username_lbl.Location = New System.Drawing.Point(155, 42)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(100, 22)
        Me.username_lbl.TabIndex = 37
        '
        'userscore
        '
        Me.userscore.Location = New System.Drawing.Point(25, 96)
        Me.userscore.Name = "userscore"
        Me.userscore.Size = New System.Drawing.Size(100, 22)
        Me.userscore.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(152, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Score"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(275, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SubjectFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(370, 592)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userscore)
        Me.Controls.Add(Me.username_lbl)
        Me.Controls.Add(Me.addQ_subb_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.category_searchtxt)
        Me.Controls.Add(Me.subject_grid)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SubjectFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubjectFrm"
        CType(Me.subject_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label13 As Label
    Friend WithEvents subject_grid As DataGridView
    Friend WithEvents category_searchtxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents addQ_subb_txt As TextBox
    Friend WithEvents username_lbl As TextBox
    Friend WithEvents userscore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
