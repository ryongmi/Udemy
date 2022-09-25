<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vallidators.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="tBox_Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tBox_Name" ErrorMessage="Missing Name"></asp:RequiredFieldValidator>
            <%-- RequiredFieldValidator: ControlToValidate 컨트롤 값이 null이면 ErrorMessage 표시하는 유효성 검사 컨트롤, ControlToValidate: 유효성 검사를 할 컨트롤명, ErrorMessage: 검사결과 유효하지 않다면 화면에 표시될 메시지 --%>
            <br />
            <br />
            Password:<asp:TextBox ID="tBox_PW" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tBox_PW" ErrorMessage="Missing Password"></asp:RequiredFieldValidator>
            <br />
            <br />
            Re-Type Password:<asp:TextBox ID="tBox_PWRe" runat="server" TextMode="Password"></asp:TextBox>
            <%-- TextMode: 텍스트가 어떻게 표시될건지 선택하는 모드, 지금은 입력값이 안보이는 모드 --%>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tBox_PWRe" ErrorMessage="Check Password"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tBox_PW" ControlToValidate="tBox_PWRe" ErrorMessage="Passwords don't match"></asp:CompareValidator>
            <%-- CompareValidator: 두 컨트롤(ControlToCompare, ControlToValidate) 값을 비교하는 컨트롤, 두 컨트롤 값이 일치하지 않으면 ErrorMessage 표시 --%>
            <br />
            <br />
            Email:<asp:TextBox ID="tBox_Email" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tBox_Email" ErrorMessage="Improper email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <%-- RegularExpressionValidator: 해당 컨트롤(ControlToValidate)의 형식이 설정한 형식(정규식)과 맞는지 유효성 검사 컨트롤, ValidationExpression: 검사할 형식 설정( 지금은 인터넷 이메일 ), 결국은 정규식을 넣어야함 --%>
            <br />
            <br />
            Age:<asp:TextBox ID="tBox_Age" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tBox_Age" ErrorMessage="ages between 0 to 100" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <%-- RangeValidator: 해당 컨트롤(ControlToValidate)의 값이 지정한 범위에(MinimumValue ~ MaximumValue) 있는지 유효성 검사 컨트롤, MaximumValue: 최대값, MinimumValue: 최솟값, Type: 입력할 타입(지금은 정수형)--%>
            <br />
            <br />
            <asp:Button ID="btn_Submit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
