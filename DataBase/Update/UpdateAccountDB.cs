using Accountant.Main.MainForm;
using System.Data.SqlClient;

namespace Accountant.DataBase.Update
{
    internal class UpdateAccountDB : UpdateAccountMain
    {
        public void GetFromMain(string I, string U, string Q)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@a", I);
                Command.Parameters.AddWithValue("@b", U);
                Command.ExecuteNonQuery();
                Connection.Close();
                Check = true;
            }
            catch
            {
                Connection.Close();
                Check = false;
            }

        }
    }
}
