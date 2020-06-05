Public Class Calculadora
    Dim OperacionBasica As String
    Dim Resultado As Nullable(Of Double) = Nothing
    Dim Valor As Nullable(Of Double) = Nothing
    Dim Botones As Boolean

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
        lstHistorial.Items.Clear()
        txtResultado.Text = ""
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Restricciones()
        txtResultado.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Restricciones()
        txtResultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Restricciones()
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Restricciones()
        txtResultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Restricciones()
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Restricciones()
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Restricciones()
        txtResultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Restricciones()
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Restricciones()
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Restricciones()
        txtResultado.Text &= "9"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        Restricciones()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        operacion()
        OperacionBasica = "+"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        operacion()
        OperacionBasica = "-"
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        operacion()
        OperacionBasica = "*"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        operacion()
        OperacionBasica = "/"
    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        operacion()
        OperacionBasica = ""
        If Resultado = Resultado / 0 Then
            txtResultado.Text = "ERROR"
            lstHistorial.Text = ""
        Else
            lstHistorial.Items.Add(txtResultado.Text)
        End If

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Text = ""
        Resultado = Nothing
        Valor = Nothing

    End Sub

    Public Sub operacion()
        Botones = True
        Valor = Val(txtResultado.Text)
        If Resultado IsNot Nothing Then
            Select Case OperacionBasica
                Case "+"
                    Resultado = Resultado + Valor
                Case "-"
                    Resultado = Resultado - Valor
                Case "*"
                    Resultado = Resultado * Valor
                Case "/"
                    Resultado = Resultado / Valor
            End Select
            txtResultado.Text = Resultado

        Else
            Resultado = Valor
        End If
    End Sub

    Public Sub Restricciones()
        If Botones = True Then
            txtResultado.Text = ""
            Botones = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub
End Class