
Public Class Bateau
    Public MMSI As String
    Public Nom_bateau As String
    Public Type_of_ship As String
    Public Position_actuelle As Position
    Public Position_T1 As Position
    Public Position_T2 As Position
    Public Position_T3 As Position
    Public Position_T4 As Position
    Public Position_T5 As Position
    Public Position_T6 As Position
    Public Position_T7 As Position
    Public Position_T8 As Position
    Public Position_T9 As Position
    Public Vmoy As Single
    Public Cmoy As Single
    Public Note As Single
End Class
Public Class Position
    Public Latitude As Double
    Public Longitude As Double
    Public heure As Date
    Public D_SOG As Single
    Public E_Position_Accuracy As Integer
    Public H_COG As Single
    Public K_Timestamp As Integer
End Class
Public Class AIS_Message
    Public A_Type_Message As String
    Public B_Repeat_Indicator As Integer
    Public C_MMSI As String
    Public D_SOG As Single
    Public E_Position_Accuracy As Integer
    Public F_Longitude As Single
    Public G_Latitude As Single
    Public H_COG As Single
    Public I_NAME As String
    Public J_Type_of_ship As Integer
    Public K_Timestamp As Integer
    Public L_HDG As Integer
    Public M_Receivedtime As Date
End Class