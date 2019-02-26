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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.blockTab = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siteView = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.passwordTab = new MetroFramework.Controls.MetroTabPage();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordBoxR2 = new System.Windows.Forms.TextBox();
            this.passwordBoxR1 = new System.Windows.Forms.TextBox();
            this.usernameBoxR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBoxL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameBoxL = new System.Windows.Forms.TextBox();
            this.metroTabControl1.SuspendLayout();
            this.blockTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.passwordTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 52);
            this.panel3.TabIndex = 7;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.blockTab);
            this.metroTabControl1.Controls.Add(this.passwordTab);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 59);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(918, 414);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // blockTab
            // 
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
            this.blockTab.Size = new System.Drawing.Size(910, 372);
            this.blockTab.TabIndex = 0;
            this.blockTab.Text = "Block list";
            this.blockTab.VerticalScrollbarBarColor = true;
            this.blockTab.VerticalScrollbarHighlightOnWheel = false;
            this.blockTab.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
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
            this.addBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(201, 52);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 44);
            this.addBtn.TabIndex = 8;
            this.addBtn.UseVisualStyleBackColor = false;
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
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
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
            this.deleteBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(584, 52);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 44);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTab
            // 
            this.passwordTab.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.passwordTab.Size = new System.Drawing.Size(910, 372);
            this.passwordTab.TabIndex = 1;
            this.passwordTab.Text = "Password";
            this.passwordTab.VerticalScrollbarBarColor = true;
            this.passwordTab.VerticalScrollbarHighlightOnWheel = false;
            this.passwordTab.VerticalScrollbarSize = 10;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(450, 167);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(166, 40);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "Let me in";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passwordBoxR2
            // 
            this.passwordBoxR2.BackColor = System.Drawing.Color.SpringGreen;
            this.passwordBoxR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBoxR2.Location = new System.Drawing.Point(450, 139);
            this.passwordBoxR2.Name = "passwordBoxR2";
            this.passwordBoxR2.Size = new System.Drawing.Size(166, 22);
            this.passwordBoxR2.TabIndex = 9;
            this.passwordBoxR2.Tag = "p";
            this.passwordBoxR2.Text = "Password";
            this.passwordBoxR2.Enter += new System.EventHandler(this.tbFocus);
            this.passwordBoxR2.Leave += new System.EventHandler(this.tbLeave);
            // 
            // passwordBoxR1
            // 
            this.passwordBoxR1.BackColor = System.Drawing.Color.SpringGreen;
            this.passwordBoxR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBoxR1.Location = new System.Drawing.Point(450, 106);
            this.passwordBoxR1.Name = "passwordBoxR1";
            this.passwordBoxR1.Size = new System.Drawing.Size(166, 22);
            this.passwordBoxR1.TabIndex = 8;
            this.passwordBoxR1.Tag = "p";
            this.passwordBoxR1.Text = "Password";
            this.passwordBoxR1.Enter += new System.EventHandler(this.tbFocus);
            this.passwordBoxR1.Leave += new System.EventHandler(this.tbLeave);
            // 
            // usernameBoxR
            // 
            this.usernameBoxR.BackColor = System.Drawing.Color.SpringGreen;
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
            this.loginBtn.BackColor = System.Drawing.Color.SpringGreen;
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
            this.passwordBoxL.BackColor = System.Drawing.Color.SpringGreen;
            this.passwordBoxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBoxL.Location = new System.Drawing.Point(39, 106);
            this.passwordBoxL.Name = "passwordBoxL";
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
            this.userNameBoxL.BackColor = System.Drawing.Color.SpringGreen;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 543);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Sofu Blocker";
            this.metroTabControl1.ResumeLayout(false);
            this.blockTab.ResumeLayout(false);
            this.blockTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.passwordTab.ResumeLayout(false);
            this.passwordTab.PerformLayout();
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
    }
}

