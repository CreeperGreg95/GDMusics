Public Class SMPlay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        StereoMadness.Show()
        'My.Computer.FileSystem.DeleteFile("C:\GD\StereoMadness.mp3",
        'Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        'Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)
    End Sub
End Class