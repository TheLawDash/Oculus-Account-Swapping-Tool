namespace OculusAccountSwapper
{
    partial class swapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(swapper));
            this.browse = new System.Windows.Forms.Button();
            this.chooseversion = new System.Windows.Forms.ComboBox();
            this.startprocess = new System.Windows.Forms.Button();
            this.blockupdate = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.LightGray;
            this.browse.Image = ((System.Drawing.Image)(resources.GetObject("browse.Image")));
            this.browse.Location = new System.Drawing.Point(12, 95);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(97, 47);
            this.browse.TabIndex = 21;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            this.browse.MouseEnter += new System.EventHandler(this.browse_MouseEnter);
            this.browse.MouseLeave += new System.EventHandler(this.browse_MouseLeave);
            // 
            // chooseversion
            // 
            this.chooseversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseversion.FormattingEnabled = true;
            this.chooseversion.Items.AddRange(new object[] {
            "Oculus Version v27.0",
            "Oculus Version v28.0",
            "Oculus Version v29.0",
            "Oculus Version v30.0",
            "Oculus Version v31.0",
            "Oculus Version v42.0",
            "Oculus Version v43.0",
            "Oculus Version v44.0",
            "Oculus Version v46.0",
            "Oculus Version v47.0",
            "Oculus Version v49.0 (current)"});
            this.chooseversion.Location = new System.Drawing.Point(136, 109);
            this.chooseversion.Name = "chooseversion";
            this.chooseversion.Size = new System.Drawing.Size(184, 21);
            this.chooseversion.TabIndex = 22;
            this.chooseversion.SelectedIndexChanged += new System.EventHandler(this.chooseversion_SelectedIndexChanged);
            // 
            // startprocess
            // 
            this.startprocess.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startprocess.ForeColor = System.Drawing.Color.LightGray;
            this.startprocess.Image = ((System.Drawing.Image)(resources.GetObject("startprocess.Image")));
            this.startprocess.Location = new System.Drawing.Point(354, 95);
            this.startprocess.Name = "startprocess";
            this.startprocess.Size = new System.Drawing.Size(97, 47);
            this.startprocess.TabIndex = 23;
            this.startprocess.Text = "Start";
            this.startprocess.UseVisualStyleBackColor = true;
            this.startprocess.Click += new System.EventHandler(this.startprocess_Click);
            this.startprocess.MouseEnter += new System.EventHandler(this.startprocess_MouseEnter);
            this.startprocess.MouseLeave += new System.EventHandler(this.startprocess_MouseLeave);
            // 
            // blockupdate
            // 
            this.blockupdate.Appearance = System.Windows.Forms.Appearance.Button;
            this.blockupdate.AutoSize = true;
            this.blockupdate.BackColor = System.Drawing.Color.Transparent;
            this.blockupdate.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockupdate.Location = new System.Drawing.Point(354, 160);
            this.blockupdate.Name = "blockupdate";
            this.blockupdate.Size = new System.Drawing.Size(89, 27);
            this.blockupdate.TabIndex = 24;
            this.blockupdate.Text = "Block Update";
            this.blockupdate.UseVisualStyleBackColor = false;
            this.blockupdate.CheckedChanged += new System.EventHandler(this.blockupdate_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "Back To Welcome";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 27);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Use Default Location?";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // swapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::OculusAccountSwapper.Properties.Resources.asfsafas;
            this.ClientSize = new System.Drawing.Size(463, 613);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blockupdate);
            this.Controls.Add(this.startprocess);
            this.Controls.Add(this.chooseversion);
            this.Controls.Add(this.browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "swapper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oculus Version Swapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.swapper_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.ComboBox chooseversion;
        private System.Windows.Forms.Button startprocess;
        private System.Windows.Forms.CheckBox blockupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}