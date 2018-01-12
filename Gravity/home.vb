Public Class home

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub introButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles introButton.Click
        MyBase.Hide()
        Introduction.Show()


    End Sub

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim answer As MsgBoxResult
        answer = MsgBox("Do you want to quit now?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub ElmInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElmInfoButton.Click
        MyBase.Hide()
        Nlaw.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MyBase.Hide()
        NlawTest.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MyBase.Hide()
        Radius.Show()
    End Sub
End Class
