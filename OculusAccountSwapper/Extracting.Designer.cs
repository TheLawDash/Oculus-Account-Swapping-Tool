namespace OculusAccountSwapper
{
    partial class Extracting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extracting));
            this.progressBar_Individual = new System.Windows.Forms.ProgressBar();
            this.progressBar_Total = new System.Windows.Forms.ProgressBar();
            this.textBox_ExtractFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_Individual
            // 
            this.progressBar_Individual.Location = new System.Drawing.Point(72, 192);
            this.progressBar_Individual.Name = "progressBar_Individual";
            this.progressBar_Individual.Size = new System.Drawing.Size(380, 23);
            this.progressBar_Individual.TabIndex = 1;
            // 
            // progressBar_Total
            // 
            this.progressBar_Total.Location = new System.Drawing.Point(72, 219);
            this.progressBar_Total.Name = "progressBar_Total";
            this.progressBar_Total.Size = new System.Drawing.Size(380, 23);
            this.progressBar_Total.TabIndex = 2;
            // 
            // textBox_ExtractFile
            // 
            this.textBox_ExtractFile.Enabled = false;
            this.textBox_ExtractFile.Location = new System.Drawing.Point(72, 165);
            this.textBox_ExtractFile.Name = "textBox_ExtractFile";
            this.textBox_ExtractFile.Size = new System.Drawing.Size(380, 20);
            this.textBox_ExtractFile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(35, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "File:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 98);
            this.label2.TabIndex = 0;
            this.label2.Text = "Extracting Files...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(4, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CURRENT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(22, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // Extracting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.ClientSize = new System.Drawing.Size(465, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ExtractFile);
            this.Controls.Add(this.progressBar_Total);
            this.Controls.Add(this.progressBar_Individual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Extracting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oculus Version Swapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Extracting_FormClosed);
            this.Shown += new System.EventHandler(this.Extracting_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_Individual;
        private System.Windows.Forms.ProgressBar progressBar_Total;
        private System.Windows.Forms.TextBox textBox_ExtractFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}