Public Class StaffMenu
    Private Sub StaffMenu_activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If LoginForm.Visible = True Then
            LoginForm.Hide()
        End If
        If AuditoriumForm.Visible = True Then
            AuditoriumForm.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnAuditorium_Click(sender As Object, e As EventArgs) Handles btnAuditorium.Click
        AuditoriumForm.btnMenu.Enabled = True
        AuditoriumForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchForm_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchForm.Click
        Me.Hide()
        SearchForm.Show()
    End Sub

    Private Sub btnViewSum_Click(sender As Object, e As EventArgs) Handles btnViewSum.Click
        Dim RevenueFriday As String = ""
        Dim RevenueSaturday As String = ""
        RevenueFriday = System.IO.File.ReadAllText("FridayTotal.txt")
        RevenueSaturday = System.IO.File.ReadAllText("SaturdayTotal.txt")
        MsgBox("Revenue for Friday: " & FormatCurrency(RevenueFriday, 2) & (Chr(10)) & "Revenue for Saturday: " & FormatCurrency(RevenueSaturday, 2))
    End Sub
End Class