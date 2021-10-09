Public Class Form1
    Private Sub play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles about.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub exito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exito.Click
        Close()
    End Sub

    Private Sub hint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hint.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class
