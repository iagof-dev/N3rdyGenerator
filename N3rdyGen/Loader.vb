Public Class Loader
    Dim yellow, red, green, blue As String

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Threading.Thread.Sleep(800)
        N3rdy.Visible = True
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        N3rdy.Visible = False
        Generator.Visible = False
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
        Timer2.Interval = (350)
        Timer2.Start()
        Timer3.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Login.Show()
        Me.Hide()
        Timer2.Stop()
        Timer1.Stop()
        Timer3.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        red = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        N3rdy.ForeColor = Color.FromArgb(red, green, blue, yellow)
        Generator.Visible = True
        Generator.ForeColor = Color.FromArgb(red, green, blue, yellow)
        Foant.Hide()

    End Sub

    Private Sub Loader_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Foant.Close()
    End Sub
End Class
