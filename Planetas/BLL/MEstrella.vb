Imports EntitiesLayer
Imports DAL
Public Class MEstrella
    Sub agregarEstrella(pestrella As Estrella)
        Dim acceso As AccesoBD = New AccesoBD()

        Dim objParam As Parametro = New Parametro("nombre", pestrella.getNombre)
        Dim objParam2 As Parametro = New Parametro("masa", pestrella.getMasa)
        Dim objParam3 As Parametro = New Parametro("tempMedia", pestrella.getTempMedia)
        Dim objParam4 As Parametro = New Parametro("duracion", pestrella.getDuracDia)
        Dim objParam5 As Parametro = New Parametro("edad", pestrella.edad)
        Dim objParam6 As Parametro = New Parametro("composicion", pestrella.composicion)
        Dim objParam7 As Parametro = New Parametro("intensidad", pestrella.intensidadLuminica)
        Dim objParam8 As Parametro = New Parametro("tamano", pestrella.tamano)

        acceso.EjecutarSQL("pa_agregar_estrella", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6, objParam7, objParam8})
    End Sub

    Function listaEstrella() As DataTable
        Dim acceso As AccesoBD = New AccesoBD()

        Dim estrellas As DataTable
        Dim dsnombrePlanetas As DataSet
        dsnombrePlanetas = acceso.EjecutarSQL("pa_cons_listaEstrella", "estrellas")
        estrellas = dsnombrePlanetas.Tables("estrellas")

        Return estrellas
    End Function

End Class
