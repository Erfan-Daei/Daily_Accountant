using Accountant.Main;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;


namespace Accountant.Main
{
    internal class One_TimePassword : MainApp
    {
        public bool Check = false;
        public int RandomNumber;
        public string EmailToken;

        public int GeneratePassword()
        {
           RandomNumber = new Random().Next(10000, 100000);
           return RandomNumber;
        }

        public void GetGmail(string Email)
        {
            if (Email != "")
            {
                bool MailFormat = Regex.IsMatch(Email, @"(.*?)\b@gmail\.com|(.*?)\b@yahoo.com");
                if (MailFormat)
                {
                    GeneratePassword();
                    Email_Sender(Email, RandomNumber);
                }
                else
                {
                    Check = false;
                }
            }
            else
            {
                Check = false;
            }
        }

        public void Email_Sender(string InputEmail, int otp)
        {
            MailMessage email = new MailMessage()
            {
                From = new MailAddress("erfan.daei.program@gmail.com"),
                Subject = "Accountant One-Time Password",
                Body = $"This Is Your One-Time Password : {otp}",
            };
            email.To.Add(InputEmail);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("erfan.daei.program@gmail.com", "pmyg hags ufvo sctj"),
                EnableSsl = true,
                Timeout = 10000,
            };
            try
            {
                smtp.Send(email);
                TokenCreator TK = new TokenCreator();
                TK.CreateToken();
                EmailToken = TK.Token;
                Check = true;
            }
            catch
            {
                DialogResult WrongEmail = MessageBox.Show("Invalid Gmail", "One-Time Password");
            }
        }
    }
}
