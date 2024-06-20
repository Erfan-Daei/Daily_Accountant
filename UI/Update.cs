using Accountant.Main.Update;
using Accountant.Main;

namespace Accountant.UI
{
    public partial class Update : Form
    {
        public string AccountBalance, Wage;
        public string LastUsername, LastPassword, LastEmail;
        public string Code;
        public string EmailToken;
        UpdateUserMain UUM = new UpdateUserMain();

        public Update()
        {
            InitializeComponent();
        }

        public (string, string) GetUsername(string U)
        {
            GetUserInfoMain GVM = new GetUserInfoMain();
            GVM.GetFromUI(U);
            SetValues(GVM.Name, GVM.LastName, U, GVM.Email);
            LastUsername = U;   LastPassword = GVM.Password;   LastEmail = GVM.Email;
            return (LastUsername, LastPassword);
        }

        public void SetValues(string N , string LN , string U, string E)
        {
            NameTB.Text = N;   LastNameTB.Text = LN;
            UsernameTB.Text = U;  EmailTB.Text = E;
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

        private void PassChkkBx2_CheckedChanged(object sender, EventArgs e)
        {
            if (ConPasswordTB.PasswordChar == '*')
            {
                ConPasswordTB.PasswordChar = '\0';
                PassChkkBx2.Text = "HIDE";
            }

            else if (ConPasswordTB.PasswordChar == '\0')
            {
                ConPasswordTB.PasswordChar = '*';
                PassChkkBx2.Text = "SHOW";
            }
        }

        private void PasswordTB_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.PasswordTB, "PASSWORD MUST CONTAIN: [A-Z][a-z][0-9][@#$*.][8>][NO SPACE]");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string Input = Num1.Text + Num2.Text + Num3.Text + Num4.Text + Num5.Text;
            TokenCreator TK = new TokenCreator();
            TK.ExpirationEmailToken(EmailToken);
            if (TK.TokenIsValid)
            {
                if (Input == Code)
                {
                    UUM.GmailUpdate(LastUsername, UsernameTB.Text, NameTB.Text, LastNameTB.Text, EmailTB.Text);
                    LogIn LI = new LogIn();
                    LI.Show();
                    this.Close();
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
                case "Email":
                    EmailErrorLabel.Visible = true;
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

        private void NextBtn_Click(object sender, EventArgs e)
        {
            UUM.GetFromUI(LastUsername, UsernameTB.Text, NameTB.Text, LastNameTB.Text, LastPassword, PasswordTB.Text, ConPasswordTB.Text, EmailTB.Text);
            if (UUM.CheckSuccesss)
            {
                if (LastEmail != EmailTB.Text)
                {
                    EmailCheck.Checked = true;
                    LastPassCheck.Enabled = false;
                }
                SelectPanel.Show();
                UpdatePanel.Hide();
            }
            else
            {
                ErrorHandler(UUM.Error);
            }
        }

        private void LastPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            EmailCheck.Checked = false;
            if (LastPassCheck.Checked)
                NextBtn2.Text = "UPDATE";
        }

        private void EmailCheck_CheckedChanged(object sender, EventArgs e)
        {
            LastPassCheck.Checked = false;
            if (EmailCheck.Checked)
                NextBtn2.Text = "NEXT";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UpdatePanel.Show();
            SelectPanel.Hide();
        }

        private void NextBtn2_Click(object sender, EventArgs e)
        {
            if (EmailCheck.Checked)
            {
                One_TimePassword OTP = new One_TimePassword();
                OTP.GetGmail(EmailTB.Text);
                Code = OTP.RandomNumber.ToString();
                EmailToken = OTP.EmailToken;
                label3.Text += "\n" + EmailTB.Text;
                CodePanel.Show();
                Num1.Select();
                SelectPanel.Hide();
            }
            else if (LastPassCheck.Checked)
            {
                UUM.CheckPassword(LastUsername, UsernameTB.Text, NameTB.Text, LastNameTB.Text, LastPassword, lastPassTB.Text, EmailTB.Text);
                if (UUM.CheckSuccesss)
                {
                    LogIn LI = new LogIn();
                    LI.Show();
                    this.Close();
                }
                else
                {
                    LastPassError.Visible = true;
                }
            }
        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            SelectPanel.Show();
            CodePanel.Hide();
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

        private void lastPassTB_TextChanged(object sender, EventArgs e)
        {
            LastPassError.Visible = false;
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

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            EmailErrorLabel.Visible = false;
        }

        private void ConPasswordTB_TextChanged(object sender, EventArgs e)
        {
            ConPasswordError.Text = "";
        }


        private void GoToMainLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainUI MUI = new MainUI();
            MUI.UserTexes(LastUsername);
            MUI.Show();
            this.Close();
        }
    }
}
