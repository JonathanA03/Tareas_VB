Public Class Formula_Cuadratica
    Dim B, AC, Praiz As Double

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If Val(txtValor1.Text) = 0 Then
            MsgBox("Ingrese primer valor no puede ser 0", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) And Not IsNumeric(txtValor2.Text) And Not IsNumeric(txtValor3.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtValor1.Text = ""
            txtValor2.Text = ""
            txtValor3.Text = ""
            txtX1.Text = ""
            txtX2.Text = ""
        ElseIf (txtValor1.Text = "" And txtValor2.Text = "" And txtValor3.Text = "") Then
            MsgBox("Por favor, Ingrese un valor", vbInformation)
        End If

        B = Math.Pow(txtValor2.Text, 2)
        AC = 4 * Val(txtValor1.Text * txtValor3.Text)
        Praiz = B - AC

        If Praiz < 0 Then
            MsgBox("No existen las raices cuadradas negativas", vbInformation)
            txtValor1.Text = ""
            txtValor2.Text = ""
            txtValor3.Text = ""
            txtX1.Text = ""
            txtX2.Text = ""
        Else
            txtX1.Text = (-Val(txtValor2.Text) + (Math.Sqrt(Praiz))) / 2 * Val(txtValor1.Text)
            txtX2.Text = (-Val(txtValor2.Text) - (Math.Sqrt(Praiz))) / 2 * Val(txtValor1.Text)
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Text = ""
        txtValor2.Text = ""
        txtValor3.Text = ""
        txtX1.Text = ""
        txtX2.Text = ""
    End Sub

End Class