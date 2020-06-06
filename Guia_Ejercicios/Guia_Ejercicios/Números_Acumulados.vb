Public Class Números_Acumulados

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If Me.ValidateChildren And IsNumeric(txtCantidad.Text) Then
                Dim numeros, positivo, negativo, impar, par, contador, numerosIng As Integer
                numeros = Val(txtCantidad.Text)
                If txtCantidad.Text = "0" Or txtCantidad.Text < 0 Then
                    MessageBox.Show("Ingrese valores positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                End If
                For i = 1 To numeros Step 1
                    numerosIng = InputBox("Ingrese un número " & i, "Ingresar")
                    contador += numerosIng
                    If numerosIng > 0 Then
                        positivo = positivo + 1

                    Else
                        negativo = negativo + 1
                    End If
                    If (numerosIng Mod 2) = 0 Then
                        par = par + 1
                    Else
                        impar = impar + 1
                    End If
                    cmbNumeros.Items.Add(numerosIng)
                Next
                txtPositivos.Text = positivo
                txtNegativos.Text = negativo
                txtPares.Text = par
                txtImpares.Text = impar
                txtSumaT.Text = contador
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
        txtPositivos.Text = ""
        txtNegativos.Text = ""
        txtPares.Text = ""
        txtImpares.Text = ""
        txtSumaT.Text = ""
        txtCantidad.Text = ""
        cmbNumeros.Text = ""
        cmbNumeros.Items.Clear()
    End Sub
End Class