Public Class AuditoriumForm
    Private Sub AuditoriumForm_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.Visible = True Then
            tabsDaySelect.SelectedTab = tabsDaySelect.TabPages.Item("tabFri")
            If LoginForm.Visible = True Then
                tabsDaySelect.SelectedTab = tabsDaySelect.TabPages.Item("tabSat")
                btnMenu.Enabled = False
            ElseIf StaffMenu.Visible = True Then
                btnMenu.Enabled = True
            End If
            StaffMenu.Hide()
            LoginForm.Hide()
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        LoginForm.Hide()
        StaffMenu.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        StaffMenu.Hide()
        LoginForm.Show()
    End Sub
End Class