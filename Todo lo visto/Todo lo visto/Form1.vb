Imports System.ComponentModel

Public Class Form1
    Dim Precio As Integer
    Dim Descuento, ISV As Double
    Dim subtotal, total, descuento1, isv1 As Double

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuSalir.Click
        End
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            cbDescuento.Enabled = True
        ElseIf chkDescuento.Checked = False Then
            cbDescuento.Enabled = False
        End If
    End Sub

    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("¿Desea realizar un pedido?", "Ingresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            cbDescuento.Enabled = True
            cbProductos.Enabled = True
            mkFecha.Enabled = True
            chkDescuento.Enabled = True
            chkISV.Enabled = True
            btnCalcular.Enabled = True
            btnPagar.Enabled = True
            menuNuevo.Enabled = True
            txtCantidad.Enabled = True
        End If
        btnPedido.Enabled = False
    End Sub

    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged
        If cbProductos.Text = "Camisetas" Then
            Precio = 150
        ElseIf cbProductos.Text = "Tenis" Then
            Precio = 500
        ElseIf cbProductos.Text = "Jeans" Then
            Precio = 300
        ElseIf cbProductos.Text = "Shorts" Then
            Precio = 200
        ElseIf cbProductos.Text = "Gorras" Then
            Precio = 100
        ElseIf cbProductos.Text = "Perfumes" Then
            Precio = 800
        End If
    End Sub

    Private Sub cbDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDescuento.SelectedIndexChanged
        If cbDescuento.Text = "5%" Then
            Descuento = 0.05
        ElseIf cbDescuento.Text = "10%" Then
            Descuento = 0.1
        ElseIf cbDescuento.Text = "15%" Then
            Descuento = 0.15
        ElseIf cbDescuento.Text = "20%" Then
            Descuento = 0.2
        ElseIf cbDescuento.Text = "25%" Then
            Descuento = 0.25
        ElseIf cbDescuento.Text = "30%" Then
            Descuento = 0.3
        End If
    End Sub

    Private Sub menuNuevo_Click(sender As Object, e As EventArgs) Handles menuNuevo.Click
        txtCantidad.Clear()
        txtSubtotal.Clear()
        txtTotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()
        cbProductos.Text = ""
        cbDescuento.Text = ""
        mkFecha.Clear()
        chkDescuento.Checked = False
        chkISV.Checked = False
    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            ISV = 0.15
        End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        MessageBox.Show("Compra exitosa " + mkFecha.Text, "Finalizar", MessageBoxButtons.OK)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Try
            If Me.ValidateChildren And Val(txtCantidad.Text) > 0 Then
                For i = 1 To Val(txtCantidad.Text) Step 1
                    subtotal = Val(txtCantidad.Text) * Precio
                    descuento1 = subtotal * Descuento
                    isv1 = subtotal * ISV
                Next
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtSubtotal.Text = subtotal
            txtDescuento.Text = descuento1
            txtISV.Text = isv1
            txtTotal.Text = subtotal + isv1 - descuento1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDescuento.Enabled = False
        cbProductos.Enabled = False
        mkFecha.Enabled = False
        chkDescuento.Enabled = False
        chkISV.Enabled = False
        btnCalcular.Enabled = False
        btnPagar.Enabled = False
        txtCantidad.Enabled = False
        txtSubtotal.Enabled = False
        txtDescuento.Enabled = False
        txtISV.Enabled = False
        txtTotal.Enabled = False
        menuNuevo.Enabled = False
    End Sub

    Private Sub mkFecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mkFecha.MaskInputRejected
        If mkFecha.Text = "" Then
            MsgBox("Ingrese una fecha", vbInformation)
        ElseIf Not IsNumeric(mkFecha.Text) Then
            MsgBox("Las fechas no permiten letras", vbInformation)
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip1.SetToolTip(txtCantidad, "Ingrese una cantidad (Entero)")
        ToolTip1.ToolTipTitle = "Cantidad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mkFecha_MouseHover(sender As Object, e As EventArgs) Handles mkFecha.MouseHover
        ToolTip1.SetToolTip(mkFecha, "Ingrese una fecha (dd/mm/aaaa)")
        ToolTip1.ToolTipTitle = "Fecha"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class



