<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.lbl_InputWord = New System.Windows.Forms.Label()
        Me.txt_InputWord = New System.Windows.Forms.TextBox()
        Me.lbl_InputShift = New System.Windows.Forms.Label()
        Me.lbl_CustomShift = New System.Windows.Forms.Label()
        Me.txt_CustomShift = New System.Windows.Forms.TextBox()
        Me.lbl_RandomShift = New System.Windows.Forms.Label()
        Me.btn_RandomShift = New System.Windows.Forms.Button()
        Me.btn_Positive = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_Between = New System.Windows.Forms.Label()
        Me.btn_Negative = New System.Windows.Forms.Button()
        Me.txt_Display = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_InputWord
        '
        Me.lbl_InputWord.AutoSize = True
        Me.lbl_InputWord.Location = New System.Drawing.Point(108, 9)
        Me.lbl_InputWord.Name = "lbl_InputWord"
        Me.lbl_InputWord.Size = New System.Drawing.Size(149, 13)
        Me.lbl_InputWord.TabIndex = 0
        Me.lbl_InputWord.Text = "Input the text you want shifted"
        '
        'txt_InputWord
        '
        Me.txt_InputWord.Location = New System.Drawing.Point(111, 29)
        Me.txt_InputWord.Name = "txt_InputWord"
        Me.txt_InputWord.Size = New System.Drawing.Size(146, 20)
        Me.txt_InputWord.TabIndex = 1
        '
        'lbl_InputShift
        '
        Me.lbl_InputShift.AutoSize = True
        Me.lbl_InputShift.Location = New System.Drawing.Point(116, 52)
        Me.lbl_InputShift.Name = "lbl_InputShift"
        Me.lbl_InputShift.Size = New System.Drawing.Size(141, 13)
        Me.lbl_InputShift.TabIndex = 2
        Me.lbl_InputShift.Text = "Choose one of the following:"
        '
        'lbl_CustomShift
        '
        Me.lbl_CustomShift.AutoSize = True
        Me.lbl_CustomShift.Location = New System.Drawing.Point(217, 76)
        Me.lbl_CustomShift.Name = "lbl_CustomShift"
        Me.lbl_CustomShift.Size = New System.Drawing.Size(128, 13)
        Me.lbl_CustomShift.TabIndex = 3
        Me.lbl_CustomShift.Text = "Input custom shift amount"
        '
        'txt_CustomShift
        '
        Me.txt_CustomShift.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CustomShift.Location = New System.Drawing.Point(263, 92)
        Me.txt_CustomShift.Name = "txt_CustomShift"
        Me.txt_CustomShift.Size = New System.Drawing.Size(49, 20)
        Me.txt_CustomShift.TabIndex = 4
        '
        'lbl_RandomShift
        '
        Me.lbl_RandomShift.AutoSize = True
        Me.lbl_RandomShift.Location = New System.Drawing.Point(36, 76)
        Me.lbl_RandomShift.Name = "lbl_RandomShift"
        Me.lbl_RandomShift.Size = New System.Drawing.Size(124, 13)
        Me.lbl_RandomShift.TabIndex = 5
        Me.lbl_RandomShift.Text = "Shift by Random Amount"
        '
        'btn_RandomShift
        '
        Me.btn_RandomShift.Location = New System.Drawing.Point(39, 117)
        Me.btn_RandomShift.Name = "btn_RandomShift"
        Me.btn_RandomShift.Size = New System.Drawing.Size(101, 23)
        Me.btn_RandomShift.TabIndex = 6
        Me.btn_RandomShift.Text = "Random Shift"
        Me.btn_RandomShift.UseVisualStyleBackColor = True
        '
        'btn_Positive
        '
        Me.btn_Positive.Location = New System.Drawing.Point(227, 117)
        Me.btn_Positive.Name = "btn_Positive"
        Me.btn_Positive.Size = New System.Drawing.Size(60, 23)
        Me.btn_Positive.TabIndex = 7
        Me.btn_Positive.Text = "Positive"
        Me.btn_Positive.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(146, 117)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 9
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'lbl_Between
        '
        Me.lbl_Between.AutoSize = True
        Me.lbl_Between.Location = New System.Drawing.Point(47, 95)
        Me.lbl_Between.Name = "lbl_Between"
        Me.lbl_Between.Size = New System.Drawing.Size(93, 13)
        Me.lbl_Between.TabIndex = 10
        Me.lbl_Between.Text = "between 1 and 10"
        '
        'btn_Negative
        '
        Me.btn_Negative.Location = New System.Drawing.Point(285, 117)
        Me.btn_Negative.Name = "btn_Negative"
        Me.btn_Negative.Size = New System.Drawing.Size(60, 23)
        Me.btn_Negative.TabIndex = 11
        Me.btn_Negative.Text = "Negative"
        Me.btn_Negative.UseVisualStyleBackColor = True
        '
        'txt_Display
        '
        Me.txt_Display.Location = New System.Drawing.Point(39, 147)
        Me.txt_Display.Multiline = True
        Me.txt_Display.Name = "txt_Display"
        Me.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Display.Size = New System.Drawing.Size(306, 141)
        Me.txt_Display.TabIndex = 12
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 300)
        Me.Controls.Add(Me.txt_Display)
        Me.Controls.Add(Me.btn_Negative)
        Me.Controls.Add(Me.lbl_Between)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Positive)
        Me.Controls.Add(Me.btn_RandomShift)
        Me.Controls.Add(Me.lbl_RandomShift)
        Me.Controls.Add(Me.txt_CustomShift)
        Me.Controls.Add(Me.lbl_CustomShift)
        Me.Controls.Add(Me.lbl_InputShift)
        Me.Controls.Add(Me.txt_InputWord)
        Me.Controls.Add(Me.lbl_InputWord)
        Me.Name = "frm_Main"
        Me.Text = "Caesar Cypher v0.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_InputWord As System.Windows.Forms.Label
    Friend WithEvents txt_InputWord As System.Windows.Forms.TextBox
    Friend WithEvents lbl_InputShift As System.Windows.Forms.Label
    Friend WithEvents lbl_CustomShift As System.Windows.Forms.Label
    Friend WithEvents txt_CustomShift As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RandomShift As System.Windows.Forms.Label
    Friend WithEvents btn_RandomShift As System.Windows.Forms.Button
    Friend WithEvents btn_Positive As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_Between As System.Windows.Forms.Label
    Friend WithEvents btn_Negative As System.Windows.Forms.Button
    Friend WithEvents txt_Display As System.Windows.Forms.TextBox

End Class
