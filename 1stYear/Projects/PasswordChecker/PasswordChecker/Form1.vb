Imports System.IO
Public Class PasswordEnter
    Structure loaded
        'this structure deals with the loaded username and password. Used in the validation
        Dim lpass As String
        Dim luser As String
    End Structure
    Dim loadedinfo(1) As loaded

    Dim str_passinput As String
    Dim int_passleng As Integer 'length of password
    Dim int_passlc As Integer = 0 'amount of lowercase characters in password
    Dim int_passuc As Integer = 0 'amount of uppercase characters in password
    Dim int_passin As Integer = 0 'amount of integer characters in password
    Dim int_passsp As Integer = 0 'amount of special characters in password
    Dim str_temp As String
    Dim int_count As Integer = 0 'Used in loops
    Dim str_userinput As String
    Public file_name As String = "N:\SavingTestFolder\PasswordFile1.txt" 'File path and name of the textfile the reading and writing will be taking place.
    Dim bln_usercorrect As Boolean 'Used in the validation. Returns true if the entered username matches the stored username
    Dim bln_passcorrect As Boolean 'Used in the validation. Returns true if the entered password matches the stored password
    Dim filelength As Integer 'Used in the reading of the file to work out the length of the file.
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        'Submit_Click is the sub responsible for the Login button. This sub reads from the file and checks the entered information against the stored information and returns the results.
        int_count = 0
        If System.IO.File.Exists(file_name) = True Then 'Making sure the file is present. 

            Dim objcounter As New System.IO.StreamReader(file_name) 'Reads the file to work out how large the file is.
            Do While objcounter.Peek() <> -1
                filelength = filelength + 1
                objcounter.ReadLine()
            Loop
            objcounter.Close()
            Dim objreader As New System.IO.StreamReader(file_name)
            ReDim loadedinfo(filelength) 'Re-declared the size of (loadedinfo) so that the entirety of the file can be stored in the structure, without needing a pre-set size.
            Do While objreader.Peek() <> -1 'Reads the contents of the file, two lines at a time. The first line will always be the username, the second the password. 

                int_count = int_count + 1
                loadedinfo(int_count).luser = objreader.ReadLine

                loadedinfo(int_count).lpass = objreader.ReadLine
            Loop

            objreader.Close()

        ElseIf System.IO.File.Exists(file_name) = False Then 'If file is not present, file is created at file_name
            System.IO.File.Create(file_name)
            Dim objcounter As New System.IO.StreamReader(file_name)
            Do While objcounter.Peek() <> -1
                filelength = filelength + 1
                objcounter.ReadLine()
            Loop
            objcounter.Close()
            Dim objreader As New System.IO.StreamReader(file_name)
            ReDim loadedinfo(filelength)
            Do While objreader.Peek() <> -1

                int_count = int_count + 1
                loadedinfo(int_count).luser = objreader.ReadLine

                loadedinfo(int_count).lpass = objreader.ReadLine
            Loop

            objreader.Close()
        End If

        str_userinput = txt_UnameEn.Text
        For i = 1 To int_count
            If loadedinfo(i).luser = str_userinput Then 'each entry in the structure is checked against the input and if the two match, bln_usercorrect changes to True.
                bln_usercorrect = True
                MsgBox("User Correct")
                i = int_count
            Else : bln_usercorrect = False
            End If

        Next
        str_passinput = txt_PasswordEn.Text
        If bln_usercorrect = True Then 'If the entered username matched one of the stored ones, the passwords are then checked the same way. If the usernames were not the same, password checking is unnecessary. 
            For i = 1 To int_count
                If loadedinfo(i).lpass = str_passinput Then 'Stored passwords are checked against the entered password and if two match, bln_passcorrect is made True.
                    bln_passcorrect = True
                    MsgBox("Pass correct")
                    i = int_count

                Else : bln_passcorrect = False
                End If

            Next
        End If
        If bln_usercorrect = True And bln_passcorrect = True Then 'If both validations are successful, this message is displayed
            MsgBox("Login Successful")
        End If
        If bln_usercorrect = False Or bln_passcorrect = False Then 'If either validation fails, this message is displayed
            MsgBox("Details not found. Please check the inputs for mistakes, or alternatively please create the account using 'Generate'")
        End If

        txt_PasswordEn.Clear()
        txt_PasswordEn.Refresh()
    End Sub

    Private Sub PasswordEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'A help message available when the program starts and when "Help" is clicked
        MsgBox("If you would like to login to your account, please input the correct username and password details and click on Login. Otherwise, please input the desired Username and Password and click generate, and the account will be created. If you would like to have a password generated for you, please leave the password field completely blank.")
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        MsgBox("If you would like to login to your account, please input the correct username and password details and click on Login. Otherwise, please input the desired Username and Password and click generate, and the account will be created. If you would like to have a password generated for you, please leave the password field completely blank.")
    End Sub

    Private Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        'This sub handles the "Generate" button and the writing to file of User details and random generation of a password.
        str_temp = ""

        If txt_PasswordEn.Text = "" Or txt_PasswordEn.Text.ToLower = "generate" Then 'Unless the password field is blank or has the word generate in it, the program will atstr_tempt to write the string in the password enter field to the textfile.
            My.Forms.Form2.Show()
        Else
            int_passleng = txt_PasswordEn.TextLength

            If int_passleng < 8 Then 'Checks string length
                MsgBox("Password too short. 8 characters or more only")
                GoTo 1
            End If

            int_count = 0
            Do
                str_temp = txt_PasswordEn.Text(int_count)

                If 64 < Asc(str_temp) And Asc(str_temp) < 91 Then 'Checks string's Uppercase count
                    int_passuc = int_passuc + 1
                ElseIf 96 < Asc(str_temp) And Asc(str_temp) < 123 Then 'Checks string's Lowercase count
                    int_passlc = int_passlc + 1
                ElseIf 31 < Asc(str_temp) And Asc(str_temp) < 48 Or 57 < Asc(str_temp) And Asc(str_temp) < 65 Or 90 < Asc(str_temp) And Asc(str_temp) < 97 Or 122 < Asc(str_temp) And Asc(str_temp) < 127 Then 'Checks string's special count
                    int_passsp = int_passsp + 1
                ElseIf 47 < Asc(str_temp) And Asc(str_temp) < 58 Then 'Checks string's Integer count
                    int_passin = int_passin + 1
                End If

                int_count = int_count + 1
            Loop Until int_count = int_passleng

            MessageBox.Show("Uppercase: " & int_passuc & Environment.NewLine & "Lowercase: " & int_passlc & Environment.NewLine & "Numbers: " & int_passin & Environment.NewLine & "Specials: " & int_passsp)
            If int_passuc > 0 Then
                int_passuc = 1
            Else
                int_passuc = 0
            End If

            If int_passlc > 0 Then
                int_passlc = 1
            Else
                int_passlc = 0
            End If

            If int_passsp > 0 Then
                int_passsp = 1
            Else
                int_passsp = 0
            End If

            If int_passin > 0 Then
                int_passin = 1
            Else
                int_passin = 0
            End If
            If int_passuc + int_passlc + int_passsp + int_passin < 3 Then 'At least 3 of the character categories have to be present. The above code checks this.
                MessageBox.Show("Please use characters from at least 3 of these categories: " & Environment.NewLine & "Uppercase" & Environment.NewLine & "Lowercase" & Environment.NewLine & "Numbers" & Environment.NewLine & "Special Characters such as @")
            Else
                If System.IO.File.Exists(file_name) = True Then
                    'If the validation of the new password is successful, 
                    Dim objwriter As New System.IO.StreamWriter(file_name, True)
                    MsgBox(txt_PasswordEn.Text)
                    MsgBox(txt_UnameEn.Text)

                    objwriter.WriteLine(txt_UnameEn.Text)
                    objwriter.WriteLine(txt_PasswordEn.Text)
                    objwriter.Close()

                End If
            End If
        End If

1:

        txt_PasswordEn.Clear()
        txt_PasswordEn.Refresh()
    End Sub
End Class
