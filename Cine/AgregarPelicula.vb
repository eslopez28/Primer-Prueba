Public Class AgregarPelicula

    Private Sub AgregarPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSubt.Items.Add("Si")
        txtSubt.Items.Add("No")
        txtSubt.Text = ""

        cargarLista()
    End Sub

    Private Sub btnAgregarPelicula_Click(sender As Object, e As EventArgs) Handles btnAgregarPelicula.Click

        Dim gestor As Gestor = New Gestor()
        gestor.setPelicula(txtTituloDIst.Text, txtTituloOrig.Text, txtIdioma.Text, txtGenero.Text, txtSubt.Text, txtOrigen.Text, txtProduccion.Text,
                           txtUrl.Text, txtHoras.Value, txtMin.Value, txtClasificacion.Text, txtEstreno.Text, 0, 0)

        cargarLista()

    End Sub

    Private Sub cargarLista()

        Dim lista As ArrayList = New MultiPelicula().getPeliculas
        Dim pelicula As Pelicula

        For Each pelicula In lista
            lstPeli.Items.Add(pelicula.getTituloDist & " - " & pelicula.getTituloOrig)
        Next
    End Sub

End Class