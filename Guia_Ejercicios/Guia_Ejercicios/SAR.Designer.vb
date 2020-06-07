<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SAR))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.PictureBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.btnRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salario del empleado"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(159, 21)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(134, 22)
        Me.txtSalario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sueldo Neto"
        '
        'txtSueldo
        '
        Me.txtSueldo.Enabled = False
        Me.txtSueldo.Location = New System.Drawing.Point(159, 180)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(134, 22)
        Me.txtSueldo.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(345, 21)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(78, 29)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(345, 180)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(66, 32)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(12, 234)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(56, 37)
        Me.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.TabStop = False
        '
        'txtMensaje
        '
        Me.txtMensaje.Enabled = False
        Me.txtMensaje.Location = New System.Drawing.Point(159, 152)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(134, 22)
        Me.txtMensaje.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(442, 283)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAR"
        CType(Me.btnRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As PictureBox
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
