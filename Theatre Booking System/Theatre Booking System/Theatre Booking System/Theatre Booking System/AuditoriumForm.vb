
Public Class AuditoriumForm
    Dim Options As New ArrayList
    'New arrays with data gathered below; public
    Public FinalPrice As Double = 0
    Public Seats(9) As String
 
    Private Sub UpdateTxtChosen()
        txtChosen.Clear()
        For Each tempChosen As Button In Options
            txtChosen.Text += tempChosen.Name + ", "
        Next
        If txtChosen.TextLength > 2 Then : txtChosen.Text = txtChosen.Text.Substring(0, txtChosen.TextLength - 2) : End If

        'Reads txtChosen for tempChosen to add to Seats(9) (is public)
        'IF statements prevent error where start-point is longer than string length within txtChosen
        If txtChosen.TextLength > 0 Then : Seats(0) = txtChosen.Text.Substring(0, 4) : Else : End If
        If txtChosen.TextLength >= 6 Then : Seats(1) = txtChosen.Text.Substring(6, 4) : Else : End If
        If txtChosen.TextLength >= 12 Then : Seats(2) = txtChosen.Text.Substring(12, 4) : Else : End If
        If txtChosen.TextLength >= 18 Then : Seats(3) = txtChosen.Text.Substring(18, 4) : Else : End If
        If txtChosen.TextLength >= 24 Then : Seats(4) = txtChosen.Text.Substring(24, 4) : Else : End If
        If txtChosen.TextLength >= 30 Then : Seats(5) = txtChosen.Text.Substring(30, 4) : Else : End If
        If txtChosen.TextLength >= 36 Then : Seats(6) = txtChosen.Text.Substring(36, 4) : Else : End If
        If txtChosen.TextLength >= 42 Then : Seats(7) = txtChosen.Text.Substring(42, 4) : Else : End If
        If txtChosen.TextLength >= 48 Then : Seats(8) = txtChosen.Text.Substring(48, 4) : Else : End If
        If txtChosen.TextLength >= 54 Then : Seats(9) = txtChosen.Text.Substring(54, 4) : Else : End If
    End Sub
    Private Sub updateLblCost()
        lblCost.Text = "£00.00"
        Dim Price As Double
        Dim i As Integer
        For i = 0 To Options.Count - 1
            Dim tempchosen As Button = Options(i)
            Select Case tempchosen.Name.Substring(0, 2)
                Case "FA", "FB", "FC", "SA", "SB", "SC"
                    Price += 10.0
                Case "FD", "FE", "FF", "SD", "SE", "SF"
                    Price += 12.5
                Case "FG", "FH", "FJ", "FK", "FL", "SG", "SH", "SJ", "SK", "SL"
                    Price += 7.25
            End Select
            lblCost.Text = FormatCurrency(Price, 2)
            FinalPrice = Price

        Next
    End Sub
    Private Sub AuditoriumForm_activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If System.IO.File.Exists("SeatsFile.txt") = True Then
            Dim line As String
            Dim words(4) As String
            Dim inputstream As System.IO.StreamReader
            Dim found As Boolean = False
            Dim i As Integer = 0
            Dim Wanted As String
            Dim Options() As Windows.Forms.Button = {FA01, FA02, FA03, FA04, FA05, FA06, FA07, FA08, FA09, FA10, FA11, FA12, FA13, FA14,
                                                 FB01, FB02, FB03, FB04, FB05, FB06, FB07, FB08, FB09, FB10, FB11, FB12, FB13, FB14,
                                                 FB15, FB16, FC01, FC02, FC03, FC04, FC05, FC06, FC07, FC08, FC09, FC10, FC11, FC12,
                                                 FC13, FC14, FC15, FC16, FC17, FD01, FD02, FD03, FD04, FD05, FD06, FD07, FD08, FD09, FD10,
                                                 FD11, FD12, FD13, FD14, FD15, FD16, FD17, FD18, FD19, FE01, FE02, FE03, FE04, FE05,
                                                 FE06, FE07, FE08, FE09, FE10, FE11, FE12, FE13, FE14, FE15, FE16, FE17, FE18, FE19,
                                                 FE20, FF01, FF02, FF03, FF04, FF05, FF06, FF07, FF08, FF09, FF10, FF11, FF12, FF13,
                                                 FF14, FF15, FF16, FF17, FF18, FF19, FF20, FG01, FG02, FG03, FG04, FG05, FG06, FG07,
                                                 FG08, FG09, FG10, FG11, FG12, FG13, FG14, FG15, FG16, FG17, FG18, FG19, FH01, FH02,
                                                 FH03, FH04, FH05, FH06, FH07, FH08, FH09, FH10, FH11, FH12, FH13, FH14, FH15, FH16,
                                                 FH17, FH18, FH19, FJ01, FJ02, FJ03, FJ04, FJ05, FJ06, FJ07, FJ08, FJ09, FJ10, FJ11,
                                                 FJ12, FJ13, FJ14, FJ15, FJ16, FJ17, FJ18, FJ19, FK01, FK02, FK03, FK04, FK05, FK06,
                                                 FK07, FK08, FK09, FK10, FK11, FK12, FK13, FK14, FK15, FK16, FK17, FK18, FK19, FL01,
                                                 FL02, FL03, FL04, FL05, FL06, FL07, FL08, FL09, FL10, FL11, FL12, FL13, FL14, FL15,
                                                 SA01, SA02, SA03, SA04, SA05, SA06, SA07, SA08, SA09, SA10, SA11, SA12, SA13, SA14,
                                                 SB01, SB02, SB03, SB04, SB05, SB06, SB07, SB08, SB09, SB10, SB11, SB12, SB13, SB14,
                                                 SB15, SB16, SC01, SC02, SC03, SC04, SC05, SC06, SC07, SC08, SC09, SC10, SC11, SC12,
                                                 SC13, SC14, SC15, SC16, SC17, SD01, SD02, SD03, SD04, SD05, SD06, SD07, SD08, SD09, SD10,
                                                 SD11, SD12, SD13, SD14, SD15, SD16, SD17, SD18, SD19, SE01, SE02, SE03, SE04, SE05,
                                                 SE06, SE07, SE08, SE09, SE10, SE11, SE12, SE13, SE14, SE15, SE16, SE17, SE18, SE19,
                                                 SE20, SF01, SF02, SF03, SF04, SF05, SF06, SF07, SF08, SF09, SF10, SF11, SF12, SF13,
                                                 SF14, SF15, SF16, SF17, SF18, SF19, SF20, SG01, SG02, SG03, SG04, SG05, SG06, SG07,
                                                 SG08, SG09, SG10, SG11, SG12, SG13, SG14, SG15, SG16, SG17, SG18, SG19, SH01, SH02,
                                                 SH03, SH04, SH05, SH06, SH07, SH08, SH09, SH10, SH11, SH12, SH13, SH14, SH15, SH16,
                                                 SH17, SH18, SH19, SJ01, SJ02, SJ03, SJ04, SJ05, SJ06, SJ07, SJ08, SJ09, SJ10, SJ11,
                                                 SJ12, SJ13, SJ14, SJ15, SJ16, SJ17, SJ18, SJ19, SK01, SK02, SK03, SK04, SK05, SK06,
                                                 SK07, SK08, SK09, SK10, SK11, SK12, SK13, SK14, SK15, SK16, SK17, SK18, SK19, SL01,
                                                 SL02, SL03, SL04, SL05, SL06, SL07, SL08, SL09, SL10, SL11, SL12, SL13, SL14, SL15}
            For i = 0 To 393
                Wanted = Options(i).Name
                inputstream = New System.IO.StreamReader("SeatsFile.txt")
                line = inputstream.ReadLine()
                'Search for within SeatsFile.txt for matches to Options while records are in file
                While (line <> Nothing) And found = False
                    words = Split(line, ";")
                    If Trim(words(0)) = Wanted Then
                        Options(i).Name = Trim(words(1))
                        'Disable button if match found
                        Options(i).Enabled = False
                        found = True
                    Else
                        line = inputstream.ReadLine
                    End If
                End While
                inputstream.Close()
                found = False
            Next
        Else : End If
        StaffMenu.Hide()
        LoginForm.Hide()
        txtChosen.BackColor = Color.FromKnownColor(KnownColor.Control)
        txtChosen.ForeColor = Color.Black
    End Sub
    Public Sub SetTab(ByVal tabName As String)
        tabsDaySelect.SelectedTab = tabsDaySelect.TabPages.Item(tabName)
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

    Private Sub AuditoriumForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
        btnMenu.Enabled = False
        Options.Clear()
    End Sub


    'Private Sub btnBook_Click(sender As System.Object, e As System.EventArgs) Handles btnBook.Click
    '    'Array, Variables
    '    Dim Options() As Windows.Forms.Button = {FA01, FA02, FA03, FA04, FA05, FA06, FA07, FA08, FA09, FA10, FA11, FA12, FA13, FA14,
    '                                             FB01, FB02, FB03, FB04, FB05, FB06, FB07, FB08, FB09, FB10, FB11, FB12, FB13, FB14,
    '                                             FB15, FB16, FC01, FC02, FC03, FC04, FC05, FC06, FC07, FC08, FC09, FC10, FC11, FC12,
    '                                             FC13, FC14, FC15, FC16, FC17, FD01, FD02, FD03, FD04, FD05, FD06, FD07, FD09, FD10,
    '                                             FD11, FD12, FD13, FD14, FD15, FD16, FD17, FD18, FD19, FE01, FE02, FE03, FE04, FE05,
    '                                             FE06, FE07, FE08, FE09, FE10, FE11, FE12, FE13, FE14, FE15, FE16, FE17, FE18, FE19,
    '                                             FE20, FF01, FF02, FF03, FF04, FF05, FF06, FF07, FF08, FF09, FF10, FF11, FF12, FF13,
    '                                             FF14, FF15, FF16, FF17, FF18, FF19, FF20, FG01, FG02, FG03, FG04, FG05, FG06, FG07,
    '                                             FG08, FG09, FG10, FG11, FG12, FG13, FG14, FG15, FG16, FG17, FG18, FG19, FH01, FH02,
    '                                             FH03, FH04, FH05, FH06, FH07, FH08, FH09, FH10, FH11, FH12, FH13, FH14, FH15, FH16,
    '                                             FH17, FH18, FH19, FJ01, FJ02, FJ03, FJ04, FJ05, FJ06, FJ07, FJ08, FJ09, FJ10, FJ11,
    '                                             FJ12, FJ13, FJ14, FJ15, FJ16, FJ17, FJ18, FJ19, FK01, FK02, FK03, FK04, FK05, FK06,
    '                                             FK07, FK08, FK09, FK10, FK11, FK12, FK13, FK14, FK15, FK16, FK17, FK18, FK19, FL01,
    '                                             FL02, FL03, FL04, FL05, FL06, FL07, FL08, FL09, FL10, FL11, FL12, FL13, FL14, FL15,
    '                                             SA01, SA02, SA03, SA04, SA05, SA06, SA07, SA08, SA09, SA10, SA11, SA12, SA13, SA14,
    '                                             SB01, SB02, SB03, SB04, SB05, SB06, SB07, SB08, SB09, SB10, SB11, SB12, SB13, SB14,
    '                                             SB15, SB16, SC01, SC02, SC03, SC04, SC05, SC06, SC07, SC08, SC09, SC10, SC11, SC12,
    '                                             SC13, SC14, SC15, SC16, SC17, SD01, SD02, SD03, SD04, SD05, SD06, SD07, SD09, SD10,
    '                                             SD11, SD12, SD13, SD14, SD15, SD16, SD17, SD18, SD19, SE01, SE02, SE03, SE04, SE05,
    '                                             SE06, SE07, SE08, SE09, SE10, SE11, SE12, SE13, SE14, SE15, SE16, SE17, SE18, SE19,
    '                                             SE20, SF01, SF02, SF03, SF04, SF05, SF06, SF07, SF08, SF09, SF10, SF11, SF12, SF13,
    '                                             SF14, SF15, SF16, SF17, SF18, SF19, SF20, SG01, SG02, SG03, SG04, SG05, SG06, SG07,
    '                                             SG08, SG09, SG10, SG11, SG12, SG13, SG14, SG15, SG16, SG17, SG18, SG19, SH01, SH02,
    '                                             SH03, SH04, SH05, SH06, SH07, SH08, SH09, SH10, SH11, SH12, SH13, SH14, SH15, SH16,
    '                                             SH17, SH18, SH19, SJ01, SJ02, SJ03, SJ04, SJ05, SJ06, SJ07, SJ08, SJ09, SJ10, SJ11,
    '                                             SJ12, SJ13, SJ14, SJ15, SJ16, SJ17, SJ18, SJ19, SK01, SK02, SK03, SK04, SK05, SK06,
    '                                             SK07, SK08, SK09, SK10, SK11, SK12, SK13, SK14, SK15, SK16, SK17, SK18, SK19, SL01,
    '                                             SL02, SL03, SL04, SL05, SL06, SL07, SL08, SL09, SL10, SL11, SL12, SL13, SL14, SL15}

    '    Dim i As Integer
    '    Dim Chosen As String
    '    Dim decPrice As Decimal

    '    Chosen = options_CLick(Index as integer)
    '    Select Case Index
    '        Case 0

    '    End Select


    '    '''TextBox1.Text = TextBox1.Text.Substring(0, 1)
    '    ''' 'From position 0 extract contents of 1 position

    '    '/Pass array to InputForm SAVE TO TEXT FILE. WORK OUT WHEN TO CLEAR

    '    Me.Hide()
    '    InputForm.Show()
    'End Sub



    Private Sub btnBook_Click(sender As System.Object, e As System.EventArgs) Handles btnBook.Click
        If FinalPrice > 1 Then
            Me.Hide()
            InputForm.Show()
        Else : MsgBox("You have not selected any seats.")
        End If
    End Sub

    Private Sub ChosenFri_Click(sender As System.Object, e As System.EventArgs) Handles FL15.Click, FL14.Click, FL13.Click, FL12.Click, FL11.Click, FL10.Click, FL09.Click, FL08.Click, FL07.Click, FL06.Click, FL05.Click, FL04.Click, FL03.Click, FL02.Click, FL01.Click, FK19.Click, FK18.Click, FK17.Click, FK16.Click, FK15.Click, FK14.Click, FK13.Click, FK12.Click, FK11.Click, FK10.Click, FK09.Click, FK08.Click, FK07.Click, FK06.Click, FK05.Click, FK04.Click, FK03.Click, FK02.Click, FK01.Click, FJ19.Click, FJ18.Click, FJ17.Click, FJ16.Click, FJ15.Click, FJ14.Click, FJ13.Click, FJ12.Click, FJ11.Click, FJ10.Click, FJ09.Click, FJ08.Click, FJ07.Click, FJ06.Click, FJ05.Click, FJ04.Click, FJ03.Click, FJ02.Click, FJ01.Click, FH19.Click, FH18.Click, FH17.Click, FH16.Click, FH15.Click, FH14.Click, FH13.Click, FH12.Click, FH11.Click, FH10.Click, FH09.Click, FH08.Click, FH07.Click, FH06.Click, FH05.Click, FH04.Click, FH03.Click, FH02.Click, FH01.Click, FG19.Click, FG18.Click, FG17.Click, FG16.Click, FG15.Click, FG14.Click, FG13.Click, FG12.Click, FG11.Click, FG10.Click, FG09.Click, FG08.Click, FG07.Click, FG06.Click, FG05.Click, FG04.Click, FG03.Click, FG02.Click, FG01.Click, FF20.Click, FF19.Click, FF18.Click, FF17.Click, FF16.Click, FF15.Click, FF14.Click, FF13.Click, FF12.Click, FF11.Click, FF10.Click, FF09.Click, FF08.Click, FF07.Click, FF06.Click, FF05.Click, FF04.Click, FF03.Click, FF02.Click, FF01.Click, FE20.Click, FE19.Click, FE18.Click, FE17.Click, FE16.Click, FE15.Click, FE14.Click, FE13.Click, FE12.Click, FE11.Click, FE10.Click, FE09.Click, FE08.Click, FE07.Click, FE06.Click, FE05.Click, FE04.Click, FE03.Click, FE02.Click, FE01.Click, FD19.Click, FD18.Click, FD17.Click, FD16.Click, FD15.Click, FD14.Click, FD13.Click, FD12.Click, FD11.Click, FD10.Click, FD09.Click, FD08.Click, FD07.Click, FD06.Click, FD05.Click, FD04.Click, FD03.Click, FD02.Click, FD01.Click, FC17.Click, FC16.Click, FC15.Click, FC14.Click, FC13.Click, FC12.Click, FC11.Click, FC10.Click, FC09.Click, FC08.Click, FC07.Click, FC06.Click, FC05.Click, FC04.Click, FC03.Click, FC02.Click, FC01.Click, FB16.Click, FB15.Click, FB14.Click, FB13.Click, FB12.Click, FB11.Click, FB10.Click, FB09.Click, FB08.Click, FB07.Click, FB06.Click, FB05.Click, FB04.Click, FB03.Click, FB02.Click, FB01.Click, FA14.Click, FA13.Click, FA12.Click, FA11.Click, FA10.Click, FA09.Click, FA08.Click, FA07.Click, FA06.Click, FA05.Click, FA04.Click, FA03.Click, FA02.Click, FA01.Click
        If Not sender.GetType Is GetType(Button) Then Exit Sub
        Dim tempChosen As Button = CType(sender, Button)

        If Options.Count = 10 Then
            MsgBox("Over both perfomances you can only book 10 seats!") : Exit Sub
        End If

        If Options.Contains(tempChosen) Then
            Options.Remove(tempChosen)
            tempChosen.BackColor = Color.FromKnownColor(KnownColor.Control)
        Else
            Options.Add(tempChosen)
            tempChosen.BackColor = Color.Lime
        End If
        UpdateTxtChosen()
        updateLblCost()

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        For Each tempChosen As Button In Options
            tempChosen.BackColor = Color.FromKnownColor(KnownColor.Control)
        Next
        Options.Clear()
        UpdateTxtChosen()
        updateLblCost()
        ResetSeatColour()

    End Sub

    Private Sub ChosenSat_Click(sender As System.Object, e As System.EventArgs) Handles SL15.Click, SL14.Click, SL13.Click, SL12.Click, SL11.Click, SL10.Click, SL09.Click, SL08.Click, SL07.Click, SL06.Click, SL05.Click, SL04.Click, SL03.Click, SL02.Click, SL01.Click, SK19.Click, SK18.Click, SK17.Click, SK16.Click, SK15.Click, SK14.Click, SK13.Click, SK12.Click, SK11.Click, SK10.Click, SK09.Click, SK08.Click, SK07.Click, SK06.Click, SK05.Click, SK04.Click, SK03.Click, SK02.Click, SK01.Click, SJ19.Click, SJ18.Click, SJ17.Click, SJ16.Click, SJ15.Click, SJ14.Click, SJ13.Click, SJ12.Click, SJ11.Click, SJ10.Click, SJ09.Click, SJ08.Click, SJ07.Click, SJ06.Click, SJ05.Click, SJ04.Click, SJ03.Click, SJ02.Click, SJ01.Click, SH19.Click, SH18.Click, SH17.Click, SH16.Click, SH15.Click, SH14.Click, SH13.Click, SH12.Click, SH11.Click, SH10.Click, SH09.Click, SH08.Click, SH07.Click, SH06.Click, SH05.Click, SH04.Click, SH03.Click, SH02.Click, SH01.Click, SG19.Click, SG18.Click, SG17.Click, SG16.Click, SG15.Click, SG14.Click, SG13.Click, SG12.Click, SG11.Click, SG10.Click, SG09.Click, SG08.Click, SG07.Click, SG06.Click, SG05.Click, SG04.Click, SG03.Click, SG02.Click, SG01.Click, SF20.Click, SF19.Click, SF18.Click, SF17.Click, SF16.Click, SF15.Click, SF14.Click, SF13.Click, SF12.Click, SF11.Click, SF10.Click, SF09.Click, SF08.Click, SF07.Click, SF06.Click, SF05.Click, SF04.Click, SF03.Click, SF02.Click, SF01.Click, SE20.Click, SE19.Click, SE18.Click, SE17.Click, SE16.Click, SE15.Click, SE14.Click, SE13.Click, SE12.Click, SE11.Click, SE10.Click, SE09.Click, SE08.Click, SE07.Click, SE06.Click, SE05.Click, SE04.Click, SE03.Click, SE02.Click, SE01.Click, SD19.Click, SD18.Click, SD17.Click, SD16.Click, SD15.Click, SD14.Click, SD13.Click, SD12.Click, SD11.Click, SD10.Click, SD09.Click, SD08.Click, SD07.Click, SD06.Click, SD05.Click, SD04.Click, SD03.Click, SD02.Click, SD01.Click, SC17.Click, SC16.Click, SC15.Click, SC14.Click, SC13.Click, SC12.Click, SC11.Click, SC10.Click, SC09.Click, SC08.Click, SC07.Click, SC06.Click, SC05.Click, SC04.Click, SC03.Click, SC02.Click, SC01.Click, SB16.Click, SB15.Click, SB14.Click, SB13.Click, SB12.Click, SB11.Click, SB10.Click, SB09.Click, SB08.Click, SB07.Click, SB06.Click, SB05.Click, SB04.Click, SB03.Click, SB02.Click, SB01.Click, SA14.Click, SA13.Click, SA12.Click, SA11.Click, SA10.Click, SA09.Click, SA08.Click, SA07.Click, SA06.Click, SA05.Click, SA04.Click, SA03.Click, SA02.Click, SA01.Click
        If Not sender.GetType Is GetType(Button) Then Exit Sub
        Dim tempChosen As Button = CType(sender, Button)

        If Options.Count = 10 Then
            MsgBox("Over both perfomances you can only book 10 seats!") : Exit Sub
        End If

        If Options.Contains(tempChosen) Then
            Options.Remove(tempChosen)
            tempChosen.BackColor = Color.FromKnownColor(KnownColor.Control)
        Else
            Options.Add(tempChosen)
            tempChosen.BackColor = Color.Lime
        End If
        UpdateTxtChosen()
        updateLblCost()
    End Sub
    Private Sub ResetSeatColour()
        'Reset colour of Disabled seating
        FA11.BackColor = Color.PowderBlue
        FA12.BackColor = Color.PowderBlue
        FB12.BackColor = Color.PowderBlue
        FB13.BackColor = Color.PowderBlue
        FC13.BackColor = Color.PowderBlue
        FC14.BackColor = Color.PowderBlue
        FD14.BackColor = Color.PowderBlue
        FD15.BackColor = Color.PowderBlue
        FE15.BackColor = Color.PowderBlue
        FE16.BackColor = Color.PowderBlue
        FF15.BackColor = Color.PowderBlue
        FF16.BackColor = Color.PowderBlue
        FG14.BackColor = Color.PowderBlue
        FG15.BackColor = Color.PowderBlue
        FH14.BackColor = Color.PowderBlue
        FH15.BackColor = Color.PowderBlue
        FJ14.BackColor = Color.PowderBlue
        FJ15.BackColor = Color.PowderBlue
        FK15.BackColor = Color.PowderBlue
        FK16.BackColor = Color.PowderBlue
        FL15.BackColor = Color.PowderBlue
        SA11.BackColor = Color.PowderBlue
        SA12.BackColor = Color.PowderBlue
        SB12.BackColor = Color.PowderBlue
        SB13.BackColor = Color.PowderBlue
        SC13.BackColor = Color.PowderBlue
        SC14.BackColor = Color.PowderBlue
        SD14.BackColor = Color.PowderBlue
        SD15.BackColor = Color.PowderBlue
        SE15.BackColor = Color.PowderBlue
        SE16.BackColor = Color.PowderBlue
        SF15.BackColor = Color.PowderBlue
        SF16.BackColor = Color.PowderBlue
        SG14.BackColor = Color.PowderBlue
        SG15.BackColor = Color.PowderBlue
        SH14.BackColor = Color.PowderBlue
        SH15.BackColor = Color.PowderBlue
        SJ14.BackColor = Color.PowderBlue
        SJ15.BackColor = Color.PowderBlue
        SK15.BackColor = Color.PowderBlue
        SK16.BackColor = Color.PowderBlue
        SL15.BackColor = Color.PowderBlue
        'Reset colour of all other seating
        For Each Button In Options
            BackColor = Color.FromKnownColor(KnownColor.Control)
        Next
    End Sub
End Class

