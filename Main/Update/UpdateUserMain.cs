using Accountant.DataBase.Update.Update;
using System.Text.RegularExpressions;

namespace Accountant.Main.Update
{
    internal class UpdateUserMain : MainApp
    {
        public bool CheckSuccesss, ChangeUsername;
        public string Password;
        public string Error;

        public bool GetFromUI(string LU, string NU, string N, string LN, string LP, string NP, string ConP, string E)
        {
            UpdateUserDB UUDB = new UpdateUserDB();
            GetUserInfoMain GVM = new GetUserInfoMain();
            GVM.GetFromUI(LU);

            if (N == GVM.Name && LN == GVM.LastName && NU == LU && NP == "" && ConP == "" && E == GVM.Email)
            {
                return CheckSuccesss = true;
            }
            if (NP == "")
            {
                NP = LP;
                Password = LP;
            }
            if (ConP == "")
                ConP = LP;

            if (NP != "" && NP != LP)
            {
                PasswordHash PHash = new PasswordHash();
                PHash.Hash(NP);
                Password = PHash.Password;
            }
            if (NU == LU)
            {
                bool IsCorrect = Regex.IsMatch(NP, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[@#$*.])[^\s]{8,}$");
                bool MailFormat = Regex.IsMatch(E, @"(.*?)\b@gmail\.com|(.*?)\b@yahoo.com");
                if ((IsCorrect || NP == LP) && (MailFormat))
                {
                    if (NP == ConP)
                    {
                        ChangeUsername = false;
                        CheckSuccesss = true;
                    }
                    else if (NP != ConP)
                    {
                        Error = "ConPassword";
                    }
                }
                else
                {
                    if (!IsCorrect)
                        Error = "Password";
                    if (!MailFormat)
                        Error = "Email";
                }
            }
            else
            {
                bool IsCorrect = Regex.IsMatch(NP, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[@#$*.])[^\s]{8,}$");
                bool MailFormat = Regex.IsMatch(E, @"(.*?)\b@gmail\.com|(.*?)\b@yahoo.com");
                if ((IsCorrect || NP == LP) && (MailFormat))
                {
                    if (NP == ConP)
                    { 
                        UUDB.GetFromMain(NU);
                        if (UUDB.CheckSuccesss)
                        {
                            ChangeUsername = true;
                            CheckSuccesss = true;
                        }
                        if (!UUDB.CheckSuccesss)
                        {
                            Error = "Username";
                        }
                    }
                    else if (NP != ConP)
                    {
                        Error = "ConPassword";
                    }
                }
                else
                {
                    if (!IsCorrect)
                        Error = "Password";
                    if (!MailFormat)
                        Error = "Email";
                }
            }
            return CheckSuccesss;
        }

        public void CheckPassword(string LU, string NU, string N, string LN, string LP, string NP, string E)
        {
            ConfirmPassword CP = new ConfirmPassword();
            UpdateUserDB UUDB = new UpdateUserDB();
            
            if (!ChangeUsername)
            {
                CP.GetLastPassword(LP, NP);

                if (CP.Check)
                {
                    Query = "update user_ set name = @a , family = @b , password = @c, email = @d  where username = @e";
                    UUDB.GetFromMain(Query, LU, N, LN, Password, E);
                    CheckSuccesss = UUDB.CheckSuccesss;
                }
                else
                {
                    CheckSuccesss = false;
                }
            }
            else
            {
                CP.GetLastPassword(LP, NP);

                if (CP.Check)
                {
                    Query = "update user_ set name = @a , family = @b , password = @c, email = @d , username = @f where username = @e";
                    UUDB.GetFromMain(Query, LU, NU, N, LN, Password, E);
                    Query = "update spend_ set username = @f where username = @e update income_ set username = @f where username = @e";
                    UUDB.GetFromMain(Query, LU, NU);
                    CheckSuccesss = UUDB.CheckSuccesss;
                }
                else
                {
                    CheckSuccesss = false;
                }
            }
        }
        public void GmailUpdate (string LU, string NU, string N, string LN, string E)
        {
            UpdateUserDB UUDB = new UpdateUserDB();

            if (!ChangeUsername)
            {
                Query = "update user_ set name = @a , family = @b , password = @c, email = @d  where username = @e";
                UUDB.GetFromMain(Query, LU, N, LN, Password, E);
                CheckSuccesss = UUDB.CheckSuccesss;
            }
            else
            {
                Query = "update user_ set name = @a , family = @b , password = @c, email = @d , username = @f where username = @e";
                UUDB.GetFromMain(Query, LU, NU, N, LN, Password, E);
                Query = "update spend_ set username = @f where username = @e update income_ set username = @f where username = @e";
                UUDB.GetFromMain(Query, LU, NU);
                CheckSuccesss = UUDB.CheckSuccesss;
            }
        }
    }
}
