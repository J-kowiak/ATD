﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 10px; top: 47px; position: absolute; width: 60px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 76px; top: 47px; position: absolute; width: 60px" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
