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

namespace GameLauncher
{
    public partial class MainView : Form
    {

        private string gameName = "UrbanTerrorista";
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.serverIPText.Text = (string)Properties.Settings.Default["serverIp"];
            this.FilePathText.Text = (string)Properties.Settings.Default["gameFolder"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
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
                Properties.Settings.Default["serverIp"] = this.serverIPText.Text;
                AddLogLine("Pinging " + this.serverIPText.Text + "...");
                if (PingHost(this.serverIPText.Text))
                {
                    AddLogLine("Successfull!");

                    Properties.Settings.Default["serverIP"] = this.serverIPText.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    AddLogLine("Unuccessfull. Check the IP");
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
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
    }
}
