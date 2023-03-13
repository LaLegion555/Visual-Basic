Public Class Form1

    Dim Aud As New Audio

    Dim Estado As Boolean = False

   
    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

        If e.KeyCode = Keys.D Then

            'mover a la derecha
            MarioDerecha.Left = MarioDerecha.Left + 5
            MarioIzquierda.Visible = False
            MarioDerecha.Visible = True

            'si mario esta en esta posicion entonces toca la flor y muere
            If MarioDerecha.Location = New Point(420, 403) = True Then
                Mariopierde.Visible = True

                'musica perdio
                My.Computer.Audio.Play("C:\NEFFEX.wav", AudioPlayMode.Background)

                'desaparecer  las dos imagenes de mario
                MarioIzquierda.Visible = False
                MarioDerecha.Visible = False
                Estado = True

            End If

        ElseIf e.KeyCode = Keys.A Then
            MarioDerecha.Left = MarioDerecha.Left - 5
            MarioDerecha.Visible = False
            MarioIzquierda.Visible = True

            'ElseIf e.KeyCode = Keys.S Then
            '    PictureBox2.Top = PictureBox2.Top + 5

        ElseIf e.KeyCode = Keys.W Then
            MarioDerecha.Location = New Point(MarioDerecha.Location.X + 2, MarioDerecha.Location.Y - 2)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        End If


        If e.KeyCode = Keys.D Then

            MarioIzquierda.Left = MarioIzquierda.Left + 5

        ElseIf e.KeyCode = Keys.A Then
            MarioIzquierda.Left = MarioIzquierda.Left - 5

            'ElseIf e.KeyCode = Keys.S Then
            '    PictureBox3.Top = PictureBox3.Top + 5

        ElseIf e.KeyCode = Keys.W Then
            MarioIzquierda.Top = MarioIzquierda.Top - 5
        End If

    End Sub

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

        If Estado = True Then
            MarioIzquierda.Visible = False
            MarioDerecha.Visible = False
            Mariopierde.Top = Mariopierde.Top + 10

            Label1.Visible = True
        End If

    End Sub

 

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aud.Audios()

    End Sub
End Class
