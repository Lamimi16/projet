<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txtisbn
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
        Textisbn = New TextBox()
        Textauteur = New TextBox()
        Texttitre = New TextBox()
        Btn_add = New Button()
        Btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(81, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(81, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 1
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label3.Location = New Point(72, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "auteur"
        ' 
        ' Textisbn
        ' 
        Textisbn.Location = New Point(143, 91)
        Textisbn.Name = "Textisbn"
        Textisbn.Size = New Size(100, 23)
        Textisbn.TabIndex = 3
        ' 
        ' Textauteur
        ' 
        Textauteur.Location = New Point(143, 230)
        Textauteur.Name = "Textauteur"
        Textauteur.Size = New Size(100, 23)
        Textauteur.TabIndex = 4
        ' 
        ' Texttitre
        ' 
        Texttitre.Location = New Point(143, 166)
        Texttitre.Name = "Texttitre"
        Texttitre.Size = New Size(100, 23)
        Texttitre.TabIndex = 5
        ' 
        ' Btn_add
        ' 
        Btn_add.Location = New Point(309, 284)
        Btn_add.Name = "Btn_add"
        Btn_add.Size = New Size(75, 37)
        Btn_add.TabIndex = 6
        Btn_add.Text = "ajouter"
        Btn_add.UseVisualStyleBackColor = True
        ' 
        ' Btn_afficher
        ' 
        Btn_afficher.Location = New Point(443, 284)
        Btn_afficher.Name = "Btn_afficher"
        Btn_afficher.Size = New Size(75, 37)
        Btn_afficher.TabIndex = 7
        Btn_afficher.Text = "afficher"
        Btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' txtisbn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_afficher)
        Controls.Add(Btn_add)
        Controls.Add(Texttitre)
        Controls.Add(Textauteur)
        Controls.Add(Textisbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "txtisbn"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Textisbn As TextBox
    Friend WithEvents Textauteur As TextBox
    Friend WithEvents Texttitre As TextBox
    Friend WithEvents Btn_add As Button
    Friend WithEvents Btn_afficher As Button

End Class
