<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents pngSADs As System.Windows.Forms.PictureBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabsLoginForm = New System.Windows.Forms.TabControl()
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBookSat = New System.Windows.Forms.Button()
        Me.btnBookFri = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabStaff = New System.Windows.Forms.TabPage()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pngSADs = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tabsLoginForm.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStaff.SuspendLayout()
        CType(Me.pngSADs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabsLoginForm
        '
        Me.tabsLoginForm.Controls.Add(Me.tabCustomer)
        Me.tabsLoginForm.Controls.Add(Me.tabStaff)
        Me.tabsLoginForm.Location = New System.Drawing.Point(1, 1)
        Me.tabsLoginForm.Name = "tabsLoginForm"
        Me.tabsLoginForm.SelectedIndex = 0
        Me.tabsLoginForm.Size = New System.Drawing.Size(321, 116)
        Me.tabsLoginForm.TabIndex = 6
        '
        'tabCustomer
        '
        Me.tabCustomer.Controls.Add(Me.lblWelcome)
        Me.tabCustomer.Controls.Add(Me.btnBookSat)
        Me.tabCustomer.Controls.Add(Me.btnBookFri)
        Me.tabCustomer.Controls.Add(Me.PictureBox1)
        Me.tabCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomer.Size = New System.Drawing.Size(313, 90)
        Me.tabCustomer.TabIndex = 0
        Me.tabCustomer.Text = "Customer"
        Me.tabCustomer.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(6, 11)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(216, 13)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Welcome to SADs Theatre Booking System!"
        '
        'btnBookSat
        '
        Me.btnBookSat.Location = New System.Drawing.Point(6, 61)
        Me.btnBookSat.Name = "btnBookSat"
        Me.btnBookSat.Size = New System.Drawing.Size(212, 23)
        Me.btnBookSat.TabIndex = 10
        Me.btnBookSat.Text = "Saturday, October 5th (05/10/2013)"
        Me.btnBookSat.UseVisualStyleBackColor = True
        '
        'btnBookFri
        '
        Me.btnBookFri.Location = New System.Drawing.Point(6, 32)
        Me.btnBookFri.Name = "btnBookFri"
        Me.btnBookFri.Size = New System.Drawing.Size(212, 23)
        Me.btnBookFri.TabIndex = 9
        Me.btnBookFri.Text = "Friday, October 4th (04/10/2013)"
        Me.btnBookFri.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Theatre_Booking_System.My.Resources.Resources.SADs_Logo
        Me.PictureBox1.InitialImage = Global.Theatre_Booking_System.My.Resources.Resources.SADs_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(226, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'tabStaff
        '
        Me.tabStaff.Controls.Add(Me.btnLogin)
        Me.tabStaff.Controls.Add(Me.pngSADs)
        Me.tabStaff.Controls.Add(Me.txtPassword)
        Me.tabStaff.Controls.Add(Me.lblPassword)
        Me.tabStaff.Location = New System.Drawing.Point(4, 22)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStaff.Size = New System.Drawing.Size(313, 90)
        Me.tabStaff.TabIndex = 1
        Me.tabStaff.Text = "Staff"
        Me.tabStaff.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(6, 61)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(212, 23)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'pngSADs
        '
        Me.pngSADs.Image = Global.Theatre_Booking_System.My.Resources.Resources.SADs_Logo
        Me.pngSADs.InitialImage = Global.Theatre_Booking_System.My.Resources.Resources.SADs_Logo
        Me.pngSADs.Location = New System.Drawing.Point(226, 3)
        Me.pngSADs.Name = "pngSADs"
        Me.pngSADs.Size = New System.Drawing.Size(86, 86)
        Me.pngSADs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pngSADs.TabIndex = 0
        Me.pngSADs.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(78, 22)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(124, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(22, 20)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 23)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Staff UID:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 118)
        Me.Controls.Add(Me.tabsLoginForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Performance Date Selection"
        Me.tabsLoginForm.ResumeLayout(False)
        Me.tabCustomer.ResumeLayout(False)
        Me.tabCustomer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStaff.ResumeLayout(False)
        Me.tabStaff.PerformLayout()
        CType(Me.pngSADs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabsLoginForm As System.Windows.Forms.TabControl
    Friend WithEvents tabCustomer As System.Windows.Forms.TabPage
    Friend WithEvents tabStaff As System.Windows.Forms.TabPage
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBookSat As System.Windows.Forms.Button
    Friend WithEvents btnBookFri As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label

End Class
