using System.Data.SqlClient;
using Accountant.Main.SignUp;

namespace Accountant.DataBase.Insert.SignUp
{
    public class SignUpDB : SignUpMain
    {
        public void GetFromMain(string U, string N, string LN, string P, string AB, string W, string E)
        {
            try
            {
                Connection.Open();
                Query = "Insert into user_ values (@a , @b , @c , @d , @e , @f, @g)";
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@a", U);
                Command.Parameters.AddWithValue("@b", N);
                Command.Parameters.AddWithValue("@c", LN);
                Command.Parameters.AddWithValue("@d", P);
                Command.Parameters.AddWithValue("@e", Convert.ToInt32(AB));
                Command.Parameters.AddWithValue("@f", Convert.ToInt32(W));
                Command.Parameters.AddWithValue("@g", E);
                Command.ExecuteNonQuery();
            }
            catch
            {
                Connection.Close();
            }
        }
    }
}
