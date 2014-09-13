Public Class Promociones

    Private descuento As Double
    Private dia As String
    Private descripcion As String
    Private idPromociones As Integer
    Private idSala As Integer

    Public Sub Promociones(pdescuento As Double, pdia As String, pdescripcion As String, pidPromociones As Integer, pidSala As Integer)
        setDescuento(pdescuento)
        setDia(pdia)
        setDescripcion(pdescripcion)
        setIdPromociones(pidPromociones)
        setIdSala(pidSala)
    End Sub

    Public Function setDescuento(pdescuento As Double)
        descuento = pdescuento
        Return Nothing
    End Function

    Public Function setDia(pdia As String)
        dia = pdia
        Return Nothing
    End Function

    Public Function setDescripcion(pdescripcion As String)
        descripcion = pdescripcion
        Return Nothing
    End Function

    Public Function setIdPromociones(pidPromociones As Integer)
        idPromociones = pidPromociones
        Return Nothing
    End Function

    Public Function setIdSala(pidSala As Integer)
        idSala = pidSala
        Return Nothing
    End Function

    Public Function getDescuento() As Double
        Return descuento
    End Function

    Public Function getDia() As String
        Return dia
    End Function

    Public Function getDescripcion() As String
        Return descripcion
    End Function

    Public Function getIdPromociones() As Integer
        Return idPromociones
    End Function

    Public Function getIdSala() As Integer
        Return idSala
    End Function


End Class
