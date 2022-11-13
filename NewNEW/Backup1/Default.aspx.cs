using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace TuVanChonNganh
{
    public partial class _Default : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection("Data Source=AI;Initial Catalog=TuyenSinh;User ID=sa;Password=sasa123");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THONGTIN WHERE MAHS='" + TextBox1.Text + "' AND MATKHAU ='" + TextBox2.Text + "'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {

                // = string.Empty;
                Session["TenDangNhap"] = TextBox1.Text;
                Session["HOTEN"] = dt.Rows[0]["HOTEN"];
                Session["GIOITINH"] = dt.Rows[0]["GIOITINH"];
                Response.Redirect("TraCuuTuVan.aspx");
            }
            else
            {
                Label1.Text = "Tên đăng nhập hoặc mật khẩu chưa chính xác!!!!!";
            }
        
        
        }
    }
}
