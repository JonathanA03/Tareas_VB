Public Class Form1
    Dim i As Integer
    Dim t As Integer

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Validación
        If txtValor.Text = "" Then
            MsgBox("La casilla esta vacia", vbInformation)
            txtValor.Text = ""
        ElseIf Not IsNumeric(txtValor.Text) Then
            MsgBox("Ingrese un valor", vbInformation)
            txtValor.Text = ""
        Else
            For i = 1 To 10
                t = Val(txtValor.Text) * i
                MsgBox(t)

            Next i
        End If

    End Sub


End Class
