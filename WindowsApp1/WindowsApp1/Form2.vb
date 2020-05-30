Public Class Form2
    Dim Descuento As Double
    Dim ISV As Double

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDescuento.Enabled = False
        cbISV.Enabled = False
        'Boton nuevo
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Validación
        If txtPrecio.Text = "" Then
            MsgBox("La casilla esta vacia", vbInformation)
        ElseIf Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Ingrese un valor", vbInformation)
            txtPrecio.Text = ""
        ElseIf txtPrecio.Text < 0 Then
            MsgBox("Los productos no pueden tener valores negativos")
            txtPrecio.Text = ""
        End If

        If txtCantidad.Text = "" Then
            MsgBox("La casilla esta vacia", vbInformation)
        ElseIf Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Ingrese un valor", vbInformation)
            txtCantidad.Text = ""
        ElseIf txtCantidad.Text < 0 Then
            MsgBox("Los productos no pueden tener valores negativos")
            txtCantidad.Text = ""
        End If

        'Procesos
        If (txtPrecio.Text = "" And txtCantidad.Text = "") Then
            MsgBox("Por favor, ingrese datos en el sistema")
        Else
            txtSubtotal.Text = txtPrecio.Text * txtCantidad.Text

            If checkDescuento.Checked = True Then
                txtDescuento.Text = txtSubtotal.Text * Descuento
                txtTotal.Text = txtSubtotal.Text - (txtSubtotal.Text * Descuento)
                txtISV.Text = "-"
            ElseIf checkISV.Checked = True Then
                txtISV.Text = txtSubtotal.Text * ISV
                txtTotal.Text = txtSubtotal.Text + (txtSubtotal.Text * ISV)
                txtDescuento.Text = "-"

            End If
        End If
        'Boton nuevo
        btnNuevo.Enabled = True
    End Sub

    Private Sub checkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles checkDescuento.CheckedChanged
        If checkDescuento.Checked = True Then
            cbDescuento.Enabled = True
            checkISV.Enabled = False
        ElseIf checkDescuento.Checked = False Then
            cbDescuento.Enabled = False
            checkISV.Enabled = True
        End If
    End Sub

    Private Sub checkISV_CheckedChanged(sender As Object, e As EventArgs) Handles checkISV.CheckedChanged
        If checkISV.Checked = True Then
            cbISV.Enabled = True
            checkDescuento.Enabled = False
        ElseIf checkISV.Checked = False Then
            cbISV.Enabled = False
            checkDescuento.Enabled = True
        End If
    End Sub

    Private Sub cbDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDescuento.SelectedIndexChanged
        If cbDescuento.Text = "Estudiantil" Then
            Descuento = 0.08
        ElseIf cbDescuento.Text = "Mayorista" Then
            Descuento = 0.25
        ElseIf cbDescuento.Text = "3era. Edad" Then
            Descuento = 0.15
        ElseIf cbDescuento.Text = "Empleado" Then
            Descuento = 0.2
        ElseIf cbDescuento.Text = "Comerciales" Then
            Descuento = 0.02
        ElseIf cbDescuento.Text = "Por pronto pago" Then
            Descuento = 0.1
        End If
    End Sub

    Private Sub cbISV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbISV.SelectedIndexChanged
        If cbISV.Text = "15%" Then
            ISV = 0.15
        ElseIf cbISV.Text = "17%" Then
            ISV = 0.17
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtSubtotal.Clear()
        txtTotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()
        cbDescuento.Text = ""
        cbISV.Text = ""
        checkDescuento.Checked = False
        checkISV.Checked = False
        'Boton nuevo
        btnNuevo.Enabled = False

    End Sub

End Class
