Imports DAL
Imports EntitiesLayer
Imports System.Data.SqlClient
Imports System.Collections.Generic
Public Class MPrograma
    Sub agregarPrograma(pprograma As ProgramaEspacial)
        Dim acceso As AccesoBD = New AccesoBD()

        Dim objParam As Parametro = New Parametro("nombre", pprograma.nombrePrograma)
        Dim objParam2 As Parametro = New Parametro("fechaInicio", pprograma.fechaInicio)
        Dim objParam3 As Parametro = New Parametro("fechaFinal", pprograma.fechaFinal)
        Dim objParam4 As Parametro = New Parametro("alcance", pprograma.alcance)

        acceso.EjecutarSQL("pa_agregar_programa", New Parametro() {objParam, objParam2, objParam3, objParam4})
    End Sub

    Function listaProgramas() As DataTable
        Dim acceso As AccesoBD = New AccesoBD()

        Dim programas As DataTable
        Dim dsnombrePlanetas As DataSet
        dsnombrePlanetas = acceso.EjecutarSQL("pa_cons_listaProgramas", "programas")
        programas = dsnombrePlanetas.Tables("programas")

        Return programas
    End Function

End Class
