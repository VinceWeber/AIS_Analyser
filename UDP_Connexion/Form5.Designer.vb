<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Txt_titre = New System.Windows.Forms.TextBox()
        Me.Txt_result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txt_titre
        '
        Me.Txt_titre.Location = New System.Drawing.Point(12, 12)
        Me.Txt_titre.Multiline = True
        Me.Txt_titre.Name = "Txt_titre"
        Me.Txt_titre.ReadOnly = True
        Me.Txt_titre.Size = New System.Drawing.Size(377, 32)
        Me.Txt_titre.TabIndex = 3
        '
        'Txt_result
        '
        Me.Txt_result.Location = New System.Drawing.Point(12, 50)
        Me.Txt_result.Multiline = True
        Me.Txt_result.Name = "Txt_result"
        Me.Txt_result.ReadOnly = True
        Me.Txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_result.Size = New System.Drawing.Size(377, 542)
        Me.Txt_result.TabIndex = 2
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 624)
        Me.Controls.Add(Me.Txt_titre)
        Me.Controls.Add(Me.Txt_result)
        Me.Name = "Form5"
        Me.Text = "Autres_MMSI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_titre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_result As System.Windows.Forms.TextBox
End Class
