using Accountant.DataBase.Select.MainForm;

namespace Accountant.Main.MainForm
{
    public class SumMain : MainApp
    {
        public string Spend, Income, Balance;
        public decimal Result;
        public bool CheckType;
        public string Error;

        public (string, string, string) GetFromUI(string U, string D1, string D2)
        {
            if (D1 != "")
            {
                SumDB SDB = new SumDB();

                if (D2 != "")
                {
                    Query = "select Tspend = (select sum(price) from spend_ where username = @a and date between @b and @c)";
                    SDB.GetFromMain(U, D1, D2, "Tspend", Query);
                    Spend = SDB.Result.ToString("N0");
                    Query = "select Tincome  = (select sum(price) from Income_ where username = @a and date between @b and @c)";
                    SDB.GetFromMain(U, D1, D2, "Tincome", Query);
                    Income = SDB.Result.ToString("N0");
                }
                else if (D2 == "")
                {
                    D2 = D1;
                    Query = "select Tspend = (select sum(price) from spend_ where username = @a and date between @b and @c)";
                    SDB.GetFromMain(U, D1, D2, "Tspend", Query);
                    Spend = SDB.Result.ToString("N0");
                    Query = "select Tincome  = (select sum(price) from Income_ where username = @a and date between @b and @c)";
                    SDB.GetFromMain(U, D1, D2, "Tincome", Query);
                    Income = SDB.Result.ToString("N0");
                    D2 = "";
                }
                CheckType = SDB.CheckType;

                if (!CheckType)
                {
                    Error = "Date";
                }
            }
            else
            {
                Error = "EmptyD1";
            }

            if (Spend == "" || !CheckType)
                Spend = "00000000";
            if (Income == "" || !CheckType)
                Income = "00000000";

            Balance = (Convert.ToDecimal(Income) - Convert.ToDecimal(Spend)).ToString("N0");
            if (Balance == "0")
                Balance = "00000000";
            return (Spend, Income, Balance);
        }
    }
}
