Imports EntitiesLayer
Imports DAL

Public Class Gestor

    Dim mprograma As MPrograma = New MPrograma
    Dim mplaneta As MPlaneta = New MPlaneta
    Dim mestrella As MEstrella = New MEstrella
    Dim msatelite As MSatelite = New MSatelite
    Dim mmision As MMision = New MMision

    Sub agregarPrograma(nombreProg As String, fechaInicio As String, fechaFinal As String, alcance As String)
        Dim objPrograma As ProgramaEspacial = New ProgramaEspacial(nombreProg, fechaInicio, fechaFinal, alcance)
        mprograma.agregarPrograma(objPrograma)
    End Sub
    Sub agregarPlaneta(ByVal pnombre As String, ByVal pmasa As String, ByVal ptempMedia As String, ByVal pduracDia As String, ByVal pdistMediaSol As String, ByVal pduracAnio As String)
        Dim objPlaneta As Planeta = New Planeta(pnombre, pmasa, ptempMedia, pduracDia, pdistMediaSol, pduracAnio)
        mplaneta.agregarPlaneta(objPlaneta)
    End Sub
    Sub agregarEstrella(ByVal pnombre As String, ByVal pmasa As String, ByVal ptempMedia As String, ByVal pduracDia As String,
                   ByVal pedad As String, ByVal pcomposicion As String, ByVal pintensidad As String, ByVal ptamano As String)
        Dim objEstrella As Estrella = New Estrella(pnombre, pmasa, ptempMedia, pduracDia, pedad, pcomposicion, pintensidad, ptamano)
        mestrella.agregarEstrella(objEstrella)
    End Sub

   

    Sub agregarSatelite(ByVal pnombre As String, pmasa As String,
                        ByVal ptempMedia As String, ByVal pduracion As String, ByVal pdistancia As String, ByVal pcaracteristica As String, ByVal pplaneta As String)
        Dim objSatelite As Satelite = New Satelite(pnombre, pmasa, ptempMedia, pduracion, pdistancia, pcaracteristica, pplaneta)
        msatelite.agregarSatelite(objSatelite)
    End Sub


    Function listarNombresProgramas() As DataTable
        Dim lista As DataTable = mplaneta.consultarNombrePlanetas()
        Return lista

    End Function

    Function listaProgramas() As DataTable
        Dim lista As DataTable = mprograma.listaProgramas()

        Return lista
    End Function

    Function listaEstrellas() As DataTable
        Dim lista As DataTable = mestrella.listaEstrella()
        Return lista
    End Function

    Sub agregarMision(nombre As String, tripulantes As String, fechaLanzamiento As String, duracTiempo As String, datosInteres As String, nave As String, cuerpoDestino As String, arrInsignia As Byte())
        Dim objMision As Mision = New Mision(nombre, tripulantes, fechaLanzamiento, duracTiempo,
                                             datosInteres, nave, cuerpoDestino, arrInsignia)
        mmision.agregarMision(objMision)

    End Sub

    Function listaPlanetas() As DataTable
        Dim lista As DataTable = mplaneta.listaPlanetas()
        Return lista
    End Function

    Function listarMisiones() As DataTable
        Dim lista As DataTable = mmision.listaMisiones()
        Return lista
    End Function

    Function listarSatelite() As DataTable
        Dim lista As DataTable = msatelite.listaSatelites()
        Return lista
    End Function

    

End Class
