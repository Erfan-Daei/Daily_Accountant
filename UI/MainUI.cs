using Accountant.Main.MainForm;
using System.Text.RegularExpressions;

namespace Accountant.UI
{
    public partial class MainUI : Form
    {
        public string AccountBalance, Wage;
        public bool CheckSI;
        public bool GetWage = false;

        public MainUI()
        {
            InitializeComponent();

            Timer.Start();

            AddFormBtn.BackColor = Color.FromArgb(64, 64, 64);
            AddFormBtn.ForeColor = Color.White;
            AddFormGroupBx.Show();
            DetailFormGroupBx.Hide();
            CalculatorFormGroupBx.Hide();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime DTime = DateTime.Now;
            DateLabel.Text = DTime.ToString("yyyy/MM/dd");
            TimeLabel.Text = DTime.ToString("HH:mm");
        }

        public string UserTexes(string U)
        {
            UserLabel.Text = U.ToUpper();
            GetAcBalanceMain GAM = new GetAcBalanceMain();
            GAM.GetFromUI(UserLabel.Text);
            MoneyLabel.Text = GAM.AccountBalance;
            MoneyLabel2.Text = GAM.Wage;
            return UserLabel.Text;
        }
        private void BtnClean_Click(object sender, EventArgs e)
        {
            CalTxBx.ResetText();
        }
        
        private void uPDATEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update Updt = new Update();
            Updt.GetUsername(UserLabel.Text);
            Updt.Show();
            this.Close();
        }

