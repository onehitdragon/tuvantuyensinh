using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using TuVanChonNganh.RemoteRepository;
using TuVanChonNganh.Model;
using System.Collections.Specialized;
using System.Collections;

namespace TuVanChonNganh
{
    public partial class TraCuuTuVan : System.Web.UI.Page
    {
        public List<GroupHobby> listGroupHobby;
        public List<PropertyHobby> listPropertyHobby;
        public Hashtable hash;
        public List<ReportHobby> listReportHobby;
        public List<Department> listDepartmentResult;
        protected void Page_Load(object sender, EventArgs e)
        {
            GroupHobbyService groupHobbyService = new GroupHobbyService(DBProvider.GetInstance());
            listGroupHobby = groupHobbyService.GetListGroupHobby();

            PropertyHobbyService propertyHobbyService = new PropertyHobbyService(DBProvider.GetInstance());
            listPropertyHobby = propertyHobbyService.GetListProperHobby();

            if (Page.IsPostBack)
            {
                NameValueCollection body = Request.Params;
                int amountHobby = int.Parse(body.Get("amountHobby").ToString());
                hash = new Hashtable();
                for (int i = 0; i < amountHobby; i++)
                {
                    string idGroup = body.Get("cbGroupHobby" + i);
                    string id = body.Get("cbPropertyHobby" + i);
                    if (!hash.ContainsKey(idGroup))
                    {
                        hash.Add(idGroup, "'" + id + "'");
                    }
                    else
                    {
                        hash[idGroup] = hash[idGroup] + "," + "'" + id + "'";
                    }
                }
                float hk = float.Parse(txtDiemTHPT.Text.ToString());
                float th = float.Parse(txtToHop.Text.ToString());

                listReportHobby = new List<ReportHobby>();
                ResultCalcService resultCalcService = new ResultCalcService(DBProvider.GetInstance());
                foreach (string idGroup in hash.Keys)
                {
                    ReportHobby reportHobby = resultCalcService.GetReportHobby(idGroup, hash[idGroup].ToString());
                    listReportHobby.Add(reportHobby);
                }

                string idGroupResult = "";
                double maxPercent = 0;
                int j = 0;
                foreach (string idGroup in hash.Keys)
                {
                    if (listReportHobby[j].CalcPercentHappy() > maxPercent)
                    {
                        maxPercent = listReportHobby[j].CalcPercentHappy();
                        idGroupResult = idGroup;
                    }
                    j++;
                }

                if (!String.IsNullOrEmpty(idGroupResult))
                {
                    listDepartmentResult = resultCalcService.GetDepartmentByHobbyGroup(idGroupResult);
                }
            }  
        }
    }
}
