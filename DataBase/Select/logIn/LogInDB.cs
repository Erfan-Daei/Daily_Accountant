using System.Data.SqlClient;
using Accountant.Main.LogIn;

namespace Accountant.DataBase.Select.logIn
{
    public class LogInDB : LogInMain
    {
        public (bool, string, string) GetFromMain(string U)
        {
            try
            {
                Connection.Open();
                Query = "select password, email from user_ where username = @a";
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Reader = Command.ExecuteReader();
                Reader.Read();
                Password = Reader["password"].ToString();
                Email = Reader["email"].ToString();
                Reader.Close();
                CheckUsername = true;
                return (CheckUsername, Password, Email);
            }
            catch
            {
                Reader.Close();
                Connection.Close();
                CheckUsername = false;
                return (CheckUsername, Password, Email);
            }
        }
    }
}
