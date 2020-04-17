namespace Yousef_IE322_P1
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
            this.picLogo_IE = new System.Windows.Forms.PictureBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.BtnArray = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.BtnClasses = new System.Windows.Forms.Button();
            this.BtnMethods = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_IE)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo_IE
            // 
            this.picLogo_IE.Image = global::Yousef_IE322_P1.Properties.Resources.IE_LOGO4_19112019;
            this.picLogo_IE.Location = new System.Drawing.Point(64, 160);
            this.picLogo_IE.Name = "picLogo_IE";
            this.picLogo_IE.Size = new System.Drawing.Size(149, 137);
            this.picLogo_IE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo_IE.TabIndex = 37;
            this.picLogo_IE.TabStop = false;
            this.picLogo_IE.Click += new System.EventHandler(this.picLogo_IE_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.LnkForgot);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.lblPW);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.BtnAbout);
            this.grpLogin.Location = new System.Drawing.Point(42, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(193, 144);
            this.grpLogin.TabIndex = 36;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login to IE322";
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.Location = new System.Drawing.Point(8, 124);
            this.LnkForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(93, 13);
            this.LnkForgot.TabIndex = 11;
            this.LnkForgot.TabStop = true;
            this.LnkForgot.Text = "Forgot password?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(91, 98);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
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
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(71, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnAbout.Location = new System.Drawing.Point(10, 98);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnAbout.TabIndex = 11;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.Orange;
            this.btnEXIT.Location = new System.Drawing.Point(42, 303);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(193, 83);
            this.btnEXIT.TabIndex = 35;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnCombo);
            this.groupBox9.Controls.Add(this.btnRadio);
            this.groupBox9.Controls.Add(this.btnCheck);
            this.groupBox9.Location = new System.Drawing.Point(309, 40);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(191, 80);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Basic Controls";
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(59, 44);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(59, 26);
            this.btnCombo.TabIndex = 34;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(14, 15);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(75, 23);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(101, 14);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CheckBox";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(586, 110);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(162, 39);
            this.BtnArray.TabIndex = 38;
            this.BtnArray.Text = "Arrays";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.BtnClasses);
            this.groupBox10.Controls.Add(this.BtnMethods);
            this.groupBox10.Location = new System.Drawing.Point(586, 202);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(162, 81);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Object Oriented";
            // 
            // BtnClasses
            // 
            this.BtnClasses.Location = new System.Drawing.Point(6, 41);
            this.BtnClasses.Name = "BtnClasses";
            this.BtnClasses.Size = new System.Drawing.Size(147, 23);
            this.BtnClasses.TabIndex = 31;
            this.BtnClasses.Text = "Classes";
            this.BtnClasses.UseVisualStyleBackColor = true;
            this.BtnClasses.Click += new System.EventHandler(this.BtnClasses_Click);
            // 
            // BtnMethods
            // 
            this.BtnMethods.Location = new System.Drawing.Point(6, 17);
            this.BtnMethods.Name = "BtnMethods";
            this.BtnMethods.Size = new System.Drawing.Size(147, 23);
            this.BtnMethods.TabIndex = 30;
            this.BtnMethods.Text = "Methods";
            this.BtnMethods.UseVisualStyleBackColor = true;
            this.BtnMethods.Click += new System.EventHandler(this.BtnMethods_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button4);
            this.groupBox13.Controls.Add(this.button5);
            this.groupBox13.Location = new System.Drawing.Point(311, 257);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(189, 74);
            this.groupBox13.TabIndex = 42;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "More Controls";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(105, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "RandomCombo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Random";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.button3);
            this.groupBox12.Location = new System.Drawing.Point(309, 153);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(191, 71);
            this.groupBox12.TabIndex = 41;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Graphical";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "PictureBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "PictureBox2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLogo_IE);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.groupBox10);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_IE)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo_IE;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button BtnClasses;
        private System.Windows.Forms.Button BtnMethods;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}