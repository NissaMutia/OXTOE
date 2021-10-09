Public Class Form2
    Dim giliran As Integer = 1
    Dim awal As Integer = 10

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lanjut.Click
        If menang.Visible = False And countdown.Visible = False Then
            cover.Visible = False
            Timer1.Enabled = True
            lanjut.Visible = False
            pause.Visible = True
        End If
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        waktu.Text = Val(waktu.Text) - 1
        If Val(waktu.Text) = 0 Then
            waktu.Text = awal
            Timer1.Enabled = False
            waktu.Text = awal
            countdown.Text = 1
            Timer2.Enabled = True
            If Val(countdown.Text) = 0 Then
                Timer2.Enabled = False
                waktu.Text = awal
                Timer1.Enabled = True
            End If
            giliran = giliran + 1
        End If

        If (giliran Mod 2 = 0) Then
            player2.Visible = True
            player1.Visible = False
        Else
            player1.Visible = True
            player2.Visible = False
        End If

    End Sub

    Private Sub kosong1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong1.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong1.Visible = False
                silang1.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong1.Visible = False
                bulet1.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'Menang horizontal
            If silang1.Visible = True And silang2.Visible = True And silang3.Visible = True Then
                horizon1.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet2.Visible = True And bulet3.Visible = True Then
                horizon1.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang vertikal
            If silang1.Visible = True And silang4.Visible = True And silang7.Visible = True Then
                verti1.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet4.Visible = True And bulet7.Visible = True Then
                verti1.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang diagonal
            If silang1.Visible = True And silang5.Visible = True And silang9.Visible = True Then
                diagonki.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet5.Visible = True And bulet9.Visible = True Then
                diagonki.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If


    End Sub

    Private Sub kosong2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong2.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong2.Visible = False
                silang2.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong2.Visible = False
                bulet2.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'menang horizontal
            If silang1.Visible = True And silang2.Visible = True And silang3.Visible = True Then
                horizon1.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet2.Visible = True And bulet3.Visible = True Then
                horizon1.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'menang vertikal
            If silang2.Visible = True And silang5.Visible = True And silang8.Visible = True Then
                verti2.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet2.Visible = True And bulet5.Visible = True And bulet8.Visible = True Then
                verti2.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong3.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong3.Visible = False
                silang3.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong3.Visible = False
                bulet3.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'menang horizontal
            If silang1.Visible = True And silang2.Visible = True And silang3.Visible = True Then
                horizon1.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet2.Visible = True And bulet3.Visible = True Then
                horizon1.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'menang vertikal
            If silang3.Visible = True And silang6.Visible = True And silang9.Visible = True Then
                verti3.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet3.Visible = True And bulet6.Visible = True And bulet9.Visible = True Then
                verti3.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang diagonal
            If silang3.Visible = True And silang5.Visible = True And silang7.Visible = True Then
                diagonka.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet3.Visible = True And bulet5.Visible = True And bulet7.Visible = True Then
                diagonka.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong4.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong4.Visible = False
                silang4.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong4.Visible = False
                bulet4.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'Menang horizontal
            If silang4.Visible = True And silang5.Visible = True And silang6.Visible = True Then
                horizon2.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet4.Visible = True And bulet5.Visible = True And bulet6.Visible = True Then
                horizon2.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang vertikal
            If silang1.Visible = True And silang4.Visible = True And silang7.Visible = True Then
                verti1.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet4.Visible = True And bulet7.Visible = True Then
                verti1.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong5.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong5.Visible = False
                silang5.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong5.Visible = False
                bulet5.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'menang horizontal
            If silang4.Visible = True And silang5.Visible = True And silang6.Visible = True Then
                horizon2.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet4.Visible = True And bulet5.Visible = True And bulet6.Visible = True Then
                horizon2.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'menang vertikal
            If silang2.Visible = True And silang5.Visible = True And silang8.Visible = True Then
                verti2.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet2.Visible = True And bulet5.Visible = True And bulet8.Visible = True Then
                verti2.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang diagonal kiri
            If silang1.Visible = True And silang5.Visible = True And silang9.Visible = True Then
                diagonki.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet5.Visible = True And bulet9.Visible = True Then
                diagonki.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang diagonal kanan
            If silang3.Visible = True And silang5.Visible = True And silang7.Visible = True Then
                diagonka.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet3.Visible = True And bulet5.Visible = True And bulet7.Visible = True Then
                diagonka.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong6.Click

        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong6.Visible = False
                silang6.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong6.Visible = False
                bulet6.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'menang horizontal
            If silang4.Visible = True And silang5.Visible = True And silang6.Visible = True Then
                horizon2.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet4.Visible = True And bulet5.Visible = True And bulet6.Visible = True Then
                horizon2.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'menang vertikal
            If silang3.Visible = True And silang6.Visible = True And silang9.Visible = True Then
                verti3.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet3.Visible = True And bulet6.Visible = True And bulet9.Visible = True Then
                verti3.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong7.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong7.Visible = False
                silang7.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong7.Visible = False
                bulet7.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'Menang Horizontal
            If silang7.Visible = True And silang8.Visible = True And silang9.Visible = True Then
                horizon3.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet7.Visible = True And bulet8.Visible = True And bulet9.Visible = True Then
                horizon3.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang vertikal
            If silang1.Visible = True And silang4.Visible = True And silang7.Visible = True Then
                verti1.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet4.Visible = True And bulet7.Visible = True Then
                verti1.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang diagonal
            If silang3.Visible = True And silang5.Visible = True And silang7.Visible = True Then
                diagonka.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet3.Visible = True And bulet5.Visible = True And bulet7.Visible = True Then
                diagonka.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong8.Click
        If menang.Visible = False Then
            If giliran Mod 2 = 0 Then
                kosong8.Visible = False
                silang8.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong8.Visible = False
                bulet8.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'menang horizontal
            If silang7.Visible = True And silang8.Visible = True And silang9.Visible = True Then
                horizon3.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet7.Visible = True And bulet8.Visible = True And bulet9.Visible = True Then
                horizon3.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang vertikal
            If silang2.Visible = True And silang5.Visible = True And silang8.Visible = True Then
                verti2.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet2.Visible = True And bulet5.Visible = True And bulet8.Visible = True Then
                verti2.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub kosong9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kosong9.Click
        If menang.Visible = False Then

            If giliran Mod 2 = 0 Then
                kosong9.Visible = False
                silang9.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            Else
                kosong9.Visible = False
                bulet9.Visible = True
                waktu.Text = awal
                giliran = giliran + 1
            End If

            'Menang horizontal
            If silang7.Visible = True And silang8.Visible = True And silang9.Visible = True Then
                horizon3.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet7.Visible = True And bulet8.Visible = True And bulet9.Visible = True Then
                horizon3.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'menang vertikal
            If silang3.Visible = True And silang6.Visible = True And silang9.Visible = True Then
                verti3.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet3.Visible = True And bulet6.Visible = True And bulet9.Visible = True Then
                verti3.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If

            'Menang diagonal
            If silang1.Visible = True And silang5.Visible = True And silang9.Visible = True Then
                diagonki.Visible = True
                Timer1.Enabled = False
                player1.Visible = False
                player2.Visible = True
                waktu.Visible = False
                menang.ForeColor = Color.Blue
                menang.Visible = True
            ElseIf bulet1.Visible = True And bulet5.Visible = True And bulet9.Visible = True Then
                diagonki.Visible = True
                Timer1.Enabled = False
                player1.Visible = True
                player2.Visible = False
                waktu.Visible = False
                menang.ForeColor = Color.Red
                menang.Visible = True
            End If
        End If
        If kosong1.Visible = False And kosong2.Visible = False And kosong3.Visible = False And kosong4.Visible = False And kosong5.Visible = False And kosong6.Visible = False And kosong7.Visible = False And kosong8.Visible = False And kosong9.Visible = False And horizon1.Visible = False And horizon2.Visible = False And horizon3.Visible = False And verti1.Visible = False And verti2.Visible = False And verti3.Visible = False And diagonka.Visible = False And diagonki.Visible = False Then
            draw.Visible = True
            Timer1.Enabled = False
            waktu.Visible = False
        End If

    End Sub

    Private Sub balikmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles balikmenu.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        cover.Visible = True
        pause.Visible = False
        lanjut.Visible = False
        Form4.Show()
    End Sub

    Private Sub pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pause.Click
        If menang.Visible = False Then
            cover.Visible = True
            Timer1.Enabled = False
            lanjut.Visible = True
            pause.Visible = False
        End If
    End Sub

    Private Sub retry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retry.Click
        cover.Visible = True
        waktu.Text = awal
        pause.Visible = False
        lanjut.Visible = False
        draw.Visible = False
        countdown.Visible = True
        countdown.Text = 3
        giliran = 1
        Timer2.Enabled = True
        Timer1.Enabled = False
        waktu.Visible = False
        player1.Visible = True
        player2.Visible = False

        If countdown.Text = 0 Then
            cover.Visible = False
            waktu.Visible = True
            pause.Visible = True
            countdown.Visible = False
            Timer2.Enabled = False
            Timer1.Enabled = True
            waktu.Text = awal
            giliran = 1
        End If

        silang1.Visible = False
        silang2.Visible = False
        silang3.Visible = False
        silang4.Visible = False
        silang5.Visible = False
        silang6.Visible = False
        silang7.Visible = False
        silang8.Visible = False
        silang9.Visible = False

        bulet1.Visible = False
        bulet2.Visible = False
        bulet3.Visible = False
        bulet4.Visible = False
        bulet5.Visible = False
        bulet6.Visible = False
        bulet7.Visible = False
        bulet8.Visible = False
        bulet9.Visible = False

        kosong1.Visible = True
        kosong2.Visible = True
        kosong3.Visible = True
        kosong4.Visible = True
        kosong5.Visible = True
        kosong6.Visible = True
        kosong7.Visible = True
        kosong8.Visible = True
        kosong9.Visible = True

        horizon1.Visible = False
        horizon2.Visible = False
        horizon3.Visible = False
        verti1.Visible = False
        verti2.Visible = False
        verti3.Visible = False
        diagonka.Visible = False
        diagonki.Visible = False

        menang.Visible = False

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        countdown.Text = Val(countdown.Text) - 1
        If countdown.Text = 0 Then
            Timer2.Enabled = False
            waktu.Visible = True
            Timer1.Enabled = True
            cover.Visible = False
            countdown.Visible = False
            pause.Visible = True

        End If
    End Sub
End Class