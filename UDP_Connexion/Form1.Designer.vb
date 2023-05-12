<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TBTo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBrcv = New System.Windows.Forms.TextBox()
        Me.UDP_Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_MMSI = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_Long2 = New System.Windows.Forms.Label()
        Me.Lbl_Lat2 = New System.Windows.Forms.Label()
        Me.Lbl_Lat1 = New System.Windows.Forms.Label()
        Me.Lbl_Long1 = New System.Windows.Forms.Label()
        Me.Lbl_Time = New System.Windows.Forms.Label()
        Me.Lbl_name = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Lbl_year = New System.Windows.Forms.Label()
        Me.lbl_month = New System.Windows.Forms.Label()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.lbl_heure = New System.Windows.Forms.Label()
        Me.lbl_minute = New System.Windows.Forms.Label()
        Me.Lbl_seconde = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Lbl_accuracy = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Decale_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Lbl_P0 = New System.Windows.Forms.Label()
        Me.Lbl_P1 = New System.Windows.Forms.Label()
        Me.Lbl_P2 = New System.Windows.Forms.Label()
        Me.Lbl_P3 = New System.Windows.Forms.Label()
        Me.Lbl_P4 = New System.Windows.Forms.Label()
        Me.Lbl_P5 = New System.Windows.Forms.Label()
        Me.Lbl_P6 = New System.Windows.Forms.Label()
        Me.Lbl_P7 = New System.Windows.Forms.Label()
        Me.Lbl_P8 = New System.Windows.Forms.Label()
        Me.Lbl_P9 = New System.Windows.Forms.Label()
        Me.Chk_Direct = New System.Windows.Forms.CheckBox()
        Me.Chk_AIS_DECODER = New System.Windows.Forms.CheckBox()
        Me.Calcul_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Periode = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label_Refresh = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Chk_Timestamp = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBTo
        '
        Me.TBTo.Location = New System.Drawing.Point(942, 441)
        Me.TBTo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TBTo.Name = "TBTo"
        Me.TBTo.Size = New System.Drawing.Size(180, 29)
        Me.TBTo.TabIndex = 0
        Me.TBTo.Text = "127.0.0.1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(999, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TBrcv
        '
        Me.TBrcv.Location = New System.Drawing.Point(130, 118)
        Me.TBrcv.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TBrcv.Multiline = True
        Me.TBrcv.Name = "TBrcv"
        Me.TBrcv.Size = New System.Drawing.Size(642, 70)
        Me.TBrcv.TabIndex = 4
        '
        'UDP_Timer1
        '
        Me.UDP_Timer1.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(825, 447)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Adresse IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Received"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 42)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "START"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "MMSI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name"
        '
        'Lbl_MMSI
        '
        Me.Lbl_MMSI.AutoSize = True
        Me.Lbl_MMSI.Location = New System.Drawing.Point(94, 18)
        Me.Lbl_MMSI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_MMSI.Name = "Lbl_MMSI"
        Me.Lbl_MMSI.Size = New System.Drawing.Size(65, 25)
        Me.Lbl_MMSI.TabIndex = 13
        Me.Lbl_MMSI.Text = "MMSI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Long"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 183)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Lat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Long"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 264)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 25)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Lat"
        '
        'Lbl_Long2
        '
        Me.Lbl_Long2.AutoSize = True
        Me.Lbl_Long2.Location = New System.Drawing.Point(94, 227)
        Me.Lbl_Long2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Long2.Name = "Lbl_Long2"
        Me.Lbl_Long2.Size = New System.Drawing.Size(67, 25)
        Me.Lbl_Long2.TabIndex = 19
        Me.Lbl_Long2.Text = "Long2"
        '
        'Lbl_Lat2
        '
        Me.Lbl_Lat2.AutoSize = True
        Me.Lbl_Lat2.Location = New System.Drawing.Point(94, 264)
        Me.Lbl_Lat2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Lat2.Name = "Lbl_Lat2"
        Me.Lbl_Lat2.Size = New System.Drawing.Size(50, 25)
        Me.Lbl_Lat2.TabIndex = 20
        Me.Lbl_Lat2.Text = "Lat2"
        '
        'Lbl_Lat1
        '
        Me.Lbl_Lat1.AutoSize = True
        Me.Lbl_Lat1.Location = New System.Drawing.Point(94, 183)
        Me.Lbl_Lat1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Lat1.Name = "Lbl_Lat1"
        Me.Lbl_Lat1.Size = New System.Drawing.Size(50, 25)
        Me.Lbl_Lat1.TabIndex = 21
        Me.Lbl_Lat1.Text = "Lat1"
        '
        'Lbl_Long1
        '
        Me.Lbl_Long1.AutoSize = True
        Me.Lbl_Long1.Location = New System.Drawing.Point(94, 142)
        Me.Lbl_Long1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Long1.Name = "Lbl_Long1"
        Me.Lbl_Long1.Size = New System.Drawing.Size(67, 25)
        Me.Lbl_Long1.TabIndex = 22
        Me.Lbl_Long1.Text = "Long1"
        '
        'Lbl_Time
        '
        Me.Lbl_Time.AutoSize = True
        Me.Lbl_Time.Location = New System.Drawing.Point(94, 102)
        Me.Lbl_Time.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Time.Name = "Lbl_Time"
        Me.Lbl_Time.Size = New System.Drawing.Size(56, 25)
        Me.Lbl_Time.TabIndex = 23
        Me.Lbl_Time.Text = "Time"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(94, 59)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(64, 25)
        Me.Lbl_name.TabIndex = 24
        Me.Lbl_name.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(319, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 25)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Année"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(319, 59)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 25)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Mois"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(319, 102)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Jour"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(319, 142)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 25)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Heure"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(319, 183)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 25)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Minute"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(321, 227)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 25)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Sec."
        '
        'Lbl_year
        '
        Me.Lbl_year.AutoSize = True
        Me.Lbl_year.Location = New System.Drawing.Point(418, 18)
        Me.Lbl_year.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_year.Name = "Lbl_year"
        Me.Lbl_year.Size = New System.Drawing.Size(70, 25)
        Me.Lbl_year.TabIndex = 31
        Me.Lbl_year.Text = "Année"
        '
        'lbl_month
        '
        Me.lbl_month.AutoSize = True
        Me.lbl_month.Location = New System.Drawing.Point(418, 59)
        Me.lbl_month.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_month.Name = "lbl_month"
        Me.lbl_month.Size = New System.Drawing.Size(54, 25)
        Me.lbl_month.TabIndex = 32
        Me.lbl_month.Text = "Mois"
        '
        'lbl_day
        '
        Me.lbl_day.AutoSize = True
        Me.lbl_day.Location = New System.Drawing.Point(418, 107)
        Me.lbl_day.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(51, 25)
        Me.lbl_day.TabIndex = 33
        Me.lbl_day.Text = "Jour"
        '
        'lbl_heure
        '
        Me.lbl_heure.AutoSize = True
        Me.lbl_heure.Location = New System.Drawing.Point(418, 142)
        Me.lbl_heure.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_heure.Name = "lbl_heure"
        Me.lbl_heure.Size = New System.Drawing.Size(65, 25)
        Me.lbl_heure.TabIndex = 34
        Me.lbl_heure.Text = "Heure"
        '
        'lbl_minute
        '
        Me.lbl_minute.AutoSize = True
        Me.lbl_minute.Location = New System.Drawing.Point(418, 183)
        Me.lbl_minute.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_minute.Name = "lbl_minute"
        Me.lbl_minute.Size = New System.Drawing.Size(71, 25)
        Me.lbl_minute.TabIndex = 35
        Me.lbl_minute.Text = "Minute"
        '
        'Lbl_seconde
        '
        Me.Lbl_seconde.AutoSize = True
        Me.Lbl_seconde.Location = New System.Drawing.Point(418, 227)
        Me.Lbl_seconde.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_seconde.Name = "Lbl_seconde"
        Me.Lbl_seconde.Size = New System.Drawing.Size(52, 25)
        Me.Lbl_seconde.TabIndex = 36
        Me.Lbl_seconde.Text = "Sec."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(321, 271)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 25)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Precis."
        '
        'Lbl_accuracy
        '
        Me.Lbl_accuracy.AutoSize = True
        Me.Lbl_accuracy.Location = New System.Drawing.Point(418, 271)
        Me.Lbl_accuracy.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_accuracy.Name = "Lbl_accuracy"
        Me.Lbl_accuracy.Size = New System.Drawing.Size(52, 25)
        Me.Lbl_accuracy.TabIndex = 38
        Me.Lbl_accuracy.Text = "Sec."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Lbl_accuracy)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Lbl_seconde)
        Me.Panel1.Controls.Add(Me.Lbl_MMSI)
        Me.Panel1.Controls.Add(Me.lbl_minute)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl_heure)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_day)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbl_month)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Lbl_year)
        Me.Panel1.Controls.Add(Me.Lbl_Long2)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Lbl_Lat2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Lbl_Lat1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Lbl_Long1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Lbl_Time)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Lbl_name)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(807, 98)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 312)
        Me.Panel1.TabIndex = 39
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(214, 31)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 42)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "SHOW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Decale_Timer
        '
        Me.Decale_Timer.Interval = 60000
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(416, 31)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 42)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Config"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(607, 31)
        Me.Button5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 42)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "STOP"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Lbl_P0
        '
        Me.Lbl_P0.AutoSize = True
        Me.Lbl_P0.Location = New System.Drawing.Point(46, 281)
        Me.Lbl_P0.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P0.Name = "Lbl_P0"
        Me.Lbl_P0.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P0.TabIndex = 43
        Me.Lbl_P0.Text = "P0"
        '
        'Lbl_P1
        '
        Me.Lbl_P1.AutoSize = True
        Me.Lbl_P1.Location = New System.Drawing.Point(46, 321)
        Me.Lbl_P1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P1.Name = "Lbl_P1"
        Me.Lbl_P1.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P1.TabIndex = 44
        Me.Lbl_P1.Text = "P0"
        '
        'Lbl_P2
        '
        Me.Lbl_P2.AutoSize = True
        Me.Lbl_P2.Location = New System.Drawing.Point(46, 366)
        Me.Lbl_P2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P2.Name = "Lbl_P2"
        Me.Lbl_P2.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P2.TabIndex = 45
        Me.Lbl_P2.Text = "P0"
        '
        'Lbl_P3
        '
        Me.Lbl_P3.AutoSize = True
        Me.Lbl_P3.Location = New System.Drawing.Point(46, 402)
        Me.Lbl_P3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P3.Name = "Lbl_P3"
        Me.Lbl_P3.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P3.TabIndex = 46
        Me.Lbl_P3.Text = "P0"
        '
        'Lbl_P4
        '
        Me.Lbl_P4.AutoSize = True
        Me.Lbl_P4.Location = New System.Drawing.Point(46, 445)
        Me.Lbl_P4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P4.Name = "Lbl_P4"
        Me.Lbl_P4.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P4.TabIndex = 47
        Me.Lbl_P4.Text = "P0"
        '
        'Lbl_P5
        '
        Me.Lbl_P5.AutoSize = True
        Me.Lbl_P5.Location = New System.Drawing.Point(315, 281)
        Me.Lbl_P5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P5.Name = "Lbl_P5"
        Me.Lbl_P5.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P5.TabIndex = 48
        Me.Lbl_P5.Text = "P0"
        '
        'Lbl_P6
        '
        Me.Lbl_P6.AutoSize = True
        Me.Lbl_P6.Location = New System.Drawing.Point(315, 321)
        Me.Lbl_P6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P6.Name = "Lbl_P6"
        Me.Lbl_P6.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P6.TabIndex = 49
        Me.Lbl_P6.Text = "P0"
        '
        'Lbl_P7
        '
        Me.Lbl_P7.AutoSize = True
        Me.Lbl_P7.Location = New System.Drawing.Point(315, 366)
        Me.Lbl_P7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P7.Name = "Lbl_P7"
        Me.Lbl_P7.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P7.TabIndex = 50
        Me.Lbl_P7.Text = "P0"
        '
        'Lbl_P8
        '
        Me.Lbl_P8.AutoSize = True
        Me.Lbl_P8.Location = New System.Drawing.Point(315, 402)
        Me.Lbl_P8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P8.Name = "Lbl_P8"
        Me.Lbl_P8.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P8.TabIndex = 51
        Me.Lbl_P8.Text = "P0"
        '
        'Lbl_P9
        '
        Me.Lbl_P9.AutoSize = True
        Me.Lbl_P9.Location = New System.Drawing.Point(315, 445)
        Me.Lbl_P9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_P9.Name = "Lbl_P9"
        Me.Lbl_P9.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_P9.TabIndex = 52
        Me.Lbl_P9.Text = "P0"
        '
        'Chk_Direct
        '
        Me.Chk_Direct.AutoSize = True
        Me.Chk_Direct.Checked = True
        Me.Chk_Direct.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Direct.Location = New System.Drawing.Point(807, 65)
        Me.Chk_Direct.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Chk_Direct.Name = "Chk_Direct"
        Me.Chk_Direct.Size = New System.Drawing.Size(106, 29)
        Me.Chk_Direct.TabIndex = 53
        Me.Chk_Direct.Text = "Decode"
        Me.Chk_Direct.UseVisualStyleBackColor = True
        '
        'Chk_AIS_DECODER
        '
        Me.Chk_AIS_DECODER.AutoSize = True
        Me.Chk_AIS_DECODER.Location = New System.Drawing.Point(807, 22)
        Me.Chk_AIS_DECODER.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Chk_AIS_DECODER.Name = "Chk_AIS_DECODER"
        Me.Chk_AIS_DECODER.Size = New System.Drawing.Size(176, 29)
        Me.Chk_AIS_DECODER.TabIndex = 54
        Me.Chk_AIS_DECODER.Text = "AIS-DECODER"
        Me.Chk_AIS_DECODER.UseVisualStyleBackColor = True
        '
        'Calcul_Timer
        '
        Me.Calcul_Timer.Interval = 5000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Période"
        '
        'Label_Periode
        '
        Me.Label_Periode.AutoSize = True
        Me.Label_Periode.Location = New System.Drawing.Point(130, 205)
        Me.Label_Periode.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_Periode.Name = "Label_Periode"
        Me.Label_Periode.Size = New System.Drawing.Size(34, 25)
        Me.Label_Periode.TabIndex = 56
        Me.Label_Periode.Text = "10"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(411, 205)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(161, 25)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Rafraichissement"
        '
        'Label_Refresh
        '
        Me.Label_Refresh.AutoSize = True
        Me.Label_Refresh.Location = New System.Drawing.Point(601, 205)
        Me.Label_Refresh.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_Refresh.Name = "Label_Refresh"
        Me.Label_Refresh.Size = New System.Drawing.Size(23, 25)
        Me.Label_Refresh.TabIndex = 58
        Me.Label_Refresh.Text = "5"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(176, 205)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 25)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "min"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(636, 205)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 25)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "sec."
        '
        'Chk_Timestamp
        '
        Me.Chk_Timestamp.AutoSize = True
        Me.Chk_Timestamp.Checked = True
        Me.Chk_Timestamp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Timestamp.Location = New System.Drawing.Point(242, 203)
        Me.Chk_Timestamp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Chk_Timestamp.Name = "Chk_Timestamp"
        Me.Chk_Timestamp.Size = New System.Drawing.Size(153, 29)
        Me.Chk_Timestamp.TabIndex = 61
        Me.Chk_Timestamp.Text = "TimeSTAMP"
        Me.Chk_Timestamp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 530)
        Me.Controls.Add(Me.Chk_Timestamp)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label_Refresh)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label_Periode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chk_AIS_DECODER)
        Me.Controls.Add(Me.Chk_Direct)
        Me.Controls.Add(Me.Lbl_P9)
        Me.Controls.Add(Me.Lbl_P8)
        Me.Controls.Add(Me.Lbl_P7)
        Me.Controls.Add(Me.Lbl_P6)
        Me.Controls.Add(Me.Lbl_P5)
        Me.Controls.Add(Me.Lbl_P4)
        Me.Controls.Add(Me.Lbl_P3)
        Me.Controls.Add(Me.Lbl_P2)
        Me.Controls.Add(Me.Lbl_P1)
        Me.Controls.Add(Me.Lbl_P0)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBrcv)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBTo)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "AIS Analyser - A.HARDY/V.WEBER - V.1.2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBTo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TBrcv As System.Windows.Forms.TextBox
    Friend WithEvents UDP_Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_MMSI As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Long2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Lat2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Lat1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Long1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Time As System.Windows.Forms.Label
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Lbl_year As System.Windows.Forms.Label
    Friend WithEvents lbl_month As System.Windows.Forms.Label
    Friend WithEvents lbl_day As System.Windows.Forms.Label
    Friend WithEvents lbl_heure As System.Windows.Forms.Label
    Friend WithEvents lbl_minute As System.Windows.Forms.Label
    Friend WithEvents Lbl_seconde As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Lbl_accuracy As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Decale_Timer As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Lbl_P0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P7 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P8 As System.Windows.Forms.Label
    Friend WithEvents Lbl_P9 As System.Windows.Forms.Label
    Friend WithEvents Chk_Direct As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_AIS_DECODER As System.Windows.Forms.CheckBox
    Friend WithEvents Calcul_Timer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_Periode As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label_Refresh As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Chk_Timestamp As System.Windows.Forms.CheckBox

End Class
