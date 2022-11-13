using System.Data;
using System.Data.SqlClient;

namespace TuVanChonNganh.RemoteRepository
{
    public class DBProvider
    {
        private static DBProvider instance;
        private DBProvider() { }
        public static DBProvider GetInstance()
        {
            if (instance == null)
            {
                return new DBProvider();
            }
            return instance;
        }

        private SqlConnection GetConnect()
        {
            return new SqlConnection(Config.connectStr);
        }

        private SqlConnection GetConnect(string conectStr)
        {
            return new SqlConnection(conectStr);
        }

        private DataTable GetData(string query, SqlConnection connect)
        {
            connect.Open();
            DataTable result = new DataTable();
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(result);
            connect.Close();

            return result;
        }

        public DataTable Query(string query)
        {
            return GetData(query, GetConnect());
        }

        public DataTable Query(string query, string connectStr)
        {
            return GetData(query, GetConnect(connectStr));
        }

        private void Excute(string query, SqlConnection connect)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void ExcuteQuery(string query)
        {
            Excute(query, GetConnect());
        }

        public void ExcuteQuery(string query, string connectStr)
        {
            Excute(query, GetConnect(connectStr));
        }
    }
}