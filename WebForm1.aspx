<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="SelemiumTestWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id ="errDiv1" style="color:red">
            <asp:Label ID ="lblErr1" runat="server"></asp:Label>
        </div>
        <asp:Label ID="Label1" runat="server" Text="入力値１："></asp:Label>
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <br />

        <div id ="errDiv2" style="color:red">
            <asp:Label ID ="lblErr2" runat="server"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="入力値２："></asp:Label>
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <br />

        <div id ="errDiv3" style="color:red">
            <asp:Label ID ="lblErr3" runat="server"></asp:Label>
        </div>
        <asp:Label ID="Label3" runat="server" Text="入力値３："></asp:Label>
        <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
        <br />

        <asp:Button ID="btn1" runat="server" Text="実行" />
        <div id="okDiv" style="color:blue">
            <asp:Label ID="lblOk" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
