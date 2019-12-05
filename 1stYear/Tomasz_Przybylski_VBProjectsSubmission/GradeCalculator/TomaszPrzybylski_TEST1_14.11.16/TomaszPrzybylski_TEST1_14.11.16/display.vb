Imports System.IO

Public Class Frm_Scores
    Dim Int_u1 As Integer 'Variables for storing the Unit marks.
    Dim Int_u2 As Integer
    Dim int_u3 As Integer

    Structure studentinfo
        Dim str_name As String
        Dim str_DOB As String
        Dim str_number As String
        Dim int_U1Marks As Integer
        Dim int_U2Marks As Integer
        Dim int_U3Marks As Integer
        Dim int_TMarks As Integer

    End Structure
    Public stinfo(1) As studentinfo
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click 'This sub writes the information to file. 
        If txt_EnterName.Text = "" Or txt_EnterStudentNumber.Text = "" Then
            MsgBox("Please input valid information. Try again")
            GoTo 1
        End If
        Dim str_file_name As String = "N:\SavingTestFolder\SavingTestFile1.txt"
        Dim str_txtfile = My.Computer.FileSystem.OpenTextFileWriter(str_file_name, True)
        stinfo(1).str_name = txt_EnterName.Text
        stinfo(1).str_DOB = txt_DOBDay.Text & "/" & txt_DOBMon.Text & "/" & txt_DOBYear.Text
        stinfo(1).str_number = txt_EnterStudentNumber.Text

        str_txtfile.WriteLine(stinfo(1).str_name) 'str_txtfile.writeline is used to write a line to the textfile specified in 'txtfile'
        str_txtfile.WriteLine(stinfo(1).str_DOB)
        str_txtfile.WriteLine(stinfo(1).str_number)
        str_txtfile.WriteLine("Unit 1: " & stinfo(1).int_U1Marks * 10)
        str_txtfile.WriteLine("Unit 2: " & stinfo(1).int_U2Marks * 10)
        str_txtfile.WriteLine("Unit 3: " & stinfo(1).int_U3Marks * 10)
        str_txtfile.WriteLine("Total: " & stinfo(1).int_TMarks * 10)

        If stinfo(1).int_TMarks >= 23 Then
            cert.Show()
            str_txtfile.WriteLine("Certificate achieved")
        ElseIf stinfo(1).int_TMarks < 23 Or stinfo(1).int_U1Marks < 7 Or stinfo(1).int_U2Marks < 7 Or stinfo(1).int_U3Marks < 7 Then
            str_txtfile.WriteLine("Qualification Failed")
            MsgBox("This student has not achieved the boundaries for certification")
        End If
        str_txtfile.WriteLine("--------------------------------------------------------------")

        str_txtfile.Close()
