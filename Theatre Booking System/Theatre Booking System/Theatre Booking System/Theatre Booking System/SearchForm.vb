Public Class SearchForm
    Private Sub LoginForm_activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtSearch.Text = ""
        rtbResults.ForeColor = Color.DimGray
        rtbResults.Text = "Enter the Customer PIN to be looked-up in the space to the left." & (Chr(10)) & "To keep customer data secure navigating away from this form will clear the results field."
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide() : StaffMenu.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Query As String = txtSearch.Text & ".txt"
        If txtSearch.TextLength = 6 And IsNumeric(txtSearch.Text) Then
            If System.IO.File.Exists(Query) = True Then : rtbResults.ForeColor = Color.Black : rtbResults.LoadFile(Query, RichTextBoxStreamType.PlainText)
            Else : rtbResults.ForeColor = Color.Black : rtbResults.Text = "No matches found."
            End If
        Else : MsgBox("Customer PINs are 6-digit numerical codes.") : End If
    End Sub
End Class