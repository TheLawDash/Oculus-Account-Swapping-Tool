namespace OculusAccountSwapper
{
    partial class Progressing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progressing));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.percent = new System.Windows.Forms.Label();
            this.downloading = new System.Windows.Forms.Label();
            this.amountt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 239);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(425, 23);
            this.progressBar.TabIndex = 0;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.Color.DarkGray;
            this.percent.Location = new System.Drawing.Point(177, 281);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(0, 20);
            this.percent.TabIndex = 1;
            // 
            // downloading
            // 
            this.downloading.AutoSize = true;
            this.downloading.BackColor = System.Drawing.Color.Transparent;
            this.downloading.Font = new System.Drawing.Font("Impact", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloading.ForeColor = System.Drawing.Color.DarkGray;
            this.downloading.Location = new System.Drawing.Point(97, 144);
            this.downloading.Name = "downloading";
            this.downloading.Size = new System.Drawing.Size(275, 53);
            this.downloading.TabIndex = 4;
            this.downloading.Text = "Downloading...";
            // 
            // amountt
            // 
            this.amountt.AutoSize = true;
            this.amountt.BackColor = System.Drawing.Color.Transparent;
            this.amountt.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountt.ForeColor = System.Drawing.Color.DarkGray;
            this.amountt.Location = new System.Drawing.Point(177, 311);
            this.amountt.Name = "amountt";
            this.amountt.Size = new System.Drawing.Size(0, 20);
            this.amountt.TabIndex = 5;
            // 
            // Progressing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.ClientSize = new System.Drawing.Size(464, 615);
            this.Controls.Add(this.amountt);
            this.Controls.Add(this.downloading);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Progressing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oculus Version Swapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Progressing_FormClosed);
            this.Shown += new System.EventHandler(this.Progressing_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label downloading;
        private System.Windows.Forms.Label amountt;
    }
}