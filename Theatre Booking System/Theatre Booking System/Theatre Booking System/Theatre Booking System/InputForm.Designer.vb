<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpNewCustomer = New System.Windows.Forms.GroupBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.lblExpire = New System.Windows.Forms.Label()
        Me.txtSecurityCode = New System.Windows.Forms.TextBox()
        Me.lblSecurity = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtMail2 = New System.Windows.Forms.TextBox()
        Me.lblMail2 = New System.Windows.Forms.Label()
        Me.txtMail1 = New System.Windows.Forms.TextBox()
        Me.lblMail1 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.txtForname = New System.Windows.Forms.TextBox()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblSeat1 = New System.Windows.Forms.Label()
        Me.lblSeat2 = New System.Windows.Forms.Label()
        Me.lblSeat3 = New System.Windows.Forms.Label()
        Me.lblSeat4 = New System.Windows.Forms.Label()
        Me.lblSeat5 = New System.Windows.Forms.Label()
        Me.lblSeatX = New System.Windows.Forms.Label()
        Me.lblSeat9 = New System.Windows.Forms.Label()
        Me.lblSeat8 = New System.Windows.Forms.Label()
        Me.lblSeat7 = New System.Windows.Forms.Label()
        Me.lblSeat6 = New System.Windows.Forms.Label()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.rtbPriceFromFriday = New System.Windows.Forms.RichTextBox()
        Me.rtbPriceFromSaturday = New System.Windows.Forms.RichTextBox()
        Me.grpNewCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNewCustomer
        '
        Me.grpNewCustomer.Controls.Add(Me.cmbYear)
        Me.grpNewCustomer.Controls.Add(Me.cmbMonth)
        Me.grpNewCustomer.Controls.Add(Me.lblExpire)
        Me.grpNewCustomer.Controls.Add(Me.txtSecurityCode)
        Me.grpNewCustomer.Controls.Add(Me.lblSecurity)
        Me.grpNewCustomer.Controls.Add(Me.txtCardNumber)
        Me.grpNewCustomer.Controls.Add(Me.lblCard)
        Me.grpNewCustomer.Controls.Add(Me.txtPostCode)
        Me.grpNewCustomer.Controls.Add(Me.txtAddress1)
        Me.grpNewCustomer.Controls.Add(Me.txtAddress2)
        Me.grpNewCustomer.Controls.Add(Me.lblAddress)
        Me.grpNewCustomer.Controls.Add(Me.txtMail2)
        Me.grpNewCustomer.Controls.Add(Me.lblMail2)
        Me.grpNewCustomer.Controls.Add(Me.txtMail1)
        Me.grpNewCustomer.Controls.Add(Me.lblMail1)
        Me.grpNewCustomer.Controls.Add(Me.txtSurname)
        Me.grpNewCustomer.Controls.Add(Me.lblSurname)
        Me.grpNewCustomer.Controls.Add(Me.cmbTitle)
        Me.grpNewCustomer.Controls.Add(Me.txtForname)
        Me.grpNewCustomer.Controls.Add(Me.lblForename)
        Me.grpNewCustomer.Controls.Add(Me.lblTitle)
        Me.grpNewCustomer.ForeColor = System.Drawing.Color.Gray
        Me.grpNewCustomer.Location = New System.Drawing.Point(3, 47)
        Me.grpNewCustomer.Name = "grpNewCustomer"
        Me.grpNewCustomer.Size = New System.Drawing.Size(240, 284)
        Me.grpNewCustomer.TabIndex = 1
        Me.grpNewCustomer.TabStop = False
        Me.grpNewCustomer.Text = "Register New Account"
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.SystemColors.Window
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cmbYear.Location = New System.Drawing.Point(172, 256)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(59, 21)
        Me.cmbYear.TabIndex = 23
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"01 (JAN)", "02 (FEB)", "03 (MAR)", "04 (APR)", "05 (MAY)", "06 (JUN)", "07 (JUL)", "08 (AUG)", "09 (SEP)", "10 (OCT)", "11 (NOV)", "12 (DEC)"})
        Me.cmbMonth.Location = New System.Drawing.Point(75, 256)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(91, 21)
        Me.cmbMonth.TabIndex = 22
        '
        'lblExpire
        '
        Me.lblExpire.AutoSize = True
        Me.lblExpire.ForeColor = System.Drawing.Color.Black
        Me.lblExpire.Location = New System.Drawing.Point(2, 260)
        Me.lblExpire.Name = "lblExpire"
        Me.lblExpire.Size = New System.Drawing.Size(66, 13)
        Me.lblExpire.TabIndex = 21
        Me.lblExpire.Text = "Expires End:"
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecurityCode.Location = New System.Drawing.Point(75, 232)
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.Size = New System.Drawing.Size(59, 20)
        Me.txtSecurityCode.TabIndex = 20
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.ForeColor = System.Drawing.Color.Black
        Me.lblSecurity.Location = New System.Drawing.Point(2, 235)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(76, 13)
        Me.lblSecurity.TabIndex = 19
        Me.lblSecurity.Text = "Security Code:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNumber.Location = New System.Drawing.Point(75, 208)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(156, 20)
        Me.txtCardNumber.TabIndex = 18
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.ForeColor = System.Drawing.Color.Black
        Me.lblCard.Location = New System.Drawing.Point(4, 211)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(72, 13)
        Me.lblCard.TabIndex = 17
        Me.lblCard.Text = "Card Number:"
        '
        'txtPostCode
        '
        Me.txtPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostCode.ForeColor = System.Drawing.Color.Black
        Me.txtPostCode.Location = New System.Drawing.Point(166, 170)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(65, 20)
        Me.txtPostCode.TabIndex = 16
        '
        'txtAddress1
        '
        Me.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress1.ForeColor = System.Drawing.Color.Black
        Me.txtAddress1.Location = New System.Drawing.Point(51, 144)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(180, 20)
        Me.txtAddress1.TabIndex = 12
        '
        'txtAddress2
        '
        Me.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress2.ForeColor = System.Drawing.Color.Black
        Me.txtAddress2.Location = New System.Drawing.Point(7, 170)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(153, 20)
        Me.txtAddress2.TabIndex = 13
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(4, 147)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address:"
        '
        'txtMail2
        '
        Me.txtMail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMail2.Location = New System.Drawing.Point(81, 108)
        Me.txtMail2.Name = "txtMail2"
        Me.txtMail2.Size = New System.Drawing.Size(150, 20)
        Me.txtMail2.TabIndex = 9
        '
        'lblMail2
        '
        Me.lblMail2.AutoSize = True
        Me.lblMail2.ForeColor = System.Drawing.Color.Black
        Me.lblMail2.Location = New System.Drawing.Point(4, 111)
        Me.lblMail2.Name = "lblMail2"
        Me.lblMail2.Size = New System.Drawing.Size(77, 13)
        Me.lblMail2.TabIndex = 11
        Me.lblMail2.Text = "Confirm E-Mail:"
        '
        'txtMail1
        '
        Me.txtMail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMail1.Location = New System.Drawing.Point(81, 83)
        Me.txtMail1.Name = "txtMail1"
        Me.txtMail1.Size = New System.Drawing.Size(150, 20)
        Me.txtMail1.TabIndex = 8
        '
        'lblMail1
        '
        Me.lblMail1.AutoSize = True
        Me.lblMail1.ForeColor = System.Drawing.Color.Black
        Me.lblMail1.Location = New System.Drawing.Point(4, 86)
        Me.lblMail1.Name = "lblMail1"
        Me.lblMail1.Size = New System.Drawing.Size(79, 13)
        Me.lblMail1.TabIndex = 10
        Me.lblMail1.Text = "Contact E-Mail:"
        '
        'txtSurname
        '
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurname.Location = New System.Drawing.Point(55, 45)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(176, 20)
        Me.txtSurname.TabIndex = 7
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.ForeColor = System.Drawing.Color.Black
        Me.lblSurname.Location = New System.Drawing.Point(4, 48)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 6
        Me.lblSurname.Text = "Surname:"
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Miss", "Ms", "Mrs", "Dr"})
        Me.cmbTitle.Location = New System.Drawing.Point(32, 19)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(61, 21)
        Me.cmbTitle.TabIndex = 0
        '
        'txtForname
        '
        Me.txtForname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtForname.Location = New System.Drawing.Point(145, 19)
        Me.txtForname.Name = "txtForname"
        Me.txtForname.Size = New System.Drawing.Size(86, 20)
        Me.txtForname.TabIndex = 5
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.ForeColor = System.Drawing.Color.Black
        Me.lblForename.Location = New System.Drawing.Point(96, 23)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(51, 13)
        Me.lblForename.TabIndex = 2
        Me.lblForename.Text = "Forname:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(4, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title:"
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(88, 335)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Location = New System.Drawing.Point(168, 335)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(75, 23)
        Me.btnBook.TabIndex = 0
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'lblSeat1
        '
        Me.lblSeat1.AutoSize = True
        Me.lblSeat1.Location = New System.Drawing.Point(5, 8)
        Me.lblSeat1.Name = "lblSeat1"
        Me.lblSeat1.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat1.TabIndex = 3
        Me.lblSeat1.Text = "--"
        '
        'lblSeat2
        '
        Me.lblSeat2.AutoSize = True
        Me.lblSeat2.Location = New System.Drawing.Point(42, 8)
        Me.lblSeat2.Name = "lblSeat2"
        Me.lblSeat2.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat2.TabIndex = 4
        Me.lblSeat2.Text = "--"
        '
        'lblSeat3
        '
        Me.lblSeat3.AutoSize = True
        Me.lblSeat3.Location = New System.Drawing.Point(79, 8)
        Me.lblSeat3.Name = "lblSeat3"
        Me.lblSeat3.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat3.TabIndex = 5
        Me.lblSeat3.Text = "--"
        '
        'lblSeat4
        '
        Me.lblSeat4.AutoSize = True
        Me.lblSeat4.Location = New System.Drawing.Point(117, 8)
        Me.lblSeat4.Name = "lblSeat4"
        Me.lblSeat4.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat4.TabIndex = 6
        Me.lblSeat4.Text = "--"
        '
        'lblSeat5
        '
        Me.lblSeat5.AutoSize = True
        Me.lblSeat5.Location = New System.Drawing.Point(155, 8)
        Me.lblSeat5.Name = "lblSeat5"
        Me.lblSeat5.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat5.TabIndex = 7
        Me.lblSeat5.Text = "--"
        '
        'lblSeatX
        '
        Me.lblSeatX.AutoSize = True
        Me.lblSeatX.Location = New System.Drawing.Point(155, 28)
        Me.lblSeatX.Name = "lblSeatX"
        Me.lblSeatX.Size = New System.Drawing.Size(13, 13)
        Me.lblSeatX.TabIndex = 12
        Me.lblSeatX.Text = "--"
        '
        'lblSeat9
        '
        Me.lblSeat9.AutoSize = True
        Me.lblSeat9.Location = New System.Drawing.Point(117, 28)
        Me.lblSeat9.Name = "lblSeat9"
        Me.lblSeat9.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat9.TabIndex = 11
        Me.lblSeat9.Text = "--"
        '
        'lblSeat8
        '
        Me.lblSeat8.AutoSize = True
        Me.lblSeat8.Location = New System.Drawing.Point(79, 28)
        Me.lblSeat8.Name = "lblSeat8"
        Me.lblSeat8.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat8.TabIndex = 10
        Me.lblSeat8.Text = "--"
        '
        'lblSeat7
        '
        Me.lblSeat7.AutoSize = True
        Me.lblSeat7.Location = New System.Drawing.Point(42, 28)
        Me.lblSeat7.Name = "lblSeat7"
        Me.lblSeat7.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat7.TabIndex = 9
        Me.lblSeat7.Text = "--"
        '
        'lblSeat6
        '
        Me.lblSeat6.AutoSize = True
        Me.lblSeat6.Location = New System.Drawing.Point(5, 28)
        Me.lblSeat6.Name = "lblSeat6"
        Me.lblSeat6.Size = New System.Drawing.Size(13, 13)
        Me.lblSeat6.TabIndex = 8
        Me.lblSeat6.Text = "--"
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalPrice.Location = New System.Drawing.Point(191, 18)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(52, 16)
        Me.lblFinalPrice.TabIndex = 13
        Me.lblFinalPrice.Text = "£XX.xx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbPriceFromFriday
        '
        Me.rtbPriceFromFriday.Location = New System.Drawing.Point(3, 335)
        Me.rtbPriceFromFriday.Name = "rtbPriceFromFriday"
        Me.rtbPriceFromFriday.Size = New System.Drawing.Size(25, 23)
        Me.rtbPriceFromFriday.TabIndex = 14
        Me.rtbPriceFromFriday.Text = ""
        '
        'rtbPriceFromSaturday
        '
        Me.rtbPriceFromSaturday.Location = New System.Drawing.Point(35, 335)
        Me.rtbPriceFromSaturday.Name = "rtbPriceFromSaturday"
        Me.rtbPriceFromSaturday.Size = New System.Drawing.Size(24, 23)
        Me.rtbPriceFromSaturday.TabIndex = 15
        Me.rtbPriceFromSaturday.Text = ""
        '
        'InputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 362)
        Me.Controls.Add(Me.rtbPriceFromSaturday)
        Me.Controls.Add(Me.rtbPriceFromFriday)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.lblSeatX)
        Me.Controls.Add(Me.lblSeat9)
        Me.Controls.Add(Me.lblSeat8)
        Me.Controls.Add(Me.lblSeat7)
        Me.Controls.Add(Me.lblSeat6)
        Me.Controls.Add(Me.lblSeat5)
        Me.Controls.Add(Me.lblSeat4)
        Me.Controls.Add(Me.lblSeat3)
        Me.Controls.Add(Me.lblSeat2)
        Me.Controls.Add(Me.lblSeat1)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpNewCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Confirmation"
        Me.grpNewCustomer.ResumeLayout(False)
        Me.grpNewCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpNewCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBook As System.Windows.Forms.Button
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtForname As System.Windows.Forms.TextBox
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtMail2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMail2 As System.Windows.Forms.Label
    Friend WithEvents txtMail1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMail1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtSecurityCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSecurity As System.Windows.Forms.Label
    Friend WithEvents txtCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCard As System.Windows.Forms.Label
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents lblExpire As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeat1 As System.Windows.Forms.Label
    Friend WithEvents lblSeat2 As System.Windows.Forms.Label
    Friend WithEvents lblSeat3 As System.Windows.Forms.Label
    Friend WithEvents lblSeat4 As System.Windows.Forms.Label
    Friend WithEvents lblSeat5 As System.Windows.Forms.Label
    Friend WithEvents lblSeatX As System.Windows.Forms.Label
    Friend WithEvents lblSeat9 As System.Windows.Forms.Label
    Friend WithEvents lblSeat8 As System.Windows.Forms.Label
    Friend WithEvents lblSeat7 As System.Windows.Forms.Label
    Friend WithEvents lblSeat6 As System.Windows.Forms.Label
    Friend WithEvents lblFinalPrice As System.Windows.Forms.Label
    Friend WithEvents rtbPriceFromFriday As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbPriceFromSaturday As System.Windows.Forms.RichTextBox
End Class
