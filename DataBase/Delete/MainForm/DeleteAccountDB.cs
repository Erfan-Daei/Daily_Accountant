using System.Data.SqlClient;
using Accountant.Main.MainForm;

namespace Accountant.DataBase.Delete.MainForm
{
    internal class DeleteAccountDB : DeleteAccountMain
    {
        public void GetFromMain(string U)
        {
            string[] Queries ={ "delete from user_ where username = @a", "delete from spend_ where username = @a", "delete from income_ where username = @a" };
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Connection.Open();
                    Command = new SqlCommand(Queries[i], Connection);
                    Command.Parameters.AddWithValue("@a", U);
                    Command.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }
    }
}
