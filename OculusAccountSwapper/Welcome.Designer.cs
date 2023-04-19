namespace OculusAccountSwapper
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.oculus = new System.Windows.Forms.Button();
            this.meta = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metamerge = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 126);
            this.label1.TabIndex = 25;
            this.label1.Text = "Welcome to Oculus\r\nAccount Tools!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oculus
            // 
            this.oculus.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oculus.ForeColor = System.Drawing.Color.LightGray;
            this.oculus.Image = ((System.Drawing.Image)(resources.GetObject("oculus.Image")));
            this.oculus.Location = new System.Drawing.Point(51, 257);
            this.oculus.Name = "oculus";
            this.oculus.Size = new System.Drawing.Size(145, 83);
            this.oculus.TabIndex = 26;
            this.oculus.Text = "Oculus Account";
            this.oculus.UseVisualStyleBackColor = true;
            this.oculus.Click += new System.EventHandler(this.oculus_Click);
            this.oculus.MouseEnter += new System.EventHandler(this.oculus_MouseEnter);
            this.oculus.MouseLeave += new System.EventHandler(this.oculus_MouseLeave);
            // 
            // meta
            // 
            this.meta.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meta.ForeColor = System.Drawing.Color.LightGray;
            this.meta.Image = ((System.Drawing.Image)(resources.GetObject("meta.Image")));
            this.meta.Location = new System.Drawing.Point(279, 257);
            this.meta.Name = "meta";
            this.meta.Size = new System.Drawing.Size(145, 83);
            this.meta.TabIndex = 27;
            this.meta.Text = "Meta Account";
            this.meta.UseVisualStyleBackColor = true;
            this.meta.Click += new System.EventHandler(this.meta_Click);
            this.meta.MouseEnter += new System.EventHandler(this.meta_MouseEnter);
            this.meta.MouseLeave += new System.EventHandler(this.meta_MouseLeave);
            // 
            // version
            // 
            this.version.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.LightGray;
            this.version.Image = ((System.Drawing.Image)(resources.GetObject("version.Image")));
            this.version.Location = new System.Drawing.Point(51, 396);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(145, 83);
            this.version.TabIndex = 28;
            this.version.Text = "Version Swapper";
            this.version.UseVisualStyleBackColor = true;
            this.version.Click += new System.EventHandler(this.version_Click);
            this.version.MouseEnter += new System.EventHandler(this.version_MouseEnter);
            this.version.MouseLeave += new System.EventHandler(this.version_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(66, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Version 42 or Below";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(294, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Version 43 or Below";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(12, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Application Created by: TheLaw-#0515";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(315, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Graphics by: whoosh#9604";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // metamerge
            // 
            this.metamerge.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metamerge.ForeColor = System.Drawing.Color.LightGray;
            this.metamerge.Image = ((System.Drawing.Image)(resources.GetObject("metamerge.Image")));
            this.metamerge.Location = new System.Drawing.Point(279, 396);
            this.metamerge.Name = "metamerge";
            this.metamerge.Size = new System.Drawing.Size(145, 83);
            this.metamerge.TabIndex = 53;
            this.metamerge.Text = "Meta Merge";
            this.metamerge.UseVisualStyleBackColor = true;
            this.metamerge.Click += new System.EventHandler(this.metamerge_Click);
            this.metamerge.MouseEnter += new System.EventHandler(this.metamerge_MouseEnter);
            this.metamerge.MouseLeave += new System.EventHandler(this.metamerge_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.Visible = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(463, 615);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metamerge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.version);
            this.Controls.Add(this.meta);
            this.Controls.Add(this.oculus);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oculus Account Swapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.Shown += new System.EventHandler(this.Welcome_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button oculus;
        private System.Windows.Forms.Button meta;
        private System.Windows.Forms.Button version;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button metamerge;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}