Module Resultados
    Const ingles = 150
    Const portugues = 80
    Const frances = 125
    Public index = 0
    Dim pparcial As Double
    Dim desc1 As Double

    Function PagoParcial(idioma As String) As Double
        Dim pago As Double
        If Form1.cb_dsabado.Checked And Form1.cb_dviernes.Checked Then
            Select Case Form1.cbx_idioma.SelectedIndex
                Case 0
                    pago = 2 * ingles * Form1.txt_horas.Text
                Case 1
                    pago = 2 * portugues * Form1.txt_horas.Text
                Case 2
                    pago = 2 * frances * Form1.txt_horas.Text
            End Select

        Else
            Select Case Form1.cbx_idioma.SelectedIndex
                Case 0
                    pago = 1 * ingles * Form1.txt_horas.Text
                Case 1
                    pago = 1 * portugues * Form1.txt_horas.Text
                Case 2
                    pago = 1 * frances * Form1.txt_horas.Text
            End Select

        End If
        pparcial = pago
        Return pago
    End Function

    Function Descuentos1(index1 As Byte) As Double
        Dim descuento1 As Double = 0
        Select Case index1
            Case 0
                descuento1 = pparcial * 0.02
            Case 1
                descuento1 = pparcial * 0.015
        End Select

        Return descuento1
    End Function

    Function Descuentos2() As Double
        Dim descuento2 As Double = 0

        If Form1.cb_dviernes.Checked And Form1.cb_dsabado.Checked Then
            descuento2 = pparcial * 0.05
        End If

        Return descuento2
    End Function

    Function PagoFinal() As Double

        Return PagoParcial(Form1.cbx_idioma.SelectedIndex) - Descuentos1(Form1.cbx_pago.SelectedIndex) - Descuentos2()
    End Function



End Module
