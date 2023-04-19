namespace OculusAccountSwapper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usernames = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logout = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.usernames.TabIndex = 18;
            this.usernames.Text = "Saved Accounts:";
            this.usernames.UseCompatibleTextRendering = true;
            this.usernames.Click += new System.EventHandler(this.usernames_Click);
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
            this.comboBox1.TabIndex = 5;
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
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseCompatibleTextRendering = true;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseEnter += new System.EventHandler(this.logout_MouseEnter);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            // 
            // signin
            // 
            this.signin.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.LightGray;
            this.signin.Image = ((System.Drawing.Image)(resources.GetObject("signin.Image")));
            this.signin.Location = new System.Drawing.Point(63, 311);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(97, 47);
            this.signin.TabIndex = 6;
            this.signin.Text = "Sign In";
            this.signin.UseCompatibleTextRendering = true;
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click_1);
            this.signin.MouseEnter += new System.EventHandler(this.signin_MouseEnter);
            this.signin.MouseLeave += new System.EventHandler(this.signin_MouseLeave);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.LightGray;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(181, 180);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 47);
            this.add.TabIndex = 4;
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
            this.label3.TabIndex = 22;
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
            this.label2.TabIndex = 23;
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
            this.label1.TabIndex = 24;
            this.label1.Text = "Username:";
            this.label1.UseCompatibleTextRendering = true;
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
            this.textBox3.TabIndex = 2;
            this.textBox3.UseSystemPasswordChar = true;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.showpass);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 614);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.LightGray;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(335, 376);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(97, 47);
            this.home.TabIndex = 33;
            this.home.Text = "Back To Home";
            this.home.UseCompatibleTextRendering = true;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(335, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 32;
            this.button1.Text = "Version Swapper";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
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
            this.showpass.TabIndex = 0;
            this.showpass.Text = "Show Password";
            this.showpass.UseCompatibleTextRendering = true;
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.LightGray;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Location = new System.Drawing.Point(63, 374);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(97, 47);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit Accounts";
            this.edit.UseCompatibleTextRendering = true;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button1_Click_1);
            this.edit.MouseEnter += new System.EventHandler(this.edit_MouseEnter);
            this.edit.MouseLeave += new System.EventHandler(this.edit_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 613);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.usernames);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oculus Account Manager";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernames;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button home;
    }
}

