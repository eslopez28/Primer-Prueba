Public Class Sala

    Private idSala As Integer
    Private numSala As Integer
    Private butacas As Integer
    Private idCine As Integer
    Private Funciones As ArrayList

    Public Sub Sala(pidSala As Integer, pnumSala As Integer, pbutacas As Integer, pidCine As Integer)
        setIdSala(pidSala)
        setNumSala(pnumSala)
        setButacas(pbutacas)
        setIdCine(pidCine)
    End Sub

    Private Function setIdSala(pidSala As Integer)
        idSala = pidSala
        Return Nothing
    End Function

    Private Function setNumSala(pnumSala As Integer)
        numSala = pnumSala
        Return Nothing
    End Function

    Private Function setButacas(pbutacas As Integer)
        butacas = pbutacas
        Return Nothing
    End Function

    Private Function setIdCine(pidCine As Integer)
        idCine = pidCine
        Return Nothing
    End Function

    Private Function getIdSala() As Integer
        Return idSala
    End Function

    Private Function getNumSala() As Integer
        Return numSala
    End Function

    Private Function getButacas() As Integer
        Return butacas
    End Function

    Private Function getIdCine() As Integer
        Return idCine
    End Function

End Class
