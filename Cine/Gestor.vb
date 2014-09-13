Public Class Gestor

    Public Function setPelicula(ptituloDist As String, ptituloOrig As String, pidiomaOrig As String, pgenero As String, psubt As String,
                        porigen As String, pproduccion As String, purl As String, phoras As Integer, pmin As Integer,
                        pclasificacion As String, pestreno As String, pidResumen As Integer, pidDIrector As Integer)

        Return New MultiPelicula().setPelicua(New Pelicula(ptituloDist, ptituloOrig, pidiomaOrig, psubt, porigen, pgenero, pproduccion, purl, phoras, pmin,
                                                           pclasificacion, pestreno, 0, pidResumen, pidDIrector))
    End Function

    Public Function getPeliculas()

        Return New MultiPelicula().getPeliculas()
    End Function

    Public Function getPeliculaPorNombre(nombre As String)

        Return New MultiPelicula().getPeliculasPorNombre(nombre)
    End Function

    Public Function getPeliculasPorId(idPelicula As String)
        Return New MultiPelicula().getPeliculasPorId(idPelicula)
    End Function

End Class
