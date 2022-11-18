Public Class frmLogin
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim vForm As New frmMenu
        vForm.ShowDialog()
        vForm.Dispose()
    End Sub

    Private Sub cmdVista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVista.Click
        If txtContraseña.PasswordChar = "*" Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class




