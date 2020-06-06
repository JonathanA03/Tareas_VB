<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Números_Acumulados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labe2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPositivos = New System.Windows.Forms.TextBox()
        Me.txtNegativos = New System.Windows.Forms.TextBox()
        Me.txtPares = New System.Windows.Forms.TextBox()
        Me.txtImpares = New System.Windows.Forms.TextBox()
        Me.txtSumaT = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNumeros = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Cuántos números desea ingresar?"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(293, 52)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(64, 17)
        Me.label.TabIndex = 1
        Me.label.Text = "Positivos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Negativos"
        '
        'labe2
        '
        Me.labe2.AutoSize = True
        Me.labe2.Location = New System.Drawing.Point(293, 134)
        Me.labe2.Name = "labe2"
        Me.labe2.Size = New System.Drawing.Size(45, 17)
        Me.labe2.TabIndex = 3
        Me.labe2.Text = "Pares"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(293, 173)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 17)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Impares"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Suma total"
        '
        'txtPositivos
        '
        Me.txtPositivos.Enabled = False
        Me.txtPositivos.Location = New System.Drawing.Point(374, 52)
        Me.txtPositivos.Name = "txtPositivos"
        Me.txtPositivos.Size = New System.Drawing.Size(102, 22)
        Me.txtPositivos.TabIndex = 6
        '
        'txtNegativos
        '
        Me.txtNegativos.Enabled = False
        Me.txtNegativos.Location = New System.Drawing.Point(374, 91)
        Me.txtNegativos.Name = "txtNegativos"
        Me.txtNegativos.Size = New System.Drawing.Size(102, 22)
        Me.txtNegativos.TabIndex = 7
        '
        'txtPares
        '
        Me.txtPares.Enabled = False
        Me.txtPares.Location = New System.Drawing.Point(374, 129)
        Me.txtPares.Name = "txtPares"
        Me.txtPares.Size = New System.Drawing.Size(102, 22)
        Me.txtPares.TabIndex = 8
        '
        'txtImpares
        '
        Me.txtImpares.Enabled = False
        Me.txtImpares.Location = New System.Drawing.Point(374, 173)
        Me.txtImpares.Name = "txtImpares"
        Me.txtImpares.Size = New System.Drawing.Size(102, 22)
        Me.txtImpares.TabIndex = 9
        '
        'txtSumaT
        '
        Me.txtSumaT.Enabled = False
        Me.txtSumaT.Location = New System.Drawing.Point(374, 209)
        Me.txtSumaT.Name = "txtSumaT"
        Me.txtSumaT.Size = New System.Drawing.Size(102, 22)
        Me.txtSumaT.TabIndex = 10
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(15, 72)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(118, 22)
        Me.txtCantidad.TabIndex = 11
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(15, 100)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 30)
        Me.btnIngresar.TabIndex = 12
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Números Ingresados"
        '
        'cmbNumeros
        '
        Me.cmbNumeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumeros.FormattingEnabled = True
        Me.cmbNumeros.Location = New System.Drawing.Point(15, 173)
        Me.cmbNumeros.Name = "cmbNumeros"
        Me.cmbNumeros.Size = New System.Drawing.Size(121, 24)
        Me.cmbNumeros.TabIndex = 14
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(172, 174)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 33)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Números_Acumulados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 259)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.cmbNumeros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtSumaT)
        Me.Controls.Add(Me.txtImpares)
        Me.Controls.Add(Me.txtPares)
        Me.Controls.Add(Me.txtNegativos)
        Me.Controls.Add(Me.txtPositivos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.labe2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Números_Acumulados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Números_Acumulados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labe2 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPositivos As TextBox
    Friend WithEvents txtNegativos As TextBox
    Friend WithEvents txtPares As TextBox
    Friend WithEvents txtImpares As TextBox
    Friend WithEvents txtSumaT As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbNumeros As ComboBox
    Friend WithEvents btnLimpiar As Button
End Class
