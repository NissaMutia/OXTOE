Public Class Form5
    Dim a As Integer = 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = a + 1

        If a = 2 Then

            PictureBox11.Visible = False
            PictureBox12.Visible = False
            Label1.Visible = False
            Label0.Visible = False

            PictureBox21.Visible = True
            PictureBox22.Visible = True
            Label2.Visible = True
            Button2.Visible = True

        ElseIf a = 3 Then

            PictureBox21.Visible = False
            PictureBox22.Visible = False
            Label2.Visible = False


            PictureBox31.Visible = True
            PictureBox32.Visible = True
            PictureBox33.Visible = True
            Label3.Visible = True

        ElseIf a = 4 Then

            PictureBox31.Visible = False
            PictureBox32.Visible = False
            PictureBox33.Visible = False
            Label3.Visible = False

            PictureBox4.Visible = True
            Label4.Visible = True
            Button2.Visible = True

        ElseIf a = 5 Then

            PictureBox4.Visible = False
            Label4.Visible = False
            Button1.Visible = False

            PictureBox5.Visible = True
            Label5.Visible = True

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = a - 1

        If a = 4 Then

            PictureBox5.Visible = False
            Label5.Visible = False

            PictureBox4.Visible = True
            Label4.Visible = True
            Button1.Visible = True

        ElseIf a = 3 Then

            PictureBox4.Visible = False
            Label4.Visible = False

            PictureBox31.Visible = True
            PictureBox32.Visible = True
            PictureBox33.Visible = True
            Label3.Visible = True

        ElseIf a = 2 Then

            PictureBox31.Visible = False
            PictureBox32.Visible = False
            PictureBox33.Visible = False
            Label3.Visible = False

            PictureBox21.Visible = True
            PictureBox22.Visible = True
            Label2.Visible = True
            Button1.Visible = True

        ElseIf a = 1 Then

            PictureBox21.Visible = False
            PictureBox22.Visible = False
            Label2.Visible = False
            Button2.Visible = False

            PictureBox12.Visible = True
            PictureBox11.Visible = True
            Label0.Visible = True
            Label1.Visible = True

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class