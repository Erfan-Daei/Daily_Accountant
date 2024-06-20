using System.Data.SqlClient;
using Accountant.Main.Update;

namespace Accountant.DataBase.Select.Update
{
    internal class GetUserInfoDB : GetUserInfoMain
    {
        public void GetFromMain(string U)
        {
            Connection.Open();
            Query = "select name , family , password, email  from user_ where username = @a ";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@a", U);
            Reader = Command.ExecuteReader();
            Reader.Read();
            Name = Reader["name"].ToString();
            LastName = Reader["family"].ToString();
            Password = Reader["password"].ToString();
            Email = Reader["email"].ToString();
            Reader.Close();
        }
    }
}
