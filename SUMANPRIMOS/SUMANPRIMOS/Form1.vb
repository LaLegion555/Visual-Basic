Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim DES As Double
        Dim HAST As Double
        Dim C As Double = 0
        Dim S As Double = 0
        DES = Val(TXTN.Text)
        HAST = Val(TXTH.Text)
        For I = DES To HAST
            For J = I To 0 Step -1
                If I Mod J = 0 Then
                    C = C + 1
                    S = S + J
                End If
            Next
            If C = 2 Then
                ListBox1.Items.Add(I)
                Label2.Text = S
            End If
            C = 0
        Next
    End Sub
End Class
