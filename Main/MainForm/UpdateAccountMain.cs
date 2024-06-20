using Accountant.DataBase.Update;

namespace Accountant.Main.MainForm
{
    internal class UpdateAccountMain : MainApp
    {
        public string Error;
        public bool Check1 = false;
        public bool Check2 = false;
        public bool Check = false;
        public void GetFromUI(string AB, string W, string U)
        {
            UpdateAccountDB UADB = new UpdateAccountDB();
            Query = "update user_ set account = @a where username = @b";
            UADB.GetFromMain(AB, U, Query);
            Check1 = UADB.Check;
            Query = "update user_ set Wage = @a where username = @b";
            UADB.GetFromMain(W, U, Query);
            Check2 = UADB.Check;

            if (!Check1)
                Error = "AccountBalance";
            if (!Check2)
                Error = "Wage";
            if (!Check1 && !Check2)
                Error = "AB&W";
        }
    }
}
