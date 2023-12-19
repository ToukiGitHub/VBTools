
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class CreatPassword
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myModule.LoadForm(Me)
        AddSymbolCheckbox()
        SetCombobox()
    End Sub

    Private Sub CreatPassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        myModule.CloseToolForm(e)

    End Sub
    Private Sub AddSymbolCheckbox()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        Dim arySymbol = New String() {"/", "*", "-", "+", ".", "!", "#", "$", "%", "(", ")", "~", "|", "_", "@", "[", "]", "^"}
        For Each it In arySymbol
            Dim checkBox As New CheckBox()
            checkBox.Text = it
            checkBox.Size = New Size(55, 50)
            checkBox.Font = New Font("Yu Gothic UI", 18, FontStyle.Bold)
            checkBox.ForeColor = Color.White
            ' PanelにCheckBoxを追加
            FlowLayoutPanel1.Controls.Add(checkBox)
        Next
        SetSymbolValue(True)
    End Sub

    Private Sub SetSymbolValue(ByVal v As Boolean)
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                checkBox.Checked = v
                If CheckBox4.Checked = False Or CheckBox5.Checked = True Then
                    checkBox.Enabled = False
                Else
                    checkBox.Enabled = True
                End If
            End If
        Next
    End Sub
    Private Sub SetCombobox()
        Dim intPasswordLen As Integer
        For intPasswordLen = 8 To 32
            ComboBox1.Items.Add(intPasswordLen)
        Next
        ComboBox1.SelectedIndex = 4
    End Sub

    Private Function GetSelectedSymbol() As String
        Dim strSymbol As String = ""
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                If checkBox.Checked Then
                    strSymbol += checkBox.Text
                End If
            End If
        Next
        Return strSymbol
    End Function

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        If CheckBox4.Checked = True Then
            CheckBox5.Checked = True
            CheckBox5.Enabled = True
        Else
            CheckBox5.Checked = False
            CheckBox5.Enabled = False
        End If
        SetSymbolValue(CheckBox5.Checked)
    End Sub
    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        SetSymbolValue(CheckBox5.Checked)
    End Sub

    Private Sub CreatePassword()
        Dim strUpperLetter As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim strLowerLetter As String = "abcdefggijklmnopqrstuvwxyz"
        Dim strNum As String = "0123456789"
        Dim strSource As String = ""
        Dim strPassword As String = ""
        '選択された文字種を最低1文字を使われるように
        If CheckBox1.Checked Then
            strPassword += strUpperLetter.Substring(Random.Shared.Next(26), 1)
            strSource += strUpperLetter
        End If
        If CheckBox2.Checked Then
            strPassword += strLowerLetter.Substring(Random.Shared.Next(26), 1)
            strSource += strLowerLetter
        End If
        If CheckBox3.Checked Then
            strPassword += strNum.Substring(Random.Shared.Next(10), 1)
            strSource += strNum
        End If
        Dim strSymbol As String = GetSelectedSymbol()
        Dim intSymbolLen As Integer = strSymbol.Length
        If intSymbolLen > 0 Then
            strPassword += strSymbol.Substring(Random.Shared.Next(intSymbolLen), 1)
            strSource += strSymbol
        End If
        Dim intSourceLen As Integer = strSource.Length
        Dim intPasswordLen As Integer = strPassword.Length
        '文字種1個以上選択されているかどうかを確認
        If intPasswordLen = 0 Then
            Label4.Text = "パスワード構成が選択されていません！"
            Label4.ForeColor = Color.DarkRed
        Else
            intPasswordLen = ComboBox1.SelectedItem - intPasswordLen
            For i = 1 To intPasswordLen
                strPassword += strSource.Substring(Random.Shared.Next(intSourceLen), 1)
            Next
            Label4.Text = strPassword
            Label4.ForeColor = Color.SpringGreen
        End If
        Label4.Location = New Point((Me.Width - Label4.Width) \ 2, Label4.Top)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreatePassword()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(Label4.Text)
    End Sub
End Class