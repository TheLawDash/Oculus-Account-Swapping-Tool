using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OculusAccountSwapper.Meta;
using static OculusAccountSwapper.Form1;
using System.IO;
using System.Windows.Forms.VisualStyles;
using static OculusAccountSwapper.BorderChange;

namespace OculusAccountSwapper
{
    public partial class AccountViewer : Form
    {
        public AccountViewer()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountViewer_Load(object sender, EventArgs e)
        {
            if(meta)
            {
                checkBox1.Text = "Meta Account     ";
                string accounts = File.ReadAllText(metapath);
                textBox1.Text = accounts;
            }
            else
            {
                checkBox1.Text = "Oculus Account";
                string accounts = File.ReadAllText(ocpath);
                textBox1.Text = accounts;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            List<string> final = new List<string>();
            List<string> accountDeets = new List<string>();
            if(meta)
            {
                string[] temp = File.ReadAllLines(metapath);
                accountDeets = temp.ToList();
            }
            else
            {
                string[] temp = File.ReadAllLines(ocpath);
                accountDeets = temp.ToList();
            }
            if (showpass.Checked)
            {
                showpass.Text = "Hide Password";
                foreach(string line in accountDeets)
                {
                    string[] noComma = line.Split(',');
                    string pass = noComma[2];
                    string decrypted = Decrypt(pass, pw);
                    string redone = noComma[0] + "," + noComma[1] + "," + decrypted + "\n";
                    final.Add(redone);
                }
                textBox1.Clear();
                string allText = String.Join(Environment.NewLine, final);
                textBox1.Text = allText;

            }
            else if (!showpass.Checked)
            {
                showpass.Text = "Show Password";
                textBox1.Clear();
                string accounts = File.ReadAllText(ocpath);
                textBox1.Text = accounts;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<string> final = new List<string>();
            List<string> accountDeets = new List<string>();
            if (meta)
            {
                string[] temp = File.ReadAllLines(metapath);
                accountDeets = temp.ToList();
            }
            else
            {
                string[] temp = File.ReadAllLines(ocpath);
                accountDeets = temp.ToList();
            }
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Meta Account     ";
                meta = true;
                if (showpass.Checked)
                {
                    showpass.Text = "Hide Password";
                    foreach (string line in accountDeets)
                    {
                        string[] noComma = line.Split(',');
                        string pass = noComma[2];
                        string decrypted = Decrypt(pass, pw);
                        string redone = noComma[0] + "," + noComma[1] + "," + decrypted + "\n";
                        final.Add(redone);
                    }
                    textBox1.Clear();
                    string allText = String.Join(Environment.NewLine, final);
                    textBox1.Text = allText;

                }
                else if (!showpass.Checked)
                {
                    showpass.Text = "Show Password";
                    textBox1.Clear();
                    string accounts = File.ReadAllText(metapath);
                    textBox1.Text = accounts;
                }
            }
            else if (!checkBox1.Checked)
            {
                meta = false;
                checkBox1.Text = "Oculus Account";
                textBox1.Clear();
                if (showpass.Checked)
                {
                    showpass.Text = "Hide Password";
                    foreach (string line in accountDeets)
                    {
                        string[] noComma = line.Split(',');
                        string pass = noComma[2];
                        string decrypted = Decrypt(pass, pw);
                        string redone = noComma[0] + "," + noComma[1] + "," + decrypted + "\n";
                        final.Add(redone);
                    }
                    textBox1.Clear();
                    string allText = String.Join(Environment.NewLine, final);
                    textBox1.Text = allText;

                }
                else if (!showpass.Checked)
                {
                    showpass.Text = "Show Password";
                    textBox1.Clear();
                    string accounts = File.ReadAllText(ocpath);
                    textBox1.Text = accounts;
                }
            }
        }
    }
}
