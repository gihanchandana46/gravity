Public Class Introduction

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        home.Show()
    End Sub

    Private Sub Introduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()
        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 17) & "FlashClips\"
        AxShockwaveFlash1.Movie = "" + fullPath + "\AttractItem.swf"
    End Sub

    
End Class