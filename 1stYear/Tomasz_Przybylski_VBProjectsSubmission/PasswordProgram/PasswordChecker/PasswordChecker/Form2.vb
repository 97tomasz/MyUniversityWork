Public Class Form2

    Private Sub btn_Generate_Click(sender As Object, e As EventArgs) Handles btn_Generate.Click
        'This form mainly deals with random generation of the password.
        If PasswordEnter.txt_UnameEn.Text = "" Then
            MsgBox("Username was left blank. Please restart the program and enter a Username before going into the generate password screen")

        End If
        Dim str_firstname As String
        Dim bln_fname As Boolean
        Dim str_surname As String
        Dim int_count As Integer
        Dim bln_sname As Boolean
        Dim str_keyword As String
        Dim bln_kword As Boolean
        Dim int_passlen As Integer
        Dim rnd As New Random
        Dim rnd_int As Integer
        Dim rnd_ucase As Integer
        Dim rnd_sp As Integer
        Dim rnd_lcase As Integer
        Dim str_passgen As String = ""
        Dim temp As Integer
        Dim tem As String = ""
        str_firstname = txt_firstname.Text
        If str_firstname <> "" Then
            bln_fname = True
        End If
        str_surname = txt_surname.Text
        If str_surname <> "" Then
            bln_sname = True
        End If
        str_keyword = txt_optional.Text
        If str_keyword <> "" Then
            bln_kword = True
        End If
        int_passlen = rnd.Next(8, 25)
        int_count = 0
        Do
            Do
                If int_count Mod 2 = 0 Then
                    rnd_int = rnd.Next(0, 2)
                End If
                rnd_lcase = rnd.Next(0, 2)
                rnd_ucase = rnd.Next(0, 2)
                If int_count Mod 4 = 0 Then
                    rnd_sp = rnd.Next(0, 2)
                End If

            Loop Until rnd_int + rnd_lcase + rnd_ucase + rnd_sp >= 3
            If rnd_int = 1 Then 'Random Integer character generation
                int_count = int_count + 1
                If bln_fname = True Then
                    rnd_int = rnd.Next(0, Len(str_firstname))
                    rnd_int = Asc(str_firstname(rnd_int))
                    rnd_int = rnd_int + rnd.Next(0, 3)
                    rnd_int = rnd_int Mod 10

                    temp = temp + rnd_int
                End If
                If bln_sname = True Then
                    rnd_int = rnd.Next(0, Len(str_surname))
                    rnd_int = Asc(str_surname(rnd_int))
                    rnd_int = rnd_int + rnd.Next(0, 3)
                    rnd_int = rnd_int Mod 10

                    temp = temp + rnd_int
                End If
                If bln_kword = True Then
                    rnd_int = rnd.Next(0, Len(str_keyword))
                    rnd_int = Asc(str_keyword(rnd_int))
                    rnd_int = rnd_int + rnd.Next(0, 3)
                    rnd_int = rnd_int Mod 10

                    temp = temp + rnd_int
                End If
                If bln_fname = False And bln_kword = False And bln_sname = False Then
                    temp = rnd.Next(0, 9)

                End If
                temp = temp Mod 10

                str_passgen = str_passgen + temp.ToString
            End If
            If rnd_sp = 1 Then 'random special character generation
                int_count = int_count + 1
                Select Case rnd.Next(0, 3)
                    Case 0
                        rnd_sp = rnd.Next(0, 14)
                        rnd_sp = 33 + rnd_sp
                        tem = Convert.ToChar(rnd_sp)
                    Case 1
                        rnd_sp = rnd.Next(0, 7)
                        rnd_sp = 58 + rnd_sp
                        tem = Convert.ToChar(rnd_sp)
                    Case 2
                        rnd_sp = rnd.Next(0, 6)
                        rnd_sp = 91 + rnd_sp
                        tem = Convert.ToChar(rnd_sp)
                End Select
                str_passgen = str_passgen + tem

            End If
            If rnd_lcase = 1 Then 'random lowercase character generation
                int_count = int_count + 1
                rnd_lcase = rnd.Next(0, 26)
                rnd_lcase = rnd_lcase + 97
                str_passgen = str_passgen + Convert.ToChar(rnd_lcase)
            End If
            If rnd_ucase = 1 Then 'random uppercase character generation
                int_count = int_count + 1
                rnd_ucase = rnd.Next(0, 26)
                rnd_ucase = rnd_ucase + 65
                tem = rnd_ucase.ToString
                str_passgen = str_passgen + Convert.ToChar(rnd_ucase)
            End If


        Loop Until int_count >= int_passlen
        If System.IO.File.Exists(PasswordEnter.file_name) = True Then 'Once the length of the password has been met, the username and password are written to file and displayed for the user. 
            Dim objwriter As New System.IO.StreamWriter(PasswordEnter.file_name, True)

            objwriter.WriteLine(PasswordEnter.txt_UnameEn.Text)
            objwriter.WriteLine(str_passgen)
            objwriter.Close()
            MsgBox("Password Generated! " & Environment.NewLine & "Username is: " & PasswordEnter.txt_UnameEn.Text & Environment.NewLine & "Generated Password is: " & str_passgen)
        End If



    End Sub
End Class