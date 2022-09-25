<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleFormatting.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "맑은 고딕";
        }
        .auto-style2 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Text Formatting plus other stuff<br />
            <br />
            In this line of text I will demonstrate on to change the <span class="auto-style1">font</span> and <span class="auto-style2">color</span><br />
            <br />
            Click here to go to <a href="http://cnn.com">CNN</a><br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="162px" ImageUrl="~/images/ori_logo_black.png" />
        </div>
    </form>
</body>
</html>
