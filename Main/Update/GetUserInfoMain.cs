using Accountant.DataBase.Select.Update;

namespace Accountant.Main.Update
{
    internal class GetUserInfoMain : MainApp
    {
        public string Name, LastName, Password, Email;

        public void GetFromUI(string U)
        {
            GetUserInfoDB GVDB = new GetUserInfoDB();
            GVDB.GetFromMain(U);
            Name = GVDB.Name;  LastName = GVDB.LastName; 
            Password = GVDB.Password;   Email = GVDB.Email;
        }
    }
}
