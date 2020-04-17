using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace GameLauncher
{
    public partial class MainView : Form
    {

        private string gameName = "UrbanTerrorista";
        WebClient client = new WebClient() ;
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.serverIPText.Text = (string)Properties.Settings.Default["serverIp"];
            this.FilePathText.Text = (string)Properties.Settings.Default["gameFolder"];
            this.currentVersionLabel.Text = (string)Properties.Settings.Default["version"];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toLaunchExe = FilePathText.Text + "\\UrbanLegacy.exe";
            Process.Start(toLaunchExe);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.FilePathText.Text = fbd.SelectedPath + '\\' + gameName;
                Properties.Settings.Default["gameFolder"] = this.FilePathText.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void serverIPText_TextChanged(object sender, EventArgs e)
        {

        }


        private void serverIp_Submit(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddLogLine("Pinging " + this.serverIPText.Text + "...");
                if (PingHost(this.serverIPText.Text))
                {
                    AddLogLine("Successfull!");

                }
                else
                {
                    AddLogLine("Unuccessfull. Check the IP");
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                Properties.Settings.Default["serverIP"] = this.serverIPText.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void AddLogLine(string line)
        {
            this.LogTextBox.Text += line + "\n";

        }
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress,1);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        private void buttonPullData_Click(object sender, EventArgs e)
        {
            try
            {
                byte [] recv = client.DownloadData("http://"+serverIPText.Text +"/lastversion.txt");
                string encodedRecv = Encoding.Default.GetString(recv);
                AddLogLine(encodedRecv);
                if (encodedRecv != currentVersionLabel.Text)
                {
                    LaunchUpdate(encodedRecv);
                }


            }
            catch(Exception ex)
            {
                AddLogLine(ex.Message);
                AddLogLine("Can't retrieve last version :(");

            }
        }
        private void LaunchUpdate(string newVersion)
        {
            currentVersionLabel.Text = newVersion;
            string address = "http://" + serverIPText.Text + "/" + newVersion + ".zip";
            string localFile = FilePathText.Text + "\\last_version.zip";
            if (Directory.Exists(FilePathText.Text))
            {
                AddLogLine("Deleting game directory");
                    Directory.Delete(FilePathText.Text,true);

            }
            AddLogLine("Creating game directory..");
            Directory.CreateDirectory(FilePathText.Text);
            try
            {
                client.DownloadProgressChanged += (s, e) =>
                {
                    progressBar1.Value = e.ProgressPercentage;
                };
                client.DownloadFileCompleted += (s, e) =>
                {
                    
                    AddLogLine("Successfull!");
                    AddLogLine("Uncompressing Archive");
                    ZipFile.ExtractToDirectory(localFile, FilePathText.Text);
                    AddLogLine("Successfull!");

                    Properties.Settings.Default["version"] = this.currentVersionLabel.Text;
                    Properties.Settings.Default.Save();
                    AddLogLine("Update Successfull!");
                };
                AddLogLine("Downloading zipped game from \n" +address +" to\n"+localFile);
                client.DownloadFileAsync(new Uri(address), localFile);

            }
            catch(Exception ex)
            {
                AddLogLine("Failed");
                AddLogLine(ex.Message);

            }



        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
