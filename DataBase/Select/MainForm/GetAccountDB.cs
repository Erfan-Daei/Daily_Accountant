using System.Data.SqlClient;
using Accountant.Main.MainForm;

namespace Accountant.DataBase.Select.MainForm
{
    internal class GetAccountDB : GetAcBalanceMain
    {
        public (string, string) GetFromMain(string U)
        {
            try
            {
                Connection.Open();
                Query = "select account , Wage from user_ where username = @a";
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Reader = Command.ExecuteReader();
                Reader.Read();
                AccountBalance = Reader["account"].ToString();
                Wage = Reader["Wage"].ToString();
                Reader.Close();
                return (AccountBalance, Wage);
            }
            catch
            {
                Wage = "0";
                AccountBalance = "0";
                return (AccountBalance, Wage);
            }
        }
    }
}
