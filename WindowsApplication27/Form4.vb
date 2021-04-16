Imports System.IO


Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "85234352523379") Then
            Dim fw As StreamWriter
            fw = New StreamWriter("C:\Windows\Temp\datacount546\datacount.txt", False)
            fw.Write(1998032876)
            fw.Close()
            MsgBox("Activation Successful" & vbNewLine & "Thank You", MsgBoxStyle.OkOnly, "Activation")
            Close()
        Else
            MsgBox("Activation code is wrong", MsgBoxStyle.OkOnly, "Activation")
        End If
    End Sub
End Class