using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                this.LogTextBox.Text += "Pinging " + this.serverIPText.Text + "...";
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
