'Patricia Hanus
'151109
'Alarm System
'____________________________________________________________________
Public Class Form1

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, _
        btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btnNumberClicked As Button = sender

        Me.txtPassword.Text &= btnNumberClicked.Tag

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Const PASSWORD As Integer = 62498
        Dim passwordAttempt As Integer = Val(Me.txtPassword.Text)

        If passwordAttempt = PASSWORD Then
            MessageBox.Show("Alarm system deactivated.")
            Application.Exit()
        Else
            MessageBox.Show("Password is incorrect.")
            Me.txtPassword.Text = Nothing
        End If
    End Sub
End Class
