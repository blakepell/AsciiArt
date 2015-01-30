<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripNewDocument = New System.Windows.Forms.ToolStripButton
        Me.ToolStripOpenImage = New System.Windows.Forms.ToolStripButton
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ToolStripExportToHTMLArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripExportToASCIIArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToUNICODEArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripResizeForm = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.PreviewHTMLArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviewASCIIArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviewUNICODEArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToHTMLArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToASCIIArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToUNICODEArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenApplicationDataTemporaryDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoResizeFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNewDocument, Me.ToolStripOpenImage, Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.ToolStripResizeForm, Me.ToolStripSeparator2, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(375, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripNewDocument
        '
        Me.ToolStripNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNewDocument.Image = CType(resources.GetObject("ToolStripNewDocument.Image"), System.Drawing.Image)
        Me.ToolStripNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNewDocument.Name = "ToolStripNewDocument"
        Me.ToolStripNewDocument.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripNewDocument.Text = "New Document"
        '
        'ToolStripOpenImage
        '
        Me.ToolStripOpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripOpenImage.Image = CType(resources.GetObject("ToolStripOpenImage.Image"), System.Drawing.Image)
        Me.ToolStripOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripOpenImage.Name = "ToolStripOpenImage"
        Me.ToolStripOpenImage.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripOpenImage.Text = "Open Image"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripExportToHTMLArtToolStripMenuItem, Me.ToolStripExportToASCIIArtToolStripMenuItem, Me.ExportToUNICODEArtToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ToolStripExportToHTMLArtToolStripMenuItem
        '
        Me.ToolStripExportToHTMLArtToolStripMenuItem.Image = CType(resources.GetObject("ToolStripExportToHTMLArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolStripExportToHTMLArtToolStripMenuItem.Name = "ToolStripExportToHTMLArtToolStripMenuItem"
        Me.ToolStripExportToHTMLArtToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripExportToHTMLArtToolStripMenuItem.Text = "Export to HTML Art"
        '
        'ToolStripExportToASCIIArtToolStripMenuItem
        '
        Me.ToolStripExportToASCIIArtToolStripMenuItem.Image = CType(resources.GetObject("ToolStripExportToASCIIArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolStripExportToASCIIArtToolStripMenuItem.Name = "ToolStripExportToASCIIArtToolStripMenuItem"
        Me.ToolStripExportToASCIIArtToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripExportToASCIIArtToolStripMenuItem.Text = "Export to ASCII Art"
        '
        'ExportToUNICODEArtToolStripMenuItem
        '
        Me.ExportToUNICODEArtToolStripMenuItem.Image = CType(resources.GetObject("ExportToUNICODEArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportToUNICODEArtToolStripMenuItem.Name = "ExportToUNICODEArtToolStripMenuItem"
        Me.ExportToUNICODEArtToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExportToUNICODEArtToolStripMenuItem.Text = "Export to UNICODE Art"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripResizeForm
        '
        Me.ToolStripResizeForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripResizeForm.Image = CType(resources.GetObject("ToolStripResizeForm.Image"), System.Drawing.Image)
        Me.ToolStripResizeForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripResizeForm.Name = "ToolStripResizeForm"
        Me.ToolStripResizeForm.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripResizeForm.Text = "ToolStripResizeForm"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreviewHTMLArtToolStripMenuItem, Me.PreviewASCIIArtToolStripMenuItem, Me.PreviewUNICODEArtToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripSplitButton1.Text = "Preview"
        '
        'PreviewHTMLArtToolStripMenuItem
        '
        Me.PreviewHTMLArtToolStripMenuItem.Name = "PreviewHTMLArtToolStripMenuItem"
        Me.PreviewHTMLArtToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PreviewHTMLArtToolStripMenuItem.Text = "Preview HTML Art"
        '
        'PreviewASCIIArtToolStripMenuItem
        '
        Me.PreviewASCIIArtToolStripMenuItem.Name = "PreviewASCIIArtToolStripMenuItem"
        Me.PreviewASCIIArtToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PreviewASCIIArtToolStripMenuItem.Text = "Preview ASCII Art"
        '
        'PreviewUNICODEArtToolStripMenuItem
        '
        Me.PreviewUNICODEArtToolStripMenuItem.Name = "PreviewUNICODEArtToolStripMenuItem"
        Me.PreviewUNICODEArtToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PreviewUNICODEArtToolStripMenuItem.Text = "Preview UNICODE Art"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(375, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDocumentToolStripMenuItem, Me.OpenImageToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ToolStripMenuItem2, Me.OpenApplicationDataTemporaryDirectoryToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewDocumentToolStripMenuItem
        '
        Me.NewDocumentToolStripMenuItem.Image = CType(resources.GetObject("NewDocumentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewDocumentToolStripMenuItem.Name = "NewDocumentToolStripMenuItem"
        Me.NewDocumentToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.NewDocumentToolStripMenuItem.Text = "New Document"
        '
        'OpenImageToolStripMenuItem
        '
        Me.OpenImageToolStripMenuItem.Image = CType(resources.GetObject("OpenImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem"
        Me.OpenImageToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.OpenImageToolStripMenuItem.Text = "&Open Image"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToHTMLArtToolStripMenuItem, Me.ToASCIIArtToolStripMenuItem, Me.ToUNICODEArtToolStripMenuItem})
        Me.ExportToolStripMenuItem.Image = CType(resources.GetObject("ExportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ToHTMLArtToolStripMenuItem
        '
        Me.ToHTMLArtToolStripMenuItem.Image = CType(resources.GetObject("ToHTMLArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToHTMLArtToolStripMenuItem.Name = "ToHTMLArtToolStripMenuItem"
        Me.ToHTMLArtToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ToHTMLArtToolStripMenuItem.Text = "To HTML Art"
        '
        'ToASCIIArtToolStripMenuItem
        '
        Me.ToASCIIArtToolStripMenuItem.Image = CType(resources.GetObject("ToASCIIArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToASCIIArtToolStripMenuItem.Name = "ToASCIIArtToolStripMenuItem"
        Me.ToASCIIArtToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ToASCIIArtToolStripMenuItem.Text = "To ASCII Art"
        '
        'ToUNICODEArtToolStripMenuItem
        '
        Me.ToUNICODEArtToolStripMenuItem.Image = CType(resources.GetObject("ToUNICODEArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToUNICODEArtToolStripMenuItem.Name = "ToUNICODEArtToolStripMenuItem"
        Me.ToUNICODEArtToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ToUNICODEArtToolStripMenuItem.Text = "To UNICODE Art"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(303, 6)
        '
        'OpenApplicationDataTemporaryDirectoryToolStripMenuItem
        '
        Me.OpenApplicationDataTemporaryDirectoryToolStripMenuItem.Name = "OpenApplicationDataTemporaryDirectoryToolStripMenuItem"
        Me.OpenApplicationDataTemporaryDirectoryToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.OpenApplicationDataTemporaryDirectoryToolStripMenuItem.Text = "Open Application Data Temporary Directory"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(303, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoResizeFormToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'AutoResizeFormToolStripMenuItem
        '
        Me.AutoResizeFormToolStripMenuItem.Image = CType(resources.GetObject("AutoResizeFormToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AutoResizeFormToolStripMenuItem.Name = "AutoResizeFormToolStripMenuItem"
        Me.AutoResizeFormToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AutoResizeFormToolStripMenuItem.Text = "Auto Resize Form"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 375)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(375, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 397)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image to Text (Ascii Art/HTML Art/Unicode Art)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripOpenImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripExportToHTMLArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripExportToASCIIArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToHTMLArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToASCIIArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripNewDocument As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripResizeForm As System.Windows.Forms.ToolStripButton
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoResizeFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenApplicationDataTemporaryDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PreviewHTMLArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewASCIIArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewUNICODEArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToUNICODEArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToUNICODEArtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
