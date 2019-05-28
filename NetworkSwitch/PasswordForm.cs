using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkSwitch
{
    public partial class PasswordForm : Form
    {
        string username;

        public PasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        bool isPassOk = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Username " + username);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SofuBlockerData");
            int pass = Convert.ToInt32(key.GetValue(username));
            Console.WriteLine(username + " " + pass);
            if (pass == textBox1.Text.ToString().GetHashCode())
            {
                isPassOk = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Inivalid password.");
                textBox1.Focus();
            }
        }

        private void PasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPassOk)
            {
                Console.WriteLine("Closing");
                this.DialogResult = DialogResult.Abort;
            }
            
            //e.Cancel = (e.CloseReason == CloseReason.UserClosing);

        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
