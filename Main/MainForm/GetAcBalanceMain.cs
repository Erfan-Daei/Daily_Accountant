using Accountant.DataBase.Select.MainForm;

namespace Accountant.Main.MainForm
{
    public class GetAcBalanceMain : MainApp
    {
        public string AccountBalance;
        public string Wage;

        public (string, string) GetFromUI(string U)
        {
            GetAccountDB GDB = new GetAccountDB();
            GDB.GetFromMain(U);
            AccountBalance = Convert.ToDecimal(GDB.AccountBalance).ToString("N0");
            Wage = Convert.ToDecimal(GDB.Wage).ToString("N0");
            return (AccountBalance, Wage);
        }
    }
}
