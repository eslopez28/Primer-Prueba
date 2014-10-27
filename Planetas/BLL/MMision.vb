Imports DAL
Imports EntitiesLayer
Public Class MMision

    Sub agregarMision(ByRef pmision As Mision)

        Dim acceso As AccesoBD = New AccesoBD()

        Dim objParam As Parametro = New Parametro("nombre", pmision.nombre)
        Dim objParam2 As Parametro = New Parametro("tripulantes", pmision.tripulantes)
        Dim objParam3 As Parametro = New Parametro("fecha_lanzamiento", pmision.fechaLanzamimento)
        Dim objParam4 As Parametro = New Parametro("duracion", pmision.duracion)
        Dim objParam5 As Parametro = New Parametro("datos", pmision.datos)
        Dim objParam6 As Parametro = New Parametro("nave", pmision.nave)
        Dim objParam7 As Parametro = New Parametro("destino", pmision.destino)
        Dim objParam8 As Parametro = New Parametro("foto", pmision.foto)


        acceso.EjecutarSQL("pa_agregar_mision", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6, objParam7, objParam8})
    End Sub

    Function listaMisiones() As DataTable
        Dim acceso As AccesoBD = New AccesoBD()

        Dim misiones As DataTable
        Dim dsnombreMisiones As DataSet
        dsnombreMisiones = acceso.EjecutarSQL("pa_cons_listaMisiones", "misiones")
        misiones = dsnombreMisiones.Tables("misiones")

        Return misiones
    End Function

    
End Class
