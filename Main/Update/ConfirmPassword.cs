using Microsoft.VisualBasic;

namespace Accountant.Main.Update
{
    internal class ConfirmPassword
    {
        public bool Check;

        public bool GetLastPassword(string LP, string NP)
        {
            if (NP != "")
            {
                PasswordHash PHash = new PasswordHash();
                PHash.Hash(NP);
                if (LP == PHash.Password)
                {
                    Check = true;
                }
                else
                {
                    Check = false;
                }
            }
            else
            {
                return Check = false;
            }
            return Check;
        }
    }
}
