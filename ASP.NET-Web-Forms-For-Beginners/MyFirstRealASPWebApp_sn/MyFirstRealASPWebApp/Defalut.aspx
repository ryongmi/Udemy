<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defalut.aspx.cs" Inherits="MyFirstRealASPWebApp.Defalut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to my first real ASP.NET web application</h1>
            <br />
            Enter First Name:
            <asp:TextBox ID="tBoxFirst" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Last Name:
            <asp:TextBox ID="tBoxLast" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
            <br />
            <br />  <%--br : 엔터(공백)--%>
            <hr />  <%--hr : 가로로 줄이 생김( 화면 구분할 수 있는 줄 )--%>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
