<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="OrderId" runat="server" height="16px" Text="Order ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="ItemName" runat="server" height="16px" Text="Item Name" width="58px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server" height="16px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Price" runat="server" height="16px" Text="Price" width="58px"></asp:Label>
&nbsp;<asp:TextBox ID="txtPrice" runat="server" height="16px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="DateOrderMade" runat="server" Text="Date Order Made" width="58px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateOrderMade" runat="server" height="16px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkItemShipped" runat="server" OnCheckedChanged="ItemShipped_CheckedChanged" Text="Item Shipped?" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="btnFind" runat="server" Text="Find" />
    </form>
</body>
</html>
