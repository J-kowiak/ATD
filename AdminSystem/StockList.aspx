<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStock" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="314px" Width="369px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
