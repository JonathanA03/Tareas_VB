<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.checkDescuento = New System.Windows.Forms.CheckBox()
        Me.checkISV = New System.Windows.Forms.CheckBox()
        Me.cbDescuento = New System.Windows.Forms.ComboBox()
        Me.cbISV = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "P. Unitario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(115, 40)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(156, 22)
        Me.txtPrecio.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(115, 77)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(156, 22)
        Me.txtCantidad.TabIndex = 5
        '
        'checkDescuento
        '
        Me.checkDescuento.AutoSize = True
        Me.checkDescuento.Location = New System.Drawing.Point(21, 123)
        Me.checkDescuento.Name = "checkDescuento"
        Me.checkDescuento.Size = New System.Drawing.Size(143, 21)
        Me.checkDescuento.TabIndex = 6
        Me.checkDescuento.Text = "Aplicar descuento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.checkDescuento.UseVisualStyleBackColor = True
        '
        'checkISV
        '
        Me.checkISV.AutoSize = True
        Me.checkISV.Location = New System.Drawing.Point(21, 198)
        Me.checkISV.Name = "checkISV"
        Me.checkISV.Size = New System.Drawing.Size(98, 21)
        Me.checkISV.TabIndex = 7
        Me.checkISV.Text = "Aplicar ISV"
        Me.checkISV.UseVisualStyleBackColor = True
        '
        'cbDescuento
        '
        Me.cbDescuento.FormattingEnabled = True
        Me.cbDescuento.Items.AddRange(New Object() {"Estudiantil", "Mayorista", "3era. Edad", "Empleado", "Comerciales", "Por pronto pago"})
        Me.cbDescuento.Location = New System.Drawing.Point(43, 150)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(175, 24)
        Me.cbDescuento.TabIndex = 8
        Me.cbDescuento.Text = "Descuentos"
        '
        'cbISV
        '
        Me.cbISV.FormattingEnabled = True
        Me.cbISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.cbISV.Location = New System.Drawing.Point(43, 225)
        Me.cbISV.Name = "cbISV"
        Me.cbISV.Size = New System.Drawing.Size(175, 24)
        Me.cbISV.TabIndex = 9
        Me.cbISV.Text = "Impuestos"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(382, 99)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(78, 36)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(382, 139)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 36)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(382, 178)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 36)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ISV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(115, 44)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 22)
        Me.txtSubtotal.TabIndex = 17
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(115, 99)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 22)
        Me.txtDescuento.TabIndex = 18
        '
        'txtISV
        '
        Me.txtISV.Enabled = False
        Me.txtISV.Location = New System.Drawing.Point(115, 147)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(100, 22)
        Me.txtISV.TabIndex = 19
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(115, 194)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.checkDescuento)
        Me.GroupBox1.Controls.Add(Me.cbDescuento)
        Me.GroupBox1.Controls.Add(Me.checkISV)
        Me.GroupBox1.Controls.Add(Me.cbISV)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 281)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 350)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 267)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(492, 646)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents checkDescuento As CheckBox
    Friend WithEvents checkISV As CheckBox
    Friend WithEvents cbDescuento As ComboBox
    Friend WithEvents cbISV As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
