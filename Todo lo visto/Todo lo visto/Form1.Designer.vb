<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.mkFecha = New System.Windows.Forms.MaskedTextBox()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.chkISV = New System.Windows.Forms.CheckBox()
        Me.cbDescuento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Controls.Add(Me.mkFecha)
        Me.GroupBox1.Controls.Add(Me.cbProductos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedido"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(84, 73)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 22)
        Me.txtCantidad.TabIndex = 8
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(6, 113)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(47, 17)
        Me.Fecha.TabIndex = 7
        Me.Fecha.Text = "Fecha"
        '
        'mkFecha
        '
        Me.mkFecha.Location = New System.Drawing.Point(84, 110)
        Me.mkFecha.Mask = "00/00/0000"
        Me.mkFecha.Name = "mkFecha"
        Me.mkFecha.Size = New System.Drawing.Size(121, 22)
        Me.mkFecha.TabIndex = 6
        Me.mkFecha.ValidatingType = GetType(Date)
        '
        'cbProductos
        '
        Me.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Items.AddRange(New Object() {"Camisetas", "Tenis", "Jeans", "Shorts", "Gorras", "Perfumes"})
        Me.cbProductos.Location = New System.Drawing.Point(84, 37)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(121, 24)
        Me.cbProductos.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(279, 111)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(12, 226)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(98, 21)
        Me.chkDescuento.TabIndex = 3
        Me.chkDescuento.Text = "Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'chkISV
        '
        Me.chkISV.AutoSize = True
        Me.chkISV.Location = New System.Drawing.Point(140, 226)
        Me.chkISV.Name = "chkISV"
        Me.chkISV.Size = New System.Drawing.Size(83, 21)
        Me.chkISV.TabIndex = 4
        Me.chkISV.Text = "15% ISV"
        Me.chkISV.UseVisualStyleBackColor = True
        '
        'cbDescuento
        '
        Me.cbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDescuento.FormattingEnabled = True
        Me.cbDescuento.Items.AddRange(New Object() {"5%", "10%", "15%", "20%", "25%", "30%"})
        Me.cbDescuento.Location = New System.Drawing.Point(12, 253)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(98, 24)
        Me.cbDescuento.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subtotal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 220)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(84, 176)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(121, 22)
        Me.txtTotal.TabIndex = 13
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(84, 133)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(121, 22)
        Me.txtISV.TabIndex = 12
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(84, 90)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(121, 22)
        Me.txtDescuento.TabIndex = 11
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(84, 38)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 22)
        Me.txtSubtotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "15% ISV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descuento"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(122, 52)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SlateGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOpciones})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(378, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOpciones
        '
        Me.MenuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNuevo, Me.menuSalir})
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Size = New System.Drawing.Size(85, 24)
        Me.MenuOpciones.Text = "Opciones"
        '
        'menuNuevo
        '
        Me.menuNuevo.Name = "menuNuevo"
        Me.menuNuevo.Size = New System.Drawing.Size(135, 26)
        Me.menuNuevo.Text = "Nuevo"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(135, 26)
        Me.menuSalir.Text = "Salir"
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(279, 149)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(75, 34)
        Me.btnPagar.TabIndex = 11
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnPedido
        '
        Me.btnPedido.Location = New System.Drawing.Point(270, 54)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(96, 46)
        Me.btnPedido.TabIndex = 12
        Me.btnPedido.Text = "Realizar Pedido"
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(378, 540)
        Me.Controls.Add(Me.btnPedido)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbDescuento)
        Me.Controls.Add(Me.chkISV)
        Me.Controls.Add(Me.chkDescuento)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents chkISV As CheckBox
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents cbDescuento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuOpciones As ToolStripMenuItem
    Friend WithEvents menuNuevo As ToolStripMenuItem
    Friend WithEvents menuSalir As ToolStripMenuItem
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnPedido As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Fecha As Label
    Friend WithEvents mkFecha As MaskedTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
