using Accountant.Main;
using Accountant.Main.LogIn;
using System.Linq;

namespace Accountant.UI
{
    public partial class LogIn : Form
    {
        public string Code;
        public string EmailToken;
        public string Email;

        public LogIn()
        {
            InitializeComponent();
        }

        private void PassChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTB.PasswordChar == '*')
            {
                PasswordTB.PasswordChar = '\0';
                PassChkBx.Text = "HIDE";
            }

            else if (PasswordTB.PasswordChar == '\0')
            {
                PasswordTB.PasswordChar = '*';
                PassChkBx.Text = "SHOW";
            }
        }

        private void LogInTB_Click(object sender, EventArgs e)
        {
            LogInMain LIM = new LogInMain();
            LIM.GetFromUI(UsernameTB.Text, PasswordTB.Text);
            if (LIM.CheckPassword)
            {
                MainUI MU = new MainUI();
                MU.Show();
                MU.UserTexes(UsernameTB.Text);
                this.Hide();
            }
            ErrorHandler(LIM.Error);
        }

        private void GoToSignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp SU = new SignUp();
            SU.Show();
            this.Hide();
        }

        public void ErrorHandler(string Error)
        {
            switch (Error)
            {
                case "Password":
                    PasswordError.Text = "WRONG PASSWORD";
                    break;
                case "Username":
                    UsernameError.Text = "WRONG USERNAME";
                    break;
                case "EmptyU":
                    UsernameError.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "EmptyP":
                    PasswordError.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "Empty":
                    PasswordError.Text = UsernameError.Text = "PLEASE FILL THIS FIELD";
                    break;
            }
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            UsernameError.Text = "";
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            PasswordError.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInMain LIM = new LogInMain();
            LIM.GetFromUI(UsernameTB.Text);
            Email = LIM.Email;
            if (LIM.CheckUsername)
            {
                One_TimePassword OTP = new One_TimePassword();
                OTP.GetGmail(LIM.Email);
                EmailToken = OTP.EmailToken;
                if (OTP.Check)
                {
                    Code = OTP.RandomNumber.ToString();
                    CodePanel.Show();
                    Num1.Select();
                    label2.Text += "\n" + LIM.Email;
                    LogInPanel.Hide();
                }
            }
            ErrorHandler(LIM.Error);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CodePanel.Hide();
            LogInPanel.Show();
        }

        private void LogInBtn2_Click(object sender, EventArgs e)
        {
            string input = Num1.Text + Num2.Text + Num3.Text + Num4.Text + Num5.Text;
            TokenCreator TK = new TokenCreator();
            TK.ExpirationEmailToken(EmailToken);
            if (TK.TokenIsValid)
            {
                if (Code == input)
                {
                    MainUI MU = new MainUI();
                    MU.Show();
                    MU.UserTexes(UsernameTB.Text);
                    this.Hide();
                }
                else
                {
                    WrongCodeLabel.Text = "Wrong Input";
                    WrongCodeLabel.Visible = true;
                }
            }
            else
            {
                WrongCodeLabel.Text = "Code Has Expired";
                WrongCodeLabel.Visible = true;
                ResendBtn.Visible = true;
                ResendBtn.Enabled = true;
            }
            
        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {
            WrongCodeLabel.Visible = false;
            Num2.Select();
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {
            WrongCodeLabel.Visible = false;
            Num3.Select();
        }

        private void Num3_TextChanged(object sender, EventArgs e)
        {
            WrongCodeLabel.Visible = false;
            Num4.Select();
        }

        private void Num4_TextChanged(object sender, EventArgs e)
        {
            WrongCodeLabel.Visible = false;
            Num5.Select();
        }

        private void Num5_TextChanged(object sender, EventArgs e)
        {
            WrongCodeLabel.Visible = false;
        }

        private void ResendBtn_Click(object sender, EventArgs e)
        {
            One_TimePassword OTP = new One_TimePassword();
            OTP.GetGmail(Email);
            EmailToken = OTP.EmailToken;
            Code = OTP.RandomNumber.ToString();
            ResendBtn.Visible = false;
            ResendBtn.Enabled = false;
            Num1.Text = Num2.Text = Num3.Text = Num4.Text = Num5.Text = "";
            Num1.Select();
        }
    }
}
