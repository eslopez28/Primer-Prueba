Public Class CuerposCelestes
    Dim formularioEstrella As ArrayList
    Dim formularioPlaneta As ArrayList
    Dim formularioSatelite As ArrayList

   
    Private Sub CuerposCelestes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validarFormEstrella()
        validarFormPlaneta()
        validarFormSatelite()
        listaNombresPl()
    End Sub
    Private Sub rbtSatelite_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSatelite.CheckedChanged

        panelEstrella.Visible = False
        panelPlaneta.Visible = False
        panelSatelite.Visible = True

    End Sub

    Private Sub rbtEstrella_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEstrella.CheckedChanged

        panelSatelite.Visible = False
        panelPlaneta.Visible = False
        panelEstrella.Visible = True

    End Sub

    Private Sub rbtPlaneta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPlaneta.CheckedChanged

        panelSatelite.Visible = False
        panelEstrella.Visible = False
        panelPlaneta.Visible = True

    End Sub
    Private Sub txtPruebaNumero_KeyPress(ByVal sender As Object, _
                          ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                              Handles txtMasa.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If panelEstrella.Visible = True Then
            Dim validarEstrella As Boolean = True
            For index = 0 To formularioEstrella.Count - 1

                If formularioEstrella(index).Text = vbNullString Then

                    validarEstrella = False


                End If
            Next

            If validarEstrella = True Then
                Dim nombreEs As String = txtNombre.Text
                Dim masaEs As String = txtMasa.Text
                Dim tempEs As String = txtTemp.Text
                Dim duracionDiaEs As String = txtDDia.Text
                Dim edadEs As String = txtEEdad.Text
                Dim compEs As String = txtEComp.Text
                Dim inteEs As String = txtEInte.Text
                Dim tamnioEs = txtETam.Text

                objgestor.agregarEstrella(nombreEs, masaEs, tempEs, duracionDiaEs, edadEs, compEs, inteEs, tamnioEs)
                MessageBox.Show("Los datos de la estrella fueron registrados")
            Else
                MessageBox.Show("Verifique que los datos esten completos")
            End If

        End If
        If panelPlaneta.Visible = True Then

            Dim validarPlaneta As Boolean = True
            For index = 0 To formularioPlaneta.Count - 1

                If formularioPlaneta(index).Text = vbNullString Then

                    validarPlaneta = False


                End If
            Next

            If validarPlaneta = True Then
                Dim nombreEs As String = txtNombre.Text
                Dim masaEs As String = txtMasa.Text
                Dim tempEs As String = txtTemp.Text
                Dim duracionDiaEs As String = txtDDia.Text
                Dim distanciaMedia As String = txtDisMedSol.Text
                Dim duracionAnio As String = txtDAnno.Text
                

                objgestor.agregarPlaneta(nombreEs, masaEs, tempEs, duracionDiaEs, distanciaMedia, duracionAnio)
                MessageBox.Show("Los datos del planeta se registraron correctamente.")
            Else
                MessageBox.Show("Verifique que todos los datos esten registrados")
            End If

        End If


        If panelSatelite.Visible = True Then

            Dim validarSatelite As Boolean = True
            For index = 0 To formularioSatelite.Count - 1

                If formularioSatelite(index).Text = vbNullString Then

                    validarSatelite = False


                End If
            Next

            If validarSatelite = True Then
                Dim nombreEs As String = txtNombre.Text
                Dim masaEs As String = txtMasa.Text
                Dim tempEs As String = txtTemp.Text
                Dim duracionDiaEs As String = txtDDia.Text
                Dim distancia As String = txtSDistancia.Text
                Dim caracteristica As String = txtSCaract.Text
                Dim planeta As String = cmbPlanetas.Text


                objgestor.agregarSatelite(nombreEs, masaEs, tempEs, duracionDiaEs, distancia, caracteristica, planeta)
                MessageBox.Show("todo validado")
            Else
                MessageBox.Show("todo mal")
            End If

        End If
    End Sub

    Private Sub validarFormEstrella()
        formularioEstrella = New ArrayList
        formularioEstrella.Add(txtNombre)
        formularioEstrella.Add(txtMasa)
        formularioEstrella.Add(txtTemp)
        formularioEstrella.Add(txtDDia)
        formularioEstrella.Add(txtEEdad)
        formularioEstrella.Add(txtEComp)
        formularioEstrella.Add(txtEInte)
        formularioEstrella.Add(txtETam)

    End Sub
    Private Sub validarFormPlaneta()
        formularioPlaneta = New ArrayList
        formularioPlaneta.Add(txtNombre)
        formularioPlaneta.Add(txtMasa)
        formularioPlaneta.Add(txtTemp)
        formularioPlaneta.Add(txtDDia)
        formularioPlaneta.Add(txtDisMedSol)
        formularioPlaneta.Add(txtDAnno)
    End Sub
    Private Sub validarFormSatelite()
        formularioSatelite = New ArrayList
        formularioSatelite.Add(txtNombre)
        formularioSatelite.Add(txtMasa)
        formularioSatelite.Add(txtTemp)
        formularioSatelite.Add(txtDDia)
        formularioSatelite.Add(txtSDistancia)
        formularioSatelite.Add(txtSCaract)
        formularioSatelite.Add(cmbPlanetas)
    End Sub

    
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        Principal.Visible = True
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Sub listaNombresPl()
        Dim nombres As DataTable = objgestor.listarNombresProgramas()
        Dim nombre As DataRow
        For Each nombre In nombres.Rows
            cmbPlanetas.Items.Add(nombre("nombre").ToString)
        Next
    End Sub
End Class