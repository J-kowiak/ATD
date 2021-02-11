<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 114px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtStaffUsername" runat="server" style="z-index: 1; left: 121px; top: 15px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStaffPassword" runat="server" style="z-index: 1; left: 121px; top: 42px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffUsername" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Staff Username"></asp:Label>
            <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute" Text="Staff Password"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute; width: 57px; right: 1205px" Text="Login" OnClick="btnLogin_Click" />
        </div>     
    </form>
</body>
</html>
