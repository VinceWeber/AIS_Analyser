Imports System.Math
Imports System.IO
Imports System.IO.File

Module M_Fonctions


    Public TABLE_CHAR_ASCII_BIN(63, 1) As String
    Public TABLE_CHAR_ASCII_BIN2(63, 1) As String
    Public Sub initialiser_table_ascii()
        TABLE_CHAR_ASCII_BIN(0, 0) = "000000"
        TABLE_CHAR_ASCII_BIN(1, 0) = "000001"
        TABLE_CHAR_ASCII_BIN(2, 0) = "000010"
        TABLE_CHAR_ASCII_BIN(3, 0) = "000011"
        TABLE_CHAR_ASCII_BIN(4, 0) = "000100"
        TABLE_CHAR_ASCII_BIN(5, 0) = "000101"
        TABLE_CHAR_ASCII_BIN(6, 0) = "000110"
        TABLE_CHAR_ASCII_BIN(7, 0) = "000111"
        TABLE_CHAR_ASCII_BIN(8, 0) = "001000"
        TABLE_CHAR_ASCII_BIN(9, 0) = "001001"
        TABLE_CHAR_ASCII_BIN(10, 0) = "001010"
        TABLE_CHAR_ASCII_BIN(11, 0) = "001011"
        TABLE_CHAR_ASCII_BIN(12, 0) = "001100"
        TABLE_CHAR_ASCII_BIN(13, 0) = "001101"
        TABLE_CHAR_ASCII_BIN(14, 0) = "001110"
        TABLE_CHAR_ASCII_BIN(15, 0) = "001111"
        TABLE_CHAR_ASCII_BIN(16, 0) = "010000"
        TABLE_CHAR_ASCII_BIN(17, 0) = "010001"
        TABLE_CHAR_ASCII_BIN(18, 0) = "010010"
        TABLE_CHAR_ASCII_BIN(19, 0) = "010011"
        TABLE_CHAR_ASCII_BIN(20, 0) = "010100"
        TABLE_CHAR_ASCII_BIN(21, 0) = "010101"
        TABLE_CHAR_ASCII_BIN(22, 0) = "010110"
        TABLE_CHAR_ASCII_BIN(23, 0) = "010111"
        TABLE_CHAR_ASCII_BIN(24, 0) = "011000"
        TABLE_CHAR_ASCII_BIN(25, 0) = "011001"
        TABLE_CHAR_ASCII_BIN(26, 0) = "011010"
        TABLE_CHAR_ASCII_BIN(27, 0) = "011011"
        TABLE_CHAR_ASCII_BIN(28, 0) = "011100"
        TABLE_CHAR_ASCII_BIN(29, 0) = "011101"
        TABLE_CHAR_ASCII_BIN(30, 0) = "011110"
        TABLE_CHAR_ASCII_BIN(31, 0) = "011111"
        TABLE_CHAR_ASCII_BIN(32, 0) = "100000"
        TABLE_CHAR_ASCII_BIN(33, 0) = "100001"
        TABLE_CHAR_ASCII_BIN(34, 0) = "100010"
        TABLE_CHAR_ASCII_BIN(35, 0) = "100011"
        TABLE_CHAR_ASCII_BIN(36, 0) = "100100"
        TABLE_CHAR_ASCII_BIN(37, 0) = "100101"
        TABLE_CHAR_ASCII_BIN(38, 0) = "100110"
        TABLE_CHAR_ASCII_BIN(39, 0) = "100111"
        TABLE_CHAR_ASCII_BIN(40, 0) = "101000"
        TABLE_CHAR_ASCII_BIN(41, 0) = "101001"
        TABLE_CHAR_ASCII_BIN(42, 0) = "101010"
        TABLE_CHAR_ASCII_BIN(43, 0) = "101011"
        TABLE_CHAR_ASCII_BIN(44, 0) = "101100"
        TABLE_CHAR_ASCII_BIN(45, 0) = "101101"
        TABLE_CHAR_ASCII_BIN(46, 0) = "101110"
        TABLE_CHAR_ASCII_BIN(47, 0) = "101111"
        TABLE_CHAR_ASCII_BIN(48, 0) = "110000"
        TABLE_CHAR_ASCII_BIN(49, 0) = "110001"
        TABLE_CHAR_ASCII_BIN(50, 0) = "110010"
        TABLE_CHAR_ASCII_BIN(51, 0) = "110011"
        TABLE_CHAR_ASCII_BIN(52, 0) = "110100"
        TABLE_CHAR_ASCII_BIN(53, 0) = "110101"
        TABLE_CHAR_ASCII_BIN(54, 0) = "110110"
        TABLE_CHAR_ASCII_BIN(55, 0) = "110111"
        TABLE_CHAR_ASCII_BIN(56, 0) = "111000"
        TABLE_CHAR_ASCII_BIN(57, 0) = "111001"
        TABLE_CHAR_ASCII_BIN(58, 0) = "111010"
        TABLE_CHAR_ASCII_BIN(59, 0) = "111011"
        TABLE_CHAR_ASCII_BIN(60, 0) = "111100"
        TABLE_CHAR_ASCII_BIN(61, 0) = "111101"
        TABLE_CHAR_ASCII_BIN(62, 0) = "111110"
        TABLE_CHAR_ASCII_BIN(63, 0) = "111111"
        TABLE_CHAR_ASCII_BIN(0, 1) = "0"
        TABLE_CHAR_ASCII_BIN(1, 1) = "1"
        TABLE_CHAR_ASCII_BIN(2, 1) = "2"
        TABLE_CHAR_ASCII_BIN(3, 1) = "3"
        TABLE_CHAR_ASCII_BIN(4, 1) = "4"
        TABLE_CHAR_ASCII_BIN(5, 1) = "5"
        TABLE_CHAR_ASCII_BIN(6, 1) = "6"
        TABLE_CHAR_ASCII_BIN(7, 1) = "7"
        TABLE_CHAR_ASCII_BIN(8, 1) = "8"
        TABLE_CHAR_ASCII_BIN(9, 1) = "9"
        TABLE_CHAR_ASCII_BIN(10, 1) = ":"
        TABLE_CHAR_ASCII_BIN(11, 1) = ";"
        TABLE_CHAR_ASCII_BIN(12, 1) = "<"
        TABLE_CHAR_ASCII_BIN(13, 1) = "="
        TABLE_CHAR_ASCII_BIN(14, 1) = ">"
        TABLE_CHAR_ASCII_BIN(15, 1) = "?"
        TABLE_CHAR_ASCII_BIN(16, 1) = "@"
        TABLE_CHAR_ASCII_BIN(17, 1) = "A"
        TABLE_CHAR_ASCII_BIN(18, 1) = "B"
        TABLE_CHAR_ASCII_BIN(19, 1) = "C"
        TABLE_CHAR_ASCII_BIN(20, 1) = "D"
        TABLE_CHAR_ASCII_BIN(21, 1) = "E"
        TABLE_CHAR_ASCII_BIN(22, 1) = "F"
        TABLE_CHAR_ASCII_BIN(23, 1) = "G"
        TABLE_CHAR_ASCII_BIN(24, 1) = "H"
        TABLE_CHAR_ASCII_BIN(25, 1) = "I"
        TABLE_CHAR_ASCII_BIN(26, 1) = "J"
        TABLE_CHAR_ASCII_BIN(27, 1) = "K"
        TABLE_CHAR_ASCII_BIN(28, 1) = "L"
        TABLE_CHAR_ASCII_BIN(29, 1) = "M"
        TABLE_CHAR_ASCII_BIN(30, 1) = "N"
        TABLE_CHAR_ASCII_BIN(31, 1) = "O"
        TABLE_CHAR_ASCII_BIN(32, 1) = "P"
        TABLE_CHAR_ASCII_BIN(33, 1) = "Q"
        TABLE_CHAR_ASCII_BIN(34, 1) = "R"
        TABLE_CHAR_ASCII_BIN(35, 1) = "S"
        TABLE_CHAR_ASCII_BIN(36, 1) = "T"
        TABLE_CHAR_ASCII_BIN(37, 1) = "U"
        TABLE_CHAR_ASCII_BIN(38, 1) = "V"
        TABLE_CHAR_ASCII_BIN(39, 1) = "W"
        TABLE_CHAR_ASCII_BIN(40, 1) = "`"
        TABLE_CHAR_ASCII_BIN(41, 1) = "a"
        TABLE_CHAR_ASCII_BIN(42, 1) = "b"
        TABLE_CHAR_ASCII_BIN(43, 1) = "c"
        TABLE_CHAR_ASCII_BIN(44, 1) = "d"
        TABLE_CHAR_ASCII_BIN(45, 1) = "e"
        TABLE_CHAR_ASCII_BIN(46, 1) = "f"
        TABLE_CHAR_ASCII_BIN(47, 1) = "g"
        TABLE_CHAR_ASCII_BIN(48, 1) = "h"
        TABLE_CHAR_ASCII_BIN(49, 1) = "i"
        TABLE_CHAR_ASCII_BIN(50, 1) = "j"
        TABLE_CHAR_ASCII_BIN(51, 1) = "k"
        TABLE_CHAR_ASCII_BIN(52, 1) = "l"
        TABLE_CHAR_ASCII_BIN(53, 1) = "m"
        TABLE_CHAR_ASCII_BIN(54, 1) = "n"
        TABLE_CHAR_ASCII_BIN(55, 1) = "o"
        TABLE_CHAR_ASCII_BIN(56, 1) = "p"
        TABLE_CHAR_ASCII_BIN(57, 1) = "q"
        TABLE_CHAR_ASCII_BIN(58, 1) = "r"
        TABLE_CHAR_ASCII_BIN(59, 1) = "s"
        TABLE_CHAR_ASCII_BIN(60, 1) = "t"
        TABLE_CHAR_ASCII_BIN(61, 1) = "u"
        TABLE_CHAR_ASCII_BIN(62, 1) = "v"
        TABLE_CHAR_ASCII_BIN(63, 1) = "w"

    End Sub
    Public Sub initialiser_table_ascii2()
        TABLE_CHAR_ASCII_BIN2(0, 0) = "000000"
        TABLE_CHAR_ASCII_BIN2(1, 0) = "000001"
        TABLE_CHAR_ASCII_BIN2(2, 0) = "000010"
        TABLE_CHAR_ASCII_BIN2(3, 0) = "000011"
        TABLE_CHAR_ASCII_BIN2(4, 0) = "000100"
        TABLE_CHAR_ASCII_BIN2(5, 0) = "000101"
        TABLE_CHAR_ASCII_BIN2(6, 0) = "000110"
        TABLE_CHAR_ASCII_BIN2(7, 0) = "000111"
        TABLE_CHAR_ASCII_BIN2(8, 0) = "001000"
        TABLE_CHAR_ASCII_BIN2(9, 0) = "001001"
        TABLE_CHAR_ASCII_BIN2(10, 0) = "001010"
        TABLE_CHAR_ASCII_BIN2(11, 0) = "001011"
        TABLE_CHAR_ASCII_BIN2(12, 0) = "001100"
        TABLE_CHAR_ASCII_BIN2(13, 0) = "001101"
        TABLE_CHAR_ASCII_BIN2(14, 0) = "001110"
        TABLE_CHAR_ASCII_BIN2(15, 0) = "001111"
        TABLE_CHAR_ASCII_BIN2(16, 0) = "010000"
        TABLE_CHAR_ASCII_BIN2(17, 0) = "010001"
        TABLE_CHAR_ASCII_BIN2(18, 0) = "010010"
        TABLE_CHAR_ASCII_BIN2(19, 0) = "010011"
        TABLE_CHAR_ASCII_BIN2(20, 0) = "010100"
        TABLE_CHAR_ASCII_BIN2(21, 0) = "010101"
        TABLE_CHAR_ASCII_BIN2(22, 0) = "010110"
        TABLE_CHAR_ASCII_BIN2(23, 0) = "010111"
        TABLE_CHAR_ASCII_BIN2(24, 0) = "011000"
        TABLE_CHAR_ASCII_BIN2(25, 0) = "011001"
        TABLE_CHAR_ASCII_BIN2(26, 0) = "011010"
        TABLE_CHAR_ASCII_BIN2(27, 0) = "011011"
        TABLE_CHAR_ASCII_BIN2(28, 0) = "011100"
        TABLE_CHAR_ASCII_BIN2(29, 0) = "011101"
        TABLE_CHAR_ASCII_BIN2(30, 0) = "011110"
        TABLE_CHAR_ASCII_BIN2(31, 0) = "011111"
        TABLE_CHAR_ASCII_BIN2(32, 0) = "100000"
        TABLE_CHAR_ASCII_BIN2(33, 0) = "100001"
        TABLE_CHAR_ASCII_BIN2(34, 0) = "100010"
        TABLE_CHAR_ASCII_BIN2(35, 0) = "100011"
        TABLE_CHAR_ASCII_BIN2(36, 0) = "100100"
        TABLE_CHAR_ASCII_BIN2(37, 0) = "100101"
        TABLE_CHAR_ASCII_BIN2(38, 0) = "100110"
        TABLE_CHAR_ASCII_BIN2(39, 0) = "100111"
        TABLE_CHAR_ASCII_BIN2(40, 0) = "101000"
        TABLE_CHAR_ASCII_BIN2(41, 0) = "101001"
        TABLE_CHAR_ASCII_BIN2(42, 0) = "101010"
        TABLE_CHAR_ASCII_BIN2(43, 0) = "101011"
        TABLE_CHAR_ASCII_BIN2(44, 0) = "101100"
        TABLE_CHAR_ASCII_BIN2(45, 0) = "101101"
        TABLE_CHAR_ASCII_BIN2(46, 0) = "101110"
        TABLE_CHAR_ASCII_BIN2(47, 0) = "101111"
        TABLE_CHAR_ASCII_BIN2(48, 0) = "110000"
        TABLE_CHAR_ASCII_BIN2(49, 0) = "110001"
        TABLE_CHAR_ASCII_BIN2(50, 0) = "110010"
        TABLE_CHAR_ASCII_BIN2(51, 0) = "110011"
        TABLE_CHAR_ASCII_BIN2(52, 0) = "110100"
        TABLE_CHAR_ASCII_BIN2(53, 0) = "110101"
        TABLE_CHAR_ASCII_BIN2(54, 0) = "110110"
        TABLE_CHAR_ASCII_BIN2(55, 0) = "110111"
        TABLE_CHAR_ASCII_BIN2(56, 0) = "111000"
        TABLE_CHAR_ASCII_BIN2(57, 0) = "111001"
        TABLE_CHAR_ASCII_BIN2(58, 0) = "111010"
        TABLE_CHAR_ASCII_BIN2(59, 0) = "111011"
        TABLE_CHAR_ASCII_BIN2(60, 0) = "111100"
        TABLE_CHAR_ASCII_BIN2(61, 0) = "111101"
        TABLE_CHAR_ASCII_BIN2(62, 0) = "111110"
        TABLE_CHAR_ASCII_BIN2(63, 0) = "111111"

        TABLE_CHAR_ASCII_BIN2(0, 1) = "@"
        TABLE_CHAR_ASCII_BIN2(1, 1) = "A"
        TABLE_CHAR_ASCII_BIN2(2, 1) = "B"
        TABLE_CHAR_ASCII_BIN2(3, 1) = "C"
        TABLE_CHAR_ASCII_BIN2(4, 1) = "D"
        TABLE_CHAR_ASCII_BIN2(5, 1) = "E"
        TABLE_CHAR_ASCII_BIN2(6, 1) = "F"
        TABLE_CHAR_ASCII_BIN2(7, 1) = "G"
        TABLE_CHAR_ASCII_BIN2(8, 1) = "H"
        TABLE_CHAR_ASCII_BIN2(9, 1) = "I"
        TABLE_CHAR_ASCII_BIN2(10, 1) = "J"
        TABLE_CHAR_ASCII_BIN2(11, 1) = "K"
        TABLE_CHAR_ASCII_BIN2(12, 1) = "L"
        TABLE_CHAR_ASCII_BIN2(13, 1) = "M"
        TABLE_CHAR_ASCII_BIN2(14, 1) = "N"
        TABLE_CHAR_ASCII_BIN2(15, 1) = "O"
        TABLE_CHAR_ASCII_BIN2(16, 1) = "P"
        TABLE_CHAR_ASCII_BIN2(17, 1) = "Q"
        TABLE_CHAR_ASCII_BIN2(18, 1) = "R"
        TABLE_CHAR_ASCII_BIN2(19, 1) = "S"
        TABLE_CHAR_ASCII_BIN2(20, 1) = "T"
        TABLE_CHAR_ASCII_BIN2(21, 1) = "U"
        TABLE_CHAR_ASCII_BIN2(22, 1) = "V"
        TABLE_CHAR_ASCII_BIN2(23, 1) = "W"
        TABLE_CHAR_ASCII_BIN2(24, 1) = "X"
        TABLE_CHAR_ASCII_BIN2(25, 1) = "Y"
        TABLE_CHAR_ASCII_BIN2(26, 1) = "Z"
        TABLE_CHAR_ASCII_BIN2(27, 1) = "["
        TABLE_CHAR_ASCII_BIN2(28, 1) = "\"
        TABLE_CHAR_ASCII_BIN2(29, 1) = "]"
        TABLE_CHAR_ASCII_BIN2(30, 1) = "\^"
        TABLE_CHAR_ASCII_BIN2(31, 1) = "\_"
        TABLE_CHAR_ASCII_BIN2(32, 1) = " "
        TABLE_CHAR_ASCII_BIN2(33, 1) = "!"
        TABLE_CHAR_ASCII_BIN2(34, 1) = """"
        TABLE_CHAR_ASCII_BIN2(35, 1) = "\#"
        TABLE_CHAR_ASCII_BIN2(36, 1) = "$"
        TABLE_CHAR_ASCII_BIN2(37, 1) = "%"
        TABLE_CHAR_ASCII_BIN2(38, 1) = "&"
        TABLE_CHAR_ASCII_BIN2(39, 1) = "\'"
        TABLE_CHAR_ASCII_BIN2(40, 1) = "("
        TABLE_CHAR_ASCII_BIN2(41, 1) = ")"
        TABLE_CHAR_ASCII_BIN2(42, 1) = "\*"
        TABLE_CHAR_ASCII_BIN2(43, 1) = "\+"
        TABLE_CHAR_ASCII_BIN2(44, 1) = ","
        TABLE_CHAR_ASCII_BIN2(45, 1) = "-"
        TABLE_CHAR_ASCII_BIN2(46, 1) = "."
        TABLE_CHAR_ASCII_BIN2(47, 1) = "/"
        TABLE_CHAR_ASCII_BIN2(48, 1) = "0"
        TABLE_CHAR_ASCII_BIN2(49, 1) = "1"
        TABLE_CHAR_ASCII_BIN2(50, 1) = "2"
        TABLE_CHAR_ASCII_BIN2(51, 1) = "3"
        TABLE_CHAR_ASCII_BIN2(52, 1) = "4"
        TABLE_CHAR_ASCII_BIN2(53, 1) = "5"
        TABLE_CHAR_ASCII_BIN2(54, 1) = "6"
        TABLE_CHAR_ASCII_BIN2(55, 1) = "7"
        TABLE_CHAR_ASCII_BIN2(56, 1) = "8"
        TABLE_CHAR_ASCII_BIN2(57, 1) = "9"
        TABLE_CHAR_ASCII_BIN2(58, 1) = ":"
        TABLE_CHAR_ASCII_BIN2(59, 1) = ";"
        TABLE_CHAR_ASCII_BIN2(60, 1) = "<"
        TABLE_CHAR_ASCII_BIN2(61, 1) = "="
        TABLE_CHAR_ASCII_BIN2(62, 1) = ">"
        TABLE_CHAR_ASCII_BIN2(63, 1) = "?"


    End Sub
    Public Sub initialiser_bateaux_connus()

        Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog
        Dim nomFichier As String
        Dim AIS_fichier(100) As AIS_Message
        For i = 0 To 100 Step 1
            AIS_fichier(i) = New AIS_Message
        Next i


        If Exists("D:\MMSI.txt") Then
            lecture_fichier_config("D:\MMSI.txt", AIS_fichier, nb_bateaux_connus)

        Else
            If MsgBox("Voulez vous charger des MMSI connus ?", vbYesNo, "Confirm") = vbYes Then
                With OpenFileDialog1
                    'On spécifie l'extension de fichiers visibles
                    .Filter = "Fichiers texte (*.txt) | *.txt"
                    'On affiche et teste le retour du dialogue
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        'On récupère le nom du fichier
                        nomFichier = .FileName
                    End If
                    lecture_fichier_config(nomFichier, AIS_fichier, nb_bateaux_connus)

                End With
            Else
                MsgBox("Aucun MMSI connu chargé")

                nb_bateaux_connus = 0

                AIS_fichier(0).C_MMSI = "---------"
                AIS_fichier(1).C_MMSI = "---------"

                AIS_fichier(0).I_NAME = "------------"
                AIS_fichier(1).I_NAME = "------------"


            End If

        End If

        For i = 0 To nb_bateaux_connus + 1 Step 1
            Nouveau_bateau(AIS_fichier(i), nb_bateaux)
        Next i

        For j = 0 To 200 Step 1
            affiche_bateau(j) = New Bateau
            affiche_bateau(j).Position_actuelle = New Position
            affiche_bateau(j).Position_T1 = New Position
            affiche_bateau(j).Position_T2 = New Position
            affiche_bateau(j).Position_T3 = New Position
            affiche_bateau(j).Position_T4 = New Position
            affiche_bateau(j).Position_T5 = New Position
            affiche_bateau(j).Position_T6 = New Position
            affiche_bateau(j).Position_T7 = New Position
            affiche_bateau(j).Position_T8 = New Position
            affiche_bateau(j).Position_T9 = New Position
        Next j

    End Sub
    Public Sub lecture_fichier_config(ByVal chemin As String, ByRef ais_fichier() As AIS_Message, ByRef Nb_bateaux_connus As Integer)

        Dim nbr_ligne As Integer = 0
        Dim ligne As String
        Dim sr As New StreamReader(chemin)
        While sr.Peek <> -1
            nbr_ligne += 1
            ligne = sr.ReadLine()

            ais_fichier(nbr_ligne - 1) = decompose_ligne(ligne)

        End While
        Nb_bateaux_connus = nbr_ligne - 2

        MsgBox(nbr_ligne - 2 & " MMSI enregistrés")

    End Sub
    Public Function decompose_ligne(ByVal Chaine As String)

        Dim lg_chaine As Integer
        Dim chr_fin, chr_sep As String
        Dim bateau As AIS_Message

        bateau = New AIS_Message

        lg_chaine = Len(Chaine)

        chr_fin = Chr(13)
        chr_sep = ";"

        For i = 1 To lg_chaine
            If Mid(Chaine, i, 1) = chr_sep Then
                bateau.C_MMSI = Mid(Chaine, 1, i - 1)
                bateau.I_NAME = Mid(Chaine, i + 1)
            End If
        Next i

        decompose_ligne = bateau

    End Function

    Public Function GetChecksum(ByVal sentence As String) As String
        Dim Character As Char
        Dim Checksum As Integer
        For Each Character In sentence
            If Checksum = 0 Then
                Checksum = Convert.ToByte(Character)
            Else
                Checksum = Checksum Xor Convert.ToByte(Character)
            End If
        Next
        Return Checksum.ToString("X2")
    End Function
    Public Function DecToBin(ByVal DecNum As String, ByVal BinLength As String) As String
        Dim BinNum As String = ""
        Dim lDecNum As Long
        Dim i As Integer
        i = 0
        lDecNum = Val(DecNum)
        Do
            If lDecNum And 2 ^ i Then
                BinNum = "1" & BinNum
            Else
                BinNum = "0" & BinNum
            End If
            i = i + 1
        Loop Until i = BinLength
        DecToBin = BinNum
    End Function
    Public Function BinToDec(ByVal BinNum As String) As String
        Dim i As Integer
        Dim DecNum As Long
        For i = Len(BinNum) To 1 Step -1
            If Mid(BinNum, i, 1) And 1 Then
                DecNum = DecNum + 2 ^ (Len(BinNum) - i)
            End If
        Next i
        BinToDec = DecNum
    End Function
    Public Sub hbwait(ByVal ms_to_wait As Long)
        Dim endwait As Double
        endwait = Environment.TickCount + ms_to_wait
        While Environment.TickCount < endwait
            System.Threading.Thread.Sleep(1)
            Application.DoEvents()
        End While
    End Sub
    Public Function payloadtoBin(ByVal Payload As String) As String
        Dim i As Integer
        Dim incode As String
        Dim bin As String = ""
        payloadtoBin = ""

        For i = 1 To Len(Payload) Step 1
            incode = Mid(Payload, i, 1)
            bin = bin & chartobin(incode)
        Next
        payloadtoBin = bin
    End Function
    Public Function chartobin(ByVal caractere As String) As String
        Dim found As Boolean = False
        Dim bin As String = "Charnotfound"
        Dim i As Integer = 0

        Do While found = False And i <= 63
            If TABLE_CHAR_ASCII_BIN(i, 1) = caractere Then
                bin = TABLE_CHAR_ASCII_BIN(i, 0)
                found = True
            End If
            i = i + 1
        Loop
        chartobin = bin
    End Function
    Public Function bintochar(ByVal bin As String) As String
        Dim found As Boolean = False
        Dim Name As String = ""
        Dim caractere As String = ""
        Dim i As Integer = 0

        For j = 1 To Len(bin) Step 6
            Do While found = False And i <= 63
                If TABLE_CHAR_ASCII_BIN2(i, 0) = Mid(bin, j, 6) Then
                    caractere = TABLE_CHAR_ASCII_BIN2(i, 1)
                    If caractere = "@" Then caractere = ""
                    found = True
                End If
                i = i + 1
            Loop
            found = False
            i = 0
            Name = Name & caractere
        Next

        If Name = "@@@@@@@@@@@@@@@@@@@" Then Name = ""
        bintochar = Name
    End Function
    Public Function twocompplement(ByVal bin As String) As String
        twocompplement = ""
        For i = 1 To Len(bin) Step 1
            If Mid(bin, i, 1) = 0 Then
                twocompplement = twocompplement & "1"
            Else
                twocompplement = twocompplement & "0"
            End If
        Next
    End Function
    Public Function toHex(ByVal s As String)
        'Converts a binary string to base 16
        Dim sResult As String
        Dim nCnt As Integer
        For nCnt = 1 To Len(s)
            sResult = sResult & Right("00" & Hex(Asc(Mid(s, nCnt, 1))), 2)
        Next
        toHex = sResult
    End Function
    Public Function toBinary(ByVal s As String)
        'Converts hex pairs to binary
        Dim sResult As String
        Dim nCnt As Integer
        For nCnt = 1 To Len(s) Step 2
            sResult = sResult & Chr(Val("&H" & Mid(s, nCnt, 2)))
        Next
        toBinary = sResult
    End Function
    Public Sub decale_positions()
        Dim i As Integer

        For i = 0 To nb_bateaux - 1 Step 1

            bateaux(i).Position_T9 = bateaux(i).Position_T8
            bateaux(i).Position_T8 = bateaux(i).Position_T7
            bateaux(i).Position_T7 = bateaux(i).Position_T6
            bateaux(i).Position_T6 = bateaux(i).Position_T5
            bateaux(i).Position_T5 = bateaux(i).Position_T4
            bateaux(i).Position_T4 = bateaux(i).Position_T3
            bateaux(i).Position_T3 = bateaux(i).Position_T2
            bateaux(i).Position_T2 = bateaux(i).Position_T1
            bateaux(i).Position_T1 = bateaux(i).Position_actuelle

        Next


    End Sub
    Public Sub tri_insertion(ByRef Tableau() As Bateau, ByVal B_inf As Integer, ByVal B_Sup As Integer)
        Dim i, j As Integer
        Dim Tampon As Bateau
        Tampon = New Bateau
        Tampon.Position_actuelle = New Position
        Tampon.Position_T1 = New Position
        Tampon.Position_T2 = New Position
        Tampon.Position_T3 = New Position
        Tampon.Position_T3 = New Position
        Tampon.Position_T4 = New Position
        Tampon.Position_T5 = New Position
        Tampon.Position_T6 = New Position
        Tampon.Position_T7 = New Position
        Tampon.Position_T8 = New Position
        Tampon.Position_T9 = New Position

        For i = B_inf To B_Sup Step 1
            Tampon = Tableau(i)
            j = i
            Do While j >= B_inf And Tableau(j - 1).Vmoy > Tampon.Vmoy
                Tableau(j) = Tableau(j - 1)
                j = j - 1
            Loop
            Tableau(j) = Tampon
        Next i


    End Sub

End Module
