using System.Data;
using Accountant.DataBase.Select.MainForm;

namespace Accountant.Main.MainForm
{
    public class ShowTableMain : MainApp
    {
        public bool CheckType;
        public string Error;

        public DataTable GetFromUI(bool SI, string U, string D1, string D2)
        {
            if (D1 != "")
            {
                if (SI)
                    Query = "select name as 'REASON' , cast(price as decimal(12,0)) as 'COST' , date as 'DATE' , time as 'TIME' from spend_ where username = @b and date between @c and @d";
                else if (!SI)
                    Query = "select name as 'REASON' , cast(price as decimal(12,0)) as 'COST' , date as 'DATE' , time as 'TIME' from income_ where username = @b and date between @c and @d";
                
                ShowTableDB ShTDB = new ShowTableDB();

                if (D2 != "")
                {
                    ShTDB.GetFromMain(Query, U, D1, D2);
                    CheckType = ShTDB.CheckType;
                    DataTbl = ShTDB.DataTbl;
                }
                else if (D2 == "")
                {
                    D2 = D1;
                    ShTDB.GetFromMain(Query, U, D1, D2);
                    CheckType = ShTDB.CheckType;
                    DataTbl = ShTDB.DataTbl;
                    D2 = "";
                }
                if (!CheckType)
                {
                    Error = "Date";
                }
            }
            else
            {
                Error = "EmptyD1";
            }           
            return DataTbl;
        }
    }
}
