Public Class Form1

    Dim rand As System.Random = New System.Random()

    Public Function RandomLetter() As String
        Dim charSet() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ".ToCharArray()
        Dim final As String = String.Empty
        final = charSet(rand.Next(charSet.Length - 1))
        Return final
    End Function

    Public Function RandomNum() As String
        Dim charSet() As Char = "1234567890".ToCharArray()
        Dim final As String = String.Empty
        final = charSet(rand.Next(charSet.Length - 1))
        Return final
    End Function

    Public Function RandomComplexChar() As String
        Dim charSet() As Char = "^°!\§$%&/()=?ß´`+*~#'äüÖÜÄö-_.:,;@€<>|".ToCharArray()
        Dim final As String = String.Empty
        final = charSet(rand.Next(charSet.Length - 1))
        Return final
    End Function


    Private Function RndStr(ByVal InitialString As String, len As Integer) As String
        Dim iStr As New System.Text.StringBuilder
        Dim rStr As New System.Text.StringBuilder
        iStr.Append(InitialString)
        Do While rStr.Length < len
            Dim idx As Integer = rand.Next(iStr.Length)
            rStr.Append(iStr(idx))
            iStr.Remove(idx, 1)
        Loop
        Return rStr.ToString
    End Function

    Private Function GenPass(ByVal len As Integer, chars As Boolean, nums As Boolean, complex As Boolean) As String
        Dim output As String = String.Empty
        If (chars = False AndAlso nums = False AndAlso complex = False) Then
            Dim NoCondText As String = "What should I generate your password from?"
            Return NoCondText
            PwTextBox.Text = NoCondText
        End If

        If output.Length < len Then
            For i As Integer = 1 To len
                If chars = True Then
                    output += RandomLetter()
                End If
                If nums = True Then
                    output += RandomNum()
                End If
                If complex = True Then
                    output += RandomComplexChar()
                End If
            Next
        End If
        Return RndStr(output, len)
    End Function

    Private Function RandTest()
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Dim sb As New System.Text.StringBuilder()
        Dim rand As New Random()
        Dim idx As Integer = rand.Next(0, validchars.Length)
        Dim randomChar As Char = validchars(idx)
        sb.Append(randomChar)


        Dim randomString = sb.ToString()
        Return randomString
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PwTextBox.Text = GenPass(PwLengthBar.Value, LettersCheckbox.Checked, NumbersCheckbox.Checked, ComplexCheckbox.Checked)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PwTextBox.Text = GenPass(PwLengthBar.Value, LettersCheckbox.Checked, NumbersCheckbox.Checked, ComplexCheckbox.Checked)
    End Sub

    Private Sub PwLengthBar_Scroll(sender As Object, e As EventArgs) Handles PwLengthBar.Scroll
        Label1.Text = PwLengthBar.Value
        PwTextBox.Text = GenPass(PwLengthBar.Value, LettersCheckbox.Checked, NumbersCheckbox.Checked, ComplexCheckbox.Checked)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(PwTextBox.Text.ToString)
        Button2.Text = "Copied!"
    End Sub

    Private Sub PwTextBox_TextChanged(sender As Object, e As EventArgs) Handles PwTextBox.TextChanged
        Button2.Text = "Copy to clipboard"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PwLengthBar.Maximum = 1024
        End If
        If CheckBox1.Checked = False Then
            PwLengthBar.Maximum = 64
        End If
    End Sub
End Class
