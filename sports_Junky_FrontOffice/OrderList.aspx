<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrders" runat="server" Height="425px" Width="693px"></asp:ListBox> <br />
            <asp:Button Text="Add" OnClick="btnAdd_Click" ID="btnAdd" runat="server" />
            <asp:Button Text="Edit" ID="btnEdit" OnClick="btnEdit_Click" runat="server" />
            <asp:Button Text="Delete" id="btnDelete" OnClick="btnDelete_Click" runat="server" />
            <br />

            <br />
            <br />
            <asp:Label Text="Enter Order Name:" runat="server" /> <asp:TextBox ID="txtSearchByName" runat="server" />
            <br />
            <asp:Button Text="Apply" ID="btnApply" OnClick="btnApply_Click" runat="server" />
            <asp:Button Text="Clear" ID="btnClear" OnClick="btnClear_Click" runat="server" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
