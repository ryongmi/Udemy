<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Methods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Length"></asp:Label>
            :&nbsp;
            <asp:TextBox ID="tBox_Length" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="width"></asp:Label>
            :
            <asp:TextBox ID="tBox_width" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Area" runat="server" OnClick="btn_Area_Click" Text="Area" />
            <br />
            <br />
            <asp:Label ID="lbl_Result" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
