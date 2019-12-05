<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza
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
        Me.cbb_Size = New System.Windows.Forms.ComboBox()
        Me.lbl_Size = New System.Windows.Forms.Label()
        Me.lbl_Topping1 = New System.Windows.Forms.Label()
        Me.lbl_Topping2 = New System.Windows.Forms.Label()
        Me.lbl_Topping3 = New System.Windows.Forms.Label()
        Me.cbb_FirstTop = New System.Windows.Forms.ComboBox()
        Me.cbb_SecondTop = New System.Windows.Forms.ComboBox()
        Me.cbb_ThirdTop = New System.Windows.Forms.ComboBox()
        Me.lbl_CurrentPizzaPrice = New System.Windows.Forms.Label()
        Me.lbl_TotalPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbb_Size
        '
        Me.cbb_Size.FormattingEnabled = True
        Me.cbb_Size.Items.AddRange(New Object() {"Small - £5.99", "Medium - £12.99", "Large - £21.00"})
        Me.cbb_Size.Location = New System.Drawing.Point(1, 41)
        Me.cbb_Size.Name = "cbb_Size"
        Me.cbb_Size.Size = New System.Drawing.Size(105, 21)
        Me.cbb_Size.TabIndex = 0
        '
        'lbl_Size
        '
        Me.lbl_Size.AutoSize = True
        Me.lbl_Size.Location = New System.Drawing.Point(22, 25)
        Me.lbl_Size.Name = "lbl_Size"
        Me.lbl_Size.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Size.TabIndex = 1
        Me.lbl_Size.Text = "Size of Pizza"
        '
        'lbl_Topping1
        '
        Me.lbl_Topping1.AutoSize = True
        Me.lbl_Topping1.Location = New System.Drawing.Point(106, 26)
        Me.lbl_Topping1.Name = "lbl_Topping1"
        Me.lbl_Topping1.Size = New System.Drawing.Size(154, 13)
        Me.lbl_Topping1.TabIndex = 2
        Me.lbl_Topping1.Text = "First Topping (included in price)"
        '
        'lbl_Topping2
        '
        Me.lbl_Topping2.AutoSize = True
        Me.lbl_Topping2.Location = New System.Drawing.Point(270, 25)
        Me.lbl_Topping2.Name = "lbl_Topping2"
        Me.lbl_Topping2.Size = New System.Drawing.Size(86, 13)
        Me.lbl_Topping2.TabIndex = 3
        Me.lbl_Topping2.Text = "Second Topping"
        '
        'lbl_Topping3
        '
        Me.lbl_Topping3.AutoSize = True
        Me.lbl_Topping3.Location = New System.Drawing.Point(389, 25)
        Me.lbl_Topping3.Name = "lbl_Topping3"
        Me.lbl_Topping3.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Topping3.TabIndex = 4
        Me.lbl_Topping3.Text = "Third Topping"
        '
        'cbb_FirstTop
        '
        Me.cbb_FirstTop.FormattingEnabled = True
        Me.cbb_FirstTop.Items.AddRange(New Object() {"Ham", "Olives", "Chicken", "Pineapple"})
        Me.cbb_FirstTop.Location = New System.Drawing.Point(141, 42)
        Me.cbb_FirstTop.Name = "cbb_FirstTop"
        Me.cbb_FirstTop.Size = New System.Drawing.Size(90, 21)
        Me.cbb_FirstTop.TabIndex = 5
        '
        'cbb_SecondTop
        '
        Me.cbb_SecondTop.FormattingEnabled = True
        Me.cbb_SecondTop.Items.AddRange(New Object() {"None", "Ham", "Olives", "Chicken", "Pineapple"})
        Me.cbb_SecondTop.Location = New System.Drawing.Point(266, 42)
        Me.cbb_SecondTop.Name = "cbb_SecondTop"
        Me.cbb_SecondTop.Size = New System.Drawing.Size(90, 21)
        Me.cbb_SecondTop.TabIndex = 6
        '
        'cbb_ThirdTop
        '
        Me.cbb_ThirdTop.FormattingEnabled = True
        Me.cbb_ThirdTop.Items.AddRange(New Object() {"None", "Ham", "Olives", "Chicken", "Pineapple"})
        Me.cbb_ThirdTop.Location = New System.Drawing.Point(382, 41)
        Me.cbb_ThirdTop.Name = "cbb_ThirdTop"
        Me.cbb_ThirdTop.Size = New System.Drawing.Size(90, 21)
        Me.cbb_ThirdTop.TabIndex = 7
        '
        'lbl_CurrentPizzaPrice
        '
        Me.lbl_CurrentPizzaPrice.AutoSize = True
        Me.lbl_CurrentPizzaPrice.Location = New System.Drawing.Point(22, 78)
        Me.lbl_CurrentPizzaPrice.Name = "lbl_CurrentPizzaPrice"
        Me.lbl_CurrentPizzaPrice.Size = New System.Drawing.Size(13, 13)
        Me.lbl_CurrentPizzaPrice.TabIndex = 8
        Me.lbl_CurrentPizzaPrice.Text = "0"
        '
        'lbl_TotalPrice
        '
        Me.lbl_TotalPrice.AutoSize = True
        Me.lbl_TotalPrice.Location = New System.Drawing.Point(22, 120)
        Me.lbl_TotalPrice.Name = "lbl_TotalPrice"
        Me.lbl_TotalPrice.Size = New System.Drawing.Size(13, 13)
        Me.lbl_TotalPrice.TabIndex = 9
        Me.lbl_TotalPrice.Text = "0"
        '
        'Pizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 142)
        Me.Controls.Add(Me.lbl_TotalPrice)
        Me.Controls.Add(Me.lbl_CurrentPizzaPrice)
        Me.Controls.Add(Me.cbb_ThirdTop)
        Me.Controls.Add(Me.cbb_SecondTop)
        Me.Controls.Add(Me.cbb_FirstTop)
        Me.Controls.Add(Me.lbl_Topping3)
        Me.Controls.Add(Me.lbl_Topping2)
        Me.Controls.Add(Me.lbl_Topping1)
        Me.Controls.Add(Me.lbl_Size)
        Me.Controls.Add(Me.cbb_Size)
        Me.Name = "Pizza"
        Me.Text = "Pizza Choice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbb_Size As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Size As System.Windows.Forms.Label
    Friend WithEvents lbl_Topping1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Topping2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Topping3 As System.Windows.Forms.Label
    Friend WithEvents cbb_FirstTop As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_SecondTop As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_ThirdTop As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CurrentPizzaPrice As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalPrice As System.Windows.Forms.Label

End Class
