using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Keys = OpenQA.Selenium.Keys;
using static OculusAccountSwapper.BorderChange;
using OpenQA.Selenium.DevTools;
using System.Net.Mail;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using AE.Net.Mail;
using System.Security.Policy;
using static OculusAccountSwapper.PassCodeForm;
using Microsoft.Win32;
using Path = System.IO.Path;
using System.Net.Http;
using System.Net;
using Ionic.Zip;
using System.IO.Compression;

namespace OculusAccountSwapper
{
    public partial class Form2 : Form
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EchoData.txt";
        public static string ocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EchoData.txt";
        public static string metapath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MetaEchoData.txt";

        public int it;
        struct user
        {
            public user(string user, string em, string pass)
            {
                username = user;
                email = em;
                password = pass;
            }
            public string email { get; }
            public string password { get; }
            public string username { get; }
        }

        List<user> UserList = new List<user>();
        List<user> EmailList = new List<user>();
        List<user> PassList = new List<user>();
        public Form2()
        {
            InitializeComponent();
        }
        public static string mergeemail = "";
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

        private void usernames_Click(object sender, EventArgs e)
        {

        }
        IWebDriver wb = null;
        public static bool CODEEEEEEStop;
        private async void metamerge_Click(object sender, EventArgs e)
        {
            CODEEEEEEStop = false;
            codey = "";
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Please make sure to select an account to merge into a meta account.",
                "Empty Selction Moment Smhmh",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                List<string> lines = File.ReadAllLines(ocpath).ToList();
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
                        try
                        {
                            MessageBox.Show("Your account is being merged, this should take around 30 seconds...\nPlease click 'OK' to start",
                            "Maybe Law Good At Code?",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            var directory = Directory.GetDirectories(@"C:\Program Files\Google\Chrome\Application");
                            string[] version = directory[0].Split('\\');
                            string chromeVersion = version[5];
                            Console.WriteLine("Chrome version: " + version[5]);
                            var thisApp = Environment.CurrentDirectory;
                            var files = Directory.GetFiles(thisApp);
                            var fileInfo = FileVersionInfo.GetVersionInfo((thisApp + @"\chromedriver.exe"));
                            string execPath = Assembly.GetEntryAssembly().Location;
                            string strWorkPath = System.IO.Path.GetDirectoryName(execPath);
                            string command = "cmd.exe";
                            string arguments = "/c chromedriver -v";

                            ProcessStartInfo processInfo = new ProcessStartInfo
                            {
                                FileName = command,
                                Arguments = arguments,
                                RedirectStandardOutput = true,
                                UseShellExecute = false,
                                CreateNoWindow = true
                            };
                            string output;
                            using (Process process = new Process())
                            {
                                process.StartInfo = processInfo;
                                process.Start();

                                output = process.StandardOutput.ReadToEnd();
                                process.WaitForExit();

                            }
                            string[] chromedriverVersion = output.Split(' ');
                            string currentDriver = chromedriverVersion[1];
                            string[] driverSplit = chromeVersion.Split('.');
                            chromeVersion = driverSplit[0] + "." + driverSplit[1] + "." + driverSplit[2];
                            driverSplit = currentDriver.Split('.');
                            currentDriver = driverSplit[0] + "." + driverSplit[1] + "." + driverSplit[2];
                            if (chromeVersion.Equals(currentDriver))
                            {
                                Console.WriteLine("We good!");
                            }
                            else
                            {
                                MessageBox.Show("Chrome driver out of date! Updating driver...", "Chrome Driver Out Of Date", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                try
                                {
                                    File.Delete(strWorkPath + "/chromedriver.exe");
                                }
                                catch
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
                                }
                                try
                                {
                                    File.Delete(strWorkPath + "/LICENSE.chromedriver");
                                }
                                catch
                                {

                                }
                                string[] versionSplit = chromeVersion.Split('.');
                                HttpClient httpClient = new HttpClient();
                                var neededVersion = await httpClient.GetAsync("https://chromedriver.storage.googleapis.com/LATEST_RELEASE_" + versionSplit[0] + "." + versionSplit[1] + "." + versionSplit[2]);
                                var searchVersion = await neededVersion.Content.ReadAsStringAsync();
                                string zipName = "chromedriver_win32.zip";
                                using(WebClient webclient = new WebClient())
                                {
                                    Uri myUri = new Uri("https://chromedriver.storage.googleapis.com/" + searchVersion + "/" + zipName);
                                    await webclient.DownloadFileTaskAsync(myUri, strWorkPath + zipName);
                                    using(ZipArchive archive = System.IO.Compression.ZipFile.OpenRead(strWorkPath + zipName))
                                    {
                                        foreach(ZipArchiveEntry entry in archive.Entries)
                                        {
                                            string extractPath = Path.Combine(strWorkPath, entry.FullName);
                                            entry.ExtractToFile(extractPath,true);
                                        }
                                    }
                                }
                            }
                            var DeviceDriver = ChromeDriverService.CreateDefaultService(strWorkPath);
                            IWebDriver wb = null;
                            DeviceDriver.HideCommandPromptWindow = true;
                            ChromeOptions options = new ChromeOptions();
                            //options.AddArguments("--headless");
                            options.AddArguments("--disable-infobars");
                            wb = new ChromeDriver(DeviceDriver, options);
                            wb.Manage().Window.Maximize();
                            wb.Navigate().GoToUrl("https://auth.meta.com");
                            wb.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                            //Login With oculus
                            var links = wb.FindElements(By.TagName("img"));
                            var test = links[0].GetAttribute("src");
                            var spans = wb.FindElements(By.TagName("span"));
                            var hehe = spans[1].Text;
                            if (hehe != "Welcome")
                            {
                                var ugh = wb.FindElements(By.TagName("span"));
                                var theone = ugh[7];
                                theone.Click();

                                Console.WriteLine("Prolly Not Work");
                                //Already Have
                                var ugh1 = wb.FindElements(By.TagName("span"));
                                var thetwo = ugh1[3];
                                thetwo.Click();
                                //Not Facebook
                                var ugh2 = wb.FindElements(By.TagName("span"));
                                var thethree = ugh2[4];
                                thethree.Click();
                                Thread.Sleep(1250);
                                var ugh22 = wb.FindElements(By.TagName("span"));
                                var thethreee = ugh22[6];
                                thethreee.Click();
                                //Oculus sign in
                                var ugh3 = wb.FindElements(By.TagName("input"));
                                //for(int i = 0; i < ugh3.Count; i++)
                                //{
                                //    try
                                //    {
                                //        ugh3[i].Click();
                                //        Console.WriteLine(i);
                                //    }
                                //    catch
                                //    {
                                //        Console.WriteLine("L");
                                //    }
                                //}
                                var thefour = ugh3[0];
                                thefour.Click();
                                thefour.SendKeys(interm[1]);
                                var thefive = ugh3[1];
                                thefive.Click();
                                string decrypt = Decrypt(interm[2], pw);
                                thefive.SendKeys(decrypt);
                                var ugh4 = wb.FindElements(By.TagName("button"));
                                ugh4[0].Click();
                                Thread.Sleep(6000);
                                Console.WriteLine("This is too easy lmao");
                                var loginConfirmation = wb.FindElements(By.TagName("h2"));
                                bool needcode = false;
                                try
                                {
                                    Console.WriteLine("Code Needed");
                                    for (int i = 0; i < loginConfirmation.Count; i++)
                                    {
                                        if (loginConfirmation[i].Text == "Login Confirmation")
                                        {
                                            needcode = true;
                                            mergeemail = interm[1];
                                            string[] domain = mergeemail.Split('@');
                                            if (domain[1] == "projectmayhem.xyz")
                                            {
                                                codeboi(interm[1]);
                                                while(codey == "")
                                                {
                                                    Thread.Sleep(1000);
                                                    Console.WriteLine("Waiting for the damned code...");
                                       
                                                }
                                                Console.WriteLine("code gathered");
                                                var inputs = wb.FindElements(By.TagName("input"));
                                                for (int j = 0; j < inputs.Count; j++)
                                                {
                                                    inputs[j].Click();
                                                    SendKeys.Send(codey[j].ToString());
                                                    if (j == 5)
                                                    {
                                                        break;
                                                    }
                                                }
                                                Console.WriteLine("Finished Inputting Stuff");
                                                var clickbutton = wb.FindElements(By.TagName("button"));
                                                clickbutton[0].Click();
                                                Console.WriteLine("Clicked Verification button");
                                                Thread.Sleep(4000);
                                                break;
                                            }
                                            else
                                            {
                                                PassCodeForm confPass = new PassCodeForm();
                                                DialogResult result = confPass.ShowDialog();
                                                if (result == DialogResult.Cancel)
                                                {
                                                    Console.WriteLine("code gathered");
                                                    var inputs = wb.FindElements(By.TagName("input"));
                                                    for (int j = 0; j < inputs.Count; j++)
                                                    {
                                                        inputs[j].Click();
                                                        SendKeys.Send(textCode[j].ToString());
                                                        if (j == 5)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.WriteLine("Finished Inputting Stuff");
                                                    var clickbutton = wb.FindElements(By.TagName("button"));
                                                    clickbutton[0].Click();
                                                    Console.WriteLine("Clicked Verification button");
                                                    Thread.Sleep(4000);
                                                    break;
                                                }
                                                else if (result == DialogResult.OK)
                                                {
                                                    CODEEEEEEStop = true;
                                                }
                                            }
                                        }
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Code not needed");
                                }
                                if (!closed)
                                {
                                    var ugh5 = wb.FindElements(By.TagName("button"));
                                    var fff = ugh5[3].Text;
                                    ugh5[2].Click();
                                    Thread.Sleep(4000);
                                    var ugh6 = wb.FindElements(By.TagName("div"));
                                    Console.WriteLine("This is too easy lmao");
                                    //This code was heavenly to debug lmao
                                    //for (int i = 0; i < ugh6.Count; i++)
                                    //{
                                    //    try
                                    //    {
                                    //        ugh6[i].Click();
                                    //        Console.WriteLine(i);
                                    //        
                                    //    }
                                    //    catch
                                    //    {
                                    //        Console.WriteLine("L");
                                    //    }
                                    //}
                                    Console.WriteLine("Wellllllll");
                                    ugh6[149].Click();
                                    Thread.Sleep(5000);
                                    var ugh7 = wb.FindElements(By.TagName("div"));
                                    //for (int i = 85; i < ugh7.Count; i++)
                                    //{
                                    //    try
                                    //    {
                                    //        ugh7[i].Click();
                                    //        Console.WriteLine(i);
                                    //        
                                    //    }
                                    //    catch
                                    //    {
                                    //        Console.WriteLine("L");
                                    //    }
                                    //}
                                    ugh7[90].Click();
                                    ugh7[90].SendKeys("1");
                                    ugh7[90].SendKeys(Keys.Enter);
                                    ugh7[85].Click();
                                    ugh7[85].SendKeys("j");
                                    ugh7[85].SendKeys(Keys.Enter);
                                    ugh7[95].Click();
                                    ugh7[95].SendKeys("1");
                                    ugh7[95].SendKeys(Keys.Enter);
                                    //for (int i = 100; i < ugh7.Count; i++)
                                    //{
                                    //    try
                                    //    {
                                    //        ugh7[i].Click();
                                    //        Console.WriteLine(i);
                                    //        
                                    //    }
                                    //    catch
                                    //    {
                                    //        Console.WriteLine("L");
                                    //    }
                                    //}
                                    ugh7[128].Click();
                                    Console.WriteLine("suck my fileCount");
                                    Thread.Sleep(2500);
                                    var ugh8 = wb.FindElements(By.TagName("div"));
                                    Console.WriteLine("buttons");
                                    ugh8[81].Click();
                                    var ugh9 = wb.FindElements(By.TagName("div"));
                                    ugh9[180].Click();
                                    Thread.Sleep(7000);
                                    wb.Quit();
                                }
                            }
                            else
                            {
                                var mailbox = wb.FindElements(By.TagName("input"));
                                mailbox[0].Click();
                                mailbox[0].SendKeys(interm[1]);
                                var span1 = wb.FindElements(By.TagName("span"));
                                for (int i = 0; i < span1.Count; i++)
                                {
                                    try
                                    {
                                        if (span1[i].Text == "Continue")
                                        {
                                            span1[i].Click();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("SadBruh");
                                    }
                                }
                                Thread.Sleep(2000);
                                //Already Have
                                var ugh1 = wb.FindElements(By.TagName("span"));
                                var thetwo = ugh1[3];
                                thetwo.Click();
                                //Not Facebook
                                Thread.Sleep(1250);
                                var spanb = wb.FindElements(By.TagName("span"));
                                for (int i = 0; i < spanb.Count; i++)
                                {
                                    try
                                    {
                                        if (spanb[i].Text == "Yes")
                                        {
                                            spanb[i].Click();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("SadBruh");
                                    }
                                }
                                var ugh2 = wb.FindElements(By.TagName("span"));
                                var thethree = ugh2[6];
                                thethree.Click();
                                //Oculus sign in
                                var ugh3 = wb.FindElements(By.TagName("input"));
                                //for(int i = 0; i < ugh3.Count; i++)
                                //{
                                //    try
                                //    {
                                //        ugh3[i].Click();
                                //        Console.WriteLine(i);
                                //    }
                                //    catch
                                //    {
                                //        Console.WriteLine("L");
                                //    }
                                //}
                                var thefour = ugh3[0];
                                thefour.Click();
                                thefour.SendKeys(interm[1]);
                                var thefive = ugh3[1];
                                thefive.Click();
                                string decrypt = Decrypt(interm[2], pw);
                                thefive.SendKeys(decrypt);
                                var ugh4 = wb.FindElements(By.TagName("button"));
                                ugh4[0].Click();
                                Thread.Sleep(6000);
                                var ugh5 = wb.FindElements(By.TagName("button"));
                                var fff = ugh5[3].Text;
                                ugh5[2].Click();
                                Console.WriteLine("This is too easy lmao");
                                Thread.Sleep(4000);
                                var ugh6 = wb.FindElements(By.TagName("div"));
                                Console.WriteLine("This is too easy lmao");
                                //for (int i = 0; i < ugh6.Count; i++)
                                //{
                                //    try
                                //    {
                                //        ugh6[i].Click();
                                //        Console.WriteLine(i);
                                //        
                                //    }
                                //    catch
                                //    {
                                //        Console.WriteLine("L");
                                //    }
                                //}
                                //Console.WriteLine("Wellllllll");
                                ugh6[73].Click();
                                Thread.Sleep(5000);
                                var ugh7 = wb.FindElements(By.TagName("div"));
                                ugh7[60].Click();
                                ugh7[60].SendKeys("1");
                                ugh7[60].SendKeys(Keys.Enter);
                                ugh7[55].Click();
                                ugh7[55].SendKeys("j");
                                ugh7[55].SendKeys(Keys.Enter);
                                ugh7[65].Click();
                                ugh7[65].SendKeys("1");
                                ugh7[65].SendKeys(Keys.Enter);
                                ugh7[74].Click();
                                Console.WriteLine("suck my fileCount");
                                Thread.Sleep(2500);
                                var ugh8 = wb.FindElements(By.TagName("div"));
                                Console.WriteLine("buttons");
                                ugh8[81].Click();
                                Thread.Sleep(4000);
                                wb.Quit();

                            }
                            if(!closed)
                            {
                                lines.Remove(interm[0] + "," + interm[1] + "," + interm[2]);
                                File.WriteAllLines(ocpath, lines);
                                List<string> lines1 = File.ReadAllLines(metapath).ToList();
                                var User = new user(interm[0], interm[1], interm[2]);
                                UserList.Add(User);
                                lines1.Add(User.username + "," + User.email + "," + User.password);
                                File.WriteAllLines(metapath, lines1);
                                try
                                {
                                    Process[] workers = Process.GetProcessesByName("chromedriver.exe");
                                    foreach (Process worker in workers)
                                    {
                                        worker.Kill();
                                        worker.WaitForExit();
                                        worker.Dispose();
                                    }
                                    Console.WriteLine("closed");
                                }
                                catch
                                {

                                }
                                MessageBox.Show("Hooray your account has been Meta-Merged!\nYou're good to work on other things now.", "Woohoo!!!! Law doesn't suck.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                            {
                                try
                                {
                                    Process[] workers = Process.GetProcessesByName("chromedriver.exe");
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
                                MessageBox.Show("Meta Merge Has Been Stopped!", "Canceled...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                Process[] workers = Process.GetProcessesByName("chromedriver.exe");
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
                            MessageBox.Show("Uhhh so something broked.\nPlease verify that your current account is not already a meta account and or is valid!\n",
                            "Law Sucks At Coding SMHMH",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                    }
                    it += 1;
                }
            }
        }

        private void metamerge_MouseEnter(object sender, EventArgs e)
        {
            metamerge.Image = Properties.Resources.pressed;
        }

        private void metamerge_MouseLeave(object sender, EventArgs e)
        {
            metamerge.Image = Properties.Resources.Butt_on;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.pressed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.Butt_on;
        }
        public static bool done, stupid;
        public static string codey;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassCodeForm F = new PassCodeForm();
            F.Show();
        }

        public static async Task codeboi(string email)
        {
            done = false;
            while(!done)
            {
                ImapClient IC = new ImapClient("imap.gmail.com", "thelawofnips@gmail.com", "ldljxeflkqobeqxo", ImapClient.AuthMethods.Login, 993, true);
                var count = IC.GetMessageCount();
                IC.SelectMailbox("INBOX");
                for (var i = count - 1; i >= 0; i--)
                {
                    var msg = IC.GetMessage(i, false);
                    string subject = msg.Subject;
                    var to = msg.To;
                    string fileCount = email.ToLower();
                    if (subject == "Oculus - Login confirmation")
                    {
                        List<System.Net.Mail.MailAddress> bleh = to.ToList();
                        string addie = bleh[0].Address;
                        if (addie == fileCount)
                        {
                            string body = msg.Body;
                            string[] looking = body.Split('>');
                            string almost = looking[61];
                            string[] further = looking[61].Split('<');
                            codey = further[0];
                            IC.DeleteMessage(msg);
                            done = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
