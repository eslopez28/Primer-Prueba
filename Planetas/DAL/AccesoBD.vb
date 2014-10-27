Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
Public Class AccesoBD

    'atributos del objeto
    Private mcadena As String = "integrated security=SSPI;data source=JORGE-LAPTOP\SQLEXPRESS;user=prueba;password=1234;" & "persist security info=False;initial catalog=planeta"

    'cadena de caracteres que contiene
    'el string de conexi�n
	Public ReadOnly Property Cadena() As String
		Get
			If mcadena = "" Then
                mcadena = ConnectionStrings("conexion").ConnectionString
            End If
            Return mcadena
        End Get
    End Property

    'm�todo que abre una conexi�n con la 
    'configuraci�n dada
    Public Function GetConexion() As IDbConnection
        Return New SqlConnection(Cadena)
    End Function

    'M�todos que ejecutan sentencias
    'en la BD
    'm�todo que no devuelve resultados
    Public Sub EjecutarSQL(ByVal pSQL As String, ByVal ParamArray parametros() As Parametro)
        Dim cmd As SqlCommand
        Dim objPar As Parametro
        Dim nombre As String
        Dim contador As Integer = 0
        'se crea el comando
        cmd = New SqlCommand
        cmd.Connection = GetConexion()
        'se sacan los par�metros
        For Each objPar In parametros

            nombre = "@" & objPar.Nombre
            cmd.Parameters.AddWithValue(nombre, objPar.Dato)


            Dim ultimo As Integer = parametros.Length - 1

            If contador >= ultimo Then
                pSQL = pSQL & " " & pSQL.Concat(nombre)
            Else
                pSQL = pSQL & " " & pSQL.Concat(nombre) & ", "
            End If
            contador = contador + 1

        Next
        cmd.CommandText = pSQL

        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
    End Sub

    'm�todo que devuelve resultados
    'en un datareader
    Public Function EjecutarSQL(ByVal pSQL As String, ByVal pconexion As IDbConnection, ByVal ParamArray parametros() As Parametro) As IDataReader
        Dim cmd As SqlCommand
        Dim objPar As Parametro
        Dim nombre As String
        'se crea el comando
        cmd = New SqlCommand
        cmd.Connection = pconexion
        'se sacan los par�metros
        For Each objPar In parametros
            nombre = String.Format("@{0}", objPar.Nombre)
            cmd.Parameters.AddWithValue(nombre, objPar.Dato)
            pSQL = pSQL.Replace(objPar.Nombre, nombre)
        Next
        cmd.CommandText = pSQL

        'si la conexi�n no est� abierta, se abre
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If
      

        Return cmd.ExecuteReader
    End Function

    'm�todo que devuelve resultados en un
    'dataset
    Public Function EjecutarSQL(ByVal pSQL As String, ByVal pTabla As String) As DataSet
        Dim adp As SqlDataAdapter
        Dim datasetL As New DataSet()
        adp = New SqlDataAdapter(pSQL, CType(GetConexion(), SqlConnection))
        adp.Fill(datasetL, pTabla)
        Return datasetL
    End Function

End Class
