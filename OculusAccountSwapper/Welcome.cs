using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static OculusAccountSwapper.BorderChange;

namespace OculusAccountSwapper
{
    public partial class Welcome : Form
    {
        //Defining local struct user with a public user varible that has gets and sets for username email and password...
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

        //Creates a list of the user struct called UserList
        List<user> UserList = new List<user>();

        //Defining local paths for account information
        public static string metapath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MetaEchoData.txt";
        public static string ocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EchoData.txt";
        public Welcome()
        {
            InitializeComponent();
        }
        
        //If user clicks the Oculus Account button it will hide the welcome window and redirect them to the appropriate form...
        private void oculus_Click(object sender, EventArgs e)
        {
            //Makes local instance of the form
            Form1 f = new Form1();

            //Hides Welcome Page
            this.Hide();

            //Shows local form instance
            f.Show();
        }

        //If user clicks the Meta Account button it will hide the welcome window and redirect them to the appropriate form...
        private void meta_Click(object sender, EventArgs e)
        {
            //Makes local instance of the form
            Meta m = new Meta();

            //Hides Welcome Page
            this.Hide();

            //Shows local form instance
            m.Show();
        }
        //If user clicks the Meta Merge button it will hide the welcome window and redirect them to the appropriate form...
        private void metamerge_Click(object sender, EventArgs e)
        {
            //Makes local instance of the form
            Form2 s = new Form2();
           
            //Hides Welcome Page
            s.Show();

            //Shows local form instance
            this.Hide();
        }

        //Button animations -- START
        private void oculus_MouseEnter(object sender, EventArgs e)
        {
            oculus.Image = Properties.Resources.pressed;
        }

        private void oculus_MouseLeave(object sender, EventArgs e)
        {
            oculus.Image = Properties.Resources.Butt_on;
        }

        private void meta_MouseEnter(object sender, EventArgs e)
        {
            meta.Image = Properties.Resources.pressed;
        }

        private void meta_MouseLeave(object sender, EventArgs e)
        {
            meta.Image = Properties.Resources.Butt_on;
        }

        private void version_MouseLeave(object sender, EventArgs e)
        {
            version.Image = Properties.Resources.Butt_on;
        }

        private void version_MouseEnter(object sender, EventArgs e)
        {
            version.Image = Properties.Resources.pressed;
        }
        private void metamerge_MouseEnter(object sender, EventArgs e)
        {
            metamerge.Image = Properties.Resources.pressed;
        }
        private void metamerge_MouseLeave(object sender, EventArgs e)
        {
            metamerge.Image = Properties.Resources.Butt_on;
        }
        //Button Animations -- END

        //If user clicks the Version Swapper button it will hide the welcome window and redirect them to the appropriate form...
        private void version_Click(object sender, EventArgs e)
        {
            //Makes local instance of the form
            swapper s = new swapper();

            //Hides Welcome Page
            s.Show();

            //Shows local form instance
            this.Hide();
        }

