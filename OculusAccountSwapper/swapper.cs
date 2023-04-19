using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.ServiceProcess;
using System.Windows.Forms;
using static OculusAccountSwapper.Progressing;

namespace OculusAccountSwapper
{
    public partial class swapper : Form
    {
        public swapper()
        {
            InitializeComponent();
        }
        //Defining all needed public variables
        public static string path;
        public static string[] verify;
        public bool correct;
        public static string version;
        public static bool block;
        public static string file;
        public static bool versionthere;
        public static bool defaultPath;
        //Defining the webclient in a global scope
        WebClient webClient;

        //Checkbox for blocking oculus update
        private void blockupdate_CheckStateChanged(object sender, EventArgs e)
        {
            //Checks for checked state
            if (blockupdate.Checked)
            {
                //Sets block bool
                block = true;
                //Updates the checkbox name
                blockupdate.Text = "Blocked";
            }
            else
            {
                //Sets block bool
                block = false;
                //Updates the checkbox name
                blockupdate.Text = "Not Blocked";
            }
        }
        //Button Animations -- START
        private void browse_MouseEnter(object sender, EventArgs e)
        {
            browse.Image = Properties.Resources.pressed;
        }

        private void browse_MouseLeave(object sender, EventArgs e)
        {
            browse.Image = Properties.Resources.Butt_on;
        }
        private void startprocess_MouseEnter(object sender, EventArgs e)
        {
            startprocess.Image = Properties.Resources.pressed;
        }

        private void startprocess_MouseLeave(object sender, EventArgs e)
        {
            startprocess.Image = Properties.Resources.Butt_on;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.pressed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.Butt_on;
        }
        //Button Animation -- END

