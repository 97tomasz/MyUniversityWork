Imports System.IO
Public Class PasswordEnter
    Dim passinput As String
    Dim passleng As Integer
    Dim passlc As Integer = 0
    Dim passuc As Integer = 0
    Dim passin As Integer = 0
    Dim passsp As Integer = 0
    Dim temp As String
    Dim count As Integer = 0
    Dim file_name As String = "N:\SavingTestFolder\PasswordFile1.txt"
    Dim txtfile = My.Computer.FileSystem.OpenTextFileWriter(file_name, True)
    Dim textline As String

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        If System.IO.File.Exists(file_name) = True Then

            Dim objReader As New System.IO.StreamReader(file_name)
            Do While objReader.Peek() <> -1
                textline = textline & objReader.ReadLine() & vbNewLine
            Loop
            MsgBox("Enter")
        ElseIf System.IO.File.Exists(file_name) = False Then
            System.IO.File.Create(file_name)
        End If
        temp = ""
        passinput = txt_PasswordEn.Text
        passleng = txt_PasswordEn.TextLength
        If passleng < 8 Then
            MsgBox("Password too short. 8 characters or more only")
            GoTo 1
        End If
        Do
            temp = txt_PasswordEn.Text(count)


            If 64 < Asc(temp) And Asc(temp) < 91 Then
                passuc = passuc + 1
            ElseIf 96 < Asc(temp) And Asc(temp) < 123 Then
                passlc = passlc + 1
            ElseIf 31 < Asc(temp) And Asc(temp) < 48 Or 57 < Asc(temp) And Asc(temp) < 65 Or 90 < Asc(temp) And Asc(temp) < 97 Or 122 < Asc(temp) And Asc(temp) < 127 Then
                passsp = passsp + 1
            ElseIf 47 < Asc(temp) And Asc(temp) < 58 Then
                passin = passin + 1
            End If

            count = count + 1
        Loop Until count = passleng

        MessageBox.Show("Uppercase: " & passuc & Environment.NewLine & "Lowercase: " & passlc & Environment.NewLine & "Numbers: " & passin & Environment.NewLine & "Specials: " & passsp)
        If passuc > 0 Then
            passuc = 1
        Else
            passuc = 0
        End If

        If passlc > 0 Then
            passlc = 1
        Else
            passlc = 0
        End If

        If passsp > 0 Then
            passsp = 1
        Else
            passsp = 0
        End If

        If passin > 0 Then
            passin = 1
        Else
            passin = 0
        End If
        If passuc + passlc + passsp + passin < 3 Then
            MessageBox.Show("Please use characters from at least 3 of these categories: " & Environment.NewLine & "Uppercase" & Environment.NewLine & "Lowercase" & Environment.NewLine & "Numbers" & Environment.NewLine & "Special Characters such as @")
        End If
1:

        txt_PasswordEn.Clear()
        txt_PasswordEn.Refresh()
    End Sub
End Class
