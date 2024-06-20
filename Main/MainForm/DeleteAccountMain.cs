using Accountant.DataBase.Delete.MainForm;

namespace Accountant.Main.MainForm
{
    internal class DeleteAccountMain : MainApp
    {
        public void GetFromUI(string U)
        {
            DeleteAccountDB DADB = new DeleteAccountDB();
            DADB.GetFromMain(U);
        }
    }
}
