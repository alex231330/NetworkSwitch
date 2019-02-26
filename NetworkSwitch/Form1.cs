using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace NetworkSwitch
{
    public partial class Form1 : Form
    {
        const string filepath = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private Configuration config;

        public Form1()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            using (StreamReader sr = new StreamReader(filepath))
            { 
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(null);
                    if (arr.Length > 1)
                    {
                        siteView.Items.Add(arr[1]);
                    }
                }
                sr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string site = getTxt.Text;
            if (!string.IsNullOrEmpty(site))
            {
                //Console.WriteLine("Added " + site);
                siteView.Items.Add(site);
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine("127.0.0.1\t" + site);
                    sw.Close();
                    //Console.WriteLine(File.ReadAllText(filepath));
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int choosedIndex = siteView.SelectedIndex;
            siteView.Items.RemoveAt(choosedIndex);
            List<string> allLines = File.ReadAllLines(filepath).ToList();
            //Console.WriteLine(File.ReadAllText(filepath));
            Console.WriteLine(choosedIndex);
            Console.WriteLine(allLines[choosedIndex]);
            allLines.Remove(allLines[choosedIndex]);
            File.WriteAllLines(filepath, allLines.ToArray());
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void getTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string login = usernameBoxR.Text;
            string pass1 = passwordBoxR1.Text;
            string pass2 = passwordBoxR2.Text;
            if (login != null && pass2 != null && pass2 != null)
            {
                if (String.Compare(pass1, pass2) == 0)
                {
                    config.AppSettings.Settings.Add(login, pass1);
                    
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string pass = ConfigurationManager.AppSettings[userNameBoxL.Text];
            if (pass != null)
            {
                Console.WriteLine(pass);
            }
            else
            {
                Console.WriteLine("No such user");
            }
        }

        private void tbFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Clear();
        }

        private void tbLeave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "")
            {
                if (tb.Tag.ToString() == "p")
                {
                    tb.Text = "Password";
                } else if (tb.Tag.ToString() == "u")
                {
                    tb.Text = "Username";
                }
            }
        }
    }
}
