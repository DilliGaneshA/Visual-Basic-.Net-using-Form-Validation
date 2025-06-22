Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim Pass As String
        username = TextBox3.Text
        Pass = TextBox4.Text
        If (username.Equals("admin") And Pass.Equals("admin")) Then
            MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Errror", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
