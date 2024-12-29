<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        L3 = New ListBox()
        L2 = New ListBox()
        L1 = New ListBox()
        Btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(481, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "Auteur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(284, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 2
        Label3.Text = "Titre"
        ' 
        ' L3
        ' 
        L3.FormattingEnabled = True
        L3.ItemHeight = 15
        L3.Location = New Point(481, 130)
        L3.Name = "L3"
        L3.Size = New Size(120, 154)
        L3.TabIndex = 3
        ' 
        ' L2
        ' 
        L2.FormattingEnabled = True
        L2.ItemHeight = 15
        L2.Location = New Point(263, 130)
        L2.Name = "L2"
        L2.Size = New Size(120, 154)
        L2.TabIndex = 4
        ' 
        ' L1
        ' 
        L1.FormattingEnabled = True
        L1.ItemHeight = 15
        L1.Location = New Point(96, 130)
        L1.Name = "L1"
        L1.Size = New Size(120, 154)
        L1.TabIndex = 5
        ' 
        ' Btn
        ' 
        Btn.Location = New Point(358, 303)
        Btn.Name = "Btn"
        Btn.Size = New Size(75, 23)
        Btn.TabIndex = 6
        Btn.Text = "afficher"
        Btn.UseVisualStyleBackColor = True
        ' 
        ' frm_afficher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn)
        Controls.Add(L1)
        Controls.Add(L2)
        Controls.Add(L3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_afficher"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents L3 As ListBox
    Friend WithEvents L2 As ListBox
    Friend WithEvents L1 As ListBox
    Friend WithEvents Btn As Button
End Class
