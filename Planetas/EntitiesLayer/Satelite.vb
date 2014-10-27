Public Class Satelite
    Inherits CuerpoCeleste

    Property distancia As String
    Property caracteristica As String
    Property planeta As String
    Property tamano As String


    Public Sub New(ByVal pnombre As String, ByVal pmasa As String, ByVal ptempMedia As String, ByVal pduracDia As String,
                   ByVal pdistancia As String, ByVal pcaracteritica As String, ByVal pplaneta As String)
        MyBase.New(pnombre, pmasa, ptempMedia, pduracDia)
        distancia = pdistancia
        caracteristica = pcaracteritica
        planeta = pplaneta


    End Sub




End Class
