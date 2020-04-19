namespace IE322_App_KAU
{
    partial class frmMain
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
            this.btnRadio = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.BtnMethods = new System.Windows.Forms.Button();
            this.BtnArray = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.grpLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRadio
            // 
            this.btnRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRadio.Location = new System.Drawing.Point(9, 18);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(75, 23);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(71, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPW_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPW_Leave);
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(90, 18);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CheckBox";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCombo.Location = new System.Drawing.Point(54, 50);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnPic
            // 
            this.btnPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPic.Location = new System.Drawing.Point(9, 56);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 6;
            this.btnPic.Text = "PictureBox";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.DarkRed;
            this.btnEXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEXIT.Location = new System.Drawing.Point(2, 304);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(193, 83);
            this.btnEXIT.TabIndex = 8;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(8, 71);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(53, 13);
            this.lblPW.TabIndex = 9;
            this.lblPW.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(91, 98);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPic2
            // 
            this.btnPic2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPic2.Location = new System.Drawing.Point(140, 56);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(75, 23);
            this.btnPic2.TabIndex = 11;
            this.btnPic2.Text = "PictureBox2";
            this.btnPic2.UseVisualStyleBackColor = true;
            this.btnPic2.Click += new System.EventHandler(this.btnPic2_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpLogin.Controls.Add(this.LnkForgot);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.lblPW);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.BtnAbout);
            this.grpLogin.Location = new System.Drawing.Point(2, 13);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(193, 144);
            this.grpLogin.TabIndex = 12;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login to IE322";
            // 
            // LnkForgot
            // 
            this.LnkForgot.Location = new System.Drawing.Point(0, 0);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(100, 23);
            this.LnkForgot.TabIndex = 0;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(0, 0);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnAbout.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(201, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 378);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox10.Controls.Add(this.BtnMethods);
            this.groupBox10.Controls.Add(this.BtnArray);
            this.groupBox10.Location = new System.Drawing.Point(350, 248);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(183, 96);
            this.groupBox10.TabIndex = 32;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Object Oriented";
            // 
            // BtnMethods
            // 
            this.BtnMethods.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnMethods.Location = new System.Drawing.Point(18, 19);
            this.BtnMethods.Name = "BtnMethods";
            this.BtnMethods.Size = new System.Drawing.Size(147, 23);
            this.BtnMethods.TabIndex = 30;
            this.BtnMethods.Text = "Methods";
            this.BtnMethods.UseVisualStyleBackColor = false;
            this.BtnMethods.Click += new System.EventHandler(this.BtnMethods_Click);
            // 
            // BtnArray
            // 
            this.BtnArray.BackColor = System.Drawing.SystemColors.Control;
            this.BtnArray.Location = new System.Drawing.Point(16, 47);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(149, 39);
            this.BtnArray.TabIndex = 29;
            this.BtnArray.Text = "Arrays";
            this.BtnArray.UseVisualStyleBackColor = false;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox4.Controls.Add(this.btnRandom);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(5, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(235, 112);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.Location = new System.Drawing.Point(9, 48);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 15;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(140, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "RandomCombo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Controls.Add(this.btnPic);
            this.groupBox3.Controls.Add(this.btnPic2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(5, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(235, 125);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Controls.Add(this.btnRadio);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.btnCombo);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(350, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(183, 76);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // StsMain
            // 
            this.StsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StsMain.Location = new System.Drawing.Point(0, 393);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(762, 22);
            this.StsMain.TabIndex = 16;
            this.StsMain.Text = "Dr. Atif Shahzad";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 415);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnEXIT);
            this.Name = "frmMain";
            this.Text = "ayed Labwork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.Button BtnMethods;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}