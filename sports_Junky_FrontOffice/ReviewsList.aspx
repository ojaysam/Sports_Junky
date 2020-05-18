<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsList.aspx.cs" Inherits="ReviewsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstReviewsList" runat="server" Height="308px" Width="326px" OnSelectedIndexChanged="lstReviewsList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <input id="btnAdd" type="button" value="Add" /><input id="btnEdit" type="button" value="Edit" /><input id="btnDelete" type="button" value="Delete" /></p>
        <p>
            <asp:Label ID="lblReviewRating" runat="server" Text="Enter Review Rating"></asp:Label>
            <input id="inputReviewRating" type="text" /></p>
        <p>
        <input id="btnApply" type="button" value="Apply" /><input id="Button1" type="button" value="Clear" /></p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
