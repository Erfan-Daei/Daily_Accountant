using Accountant.Main.SignUp;
using System.Data.SqlClient;

namespace Accountant.DataBase.Select.SignUp
{
    internal class CheckUsernameDB : SignUpMain
    {
        public bool GetUsername(string U)
        {
             try
             {

                Connection.Open();
                Query = "select username from user_ where username = @a";
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Reader = Command.ExecuteReader();
                Reader.Read();
                string temp = Reader["username"].ToString();
                Reader.Close();
                if (temp == "")
                {
                    CheckUsername = true;
                }
                else
                {
                    CheckUsername = false;
                }
                return CheckUsername;
             }
             catch
             {
                CheckUsername = true;
                return CheckUsername;
             }
        }
    }
}
