using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TuVanChonNganh.Model;

namespace TuVanChonNganh.RemoteRepository
{
    public class PropertyHobbyService
    {
        private DBProvider dbProvider;
        public PropertyHobbyService(DBProvider dbProvider)
        {
            this.dbProvider = dbProvider;
        }

        public List<PropertyHobby> GetListProperHobby()
        {
            List<PropertyHobby> result = new List<PropertyHobby>();
            string query = $"SELECT * FROM DACDIEMSOTHICH";
            foreach (DataRow item in dbProvider.Query(query).Rows)
            {
                result.Add(new PropertyHobby(item[0].ToString(), item[1].ToString(), item[2].ToString()));
            }

            return result;
        }
    }
}