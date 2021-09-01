Public Class menug
    Dim g, y, b, r As String
    Private branco As Image = My.Resources.idaiusd
    Dim g2, y2, b2, r2 As String

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MinecraftG.Timer2.Stop()
        Timer2.Start()
        home.Label4.Text = My.Computer.Name
        Panel2.Controls.Clear()
        home.TopLevel = False
        Panel2.Controls.Add(home)
        home.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MinecraftG.Timer2.Start()
        home.Close()
        Timer2.Stop()
        Panel2.Controls.Clear()
        MinecraftG.TopLevel = False
        Panel2.Controls.Add(MinecraftG)
        MinecraftG.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        Else
            If Panel3.Visible = False Then
                Panel3.Visible = True
            End If
        End If
    End Sub

    Private Sub menug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        home.Label4.Text = My.Computer.Name
        Panel2.Controls.Clear()
        home.TopLevel = False
        Panel2.Controls.Add(home)
        home.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Foant.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        g2 = (Rnd() * 255)
        y2 = (Rnd() * 255)
        b2 = (Rnd() * 255)
        r2 = (Rnd() * 255)
        home.Label4.ForeColor = Color.FromArgb(r2, b2, y2, g2)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        g = (Rnd() * 255)
        y = (Rnd() * 255)
        b = (Rnd() * 255)
        r = (Rnd() * 255)
        Logo.ForeColor = Color.FromArgb(r, b, y, g)
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Red
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover

        PictureBox1.Image = My.Resources.idaiusd
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.ezgif_com_webp_to_png
    End Sub
End Class