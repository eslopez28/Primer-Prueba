Imports DAL
Imports EntitiesLayer

Public Class MSatelite
    Sub agregarSatelite(ByRef psatelite As Satelite)

        Dim acceso As AccesoBD = New AccesoBD()

        Dim objParam As Parametro = New Parametro("nombre", psatelite.getNombre)
        Dim objParam2 As Parametro = New Parametro("fechaInicio", psatelite.getMasa)
        Dim objParam3 As Parametro = New Parametro("fechaFinal", psatelite.getTempMedia)
        Dim objParam4 As Parametro = New Parametro("duracion", psatelite.getDuracDia)
        Dim objParam5 As Parametro = New Parametro("distancia", psatelite.distancia)
        Dim objParam6 As Parametro = New Parametro("caracteristica", psatelite.caracteristica)
        Dim objParam7 As Parametro = New Parametro("planeta", psatelite.planeta)


        acceso.EjecutarSQL("pa_agregar_satelite", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6, objParam7})
    End Sub

    Function listaSatelites() As DataTable
        Dim acceso As AccesoBD = New AccesoBD()

        Dim satelites As DataTable
        Dim dsnombreSatelites As DataSet
        dsnombreSatelites = acceso.EjecutarSQL("pa_cons_listaSatelites", "satelites")
        satelites = dsnombreSatelites.Tables("satelites")

        Return satelites
    End Function

End Class
