Public Class frmMenu
    Private Sub PacientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPacientes.Click
        Dim vForm As New frmPacientes
        vForm.ShowDialog()
        vForm.Dispose()
    End Sub

    Private Sub mnuEnfermeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEnfermeros.Click
        Dim vForm As New frmEnfermeros
        vForm.ShowDialog()
        vForm.Dispose()
    End Sub


    Private Sub mnuFichaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFichaMedica.Click
        Dim vForm As New frmFichaMedica
        vForm.ShowDialog()
        vForm.Dispose()
    End Sub

End Class
