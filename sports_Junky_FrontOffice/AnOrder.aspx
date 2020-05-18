<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 416px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">   
        Order ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox> <asp:Button Text="Search" ID="btnSearch" OnClick="btnSearch_Click" runat="server" />
            <br />
        <br />
        OrderNumber 
            <asp:TextBox ID="txtOrderNumber" runat="server"></asp:TextBox>
            <br />
        <br />
        OrderName&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtOrderName" runat="server"></asp:TextBox>
            <br />
        <br />
        OrderDate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
            <br />
        <br />
        OrderQuantity 
            <asp:TextBox ID="txtOrderQuantity" runat="server"></asp:TextBox>
            <br />
        <br />
        OrderTotal&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtOrderTotal" runat="server"></asp:TextBox>
        <br />
      
        <asp:Button Text="Ok" ID="btnOK" OnClick="btnOK_Click" runat="server" /> <asp:Button Text="Cancel" ID="btnCancel" OnClick="btnCancel_Click" runat="server" /><br />
        <br />
        <asp:Label Text="" ID="lblError" ForeColor="Red" runat="server" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>