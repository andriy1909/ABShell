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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.pnPower = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnContents = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonApp7 = new ABShell.ButtonApp();
            this.buttonApp4 = new ABShell.ButtonApp();
            this.buttonApp5 = new ABShell.ButtonApp();
            this.buttonApp6 = new ABShell.ButtonApp();
            this.buttonApp3 = new ABShell.ButtonApp();
            this.buttonApp2 = new ABShell.ButtonApp();
            this.buttonApp1 = new ABShell.ButtonApp();
            this.btnUseShell = new ABShell.ButtonRedLine();
            this.btnDisp = new ABShell.ButtonRedLine();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnButtons.SuspendLayout();
            this.pnPower.SuspendLayout();
            this.pnHead.SuspendLayout();
            this.pnContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(520, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(242, 181);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 228.496F;
            this.Column1.HeaderText = "Користувач";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.pnPower);
            this.pnButtons.Controls.Add(this.pnHead);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButtons.Location = new System.Drawing.Point(0, 0);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(832, 85);
            this.pnButtons.TabIndex = 11;
            // 
            // pnPower
            // 
            this.pnPower.Controls.Add(this.btnSetting);
            this.pnPower.Controls.Add(this.btnPowerOff);
            this.pnPower.Controls.Add(this.btnRestart);
            this.pnPower.Controls.Add(this.btnLogout);
            this.pnPower.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPower.Location = new System.Drawing.Point(514, 0);
            this.pnPower.Name = "pnPower";
            this.pnPower.Size = new System.Drawing.Size(318, 85);
            this.pnPower.TabIndex = 31;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetting.Location = new System.Drawing.Point(5, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 75);
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
            this.btnPowerOff.Location = new System.Drawing.Point(236, 5);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(75, 75);
            this.btnPowerOff.TabIndex = 28;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::ABShell.Properties.Resources.restart;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(158, 5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 75);
            this.btnRestart.TabIndex = 27;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.Location = new System.Drawing.Point(80, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 75);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnHead
            // 
            this.pnHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHead.Controls.Add(this.buttonApp3);
            this.pnHead.Controls.Add(this.buttonApp2);
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(515, 85);
            this.pnHead.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(591, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Пользователи";
            this.label1.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(766, 146);
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
            this.label8.Location = new System.Drawing.Point(766, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 44);
            this.label8.TabIndex = 43;
            this.label8.Text = "Заменить Windows Shell";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.btUseShell_Click);
            // 
            // pnContents
            // 
            this.pnContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContents.Controls.Add(this.buttonApp7);
            this.pnContents.Controls.Add(this.buttonApp4);
            this.pnContents.Controls.Add(this.buttonApp5);
            this.pnContents.Controls.Add(this.buttonApp6);
            this.pnContents.Location = new System.Drawing.Point(0, 91);
            this.pnContents.Name = "pnContents";
            this.pnContents.Size = new System.Drawing.Size(515, 202);
            this.pnContents.TabIndex = 44;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::ABShell.Properties.Resources.desktop2;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(536, 213);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 75);
            this.button12.TabIndex = 46;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button6_MouseClick);
            // 
            // addBut
            // 
            this.addBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBut.BackgroundImage")));
            this.addBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBut.FlatAppearance.BorderSize = 0;
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(617, 224);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(52, 52);
            this.addBut.TabIndex = 47;
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Visible = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.buttonApp7.Location = new System.Drawing.Point(395, 56);
            this.buttonApp7.login = "";
            this.buttonApp7.Name = "buttonApp7";
            this.buttonApp7.password = "";
            this.buttonApp7.path = "C:\\TeamViewer 10.exe";
            this.buttonApp7.server = "";
            this.buttonApp7.Size = new System.Drawing.Size(75, 75);
            this.buttonApp7.TabIndex = 51;
            this.buttonApp7.UseVisualStyleBackColor = true;
            this.buttonApp7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp_MouseDown);
            this.buttonApp7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonApp_MouseMove);
            this.buttonApp7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonApp_MouseUp);
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
            this.buttonApp4.Location = new System.Drawing.Point(154, 3);
            this.buttonApp4.login = "";
            this.buttonApp4.Name = "buttonApp4";
            this.buttonApp4.password = "";
            this.buttonApp4.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp4.server = "";
            this.buttonApp4.Size = new System.Drawing.Size(75, 75);
            this.buttonApp4.TabIndex = 50;
            this.buttonApp4.UseVisualStyleBackColor = true;
            this.buttonApp4.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
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
            this.buttonApp5.Location = new System.Drawing.Point(79, 3);
            this.buttonApp5.login = "";
            this.buttonApp5.Name = "buttonApp5";
            this.buttonApp5.password = "";
            this.buttonApp5.path = "C:\\TeamViewer 10.exe";
            this.buttonApp5.server = "";
            this.buttonApp5.Size = new System.Drawing.Size(75, 75);
            this.buttonApp5.TabIndex = 49;
            this.buttonApp5.UseVisualStyleBackColor = true;
            this.buttonApp5.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
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
            this.buttonApp6.Location = new System.Drawing.Point(4, 3);
            this.buttonApp6.login = "";
            this.buttonApp6.Name = "buttonApp6";
            this.buttonApp6.password = "";
            this.buttonApp6.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp6.server = "";
            this.buttonApp6.Size = new System.Drawing.Size(75, 75);
            this.buttonApp6.TabIndex = 48;
            this.buttonApp6.UseVisualStyleBackColor = true;
            this.buttonApp6.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
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
            this.buttonApp3.Location = new System.Drawing.Point(155, 5);
            this.buttonApp3.login = "";
            this.buttonApp3.Name = "buttonApp3";
            this.buttonApp3.password = "";
            this.buttonApp3.path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            this.buttonApp3.server = "";
            this.buttonApp3.Size = new System.Drawing.Size(75, 75);
            this.buttonApp3.TabIndex = 44;
            this.buttonApp3.UseVisualStyleBackColor = true;
            this.buttonApp3.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
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
            this.buttonApp2.Location = new System.Drawing.Point(80, 5);
            this.buttonApp2.login = "";
            this.buttonApp2.Name = "buttonApp2";
            this.buttonApp2.password = "";
            this.buttonApp2.path = "C:\\TeamViewer 10.exe";
            this.buttonApp2.server = "";
            this.buttonApp2.Size = new System.Drawing.Size(75, 75);
            this.buttonApp2.TabIndex = 43;
            this.buttonApp2.UseVisualStyleBackColor = true;
            this.buttonApp2.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
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
            this.buttonApp1.Location = new System.Drawing.Point(691, 108);
            this.buttonApp1.login = "";
            this.buttonApp1.Name = "buttonApp1";
            this.buttonApp1.password = "";
            this.buttonApp1.path = "D:\\office4\\client\\O4Client.exe";
            this.buttonApp1.server = "";
            this.buttonApp1.Size = new System.Drawing.Size(75, 75);
            this.buttonApp1.TabIndex = 42;
            this.buttonApp1.UseVisualStyleBackColor = true;
            this.buttonApp1.Click += new System.EventHandler(this.buttonApp_Click);
            this.buttonApp1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonApp4_MouseDown);
            // 
            // btnUseShell
            // 
            this.btnUseShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseShell.BackColor = System.Drawing.Color.Transparent;
            this.btnUseShell.BackgroundImage = global::ABShell.Properties.Resources.desktop;
            this.btnUseShell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseShell.Location = new System.Drawing.Point(772, 190);
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
            this.btnDisp.Location = new System.Drawing.Point(772, 101);
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
            this.ClientSize = new System.Drawing.Size(832, 294);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonApp1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.pnContents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUseShell);
            this.Controls.Add(this.btnDisp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 130);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompLife";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnButtons.ResumeLayout(false);
            this.pnPower.ResumeLayout(false);
            this.pnHead.ResumeLayout(false);
            this.pnContents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPower;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private ButtonRedLine btnUseShell;
        private ButtonRedLine btnDisp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ButtonApp buttonApp3;
        private ButtonApp buttonApp2;
        private ButtonApp buttonApp1;
        private ButtonApp buttonApp4;
        private ButtonApp buttonApp5;
        private ButtonApp buttonApp6;
        private System.Windows.Forms.Button button4;
        private ButtonApp buttonApp7;
    }
}

