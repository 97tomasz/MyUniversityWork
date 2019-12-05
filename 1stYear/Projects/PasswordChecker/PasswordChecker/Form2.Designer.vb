<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_firstname = New System.Windows.Forms.TextBox()
        Me.txt_surname = New System.Windows.Forms.TextBox()
        Me.txt_optional = New System.Windows.Forms.TextBox()
        Me.btn_Generate = New System.Windows.Forms.Button()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_kword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_firstname
        '
        Me.txt_firstname.Location = New System.Drawing.Point(157, 12)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(100, 20)
        Me.txt_firstname.TabIndex = 0
        '
        'txt_surname
        '
        Me.txt_surname.Location = New System.Drawing.Point(157, 49)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(100, 20)
        Me.txt_surname.TabIndex = 1
        '
        'txt_optional
        '
        Me.txt_optional.Location = New System.Drawing.Point(157, 86)
        Me.txt_optional.Name = "txt_optional"
        Me.txt_optional.Size = New System.Drawing.Size(100, 20)
        Me.txt_optional.TabIndex = 2
        '
        'btn_Generate
        '
        Me.btn_Generate.Location = New System.Drawing.Point(78, 157)
        Me.btn_Generate.Name = "btn_Generate"
        Me.btn_Generate.Size = New System.Drawing.Size(113, 23)
        Me.btn_Generate.TabIndex = 3
        Me.btn_Generate.Text = "Generate Password"
        Me.btn_Generate.UseVisualStyleBackColor = True
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Location = New System.Drawing.Point(18, 15)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(133, 13)
        Me.lbl_fname.TabIndex = 4
        Me.lbl_fname.Text = "Enter First Name (Optional)"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.Location = New System.Drawing.Point(26, 52)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(125, 13)
        Me.lbl_sname.TabIndex = 5
        Me.lbl_sname.Text = "Enter Surname (Optional)"
        '
        'lbl_kword
        '
        Me.lbl_kword.AutoSize = True
        Me.lbl_kword.Location = New System.Drawing.Point(24, 89)
        Me.lbl_kword.Name = "lbl_kword"
        Me.lbl_kword.Size = New System.Drawing.Size(127, 13)
        Me.lbl_kword.TabIndex = 6
        Me.lbl_kword.Text = "Keyword/Other (Optional)"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl_kword)
        Me.Controls.Add(Me.lbl_sname)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.btn_Generate)
        Me.Controls.Add(Me.txt_optional)
        Me.Controls.Add(Me.txt_surname)
        Me.Controls.Add(Me.txt_firstname)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_firstname As System.Windows.Forms.TextBox
    Friend WithEvents txt_surname As System.Windows.Forms.TextBox
    Friend WithEvents txt_optional As System.Windows.Forms.TextBox
    Friend WithEvents btn_Generate As System.Windows.Forms.Button
    Friend WithEvents lbl_fname As System.Windows.Forms.Label
    Friend WithEvents lbl_sname As System.Windows.Forms.Label
    Friend WithEvents lbl_kword As System.Windows.Forms.Label
End Class
