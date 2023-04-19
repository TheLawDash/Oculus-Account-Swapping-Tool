using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Web;
using System.Windows.Forms;
using static OculusAccountSwapper.BorderChange;

namespace OculusAccountSwapper
{
    internal static class Program
    {
        //Creating public string array for parameters 
        public static string[] parameters;
        [STAThread]
        static void Main(string[] args)
        {
            //Sets the parameters == to args which get passed through the URL handler
            parameters = args;
            if (parameters.Length == 0)
            {
                //Checking the WindowsIdentity of the user
                WindowsIdentity wi = WindowsIdentity.GetCurrent();

                //Gathers windows principal of the Windows Identity
                WindowsPrincipal wp = new WindowsPrincipal(wi);

                //Checks to see if program was run in administrator
                bool runAsAdmin = wp.IsInRole(WindowsBuiltInRole.Administrator);
                if (!runAsAdmin)
                {
                    //Getting assembly process Info
                    ProcessStartInfo processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);

                    // The following properties run the new process as administrator
                    processInfo.UseShellExecute = true;
                    processInfo.Verb = "runas";

                    // Start the new process
                    Process.Start(processInfo);
                    // Shut down the current process
                    Application.Exit();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Welcome());
                }
            }
            else
            {
                //If parameters are present
                try
                {
                    //Gets the file path for oculus and meta accounts
                    string metapath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MetaEchoData.txt";
                    string ocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EchoData.txt";

                    //Decodes the URL Protocol to prepare for parsing
                    string urlDecode = HttpUtility.UrlDecode(parameters[0]);
                    
                    //Parsing the URL Protocol arguements
                    string[] paramSplit = urlDecode.Split('/');

                    //If the url protocol is for a meta account it will go into here
                    if (paramSplit[0] == "metaswapper:")
                    {
                        //Encrypts password string using encrypt function
                        string encrypted = Encrypt(paramSplit[4], pw);

                        //Makes a local string list of metapath accounts
                        List<string> lines = File.ReadAllLines(metapath).ToList();

                        //Adds the new account to the old meta account list
                        lines.Add(paramSplit[2] + "," + paramSplit[3] + "," + encrypted);

                        //Writes the updated version of list
                        File.WriteAllLines(metapath, lines);

                        //Alerts the user that their account has been added
                        MessageBox.Show("Account has successfully been added!");

                        //Exits the program
                        System.Windows.Forms.Application.Exit();
                    }

                    //If the url protocol is for a oculus account it will go into here
                    else if (paramSplit[0] == "accountswapper:")
                    {
                        //Makes a local string list of ocpath accounts
                        List<string> lines = File.ReadAllLines(ocpath).ToList();
                        
                        //Encrypts password string using encrypt function
                        string encrypted = Encrypt(paramSplit[4], pw);

                        //Adds the new account to the old meta account list
                        lines.Add(paramSplit[2] + "," + paramSplit[3] + "," + encrypted);
                        
                        //Writes the updated version of list
                        File.WriteAllLines(ocpath, lines);

                        //Alerts the user that their account has been added
                        MessageBox.Show("Account has successfully been added!");
                        
                        //Exits the program
                        System.Windows.Forms.Application.Exit();
                    }
                }
                catch(Exception ex)
                {
                    //Arguements are not valid
                    Console.WriteLine("No Arguements...");
                }
            }
        }
    }
}
