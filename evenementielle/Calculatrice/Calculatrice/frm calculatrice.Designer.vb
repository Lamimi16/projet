<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(20, 21)
        Label1.TabIndex = 0
        Label1.Text = "B"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(74, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 21)
        Label2.TabIndex = 1
        Label2.Text = "A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(74, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 2
        Label3.Text = "Resultat"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(106, 271)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 49)
        Button1.TabIndex = 4
        Button1.Text = "="
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(126, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(130, 143)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.AppWorkspace
        Button2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(245, 271)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 49)
        Button2.TabIndex = 7
        Button2.Text = "RESET"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDark
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(106, 205)
        Button3.Name = "Button3"
        Button3.Size = New Size(55, 49)
        Button3.TabIndex = 8
        Button3.Text = "+"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.AppWorkspace
        Button4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.Location = New Point(166, 205)
        Button4.Name = "Button4"
        Button4.Size = New Size(53, 49)
        Button4.TabIndex = 9
        Button4.Text = "-"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.AppWorkspace
        Button5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.Location = New Point(225, 205)
        Button5.Name = "Button5"
        Button5.Size = New Size(56, 49)
        Button5.TabIndex = 10
        Button5.Text = "*"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.AppWorkspace
        Button6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Button6.ForeColor = SystemColors.ActiveCaptionText
        Button6.Location = New Point(287, 205)
        Button6.Name = "Button6"
        Button6.Size = New Size(52, 49)
        Button6.TabIndex = 11
        Button6.Text = "/"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