1:
        lbl_U2Grade.Text = "" 'This section of the code clears all the textboxes to make it easier to use again without restarting the program. Allows the user to input the next set of data immediately after the first.
        lbl_U1Grade.Text = ""
        lbl_U3Grade.Text = ""
        txt_U2Marks.Clear()
        txt_U1Marks.Clear()
        txt_U3Marks.Clear()
        txt_EnterName.Clear()
        txt_DOBDay.Clear()
        txt_EnterStudentNumber.Clear()
        txt_DOBMon.Clear()
        txt_DOBYear.Clear()

    End Sub


    Private Sub Frm_Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_StudentDetails.Hide()
    End Sub

    Private Sub txt_U1Marks_TextChanged(sender As Object, e As EventArgs) Handles txt_U1Marks.TextChanged
        Try
            stinfo(1).int_U1Marks = txt_U1Marks.Text
            Int_u1 = txt_U1Marks.Text
        Catch ex As Exception
        End Try
        If stinfo(1).int_U1Marks >= 9 And stinfo(1).int_U1Marks <= 10 Then 'If states to determine the mark for the specific unit
            lbl_U1Grade.Text = "D"
        ElseIf stinfo(1).int_U1Marks = 8 Then
            lbl_U1Grade.Text = "M"
        ElseIf stinfo(1).int_U1Marks = 7 Then
            lbl_U1Grade.Text = "P"
        ElseIf stinfo(1).int_U1Marks > 10 Or stinfo(1).int_U1Marks < 0 Then 'Validation to make sure extreme data cannot be inputted into the program and cause further errors
            lbl_U1Grade.Text = "Invalid Marks"
        Else
            lbl_U1Grade.Text = "BP"
        End If

        stinfo(1).int_TMarks = Int_u1 + Int_u2 + int_u3
        If Int_u1 < 7 Or Int_u2 < 7 Or int_u3 < 7 Then 'If statement to determine if all units were passed
            stinfo(1).int_TMarks = 0
        End If


        If stinfo(1).int_TMarks > 25 Then
            lbl_OverallGrade.Text = "D"
        ElseIf stinfo(1).int_TMarks > 23 And stinfo(1).int_TMarks <= 25 Then
            lbl_OverallGrade.Text = "M"
        ElseIf stinfo(1).int_TMarks >= 21 And stinfo(1).int_TMarks <= 23 Then
            lbl_OverallGrade.Text = "P"
        ElseIf stinfo(1).int_TMarks > 27 Or stinfo(1).int_TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "BP"
        End If
    End Sub 'The next two subs contain identical code, just for checking Unit 2 marks and Unit 3 marks. As such, they will not be annotated as the annotations above also apply to them. 

    Private Sub txt_U2Marks_TextChanged(sender As Object, e As EventArgs) Handles txt_U2Marks.TextChanged
        Try
            stinfo(1).int_U2Marks = txt_U2Marks.Text
            Int_u2 = txt_U2Marks.Text
        Catch ex As Exception
        End Try
        If stinfo(1).int_U2Marks >= 9 And stinfo(1).int_U2Marks <= 10 Then
            lbl_U2Grade.Text = "D"
        ElseIf stinfo(1).int_U2Marks = 8 Then
            lbl_U2Grade.Text = "M"
        ElseIf stinfo(1).int_U2Marks = 7 Then
            lbl_U2Grade.Text = "P"
        ElseIf stinfo(1).int_U2Marks > 10 Or stinfo(1).int_U2Marks < 0 Then
            lbl_U2Grade.Text = "Invalid Marks"
        Else
            lbl_U2Grade.Text = "BP"
        End If

        stinfo(1).int_TMarks = Int_u1 + Int_u2 + int_u3
        If Int_u1 < 7 Or Int_u2 < 7 Or int_u3 < 7 Then
            stinfo(1).int_TMarks = 0
        End If
        If stinfo(1).int_TMarks > 25 Then
            lbl_OverallGrade.Text = "D"
        ElseIf stinfo(1).int_TMarks > 23 And stinfo(1).int_TMarks <= 25 Then
            lbl_OverallGrade.Text = "M"
        ElseIf stinfo(1).int_TMarks >= 21 And stinfo(1).int_TMarks <= 23 Then
            lbl_OverallGrade.Text = "P"
        ElseIf stinfo(1).int_TMarks > 27 Or stinfo(1).int_TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "BP"
        End If
    End Sub

    Private Sub txt_U3Marks_TextChanged(sender As Object, e As EventArgs) Handles txt_U3Marks.TextChanged
        Try
            stinfo(1).int_U3Marks = txt_U3Marks.Text
            int_u3 = txt_U3Marks.Text
        Catch ex As Exception
        End Try

        If stinfo(1).int_U3Marks >= 9 And stinfo(1).int_U3Marks <= 10 Then
            lbl_U3Grade.Text = "D"
        ElseIf stinfo(1).int_U3Marks = 8 Then
            lbl_U3Grade.Text = "M"
        ElseIf stinfo(1).int_U3Marks = 7 Then
            lbl_U3Grade.Text = "P"
        ElseIf stinfo(1).int_U3Marks > 10 Or stinfo(1).int_U3Marks < 0 Then
            lbl_U3Grade.Text = "Invalid Marks"
        Else
            lbl_U3Grade.Text = "BP"
        End If

        stinfo(1).int_TMarks = Int_u1 + Int_u2 + int_u3
        If Int_u1 < 7 Or Int_u2 < 7 Or int_u3 < 7 Then
            stinfo(1).int_TMarks = 0
        End If

        If stinfo(1).int_TMarks > 25 Then
            lbl_OverallGrade.Text = "D"
        ElseIf stinfo(1).int_TMarks > 23 And stinfo(1).int_TMarks <= 25 Then
            lbl_OverallGrade.Text = "M"
        ElseIf stinfo(1).int_TMarks >= 21 And stinfo(1).int_TMarks <= 23 Then
            lbl_OverallGrade.Text = "P"
        ElseIf stinfo(1).int_TMarks > 27 Or stinfo(1).int_TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "BP"
        End If
    End Sub


    Private Sub btn_Finished_Click(sender As Object, e As EventArgs) Handles btn_Finished.Click
        'This sub does the same as the btn_Submit_Click sub, only this is used when dealing with the last set of data. 
        Dim str_file_name As String = "N:\SavingTestFolder\SavingTestFile1.txt"
        Dim str_txtfile = My.Computer.FileSystem.OpenTextFileWriter(str_file_name, True)
        'Clicking "Finished" on the form with no input will result in the closing of the textfile connection and the termination of the program
        If txt_EnterName.Text = "" And txt_EnterStudentNumber.Text = "" Then
            str_txtfile.Close()
            End
        End If
        'Clicking "Finished" on the form with input will result in one last write to textfile, followed by the closing of the connection and termination of program.
        stinfo(1).str_name = txt_EnterName.Text
        stinfo(1).str_DOB = txt_DOBDay.Text & "/" & txt_DOBMon.Text & "/" & txt_DOBYear.Text
        stinfo(1).str_number = txt_EnterStudentNumber.Text

        str_txtfile.WriteLine(stinfo(1).str_name) 'Writes data to file, same as in the btn_Submit_click sub.
        str_txtfile.WriteLine(stinfo(1).str_DOB)
        str_txtfile.WriteLine(stinfo(1).str_number)
        str_txtfile.WriteLine("Unit 1: " & stinfo(1).int_U1Marks * 10)
        str_txtfile.WriteLine("Unit 2: " & stinfo(1).int_U2Marks * 10)
        str_txtfile.WriteLine("Unit 3: " & stinfo(1).int_U3Marks * 10)
        str_txtfile.WriteLine("Total:" & stinfo(1).int_TMarks * 10)
        If stinfo(1).int_TMarks >= 23 Then
            cert.Show()
            str_txtfile.WriteLine("Certificate achieved")
        Else
            str_txtfile.WriteLine("Qualification Failed")
            MsgBox("This student has not achieved the boundaries for certification")
        End If
        str_txtfile.WriteLine("--------------------------------------------------------------")

        str_txtfile.Close() 'Closes the connection to the textfile and terminates the program
        End
    End Sub
End Class
