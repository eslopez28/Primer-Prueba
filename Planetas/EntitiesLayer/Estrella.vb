Public Class Estrella
    Inherits CuerpoCeleste

    Property edad As String
    Property composicion As String
    Property intensidadLuminica As String
    Property tamano As String


    Public Sub New(ByVal pnombre As String, ByVal pmasa As String, ByVal ptempMedia As String, ByVal pduracDia As String,
                   ByVal pedad As String, ByVal pcomposicion As String, ByVal pintensidad As String, ByVal ptamano As String)
        MyBase.New(pnombre, pmasa, ptempMedia, pduracDia)
        edad = pedad
        composicion = pcomposicion
        intensidadLuminica = pintensidad
        tamano = ptamano

    End Sub


   

End Class

