Public Class Pizza
    Structure pizza
        Dim sizeprice As Decimal
        Dim firsttop As Decimal
        Dim firststr As String
        Dim secondtop As Decimal
        Dim secondstr As String
        Dim thirdtop As Decimal
        Dim thirdstr As String
        Dim currenttotal As Decimal
    End Structure
    Dim currentpizza As pizza
    Dim vat As Integer
    Dim totaltotal As Decimal
    Dim firsttime As Boolean = True
    Dim 

    Private Sub cbb_Size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_Size.SelectedIndexChanged
        lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text - currentpizza.sizeprice
        If cbb_Size.Text = "Small - £5.99" Then
            currentpizza.sizeprice = 5.99
        ElseIf cbb_Size.Text = "Medium - £12.99" Then
            currentpizza.sizeprice = 12.99
        ElseIf cbb_Size.Text = "Large - £21.00" Then
            currentpizza.sizeprice = 21.0
        End If
        lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text + currentpizza.sizeprice
    End Sub

    Private Sub Pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbb_FirstTop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_FirstTop.SelectedIndexChanged

        If firsttime = True Then
            lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text + 1.5
            currentpizza.firsttop = 1.5


        End If
        firsttime = False
        currentpizza.firststr = cbb_FirstTop.Text

    End Sub

    Private Sub cbb_SecondTop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_SecondTop.SelectedIndexChanged
        lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text - currentpizza.secondtop
None:
        If cbb_SecondTop.Text <> "None" Then
            currentpizza.secondtop = 1.5
        ElseIf cbb_SecondTop.Text = "None" Then

            currentpizza.secondtop = 0
        End If
        lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text + currentpizza.secondtop
        currentpizza.secondstr = cbb_SecondTop.Text
        If currentpizza.secondstr = currentpizza.firststr Then
            MsgBox("Are you sure you want to double your toppings?", vbYesNo)
            If MsgBoxResult.No Then
                cbb_SecondTop.Text = "None"
                GoTo None
            ElseIf MsgBoxResult.Yes Then

            End If
        End If


    End Sub

    Private Sub cbb_ThirdTop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_ThirdTop.SelectedIndexChanged
        lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text - currentpizza.thirdtop
        If cbb_ThirdTop.Text <> "None" Then
            currentpizza.thirdtop = 1.5
        ElseIf cbb_ThirdTop.Text = "None" Then
            currentpizza.thirdtop = 0
        End If
        lbl_CurrentPizzaPrice.Text = lbl_CurrentPizzaPrice.Text + currentpizza.thirdtop
        currentpizza.thirdstr = cbb_ThirdTop.Text

    End Sub
End Class
