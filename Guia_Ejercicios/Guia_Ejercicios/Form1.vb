Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Calculadora.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Formula_Cuadratica.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Almacenes.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Números_Acumulados.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SAR.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ToolTip1.SetToolTip(PictureBox1, "Calculadora")
        ToolTip1.ToolTipTitle = "Formulario Calculadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        ToolTip1.SetToolTip(PictureBox2, "Formula Cuadrática")
        ToolTip1.ToolTipTitle = "Formula General"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        ToolTip1.SetToolTip(PictureBox5, "Almacenes")
        ToolTip1.ToolTipTitle = "Formulario Almacenes"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        ToolTip1.SetToolTip(PictureBox3, "Números acumulados")
        ToolTip1.ToolTipTitle = "Formulario Números"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        ToolTip1.SetToolTip(PictureBox4, "SAR")
        ToolTip1.ToolTipTitle = "Formulario SAR"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
