Public Class interpolaciones

    Private Sub interpolaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        salida.Text = -((((Val(grande1.Text) - Val(mediano1.Text)) * (Val(grande2.Text) - Val(chico2.Text))) / (Val(grande1.Text) - Val(chico1.Text))) - Val(grande2.Text))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        grande1.Text = ""
        grande2.Text = ""

        chico1.Text = ""
        chico2.Text = ""

        mediano1.Text = ""

        salida.Text = "Salida"
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackgroundImage = My.Resources.Sin_título_21_03
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackgroundImage = My.Resources.Sin_título_2_031
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackgroundImage = My.Resources.Sin_título_21_06
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackgroundImage = My.Resources.Sin_título_2_06
    End Sub
End Class