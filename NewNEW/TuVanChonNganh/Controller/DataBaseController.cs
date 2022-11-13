using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TuVanChonNganh.Model;
using TuVanChonNganh.RemoteRepository;
using TuVanChonNganh.Util;

namespace TuVanChonNganh.Controller
{
    public class DataBaseController
    {
        private DBProvider dbProvider;

        public DataBaseController(DBProvider dbProvider)
        {
            this.dbProvider = dbProvider;
        }

        public void ConvertDBTuyenSinhToTuVanTuyenSinh()
        {
            Hashtable departments = new Hashtable();
            Hashtable universities = new Hashtable();
            Hashtable groupHobbies = new Hashtable();
            Hashtable propertyHobbies = new Hashtable();
            DataTable thongTinTable = dbProvider.Query("SELECT * FROM THONGTIN", Config.connectStrTuyenSinh);
            foreach (DataRow thongTin in thongTinTable.Rows)
            {
                string idDepartment = thongTin[5].ToString();
                if (!departments.ContainsKey(idDepartment))
                {
                    dbProvider.ExcuteQuery($"INSERT INTO CHUYENNGANH VALUES('{idDepartment}', N'{thongTin[6]}')");
                    departments.Add(idDepartment, thongTin[6].ToString());
                }

                string idUni = UtilString.ConvertStringToId(thongTin[4].ToString());
                if (!universities.ContainsKey(idUni))
                {
                    dbProvider.ExcuteQuery($"INSERT INTO TRUONG VALUES('{idUni}', N'{thongTin[4]}')");
                    universities.Add(idUni, thongTin[4].ToString().ToUpper());
                }

                string idGroupHobby = UtilString.ConvertStringToId(thongTin[9].ToString());
                if (!groupHobbies.ContainsKey(idGroupHobby))
                {
                    dbProvider.ExcuteQuery($"INSERT INTO NHOMSOTHICH VALUES ('{idGroupHobby}', N'{thongTin[9]}')");
                    groupHobbies.Add(idGroupHobby, thongTin[9].ToString());
                }

                string idPropertyHobby = UtilString.ConvertStringToId(thongTin[10].ToString()) + "-" + idGroupHobby;
                if (!propertyHobbies.ContainsKey(idPropertyHobby))
                {
                    dbProvider.ExcuteQuery($"INSERT INTO DACDIEMSOTHICH VALUES('{idPropertyHobby}', '{idGroupHobby}', N'{thongTin[10]}')");
                    propertyHobbies.Add(idPropertyHobby, thongTin[10].ToString());
                }

                string idHs = thongTin[0].ToString();
                string fullname = thongTin[1].ToString();
                DateTime birthDate = DateTime.Parse(thongTin[2].ToString());
                bool gender = thongTin[3].ToString().ToLower().Trim().Equals("nam") ? true : false;
                float average = float.Parse(thongTin[7].ToString());
                float averageUni = float.Parse(thongTin[8].ToString());
                bool result = thongTin[11].ToString().ToLower().Trim().Equals("hạnh phúc") ? true : false;
                dbProvider.ExcuteQuery($"INSERT INTO HOCSINH VALUES('{idHs}', N'{fullname}', '{birthDate.ToString("yyyy-MM-dd")}', {(gender ? 1 : 0)}, {average}, {averageUni}, '{idUni}', '{idDepartment}')");
                dbProvider.ExcuteQuery($"INSERT INTO KETQUA VALUES ('{idHs}', '{idPropertyHobby}', {(result ? 1 : 0)})");
            }
        }
    }
}