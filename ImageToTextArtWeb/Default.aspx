<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Text Art Web</title>

    <style type="text/css" media="screen">
        body {
       	    margin: 1;
	        font-family: "Trebuchet MS", Verdana, Arial, sans-serif;
	        font-size: 16px;
	        color: black;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Image to Text Art (HTML Art, Unicode Art, Ascii Art)</h1>
        <table border="0">
            <tr>
                <td>1.) Export Type:</td>
                <td>
                    <asp:DropDownList ID="ddExportType" runat="server" AutoPostBack="true">
                        <asp:ListItem Value="HTML">HTML Art</asp:ListItem>
                        <asp:ListItem Value="UNICODE">Unicode Art</asp:ListItem>
                        <asp:ListItem value="ASCII">Ascii Art</asp:ListItem>            
                    </asp:DropDownList>                
                </td>
            </tr>
            <tr>
                <td>2.) Image File:</td>
                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Literal id="litHtmlArtText" Text="3.) Text to Use on HTML Art:" Visible="true" runat="server"></asp:Literal>
                </td>
                <td>
                    <asp:TextBox ID="txtHtmlArtText" runat="server" Visible="true"></asp:TextBox>                
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right;">
                    <asp:Button ID="btnGenerateTextArt" runat="server" Text="Create Text Art" />                
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right;">
                    <asp:Literal ID="litInfo" runat="server"></asp:Literal>
                </td>            
            </tr>
        </table>

        <br />       
        <b>Note:</b>  Your image is not saved to hard disk.  It is used in memory and then disposed of.

    </div>
    </form>
</body>
</html>
