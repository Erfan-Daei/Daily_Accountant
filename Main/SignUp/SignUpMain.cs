using Accountant.DataBase.Insert.SignUp;
using Accountant.DataBase.Select.SignUp;
using System.Text.RegularExpressions;

namespace Accountant.Main.SignUp
{
    public class SignUpMain : MainApp
    {
        public bool CheckUsername;
        public string Error;
        
        public bool GetUsername(string U, string P, string ConP)
        {
            if (U != null && P != null)
            {
                bool IsCorrect = Regex.IsMatch(P, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[@#$*.])[^\s]{8,}$");
                if (IsCorrect)
                {
                    if (P == ConP)
                    {
                        CheckUsernameDB CUDB = new CheckUsernameDB();
                        CUDB.GetUsername(U);
                        CheckUsername = CUDB.CheckUsername;

                        if (CheckUsername)
                        {
                            return CheckUsername = true;
                        }
                        else if (!CheckUsername)
                        {
                            Error = "Username";
                        }
                    }
                    else if (P != ConP)
                    {
                        Error = "ConPassword";
                    }
                }
                else
                {
                    Error = "Password";
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
            return CheckUsername;
        }
        public void GetFromUI(string U, string N, string LN, string P, string ConP, string AB, string W, string E)
        {
            PasswordHash PHash = new PasswordHash();
            PHash.Hash(P);
            string Password = PHash.Password;
            SignUpDB SUDB = new SignUpDB();
            SUDB.GetFromMain(U, N, LN, Password, AB, W, E);
        }
    }
}
