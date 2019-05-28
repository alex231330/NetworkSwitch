using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using Microsoft.Win32;
using NetFwTypeLib;
using Microsoft.VisualBasic;
using System.Drawing;

namespace NetworkSwitch
{
    public partial class Form1 : Form
    {
        const string filepath = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private static System.Timers.Timer timer;
        private RegistryKey key;
        private String currentUsername = null;
        private int h, m, s;

        private static string GetDefaultBrowserPath()
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            return ((string)registryKey.GetValue(null, null)).Split('"')[1];
        }

        private void disableNet()
        {
            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRule.Description = "Used to block all internet access.";
            firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            firewallRule.Enabled = true;
            firewallRule.InterfaceTypes = "All";
            firewallRule.Name = "Block Internet";

            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
                Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(firewallRule);
            Console.WriteLine("Internet disabled");
        }

        private void undisableNet()
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Remove("Block Internet");
            Console.WriteLine("Internet enabled");
        }

        public Form1()
        {  
            InitializeComponent();
            this.Icon = new Icon("logo32.ico");
            undisableNet();
            key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SofuBlockerData");
            Console.WriteLine(GetDefaultBrowserPath());
            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(null);
                    if (arr.Length > 1)
                    {
                        if (!arr[1].Contains("www."))
                        {
                            siteView.Items.Add(arr[1]);
                        }
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
                siteView.Items.Add(site);
                //siteView.Items.Add("www." + site);

                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine("0.0.0.0\t" + site);
                    sw.WriteLine("0.0.0.0\t" + "www." + site);
                    sw.Close();
                }
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            int choosedIndex = siteView.SelectedIndex;
            if (choosedIndex != -1)
            {
                siteView.Items.RemoveAt(choosedIndex);
                List<string> allLines = File.ReadAllLines(filepath).ToList();

                Console.WriteLine(allLines.Count);
                Console.WriteLine(choosedIndex);
                Console.WriteLine(allLines[choosedIndex * 2]);
                Console.WriteLine(allLines[choosedIndex * 2 + 1]);

                allLines.Remove(allLines[(choosedIndex * 2) + 1]);
                allLines.Remove(allLines[(choosedIndex * 2)]);
                File.WriteAllLines(filepath, allLines.ToArray());
            }
        }

        private bool isReg = false;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string login = usernameBoxR.Text;
            string pass1 = passwordBoxR1.Text;
            string pass2 = passwordBoxR2.Text;

            if (login != null && pass2 != null && pass2 != null)
            {

                if (key.GetValue(login) != null)
                {
                    MessageBox.Show("This name has already been taken!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.Compare(pass1, pass2) == 0)
                {
                    key.SetValue(login.ToString(), pass1.GetHashCode());
                    MessageBox.Show("Successfully registered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Password must match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    
        private void loginBtn_Click(object sender, EventArgs e)
        {
            int password;
            if(key.GetValue(userNameBoxL.Text.ToString()) != null)
            {
                password = Convert.ToInt32(key.GetValue(userNameBoxL.Text.ToString()));
                if (password == passwordBoxL.Text.ToString().GetHashCode())
                {
                    currentUsername = userNameBoxL.Text.ToString();
                    label2.Text = "Loggined";
                    clsBtn.Enabled = true;
                    siteView.Enabled = true;
                    addBtn.Enabled = true;
                    deleteBtn.Enabled = true;
                    userNameBoxL.Enabled = false;
                    passwordBoxL.Enabled = false;
                    loginBtn.Enabled = false;
                    timer_start_btn.Enabled = true;
                    timer_stop_btn.Enabled = true;
                    hoursBox.Enabled = true;
                    minutesBox.Enabled = true;
                    secsBox.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No such user!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void clsBtn_Click(object sender, EventArgs e)
        {       
            System.IO.File.WriteAllText(filepath, string.Empty);
            siteView.Items.Clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Process.Start(GetDefaultBrowserPath(), "paypal.me/SofuBlocker");

        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s--;
                if (s <= 0)
                {
                    if (m > 0 || h > 0)
                    {
                        if (m == 0)
                        {
                            if (h >= 0)
                            {
                                h = h - 1;
                                m = 60;
                                if (h < 0)
                                {
                                    h = 0;
                                }
                            }
                        }
                        m = m - 1;
                        s = 59;
                        hoursBox.Text = h.ToString();
                        minutesBox.Text = m.ToString();
                        secsBox.Text = s.ToString();
                        if (m < 0)
                        {
                            m = 0;
                        }

                    }
                    if (s < 0)
                    {
                        s = 0;
                    }

                    //timer.Stop();
                }
                hoursBox.Text = h.ToString();
                minutesBox.Text = m.ToString();
                secsBox.Text = s.ToString();
                Console.WriteLine(flag);
                if((h == 0 && m == 0 && s == 0) || flag)
                {
                    flag = false;
                    statLabel.Text = "Current status: Internet enabled";
                    undisableNet();
                    Console.WriteLine("Timer finished");
                    timer.Stop();
                    h = 0;
                    m = 0;
                    s = 0;
                }
            }));
        }

        private bool flag = false;

        private void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentUsername != null)
            {
                PasswordForm dialog = new PasswordForm(currentUsername);
                DialogResult res = dialog.ShowDialog();
                Console.WriteLine(res.ToString());
                if (res == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    //e.Cancel = false;
                    undisableNet();
                    System.Environment.Exit(1);
                }
                if (res == DialogResult.Abort)
                {
                    Console.WriteLine("Abort");
                    dialog.Close();
                    e.Cancel = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool isStopped = true;

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!isStopped)
            {
                undisableNet();
                flag = true;
                h = 0;
                m = 0;
                s = 0;
            }else
            {
                flag = false;
                statLabel.Text = "Current status: Internet enabled";
                undisableNet();
                Console.WriteLine("Timer finished");
                timer.Stop();
                h = 0;
                m = 0;
                s = 0;
                hoursBox.Text = h.ToString();
                minutesBox.Text = m.ToString();
                secsBox.Text = s.ToString();
            }
        }

        private void passwordTab_Click(object sender, EventArgs e)
        {

        }

        private void timer_start_btn_Click(object sender, EventArgs e)
        {
            flag = false;
            isStopped = false;
            statLabel.Text = "Current status: Internet disabled";
            disableNet();
            h = int.Parse(hoursBox.Text);
            m = int.Parse(minutesBox.Text);
            s = int.Parse(secsBox.Text);
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.Start();
        }

        private void timer_stop_btn_Click(object sender, EventArgs e)
        {
            isStopped = true;
            timer.Stop();
        }
    }
}
