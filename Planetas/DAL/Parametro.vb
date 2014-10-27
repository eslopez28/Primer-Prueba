Public Class Parametro

#Region "atributos"
    Private mnombre As String
    Private mdato As Object
#End Region

#Region "propiedades"
    Public Property Nombre() As String
        Get
            Return mnombre
        End Get
        Set(ByVal value As String)
            mnombre = value
        End Set
    End Property

    Public Property Dato() As Object
        Get
            Return mdato
        End Get
        Set(ByVal value As Object)
            mdato = value
        End Set
    End Property
#End Region

#Region "constructores"
    Sub New(ByVal pnombre As String, ByVal pdato As Object)
        Nombre = pnombre
        Dato = pdato
    End Sub
#End Region

End Class
