Imports MySql.Data.MySqlClient

Public Class MultiPelicula

    Private mysqlConector As MySqlConnection

    Public Function getPeliculas()
        mysqlConector = New MySqlConnection("server=localhost; uid=root; pwd=root; database=cine;")

        Dim sqlExecute As String = "SELECT * FROM cine.pelicula;"
        Dim comandExecute As MySqlDataAdapter = New MySqlDataAdapter(sqlExecute, mysqlConector)
        Dim listaPeliculas As ArrayList = New ArrayList()
        Dim dataSet As New DataSet

        mysqlConector.Open()

        comandExecute.Fill(dataSet, "pelicula")
        mysqlConector.Close()

        Dim listaPelicula As ArrayList = New ArrayList()

        Dim tablaPelicula As DataTable
        tablaPelicula = dataSet.Tables("pelicula")

        Dim peliculaFila As DataRow
        For Each peliculaFila In tablaPelicula.Rows
            listaPelicula.Add(New Pelicula(peliculaFila.Item("tituloDist"), peliculaFila.Item("tituloOrig"), peliculaFila.Item("idiomaOri"), peliculaFila.Item("genero"), peliculaFila.Item("subt"), peliculaFila.Item("origen"),
                                           peliculaFila.Item("produccion"), peliculaFila.Item("url"), peliculaFila.Item("horas"), peliculaFila.Item("min"), peliculaFila.Item("clasificacion"),
                                           peliculaFila.Item("estreno"), peliculaFila.Item("idPelicula"), 0, 0))
        Next
        Return listaPelicula

    End Function

    Public Function getPeliculasPorNombre(nombre As String)
        mysqlConector = New MySqlConnection("server=localhost; uid=root; pwd=root; database=cine;")

        Dim sqlExecute As String = "SELECT * FROM cine.pelicula where tituloDist =" & nombre & ";"
        Dim comandExecute As MySqlDataAdapter = New MySqlDataAdapter(sqlExecute, mysqlConector)
        Dim listaPeliculas As ArrayList = New ArrayList()
        Dim dataSet As New DataSet

        mysqlConector.Open()

        comandExecute.Fill(dataSet, "pelicula")
        mysqlConector.Close()

        Dim listaPelicula As ArrayList = New ArrayList()

        Dim tablaPelicula As DataTable
        tablaPelicula = dataSet.Tables("pelicula")

        Dim peliculaFila As DataRow
        For Each peliculaFila In tablaPelicula.Rows
            listaPelicula.Add(New Pelicula(peliculaFila.Item("tituloDist"), peliculaFila.Item("tituloOrig"), peliculaFila.Item("idiomaOri"), peliculaFila.Item("genero"), peliculaFila.Item("subt"), peliculaFila.Item("origen"),
                                           peliculaFila.Item("produccion"), peliculaFila.Item("url"), peliculaFila.Item("horas"), peliculaFila.Item("min"), peliculaFila.Item("clasificacion"),
                                           peliculaFila.Item("estreno"), peliculaFila.Item("idPelicula"), peliculaFila.Item("idResumen"), peliculaFila.Item("idDirector")))
        Next
        Return listaPelicula

    End Function

    Public Function getPeliculasPorId(id As String)
        mysqlConector = New MySqlConnection("server=localhost; uid=root; pwd=root; database=cine;")

        Dim sqlExecute As String = "SELECT * FROM cine.pelicula WHERE tituloDist =" & id & ";"
        Dim comandExecute As MySqlDataAdapter = New MySqlDataAdapter(sqlExecute, mysqlConector)
        Dim listaPeliculas As ArrayList = New ArrayList()
        Dim dataSet As New DataSet

        mysqlConector.Open()

        comandExecute.Fill(dataSet, "pelicula")
        mysqlConector.Close()

        Dim listaPelicula As ArrayList = New ArrayList()

        Dim tablaPelicula As DataTable
        tablaPelicula = dataSet.Tables("pelicula")

        Dim peliculaFila As DataRow
        Dim pelicula As Pelicula

        For Each peliculaFila In tablaPelicula.Rows
            pelicula = New Pelicula(peliculaFila.Item("tituloDist"), peliculaFila.Item("tituloOrig"), peliculaFila.Item("idiomaOri"), peliculaFila.Item("genero"), peliculaFila.Item("subt"), peliculaFila.Item("origen"),
                                               peliculaFila.Item("produccion"), peliculaFila.Item("url"), peliculaFila.Item("horas"), peliculaFila.Item("min"), peliculaFila.Item("clasificacion"),
                                               peliculaFila.Item("estreno"), peliculaFila.Item("idPelicula"), peliculaFila.Item("idResumen"), peliculaFila.Item("idDirector"))
        Next

        Return pelicula
    End Function

    Public Function setPelicua(pelicula As Pelicula)
        mysqlConector = New MySqlConnection("server=localhost; uid=root; pwd=root; database=cine;")

        Dim sqlExecute As String = "INSERT INTO `cine`.`pelicula` (`tituloDist`, `tituloOrig`, `genero`, `idiomaOri`, `subt`, `origen`, `produccion`, `url`, `horas`, `min`, `clasificacion`, `estreno`)  " &
            "VALUES ('" & pelicula.getTituloDist() & "', '" & pelicula.getTituloOrig() & "', '" & pelicula.getGenero & "', '" & pelicula.getIdiomaOrig() & "', '" & pelicula.getSubt() & "', '" & pelicula.getOrigen() & "', '" & pelicula.getProduccion() & "', '" &
            pelicula.getUrl() & "', '" & pelicula.getHoras() & "', '" & pelicula.getMin() & "', '" & pelicula.getClasificacion() & "', '" & pelicula.getEstreno() & "');"

        Dim comandExecute As MySqlCommand = New MySqlCommand(sqlExecute, mysqlConector)

        mysqlConector.Close()
        mysqlConector.Open()
        comandExecute.ExecuteNonQuery()
        mysqlConector.Close()

        Return Nothing
    End Function

End Class
