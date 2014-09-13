Public Class Funciones

    Private dia As String
    Private hora As String
    Private idSala As Integer
    Private idPelicula As Integer
    Private pelicula As Pelicula

    Public Sub Funciones(pdia As String, phora As String, pidPelicula As Integer, pidSala As Integer)
        setDia(pdia)
        setHora(phora)
        setIdPelicula(pidPelicula)
        setIdSala(pidSala)
    End Sub

    Private Function setDia(pdia As String)
        dia = pdia
        Return Nothing
    End Function

    Private Function setHora(phora As String)
        hora = phora
        Return Nothing
    End Function

    Private Function getDia()
        Return dia
    End Function

    Private Function getHora()
        Return hora
    End Function

    Private Function setIdPelicula(pidPelicula As Integer)
        idPelicula = pidPelicula
        Return Nothing
    End Function

    Private Function setIdSala(pidSala As Integer)
        idSala = pidSala
        Return Nothing
    End Function

    Private Function getIdPelicula() As Integer
        Return idPelicula
    End Function

    Private Function getIdSala() As Integer
        Return idSala
    End Function
End Class
