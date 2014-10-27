Public Class Planeta
    Inherits CuerpoCeleste

    Private distMediaSol As String
    Private duracAnio As String


    Public Sub New(ByVal pnombre As String, ByVal pmasa As String, ByVal ptempMedia As String, ByVal pduracDia As String, ByVal pdistMediaSol As String, ByVal pduracAnio As String)
        MyBase.New(pnombre, pmasa, ptempMedia, pduracDia)

        setDistMediaSol(pdistMediaSol)
        setDuracAnio(pduracAnio)
    End Sub


    Public Function getDistMediaSol() As String
        Return distMediaSol
    End Function
    Private Sub setDistMediaSol(ByVal pdistMediaSol As String)
        distMediaSol = pdistMediaSol
    End Sub

    Public Function getDuracAnio() As String
        Return duracAnio
    End Function
    Private Sub setDuracAnio(ByVal pduracAnio As String)
        duracAnio = pduracAnio
    End Sub

End Class



