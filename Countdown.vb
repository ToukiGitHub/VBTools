﻿Public Class Countdown
    Private WithEvents timer1 As New Timer()
    Private Sub Formcountdow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myModule.LoadForm(Me)
        ' 時間設定
        SetTimeCombobox()
        ' 指定日時を初期化（明日に指定）
        DateTimePicker1.Value = DateTime.Today().AddDays(1)

        timer1.Interval = 1000 ' 1秒ごとに更新
        timer1.Start()
        AddHandler timer1.Tick, AddressOf Timer1_Tick
        UpdateClock()
    End Sub

    Private Sub Countdown_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        myModule.CloseToolForm(e)
    End Sub

    Private Sub SetTimeCombobox()
        Dim i As Int16
        For i = 0 To 23
            ComboBox1.Items.Add(i.ToString().PadLeft(2, "0"c))
        Next
        ComboBox1.SelectedIndex = 0
        For i = 0 To 59
            ComboBox2.Items.Add(i.ToString().PadLeft(2, "0"c))
            ComboBox3.Items.Add(i.ToString().PadLeft(2, "0"c))
        Next
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Function GetSpecifiedDateTime()
        Dim SpecifiedDateTime As New DateTime(Integer.Parse(DateTimePicker1.Value.Year),
                                      Integer.Parse(DateTimePicker1.Value.Month),
                                      Integer.Parse(DateTimePicker1.Value.Day),
                                      Integer.Parse(ComboBox1.SelectedItem),
                                      Integer.Parse(ComboBox2.SelectedItem),
                                      Integer.Parse(ComboBox3.SelectedItem))
        Return SpecifiedDateTime
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        UpdateClock()
    End Sub

    Private Sub UpdateClock()
        Label2.Text = $"現在日時：{DateTime.Now.ToString("yyyy年M月dd日 HH時mm分ss秒")}"
        ' 現在日時の表示を常にフォームの左右中央に配置
        Label2.Location = New Point((Me.Width - Label2.Width) \ 2, Label2.Top)
        ' 指定日時を取得
        Dim SpecifiedDateTime As DateTime = GetSpecifiedDateTime()
        If SpecifiedDateTime > DateTime.Now Then
            Label8.ForeColor = Color.MediumSpringGreen
            Dim timeDifference As TimeSpan = SpecifiedDateTime - DateTime.Now
            Label8.Text = $"{timeDifference.Days}日{timeDifference.Hours.ToString().PadLeft(2, "0"c)}時間{timeDifference.Minutes.ToString().PadLeft(2, "0"c)}分{timeDifference.Seconds.ToString().PadLeft(2, "0"c)}秒"
        Else
            Label8.ForeColor = Color.Crimson
            Label8.Text = "未来の日時を指定してください！"
        End If
        Label8.Location = New Point((Me.Width - Label8.Width) \ 2, Label8.Top)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label8.Focus()
    End Sub
End Class