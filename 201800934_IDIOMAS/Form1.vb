Public Class Form1
    Public index As Byte = 0
    Public matriz(10, 7) As String
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If index < 8 Then

            matriz(2, index) = fecha.Value

            If txt_carnet.Text <> "" Then
                matriz(0, index) = txt_carnet.Text
            Else
                MsgBox("Debe ingresar un carnet..")
                Exit Sub
            End If

            If txt_nombre.Text <> "" Then
                matriz(1, index) = txt_nom.Text
            Else
                MsgBox("Debe ingresar un nombre..")
                Exit Sub
            End If

            If cbx_pago.SelectedIndex <> -1 Then
                matriz(3, index) = cbx_pago.Text
            Else
                MsgBox("Debe seleccionar un metodo de pago..")
                Exit Sub
            End If

            If cbx_idioma.SelectedIndex <> -1 Then
                matriz(4, index) = cbx_idioma.Text
            Else
                MsgBox("Debe seleccionar un idioma..")
                Exit Sub
            End If

            If cb_dsabado.Checked And cb_dviernes.Checked Then
                matriz(5, index) = "Viernes - Sabado"

            ElseIf cb_dsabado.Checked Then
                matriz(5, index) = "Sabado"

            ElseIf cb_dviernes.Checked Then
                matriz(5, index) = "Viernes"

            Else
                MsgBox("Debe seleccionar al menos un dia..")
                Exit Sub
            End If

            If txt_horas.Text <> "" Then
                matriz(6, index) = txt_horas.Text
            Else
                MsgBox("Debe ingresar cantidad de horas..")
                Exit Sub
            End If

            matriz(7, index) = System.Math.Round(Resultados.PagoParcial(cbx_idioma.Text), 2)
            matriz(8, index) = System.Math.Round(Resultados.Descuentos1(cbx_pago.SelectedIndex), 2)
            matriz(9, index) = System.Math.Round(Resultados.Descuentos2, 2)
            matriz(10, index) = System.Math.Round(Resultados.PagoFinal, 2)

            tabla.Rows.Add(index + 1, matriz(0, index), matriz(1, index), matriz(2, index), matriz(3, index), matriz(4, index), matriz(5, index), matriz(6, index), matriz(7, index), matriz(8, index), matriz(9, index), matriz(10, index))
            index = index + 1
        Else
            MsgBox("Ya no hay mas espacios..")
            Exit Sub
        End If

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        txt_carnet.Clear()
        txt_carnet.Focus()
        txt_nom.Clear()
        txt_horas.Clear()
        cbx_idioma.SelectedIndex = -1
        cbx_pago.SelectedIndex = -1
        cb_dsabado.Checked = False
        cb_dviernes.Checked = False
    End Sub

    Private Sub LimpiarTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTablaToolStripMenuItem.Click
        'Aqui se limpia el datagridview
        tabla.DataSource = ""

        'aqui se limpia la matriz 
        For i = 0 To 10
            For j = 0 To 7
                matriz(i, j) = ""
            Next j
        Next i
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub
End Class
