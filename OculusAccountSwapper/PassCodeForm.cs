using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OculusAccountSwapper.Form2;

namespace OculusAccountSwapper
{
    public partial class PassCodeForm : Form
    {
        public PassCodeForm()
        {
            InitializeComponent();
        }

        private void PassCodeForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Please check\n" + mergeemail + "\nfor  6 digit code";
            textBox1.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            textBox1.MaxLength = 6;
            this.TopMost = true;
        }
        public static string textCode;
        public static bool closed;
        private void metamerge_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == "" || text.Length != 6)
            {
                MessageBox.Show("Please make sure you enter a valid 6 digit code...", "Meta Merge Code Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textCode = text;
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }

        }
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PassCodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
