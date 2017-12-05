Public Class formMain 

    Private Sub colorSelect(sender As Object, e As EventArgs) Handles btnDotColor.Click, btnLineColor.Click, btnBackground.Click
        Dim nColorDialog As New ColorDialog
        If nColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            DirectCast(sender, Button).BackColor = nColorDialog.Color
        End If
    End Sub

    Private Sub fontSelect(sender As Object, e As EventArgs) Handles btnFont1.Click, btnFont2.Click
        Dim nFontDialog As New FontDialog
        If nFontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            DirectCast(sender, Button).Font = nFontDialog.Font
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Captcha1.GenerateCaptcha(btnFont1.Font, btnFont2.Font, numDots.Value, btnDotColor.BackColor, numLines.Value, btnLineColor.BackColor, IIf(checkTransparent.Checked, Color.Transparent, btnBackground.BackColor))
    End Sub

    Private Sub checkTransparent_CheckedChanged(sender As Object, e As EventArgs) Handles checkTransparent.CheckedChanged
        If checkTransparent.Checked Then btnBackground.Enabled = False Else btnBackground.Enabled = True
    End Sub     

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        If checkCase.Checked Then
            If txtCaptchaInput.Text = Captcha1.answser Then MsgBox("Correct!") Else MsgBox("Incorrect!")
        Else
            If txtCaptchaInput.Text.ToLower = Captcha1.answser.ToLower Then MsgBox("Correct!") Else MsgBox("Incorrect!")
        End If
    End Sub   
End Class

Public Class Captcha
    Inherits Control
     
    Public answser As String

    Sub New()
        DoubleBuffered = True
    End Sub 

    Public Function generateString(x As Integer)
        Dim randomString As String = ""
        Static dict As String = "abcdefghjkmnpqrstuvwxyzABCDEFGHJKMNPQRSTUVWXYZ23456789"
        Static rnd As New System.Random()
        For i As Integer = 0 To 5 - 1
            randomString &= dict.Substring(rnd.Next(0, dict.Length - 1), 1)
        Next
        Return randomString
    End Function

    Public Function getRandom(min As Integer, max As Integer) As Integer
        Static rnd As New System.Random
        Return rnd.Next(min, max)
    End Function

    Public Sub GenerateCaptcha(font1 As Font, font2 As Font, dotCount As Integer, dotColor As Color, lineCount As Integer, lineColor As Color, backgroundColor As Color)
        Dim g As Graphics = CreateGraphics()
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality 
        answser = generateString(5)
        g.Clear(backgroundColor)

        For i As Integer = 1 To answser.Length
            Dim curChar As String = answser.Substring(i - 1, 1)
            Dim useFont As Font = IIf(i Mod 2 = 0, font1, font2) 
            g.TranslateTransform((Width / 5 * i) - Width / 5 / 2 - g.MeasureString(curChar, useFont).Width / 2, Height / 2 - g.MeasureString(curChar, useFont).Height / 2)
            g.RotateTransform(getRandom(-45, 45))
            g.DrawString(curChar, New Font(useFont.Name, 22), New SolidBrush(Color.FromArgb(getRandom(0, 255), getRandom(0, 255), getRandom(0, 255))), 0, 0)
            g.ResetTransform()
        Next

        For i As Integer = 0 To Math.Ceiling(lineCount / 2) - 1
            g.DrawLine(New Pen(lineColor), New Point(0, getRandom(0, Height)), New Point(Width, getRandom(0, Height)))
        Next
        For i As Integer = 0 To Math.Floor(lineCount / 2) - 1
            g.DrawLine(New Pen(lineColor), New Point(getRandom(0, Width), 0), New Point(getRandom(0, Width), Height))
        Next

        For i As Integer = 0 To dotCount - 1
            g.DrawEllipse(New Pen(dotColor), New Rectangle(New Point(getRandom(0, Width), getRandom(0, Height)), New Size(8, 8)))
        Next

        g.Dispose()
    End Sub
End Class