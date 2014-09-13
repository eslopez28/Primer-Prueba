Public Class Comentario
    Private nombre As String
    Private edad As Integer
    Private calificacion As String
    Private comentarioPelicula As String
    Private fecha As Date
    Private idComentario As Integer
    Private idResumen As Integer

    Public Sub Comentario(pnombre As String, pedad As Integer, pcalificacion As String, pcomentarioPelicula As String,
                          pfecha As Date, pidComentario As Integer, pidResumen As Integer)
        setNombre(pnombre)
        setEdad(pedad)
        setCalificacion(pcalificacion)
        setComentarioPelicula(pcomentarioPelicula)
        setFecha(pfecha)
        setIdComentario(pidComentario)
        setIdResumen(pidResumen)
    End Sub

    Public Function setNombre(pnombre As String)
        nombre = pnombre
        Return Nothing
    End Function

    Public Function setEdad(pedad As Integer)
        edad = pedad
        Return Nothing
    End Function

    Public Function setCalificacion(pcalificacion As String)
        calificacion = pcalificacion
        Return Nothing
    End Function

    Public Function setComentarioPelicula(pcomentarioPelicula As String)
        comentarioPelicula = pcomentarioPelicula
        Return Nothing
    End Function

    Public Function setFecha(pfecha As Date)
        fecha = pfecha
        Return Nothing
    End Function

    Public Function setIdComentario(pidComentario As Integer)
        idComentario = pidComentario
        Return Nothing
    End Function

    Public Function setIdResumen(pidResumen As Integer)
        idResumen = pidResumen
        Return Nothing
    End Function

    Public Function getNombre(pnombre As String)
        Return nombre
    End Function

    Public Function getEdad() As Integer
        Return edad
    End Function

    Public Function getCalificacion() As String
        Return calificacion
    End Function

    Public Function getComentarioPelicula() As String
        Return comentarioPelicula
    End Function

    Public Function getFecha() As Date
        Return fecha
    End Function

    Public Function getIdComentario() As Integer
        Return idComentario
    End Function

    Public Function getIdResumen() As Integer
        Return idResumen
    End Function

End Class
