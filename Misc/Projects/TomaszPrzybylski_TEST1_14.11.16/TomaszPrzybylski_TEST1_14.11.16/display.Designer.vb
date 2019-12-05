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
        Me.lbl_displayname = New System.Windows.Forms.Label()
        Me.lbl_displaysurname = New System.Windows.Forms.Label()
        Me.lbl_displaynumber = New System.Windows.Forms.Label()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_Surname = New System.Windows.Forms.Label()
        Me.lbl_Number = New System.Windows.Forms.Label()
        Me.lbl_MathsMarks = New System.Windows.Forms.Label()
        Me.txt_MathsMarks = New System.Windows.Forms.TextBox()
        Me.lbl_EnglishMarks = New System.Windows.Forms.Label()
        Me.txt_EnglishMarks = New System.Windows.Forms.TextBox()
        Me.lbl_SysAnMarks = New System.Windows.Forms.Label()
        Me.txt_SysAnMarks = New System.Windows.Forms.TextBox()
        Me.lbl_ProgInfMarks1 = New System.Windows.Forms.Label()
        Me.lbl_ProgInfMarks2 = New System.Windows.Forms.Label()
        Me.txt_ProgInfMarks = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.lbl_MathsGrade = New System.Windows.Forms.Label()
        Me.lbl_SysAnGrade = New System.Windows.Forms.Label()
        Me.lbl_EnglishGrade = New System.Windows.Forms.Label()
        Me.lbl_ProgInfGrade = New System.Windows.Forms.Label()
        Me.lbl_FinalGrade = New System.Windows.Forms.Label()
        Me.lbl_OverallGrade = New System.Windows.Forms.Label()
        Me.lbl_CurrentStd = New System.Windows.Forms.Label()
        Me.lbl_Div = New System.Windows.Forms.Label()
        Me.lbl_MaxStd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_displayname
        '
        Me.lbl_displayname.AutoSize = True
        Me.lbl_displayname.Location = New System.Drawing.Point(168, 44)
        Me.lbl_displayname.Name = "lbl_displayname"
        Me.lbl_displayname.Size = New System.Drawing.Size(39, 13)
        Me.lbl_displayname.TabIndex = 0
        Me.lbl_displayname.Text = "Label1"
        '
        'lbl_displaysurname
        '
        Me.lbl_displaysurname.AutoSize = True
        Me.lbl_displaysurname.Location = New System.Drawing.Point(168, 78)
        Me.lbl_displaysurname.Name = "lbl_displaysurname"
        Me.lbl_displaysurname.Size = New System.Drawing.Size(39, 13)
        Me.lbl_displaysurname.TabIndex = 1
        Me.lbl_displaysurname.Text = "Label2"
        '
        'lbl_displaynumber
        '
        Me.lbl_displaynumber.AutoSize = True
        Me.lbl_displaynumber.Location = New System.Drawing.Point(168, 111)
        Me.lbl_displaynumber.Name = "lbl_displaynumber"
        Me.lbl_displaynumber.Size = New System.Drawing.Size(39, 13)
        Me.lbl_displaynumber.TabIndex = 2
        Me.lbl_displaynumber.Text = "Label3"
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(13, 44)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(100, 13)
        Me.lbl_FirstName.TabIndex = 4
        Me.lbl_FirstName.Text = "Student First Name:"
        '
        'lbl_Surname
        '
        Me.lbl_Surname.AutoSize = True
        Me.lbl_Surname.Location = New System.Drawing.Point(13, 78)
        Me.lbl_Surname.Name = "lbl_Surname"
        Me.lbl_Surname.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Surname.TabIndex = 5
        Me.lbl_Surname.Text = "Student Surname:"
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
        'lbl_MathsMarks
        '
        Me.lbl_MathsMarks.AutoSize = True
        Me.lbl_MathsMarks.Location = New System.Drawing.Point(32, 151)
        Me.lbl_MathsMarks.Name = "lbl_MathsMarks"
        Me.lbl_MathsMarks.Size = New System.Drawing.Size(68, 13)
        Me.lbl_MathsMarks.TabIndex = 7
        Me.lbl_MathsMarks.Text = "Maths Marks"
        '
        'txt_MathsMarks
        '
        Me.txt_MathsMarks.Location = New System.Drawing.Point(16, 167)
        Me.txt_MathsMarks.Name = "txt_MathsMarks"
        Me.txt_MathsMarks.Size = New System.Drawing.Size(100, 20)
        Me.txt_MathsMarks.TabIndex = 8
        '
        'lbl_EnglishMarks
        '
        Me.lbl_EnglishMarks.AutoSize = True
        Me.lbl_EnglishMarks.Location = New System.Drawing.Point(29, 190)
        Me.lbl_EnglishMarks.Name = "lbl_EnglishMarks"
        Me.lbl_EnglishMarks.Size = New System.Drawing.Size(73, 13)
        Me.lbl_EnglishMarks.TabIndex = 9
        Me.lbl_EnglishMarks.Text = "English Marks"
        '
        'txt_EnglishMarks
        '
        Me.txt_EnglishMarks.Location = New System.Drawing.Point(16, 206)
        Me.txt_EnglishMarks.Name = "txt_EnglishMarks"
        Me.txt_EnglishMarks.Size = New System.Drawing.Size(100, 20)
        Me.txt_EnglishMarks.TabIndex = 10
        '
        'lbl_SysAnMarks
        '
        Me.lbl_SysAnMarks.AutoSize = True
        Me.lbl_SysAnMarks.Location = New System.Drawing.Point(12, 229)
        Me.lbl_SysAnMarks.Name = "lbl_SysAnMarks"
        Me.lbl_SysAnMarks.Size = New System.Drawing.Size(114, 13)
        Me.lbl_SysAnMarks.TabIndex = 11
        Me.lbl_SysAnMarks.Text = "System Analysis Marks"
        '
        'txt_SysAnMarks
        '
        Me.txt_SysAnMarks.Location = New System.Drawing.Point(16, 245)
        Me.txt_SysAnMarks.Name = "txt_SysAnMarks"
        Me.txt_SysAnMarks.Size = New System.Drawing.Size(100, 20)
        Me.txt_SysAnMarks.TabIndex = 12
        '
        'lbl_ProgInfMarks1
        '
        Me.lbl_ProgInfMarks1.AutoSize = True
        Me.lbl_ProgInfMarks1.Location = New System.Drawing.Point(16, 268)
        Me.lbl_ProgInfMarks1.Name = "lbl_ProgInfMarks1"
        Me.lbl_ProgInfMarks1.Size = New System.Drawing.Size(89, 13)
        Me.lbl_ProgInfMarks1.TabIndex = 13
        Me.lbl_ProgInfMarks1.Text = "Programming and"
        '
        'lbl_ProgInfMarks2
        '
        Me.lbl_ProgInfMarks2.AutoSize = True
        Me.lbl_ProgInfMarks2.Location = New System.Drawing.Point(15, 281)
        Me.lbl_ProgInfMarks2.Name = "lbl_ProgInfMarks2"
        Me.lbl_ProgInfMarks2.Size = New System.Drawing.Size(101, 13)
        Me.lbl_ProgInfMarks2.TabIndex = 14
        Me.lbl_ProgInfMarks2.Text = "Information Systems"
        '
        'txt_ProgInfMarks
        '
        Me.txt_ProgInfMarks.Location = New System.Drawing.Point(16, 297)
        Me.txt_ProgInfMarks.Name = "txt_ProgInfMarks"
        Me.txt_ProgInfMarks.Size = New System.Drawing.Size(100, 20)
        Me.txt_ProgInfMarks.TabIndex = 15
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(27, 323)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 19)
        Me.btn_Submit.TabIndex = 16
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'lbl_MathsGrade
        '
        Me.lbl_MathsGrade.AutoSize = True
        Me.lbl_MathsGrade.Location = New System.Drawing.Point(168, 170)
        Me.lbl_MathsGrade.Name = "lbl_MathsGrade"
        Me.lbl_MathsGrade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_MathsGrade.TabIndex = 17
        Me.lbl_MathsGrade.Text = "Label1"
        '
        'lbl_SysAnGrade
        '
        Me.lbl_SysAnGrade.AutoSize = True
        Me.lbl_SysAnGrade.Location = New System.Drawing.Point(168, 248)
        Me.lbl_SysAnGrade.Name = "lbl_SysAnGrade"
        Me.lbl_SysAnGrade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_SysAnGrade.TabIndex = 18
        Me.lbl_SysAnGrade.Text = "Label1"
        '
        'lbl_EnglishGrade
        '
        Me.lbl_EnglishGrade.AutoSize = True
        Me.lbl_EnglishGrade.Location = New System.Drawing.Point(168, 209)
        Me.lbl_EnglishGrade.Name = "lbl_EnglishGrade"
        Me.lbl_EnglishGrade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_EnglishGrade.TabIndex = 19
        Me.lbl_EnglishGrade.Text = "Label1"
        '
        'lbl_ProgInfGrade
        '
        Me.lbl_ProgInfGrade.AutoSize = True
        Me.lbl_ProgInfGrade.Location = New System.Drawing.Point(168, 300)
        Me.lbl_ProgInfGrade.Name = "lbl_ProgInfGrade"
        Me.lbl_ProgInfGrade.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ProgInfGrade.TabIndex = 20
        Me.lbl_ProgInfGrade.Text = "Label1"
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
        'lbl_CurrentStd
        '
        Me.lbl_CurrentStd.AutoSize = True
        Me.lbl_CurrentStd.Location = New System.Drawing.Point(32, 13)
        Me.lbl_CurrentStd.Name = "lbl_CurrentStd"
        Me.lbl_CurrentStd.Size = New System.Drawing.Size(13, 13)
        Me.lbl_CurrentStd.TabIndex = 23
        Me.lbl_CurrentStd.Text = "1"
        '
        'lbl_Div
        '
        Me.lbl_Div.AutoSize = True
        Me.lbl_Div.Location = New System.Drawing.Point(51, 13)
        Me.lbl_Div.Name = "lbl_Div"
        Me.lbl_Div.Size = New System.Drawing.Size(12, 13)
        Me.lbl_Div.TabIndex = 24
        Me.lbl_Div.Text = "/"
        '
        'lbl_MaxStd
        '
        Me.lbl_MaxStd.AutoSize = True
        Me.lbl_MaxStd.Location = New System.Drawing.Point(69, 13)
        Me.lbl_MaxStd.Name = "lbl_MaxStd"
        Me.lbl_MaxStd.Size = New System.Drawing.Size(13, 13)
        Me.lbl_MaxStd.TabIndex = 25
        Me.lbl_MaxStd.Text = "1"
        '
        'Frm_Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 462)
        Me.Controls.Add(Me.lbl_MaxStd)
        Me.Controls.Add(Me.lbl_Div)
        Me.Controls.Add(Me.lbl_CurrentStd)
        Me.Controls.Add(Me.lbl_OverallGrade)
        Me.Controls.Add(Me.lbl_FinalGrade)
        Me.Controls.Add(Me.lbl_ProgInfGrade)
        Me.Controls.Add(Me.lbl_EnglishGrade)
        Me.Controls.Add(Me.lbl_SysAnGrade)
        Me.Controls.Add(Me.lbl_MathsGrade)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_ProgInfMarks)
        Me.Controls.Add(Me.lbl_ProgInfMarks2)
        Me.Controls.Add(Me.lbl_ProgInfMarks1)
        Me.Controls.Add(Me.txt_SysAnMarks)
        Me.Controls.Add(Me.lbl_SysAnMarks)
        Me.Controls.Add(Me.txt_EnglishMarks)
        Me.Controls.Add(Me.lbl_EnglishMarks)
        Me.Controls.Add(Me.txt_MathsMarks)
        Me.Controls.Add(Me.lbl_MathsMarks)
        Me.Controls.Add(Me.lbl_Number)
        Me.Controls.Add(Me.lbl_Surname)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.lbl_displaynumber)
        Me.Controls.Add(Me.lbl_displaysurname)
        Me.Controls.Add(Me.lbl_displayname)
        Me.Name = "Frm_Scores"
        Me.Text = "Student Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_displayname As System.Windows.Forms.Label
    Friend WithEvents lbl_displaysurname As System.Windows.Forms.Label
    Friend WithEvents lbl_displaynumber As System.Windows.Forms.Label
    Friend WithEvents lbl_FirstName As System.Windows.Forms.Label
    Friend WithEvents lbl_Surname As System.Windows.Forms.Label
    Friend WithEvents lbl_Number As System.Windows.Forms.Label
    Friend WithEvents lbl_MathsMarks As System.Windows.Forms.Label
    Friend WithEvents txt_MathsMarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EnglishMarks As System.Windows.Forms.Label
    Friend WithEvents txt_EnglishMarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SysAnMarks As System.Windows.Forms.Label
    Friend WithEvents txt_SysAnMarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ProgInfMarks1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ProgInfMarks2 As System.Windows.Forms.Label
    Friend WithEvents txt_ProgInfMarks As System.Windows.Forms.TextBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents lbl_MathsGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_SysAnGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_EnglishGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_ProgInfGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_FinalGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_OverallGrade As System.Windows.Forms.Label
    Friend WithEvents lbl_CurrentStd As System.Windows.Forms.Label
    Friend WithEvents lbl_Div As System.Windows.Forms.Label
    Friend WithEvents lbl_MaxStd As System.Windows.Forms.Label
End Class
