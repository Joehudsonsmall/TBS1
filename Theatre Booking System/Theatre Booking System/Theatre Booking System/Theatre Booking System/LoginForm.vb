Public Class LoginForm
    Private Sub LoginForm_activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        txtPassword.Clear()
        tabsLoginForm.SelectedTab = tabsLoginForm.TabPages.Item("tabCustomer")

        StaffMenu.Hide()
        AuditoriumForm.Hide()

        AuditoriumForm.btnMenu.Enabled = False
        AuditoriumForm.FinalPrice = 0
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "19960805" Or txtPassword.Text = "19961110" Then
            Me.Hide()
            StaffMenu.Show()
        ElseIf txtPassword.Text.Length <> 8 Then
            MsgBox("Invalid UID entered.", MsgBoxStyle.Exclamation)
            'UID of incorrect length Alerts user
        Else
            MsgBox("Incorrect UID entered.", MsgBoxStyle.Exclamation)
            'incorrect UID of correct length alerts user
        End If
    End Sub

    Public Sub btnBookFri_Click(sender As System.Object, e As System.EventArgs) Handles btnBookFri.Click
        AuditoriumForm.SetTab("tabFri")
        Me.Hide()
        AuditoriumForm.Show()
    End Sub

    Public Sub btnBookSat_Click(sender As System.Object, e As System.EventArgs) Handles btnBookSat.Click
        AuditoriumForm.SetTab("tabSat")
        Me.Hide()
        AuditoriumForm.Show()
    End Sub
End Class
