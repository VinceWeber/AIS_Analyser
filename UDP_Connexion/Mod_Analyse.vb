Imports System.Math
Module Mod_Analyse

    Public bateaux(200) As Bateau
    Public affiche_bateau(200) As Bateau
    Public nb_bateaux, nb_bateaux_connus As Integer
    Public phrases(50000) As String

    Public cpt1, cpt2, cpt3 As Integer



    Public Sub affiche_phrase(ByVal phrase() As String)
        Form1.Lbl_P0.Text = phrase(0)
        Form1.Lbl_P1.Text = phrase(1)
        Form1.Lbl_P2.Text = phrase(2)
        Form1.Lbl_P3.Text = phrase(3)
        Form1.Lbl_P4.Text = phrase(4)
        Form1.Lbl_P5.Text = phrase(5)
        Form1.Lbl_P6.Text = phrase(6)
        Form1.Lbl_P7.Text = phrase(7)
        Form1.Lbl_P8.Text = phrase(8)
        Form1.Lbl_P9.Text = phrase(9)

    End Sub

#Region "Analyse des Chaines NMEA"
    Public Sub Analyse_phrase_NMEA(ByVal Chaine As String, ByVal heure As Date)
        '********  ATTENTION CE CODE N'ANALYSE QU'UNE SEULE LIGNE DU TAMPON (corrigé) ****************
        Dim lg_chaine, i, j, pos_parametre(10), parametre As Integer
        Dim chr_deb, chr_fin, chr_sep, chr_checksum, checksum_phrase, phrase(10) As String
        Dim checksum_ok, debut_valide As Boolean

        lg_chaine = Len(Chaine)
        chr_deb = "!"
        chr_fin = Chr(13)
        chr_sep = ","
        chr_checksum = "*"
        checksum_ok = False
        checksum_phrase = ""
        debut_valide = False

        Form2.Label9.Text = cpt3
        cpt3 = cpt3 + 1

        For i = 1 To lg_chaine
            If Mid(Chaine, i, 1) = chr_deb Then
                'Défini le début de la phrase NMEA
                For j = 0 To 10
                    phrase(j) = ""
                Next j
                pos_parametre(0) = i
                debut_valide = True
                parametre = 0



            ElseIf Mid(Chaine, i, 1) = chr_sep Then
                'Défini que l'on passe au prochain paramètre
                phrase(parametre) = Mid(Chaine, pos_parametre(parametre) + 1, i - pos_parametre(parametre) - 1)
                parametre = parametre + 1
                pos_parametre(parametre) = i
                affiche_phrase(phrase)

            ElseIf Mid(Chaine, i, 1) = chr_checksum Then

                If debut_valide = True Then
                    checksum_phrase = Mid(Chaine, i + 1, 2)
                    If GetChecksum(Mid(Chaine, pos_parametre(0) + 1, i - pos_parametre(0))) = checksum_phrase Then
                        'Défini que l'on passe au prochain paramètre
                        phrase(parametre) = Mid(Chaine, pos_parametre(parametre) + 1, i - pos_parametre(parametre) - 1) & "OK"
                        parametre = parametre + 1
                        pos_parametre(parametre) = i
                        Traduction_Payload(phrase, heure)
                    End If
                End If
                affiche_phrase(phrase)

                ' ElseIf Mid(Chaine, i, 1) = chr_fin Then
            ElseIf i = lg_chaine Then
                If debut_valide = True Then
                    phrase(parametre) = Mid(Chaine, pos_parametre(parametre) + 1, i - pos_parametre(parametre) - 1)
                    parametre = parametre + 1
                    pos_parametre(parametre) = i

                End If
                debut_valide = False
            End If
            affiche_phrase(phrase)
            If parametre = 10 Then parametre = 9
        Next i

    End Sub
    Public Sub Traduction_Payload(ByVal Phrase() As String, ByVal heure As Date)
        Dim bin As String
        Dim AIS_MSg As AIS_Message
        AIS_MSg = New AIS_Message
        Dim adresse_bateau As Integer = 0


        If Phrase(0) = "AIVDM" Or Phrase(0) = "AIVDO" Then
            bin = payloadtoBin(Phrase(5))
            '    Form2.Label3.Text = cpt1
            '    Form2.Label11.Text = bin
            '    cpt1 = cpt1 + 1

            Extract_Bin_Entete_AIS(bin, AIS_MSg)

            ' Form2.Label13.Text = AIS_MSg.A_Type_Message
            ' Form2.Label15.Text = AIS_MSg.B_Repeat_Indicator
            ' Form2.Label16.Text = AIS_MSg.C_MMSI


            ' Form2.Label5.Text = cpt2
            ' cpt2 = cpt2 + 1

            'Form2.Label18.Text = checktypeaismess(AIS_MSg)

            If checktypeaismess(AIS_MSg) Then

                '   Form2.Label7.Text = cpt3
                '   cpt3 = cpt3 + 1

                Extract_Bin_Message(bin, AIS_MSg)
                AIS_MSg.M_Receivedtime = heure

                '   Form2.Label7.Text = nb_bateaux

                If MMSI_exists(AIS_MSg, adresse_bateau) And nb_bateaux <> 0 Then
                    completer_bateau(AIS_MSg, adresse_bateau)
                ElseIf MMSI_exists(AIS_MSg, adresse_bateau) = False And nb_bateaux < 199 Then
                    Nouveau_bateau(AIS_MSg, nb_bateaux)
                End If
            End If
        End If


    End Sub
    Public Function Test_phrase_NMEA(ByVal chaine As String) As Boolean
        Dim lg_chaine, i As Integer
        Dim chr_deb, chr_fin, chr_checksum, checksum_phrase As String
        Dim checksum_ok, debut_valide As Boolean
        lg_chaine = Len(chaine)
        chr_deb = "$"
        chr_fin = Chr(10)
        chr_checksum = "*"
        checksum_ok = False
        checksum_phrase = ""
        debut_valide = False

        For i = 1 To lg_chaine
            If Mid(chaine, i, 1) = chr_deb Then
                'Défini le début de la phrase NMEA
                debut_valide = True
            ElseIf Mid(chaine, i, 1) = chr_checksum Then
                If debut_valide = True Then
                    checksum_phrase = Mid(chaine, i + 1, 2)
                    If GetChecksum(Mid(chaine, 0, i - 1)) = checksum_phrase Then
                        checksum_ok = True
                    End If
                End If
                debut_valide = False
            End If
        Next i
        Return checksum_ok
    End Function
    Public Function GetChecksum(ByVal sentence As String) As String
        ' Loop through all chars to get a checksum
        Dim Character As Char
        Dim Checksum As Integer
        On Error Resume Next
        For Each Character In sentence
            Select Case Character
                Case "$"c
                    ' Ignore the dollar sign
                Case "*"c
                    ' Stop processing before the asterisk
                    Exit For
                Case Else
                    ' Is this the first value for the checksum?
                    If Checksum = 0 Then
                        ' Yes. Set the checksum to the value
                        Checksum = Convert.ToByte(Character)
                    Else
                        ' No. XOR the checksum with this character's value
                        Checksum = Checksum Xor Convert.ToByte(Character)
                    End If
            End Select
        Next
        ' Return the checksum formatted as a two-character hexadecimal
        Return Checksum.ToString("X2")
    End Function
    Public Function checktypeaismess(ByVal aismsg As AIS_Message) As Boolean
        checktypeaismess = False

        If aismsg.A_Type_Message = 1 Or aismsg.A_Type_Message = 2 Or aismsg.A_Type_Message = 3 Then
            If Form3.Chk_T1.Checked Then
                checktypeaismess = True
            End If
        End If

        If aismsg.A_Type_Message = 5 Then
            If Form3.Chk_T5.Checked Then
                checktypeaismess = True
            End If
        End If

        If aismsg.A_Type_Message = 18 Then
            If Form3.Chk_T18.Checked Then
                checktypeaismess = True
            End If
        End If

        If aismsg.A_Type_Message = 19 Then
            If Form3.Chk_T19.Checked Then
                checktypeaismess = True
            End If
        End If

        If aismsg.A_Type_Message = 24 Then
            If Form3.Chk_T24.Checked Then
                checktypeaismess = True
            End If
        End If

        '   If aismsg.A_Type_Message = 1 Or aismsg.A_Type_Message = 2 Or aismsg.A_Type_Message = 3 Or aismsg.A_Type_Message = 5 Or aismsg.A_Type_Message = 18 Or aismsg.A_Type_Message = 19 Or aismsg.A_Type_Message = 24 Then
        'If aismsg.A_Type_Message = 24 Then

        'checktypeaismess = True
        '  End If

    End Function
    Public Sub Extract_Bin_Entete_AIS(ByVal Bin As String, ByRef AIS_Msg As AIS_Message)
        'Extract_Bin_Entete_AIS = New AIS_Message

        'Compléter en extrayant les bits correspondants au Type Message, Repeat Indicator, MMSI
        AIS_Msg.A_Type_Message = BinToDec(Mid(Bin, 1, 6))
        AIS_Msg.B_Repeat_Indicator = BinToDec(Mid(Bin, 7, 2))
        AIS_Msg.C_MMSI = BinToDec(Mid(Bin, 9, 30))
    End Sub
    Public Sub Extract_Bin_Message(ByVal Bin As String, ByRef AIS_MSG As AIS_Message)
        If AIS_MSG.A_Type_Message = 1 Or AIS_MSG.A_Type_Message = 2 Or AIS_MSG.A_Type_Message = 3 Then
            'Extraire un mesage de type 1,2,3
            AIS_MSG.D_SOG = BinToDec(Mid(Bin, 51, 10))   'OK (A vérifier sur valeur non nulle)
            AIS_MSG.E_Position_Accuracy = Mid(Bin, 61, 1)   'OK 0 =False; 1=True

            If Mid(Bin, 62, 1) = 0 Then
                AIS_MSG.F_Longitude = BinToDec(Mid(Bin, 62, 28)) / 600000   'A traiter
            ElseIf Mid(Bin, 62, 1) = 1 Then
                AIS_MSG.F_Longitude = -BinToDec(twocompplement(Mid(Bin, 63, 27))) / 600000
            End If

            If Mid(Bin, 90, 1) = 0 Then
                AIS_MSG.G_Latitude = BinToDec(Mid(Bin, 90, 27)) / 600000   'A traiter
            ElseIf Mid(Bin, 90, 1) = 1 Then
                AIS_MSG.G_Latitude = -BinToDec(twocompplement(Mid(Bin, 91, 26))) / 600000
            End If

            AIS_MSG.H_COG = BinToDec(Mid(Bin, 117, 12)) / 10  'Ok
            AIS_MSG.K_Timestamp = BinToDec(Mid(Bin, 138, 6))  'OK
            ' AIS_MSG.L_HDG = BinToDec(Mid(Bin, 129, 12)) Mod 360  'non solutionné
        ElseIf AIS_MSG.A_Type_Message = 5 Then
            'Extraire un message de type 5

            AIS_MSG.I_NAME = bintochar(Mid(Bin, 113, 120)) ' ok
            AIS_MSG.J_Type_of_ship = BinToDec(Mid(Bin, 233, 8))  'ok


        ElseIf AIS_MSG.A_Type_Message = 18 Then
            'Extraire un message de type 18
            'Extraire un mesage de type 1,2,3
            AIS_MSG.D_SOG = BinToDec(Mid(Bin, 47, 10))   'OK (A vérifier sur valeur non nulle)
            AIS_MSG.E_Position_Accuracy = Mid(Bin, 57, 1)   'OK 0 =False; 1=True

            If Mid(Bin, 58, 1) = 0 Then
                AIS_MSG.F_Longitude = BinToDec(Mid(Bin, 58, 28)) / 600000   'A traiter
            ElseIf Mid(Bin, 58, 1) = 1 Then
                AIS_MSG.F_Longitude = -BinToDec(twocompplement(Mid(Bin, 59, 27))) / 600000
            End If

            If Mid(Bin, 86, 1) = 0 Then
                AIS_MSG.G_Latitude = BinToDec(Mid(Bin, 86, 27)) / 600000   'A traiter
            ElseIf Mid(Bin, 86, 1) = 1 Then
                AIS_MSG.G_Latitude = -BinToDec(twocompplement(Mid(Bin, 87, 26))) / 600000
            End If

            AIS_MSG.H_COG = BinToDec(Mid(Bin, 113, 12)) / 10  'Ok
            AIS_MSG.K_Timestamp = BinToDec(Mid(Bin, 134, 6))  'OK

        ElseIf AIS_MSG.A_Type_Message = 19 Then
            'Extraire un message de type 19
            AIS_MSG.D_SOG = BinToDec(Mid(Bin, 47, 10))   'OK (A vérifier sur valeur non nulle)
            AIS_MSG.E_Position_Accuracy = Mid(Bin, 57, 1)   'OK 0 =False; 1=True

            If Mid(Bin, 58, 1) = 0 Then
                AIS_MSG.F_Longitude = BinToDec(Mid(Bin, 58, 28)) / 600000   'A traiter
            ElseIf Mid(Bin, 58, 1) = 1 Then
                AIS_MSG.F_Longitude = -BinToDec(twocompplement(Mid(Bin, 59, 27))) / 600000
            End If

            If Mid(Bin, 86, 1) = 0 Then
                AIS_MSG.G_Latitude = BinToDec(Mid(Bin, 86, 27)) / 600000   'A traiter
            ElseIf Mid(Bin, 86, 1) = 1 Then
                AIS_MSG.G_Latitude = -BinToDec(twocompplement(Mid(Bin, 87, 26))) / 600000
            End If

            AIS_MSG.H_COG = BinToDec(Mid(Bin, 113, 12)) / 10  'Ok
            AIS_MSG.K_Timestamp = BinToDec(Mid(Bin, 134, 6))  'OK

            AIS_MSG.I_NAME = Mid(Bin, 144, 120)
            AIS_MSG.J_Type_of_ship = BinToDec(Mid(Bin, 264, 8))


        ElseIf AIS_MSG.A_Type_Message = 24 Then
            'Extraire un message de type 24

            AIS_MSG.I_NAME = bintochar(Mid(Bin, 41, 120))
            AIS_MSG.J_Type_of_ship = BinToDec(Mid(Bin, 41, 8))  ' Attention traiter le repeat indicator, le type of ship se traite uniquement dans le second message

        End If

    End Sub
    Public Function MMSI_exists(ByVal MessageAIS As AIS_Message, ByRef adresse_bateau As Integer) As Boolean
        Dim i As Integer = 0
        Dim found As Boolean = False
        MMSI_exists = False
        If nb_bateaux <> 0 Then
            Do While i < nb_bateaux And found = False
                If bateaux(i).MMSI = MessageAIS.C_MMSI Then
                    MMSI_exists = True
                    adresse_bateau = i
                End If
                i = i + 1
            Loop
        End If
    End Function
    Public Sub completer_bateau(ByVal AIS_Msg As AIS_Message, ByVal ID As Integer)
        'bateaux(ID).MMSI = AIS_Msg.C_MMSI
        If bateaux(ID).Nom_bateau = "" Then
            bateaux(ID).Nom_bateau = AIS_Msg.I_NAME
        End If
        If bateaux(ID).Type_of_ship = "" Then
            bateaux(ID).Type_of_ship = AIS_Msg.J_Type_of_ship
        End If
        bateaux(ID).Position_actuelle.D_SOG = AIS_Msg.D_SOG
        bateaux(ID).Position_actuelle.E_Position_Accuracy = AIS_Msg.E_Position_Accuracy
        bateaux(ID).Position_actuelle.H_COG = AIS_Msg.H_COG
        bateaux(ID).Position_actuelle.heure = AIS_Msg.M_Receivedtime
        bateaux(ID).Position_actuelle.K_Timestamp = AIS_Msg.K_Timestamp
        bateaux(ID).Position_actuelle.Latitude = AIS_Msg.G_Latitude
        bateaux(ID).Position_actuelle.Longitude = AIS_Msg.F_Longitude
    End Sub
    Public Sub Nouveau_bateau(ByVal AIS_MSg As AIS_Message, ByRef ID As Integer)
 

        bateaux(ID) = New Bateau
        bateaux(ID).Position_actuelle = New Position
        bateaux(ID).Position_T1 = New Position
        bateaux(ID).Position_T2 = New Position
        bateaux(ID).Position_T3 = New Position
        bateaux(ID).Position_T4 = New Position
        bateaux(ID).Position_T5 = New Position
        bateaux(ID).Position_T6 = New Position
        bateaux(ID).Position_T7 = New Position
        bateaux(ID).Position_T8 = New Position
        bateaux(ID).Position_T9 = New Position

        bateaux(ID).MMSI = AIS_MSg.C_MMSI
        bateaux(ID).Nom_bateau = AIS_MSg.I_NAME
        bateaux(ID).Type_of_ship = AIS_MSg.J_Type_of_ship
        bateaux(ID).Position_actuelle.D_SOG = AIS_MSg.D_SOG
        bateaux(ID).Position_actuelle.E_Position_Accuracy = AIS_MSg.E_Position_Accuracy
        bateaux(ID).Position_actuelle.H_COG = AIS_MSg.H_COG
        bateaux(ID).Position_actuelle.heure = AIS_MSg.M_Receivedtime
        bateaux(ID).Position_actuelle.K_Timestamp = AIS_MSg.K_Timestamp
        bateaux(ID).Position_actuelle.Latitude = AIS_MSg.G_Latitude
        bateaux(ID).Position_actuelle.Longitude = AIS_MSg.F_Longitude
        ID = ID + 1
    End Sub
    
    Public Sub Nouveau_bateau2(ByVal phrase() As String, ByVal compteur As Integer)
        bateaux(compteur) = New Bateau
        bateaux(compteur).Position_actuelle = New Position
        bateaux(compteur).Position_T1 = New Position
        bateaux(compteur).Position_T2 = New Position
        bateaux(compteur).Position_T3 = New Position
        bateaux(compteur).Position_T4 = New Position
        bateaux(compteur).Position_T5 = New Position
        bateaux(compteur).Position_T6 = New Position
        bateaux(compteur).Position_T7 = New Position
        bateaux(compteur).Position_T8 = New Position
        bateaux(compteur).Position_T9 = New Position

        bateaux(compteur).MMSI = phrase(0)
        bateaux(compteur).Nom_bateau = phrase(1)
        bateaux(compteur).Position_actuelle.Longitude = Val(phrase(3))
        bateaux(compteur).Position_actuelle.Latitude = Val(phrase(4))
        bateaux(compteur).Position_actuelle.heure = TimeValue(phrase(2))
        nb_bateaux = nb_bateaux + 1
    End Sub
    Public Sub Enregistrement_AIS(ByVal phrase() As String, ByVal compteur As Integer)

        ' bateaux(compteur).MMSI = phrase(0)
        If phrase(1) <> "" Then
            bateaux(compteur).Nom_bateau = phrase(1)
        End If
        If phrase(3) <> "" Then
            bateaux(compteur).Position_actuelle.Longitude = Val(phrase(3))
            bateaux(compteur).Position_actuelle.Latitude = Val(phrase(4))
            bateaux(compteur).Position_actuelle.heure = TimeValue(phrase(2))
        End If

    End Sub

