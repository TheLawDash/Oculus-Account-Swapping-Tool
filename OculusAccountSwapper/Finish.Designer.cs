namespace OculusAccountSwapper
{
    partial class Finish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finish));
            this.version = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.LightGray;
            this.version.Image = ((System.Drawing.Image)(resources.GetObject("version.Image")));
            this.version.Location = new System.Drawing.Point(272, 312);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(145, 83);
            this.version.TabIndex = 26;
            this.version.Text = "Back To Versions";
            this.version.UseVisualStyleBackColor = true;
            this.version.Click += new System.EventHandler(this.button1_Click);
            this.version.MouseEnter += new System.EventHandler(this.version_MouseEnter);
            this.version.MouseLeave += new System.EventHandler(this.version_MouseLeave);
            // 
            // manager
            // 
            this.manager.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager.ForeColor = System.Drawing.Color.LightGray;
            this.manager.Image = ((System.Drawing.Image)(resources.GetObject("manager.Image")));
            this.manager.Location = new System.Drawing.Point(46, 312);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(145, 83);
            this.manager.TabIndex = 25;
            this.manager.Text = "Back To Home";
            this.manager.UseVisualStyleBackColor = true;
            this.manager.Click += new System.EventHandler(this.browse_Click);
            this.manager.MouseEnter += new System.EventHandler(this.manager_MouseEnter);
            this.manager.MouseLeave += new System.EventHandler(this.manager_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(127, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 63);
            this.label1.TabIndex = 24;
            this.label1.Text = "Finished!";
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.ClientSize = new System.Drawing.Size(464, 615);
            this.Controls.Add(this.version);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Finish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oculus Account Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Finish_FormClosed);
            this.Load += new System.EventHandler(this.Finish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button version;
        private System.Windows.Forms.Button manager;
        private System.Windows.Forms.Label label1;
    }
}