Module myModule
    Public Sub LoadForm(ByRef myForm As Object)
        ' FormStartPosition.CenterScreen何故か効かない？？？
        'Me.StartPosition = FormStartPosition.CenterScreen
        ' フォームをPC画面の中央に表示
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        myForm.Location = New Point((screenWidth - myForm.Width) \ 2, (screenHeight - myForm.Height) \ 2)
        ' フォームのサイズを変更されない
        myForm.FormBorderStyle = FormBorderStyle.FixedDialog
    End Sub

    Public Sub CloseToolForm(e As FormClosingEventArgs)
        ' フォームが閉じられる前に確認メッセージを表示
        Dim result As DialogResult = MessageBox.Show("本当に閉じますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            ' フォームの閉じる操作をキャンセル
            e.Cancel = True
        Else
            ' Yesが選択された場合はMenuフォームを表示
            MenuForm.Show()
        End If
    End Sub
End Module
