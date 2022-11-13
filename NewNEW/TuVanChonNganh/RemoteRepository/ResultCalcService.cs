using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TuVanChonNganh.Model;

namespace TuVanChonNganh.RemoteRepository
{
    public class ResultCalcService
    {
        private DBProvider dbProvider;
        public ResultCalcService(DBProvider dbProvider)
        {
            this.dbProvider = dbProvider;
        }

        public ReportHobby GetReportHobby(string idGroup, string idPropertyHoppys)
        {
            string query = $"SELECT SUM(KETQUA.KetQua * 1) as N'Hạnh phúc', COUNT(DACDIEMSOTHICH.MaNhomST) as N'Tổng'\r\nFROM HOCSINH JOIN KETQUA ON HOCSINH.MaHS = KETQUA.MaHS JOIN DACDIEMSOTHICH ON KETQUA.MaDacDiemST = DACDIEMSOTHICH.MaDacDiemST WHERE DACDIEMSOTHICH.MaDacDiemST IN ({idPropertyHoppys}) AND  DACDIEMSOTHICH.MaNhomST = '{idGroup}'";
            DataRow row = dbProvider.Query(query).Rows[0];

            return new ReportHobby(
                int.Parse(row[0].ToString()),
                int.Parse(row[1].ToString()) - int.Parse(row[0].ToString()),
                int.Parse(row[1].ToString())
            );
        }

        public List<Department> GetDepartmentByHobbyGroup(string idGroup)
        {
            List<Department> resullt = new List<Department>();
            string query = $"SELECT CHUYENNGANH.MaNghanh, CHUYENNGANH.TenNganh FROM HOCSINH JOIN KETQUA ON HOCSINH.MaHS = KETQUA.MaHS JOIN DACDIEMSOTHICH ON KETQUA.MaDacDiemST = DACDIEMSOTHICH.MaDacDiemST JOIN CHUYENNGANH ON CHUYENNGANH.MaNghanh = HOCSINH.MaNghanh WHERE DACDIEMSOTHICH.MaNhomST = '{idGroup}' GROUP BY CHUYENNGANH.MaNghanh, CHUYENNGANH.TenNganh";
            DataTable tb = dbProvider.Query(query);
            foreach (DataRow row in tb.Rows)
            {
                resullt.Add(new Department(
                        row[0].ToString(),
                        row[1].ToString()
                    ));
            }

            return resullt;
        }
    }
}