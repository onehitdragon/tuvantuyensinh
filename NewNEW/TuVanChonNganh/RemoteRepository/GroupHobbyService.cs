using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TuVanChonNganh.Model;

namespace TuVanChonNganh.RemoteRepository
{
    public class GroupHobbyService
    {
        private DBProvider dbProvider;
        public GroupHobbyService(DBProvider dbProvider) 
        { 
            this.dbProvider = dbProvider;
        }

        public List<GroupHobby> GetListGroupHobby()
        {
            List<GroupHobby> result = new List<GroupHobby>();
            string query = "SELECT * FROM NHOMSOTHICH";
            foreach (DataRow item in dbProvider.Query(query).Rows)
            {
                result.Add(new GroupHobby(item[0].ToString(), item[1].ToString()));
            }

            return result;
        }

        public GroupHobby GetGroupHobby(string id)
        {
            string query = $"SELECT * FROM NHOMSOTHICH WHERE MaNhomST = '{id}'";
            DataRow row = dbProvider.Query(query).Rows[0];
            return new GroupHobby(
                id,
                row[1].ToString()
            );
        }
    }
}