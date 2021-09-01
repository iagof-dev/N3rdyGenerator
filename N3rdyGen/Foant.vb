Option Strict On
Imports System.Drawing.Text
Imports System.IO
Public Class Foant
    Sub Fonte()
        Dim aakam As Integer
        On Error Resume Next
        aakam = 1000
        Dim aakam031 As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim akam As String = aakam031 + "Doctor.otf"
        IO.File.WriteAllBytes(akam, My.Resources.Doctor)
        Process.Start(akam)
        MsgBox("Reinicie o Gerador!")
    End Sub
    Private Sub Font_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
        Threading.Thread.Sleep(1500)
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", "Doctor Glitch (TrueType)", Nothing) Is Nothing Then
            MsgBox("Uma fonte necessaria não foi encontrada! Instale-a clicando em ""Instalar""")
            Fonte()
            Me.Close()
        Else
            Loader.Show()
            Me.Hide()
        End If


    End Sub
End Class