<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Scores
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
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_Surname = New System.Windows.Forms.Label()
        Me.lbl_Number = New System.Windows.Forms.Label()
        Me.lbl_Unit1Marks = New System.Windows.Forms.Label()
        Me.txt_U1Marks = New System.Windows.Forms.TextBox()
        Me.lbl_Unit2Marks = New System.Windows.Forms.Label()
        Me.txt_U2Marks = New System.Windows.Forms.TextBox()
        Me.lbl_Unit3Marks = New System.Windows.Forms.Label()
        Me.txt_U3Marks = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.lbl_U1Grade = New System.Windows.Forms.Label()
        Me.lbl_U3Grade = New System.Windows.Forms.Label()
        Me.lbl_U2Grade = New System.Windows.Forms.Label()
        Me.lbl_FinalGrade = New System.Windows.Forms.Label()
        Me.lbl_OverallGrade = New System.Windows.Forms.Label()
        Me.txt_EnterName = New System.Windows.Forms.TextBox()
        Me.txt_DOBDay = New System.Windows.Forms.TextBox()
        Me.txt_EnterStudentNumber = New System.Windows.Forms.TextBox()
        Me.btn_Finished = New System.Windows.Forms.Button()
        Me.txt_DOBMon = New System.Windows.Forms.TextBox()
        Me.txt_DOBYear = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(13, 44)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(78, 13)
        Me.lbl_FirstName.TabIndex = 4
        Me.lbl_FirstName.Text = "Student Name:"
        '
        'lbl_Surname
        '
        Me.lbl_Surname.AutoSize = True
        Me.lbl_Surname.Location = New System.Drawing.Point(13, 78)
        Me.lbl_Surname.Name = "lbl_Surname"
        Me.lbl_Surname.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Surname.TabIndex = 5
        Me.lbl_Surname.Text = "Student DOB:"
        '
        'lbl_Number
        '
        Me.lbl_Number.AutoSize = True
        Me.lbl_Number.Location = New System.Drawing.Point(13, 111)
        Me.lbl_Number.Name = "lbl_Number"
        Me.lbl_Number.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Number.TabIndex = 6
        Me.lbl_Number.Text = "Student Number:"
        '
        'lbl_Unit1Marks
        '
        Me.lbl_Unit1Marks.AutoSize = True
        Me.lbl_Unit1Marks.Location = New System.Drawing.Point(32, 151)
        Me.lbl_Unit1Marks.Name = "lbl_Unit1Marks"
        Me.lbl_Unit1Marks.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Unit1Marks.TabIndex = 7
        Me.lbl_Unit1Marks.Text = "Unit 1 Marks"
        '
        'txt_U1Marks
        '
        Me.txt_U1Marks.Location = New System.Drawing.Point(16, 167)
        Me.txt_U1Marks.Name = "txt_U1Marks"
        Me.txt_U1Marks.Size = New System.Drawing.Size(100, 20)
        Me.txt_U1Marks.TabIndex = 8
        '
        'lbl_Unit2Marks
        '
        Me.lbl_Unit2Marks.AutoSize = True
        Me.lbl_Unit2Marks.Location = New System.Drawing.Point(32, 190)
        Me.lbl_Unit2Marks.Name = "lbl_Unit2Marks"
        Me.lbl_Unit2Marks.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Unit2Marks.TabIndex = 9
        Me.lbl_Unit2Marks.Text = "Unit 2 Marks"
        '
        'txt_U2Marks
        '
        Me.txt_U2Marks.Location = New System.Drawing.Point(16, 206)
        Me.txt_U2Marks.Name = "txt_U2Marks"
        Me.txt_U2Marks.Size = New System.Drawing.Size(100, 20)
        Me.txt_U2Marks.TabIndex = 10
        '
        'lbl_Unit3Marks
        '
        Me.lbl_Unit3Marks.AutoSize = True
        Me.lbl_Unit3Marks.Location = New System.Drawing.Point(32, 229)
        Me.lbl_Unit3Marks.Name = "lbl_Unit3Marks"
        Me.lbl_Unit3Marks.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Unit3Marks.TabIndex = 11
        Me.lbl_Unit3Marks.Text = "Unit 3 Marks"
        '
        'txt_U3Marks
        '
        Me.txt_U3Marks.Location = New System.Drawing.Point(16, 245)
        Me.txt_U3Marks.Name = "txt_U3Marks"
        Me.txt_U3Marks.Size = New System.Drawing.Size(100, 20)
        Me.txt_U3Marks.TabIndex = 12
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(25, 293)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 19)
        Me.btn_Submit.TabIndex = 16
        Me.btn_Submit.Text = "New"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'lbl_U1Grade
        '
        Me.lbl_U1Grade.AutoSize = True
        Me.lbl_U1Grade.Location = New System.Drawing.Point(168, 170)
        Me.lbl_U1Grade.Name = "lbl_U1Grade"
        Me.lbl_U1Grade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_U1Grade.TabIndex = 17
        Me.lbl_U1Grade.Text = "Label1"
        '
        'lbl_U3Grade
        '
        Me.lbl_U3Grade.AutoSize = True
        Me.lbl_U3Grade.Location = New System.Drawing.Point(168, 248)
        Me.lbl_U3Grade.Name = "lbl_U3Grade"
        Me.lbl_U3Grade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_U3Grade.TabIndex = 18
        Me.lbl_U3Grade.Text = "Label1"
        '
        'lbl_U2Grade
        '
        Me.lbl_U2Grade.AutoSize = True
        Me.lbl_U2Grade.Location = New System.Drawing.Point(168, 209)
        Me.lbl_U2Grade.Name = "lbl_U2Grade"
        Me.lbl_U2Grade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_U2Grade.TabIndex = 19
        Me.lbl_U2Grade.Text = "Label1"
        '
        'lbl_FinalGrade
        '
        Me.lbl_FinalGrade.AutoSize = True
        Me.lbl_FinalGrade.Location = New System.Drawing.Point(15, 395)
        Me.lbl_FinalGrade.Name = "lbl_FinalGrade"
        Me.lbl_FinalGrade.Size = New System.Drawing.Size(119, 13)
        Me.lbl_FinalGrade.TabIndex = 21
        Me.lbl_FinalGrade.Text = "Final Grade of Student: "
        '
        'lbl_OverallGrade
        '
        Me.lbl_OverallGrade.AutoSize = True
        Me.lbl_OverallGrade.Location = New System.Drawing.Point(168, 395)
        Me.lbl_OverallGrade.Name = "lbl_OverallGrade"
        Me.lbl_OverallGrade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_OverallGrade.TabIndex = 22
        Me.lbl_OverallGrade.Text = "Label1"
        '
        'txt_EnterName
        '
        Me.txt_EnterName.Location = New System.Drawing.Point(139, 41)
        Me.txt_EnterName.Name = "txt_EnterName"
        Me.txt_EnterName.Size = New System.Drawing.Size(100, 20)
        Me.txt_EnterName.TabIndex = 26
        '
        'txt_DOBDay
        '
        Me.txt_DOBDay.Location = New System.Drawing.Point(139, 75)
        Me.txt_DOBDay.Name = "txt_DOBDay"
        Me.txt_DOBDay.Size = New System.Drawing.Size(27, 20)
        Me.txt_DOBDay.TabIndex = 27
        Me.txt_DOBDay.Text = "DD"
        '
        'txt_EnterStudentNumber
        '
        Me.txt_EnterStudentNumber.Location = New System.Drawing.Point(139, 108)
        Me.txt_EnterStudentNumber.Name = "txt_EnterStudentNumber"
        Me.txt_EnterStudentNumber.Size = New System.Drawing.Size(100, 20)
        Me.txt_EnterStudentNumber.TabIndex = 28
        '
        'btn_Finished
        '
        Me.btn_Finished.Location = New System.Drawing.Point(149, 291)
        Me.btn_Finished.Name = "btn_Finished"
        Me.btn_Finished.Size = New System.Drawing.Size(75, 23)
        Me.btn_Finished.TabIndex = 29
        Me.btn_Finished.Text = "Finished"
        Me.btn_Finished.UseVisualStyleBackColor = True
        '
        'txt_DOBMon
        '
        Me.txt_DOBMon.Location = New System.Drawing.Point(172, 75)
        Me.txt_DOBMon.Name = "txt_DOBMon"
        Me.txt_DOBMon.Size = New System.Drawing.Size(25, 20)
        Me.txt_DOBMon.TabIndex = 30
        Me.txt_DOBMon.Text = "MM"
        '
        'txt_DOBYear
        '
        Me.txt_DOBYear.Location = New System.Drawing.Point(203, 75)
        Me.txt_DOBYear.Name = "txt_DOBYear"
        Me.txt_DOBYear.Size = New System.Drawing.Size(36, 20)
        Me.txt_DOBYear.TabIndex = 31
        Me.txt_DOBYear.Text = "YYYY"
        '
        'Frm_Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.txt_DOBYear)
        Me.Controls.Add(Me.txt_DOBMon)
        Me.Controls.Add(Me.btn_Finished)
        Me.Controls.Add(Me.txt_EnterStudentNumber)
        Me.Controls.Add(Me.txt_DOBDay)
        Me.Controls.Add(Me.txt_EnterName)
        Me.Controls.Add(Me.lbl_OverallGrade)
        Me.Controls.Add(Me.lbl_FinalGrade)
        Me.Controls.Add(Me.lbl_U2Grade)
        Me.Controls.Add(Me.lbl_U3Grade)
        Me.Controls.Add(Me.lbl_U1Grade)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_U3Marks)
        Me.Controls.Add(Me.lbl_Unit3Marks)
        Me.Controls.Add(Me.txt_U2Marks)
        Me.Controls.Add(Me.lbl_Unit2Marks)
        Me.Controls.Add(Me.txt_U1Marks)
        Me.Controls.Add(Me.lbl_Unit1Marks)
        Me.Controls.Add(Me.lbl_Number)
        Me.Controls.Add(Me.lbl_Surname)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Name = "Frm_Scores"
        Me.Text = "Student Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_FirstName As System.Windows.Forms.Label
    Friend WithEvents lbl_Surname As System.Windows.Forms.Label
    Friend WithEvents lbl_Number As System.Windows.Forms.Label
    Friend WithEvents lbl_Unit1Marks As System.Windows.Forms.Label
    Friend WithEvents txt_U1Marks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Unit2Marks As System.Windows.Forms.Label
    Friend WithEvents txt_U2Marks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Unit3Marks As System.Windows.Forms.Label
    Friend WithEvents txt_U3Marks As System.Windows.Forms.TextBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents lbl_U1Grade As System.Windows.Forms.Label
    Friend WithEvents lbl_U3Grade As System.Windows.Forms.Label
    Friend WithEvents lbl_U2Grade As System.Windows.Forms.Label
    Friend WithEvents lbl_FinalGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_OverallGrade As System.Windows.Forms.Label
    Friend WithEvents txt_EnterName As System.Windows.Forms.TextBox
    Friend WithEvents txt_DOBDay As System.Windows.Forms.TextBox
    Friend WithEvents txt_EnterStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents btn_Finished As System.Windows.Forms.Button
    Friend WithEvents txt_DOBMon As System.Windows.Forms.TextBox
    Friend WithEvents txt_DOBYear As System.Windows.Forms.TextBox
End Class
