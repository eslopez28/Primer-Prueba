Public Class Cine

    Private idCine As Integer
    Private nombre As String
    Private direccion As String
    Private telefono As String
    Private salas As ArrayList
    Private promociones As ArrayList

    Public Sub Cine(pidCine As Integer, pnombre As String, pdireccion As String, ptelefono As String)
        setIdCine(pidCine)
        setNombre(pnombre)
        setDireccion(pdireccion)
        setTelefono(ptelefono)
    End Sub

    Public Function setIdCine(pidCine As Integer)
        idCine = pidCine
        Return Nothing
    End Function

    Public Function setNombre(pnombre As String)
        nombre = pnombre
        Return Nothing
    End Function

    Public Function setDireccion(pdireccion As String)
        direccion = pdireccion
        Return Nothing
    End Function

    Public Function setTelefono(ptelefono As String)
        telefono = ptelefono
        Return Nothing
    End Function

    Public Function getIdCine() As Integer
        Return idCine
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getDireccion() As String
        Return direccion
    End Function

    Public Function getTelefono() As String
        Return telefono
    End Function

End Class
