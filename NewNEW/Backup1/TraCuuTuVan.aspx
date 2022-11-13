<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TraCuuTuVan.aspx.cs" Inherits="TuVanChonNganh.TraCuuTuVan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 242px;
        }
    </style>
    <style type="text/css">
        .style1
        {
            width: 792px;
        }
        .style3
        {
            width: 129px;
        }
        .style4
        {
            width: 188px;
        }
        .style8
        {
            width: 431px;
        }
        .style9
        {
            width: 1300px;
        }
        .style11
        {
            width: 189px;
        }
        .style12
        {
            width: 432px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     
    <asp:Label ID="Label1" runat="server" BackColor="White" ForeColor="#68F40B" 
        Text="DỰ BÁO TƯ VẤN NGHỀ NGHIỆP" Font-Bold="True"></asp:Label>
     <div >  
            <table style="width:45%;"> 
            <caption class="style1">  
                    <strong>Thông tin học sinh</strong>  
            </caption>
                   <tr>  
                        <td class="style4"> Mã học sinh:</td>  
                        <td class="style3">  
                            <asp:TextBox ID="txtMaHocSinh" ReadOnly=true runat="server" Width="431px"></asp:TextBox>  
                        </td>  
                   </tr>
                   <tr>  
                        <td class="style4"> Họ tên học sinh:</td>  
                        <td class="style3">  
                            <asp:TextBox ID="txtHoTen" ReadOnly=true runat="server" Width="431px"></asp:TextBox>  
                        </td>  
                   </tr> 
                   <tr>  
                        <td class="style4"> Giới tính:</td>  
                        <td class="style3">  
                            <asp:TextBox ID="txtGioiTinh" ReadOnly=true runat="server" Width="431px"></asp:TextBox>  
                        </td>  
                   </tr>  
            </table>
            
            <table style="width:45%;"> 
            <caption class="style1">  
                    <strong>Thông tin tư vấn</strong>  
            </caption>
             
             <tr>  
                    <td class="style9">  Nhóm sở thích:</td>  
                    <td class="style8">  
                        <asp:DropDownList ID="cboNhomSoThich" runat="server" Width="189px" 
                            Height="16px">
                            <asp:ListItem Value="Kỹ thuật"></asp:ListItem>
                            <asp:ListItem Value="Nghệ thuật"></asp:ListItem>
                            <asp:ListItem Value="Nghiên cứu"></asp:ListItem>
                            <asp:ListItem Value="Nghiệp vụ"></asp:ListItem>
                            <asp:ListItem Value="Quản lý"></asp:ListItem>
                            <asp:ListItem Value="Xã hội"></asp:ListItem>
                        </asp:DropDownList>  
                    </td>
                    <td class="style9">  Đặc điểm, Sở thích:</td>  
                    <td class="style8">  
                        <asp:DropDownList ID="cboDacDiemSoThich" runat="server" Width="189px" 
                            Height="16px">
                           
                        </asp:DropDownList>  
                    </td>
                     
              </tr>
              <tr>
               <td class="style9">Điểm trung bình HK I lớp 12:</td>  
                    <td class="style8">  
                        <asp:TextBox ID="txtDiemTHPT" runat="server" Width="186px" Height="16px"></asp:TextBox>  
               </td>
               <td class="style12">  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"   
ControlToValidate="txtDiemTHPT" ErrorMessage="Vui lòng nhập điểm"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td>  
               <td class="style11">Điểm trung bình tổ hợp:</td>  
                    <td class="style3">  
                        <asp:TextBox ID="txtToHop" runat="server" Width="123px"></asp:TextBox>  
               </td>
               <td>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"   
ControlToValidate="txtToHop" ErrorMessage="Vui lòng nhập điểm"   
ForeColor="Red"></asp:RequiredFieldValidator>  
                    </td> 
              </tr>
              
              <tr>
               <td class="style9">Ngành đăng ký xét tuyển:</td>  
                    <td class="style8">  
                        <asp:DropDownList ID="cboNganh" runat="server" Width="182px" Height="16px" 
                            DataTextField="TENNGANH" DataValueField="MANGANH" 
                            onselectedindexchanged="cboNganh_SelectedIndexChanged1" 
                            ontextchanged="cboNganh_SelectedIndexChanged"></asp:DropDownList>  
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:TuyenSinhConnectionString %>" 
                            SelectCommand="SELECT [MANGANH], [TENNGANH] FROM [THONGTIN]">
                        </asp:SqlDataSource>
               </td>
                <td class="style12">  Trường đăng ký xét tuyển:</td>  
                    <td class="style11">  
                        <asp:DropDownList ID="cboTruongDangKy" runat="server" Width="189px" 
                            Height="16px" style="height: 22px"></asp:DropDownList>  
                    </td> 
              </tr>   
            </table>
            
            <table style="width:45%;"> 
            <caption class="style1">  
                    <strong>KẾT QUẢ TƯ VẤN</strong>  
            </caption>
                   <tr>  
                        <td class="style4"> Kết quả:</td>  
                        <td class="style3">  
                            <asp:TextBox ID="TextBox1" ReadOnly=true runat="server" Width="431px"></asp:TextBox>  
                        </td>  
                   </tr>
                   <tr>  
                    <td class="style2">  
 </td>  
                    <td class="style3">  
                        <asp:Button ID="Button1" runat="server" Text="Tư vấn" onclick="Button1_Click" />  
                    </td>  
                    <td>  
                        <asp:Label ID="Label2" runat="server"></asp:Label>  
                    </td>  
                </tr>  
                   
            </table>
            
          
     </div>
    </form>
</body>
</html>
