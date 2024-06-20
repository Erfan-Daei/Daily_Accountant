using System.Data.SqlClient;
using Accountant.Main.MainForm;

namespace Accountant.DataBase.Insert.MainForm
{
    internal class AddMoneyDB : AddMoneyMain
    {
        public bool GetFromMain(string Q, string U, string F, string C, string T, string D)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Command.Parameters.AddWithValue("@b", F);
                Command.Parameters.AddWithValue("@c", C);
                Command.Parameters.AddWithValue("@d", T);
                Command.Parameters.AddWithValue("@e", D);
                Command.ExecuteNonQuery();
                CheckSuccess = true;
                return CheckSuccess;
            }
            catch
            {
                CheckSuccess = false;
                return CheckSuccess;
            }
        }
    }
}
