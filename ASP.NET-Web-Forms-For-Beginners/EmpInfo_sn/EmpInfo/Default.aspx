<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmpInfo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Information</h2>
            <p>
                &nbsp;</p>
            <p>
                Name:
                <asp:TextBox ID="tBoxName" runat="server"></asp:TextBox>
            </p>
            <p>
                Select Office:
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem> Pick City</asp:ListItem>
                    <asp:ListItem>Toronto</asp:ListItem>
                    <asp:ListItem>New York</asp:ListItem>
                    <asp:ListItem>London</asp:ListItem>
                </asp:DropDownList>
&nbsp;<asp:Label ID="lblResult" runat="server"></asp:Label>
            </p>
            <p>
                Department</p>
            <p>
                <asp:RadioButton ID="rdoBtnMarket" runat="server" GroupName="Department" Text="Marketing" />
            </p>
            <p>
                <asp:RadioButton ID="rdoBtnAccount" runat="server" GroupName="Department" Text="Accounting" />
            </p>
            <p>
                <asp:RadioButton ID="rdoBtnLegal" runat="server" GroupName="Department" Text="Legal" />
            </p>
            <p>
                Qualifications</p>
            <p>
                <asp:CheckBox ID="chkBoxBA" runat="server" Text="BA" />
            </p>
            <p>
                <asp:CheckBox ID="chkBoxMA" runat="server" Text="MA" />
            </p>
            <p>
                <asp:CheckBox ID="chkBoxPHD" runat="server" Text="PHD" />
            </p>
            <p>
                <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="Go" />
            </p>
            <p>
                <asp:Label ID="lblFullName" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
