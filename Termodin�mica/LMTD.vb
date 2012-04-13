Public Class LMTD

   
    Private Sub Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.Click
        Dim u As Double
        ''hora de sacar la formula ponerla aqui y ver que todo funcione :)!
        If (ComboBox1.Text = "Agua-Agua") Then
            u = 210
        End If

        If (ComboBox1.Text = "Agua-Solventes Organicos") Then
            u = 87.5
        End If

        If (ComboBox1.Text = "Agua-Gases") Then
            u = 23.8
        End If

        If (ComboBox1.Text = "Agua-Aceites Livianos") Then
            u = 110
        End If

        If (ComboBox1.Text = "Agua-Aceites Pesados") Then
            u = 27.5
        End If

        If (ComboBox1.Text = "Aceites Livianos-Solventes Organicos") Then
            u = 45
        End If
        If (ComboBox1.Text = "Salmuera-Agua") Then
            u = 157.5
        End If
        If (ComboBox1.Text = "Salmuera-Solventes Organicos") Then
            u = 58
        End If
        If (ComboBox1.Text = "Salmuera-Gases") Then
            u = 23.8
        End If
        If (ComboBox1.Text = "Solventes Organicos-Solventes Organicos") Then
            u = 41
        End If
        If (ComboBox1.Text = "Aceites Pesados-Aceites Pesados") Then
            u = 26
        End If
        Dim lmtd As Double
        Dim tci, tcf, tfi, tff As Double
        tci = Convert.ToDouble(Ci.Text)
        tcf = Convert.ToDouble(Cf.Text)
        tfi = Convert.ToDouble(Fi.Text)
        tff = Convert.ToDouble(Ff.Text)
        lmtd = ((tci - tfi) - (tcf - tff)) / (Math.Log((tci - tfi) / (tcf - tff)))
        If (lmtd < 0) Then
            lmtd = lmtd * -1
        End If
        Label1.Text = (Convert.ToDouble(Cp.Text) / (u * lmtd))

    End Sub

    Private Sub Calcular_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.MouseEnter
        Me.Calcular.BackgroundImage = My.Resources.Sin_título_21_03
    End Sub

    Private Sub Calcular_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.MouseLeave
        Me.Calcular.BackgroundImage = My.Resources.Sin_título_2_031
    End Sub
End Class