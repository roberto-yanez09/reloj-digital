Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM' del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_mod = Time_o.Split(":")

        horas.Text = Time_mod(0)
        minutos.Text = Time_mod(1)
        Dia.Text = day_o
        fecha.Text = date_o

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Dia_Click(sender As Object, e As EventArgs) Handles Dia.Click

    End Sub

    Private Sub horas_Click(sender As Object, e As EventArgs) Handles horas.Click

    End Sub

    Private Sub minutos_Click(sender As Object, e As EventArgs) Handles minutos.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picturebox.Click
        If config.Visible = False Then
            config.Visible = True
        ElseIf config.Visible = True Then
            config.Visible = False
        End If
    End Sub
End Class
