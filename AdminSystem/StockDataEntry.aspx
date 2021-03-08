<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductId" runat="server" Text="Product ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
&nbsp;<asp:Label ID="lblCategory" runat="server" Text="Category" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCategory" runat="server" OnTextChanged="txtCategory_TextChanged">213</asp:TextBox>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblNextDelivery" runat="server" Text="Next Delivery" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtNextDelivery" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="cbSaleReady" runat="server" Text="Sale Ready" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p style="margin-left: 40px">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
