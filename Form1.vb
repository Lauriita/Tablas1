Public Class Form1

    Dim n1 As Integer
    Dim n2 As Integer
    Dim salida As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim res As Integer

        n1 = TextBox2.Text
        n2 = TextBox3.Text

        TextBox3.Clear()
        salida = ""

       For n3 As Integer = 0 To n2 Step 1

            res = n1 * n3
            salida = n1 & "x" & n3 & "=" & res
            TextBox1.Text = TextBox1.Text + salida & vbNewLine


        Next
    End Sub
End Class
