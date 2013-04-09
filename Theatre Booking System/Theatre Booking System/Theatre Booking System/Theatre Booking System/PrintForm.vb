
Public Class PrintForm

    Private Sub PrintForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub
    Public Sub PrintForm_activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Customer File writing moved to btnDone_Click and btnPrint_Click to avoid duplicates caused by switching window in focus

        'Read 1. FinalPrice 2. Title, Forename, Surname and 3. Card Number into lblDynamic
        lblDynamic.Text = "Your order of " & FormatCurrency(InputForm.BookingDetails(22), 2) & " Has been processed to: " & InputForm.BookingDetails(1) & " " & InputForm.BookingDetails(2) & " " & InputForm.BookingDetails(3) & " on the card **** **** **** " & InputForm.BookingDetails(8).Substring(12, 4)
        'Split CustPIN by dashes to increase readalibily
        lblCustPIN.Text = InputForm.BookingDetails(0).Substring(0, 2) & " – " & InputForm.BookingDetails(0).Substring(2, 2) & " – " & InputForm.BookingDetails(0).Substring(4, 2)

    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        'Don't Print
        
        'Create Customer File [[custPIN variable].txt]
        'Allows uniquily named file to be created
        Dim CustPINtxt As String = InputForm.BookingDetails(0) & ".txt"
        'Declare Object, Import StreamWriter
        Dim CustomerFile As New System.IO.StreamWriter(InputForm.BookingDetails(0) & ".txt", True)
        CustomerFile.WriteLine(InputForm.BookingDetails(0)) 'custPIN
        CustomerFile.WriteLine(InputForm.BookingDetails(1)) 'Title
        CustomerFile.WriteLine(InputForm.BookingDetails(2)) 'Forname
        CustomerFile.WriteLine(InputForm.BookingDetails(3)) 'Surname
        CustomerFile.WriteLine(InputForm.BookingDetails(4)) 'E-mail
        CustomerFile.WriteLine(FormatCurrency((InputForm.BookingDetails(22)), 2)) 'FinalPrice
        CustomerFile.WriteLine("**** **** **** " & InputForm.BookingDetails(8).Substring(12, 4)) 'Final 4 numbers on card
        'Seats
        CustomerFile.WriteLine(InputForm.BookingDetails(12) & " " & InputForm.BookingDetails(13) & " " & InputForm.BookingDetails(14) & " " & InputForm.BookingDetails(15) & " " & InputForm.BookingDetails(16))
        CustomerFile.WriteLine(InputForm.BookingDetails(17) & " " & InputForm.BookingDetails(18) & " " & InputForm.BookingDetails(19) & " " & InputForm.BookingDetails(20) & " " & InputForm.BookingDetails(21))

        'Close File
        CustomerFile.Close()

        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Read 1. FinalPrice 2. Title, Forename, Surname and 3. Card Number into lblDynamic
        lblDynamic.Text = "Your order of " & FormatCurrency(InputForm.BookingDetails(22), 2) & " Has been processed to: " & InputForm.BookingDetails(1) & " " & InputForm.BookingDetails(2) & " " & InputForm.BookingDetails(3) & " on the card **** **** **** " & InputForm.BookingDetails(8).Substring(12, 4)
        'Split CustPIN by dashes to increase readalibily
        lblCustPIN.Text = InputForm.BookingDetails(0).Substring(0, 2) & " – " & InputForm.BookingDetails(0).Substring(2, 2) & " – " & InputForm.BookingDetails(0).Substring(4, 2)

        'Create Customer File [[custPIN variable].txt]
        'Allows uniquily named file to be created
        Dim CustPINtxt As String = InputForm.BookingDetails(0) & ".txt"
        'Declare Object, Import StreamWriter
        Dim CustomerFile As New System.IO.StreamWriter(InputForm.BookingDetails(0) & ".txt", True)
        CustomerFile.WriteLine(InputForm.BookingDetails(0)) 'custPIN
        CustomerFile.WriteLine(InputForm.BookingDetails(1)) 'Title
        CustomerFile.WriteLine(InputForm.BookingDetails(2)) 'Forname
        CustomerFile.WriteLine(InputForm.BookingDetails(3)) 'Surname
        CustomerFile.WriteLine(InputForm.BookingDetails(4)) 'E-mail
        CustomerFile.WriteLine(FormatCurrency((InputForm.BookingDetails(22)), 2)) 'FinalPrice
        CustomerFile.WriteLine("**** **** **** " & InputForm.BookingDetails(8).Substring(12, 4)) 'Final 4 numbers on card
        'Seats
        CustomerFile.WriteLine(InputForm.BookingDetails(12) & " " & InputForm.BookingDetails(13) & " " & InputForm.BookingDetails(14) & " " & InputForm.BookingDetails(15) & " " & InputForm.BookingDetails(16))
        CustomerFile.WriteLine(InputForm.BookingDetails(17) & " " & InputForm.BookingDetails(18) & " " & InputForm.BookingDetails(19) & " " & InputForm.BookingDetails(20) & " " & InputForm.BookingDetails(21))

        'Close File
        CustomerFile.Close()
        'Print (this) Customer File --- Cannot Print file so printing duplicate of File contents
        '(CHR(10)) is line feed character
        Dim Print As New myPrinter
        Print.prt(InputForm.BookingDetails(0) & (Chr(10)) & InputForm.BookingDetails(1) & (Chr(10)) & InputForm.BookingDetails(2) & (Chr(10)) & InputForm.BookingDetails(3) & (Chr(10)) & InputForm.BookingDetails(4) & (Chr(10)) & FormatCurrency((InputForm.BookingDetails(22)), 2) & (Chr(10)) & "**** **** **** " & InputForm.BookingDetails(8).Substring(12, 4) & (Chr(10)) & InputForm.BookingDetails(12) & " " & InputForm.BookingDetails(13) & " " & InputForm.BookingDetails(14) & " " & InputForm.BookingDetails(15) & " " & InputForm.BookingDetails(16) & (Chr(10)) & InputForm.BookingDetails(17) & " " & InputForm.BookingDetails(18) & " " & InputForm.BookingDetails(19) & " " & InputForm.BookingDetails(20) & " " & InputForm.BookingDetails(21))
        
        Me.Hide()
        LoginForm.Show()
    End Sub

End Class

Public Class myPrinter
    Friend TextToBePrinted As String
    Public Sub prt(ByVal text As String)
        TextToBePrinted = text
        Dim prn As New Printing.PrintDocument
        Using (prn)
            'Note: VB/Windows 8 is within Virtual Machine on OS X – Conversion to PostScript error cuased by Parallels software bug
            'Unless Parallels printer sync is disabled and OS X shares connected Printer over network Parallels cannot transfer Print jobs
            'Once Windows connects to printer via Bonjour then Printer will not show as local in Window's Control Panel...
            'PrinterName (below) will find the Printer:
            'Note: PRINTER NAME CONST (IN RED) IS MACHINE DEPENDANT
            prn.PrinterSettings.PrinterName _
               = "Canon MP520 Series Printer"
            AddHandler prn.PrintPage, _
               AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage, _
               AddressOf Me.PrintPageHandler
        End Using
    End Sub
    Private Sub PrintPageHandler(ByVal sender As Object, _
       ByVal args As Printing.PrintPageEventArgs)
        Dim myFont As New Font("Consolas", 12)
        args.Graphics.DrawString(TextToBePrinted, _
           New Font(myFont, FontStyle.Regular), _
           Brushes.Black, 50, 50)
    End Sub
End Class