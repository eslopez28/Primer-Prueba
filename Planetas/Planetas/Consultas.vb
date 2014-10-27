

Imports BLL
Public Class Consultas


    Private Sub Button1_Click(sender As System.Object, e As EventArgs)


    End Sub


    Private Sub btnVolver1_Click(sender As Object, e As EventArgs) Handles btnVolver1.Click
        Me.Visible = False
        Principal.Visible = True
    End Sub

   
    
    Sub listaProgramas()
        Dim lista As DataTable = objgestor.listaProgramas()
        DataGridProgramas.DataSource = lista
        DataGridProgramas.AutoGenerateColumns = False


        DataGridProgramas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Sub listaEstrellas()
        Dim lista As DataTable = objgestor.listaEstrellas()
        Dim dgvColumChecked = New DataGridViewCheckBoxColumn()
        DataGridEstrella.DataSource = lista
        DataGridEstrella.AutoGenerateColumns = False

        DataGridEstrella.Columns.Add(dgvColumChecked)
        DataGridEstrella.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells


    End Sub
    Sub listarPlanetas()
        Dim lista As DataTable = objgestor.listaPlanetas()
        DataGridPlanetas.DataSource = lista
        DataGridPlanetas.AutoGenerateColumns = False


        DataGridPlanetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Sub listarMisiones()
        Dim lista As DataTable = objgestor.listarMisiones()
        DataGridMision.DataSource = lista
        DataGridMision.AutoGenerateColumns = False


        DataGridMision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Sub listaSatelites()
        Dim lista As DataTable = objgestor.listarSatelite()
        DataGridSatelite.DataSource = lista
        DataGridSatelite.AutoGenerateColumns = False


        DataGridSatelite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbtEstrella_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEstrella.CheckedChanged
        DataGridEstrella.Visible = True
        DataGridPlanetas.Visible = False
        DataGridSatelite.Visible = False
        listaEstrellas()

    End Sub

    Private Sub rbtPlanetas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPlanetas.CheckedChanged
        DataGridEstrella.Visible = False
        DataGridPlanetas.Visible = True
        DataGridSatelite.Visible = False
        listarPlanetas()


    End Sub

    

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        listarMisiones()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        listaProgramas()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DataGridEstrella.Visible = False
        DataGridPlanetas.Visible = False
        DataGridSatelite.Visible = True
        listaSatelites()
    End Sub

   
End Class