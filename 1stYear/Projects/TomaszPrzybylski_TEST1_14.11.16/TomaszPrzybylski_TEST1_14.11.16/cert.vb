Public Class cert

    Private Sub cert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Displays Student Information entered earlier in a certificate format if the conditions were met earlier.
        lbl_DisplayDOB.Text = Frm_Scores.txt_DOBDay.Text & "/" & Frm_Scores.txt_DOBMon.Text & "/" & Frm_Scores.txt_DOBYear.Text
        lbl_DisplayIDNumber.Text = Frm_Scores.txt_EnterStudentNumber.Text
        lbl_DisplayName.Text = Frm_Scores.txt_EnterName.Text
        lbl_Unit1.Text = Frm_Scores.txt_U1Marks.Text & " * 10 Credits = " & Frm_Scores.stinfo(1).int_U1Marks * 10 & " | Grade : " & Frm_Scores.lbl_U1Grade.Text
        lbl_Unit2.Text = Frm_Scores.txt_U2Marks.Text & " * 10 Credits = " & Frm_Scores.stinfo(1).int_U2Marks * 10 & " | Grade : " & Frm_Scores.lbl_U2Grade.Text
        lbl_Unit3.Text = Frm_Scores.txt_U3Marks.Text & " * 10 Credits = " & Frm_Scores.stinfo(1).int_U3Marks * 10 & " | Grade : " & Frm_Scores.lbl_U3Grade.Text
        lbl_DisplayOverall.Text = Frm_Scores.lbl_OverallGrade.Text
    End Sub
End Class