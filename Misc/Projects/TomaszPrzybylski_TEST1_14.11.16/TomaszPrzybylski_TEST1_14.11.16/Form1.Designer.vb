<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StudentDetails
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
        Me.txt_EnterFirstName = New System.Windows.Forms.TextBox()
        Me.lbl_EnterFirstName = New System.Windows.Forms.Label()
        Me.lbl_EnterSurname = New System.Windows.Forms.Label()
        Me.txt_EnterSurname = New System.Windows.Forms.TextBox()
        Me.lbl_EnterStudentNumber = New System.Windows.Forms.Label()
        Me.txt_EnterStudentNumber = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.txt_NoStudents = New System.Windows.Forms.TextBox()
        Me.lbl_TotalStudent = New System.Windows.Forms.Label()
        Me.btn_Scores = New System.Windows.Forms.Button()
        Me.lbl_studentnumber = New System.Windows.Forms.Label()
        Me.lbl_sl = New System.Windows.Forms.Label()
        Me.lbl_maxstudents = New System.Windows.Forms.Label()
        Me.btn_UpdateStudentNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_EnterFirstName
        '
        Me.txt_EnterFirstName.Location = New System.Drawing.Point(12, 25)
        Me.txt_EnterFirstName.Name = "txt_EnterFirstName"
        Me.txt_EnterFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txt_EnterFirstName.TabIndex = 0
        '
        'lbl_EnterFirstName
        '
        Me.lbl_EnterFirstName.AutoSize = True
        Me.lbl_EnterFirstName.Location = New System.Drawing.Point(9, 9)
        Me.lbl_EnterFirstName.Name = "lbl_EnterFirstName"
        Me.lbl_EnterFirstName.Size = New System.Drawing.Size(85, 13)
        Me.lbl_EnterFirstName.TabIndex = 1
        Me.lbl_EnterFirstName.Text = "Enter First Name"
        '
        'lbl_EnterSurname
        '
        Me.lbl_EnterSurname.AutoSize = True
        Me.lbl_EnterSurname.Location = New System.Drawing.Point(9, 64)
        Me.lbl_EnterSurname.Name = "lbl_EnterSurname"
        Me.lbl_EnterSurname.Size = New System.Drawing.Size(77, 13)
        Me.lbl_EnterSurname.TabIndex = 2
        Me.lbl_EnterSurname.Text = "Enter Surname"
        '
        'txt_EnterSurname
        '
        Me.txt_EnterSurname.Location = New System.Drawing.Point(12, 80)
        Me.txt_EnterSurname.Name = "txt_EnterSurname"
        Me.txt_EnterSurname.Size = New System.Drawing.Size(100, 20)
        Me.txt_EnterSurname.TabIndex = 3
        '
        'lbl_EnterStudentNumber
        '
        Me.lbl_EnterStudentNumber.AutoSize = True
        Me.lbl_EnterStudentNumber.Location = New System.Drawing.Point(9, 123)
        Me.lbl_EnterStudentNumber.Name = "lbl_EnterStudentNumber"
        Me.lbl_EnterStudentNumber.Size = New System.Drawing.Size(112, 13)
        Me.lbl_EnterStudentNumber.TabIndex = 4
        Me.lbl_EnterStudentNumber.Text = "Enter Student Number"
        '
        'txt_EnterStudentNumber
        '
        Me.txt_EnterStudentNumber.Location = New System.Drawing.Point(12, 139)
        Me.txt_EnterStudentNumber.Name = "txt_EnterStudentNumber"
        Me.txt_EnterStudentNumber.Size = New System.Drawing.Size(100, 20)
        Me.txt_EnterStudentNumber.TabIndex = 5
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(22, 165)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Submit.TabIndex = 6
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'txt_NoStudents
        '
        Me.txt_NoStudents.Location = New System.Drawing.Point(157, 44)
        Me.txt_NoStudents.Name = "txt_NoStudents"
        Me.txt_NoStudents.Size = New System.Drawing.Size(100, 20)
        Me.txt_NoStudents.TabIndex = 7
        '
        'lbl_TotalStudent
        '
        Me.lbl_TotalStudent.AutoSize = True
        Me.lbl_TotalStudent.Location = New System.Drawing.Point(141, 9)
        Me.lbl_TotalStudent.Name = "lbl_TotalStudent"
        Me.lbl_TotalStudent.Size = New System.Drawing.Size(131, 13)
        Me.lbl_TotalStudent.TabIndex = 8
        Me.lbl_TotalStudent.Text = "Total Number of Students:"
        '
        'btn_Scores
        '
        Me.btn_Scores.Location = New System.Drawing.Point(171, 165)
        Me.btn_Scores.Name = "btn_Scores"
        Me.btn_Scores.Size = New System.Drawing.Size(75, 23)
        Me.btn_Scores.TabIndex = 9
        Me.btn_Scores.Text = "Input Scores"
        Me.btn_Scores.UseVisualStyleBackColor = True
        '
        'lbl_studentnumber
        '
        Me.lbl_studentnumber.AutoSize = True
        Me.lbl_studentnumber.Location = New System.Drawing.Point(168, 28)
        Me.lbl_studentnumber.Name = "lbl_studentnumber"
        Me.lbl_studentnumber.Size = New System.Drawing.Size(13, 13)
        Me.lbl_studentnumber.TabIndex = 10
        Me.lbl_studentnumber.Text = "1"
        '
        'lbl_sl
        '
        Me.lbl_sl.AutoSize = True
        Me.lbl_sl.Location = New System.Drawing.Point(197, 28)
        Me.lbl_sl.Name = "lbl_sl"
        Me.lbl_sl.Size = New System.Drawing.Size(12, 13)
        Me.lbl_sl.TabIndex = 11
        Me.lbl_sl.Text = "/"
        '
        'lbl_maxstudents
        '
        Me.lbl_maxstudents.AutoSize = True
        Me.lbl_maxstudents.Location = New System.Drawing.Point(225, 28)
        Me.lbl_maxstudents.Name = "lbl_maxstudents"
        Me.lbl_maxstudents.Size = New System.Drawing.Size(13, 13)
        Me.lbl_maxstudents.TabIndex = 12
        Me.lbl_maxstudents.Text = "1"
        '
        'btn_UpdateStudentNo
        '
        Me.btn_UpdateStudentNo.Location = New System.Drawing.Point(171, 70)
        Me.btn_UpdateStudentNo.Name = "btn_UpdateStudentNo"
        Me.btn_UpdateStudentNo.Size = New System.Drawing.Size(75, 23)
        Me.btn_UpdateStudentNo.TabIndex = 13
        Me.btn_UpdateStudentNo.Text = "Update"
        Me.btn_UpdateStudentNo.UseVisualStyleBackColor = True
        '
        'frm_StudentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_UpdateStudentNo)
        Me.Controls.Add(Me.lbl_maxstudents)
        Me.Controls.Add(Me.lbl_sl)
        Me.Controls.Add(Me.lbl_studentnumber)
        Me.Controls.Add(Me.btn_Scores)
        Me.Controls.Add(Me.lbl_TotalStudent)
        Me.Controls.Add(Me.txt_NoStudents)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_EnterStudentNumber)
        Me.Controls.Add(Me.lbl_EnterStudentNumber)
        Me.Controls.Add(Me.txt_EnterSurname)
        Me.Controls.Add(Me.lbl_EnterSurname)
        Me.Controls.Add(Me.lbl_EnterFirstName)
        Me.Controls.Add(Me.txt_EnterFirstName)
        Me.Name = "frm_StudentDetails"
        Me.Text = "Student Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_EnterFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EnterFirstName As System.Windows.Forms.Label
    Friend WithEvents lbl_EnterSurname As System.Windows.Forms.Label
    Friend WithEvents txt_EnterSurname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EnterStudentNumber As System.Windows.Forms.Label
    Friend WithEvents txt_EnterStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents txt_NoStudents As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalStudent As System.Windows.Forms.Label
    Friend WithEvents btn_Scores As System.Windows.Forms.Button
    Friend WithEvents lbl_studentnumber As System.Windows.Forms.Label
    Friend WithEvents lbl_sl As System.Windows.Forms.Label
    Friend WithEvents lbl_maxstudents As System.Windows.Forms.Label
    Friend WithEvents btn_UpdateStudentNo As System.Windows.Forms.Button

End Class
