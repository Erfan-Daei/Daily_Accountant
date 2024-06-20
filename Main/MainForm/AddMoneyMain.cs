using Accountant.DataBase.Insert.MainForm;
using Accountant.DataBase.Select.MainForm;

namespace Accountant.Main.MainForm
{
    internal class AddMoneyMain : MainApp
    {
        public bool CheckSuccess;
        public string AccountBalance;
        public string Error;

        public (bool, string) GetFromUI(bool SI , string U, string F, string C, string T, string D)
        {
            if (F != "" && C != "")
            {
                if (SI)
                    Query = "insert into Spend_ values (@a , @b , @c , @D , @e) ";
                else if (!SI)
                    Query = "insert into Income_ values (@a , @b , @c , @D , @e) ";

                AddMoneyDB AVDB = new AddMoneyDB();
                AVDB.GetFromMain(Query, U, F, C, T, D);
                CheckSuccess = AVDB.CheckSuccess;

                if (SI)
                    Query = "update user_ set account = (select (account - @b) from user_ where USERNAME = @a) where username = @a  select account from user_ where username = @a";
                else if (!SI)
                    Query = "update user_ set account = (select (account + @b) from user_ where USERNAME = @a) where username = @a  select account from user_ where username = @a";

                if (CheckSuccess)
                {
                    UpdateAcBalanceDB UADB = new UpdateAcBalanceDB();
                    UADB.GetFromMain(Query, U, C);
                    CheckSuccess = UADB.CheckSuccess;
                    AccountBalance = Convert.ToDecimal(UADB.AccountBalance).ToString("N0");
                }

                if (CheckSuccess)
                {
                    return (CheckSuccess, AccountBalance);
                }
                else if (!CheckSuccess)
                {
                    if (SI)
                        Error = "Cost1";
                    if (!SI)
                        Error = "Cost2";
                }
            }
            else
            {
                if (SI)
                {
                    if (F == "")
                        Error = "EmptyF1";
                    if (C == "")
                        Error = "EmptyC1";
                }
                if (!SI)
                {
                    if (F == "")
                        Error = "EmptyF2";
                    if (C == "")
                        Error = "EmptyC2";
                }
            }
            return (CheckSuccess, AccountBalance);
        }
    }
}
