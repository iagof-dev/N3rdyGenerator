<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loader
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loader))
        Me.N3rdy = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Generator = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'N3rdy
        '
        Me.N3rdy.AutoSize = True
        Me.N3rdy.Font = New System.Drawing.Font("Doctor Glitch", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N3rdy.Location = New System.Drawing.Point(121, 132)
        Me.N3rdy.Name = "N3rdy"
        Me.N3rdy.Size = New System.Drawing.Size(274, 67)
        Me.N3rdy.TabIndex = 0
        Me.N3rdy.Text = "N3rdy"
        Me.N3rdy.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        '
        'Generator
        '
        Me.Generator.AutoSize = True
        Me.Generator.Font = New System.Drawing.Font("Doctor Glitch", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Generator.Location = New System.Drawing.Point(219, 219)
        Me.Generator.Name = "Generator"
        Me.Generator.Size = New System.Drawing.Size(466, 67)
        Me.Generator.TabIndex = 1
        Me.Generator.Text = "Generator"
        Me.Generator.Visible = False
        '
        'Timer3
        '
        '
        'Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Generator)
        Me.Controls.Add(Me.N3rdy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loader [v1.0]"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents N3rdy As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Generator As Label
    Friend WithEvents Timer3 As Timer
End Class
