Public Class MisionEspacial
    Private Sub MisionEspacial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaNombresPl()
    End Sub
    Private Sub btnInsignia_Click(sender As Object, e As EventArgs) Handles btnInsignia.Click
        OpenFileDialog1.InitialDirectory = "Bibliotecas\Imágenes"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        Principal.Visible = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrInsignia As Byte() = mstream.GetBuffer()
        mstream.Close()
        Dim nombre = txtNombreM.Text
        Dim fechaLanzamiento = dtpFechaLanzamiento.Value.Date.ToString
        Dim duracTiempo = txtDuracion.Text
        Dim nave = txtNave.Text
        Dim datosInteres = txtDatosI.Text
        Dim cuerpoDestino = cmbCuerpoC.Text
        Dim resultado = txtResultado.Text
        Dim tripulantes = txtTripulantes.Text

        objgestor.agregarMision(nombre, tripulantes, fechaLanzamiento, duracTiempo, datosInteres, nave, cuerpoDestino, arrInsignia)
        MessageBox.Show("Los datos se registraron correctamente")
    End Sub
    Sub listaNombresPl()
        Dim nombres As DataTable = objgestor.listarNombresProgramas()
        Dim nombre As DataRow
        For Each nombre In nombres.Rows
            cmbCuerpoC.Items.Add(nombre("nombre").ToString)
        Next
    End Sub

   
End Class