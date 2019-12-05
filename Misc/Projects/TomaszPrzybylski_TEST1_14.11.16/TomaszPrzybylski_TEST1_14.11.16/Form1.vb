Public Class frm_StudentDetails
    Structure studentinfo
        Dim firstname As String
        Dim surname As String
        Dim number As String
        Dim MMarks As Integer
        Dim EMarks As Integer
        Dim SAMarks As Integer
        Dim PISMarks As Integer
        Dim TMarks As Integer

    End Structure
    Public stinfo(1) As studentinfo
    Public stno As Integer
    Dim count As Integer = 1
    Dim change As Boolean
    Dim firsttime As Boolean = True

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            If txt_NoStudents.Text = "" Then
                If firsttime = True Then
                    MsgBox("Invalid Number of students. Please try again")
                    GoTo escape1
                Else
                    change = False
                    GoTo 2
                End If
            End If

2:          
            If count = stno - 1 Then
                MsgBox("You have reached the number of students specified. This is your last entry. Please change the total number of students if you wish to add more.")
            End If
            stinfo(count).firstname = txt_EnterFirstName.Text
            stinfo(count).surname = txt_EnterSurname.Text
            stinfo(count).number = txt_EnterStudentNumber.Text
            count = count + 1

            lbl_studentnumber.Text = count
            txt_EnterFirstName.Clear()
            txt_EnterSurname.Clear()
            txt_EnterStudentNumber.Clear()
            If count = stno + 1 Then
                txt_EnterFirstName.Text = "NO"
                txt_EnterSurname.Text = "MORE"
                txt_EnterStudentNumber.Text = "SPACE"
                txt_NoStudents.Text = "Please add more"
                GoTo escape1

            End If
        Catch ex As Exception
            MsgBox("An error occured. Please make sure all inputs (including the total number of students) are valid before submitting. Please launch the program again")
            Me.Close()
        End Try

escape1:
    End Sub

    Private Sub btn_Scores_Click(sender As Object, e As EventArgs) Handles btn_Scores.Click
        Me.Hide()
        Frm_Scores.Show()
    End Sub
    Private Sub txt_noStudents_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NoStudents.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_UpdateStudentNo_Click(sender As Object, e As EventArgs) Handles btn_UpdateStudentNo.Click
        Try
            If txt_NoStudents.Text = "" Then
                If firsttime = True Then
                    MsgBox("Invalid Number of students. Please try again")
                    GoTo escape1
                Else
                    GoTo 2
                    change = False

                End If
            End If
            firsttime = False
            If stno = txt_NoStudents.Text Then
                change = False
            ElseIf stno <> txt_NoStudents.Text Then
                If stno > txt_NoStudents.Text Then
                    MsgBox("You cannot reduce the number of students. Please run the program again")
                    Me.Close()

                End If
                stno = txt_NoStudents.Text
                change = True
            End If
2:

            If change = True Then
                ReDim stinfo(stno)

            End If
            lbl_maxstudents.Text = stno
            txt_NoStudents.Clear()

        Catch ex As Exception
        End Try
escape1:

    End Sub

    Private Sub txt_EnterFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_EnterFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_Surname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_EnterSurname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class

