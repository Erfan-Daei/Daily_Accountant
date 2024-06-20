using Accountant.Main.SignUp;
using Accountant.Main;

namespace Accountant.UI
{
    public partial class SignUp : Form
    {
        public string AccountBalance, Wage;
        public string Code;
        public string EmailToken;

        public SignUp()
        {
            InitializeComponent();
            DetailPanel.Show();
            GetEmailPanel.Hide();
            GetCodePanel.Hide();

            AccountBalance = "0";
            Wage = "0";
        }

        private void PasswordTB_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.PasswordTB, "PASSWORD MUST CONTAIN: [A-Z][a-z][0-9][@#$*.][8>][NO SPACE]");
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

        private void PassChkBx2_CheckedChanged(object sender, EventArgs e)
        {
            if (ConPasswordTB.PasswordChar == '*')
            {
                ConPasswordTB.PasswordChar = '\0';
                PassChkBx2.Text = "HIDE";
            }

            else if (ConPasswordTB.PasswordChar == '\0')
            {
                ConPasswordTB.PasswordChar = '*';
                PassChkBx2.Text = "SHOW";
            }
        }

        public void ErrorHandler(string Error)
        {
            switch (Error)
            {
                case "Password":
                    PasswordError.Text = "WRONG PASSWORD TYPE";
                    break;
                case "ConPassword":
                    ConPasswordError.Text = "PASSWORDS ARE NOT EQUAL";
                    break;
                case "Username":
                    UsernameError.Text = "USERNAME ALREADY TAKEN";
                    break;
                case "EmptyU":
                    UsernameError.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "EmptyP":
                    PasswordError.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "Empty":
                    PasswordError.Text = UsernameError.Text  = "PLEASE FILL THIS FIELD";
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

        private void ConPasswordTB_TextChanged(object sender, EventArgs e)
        {
            ConPasswordError.Text = "";
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            SignUpMain SUM = new SignUpMain();
            SUM.GetUsername(UsernameTB.Text, PasswordTB.Text, ConPasswordTB.Text);
            if (SUM.CheckUsername)
            {
                DetailPanel.Hide();
                GetEmailPanel.Show();
            }
            else
            {
                ErrorHandler(SUM.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Show();
            GetEmailPanel.Hide();
        }

        private void NextBtn2_Click(object sender, EventArgs e)
        {
            One_TimePassword OTP = new One_TimePassword();
            OTP.GetGmail(EmailTB.Text);
            EmailToken = OTP.EmailToken;
            if (OTP.Check)
            {
                label2.Text += "\n" + EmailTB.Text;
                Code = OTP.RandomNumber.ToString();
                GetCodePanel.Show();
                GetEmailPanel.Hide();
            }
            else
            {
                WrongEmailLabel.Visible = true;
            }
        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            GetCodePanel.Hide();
            GetEmailPanel.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string input = Num1.Text + Num2.Text + Num3.Text + Num4.Text + Num5.Text;
            TokenCreator TK = new TokenCreator();
            TK.ExpirationEmailToken(EmailToken);
            if (TK.TokenIsValid)
            {
                if (input == Code)
                {
                    SignUpMain SUM = new SignUpMain();
                    SUM.GetFromUI(UsernameTB.Text, NameTB.Text, LastNameTB.Text, PasswordTB.Text,
                        ConPasswordTB.Text, AccountBalance, Wage, EmailTB.Text);
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

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            WrongEmailLabel.Visible = false;
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
            OTP.GetGmail(EmailTB.Text);
            EmailToken = OTP.EmailToken;
            Code = OTP.RandomNumber.ToString();
            ResendBtn.Visible = false;
            ResendBtn.Enabled = false;
            Num1.Text = Num2.Text = Num3.Text = Num4.Text = Num5.Text = "";
            Num1.Select();
        }

        private void GoToLogInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn LI = new LogIn();
            LI.Show();
            this.Hide();
        }
    }
}