        //Allows user to define their own oculus path
        private void browse_Click(object sender, EventArgs e)
        {
            //Opens a folder browser dialog for the user to input their directory
            FolderBrowserDialog Fld = new FolderBrowserDialog();
            Fld.SelectedPath = path;
            Fld.ShowNewFolderButton = true;

            //If this was successful
            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                path = Fld.SelectedPath;
                verify = path.Split('\\');
                //If the path == Oculus
                if (verify[verify.Length - 1] == "Oculus")
                {
                    MessageBox.Show("It looks like you have the correct directory!");
                    correct = true;
                }
                //If the path directory name isn't oculus it throws an error
                else
                {
                    MessageBox.Show("Are you sure you have the correct directory? \nPlease make sure you have your \"Oculus\" directory selected...");
                    correct = false;
                }
            }
            else
            {
                // Selection canceled
                MessageBox.Show("Operation canceled.");
            }
        }
        //Sets global variable version to the version the user would like to get
        private void chooseversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            version = chooseversion.Text;
        }

        //Version swap process begins
        private void startprocess_Click(object sender, EventArgs e)
        {
            //If version is not selected
            if (version == null)
            {
                MessageBox.Show("Please select a version...");
                return;
            }
            //if user doesn't select a path
            else if (path == null)
            {
                MessageBox.Show("Please select a valid path...");
                return;
            }
            //If default location or correct true
            else if (correct == true | checkBox1.Checked)
            {
                //If user opts to block update
                if (block)
                {
                    //Defines service name to look for
                    string serviceName = "OVRService";

                    //Creates service controller for OVRService
                    ServiceController serviceController = new ServiceController(serviceName);

                    //Defines a timeout incase it takes too long searching
                    TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
                    try
                    {
                        //Attempts to stop the service
                        serviceController.Stop();

                        //Waits for SErviceControllerStatus.Stopped as the desired status and sets the timeout to ensure no hanging
                        serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    }
                    catch
                    {
                        //If service already stopped...
                        Console.WriteLine("Already OFF");
                    }
                    //Sends a messagebox making the user aware of this
                    MessageBox.Show("Downloading and Installing Update Blocker...\nPlease Click OK.");

                    //Defines the staging and temp zip name
                    string update = "noupdate.zip";
                    
                    //Creates the filepath including the zip in a string
                    string zipPath = path + "\\Versions\\" + update;
                    
                    //Looks for the file info of the zip file
                    FileInfo fi = new FileInfo(zipPath);

                    //If this file already exists
                    if (File.Exists(zipPath))
                    {
                        //Checks file size
                        if (fi.Length == 194)
                        {
                            try
                            {
                                //This will extract the 2 files to our C:/ProgramFiles/Oculus directory
                                ZipFile.ExtractToDirectory(zipPath, path);
                            }
                            catch
                            {
                                //If there is an exception it likely already has installed
                                Console.WriteLine("Already Installed...");
                            }
                            //Shows user that the update blacked was successful
                            MessageBox.Show("Update Blocker Extraction Completed!");
                            this.Dispose();

                            //Instantiates a local instance of Progressing as prog and shows it
                            Progressing prog = new Progressing();
                            prog.Show();
                        }
                        else
                        {
                            //Runs the delete block method to ensure the correct files are installed with no issue
                            delBlock();
                            
                            //Defines webClient as a new instance of WebClient
                            using (webClient = new WebClient())
                            {
                                //Sets download URI to google drive link to the zipped files
                                Uri remoteUri = new Uri("https://drive.google.com/uc?export=download&id=13U9w6wxbsSHuxS4Zk5ut1TUdQeyPpCA3");
                                try
                                {
                                    //Registers completed event handler
                                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                                    // Start downloading the file
                                    webClient.DownloadFileAsync(remoteUri, zipPath);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                    else
                    {
                        //Defines webClient as a new instance of WebClient
                        using (webClient = new WebClient())
                        {
                            //Sets download URI to google drive link to the zipped files
                            Uri remoteUri = new Uri("https://drive.google.com/uc?export=download&id=13U9w6wxbsSHuxS4Zk5ut1TUdQeyPpCA3");
                            try
                            {
                                //Registers completed event handler
                                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                                // Start downloading the file
                                webClient.DownloadFileAsync(remoteUri, zipPath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }
                }
                else if (!block)
                {
                    //Defines service name to look for
                    string serviceName = "OVRService";

                    //Creates service controller for OVRService
                    ServiceController serviceController = new ServiceController(serviceName);

                    //Defines a timeout incase it takes too long searching
                    TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
                    try
                    {
                        //Attempts to stop the service
                        serviceController.Stop();

                        //Waits for SErviceControllerStatus.Stopped as the desired status and sets the timeout to ensure no hanging
                        serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    }
                    catch
                    {
                        //If service already stopped...
                        Console.WriteLine("Already OFF");
                    }
                    this.Dispose();

                    //Instantiates a local instance of Progressing as prog and shows it
                    Progressing prog = new Progressing();
                    prog.Show();
                }
            }
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //If the download is canceled it sends a message box
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {                    
                //Defines the staging and temp zip name
                string update = "noupdate.zip";

                //Creates the filepath including the zip in a string
                string zipPath = path + "\\Versions\\" + update;

                MessageBox.Show("Download completed!\nExtracting files now!");
                try
                {
                    //This will extract the 2 files to our C:/ProgramFiles/Oculus directory
                    ZipFile.ExtractToDirectory(zipPath, path);
                }
                catch
                {
                    Console.WriteLine("Already Installed...");
                }
                MessageBox.Show("Update Blocker Extraction Completed!");
                this.Dispose();

                //Instantiates a local instance of Progressing as prog and shows it
                Progressing prog = new Progressing();
                prog.Show();
            }
        }
        //Goes back to welcome screen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //Instantiates a local instance of welcome as wel and shows it
            Welcome wel = new Welcome();
            wel.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //If default path is checked
            if (checkBox1.Checked)
            {
                defaultPath = true;
                checkBox1.Text = "Using Default Location";
                path = @"C:\Program Files\Oculus";
                browse.Visible = false;
            }
            //If default path isn't checked
            else
            {
                defaultPath = false;
                checkBox1.Text = "Choose Location Below";
                browse.Visible = true;
            }
        }

        private void swapper_FormClosed(object sender, FormClosedEventArgs e)
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
