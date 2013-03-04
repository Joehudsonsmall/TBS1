Public Class StaffMenu
    Private Sub StaffMenu_shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If LoginForm.Visible = True Then
            LoginForm.Hide()
        End If
        If AuditoriumForm.Visible = True Then
            AuditoriumForm.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        LoginForm.Location = Me.Location
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnAuditorium_Click(sender As Object, e As EventArgs) Handles btnAuditorium.Click
        AuditoriumForm.Show()
    End Sub

   
End Class