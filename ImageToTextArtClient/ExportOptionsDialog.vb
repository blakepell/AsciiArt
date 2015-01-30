Imports System.Windows.Forms

Public Class ExportOptionsDialog

    ''' <summary>
    ''' Closes the form with a success.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If txtHTMLArtText.Text.Replace(" ", "") = "" Then
            MessageBox.Show("You must enter text to display in the HTML Art.", "Form not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    ''' <summary>
    ''' Cancels the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' Sets the backcolor on the labels.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lblBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackColor.Click
        ColorDialog1.SolidColorOnly = False

        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        lblBackColor.BackColor = ColorDialog1.Color
        lblForeColor.BackColor = ColorDialog1.Color

    End Sub

    ''' <summary>
    ''' Sets the forecolor on the labels.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lblForeColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblForeColor.Click
        ColorDialog1.SolidColorOnly = False

        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        lblBackColor.ForeColor = ColorDialog1.Color
        lblForeColor.ForeColor = ColorDialog1.Color

    End Sub

End Class
