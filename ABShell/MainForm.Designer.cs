﻿namespace ABShell
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnHead = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnStandart = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnContents = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button12 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cbUseDisp = new ABShell.CheckBox2();
            this.cbUseShell = new ABShell.CheckBox2();
            this.buttonApp2 = new ABShell.ButtonApp();
            this.buttonApp4 = new ABShell.ButtonApp();
            this.userButton2 = new ABShell.UserButton();
            this.userButton1 = new ABShell.UserButton();
            this.btnUseShell = new ABShell.ButtonRedLine();
            this.btnDisp = new ABShell.ButtonRedLine();
            this.userButton4 = new ABShell.UserButton();
            this.userButton3 = new ABShell.UserButton();
            this.buttonApp13 = new ABShell.ButtonApp();
            this.buttonApp14 = new ABShell.ButtonApp();
            this.buttonApp15 = new ABShell.ButtonApp();
            this.buttonApp16 = new ABShell.ButtonApp();
            this.buttonApp17 = new ABShell.ButtonApp();
            this.buttonApp8 = new ABShell.ButtonApp();
            this.buttonApp9 = new ABShell.ButtonApp();
            this.buttonApp10 = new ABShell.ButtonApp();
            this.buttonApp11 = new ABShell.ButtonApp();
            this.buttonApp12 = new ABShell.ButtonApp();
            this.pnHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnStandart.SuspendLayout();
            this.pnContents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHead
            // 
            this.pnHead.Controls.Add(this.label2);
            this.pnHead.Controls.Add(this.panel1);
            this.pnHead.Controls.Add(this.pictureBox1);
            this.pnHead.Controls.Add(this.pnStandart);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(754, 178);
            this.pnHead.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "v 1.0.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFont);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(236, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 112);
            this.panel1.TabIndex = 34;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(48, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(472, 112);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // pnStandart
            // 
            this.pnStandart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStandart.Controls.Add(this.buttonApp2);
            this.pnStandart.Controls.Add(this.button12);
            this.pnStandart.Controls.Add(this.buttonApp4);
            this.pnStandart.Controls.Add(this.btnSetting);
            this.pnStandart.Controls.Add(this.btnPowerOff);
            this.pnStandart.Controls.Add(this.btnRestart);
            this.pnStandart.Controls.Add(this.btnLogout);
            this.pnStandart.Location = new System.Drawing.Point(267, 114);
            this.pnStandart.Name = "pnStandart";
            this.pnStandart.Size = new System.Drawing.Size(487, 64);
            this.pnStandart.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(348, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 44);
            this.label6.TabIndex = 40;
            this.label6.Text = "Запретить диспечер задач";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.btDisp_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(414, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 44);
            this.label8.TabIndex = 43;
            this.label8.Text = "Заменить Windows Shell";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.btUseShell_Click);
            // 
            // pnContents
            // 
            this.pnContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContents.Controls.Add(this.userButton2);
            this.pnContents.Controls.Add(this.userButton1);
            this.pnContents.Controls.Add(this.button5);
            this.pnContents.Location = new System.Drawing.Point(0, 179);
            this.pnContents.Name = "pnContents";
            this.pnContents.Size = new System.Drawing.Size(754, 101);
            this.pnContents.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 460);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.userButton4);
            this.panel2.Controls.Add(this.userButton3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonApp8);
            this.panel2.Controls.Add(this.buttonApp9);
            this.panel2.Controls.Add(this.buttonApp10);
            this.panel2.Controls.Add(this.buttonApp11);
            this.panel2.Controls.Add(this.buttonApp12);
            this.panel2.Location = new System.Drawing.Point(0, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 213);
            this.panel2.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(540, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Блокировать диспечер задач";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(556, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Заменять Windows Shell";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.buttonApp13);
            this.panel3.Controls.Add(this.buttonApp14);
            this.panel3.Controls.Add(this.buttonApp15);
            this.panel3.Controls.Add(this.buttonApp16);
            this.panel3.Controls.Add(this.buttonApp17);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(128, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 75);
            this.panel3.TabIndex = 53;
            // 
            // btnFont
            // 
            this.btnFont.BackgroundImage = global::ABShell.Properties.Resources.fonts_4265;
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFont.Location = new System.Drawing.Point(6, 3);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(36, 31);
            this.btnFont.TabIndex = 48;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Visible = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABShell.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::ABShell.Properties.Resources.desktop2;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 64);
            this.button12.TabIndex = 46;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetting.Location = new System.Drawing.Point(210, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(64, 64);
            this.btnSetting.TabIndex = 29;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerOff.BackgroundImage")));
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            this.btnPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPowerOff.Location = new System.Drawing.Point(420, 0);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(64, 64);
            this.btnPowerOff.TabIndex = 28;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::ABShell.Properties.Resources.restart;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(350, 0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(64, 64);
            this.btnRestart.TabIndex = 27;
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.Location = new System.Drawing.Point(280, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 64);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(156, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 51);
            this.button5.TabIndex = 47;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(354, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 52);
            this.button6.TabIndex = 47;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cbUseDisp
            // 
            this.cbUseDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseDisp.Checked = false;
            this.cbUseDisp.Location = new System.Drawing.Point(607, 311);
            this.cbUseDisp.Name = "cbUseDisp";
            this.cbUseDisp.SetText = "";
            this.cbUseDisp.Size = new System.Drawing.Size(93, 37);
            this.cbUseDisp.TabIndex = 53;
            this.cbUseDisp.Click += new System.EventHandler(this.cbUseDisp_Click);
            // 
            // cbUseShell
            // 
            this.cbUseShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseShell.Checked = false;
            this.cbUseShell.Location = new System.Drawing.Point(607, 375);
            this.cbUseShell.Name = "cbUseShell";
            this.cbUseShell.SetText = null;
            this.cbUseShell.Size = new System.Drawing.Size(85, 37);
            this.cbUseShell.TabIndex = 52;
            this.cbUseShell.Click += new System.EventHandler(this.cbUseShell_Click);
            // 
            // buttonApp2
            // 
            this.buttonApp2.BackgroundImage = global::ABShell.Properties.Resources.TeamViewer02x128;
            this.buttonApp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp2.FlatAppearance.BorderSize = 0;
            this.buttonApp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp2.id = 1;
            this.buttonApp2.image = global::ABShell.Properties.Resources.TeamViewer02x128;
            this.buttonApp2.isVisible = true;
            this.buttonApp2.Location = new System.Drawing.Point(140, 0);
            this.buttonApp2.login = "";
            this.buttonApp2.Name = "buttonApp2";
            this.buttonApp2.password = "";
            this.buttonApp2.path = "C:\\TeamViewer 10.exe";
            this.buttonApp2.server = "";
            this.buttonApp2.Size = new System.Drawing.Size(64, 64);
            this.buttonApp2.TabIndex = 43;
            this.buttonApp2.UseVisualStyleBackColor = true;
            // 
            // buttonApp4
            // 
            this.buttonApp4.BackgroundImage = global::ABShell.Properties.Resources.print;
            this.buttonApp4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp4.FlatAppearance.BorderSize = 0;
            this.buttonApp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp4.id = 5;
            this.buttonApp4.image = global::ABShell.Properties.Resources.print;
            this.buttonApp4.isVisible = false;
            this.buttonApp4.Location = new System.Drawing.Point(70, 0);
            this.buttonApp4.login = "";
            this.buttonApp4.Name = "buttonApp4";
            this.buttonApp4.password = "";
            this.buttonApp4.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp4.server = "";
            this.buttonApp4.Size = new System.Drawing.Size(64, 64);
            this.buttonApp4.TabIndex = 50;
            this.buttonApp4.UseVisualStyleBackColor = true;
            // 
            // userButton2
            // 
            this.userButton2.id = -1;
            this.userButton2.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.userButton2.isVisible = false;
            this.userButton2.Location = new System.Drawing.Point(75, 0);
            this.userButton2.name = "Excel";
            this.userButton2.Name = "userButton2";
            this.userButton2.path = "";
            this.userButton2.SetText = "Excel";
            this.userButton2.Size = new System.Drawing.Size(75, 100);
            this.userButton2.TabIndex = 53;
            // 
            // userButton1
            // 
            this.userButton1.id = 0;
            this.userButton1.image = global::ABShell.Properties.Resources.aboffice;
            this.userButton1.isVisible = false;
            this.userButton1.Location = new System.Drawing.Point(0, 0);
            this.userButton1.name = "АБ ОФИС";
            this.userButton1.Name = "userButton1";
            this.userButton1.path = "";
            this.userButton1.SetText = "АБ ОФИС";
            this.userButton1.Size = new System.Drawing.Size(75, 100);
            this.userButton1.TabIndex = 52;
            // 
            // btnUseShell
            // 
            this.btnUseShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseShell.BackColor = System.Drawing.Color.Transparent;
            this.btnUseShell.BackgroundImage = global::ABShell.Properties.Resources.desktop;
            this.btnUseShell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseShell.Location = new System.Drawing.Point(420, 354);
            this.btnUseShell.Name = "btnUseShell";
            this.btnUseShell.Size = new System.Drawing.Size(60, 51);
            this.btnUseShell.TabIndex = 45;
            this.btnUseShell.Click += new System.EventHandler(this.btUseShell_Click);
            // 
            // btnDisp
            // 
            this.btnDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisp.BackColor = System.Drawing.Color.Transparent;
            this.btnDisp.BackgroundImage = global::ABShell.Properties.Resources.taskmgr_icon;
            this.btnDisp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisp.Location = new System.Drawing.Point(354, 355);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(60, 51);
            this.btnDisp.TabIndex = 46;
            this.btnDisp.Click += new System.EventHandler(this.btDisp_Click);
            // 
            // userButton4
            // 
            this.userButton4.id = -1;
            this.userButton4.image = global::ABShell.Properties.Resources.aboffice;
            this.userButton4.isVisible = false;
            this.userButton4.Location = new System.Drawing.Point(3, 3);
            this.userButton4.name = "АБ ОФИС";
            this.userButton4.Name = "userButton4";
            this.userButton4.path = "";
            this.userButton4.SetText = "АБ ОФИС";
            this.userButton4.Size = new System.Drawing.Size(75, 100);
            this.userButton4.TabIndex = 55;
            // 
            // userButton3
            // 
            this.userButton3.id = -1;
            this.userButton3.image = global::ABShell.Properties.Resources.aboffice;
            this.userButton3.isVisible = false;
            this.userButton3.Location = new System.Drawing.Point(3, 109);
            this.userButton3.name = "АБ ОФИС";
            this.userButton3.Name = "userButton3";
            this.userButton3.path = "";
            this.userButton3.SetText = "АБ ОФИС";
            this.userButton3.Size = new System.Drawing.Size(75, 100);
            this.userButton3.TabIndex = 54;
            // 
            // buttonApp13
            // 
            this.buttonApp13.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp13.FlatAppearance.BorderSize = 0;
            this.buttonApp13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp13.id = 4;
            this.buttonApp13.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp13.isVisible = false;
            this.buttonApp13.Location = new System.Drawing.Point(284, 3);
            this.buttonApp13.login = "";
            this.buttonApp13.Name = "buttonApp13";
            this.buttonApp13.password = "";
            this.buttonApp13.path = "C:\\TeamViewer 10.exe";
            this.buttonApp13.server = "";
            this.buttonApp13.Size = new System.Drawing.Size(64, 64);
            this.buttonApp13.TabIndex = 51;
            this.buttonApp13.UseVisualStyleBackColor = true;
            // 
            // buttonApp14
            // 
            this.buttonApp14.BackgroundImage = global::ABShell.Properties.Resources.Chrome;
            this.buttonApp14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp14.FlatAppearance.BorderSize = 0;
            this.buttonApp14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp14.id = 2;
            this.buttonApp14.image = global::ABShell.Properties.Resources.Chrome;
            this.buttonApp14.isVisible = true;
            this.buttonApp14.Location = new System.Drawing.Point(214, 3);
            this.buttonApp14.login = "";
            this.buttonApp14.Name = "buttonApp14";
            this.buttonApp14.password = "";
            this.buttonApp14.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp14.server = "";
            this.buttonApp14.Size = new System.Drawing.Size(64, 64);
            this.buttonApp14.TabIndex = 44;
            this.buttonApp14.UseVisualStyleBackColor = true;
            // 
            // buttonApp15
            // 
            this.buttonApp15.BackgroundImage = global::ABShell.Properties.Resources.aboffice;
            this.buttonApp15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp15.FlatAppearance.BorderSize = 0;
            this.buttonApp15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp15.id = 0;
            this.buttonApp15.image = global::ABShell.Properties.Resources.aboffice;
            this.buttonApp15.isVisible = true;
            this.buttonApp15.Location = new System.Drawing.Point(4, 3);
            this.buttonApp15.login = "";
            this.buttonApp15.Name = "buttonApp15";
            this.buttonApp15.password = "";
            this.buttonApp15.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp15.server = "";
            this.buttonApp15.Size = new System.Drawing.Size(64, 64);
            this.buttonApp15.TabIndex = 42;
            this.buttonApp15.UseVisualStyleBackColor = true;
            // 
            // buttonApp16
            // 
            this.buttonApp16.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007word_5551;
            this.buttonApp16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp16.FlatAppearance.BorderSize = 0;
            this.buttonApp16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp16.id = 3;
            this.buttonApp16.image = global::ABShell.Properties.Resources.microsoftoffice2007word_5551;
            this.buttonApp16.isVisible = false;
            this.buttonApp16.Location = new System.Drawing.Point(144, 3);
            this.buttonApp16.login = "";
            this.buttonApp16.Name = "buttonApp16";
            this.buttonApp16.password = "";
            this.buttonApp16.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp16.server = "";
            this.buttonApp16.Size = new System.Drawing.Size(64, 64);
            this.buttonApp16.TabIndex = 48;
            this.buttonApp16.UseVisualStyleBackColor = true;
            // 
            // buttonApp17
            // 
            this.buttonApp17.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp17.FlatAppearance.BorderSize = 0;
            this.buttonApp17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp17.id = 4;
            this.buttonApp17.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp17.isVisible = false;
            this.buttonApp17.Location = new System.Drawing.Point(74, 3);
            this.buttonApp17.login = "";
            this.buttonApp17.Name = "buttonApp17";
            this.buttonApp17.password = "";
            this.buttonApp17.path = "C:\\TeamViewer 10.exe";
            this.buttonApp17.server = "";
            this.buttonApp17.Size = new System.Drawing.Size(64, 64);
            this.buttonApp17.TabIndex = 49;
            this.buttonApp17.UseVisualStyleBackColor = true;
            // 
            // buttonApp8
            // 
            this.buttonApp8.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp8.FlatAppearance.BorderSize = 0;
            this.buttonApp8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp8.id = 4;
            this.buttonApp8.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp8.isVisible = false;
            this.buttonApp8.Location = new System.Drawing.Point(284, 3);
            this.buttonApp8.login = "";
            this.buttonApp8.Name = "buttonApp8";
            this.buttonApp8.password = "";
            this.buttonApp8.path = "C:\\TeamViewer 10.exe";
            this.buttonApp8.server = "";
            this.buttonApp8.Size = new System.Drawing.Size(64, 64);
            this.buttonApp8.TabIndex = 51;
            this.buttonApp8.UseVisualStyleBackColor = true;
            // 
            // buttonApp9
            // 
            this.buttonApp9.BackgroundImage = global::ABShell.Properties.Resources.Chrome;
            this.buttonApp9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp9.FlatAppearance.BorderSize = 0;
            this.buttonApp9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp9.id = 2;
            this.buttonApp9.image = global::ABShell.Properties.Resources.Chrome;
            this.buttonApp9.isVisible = true;
            this.buttonApp9.Location = new System.Drawing.Point(214, 3);
            this.buttonApp9.login = "";
            this.buttonApp9.Name = "buttonApp9";
            this.buttonApp9.password = "";
            this.buttonApp9.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp9.server = "";
            this.buttonApp9.Size = new System.Drawing.Size(64, 64);
            this.buttonApp9.TabIndex = 44;
            this.buttonApp9.UseVisualStyleBackColor = true;
            // 
            // buttonApp10
            // 
            this.buttonApp10.BackgroundImage = global::ABShell.Properties.Resources.aboffice;
            this.buttonApp10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp10.FlatAppearance.BorderSize = 0;
            this.buttonApp10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp10.id = 0;
            this.buttonApp10.image = global::ABShell.Properties.Resources.aboffice;
            this.buttonApp10.isVisible = true;
            this.buttonApp10.Location = new System.Drawing.Point(4, 3);
            this.buttonApp10.login = "";
            this.buttonApp10.Name = "buttonApp10";
            this.buttonApp10.password = "";
            this.buttonApp10.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp10.server = "";
            this.buttonApp10.Size = new System.Drawing.Size(64, 64);
            this.buttonApp10.TabIndex = 42;
            this.buttonApp10.UseVisualStyleBackColor = true;
            // 
            // buttonApp11
            // 
            this.buttonApp11.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007word_5551;
            this.buttonApp11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp11.FlatAppearance.BorderSize = 0;
            this.buttonApp11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp11.id = 3;
            this.buttonApp11.image = global::ABShell.Properties.Resources.microsoftoffice2007word_5551;
            this.buttonApp11.isVisible = false;
            this.buttonApp11.Location = new System.Drawing.Point(144, 3);
            this.buttonApp11.login = "";
            this.buttonApp11.Name = "buttonApp11";
            this.buttonApp11.password = "";
            this.buttonApp11.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp11.server = "";
            this.buttonApp11.Size = new System.Drawing.Size(64, 64);
            this.buttonApp11.TabIndex = 48;
            this.buttonApp11.UseVisualStyleBackColor = true;
            // 
            // buttonApp12
            // 
            this.buttonApp12.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp12.FlatAppearance.BorderSize = 0;
            this.buttonApp12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp12.id = 4;
            this.buttonApp12.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp12.isVisible = false;
            this.buttonApp12.Location = new System.Drawing.Point(74, 3);
            this.buttonApp12.login = "";
            this.buttonApp12.Name = "buttonApp12";
            this.buttonApp12.password = "";
            this.buttonApp12.path = "C:\\TeamViewer 10.exe";
            this.buttonApp12.server = "";
            this.buttonApp12.Size = new System.Drawing.Size(64, 64);
            this.buttonApp12.TabIndex = 49;
            this.buttonApp12.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(188)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(754, 491);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUseDisp);
            this.Controls.Add(this.cbUseShell);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pnContents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUseShell);
            this.Controls.Add(this.btnDisp);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 130);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHead.ResumeLayout(false);
            this.pnHead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnStandart.ResumeLayout(false);
            this.pnContents.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnContents;
        private ButtonRedLine btnUseShell;
        private ButtonRedLine btnDisp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnStandart;
        private ButtonApp buttonApp2;
        private System.Windows.Forms.Button button12;
        private ButtonApp buttonApp4;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private ButtonApp buttonApp8;
        private ButtonApp buttonApp9;
        private ButtonApp buttonApp10;
        private ButtonApp buttonApp11;
        private ButtonApp buttonApp12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CheckBox2 cbUseDisp;
        private CheckBox2 cbUseShell;
        private UserButton userButton1;
        private System.Windows.Forms.Panel panel3;
        private ButtonApp buttonApp13;
        private ButtonApp buttonApp14;
        private ButtonApp buttonApp15;
        private ButtonApp buttonApp16;
        private ButtonApp buttonApp17;
        private System.Windows.Forms.Button button6;
        private UserButton userButton2;
        private UserButton userButton4;
        private UserButton userButton3;
    }
}

