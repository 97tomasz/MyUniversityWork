Imports System.IO

Public Class Frm_Scores


    Dim count As Integer = 1
    Dim Int_m As Integer
    Dim Int_E As Integer
    Dim int_S As Integer
    Dim Int_p As Integer
    Dim file_name As String = "N:\SavingTestFolder\SavingTestFile1.txt"
    Dim txtfile = My.Computer.FileSystem.OpenTextFileWriter(file_name, True)
    Dim textline As String



    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

        txtfile.WriteLine(frm_StudentDetails.stinfo(count).firstname)
        txtfile.WriteLine(frm_StudentDetails.stinfo(count).surname)
        txtfile.WriteLine(frm_StudentDetails.stinfo(count).number)
        txtfile.WriteLine("Maths:" & frm_StudentDetails.stinfo(count).MMarks)
        txtfile.WriteLine("English:" & frm_StudentDetails.stinfo(count).EMarks)
        txtfile.WriteLine("System Analysis:" & frm_StudentDetails.stinfo(count).SAMarks)
        txtfile.WriteLine("Programming & Info:" & frm_StudentDetails.stinfo(count).PISMarks)
        txtfile.WriteLine("Total:" & frm_StudentDetails.stinfo(count).TMarks)
        txtfile.Writeline("--------------------------------------------------------------")
        count = count + 1
        lbl_CurrentStd.Text = count
        If count > frm_StudentDetails.stno Then
            txtfile.CLOSE()
            End
        End If
        lbl_displayname.Text = frm_StudentDetails.stinfo(count).firstname
        lbl_displaysurname.Text = frm_StudentDetails.stinfo(count).surname
        lbl_displaynumber.Text = frm_StudentDetails.stinfo(count).number
        lbl_EnglishGrade.Text = ""
        lbl_MathsGrade.Text = ""
        lbl_SysAnGrade.Text = ""
        lbl_ProgInfGrade.Text = ""


    End Sub


    Private Sub Frm_Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_MaxStd.Text = frm_StudentDetails.stno
        lbl_displayname.Text = frm_StudentDetails.stinfo(count).firstname
        lbl_displaysurname.Text = frm_StudentDetails.stinfo(count).surname
        lbl_displaynumber.Text = frm_StudentDetails.stinfo(count).number
    End Sub
    Sub readfile()
        If System.IO.File.Exists(file_name) = True Then
            Dim objReader As New System.IO.StreamReader(file_name)
            Do While objReader.Peek() <> -1
                textline = textline & objReader.ReadLine() & vbNewLine
            Loop
        ElseIf System.IO.File.Exists(file_name) = False Then
            System.IO.File.Create(file_name)
        End If
    End Sub

    Private Sub txt_MathsMarks_TextChanged(sender As Object, e As EventArgs) Handles txt_MathsMarks.TextChanged
        Try
            frm_StudentDetails.stinfo(count).MMarks = txt_MathsMarks.Text
            Int_m = txt_MathsMarks.Text
        Catch ex As Exception
        End Try
        If frm_StudentDetails.stinfo(count).MMarks > 80 And frm_StudentDetails.stinfo(count).MMarks <= 100 Then
            lbl_MathsGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).MMarks > 60 And frm_StudentDetails.stinfo(count).MMarks <= 80 Then
            lbl_MathsGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).MMarks > 40 And frm_StudentDetails.stinfo(count).MMarks <= 60 Then
            lbl_MathsGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).MMarks > 100 Or frm_StudentDetails.stinfo(count).MMarks < 0 Then
            lbl_MathsGrade.Text = "Invalid Marks"
        Else
            lbl_MathsGrade.Text = "D"
        End If

        frm_StudentDetails.stinfo(count).TMarks = Int_m + Int_E + int_S + Int_p

        If frm_StudentDetails.stinfo(count).TMarks > 320 And frm_StudentDetails.stinfo(count).TMarks <= 400 Then
            lbl_OverallGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 240 And frm_StudentDetails.stinfo(count).TMarks <= 320 Then
            lbl_OverallGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 160 And frm_StudentDetails.stinfo(count).TMarks <= 240 Then
            lbl_OverallGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 400 Or frm_StudentDetails.stinfo(count).TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "D"
        End If
    End Sub

    Private Sub txt_EnglishMarks_TextChanged(sender As Object, e As EventArgs) Handles txt_EnglishMarks.TextChanged
        Try
            frm_StudentDetails.stinfo(count).EMarks = txt_EnglishMarks.Text
            Int_E = txt_EnglishMarks.Text
        Catch ex As Exception
        End Try
        If frm_StudentDetails.stinfo(count).EMarks > 80 And frm_StudentDetails.stinfo(count).EMarks <= 100 Then
            lbl_EnglishGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).EMarks > 60 And frm_StudentDetails.stinfo(count).EMarks <= 80 Then
            lbl_EnglishGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).EMarks > 40 And frm_StudentDetails.stinfo(count).EMarks <= 60 Then
            lbl_EnglishGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).EMarks > 100 Or frm_StudentDetails.stinfo(count).EMarks < 0 Then
            lbl_EnglishGrade.Text = "Invalid Marks"
        Else
            lbl_EnglishGrade.Text = "D"
        End If

        frm_StudentDetails.stinfo(count).TMarks = Int_m + Int_E + int_S + Int_p

        If frm_StudentDetails.stinfo(count).TMarks > 320 And frm_StudentDetails.stinfo(count).TMarks <= 400 Then
            lbl_OverallGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 240 And frm_StudentDetails.stinfo(count).TMarks <= 320 Then
            lbl_OverallGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 160 And frm_StudentDetails.stinfo(count).TMarks <= 240 Then
            lbl_OverallGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 400 Or frm_StudentDetails.stinfo(count).TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "D"
        End If
    End Sub

    Private Sub txt_SysAnMarks_TextChanged(sender As Object, e As EventArgs) Handles txt_SysAnMarks.TextChanged
        Try
            frm_StudentDetails.stinfo(count).SAMarks = txt_SysAnMarks.Text
            int_S = txt_SysAnMarks.Text
        Catch ex As Exception
        End Try

        If frm_StudentDetails.stinfo(count).SAMarks > 80 And frm_StudentDetails.stinfo(count).SAMarks <= 100 Then
            lbl_SysAnGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).SAMarks > 60 And frm_StudentDetails.stinfo(count).SAMarks <= 80 Then
            lbl_SysAnGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).SAMarks > 40 And frm_StudentDetails.stinfo(count).SAMarks <= 60 Then
            lbl_SysAnGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).SAMarks > 100 Or frm_StudentDetails.stinfo(count).SAMarks < 0 Then
            lbl_SysAnGrade.Text = "Invalid Marks"
        Else
            lbl_SysAnGrade.Text = "D"
        End If

        frm_StudentDetails.stinfo(count).TMarks = Int_m + Int_E + int_S + Int_p

        If frm_StudentDetails.stinfo(count).TMarks > 320 And frm_StudentDetails.stinfo(count).TMarks <= 400 Then
            lbl_OverallGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 240 And frm_StudentDetails.stinfo(count).TMarks <= 320 Then
            lbl_OverallGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 160 And frm_StudentDetails.stinfo(count).TMarks <= 240 Then
            lbl_OverallGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 400 Or frm_StudentDetails.stinfo(count).TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "D"
        End If
    End Sub

    Private Sub txt_ProgInfMarks_TextChanged(sender As Object, e As EventArgs) Handles txt_ProgInfMarks.TextChanged
        Try
            frm_StudentDetails.stinfo(count).PISMarks = txt_ProgInfMarks.Text
            Int_p = txt_ProgInfMarks.Text
        Catch ex As Exception
        End Try
        If frm_StudentDetails.stinfo(count).PISMarks > 80 And frm_StudentDetails.stinfo(count).PISMarks <= 100 Then
            lbl_ProgInfGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).PISMarks > 60 And frm_StudentDetails.stinfo(count).PISMarks <= 80 Then
            lbl_ProgInfGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).PISMarks > 40 And frm_StudentDetails.stinfo(count).PISMarks <= 60 Then
            lbl_ProgInfGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).PISMarks > 100 Or frm_StudentDetails.stinfo(count).PISMarks < 0 Then
            lbl_ProgInfGrade.Text = "Invalid Marks"
        Else
            lbl_ProgInfGrade.Text = "D"
        End If

        frm_StudentDetails.stinfo(count).TMarks = Int_m + Int_E + int_S + Int_p

        If frm_StudentDetails.stinfo(count).TMarks > 320 And frm_StudentDetails.stinfo(count).TMarks <= 400 Then
            lbl_OverallGrade.Text = "A"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 240 And frm_StudentDetails.stinfo(count).TMarks <= 320 Then
            lbl_OverallGrade.Text = "B"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 160 And frm_StudentDetails.stinfo(count).TMarks <= 240 Then
            lbl_OverallGrade.Text = "C"
        ElseIf frm_StudentDetails.stinfo(count).TMarks > 400 Or frm_StudentDetails.stinfo(count).TMarks < 0 Then
            lbl_OverallGrade.Text = "Invalid Marks"
        Else
            lbl_OverallGrade.Text = "D"
        End If
    End Sub
End Class
