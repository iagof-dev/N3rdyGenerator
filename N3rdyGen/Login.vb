Imports System.Net
Public Class Login
    Dim webi As New Net.WebClient
    Dim siiiite As String = "https://n3rdygenerator.n3rdydesigner.xyz/contas/"


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Foant.Hide()
    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Foant.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim usuario As String = webi.DownloadString("https://n3rdygenerator.n3rdydesigner.xyz/contas/")
        'If usuario.Contains(Usuariio.Text) Then
        'Dim PASSw As String = webi.DownloadString(siiiite & Usuariio.Text & ".n3rdy")
        'If Senha.Text = "" Then
        'MsgBox("Senha não pode ficar em branca")
        'Else
        'If Senha.Text = PASSw Then
        menug.Show()
        Me.Hide()
        'Else
        'MsgBox("Senha incorreta")
        'End If
        'End If
        'Else
        'MsgBox("Usuario Incorreto, Registre-se")
        'End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Foant.Close()
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Red
    End Sub
End Class