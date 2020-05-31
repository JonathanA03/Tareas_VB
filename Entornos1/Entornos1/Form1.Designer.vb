<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.v1 = New System.Windows.Forms.Label()
        Me.v2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.checkSuma = New System.Windows.Forms.CheckBox()
        Me.checkResta = New System.Windows.Forms.CheckBox()
        Me.checkDiv = New System.Windows.Forms.CheckBox()
        Me.checkMult = New System.Windows.Forms.CheckBox()
        Me.checkRaiz = New System.Windows.Forms.CheckBox()
        Me.checkPotencia = New System.Windows.Forms.CheckBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.txtPotencia = New System.Windows.Forms.TextBox()
        Me.txtRaiz = New System.Windows.Forms.TextBox()
        Me.txtMulti = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'v1
        '
        Me.v1.AutoSize = True
        Me.v1.Location = New System.Drawing.Point(68, 82)
        Me.v1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.v1.Name = "v1"
        Me.v1.Size = New System.Drawing.Size(57, 17)
        Me.v1.TabIndex = 0
        Me.v1.Text = "Valor 1:"
        '
        'v2
        '
        Me.v2.AutoSize = True
        Me.v2.Location = New System.Drawing.Point(340, 82)
        Me.v2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.v2.Name = "v2"
        Me.v2.Size = New System.Drawing.Size(57, 17)
        Me.v2.TabIndex = 2
        Me.v2.Text = "Valor 2:"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(164, 79)
        Me.txtValor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(132, 22)
        Me.txtValor1.TabIndex = 3
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(465, 82)
        Me.txtValor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(132, 22)
        Me.txtValor2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 436)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 436)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'checkSuma
        '
        Me.checkSuma.AutoSize = True
        Me.checkSuma.Location = New System.Drawing.Point(71, 153)
        Me.checkSuma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkSuma.Name = "checkSuma"
        Me.checkSuma.Size = New System.Drawing.Size(66, 21)
        Me.checkSuma.TabIndex = 16
        Me.checkSuma.Text = "Suma"
        Me.checkSuma.UseVisualStyleBackColor = True
        '
        'checkResta
        '
        Me.checkResta.AutoSize = True
        Me.checkResta.Location = New System.Drawing.Point(71, 225)
        Me.checkResta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkResta.Name = "checkResta"
        Me.checkResta.Size = New System.Drawing.Size(67, 21)
        Me.checkResta.TabIndex = 17
        Me.checkResta.Text = "Resta"
        Me.checkResta.UseVisualStyleBackColor = True
        '
        'checkDiv
        '
        Me.checkDiv.AutoSize = True
        Me.checkDiv.Location = New System.Drawing.Point(71, 290)
        Me.checkDiv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkDiv.Name = "checkDiv"
        Me.checkDiv.Size = New System.Drawing.Size(79, 21)
        Me.checkDiv.TabIndex = 18
        Me.checkDiv.Text = "División"
        Me.checkDiv.UseVisualStyleBackColor = True
        '
        'checkMult
        '
        Me.checkMult.AutoSize = True
        Me.checkMult.Location = New System.Drawing.Point(343, 153)
        Me.checkMult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkMult.Name = "checkMult"
        Me.checkMult.Size = New System.Drawing.Size(114, 21)
        Me.checkMult.TabIndex = 19
        Me.checkMult.Text = "Multiplicación"
        Me.checkMult.UseVisualStyleBackColor = True
        '
        'checkRaiz
        '
        Me.checkRaiz.AutoSize = True
        Me.checkRaiz.Location = New System.Drawing.Point(343, 225)
        Me.checkRaiz.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkRaiz.Name = "checkRaiz"
        Me.checkRaiz.Size = New System.Drawing.Size(58, 21)
        Me.checkRaiz.TabIndex = 20
        Me.checkRaiz.Text = "Raíz"
        Me.checkRaiz.UseVisualStyleBackColor = True
        '
        'checkPotencia
        '
        Me.checkPotencia.AutoSize = True
        Me.checkPotencia.Location = New System.Drawing.Point(343, 290)
        Me.checkPotencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkPotencia.Name = "checkPotencia"
        Me.checkPotencia.Size = New System.Drawing.Size(85, 21)
        Me.checkPotencia.TabIndex = 21
        Me.checkPotencia.Text = "Potencia"
        Me.checkPotencia.UseVisualStyleBackColor = True
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(164, 153)
        Me.txtSuma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.ReadOnly = True
        Me.txtSuma.Size = New System.Drawing.Size(132, 22)
        Me.txtSuma.TabIndex = 24
        '
        'txtResta
        '
        Me.txtResta.Location = New System.Drawing.Point(164, 225)
        Me.txtResta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.ReadOnly = True
        Me.txtResta.Size = New System.Drawing.Size(132, 22)
        Me.txtResta.TabIndex = 25
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(164, 288)
        Me.txtDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.ReadOnly = True
        Me.txtDivision.Size = New System.Drawing.Size(132, 22)
        Me.txtDivision.TabIndex = 26
        '
        'txtPotencia
        '
        Me.txtPotencia.Location = New System.Drawing.Point(465, 288)
        Me.txtPotencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPotencia.Name = "txtPotencia"
        Me.txtPotencia.ReadOnly = True
        Me.txtPotencia.Size = New System.Drawing.Size(132, 22)
        Me.txtPotencia.TabIndex = 29
        '
        'txtRaiz
        '
        Me.txtRaiz.Location = New System.Drawing.Point(465, 225)
        Me.txtRaiz.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRaiz.Name = "txtRaiz"
        Me.txtRaiz.ReadOnly = True
        Me.txtRaiz.Size = New System.Drawing.Size(132, 22)
        Me.txtRaiz.TabIndex = 28
        '
        'txtMulti
        '
        Me.txtMulti.Location = New System.Drawing.Point(465, 153)
        Me.txtMulti.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMulti.Name = "txtMulti"
        Me.txtMulti.ReadOnly = True
        Me.txtMulti.Size = New System.Drawing.Size(132, 22)
        Me.txtMulti.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 505)
        Me.Controls.Add(Me.txtPotencia)
        Me.Controls.Add(Me.txtRaiz)
        Me.Controls.Add(Me.txtMulti)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.checkPotencia)
        Me.Controls.Add(Me.checkRaiz)
        Me.Controls.Add(Me.checkMult)
        Me.Controls.Add(Me.checkDiv)
        Me.Controls.Add(Me.checkResta)
        Me.Controls.Add(Me.checkSuma)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.v2)
        Me.Controls.Add(Me.v1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Mi Primer App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents v1 As Label
    Friend WithEvents v2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents checkSuma As CheckBox
    Friend WithEvents checkResta As CheckBox
    Friend WithEvents checkDiv As CheckBox
    Friend WithEvents checkMult As CheckBox
    Friend WithEvents checkRaiz As CheckBox
    Friend WithEvents checkPotencia As CheckBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents txtPotencia As TextBox
    Friend WithEvents txtRaiz As TextBox
    Friend WithEvents txtMulti As TextBox
End Class
