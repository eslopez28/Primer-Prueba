Imports EntitiesLayer
Imports DAL
Public Class MPlaneta

    Sub agregarPlaneta(ByRef pplaneta As Planeta)

        Dim acceso As AccesoBD = New AccesoBD()

        Dim objParam As Parametro = New Parametro("nombre", pplaneta.getNombre)
        Dim objParam2 As Parametro = New Parametro("fechaInicio", pplaneta.getMasa)
        Dim objParam3 As Parametro = New Parametro("fechaFinal", pplaneta.getTempMedia)
        Dim objParam4 As Parametro = New Parametro("duracion", pplaneta.getDuracDia)
        Dim objParam5 As Parametro = New Parametro("distanciaMedia", pplaneta.getDistMediaSol)
        Dim objParam6 As Parametro = New Parametro("duracionAnio", pplaneta.getDuracAnio)
       

        acceso.EjecutarSQL("pa_agregar_planeta", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6})
    End Sub

    Public Function consultarNombrePlanetas() As DataTable
        Dim acceso As AccesoBD = New AccesoBD()

        Dim nombrePlanetas As DataTable
        Dim dsnombrePlanetas As DataSet
        dsnombrePlanetas = acceso.EjecutarSQL("pa_cons_nombrePlanetas", "nombre")
        nombrePlanetas = dsnombrePlanetas.Tables("nombre")

        Return nombrePlanetas
    End Function

    Function listaPlanetas() As DataTable
        Dim acceso As AccesoBD = New AccesoBD()

        Dim planetas As DataTable
        Dim dsnombrePlanetas As DataSet
        dsnombrePlanetas = acceso.EjecutarSQL("pa_cons_listaPlanetas", "planetas")
        planetas = dsnombrePlanetas.Tables("planetas")

        Return planetas
    End Function

End Class
