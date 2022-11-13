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
    <form id="form1" runat="server" method="post">
     
    <asp:Label ID="Label1" runat="server" BackColor="White" ForeColor="#68F40B" 
        Text="DỰ BÁO TƯ VẤN NGHỀ NGHIỆP" Font-Bold="True"></asp:Label>
     <div >  
            <table style="width:45%;"> 
            <caption class="style1">  
                    <strong>Thông tin học sinh</strong>  
            </caption>
                  <%-- <tr>  
                        <td class="style4"> Mã học sinh:</td>  
                        <td class="style3">  
                            <asp:TextBox ID="txtMaHocSinh" ReadOnly=true runat="server" Width="431px"></asp:TextBox>  
                        </td>  
                   </tr>--%>
                   <tr>  
                        <td class="style4"> Họ tên học sinh: </td>  
                        <td class="style3">  
                            <asp:TextBox ID="txtHoTen" runat="server" Width="431px"></asp:TextBox>  
                        </td>  
                   </tr> 
                   <tr>  
                        <td class="style4"> Giới tính:</td>  
                        <td class="style3">  
                            <asp:RadioButtonList runat="server">
                                <asp:ListItem Text="Nam" Value="True" Selected="True"/>
                                <asp:ListItem Text="Nữ" Value="False" />
                            </asp:RadioButtonList> 
                        </td>  
                   </tr>  
            </table>
            
            <table style="width:45%;"> 
            <caption class="style1">  
                    <strong>Thông tin tư vấn</strong>  
            </caption>
              <tr id="main-selector">
                  <td>
                      <input type="hidden" name="amountHobby" value="0"/>
                  </td>
              </tr>
              <tr>
                  <td>
                      <button type="button" id="button-add-hobby">Thêm nhóm sở thích</button>
                  </td>
              </tr>
              <tr>
               <td class="style9">Điểm trung bình HK I lớp 12:</td>  
                <td class="style8">  
                    <asp:TextBox ID="txtDiemTHPT" runat="server" Width="186px" Height="16px"></asp:TextBox>
                    <br />
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
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>  
               </td> 
              </tr>
              <%--<tr>
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
              </tr> --%>  
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
                        <button id="buttonSubmit">Tư Vấn</button>  
                    </td>  
                    <td>  
                        <asp:Label ID="Label2" runat="server"></asp:Label>  
                    </td>  
                </tr>  
                   
            </table>
          
     </div>
    </form>
    <div>
        <b style="color: red">Result</b>
        <% if(listDepartmentResult != null) {%>
            <% foreach (TuVanChonNganh.Model.Department department in listDepartmentResult)
                { %>
                <span style="margin:5px; font-weight: bold"><%= department.Name %></span>
            <% } %>
        <% } %>
    </div>
    <div>
        <b style="color: red">Debug</b>
        <% if (hash != null && listReportHobby != null)
            {
                int j = 0;%>
                <div style="display: flex">
                    <div style="width: 100px; margin: 5px">Tên nhóm sở thích</div>
                    <div style="width: 100px; margin: 5px"">Hạnh phúc</div>
                    <div style="width: 100px; margin: 5px"">Không hạnh phúc</div>
                    <div style="width: 100px; margin: 5px"">Khả năng hạnh phúc</div>
                </div>
                <% foreach (string idGroup in hash.Keys)
                    { %>
                    <div style="display: flex">
                        <div style="width: 100px; margin: 5px""><%= new TuVanChonNganh.RemoteRepository.GroupHobbyService(TuVanChonNganh.RemoteRepository.DBProvider.GetInstance()).GetGroupHobby(idGroup).Content %></div>
                        <div style="width: 100px; margin: 5px""><%= listReportHobby[j].HappyAmount %></div>
                        <div style="width: 100px; margin: 5px""><%= listReportHobby[j].UnhappyAmount %></div>
                        <div style="width: 100px; margin: 5px""><%= listReportHobby[j].CalcPercentHappy().ToString("0.##") %> %</div>
                    </div>
                 <%  j++; 
                   } %>
        <% } %>
    </div>
</body>
    <script type="text/javascript">
        const listHobbyGroup = [
                <% foreach (TuVanChonNganh.Model.GroupHobby item in listGroupHobby) { %>
                    {
                        id: "<%=item.Id%>",
                        content: "<%=item.Content%>"          
                    },
                <% } %>
        ];
        const listPropertyHobby = [
                <% foreach (TuVanChonNganh.Model.PropertyHobby item in listPropertyHobby) { %>
                    {
                        id: "<%=item.Id%>",
                        groupId: "<%=item.GroupHobbyId%>",
                        content: "<%=item.Property%>"
                    },
                <% } %>
        ];
        console.log(listHobbyGroup, listPropertyHobby);
        const trElement = document.querySelector("#main-selector");
        const amountHobbyElement = document.querySelector("input[name='amountHobby']");

        function getListPropertyHobbyFromGroup(groupId) {
            return listPropertyHobby.filter(item => item.groupId === groupId);
        }

        let amount = 0;
        function createElementSelector() {
            amountHobbyElement.value = parseInt(amountHobbyElement.value) + 1;
            const currentAmount = amount++;
            const container = document.createElement("tr");
            container.innerHTML = `
                <td class="style9" > Nhóm sở thích: </td>
                <td class="style8"> 
                    <select style="width: 180px" name="cbGroupHobby${currentAmount}">
                        ${listHobbyGroup.map(item => `<option value="${item.id}">${item.content}</option > `)}
                    </select>
                </td>
                <td class="style9">  Đặc điểm, Sở thích:</td>  
                <td class="style8">
                    <select style="width: 180px" name="cbPropertyHobby${currentAmount}">
                        ${getListPropertyHobbyFromGroup(listHobbyGroup[0].id).map(item => `<option value="${item.id}">${item.content}</option > `)}
                    </select>
                </td>
            `;
            const propertySelectElement = container.querySelector(`select[name='cbPropertyHobby${currentAmount}']`);
            container.querySelector(`select[name='cbGroupHobby${currentAmount}']`).addEventListener("change", (e) => {
                propertySelectElement.innerHTML = `
                    ${getListPropertyHobbyFromGroup(e.target.value).map(item => `<option value="${item.id}">${item.content}</option > `)}
                `;
            });

            return container;
        }

        trElement.insertAdjacentElement("beforebegin", createElementSelector());
        const buttonAddHobbyElement = document.querySelector("#button-add-hobby");
        buttonAddHobbyElement.addEventListener("click", (e) => {
            trElement.insertAdjacentElement("beforebegin", createElementSelector());
        })
    </script>
</html>
