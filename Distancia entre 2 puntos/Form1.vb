Public Class Form1
    Private Sub Distancia()
        'Declaramos 5 variables de tipo double
        Dim x1, x2, y1, y2, distancia As Double
        'Condición que evalúa los TextBox si están vacios 
        If TextBox_Y2.Text = "" Then
            MessageBox.Show("Ingrese la distancia de Y2", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Colocamos el focus en el TextBox_Y2
            TextBox_Y2.Focus()
        Else
            'Condición que evalúa los TextBox si están vacios 
            If TextBox_Y1.Text = "" Then
                MessageBox.Show("Ingrese la distancia de Y1", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Colocamos el focus en el TextBox_Y2
                TextBox_Y1.Focus()
            Else
                'Condición que evalúa los TextBox si están vacios 
                If TextBox_X1.Text = "" Then
                    MessageBox.Show("Ingrese la distancia de X1", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Colocamos el focus en el TextBox_Y2
                    TextBox_X1.Focus()
                Else
                    'Condición que evalúa los TextBox si están vacios 
                    If TextBox_X2.Text = "" Then
                        MessageBox.Show("Ingrese la distancia de X2", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Colocamos el focus en el TextBox_Y2
                        TextBox_X2.Focus()
                    Else
                        'Funciones que convierte en un tipo double el valor que se ingrese por 
                        'los TextBox y lo almacena en las variables x1,x2,y1,y2 
                        x1 = Convert.ToDouble(TextBox_X1.Text())
                        x2 = Convert.ToDouble(TextBox_X2.Text())
                        y1 = Convert.ToDouble(TextBox_Y1.Text())
                        y2 = Convert.ToDouble(TextBox_Y2.Text())
                        'Fórmula para sacar la distancia entre los 2 puntos 
                        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))
                        'Mostraremos el resultado que este almacenado en la variable 
                        'distancia en la Label_Distancia 
                        Label_Distancia.Text = distancia.ToString()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        TextBox_X1.Text = ""
        TextBox_X2.Text = ""
        TextBox_Y1.Text = ""
        TextBox_Y2.Text = ""
        Label_Distancia.Text = "0"
        TextBox_Y2.Focus()

    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        Distancia()
    End Sub
End Class
