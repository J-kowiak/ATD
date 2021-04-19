<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 501px">
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" width="113px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="113px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="113px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth" width="113px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="tblAddress" runat="server" Text="Address" width="113px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkArchived" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Archived" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
