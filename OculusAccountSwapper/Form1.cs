using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Automation;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using static OculusAccountSwapper.Program;
using FlaUI.Core.AutomationElements;
using AutomationElement = System.Windows.Automation.AutomationElement;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using System.Threading;
using FlaUI.Core.Tools;
using System.Threading.Tasks;
using static OculusAccountSwapper.BorderChange;
using static OculusAccountSwapper.Meta;
using static OculusAccountSwapper.AccountViewer;


namespace OculusAccountSwapper
{
    public partial class Form1 : Form
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EchoData.txt";
        struct user
        {
            public user(string user, string em,string pass)
            {
                username = user;
                email = em;
                password = pass;
            }
            public string email { get; }
            public string password { get;  }
            public string username { get; }
        }

        List<user> UserList = new List<user>();
        List<user> EmailList = new List<user>();
        List<user> PassList = new List<user>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Logout Function
        public async Task log(object sender, EventArgs e)
        {
            //Checks for oculus being open

            Process[] pname = Process.GetProcessesByName("OculusClient");
            if (pname.Length == 0)
            {
                MessageBox.Show("Uh oh! Oculus doesn't seem to be open." + "\nPlease open now.", "Oculus Process Check");
            }
            else
            {
                //Gathers to app as a FlaUI.Core.Application
                var app = FlaUI.Core.Application.Attach(pname[1]);
                //Writes Process ID
                var processId = app.ProcessId;
                Console.WriteLine(processId);
                //Uses Automation for logout
                using (var automation = new UIA3Automation())
                {
                    FlaUI.Core.Conditions.ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
                    //Focuses the Oculus window

                    var window = (app.GetMainWindow(automation, TimeSpan.FromSeconds(1)));
                    int yikes = 0;
                    if (window == null)
                    {
                        foreach (var p in pname)
                        {
                            try
                            {                                
                                //Keeps going until it finds the proper window
                                app = FlaUI.Core.Application.Attach(pname[yikes]);
                                window = (app.GetMainWindow(automation, TimeSpan.FromSeconds(1)));
                                if (window != null)
                                {
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            yikes += 1;
                        }
                    }
                    //Clicks through the menus signing the user out
                    Console.WriteLine(window.Title);
                    window.FindFirstDescendant(cf.ByText("Settings"))?.AsButton().Invoke();
                    Thread.Sleep(1000);
                    window.FindFirstDescendant(cf.ByText("Log Out"))?.AsButton().Invoke();
                    Thread.Sleep(1000);
                    window.FindFirstDescendant(cf.ByText("OK"))?.AsButton().Invoke();
                }
            }
        }
        private async void logout_Click(object sender, EventArgs e)
        {
            Task.Run(() => { log(sender, e); });
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please be sure you inputted a value!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please be sure you inputted a value!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please be sure you inputted a value!");
            }
            else
            {
                //Gathers all accounts to a List
                List<string> lines = File.ReadAllLines(path).ToList();
                //Gathers user values to the struct
                var User = new user(textBox1.Text, textBox2.Text, textBox3.Text);
                //Adds this to the list
                UserList.Add(User);
                //Encrypts the password
                string encrypted = Encrypt(User.password, pw);
                //Adds the account to the lines list
                lines.Add(User.username + "," + User.email + "," + encrypted);
                //Re-writes the file with the new addition
                File.WriteAllLines(path, lines);

                comboBox1.Items.Clear();
                foreach (user v in UserList)
                {
                    comboBox1.Items.Add(v.username);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (showpass.Checked)
                {
                    textBox3.UseSystemPasswordChar = false;
                }
                else if (!showpass.Checked)
                {
                    textBox3.UseSystemPasswordChar = true;
                }
            }
            catch
            {

            }
        }
        int flag = 1;
        private async Task sign(object sender, EventArgs e)
        {
            
        }
        private void signin_Click_1(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("OculusClient");
            if (pname.Length == 0)
            {
                MessageBox.Show("Uh oh! Oculus doesn't seem to be open." + "\nPlease open now.", "Oculus Process Check");
            }
            else
            {
                var app = FlaUI.Core.Application.Attach(pname[1]);
                var processId = app.ProcessId;
                Console.WriteLine(processId);

                using (var automation = new UIA3Automation())
                {
                    FlaUI.Core.Conditions.ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
                    var window = (app.GetMainWindow(automation, TimeSpan.FromSeconds(1)));
                    int yikes = 0;
                    if (window == null)
                    {
                        foreach (var p in pname)
                        {
                            try
                            {
                                app = FlaUI.Core.Application.Attach(pname[yikes]);
                                window = (app.GetMainWindow(automation, TimeSpan.FromSeconds(1)));
                                if (window != null)
                                {
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            yikes += 1;
                        }
                    }
                    List<string> lines = File.ReadAllLines(path).ToList();
                    foreach (var line in lines)
                    {
                        string[] interm = line.Split(',');
                        if (interm[0] == comboBox1.Text)
                        {
                            foreach (char bean in interm[2])
                            {
                                if (bean == '%')
                                {
                                    interm[2].Remove(interm[2].Length - 1);
                                    interm[2].Append<char>('{');
                                    interm[2].Append<char>('%');
                                    interm[2].Append<char>('}');
                                }
                            }
                            Console.WriteLine(window.Title);
                            window.FindFirstDescendant(cf.ByText("Have an Oculus account?"))?.AsButton().Invoke();
                            Console.WriteLine("Oculus Account Clicked...");
                            window.FindFirstDescendant(cf.ByLocalizedControlType("edit"))?.AsButton().Invoke();
                            Console.WriteLine("Email Clicked.");
                            SendKeys.Send(interm[1]);
                            SendKeys.Send("{tab}");
                            string decrypted = Decrypt(interm[2], pw);
                            string pass = Regex.Replace(decrypted, "[+^%~()]", "{$0}");
                            SendKeys.Send(pass);
                            window.FindFirstDescendant(cf.ByText("Log In"))?.AsButton().Invoke();
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            meta = false;
            AccountViewer av = new AccountViewer();
            av.Show();
            //Process.Start("notepad.exe", path);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Flush();
                sw.Dispose();
            }
            comboBox1.Items.Clear();
            List<string> lines = File.ReadAllLines(path).ToList();
            foreach (var line in lines)
            {
                // username,email,password
                string[] data = line.Split(',');
                user newuser = new user(data[0], data[1], data[2]);
                comboBox1.Items.Add(data[0]);
                UserList.Add(newuser);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usernames_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void logout_Click_1(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {

        }

        private void add_Click_1(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void signin_MouseEnter(object sender, EventArgs e)
        {
            signin.Image = Properties.Resources.pressed;
        }

        private void signin_MouseLeave(object sender, EventArgs e)
        {
            signin.Image = Properties.Resources.Butt_on;
        }

        private void edit_MouseEnter(object sender, EventArgs e)
        {
            edit.Image = Properties.Resources.pressed;
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            edit.Image = Properties.Resources.Butt_on;
        }

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            logout.Image = Properties.Resources.pressed;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.Image = Properties.Resources.Butt_on;
        }

        private void add_MouseEnter(object sender, EventArgs e)
        {
            add.Image = Properties.Resources.pressed;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.Image = Properties.Resources.Butt_on;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void versionswap_Click(object sender, EventArgs e)
        {
            swapper s = new swapper();
            s.Show();
            this.Hide();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            swapper s = new swapper();
            s.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.pressed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.Butt_on;
        }
        public static void SignIn()
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Process[] workers = Process.GetProcessesByName("chromedriver");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                    Console.WriteLine("closed");
                }
            }
            catch
            {

            }
            try
            {
                Process[] workerss = Process.GetProcessesByName("OculusAccountSwapper");
                foreach (Process worker in workerss)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                    Console.WriteLine("closed");
                }
            }
            catch
            {

            }
            Application.ExitThread();
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Dispose();
        }
    }
}
