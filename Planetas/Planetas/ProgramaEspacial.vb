Imports BLL

Public Class ProgramaEspacial
    Dim valores As ArrayList

    Private Sub ProgramaEspacial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarValores()
        cargarMeses()
        cargarAnnos()
    End Sub



    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim validar As Boolean = True
        Dim nombreProg As String = ""
        Dim mesInicio As String = ""
        Dim annoInicio As String = ""
        Dim mesFinal As String = ""
        Dim annoFinal As String = ""
        Dim alcance As String = ""
        Dim fechaInicio As String = ""
        Dim fechaFinal As String = ""

        For index = 0 To valores.Count - 1
            If valores(index).Text = vbNullString Then
                validar = False
            End If

        Next

        Try
            If validar = True Then
                nombreProg = txtNombreProg.Text
                mesInicio = cmbMesInc.Text
                annoInicio = cmbAnnoInc.Text
                annoFinal = cmbAnnoFin.Text
                mesFinal = cmbMesFin.Text
                alcance = txtAlcance.Text
                fechaInicio = mesInicio & "/" & annoInicio
                fechaFinal = mesFinal & "/" & annoFinal
                MessageBox.Show("Los datos fueron registrados")
                objgestor.agregarPrograma(nombreProg, fechaInicio, fechaFinal, alcance)

            Else

                MessageBox.Show("Verifique que todos los campos esten llenos")

            End If
        Catch ex As Exception

        End Try





    End Sub
    Private Sub llenarValores()
        valores = New ArrayList

        valores.Add(txtNombreProg)
        valores.Add(cmbMesInc)
        valores.Add(cmbMesFin)
        valores.Add(cmbAnnoInc)
        valores.Add(cmbAnnoFin)
        valores.Add(txtAlcance)

    End Sub
    Private Sub cargarMeses()
        Dim meses As ArrayList = New ArrayList
        meses.Add(valores(1))
        meses.Add(valores(2))
        For index = 0 To meses.Count - 1
            meses(index).Items.Add(1)
            meses(index).Items.Add(2)
            meses(index).Items.Add(3)
            meses(index).Items.Add(4)
            meses(index).Items.Add(5)
            meses(index).Items.Add(6)
            meses(index).Items.Add(7)
            meses(index).Items.Add(8)
            meses(index).Items.Add(9)
            meses(index).Items.Add(10)
            meses(index).Items.Add(11)
            meses(index).Items.Add(12)

        Next


    End Sub
    Private Sub cargarAnnos()
        Dim meses As ArrayList = New ArrayList
        meses.Add(valores(3))
        meses.Add(valores(4))
        For index = 0 To meses.Count - 1
            meses(index).Items.Add(1999)
            meses(index).Items.Add(2000)
            meses(index).Items.Add(2001)
            meses(index).Items.Add(2002)
            meses(index).Items.Add(2003)
            meses(index).Items.Add(2004)
            meses(index).Items.Add(2005)
            meses(index).Items.Add(2006)
            meses(index).Items.Add(2007)
            meses(index).Items.Add(2008)
            meses(index).Items.Add(2009)
            meses(index).Items.Add(2010)
            meses(index).Items.Add(2011)
            meses(index).Items.Add(2012)
            meses(index).Items.Add(2013)
            meses(index).Items.Add(2014)

        Next


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        Principal.Visible = True
    End Sub
End Class