Module Globals

    ' It's like a fake constant after initialization.  ;P
    Public ReadOnly ApplicationData As String = String.Format("{0}\Image2Text\", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).TrimEnd("\"))

    ''' <summary>
    ''' Starts a Url using the System.Diagnostics.Process class, this will work for Internet Url's as well as local files and directories.
    ''' </summary>
    ''' <param name="Url"></param>
    ''' <remarks></remarks>
    Public Sub StartUrl(ByVal Url As String)
        Try
            Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()
            proc.StartInfo.FileName = Url
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            proc.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
