Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim nota1, nota2, nota3, promedio As Double
        Dim condicion As String

        nota1 = txtnota1.Text
        nota2 = txtnota2.Text
        nota3 = txtnota3.Text

        promedio = (nota1 + nota2 + nota3) / 3

        If promedio <= 13 Then
            condicion = "DESPROBADO"
            txtcondicion.Text = condicion
            txtpromedio.Text = promedio

        ElseIf promedio >= 14 And promedio <= 20 Then
            condicion = "APROBADO"
            txtcondicion.Text = condicion
            txtpromedio.Text = promedio

        Else
            condicion = "NOTA FUERA DE RANGO"
            txtcondicion.Text = condicion
            txtpromedio.Text = promedio

        End If

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtnota1.Clear()
        txtnota2.Clear()
        txtnota3.Clear()
        txtcondicion.Clear()
        txtpromedio.Clear()

    End Sub
End Class
