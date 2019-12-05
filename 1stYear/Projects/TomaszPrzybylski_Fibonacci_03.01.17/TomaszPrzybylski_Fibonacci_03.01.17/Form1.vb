Public Class Form1
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        txt_DisplaySeq.Clear()

        Dim Ln_a As Long = 0
        Dim Ln_b As Long = 1
        Dim Ln_fibo As Long = 0 'Fibonacci number
        Dim Int_nth As Integer = 1 'N-th Fibonacci number

        txt_DisplaySeq.Text = "*0th Number* " & txt_DisplaySeq.Text + Ln_a.ToString & ControlChars.NewLine 'Displays the first two digits of the Fibonacci sequence (0, 1)
        txt_DisplaySeq.Text = txt_DisplaySeq.Text + Ln_b.ToString & ControlChars.NewLine
        Try
            Do
                Ln_fibo = Ln_a + LN_b 'Adds the two values of a and b'
                Ln_a = Ln_b 'A takes the value of B, while B takes the value of a+b'
                Ln_b = Ln_fibo
                txt_DisplaySeq.Text = txt_DisplaySeq.Text + Ln_fibo.ToString & ControlChars.NewLine 'Writes the fibonacci number to the text box and creates a new line'
                Int_nth = Int_nth + 1
            Loop Until Int_nth = txt_Enternth.Text
            'Loops for nth number of times before stopping the loop
        
            txt_DisplayFibo.Text = Ln_fibo.ToString 'writes final loop result to the text box
        Catch ex As Exception
            txt_DisplaySeq.Text = "Invalid Term - Check if out of range"
            txt_DisplayFibo.Text = "Invalid Term"
        End Try
    End Sub

    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        Dim Dbl_a As Double = 0
        Dim Dbl_b As Double = 1
        Dim Dbl_fibo As Double = 0
        Dim Int_nth As Integer = 1

        Dim Dbl_checkinput As Double
        Dim Bln_fibonacci As Boolean
        Try
            Dbl_checkinput = txt_CheckInput.Text
        Catch ex As Exception

        End Try

        If Dbl_checkinput < 1 Then
            txt_CheckInput.Text = "Invalid Input"
        End If

        Do
            Dbl_fibo = Dbl_a + Dbl_b
            If Dbl_fibo = Dbl_checkinput Then 'checks if the input is a fibonacci number with each loop
                Bln_fibonacci = True 'if the two numbers match then the loop will end early
                txt_CheckOutput.Text = Int_nth + 1 'If the input is a fibonacci number, this will display which fibonacci number it is.
            End If
            Dbl_a = Dbl_b
            Dbl_b = Dbl_fibo
            Int_nth = Int_nth + 1
        Loop Until Int_nth = 300 Or Bln_fibonacci = True
        'Loops until the number being checked turns out to be a Fibonacci or until Loop gets to 300th iteration
        If Bln_fibonacci = True Then
        Else
            txt_CheckOutput.Text = "Not Fibonacci"
        End If
    End Sub

End Class
