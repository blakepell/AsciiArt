Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Math
Imports System.IO

Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Directory.Exists(Globals.ApplicationData) = False Then

            Try
                Directory.CreateDirectory(Globals.ApplicationData)
            Catch ex As Exception
                Dim buf As String = "An error occured creating the temporary directory for this application.  The preview " & vbCrLf & _
                                    "button may not function as a result though you can still export files." & vbCrLf & vbCrLf & _
                                    "Error Description:  " & ex.Message

                MessageBox.Show(buf, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    ''' <summary>
    ''' End the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OpenImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Open Image File"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.ShowReadOnly = False
        OpenFileDialog1.SupportMultiDottedExtensions = True
        OpenFileDialog1.ValidateNames = True
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp|All Files *.*|*.*"

        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        Try
            Dim bMap As New Bitmap(OpenFileDialog1.FileName)
            PictureBox1.Image = bMap
            SetStatus(String.Format("Image Resolution:  {0}x{1}", bMap.Width, bMap.Height))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error opening image", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Call AutoResizeFormToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub ToHTMLArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToHTMLArtToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("You must open an image first before you export to an HTML Art file.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim optionsForm As New ExportOptionsDialog
        If optionsForm.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Title = "Export to HTML File"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = ".html"
        SaveFileDialog1.SupportMultiDottedExtensions = True
        SaveFileDialog1.ValidateNames = True
        SaveFileDialog1.Filter = "HTML Files|*.html;*.htm;"

        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        Try
            Dim asciiArt As New Argus.Imaging.TextArt(PictureBox1.Image)
            asciiArt.HtmlArtText = optionsForm.txtHTMLArtText.Text
            asciiArt.BackgroundColor = optionsForm.lblBackColor.BackColor
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, asciiArt.HtmlArt, False, System.Text.Encoding.ASCII)
            asciiArt.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Saving HTML Art", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ToASCIIArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToASCIIArtToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("You must open an image first before you export to an ASCII Art file.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Title = "Export to ASCII Art Text File"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.SupportMultiDottedExtensions = True
        SaveFileDialog1.ValidateNames = True
        SaveFileDialog1.Filter = "Text Files|*.txt;"

        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        Try
            Dim asciiArt As New Argus.Imaging.TextArt(PictureBox1.Image)
            ' Write out to the file system with ASCII encoding.
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, asciiArt.AsciiText, False, System.Text.Encoding.ASCII)
            asciiArt.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Saving ASCII Art", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToUNICODEArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToUNICODEArtToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("You must open an image first before you export to an UNICODE Art file.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Title = "Export to UNICODE Art Text File"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.SupportMultiDottedExtensions = True
        SaveFileDialog1.ValidateNames = True
        SaveFileDialog1.Filter = "Text Files|*.txt;"

        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        Try
            Dim unicodeArt As New Argus.Imaging.TextArt(PictureBox1.Image)
            ' Write out to the file system with Unicode encoding.
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, unicodeArt.UnicodeText, False, System.Text.Encoding.Unicode)
            unicodeArt.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Saving UNICODE Art", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NewDocumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDocumentToolStripMenuItem.Click

        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
        End If

        PictureBox1.Image = Nothing
        SetStatus("")

    End Sub

    Private Sub AutoResizeFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoResizeFormToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then

            If PictureBox1.Image.Width < Screen.PrimaryScreen.WorkingArea.Width And PictureBox1.Image.Height < Screen.PrimaryScreen.WorkingArea.Height Then
                Me.Width = PictureBox1.Image.Width + 40
                Me.Height = PictureBox1.Image.Height + 125
                PictureBox1.Height = PictureBox1.Image.Height
                PictureBox1.Width = PictureBox1.Image.Width
                SetStatus(String.Format("{0}x{1} shown at {2}x{3}", PictureBox1.Image.Width, PictureBox1.Image.Height, PictureBox1.Width, PictureBox1.Height))

                If Me.Bottom < Screen.PrimaryScreen.WorkingArea.Height Then
                    Me.Top = 0
                    Me.Left = 0
                End If

            Else

                Dim tWidth As Integer = 0
                Dim tHeight As Integer = 0
                Dim widthPercent As Decimal = 0
                Dim heightPercent As Decimal = 0

                widthPercent = Screen.PrimaryScreen.WorkingArea.Width / PictureBox1.Image.Width
                heightPercent = Screen.PrimaryScreen.WorkingArea.Height / PictureBox1.Image.Height

                If heightPercent >= widthPercent Then
                    Me.Height = PictureBox1.Image.Height * (widthPercent)
                    Me.Width = PictureBox1.Image.Width * (widthPercent)
                    PictureBox1.Width = Me.Width * 0.89
                    PictureBox1.Height = Me.Height * 0.89

                    Me.Width = PictureBox1.Width + 40

                Else
                    Me.Height = PictureBox1.Image.Height * (heightPercent)
                    Me.Width = PictureBox1.Image.Width * (heightPercent)
                    PictureBox1.Width = Me.Width * 0.89
                    PictureBox1.Height = Me.Height * 0.89

                    Me.Width = PictureBox1.Width + 40

                End If

                Me.Left = 0
                Me.Top = 0

                SetStatus(String.Format("{0}x{1} shown at {2}x{3}", PictureBox1.Image.Width, PictureBox1.Image.Height, PictureBox1.Width, PictureBox1.Height))
            End If

        End If
    End Sub

    Private Sub SetStatus(ByVal status As String)
        StatusLabel.Text = status
    End Sub

    ''' <summary>
    ''' Opens the application's temporary data directory.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OpenApplicationDataTemporaryDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenApplicationDataTemporaryDirectoryToolStripMenuItem.Click
        Globals.StartUrl(Globals.ApplicationData)
    End Sub

    '*******************************************************************************************************************************
    '
    '   Toolstrip Sub's
    '
    '*******************************************************************************************************************************

    Private Sub ToolStripPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Not yet implemented.")
    End Sub

    Private Sub ToolStripNewDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNewDocument.Click
        Call NewDocumentToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripOpenImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripOpenImage.Click
        Call OpenImageToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripExportToHTMLArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripExportToHTMLArtToolStripMenuItem.Click
        Call ToHTMLArtToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripExportToASCIIArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripExportToASCIIArtToolStripMenuItem.Click
        Call ToASCIIArtToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripResizeForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripResizeForm.Click
        Call AutoResizeFormToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub PreviewHTMLArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewHTMLArtToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("You must open an image first before you preview an HTML Art file.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim asciiArt As New Argus.Imaging.TextArt(PictureBox1.Image)
        My.Computer.FileSystem.WriteAllText(Globals.ApplicationData & "Preview.html", asciiArt.HtmlArt, False, System.Text.Encoding.ASCII)
        asciiArt.Dispose()

        Globals.StartUrl(Globals.ApplicationData & "Preview.html")

    End Sub

    Private Sub PreviewASCIIArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewASCIIArtToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("You must open an image first before you export to an ASCII Art file.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim asciiArt As New Argus.Imaging.TextArt(PictureBox1.Image)
        My.Computer.FileSystem.WriteAllText(Globals.ApplicationData & "Preview.txt", asciiArt.AsciiText, False, System.Text.Encoding.Unicode)
        asciiArt.Dispose()

        Globals.StartUrl(Globals.ApplicationData & "Preview.txt")
    End Sub

    Private Sub PreviewUNICODEArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewUNICODEArtToolStripMenuItem.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("You must open an image first before you export to an UNICODE Art file.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim unicodeArt As New Argus.Imaging.TextArt(PictureBox1.Image)
        My.Computer.FileSystem.WriteAllText(Globals.ApplicationData & "Preview.txt", unicodeArt.UnicodeText, False, System.Text.Encoding.Unicode)
        unicodeArt.Dispose()

        Globals.StartUrl(Globals.ApplicationData & "Preview.txt")

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutForm As New AboutBox
        aboutForm.ShowDialog()
    End Sub

    Private Sub ExportToUNICODEArtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToUNICODEArtToolStripMenuItem.Click
        Call ToUNICODEArtToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

End Class
