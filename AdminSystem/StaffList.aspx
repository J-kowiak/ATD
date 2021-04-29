<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 432px; width: 454px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 458px; position: absolute; width: 60px" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 76px; top: 458px; position: absolute; width: 60px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 142px; top: 458px; position: absolute; width: 60px" Text="Delete" />
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 499px; position: absolute; width: 91px;" Text="Enter a name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 106px; top: 499px; position: absolute; width: 145px"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 10px; top: 540px; position: absolute; width: 60px" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 76px; top: 540px; position: absolute; width: 60px" Text="Clear" OnClick="btnClear_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 590px; position: absolute"></asp:Label>
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" style="z-index: 1; left: 10px; top: 636px; position: absolute; width: 60px" Text="Logout" />
        </div>      
    </form>
</body>
</html>
