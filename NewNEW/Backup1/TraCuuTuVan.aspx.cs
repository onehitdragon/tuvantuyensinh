using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace TuVanChonNganh
{
    public partial class TraCuuTuVan : System.Web.UI.Page
    {
        OleDbConnection cnn = new OleDbConnection("Provider=MSOLAP.8;Data Source=AI;Integrated Security=SSPI;Initial Catalog=NewTuyenSinh");
        SqlConnection cnnsql = new SqlConnection("Data Source=AI;Initial Catalog=TuyenSinh;User ID=sa;Password=sasa123");
        protected void Page_Load(object sender, EventArgs e)
        {
             //Session["TenDangNhap"] = TextBox1.Text;
             //   Session["HOTEN"] = dt.Rows[0]["HOTEN"];
             //   Session["GIOITINH"] = dt.Rows[0]["GIOITINH"];
            // gAN THONG TIN HOC SINH
            txtMaHocSinh.Text = Session["TenDangNhap"].ToString();
            txtHoTen.Text = Session["HOTEN"].ToString();
            txtGioiTinh.Text = Session["GIOITINH"].ToString();

            // Add truong 
            SqlDataAdapter da = new SqlDataAdapter("select distinct(TENTRUONG) from THONGTIN", cnnsql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                cboTruongDangKy.Items.Add(item["TENTRUONG"].ToString());
            }
           //Add nganh 
            SqlDataAdapter daNghanh = new SqlDataAdapter("select * from THONGTIN", cnnsql);
            DataTable dtNghanh = new DataTable();
            daNghanh.Fill(dtNghanh);


            foreach (DataRow item in dtNghanh.Rows)
            {
                //ListItem[] SUBitem = new ListItem[2];
                //SUBitem[0].Text = item.ItemArray[5].ToString();
                //SUBitem[1].Text = item.ItemArray[6].ToString();
                cboNganh.Items.Add(item.ItemArray[6].ToString());
            }
            // Add dacdiemsothich 
            SqlDataAdapter da_sothich = new SqlDataAdapter("select distinct(DACDIEMSOTHICH) from THONGTIN", cnnsql);
            DataTable dt_sothich = new DataTable();
            da_sothich.Fill(dt_sothich);
            foreach (DataRow item in dt_sothich.Rows)
            {
                cboDacDiemSoThich.Items.Add(item["DACDIEMSOTHICH"].ToString());
            }
        }
        string _manganhchon = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter daNghanh = new SqlDataAdapter("select * from THONGTIN WHERE TENNGANH=N'" + cboNganh.SelectedValue.ToString() + "'", cnnsql);
            DataTable dtNghanh = new DataTable();
            daNghanh.Fill(dtNghanh);
            if (dtNghanh.Rows.Count > 0)
            {
                _manganhchon = dtNghanh.Rows[0][5].ToString();
            }
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT [THONGTIN].[KETQUA] From [THONGTIN] NATURAL PREDICTION JOIN (SELECT '"+cboDacDiemSoThich.SelectedValue.ToString()+"' AS [DACDIEMSOTHICH],'"+cboNhomSoThich.SelectedValue.ToString()+"' AS [NHOMSOTHICH], "+int.Parse(txtToHop.Text)+" AS [TBTH],"+int.Parse(txtDiemTHPT.Text)+" AS [TBTHPT]) AS t", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
               TextBox1.Text = dt.Rows[0][0].ToString();
              
            }
            else
            {
                TextBox1.Text = "Hệ thống chưa có đủ thông tin!!!!!";
            }
        }

        protected void cboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        protected void cboNganh_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}
