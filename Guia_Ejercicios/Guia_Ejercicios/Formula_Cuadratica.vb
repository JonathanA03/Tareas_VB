Public Class Formula_Cuadratica
    Dim B, AC, Praiz As Double

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        B = Math.Pow(Val(txtValor2.Text), 2)
        AC = 4 * Val(txtValor1.Text) * Val(txtValor3.Text)
        Praiz = B - AC
        Try
            If Me.ValidateChildren And IsNumeric(txtValor1.Text) And IsNumeric(txtValor2.Text) And IsNumeric(txtValor3.Text) Then

                'Terminar try catch
                If Praiz < 0 Then
                    MsgBox("No existen las raices cuadradas negativas", vbInformation)
                    Limpiar()
                ElseIf Val(txtValor1.Text) = 0 Then
                    MessageBox.Show("El primer valor no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                Else
                    txtX1.Text = (-Val(txtValor2.Text) + (Math.Sqrt(Praiz))) / 2 * Val(txtValor1.Text)
                    txtX2.Text = (-Val(txtValor2.Text) - (Math.Sqrt(Praiz))) / 2 * Val(txtValor1.Text)
                End If
            Else
                MessageBox.Show("Ingrese valores númericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Limpiar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        txtValor1.Text = ""
        txtValor2.Text = ""
        txtValor3.Text = ""
        txtX1.Clear()
        txtX2.Clear()

    End Sub
End Class