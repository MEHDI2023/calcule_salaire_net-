Imports System.Security.Cryptography.Xml

Module Module1
    Public Class Etudiant
        Public Mat_et As Integer
        Public Nom_et As String
        Public pre_et As String
        Public Adress_et As String
        Public Dat_et As Date
    End Class
    Public V_et(30) As Etudiant
    Public ne As Integer
    Public Function recherche(mat As Integer, n As Integer, v() As Etudiant) As Boolean
        Dim i As Integer
        For i = 1 To n
            If (mat = v(i).Mat_et) Then
                Return False

            End If

        Next
        Return True
    End Function
End Module
