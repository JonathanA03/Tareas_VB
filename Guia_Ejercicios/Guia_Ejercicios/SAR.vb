Imports System.ComponentModel

Public Class SAR
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub txtSalario_TextChanged(sender As Object, e As EventArgs) Handles txtSalario.TextChanged

    End Sub

    Private Sub txtSalario_Validating(sender As Object, e As CancelEventArgs) Handles txtSalario.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorProvider1.SetError(sender, "")

            Else
                Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If Val(txtSalario.Text) = 0 Then
            MsgBox("Ingrese un valor númerico")
            limpiar()
        ElseIf Not IsNumeric(txtSalario.Text) Then
            MsgBox("Ingrese un valor númerico")
            limpiar()
        ElseIf txtSalario.Text < 0 Then
            MsgBox("Ingrese un valor númerico")
            limpiar()
        Else
            If Val(txtSalario.Text) < 16582.92 Then
                txtMensaje.Text = "Empleado excento"
                txtSueldo.Text = Val(txtSalario.Text)
            ElseIf (txtSalario.Text > 16582.93 And txtSalario.Text < 23536.61) Then
                txtMensaje.Text = "Aplica deducción"
                txtSueldo.Text = Val(txtSalario.Text) - (Val(txtSalario.Text) * 0.15)
            ElseIf (Val(txtSalario.Text) > 23536.62 And Val(txtSalario.Text) < 50317.69) Then
                txtMensaje.Text = "Aplica deducción"
                txtSueldo.Text = Val(txtSalario.Text) - (Val(txtSalario.Text) * 0.2)
            ElseIf Val(txtSalario.Text) > 50317.69 Then
                txtMensaje.Text = "Aplica deducción"
                txtSueldo.Text = Val(txtSalario.Text) - (Val(txtSalario.Text) * 0.25)
            End If
        End If

    End Sub

    Public Sub limpiar()
        txtMensaje.Text = ""
        txtSalario.Text = ""
        txtSueldo.Text = ""
    End Sub
End Class