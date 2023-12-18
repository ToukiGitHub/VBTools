
Public Class CreatPassword
    Public arrUpperLetter = New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Public arrLowerLetter = New String() {"a", "b", "c", "d", "e", "f", "g", "g", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Public arrNum = New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Public arrSymbol = New String() {"/", "*", "-", "+", ".", "!", "#", "$", "%", "(", ")", "~", "|", "_", "@", "[", "]", "^"}
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myModule.LoadForm(Me)
        AddSymbolCheckbox()

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
        For Each it In arrSymbol
            Dim checkBox As New CheckBox()
            checkBox.Text = it
            checkBox.Size = New Size(60, 50)
            checkBox.Font = New Font("Yu Gothic UI", 18, FontStyle.Bold)
            checkBox.ForeColor = Color.White
            ' PanelにCheckBoxを追加
            FlowLayoutPanel1.Controls.Add(checkBox)
            checkBox.Checked = True
        Next
    End Sub

    Private Sub SetSymbolValue(ByVal v As Boolean)
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                checkBox.Checked = v
                If CheckBox4.Checked = True Then
                    checkBox.Enabled = True
                Else
                    checkBox.Enabled = False
                End If
            End If
        Next
    End Sub

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
End Class