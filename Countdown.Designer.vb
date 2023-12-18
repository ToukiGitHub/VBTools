<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Countdown
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 36F, FontStyle.Bold)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(245, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 65)
        Label1.TabIndex = 0
        Label1.Text = "カウントダウンツール"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = Color.MediumSpringGreen
        Label2.Location = New Point(310, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(207, 50)
        Label2.TabIndex = 1
        Label2.Text = "現在日時："
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(-1, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 47)
        Label3.TabIndex = 2
        Label3.Text = "指定日時："
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(581, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 47)
        Label4.TabIndex = 3
        Label4.Text = "時"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(708, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 47)
        Label5.TabIndex = 4
        Label5.Text = "分"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(835, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 47)
        Label6.TabIndex = 5
        Label6.Text = "秒"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.AllowDrop = True
        DateTimePicker1.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(179, 150)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(315, 54)
        DateTimePicker1.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownHeight = 100
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.Location = New Point(509, 149)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(72, 55)
        ComboBox1.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownHeight = 100
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.Location = New Point(636, 149)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(72, 55)
        ComboBox2.TabIndex = 8
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownHeight = 100
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Yu Gothic UI", 26.25F, FontStyle.Bold)
        ComboBox3.FormattingEnabled = True
        ComboBox3.IntegralHeight = False
        ComboBox3.Location = New Point(763, 149)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(72, 55)
        ComboBox3.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.ForeColor = Color.MediumSpringGreen
        Label7.Location = New Point(278, 236)
        Label7.Name = "Label7"
        Label7.Size = New Size(329, 50)
        Label7.TabIndex = 10
        Label7.Text = "指定日時まで残り："
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.ForeColor = Color.Crimson
        Label8.Location = New Point(229, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(426, 65)
        Label8.TabIndex = 11
        Label8.Text = "指定日時まで残り："
        ' 
        ' FormCountdown
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(884, 411)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormCountdown"
        Text = "株式会社Bloom Basis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
