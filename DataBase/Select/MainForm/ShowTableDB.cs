using System.Data;
using System.Data.SqlClient;
using Accountant.Main.MainForm;

namespace Accountant.DataBase.Select.MainForm
{
    internal class ShowTableDB : ShowTableMain
    {
        public (bool, DataTable) GetFromMain(string Q, string U, string D1, string D2)
        {
            try
            {
                Connection.Open();
                Adapter = new SqlDataAdapter(Q, Connection);
                Adapter.SelectCommand.Parameters.AddWithValue("@b", U);
                Adapter.SelectCommand.Parameters.AddWithValue("@c", D1);
                Adapter.SelectCommand.Parameters.AddWithValue("@d", D2);
                DataTbl = new DataTable();
                Adapter.Fill(DataTbl);
                CheckType = true;
                return (CheckType, DataTbl);
            }
            catch
            {
                CheckType = false;
                return (CheckType, DataTbl);
            }
        }
    }
}
