Public Class Principal

   
    Private Sub cuerpo_celeste_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cuerpo_celeste.LinkClicked
        Me.Visible = False
        CuerposCelestes.Visible = True
    End Sub

    Private Sub linkPrograma_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkPrograma.LinkClicked
        Me.Visible = False
        ProgramaEspacial.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Visible = False
        Consultas.Visible = True
    End Sub

    Private Sub linkMisiones_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkMisiones.LinkClicked
        Me.Visible = False
        MisionEspacial.Visible = True
    End Sub
End Class
