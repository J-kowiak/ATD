<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 122px; top: 15px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute" Text="Staff Username"></asp:Label>
            <asp:TextBox ID="txtStaffUsername" runat="server" style="z-index: 1; left: 122px; top: 42px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 10px; top: 69px; position: absolute" Text="Staff Password"></asp:Label>
            <asp:TextBox ID="txtStaffPassword" runat="server" style="z-index: 1; left: 122px; top: 69px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 10px; top: 96px; position: absolute" Text="Staff Name"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 122px; top: 96px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 10px; top: 123px; position: absolute" Text="Staff Address"></asp:Label>
            <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 122px; top: 123px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDateOfCreation" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Date of Creation"></asp:Label>
            <asp:TextBox ID="txtDateOfCreation" runat="server" style="z-index: 1; left: 122px; top: 150px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffAge" runat="server" style="z-index: 1; left: 10px; top: 177px; position: absolute" Text="Staff Age"></asp:Label>
            <asp:TextBox ID="txtStaffAge" runat="server" style="z-index: 1; left: 122px; top: 177px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkAdmin" runat="server" style="z-index: 1; left: 10px; top: 204px; position: absolute" Text="Admin" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 251px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 277px; position: absolute; width: 60px" Text="Ok" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 76px; top: 277px; position: absolute; width: 60px" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 142px; top: 277px; position: absolute; width: 60px" Text="Find" OnClick="btnFind_Click" />
        </div>
        
    </form>
</body>
</html>
