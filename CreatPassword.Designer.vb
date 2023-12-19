<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatPassword
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
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        CheckBox5 = New CheckBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label4 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 36F, FontStyle.Bold)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(186, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 65)
        Label1.TabIndex = 0
        Label1.Text = "パスワード生成ツール"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = Color.SpringGreen
        Label2.Location = New Point(30, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 32)
        Label2.TabIndex = 1
        Label2.Text = "パスワード構成"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        CheckBox1.ForeColor = Color.SpringGreen
        CheckBox1.Location = New Point(177, 135)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(153, 36)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "大文字英字"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        CheckBox2.ForeColor = Color.SpringGreen
        CheckBox2.Location = New Point(359, 135)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(153, 36)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "小文字英字"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        CheckBox3.ForeColor = Color.SpringGreen
        CheckBox3.Location = New Point(541, 135)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(81, 36)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "数字"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        CheckBox4.ForeColor = Color.SpringGreen
        CheckBox4.Location = New Point(651, 135)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(81, 36)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "記号"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(175, 217)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(563, 130)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        CheckBox5.ForeColor = Color.SpringGreen
        CheckBox5.Location = New Point(177, 177)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(159, 36)
        CheckBox5.TabIndex = 8
        CheckBox5.Text = "すべての記号"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ForeColor = Color.SpringGreen
        Label3.Location = New Point(6, 356)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 32)
        Label3.TabIndex = 9
        Label3.Text = "パスワード文字数"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownHeight = 100
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.Location = New Point(189, 352)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(74, 40)
        ComboBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button1.Location = New Point(270, 352)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 40)
        Button1.TabIndex = 11
        Button1.Text = "パスワード生成"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ForeColor = Color.SpringGreen
        Label4.Location = New Point(322, 427)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 50)
        Label4.TabIndex = 12
        Label4.Text = "パスワード"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button2.Location = New Point(501, 352)
        Button2.Name = "Button2"
        Button2.Size = New Size(236, 40)
        Button2.TabIndex = 13
        Button2.Text = "パスワードをコピー"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CreatPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(804, 511)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(CheckBox5)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreatPassword"
        Text = "株式会社Bloom Basis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
