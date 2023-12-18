<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.MediumSpringGreen
        Label1.Location = New Point(32, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 65)
        Label1.TabIndex = 0
        Label1.Text = "VB.Net学習成果物"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.Font = New Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(117, 125)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 60)
        Button1.TabIndex = 1
        Button1.Text = "カウントダウン"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RoyalBlue
        Button2.Font = New Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(117, 200)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 60)
        Button2.TabIndex = 2
        Button2.Text = "パスワード生成"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(484, 361)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        ForeColor = Color.Black
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormMenu"
        Text = "株式会社Bloom Basis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
