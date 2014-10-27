Public Class ProgramaEspacial
    Property nombrePrograma As String
    Property fechaInicio As String
    Property fechaFinal As String
    
    Property alcance As String




    Sub New(ByVal pnombre As String, ByVal pfechaInicio As String, ByVal pfechaFinal As String,
           ByVal palcance As String)
        nombrePrograma = pnombre
        fechaInicio = pfechaInicio
        fechaFinal = pfechaFinal
        alcance = palcance

    End Sub

End Class
