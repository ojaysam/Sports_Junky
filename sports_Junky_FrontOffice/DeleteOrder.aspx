<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Are you sure you want to delete this record ?" runat="server" />
            <asp:Button Text="Yes" ID="btnYes" OnClick="btnYes_Click" runat="server" />
            <asp:Button Text="No" ID="btnNo" OnClick="btnNo_Click" runat="server" />
        </div>
    </form>
</body>
</html>
