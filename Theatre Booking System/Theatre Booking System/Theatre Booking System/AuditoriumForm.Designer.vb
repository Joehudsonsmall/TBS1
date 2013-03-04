<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditoriumForm
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
        Me.tabsDaySelect = New System.Windows.Forms.TabControl()
        Me.tabFri = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabSat = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tabsDaySelect.SuspendLayout()
        Me.tabFri.SuspendLayout()
        Me.tabSat.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabsDaySelect
        '
        Me.tabsDaySelect.Controls.Add(Me.tabFri)
        Me.tabsDaySelect.Controls.Add(Me.tabSat)
        Me.tabsDaySelect.Location = New System.Drawing.Point(3, 3)
        Me.tabsDaySelect.Name = "tabsDaySelect"
        Me.tabsDaySelect.SelectedIndex = 0
        Me.tabsDaySelect.Size = New System.Drawing.Size(969, 523)
        Me.tabsDaySelect.TabIndex = 0
        '
        'tabFri
        '
        Me.tabFri.Controls.Add(Me.Label1)
        Me.tabFri.Location = New System.Drawing.Point(4, 22)
        Me.tabFri.Name = "tabFri"
        Me.tabFri.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFri.Size = New System.Drawing.Size(961, 497)
        Me.tabFri.TabIndex = 0
        Me.tabFri.Text = "Friday, October 4th (04/10/2013)"
        Me.tabFri.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tab 0"
        '
        'tabSat
        '
        Me.tabSat.Controls.Add(Me.Label2)
        Me.tabSat.Location = New System.Drawing.Point(4, 22)
        Me.tabSat.Name = "tabSat"
        Me.tabSat.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSat.Size = New System.Drawing.Size(961, 497)
        Me.tabSat.TabIndex = 1
        Me.tabSat.Text = "Saturday, October 5th (05/10/2013)"
        Me.tabSat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tab 1"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(97, 532)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Selection"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(191, 532)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(88, 23)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Exit to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(883, 532)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(88, 23)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "Book ⇒"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(3, 532)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Start Over"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AuditoriumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 558)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tabsDaySelect)
        Me.Name = "AuditoriumForm"
        Me.Text = "Auditorium Plan - Seating Selection"
        Me.tabsDaySelect.ResumeLayout(False)
        Me.tabFri.ResumeLayout(False)
        Me.tabFri.PerformLayout()
        Me.tabSat.ResumeLayout(False)
        Me.tabSat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabsDaySelect As System.Windows.Forms.TabControl
    Friend WithEvents tabFri As System.Windows.Forms.TabPage
    Friend WithEvents tabSat As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnBook As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
