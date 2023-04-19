namespace OculusAccountSwapper
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usernames = new System.Windows.Forms.Label();
            this.metamerge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // usernames
            // 
            this.usernames.AutoSize = true;
            this.usernames.BackColor = System.Drawing.Color.Transparent;
            this.usernames.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernames.ForeColor = System.Drawing.Color.DarkGray;
            this.usernames.Location = new System.Drawing.Point(92, 242);
            this.usernames.Name = "usernames";
            this.usernames.Size = new System.Drawing.Size(138, 29);
            this.usernames.TabIndex = 19;
            this.usernames.Text = "Saved Accounts:";
            this.usernames.UseCompatibleTextRendering = true;
            this.usernames.Click += new System.EventHandler(this.usernames_Click);
            // 
            // metamerge
            // 
            this.metamerge.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metamerge.ForeColor = System.Drawing.Color.LightGray;
            this.metamerge.Image = ((System.Drawing.Image)(resources.GetObject("metamerge.Image")));
            this.metamerge.Location = new System.Drawing.Point(63, 343);
            this.metamerge.Name = "metamerge";
            this.metamerge.Size = new System.Drawing.Size(145, 83);
            this.metamerge.TabIndex = 54;
            this.metamerge.Text = "Meta Merge";
            this.metamerge.UseVisualStyleBackColor = true;
            this.metamerge.Click += new System.EventHandler(this.metamerge_Click);
            this.metamerge.MouseEnter += new System.EventHandler(this.metamerge_MouseEnter);
            this.metamerge.MouseLeave += new System.EventHandler(this.metamerge_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(92, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 47);
            this.label1.TabIndex = 55;
            this.label1.Text = "Choose your account!";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(273, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 83);
            this.button1.TabIndex = 56;
            this.button1.Text = "Back To Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.ClientSize = new System.Drawing.Size(464, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metamerge);
            this.Controls.Add(this.usernames);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meta Merge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label usernames;
        private System.Windows.Forms.Button metamerge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}