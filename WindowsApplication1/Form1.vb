Import System.Windows.Forms
Public Class Form1

	Public Sub PrintSomething()

		MessageBox.Show("HEllo, World")

	End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("button 1")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("button 2")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MsgBox("Hello World1")
    End Sub
End Class
