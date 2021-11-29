Public Class Formulario
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Ocurrio el evento Load", "AVISO")
    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        MessageBox.Show("Bienvenido: " & System.Environment.NewLine & txtnombre.Text)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
