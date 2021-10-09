Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
        Form2.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Form2.menang.Visible = True Then
            Form2.cover.Visible = False
            Me.Close()
        ElseIf Form2.draw.Visible = True Then
            Form2.cover.Visible = False
            Me.Close()
        Else
            Form2.countdown.Visible = True
            Form2.countdown.Text = 3
            Form2.Timer2.Enabled = True
        End If
        Me.Close()

    End Sub
End Class