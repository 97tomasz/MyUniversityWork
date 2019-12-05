<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordEnter
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
        Me.txt_PasswordEn = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_UnameEn = New System.Windows.Forms.TextBox()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_PasswordEn
        '
        Me.txt_PasswordEn.Location = New System.Drawing.Point(12, 90)
        Me.txt_PasswordEn.Name = "txt_PasswordEn"
        Me.txt_PasswordEn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_PasswordEn.Size = New System.Drawing.Size(173, 20)
        Me.txt_PasswordEn.TabIndex = 0
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(12, 144)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 25)
        Me.btn_Submit.TabIndex = 1
        Me.btn_Submit.Text = "Login"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'btn_Create
        '
        Me.btn_Create.Location = New System.Drawing.Point(110, 144)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(75, 25)
        Me.btn_Create.TabIndex = 2
        Me.btn_Create.Text = "Generate"
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'txt_UnameEn
        '
        Me.txt_UnameEn.Location = New System.Drawing.Point(12, 29)
        Me.txt_UnameEn.Name = "txt_UnameEn"
        Me.txt_UnameEn.Size = New System.Drawing.Size(173, 20)
        Me.txt_UnameEn.TabIndex = 5
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(74, 116)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(53, 22)
        Me.btn_help.TabIndex = 6
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'PasswordEnter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 179)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.txt_UnameEn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_PasswordEn)
        Me.Name = "PasswordEnter"
        Me.Text = "Enter Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_PasswordEn As System.Windows.Forms.TextBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents btn_Create As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_UnameEn As System.Windows.Forms.TextBox
    Friend WithEvents btn_help As System.Windows.Forms.Button

End Class
