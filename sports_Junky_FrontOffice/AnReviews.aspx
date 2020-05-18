<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnReviews.aspx.cs" Inherits="AnReviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            width: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Reviewer Name&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="rvwNameOK" runat="server"></asp:TextBox>
            <br />
            <br />
            Review Text&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="rvwTextOK" runat="server"></asp:TextBox>
            <br />
            <br />
            Reviewed Product&nbsp; 
            <asp:TextBox ID="rvwdProdOK" runat="server" OnTextChanged="rvwdProdOK_TextChanged"></asp:TextBox>
            <br />
            <br />
            Review Rating&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="rvwRatOK" runat="server"></asp:TextBox>
            <br />
            <br />
            Date Added&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
            <asp:TextBox ID="dateAddOK" runat="server"></asp:TextBox>
            <br />
            <br />
            Review Approved&nbsp;&nbsp;
            <asp:TextBox ID="rvwAppOK" runat="server"></asp:TextBox>
            <br />
            <br />
            ReviewsId
            <asp:TextBox ID="rvwsId" runat="server"></asp:TextBox>
            <br />
            <br />
            <input id="activeOK" type="checkbox" />Active<br />
            <input id="btnSubmit" type="submit" value="Submit" /><input id="cnclOK" type="reset" value="Cancel" /><br />
            </div>
        <p id="lblError">
            [lblError]</p>
        <p>
            <asp:TextBox ID="fndField" runat="server"></asp:TextBox>
            <input id="btnFind" type="submit" value="Find" /></p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
