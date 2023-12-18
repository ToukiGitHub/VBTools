Public Class MenuForm
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myModule.LoadForm(Me)
        ' FormStartPosition.CenterScreen何故か効かない？？？
        'Me.StartPosition = FormStartPosition.CenterScreen
        ' フォームをPC画面の中央に表示
        'Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        'Me.Location = New Point((screenWidth - Me.Width) \ 2, (screenHeight - Me.Height) \ 2)
        ' フォームのサイズを変更されない
        'Me.FormBorderStyle = FormBorderStyle.FixedDialog
    End Sub

    Private Sub FormMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' フォームが閉じられる前に確認メッセージを表示
        Dim result As DialogResult = MessageBox.Show("本当に閉じますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Yesが選択された場合はフォームを閉じる
        If result = DialogResult.No Then
            e.Cancel = True ' フォームの閉じる操作をキャンセル
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Countdown.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CreatPassword.Show()
        Me.Hide()
    End Sub
End Class
