Public Class FrmPrincipal
    Private Sub FPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PanelContenido(FrmInicio)

    End Sub

    Public Sub PanelContenido(ByVal Formulario As Form)

        Panel1.Controls.Clear()
        Formulario.TopLevel = False
        Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Formulario.Dock = DockStyle.Fill
        Panel1.Controls.Add(Formulario)

        Formulario.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Call PanelContenido(FBibliotecario)
        FBibliotecario.CargarListaBibliotecario()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call PanelContenido(FrmInicio)
    End Sub
End Class