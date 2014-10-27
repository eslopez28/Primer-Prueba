Public Class CuerpoCeleste

    Private nombre As String
    Private masa As String
    Private tempMedia As String
    Private duracDia As String


    Public Sub New(ByVal pnombre As String, ByVal pmasa As String, ByVal ptempMedia As String, ByVal pduracDia As String)
        setNombre(pnombre)
        setMasa(pmasa)
        setTempMedia(ptempMedia)
        setDuracDia(pduracDia)
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function
    Private Sub setNombre(ByVal pnombre As String)
        nombre = pnombre
    End Sub

    Public Function getMasa() As String
        Return masa
    End Function
    Private Sub setMasa(ByVal pmasa As String)
        masa = pmasa
    End Sub
    Public Function getTempMedia() As String
        Return tempMedia
    End Function
    Private Sub setTempMedia(ByVal ptempMedia As String)
        tempMedia = ptempMedia
    End Sub
    Public Function getDuracDia() As String
        Return duracDia
    End Function
    Private Sub setDuracDia(ByVal pduracDia As String)
        duracDia = pduracDia
    End Sub

End Class
