<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportOptionsDialog
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblBackColor = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHTMLArtText = New System.Windows.Forms.TextBox
        Me.lblForeColor = New System.Windows.Forms.Label
        Me.numFontSize = New System.Windows.Forms.NumericUpDown
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.numFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Font Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Page ForeColor:"
        '
        'lblBackColor
        '
        Me.lblBackColor.BackColor = System.Drawing.Color.Black
        Me.lblBackColor.ForeColor = System.Drawing.Color.White
        Me.lblBackColor.Location = New System.Drawing.Point(169, 50)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(160, 15)
        Me.lblBackColor.TabIndex = 10
        Me.lblBackColor.Text = "Click to set the BackColor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Page BackColor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Text to use on the HTML Art:"
        '
        'txtHTMLArtText
        '
        Me.txtHTMLArtText.Location = New System.Drawing.Point(169, 23)
        Me.txtHTMLArtText.Name = "txtHTMLArtText"
        Me.txtHTMLArtText.Size = New System.Drawing.Size(251, 20)
        Me.txtHTMLArtText.TabIndex = 9
        '
        'lblForeColor
        '
        Me.lblForeColor.BackColor = System.Drawing.Color.Black
        Me.lblForeColor.ForeColor = System.Drawing.Color.White
        Me.lblForeColor.Location = New System.Drawing.Point(169, 71)
        Me.lblForeColor.Name = "lblForeColor"
        Me.lblForeColor.Size = New System.Drawing.Size(160, 15)
        Me.lblForeColor.TabIndex = 13
        Me.lblForeColor.Text = "Click to set the ForeColor"
        '
        'numFontSize
        '
        Me.numFontSize.Location = New System.Drawing.Point(169, 91)
        Me.numFontSize.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numFontSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFontSize.Name = "numFontSize"
        Me.numFontSize.Size = New System.Drawing.Size(120, 20)
        Me.numFontSize.TabIndex = 15
        Me.numFontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(308, 157)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 17
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(381, 157)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 18
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.numFontSize)
        Me.GroupBox1.Controls.Add(Me.lblForeColor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHTMLArtText)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblBackColor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 139)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display Options"
        '
        'ExportOptionsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 191)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExportOptionsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Options"
        CType(Me.numFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBackColor As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHTMLArtText As System.Windows.Forms.TextBox
    Friend WithEvents lblForeColor As System.Windows.Forms.Label
    Friend WithEvents numFontSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
