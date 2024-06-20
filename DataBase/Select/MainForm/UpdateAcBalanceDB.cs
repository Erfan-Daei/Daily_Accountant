using System.Data.SqlClient;
using Accountant.Main.MainForm;

namespace Accountant.DataBase.Select.MainForm
{
    internal class UpdateAcBalanceDB : AddMoneyMain
    {
        public (string, bool) GetFromMain(string Q, string U, string C)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Command.Parameters.AddWithValue("@b", C);
                Reader = Command.ExecuteReader();
                Reader.Read();
                AccountBalance = Reader["account"].ToString();
                Reader.Close();
                CheckSuccess = true;
                return (AccountBalance, CheckSuccess);
            }
            catch
            {
                CheckSuccess = false;
                return (AccountBalance, CheckSuccess);
            }
        }
    }
}
