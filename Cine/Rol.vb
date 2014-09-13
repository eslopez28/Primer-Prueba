Public Class Rol

    Private idRol As Integer
    Private nombre As String

    Public Sub Rol(pidRol As Integer, pnombre As String)
        setIdRol(pidRol)
        setNombre(pnombre)
    End Sub

    Public Function setIdRol(pidRol As Integer)
        idRol = pidRol
        Return Nothing
    End Function

    Public Function setNombre(pnombre As String)
        nombre = pnombre
        Return Nothing
    End Function

    Public Function getIdRol() As Integer
        Return idRol
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

End Class