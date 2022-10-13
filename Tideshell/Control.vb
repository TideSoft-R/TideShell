Imports System.Math
Imports System.Drawing.Drawing2D
Public Class Control
    Public avatars As Integer
    Public sec, min, ch As Integer
    Public x1, x2, y1, y2, x3, y3, xt, yt As Integer, n, t As Double, gr As Graphics, pen1 As New Pen(Color.Black, 2), pen2 As New Pen(Color.DarkBlue, 3), pen3 As New Pen(Color.Chocolate, 4), br As New SolidBrush(Color.Black), font1 As New Font("Arial", 16)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Personalizations.SelectTab(1)
        ControlPanel.SelectTab(1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Useer.SelectTab(1)
        ControlPanel.SelectTab(2)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Avatarka.Text = OpenFileDialog1.FileName
            defava8.Image = Image.FromFile(Avatarka.Text)
            Tide.PictureBox1.Image = defava8.Image
            SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
        End If
        AvatarUser.Image = Tide.PictureBox1.Image
    End Sub
    Private Sub defava1_Click(sender As Object, e As EventArgs) Handles defava1.Click
        defava1.BorderStyle = BorderStyle.Fixed3D
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "1"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava2_Click(sender As Object, e As EventArgs) Handles defava2.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.Fixed3D
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "2"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava3_Click(sender As Object, e As EventArgs) Handles defava3.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.Fixed3D
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "3"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava4_Click(sender As Object, e As EventArgs) Handles defava4.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.Fixed3D
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "4"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava5_Click(sender As Object, e As EventArgs) Handles defava5.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.Fixed3D
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "5"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava6_Click(sender As Object, e As EventArgs) Handles defava6.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.Fixed3D
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "6"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava7_Click(sender As Object, e As EventArgs) Handles defava7.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.Fixed3D
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "7"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava8_Click(sender As Object, e As EventArgs) Handles defava8.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.Fixed3D
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "8"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava9_Click(sender As Object, e As EventArgs) Handles defava9.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.Fixed3D
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "9"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava10_Click(sender As Object, e As EventArgs) Handles defava10.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.Fixed3D
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "10"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava11_Click(sender As Object, e As EventArgs) Handles defava11.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.Fixed3D
        defava12.BorderStyle = BorderStyle.None
        avatars = "11"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub defava12_Click(sender As Object, e As EventArgs) Handles defava12.Click
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.Fixed3D
        avatars = "12"
        Avatarka.Text = ""
        SaveSetting("Tideshell", "personalization", "Avatarka", Avatarka.Text)
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If avatars = "1" Then
            PictureBoxAva.Image = im(1)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "1")
        ElseIf avatars = "2" Then
            PictureBoxAva.Image = im(2)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "2")
        ElseIf avatars = "3" Then
            PictureBoxAva.Image = im(3)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "3")
        ElseIf avatars = "4" Then
            PictureBoxAva.Image = im(4)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "4")
        ElseIf avatars = "5" Then
            PictureBoxAva.Image = im(5)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "5")
        ElseIf avatars = "6" Then
            PictureBoxAva.Image = im(6)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "6")
        ElseIf avatars = "7" Then
            PictureBoxAva.Image = im(7)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "7")
        ElseIf avatars = "8" Then
            PictureBoxAva.Image = im(8)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "8")
        ElseIf avatars = "9" Then
            PictureBoxAva.Image = im(9)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "9")
        ElseIf avatars = "10" Then
            PictureBoxAva.Image = im(10)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "10")
        ElseIf avatars = "11" Then
            PictureBoxAva.Image = im(11)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "11")
        ElseIf avatars = "12" Then
            PictureBoxAva.Image = im(12)
            Tide.PictureBox1.Image = PictureBoxAva.Image
            SaveSetting("Tideshell", "personalization", "avatars", "12")
        ElseIf avatars = "0" Then
            MsgBox("Пожалуйста выберите аватарку", 0 + 64, "Ошибка")
        End If
        AvatarUser.Image = Tide.PictureBox1.Image
        PictureBox5.Image = Tide.PictureBox1.Image
        defava1.BorderStyle = BorderStyle.None
        defava2.BorderStyle = BorderStyle.None
        defava3.BorderStyle = BorderStyle.None
        defava4.BorderStyle = BorderStyle.None
        defava5.BorderStyle = BorderStyle.None
        defava6.BorderStyle = BorderStyle.None
        defava7.BorderStyle = BorderStyle.None
        defava8.BorderStyle = BorderStyle.None
        defava9.BorderStyle = BorderStyle.None
        defava10.BorderStyle = BorderStyle.None
        defava11.BorderStyle = BorderStyle.None
        defava12.BorderStyle = BorderStyle.None
        avatars = "0"
    End Sub
    Private Sub None__Click(sender As Object, e As EventArgs) Handles None.Click
        Tide.oboi.BackgroundImageLayout = ImageLayout.None
        SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.None)
    End Sub
    Private Sub Zoom_Click(sender As Object, e As EventArgs) Handles Zoom.Click
        Tide.oboi.BackgroundImageLayout = ImageLayout.Zoom
        SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.Zoom)
    End Sub
    Private Sub Stretch_Click(sender As Object, e As EventArgs) Handles Stretch.Click
        Tide.oboi.BackgroundImageLayout = ImageLayout.Stretch
        SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.Stretch)
    End Sub
    Private Sub Tile_Click(sender As Object, e As EventArgs) Handles Tile.Click
        Tide.oboi.BackgroundImageLayout = ImageLayout.Tile
        SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.Tile)
    End Sub
    Private Sub Centre_Click(sender As Object, e As EventArgs) Handles Centre.Click
        Tide.oboi.BackgroundImageLayout = ImageLayout.Center
        SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.Center)
    End Sub
    Private Sub Noneimage_Click(sender As Object, e As EventArgs) Handles Noneimage.Click
        Tide.oboi.BackgroundImage = Nothing
        PictureBoxwallpaper.Image = Nothing
        TideWallpaper.Text = "Ничего"
        SaveSetting("tideshell", "personalization", "TideWallpaper", "Ничего")
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TideWallpaper.Text = OpenFileDialog1.FileName
            PictureBoxwallpaper.Image = Image.FromFile(TideWallpaper.Text)
            Tide.oboi.BackgroundImage = PictureBoxwallpaper.Image
            Tide.oboi.BackgroundImageLayout = ImageLayout.Stretch
            SaveSetting("Tideshell", "personalization", "TideWallpaper", TideWallpaper.Text)
            SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.Stretch)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If WriteName.Text = "" Then
            MsgBox("Пожалуйста введите имя", 0 + 64, "Ошибка")
        Else
            NameUser.Text = WriteName.Text
            UserName.Text = NameUser.Text
            SaveSetting("Tideshell", "Information", "Username", WriteName.Text)
            WriteName.Text = ""
            MsgBox("Информация была успешно изменена.", 0 + 64, "Уведомление")
        End If
    End Sub
    Private Sub TabPage7_Enter(sender As Object, e As EventArgs) Handles LeaveToHome.Enter, LeaveToHome.Enter
        ControlPanel.SelectTab(0)
    End Sub
    Private Sub LeaveToHome1_Enter(sender As Object, e As EventArgs) Handles LeaveToHome1.Enter
        ControlPanel.SelectTab(0)
    End Sub
    Private Sub LeaveToHome5_Enter(sender As Object, e As EventArgs) Handles LeaveToHome5.Enter
        ControlPanel.SelectTab(0)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AboutTideshelll.SelectTab(1)
        ControlPanel.SelectTab(6)
    End Sub
    Private Sub LeaveToHome2_Enter(sender As Object, e As EventArgs) Handles LeaveTOHome2.Enter
        ControlPanel.SelectTab(0)
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https:\\vk.com/tidesoft")
    End Sub
    Private Sub Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcntrl()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TimeDate.SelectTab(1)
        ControlPanel.SelectTab(3)
    End Sub
    Private Sub LeaveToHome3_Enter(sender As Object, e As EventArgs) Handles LeaveToHome3.Enter
        ControlPanel.SelectTab(0)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ResetTideShell.SelectTab(1)
        ControlPanel.SelectTab(4)
    End Sub
    Private Sub LeaveToHome4_Enter(sender As Object, e As EventArgs) Handles LeaveToHome4.Enter
        ControlPanel.SelectTab(0)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim r As String
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1400
        ProgressBar1.Value = 200
        r = MsgBox("Вы действительно хотите сбросить все настройки TideShell?", 64 + 4, "Сброс")
        If r = 6 Then
            Dim r1 As String
            ProgressBar1.Value = 400
            r1 = MsgBox("Вы уверены?", 64 + 4, "Сброс")
            If r1 = 6 Then
                SaveSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", "")
                ProgressBar1.Value = 600
                SaveSetting("Tideshell", "personalization", "avatars", "")
                ProgressBar1.Value = 800
                SaveSetting("Tideshell", "personalization", "TideWallpaper", "")
                ProgressBar1.Value = 1000
                SaveSetting("Tideshell", "personalization", "Avatarka", "")
                ProgressBar1.Value = 1200
                SaveSetting("Tideshell", "Information", "Username", "")
                Dim r2 As String
                ProgressBar1.Value = 1400
                r2 = MsgBox("Сброс окончен. Производится выключение оболочки...", 64 + 0, "Сброс")
                If r2 = 1 Then
                    End
                End If
                If r2 = 7 Then
                End If
            End If
            If r1 = 7 Then
                ProgressBar1.Value = 0
            End If
        End If
        If r = 7 Then
            ProgressBar1.Value = 0
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        time()
    End Sub
    Sub time()
        sec = Date.Now.Second
        min = Date.Now.Minute
        ch = Date.Now.Hour
        Dim bp As New Bitmap(250, 250)
        gr = Graphics.FromImage(bp)
        PictureBox1.Image = bp
        gr.ScaleTransform(1, -1)
        gr.TranslateTransform(125, -125)
        If ch > 12 Then ch -= 12
        x3 = Round(55 * Sin(6.28 * (ch + min / 60) / 12))
        y3 = Round(55 * Cos(6.28 * (ch + min / 60) / 12))
        gr.DrawLine(pen3, 0, 0, x3, y3)
        x2 = Round(65 * Sin(6.28 * min / 60))
        y2 = Round(65 * Cos(6.28 * min / 60))
        gr.DrawLine(pen2, 0, 0, x2, y2)
        x1 = Round(90 * Sin(6.28 * sec / 60))
        y1 = Round(90 * Cos(6.28 * sec / 60))
        gr.DrawLine(pen1, 0, 0, x1, y1)
        Dim D As Date = Now
        denb.Text = Format(D, "dddd")
        mesac.Text = Format(D, "MMMM")
        god.Text = Format(D, "yyyy")
        Timee.Text = Now.ToLongTimeString
        Data.Text = Now.Date
    End Sub
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim i As Byte
        gr = e.Graphics
        For i = 1 To 12
            xt = 115 + Math.Round(100 * Math.Sin(6.28 * 30 * i / 360))
            yt = 115 - Math.Round(100 * Math.Cos(6.28 * 30 * i / 360))
            gr.DrawString(i, font1, br, xt, yt)
        Next i
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TideshellUpdate.SelectTab(1)
        ControlPanel.SelectTab(5)
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        checkupdate()
    End Sub
    Sub checkupdate()
        'MsgBox("простите я тупой еблан который не может реализовать сайт для обновления. Чтобы узнавать вышел ли новый билд пишите vk.com/andrew.lentay")
        Dim verfile As String = "C:\tideshell\version.txt"
        If My.Computer.FileSystem.FileExists(verfile) Then My.Computer.FileSystem.DeleteFile(verfile)
        My.Computer.Network.DownloadFile("https://drive.google.com/u/0/uc?id=1jJI4Fv67z2gN7y3Pcpk78fYTppKIvbcQ&export=download", verfile)
        Dim lastver As String = My.Computer.FileSystem.ReadAllText(verfile)
        If Not ver = lastver Then
            If MsgBox("noviy bild?" & vbCrLf & "download?", vbYesNo) = MsgBoxResult.Yes Then
                Shell("update.exe")
                End
            End If
        End If
    End Sub
End Class