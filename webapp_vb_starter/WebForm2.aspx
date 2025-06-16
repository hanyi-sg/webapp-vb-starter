<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="webapp_vb_starter.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Add New" />
            <asp:GridView ID="GridView1" runat="server" Width="100%">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="WebForm1.aspx?Edit={0}" DataTextField="ID" DataTextFormatString="Edit"></asp:HyperLinkField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
