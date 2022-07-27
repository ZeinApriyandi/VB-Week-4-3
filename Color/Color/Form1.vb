Public Class Form1

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        lbl_hasil.Text = txt_nama.Text
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lbl_hasil.ForeColor = Drawing.Color.Red
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        lbl_hasil.ForeColor = Drawing.Color.Yellow
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        lbl_hasil.ForeColor = Drawing.Color.Green
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        lbl_hasil.ForeColor = Drawing.Color.Blue
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        lbl_hasil.Font = New Font("Microsoft sans serif", lbl_hasil.Font.Size, lbl_hasil.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        lbl_hasil.Font = New Font("Microsoft sans serif", lbl_hasil.Font.Size, lbl_hasil.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        lbl_hasil.Font = New Font("Microsoft sans serif", lbl_hasil.Font.Size, lbl_hasil.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        lbl_hasil.Font = New Font("Microsoft sans serif", lbl_hasil.Font.Size, lbl_hasil.Font.Style Xor FontStyle.Strikeout)
    End Sub
End Class
