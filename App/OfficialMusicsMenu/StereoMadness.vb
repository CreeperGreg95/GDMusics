Public Class StereoMadness
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        SMPlay.Show()

        'My.Computer.Network.DownloadFile("https://geometrydashmusics.000webhostapp.com/OriginalMusics/GeometryDash/Musics/StereoMadness.mp3", "C:\GD\StereoMadness.wav")
        MessageBox.Show("The server doesn't respond to the request and the app can't download and read the file.")
        'My.Computer.Audio.Play("C:\GD\StereoMadness.wav")

    End Sub
End Class