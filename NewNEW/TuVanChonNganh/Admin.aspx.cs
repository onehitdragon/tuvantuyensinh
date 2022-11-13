using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TuVanChonNganh.Controller;
using TuVanChonNganh.RemoteRepository;

namespace TuVanChonNganh
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_ConvertDB(object sender, EventArgs e)
        {
            DataBaseController dataBaseController = new DataBaseController(DBProvider.GetInstance());
            dataBaseController.ConvertDBTuyenSinhToTuVanTuyenSinh();
        }
    }
}