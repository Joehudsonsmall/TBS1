Public Class LoginForm
    Private Sub LoginForm_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        txtPassword.Clear()
        tabsLoginForm.SelectedTab = tabsLoginForm.TabPages.Item("tabCustomer")

        StaffMenu.Hide()
        AuditoriumForm.Hide()

    End Sub
    Private Sub
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "19960805" Or "19961110" Then
            StaffMenu.Location = Me.Location
            Me.Hide()
            StaffMenu.Show()
            'Correct UID of correct length opens StaffMenu form in loaction of LoginForm
        ElseIf MsgBox("Incorrect UID entered.", MsgBoxStyle.Exclamation) Then
            'Incorrect UID of correct length Alerts user
        End If
    End Sub

    Public Sub btnBookFri_Click(sender As System.Object, e As System.EventArgs) Handles btnBookFri.Click
        Me.Hide()
        AuditoriumForm.Show()
    End Sub

    Public Sub btnBookSat_Click(sender As System.Object, e As System.EventArgs) Handles btnBookSat.Click
        AuditoriumForm.Show()
    End Sub
End Class
