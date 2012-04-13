Public Class transformaciones

  

    Private Sub Temperatura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Masa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ESTE ES EL BOTÓN DE "LIMPIAR" LIMPIARÁ TODOS LOS CAMPOS
        com1.ResetText()
        com2.ResetText()
        ComboBox1.ResetText()

        com1.Items.Clear()
        com2.Items.Clear()
        ComboBox1.ResetText()

        x.Text = ""


        respuesta.Visible = False


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'ESTE ES EL BOTÓN DE "CALCULAR"

        'ESTAS SON PARA CALCULAR LA TEMPERATURA********************************************************

        respuesta.Visible = True

        If ComboBox1.Text = "Temperatura" Then

            If com1.Text = "Farenheit" Then
                If com2.Text = "Celsius" Then
                    respuesta.Text = (5 / 9) * (x.Text - 32)
                End If

                If com2.Text = "Kelvin" Then
                    respuesta.Text = (5 / 9) * (x.Text - 32) + 273.15
                End If

                If com2.Text = "Ranking" Then
                    respuesta.Text = ((5 / 9) * (x.Text - 32) + 273.15) * 1.8
                End If
            End If

            If com1.Text = "Celsius" Then
                If com2.Text = "Farenheit" Then
                    respuesta.Text = (1.8) * x.Text + 32
                End If

                If com2.Text = "Kelvin" Then
                    respuesta.Text = x.Text + 273.15
                End If

                If com2.Text = "Ranking" Then
                    respuesta.Text = (x.Text + 273.15) * 1.8
                End If
            End If

            If com1.Text = "Kelvin" Then
                If com2.Text = "Celsius" Then
                    respuesta.Text = x.Text - 273.15
                End If

                If com2.Text = "Farenheit" Then
                    respuesta.Text = (x.Text - 273.15) * (9 / 5) + 32
                End If

                If com2.Text = "Ranking" Then
                    respuesta.Text = ((x.Text - 273.15) * (9 / 5) + 32) + 459.67
                End If
            End If

            If com1.Text = "Ranking" Then
                If com2.Text = "Celsius" Then
                    respuesta.Text = ((x.Text - 459.67) - 32) * (5 / 9)
                End If

                If com2.Text = "Farenheit" Then
                    respuesta.Text = x.Text - 459.67
                End If

                If com2.Text = "Kelvin" Then
                    respuesta.Text = (((x.Text - 459.67) - 32) * (5 / 9)) + 273.15
                End If
            End If
        End If
        'ESTAS SON PARA CALCULAR LA TEMPERATURA********************************************************

        'ESTAS SON PARA CALCULAR LA MASA***************************************************************

        If ComboBox1.Text = "Masa" Then
            If com1.Text = "Libra masa" Then
                If com2.Text = "Kilogramo" Then
                    respuesta.Text = (1 / 0.453592) * x.Text
                End If

                If com2.Text = "Slug" Then
                    respuesta.Text = ((1 / 0.453592) * x.Text) * 14.594
                End If

                If com2.Text = "Tonelada" Then
                    respuesta.Text = 2000 * x.Text
                End If
            End If

            If com1.Text = "Kilogramo" Then
                If com2.Text = "Libra masa" Then
                    respuesta.Text = 0.453592 * x.Text
                End If

                If com2.Text = "Slug" Then
                    respuesta.Text = 14.594 * x.Text
                End If

                If com2.Text = "Tonelada" Then
                    respuesta.Text = 1000 * x.Text
                End If
            End If

            If com1.Text = "Tonelada" Then
                If com2.Text = "Libra masa" Then
                    respuesta.Text = (1 / 2000) * x.Text
                End If

                If com2.Text = "Slug" Then
                    respuesta.Text = (1 / 1000) * x.Text * 14.594
                End If

                If com2.Text = "Kilogramo" Then
                    respuesta.Text = (1 / 1000) * x.Text
                End If
            End If

            If com1.Text = "Slug" Then
                If com2.Text = "Kilogramo" Then
                    respuesta.Text = (1 / 14.594) * x.Text
                End If

                If com2.Text = "Libra masa" Then
                    respuesta.Text = ((1 / 14.594) * x.Text) / 2.20462
                End If

                If com2.Text = "Tonelada" Then
                    respuesta.Text = ((1 / 14.594) * x.Text) * 1000
                End If
            End If
        End If
        'ESTAS SON PARA CALCULAR LA MASA***************************************************************

        'ESTAS SON PARA CALCULAR LA LONGITUD***********************************************************

        If ComboBox1.Text = "Longitud" Then
            If com1.Text = "Pie" Then
                If com2.Text = "Metro" Then
                    respuesta.Text = x.Text * 0.3048
                End If

                If com2.Text = "Pulgada" Then
                    respuesta.Text = (x.Text * 0.3048) / 0.0254
                End If

                If com2.Text = "Milla" Then
                    respuesta.Text = x.Text / 5280
                End If

                If com2.Text = "Centimetro" Then
                    respuesta.Text = x.Text * 0.3048 * 100
                End If

                If com2.Text = "Kilometro" Then
                    respuesta.Text = (0.3048 * x.Text) / 1000
                End If
            End If

            If com1.Text = "Metro" Then
                If com2.Text = "Pie" Then
                    respuesta.Text = x.Text / 0.3048
                End If

                If com2.Text = "Pulgada" Then
                    respuesta.Text = x.Text / 0.0254
                End If

                If com2.Text = "Milla" Then
                    respuesta.Text = x.Text * 0.6214 / 1000
                End If

                If com2.Text = "Centimetro" Then
                    respuesta.Text = x.Text * 100
                End If

                If com2.Text = "Kilometro" Then
                    respuesta.Text = x.Text / 1000
                End If
            End If

            If com1.Text = "Milla" Then
                If com2.Text = "Pie" Then
                    respuesta.Text = x.Text * 5280
                End If

                If com2.Text = "Pulgada" Then
                    respuesta.Text = ((x.Text * 5280) * 0.3048) / 0.0254
                End If

                If com2.Text = "Metro" Then
                    respuesta.Text = (x.Text * 5280) * 0.3048
                End If

                If com2.Text = "Centimetro" Then
                    respuesta.Text = ((x.Text * 5280) * 0.3048) * 100
                End If

                If com2.Text = "Kilometro" Then
                    respuesta.Text = ((x.Text * 5280) * 0.3048) / 1000
                End If
            End If

            If com1.Text = "Centimetro" Then
                If com2.Text = "Pie" Then
                    respuesta.Text = (x.Text / 100) * 3.281
                End If

                If com2.Text = "Pulgada" Then
                    respuesta.Text = x.Text * 0.3937
                End If

                If com2.Text = "Metro" Then
                    respuesta.Text = x.Text / 100
                End If

                If com2.Text = "Milla" Then
                    respuesta.Text = ((x.Text / 100) / 1000) * 0.6214
                End If

                If com2.Text = "Kilometro" Then
                    respuesta.Text = (x.Text / 100) / 1000
                End If
            End If

            If com1.Text = "Kilometro" Then
                If com2.Text = "Pie" Then
                    respuesta.Text = x.Text * 1000 / 0.3048
                End If

                If com2.Text = "Pulgada" Then
                    respuesta.Text = x.Text * 1000 / 0.0254
                End If

                If com2.Text = "Metro" Then
                    respuesta.Text = x.Text * 1000
                End If

                If com2.Text = "Milla" Then
                    respuesta.Text = x.Text / 0.6214
                End If

                If com2.Text = "Centimetro" Then
                    respuesta.Text = (x.Text * 1000) * 100
                End If
            End If

            If com1.Text = "Pulgada" Then
                If com2.Text = "Pie" Then
                    respuesta.Text = (x.Text * 0.0254) / 0.3048
                End If

                If com2.Text = "Kilometro" Then
                    respuesta.Text = (x.Text * 0.0254) / 1000
                End If

                If com2.Text = "Metro" Then
                    respuesta.Text = x.Text * 0.0254
                End If

                If com2.Text = "Milla" Then
                    respuesta.Text = ((x.Text * 0.0254) / 1000) * 0.6214
                End If

                If com2.Text = "Centimetro" Then
                    respuesta.Text = x.Text / 0.3914
                End If
            End If
        End If

        'ESTAS SON PARA CALCULAR LA LONGITUD***********************************************************

        'ESTAS SON PARA CALCULAR PRESION **************************************************************

        If ComboBox1.Text = "Presion" Then
            If com1.Text = "Pa" Then
                If com2.Text = "N/m^2" Then
                    respuesta.Text = x.Text
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = (x.Text / 1000) * 0.145038
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = x.Text / 1000
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = (x.Text / 1000) / 3.387
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = (x.Text / 1000) / 100
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = (x.Text / 1000) / 101.325
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = (x.Text / 1000) / 0.1333
                End If
            End If

            If com1.Text = "N/m^2" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = x.Text
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = (x.Text / 1000) * 0.145038
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = x.Text / 1000
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = (x.Text / 1000) / 3.387
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = (x.Text / 1000) / 100
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = (x.Text / 1000) / 101.325
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = (x.Text / 1000) / 0.1333
                End If
            End If

            If com1.Text = "psi" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = x.Text * 6.894757 * 1000
                End If

                If com2.Text = "N/m^2" Then
                    respuesta.Text = (x.Text * 6.894757 * 1000)
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = x.Text * 6.894757
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = (x.Text * 6.894757 * 1000) / 3.387
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = x.Text * 6.894757 / 100
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = x.Text * 6.894757 / 101.325
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = x.Text * 6.894757 / 0.1333
                End If
            End If

            If com1.Text = "kPa" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = x.Text * 1000
                End If

                If com2.Text = "N/m^2" Then
                    respuesta.Text = x.Text * 1000
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = x.Text * 0.145038
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = x.Text * 0.145038 / 0.4912
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = x.Text / 100
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = x.Text / 101.325
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = x.Text / 0.1333
                End If
            End If

            If com1.Text = "in Hg" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = ((x.Text * 0.4912) * 6.894757) * 1000
                End If

                If com2.Text = "N/m^2" Then
                    respuesta.Text = ((x.Text * 0.4912) * 6.894757) * 1000
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = x.Text * 0.4912
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = ((x.Text * 0.4912) * 6.894757)
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = ((x.Text * 0.4912) * 6.894757) / 100
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = ((x.Text * 0.4912) * 6.894757) / 101.325
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = ((x.Text * 0.4912) * 6.894757) / 0.1333
                End If
            End If

            If com1.Text = "bar" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = x.Text * 100 * 1000
                End If

                If com2.Text = "N/m^2" Then
                    respuesta.Text = x.Text * 100 * 1000
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = (x.Text * 100) * 0.145038
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = (x.Text * 100)
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = (x.Text * 100) / 3.387
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = (x.Text * 100) / 101.325
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = (x.Text * 100) * 0.1333
                End If
            End If

            If com1.Text = "atm" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = x.Text * 101.325 * 1000
                End If

                If com2.Text = "N/m^2" Then
                    respuesta.Text = x.Text * 101.325 * 1000
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = x.Text * 14.696
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = x.Text * 101.325
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = (x.Text * 101.325) / 3.387
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = (x.Text * 101.325) / 100
                End If

                If com2.Text = "mm Hg" Then
                    respuesta.Text = (x.Text * 101.325) / 0.1333
                End If
            End If

            If com1.Text = "mm Hg" Then
                If com2.Text = "Pa" Then
                    respuesta.Text = x.Text * 0.1333 * 1000
                End If

                If com2.Text = "N/m^2" Then
                    respuesta.Text = x.Text * 0.1333 * 1000
                End If

                If com2.Text = "psi" Then
                    respuesta.Text = (x.Text * 0.1333 / 6.894757)
                End If

                If com2.Text = "kPa" Then
                    respuesta.Text = x.Text * 0.1333
                End If

                If com2.Text = "in Hg" Then
                    respuesta.Text = (x.Text * 0.1333 / 6.894757) / 0.4912
                End If

                If com2.Text = "bar" Then
                    respuesta.Text = x.Text * 0.1333 / 100
                End If

                If com2.Text = "atm" Then
                    respuesta.Text = x.Text * 0.1333 / 101.325
                End If
            End If

        End If

        'ESTAS SON PARA CALCULAR PRESION **************************************************************


        'ESTAS SON PARA CALCULAR SUPERFICIE **************************************************************

        If ComboBox1.Text = "Superficie" Then
            If com1.Text = "ft^2" Then
                If com2.Text = "in^2" Then
                    respuesta.Text = x.Text * 0.0929
                End If

                If com2.Text = "mm^2" Then
                    respuesta.Text = (x.Text * 0.0929) * 645.16
                End If

                If com2.Text = "m^2" Then
                    respuesta.Text = x.Text / 10.76
                End If

                If com2.Text = "cm^2" Then
                    respuesta.Text = (x.Text * 0.0929) / 0.155
                End If
            End If

            If com1.Text = "in^2" Then
                If com2.Text = "ft^2" Then
                    respuesta.Text = x.Text / 0.0929
                End If

                If com2.Text = "mm^2" Then
                    respuesta.Text = x.Text * 645.16
                End If

                If com2.Text = "m^2" Then
                    respuesta.Text = (x.Text / 0.0929) / 10.76
                End If

                If com2.Text = "cm^2" Then
                    respuesta.Text = x.Text / 0.155
                End If
            End If

            If com1.Text = "mm^2" Then
                If com2.Text = "ft^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "in^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "m^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "cm^2" Then
                    ''respuesta.Text = 
                End If
            End If

            If com1.Text = "m^2" Then
                If com2.Text = "ft^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "in^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "mm^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "cm^2" Then
                    ''respuesta.Text = 
                End If
            End If

            If com1.Text = "cm^2" Then
                If com2.Text = "ft^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "in^2" Then
                    'respuesta.Text = 
                End If

                If com2.Text = "mm^2" Then
                    ''respuesta.Text = 
                End If

                If com2.Text = "m^2" Then
                    ''respuesta.Text = 
                End If
            End If
        End If

        'ESTAS SON PARA CALCULAR PRESION **************************************************************

    End Sub

    Private Sub com1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com1.SelectedIndexChanged

        If ComboBox1.Text = "Temperatura" Then
            If com1.Text = "Celsius" Then
                com2.Items.Clear()
                com2.ResetText()
                com2.Items.Add("Farenheit")
                com2.Items.Add("Kelvin")
                com2.Items.Add("Ranking")
            Else
                If com1.Text = "Farenheit" Then
                    com2.Items.Clear()
                    com2.ResetText()
                    com2.Items.Add("Celsius")
                    com2.Items.Add("Kelvin")
                    com2.Items.Add("Ranking")
                Else
                    If com1.Text = "Kelvin" Then
                        com2.Items.Clear()
                        com2.ResetText()
                        com2.Items.Add("Celsius")
                        com2.Items.Add("Farenheit")
                        com2.Items.Add("Ranking")
                    Else
                        If com1.Text = "Ranking" Then
                            com2.Items.Clear()
                            com2.ResetText()
                            com2.Items.Add("Celsius")
                            com2.Items.Add("Farenheit")
                            com2.Items.Add("Kelvin")
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Masa" Then
            If com1.Text = "Libra masa" Then
                com2.Items.Clear()
                com2.ResetText()
                com2.Items.Add("Slug")
                com2.Items.Add("Tonelada")
                com2.Items.Add("Kilogramo")
            Else
                If com1.Text = "Slug" Then
                    com2.Items.Clear()
                    com2.ResetText()
                    com2.Items.Add("Libra masa")
                    com2.Items.Add("Tonelada")
                    com2.Items.Add("Kilogramo")
                Else
                    If com1.Text = "Tonelada" Then
                        com2.Items.Clear()
                        com2.ResetText()
                        com2.Items.Add("Libra masa")
                        com2.Items.Add("Slug")
                        com2.Items.Add("Kilogramo")
                    Else
                        If com1.Text = "Kilogramo" Then
                            com2.Items.Clear()
                            com2.ResetText()
                            com2.Items.Add("Libra masa")
                            com2.Items.Add("Slug")
                            com2.Items.Add("Tonelada")
                        End If
                    End If
                End If
            End If
        End If

        If ComboBox1.Text = "Longitud" Then
            If com1.Text = "Pie" Then
                com2.Items.Clear()
                com2.ResetText()
                com2.Items.Add("Metro")
                com2.Items.Add("Kilometro")
                com2.Items.Add("Centimetro")
                com2.Items.Add("Pulgada")
                com2.Items.Add("Milla")
            Else
                If com1.Text = "Metro" Then
                    com2.Items.Clear()
                    com2.ResetText()
                    com2.Items.Add("Pie")
                    com2.Items.Add("Kilometro")
                    com2.Items.Add("Centimetro")
                    com2.Items.Add("Pulgada")
                    com2.Items.Add("Milla")
                Else
                    If com1.Text = "Kilometro" Then
                        com2.Items.Clear()
                        com2.ResetText()
                        com2.Items.Add("Pie")
                        com2.Items.Add("Metro")
                        com2.Items.Add("Centimetro")
                        com2.Items.Add("Pulgada")
                        com2.Items.Add("Milla")
                    Else
                        If com1.Text = "Centimetro" Then
                            com2.Items.Clear()
                            com2.ResetText()
                            com2.Items.Add("Pie")
                            com2.Items.Add("Metro")
                            com2.Items.Add("Kilometro")
                            com2.Items.Add("Pulgada")
                            com2.Items.Add("Milla")
                        Else
                            If com1.Text = "Pulgada" Then
                                com2.Items.Clear()
                                com2.ResetText()
                                com2.Items.Add("Pie")
                                com2.Items.Add("Metro")
                                com2.Items.Add("Kilometro")
                                com2.Items.Add("Centimetro")
                                com2.Items.Add("Milla")
                            Else
                                If com1.Text = "Milla" Then
                                    com2.Items.Clear()
                                    com2.ResetText()
                                    com2.Items.Add("Pie")
                                    com2.Items.Add("Metro")
                                    com2.Items.Add("Kilometro")
                                    com2.Items.Add("Centimetro")
                                    com2.Items.Add("Pulgada")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        If ComboBox1.Text = "Presion" Then
            If com1.Text = "Pa" Then
                com2.Items.Clear()
                com2.ResetText()
                com2.Items.Add("N/m^2")
                com2.Items.Add("psi")
                com2.Items.Add("kPa")
                com2.Items.Add("in Hg")
                com2.Items.Add("mm Hg")
                com2.Items.Add("bar")
                com2.Items.Add("atm")
            Else
                If com1.Text = "N/m^2" Then
                    com2.Items.Clear()
                    com2.ResetText()
                    com2.Items.Add("Pa")
                    com2.Items.Add("psi")
                    com2.Items.Add("kPa")
                    com2.Items.Add("in Hg")
                    com2.Items.Add("mm Hg")
                    com2.Items.Add("bar")
                    com2.Items.Add("atm")
                Else
                    If com1.Text = "psi" Then
                        com2.Items.Clear()
                        com2.ResetText()
                        com2.Items.Add("Pa")
                        com2.Items.Add("N/m^2")
                        com2.Items.Add("kPa")
                        com2.Items.Add("in Hg")
                        com2.Items.Add("mm Hg")
                        com2.Items.Add("bar")
                        com2.Items.Add("atm")
                    Else
                        If com1.Text = "kPa" Then
                            com2.Items.Clear()
                            com2.ResetText()
                            com2.Items.Add("Pa")
                            com2.Items.Add("N/m^2")
                            com2.Items.Add("psi")
                            com2.Items.Add("in Hg")
                            com2.Items.Add("mm Hg")
                            com2.Items.Add("bar")
                            com2.Items.Add("atm")
                        Else
                            If com1.Text = "in Hg" Then
                                com2.Items.Clear()
                                com2.ResetText()
                                com2.Items.Add("Pa")
                                com2.Items.Add("N/m^2")
                                com2.Items.Add("psi")
                                com2.Items.Add("kPa")
                                com2.Items.Add("mm Hg")
                                com2.Items.Add("bar")
                                com2.Items.Add("atm")
                            Else
                                If com1.Text = "mm Hg" Then
                                    com2.Items.Clear()
                                    com2.ResetText()
                                    com2.Items.Add("Pa")
                                    com2.Items.Add("N/m^2")
                                    com2.Items.Add("psi")
                                    com2.Items.Add("kPa")
                                    com2.Items.Add("in Hg")
                                    com2.Items.Add("bar")
                                    com2.Items.Add("atm")
                                Else
                                    If com1.Text = "bar" Then
                                        com2.Items.Clear()
                                        com2.ResetText()
                                        com2.Items.Add("Pa")
                                        com2.Items.Add("N/m^2")
                                        com2.Items.Add("psi")
                                        com2.Items.Add("kPa")
                                        com2.Items.Add("in Hg")
                                        com2.Items.Add("mm Hg")
                                        com2.Items.Add("atm")
                                    Else
                                        If com1.Text = "atm" Then
                                            com2.Items.Clear()
                                            com2.ResetText()
                                            com2.Items.Add("Pa")
                                            com2.Items.Add("N/m^2")
                                            com2.Items.Add("psi")
                                            com2.Items.Add("kPa")
                                            com2.Items.Add("in Hg")
                                            com2.Items.Add("mm Hg")
                                            com2.Items.Add("bar")
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'Superficie********************************************************************************
        If ComboBox1.Text = "Superficie" Then
            If com1.Text = "ft^2" Then
                com2.Items.Clear()
                com2.ResetText()
                com2.Items.Add("in^2")
                com2.Items.Add("mm^2")
                com2.Items.Add("m^2")
                com2.Items.Add("cm^2")
            Else
                If com1.Text = "in^2" Then
                    com2.Items.Clear()
                    com2.ResetText()
                    com2.Items.Add("ft^2")
                    com2.Items.Add("mm^2")
                    com2.Items.Add("m^2")
                    com2.Items.Add("cm^2")
                Else
                    If com1.Text = "mm^2" Then
                        com2.Items.Clear()
                        com2.ResetText()
                        com2.Items.Add("ft^2")
                        com2.Items.Add("in^2")
                        com2.Items.Add("m^2")
                        com2.Items.Add("cm^2")
                    Else
                        If com1.Text = "m^2" Then
                            com2.Items.Clear()
                            com2.ResetText()
                            com2.Items.Add("ft^2")
                            com2.Items.Add("in^2")
                            com2.Items.Add("mm^2")
                            com2.Items.Add("cm^2")
                        Else
                            If com1.Text = "cm^2" Then
                                com2.Items.Clear()
                                com2.ResetText()
                                com2.Items.Add("ft^2")
                                com2.Items.Add("in^2")
                                com2.Items.Add("mm^2")
                                com2.Items.Add("m^2")
                            End If
                        End If
                    End If
                End If
            End If
        End If
        'Superficie********************************************************************************
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        com1.ResetText()
        com2.ResetText()

        If ComboBox1.Text = "Temperatura" Then
            com1.Items.Clear()
            com1.Items.Add("Celsius")
            com1.Items.Add("Farenheit")
            com1.Items.Add("Kelvin")
            com1.Items.Add("Ranking")
        Else
            If ComboBox1.Text = "Masa" Then
                com1.Items.Clear()
                com1.Items.Add("Kilogramo")
                com1.Items.Add("Tonelada")
                com1.Items.Add("Slug")
                com1.Items.Add("Libra masa")
            Else
                If ComboBox1.Text = "Longitud" Then
                    com1.Items.Clear()
                    com1.Items.Add("Pie")
                    com1.Items.Add("Metro")
                    com1.Items.Add("Milla")
                    com1.Items.Add("Pulgada")
                    com1.Items.Add("Centimetro")
                    com1.Items.Add("Kilometro")
                Else
                    If ComboBox1.Text = "Presion" Then
                        com1.Items.Clear()
                        com1.Items.Add("Pa")
                        com1.Items.Add("N/m^2")
                        com1.Items.Add("psi")
                        com1.Items.Add("kPa")
                        com1.Items.Add("in Hg")
                        com1.Items.Add("mm Hg")
                        com1.Items.Add("bar")
                        com1.Items.Add("atm")
                    Else
                        If ComboBox1.Text = "Superficie" Then
                            com1.Items.Clear()
                            com1.Items.Add("ft^2")
                            com1.Items.Add("in^2")
                            com1.Items.Add("mm^2")
                            com1.Items.Add("m^2")
                            com1.Items.Add("cm^2")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackgroundImage = My.Resources.hover_06
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackgroundImage = My.Resources.Sin_título_3_22
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackgroundImage = My.Resources.hover_03
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackgroundImage = My.Resources.Sin_título_3_19
    End Sub
End Class