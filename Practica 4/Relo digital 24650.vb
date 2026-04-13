Public Class Form1
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM' del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""

        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        horas.Text = Time_mod(0)
        minutos.Text = Time_mod(1)
        segundos.Text = Time_mod(2)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim colortexto As String = ComboBox1.SelectedItem.ToString()
        If colortexto = "Blanco" Then
            horas.ForeColor = Color.White
            minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Dia.ForeColor = Color.White
            fecha.ForeColor = Color.White
        ElseIf colortexto = "Rojo" Then
            horas.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Dia.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
        ElseIf colortexto = "Azul" Then
            horas.ForeColor = Color.Blue
            minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Dia.ForeColor = Color.Blue
            fecha.ForeColor = Color.Blue
        ElseIf colortexto = "Verde" Then
            horas.ForeColor = Color.Green
            minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Dia.ForeColor = Color.Green
            fecha.ForeColor = Color.Green
        ElseIf colortexto = "Amarillo" Then
            horas.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Dia.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True

        End If
    End Sub

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click


        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            start.Text = "Stop"
            startTime = DateTime.Now
        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            start.Text = "start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub



    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        elapsed = TimeSpan.Zero
        Timer3.Enabled = False
        tiempo.Text = "00:00:00.0"
        boton_start = False
        start.Text = "start"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim current = elapsed + (DateTime.Now - startTime)
        tiempo.Text = current.ToString("hh\:mm\:ss\.ff")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If

    End Sub

    Private tiempoRestante As TimeSpan = TimeSpan.Zero
    Private temporizadorActivo As Boolean = False

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Temporizador.Visible = False Then
            Temporizador.Visible = True
        ElseIf Temporizador.Visible = True Then
            Temporizador.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(1))
        Label4.Text = tiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(5))
        Label4.Text = tiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tiempoRestante = TimeSpan.Zero Then
            MessageBox.Show("Agrega tiempo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If temporizadorActivo = False Then
            Timer4.Enabled = True
            temporizadorActivo = True
            Button5.Text = "stop"
        Else
            Timer4.Enabled = False
            temporizadorActivo = False
            Button5.Text = "Start"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer4.Enabled = False
        tiempoRestante = TimeSpan.Zero
        temporizadorActivo = False
        Label4.Text = "00:00"
        Button5.Text = "Start"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If tiempoRestante.TotalMilliseconds > 0 Then
            tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromMilliseconds(Timer4.Interval))
            Label4.Text = tiempoRestante.ToString("mm\:ss")
        ElseIf
                Timer4.Enabled = False
            temporizadorActivo = False
            tiempoRestante = TimeSpan.Zero
            Label4.Text = "00:00"
            Button5.Text = "start"
            MessageBox.Show("Tiempo terminado", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
