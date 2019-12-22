<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControleTempo
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.labelClock = New System.Windows.Forms.Label()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'labelClock
        '
        Me.labelClock.AutoSize = True
        Me.labelClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClock.Location = New System.Drawing.Point(34, 26)
        Me.labelClock.Name = "labelClock"
        Me.labelClock.Size = New System.Drawing.Size(0, 25)
        Me.labelClock.TabIndex = 0
        '
        'TimerClock
        '
        Me.TimerClock.Enabled = True
        '
        'ControleTempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labelClock)
        Me.Name = "ControleTempo"
        Me.Size = New System.Drawing.Size(79, 60)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelClock As Label
    Friend WithEvents TimerClock As Timer
End Class
