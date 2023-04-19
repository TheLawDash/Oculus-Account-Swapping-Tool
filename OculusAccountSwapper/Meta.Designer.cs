namespace OculusAccountSwapper
{
    partial class Meta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meta));
            this.button1 = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.usernames = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logout = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.oculus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(63, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 32;
            this.button1.Text = "Edit Accounts";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.edit_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.edit_MouseLeave);
            // 
            // signin
            // 
            this.signin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.LightGray;
            this.signin.Image = ((System.Drawing.Image)(resources.GetObject("signin.Image")));
            this.signin.Location = new System.Drawing.Point(63, 311);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(97, 47);
            this.signin.TabIndex = 33;
            this.signin.Text = "Sign In";
            this.signin.UseCompatibleTextRendering = true;
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click_1);
            this.signin.MouseEnter += new System.EventHandler(this.signin_MouseEnter);
            this.signin.MouseLeave += new System.EventHandler(this.signin_MouseLeave);
            // 
            // usernames
            // 
            this.usernames.AutoSize = true;
            this.usernames.BackColor = System.Drawing.Color.Transparent;
            this.usernames.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernames.ForeColor = System.Drawing.Color.DarkGray;
            this.usernames.Location = new System.Drawing.Point(46, 273);
            this.usernames.Name = "usernames";
            this.usernames.Size = new System.Drawing.Size(138, 29);
            this.usernames.TabIndex = 35;
            this.usernames.Text = "Saved Accounts:";
            this.usernames.UseCompatibleTextRendering = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.LightGray;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(63, 180);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(97, 47);
            this.logout.TabIndex = 37;
            this.logout.Text = "Log Out";
            this.logout.UseCompatibleTextRendering = true;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseEnter += new System.EventHandler(this.logout_MouseEnter);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.LightGray;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(181, 180);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 47);
            this.add.TabIndex = 38;
            this.add.Text = "Add New Account";
            this.add.UseCompatibleTextRendering = true;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.MouseEnter += new System.EventHandler(this.add_MouseEnter);
            this.add.MouseLeave += new System.EventHandler(this.add_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(81, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(111, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Email:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Username:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(181, 65);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 23);
            this.textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(181, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 23);
            this.textBox2.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(181, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 23);
            this.textBox3.TabIndex = 44;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // showpass
            // 
            this.showpass.Appearance = System.Windows.Forms.Appearance.Button;
            this.showpass.AutoSize = true;
            this.showpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.showpass.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.showpass.FlatAppearance.BorderSize = 2;
            this.showpass.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.ForeColor = System.Drawing.Color.Black;
            this.showpass.Location = new System.Drawing.Point(308, 141);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(101, 28);
            this.showpass.TabIndex = 45;
            this.showpass.Text = "Show Password";
            this.showpass.UseCompatibleTextRendering = true;
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(312, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 47);
            this.button2.TabIndex = 46;
            this.button2.Text = "Version Swapper";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.versionswap_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // oculus
            // 
            this.oculus.Appearance = System.Windows.Forms.Appearance.Button;
            this.oculus.AutoSize = true;
            this.oculus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oculus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.oculus.FlatAppearance.BorderSize = 2;
            this.oculus.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oculus.ForeColor = System.Drawing.Color.Black;
            this.oculus.Location = new System.Drawing.Point(342, 272);
            this.oculus.Name = "oculus";
            this.oculus.Size = new System.Drawing.Size(89, 28);
            this.oculus.TabIndex = 47;
            this.oculus.Text = "Meta Account";
            this.oculus.UseCompatibleTextRendering = true;
            this.oculus.UseVisualStyleBackColor = false;
            this.oculus.CheckedChanged += new System.EventHandler(this.oculus_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(350, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Account type";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.LightGray;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(312, 374);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(97, 47);
            this.home.TabIndex = 49;
            this.home.Text = "Back To Home";
            this.home.UseCompatibleTextRendering = true;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Meta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.ClientSize = new System.Drawing.Size(464, 614);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oculus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.usernames);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Meta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meta Account Swapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Meta_FormClosed);
            this.Load += new System.EventHandler(this.Meta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label usernames;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox oculus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button home;
    }
}