<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteReviews.aspx.cs" Inherits="DeleteReviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
    </form>
    <p id="btnNo">
        <input id="btnYes" type="button" value="Yes" /><input id="btnNo" type="button" value="No" /></p>
</body>
</html>
