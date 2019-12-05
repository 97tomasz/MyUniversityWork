<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.txt_Enternth = New System.Windows.Forms.TextBox()
        Me.txt_DisplaySeq = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.txt_DisplayFibo = New System.Windows.Forms.TextBox()
        Me.txt_CheckInput = New System.Windows.Forms.TextBox()
        Me.txt_CheckOutput = New System.Windows.Forms.TextBox()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Location = New System.Drawing.Point(9, 9)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(140, 13)
        Me.lbl_info.TabIndex = 0
        Me.lbl_info.Text = "Enter n-th Fibonacci number"
        '
        'txt_Enternth
        '
        Me.txt_Enternth.Location = New System.Drawing.Point(12, 27)
        Me.txt_Enternth.Name = "txt_Enternth"
        Me.txt_Enternth.Size = New System.Drawing.Size(53, 20)
        Me.txt_Enternth.TabIndex = 1
        '
        'txt_DisplaySeq
        '
        Me.txt_DisplaySeq.Location = New System.Drawing.Point(12, 54)
        Me.txt_DisplaySeq.Multiline = True
        Me.txt_DisplaySeq.Name = "txt_DisplaySeq"
        Me.txt_DisplaySeq.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_DisplaySeq.Size = New System.Drawing.Size(291, 272)
        Me.txt_DisplaySeq.TabIndex = 2
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(71, 25)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 20)
        Me.btn_Submit.TabIndex = 3
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'txt_DisplayFibo
        '
        Me.txt_DisplayFibo.Location = New System.Drawing.Point(152, 27)
        Me.txt_DisplayFibo.Name = "txt_DisplayFibo"
        Me.txt_DisplayFibo.Size = New System.Drawing.Size(150, 20)
        Me.txt_DisplayFibo.TabIndex = 4
        '
        'txt_CheckInput
        '
        Me.txt_CheckInput.Location = New System.Drawing.Point(12, 332)
        Me.txt_CheckInput.Name = "txt_CheckInput"
        Me.txt_CheckInput.Size = New System.Drawing.Size(110, 20)
        Me.txt_CheckInput.TabIndex = 5
        '
        'txt_CheckOutput
        '
        Me.txt_CheckOutput.Location = New System.Drawing.Point(209, 331)
        Me.txt_CheckOutput.Name = "txt_CheckOutput"
        Me.txt_CheckOutput.Size = New System.Drawing.Size(93, 20)
        Me.txt_CheckOutput.TabIndex = 6
        '
        'btn_Check
        '
        Me.btn_Check.Location = New System.Drawing.Point(128, 331)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(75, 20)
        Me.btn_Check.TabIndex = 7
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 357)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.txt_CheckOutput)
        Me.Controls.Add(Me.txt_CheckInput)
        Me.Controls.Add(Me.txt_DisplayFibo)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_DisplaySeq)
        Me.Controls.Add(Me.txt_Enternth)
        Me.Controls.Add(Me.lbl_info)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_info As System.Windows.Forms.Label
    Friend WithEvents txt_Enternth As System.Windows.Forms.TextBox
    Friend WithEvents txt_DisplaySeq As System.Windows.Forms.TextBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents txt_DisplayFibo As System.Windows.Forms.TextBox
    Friend WithEvents txt_CheckInput As System.Windows.Forms.TextBox
    Friend WithEvents txt_CheckOutput As System.Windows.Forms.TextBox
    Friend WithEvents btn_Check As System.Windows.Forms.Button

End Class