        private void sWITCHACCOUNTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LogIn LI = new LogIn();
            LI.Show();
            this.Close();
        }

        private void dELETEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Warning = MessageBox.Show("ARE YOU SURE TO DELETE YOUR ACCOUNT?\nALL OF YOUR DATA WILL BE LOST!", "ACCOUNTANT", MessageBoxButtons.YesNo);
            if (Warning == DialogResult.Yes)
            {
                DeleteAccountMain DAM = new DeleteAccountMain();
                DAM.GetFromUI(UserLabel.Text);
                LogIn LI = new LogIn();
                LI.Show();
                this.Close();
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //
        //
        //Add Form
        //
        //
        //
        private void AddSpend_Click(object sender, EventArgs e)
        {
            AddMoneyMain AVM = new AddMoneyMain();
            CheckSI = true;
            AVM.GetFromUI(CheckSI, UserLabel.Text, ForTB.Text, CostTB.Text, TimeLabel.Text, DateLabel.Text);

            if (AVM.CheckSuccess)
            {
                MoneyLabel.Text = AVM.AccountBalance;
                ForTB.ResetText(); CostTB.ResetText();
            }
            else if (!AVM.CheckSuccess)
            {
                CostTB.ResetText();
            }
            ErrorHandler1(AVM.Error);
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            AddMoneyMain AVM = new AddMoneyMain();
            CheckSI = false;
            AVM.GetFromUI(CheckSI, UserLabel.Text, FromTB.Text, CostTB2.Text, TimeLabel.Text, DateLabel.Text);

            if (AVM.CheckSuccess)
            {
                MoneyLabel.Text = AVM.AccountBalance;
                FromTB.ResetText(); CostTB2.ResetText();
            }
            else if (!AVM.CheckSuccess)
            {
                CostTB2.ResetText();
            }
            ErrorHandler1(AVM.Error);
        }

        private void ForTB_TextChanged(object sender, EventArgs e)
        {
            ForError.Text = "";
        }

        private void CostTB_TextChanged(object sender, EventArgs e)
        {
            Cost1Error.Text = "";
        }

        private void FromTB_TextChanged(object sender, EventArgs e)
        {
            FromError.Text = "";
        }

        private void CostTB2_TextChanged(object sender, EventArgs e)
        {
            Cost2Error.Text = "";
        }

        private void BalanceTB_TextChanged(object sender, EventArgs e)
        {
            AccountBalance = BalanceTB.Text;
            BalanceError.Text = "";
        }

        private void WageTB_TextChanged(object sender, EventArgs e)
        {
            Wage = WageTB.Text;
            WageError.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (BalanceTB.Text == "")
                AccountBalance = MoneyLabel.Text;
            if (WageTB.Text == "")
                Wage = MoneyLabel2.Text;
            UpdateAccountMain UAM = new UpdateAccountMain();
            UAM.GetFromUI(AccountBalance, Wage, UserLabel.Text);
            UserTexes(UserLabel.Text);
            BalanceTB.ResetText();   WageTB.ResetText();

            ErrorHandler1(UAM.Error);
        }

        public void ErrorHandler1(string Error)
        {
            switch (Error)
            {
                case "Cost1":
                    Cost1Error.Text = "WRONG COST TYPE";
                    break;
                case "Cost2":
                    Cost2Error.Text = "WRONG COST TYPE";
                    break;
                case "EmptyF1":
                    ForError.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "EmptyF2":
                    FromError.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "EmptyC1":
                    Cost1Error.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "EmptyC2":
                    Cost2Error.Text = "PLEASE FILL THIS FIELD";
                    break;
                case "AccountBalance":
                    BalanceError.Text = "WRONG TYPE";
                    break;
                case "Wage":
                    WageError.Text = "WRONG TYPE";
                    break;
                case "AB&W":
                    BalanceError.Text = WageError.Text = "WRONG TYPE";
                    break;
            }
        }
        //
        //
        //
        //Detail Form
        //
        //
        //
        private void Today1_CheckedChanged(object sender, EventArgs e)
        {
            Date1TB.ResetText();
            Date1TB.Text = DateLabel.Text;
            Today1.Checked = false;
        }

        private void CLEAR1_CheckedChanged(object sender, EventArgs e)
        {
            Date1TB.ResetText();
            Clear1.Checked = false;
        }

        private void Today2_CheckedChanged(object sender, EventArgs e)
        {
            Date2TB.ResetText();
            Date2TB.Text = DateLabel.Text;
            Today2.Checked = false;
        }

        private void Clear2_CheckedChanged(object sender, EventArgs e)
        {
            Date2TB.ResetText();
            Clear2.Checked = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SumMain SM = new SumMain();
            SM.GetFromUI(UserLabel.Text, Date1TB.Text, Date2TB.Text);
            TotalSpendLabel.Text = SM.Spend;
            TotalIncomeLabel.Text = SM.Income;
            BalanceLabel.Text = SM.Balance;

            ErrorHandler2(SM.Error);
        }

        private void SpendRB_CheckedChanged(object sender, EventArgs e)
        {
            ShowTableMain STM = new ShowTableMain();
            CheckSI = true;
            STM.GetFromUI(CheckSI, UserLabel.Text, Date1TB.Text, Date2TB.Text);
            SpInTable.DataSource = STM.DataTbl;
            SpendRB.Checked = false;

            ErrorHandler2(STM.Error);
        }

        private void IncomeRB_CheckedChanged(object sender, EventArgs e)
        {
            ShowTableMain STM = new ShowTableMain();
            CheckSI = false;
            STM.GetFromUI(CheckSI, UserLabel.Text, Date1TB.Text, Date2TB.Text);
            SpInTable.DataSource = STM.DataTbl;
            IncomeRB.Checked = false;

            ErrorHandler2(STM.Error);
        }

        private void Date1TB_TextChanged(object sender, EventArgs e)
        {
            DateError.Text = Date1Error.Text = "";
        }

        private void Date2TB_TextChanged(object sender, EventArgs e)
        {
            DateError.Text = "";
        }

        public void ErrorHandler2(string Error)
        {
            switch (Error)
            {
                case "Date":
                    DateError.Text = "WRONG TYPE";
                    break;
                case "EmptyD1":
                    Date1Error.Text = "PLEASE FILL THIS FIELD";
                    break;
            }
        }
        //
        //
        //
        // Calculator Form
        //
        //
        //
        private void AddFormBtn_Click(object sender, EventArgs e)
        {
            AddFormBtn.BackColor = Color.FromArgb(64, 64, 64); ;
            AddFormBtn.ForeColor = Color.White;
            DetailsFormBtn.BackColor = Color.Silver;
            DetailsFormBtn.ForeColor = Color.Black;
            CalculatorFormBtn.BackColor = Color.Silver;
            CalculatorFormBtn.ForeColor = Color.Black;
            AddFormGroupBx.Show();
            DetailFormGroupBx.Hide();
            CalculatorFormGroupBx.Hide();
        }

        private void DetailsFormBtn_Click(object sender, EventArgs e)
        {
            DetailsFormBtn.BackColor = Color.FromArgb(64, 64, 64);
            DetailsFormBtn.ForeColor = Color.White;
            AddFormBtn.BackColor = Color.Silver;
            AddFormBtn.ForeColor = Color.Black;
            CalculatorFormBtn.BackColor = Color.Silver;
            CalculatorFormBtn.ForeColor = Color.Black;
            DetailFormGroupBx.Show();
            AddFormGroupBx.Hide();
            CalculatorFormGroupBx.Hide();
        }

        private void CalculatorFormBtn_Click(object sender, EventArgs e)
        {
            CalculatorFormBtn.BackColor = Color.FromArgb(64, 64, 64);
            CalculatorFormBtn.ForeColor = Color.White;
            AddFormBtn.BackColor = Color.Silver;
            AddFormBtn.ForeColor = Color.Black;
            DetailsFormBtn.BackColor = Color.Silver;
            DetailsFormBtn.ForeColor = Color.Black;
            DetailFormGroupBx.Hide();
            AddFormGroupBx.Hide();
            CalculatorFormGroupBx.Show();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "9";
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!CalTxBx.Text.Contains('.'))
            {
                CalTxBx.Text += ".";
            }
        }
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            OperationChanges("+");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {

            OperationChanges("-");
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {

            OperationChanges("x");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {

            OperationChanges("/");
        }

        private void BtnPosPercent_Click(object sender, EventArgs e)
        {

            OperationChanges("P");
        }

        private void BtnNegPercent_Click(object sender, EventArgs e)
        {

            OperationChanges("L");
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {

            OperationChanges("%");
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "(";
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += ")";
        }

        private void BtnNegTax_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += "R";
        }

        private void BtnTax_Click(object sender, EventArgs e)
        {

            CalTxBx.Text += "T";
        }

        private void BtnNextLine_Click(object sender, EventArgs e)
        {
            CalTxBx.AppendText(Environment.NewLine);
        }

        private void BtnWage_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += MoneyLabel2.Text;
        }

        private void BtnAB_Click(object sender, EventArgs e)
        {
            CalTxBx.Text += MoneyLabel.Text;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            OperationChanges("=");
            try
            {
                Calculator Cal = new Calculator();
                Cal.Tax(CalTxBx.Lines[CalTxBx.Lines.Length - 1]);
                CalTxBx.AppendText(Environment.NewLine);
                CalTxBx.Text += Cal.result;
            }
            catch { }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try 
            { 
                CalTxBx.Text = CalTxBx.Text.Remove(CalTxBx.Text.Length - 1); 
            }
            catch { }
        }

        public void OperationChanges(string Opr)
        {
            try
            {
                bool IsOperation = Regex.IsMatch(Convert.ToString(CalTxBx.Text.Last()), @"[+\-x/%PL]");
                bool Exception = Regex.IsMatch(Convert.ToString(CalTxBx.Text.Last()), @"[TR]");
                bool Exception2 = Regex.IsMatch(Convert.ToString(CalTxBx.Text.Last()), @"[(]");

                if (Exception)
                    CalTxBx.Text = CalTxBx.Text.Remove(CalTxBx.Text.Length - 2,2);
                if (IsOperation)
                {
                    CalTxBx.Text = CalTxBx.Text.Remove(CalTxBx.Text.Length - 1);
                    CalTxBx.Text += Opr;
                }
                if (!IsOperation && !Exception2)
                {
                    CalTxBx.Text += Opr;
                }
            }
            catch { }   
        }
    }
}
