
Public Class frm_Main

    Dim Str_cypherinput As String 'the string input is assigned here 
    Public Int_shiftamount As Integer 'the integer input for the shift 
    Public Str_cypheroutput As String 'the string after it has been shifted
    Dim Int_Inputlength As Integer 'the length of the input string
    Dim IntArr_ShiftArr(1) As Integer 'an array storing the ASCII of the shifted character
    Dim StrArr_PostArr(1) As String 'an array storing the shifted character
    Dim Int_ran As Integer 'takes the value of the randomly generated number
    Dim Rdm_Rd As New Random 'used to generate a random number

    Private Sub btn_RandomShift_Click(sender As Object, e As EventArgs) Handles btn_RandomShift.Click

        Str_cypherinput = UCase(txt_InputWord.Text) 'converts string to uppercase

        Int_Inputlength = txt_InputWord.TextLength - 1 'corrects the string length so that calculations are correct

        Int_ran = Rdm_Rd.Next(1, 11) 'generates a random integer between inclusive 1 and exclusive 11 (1-10)
        Int_shiftamount = Int_ran
        ReDim IntArr_ShiftArr(Int_Inputlength) 're-declares the IntArr_ShiftArr to the size of the string length
        ReDim StrArr_PostArr(Int_Inputlength) 're-declares the StrArr_PostArr to the size of the string length

        If txt_InputWord.Text = "" Then
            MsgBox("No String Input")
            GoTo escape1

        End If
        For i = 0 To Int_Inputlength

            If Str_cypherinput(i) <> " " Then
                IntArr_ShiftArr(i) = Asc(Str_cypherinput(i)) + Int_shiftamount 'converts the current character into ASCII and adds the shift amount onto the ASCII value
                If IntArr_ShiftArr(i) > 90 Then
                    IntArr_ShiftArr(i) = IntArr_ShiftArr(i) - 26 'if the ASCII value is above the uppercase Z value, that particular ASCII value is moved back down to uppercase A, creating a loop like a physical caesar cypher would create
                End If
                StrArr_PostArr(i) = Convert.ToChar(IntArr_ShiftArr(i))
            ElseIf Str_cypherinput(i) = " " Then 'spaces are kept in the same place
                StrArr_PostArr(i) = " "
            End If

        Next

        For i = 0 To Int_Inputlength

            Str_cypheroutput = Str_cypheroutput + StrArr_PostArr(i) 'this re-creates the string with the new encrypted characters

        Next

        txt_Display.Text = txt_Display.Text + Str_cypheroutput & " Shift Amount: " & Int_shiftamount.ToString & ControlChars.NewLine 'displays the encrypted (or decrypted) string in the textbox on the bottom, and creates a new line
        Str_cypheroutput = ""

escape1:
    End Sub


    Private Sub btn_positive_Click(sender As Object, e As EventArgs) Handles btn_Positive.Click

        'majority of this code is the same as previous, with only some of the variables changed and lacking the integer generation
        Str_cypherinput = UCase(txt_InputWord.Text)

        Int_Inputlength = txt_InputWord.TextLength - 1

        Try 'a try catch block, in case there is a problem with the shift input
            Int_shiftamount = txt_CustomShift.Text
        Catch ex As Exception
            MessageBox.Show("Invalid Shift Input")
        End Try


        If Int_shiftamount >= 26 Or Int_shiftamount < 1 Then
            MessageBox.Show("Please input a number between 1 and 25")
            GoTo escape1

        End If

        ReDim IntArr_ShiftArr(Int_Inputlength)
        ReDim StrArr_PostArr(Int_Inputlength)

        For i = 0 To Int_Inputlength

            If Str_cypherinput(i) <> " " Then
                IntArr_ShiftArr(i) = Asc(Str_cypherinput(i)) + Int_shiftamount
                If IntArr_ShiftArr(i) > 90 Then
                    IntArr_ShiftArr(i) = IntArr_ShiftArr(i) - 26 'this accounts for the "Positive" shift
                End If
                StrArr_PostArr(i) = Convert.ToChar(IntArr_ShiftArr(i))
            ElseIf Str_cypherinput(i) = " " Then
                StrArr_PostArr(i) = " "
            End If

        Next

        For i = 0 To Int_Inputlength

            Str_cypheroutput = Str_cypheroutput + StrArr_PostArr(i)

        Next
        txt_Display.Text = txt_Display.Text + Str_cypheroutput & ControlChars.NewLine
        Str_cypheroutput = ""
escape1:
    End Sub


    Private Sub txt_customshift_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CustomShift.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True 'disables the user from inputting any non-integer characters
        End If

    End Sub


    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        txt_Display.Clear() 'clears the display

    End Sub

    Private Sub btn_Negative_Click(sender As Object, e As EventArgs) Handles btn_Negative.Click
        Str_cypherinput = UCase(txt_InputWord.Text) 'identical to the positive shift sub, just moves the ASCII down instead of up

        Int_Inputlength = txt_InputWord.TextLength - 1

        Try
            Int_shiftamount = txt_CustomShift.Text
        Catch ex As Exception
            MessageBox.Show("Invalid Shift Input")
        End Try


        If Int_shiftamount >= 26 Or Int_shiftamount < 1 Then
            MessageBox.Show("Please input a number between 1 and 25")
            GoTo escape1
        End If

        ReDim IntArr_ShiftArr(Int_Inputlength)
        ReDim StrArr_PostArr(Int_Inputlength)

        For i = 0 To Int_Inputlength

            If Str_cypherinput(i) <> " " Then
                IntArr_ShiftArr(i) = Asc(Str_cypherinput(i)) - Int_shiftamount
                If IntArr_ShiftArr(i) < 65 Then
                    IntArr_ShiftArr(i) = IntArr_ShiftArr(i) + 26 'this accounts for the "Negative" shift
                End If
                StrArr_PostArr(i) = Convert.ToChar(IntArr_ShiftArr(i))
            ElseIf Str_cypherinput(i) = " " Then
                StrArr_PostArr(i) = " "
            End If

        Next

        For i = 0 To Int_Inputlength

            Str_cypheroutput = Str_cypheroutput + StrArr_PostArr(i)

        Next

        txt_Display.Text = txt_Display.Text + Str_cypheroutput & ControlChars.NewLine
        Str_cypheroutput = ""
escape1:
    End Sub

    Private Sub txt_InputWord_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_InputWord.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True 'disables input of numbers of symbols (apart from Spacebar) into the "Input text" textbox
        End If
    End Sub
End Class
