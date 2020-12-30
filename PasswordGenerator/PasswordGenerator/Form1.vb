Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim minusculas(25) As Char
        Dim mayusculas(25) As Char
        Dim numeros(9) As Char
        Dim caracteres(21) As Char
        Dim c As Integer
        c = 0
        For i As Integer = 97 To 122 Step 1
            minusculas(c) = Convert.ToChar(i)
            c += 1
        Next
        c = 0
        For i As Integer = 65 To 90 Step 1
            mayusculas(c) = Convert.ToChar(i)
            c += 1
        Next
        c = 0
        For i As Integer = 48 To 57 Step 1
            numeros(c) = Convert.ToChar(i)
            c += 1
        Next
        c = 0
        For i As Integer = 33 To 47 Step 1
            caracteres(c) = Convert.ToChar(i)
            c += 1
        Next
        For i As Integer = 58 To 64 Step 1
            caracteres(c) = Convert.ToChar(i)
            c += 1
        Next

        If (Checkmin.Checked = False And Checkmay.Checked = False And checknum.Checked = False And checkesp.Checked = False) Then
            MessageBox.Show("Debes seleccionar al menos una opción")
        Else
            Dim t() As Char = {}
            Dim cadenafinal() As Char
            cadenafinal = t.Concat(t).ToArray
            If (Checkmin.Checked = True) Then
                cadenafinal = cadenafinal.Concat(minusculas).ToArray
            End If
            If (Checkmay.Checked = True) Then
                cadenafinal = cadenafinal.Concat(mayusculas).ToArray
            End If
            If (checknum.Checked = True) Then
                cadenafinal = cadenafinal.Concat(numeros).ToArray
            End If
            If (checkesp.Checked = True) Then
                cadenafinal = cadenafinal.Concat(caracteres).ToArray
            End If
            Dim password As String
            For i As Integer = 1 To NumericUpDown1.Value Step 1
                Randomize()
                Dim aleatorio = CLng((0 - (cadenafinal.Length - 1)) * Rnd() + (cadenafinal.Length - 1))

                password = password + cadenafinal(aleatorio)
            Next

            TextBox1.Clear()
            TextBox1.Text = password
            If CheckBox6.Checked = True Then
                Clipboard.Clear()
                Clipboard.SetText(password)
            End If
        End If


    End Sub
End Class