#End Region

    Public Sub Calcul_Parametres()
        Dim i As Integer
        Dim distance As Double
        Dim Cap As Double
        Dim temps As Double
        Dim vmoy As Double

        Dim position_calcul1 As Position
        Dim position_calcul2 As Position

        position_calcul1 = New Position
        position_calcul2 = New Position
        i = 0
        If nb_bateaux <> 0 Then
            Do While i < nb_bateaux

                position_calcul1 = position1(bateaux(i))
                position_calcul2 = position2(bateaux(i))


                If bateaux(i).Note <> 0 And bateaux(i).Note <> -10 Then
                    bateaux(i).Cmoy = Calcul_cap(position_calcul1, position_calcul2)
                    'distance = Calcul_distance_ortho(position_calcul1, position_calcul2)
                    distance = Calcul_distance_loxo(position_calcul1, position_calcul2, bateaux(i).Cmoy)


                    'recalage du temps via le timestamp

                    If Form1.Chk_Timestamp.Checked = True Then
                        position_calcul1 = Modif_Heure_time_stamp(position_calcul1)
                        position_calcul2 = Modif_Heure_time_stamp(position_calcul2)
                    End If

                    temps = DateDiff("s", position_calcul1.heure, position_calcul2.heure) / 3600

                    If temps <> 0 Then
                        bateaux(i).Vmoy = distance / temps
                    Else
                        bateaux(i).Vmoy = 0
                    End If
                Else
                    bateaux(i).Vmoy = 0
                    bateaux(i).Cmoy = 0
                End If

                i = i + 1
            Loop
        End If
        affiche_tableau()
    End Sub
    Public Function Modif_Heure_time_stamp(ByVal Position As Position) As Position
        Modif_Heure_time_stamp = Position

        Dim timestamp As Single
        Dim annee, mois, jour, h, min, seconde As String
        Dim heure As Date

        heure = Position.heure
        timestamp = Position.K_Timestamp

        'extraire les données du temps
        annee = Year(Now)
        mois = heure.ToString("MM")
        jour = heure.ToString("dd")
        h = heure.ToString("HH")
        min = heure.ToString("mm")
        seconde = heure.ToString("ss")

        If timestamp < 60 Then
            ' dfghd()
            ' Dim dateNaissance As New System.DateTime(1996, 6, 3, 22, 15, 0)
            'Année, mois, jour, heure, minute, seconde, et éventuellement millisecondes)
            If timestamp > seconde Then
                If min <> 0 Then
                    min = min - 1
                Else
                    If h <> 0 Then
                        h = h - 1
                        min = 59
                    Else
                        jour = jour - 1
                        h = 23
                        min = 59
                    End If
                End If

            End If

                heure = New System.DateTime(annee, mois, jour, h, min, timestamp)

            Else
                heure = New System.DateTime(annee, mois, jour, h, min, seconde)

            End If



            Modif_Heure_time_stamp.heure = heure




    End Function
    Public Function Calcul_distance_ortho(ByVal Position1 As Position, ByVal Position2 As Position) As Double
        Dim Lat1, Long1, Lat2, Long2, cosN As Double

        Lat1 = Position1.Latitude * PI / 180
        Long1 = Position1.Longitude * PI / 180

        Lat2 = Position2.Latitude * PI / 180
        Long2 = Position2.Longitude * PI / 180

        cosN = Sin(Lat1) * Sin(Lat2) + Cos(Lat1) * Cos(Lat2) * Cos(Long2 - Long1)
        Calcul_distance_ortho = 6378 / 1.852 * Acos(cosN)
    End Function
    Public Function Calcul_distance_loxo(ByVal Position1 As Position, ByVal Position2 As Position, ByVal rte As Double) As Double
        Dim Lat1, Long1, Lat2, Long2, DF As Double

        Lat1 = Position1.Latitude
        Long1 = -Position1.Longitude

        Lat2 = Position2.Latitude
        Long2 = -Position2.Longitude

        If Lat1 <> Lat2 Or Long1 <> Long2 Then

            If Lat1 = Lat2 Then
                DF = (Abs(Long2 - Long1) * 60) * Cos(Lat2 / 180 * PI)
            Else
                DF = Abs((Lat2 - Lat1) * 60 / Cos(rte * PI / 180))
            End If
        Else
            DF = 0
        End If

        If Lat1 <> Lat2 Or Long1 <> Long2 Then
            ' Code suivant a effacer
            Dim temps, vmoy As Double
            temps = DateDiff("s", Position1.heure, Position2.heure) / 3600


            If temps <> 0 Then
                vmoy = DF / temps
            Else
                vmoy = 0
            End If
        End If



        Calcul_distance_loxo = DF
    End Function
   
    Public Function LatCroissante(ByVal Latitude)
        LatCroissante = 180 * Log(Tan(Latitude / 360 * Pi + Pi / 4)) / Pi
    End Function
    Public Function Calcul_cap(ByVal Position1 As Position, ByVal Position2 As Position) As Double
        Dim Lat1, Long1, Lat2, Long2, rfq As Double
        Lat1 = Position1.Latitude
        Long1 = -Position1.Longitude   'Inversion Long W = + ; Long E =-

        Lat2 = Position2.Latitude
        Long2 = -Position2.Longitude   'Inversion Long W = + ; Long E =-

        If (Lat1 <> Lat2) Then
            rfq = Atan(Abs((Long2 - Long1) / (LatCroissante(Lat1) - LatCroissante(Lat2)))) * 180 / PI
        End If
        If (Lat1 > Lat2) And (Long2 >= Long1) Then
            rfq = rfq + 180
        End If

        If (Lat1 > Lat2) And (Long2 < Long1) Then
            rfq = 180 - rfq
        End If
        If (Lat1 < Lat2) And (Long2 > Long1) Then
            rfq = 360 - rfq
        End If
        If (Lat1 = Lat2) And (Long2 > Long1) Then
            rfq = 270
        End If
        If (Lat1 = Lat2) And (Long2 < Long1) Then
            rfq = 90
        End If

        Calcul_cap = rfq
    End Function
    Public Function Vitesse_moyenne(ByVal distance As Single, ByVal Temps As Single) As Double
        Vitesse_moyenne = 1
    End Function
    Public Function Note(ByVal bateau As Bateau) As Single
        Note = 1
    End Function

    Public Function position1(ByRef bateau As Bateau) As Position
        If bateau.Position_T9.Latitude = 0 Then
            If bateau.Position_T8.Latitude = 0 Then
                If bateau.Position_T7.Latitude = 0 Then
                    If bateau.Position_T6.Latitude = 0 Then
                        If bateau.Position_T5.Latitude = 0 Then
                            If bateau.Position_T4.Latitude = 0 Then
                                If bateau.Position_T3.Latitude = 0 Then
                                    If bateau.Position_T2.Latitude = 0 Then
                                        If bateau.Position_T1.Latitude = 0 Then
                                            If bateau.Position_actuelle.Latitude = 0 Then
                                                bateau.Note = 0
                                            Else
                                                bateau.Note = 1
                                                position1 = bateau.Position_actuelle
                                            End If
                                            bateau.Note = 0
                                        Else
                                            bateau.Note = 2
                                            position1 = bateau.Position_T1
                                        End If
                                    Else
                                        bateau.Note = 3
                                        position1 = bateau.Position_T2
                                    End If
                                Else
                                    bateau.Note = 4
                                    position1 = bateau.Position_T3
                                End If
                            Else
                                bateau.Note = 5
                                position1 = bateau.Position_T4
                            End If
                        Else
                            bateau.Note = 6
                            position1 = bateau.Position_T5
                        End If
                    Else
                        bateau.Note = 7
                        position1 = bateau.Position_T6
                    End If
                Else
                    bateau.Note = 8
                    position1 = bateau.Position_T7
                End If
            Else
                bateau.Note = 9
                position1 = bateau.Position_T8
            End If
        Else
            bateau.Note = 10
            position1 = bateau.Position_T9
        End If
    End Function
    Public Function position2(ByRef bateau As Bateau) As Position
        If bateau.Position_actuelle.Latitude = 0 Then
            If bateau.Position_T1.Latitude = 0 Then
                If bateau.Position_T2.Latitude = 0 Then
                    If bateau.Position_T3.Latitude = 0 Then
                        If bateau.Position_T4.Latitude = 0 Then
                            If bateau.Position_T5.Latitude = 0 Then
                                If bateau.Position_T6.Latitude = 0 Then
                                    If bateau.Position_T7.Latitude = 0 Then
                                        If bateau.Position_T8.Latitude = 0 Then
                                            If bateau.Position_T9.Latitude = 0 Then
                                                bateau.Note = bateau.Note - 10
                                            Else
                                                bateau.Note = bateau.Note - 9
                                                position2 = bateau.Position_T9
                                            End If
                                        Else
                                            bateau.Note = bateau.Note - 8
                                            position2 = bateau.Position_T8
                                        End If
                                    Else
                                        bateau.Note = bateau.Note - 7
                                        position2 = bateau.Position_T7
                                    End If
                                Else
                                    bateau.Note = bateau.Note - 6
                                    position2 = bateau.Position_T6
                                End If
                            Else
                                bateau.Note = bateau.Note - 5
                                position2 = bateau.Position_T5
                            End If
                        Else
                            bateau.Note = bateau.Note - 4
                            position2 = bateau.Position_T4
                        End If
                    Else
                        bateau.Note = bateau.Note - 3
                        position2 = bateau.Position_T3
                    End If
                Else
                    bateau.Note = bateau.Note - 2
                    position2 = bateau.Position_T2
                End If
            Else
                bateau.Note = bateau.Note - 1
                position2 = bateau.Position_T1
            End If
        Else
            bateau.Note = bateau.Note - 0
            position2 = bateau.Position_actuelle
        End If
    End Function

    Public Sub affiche_tableau()
        Form2.Txt_titre.Text = "      MMSI        Vmoy      Route    Note    Nom"
        Form2.Txt_result.Text = ""
        Form5.Txt_titre.Text = "      MMSI        Vmoy      Route    Note    Nom"
        Form5.Txt_result.Text = ""

        '-------  TRI TABLEAU PAR ORDRE DECROISSANT DE VITESSES

        For i = 0 To nb_bateaux - 1
            affiche_bateau(i) = bateaux(i)
        Next i

        Dim Vmoy As String
        Dim route As String
        Dim note As String
        Dim Nom As String
        Dim temp As Integer


        tri_insertion(affiche_bateau, 1, nb_bateaux_connus)

        For i = nb_bateaux_connus + 1 To 0 Step -1

            Vmoy = Int(affiche_bateau(i).Vmoy * 100) / 100
            temp = Len(Vmoy)

            If temp < 4 Then
                For j = 1 To 4 - temp Step 1
                    Vmoy = Vmoy & "0"
                Next
            End If

            route = Int(affiche_bateau(i).Cmoy)
            temp = Len(route)
            If temp < 3 Then
                For j = 1 To 3 - temp Step 1
                    route = "0" & route
                Next
            End If

            note = Int(affiche_bateau(i).Note)
            temp = Len(note)
            If temp < 3 Then
                For j = 1 To 3 - temp Step 1
                    note = " " & note
                Next
            End If

            Nom = affiche_bateau(i).Nom_bateau
            temp = Len(Nom)
            If temp < 20 Then
                For j = 1 To 20 - temp Step 1
                    Nom = Nom & " "
                Next
            End If


            'Form2.Txt_result.Text = Form2.Txt_result.Text & vbCrLf & affiche_bateau(i).MMSI & " -  " & "      " & Int(affiche_bateau(i).Vmoy * 100) / 100 & "      " & Int(affiche_bateau(i).Cmoy) & "      " & affiche_bateau(i).Note & "       " & affiche_bateau(i).Nom_bateau
            Form2.Txt_result.Text = Form2.Txt_result.Text & vbCrLf & affiche_bateau(i).MMSI & " -  " & "      " & Vmoy & "      " & route & "      " & note & "       " & Nom


        Next i

        tri_insertion(affiche_bateau, nb_bateaux_connus + 3, nb_bateaux - 1)

        For i = nb_bateaux - 1 To nb_bateaux_connus + 2 Step -1

            Vmoy = Int(affiche_bateau(i).Vmoy * 100) / 100
            temp = Len(Vmoy)
            If temp < 4 Then
                For j = 1 To 4 - temp Step 1
                    Vmoy = Vmoy & "0"
                Next
            End If

            route = Int(affiche_bateau(i).Cmoy)
            temp = Len(route)
            If temp < 3 Then
                For j = 1 To 3 - temp Step 1
                    route = "0" & route
                Next
            End If

            note = Int(affiche_bateau(i).Note)
            temp = Len(note)
            If temp < 3 Then
                For j = 1 To 3 - temp Step 1
                    note = " " & note
                Next
            End If

            Nom = affiche_bateau(i).Nom_bateau
            temp = Len(Nom)
            If temp < 20 Then
                For j = 1 To 20 - temp Step 1
                    Nom = Nom & " "
                Next
            End If



            'Form5.Txt_result.Text = Form5.Txt_result.Text & vbCrLf & affiche_bateau(i).MMSI & " -  " & "      " & Int(affiche_bateau(i).Vmoy * 100) / 100 & "      " & Int(affiche_bateau(i).Cmoy) & "      " & affiche_bateau(i).Note & "       " & affiche_bateau(i).Nom_bateau
            Form5.Txt_result.Text = Form5.Txt_result.Text & vbCrLf & affiche_bateau(i).MMSI & " -  " & "      " & Vmoy & "      " & route & "      " & note & "       " & Nom


        Next i

    End Sub


End Module
