<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TuVanChonNganh._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
  <title>TƯ VẤN CHỌN NGÀNH</title>
     
    <style type="text/css">
        .style1
        {
            width: 413px;
        }
        .style2
        {
            width: 97px;
        }
        .style3
        {
            width: 129px;
        }
    </style>
     
</head>
 <body>  
    <form id="form1" runat="server">  
        <div >  
            <table style="width:45%;">  
                <caption class="style1">  
                    <strong>Thông tin đăng nhập</strong>  
                </caption>  
                <tr>  
                    <td class="style2">  
 </td>  
                    <td class="style3">  
 </td>  
                    <td>  
 </td>  
                </tr>  
                <tr>  
                    <td class="style2">  
Tên đăng nhập:</td>  
                    <td class="style3">  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"   
ControlToValidate="TextBox1" ErrorMessage="Vui lòng nhập tên đăng nhập"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="style2">  
Mật khẩu:</td>  
                    <td class="style3">  
                        <asp:TextBox ID="TextBox2" TextMode="password" runat="server">123456</asp:TextBox>  
                    </td>  
                    <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"   
ControlToValidate="TextBox2" ErrorMessage="Vui lòng nhập mật khẩu"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="style2">  
 </td>  
                    <td class="style3">  
 </td>  
                    <td>  
 </td>  
                </tr>  
                <tr>  
                    <td class="style2">  
 </td>  
                    <td class="style3">  
                        <asp:Button ID="Button1" runat="server" Text="Đăng nhập" onclick="Button1_Click" />  
                    </td>  
                    <td>  
                        <asp:Label ID="Label1" runat="server"></asp:Label>  
                    </td>  
                </tr>  
            </table>  
        </div>  
    </form>  
</body> 

</html>
