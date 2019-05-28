namespace NetworkSwitch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.blockTab = new MetroFramework.Controls.MetroTabPage();
            this.clsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siteView = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.passwordTab = new MetroFramework.Controls.MetroTabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordBoxR2 = new System.Windows.Forms.TextBox();
            this.passwordBoxR1 = new System.Windows.Forms.TextBox();
            this.usernameBoxR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBoxL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameBoxL = new System.Windows.Forms.TextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.stopBtn = new System.Windows.Forms.Button();
            this.statLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.secsBox = new System.Windows.Forms.TextBox();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.timer_stop_btn = new System.Windows.Forms.Button();
            this.timer_start_btn = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.blockTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.passwordTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 64);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.passwordTab);
            this.metroTabControl1.Controls.Add(this.blockTab);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 70);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(918, 402);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // blockTab
            // 
            this.blockTab.Controls.Add(this.clsBtn);
            this.blockTab.Controls.Add(this.panel2);
            this.blockTab.Controls.Add(this.addBtn);
            this.blockTab.Controls.Add(this.label1);
            this.blockTab.Controls.Add(this.siteView);
            this.blockTab.Controls.Add(this.panel1);
            this.blockTab.Controls.Add(this.deleteBtn);
            this.blockTab.HorizontalScrollbarBarColor = true;
            this.blockTab.HorizontalScrollbarHighlightOnWheel = false;
            this.blockTab.HorizontalScrollbarSize = 10;
            this.blockTab.Location = new System.Drawing.Point(4, 38);
            this.blockTab.Name = "blockTab";
            this.blockTab.Size = new System.Drawing.Size(910, 360);
            this.blockTab.TabIndex = 0;
            this.blockTab.Text = "Block list";
            this.blockTab.VerticalScrollbarBarColor = true;
            this.blockTab.VerticalScrollbarHighlightOnWheel = false;
            this.blockTab.VerticalScrollbarSize = 10;
            // 
            // clsBtn
            // 
            this.clsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(198)))), ((int)(((byte)(175)))));
            this.clsBtn.Enabled = false;
            this.clsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsBtn.Location = new System.Drawing.Point(357, 326);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(124, 33);
            this.clsBtn.TabIndex = 14;
            this.clsBtn.Text = "Clear Hosts File";
            this.clsBtn.UseVisualStyleBackColor = false;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(198)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.getTxt);
            this.panel2.Location = new System.Drawing.Point(289, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 44);
            this.panel2.TabIndex = 13;
            // 
            // getTxt
            // 
            this.getTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getTxt.Location = new System.Drawing.Point(7, 12);
            this.getTxt.Name = "getTxt";
            this.getTxt.Size = new System.Drawing.Size(271, 22);
            this.getTxt.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(198)))), ((int)(((byte)(175)))));
            this.addBtn.Enabled = false;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(201, 52);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 44);
            this.addBtn.TabIndex = 8;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Block lists";
            // 
            // siteView
            // 
            this.siteView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siteView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siteView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.siteView.Enabled = false;
            this.siteView.FormattingEnabled = true;
            this.siteView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siteView.ItemHeight = 16;
            this.siteView.Location = new System.Drawing.Point(296, 117);
            this.siteView.Name = "siteView";
            this.siteView.ScrollAlwaysVisible = true;
            this.siteView.Size = new System.Drawing.Size(271, 194);
            this.siteView.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(198)))), ((int)(((byte)(175)))));
            this.panel1.Location = new System.Drawing.Point(289, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 210);
            this.panel1.TabIndex = 12;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(198)))), ((int)(((byte)(175)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(584, 52);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 44);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // passwordTab
            // 
            this.passwordTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.passwordTab.Controls.Add(this.label7);
            this.passwordTab.Controls.Add(this.label4);
            this.passwordTab.Controls.Add(this.registerBtn);
            this.passwordTab.Controls.Add(this.passwordBoxR2);
            this.passwordTab.Controls.Add(this.passwordBoxR1);
            this.passwordTab.Controls.Add(this.usernameBoxR);
            this.passwordTab.Controls.Add(this.label3);
            this.passwordTab.Controls.Add(this.loginBtn);
            this.passwordTab.Controls.Add(this.passwordBoxL);
            this.passwordTab.Controls.Add(this.label2);
            this.passwordTab.Controls.Add(this.userNameBoxL);
            this.passwordTab.HorizontalScrollbarBarColor = true;
            this.passwordTab.HorizontalScrollbarHighlightOnWheel = false;
            this.passwordTab.HorizontalScrollbarSize = 10;
            this.passwordTab.Location = new System.Drawing.Point(4, 38);
            this.passwordTab.Name = "passwordTab";
            this.passwordTab.Size = new System.Drawing.Size(910, 360);
            this.passwordTab.TabIndex = 1;
            this.passwordTab.Text = "Password";
            this.passwordTab.VerticalScrollbarBarColor = true;
            this.passwordTab.VerticalScrollbarHighlightOnWheel = false;
            this.passwordTab.VerticalScrollbarSize = 10;
            this.passwordTab.Click += new System.EventHandler(this.passwordTab_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(437, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "You need to be logged in to use the blocker!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "We don\'t store the information.  \r\nDont forget  your username and password!";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(450, 167);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(166, 40);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passwordBoxR2
            // 
            this.passwordBoxR2.BackColor = System.Drawing.Color.White;
            this.passwordBoxR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBoxR2.Location = new System.Drawing.Point(450, 139);
            this.passwordBoxR2.Name = "passwordBoxR2";
            this.passwordBoxR2.PasswordChar = '*';
            this.passwordBoxR2.Size = new System.Drawing.Size(166, 22);
            this.passwordBoxR2.TabIndex = 9;
            this.passwordBoxR2.Tag = "p";
            this.passwordBoxR2.Text = "Password";
            this.passwordBoxR2.Enter += new System.EventHandler(this.tbFocus);
            this.passwordBoxR2.Leave += new System.EventHandler(this.tbLeave);
            // 
            // passwordBoxR1
            // 
            this.passwordBoxR1.BackColor = System.Drawing.Color.White;
            this.passwordBoxR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBoxR1.Location = new System.Drawing.Point(450, 106);
            this.passwordBoxR1.Name = "passwordBoxR1";
            this.passwordBoxR1.PasswordChar = '*';
            this.passwordBoxR1.Size = new System.Drawing.Size(166, 22);
            this.passwordBoxR1.TabIndex = 8;
            this.passwordBoxR1.Tag = "p";
            this.passwordBoxR1.Text = "Password";
            this.passwordBoxR1.Enter += new System.EventHandler(this.tbFocus);
            this.passwordBoxR1.Leave += new System.EventHandler(this.tbLeave);
            // 
            // usernameBoxR
            // 
            this.usernameBoxR.BackColor = System.Drawing.Color.White;
            this.usernameBoxR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBoxR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBoxR.Location = new System.Drawing.Point(450, 77);
            this.usernameBoxR.Name = "usernameBoxR";
            this.usernameBoxR.Size = new System.Drawing.Size(166, 22);
            this.usernameBoxR.TabIndex = 7;
            this.usernameBoxR.Tag = "u";
            this.usernameBoxR.Text = "Username";
            this.usernameBoxR.Enter += new System.EventHandler(this.tbFocus);
            this.usernameBoxR.Leave += new System.EventHandler(this.tbLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Register";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(39, 135);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(166, 37);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Let me in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordBoxL
            // 
            this.passwordBoxL.BackColor = System.Drawing.Color.White;
            this.passwordBoxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBoxL.Location = new System.Drawing.Point(39, 106);
            this.passwordBoxL.Name = "passwordBoxL";
            this.passwordBoxL.PasswordChar = '*';
            this.passwordBoxL.Size = new System.Drawing.Size(166, 22);
            this.passwordBoxL.TabIndex = 4;
            this.passwordBoxL.Tag = "p";
            this.passwordBoxL.Text = "Password";
            this.passwordBoxL.Enter += new System.EventHandler(this.tbFocus);
            this.passwordBoxL.Leave += new System.EventHandler(this.tbLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // userNameBoxL
            // 
            this.userNameBoxL.BackColor = System.Drawing.Color.White;
            this.userNameBoxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameBoxL.Location = new System.Drawing.Point(39, 77);
            this.userNameBoxL.Name = "userNameBoxL";
            this.userNameBoxL.Size = new System.Drawing.Size(166, 22);
            this.userNameBoxL.TabIndex = 2;
            this.userNameBoxL.Tag = "u";
            this.userNameBoxL.Text = "Username";
            this.userNameBoxL.Enter += new System.EventHandler(this.tbFocus);
            this.userNameBoxL.Leave += new System.EventHandler(this.tbLeave);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.stopBtn);
            this.metroTabPage1.Controls.Add(this.statLabel);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.secsBox);
            this.metroTabPage1.Controls.Add(this.minutesBox);
            this.metroTabPage1.Controls.Add(this.hoursBox);
            this.metroTabPage1.Controls.Add(this.timer_stop_btn);
            this.metroTabPage1.Controls.Add(this.timer_start_btn);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(910, 360);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Timer";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(260, 198);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(86, 33);
            this.stopBtn.TabIndex = 10;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.BackColor = System.Drawing.Color.Transparent;
            this.statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.Location = new System.Drawing.Point(271, 94);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(397, 31);
            this.statLabel.TabIndex = 9;
            this.statLabel.Text = "Current status: Internet enabled";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 23);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(503, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Here you can turn off the internet for a while";
            // 
            // secsBox
            // 
            this.secsBox.Enabled = false;
            this.secsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secsBox.Location = new System.Drawing.Point(198, 84);
            this.secsBox.Name = "secsBox";
            this.secsBox.Size = new System.Drawing.Size(56, 58);
            this.secsBox.TabIndex = 7;
            this.secsBox.Text = "00";
            // 
            // minutesBox
            // 
            this.minutesBox.Enabled = false;
            this.minutesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesBox.Location = new System.Drawing.Point(133, 84);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(59, 58);
            this.minutesBox.TabIndex = 6;
            this.minutesBox.Text = "00";
            // 
            // hoursBox
            // 
            this.hoursBox.Enabled = false;
            this.hoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursBox.Location = new System.Drawing.Point(70, 84);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(57, 58);
            this.hoursBox.TabIndex = 5;
            this.hoursBox.Text = "00";
            // 
            // timer_stop_btn
            // 
            this.timer_stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.timer_stop_btn.Enabled = false;
            this.timer_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timer_stop_btn.Location = new System.Drawing.Point(172, 198);
            this.timer_stop_btn.Name = "timer_stop_btn";
            this.timer_stop_btn.Size = new System.Drawing.Size(82, 33);
            this.timer_stop_btn.TabIndex = 4;
            this.timer_stop_btn.Text = "Pause";
            this.timer_stop_btn.UseVisualStyleBackColor = false;
            this.timer_stop_btn.Click += new System.EventHandler(this.timer_stop_btn_Click);
            // 
            // timer_start_btn
            // 
            this.timer_start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.timer_start_btn.Enabled = false;
            this.timer_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timer_start_btn.Location = new System.Drawing.Point(70, 198);
            this.timer_start_btn.Name = "timer_start_btn";
            this.timer_start_btn.Size = new System.Drawing.Size(91, 33);
            this.timer_start_btn.TabIndex = 3;
            this.timer_start_btn.Text = "Start";
            this.timer_start_btn.UseVisualStyleBackColor = false;
            this.timer_start_btn.Click += new System.EventHandler(this.timer_start_btn_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.button1);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(910, 360);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "Donate";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Donate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(863, 108);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 543);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sofu Blocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.blockTab.ResumeLayout(false);
            this.blockTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.passwordTab.ResumeLayout(false);
            this.passwordTab.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage blockTab;
        private MetroFramework.Controls.MetroTabPage passwordTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox getTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox siteView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox passwordBoxR2;
        private System.Windows.Forms.TextBox passwordBoxR1;
        private System.Windows.Forms.TextBox usernameBoxR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordBoxL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameBoxL;
        private System.Windows.Forms.Button clsBtn;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button timer_stop_btn;
        private System.Windows.Forms.Button timer_start_btn;
        private System.Windows.Forms.TextBox secsBox;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button stopBtn;
    }
}

