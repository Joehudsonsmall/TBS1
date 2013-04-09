<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMenu
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
        Me.btnSearchForm = New System.Windows.Forms.Button()
        Me.btnViewSum = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAuditorium = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSearchForm
        '
        Me.btnSearchForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSearchForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSearchForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchForm.Location = New System.Drawing.Point(2, 4)
        Me.btnSearchForm.Name = "btnSearchForm"
        Me.btnSearchForm.Size = New System.Drawing.Size(180, 23)
        Me.btnSearchForm.TabIndex = 0
        Me.btnSearchForm.Text = "Customer and Booking Search"
        Me.btnSearchForm.UseVisualStyleBackColor = True
        '
        'btnViewSum
        '
        Me.btnViewSum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnViewSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnViewSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSum.Location = New System.Drawing.Point(2, 33)
        Me.btnViewSum.Name = "btnViewSum"
        Me.btnViewSum.Size = New System.Drawing.Size(180, 23)
        Me.btnViewSum.TabIndex = 1
        Me.btnViewSum.Text = "View Financial Summary"
        Me.btnViewSum.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(2, 91)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit to Login"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAuditorium
        '
        Me.btnAuditorium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAuditorium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAuditorium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditorium.Location = New System.Drawing.Point(2, 62)
        Me.btnAuditorium.Name = "btnAuditorium"
        Me.btnAuditorium.Size = New System.Drawing.Size(180, 23)
        Me.btnAuditorium.TabIndex = 3
        Me.btnAuditorium.Text = "Auditorium Plan"
        Me.btnAuditorium.UseVisualStyleBackColor = True
        '
        'StaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 119)
        Me.Controls.Add(Me.btnAuditorium)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewSum)
        Me.Controls.Add(Me.btnSearchForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StaffMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearchForm As System.Windows.Forms.Button
    Friend WithEvents btnViewSum As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAuditorium As System.Windows.Forms.Button
End Class
