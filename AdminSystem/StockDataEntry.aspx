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
&nbsp;<p>
            <asp:Label ID="lblName" runat="server" Text="Name" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server" width="168px"></asp:TextBox>
        </p>
&nbsp;<asp:Label ID="lblCategory" runat="server" Text="Category" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCategory" runat="server" OnTextChanged="txtCategory_TextChanged" width="168px"></asp:TextBox>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantity" runat="server" width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblNextDelivery" runat="server" Text="Next Delivery" width="86px"></asp:Label>
&nbsp;<asp:TextBox ID="txtNextDelivery" runat="server" width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="cbSaleReady" runat="server" Text="Sale Ready" OnCheckedChanged="cbSaleReady_CheckedChanged" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p style="margin-left: 40px">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Add" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" Text="Cancel" />
        </p>
        <p style="margin-left: 40px">
        <asp:Label ID="lblProductId" runat="server" Text="Product ID" style="text-align: left; float: left"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server" OnTextChanged="txtProductId_TextChanged"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
