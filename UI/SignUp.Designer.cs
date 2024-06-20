namespace Accountant.UI
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ConPasswordTB = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.GoToLogInLink = new System.Windows.Forms.LinkLabel();
            this.Creat_Account_Label = new System.Windows.Forms.Label();
            this.PassChkBx = new System.Windows.Forms.CheckBox();
            this.PassChkBx2 = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UsernameError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.ConPasswordError = new System.Windows.Forms.Label();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.NextBtn = new System.Windows.Forms.Button();
            this.GetEmailPanel = new System.Windows.Forms.Panel();
            this.NextBtn2 = new System.Windows.Forms.Button();
            this.WrongEmailLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetCodePanel = new System.Windows.Forms.Panel();
            this.ResendBtn = new System.Windows.Forms.Button();
            this.WrongCodeLabel = new System.Windows.Forms.Label();
            this.BackBtn2 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.TextBox();
            this.Num4 = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DetailPanel.SuspendLayout();
            this.GetEmailPanel.SuspendLayout();
            this.GetCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTB.Location = new System.Drawing.Point(122, 96);
            this.NameTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.NameTB.MaxLength = 20;
            this.NameTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.NameTB.Name = "NameTB";
            this.NameTB.PlaceholderText = "NAME";
            this.NameTB.Size = new System.Drawing.Size(200, 30);
            this.NameTB.TabIndex = 0;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameTB.Location = new System.Drawing.Point(122, 146);
            this.LastNameTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.LastNameTB.MaxLength = 20;
            this.LastNameTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.PlaceholderText = "LAST NAME";
            this.LastNameTB.Size = new System.Drawing.Size(200, 30);
            this.LastNameTB.TabIndex = 1;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTB.Location = new System.Drawing.Point(122, 196);
            this.UsernameTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.UsernameTB.MaxLength = 20;
            this.UsernameTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PlaceholderText = "USERNAME*";
            this.UsernameTB.Size = new System.Drawing.Size(200, 30);
            this.UsernameTB.TabIndex = 2;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.AccessibleDescription = "";
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTB.Location = new System.Drawing.Point(122, 246);
            this.PasswordTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.PasswordTB.MaxLength = 16;
            this.PasswordTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.PlaceholderText = "PASSWORD*";
            this.PasswordTB.Size = new System.Drawing.Size(200, 30);
            this.PasswordTB.TabIndex = 3;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.PasswordTB.MouseHover += new System.EventHandler(this.PasswordTB_MouseHover);
            // 
            // ConPasswordTB
            // 
            this.ConPasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConPasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConPasswordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConPasswordTB.Location = new System.Drawing.Point(122, 296);
            this.ConPasswordTB.MaximumSize = new System.Drawing.Size(200, 0);
            this.ConPasswordTB.MaxLength = 16;
            this.ConPasswordTB.MinimumSize = new System.Drawing.Size(200, 0);
            this.ConPasswordTB.Name = "ConPasswordTB";
            this.ConPasswordTB.PasswordChar = '*';
            this.ConPasswordTB.PlaceholderText = "CONFIRM PASSWORD*";
            this.ConPasswordTB.Size = new System.Drawing.Size(200, 30);
            this.ConPasswordTB.TabIndex = 4;
            this.ConPasswordTB.TextChanged += new System.EventHandler(this.ConPasswordTB_TextChanged);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpBtn.BackColor = System.Drawing.Color.Silver;
            this.SignUpBtn.Location = new System.Drawing.Point(247, 252);
            this.SignUpBtn.MaximumSize = new System.Drawing.Size(100, 40);
            this.SignUpBtn.MinimumSize = new System.Drawing.Size(100, 40);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(100, 40);
            this.SignUpBtn.TabIndex = 6;
            this.SignUpBtn.Text = "SIGNUP";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // GoToLogInLink
            // 
            this.GoToLogInLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToLogInLink.LinkColor = System.Drawing.Color.Gray;
            this.GoToLogInLink.Location = new System.Drawing.Point(72, 401);
            this.GoToLogInLink.MaximumSize = new System.Drawing.Size(300, 20);
            this.GoToLogInLink.MinimumSize = new System.Drawing.Size(300, 20);
            this.GoToLogInLink.Name = "GoToLogInLink";
            this.GoToLogInLink.Size = new System.Drawing.Size(300, 20);
            this.GoToLogInLink.TabIndex = 7;
            this.GoToLogInLink.TabStop = true;
            this.GoToLogInLink.Text = "ALREADY HAVE ACCOUNT? LOGIN HERE";
            this.GoToLogInLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoToLogInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToLogInLink_LinkClicked);
            // 
            // Creat_Account_Label
            // 
            this.Creat_Account_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Creat_Account_Label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Creat_Account_Label.Location = new System.Drawing.Point(97, 36);
            this.Creat_Account_Label.MaximumSize = new System.Drawing.Size(250, 25);
            this.Creat_Account_Label.MinimumSize = new System.Drawing.Size(250, 25);
            this.Creat_Account_Label.Name = "Creat_Account_Label";
            this.Creat_Account_Label.Size = new System.Drawing.Size(250, 25);
            this.Creat_Account_Label.TabIndex = 8;
            this.Creat_Account_Label.Text = "CREATE NEW ACCOUNT";
            this.Creat_Account_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassChkBx
            // 
            this.PassChkBx.AutoSize = true;
            this.PassChkBx.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassChkBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassChkBx.Location = new System.Drawing.Point(328, 252);
            this.PassChkBx.Name = "PassChkBx";
            this.PassChkBx.Size = new System.Drawing.Size(68, 21);
            this.PassChkBx.TabIndex = 10;
            this.PassChkBx.Text = "SHOW";
            this.PassChkBx.UseVisualStyleBackColor = true;
            this.PassChkBx.CheckedChanged += new System.EventHandler(this.PassChkBx_CheckedChanged);
            // 
            // PassChkBx2
            // 
            this.PassChkBx2.AutoSize = true;
            this.PassChkBx2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassChkBx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassChkBx2.Location = new System.Drawing.Point(328, 302);
            this.PassChkBx2.Name = "PassChkBx2";
            this.PassChkBx2.Size = new System.Drawing.Size(68, 21);
            this.PassChkBx2.TabIndex = 11;
            this.PassChkBx2.Text = "SHOW";
            this.PassChkBx2.UseVisualStyleBackColor = true;
            this.PassChkBx2.CheckedChanged += new System.EventHandler(this.PassChkBx2_CheckedChanged);
            // 
            // UsernameError
            // 
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(122, 227);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.Size = new System.Drawing.Size(209, 17);
            this.UsernameError.TabIndex = 12;
            // 
            // PasswordError
            // 
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(122, 277);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(200, 17);
            this.PasswordError.TabIndex = 13;
            // 
            // ConPasswordError
            // 
            this.ConPasswordError.ForeColor = System.Drawing.Color.Red;
            this.ConPasswordError.Location = new System.Drawing.Point(122, 327);
            this.ConPasswordError.Name = "ConPasswordError";
            this.ConPasswordError.Size = new System.Drawing.Size(209, 22);
            this.ConPasswordError.TabIndex = 14;
            // 
            // DetailPanel
            // 
            this.DetailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailPanel.Controls.Add(this.NextBtn);
            this.DetailPanel.Controls.Add(this.Creat_Account_Label);
            this.DetailPanel.Controls.Add(this.ConPasswordError);
            this.DetailPanel.Controls.Add(this.NameTB);
            this.DetailPanel.Controls.Add(this.PasswordError);
            this.DetailPanel.Controls.Add(this.LastNameTB);
            this.DetailPanel.Controls.Add(this.UsernameError);
            this.DetailPanel.Controls.Add(this.UsernameTB);
            this.DetailPanel.Controls.Add(this.PassChkBx2);
            this.DetailPanel.Controls.Add(this.PasswordTB);
            this.DetailPanel.Controls.Add(this.PassChkBx);
            this.DetailPanel.Controls.Add(this.ConPasswordTB);
            this.DetailPanel.Controls.Add(this.GoToLogInLink);
            this.DetailPanel.Location = new System.Drawing.Point(12, 12);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(458, 479);
            this.DetailPanel.TabIndex = 15;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Silver;
            this.NextBtn.Location = new System.Drawing.Point(169, 352);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(94, 40);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "NEXT";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // GetEmailPanel
            // 
            this.GetEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GetEmailPanel.Controls.Add(this.NextBtn2);
            this.GetEmailPanel.Controls.Add(this.WrongEmailLabel);
            this.GetEmailPanel.Controls.Add(this.BackBtn);
            this.GetEmailPanel.Controls.Add(this.EmailTB);
            this.GetEmailPanel.Controls.Add(this.label1);
            this.GetEmailPanel.Location = new System.Drawing.Point(12, 12);
            this.GetEmailPanel.Name = "GetEmailPanel";
            this.GetEmailPanel.Size = new System.Drawing.Size(458, 479);
            this.GetEmailPanel.TabIndex = 15;
            // 
            // NextBtn2
            // 
            this.NextBtn2.BackColor = System.Drawing.Color.Silver;
            this.NextBtn2.Location = new System.Drawing.Point(228, 277);
            this.NextBtn2.Name = "NextBtn2";
            this.NextBtn2.Size = new System.Drawing.Size(94, 40);
            this.NextBtn2.TabIndex = 7;
            this.NextBtn2.Text = "NEXT";
            this.NextBtn2.UseVisualStyleBackColor = false;
            this.NextBtn2.Click += new System.EventHandler(this.NextBtn2_Click);
            // 
            // WrongEmailLabel
            // 
            this.WrongEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongEmailLabel.Location = new System.Drawing.Point(122, 224);
            this.WrongEmailLabel.Name = "WrongEmailLabel";
            this.WrongEmailLabel.Size = new System.Drawing.Size(200, 25);
            this.WrongEmailLabel.TabIndex = 4;
            this.WrongEmailLabel.Text = "Wrong Email Type";
            this.WrongEmailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WrongEmailLabel.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Silver;
            this.BackBtn.Location = new System.Drawing.Point(122, 277);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 40);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EmailTB
            // 
            this.EmailTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTB.Location = new System.Drawing.Point(122, 196);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.PlaceholderText = "Email";
            this.EmailTB.Size = new System.Drawing.Size(200, 27);
            this.EmailTB.TabIndex = 1;
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "WRITE DOWN YOUR EMAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetCodePanel
            // 
            this.GetCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GetCodePanel.Controls.Add(this.ResendBtn);
            this.GetCodePanel.Controls.Add(this.SignUpBtn);
            this.GetCodePanel.Controls.Add(this.WrongCodeLabel);
            this.GetCodePanel.Controls.Add(this.BackBtn2);
            this.GetCodePanel.Controls.Add(this.Num5);
            this.GetCodePanel.Controls.Add(this.Num4);
            this.GetCodePanel.Controls.Add(this.Num3);
            this.GetCodePanel.Controls.Add(this.Num2);
            this.GetCodePanel.Controls.Add(this.Num1);
            this.GetCodePanel.Controls.Add(this.label2);
            this.GetCodePanel.Location = new System.Drawing.Point(12, 12);
            this.GetCodePanel.Name = "GetCodePanel";
            this.GetCodePanel.Size = new System.Drawing.Size(458, 479);
            this.GetCodePanel.TabIndex = 16;
            // 
            // ResendBtn
            // 
            this.ResendBtn.BackColor = System.Drawing.Color.Silver;
            this.ResendBtn.Enabled = false;
            this.ResendBtn.Location = new System.Drawing.Point(169, 309);
            this.ResendBtn.Name = "ResendBtn";
            this.ResendBtn.Size = new System.Drawing.Size(94, 40);
            this.ResendBtn.TabIndex = 19;
            this.ResendBtn.Text = "RESEND";
            this.ResendBtn.UseVisualStyleBackColor = false;
            this.ResendBtn.Visible = false;
            this.ResendBtn.Click += new System.EventHandler(this.ResendBtn_Click);
            // 
            // WrongCodeLabel
            // 
            this.WrongCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongCodeLabel.Location = new System.Drawing.Point(98, 213);
            this.WrongCodeLabel.Name = "WrongCodeLabel";
            this.WrongCodeLabel.Size = new System.Drawing.Size(250, 25);
            this.WrongCodeLabel.TabIndex = 8;
            this.WrongCodeLabel.Text = "Wrong Input";
            this.WrongCodeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WrongCodeLabel.Visible = false;
            // 
            // BackBtn2
            // 
            this.BackBtn2.BackColor = System.Drawing.Color.Silver;
            this.BackBtn2.Location = new System.Drawing.Point(98, 252);
            this.BackBtn2.Name = "BackBtn2";
            this.BackBtn2.Size = new System.Drawing.Size(94, 40);
            this.BackBtn2.TabIndex = 6;
            this.BackBtn2.Text = "BACK";
            this.BackBtn2.UseVisualStyleBackColor = false;
            this.BackBtn2.Click += new System.EventHandler(this.BackBtn2_Click);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num5.Location = new System.Drawing.Point(303, 183);
            this.Num5.MaxLength = 1;
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(45, 27);
            this.Num5.TabIndex = 5;
            this.Num5.TextChanged += new System.EventHandler(this.Num5_TextChanged);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num4.Location = new System.Drawing.Point(252, 183);
            this.Num4.MaxLength = 1;
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(45, 27);
            this.Num4.TabIndex = 4;
            this.Num4.TextChanged += new System.EventHandler(this.Num4_TextChanged);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num3.Location = new System.Drawing.Point(201, 183);
            this.Num3.MaxLength = 1;
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(45, 27);
            this.Num3.TabIndex = 3;
            this.Num3.TextChanged += new System.EventHandler(this.Num3_TextChanged);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num2.Location = new System.Drawing.Point(150, 183);
            this.Num2.MaxLength = 1;
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(45, 27);
            this.Num2.TabIndex = 2;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num1.Location = new System.Drawing.Point(98, 183);
            this.Num1.MaxLength = 1;
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(45, 27);
            this.Num1.TabIndex = 1;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "WE HAVE SENT CODE TO YOUR EMAIL: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.DetailPanel);
            this.Controls.Add(this.GetCodePanel);
            this.Controls.Add(this.GetEmailPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            this.GetEmailPanel.ResumeLayout(false);
            this.GetEmailPanel.PerformLayout();
            this.GetCodePanel.ResumeLayout(false);
            this.GetCodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox NameTB;
        private TextBox LastNameTB;
        private TextBox UsernameTB;
        private TextBox PasswordTB;
        private TextBox ConPasswordTB;
        private Button SignUpBtn;
        private LinkLabel GoToLogInLink;
        private Label Creat_Account_Label;
        private CheckBox PassChkBx;
        private CheckBox PassChkBx2;
        private ToolTip toolTip;
        private Label UsernameError;
        private Label PasswordError;
        private Label ConPasswordError;
        private Panel DetailPanel;
        private Panel GetEmailPanel;
        private Button BackBtn;
        private Button NextBtn;
        private TextBox EmailTB;
        private Label label1;
        private Panel GetCodePanel;
        private TextBox Num5;
        private TextBox Num4;
        private TextBox Num3;
        private TextBox Num2;
        private TextBox Num1;
        private Label label2;
        private Label WrongCodeLabel;
        private Button NextBtn2;
        private Button BackBtn2;
        private Label WrongEmailLabel;
        private Button ResendBtn;
    }
}