        //When the welcome form is shown, this is executed, meant to encrypt any plaintext passwords and register the URL Protocols
        private void Welcome_Shown(object sender, EventArgs e)
        {
            //Initilizes the RegistryKey variable to see if the handler has been registered
            RegistryKey key = Registry.ClassesRoot.OpenSubKey("AccountSwapper");

            //If the protocol has not been registered it will register it
            if(key == null)
            {
                //Creating a subkey called AccountSwapper
                key = Registry.ClassesRoot.CreateSubKey("AccountSwapper");

                //Sets the value of the subKey
                key.SetValue(string.Empty, "URL: Account Protocol");
                key.SetValue("URL Protocol", string.Empty);
                key = key.CreateSubKey(@"shell\open\command");
                
                //Sets the application path and what parameters to look for, shown as %1, %2, %3 respectively
                key.SetValue(string.Empty, System.Reflection.Assembly.GetEntryAssembly().Location + " " + "%1" + "%2" + "%3");

                //Creating another protocol for Meta Accounts named MetaSwapper
                key = Registry.ClassesRoot.CreateSubKey("MetaSwapper");
                
                //Sets the value of the subKey
                key.SetValue(string.Empty, "URL: Account Protocol");
                key.SetValue("URL Protocol", string.Empty);
                key = key.CreateSubKey(@"shell\open\command");

                //Sets the application path and what parameters to look for, shown as %1, %2, %3 respectively
                key.SetValue(string.Empty, System.Reflection.Assembly.GetEntryAssembly().Location + " " + "%1" + "%2" + "%3");
            }
            //Creates a string list named ocFiles to hold every account in the text file
            List<string> ocAccounts = File.ReadAllLines(ocpath).ToList();

            //Instatiates local string list for account management
            List<string> encrypted = new List<string>();

            //For loop to itterate through each account in the ocPath text file
            foreach(string line in ocAccounts)
            {
                //Parses each line by the commas, each line is set up as Username,Email,EncryptedPassword
                string[] split = line.Split(',');
                if(split.Length <= 1)
                {
                    continue;
                }
                try
                {
                    Console.WriteLine(split[2]);
                    //Attempts to decrypt the password: If password is not encrypted it will throw an exception and go into the catch statement
                    string decrypt = Decrypt(split[2], pw);
                    Console.WriteLine("Encrypted!");

                    //This puts the line back together and adds it to the local list
                    string correctedLine = split[0] + ',' + split[1] + ',' + split[2];

                    //Adds the correct line to the encrypted list
                    encrypted.Add(correctedLine);
                }
                catch
                {
                    Console.WriteLine("Not encrypted yet!!");

                    //If the exception is thrown it will then encrypt the password
                    string encrypt = Encrypt(split[2], pw);

                    //Puts the corrected account line into a string
                    string correctedLine = split[0] + ',' + split[1] + ',' + encrypt;

                    //Adds the corrected string to the encrypted list
                    encrypted.Add(correctedLine);
                }
            }
            //Uses a StreamWriter to write the corrected lines back to the ocPath text file
            using (StreamWriter outputFile = (new StreamWriter(ocpath)))
            {
                foreach(string line in encrypted)
                    outputFile.WriteLine(line);
            }
            //Clears the ocAccounts list for the MetaAccounts
            ocAccounts.Clear();

            //Re-defines ocAccounts to hold every account in the text file metapath
            ocAccounts = File.ReadAllLines(metapath).ToList();

            //Clears the encrypted list for the MetaAccounts
            encrypted.Clear();
            //For loop to itterate through each account in the ocPath text file
            foreach (string line in ocAccounts)
            {
                //Parses each line by the commas, each line is set up as Username,Email,EncryptedPassword
                string[] split = line.Split(',');
                //If there are blank lines it will be skipped
                if (split.Length <= 1)
                {
                    continue;
                }
                try
                {
                    Console.WriteLine(split[2]);
                    //Attempts to decrypt the password: If password is not encrypted it will throw an exception and go into the catch statement
                    string decrypt = Decrypt(split[2], pw);
                    Console.WriteLine("Encrypted!");

                    //This puts the line back together and adds it to the local list
                    string correctedLine = split[0] + ',' + split[1] + ',' + split[2];

                    //Adds the correct line to the encrypted list
                    encrypted.Add(correctedLine);
                }
                catch
                {
                    Console.WriteLine("Not encrypted yet!!");

                    //If the exception is thrown it will then encrypt the password
                    string encrypt = Encrypt(split[2], pw);

                    //Puts the corrected account line into a string
                    string correctedLine = split[0] + ',' + split[1] + ',' + encrypt;

                    //Adds the corrected string to the encrypted list
                    encrypted.Add(correctedLine);
                }
            }
            //Uses a StreamWriter to write the corrected lines back to the metapath text file
            using (StreamWriter outputFile = (new StreamWriter(metapath)))
            {
                foreach (string line in encrypted)
                    outputFile.WriteLine(line);
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //Checks to see if metapath exists, if it doesn't it will create it
            if (!File.Exists(metapath))
            {
                StreamWriter sw = File.CreateText(metapath);
                sw.Flush();
                sw.Dispose();
            }
            //Checks to see if ocpath exists, if it doesn't it will create it
            if (!File.Exists(ocpath))
            {
                StreamWriter sw = File.CreateText(ocpath);
                sw.Flush();
                sw.Dispose();
            }
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Looks to make sure chromedriver isn't left open, if it is, it'll kill it...
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
                Console.WriteLine("No chromedriver open");
            }
            //Looks to make sure OculusAccountSwapper isn't left open, if it is, it'll kill it...
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
                Console.WriteLine("No OculusAccountSwapper open");
            }

            //Exits the program
            Application.ExitThread();
            Application.Exit();
        }
    }
}
