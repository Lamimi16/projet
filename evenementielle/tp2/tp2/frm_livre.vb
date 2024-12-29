Imports System.Net.NetworkInformation

Public Class txtisbn
    Private Sub Textisbn_TextChanged(sender As Object, e As EventArgs) Handles Textisbn.TextChanged

    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        Dim l As Livre
        l.ISBN = Textisbn.Text
        l.titre = Texttitre.Text
        l.auteur = Textauteur.Text
        If ajouterlivre(l) Then
            MessageBox.Show("ajout du livre avec succes")
        Else MessageBox.Show("le tableau bibliotheque est saturé")
        End If

    End Sub

    Private Sub Btn_afficher_Click(sender As Object, e As EventArgs) Handles Btn_afficher.Click
        frm_afficher.Show()


    End Sub
End Class
