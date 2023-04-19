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

namespace OculusAccountSwapper
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            swapper s = new swapper();
            s.Show();
            this.Dispose();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            Welcome s = new Welcome();
            s.Show();
            this.Dispose();
        }
        private void manager_MouseEnter(object sender, EventArgs e)
        {
            manager.Image = Properties.Resources.pressed;
        }

        private void manager_MouseLeave(object sender, EventArgs e)
        {
            manager.Image = Properties.Resources.Butt_on;
        }

        private void version_MouseEnter(object sender, EventArgs e)
        {
            version.Image = Properties.Resources.pressed;
        }

        private void version_MouseLeave(object sender, EventArgs e)
        {
            version.Image = Properties.Resources.Butt_on;
        }

        private void Finish_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Killmenowplease");
        }

        private void Finish_FormClosed(object sender, FormClosedEventArgs e)
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
