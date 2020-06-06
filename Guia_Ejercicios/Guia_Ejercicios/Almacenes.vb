Public Class Almacenes
    Dim media As Double
    Dim almacen1 As Double
    Dim almacen2 As Double
    Dim almacen3 As Double
    Dim almacen4 As Double
    Dim almacen5 As Double
    Dim almacen6 As Double
    Dim almacen7 As Double
    Dim almacen8 As Double
    Dim almacen9 As Double
    Dim almacen10 As Double
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If Me.ValidateChildren And IsNumeric(txtVenta.Text) Then
                If txtVenta.Text = "0" Or txtVenta.Text < 0 Then
                    MessageBox.Show("Ingrese valores positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtVenta.Text = ""
                End If
                If cmbAlmacen.Text = "Las Flores" Then
                    almacen1 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "El Tigre" Then
                    almacen2 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "El Oro" Then
                    almacen3 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "El Rey" Then
                    almacen4 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "Banasupro" Then
                    almacen5 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "Lempirita" Then
                    almacen6 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "Tilapia" Then
                    almacen7 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "Los Hermanos" Then
                    almacen8 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "La Suegra" Then
                    almacen9 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                ElseIf cmbAlmacen.Text = "El Visual Basic" Then
                    almacen10 = Val(txtVenta.Text)
                    txtVenta.Text = ""
                End If
                media = (almacen1 + almacen2 + almacen3 + almacen4 + almacen5 + almacen6 + almacen7 + almacen8 + almacen9 + almacen10) / 10
            Else
                MessageBox.Show("Ingrese valores númericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        txtMedia.Text = media
        If media < almacen1 Then
            lstMedia.Items.Add("Las Flores")
        End If
        If media < almacen2 Then
            lstMedia.Items.Add("El Tigre")
        End If
        If media < almacen3 Then
            lstMedia.Items.Add("El Oro")
        End If
        If media < almacen4 Then
            lstMedia.Items.Add("El Rey")
        End If
        If media < almacen5 Then
            lstMedia.Items.Add("Banasupro")
        End If
        If media < almacen6 Then
            lstMedia.Items.Add("Lempirita")
        End If
        If media < almacen7 Then
            lstMedia.Items.Add("Tilapia")
        End If
        If media < almacen8 Then
            lstMedia.Items.Add("Los Hermanos")
        End If
        If media < almacen9 Then
            lstMedia.Items.Add("La Suegra")
        End If
        If media < almacen10 Then
            lstMedia.Items.Add("El Visual Basic")
        End If
        cmbAlmacen.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstMedia.Items.Clear()
        txtMedia.Text = ""
    End Sub
End Class