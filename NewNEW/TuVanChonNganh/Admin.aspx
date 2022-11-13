<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="TuVanChonNganh.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="admin" runat="server">
        <asp:Button id="convertDB" runat="server"
            Text="Chuyển DB Tuyển Sinh Sang Tư Vấn Tuyển Sinh"
            OnClick="Button_ConvertDB"
          />
    </form>
</body>
</html>
