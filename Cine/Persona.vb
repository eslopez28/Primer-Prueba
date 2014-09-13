Public Class Persona

    Private nombre As String
    Private nacionalidad As String
    Private cantPelis As Integer
    Private idPersona As Integer
    Private roles As ArrayList

    Public Sub Persona(pnombre As String, pnacionalidad As String, pcantPelis As Integer, pidPersona As Integer)
        setNombre(pnombre)
        setNacionalidad(pnacionalidad)
        setCantPelis(pcantPelis)
        setIdPersona(pidPersona)
    End Sub

    Public Function setNombre(pnombre As String)
        nombre = pnombre
        Return Nothing
    End Function

    Public Function setNacionalidad(pnacionalidad As String)
        nacionalidad = pnacionalidad
        Return Nothing
    End Function

    Public Function setCantPelis(pcantPelis As Integer)
        cantPelis = cantPelis
        Return Nothing
    End Function

    Public Function setIdPersona(pidPersona As Integer)
        idPersona = pidPersona
        Return Nothing
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getNacionalidad() As String
        Return nacionalidad
    End Function

    Public Function getCantPelis() As Integer
        Return cantPelis
    End Function

    Public Function getIdPersona() As Integer
        Return idPersona
    End Function

End Class