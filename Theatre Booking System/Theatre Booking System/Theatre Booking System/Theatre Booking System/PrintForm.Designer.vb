<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatic = New System.Windows.Forms.TextBox()
        Me.lblDynamic = New System.Windows.Forms.TextBox()
        Me.barPrintProgress = New System.Windows.Forms.ProgressBar()
        Me.lblCustPIN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(244, 143)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 21)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Location = New System.Drawing.Point(163, 143)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 21)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'lblStatic
        '
        Me.lblStatic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblStatic.Location = New System.Drawing.Point(12, 58)
        Me.lblStatic.Multiline = True
        Me.lblStatic.Name = "lblStatic"
        Me.lblStatic.ReadOnly = True
        Me.lblStatic.Size = New System.Drawing.Size(300, 39)
        Me.lblStatic.TabIndex = 3
        Me.lblStatic.Text = "Please collect  your tickets and take note of your Order Number/PIN, to be quoted" & _
    " at this terminal or over the theatre’s helpline, should you choose to cancel yo" & _
    "ur booking:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDynamic
        '
        Me.lblDynamic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDynamic.Location = New System.Drawing.Point(12, 12)
        Me.lblDynamic.Multiline = True
        Me.lblDynamic.Name = "lblDynamic"
        Me.lblDynamic.ReadOnly = True
        Me.lblDynamic.Size = New System.Drawing.Size(300, 39)
        Me.lblDynamic.TabIndex = 4
        Me.lblDynamic.Text = "placeholder"
        '
        'barPrintProgress
        '
        Me.barPrintProgress.ForeColor = System.Drawing.Color.LawnGreen
        Me.barPrintProgress.Location = New System.Drawing.Point(4, 143)
        Me.barPrintProgress.Name = "barPrintProgress"
        Me.barPrintProgress.Size = New System.Drawing.Size(153, 21)
        Me.barPrintProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barPrintProgress.TabIndex = 5
        '
        'lblCustPIN
        '
        Me.lblCustPIN.AutoSize = True
        Me.lblCustPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustPIN.Location = New System.Drawing.Point(115, 110)
        Me.lblCustPIN.Name = "lblCustPIN"
        Me.lblCustPIN.Size = New System.Drawing.Size(88, 16)
        Me.lblCustPIN.TabIndex = 6
        Me.lblCustPIN.Text = "XX - XX - XX"
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 170)
        Me.Controls.Add(Me.lblCustPIN)
        Me.Controls.Add(Me.barPrintProgress)
        Me.Controls.Add(Me.lblDynamic)
        Me.Controls.Add(Me.lblStatic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PrintForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thank You For Booking!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatic As System.Windows.Forms.TextBox
    Friend WithEvents lblDynamic As System.Windows.Forms.TextBox
    Friend WithEvents barPrintProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCustPIN As System.Windows.Forms.Label
End Class
