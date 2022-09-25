<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaStore.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            The Chiarelli Pizzeria<br />
            <br />
            <asp:RadioButton ID="rdoBtnBaby" runat="server" GroupName="Menu" Text="Baby $10" />
            <br />
            <asp:RadioButton ID="rdoBtnMama" runat="server" GroupName="Menu" Text="Mama $13" />
            <br />
            <asp:RadioButton ID="rdoBtnPapa" runat="server" GroupName="Menu" Text="Papa $16" />
            <br />
            <br />
            <asp:RadioButton ID="rdoBtnCrust" runat="server" GroupName="Dou" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="rdoBtnDish" runat="server" GroupName="Dou" Text="Deep Dish (+$2.00)" />
            <br />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="1.50">Pepperoni $1.50</asp:ListItem>
                <asp:ListItem Value="0.75">Onions $.75</asp:ListItem>
                <asp:ListItem Value="0.50">Green Peppers $.50</asp:ListItem>
                <asp:ListItem Value="0.75">Red Peppers $.75</asp:ListItem>
                <asp:ListItem Value="2.00">Anchovies $2.00</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            Special Deal: Save $2.00 when you add pepperoni, green peppers and anchovies OR pepperoni, red peppers and onions to your pizza<br />
            <br />
            <asp:Button ID="btnPurchase" runat="server" OnClick="btnPurchase_Click" Text="Purchase" />
            <br />
            <br />
            Total : <asp:Label ID="lblTotal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
