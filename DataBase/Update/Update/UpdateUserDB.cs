using System.Data.SqlClient;
using Accountant.Main.Update;

namespace Accountant.DataBase.Update.Update
{
    internal class UpdateUserDB : UpdateUserMain
    {
        public bool GetFromMain(string Q, string LU, string N, string LN, string P, string E)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@a", N);
                Command.Parameters.AddWithValue("@b", LN);
                Command.Parameters.AddWithValue("@c", P);
                Command.Parameters.AddWithValue("@d", E);
                Command.Parameters.AddWithValue("@e", LU);
                Command.ExecuteNonQuery();
                Connection.Close();
                return CheckSuccesss = true;
            }
            catch
            {
                Connection.Close();
                return CheckSuccesss = false;
            }
        }

        public bool GetFromMain(string Q, string LU, string U, string N, string LN, string P, string E)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@a", N);
                Command.Parameters.AddWithValue("@b", LN);
                Command.Parameters.AddWithValue("@c", P);
                Command.Parameters.AddWithValue("@d", E);
                Command.Parameters.AddWithValue("@e", LU);
                Command.Parameters.AddWithValue("@f", U);
                Command.ExecuteNonQuery();
                Connection.Close();
                return CheckSuccesss = true;
            }
            catch
            {
                Connection.Close();
                return CheckSuccesss = false;
            }
        }

        public bool GetFromMain(string Q, string LU, string U)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(Q, Connection);
                Command.Parameters.AddWithValue("@e", LU);
                Command.Parameters.AddWithValue("@f", U);
                Command.ExecuteNonQuery();
                Connection.Close();
                return CheckSuccesss = true;
            }
            catch
            {
                Connection.Close();
                return CheckSuccesss = false;
            }
        }

        public bool GetFromMain(string NU)
        {
            try
            {
                Connection.Open();
                Query = "Select username from user_ where username = @a";
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@a", NU);
                Reader = Command.ExecuteReader();
                Reader.Read();
                string temp = Reader["username"].ToString();
                Reader.Close();
                Connection.Close();
                return CheckSuccesss = false;
            }
            catch
            {
                Reader.Close ();
                Connection.Close();
                return CheckSuccesss = true;
            }
        }
    }
}

