using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OculusAccountSwapper.swapper;

namespace OculusAccountSwapper
{
    public partial class Progressing : Form
    {
        public Progressing()
        {
            InitializeComponent();
        }

        //Defining public boolean
        public static bool finished;
        public static Label percentLabel;
        public static ProgressBar progBar;

        //Downloading Zipped folders 
        private async Task downloadZip()
        {
            //Array of supported versions
            string[] versions = { "Oculus Version v27.0", "Oculus Version v28.0", "Oculus Version v29.0", "Oculus Version v30.0", "Oculus Version v31.0", "Oculus Version v42.0", "Oculus Version v43.0", "Oculus Version v44.0", "Oculus Version v46.0", "Oculus Version v47.0", "Oculus Version v49.0 (current)" };
            
            //Array of available download links for each version
            string[] downloads = { "https://drive.google.com/u/2/uc?id=1TuPtnoZy57TPIuc__rnDHmktdE-j00YU&export=download&confirm=t&uuid=47614255-5781-4161-a30d-4a125b342c3c", "https://drive.google.com/u/2/uc?id=1zZjoQl4KhFnyC1-exfUF6oqEl1dN7fjc&export=download&confirm=t&uuid=0137f080-c2c1-4461-b3af-32af8c72fbe7", "https://drive.google.com/u/4/uc?id=1ns8iBicr1beNBEkwJ9_Y8OeeFdYIjwbG&export=download&confirm=t&uuid=ceee3ebe-2152-4cdb-aaa4-db5e4aff1536", "https://drive.google.com/u/0/uc?id=17pR0vEqfdT3cq0l0BwhCSRAPV9pHJjH5&export=download&confirm=t&uuid=314ac9d5-8f55-48e8-853b-ab2c61852eec", "https://drive.google.com/u/4/uc?id=1m6uUwXJghYTkkmrGSzgs0PhIHgqLlhD-&export=download&confirm=t&uuid=2e58323c-02cb-4d37-9ac4-661c4f2514e3", "https://drive.google.com/u/5/uc?id=1_VpncwhpXnuMh2Y30bWfKpCHW1jBpEgW&export=download&confirm=t&uuid=ed05af2a-0767-4728-bf95-2573b2b2cda6", "https://drive.google.com/u/1/uc?id=1voFnt46OVaYBK8NpzeTaI6Fb6kI4lq7p&export=download&confirm=t&uuid=662ebdef-8465-4616-b67a-cb27d3b70cea", "https://drive.google.com/u/1/uc?id=1AMPuk-QjEPUgWfLZDuweeppEGL1uN8JO&export=download&confirm=t&uuid=c927eeba-5e48-4a47-b187-43c0508dea9f", "https://drive.google.com/u/1/uc?id=1EHeb0V6ia2jaYxmesYWOu3kZpIjbley2&export=download&confirm=t&uuid=34a167eb-aca9-407f-bb87-43841ba0e579", "https://drive.google.com/u/1/uc?id=1bReLp5ZtAbia2-Arv8_Of5CCCxQEorV-&export=download&confirm=t&uuid=0c88cc76-1b00-4d15-99bd-a4de1b68a52a&at=AHV7M3cTfwdRaKlW3LSbMmt6Mqb-:1670991944982", "https://drive.google.com/u/0/uc?id=161gf3OzrMKkEoONdasgfu5QsilSQdyx8&export=download&confirm=t&uuid=9c866351-a054-43f3-84bd-381d334a002d&at=ALgDtsxidO8-tdvRMWc__JXkp9lO:1678130191169" };
            
            //Array of the zipped folder names with extension
            string[] zipNames = { "Oculus_v27.zip", "Oculus_v28.zip", "Oculus_v29.zip", "Oculus_v30.zip", "Oculus_v31.zip", "Oculus_v42.zip", "Oculus_v43.zip", "Oculus_v44.zip", "Oculus_v46.zip", "Oculus_v47.zip", "Oculus_v49.zip" };
            
            //Array of the byte sizes for each version to ensure it was properly downloaded
            Int64[] zipSizes = { 6378209458, 5385745346, 7113614879, 6251985369, 5380861544, 6399220003, 6399220003, 5415428096, 5417488384, 5992857604, 5461467136 };
            
            //Uses a foreach loop to find the index of the selected version
            int index = 0;
            foreach(string value in versions)
            {
                if(value == version)
                {
                    break;
                }
                index+=1;
            }

            //Defines a Uri variable and initializes the Uri class with the specified URL
            Uri downloadURI = new Uri(downloads[index]);

            //Setting file name to string variable
            string fileName = path + "\\Versions\\" + zipNames[index];

            //Creates directory if it doesn't exist
            if(!Directory.Exists(path+"\\Versions"))
            {
                DirectoryInfo di = Directory.CreateDirectory(path + "\\Versions");
            }

            //Set's string to the zipped file's name
            file = zipNames[index];

            //Get's all the file paths from the Versions directory and saves it to a string array
            string[] files = Directory.GetFiles(path + "\\Versions");

            //Cycles through each itteration of the files array
            foreach (string f in files)
            {
                //If the file matches the wanted file
                if (path + "\\Versions\\" + file == f)
                {
                    //Gaters the file size
                    FileInfo fi = new FileInfo(f);
                    long size = fi.Length;
                    //If the file downloaded correctly it will skip the installation and sets the version there boolean to true
                    if (size == zipSizes[index])
                    {
                        Console.WriteLine("Already Downloaded!");
                        versionthere = true;
                    }
                    //if it doesn't match it will delete the un-finished installation and sets the version there boolean to false
                    else
                    {
                        fi.Delete();
                        MessageBox.Show("It looks like the download was previously interrupted, re-downloading files...");
                        versionthere = false;
                    }
                }
            }
            if (versionthere)
            {
                MessageBox.Show("File already downloaded!\nExtracting now!");
                Console.WriteLine("It's all good!");
            }
            else
            {
                //If the version has not been successfully downloaded
                using (webClient = new WebClient())
                {
                    //Sets event handlers for progress changed and completed
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                    try
                    {
                        // Start downloading the file
                        webClient.DownloadFileAsync(downloadURI, fileName);
                        while (!finished)
                        {
                            Thread.Sleep(500);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //Had issues with attempting to update the UI thread without it throwing an exception error
            if (InvokeRequired)
            {
                //If the invoke is needed it will run the UpdateProgressBar as a new action while passing through e.ProgressPercentage
                Invoke(new Action<int>(UpdateProgressBar), e.ProgressPercentage);
                return;
            }
            // Update the progressbar percentage.
            progBar.Value = e.ProgressPercentage;
            percentLabel.Text = "Downloading " + e.ProgressPercentage.ToString() + "%";
        }
        private void UpdateProgressBar(int percent)
        {
            //Had issues with attempting to update the UI thread without it throwing an exception error
            if (InvokeRequired)
            {
                //If the invoke is needed it will run the UpdateProgressBar as a new action while passing through percent
                Invoke(new Action<int>(UpdateProgressBar), percent);
                return;
            }
            // Update the progressbar percentage.
            progressBar.Value = percent;
            percentLabel.Text = "Downloading " + percent.ToString() + "%";
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //If the download was canceled while still installing
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            //If there was an error during installation
            else if (e.Error != null)
            {
                //Typically the only error that gets thrown is due to an excessive amount of downloads...
                MessageBox.Show("You've attempted to download this version too many times, please try again later or use a VPN...");
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                //If nothing breaks it will hit this
                MessageBox.Show("Download completed!\nExtracting files now!");
                finished = true;
            }
        }
        public static void delBlock()
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

            //Gets directory info of @"C:\Program Files\Oculus"
            DirectoryInfo di = new DirectoryInfo(path);

            //Navigates through each directory and looks for these 2
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                if (dir.Name == "Staging")
                {
                    //if found it deletes
                    dir.Delete(true);
                }
                else if (dir.Name == "tmp")
                {
                    //if found it deletes
                    dir.Delete(true);
                }
            }
            //Navigates through each file and looks for these 2
            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Name == "Staging")
                {
                    //if found it deletes
                    file.Delete();
                }
                else if (file.Name == "tmp")
                {
                    //if found it deletes
                    file.Delete();
                }
            }
        }
        public async Task delOld()
        {
            //Looks for the OVRService 
            string serviceName = "OVRService";
            //Creates a serviceController with a new instance of the ServiceController class
            ServiceController serviceController = new ServiceController(serviceName);

            //Defines the timeout span to 1 second
            TimeSpan timeout = TimeSpan.FromSeconds(1);
            //Trys to stop the process 
            try
            {
                serviceController.Stop();
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch
            {
                //Throws an exception if the process is not stopped...
                Console.WriteLine("Already OFF");
            }

            //Creates a directoryInfo variable called di and sets it to the Oculus Path
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            //Itteraties through each directory
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                //If this exists it will delete
                if (dir.Name == "Manifests")
                {
                    dir.Delete(true);
                }
                //If this exists it will delete
                else if (dir.Name == "Support")
                {
                    dir.Delete(true);
                }
                else
                {
                    Console.WriteLine(dir.Name + " is safe for now...");
                }
            }
            //If the user doesn't want the updates blocked
            if(!block)
            {
                //Defines a file info variable for the desired path
                FileInfo f = new FileInfo(path);

                //Itterates through each file in that path
                foreach (FileInfo ff in di.GetFiles())
                {
                    //If this exists it will delete
                    if (ff.Name == "Staging")
                    {
                        ff.Delete();
                    }
                    //If this exists it will delete
                    else if (ff.Name == "tmp")
                    {
                        ff.Delete();
                    }
                }

            }
        }
        WebClient webClient;
        private async void Progressing_Shown(object sender, EventArgs e)
        {
            //Used public variables to test something, just gonna keep it as this
            percentLabel = percent;
            progBar = progressBar;
            //Sets Version ID
            string versionTemp = version;
            //Runs the function asynchronously
            await Task.Run(() =>
            {
                downloadZip();
            });
            //This will delete the necesary local files upon successful download
            await delOld();
            //Makes local instance of the form Extracting
            Extracting extract = new Extracting();
            //Shows Form
            extract.Show();
            //Disposes of current
            this.Dispose();
        }
        private void Progressing_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
