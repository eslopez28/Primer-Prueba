Imports BLL
Public Class FigurasVarias
    Public gestor As New Gestor

    Private Sub btnCrearFigura_Click(sender As Object, e As EventArgs) Handles btnCrearFigura.Click
        Dim seleccion As Integer
        Dim figura As String = ""
        If (rbtnTriangulo.Checked) Then
            seleccion = 1
        ElseIf (rbtnRectangulo.Checked) Then
            seleccion = 2
        ElseIf (rbtnCirculo.Checked) Then
            seleccion = 3
        End If

        figura = gestor.crearFigura(seleccion)
        txtFigura.Text = figura
    End Sub
End Class
