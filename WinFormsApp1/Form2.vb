Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim et As New Etudiant
        et.Mat_et = CInt(a.Text)
        et.Nom_et = b.Text
        et.pre_et = c.Text
        et.Adress_et = d.Text
        et.Dat_et = data.Value
        V_et(ne) = et
        ne += 1
        If recherche(et.Mat_et, ne, V_et) = True Then
            MessageBox.Show("ajouter avec succés")
        End If

    End Sub
End Class