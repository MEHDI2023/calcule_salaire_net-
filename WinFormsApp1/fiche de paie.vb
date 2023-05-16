Public Class Form11
    Public s As Integer
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ll1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles f.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccm.SelectedIndexChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles o.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles salnet.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles l8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Text = CDbl(sbr.Text * 9.18) / 100


        sim.Text = CDbl(sbr.Text) - CDbl(cn.Text)
        If sim.Text > 0.000 And sim.Text < 5000.0 Then
            ir.Text = 0

        ElseIf sim.Text > 5000.001 And sim.Text < 20000.001 Then
            ir.Text = CDbl(sim.Text * 26) / 100

        ElseIf sim.Text > 20000.002 And sim.Text < 30000.0 Then
            ir.Text = CDbl(sim.Text * 28) / 100

        ElseIf sim.Text > 30000.001 And sim.Text < 50000.0 Then
            ir.Text = CDbl(sim.Text * 32) / 100

        ElseIf sim.Text > 50000.001 And sim.Text < 200000.0 Then
            ir.Text = CDbl(sim.Text * 30) / 100

        End If
        Dim ss As Integer
        If o.Checked = True Then
            ss += 300
        ElseIf n.Checked = True Then
            ss += 0
        End If
        ir.Text += ss

        s = CInt(nbr.Text) * 100

        ir.Text += s

        salnet.Text = CDbl(sim.Text) - CDbl(ir.Text)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles som.Click
        sbr.Text = CDbl(sbs.Text) + CDbl(av.Text) + CDbl(hs.Text * 1.75) + CInt(pr.Text)
        sb2.Text = CDbl(sbr.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b1.Click
        sbs.Text = CInt(sb.Text)
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub sim_TextChanged(sender As Object, e As EventArgs) Handles sim.TextChanged

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles l6.Click

    End Sub

    Private Sub hs_TextChanged(sender As Object, e As EventArgs) Handles hs.TextChanged

    End Sub

    Private Sub sb_TextChanged(sender As Object, e As EventArgs) Handles sb.TextChanged
        If Not IsNumeric(sb.Text) And Not IsNumeric(nbr.Text) Then

        Else
            b1.Enabled = True

        End If
    End Sub

    Private Sub nbr_TextChanged(sender As Object, e As EventArgs) Handles nbr.TextChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        s = CInt(nbr.Text) * 100

        Dim bb As String = "le charge d'enfant est : "
        Dim bc As String
        Dim ba As String = "homme"
        Dim br As String = "femme"
        bc = Label17.Text
        bc += sb.Text
        bb += s.ToString

        List.Items.Add(ll1.Text + m.Text)
        List.Items.Add(ll2.Text + p.Text)
        List.Items.Add(ll3.Text + nm.Text)
        If ccm.SelectedIndex = 0 Then
            List.Items.Add(ll4.Text + ba)
        ElseIf ccm.SelectedIndex = 1 Then
            List.Items.Add(ll4.Text + br)
        End If
        List.Items.Add(ll5.Text + f.Text)
        List.Items.Add(bc)
        List.Items.Add(l1.Text + hs.Text)
        List.Items.Add(l2.Text + pr.Text)
        List.Items.Add(l3.Text + av.Text)
        List.Items.Add(l4.Text + sbr.Text)
        List.Items.Add(l5.Text + cn.Text)
        List.Items.Add(l6.Text + sim.Text)
        List.Items.Add(l7.Text + ir.Text)
        List.Items.Add(bb)
        List.Items.Add(l8.Text + salnet.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        m.Clear()
        p.Clear()
        nm.Clear()
        nbr.Clear()
        sb.Clear()
        f.Clear()
        sbs.Clear()
        hs.Clear()
        pr.Clear()
        av.Clear()
        sbr.Clear()
        sb2.Clear()
        cn.Clear()
        sim.Clear()
        ir.Clear()
        salnet.Clear()
        List.Items.Clear()

    End Sub

    Private Sub av_TextChanged(sender As Object, e As EventArgs) Handles av.TextChanged
        If Not IsNumeric(hs.Text) And Not IsNumeric(pr.Text) And Not IsNumeric(av.Text) Then

        Else
            som.Enabled = True
        End If
    End Sub
End Class