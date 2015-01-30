Imports System.Drawing
Imports System.IO

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ''' <summary>
    ''' Change form element when the drop down's criteria changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub ddExportType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddExportType.SelectedIndexChanged

        Select Case ddExportType.SelectedValue
            Case "ASCII", "UNICODE"
                txtHtmlArtText.Visible = False
                litHtmlArtText.Visible = False
            Case "HTML"
                txtHtmlArtText.Visible = True
                litHtmlArtText.Visible = True
            Case Else
                txtHtmlArtText.Visible = False
                litHtmlArtText.Visible = False
        End Select

    End Sub

    Protected Sub btnGenerateTextArt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerateTextArt.Click

        If FileUpload1.HasFile = False Then
            litInfo.Text = "<font color='red'>You must select a file to upload.</font>"
            Exit Sub
        End If

        Dim fi As New FileInfo(FileUpload1.FileName)

        Select Case fi.Extension.ToLower
            Case ".jpg", ".jpeg", ".bmp", ".exig", ".png", ".tiff"

            Case Else
                litInfo.Text = "<font color='red'>You have choosen an unsupported file type.  Supported file types include:  BMP, GIF, EXIG, JPG, PNG and TIFF.</font>"
                Exit Sub
        End Select

        Dim sourcePic As New Bitmap(FileUpload1.FileContent)
        Dim picConvert As New Argus.Imaging.BitmapToText(sourcePic)

        Select Case ddExportType.SelectedValue
            Case "ASCII"
                Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}.txt", Guid.NewGuid.ToString))
                Response.ContentType = "text/plain"
                Response.Write(picConvert.AsciiText)
                Response.End()
            Case "UNICODE"
                Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}.txt", Guid.NewGuid.ToString))
                Response.ContentType = "text/plain"
                Response.Write(picConvert.UnicodeText)
                Response.End()
            Case "HTML"
                If txtHtmlArtText.Text <> "" Then
                    Response.AddHeader("Content-Disposition", String.Format("inline; filename={0}.html", Guid.NewGuid.ToString))
                    Response.ContentType = "text/html"
                    picConvert.HtmlArtText = txtHtmlArtText.Text
                End If

                Response.Write(picConvert.HtmlArt)
                'Response.Flush()            
                Response.End()
            Case Else
                litInfo.Text = "Invalid selection."
        End Select

        sourcePic.Dispose()
        picConvert.Dispose()

    End Sub

End Class
