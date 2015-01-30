Imports System.Drawing
Imports System.Text
Imports System.Math
Imports System.Drawing.Drawing2D

Namespace Argus.Imaging

    ''' <summary>
    ''' Converts a System.Drawing.Bitmap into a text, unicode or HTML representation.
    ''' </summary>
    ''' <remarks>Formerly BitmapToText</remarks>
    Public Class TextArt
        Implements IDisposable

        '*********************************************************************************************************************
        '
        '             Class:  TextArt
        '      Initial Date:  10/03/2008
        '      Last Updated:  01/30/2015
        '     Programmer(s):  Blake Pell, blakepell@hotmail.com
        '      Organization:  http://www.blakepell.com
        '       Description:  This class will allow you to turn a picture into either ASCII Art, colored HTML Art or 
        '                     Unicode Art.  
        '
        '*********************************************************************************************************************

        ''' <summary>
        ''' Darkest to lightest characters to use in Unicode encoding.  
        ''' </summary>
        ''' <remarks>
        ''' For this to work, a font with a constant width needs to be used and moreso, this was specifically written for Courier New
        ''' was specifically written for Courier New (1.5 font works well for display).  You can change the characters if you want
        ''' different fonts.  New characters can be added and the CalculateBrightnessValue will compenstate.  For a good render though
        ''' you'll go darkest looking to lightest looking characters.  We are going to use 20 characters in both the unicode and ascii
        ''' array.  The CalculateBrightnessValue will return the % brightness divided by 20 in order to get one of these characters from
        ''' lightest to darkest.
        ''' </remarks>
        ''' 
        Private _unicodeCharArray As String() = New String() {"█", "█", "▓", "▓", "▒", "▒", "░", "░", "#", "$", "@", "%", "&", "9", "W", "~", "+", ",", ".", "`", "`"}

        ''' <summary>
        ''' Darkest to lightest characters to use in ASCII encoding.  
        ''' </summary>
        ''' <remarks>
        ''' Same remarks as above.
        ''' </remarks>
        ''' 
        Private _asciiCharArray As String() = New String() {"$", "$", "#", "#", "&", "&", "B", "B", "2", "2", "!", "!", "b", "b", "c", "c", "-", "'", "'", "`", "`"}

        ''' <summary>
        ''' Constructor
        ''' </summary>
        ''' <param name="sourceBitmap">The source image.  This will populate the SourceBitmap property.</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal sourceBitmap As Bitmap)
            Me.SourceBitmap = sourceBitmap
        End Sub

        ''' <summary>
        ''' Constructor
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

        End Sub

        ''' <summary>
        ''' Calculates the brightness based off of the bitmap and the number of elements in our character array to choose
        ''' from to create the picture.
        ''' </summary>
        ''' <param name="PixelBrightness"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function CalculateBrightnessValue(ByVal pixelBrightness As Single) As Integer
            CalculateBrightnessValue = Floor((pixelBrightness * 100) / 5) '/ UBound(_charArray)
        End Function

        ''' <summary>
        ''' Resizes the bitmap set via the source bitmap property to the specified heighth and width.
        ''' </summary>
        ''' <param name="width"></param>
        ''' <param name="height"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function ResizeBitmap(ByVal width As Integer, ByVal height As Integer) As Bitmap
            Dim destBitmap As New Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
            destBitmap.SetResolution(_sourceBitmap.HorizontalResolution, _sourceBitmap.VerticalResolution)

            Using gr As Graphics = Graphics.FromImage(destBitmap)
                gr.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                gr.DrawImage(_sourceBitmap, New Rectangle(0, 0, width, height), New Rectangle(0, 0, _sourceBitmap.Width, _sourceBitmap.Height), GraphicsUnit.Pixel)
            End Using

            Return destBitmap
        End Function

        ''' <summary>
        ''' Resizes an image keeping the proportion correct.  This returns a new Image, the passed in image can
        ''' be disposed off afterwards.
        ''' </summary>
        ''' <param name="sourceImage"></param>
        ''' <param name="maxWidth"></param>
        ''' <param name="maxHeight"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ResizeImageInProportion(sourceImage As Image, maxWidth As Integer, maxHeight As Integer) As Image
            ' Determine which ratio is greater, the width or height, and use this to calculate the new width and height
            ' Effectually constrains the proportions of the resized image to the proportions of the original.
            Dim xRatio As Double = CDbl(sourceImage.Width) / maxWidth
            Dim yRatio As Double = CDbl(sourceImage.Height) / maxHeight
            Dim ratioToResizeImage As Double = Math.Max(xRatio, yRatio)
            Dim newWidth As Integer = CInt(Math.Floor(sourceImage.Width / ratioToResizeImage))
            Dim newHeight As Integer = CInt(Math.Floor(sourceImage.Height / ratioToResizeImage))

            ' Create new image canvas -- use maxWidth and maxHeight in this function call if you wish to set the exact
            ' dimensions of the output image.
            Dim newImage As New Bitmap(newWidth, newHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

            ' Render the new image, using a graphic object
            Using newGraphic As Graphics = Graphics.FromImage(newImage)
                ' Set the background color to be transparent (can change this to any color)
                newGraphic.Clear(Color.Transparent)

                ' Set the method of scaling to use -- HighQualityBicubic is said to have the best quality
                newGraphic.InterpolationMode = InterpolationMode.HighQualityBicubic

                ' Apply the transformation onto the new graphic
                Dim sourceDimensions As New Rectangle(0, 0, sourceImage.Width, sourceImage.Height)
                Dim destinationDimensions As New Rectangle(0, 0, newWidth, newHeight)
                newGraphic.DrawImage(sourceImage, destinationDimensions, sourceDimensions, GraphicsUnit.Pixel)
            End Using

            ' Image has been modified by all the references to it's related graphic above. Return changes.
            Return newImage
        End Function

        Private _sourceBitmap As Bitmap
        ''' <summary>
        ''' The source bitmap.  
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SourceBitmap() As Bitmap
            Get
                Return _sourceBitmap
            End Get
            Set(ByVal value As Bitmap)

                If _sourceBitmap IsNot Nothing Then
                    _sourceBitmap.Dispose()
                End If

                _sourceBitmap = value

                If _autoResize = True Then
                    ' Dispose of the old, keep the new if it's larger than the max width/height
                    If _sourceBitmap.Width > Me.MaxWidth Or _sourceBitmap.Height > Me.MaxHeight Then
                        _sourceBitmap = ResizeImageInProportion(_sourceBitmap, Me.MaxWidth, Me.MaxHeight)
                    End If
                End If

            End Set
        End Property

        ''' <summary>
        ''' For use in the AsciiText and UnicodeText properties
        ''' </summary>
        ''' <remarks></remarks>
        Private _sb As New StringBuilder

        ''' <summary>
        ''' The text that makes up the picture.  This re-renders the image when called so if you plan on manipulating the text you
        ''' will need to save the string in a local variable.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks>
        ''' </remarks>
        Public ReadOnly Property UnicodeText() As String
            Get

                If _sourceBitmap Is Nothing Then
                    Return String.Empty
                End If

                ' Clear the StringBuilder
                _sb.Length = 0
                _sb.Capacity = 16

                For y As Integer = 0 To _sourceBitmap.Height - 1
                    For x As Integer = 0 To _sourceBitmap.Width - 1
                        _sb.AppendFormat("{0}", _unicodeCharArray(CalculateBrightnessValue(_sourceBitmap.GetPixel(x, y).GetBrightness)))
                    Next
                    _sb.Append(vbCrLf)
                Next

                Return _sb.ToString
            End Get
        End Property

        ''' <summary>
        ''' The text that makes up the picture.  This re-renders the image when called so if you plan on manipulating the text you
        ''' will need to save the string in a local variable.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks>
        ''' </remarks>
        Public ReadOnly Property AsciiText() As String
            Get

                If _sourceBitmap Is Nothing Then
                    Return String.Empty
                End If

                ' Clear the StringBuilder
                _sb.Length = 0
                _sb.Capacity = 16

                For y As Integer = 0 To _sourceBitmap.Height - 1
                    For x As Integer = 0 To _sourceBitmap.Width - 1
                        _sb.AppendFormat("{0}", _asciiCharArray(CalculateBrightnessValue(_sourceBitmap.GetPixel(x, y).GetBrightness)))
                    Next
                    _sb.Append(vbCrLf)
                Next

                Return _sb.ToString
            End Get
        End Property

        Private _htmlArtText As String = "HTMLART"
        ''' <summary>
        ''' The text to repeat when making up the HTML Art page.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property HtmlArtText() As String
            Get
                Return _htmlArtText
            End Get
            Set(ByVal value As String)
                _htmlArtText = value
            End Set
        End Property

        ''' <summary>
        ''' The HTML to display the color coded picture.  The text used it set in the HtmlArtText property and the IncludePageTags 
        ''' boolean property specifies whether or not this should render the html and body tags.  It will render them by default.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property HtmlArt() As String
            Get

                If _sourceBitmap Is Nothing Then
                    Return String.Empty
                End If

                Dim textPosition As Integer = 0

                ' Clear the StringBuilder
                _sb.Length = 0
                _sb.Capacity = 16

                If _includePageTags = True Then
                    _sb.AppendFormat("<html><body style=""background-color:{0};"">", System.Drawing.ColorTranslator.ToHtml(_backgroundColor))
                End If

                _sb.Append("<div style=""font-family: Courier New, Courier, monospace !important; font-size: 8px !important; background-color: black !important; line-height: 1 !important; display: inline-block !important; letter-spacing: 1px !important; white-space: nowrap !important;"">")

                For y As Integer = 0 To _sourceBitmap.Height - 1
                    For x As Integer = 0 To _sourceBitmap.Width - 1
                        _sb.AppendFormat("<b style=""color:{0}"">{1}</b>", System.Drawing.ColorTranslator.ToHtml(_sourceBitmap.GetPixel(x, y)), _htmlArtText.Substring(textPosition, 1))
                        textPosition += 1

                        If textPosition = _htmlArtText.Length Then
                            textPosition = 0
                        End If

                    Next
                    _sb.Append("<br />")
                Next

                _sb.Append("</div>")

                If _includePageTags = True Then
                    _sb.Append("</body></html>")
                End If

                Return _sb.ToString
            End Get
        End Property

        Private _backgroundColor As System.Drawing.Color = Color.Black
        ''' <summary>
        ''' The background color for the HTML page if the IncludePageTags is set to true.
        ''' </summary>
        ''' <value>Default is Color.Black</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BackgroundColor() As System.Drawing.Color
            Get
                Return _backgroundColor
            End Get
            Set(ByVal value As System.Drawing.Color)
                _backgroundColor = value
            End Set
        End Property

        Private _autoResize As Boolean = True
        ''' <summary>
        ''' Whether or not to resize original photo into a more manageable size before rendering the text.  This is true by default.
        ''' If this property is toggled to false, you will be responsible for setting the image size yourself or leaving it how it is
        ''' (which can produce very large outputs).
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoResize() As Boolean
            Get
                Return _autoResize
            End Get
            Set(ByVal value As Boolean)
                _autoResize = value
            End Set
        End Property

        Private _maxHeight As Integer = 160
        ''' <summary>
        ''' The maximum height that the resized image will be.  Each of these will represent one character in the output provided.  The 
        ''' default value is 160.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MaxHeight() As Integer
            Get
                Return _maxHeight
            End Get
            Set(ByVal value As Integer)
                _maxHeight = value
            End Set
        End Property

        Private _maxWidth As Integer = 160
        ''' <summary>
        ''' The maximum width that the resized image will be.  Each of these will represent one character in the output provided.  The default 
        ''' value is 160.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MaxWidth() As Integer
            Get
                Return _maxWidth
            End Get
            Set(ByVal value As Integer)
                _maxWidth = value
            End Set
        End Property

        Private _includePageTags As Boolean = True
        ''' <summary>
        ''' Whether or not the HtmlArt property should return page tags with it.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IncludePageTags() As Boolean
            Get
                Return _includePageTags
            End Get
            Set(ByVal value As Boolean)
                _includePageTags = value
            End Set
        End Property

        Private disposedValue As Boolean = False        ' To detect redundant calls

        ''' <summary>
        ''' Cleanup objects in memory.
        ''' </summary>
        ''' <param name="disposing"></param>
        ''' <remarks></remarks>
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: free other state (managed objects).
                    If _sourceBitmap IsNot Nothing Then
                        _sourceBitmap.Dispose() : _sourceBitmap = Nothing
                    End If
                End If

                ' TODO: free your own state (unmanaged objects).
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

#Region " IDisposable Support "
        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace