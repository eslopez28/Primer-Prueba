Public Class Mision


    Property nombre As String
    Property tripulantes As String
    Property fechaLanzamimento As String
    Property duracion As String
    Property datos As String
    Property nave As String
    Property destino As String
    Property foto As Byte()


    Public Sub New(ByVal pnombre As String, ptripulantes As String, pfechaLanzamiento As String, pduracion As String,
                   pdatos As String, pnave As String, pdestino As String, pfoto As Byte())
        nombre = pnombre
        tripulantes = ptripulantes
        fechaLanzamimento = pfechaLanzamiento
        duracion = pduracion
        datos = pdatos
        nave = pnave
        destino = pdestino
        foto = pfoto
    End Sub




End Class