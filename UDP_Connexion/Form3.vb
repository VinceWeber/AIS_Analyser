Public Class Form3

    Private Sub Form3_close(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click
        If IsNumeric(Txt_Periode.Text) Then
            If CLng(Txt_Periode.Text) = Val(Txt_Periode.Text) Then

                If Val(Txt_Periode.Text) > 0 Then
                    Form1.Decale_Timer.Interval = Val(Txt_Periode.Text) * 60000 / 10
                    Form1.Label_Periode.Text = Txt_Periode.Text
                    Form2.Text = "Analyse " & Txt_Periode.Text & "min - MMSI Connus - Tri décroissant "
                Else
                    MsgBox("La période inscrite doit être supérieure à zéro")
                    Txt_Periode.Text = "-"
                End If
            Else
                MsgBox("La période inscrite n'est pas un entier")
                Txt_Periode.Text = "-"
            End If
        Else
            MsgBox("La période inscrite n'est pas un nombre")
            Txt_Periode.Text = "-"
        End If

        If IsNumeric(Txt_Refresh.Text) Then
            If CLng(Txt_Refresh.Text) = Val(Txt_Refresh.Text) Then

                If Val(Txt_Refresh.Text) > 0 Then
                    Form1.Calcul_Timer.Interval = Val(Txt_Refresh.Text) * 1000
                    Form1.Label_Refresh.Text = Txt_Refresh.Text
                Else
                    MsgBox("La période inscrite doit être supérieure à zéro")
                    Txt_Refresh.Text = "-"
                End If
            Else
                MsgBox("La période inscrite n'est pas un entier")
                Txt_Refresh.Text = "-"
            End If
        Else
            MsgBox("La période inscrite n'est pas un nombre")
            Txt_Refresh.Text = "-"
        End If



    End Sub


End Class