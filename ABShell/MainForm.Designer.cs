namespace ABShell
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
            this.btnFont = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnStandart = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnContents = new System.Windows.Forms.Panel();
            this.addBut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUseDisp = new ABShell.CheckBox2();
            this.cbUseShell = new ABShell.CheckBox2();
            this.buttonApp8 = new ABShell.ButtonApp();
            this.buttonApp9 = new ABShell.ButtonApp();
            this.buttonApp10 = new ABShell.ButtonApp();
            this.buttonApp11 = new ABShell.ButtonApp();
            this.buttonApp12 = new ABShell.ButtonApp();
            this.buttonApp2 = new ABShell.ButtonApp();
            this.buttonApp4 = new ABShell.ButtonApp();
            this.buttonApp7 = new ABShell.ButtonApp();
            this.buttonApp3 = new ABShell.ButtonApp();
            this.buttonApp1 = new ABShell.ButtonApp();
            this.buttonApp6 = new ABShell.ButtonApp();
            this.buttonApp5 = new ABShell.ButtonApp();
            this.btnUseShell = new ABShell.ButtonRedLine();
            this.btnDisp = new ABShell.ButtonRedLine();
            this.pnHead.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnStandart.SuspendLayout();
            this.pnContents.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnHead.Size = new System.Drawing.Size(756, 183);
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
            this.panel1.Size = new System.Drawing.Size(626, 112);
            this.panel1.TabIndex = 34;
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(52, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(574, 112);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
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
            this.pnStandart.Location = new System.Drawing.Point(265, 114);
            this.pnStandart.Name = "pnStandart";
            this.pnStandart.Size = new System.Drawing.Size(491, 64);
            this.pnStandart.TabIndex = 32;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::ABShell.Properties.Resources.desktop2;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(3, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 64);
            this.button12.TabIndex = 46;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetting.Location = new System.Drawing.Point(213, 0);
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
            this.btnPowerOff.Location = new System.Drawing.Point(423, 0);
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
            this.btnRestart.Location = new System.Drawing.Point(353, 0);
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
            this.btnLogout.Location = new System.Drawing.Point(283, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 64);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(350, 400);
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
            this.label8.Location = new System.Drawing.Point(416, 400);
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
            this.pnContents.Controls.Add(this.buttonApp7);
            this.pnContents.Controls.Add(this.buttonApp3);
            this.pnContents.Controls.Add(this.buttonApp1);
            this.pnContents.Controls.Add(this.buttonApp6);
            this.pnContents.Controls.Add(this.buttonApp5);
            this.pnContents.Controls.Add(this.addBut);
            this.pnContents.Location = new System.Drawing.Point(0, 182);
            this.pnContents.Name = "pnContents";
            this.pnContents.Size = new System.Drawing.Size(756, 75);
            this.pnContents.TabIndex = 44;
            // 
            // addBut
            // 
            this.addBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBut.BackgroundImage")));
            this.addBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBut.FlatAppearance.BorderSize = 0;
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(354, 10);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(52, 52);
            this.addBut.TabIndex = 47;
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonApp8);
            this.panel2.Controls.Add(this.buttonApp9);
            this.panel2.Controls.Add(this.buttonApp10);
            this.panel2.Controls.Add(this.buttonApp11);
            this.panel2.Controls.Add(this.buttonApp12);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 75);
            this.panel2.TabIndex = 51;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(354, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 52);
            this.button5.TabIndex = 47;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(542, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Блокировать диспечер задач";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(558, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Заменять Windows Shell";
            // 
            // cbUseDisp
            // 
            this.cbUseDisp.Checked = false;
            this.cbUseDisp.Location = new System.Drawing.Point(600, 344);
            this.cbUseDisp.Name = "cbUseDisp";
            this.cbUseDisp.SetText = "";
            this.cbUseDisp.Size = new System.Drawing.Size(93, 37);
            this.cbUseDisp.TabIndex = 53;
            // 
            // cbUseShell
            // 
            this.cbUseShell.Checked = false;
            this.cbUseShell.Location = new System.Drawing.Point(600, 279);
            this.cbUseShell.Name = "cbUseShell";
            this.cbUseShell.SetText = null;
            this.cbUseShell.Size = new System.Drawing.Size(85, 37);
            this.cbUseShell.TabIndex = 52;
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
            // buttonApp2
            // 
            this.buttonApp2.BackgroundImage = global::ABShell.Properties.Resources.TeamViewer02x128;
            this.buttonApp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp2.FlatAppearance.BorderSize = 0;
            this.buttonApp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp2.id = 1;
            this.buttonApp2.image = global::ABShell.Properties.Resources.TeamViewer02x128;
            this.buttonApp2.isVisible = true;
            this.buttonApp2.Location = new System.Drawing.Point(73, 0);
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
            this.buttonApp4.Location = new System.Drawing.Point(143, 0);
            this.buttonApp4.login = "";
            this.buttonApp4.Name = "buttonApp4";
            this.buttonApp4.password = "";
            this.buttonApp4.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp4.server = "";
            this.buttonApp4.Size = new System.Drawing.Size(64, 64);
            this.buttonApp4.TabIndex = 50;
            this.buttonApp4.UseVisualStyleBackColor = true;
            // 
            // buttonApp7
            // 
            this.buttonApp7.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp7.FlatAppearance.BorderSize = 0;
            this.buttonApp7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp7.id = 4;
            this.buttonApp7.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp7.isVisible = false;
            this.buttonApp7.Location = new System.Drawing.Point(284, 3);
            this.buttonApp7.login = "";
            this.buttonApp7.Name = "buttonApp7";
            this.buttonApp7.password = "";
            this.buttonApp7.path = "C:\\TeamViewer 10.exe";
            this.buttonApp7.server = "";
            this.buttonApp7.Size = new System.Drawing.Size(64, 64);
            this.buttonApp7.TabIndex = 51;
            this.buttonApp7.UseVisualStyleBackColor = true;
            this.buttonApp7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp_MouseDown);
            this.buttonApp7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonApp_MouseMove);
            this.buttonApp7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonApp_MouseUp);
            // 
            // buttonApp3
            // 
            this.buttonApp3.BackgroundImage = global::ABShell.Properties.Resources.Chrome;
            this.buttonApp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp3.FlatAppearance.BorderSize = 0;
            this.buttonApp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp3.id = 2;
            this.buttonApp3.image = global::ABShell.Properties.Resources.Chrome;
            this.buttonApp3.isVisible = true;
            this.buttonApp3.Location = new System.Drawing.Point(214, 3);
            this.buttonApp3.login = "";
            this.buttonApp3.Name = "buttonApp3";
            this.buttonApp3.password = "";
            this.buttonApp3.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp3.server = "";
            this.buttonApp3.Size = new System.Drawing.Size(64, 64);
            this.buttonApp3.TabIndex = 44;
            this.buttonApp3.UseVisualStyleBackColor = true;
            this.buttonApp3.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
            // 
            // buttonApp1
            // 
            this.buttonApp1.BackgroundImage = global::ABShell.Properties.Resources.aboffice;
            this.buttonApp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp1.FlatAppearance.BorderSize = 0;
            this.buttonApp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp1.id = 0;
            this.buttonApp1.image = global::ABShell.Properties.Resources.aboffice;
            this.buttonApp1.isVisible = true;
            this.buttonApp1.Location = new System.Drawing.Point(4, 3);
            this.buttonApp1.login = "";
            this.buttonApp1.Name = "buttonApp1";
            this.buttonApp1.password = "";
            this.buttonApp1.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp1.server = "";
            this.buttonApp1.Size = new System.Drawing.Size(64, 64);
            this.buttonApp1.TabIndex = 42;
            this.buttonApp1.UseVisualStyleBackColor = true;
            this.buttonApp1.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
            // 
            // buttonApp6
            // 
            this.buttonApp6.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007word_5551;
            this.buttonApp6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp6.FlatAppearance.BorderSize = 0;
            this.buttonApp6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp6.id = 3;
            this.buttonApp6.image = global::ABShell.Properties.Resources.microsoftoffice2007word_5551;
            this.buttonApp6.isVisible = false;
            this.buttonApp6.Location = new System.Drawing.Point(144, 3);
            this.buttonApp6.login = "";
            this.buttonApp6.Name = "buttonApp6";
            this.buttonApp6.password = "";
            this.buttonApp6.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp6.server = "";
            this.buttonApp6.Size = new System.Drawing.Size(64, 64);
            this.buttonApp6.TabIndex = 48;
            this.buttonApp6.UseVisualStyleBackColor = true;
            this.buttonApp6.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
            // 
            // buttonApp5
            // 
            this.buttonApp5.BackgroundImage = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApp5.FlatAppearance.BorderSize = 0;
            this.buttonApp5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp5.id = 4;
            this.buttonApp5.image = global::ABShell.Properties.Resources.microsoftoffice2007excel_8537;
            this.buttonApp5.isVisible = false;
            this.buttonApp5.Location = new System.Drawing.Point(74, 3);
            this.buttonApp5.login = "";
            this.buttonApp5.Name = "buttonApp5";
            this.buttonApp5.password = "";
            this.buttonApp5.path = "C:\\TeamViewer 10.exe";
            this.buttonApp5.server = "";
            this.buttonApp5.Size = new System.Drawing.Size(64, 64);
            this.buttonApp5.TabIndex = 49;
            this.buttonApp5.UseVisualStyleBackColor = true;
            this.buttonApp5.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
            // 
            // btnUseShell
            // 
            this.btnUseShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseShell.BackColor = System.Drawing.Color.Transparent;
            this.btnUseShell.BackgroundImage = global::ABShell.Properties.Resources.desktop;
            this.btnUseShell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseShell.Location = new System.Drawing.Point(422, 354);
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
            this.btnDisp.Location = new System.Drawing.Point(356, 355);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(60, 51);
            this.btnDisp.TabIndex = 46;
            this.btnDisp.Click += new System.EventHandler(this.btDisp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 459);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUseDisp);
            this.Controls.Add(this.cbUseShell);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnContents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUseShell);
            this.Controls.Add(this.btnDisp);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnStandart.ResumeLayout(false);
            this.pnContents.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnContents;
        private ButtonRedLine btnUseShell;
        private ButtonRedLine btnDisp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ButtonApp buttonApp3;
        private ButtonApp buttonApp1;
        private ButtonApp buttonApp5;
        private ButtonApp buttonApp6;
        private System.Windows.Forms.Button button4;
        private ButtonApp buttonApp7;
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
    }
}

