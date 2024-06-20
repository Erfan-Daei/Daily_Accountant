using Accountant.DataBase.Select.logIn;

namespace Accountant.Main.LogIn
{
    public class LogInMain : MainApp
    {
        public bool CheckUsername;
        public bool CheckPassword;
        public string Password;
        public string Email;
        public string Error;

        public bool GetFromUI(string U, string P)
        {
            
            if (U != "" && P != "")
            {
                PasswordHash PHash = new PasswordHash();
                PHash.Hash(P);
                LogInDB LDB = new LogInDB();
                LDB.GetFromMain(U);
                CheckUsername = LDB.CheckUsername;
                Password = LDB.Password;

                if (CheckUsername)
                {
                    if (Password == PHash.Password)
                    {
                        return CheckPassword = true;
                    }
                    else if (Password != PHash.Password)
                    {
                        Error = "Password";
                    }
                }
                else if (!CheckUsername)
                {
                    Error = "Username";
                }
            }
            if (U == "")
            {
                Error = "EmptyU";
            }
            if (P == "")
            {
                Error = "EmptyP";
            }
            if (U == "" && P == "")
            {
                Error = "Empty";
            }
            return CheckPassword;
        }

        public bool GetFromUI(string U)
        {
            LogInDB LDB = new LogInDB();
            LDB.GetFromMain(U);
            CheckUsername = LDB.CheckUsername;
            Email = LDB.Email;

            if (CheckUsername)
                return CheckUsername = true;
            if (!CheckUsername)
                Error = "Username";
            if (U == "")
                Error = "EmptyU";

            return CheckUsername;
        }
    }
}
