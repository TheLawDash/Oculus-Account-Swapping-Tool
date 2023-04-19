namespace OculusAccountSwapper
{
    partial class AccountViewer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(794, 852);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.showpass.Location = new System.Drawing.Point(22, 881);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(101, 28);
            this.showpass.TabIndex = 46;
            this.showpass.Text = "Show Password";
            this.showpass.UseCompatibleTextRendering = true;
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.FlatAppearance.BorderSize = 2;
            this.checkBox1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(22, 926);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 28);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Meta Account     ";
            this.checkBox1.UseCompatibleTextRendering = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AccountViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 1031);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AccountViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Viewer";
            this.Load += new System.EventHandler(this.AccountViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}