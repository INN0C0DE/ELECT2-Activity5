Public Class Form1

  
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged

    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            cb1.Checked = True
            cb2.Checked = False
            cb3.Checked = True
            cb4.Checked = False
            cb5.Checked = True
            cb6.Checked = False
            cb7.Checked = False
            tb1.Text = "185"

        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            cb1.Checked = True
            cb2.Checked = True
            cb3.Checked = True
            cb4.Checked = True
            cb5.Checked = True
            cb6.Checked = False
            cb7.Checked = False
            tb1.Text = "250"

        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            cb1.Checked = True
            cb2.Checked = True
            cb3.Checked = True
            cb4.Checked = True
            cb5.Checked = True
            cb6.Checked = True
            cb7.Checked = True
            tb1.Text = "290"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb1.Enabled = False

    End Sub
End Class
