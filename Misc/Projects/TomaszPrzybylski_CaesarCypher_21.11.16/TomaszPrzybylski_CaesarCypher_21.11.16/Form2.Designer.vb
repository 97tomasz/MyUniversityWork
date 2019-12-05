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
        Me.lbl_Cypheroutput = New System.Windows.Forms.Label()
        Me.lbl_Shiftamount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Cypheroutput
        '
        Me.lbl_Cypheroutput.AutoSize = True
        Me.lbl_Cypheroutput.Location = New System.Drawing.Point(0, 40)
        Me.lbl_Cypheroutput.Name = "lbl_Cypheroutput"
        Me.lbl_Cypheroutput.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Cypheroutput.TabIndex = 1
        Me.lbl_Cypheroutput.Text = "label1"
        '
        'lbl_Shiftamount
        '
        Me.lbl_Shiftamount.AutoSize = True
        Me.lbl_Shiftamount.Location = New System.Drawing.Point(0, 73)
        Me.lbl_Shiftamount.Name = "lbl_Shiftamount"
        Me.lbl_Shiftamount.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Shiftamount.TabIndex = 2
        Me.lbl_Shiftamount.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 129)
        Me.Controls.Add(Me.lbl_Shiftamount)
        Me.Controls.Add(Me.lbl_Cypheroutput)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Cypheroutput As System.Windows.Forms.Label
    Friend WithEvents lbl_Shiftamount As System.Windows.Forms.Label
End Class
