Public Class Resumen

    Private idResumen As Integer
    Private resumenPelicula As String
    Private listaComentario As ArrayList
    Public Sub Resumen(pidResumen As Integer, presumenPelicula As String)
        setIdResumen(pidResumen)
        setResumenPelicula(presumenPelicula)
    End Sub

    Public Function setIdResumen(pidResumen As Integer)
        idResumen = pidResumen
        Return Nothing
    End Function

    Public Function getIdResumen() As Integer
        Return idResumen
    End Function

    Public Function setResumenPelicula(presumenPelicula As String)
        resumenPelicula = presumenPelicula
        Return Nothing
    End Function

    Public Function getResumenPelicula() As String
        Return resumenPelicula
    End Function

End Class
