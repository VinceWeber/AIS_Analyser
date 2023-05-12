<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Periode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Refresh = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Chk_T24 = New System.Windows.Forms.CheckBox()
        Me.Chk_T19 = New System.Windows.Forms.CheckBox()
        Me.Chk_T18 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Chk_T5 = New System.Windows.Forms.CheckBox()
        Me.Chk_T1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Période de calcul"
        '
        'Txt_Periode
        '
        Me.Txt_Periode.Location = New System.Drawing.Point(133, 19)
        Me.Txt_Periode.Name = "Txt_Periode"
        Me.Txt_Periode.Size = New System.Drawing.Size(73, 20)
        Me.Txt_Periode.TabIndex = 7
        Me.Txt_Periode.Text = "10"
        Me.Txt_Periode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Rafraichissement"
        '
        'Txt_Refresh
        '
        Me.Txt_Refresh.Location = New System.Drawing.Point(133, 45)
        Me.Txt_Refresh.Name = "Txt_Refresh"
        Me.Txt_Refresh.Size = New System.Drawing.Size(73, 20)
        Me.Txt_Refresh.TabIndex = 9
        Me.Txt_Refresh.Text = "5"
        Me.Txt_Refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 181)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtres Messages AIS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.Chk_T24)
        Me.GroupBox3.Controls.Add(Me.Chk_T19)
        Me.GroupBox3.Controls.Add(Me.Chk_T18)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 73)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Class B"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(50, 86)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 22
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Chk_T24
        '
        Me.Chk_T24.AutoSize = True
        Me.Chk_T24.Checked = True
        Me.Chk_T24.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_T24.Location = New System.Drawing.Point(108, 25)
        Me.Chk_T24.Name = "Chk_T24"
        Me.Chk_T24.Size = New System.Drawing.Size(65, 17)
        Me.Chk_T24.TabIndex = 21
        Me.Chk_T24.Text = "Type 24"
        Me.Chk_T24.UseVisualStyleBackColor = True
        '
        'Chk_T19
        '
        Me.Chk_T19.AutoSize = True
        Me.Chk_T19.Checked = True
        Me.Chk_T19.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_T19.Location = New System.Drawing.Point(22, 48)
        Me.Chk_T19.Name = "Chk_T19"
        Me.Chk_T19.Size = New System.Drawing.Size(65, 17)
        Me.Chk_T19.TabIndex = 20
        Me.Chk_T19.Text = "Type 19"
        Me.Chk_T19.UseVisualStyleBackColor = True
        '
        'Chk_T18
        '
        Me.Chk_T18.AutoSize = True
        Me.Chk_T18.Checked = True
        Me.Chk_T18.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_T18.Location = New System.Drawing.Point(22, 25)
        Me.Chk_T18.Name = "Chk_T18"
        Me.Chk_T18.Size = New System.Drawing.Size(65, 17)
        Me.Chk_T18.TabIndex = 19
        Me.Chk_T18.Text = "Type 18"
        Me.Chk_T18.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chk_T5)
        Me.GroupBox2.Controls.Add(Me.Chk_T1)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 73)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Class A"
        '
        'Chk_T5
        '
        Me.Chk_T5.AutoSize = True
        Me.Chk_T5.Checked = True
        Me.Chk_T5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_T5.Location = New System.Drawing.Point(21, 42)
        Me.Chk_T5.Name = "Chk_T5"
        Me.Chk_T5.Size = New System.Drawing.Size(59, 17)
        Me.Chk_T5.TabIndex = 22
        Me.Chk_T5.Text = "Type 5"
        Me.Chk_T5.UseVisualStyleBackColor = True
        '
        'Chk_T1
        '
        Me.Chk_T1.AutoSize = True
        Me.Chk_T1.Checked = True
        Me.Chk_T1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_T1.Location = New System.Drawing.Point(22, 19)
        Me.Chk_T1.Name = "Chk_T1"
        Me.Chk_T1.Size = New System.Drawing.Size(77, 17)
        Me.Chk_T1.TabIndex = 19
        Me.Chk_T1.Text = "Type 1,2,3"
        Me.Chk_T1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Minutes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Secondes"
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(121, 82)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(97, 23)
        Me.Btn_Save.TabIndex = 17
        Me.Btn_Save.Text = "Sauver chgt."
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 350)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Refresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Periode)
        Me.Name = "Form3"
        Me.Text = "Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Periode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Refresh As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_T24 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_T19 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_T18 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_T5 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_T1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
End Class
