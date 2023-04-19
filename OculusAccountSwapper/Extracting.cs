using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using static OculusAccountSwapper.swapper;
using ZipFile = System.IO.Compression.ZipFile;

namespace OculusAccountSwapper
{
    public partial class Extracting : Form
    {
        public Extracting()
        {
            InitializeComponent();
        }
        private async Task Extract()
        {
            string zipFilePath = path + "\\Versions\\" + file;
            string extractionPath = path;
            using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile(zipFilePath))
            {
                count();
                zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zipProgress);
                zip.ExtractAll(extractionPath);
            }
        }
        private int fileIndex = 0;
        private int counta = 0;
        public List<string> files = new List<string>();
        private void count()
        {
            string zipFilePath = path + "\\Versions\\" + file;
            using (ZipArchive archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Read))
            {

                // We count only named (i.e. that are with files) entries
                foreach (var entry in archive.Entries)
                {

                    files.Add(entry.FullName);
                    counta += 1;
                }
                Console.WriteLine("Count finished");
            }
        }
        private void UpdateProgressBar(ExtractProgressEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ExtractProgressEventArgs>(UpdateProgressBar), e);
                return;
            }
            if (e.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
            {

                this.textBox_ExtractFile.Text = files[fileIndex];
                this.progressBar_Individual.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                Console.WriteLine(progressBar_Individual.Value.ToString());
            }

            else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
            {
                this.progressBar_Individual.Value = 100;
                Console.WriteLine("Finished Zip");

            }
            else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractEntry)
            {
                fileIndex += 1;
                this.progressBar_Total.Value = (fileIndex * 100) / counta;
            }
        }
        private void zipProgress(object sender, ExtractProgressEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ExtractProgressEventArgs>(UpdateProgressBar), e);
                return;
            }
            if (e.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
            {

                this.textBox_ExtractFile.Text = files[fileIndex];
                this.progressBar_Individual.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                Console.WriteLine(progressBar_Individual.Value.ToString());
            }

            else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
            {
                this.progressBar_Individual.Value = 100;
                Console.WriteLine("Finished Zip");

            }
            else if(e.EventType == ZipProgressEventType.Extracting_AfterExtractEntry)
            {
                fileIndex += 1;
                this.progressBar_Total.Value = (fileIndex * 100) / counta;
            }
        }
        private async Task enable()
        {
            string serviceName = "OVRService";
            ServiceController serviceController = new ServiceController(serviceName);
            TimeSpan timeout = TimeSpan.FromSeconds(1);
            try
            {
                serviceController.Start();
                serviceController.WaitForStatus(ServiceControllerStatus.StartPending, timeout);
            }
            catch
            {
                Console.WriteLine("This defintely should never happen.");
            }
        }

        private async void Extracting_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            await Task.Run(() => { Extract(); }); ;
            Finish f = new Finish();
            f.Show();
            this.Hide();
        }

        private void Extracting_FormClosed(object sender, FormClosedEventArgs e)
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
