<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MultiPage.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
            height: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to my web application<br />
            <br />
            <img alt="image" class="auto-style1" src="images/ori_logo_black.png" /><asp:Label ID="lblWelcome" runat="server"></asp:Label>
            <br />
            <br />
            Clicke here to go to <a href="Page2.aspx">page 2</a></div>
    </form>
</body>
</html>
