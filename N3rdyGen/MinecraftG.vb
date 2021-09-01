Imports System.Net
Public Class MinecraftG
    Dim N3rdyWeb As WebClient
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.ImageLocation = ("https://minotar.net/armor/body/" & Nick.Text & "/100.png")
    End Sub

    Private Sub MinecraftG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.ImageLocation = ("https://n3rdygenerator.n3rdydesigner.xyz/Anuncio/ads.png")
        Timer2.Stop()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
    End Sub
End Class