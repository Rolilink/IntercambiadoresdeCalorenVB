Public Class main

    Private Sub interpola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interpola.Click

        interpolaciones.Show()

    End Sub

    Private Sub transforma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transforma.Click

        transformaciones.Show()

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub interpola_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interpola.MouseEnter
        Me.interpola.BackgroundImage = My.Resources.hoverint
    End Sub

    Private Sub interpola_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interpola.MouseLeave
        Me.interpola.BackgroundImage = My.Resources.st_03
    End Sub

    Private Sub transforma_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transforma.MouseEnter
        Me.transforma.BackgroundImage = My.Resources.hovertran
    End Sub

    Private Sub transforma_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transforma.MouseLeave
        Me.transforma.BackgroundImage = My.Resources.st_06
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackgroundImage = My.Resources.st_08
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackgroundImage = My.Resources.hoverlmtd
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackgroundImage = My.Resources.hoversalir
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackgroundImage = My.Resources.st_10
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LMTD.Show()
    End Sub
End Class
