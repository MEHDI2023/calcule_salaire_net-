Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Dim username As String = "Admin"
    Dim password As String = "Admin"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (l.Text = username And m.Text = password) Then
            MessageBox.Show("connexion réussie")
            Form11.Show()
            Me.Hide()
        ElseIf (l.Text = username And m.Text <> password) Then
            MessageBox.Show("Mot de passe incorrect")
            m.Clear()
            m.Focus()
        ElseIf (l.Text <> username And m.Text = password) Then
            MessageBox.Show("le nom d'utilisateur invalide")
            l.Clear()
            l.Focus()
        Else
            MessageBox.Show("les Données sont incorrectes")
            l.Clear()
            m.Clear()
            l.Focus()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l.Focus()
    End Sub
End Class