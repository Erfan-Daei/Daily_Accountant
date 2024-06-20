namespace Accountant.UI
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GoToSignInLink = new System.Windows.Forms.LinkLabel();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.Enter_To_Account_Label = new System.Windows.Forms.Label();
            this.PassChkBx = new System.Windows.Forms.CheckBox();
            this.UsernameError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.CodePanel = new System.Windows.Forms.Panel();
            this.ResendBtn = new System.Windows.Forms.Button();
            this.LogInBtn2 = new System.Windows.Forms.Button();
            this.WrongCodeLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.TextBox();
            this.Num4 = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInPanel.SuspendLayout();
            this.CodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoToSignInLink
            // 
            this.GoToSignInLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToSignInLink.LinkColor = System.Drawing.Color.Gray;
            this.GoToSignInLink.Location = new System.Drawing.Point(76, 310);
            this.GoToSignInLink.MaximumSize = new System.Drawing.Size(300, 20);
            this.GoToSignInLink.MinimumSize = new System.Drawing.Size(300, 20);
            this.GoToSignInLink.Name = "GoToSignInLink";
            this.GoToSignInLink.Size = new System.Drawing.Size(300, 20);
            this.GoToSignInLink.TabIndex = 15;
            this.GoToSignInLink.TabStop = true;
            this.GoToSignInLink.Text = "DON\'T HAVE ACCOUNT? SIGNUP HERE";
            this.GoToSignInLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoToSignInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToSignInLink_LinkClicked);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInBtn.BackColor = System.Drawing.Color.Silver;
            this.LogInBtn.Location = new System.Drawing.Point(176, 260);
            this.LogInBtn.MaximumSize = new System.Drawing.Size(100, 40);
            this.LogInBtn.MinimumSize = new System.Drawing.Size(100, 40);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(100, 40);
            this.LogInBtn.TabIndex = 14;
            this.LogInBtn.Text = "LOGIN";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInTB_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTB.Location = new System.Drawing.Point(126, 210);
            this.PasswordTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.PasswordTB.MaxLength = 16;
            this.PasswordTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.PlaceholderText = "PASSWORD*";
            this.PasswordTB.Size = new System.Drawing.Size(200, 30);
            this.PasswordTB.TabIndex = 11;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTB.Location = new System.Drawing.Point(126, 160);
            this.UsernameTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.UsernameTB.MaxLength = 20;
            this.UsernameTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PlaceholderText = "USERNAME*";
            this.UsernameTB.Size = new System.Drawing.Size(200, 30);
            this.UsernameTB.TabIndex = 10;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // Enter_To_Account_Label
            // 
            this.Enter_To_Account_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Enter_To_Account_Label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enter_To_Account_Label.Location = new System.Drawing.Point(101, 110);
            this.Enter_To_Account_Label.MaximumSize = new System.Drawing.Size(250, 25);
            this.Enter_To_Account_Label.MinimumSize = new System.Drawing.Size(250, 25);
            this.Enter_To_Account_Label.Name = "Enter_To_Account_Label";
            this.Enter_To_Account_Label.Size = new System.Drawing.Size(250, 25);
            this.Enter_To_Account_Label.TabIndex = 16;
            this.Enter_To_Account_Label.Text = "ENTER TO YOUR ACCOUNT";
            this.Enter_To_Account_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassChkBx
            // 
            this.PassChkBx.AutoSize = true;
            this.PassChkBx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassChkBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassChkBx.Location = new System.Drawing.Point(332, 216);
            this.PassChkBx.Name = "PassChkBx";
            this.PassChkBx.Size = new System.Drawing.Size(68, 21);
            this.PassChkBx.TabIndex = 17;
            this.PassChkBx.Text = "SHOW";
            this.PassChkBx.UseVisualStyleBackColor = true;
            this.PassChkBx.CheckedChanged += new System.EventHandler(this.PassChkBx_CheckedChanged);
            // 
            // UsernameError
            // 
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(126, 191);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.Size = new System.Drawing.Size(200, 17);
            this.UsernameError.TabIndex = 18;
            // 
            // PasswordError
            // 
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(126, 241);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(200, 17);
            this.PasswordError.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(0, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(458, 25);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FORGET YOUR PASSWORD? USE ONE-TIME PASWORD HERE !";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LogInPanel
            // 
            this.LogInPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogInPanel.Controls.Add(this.Enter_To_Account_Label);
            this.LogInPanel.Controls.Add(this.linkLabel1);
            this.LogInPanel.Controls.Add(this.UsernameTB);
            this.LogInPanel.Controls.Add(this.PasswordError);
            this.LogInPanel.Controls.Add(this.PasswordTB);
            this.LogInPanel.Controls.Add(this.UsernameError);
            this.LogInPanel.Controls.Add(this.LogInBtn);
            this.LogInPanel.Controls.Add(this.PassChkBx);
            this.LogInPanel.Controls.Add(this.GoToSignInLink);
            this.LogInPanel.Location = new System.Drawing.Point(12, 12);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(458, 479);
            this.LogInPanel.TabIndex = 22;
            // 
            // CodePanel
            // 
            this.CodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodePanel.Controls.Add(this.ResendBtn);
            this.CodePanel.Controls.Add(this.LogInBtn2);
            this.CodePanel.Controls.Add(this.WrongCodeLabel);
            this.CodePanel.Controls.Add(this.BackBtn);
            this.CodePanel.Controls.Add(this.Num5);
            this.CodePanel.Controls.Add(this.Num4);
            this.CodePanel.Controls.Add(this.Num3);
            this.CodePanel.Controls.Add(this.Num2);
            this.CodePanel.Controls.Add(this.Num1);
            this.CodePanel.Controls.Add(this.label2);
            this.CodePanel.Location = new System.Drawing.Point(12, 12);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(458, 479);
            this.CodePanel.TabIndex = 23;
            // 
            // ResendBtn
            // 
            this.ResendBtn.BackColor = System.Drawing.Color.Silver;
            this.ResendBtn.Enabled = false;
            this.ResendBtn.Location = new System.Drawing.Point(176, 352);
            this.ResendBtn.Name = "ResendBtn";
            this.ResendBtn.Size = new System.Drawing.Size(94, 40);
            this.ResendBtn.TabIndex = 18;
            this.ResendBtn.Text = "RESEND";
            this.ResendBtn.UseVisualStyleBackColor = false;
            this.ResendBtn.Visible = false;
            this.ResendBtn.Click += new System.EventHandler(this.ResendBtn_Click);
            // 
            // LogInBtn2
            // 
            this.LogInBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInBtn2.BackColor = System.Drawing.Color.Silver;
            this.LogInBtn2.Location = new System.Drawing.Point(247, 296);
            this.LogInBtn2.MaximumSize = new System.Drawing.Size(100, 40);
            this.LogInBtn2.MinimumSize = new System.Drawing.Size(100, 40);
            this.LogInBtn2.Name = "LogInBtn2";
            this.LogInBtn2.Size = new System.Drawing.Size(100, 40);
            this.LogInBtn2.TabIndex = 15;
            this.LogInBtn2.Text = "LOGIN";
            this.LogInBtn2.UseVisualStyleBackColor = false;
            this.LogInBtn2.Click += new System.EventHandler(this.LogInBtn2_Click);
            // 
            // WrongCodeLabel
            // 
            this.WrongCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongCodeLabel.Location = new System.Drawing.Point(98, 258);
            this.WrongCodeLabel.Name = "WrongCodeLabel";
            this.WrongCodeLabel.Size = new System.Drawing.Size(250, 25);
            this.WrongCodeLabel.TabIndex = 17;
            this.WrongCodeLabel.Text = "Wrong Input";
            this.WrongCodeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WrongCodeLabel.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Silver;
            this.BackBtn.Location = new System.Drawing.Point(98, 297);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 40);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num5.Location = new System.Drawing.Point(303, 228);
            this.Num5.MaxLength = 1;
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(45, 27);
            this.Num5.TabIndex = 14;
            this.Num5.TextChanged += new System.EventHandler(this.Num5_TextChanged);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num4.Location = new System.Drawing.Point(252, 228);
            this.Num4.MaxLength = 1;
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(45, 27);
            this.Num4.TabIndex = 13;
            this.Num4.TextChanged += new System.EventHandler(this.Num4_TextChanged);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num3.Location = new System.Drawing.Point(201, 228);
            this.Num3.MaxLength = 1;
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(45, 27);
            this.Num3.TabIndex = 12;
            this.Num3.TextChanged += new System.EventHandler(this.Num3_TextChanged);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num2.Location = new System.Drawing.Point(150, 228);
            this.Num2.MaxLength = 1;
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(45, 27);
            this.Num2.TabIndex = 11;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num1.Location = new System.Drawing.Point(98, 228);
            this.Num1.MaxLength = 1;
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(45, 27);
            this.Num1.TabIndex = 10;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 71);
            this.label2.TabIndex = 9;
            this.label2.Text = "WE HAVE SENT CODE TO YOUR EMAIL: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.LogInPanel);
            this.Controls.Add(this.CodePanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.CodePanel.ResumeLayout(false);
            this.CodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LinkLabel GoToSignInLink;
        private Button LogInBtn;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Label Enter_To_Account_Label;
        private CheckBox PassChkBx;
        public Label UsernameError;
        public Label PasswordError;
        private LinkLabel linkLabel1;
        private Panel LogInPanel;
        private Panel CodePanel;
        private Button LogInBtn2;
        private Label WrongCodeLabel;
        private Button BackBtn;
        private TextBox Num5;
        private TextBox Num4;
        private TextBox Num3;
        private TextBox Num2;
        private TextBox Num1;
        private Label label2;
        private Button ResendBtn;
    }
}