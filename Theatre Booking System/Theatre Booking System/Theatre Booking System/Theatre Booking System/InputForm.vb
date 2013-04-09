Public Class InputForm
    Public Shared Function getcurrentdirectory() As String
    End Function
    'Array: 0,11 Customer Details; 12,21 Seat Details; 22 FinalPrice BookingsFile.txt
    Public BookingDetails(22) As String
    'SeatsFile.txt Input line by line for each seat
    Public SeatsFileInput1(4) As String
    Public SeatsFileInput2(4) As String
    Public SeatsFileInput3(4) As String
    Public SeatsFileInput4(4) As String
    Public SeatsFileInput5(4) As String
    Public SeatsFileInput6(4) As String
    Public SeatsFileInput7(4) As String
    Public SeatsFileInput8(4) As String
    Public SeatsFileInput9(4) As String
    Public SeatsFileInputX(4) As String
    'Generate custPIN and insert as first field of array
    Public Sub custPINgen()
        Dim randGen As New Random
        BookingDetails(0) = ""

        Randomize()
        For i = 0 To 5
            BookingDetails(0) += CStr(randGen.Next(0, 10))
        Next
    End Sub

    Private Sub InputForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        LoginForm.Show()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnBook_Click(sender As System.Object, e As System.EventArgs) Handles btnBook.Click

        Dim Valid As Boolean = True
        custPINgen()                        'Call custPINgen function then populate rest of array once inputs validated...
        BookingDetails(1) = cmbTitle.Text
        If txtForname.Text <> "" And txtForname.TextLength <= 12 Then
            BookingDetails(2) = txtForname.Text
        Else : MsgBox("If your forename is not between 1 and 12 characters please enter a shortened version.")
            Valid = False
        End If
        If txtSurname.Text <> "" And txtSurname.TextLength <= 20 Then
            BookingDetails(3) = txtSurname.Text
        Else : MsgBox("If your surname is not between 1 and 20 characters please enter a shortened version.")
            Valid = False
        End If
        If txtMail1.Text = txtMail2.Text And txtMail1.Text <> "" Then
            If txtMail1.TextLength <= 30 Then
                BookingDetails(4) = txtMail1.Text
            Else : MsgBox("Please enter an E-Mail address that between 1 and 30 characters.")
                Valid = False
            End If
        Else : MsgBox("Please make sure you've entered your E-Mail address correctly in both the first E-Mail and confirmation fields.")
            Valid = False
        End If
        If txtAddress1.Text <> "" And txtAddress2.Text <> "" Then
            BookingDetails(5) = txtAddress1.Text
            BookingDetails(6) = txtAddress2.Text
        Else : MsgBox("Please make sure you've entered your full address.")
            Valid = False
        End If
        If txtPostCode.TextLength >= 6 And txtPostCode.TextLength <= 8 Then
            BookingDetails(7) = txtPostCode.Text
        Else : MsgBox("Please enter a valid UK Postcode.")
            Valid = False
        End If
        If txtCardNumber.TextLength = 16 And IsNumeric(txtCardNumber.Text) Then
            BookingDetails(8) = txtCardNumber.Text
        Else : MsgBox("Enter the 16-digit Credit or Debit card number usually on the front side of the card.")
            Valid = False
        End If
        If txtSecurityCode.TextLength >= 3 And txtSecurityCode.TextLength <= 4 And IsNumeric(txtSecurityCode.Text) Then
            BookingDetails(9) = txtSecurityCode.Text
        Else : MsgBox("Enter 3-digit or 4-digit (AMEX) number usually on the reverse of the card.")
            Valid = False
        End If
        BookingDetails(10) = cmbMonth.Text
        BookingDetails(11) = cmbYear.Text

        'Seats
        BookingDetails(12) = AuditoriumForm.Seats(0)
        BookingDetails(13) = AuditoriumForm.Seats(1)
        BookingDetails(14) = AuditoriumForm.Seats(2)
        BookingDetails(15) = AuditoriumForm.Seats(3)
        BookingDetails(16) = AuditoriumForm.Seats(4)
        BookingDetails(17) = AuditoriumForm.Seats(5)
        BookingDetails(18) = AuditoriumForm.Seats(6)
        BookingDetails(19) = AuditoriumForm.Seats(7)
        BookingDetails(20) = AuditoriumForm.Seats(8)
        BookingDetails(21) = AuditoriumForm.Seats(9)
        'Price
        BookingDetails(22) = AuditoriumForm.FinalPrice

        If Valid = True Then

            'BookingsFile.txt
            'Declare Object, Import StreamWriter
            Dim BookingsFile As New System.IO.StreamWriter("BookingsFile.txt", True)
            BookingsFile.WriteLine(Join(BookingDetails, ";"))

            'SeatsFileInput1(4)
            If lblSeat1.Text <> "" Then
                'Seat ID
                SeatsFileInput1(0) = lblSeat1.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat1.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput1(1) = "Y"
                    Case Else : SeatsFileInput1(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput1(2) = "Yes"
                'CustPIN
                SeatsFileInput1(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat1.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput1(4) = PriceEach
            End If

            'SeatsFileInput2(4)
            If lblSeat2.Text <> "" Then
                'Seat ID
                SeatsFileInput2(0) = lblSeat2.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat2.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput2(1) = "Y"
                    Case Else : SeatsFileInput2(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput2(2) = "Yes"
                'CustPIN
                SeatsFileInput2(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat2.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput2(4) = PriceEach
            End If

            'SeatsFileInput3(4)
            If lblSeat3.Text <> "" Then
                'Seat ID
                SeatsFileInput3(0) = lblSeat3.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat3.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput3(1) = "Y"
                    Case Else : SeatsFileInput3(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput3(2) = "Yes"
                'CustPIN
                SeatsFileInput3(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat3.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput3(4) = PriceEach
            End If

            'SeatsFileInput4(4)
            If lblSeat4.Text <> "" Then
                'Seat ID
                SeatsFileInput4(0) = lblSeat4.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat4.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput4(1) = "Y"
                    Case Else : SeatsFileInput4(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput4(2) = "Yes"
                'CustPIN
                SeatsFileInput4(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat4.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput4(4) = PriceEach
            End If

            'SeatsFileInput5(4)
            If lblSeat5.Text <> "" Then
                'Seat ID
                SeatsFileInput5(0) = lblSeat5.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat5.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput5(1) = "Y"
                    Case Else : SeatsFileInput5(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput5(2) = "Yes"
                'CustPIN
                SeatsFileInput5(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat5.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput5(4) = PriceEach
            End If

            'SeatsFileInput6(4)
            If lblSeat6.Text <> "" Then
                'Seat ID
                SeatsFileInput6(0) = lblSeat6.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat6.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput6(1) = "Y"
                    Case Else : SeatsFileInput6(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput6(2) = "Yes"
                'CustPIN
                SeatsFileInput6(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat6.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput6(4) = PriceEach
            End If

            'SeatsFileInput7(4)
            If lblSeat7.Text <> "" Then
                'Seat ID
                SeatsFileInput7(0) = lblSeat7.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat7.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput7(1) = "Y"
                    Case Else : SeatsFileInput7(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput7(2) = "Yes"
                'CustPIN
                SeatsFileInput7(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat7.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput7(4) = PriceEach
            End If

            'SeatsFileInput8(4)
            If lblSeat8.Text <> "" Then
                'Seat ID
                SeatsFileInput8(0) = lblSeat8.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat8.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput8(1) = "Y"
                    Case Else : SeatsFileInput8(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput8(2) = "Yes"
                'CustPIN
                SeatsFileInput8(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat8.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput8(4) = PriceEach
            End If

            'SeatsFileInput9(4)
            If lblSeat9.Text <> "" Then
                'Seat ID
                SeatsFileInput9(0) = lblSeat9.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeat9.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInput9(1) = "Y"
                    Case Else : SeatsFileInput9(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInput9(2) = "Yes"
                'CustPIN
                SeatsFileInput9(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeat9.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInput9(4) = PriceEach
            End If

            'SeatsFileInputX(4)
            If lblSeatX.Text <> "" Then
                'Seat ID
                SeatsFileInputX(0) = lblSeatX.Text
                'Determine disabled status
                Dim wanted As String
                wanted = lblSeatX.Text
                Select Case wanted
                    Case "FA11", "FA12", "FB12", "FB13", "FC13", "FC14", "FD14", "FD15", "FE15", "FE16", "FF15", "FF16", "FG14", "FG15", "FH14", "FH15", "FJ14", "FJ15", "FK15", "FK16", "FL15", "SA11", "SA12", "SB12", "SB13", "SC13", "SC14", "SD14", "SD15", "SE15", "SE16", "SF15", "SF16", "SG14", "SG15", "SH14", "SH15", "SJ14", "SJ15", "SK15", "SK16", "SL15"
                        SeatsFileInputX(1) = "Y"
                    Case Else : SeatsFileInputX(1) = "N" : End Select
                'Set as booked - technically redundant as will search for seatID presence in File at AuditoriumForm activate event
                SeatsFileInputX(2) = "Yes"
                'CustPIN
                SeatsFileInputX(3) = BookingDetails(0)
                'Cost per seat
                Dim PriceEach As Double
                Select Case lblSeatX.Text.Substring(0, 2)
                    Case "FA", "FB", "FC", "SA", "SB", "SC"
                        PriceEach = 10.0
                    Case "FD", "FE", "FF", "SD", "SE", "SF"
                        PriceEach = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                        PriceEach = 7.25
                End Select
                SeatsFileInputX(4) = PriceEach
            End If

            'SeatsFile.txt
            'Declare Object, Import StreamWriter
            Dim SeatsFile As New System.IO.StreamWriter("SeatsFile.txt", True)
            'For Seat 1 of 10 no validation
            SeatsFile.WriteLine(Join(SeatsFileInput1, ";"))
            'Validatation for 2 through 10/X
            If SeatsFileInput2(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput2, ";"))
            End If
            If SeatsFileInput3(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput3, ";"))
            End If
            If SeatsFileInput4(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput4, ";"))
            End If
            If SeatsFileInput5(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput5, ";"))
            End If
            If SeatsFileInput6(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput6, ";"))
            End If
            If SeatsFileInput7(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput7, ";"))
            End If
            If SeatsFileInput8(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput8, ";"))
            End If
            If SeatsFileInput9(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInput9, ";"))
            End If
            If SeatsFileInputX(0) <> "" Then
                SeatsFile.WriteLine(Join(SeatsFileInputX, ";"))
            End If

            'Financial Files
            Dim PriceForFileFriday1 As Double
            Dim PriceForFileSaturday1 As Double
            'If lblSeat1.Text <> "" Then
            Select Case lblSeat1.Text.Substring(0, 2)
                Case "FA", "FB", "FC"
                    PriceForFileFriday1 = 10.0
                Case "SA", "SB", "SC"
                    PriceForFileSaturday1 = 10.0
                Case "FD", "FE", "FF"
                    PriceForFileFriday1 = 12.5
                Case "SD", "SE", "SF"
                    PriceForFileSaturday1 = 12.5
                Case "FG", "FH", "FJ", "FK", "FL"
                    PriceForFileFriday1 = 7.25
                Case "SG", "SH", "SJ", "SK", "SL"
                    PriceForFileSaturday1 = 7.25
            End Select ': Else : End If
            Dim PriceForFileFriday2 As Double
            Dim PriceForFileSaturday2 As Double
            If lblSeat2.Text <> "" Then
                Select Case lblSeat2.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday2 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday2 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday2 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday2 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday2 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday2 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday3 As Double
            Dim PriceForFileSaturday3 As Double
            If lblSeat3.Text <> "" Then
                Select Case lblSeat3.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday3 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday3 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday3 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday3 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday3 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday3 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday4 As Double
            Dim PriceForFileSaturday4 As Double
            If lblSeat4.Text <> "" Then
                Select Case lblSeat4.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday4 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday4 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday4 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday4 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday4 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday4 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday5 As Double
            Dim PriceForFileSaturday5 As Double
            If lblSeat5.Text <> "" Then
                Select Case lblSeat5.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday5 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday5 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday5 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday5 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday5 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday5 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday6 As Double
            Dim PriceForFileSaturday6 As Double
            If lblSeat6.Text <> "" Then
                Select Case lblSeat6.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday6 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday6 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday6 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday6 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday6 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday6 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday7 As Double
            Dim PriceForFileSaturday7 As Double
            If lblSeat7.Text <> "" Then
                Select Case lblSeat7.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday7 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday7 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday7 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday7 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday7 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday7 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday8 As Double
            Dim PriceForFileSaturday8 As Double
            If lblSeat8.Text <> "" Then
                Select Case lblSeat8.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday8 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday8 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday8 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday8 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday8 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday8 = 7.25
                End Select : Else : End If
            Dim PriceForFileFriday9 As Double
            Dim PriceForFileSaturday9 As Double
            If lblSeat9.Text <> "" Then
                Select Case lblSeat9.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFriday9 = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturday9 = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFriday9 = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturday9 = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFriday9 = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturday9 = 7.25
                End Select : Else : End If
            Dim PriceForFileFridayX As Double
            Dim PriceForFileSaturdayX As Double
            If lblSeatX.Text <> "" Then
                Select Case lblSeatX.Text.Substring(0, 2)
                    Case "FA", "FB", "FC"
                        PriceForFileFridayX = 10.0
                    Case "SA", "SB", "SC"
                        PriceForFileSaturdayX = 10.0
                    Case "FD", "FE", "FF"
                        PriceForFileFridayX = 12.5
                    Case "SD", "SE", "SF"
                        PriceForFileSaturdayX = 12.5
                    Case "FG", "FH", "FJ", "FK", "FL"
                        PriceForFileFridayX = 7.25
                    Case "SG", "SH", "SJ", "SK", "SL"
                        PriceForFileSaturdayX = 7.25
                End Select : Else : End If
            'Combine Values from labels then combine with existing file data
            Dim PriceForFriday As Double = 0  'New Values
            Dim PriceForSaturday As Double = 0
            Dim PriceFromFriday As Double = 0  'Existing Values from FridayTotal and SaturdayTotal Files
            Dim PriceFromSaturday As Double = 0
            Dim CombinedFriday As Double = 0  'New Values to be written
            Dim CombinedSaturday As Double = 0

            PriceForFriday = PriceForFileFriday1 + PriceForFileFriday2 + PriceForFileFriday3 + PriceForFileFriday4 + PriceForFileFriday5 + PriceForFileFriday6 + PriceForFileFriday7 + PriceForFileFriday8 + PriceForFileFriday9 + PriceForFileFridayX
            PriceForSaturday = PriceForFileSaturday1 + PriceForFileSaturday2 + PriceForFileFriday3 + PriceForFileSaturday4 + PriceForFileSaturday5 + PriceForFileSaturday6 + PriceForFileSaturday7 + PriceForFileSaturday8 + PriceForFileSaturday9 + PriceForFileSaturdayX

            'If Friday's total needs to be updated then
            If PriceForFriday > 1 Then
                'If the Friday file exists read it's contents as double
                'Or create the file
                'Write appropriate value
                If System.IO.File.Exists("FridayTotal.txt") = True Then
                    rtbPriceFromFriday.LoadFile("FridayTotal.txt", RichTextBoxStreamType.PlainText)
                    PriceFromFriday = rtbPriceFromFriday.Text
                    Dim FridayTotal As New System.IO.StreamWriter("FridayTotal.txt", False)
                    CombinedFriday = PriceFromFriday + PriceForFriday
                    FridayTotal.WriteLine(CombinedFriday)
                    FridayTotal.Close()
                Else : Dim FridayTotal As New System.IO.StreamWriter("FridayTotal.txt", True)
                    FridayTotal.WriteLine(PriceForFriday)
                    FridayTotal.Close()
                End If
            Else : End If
            'For Saturday
            If PriceForSaturday > 1 Then
                If System.IO.File.Exists("SaturdayTotal.txt") = True Then
                    rtbPriceFromSaturday.LoadFile("SaturdayTotal.txt", RichTextBoxStreamType.PlainText)
                    PriceFromSaturday = rtbPriceFromSaturday.Text
                    Dim SaturdayTotal As New System.IO.StreamWriter("SaturdayTotal.txt", False)
                    CombinedSaturday = PriceFromSaturday + PriceForSaturday
                    SaturdayTotal.WriteLine(CombinedSaturday)
                    SaturdayTotal.Close()
                Else : Dim SaturdayTotal As New System.IO.StreamWriter("SaturdayTotal.txt", True)
                    SaturdayTotal.WriteLine(PriceForSaturday)
                    SaturdayTotal.Close()
                End If
            Else : End If

            'Close Files
            BookingsFile.Close()
            SeatsFile.Close()

            Me.Hide()
            PrintForm.Show()
        Else : End If
    End Sub

    Private Sub InputForm_activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        'Set default values for combo boxes AND placeholders for Address prompts
        cmbTitle.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
        cmbYear.SelectedIndex = 0
        txtAddress1.ForeColor = Color.DimGray
        txtAddress1.Text = "Number, Street"
        txtAddress2.ForeColor = Color.DimGray
        txtAddress2.Text = "City, County"
        txtPostCode.ForeColor = Color.DimGray
        txtPostCode.Text = "Postcode"

        'Load tempChosen/Seats and FinalPrice arrays, display in labels
        lblFinalPrice.Text = FormatCurrency(AuditoriumForm.FinalPrice, 2)

        lblSeat1.Text = AuditoriumForm.Seats(0)
        lblSeat2.Text = AuditoriumForm.Seats(1)
        lblSeat3.Text = AuditoriumForm.Seats(2)
        lblSeat4.Text = AuditoriumForm.Seats(3)
        lblSeat5.Text = AuditoriumForm.Seats(4)
        lblSeat6.Text = AuditoriumForm.Seats(5)
        lblSeat7.Text = AuditoriumForm.Seats(6)
        lblSeat8.Text = AuditoriumForm.Seats(7)
        lblSeat9.Text = AuditoriumForm.Seats(8)
        lblSeatX.Text = AuditoriumForm.Seats(9)

    End Sub

    Private Sub txtAddress1_Click(sender As Object, e As EventArgs) Handles txtAddress1.Click
        txtAddress1.Text = ""
        txtAddress1.ForeColor = Color.Black
    End Sub

    Private Sub txtAddress2_Click(sender As Object, e As EventArgs) Handles txtAddress2.Click
        txtAddress2.Text = ""
        txtAddress2.ForeColor = Color.Black
    End Sub

    Private Sub txtPostCode_Click(sender As Object, e As EventArgs) Handles txtPostCode.Click
        txtPostCode.Text = ""
        txtPostCode.ForeColor = Color.Black
    End Sub
End Class