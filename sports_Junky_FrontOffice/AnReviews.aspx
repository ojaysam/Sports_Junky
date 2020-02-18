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
            <input id="rvwNameOK" type="text" /><br />
            <br />
            Review Text&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id="rvwTextOK" type="text" /><br />
            <br />
            Reviewed Product&nbsp; <input id="rvwdProdOK" type="text" /><br />
            <br />
            Review Rating&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <input id="rvwRatOK" type="text" /><br />
            <br />
            Date Added&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <input id="dateAddOK" type="text" /><br />
            <br />
            Review Approved&nbsp;
            <input id="rvwAppOK" /> <br />
            <br />
            <input id="activeOK" type="checkbox" />Active<br />
            <br />
            <input id="cnclOK" type="button" value="Cancel" /><input id="btnSubmit" type="button" value="submit" onclick ="btnSubmit_OK"/></div>
    </form>
</body>
</html>
