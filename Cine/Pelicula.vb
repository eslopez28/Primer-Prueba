Public Class Pelicula

    Private tituloDist As String
    Private tituloOrig As String
    Private idiomaOrig As String
    Private genero As String
    Private subt As String
    Private origen As String
    Private produccion As String
    Private url As String
    Private horas As Integer
    Private min As Integer
    Private clasificacion As String
    Private estreno As String
    Private idPelicula As Integer
    Private resumen As Resumen
    Private idResumen As Integer
    Private director As Persona
    Private idDIrector As Integer
    Private reparto As ArrayList


    Sub New(ptituloDist As String, ptituloOrig As String, pidiomaOrig As String, pgenero As String, psubt As String,
                        porigen As String, pproduccion As String, purl As String, phoras As Integer, pmin As Integer,
                        pclasificacion As String, pestreno As String, pidPelicula As Integer, pidResumen As Integer, pidDIrector As Integer)
        setTituloDist(ptituloDist)
        setTituloOrig(ptituloOrig)
        setIdiomaOrig(pidiomaOrig)
        setGenero(pgenero)
        setSubt(psubt)
        setOrigen(porigen)
        setProduccion(pproduccion)
        setUrl(purl)
        setHoras(phoras)
        setMin(pmin)
        setClasificacion(pclasificacion)
        setEstreno(pestreno)
        setIdPelicula(pidPelicula)
        setIdResumen(pidResumen)
        setIdDirector(pidResumen)
    End Sub

    Public Function setTituloDist(ptituloDist As String)
        tituloDist = ptituloDist
        Return Nothing
    End Function

    Public Function getTituloDist() As String
        Return tituloDist
    End Function

    Public Function setTituloOrig(ptituloOrig As String)
        tituloOrig = ptituloOrig
        Return Nothing
    End Function

    Public Function getTituloOrig() As String
        Return tituloOrig
    End Function

    Public Function setIdiomaOrig(pidiomaOrig As String)
        idiomaOrig = pidiomaOrig
        Return Nothing
    End Function

    Public Function getGenero() As String
        Return genero
    End Function

    Public Function setGenero(pgenero As String)
        genero = pgenero
        Return Nothing
    End Function

    Public Function getIdiomaOrig() As String
        Return idiomaOrig
    End Function

    Public Function setSubt(pSubt As String)
        subt = pSubt
        Return Nothing
    End Function

    Public Function getSubt() As String
        Return subt
    End Function

    Public Function setOrigen(porigen As String)
        origen = porigen
        Return Nothing
    End Function

    Public Function getOrigen() As String
        Return origen
    End Function

    Public Function setProduccion(pproduccion As String)
        produccion = pproduccion
        Return Nothing
    End Function

    Public Function getProduccion() As String
        Return produccion
    End Function

    Public Function setUrl(purl As String)
        url = purl
        Return Nothing
    End Function

    Public Function getUrl() As String
        Return url
    End Function

    Public Function setHoras(phoras As Integer)
        horas = phoras
        Return Nothing
    End Function

    Public Function getHoras() As Integer
        Return horas
    End Function

    Public Function setMin(pmin As Integer)
        min = pmin
        Return Nothing
    End Function

    Public Function getMin() As Integer
        Return min
    End Function

    Public Function setClasificacion(pclasificacion As String)
        clasificacion = pclasificacion
        Return Nothing
    End Function

    Public Function getClasificacion() As String
        Return clasificacion
    End Function

    Public Function setEstreno(pestreno As String)
        estreno = pestreno
        Return Nothing
    End Function

    Public Function getEstreno() As String
        Return estreno
    End Function

    Public Function setIdPelicula(pidPelicula As Integer)
        idPelicula = pidPelicula
        Return Nothing
    End Function

    Public Function getIdPelicula() As Integer
        Return idPelicula
    End Function

    Public Function setIdResumen(pidResumen As Integer)
        idResumen = pidResumen
        Return Nothing
    End Function

    Public Function getIdResumen() As Integer
        Return idResumen
    End Function

    Public Function setIdDirector(pidDirector As Integer)
        idDIrector = pidDirector
        Return Nothing
    End Function

    Public Function getIdDirector() As Integer
        Return idDIrector
    End Function

End Class
