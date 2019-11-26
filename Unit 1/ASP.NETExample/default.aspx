<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ASP.NETExample._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            some stuff
            <br />
            more stuff<br />
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First name: "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btn2" runat="server" Text="Button" />

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="www.google.com">HyperLink</asp:HyperLink>

        </div>
    </form>
</body>
</html>
