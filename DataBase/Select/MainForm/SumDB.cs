using System.Data.SqlClient;
using Accountant.Main.MainForm;

namespace Accountant.DataBase.Select.MainForm
{
    internal class SumDB : SumMain
    {
        public (decimal, bool) GetFromMain(string U, string D1, string D2, string SI, string Q)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Command.Parameters.AddWithValue("@b", D1);
                Command.Parameters.AddWithValue("@C", D2);
                Reader = Command.ExecuteReader();
                Reader.Read();
                Result = Convert.ToDecimal(Reader[SI]);
                Reader.Close();
                Connection.Close();
                CheckType = true;
                return (Result, CheckType);
                
            }
            catch
            {
                Connection.Close();
                CheckType = false;
                Result = 0m;
                return (Result, CheckType);
            }
        }
    }
}
